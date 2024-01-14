Public Class WritableContent
    Private _dataSource As Object
    Private displayMember As String
    Private valueMember As String

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
        RaiseEvent clickLoad()
    End Sub


End Class
