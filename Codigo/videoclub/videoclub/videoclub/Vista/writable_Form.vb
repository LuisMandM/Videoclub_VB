Imports System.Diagnostics.Eventing
Imports System.Runtime.Remoting.Contexts
Imports videoclub.Controller

Public Class writable_Form

    Shared formulario As writable_Form
    Private reader As New ReadSQL
    Private writer As New WriteSQL
    Private controller As New Controller
    Shared Function GetInstance(id As Integer) As writable_Form
        If formulario Is Nothing Then
            formulario = New writable_Form
        End If
        formulario.discardChanges()
        formulario.Cargar_Datos(id)
        Return formulario
    End Function
    Shared Function GetInstance() As writable_Form
        If formulario Is Nothing Then
            formulario = New writable_Form
        End If
        formulario.btton_add_Personaje.Enabled = False
        formulario.btton_add_Personaje.Visible = False
        formulario.discardChanges()
        Return formulario
    End Function

    Sub Cargar_Datos(id_Movie As Integer)
        Dim v_movie As Pelicula = reader.ReadPelicula_Single(id_Movie)
        creationCtrl.id = v_movie.id
        creationCtrl.nombre = v_movie.nombre
        creationCtrl.duracion = v_movie.duracion
        creationCtrl.productora = v_movie.productora
        creationCtrl.sinopsis = v_movie.sinopsis
        'creationCtrl.DataSource = reader.ReadingDirectorsDataSource
        'creationCtrl.DisplayMember1 = "nombre"
        'creationCtrl.ValueMember1 = "id"
        'creationCtrl.genero = controller.enumString


        'content.nombre = v_movie.nombre
        'wcontent.productora = v_movie.productora
        'wcontent.duracion = String.Format("{0} min", v_movie.duracion.ToString)
        'wcontent.sinopsis = v_movie.sinopsis
        'wcontent.genero = v_movie.genero.ToString
        'wcontent.director = v_movie.director.nombre
        'SetEnable()
        'dataGrid_Roles.DataSource = reader.ReadingRolesDataSet(v_movie.id)

    End Sub

    Private Sub discardChanges()
        creationCtrl.nombre = ""
        creationCtrl.duracion = ""
        creationCtrl.productora = ""
        creationCtrl.sinopsis = ""
        creationCtrl.DataSource = reader.ReadingDirectorsDataSource
        creationCtrl.DisplayMember1 = "nombre"
        creationCtrl.ValueMember1 = "id"
        creationCtrl.genero = Nothing
        creationCtrl.genero = controller.enumString
    End Sub

    Private Sub btton_Discard_Click(sender As Object, e As EventArgs) Handles btton_Discard.Click
        discardChanges()
        Main_Form.InsertarFormulario(Init_Form.GetInstance())
    End Sub

    Private Sub btton_Save_Click(sender As Object, e As EventArgs) Handles btton_Save.Click
        Try
            Dim selected = creationCtrl.selected_gender
            Dim selected_dir = Integer.Parse(creationCtrl.director)
            Console.WriteLine(selected)
            writer.UpdatePelicula(creationCtrl.id, creationCtrl.nombre, creationCtrl.duracion, creationCtrl.productora, creationCtrl.sinopsis, selected.ToString, selected_dir)
            MsgBox("Pelicula actualizada", Title:="Actualización Exitosa")
            Main_Form.InsertarFormulario(Init_Form.GetInstance())
        Catch ex As Exception
            MsgBox(ex.Message, Title:="Error Actualización")
        End Try
    End Sub
End Class