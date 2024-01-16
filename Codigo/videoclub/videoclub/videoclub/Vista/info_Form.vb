Public Class info_Form
    Shared formulario As info_Form
    Dim reader As New ReadSQL
    Shared Function GetInstance() As info_Form
        If formulario Is Nothing Then
            formulario = New info_Form
        End If
        Return formulario
    End Function

    Sub Cargar_Datos(id_Movie As Integer)
        Dim v_movie As Pelicula = reader.ReadPelicula_Single(id_Movie)
        wcontent.registro = v_movie.id


    End Sub

End Class