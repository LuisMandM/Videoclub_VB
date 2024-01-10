Imports System.Data.SQLite
Imports System.IO

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
            While lector.Read()
                'resultado = New Pelicula(id:=lector.GetInt64(0), nombre:=)
            End While
            lector.Close()
            conexion.Close()
            Return resultado
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function


End Class
