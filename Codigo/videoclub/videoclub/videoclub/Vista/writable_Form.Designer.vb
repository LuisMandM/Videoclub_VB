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
        Me.tlp_Buttons = New System.Windows.Forms.TableLayoutPanel()
        Me.btton_add_Director = New System.Windows.Forms.Button()
        Me.btton_add_Personaje = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btton_Discard = New System.Windows.Forms.Button()
        Me.btton_Save = New System.Windows.Forms.Button()
        Me.creationCtrl = New CreationContentControl.CreationContentControl()
        Me.tlp_Principal.SuspendLayout()
        Me.tlp_DisplayContent.SuspendLayout()
        Me.tlp_Buttons.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlp_Principal
        '
        Me.tlp_Principal.BackColor = System.Drawing.SystemColors.ControlText
        Me.tlp_Principal.ColumnCount = 1
        Me.tlp_Principal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlp_Principal.Controls.Add(Me.tlp_DisplayContent, 0, 0)
        Me.tlp_Principal.Controls.Add(Me.TableLayoutPanel1, 0, 1)
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
        Me.tlp_DisplayContent.Controls.Add(Me.tlp_Buttons, 1, 0)
        Me.tlp_DisplayContent.Controls.Add(Me.creationCtrl, 0, 0)
        Me.tlp_DisplayContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlp_DisplayContent.Location = New System.Drawing.Point(3, 3)
        Me.tlp_DisplayContent.Name = "tlp_DisplayContent"
        Me.tlp_DisplayContent.RowCount = 1
        Me.tlp_DisplayContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlp_DisplayContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 443.0!))
        Me.tlp_DisplayContent.Size = New System.Drawing.Size(1266, 443)
        Me.tlp_DisplayContent.TabIndex = 0
        '
        'tlp_Buttons
        '
        Me.tlp_Buttons.ColumnCount = 1
        Me.tlp_Buttons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlp_Buttons.Controls.Add(Me.btton_add_Director, 0, 2)
        Me.tlp_Buttons.Controls.Add(Me.btton_add_Personaje, 0, 1)
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
        'btton_add_Director
        '
        Me.btton_add_Director.BackColor = System.Drawing.SystemColors.ControlText
        Me.btton_add_Director.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btton_add_Director.Font = New System.Drawing.Font("Courier New", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btton_add_Director.ForeColor = System.Drawing.Color.Yellow
        Me.btton_add_Director.Image = CType(resources.GetObject("btton_add_Director.Image"), System.Drawing.Image)
        Me.btton_add_Director.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btton_add_Director.Location = New System.Drawing.Point(3, 221)
        Me.btton_add_Director.Name = "btton_add_Director"
        Me.btton_add_Director.Size = New System.Drawing.Size(368, 103)
        Me.btton_add_Director.TabIndex = 2
        Me.btton_add_Director.Text = "Añadir Director"
        Me.btton_add_Director.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btton_add_Director.UseVisualStyleBackColor = False
        '
        'btton_add_Personaje
        '
        Me.btton_add_Personaje.BackColor = System.Drawing.SystemColors.ControlText
        Me.btton_add_Personaje.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btton_add_Personaje.Font = New System.Drawing.Font("Courier New", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btton_add_Personaje.ForeColor = System.Drawing.Color.Yellow
        Me.btton_add_Personaje.Image = CType(resources.GetObject("btton_add_Personaje.Image"), System.Drawing.Image)
        Me.btton_add_Personaje.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btton_add_Personaje.Location = New System.Drawing.Point(3, 112)
        Me.btton_add_Personaje.Name = "btton_add_Personaje"
        Me.btton_add_Personaje.Size = New System.Drawing.Size(368, 103)
        Me.btton_add_Personaje.TabIndex = 0
        Me.btton_add_Personaje.Text = "Añadir Personaje"
        Me.btton_add_Personaje.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btton_add_Personaje.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btton_Discard, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btton_Save, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 452)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(416, 44)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'btton_Discard
        '
        Me.btton_Discard.BackColor = System.Drawing.Color.Yellow
        Me.btton_Discard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btton_Discard.Font = New System.Drawing.Font("Courier New", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btton_Discard.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btton_Discard.Location = New System.Drawing.Point(211, 3)
        Me.btton_Discard.Name = "btton_Discard"
        Me.btton_Discard.Size = New System.Drawing.Size(202, 38)
        Me.btton_Discard.TabIndex = 1
        Me.btton_Discard.Text = "Descartar"
        Me.btton_Discard.UseVisualStyleBackColor = False
        '
        'btton_Save
        '
        Me.btton_Save.BackColor = System.Drawing.Color.Yellow
        Me.btton_Save.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btton_Save.Font = New System.Drawing.Font("Courier New", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btton_Save.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btton_Save.Location = New System.Drawing.Point(3, 3)
        Me.btton_Save.Name = "btton_Save"
        Me.btton_Save.Size = New System.Drawing.Size(202, 38)
        Me.btton_Save.TabIndex = 0
        Me.btton_Save.Text = "Guardar"
        Me.btton_Save.UseVisualStyleBackColor = False
        '
        'creationCtrl
        '
        Me.creationCtrl.BackColor = System.Drawing.SystemColors.ControlText
        Me.creationCtrl.DataSource = Nothing
        Me.creationCtrl.director = Nothing
        Me.creationCtrl.DisplayMember1 = ""
        Me.creationCtrl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.creationCtrl.duracion = ""
        Me.creationCtrl.genero = Nothing
        Me.creationCtrl.id = 0
        Me.creationCtrl.Location = New System.Drawing.Point(3, 3)
        Me.creationCtrl.MinimumSize = New System.Drawing.Size(317, 440)
        Me.creationCtrl.Name = "creationCtrl"
        Me.creationCtrl.nombre = ""
        Me.creationCtrl.poster = Nothing
        Me.creationCtrl.productora = ""
        Me.creationCtrl.sinopsis = ""
        Me.creationCtrl.Size = New System.Drawing.Size(880, 440)
        Me.creationCtrl.TabIndex = 2
        Me.creationCtrl.ValueMember1 = ""
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
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlp_Principal As TableLayoutPanel
    Friend WithEvents tlp_DisplayContent As TableLayoutPanel
    Friend WithEvents tlp_Buttons As TableLayoutPanel
    Friend WithEvents btton_add_Personaje As Button
    Friend WithEvents btton_add_Director As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btton_Save As Button
    Friend WithEvents btton_Discard As Button
    Friend WithEvents creationCtrl As CreationContentControl.CreationContentControl
End Class
