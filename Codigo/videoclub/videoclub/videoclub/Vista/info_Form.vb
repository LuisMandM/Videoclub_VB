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
        dataGrid_Roles.DataSource = reader.ReadingRolesDataSet(v_movie.id)

    End Sub


    Private Sub SetEnable()
        wcontent.Enabled = False
    End Sub

    Private Sub btton_Close_Click(sender As Object, e As EventArgs) Handles btton_Close.Click
        Main_Form.InsertarFormulario(Views_Form.GetInstance)
        Views_Form.GetInstance().CargarDatos()

    End Sub
End Class