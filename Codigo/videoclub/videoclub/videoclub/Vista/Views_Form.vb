Public Class Views_Form
    Shared formulario As Views_Form
    Shared Function GetInstance() As Views_Form
        If formulario Is Nothing Then
            formulario = New Views_Form
        End If
        Return formulario
    End Function
End Class