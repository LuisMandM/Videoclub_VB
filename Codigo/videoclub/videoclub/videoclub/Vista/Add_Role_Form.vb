Public Class Add_Role_Form
    Shared formulario As Views_Form
    Dim reader As New ReadSQL
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
        'creationCtrl.DataSource = reader.ReadingDirectorsDataSource
        'creationCtrl.DisplayMember1 = "nombre"
        'creationCtrl.ValueMember1 = "id"
    End Sub
End Class