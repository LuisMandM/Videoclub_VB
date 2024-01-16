Imports System.ComponentModel
Imports System.Security.Cryptography.X509Certificates
Imports DetailPreView

Public Class Views_Form
    Shared formulario As Views_Form
    Dim tlpMovies = New TableLayoutPanel()
    Dim reader As New ReadSQL
    Shared Function GetInstance() As Views_Form
        If formulario Is Nothing Then
            formulario = New Views_Form
        End If
        Return formulario
    End Function

    Sub New()
        ' Constructor del formulario
        InitializeComponent()

        ' Configurar el TableLayoutPanel en el constructor

        tlpMovies.AutoScroll = True
        tlpMovies.ColumnCount = 1
        tlpMovies.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.0!))
        tlpMovies.Dock = DockStyle.Fill
        tlpMovies.Name = "tlpMovies"
        tlpMovies.TabIndex = 0

        ' Agregar el TableLayoutPanel al formulario
        Me.Controls.Add(tlpMovies)
    End Sub

    Sub CargarDatos()
        Dim filmStock As List(Of Pelicula) = reader.ReadPelicula()
        tlpMovies.Controls.Clear

        Dim i As Integer = 0
        For Each movie In filmStock
            Dim v_movie As New DetailView With {
                .titulo = movie.nombre,
                .contenido = movie.sinopsis
            }
            tlpMovies.RowStyles.Add(New RowStyle(AutoSize))
            tlpMovies.Controls.Add(v_movie, 0, i)



            AddHandler v_movie.clickView, AddressOf show_Info
            AddHandler v_movie.clickEdit, AddressOf show
            AddHandler v_movie.clickDelete, AddressOf show

            i = i + 1
        Next
        tlpMovies.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0!))
        Me.Controls.Add(tlpMovies)
    End Sub

    Sub show_Info()
        Main_Form.ShowInfoView()
    End Sub

End Class