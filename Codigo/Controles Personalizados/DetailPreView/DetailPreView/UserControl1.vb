Public Class DetailView
    Private _titulo As String
    Private _contenido As String

    Property contenido As String
        Get
            Return tbox_Content.Text
        End Get
        Set
            tbox_Content.Text = Value
        End Set
    End Property

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
        RaiseEvent clickView()
    End Sub

    Private Sub btton_Edit_Click(sender As Object, e As EventArgs) Handles btton_Edit.Click
        RaiseEvent clickEdit()
    End Sub

    Private Sub btton_Delete_Click(sender As Object, e As EventArgs) Handles btton_Delete.Click
        RaiseEvent clickDelete()
    End Sub
End Class
