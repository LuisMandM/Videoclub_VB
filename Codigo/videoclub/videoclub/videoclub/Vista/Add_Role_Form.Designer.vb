<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Role_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Add_Role_Form))
        Me.tlp_Principal = New System.Windows.Forms.TableLayoutPanel()
        Me.btton_Create = New System.Windows.Forms.Button()
        Me.btton_Save = New System.Windows.Forms.Button()
        Me.tlp_Form = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_Actor = New System.Windows.Forms.Label()
        Me.lbl_Role = New System.Windows.Forms.Label()
        Me.cbox_Actor = New System.Windows.Forms.ComboBox()
        Me.tbox_Role = New System.Windows.Forms.TextBox()
        Me.tlp_Principal.SuspendLayout()
        Me.tlp_Form.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlp_Principal
        '
        Me.tlp_Principal.BackColor = System.Drawing.SystemColors.ControlText
        Me.tlp_Principal.ColumnCount = 2
        Me.tlp_Principal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlp_Principal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlp_Principal.Controls.Add(Me.btton_Create, 0, 3)
        Me.tlp_Principal.Controls.Add(Me.btton_Save, 1, 3)
        Me.tlp_Principal.Controls.Add(Me.tlp_Form, 0, 1)
        Me.tlp_Principal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlp_Principal.Location = New System.Drawing.Point(0, 0)
        Me.tlp_Principal.Name = "tlp_Principal"
        Me.tlp_Principal.RowCount = 5
        Me.tlp_Principal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlp_Principal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlp_Principal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlp_Principal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlp_Principal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlp_Principal.Size = New System.Drawing.Size(585, 271)
        Me.tlp_Principal.TabIndex = 0
        '
        'btton_Create
        '
        Me.btton_Create.BackColor = System.Drawing.Color.Yellow
        Me.btton_Create.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btton_Create.Font = New System.Drawing.Font("Courier New", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btton_Create.Location = New System.Drawing.Point(3, 165)
        Me.btton_Create.Name = "btton_Create"
        Me.btton_Create.Size = New System.Drawing.Size(286, 48)
        Me.btton_Create.TabIndex = 2
        Me.btton_Create.Text = "Crear Actor"
        Me.btton_Create.UseVisualStyleBackColor = False
        '
        'btton_Save
        '
        Me.btton_Save.BackColor = System.Drawing.Color.Yellow
        Me.btton_Save.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btton_Save.Font = New System.Drawing.Font("Courier New", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btton_Save.Location = New System.Drawing.Point(295, 165)
        Me.btton_Save.Name = "btton_Save"
        Me.btton_Save.Size = New System.Drawing.Size(287, 48)
        Me.btton_Save.TabIndex = 5
        Me.btton_Save.Text = "Guardar"
        Me.btton_Save.UseVisualStyleBackColor = False
        '
        'tlp_Form
        '
        Me.tlp_Form.ColumnCount = 2
        Me.tlp_Principal.SetColumnSpan(Me.tlp_Form, 2)
        Me.tlp_Form.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlp_Form.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlp_Form.Controls.Add(Me.lbl_Actor, 0, 1)
        Me.tlp_Form.Controls.Add(Me.lbl_Role, 0, 2)
        Me.tlp_Form.Controls.Add(Me.cbox_Actor, 1, 1)
        Me.tlp_Form.Controls.Add(Me.tbox_Role, 1, 2)
        Me.tlp_Form.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlp_Form.Location = New System.Drawing.Point(3, 57)
        Me.tlp_Form.Name = "tlp_Form"
        Me.tlp_Form.RowCount = 4
        Me.tlp_Principal.SetRowSpan(Me.tlp_Form, 2)
        Me.tlp_Form.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlp_Form.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlp_Form.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlp_Form.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlp_Form.Size = New System.Drawing.Size(579, 102)
        Me.tlp_Form.TabIndex = 6
        '
        'lbl_Actor
        '
        Me.lbl_Actor.AutoSize = True
        Me.lbl_Actor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Actor.Font = New System.Drawing.Font("Courier New", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Actor.ForeColor = System.Drawing.Color.Yellow
        Me.lbl_Actor.Location = New System.Drawing.Point(3, 20)
        Me.lbl_Actor.Name = "lbl_Actor"
        Me.lbl_Actor.Size = New System.Drawing.Size(79, 31)
        Me.lbl_Actor.TabIndex = 0
        Me.lbl_Actor.Text = "Actor"
        '
        'lbl_Role
        '
        Me.lbl_Role.AutoSize = True
        Me.lbl_Role.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Role.Font = New System.Drawing.Font("Courier New", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Role.ForeColor = System.Drawing.Color.Yellow
        Me.lbl_Role.Location = New System.Drawing.Point(3, 51)
        Me.lbl_Role.Name = "lbl_Role"
        Me.lbl_Role.Size = New System.Drawing.Size(79, 30)
        Me.lbl_Role.TabIndex = 1
        Me.lbl_Role.Text = "Personaje"
        '
        'cbox_Actor
        '
        Me.cbox_Actor.BackColor = System.Drawing.Color.DimGray
        Me.cbox_Actor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbox_Actor.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbox_Actor.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cbox_Actor.FormattingEnabled = True
        Me.cbox_Actor.Location = New System.Drawing.Point(88, 23)
        Me.cbox_Actor.Name = "cbox_Actor"
        Me.cbox_Actor.Size = New System.Drawing.Size(488, 25)
        Me.cbox_Actor.TabIndex = 2
        '
        'tbox_Role
        '
        Me.tbox_Role.BackColor = System.Drawing.Color.DimGray
        Me.tbox_Role.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbox_Role.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbox_Role.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.tbox_Role.Location = New System.Drawing.Point(88, 54)
        Me.tbox_Role.Name = "tbox_Role"
        Me.tbox_Role.Size = New System.Drawing.Size(488, 24)
        Me.tbox_Role.TabIndex = 3
        '
        'Add_Role_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(585, 271)
        Me.Controls.Add(Me.tlp_Principal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(620, 318)
        Me.MinimumSize = New System.Drawing.Size(603, 318)
        Me.Name = "Add_Role_Form"
        Me.Text = "Añadir Personaje"
        Me.tlp_Principal.ResumeLayout(False)
        Me.tlp_Form.ResumeLayout(False)
        Me.tlp_Form.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlp_Principal As TableLayoutPanel
    Friend WithEvents btton_Create As Button
    Friend WithEvents btton_Save As Button
    Friend WithEvents tlp_Form As TableLayoutPanel
    Friend WithEvents lbl_Actor As Label
    Friend WithEvents lbl_Role As Label
    Friend WithEvents cbox_Actor As ComboBox
    Friend WithEvents tbox_Role As TextBox
End Class
