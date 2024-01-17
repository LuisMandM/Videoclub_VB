Imports System.Diagnostics.Eventing
Imports System.Runtime.Remoting.Contexts

Public Class writable_Form

    Shared formulario As writable_Form
    Dim reader As ReadSQL
    Shared Function GetInstance() As writable_Form
        If formulario Is Nothing Then
            formulario = New writable_Form
        End If
        Return formulario
    End Function

    Sub Cargar_Datos(id_Movie As Integer)
        Dim v_movie As Pelicula = Reader.ReadPelicula_Single(id_Movie)
        creationCtrl.nombre = v_movie.nombre
        creationCtrl.duracion = v_movie.duracion
        creationCtrl.productora = v_movie.productora
        creationCtrl.sinopsis = v_movie.sinopsis

        'content.nombre = v_movie.nombre
        'wcontent.productora = v_movie.productora
        'wcontent.duracion = String.Format("{0} min", v_movie.duracion.ToString)
        'wcontent.sinopsis = v_movie.sinopsis
        'wcontent.genero = v_movie.genero.ToString
        'wcontent.director = v_movie.director.nombre
        'SetEnable()
        'dataGrid_Roles.DataSource = reader.ReadingRolesDataSet(v_movie.id)

    End Sub
End Class