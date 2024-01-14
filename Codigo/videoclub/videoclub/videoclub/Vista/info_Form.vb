Public Class info_Form
    Shared formulario As info_Form
    Shared Function GetInstance() As info_Form
        If formulario Is Nothing Then
            formulario = New info_Form
        End If
        Return formulario
    End Function


End Class