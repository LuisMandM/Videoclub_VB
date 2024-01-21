Imports System.Deployment.Internal

Public Class DetailView
    Private _titulo As String
    Private _contenido As String
    Private _id_Movie As String
    Private _poster As Image

    Property poster As Image
        Get
            Return picBox.Image
        End Get
        Set
            picBox.Image = Value
        End Set
    End Property

    Property id_Movie As String
        Get
            Return _id_Movie
        End Get
        Set
            _id_Movie = Value
        End Set
    End Property

    Property contenido As String
        Get
            Return tbox_Content.Text
        End Get
        Set
            tbox_Content.Text = Value
        End Set
    End Property

    Public Event MyclickView As EventHandler(Of ButtonClickEventArgs)
    Public Event MyclickEdit As EventHandler(Of ButtonClickEventArgs)
    Public Event MyclickDelete As EventHandler(Of ButtonClickEventArgs)


    Public Event clickEdit()
    Public Event clickView()
    Public Event clickDelete()


    Property titulo As String
        Get
            Return lbl_Title.Text
        End Get
        Set
            lbl_Title.Text = Value
        End Set
    End Property

    Public Overrides Property MinimumSize As Size
        Get
            Return MyBase.MinimumSize
        End Get
        Set(value As Size)
            MyBase.MinimumSize = New Size(242, 50)
        End Set
    End Property

    Private Sub btton_View_Click(sender As Object, e As EventArgs) Handles btton_View.Click
        Dim movie As Integer = id_Movie
        RaiseEvent MyclickView(Me, New ButtonClickEventArgs(movie))
    End Sub

    Private Sub btton_Edit_Click(sender As Object, e As EventArgs) Handles btton_Edit.Click
        Dim movie As Integer = id_Movie
        RaiseEvent MyclickEdit(Me, New ButtonClickEventArgs(movie))
    End Sub

    Private Sub btton_Delete_Click(sender As Object, e As EventArgs) Handles btton_Delete.Click
        Dim movie As Integer = id_Movie
        RaiseEvent MyclickDelete(Me, New ButtonClickEventArgs(movie))
    End Sub
End Class

Public Class ButtonClickEventArgs
    Inherits EventArgs

    Public Sub New(id As Integer)
        Me.Id_Movie = id
    End Sub

    Public ReadOnly Property Id_Movie As Integer
End Class
