﻿Imports System.Data.SQLite
Imports System.IO
Imports System.Linq.Expressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class ReadSQL

    Function ReadDirector_Single(id As Integer)
        Dim resultado As Persona
        Try
            Dim conexion As SQLiteConnection = New SQLiteConnection(My.Settings.conexion_db)
            Dim consulta As String = String.Format("SELECT ID, NOMBRE FROM DIRECTORES WHERE ID = @id”)
            conexion.Open()
            Dim cmd As New SQLiteCommand(consulta, conexion)
            cmd.Parameters.Add("@id", DbType.Int64).Value = id
            Dim lector As SQLiteDataReader = cmd.ExecuteReader()
            While lector.Read()
                resultado = New Persona(id:=lector.GetInt16(0), nombre:=lector.GetString(1))
            End While
            lector.Close()
            conexion.Close()
            Return resultado
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function

    Function ReadDirector_All()
        Dim resultado As New List(Of Persona)
        Try
            Dim conexion As SQLiteConnection = New SQLiteConnection(My.Settings.conexion_db)
            Dim consulta As String = String.Format("SELECT ID, NOMBRE FROM DIRECTORES”)
            conexion.Open()
            Dim cmd As New SQLiteCommand(consulta, conexion)
            Dim lector As SQLiteDataReader = cmd.ExecuteReader()
            While lector.Read()
                Dim current = New Persona(id:=lector.GetInt16(0), nombre:=lector.GetString(1))
                resultado.Add(current)
            End While
            lector.Close()
            conexion.Close()
            Return resultado
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function


    Function ReadActor_Single(id As Integer)
        Dim resultado As Persona
        Try
            Dim conexion As SQLiteConnection = New SQLiteConnection(My.Settings.conexion_db)
            Dim consulta As String = String.Format("SELECT ID, NOMBRE FROM ACTORES WHERE ID = @id”)
            conexion.Open()
            Dim cmd As New SQLiteCommand(consulta, conexion)
            cmd.Parameters.Add("@id", DbType.Int64).Value = id
            Dim lector As SQLiteDataReader = cmd.ExecuteReader()
            While lector.Read()
                resultado = New Persona(id:=lector.GetInt16(0), nombre:=lector.GetString(1))
            End While
            lector.Close()
            conexion.Close()
            Return resultado
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function

    Function ReadActor_All()
        Dim resultado As New List(Of Persona)
        Try
            Dim conexion As SQLiteConnection = New SQLiteConnection(My.Settings.conexion_db)
            Dim consulta As String = String.Format("SELECT ID, NOMBRE FROM ACTORES”)
            conexion.Open()
            Dim cmd As New SQLiteCommand(consulta, conexion)
            Dim lector As SQLiteDataReader = cmd.ExecuteReader()
            While lector.Read()
                Dim current = New Persona(id:=lector.GetInt16(0), nombre:=lector.GetString(1))
                resultado.Add(current)
            End While
            lector.Close()
            conexion.Close()
            Return resultado
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function



    Function ReadPelicula_Single(id As Integer)
        Dim resultado As Pelicula
        Try
            Dim conexion As SQLiteConnection = New SQLiteConnection(My.Settings.conexion_db)
            Dim consulta As String = String.Format("SELECT * FROM PELICULAS WHERE ID = @id”)
            conexion.Open()
            Dim cmd As New SQLiteCommand(consulta, conexion)
            cmd.Parameters.Add("@id", DbType.Int64).Value = id
            Dim lector As SQLiteDataReader = cmd.ExecuteReader()
            Dim image_Ar As Byte()
            While lector.Read()
                Dim poster_Image
                image_Ar = DirectCast(lector("poster"), Byte())
                If image_Ar IsNot Nothing AndAlso image_Ar.Length > 0 Then
                    Using stream As New MemoryStream(image_Ar)
                        Dim poster As Image = Image.FromStream(stream)
                        poster_Image = poster
                    End Using
                End If
                If poster_Image IsNot Nothing Then
                    resultado = New Pelicula(id:=lector.GetInt64(0), nombre:=lector.GetString(7), director:=ReadDirector_Single(lector.GetInt64(1)),
                                              duracion:=lector.GetInt64(2), productora:=lector.GetString(3), genero:=lector.GetString(4), sinopsis:=lector.GetString(5), poster:=poster_Image)
                ElseIf poster_Image Is Nothing Then
                    resultado = New Pelicula(id:=lector.GetInt64(0), nombre:=lector.GetString(7), director:=ReadDirector_Single(lector.GetInt64(1)),
                                              duracion:=lector.GetInt64(2), productora:=lector.GetString(3), genero:=lector.GetString(4), sinopsis:=lector.GetString(5))

                End If
                'Select Case lector.GetBlob(6)
                '    Case Nothing
                '        resultado = New Pelicula(id:=lector.GetInt64(0), nombre:=lector.GetString(7), director:=ReadDirector_Single(lector.GetInt64(1)),
                '                              duracion:=lector.GetInt64(2), productora:=lector.GetString(3), genero:=lector.GetString(4), sinopsis:=lector.GetString(5))
                '    Case Is <> Nothing
                '        resultado = New Pelicula(id:=lector.GetInt64(0), nombre:=lector.GetString(7), director:=ReadDirector_Single(lector.GetInt64(1)),
                '                                                  duracion:=lector.GetInt64(2), productora:=lector.GetString(3), genero:=lector.GetString(4), sinopsis:=lector.GetString(5))
                'End Select

                'resultado = New Pelicula(id:=lector.GetInt64(0), nombre:=lector.GetString(7), director:=ReadDirector_Single(lector.GetInt64(1)),
                'duracion:=lector.GetInt64(2), productora:=lector.GetString(3), genero:=lector.GetString(4), sinopsis:=lector.GetString(5))

            End While
            lector.Close()
            conexion.Close()
            Return resultado
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function

    Public Function ReadPelicula()
        Dim resultado As List(Of Pelicula)
        Try
            Dim conexion As SQLiteConnection = New SQLiteConnection(My.Settings.conexion_db)
            Dim consulta As String = String.Format("SELECT * FROM PELICULAS”)
            conexion.Open()
            Dim cmd As New SQLiteCommand(consulta, conexion)
            Dim lector As SQLiteDataReader = cmd.ExecuteReader()
            While lector.Read()
                If resultado Is Nothing Then
                    resultado = New List(Of Pelicula)
                    'Dim current = New Pelicula(id:=lector.GetInt64(0), nombre:=lector.GetString(7), director:=ReadDirector_Single(lector.GetInt64(1)), duracion:=lector.GetInt64(2)
                    '   , productora:=lector.GetString(3), genero:=Controller.genero_Enum.genero.DRAMA, sinopsis:=lector.GetString(5))
                    Dim current = New Pelicula(id:=lector.GetInt64(0), nombre:=lector.GetString(7), director:=ReadDirector_Single(lector.GetInt64(1)),
                                               duracion:=lector.GetInt64(2), productora:=lector.GetString(3), genero:=lector.GetString(4), sinopsis:=lector.GetString(5))
                    resultado.Add(current)
                Else
                    Dim current = New Pelicula(id:=lector.GetInt64(0), nombre:=lector.GetString(7), director:=ReadDirector_Single(lector.GetInt64(1)),
                                              duracion:=lector.GetInt64(2), productora:=lector.GetString(3), genero:=lector.GetString(4), sinopsis:=lector.GetString(5))
                    resultado.Add(current)
                End If

                'resultado = New Pelicula(id:=lector.GetInt64(0), nombre:=)
            End While
            lector.Close()
            conexion.Close()
            Return resultado
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function

    Function ReadingRolesDataSet(id As Integer)
        Dim con As New SQLiteConnection(My.Settings.conexion_db)
        Dim consulta As String = "SELECT D.NOMBRE AS ""Actor"", A.NOMBRE AS ""Personaje"" FROM PERSONAJES A JOIN ACTORES D ON(D.id = A.actor)  WHERE A.pelicula = @id"
        Try
            con.Open()
            Dim cmd As New SQLiteCommand(consulta, con)
            cmd.Parameters.Add("@id", DbType.Int64).Value = id
            Dim da As New SQLiteDataAdapter(cmd)
            Dim ds As New DataSet()
            ds.Tables.Add("tabla")
            da.Fill(ds.Tables("tabla"))
            con.Close()
            Return ds.Tables("tabla")
        Catch ex As Exception
            MsgBox("Problemas con la BBDD")
        End Try
    End Function


    Function ReadingDirectorsDataSource()
        Dim con As New SQLiteConnection(My.Settings.conexion_db)
        Dim consulta As String = "SELECT ID, NOMBRE FROM DIRECTORES"
        Try
            con.Open()
            Dim cmd As New SQLiteCommand(consulta, con)
            Dim da As New SQLiteDataAdapter(cmd)
            Dim ds As New DataSet()
            ds.Tables.Add("tabla")
            da.Fill(ds.Tables("tabla"))

            'ComboBox1.DataSource = ds.Tables("tabla")
            'ComboBox1.DisplayMember = "titulo"
            'ComboBox1.ValueMember = "id"
            con.Close()
            Return ds.Tables("Tabla")
        Catch ex As Exception
            MsgBox("Problemas con la BBDD")
        End Try
    End Function

    Private Function BinaryData_To_Image(data As Image)

    End Function
End Class
