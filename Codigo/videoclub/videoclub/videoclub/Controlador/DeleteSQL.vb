Imports System.Data.SQLite

Public Class DeleteSQL

    Public Sub Delete_Movie(movie As Integer)
        Dim con As SQLiteConnection = New SQLiteConnection(My.Settings.conexion_db)
        Try
            con.Open()
            Delete_Roles(movie)
            Dim query As String = String.Format("DELETE FROM PELICULAS WHERE ID = @id")
            Dim cmd As New SQLiteCommand(query, con)
            cmd.Parameters.Add("@id", DbType.Int64).Value = movie
            cmd.ExecuteNonQuery()
            con.Close()

        Catch ex As Exception
            Throw New Exception(ex.Message)

        End Try
    End Sub


    Private Sub Delete_Roles(movie As Integer)
        Dim con As SQLiteConnection = New SQLiteConnection(My.Settings.conexion_db)
        Try
            con.Open()
            Dim query As String = String.Format("DELETE FROM PERSONAJES WHERE PELICULA = @movie")
            Dim cmd As New SQLiteCommand(query, con)
            cmd.Parameters.Add("@movie", DbType.Int64).Value = movie
            cmd.ExecuteNonQuery()
            con.Close()

        Catch ex As Exception
            Throw New Exception(ex.Message)

        End Try
    End Sub

End Class
