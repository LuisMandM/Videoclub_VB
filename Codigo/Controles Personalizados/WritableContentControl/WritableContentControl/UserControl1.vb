Public Class WritableContent
    Private _dataSource As Object
    Private displayMember As String
    Private valueMember As String



    Public Property DataSource As Object
        Get
            Return cbox_1.DataSource
        End Get
        Set(value As Object)
            cbox_1.DataSource = value
        End Set
    End Property

    Public Property DisplayMember1 As String
        Get
            Return cbox_1.DisplayMember
        End Get
        Set(value As String)
            cbox_1.DisplayMember = value
        End Set
    End Property

    Public Property ValueMember1 As String
        Get
            Return cbox_1.ValueMember
        End Get
        Set(value As String)
            cbox_1.ValueMember = value
        End Set
    End Property





    'Funcion para la selección de la foto <- funciona en local probar a la escritura desde la recuperacion desde BD.
    Private Sub picBox_Click(sender As Object, e As EventArgs) Handles picBox.Click
        Dim resultado As DialogResult
        resultado = OpenFileDialog1.ShowDialog(Me)
        If resultado = DialogResult.OK Then
            picBox.ImageLocation = OpenFileDialog1.FileName
        End If
    End Sub



End Class
