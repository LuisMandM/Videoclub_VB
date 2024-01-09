Imports System.Data.SQLite

Public Class Controller




    Function Escribir()
        Dim con As SQLiteConnection = New SQLiteConnection(My.Settings.conexion_db)
        Try
            con.Open()
            Dim query As String = String.Format("INSERT INTO DIRECTORES (NOMBRE) VALUES (@nombre)")
            Dim cmd As New SQLiteCommand(query, con)

            cmd.Parameters.Add("@nombre", DbType.String).Value = "Guillermo del Toro"

            cmd.ExecuteNonQuery()
            Console.WriteLine("Registro exitoso")


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Structure genero_Enum
        Enum genero
            TERROR
            ACCION
            COMEDIA
            DRAMA
            ANIMACION
        End Enum

    End Structure

End Class
