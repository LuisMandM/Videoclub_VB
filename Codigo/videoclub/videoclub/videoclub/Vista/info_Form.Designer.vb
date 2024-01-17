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
        Me.tlp_DisplayControls = New System.Windows.Forms.TableLayoutPanel()
        Me.wcontent = New WritableContentControl.WritableContent()
        Me.dataGrid_Roles = New System.Windows.Forms.DataGridView()
        Me.btton_Close = New System.Windows.Forms.Button()
        Me.tlp_Principal.SuspendLayout()
        Me.tlp_DisplayControls.SuspendLayout()
        CType(Me.dataGrid_Roles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlp_Principal
        '
        Me.tlp_Principal.BackColor = System.Drawing.SystemColors.ControlText
        Me.tlp_Principal.ColumnCount = 1
        Me.tlp_Principal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlp_Principal.Controls.Add(Me.tlp_DisplayControls, 0, 0)
        Me.tlp_Principal.Controls.Add(Me.btton_Close, 0, 1)
        Me.tlp_Principal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlp_Principal.Location = New System.Drawing.Point(0, 0)
        Me.tlp_Principal.Name = "tlp_Principal"
        Me.tlp_Principal.RowCount = 2
        Me.tlp_Principal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.0!))
        Me.tlp_Principal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlp_Principal.Size = New System.Drawing.Size(1272, 499)
        Me.tlp_Principal.TabIndex = 0
        '
        'tlp_DisplayControls
        '
        Me.tlp_DisplayControls.ColumnCount = 2
        Me.tlp_DisplayControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.tlp_DisplayControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tlp_DisplayControls.Controls.Add(Me.wcontent, 0, 0)
        Me.tlp_DisplayControls.Controls.Add(Me.dataGrid_Roles, 1, 0)
        Me.tlp_DisplayControls.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlp_DisplayControls.Location = New System.Drawing.Point(3, 3)
        Me.tlp_DisplayControls.Name = "tlp_DisplayControls"
        Me.tlp_DisplayControls.RowCount = 1
        Me.tlp_DisplayControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlp_DisplayControls.Size = New System.Drawing.Size(1266, 443)
        Me.tlp_DisplayControls.TabIndex = 0
        '
        'wcontent
        '
        Me.wcontent.BackColor = System.Drawing.SystemColors.ControlText
        Me.wcontent.director = Nothing
        Me.wcontent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wcontent.duracion = ""
        Me.wcontent.genero = Nothing
        Me.wcontent.Location = New System.Drawing.Point(3, 3)
        Me.wcontent.MinimumSize = New System.Drawing.Size(317, 440)
        Me.wcontent.Name = "wcontent"
        Me.wcontent.nombre = "Movie"
        Me.wcontent.poster = Nothing
        Me.wcontent.productora = ""
        Me.wcontent.registro = ""
        Me.wcontent.sinopsis = ""
        Me.wcontent.Size = New System.Drawing.Size(880, 440)
        Me.wcontent.TabIndex = 0
        '
        'dataGrid_Roles
        '
        Me.dataGrid_Roles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGrid_Roles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataGrid_Roles.Location = New System.Drawing.Point(889, 3)
        Me.dataGrid_Roles.Name = "dataGrid_Roles"
        Me.dataGrid_Roles.RowHeadersWidth = 51
        Me.dataGrid_Roles.RowTemplate.Height = 24
        Me.dataGrid_Roles.Size = New System.Drawing.Size(374, 437)
        Me.dataGrid_Roles.TabIndex = 1
        '
        'btton_Close
        '
        Me.btton_Close.BackColor = System.Drawing.Color.Yellow
        Me.btton_Close.Dock = System.Windows.Forms.DockStyle.Left
        Me.btton_Close.Font = New System.Drawing.Font("Courier New", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btton_Close.Location = New System.Drawing.Point(3, 452)
        Me.btton_Close.Name = "btton_Close"
        Me.btton_Close.Size = New System.Drawing.Size(150, 44)
        Me.btton_Close.TabIndex = 1
        Me.btton_Close.Text = "Cerrar"
        Me.btton_Close.UseVisualStyleBackColor = False
        '
        'info_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1272, 499)
        Me.Controls.Add(Me.tlp_Principal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(1272, 499)
        Me.Name = "info_Form"
        Me.Text = "info_Form"
        Me.tlp_Principal.ResumeLayout(False)
        Me.tlp_DisplayControls.ResumeLayout(False)
        CType(Me.dataGrid_Roles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlp_Principal As TableLayoutPanel
    Friend WithEvents tlp_DisplayControls As TableLayoutPanel
    Friend WithEvents wcontent As WritableContentControl.WritableContent
    Friend WithEvents dataGrid_Roles As DataGridView
    Friend WithEvents btton_Close As Button
End Class
