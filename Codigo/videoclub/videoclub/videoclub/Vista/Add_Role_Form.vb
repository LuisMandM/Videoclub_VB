Public Class Add_Role_Form
    Shared formulario As Views_Form
    Dim reader As New ReadSQL
    Dim writer As New WriteSQL
    Private _current_Movie As Integer

    Property current_Movie As Integer
        Get
            Return _current_Movie
        End Get
        Set
            _current_Movie = Value
        End Set
    End Property

    Shared Function GetInstance() As Views_Form
        If formulario Is Nothing Then
            formulario = New Views_Form
        End If
        Return formulario
    End Function

    Sub Cargar_Datos()
        cbox_Actor.DataSource = reader.ReadingActorsDataSource
        cbox_Actor.DisplayMember = "nombre"
        cbox_Actor.ValueMember = "id"
    End Sub

    Private Sub btton_Create_Click(sender As Object, e As EventArgs) Handles btton_Create.Click
        Dim formulario = Add_Persona_Form
        formulario.Text = "Añadir Actor"
        formulario.tipo_Persona = Add_Persona_Form.Role.role.ACTOR
        formulario.source = Me
        formulario.Show()
    End Sub

    Private Sub btton_Save_Click(sender As Object, e As EventArgs) Handles btton_Save.Click
        Try
            writer.AddPersonaje(cbox_Actor.SelectedValue, tbox_Role.Text, current_Movie)
            MsgBox(String.Format("Personaje: {0}, Guardado exitosamente", tbox_Role.Text), Title:="Guardado Personajes")
            Me.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message, Title:="Error Guardado personajes")
        End Try
    End Sub
End Class