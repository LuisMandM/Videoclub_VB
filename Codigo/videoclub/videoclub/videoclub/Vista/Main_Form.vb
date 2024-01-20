Public Class Main_Form
    Private Sub Main_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InsertarFormulario(Init_Form.GetInstance())
    End Sub

    Sub InsertarFormulario(formulario As Form)
        ' Comprobar si hay un formulario secundario activo
        If Me.ActiveMdiChild IsNot Nothing Then
            ' Cerrar y quitar el formulario secundario activo
            Me.ActiveMdiChild.Hide()
        End If

        formulario.MdiParent = Me
        formulario.Dock = DockStyle.Fill
        formulario.Show()
    End Sub



    Private Sub smi_Pelicula_Click(sender As Object, e As EventArgs) Handles smi_Pelicula.Click
        InsertarFormulario(writable_Form.GetInstance)
        'writable_Form.role = writable_Form.Action.action.CREATING
    End Sub

    Private Sub smi_Visualizar_Click(sender As Object, e As EventArgs) Handles smi_Visualizar.Click
        InsertarFormulario(Views_Form.GetInstance)
        Views_Form.GetInstance().CargarDatos()

    End Sub

    Private Sub smi_Actor_Click(sender As Object, e As EventArgs) Handles smi_Actor.Click
        Dim formulario = Add_Persona_Form
        formulario.Text = "Añadir Actor"
        formulario.tipo_Persona = Add_Persona_Form.Role.role.ACTOR
        formulario.Show()
    End Sub

    Private Sub smi_Director_Click(sender As Object, e As EventArgs) Handles smi_Director.Click
        Dim formulario = Add_Persona_Form
        formulario.Text = "Añadir Director"
        formulario.tipo_Persona = Add_Persona_Form.Role.role.DIRECTOR
        formulario.Show()
    End Sub

    Public Sub ShowInfoView(movie As Integer)
        InsertarFormulario(info_Form.GetInstance(movie))
    End Sub

    Public Sub ShowEditView(movie As Integer)
        InsertarFormulario(writable_Form.GetInstance(movie))
        'writable_Form.role = writable_Form.Action.action.CREATING
    End Sub
End Class