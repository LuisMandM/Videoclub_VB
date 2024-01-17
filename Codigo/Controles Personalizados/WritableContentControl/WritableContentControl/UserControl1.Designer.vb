<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WritableContent
    Inherits System.Windows.Forms.UserControl

    'UserControl1 reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.tlp_WritableContent = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbox_Registro = New System.Windows.Forms.TextBox()
        Me.tbox_Duracion = New System.Windows.Forms.TextBox()
        Me.tbox_Productora = New System.Windows.Forms.TextBox()
        Me.tbox_Sinopsis = New System.Windows.Forms.TextBox()
        Me.lbl_Name = New System.Windows.Forms.Label()
        Me.picBox_Poster = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.tbox_Director = New System.Windows.Forms.TextBox()
        Me.tbox_Genero = New System.Windows.Forms.TextBox()
        Me.tlp_Principal.SuspendLayout()
        Me.tlp_WritableContent.SuspendLayout()
        CType(Me.picBox_Poster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlp_Principal
        '
        Me.tlp_Principal.ColumnCount = 2
        Me.tlp_Principal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.tlp_Principal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.tlp_Principal.Controls.Add(Me.tlp_WritableContent, 0, 0)
        Me.tlp_Principal.Controls.Add(Me.picBox_Poster, 1, 0)
        Me.tlp_Principal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlp_Principal.Location = New System.Drawing.Point(0, 0)
        Me.tlp_Principal.Name = "tlp_Principal"
        Me.tlp_Principal.RowCount = 1
        Me.tlp_Principal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlp_Principal.Size = New System.Drawing.Size(867, 470)
        Me.tlp_Principal.TabIndex = 0
        '
        'tlp_WritableContent
        '
        Me.tlp_WritableContent.ColumnCount = 2
        Me.tlp_WritableContent.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tlp_WritableContent.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.tlp_WritableContent.Controls.Add(Me.Label2, 0, 1)
        Me.tlp_WritableContent.Controls.Add(Me.Label3, 0, 2)
        Me.tlp_WritableContent.Controls.Add(Me.Label4, 0, 3)
        Me.tlp_WritableContent.Controls.Add(Me.Label5, 0, 4)
        Me.tlp_WritableContent.Controls.Add(Me.Label6, 0, 5)
        Me.tlp_WritableContent.Controls.Add(Me.Label7, 0, 6)
        Me.tlp_WritableContent.Controls.Add(Me.tbox_Registro, 1, 1)
        Me.tlp_WritableContent.Controls.Add(Me.tbox_Duracion, 1, 3)
        Me.tlp_WritableContent.Controls.Add(Me.tbox_Productora, 1, 4)
        Me.tlp_WritableContent.Controls.Add(Me.tbox_Sinopsis, 1, 6)
        Me.tlp_WritableContent.Controls.Add(Me.lbl_Name, 1, 0)
        Me.tlp_WritableContent.Controls.Add(Me.tbox_Director, 1, 2)
        Me.tlp_WritableContent.Controls.Add(Me.tbox_Genero, 1, 5)
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
        Me.tlp_WritableContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlp_WritableContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlp_WritableContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlp_WritableContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlp_WritableContent.Size = New System.Drawing.Size(514, 464)
        Me.tlp_WritableContent.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(3, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 30)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "#Registro"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(3, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 30)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Director"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(3, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 30)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Duración"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(3, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(148, 30)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Productora"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Yellow
        Me.Label6.Location = New System.Drawing.Point(3, 182)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(148, 30)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Genero"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Yellow
        Me.Label7.Location = New System.Drawing.Point(3, 212)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(148, 252)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Sinopsis"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbox_Registro
        '
        Me.tbox_Registro.BackColor = System.Drawing.Color.DimGray
        Me.tbox_Registro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbox_Registro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbox_Registro.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbox_Registro.ForeColor = System.Drawing.SystemColors.Window
        Me.tbox_Registro.Location = New System.Drawing.Point(157, 65)
        Me.tbox_Registro.Name = "tbox_Registro"
        Me.tbox_Registro.Size = New System.Drawing.Size(354, 24)
        Me.tbox_Registro.TabIndex = 7
        '
        'tbox_Duracion
        '
        Me.tbox_Duracion.BackColor = System.Drawing.Color.DimGray
        Me.tbox_Duracion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbox_Duracion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbox_Duracion.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbox_Duracion.ForeColor = System.Drawing.SystemColors.Window
        Me.tbox_Duracion.Location = New System.Drawing.Point(157, 125)
        Me.tbox_Duracion.Name = "tbox_Duracion"
        Me.tbox_Duracion.Size = New System.Drawing.Size(354, 24)
        Me.tbox_Duracion.TabIndex = 9
        '
        'tbox_Productora
        '
        Me.tbox_Productora.BackColor = System.Drawing.Color.DimGray
        Me.tbox_Productora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbox_Productora.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbox_Productora.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbox_Productora.ForeColor = System.Drawing.SystemColors.Window
        Me.tbox_Productora.Location = New System.Drawing.Point(157, 155)
        Me.tbox_Productora.Name = "tbox_Productora"
        Me.tbox_Productora.Size = New System.Drawing.Size(354, 24)
        Me.tbox_Productora.TabIndex = 10
        '
        'tbox_Sinopsis
        '
        Me.tbox_Sinopsis.BackColor = System.Drawing.Color.DimGray
        Me.tbox_Sinopsis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbox_Sinopsis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbox_Sinopsis.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbox_Sinopsis.ForeColor = System.Drawing.SystemColors.Window
        Me.tbox_Sinopsis.Location = New System.Drawing.Point(157, 215)
        Me.tbox_Sinopsis.Multiline = True
        Me.tbox_Sinopsis.Name = "tbox_Sinopsis"
        Me.tbox_Sinopsis.Size = New System.Drawing.Size(354, 246)
        Me.tbox_Sinopsis.TabIndex = 12
        '
        'lbl_Name
        '
        Me.lbl_Name.AutoSize = True
        Me.lbl_Name.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Name.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Name.ForeColor = System.Drawing.Color.Yellow
        Me.lbl_Name.Location = New System.Drawing.Point(157, 0)
        Me.lbl_Name.Name = "lbl_Name"
        Me.lbl_Name.Size = New System.Drawing.Size(354, 62)
        Me.lbl_Name.TabIndex = 15
        Me.lbl_Name.Text = "Movie"
        Me.lbl_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picBox_Poster
        '
        Me.picBox_Poster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picBox_Poster.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picBox_Poster.InitialImage = Nothing
        Me.picBox_Poster.Location = New System.Drawing.Point(535, 15)
        Me.picBox_Poster.Margin = New System.Windows.Forms.Padding(15)
        Me.picBox_Poster.Name = "picBox_Poster"
        Me.picBox_Poster.Size = New System.Drawing.Size(317, 440)
        Me.picBox_Poster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBox_Poster.TabIndex = 1
        Me.picBox_Poster.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'tbox_Director
        '
        Me.tbox_Director.BackColor = System.Drawing.Color.DimGray
        Me.tbox_Director.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbox_Director.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbox_Director.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbox_Director.ForeColor = System.Drawing.SystemColors.Window
        Me.tbox_Director.Location = New System.Drawing.Point(157, 95)
        Me.tbox_Director.Name = "tbox_Director"
        Me.tbox_Director.Size = New System.Drawing.Size(354, 24)
        Me.tbox_Director.TabIndex = 16
        '
        'tbox_Genero
        '
        Me.tbox_Genero.BackColor = System.Drawing.Color.DimGray
        Me.tbox_Genero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbox_Genero.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbox_Genero.ForeColor = System.Drawing.SystemColors.Window
        Me.tbox_Genero.Location = New System.Drawing.Point(157, 185)
        Me.tbox_Genero.Name = "tbox_Genero"
        Me.tbox_Genero.Size = New System.Drawing.Size(354, 24)
        Me.tbox_Genero.TabIndex = 17
        '
        'WritableContent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlText
        Me.Controls.Add(Me.tlp_Principal)
        Me.Name = "WritableContent"
        Me.Size = New System.Drawing.Size(867, 470)
        Me.tlp_Principal.ResumeLayout(False)
        Me.tlp_WritableContent.ResumeLayout(False)
        Me.tlp_WritableContent.PerformLayout()
        CType(Me.picBox_Poster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlp_Principal As TableLayoutPanel
    Friend WithEvents tlp_WritableContent As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents tbox_Registro As TextBox
    Friend WithEvents tbox_Duracion As TextBox
    Friend WithEvents tbox_Productora As TextBox
    Friend WithEvents tbox_Sinopsis As TextBox
    Friend WithEvents picBox_Poster As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents lbl_Name As Label
    Friend WithEvents tbox_Director As TextBox
    Friend WithEvents tbox_Genero As TextBox
End Class
