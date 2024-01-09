Public Class Personaje
    Property nombre As String
    Property pelicula As Pelicula
    Property actor As Persona

    Public Sub New(nombre As String, pelicula As Pelicula, actor As Persona)
        Me.nombre = nombre
        Me.pelicula = pelicula
        Me.actor = actor
    End Sub
End Class
