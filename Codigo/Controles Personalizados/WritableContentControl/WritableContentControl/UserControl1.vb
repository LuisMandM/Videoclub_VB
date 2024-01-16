Public Class WritableContent
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
            Return lbl_Name.Text
        End Get
        Set
            lbl_Name.Text = Value
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

    Property director As List(Of String)
        Get
            Return cbox_Director.SelectedItem
        End Get
        Set
            For Each item In Value
                cbox_Director.Items.Add(item)
            Next
        End Set
    End Property

    Property genero As List(Of String)
        Get
            Return cbox_Genero.SelectedItem
        End Get
        Set
            For Each item In Value
                cbox_Genero.Items.Add(item)
            Next
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

    Property registro As String
        Get
            Return tbox_Registro.Text
        End Get
        Set
            tbox_Registro.Text = Value
        End Set
    End Property

    Public Event clickLoad()

    Public Property DataSource As Object
        Get
            Return cbox_Director.DataSource
        End Get
        Set(value As Object)
            cbox_Director.DataSource = value
        End Set
    End Property

    Public Property DisplayMember1 As String
        Get
            Return cbox_Director.DisplayMember
        End Get
        Set(value As String)
            cbox_Director.DisplayMember = value
        End Set
    End Property

    Public Property ValueMember1 As String
        Get
            Return cbox_Director.ValueMember
        End Get
        Set(value As String)
            cbox_Director.ValueMember = value
        End Set
    End Property


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
