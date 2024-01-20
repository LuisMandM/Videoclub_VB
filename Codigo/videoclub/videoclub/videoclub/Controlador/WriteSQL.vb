Imports System.Data.SQLite
Imports System.IO

Public Class WriteSQL

    Sub AddDirector(director As String)
        Dim con As SQLiteConnection = New SQLiteConnection(My.Settings.conexion_db)
        Try
            con.Open()
            Dim query As String = String.Format("INSERT INTO DIRECTORES (NOMBRE) VALUES (@nombre)")
            Dim cmd As New SQLiteCommand(query, con)
            cmd.Parameters.Add("@nombre", DbType.String).Value = director
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            Throw New Exception(ex.Message)

        End Try
    End Sub

    Sub AddActor(actor As String)
        Dim con As SQLiteConnection = New SQLiteConnection(My.Settings.conexion_db)
        Try
            con.Open()
            Dim query As String = String.Format("INSERT INTO ACTORES (NOMBRE) VALUES (@nombre)")
            Dim cmd As New SQLiteCommand(query, con)
            cmd.Parameters.Add("@nombre", DbType.String).Value = actor
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            Throw New Exception(ex.Message)

        End Try
    End Sub


    Sub AddPersonaje(personaje As Personaje)
        Dim con As SQLiteConnection = New SQLiteConnection(My.Settings.conexion_db)
        Try
            con.Open()
            Dim query As String = String.Format("INSERT INTO PERSONAJES (ACTOR, NOMBRE, PELICULA) VALUES (@actor ,@nombre, @pelicula)")
            Dim cmd As New SQLiteCommand(query, con)
            cmd.Parameters.Add("@actor", DbType.Int64).Value = personaje.actor.id
            cmd.Parameters.Add("@nombre", DbType.String).Value = personaje.nombre
            cmd.Parameters.Add("@pelicula", DbType.Int64).Value = personaje.pelicula.id
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            Throw New Exception(ex.Message)

        End Try
    End Sub


    Sub AddPelicula_All(nombre As String, duracion As String, productora As String, sinopsis As String, genero As String, director As Integer, poster As Image)
        Dim con As SQLiteConnection = New SQLiteConnection(My.Settings.conexion_db)
        Try
            con.Open()
            Dim query As String = String.Format("INSERT INTO PELICULAS (DIRECTOR,NOMBRE, DURACION, PRODUCTORA, GENERO, SINOPSIS, POSTER) VALUES (@director ,@nombre, @duracion,@productora,@genero,@sinopsis,@poster)")
            Dim cmd As New SQLiteCommand(query, con)

            cmd.Parameters.Add("@director", DbType.Int64).Value = director
            cmd.Parameters.Add("@nombre", DbType.String).Value = nombre
            cmd.Parameters.Add("@duracion", DbType.Int64).Value = duracion
            cmd.Parameters.Add("@productora", DbType.String).Value = productora
            cmd.Parameters.Add("@genero", DbType.String).Value = genero
            cmd.Parameters.Add("@sinopsis", DbType.String).Value = sinopsis
            If poster IsNot Nothing Then
                Using stream As New MemoryStream()
                    poster.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg)
                    Dim imageData As Byte() = stream.ToArray
                    cmd.Parameters.Add("@poster", DbType.Binary).Value = imageData
                End Using
            Else
                Throw New Exception("Imagen sin valor")
            End If
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            Throw New Exception(ex.Message)

        End Try
    End Sub

    Sub AddPelicula(nombre As String, duracion As String, productora As String, sinopsis As String, genero As String, director As Integer)
        Dim con As SQLiteConnection = New SQLiteConnection(My.Settings.conexion_db)
        Try
            con.Open()
            Dim query As String = String.Format("INSERT INTO PELICULAS (DIRECTOR,NOMBRE, DURACION, PRODUCTORA, GENERO, SINOPSIS) VALUES (@director ,@nombre, @duracion,@productora,@genero,@sinopsis)")
            Dim cmd As New SQLiteCommand(query, con)

            cmd.Parameters.Add("@director", DbType.Int64).Value = director
            cmd.Parameters.Add("@nombre", DbType.String).Value = nombre
            cmd.Parameters.Add("@duracion", DbType.Int64).Value = duracion
            cmd.Parameters.Add("@productora", DbType.String).Value = productora
            cmd.Parameters.Add("@genero", DbType.String).Value = genero
            cmd.Parameters.Add("@sinopsis", DbType.String).Value = sinopsis
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            Throw New Exception(ex.Message)

        End Try
    End Sub


    Sub UpdatePelicula(id As Integer, nombre As String, duracion As String, productora As String, sinopsis As String, genero As String, director As Integer)
        Dim con As SQLiteConnection = New SQLiteConnection(My.Settings.conexion_db)
        Try
            con.Open()
            Dim query As String = String.Format("UPDATE PELICULAS SET DIRECTOR = @director, NOMBRE = @nombre, DURACION = @duracion, PRODUCTORA = @productora, GENERO = @genero, SINOPSIS = @sinopsis WHERE ID = @id")
            Dim cmd As New SQLiteCommand(query, con)

            cmd.Parameters.Add("@director", DbType.Int64).Value = director
            cmd.Parameters.Add("@nombre", DbType.String).Value = nombre
            cmd.Parameters.Add("@duracion", DbType.Int64).Value = duracion
            cmd.Parameters.Add("@productora", DbType.String).Value = productora
            cmd.Parameters.Add("@genero", DbType.String).Value = genero
            cmd.Parameters.Add("@sinopsis", DbType.String).Value = sinopsis
            cmd.Parameters.Add("@id", DbType.String).Value = id
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            Throw New Exception(ex.Message)

        End Try

    End Sub

    Sub UpdatePelicula_All(id As Integer, nombre As String, duracion As String, productora As String, sinopsis As String, genero As String, director As Integer, poster As Image)
        Dim con As SQLiteConnection = New SQLiteConnection(My.Settings.conexion_db)
        Try
            con.Open()
            Dim query As String = String.Format("UPDATE PELICULAS SET DIRECTOR = @director, NOMBRE = @nombre, DURACION = @duracion, PRODUCTORA = @productora, GENERO = @genero, SINOPSIS = @sinopsis, POSTER = @poster WHERE ID = @id")
            Dim cmd As New SQLiteCommand(query, con)

            cmd.Parameters.Add("@director", DbType.Int64).Value = director
            cmd.Parameters.Add("@nombre", DbType.String).Value = nombre
            cmd.Parameters.Add("@duracion", DbType.Int64).Value = duracion
            cmd.Parameters.Add("@productora", DbType.String).Value = productora
            cmd.Parameters.Add("@genero", DbType.String).Value = genero
            cmd.Parameters.Add("@sinopsis", DbType.String).Value = sinopsis
            If poster IsNot Nothing Then
                Using stream As New MemoryStream()
                    poster.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg)
                    Dim imageData As Byte() = stream.ToArray
                    cmd.Parameters.Add("@poster", DbType.Binary).Value = imageData
                End Using
            Else
                Throw New Exception("Imagen sin valor")
            End If
            cmd.Parameters.Add("@id", DbType.String).Value = id
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            Throw New Exception(ex.Message)

        End Try

    End Sub
End Class
