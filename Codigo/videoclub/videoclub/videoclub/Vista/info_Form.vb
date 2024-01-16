Imports System.Data.SQLite
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class info_Form
    Shared formulario As info_Form
    Dim reader As New ReadSQL
    Shared Function GetInstance() As info_Form
        If formulario Is Nothing Then
            formulario = New info_Form
        End If
        formulario.Cargar_Datos(1)
        Return formulario
    End Function

    Sub Cargar_Datos(id_Movie As Integer)
        Dim v_movie As Pelicula = reader.ReadPelicula_Single(id_Movie)
        wcontent.registro = v_movie.id.ToString
        wcontent.nombre = v_movie.nombre
        wcontent.productora = v_movie.productora
        wcontent.duracion = String.Format("{0} min", v_movie.duracion.ToString)
        wcontent.sinopsis = v_movie.sinopsis
        wcontent.genero = New List(Of String) From {v_movie.genero.ToString}
        wcontent.director = New List(Of String) From {v_movie.director.nombre}
        'SetEnable()

        'Dim con As New SQLiteConnection(My.Settings.conexion_db)
        'Dim consulta As String = "SELECT D.NOMBRE AS ""Actor"", A.NOMBRE AS ""Personaje"" FROM PERSONAJES A JOIN ACTORES D ON(D.id = A.actor)"
        'Try
        '    con.Open()
        '    Dim cmd As New SQLiteCommand(consulta, con)
        '    Dim da As New SQLiteDataAdapter(cmd)
        '    Dim ds As New DataSet()
        '    ds.Tables.Add("tabla")
        '    da.Fill(ds.Tables("tabla"))
        '    dataGrid_Roles.DataSource = ds.Tables("tabla")
        '    dataGrid_Roles.Dock = DockStyle.Fill
        '    con.Close()
        'Catch ex As Exception
        '    MsgBox("Problemas con la BBDD")
        'End Try

        dataGrid_Roles.DataSource = reader.ReadingRolesDataSet(v_movie.id)

    End Sub


    Private Sub SetEnable()
        wcontent.Enabled = False
    End Sub
End Class