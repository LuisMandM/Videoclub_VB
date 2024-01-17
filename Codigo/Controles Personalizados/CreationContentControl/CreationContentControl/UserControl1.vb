Public Class CreationContentControl
    Private _dataSource As Object
    Private displayMember As String
    Private valueMember As String
    Private _registro As String
    Private _duracion As String
    Private _productora As String
    Private _sinopsis As String
    Private _genero As List(Of String)
    Private _director As List(Of String)
    Private _poster As Image
    Private _nombre As String

    Property nombre As String
        Get
            Return tbox_Nombre.Text
        End Get
        Set
            tbox_Nombre.Text = Value
        End Set
    End Property

    Property poster As Image
        Get
            Return picBox_Poster.Image
        End Get
        Set
            picBox_Poster.Image = Value
        End Set
    End Property


    Property sinopsis As String
        Get
            Return tbox_Sinopsis.Text
        End Get
        Set
            tbox_Sinopsis.Text = Value
        End Set
    End Property

    Property productora As String
        Get
            Return tbox_Productora.Text
        End Get
        Set
            tbox_Productora.Text = Value
        End Set
    End Property

    Property duracion As String
        Get
            Return tbox_Duracion.Text
        End Get
        Set
            tbox_Duracion.Text = Value
        End Set
    End Property

    Public Event clickLoad()


    Public Overrides Property MinimumSize As Size
        Get
            Return MyBase.MinimumSize
        End Get
        Set(value As Size)
            MyBase.MinimumSize = New Size(317, 440)
        End Set
    End Property


    'Funcion para la selección de la foto <- funciona en local probar a la escritura desde la recuperacion desde BD.
    Private Sub picBox_Click(sender As Object, e As EventArgs) Handles picBox_Poster.Click
        Dim resultado As DialogResult
        resultado = OpenFileDialog1.ShowDialog(Me)
        If resultado = DialogResult.OK Then
            picBox_Poster.ImageLocation = OpenFileDialog1.FileName
        End If
    End Sub

End Class
