Public Class Persona
    Property id As Integer
    Property nombre As String

    Public Sub New(nombre As String)
        Me.nombre = nombre
    End Sub

    Public Sub New(id As Integer, nombre As String)
        Me.id = id
        Me.nombre = nombre
    End Sub
End Class
