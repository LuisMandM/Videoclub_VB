Imports System.Data.SQLite

Public Class WriteSQL

    Sub AddDirector(director As Persona)
        Dim con As SQLiteConnection = New SQLiteConnection(My.Settings.conexion_db)
        Try
            con.Open()
            Dim query As String = String.Format("INSERT INTO DIRECTORES (NOMBRE) VALUES (@nombre)")
            Dim cmd As New SQLiteCommand(query, con)
            cmd.Parameters.Add("@nombre", DbType.String).Value = director.nombre
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            Throw New Exception(ex.Message)

        End Try
    End Sub

    Sub AddActor(actor As Persona)
        Dim con As SQLiteConnection = New SQLiteConnection(My.Settings.conexion_db)
        Try
            con.Open()
            Dim query As String = String.Format("INSERT INTO ACTORES (NOMBRE) VALUES (@nombre)")
            Dim cmd As New SQLiteCommand(query, con)
            cmd.Parameters.Add("@nombre", DbType.String).Value = actor.nombre
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

    Sub AddPelicula(pelicula As Pelicula)
        Dim con As SQLiteConnection = New SQLiteConnection(My.Settings.conexion_db)
        Try
            con.Open()
            Dim query As String = String.Format("INSERT INTO PELICULAS (DIRECTOR,NOMBRE, DURACION, PRODUCTORA, GENERO, SINOPSIS) VALUES (@director ,@nombre, @duracion,@productora,@genero,@sinopsis)")
            Dim cmd As New SQLiteCommand(query, con)

            cmd.Parameters.Add("@director", DbType.Int64).Value = pelicula.director.id
            cmd.Parameters.Add("@nombre", DbType.String).Value = pelicula.nombre
            cmd.Parameters.Add("@duracion", DbType.Int64).Value = pelicula.duracion
            cmd.Parameters.Add("@productora", DbType.String).Value = pelicula.productora
            cmd.Parameters.Add("@genero", DbType.String).Value = pelicula.genero
            cmd.Parameters.Add("@sinopsis", DbType.String).Value = pelicula.sinopsis


            cmd.ExecuteNonQuery()

        Catch ex As Exception
            Throw New Exception(ex.Message)

        End Try
    End Sub

End Class
