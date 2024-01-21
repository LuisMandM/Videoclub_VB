﻿Imports System.Diagnostics.Eventing
Imports System.IO
Imports System.Net.Mime.MediaTypeNames
Imports System.Runtime.Remoting.Contexts
Imports videoclub.Controller

Public Class writable_Form

    Shared formulario As writable_Form
    Private reader As New ReadSQL
    Private writer As New WriteSQL
    Private controller As New Controller
    Private _role As Action.action
    Private current_Poster As System.Drawing.Image

    Property role As Action.action
        Get
            Return _role
        End Get
        Set
            _role = Value
        End Set
    End Property

    Shared Function GetInstance(id As Integer) As writable_Form
        If formulario Is Nothing Then
            formulario = New writable_Form
        End If
        formulario.discardChanges()
        formulario.Cargar_Datos(id)
        formulario.btton_add_Personaje.Enabled = True
        formulario.btton_add_Personaje.Visible = True
        formulario.btton_add_Director.Enabled = False
        formulario.btton_add_Director.Visible = False
        formulario.role = Action.action.EDITING
        Return formulario
    End Function
    Shared Function GetInstance() As writable_Form
        If formulario Is Nothing Then
            formulario = New writable_Form
        End If
        formulario.btton_add_Personaje.Enabled = False
        formulario.btton_add_Personaje.Visible = False
        formulario.btton_add_Director.Enabled = False
        formulario.btton_add_Director.Visible = False
        formulario.role = Action.action.CREATING
        formulario.discardChanges()
        Return formulario
    End Function

    Sub Cargar_Datos(id_Movie As Integer)
        Dim v_movie As Pelicula = reader.ReadPelicula_Single(id_Movie)
        creationCtrl.id = v_movie.id
        creationCtrl.nombre = v_movie.nombre
        creationCtrl.duracion = v_movie.duracion
        creationCtrl.productora = v_movie.productora
        creationCtrl.sinopsis = v_movie.sinopsis
        creationCtrl.selected_gender = Nothing
        If v_movie.poster IsNot Nothing Then
            creationCtrl.poster = v_movie.poster
            current_Poster = v_movie.poster
        End If

    End Sub

    Private Sub discardChanges()
        creationCtrl.nombre = ""
        creationCtrl.duracion = ""
        creationCtrl.productora = ""
        creationCtrl.sinopsis = ""
        creationCtrl.DataSource = reader.ReadingDirectorsDataSource
        creationCtrl.DisplayMember1 = "nombre"
        creationCtrl.ValueMember1 = "id"
        creationCtrl.genero = Nothing
        creationCtrl.genero = controller.enumString
        creationCtrl.poster = Nothing

    End Sub

    Private Sub btton_Discard_Click(sender As Object, e As EventArgs) Handles btton_Discard.Click
        discardChanges()
        Main_Form.InsertarFormulario(Init_Form.GetInstance())
    End Sub

    Private Sub btton_Save_Click(sender As Object, e As EventArgs) Handles btton_Save.Click
        Try


            If Not CheckingForm() Then
                MsgBox("Algunos de los campos obligatorios pueden estar vacios, verifique la información e intente nuevamente", Title:="Error Creación Pelicula")
            Else
                Dim selected = creationCtrl.selected_gender
                Dim selected_dir = Integer.Parse(creationCtrl.director)

                If role = Action.action.CREATING Then
                    ''Console.WriteLine(selected)
                    If creationCtrl.poster IsNot Nothing Then
                        writer.AddPelicula_All(creationCtrl.nombre, creationCtrl.duracion, creationCtrl.productora, creationCtrl.sinopsis, selected.ToString, selected_dir, creationCtrl.poster)
                    Else
                        writer.AddPelicula(creationCtrl.nombre, creationCtrl.duracion, creationCtrl.productora, creationCtrl.sinopsis, selected.ToString, selected_dir)

                    End If

                    'writer.AddPelicula(creationCtrl.nombre, creationCtrl.duracion, creationCtrl.productora, creationCtrl.sinopsis, selected.ToString, selected_dir)
                    MsgBox("Pelicula añadida", Title:="Registro Exitoso")
                    'Main_Form.InsertarFormulario(Init_Form.GetInstance())

                Else role = Action.action.EDITING
                    'Console.WriteLine(selected)
                    If creationCtrl.poster IsNot Nothing Then
                        'If ComparingPosters(Me.current_Poster, creationCtrl.poster) Then
                        '    writer.UpdatePelicula(creationCtrl.id, creationCtrl.nombre, creationCtrl.duracion, creationCtrl.productora, creationCtrl.sinopsis, selected.ToString, selected_dir)
                        'Else
                        '    writer.UpdatePelicula_All(creationCtrl.id, creationCtrl.nombre, creationCtrl.duracion, creationCtrl.productora, creationCtrl.sinopsis, selected.ToString, selected_dir, creationCtrl.poster)

                        'End If

                        writer.UpdatePelicula_All(creationCtrl.id, creationCtrl.nombre, creationCtrl.duracion, creationCtrl.productora, creationCtrl.sinopsis, selected.ToString, selected_dir, creationCtrl.poster)
                        'MsgBox("Pelicula actualizada", Title:="Actualización Exitosa")

                    Else
                        writer.UpdatePelicula(creationCtrl.id, creationCtrl.nombre, creationCtrl.duracion, creationCtrl.productora, creationCtrl.sinopsis, selected.ToString, selected_dir)
                        'MsgBox("Pelicula actualizada", Title:="Actualización Exitosa")

                    End If

                    'writer.UpdatePelicula(creationCtrl.id, creationCtrl.nombre, creationCtrl.duracion, creationCtrl.productora, creationCtrl.sinopsis, selected.ToString, selected_dir)
                    MsgBox("Pelicula actualizada", Title:="Actualización Exitosa")
                    'Main_Form.InsertarFormulario(Init_Form.GetInstance())
                End If
                Main_Form.InsertarFormulario(Views_Form.GetInstance)
                Views_Form.GetInstance().CargarDatos()
            End If
            ''Console.WriteLine(selected)
            'writer.UpdatePelicula(creationCtrl.id, creationCtrl.nombre, creationCtrl.duracion, creationCtrl.productora, creationCtrl.sinopsis, selected.ToString, selected_dir)
            'MsgBox("Pelicula actualizada", Title:="Actualización Exitosa")
            'Main_Form.InsertarFormulario(Init_Form.GetInstance())
        Catch ex As Exception
            MsgBox(ex.Message, Title:="Error Actualización")
        End Try
    End Sub


    Private Sub btton_add_Personaje_Click(sender As Object, e As EventArgs) Handles btton_add_Personaje.Click
        Dim formulario = Add_Role_Form
        formulario.Text = "Añadir Personaje"
        formulario.current_Movie = creationCtrl.id
        formulario.Cargar_Datos()
        formulario.Show()
    End Sub

    Public Structure Action
        Enum action
            EDITING
            CREATING
        End Enum
    End Structure

    Private Function ComparingPosters(image_current As System.Drawing.Image, changing_Image As System.Drawing.Image)
        Dim stream1 As New MemoryStream()
        Dim stream2 As New MemoryStream()
        image_current.Save(stream1, Imaging.ImageFormat.Jpeg)
        changing_Image.Save(stream2, Imaging.ImageFormat.Jpeg)
        Dim imageData As Byte() = stream1.ToArray

        Return stream1.ToArray().SequenceEqual(stream2.ToArray())
    End Function

    Private Function CheckingForm() As Boolean
        Dim correct_Form As Boolean
        If creationCtrl.nombre IsNot "" And creationCtrl.productora IsNot "" And creationCtrl.sinopsis IsNot "" And creationCtrl.duracion IsNot "" Then
            correct_Form = True
        Else
            correct_Form = False
        End If

        Dim nullable_director As Integer? = Integer.Parse(creationCtrl.director)
        If nullable_director Is Nothing Then
            Throw New Exception("Se debe elegir un Director para realizar el guardado.")
        End If

        Try
            Dim genero = creationCtrl.selected_gender
        Catch ex As Exception
            Throw New Exception("Se debe elegir un Genero para realizar el guardado.")
        End Try

        Try
            Dim duracion As Integer? = Integer.Parse(creationCtrl.duracion)
        Catch ex As Exception
            Throw New Exception("Los datos del campo duración deben ser unicamente númericos.")
        End Try

        Return correct_Form
    End Function

End Class