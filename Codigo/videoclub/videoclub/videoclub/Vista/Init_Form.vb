Public Class Init_Form

    Shared formulario As Init_Form
    Shared Function GetInstance() As Init_Form
        If formulario Is Nothing Then
            formulario = New Init_Form
        End If
        Return formulario
    End Function

End Class