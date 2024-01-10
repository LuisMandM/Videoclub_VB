<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class info_Form
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tlp_Principal = New System.Windows.Forms.TableLayoutPanel()
        Me.tlp_Content = New System.Windows.Forms.TableLayoutPanel()
        Me.tlp_WritableContent = New System.Windows.Forms.TableLayoutPanel()
        Me.tlp_multimedia = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Actores = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Personaje = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tlp_Principal.SuspendLayout()
        Me.tlp_Content.SuspendLayout()
        Me.tlp_WritableContent.SuspendLayout()
        Me.tlp_multimedia.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlp_Principal
        '
        Me.tlp_Principal.ColumnCount = 1
        Me.tlp_Principal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlp_Principal.Controls.Add(Me.tlp_Content, 0, 0)
        Me.tlp_Principal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlp_Principal.Location = New System.Drawing.Point(0, 0)
        Me.tlp_Principal.Name = "tlp_Principal"
        Me.tlp_Principal.RowCount = 2
        Me.tlp_Principal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.0!))
        Me.tlp_Principal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlp_Principal.Size = New System.Drawing.Size(1272, 450)
        Me.tlp_Principal.TabIndex = 0
        '
        'tlp_Content
        '
        Me.tlp_Content.ColumnCount = 2
        Me.tlp_Content.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.tlp_Content.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.tlp_Content.Controls.Add(Me.tlp_WritableContent, 0, 0)
        Me.tlp_Content.Controls.Add(Me.tlp_multimedia, 1, 0)
        Me.tlp_Content.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlp_Content.Location = New System.Drawing.Point(3, 3)
        Me.tlp_Content.Name = "tlp_Content"
        Me.tlp_Content.RowCount = 1
        Me.tlp_Content.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlp_Content.Size = New System.Drawing.Size(1266, 399)
        Me.tlp_Content.TabIndex = 0
        '
        'tlp_WritableContent
        '
        Me.tlp_WritableContent.ColumnCount = 2
        Me.tlp_WritableContent.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlp_WritableContent.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlp_WritableContent.Controls.Add(Me.Label1, 0, 1)
        Me.tlp_WritableContent.Controls.Add(Me.Label3, 0, 3)
        Me.tlp_WritableContent.Controls.Add(Me.Label4, 0, 4)
        Me.tlp_WritableContent.Controls.Add(Me.Label5, 0, 5)
        Me.tlp_WritableContent.Controls.Add(Me.Label6, 0, 6)
        Me.tlp_WritableContent.Controls.Add(Me.Label2, 0, 2)
        Me.tlp_WritableContent.Controls.Add(Me.TextBox1, 1, 1)
        Me.tlp_WritableContent.Controls.Add(Me.TextBox2, 1, 3)
        Me.tlp_WritableContent.Controls.Add(Me.TextBox3, 1, 4)
        Me.tlp_WritableContent.Controls.Add(Me.ComboBox1, 1, 2)
        Me.tlp_WritableContent.Controls.Add(Me.ComboBox2, 1, 5)
        Me.tlp_WritableContent.Controls.Add(Me.TextBox4, 1, 6)
        Me.tlp_WritableContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlp_WritableContent.Location = New System.Drawing.Point(3, 3)
        Me.tlp_WritableContent.Name = "tlp_WritableContent"
        Me.tlp_WritableContent.RowCount = 7
        Me.tlp_WritableContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlp_WritableContent.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlp_WritableContent.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlp_WritableContent.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlp_WritableContent.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlp_WritableContent.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlp_WritableContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.tlp_WritableContent.Size = New System.Drawing.Size(500, 393)
        Me.tlp_WritableContent.TabIndex = 0
        '
        'tlp_multimedia
        '
        Me.tlp_multimedia.ColumnCount = 2
        Me.tlp_multimedia.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlp_multimedia.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlp_multimedia.Controls.Add(Me.DataGridView1, 1, 0)
        Me.tlp_multimedia.Controls.Add(Me.PictureBox1, 0, 0)
        Me.tlp_multimedia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlp_multimedia.Location = New System.Drawing.Point(509, 3)
        Me.tlp_multimedia.Name = "tlp_multimedia"
        Me.tlp_multimedia.RowCount = 1
        Me.tlp_multimedia.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlp_multimedia.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 393.0!))
        Me.tlp_multimedia.Size = New System.Drawing.Size(754, 393)
        Me.tlp_multimedia.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "#Registro"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Director"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Duración"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 224)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Productora"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 280)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Genero"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 336)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Sinopsis"
        '
        'TextBox1
        '
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Location = New System.Drawing.Point(253, 59)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(244, 22)
        Me.TextBox1.TabIndex = 6
        '
        'TextBox2
        '
        Me.TextBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox2.Location = New System.Drawing.Point(253, 171)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(244, 22)
        Me.TextBox2.TabIndex = 7
        '
        'TextBox3
        '
        Me.TextBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox3.Location = New System.Drawing.Point(253, 227)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(244, 22)
        Me.TextBox3.TabIndex = 8
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(253, 115)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox1.TabIndex = 10
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(253, 283)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox2.TabIndex = 11
        '
        'TextBox4
        '
        Me.TextBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox4.Location = New System.Drawing.Point(253, 339)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(244, 51)
        Me.TextBox4.TabIndex = 12
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Actores, Me.Personaje})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(380, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(371, 387)
        Me.DataGridView1.TabIndex = 0
        '
        'Actores
        '
        Me.Actores.HeaderText = "Actores"
        Me.Actores.MinimumWidth = 6
        Me.Actores.Name = "Actores"
        Me.Actores.Width = 125
        '
        'Personaje
        '
        Me.Personaje.HeaderText = "Personaje"
        Me.Personaje.MinimumWidth = 6
        Me.Personaje.Name = "Personaje"
        Me.Personaje.Width = 125
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(371, 387)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'info_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1272, 450)
        Me.Controls.Add(Me.tlp_Principal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "info_Form"
        Me.Text = "info_Form"
        Me.tlp_Principal.ResumeLayout(False)
        Me.tlp_Content.ResumeLayout(False)
        Me.tlp_WritableContent.ResumeLayout(False)
        Me.tlp_WritableContent.PerformLayout()
        Me.tlp_multimedia.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlp_Principal As TableLayoutPanel
    Friend WithEvents tlp_Content As TableLayoutPanel
    Friend WithEvents tlp_WritableContent As TableLayoutPanel
    Friend WithEvents tlp_multimedia As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Actores As DataGridViewTextBoxColumn
    Friend WithEvents Personaje As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As PictureBox
End Class
