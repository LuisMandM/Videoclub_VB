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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.cbox_1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.picBox = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.tlp_Principal.SuspendLayout()
        Me.tlp_WritableContent.SuspendLayout()
        CType(Me.picBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlp_Principal
        '
        Me.tlp_Principal.ColumnCount = 2
        Me.tlp_Principal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.tlp_Principal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.tlp_Principal.Controls.Add(Me.tlp_WritableContent, 0, 0)
        Me.tlp_Principal.Controls.Add(Me.picBox, 1, 0)
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
        Me.tlp_WritableContent.Controls.Add(Me.TextBox1, 1, 1)
        Me.tlp_WritableContent.Controls.Add(Me.TextBox3, 1, 3)
        Me.tlp_WritableContent.Controls.Add(Me.TextBox4, 1, 4)
        Me.tlp_WritableContent.Controls.Add(Me.TextBox6, 1, 6)
        Me.tlp_WritableContent.Controls.Add(Me.cbox_1, 1, 2)
        Me.tlp_WritableContent.Controls.Add(Me.ComboBox2, 1, 5)
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
        Me.Label3.Size = New System.Drawing.Size(148, 31)
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
        Me.Label4.Location = New System.Drawing.Point(3, 123)
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
        Me.Label5.Location = New System.Drawing.Point(3, 153)
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
        Me.Label6.Location = New System.Drawing.Point(3, 183)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(148, 31)
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
        Me.Label7.Location = New System.Drawing.Point(3, 214)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(148, 250)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Sinopsis"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.DimGray
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBox1.Location = New System.Drawing.Point(157, 65)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(354, 24)
        Me.TextBox1.TabIndex = 7
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.DimGray
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox3.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBox3.Location = New System.Drawing.Point(157, 126)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(354, 24)
        Me.TextBox3.TabIndex = 9
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.DimGray
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox4.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBox4.Location = New System.Drawing.Point(157, 156)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(354, 24)
        Me.TextBox4.TabIndex = 10
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.DimGray
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox6.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBox6.Location = New System.Drawing.Point(157, 217)
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(354, 244)
        Me.TextBox6.TabIndex = 12
        '
        'cbox_1
        '
        Me.cbox_1.BackColor = System.Drawing.Color.DimGray
        Me.cbox_1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbox_1.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbox_1.ForeColor = System.Drawing.SystemColors.Window
        Me.cbox_1.FormattingEnabled = True
        Me.cbox_1.Location = New System.Drawing.Point(157, 95)
        Me.cbox_1.Name = "cbox_1"
        Me.cbox_1.Size = New System.Drawing.Size(354, 25)
        Me.cbox_1.TabIndex = 13
        '
        'ComboBox2
        '
        Me.ComboBox2.BackColor = System.Drawing.Color.DimGray
        Me.ComboBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBox2.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.ForeColor = System.Drawing.SystemColors.Window
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(157, 186)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(354, 25)
        Me.ComboBox2.TabIndex = 14
        '
        'picBox
        '
        Me.picBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picBox.InitialImage = Nothing
        Me.picBox.Location = New System.Drawing.Point(535, 15)
        Me.picBox.Margin = New System.Windows.Forms.Padding(15)
        Me.picBox.Name = "picBox"
        Me.picBox.Size = New System.Drawing.Size(317, 440)
        Me.picBox.TabIndex = 1
        Me.picBox.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
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
        CType(Me.picBox, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents cbox_1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents picBox As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
