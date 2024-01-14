<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class writable_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(writable_Form))
        Me.tlp_Principal = New System.Windows.Forms.TableLayoutPanel()
        Me.tlp_DisplayContent = New System.Windows.Forms.TableLayoutPanel()
        Me.WritableContent1 = New WritableContentControl.WritableContent()
        Me.tlp_Buttons = New System.Windows.Forms.TableLayoutPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.tlp_Principal.SuspendLayout()
        Me.tlp_DisplayContent.SuspendLayout()
        Me.tlp_Buttons.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlp_Principal
        '
        Me.tlp_Principal.BackColor = System.Drawing.SystemColors.ControlText
        Me.tlp_Principal.ColumnCount = 1
        Me.tlp_Principal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlp_Principal.Controls.Add(Me.tlp_DisplayContent, 0, 0)
        Me.tlp_Principal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlp_Principal.Location = New System.Drawing.Point(0, 0)
        Me.tlp_Principal.Name = "tlp_Principal"
        Me.tlp_Principal.RowCount = 2
        Me.tlp_Principal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.0!))
        Me.tlp_Principal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlp_Principal.Size = New System.Drawing.Size(1272, 499)
        Me.tlp_Principal.TabIndex = 0
        '
        'tlp_DisplayContent
        '
        Me.tlp_DisplayContent.ColumnCount = 2
        Me.tlp_DisplayContent.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.tlp_DisplayContent.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tlp_DisplayContent.Controls.Add(Me.WritableContent1, 0, 0)
        Me.tlp_DisplayContent.Controls.Add(Me.tlp_Buttons, 1, 0)
        Me.tlp_DisplayContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlp_DisplayContent.Location = New System.Drawing.Point(3, 3)
        Me.tlp_DisplayContent.Name = "tlp_DisplayContent"
        Me.tlp_DisplayContent.RowCount = 1
        Me.tlp_DisplayContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlp_DisplayContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlp_DisplayContent.Size = New System.Drawing.Size(1266, 443)
        Me.tlp_DisplayContent.TabIndex = 0
        '
        'WritableContent1
        '
        Me.WritableContent1.BackColor = System.Drawing.SystemColors.ControlText
        Me.WritableContent1.DataSource = Nothing
        Me.WritableContent1.DisplayMember1 = ""
        Me.WritableContent1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WritableContent1.Location = New System.Drawing.Point(3, 3)
        Me.WritableContent1.MinimumSize = New System.Drawing.Size(317, 440)
        Me.WritableContent1.Name = "WritableContent1"
        Me.WritableContent1.Size = New System.Drawing.Size(880, 440)
        Me.WritableContent1.TabIndex = 0
        Me.WritableContent1.ValueMember1 = ""
        '
        'tlp_Buttons
        '
        Me.tlp_Buttons.ColumnCount = 1
        Me.tlp_Buttons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlp_Buttons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlp_Buttons.Controls.Add(Me.Button3, 0, 2)
        Me.tlp_Buttons.Controls.Add(Me.Button1, 0, 1)
        Me.tlp_Buttons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlp_Buttons.Location = New System.Drawing.Point(889, 3)
        Me.tlp_Buttons.Name = "tlp_Buttons"
        Me.tlp_Buttons.RowCount = 4
        Me.tlp_Buttons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlp_Buttons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlp_Buttons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlp_Buttons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlp_Buttons.Size = New System.Drawing.Size(374, 437)
        Me.tlp_Buttons.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.Font = New System.Drawing.Font("Courier New", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Yellow
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(3, 112)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(368, 103)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Añadir Personaje"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ControlText
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button3.Font = New System.Drawing.Font("Courier New", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Yellow
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(3, 221)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(368, 103)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Añadir Director"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = False
        '
        'writable_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1272, 499)
        Me.Controls.Add(Me.tlp_Principal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(1272, 499)
        Me.Name = "writable_Form"
        Me.Text = "writable_Form"
        Me.tlp_Principal.ResumeLayout(False)
        Me.tlp_DisplayContent.ResumeLayout(False)
        Me.tlp_Buttons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlp_Principal As TableLayoutPanel
    Friend WithEvents tlp_DisplayContent As TableLayoutPanel
    Friend WithEvents WritableContent1 As WritableContentControl.WritableContent
    Friend WithEvents tlp_Buttons As TableLayoutPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
End Class
