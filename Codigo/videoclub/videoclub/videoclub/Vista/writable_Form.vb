Public Class writable_Form

    Shared formulario As writable_Form
    Shared Function GetInstance() As writable_Form
        If formulario Is Nothing Then
            formulario = New writable_Form
        End If
        Return formulario
    End Function

End Class