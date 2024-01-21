﻿Public Class Pelicula

    Property id As Integer
    Property nombre As String
    Property director As Persona
    Property duracion As Integer
    Property productora As String
    Property genero As String

    Property sinopsis As String

    Property poster As Image

    Property personajes As List(Of Personaje)

    Public Sub New(nombre As String, director As Persona, duracion As Integer, productora As String, genero As String, sinopsis As String)
        Me.nombre = nombre
        Me.director = director
        Me.duracion = duracion
        Me.productora = productora
        Me.genero = genero
        Me.sinopsis = sinopsis
    End Sub

    Public Sub New(nombre As String, director As Persona, duracion As Integer, productora As String, genero As String, sinopsis As String, poster As Image, personajes As List(Of Personaje))
        Me.New(nombre, director, duracion, productora, genero, sinopsis)
        Me.poster = poster
        Me.personajes = personajes
    End Sub

    Public Sub New(id As Integer, nombre As String, director As Persona, duracion As Integer, productora As String, genero As String, sinopsis As String)
        Me.id = id
        Me.nombre = nombre
        Me.director = director
        Me.duracion = duracion
        Me.productora = productora
        Me.genero = genero
        Me.sinopsis = sinopsis
    End Sub

    Public Sub New(id As Integer, nombre As String, director As Persona, duracion As Integer, productora As String, genero As String, sinopsis As String, poster As Image, personajes As List(Of Personaje))
        Me.New(id, nombre, director, duracion, productora, genero, sinopsis)
        Me.poster = poster
        Me.personajes = personajes
    End Sub

    Public Sub New(id As Integer, nombre As String, director As Persona, duracion As Integer, productora As String, genero As String, sinopsis As String, poster As Image)
        Me.New(id, nombre, director, duracion, productora, genero, sinopsis)
        Me.poster = poster
    End Sub
End Class
