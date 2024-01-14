<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetailView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DetailView))
        Me.tlp_Principal = New System.Windows.Forms.TableLayoutPanel()
        Me.tlp_Media = New System.Windows.Forms.TableLayoutPanel()
        Me.picBox = New System.Windows.Forms.PictureBox()
        Me.lbl_Title = New System.Windows.Forms.Label()
        Me.tlp_Buttons = New System.Windows.Forms.TableLayoutPanel()
        Me.btton_View = New System.Windows.Forms.Button()
        Me.btton_Edit = New System.Windows.Forms.Button()
        Me.btton_Delete = New System.Windows.Forms.Button()
        Me.tbox_Content = New System.Windows.Forms.TextBox()
        Me.tlp_Principal.SuspendLayout()
        Me.tlp_Media.SuspendLayout()
        CType(Me.picBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlp_Buttons.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlp_Principal
        '
        Me.tlp_Principal.BackColor = System.Drawing.SystemColors.Desktop
        Me.tlp_Principal.ColumnCount = 3
        Me.tlp_Principal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlp_Principal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlp_Principal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tlp_Principal.Controls.Add(Me.tlp_Media, 0, 0)
        Me.tlp_Principal.Controls.Add(Me.tlp_Buttons, 2, 0)
        Me.tlp_Principal.Controls.Add(Me.tbox_Content, 1, 0)
        Me.tlp_Principal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlp_Principal.Location = New System.Drawing.Point(0, 0)
        Me.tlp_Principal.Name = "tlp_Principal"
        Me.tlp_Principal.RowCount = 1
        Me.tlp_Principal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlp_Principal.Size = New System.Drawing.Size(1272, 170)
        Me.tlp_Principal.TabIndex = 0
        '
        'tlp_Media
        '
        Me.tlp_Media.ColumnCount = 1
        Me.tlp_Media.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlp_Media.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlp_Media.Controls.Add(Me.picBox, 0, 0)
        Me.tlp_Media.Controls.Add(Me.lbl_Title, 0, 1)
        Me.tlp_Media.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlp_Media.Location = New System.Drawing.Point(3, 3)
        Me.tlp_Media.Name = "tlp_Media"
        Me.tlp_Media.RowCount = 2
        Me.tlp_Media.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.tlp_Media.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tlp_Media.Size = New System.Drawing.Size(248, 164)
        Me.tlp_Media.TabIndex = 0
        '
        'picBox
        '
        Me.picBox.BackColor = System.Drawing.Color.DimGray
        Me.picBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picBox.Location = New System.Drawing.Point(50, 15)
        Me.picBox.Margin = New System.Windows.Forms.Padding(50, 15, 50, 3)
        Me.picBox.Name = "picBox"
        Me.picBox.Size = New System.Drawing.Size(148, 96)
        Me.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBox.TabIndex = 0
        Me.picBox.TabStop = False
        '
        'lbl_Title
        '
        Me.lbl_Title.AutoSize = True
        Me.lbl_Title.BackColor = System.Drawing.SystemColors.ControlText
        Me.lbl_Title.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Title.Font = New System.Drawing.Font("Courier New", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Title.ForeColor = System.Drawing.Color.Yellow
        Me.lbl_Title.Location = New System.Drawing.Point(3, 114)
        Me.lbl_Title.Name = "lbl_Title"
        Me.lbl_Title.Size = New System.Drawing.Size(242, 50)
        Me.lbl_Title.TabIndex = 1
        Me.lbl_Title.Text = "Title"
        Me.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tlp_Buttons
        '
        Me.tlp_Buttons.ColumnCount = 5
        Me.tlp_Buttons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.tlp_Buttons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlp_Buttons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlp_Buttons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlp_Buttons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.tlp_Buttons.Controls.Add(Me.btton_View, 1, 1)
        Me.tlp_Buttons.Controls.Add(Me.btton_Edit, 2, 1)
        Me.tlp_Buttons.Controls.Add(Me.btton_Delete, 3, 1)
        Me.tlp_Buttons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlp_Buttons.Location = New System.Drawing.Point(893, 3)
        Me.tlp_Buttons.Name = "tlp_Buttons"
        Me.tlp_Buttons.RowCount = 3
        Me.tlp_Buttons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlp_Buttons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlp_Buttons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlp_Buttons.Size = New System.Drawing.Size(376, 164)
        Me.tlp_Buttons.TabIndex = 1
        '
        'btton_View
        '
        Me.btton_View.BackColor = System.Drawing.Color.Yellow
        Me.btton_View.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btton_View.Image = CType(resources.GetObject("btton_View.Image"), System.Drawing.Image)
        Me.btton_View.Location = New System.Drawing.Point(50, 57)
        Me.btton_View.Name = "btton_View"
        Me.btton_View.Size = New System.Drawing.Size(88, 48)
        Me.btton_View.TabIndex = 0
        Me.btton_View.UseVisualStyleBackColor = False
        '
        'btton_Edit
        '
        Me.btton_Edit.BackColor = System.Drawing.Color.Yellow
        Me.btton_Edit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btton_Edit.Image = CType(resources.GetObject("btton_Edit.Image"), System.Drawing.Image)
        Me.btton_Edit.Location = New System.Drawing.Point(144, 57)
        Me.btton_Edit.Name = "btton_Edit"
        Me.btton_Edit.Size = New System.Drawing.Size(88, 48)
        Me.btton_Edit.TabIndex = 1
        Me.btton_Edit.UseVisualStyleBackColor = False
        '
        'btton_Delete
        '
        Me.btton_Delete.BackColor = System.Drawing.Color.Yellow
        Me.btton_Delete.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btton_Delete.Image = CType(resources.GetObject("btton_Delete.Image"), System.Drawing.Image)
        Me.btton_Delete.Location = New System.Drawing.Point(238, 57)
        Me.btton_Delete.Name = "btton_Delete"
        Me.btton_Delete.Size = New System.Drawing.Size(88, 48)
        Me.btton_Delete.TabIndex = 2
        Me.btton_Delete.UseVisualStyleBackColor = False
        '
        'tbox_Content
        '
        Me.tbox_Content.BackColor = System.Drawing.SystemColors.ControlText
        Me.tbox_Content.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbox_Content.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbox_Content.Enabled = False
        Me.tbox_Content.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbox_Content.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.tbox_Content.Location = New System.Drawing.Point(274, 20)
        Me.tbox_Content.Margin = New System.Windows.Forms.Padding(20)
        Me.tbox_Content.Multiline = True
        Me.tbox_Content.Name = "tbox_Content"
        Me.tbox_Content.Size = New System.Drawing.Size(596, 130)
        Me.tbox_Content.TabIndex = 2
        '
        'DetailView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tlp_Principal)
        Me.Name = "DetailView"
        Me.Size = New System.Drawing.Size(1272, 170)
        Me.tlp_Principal.ResumeLayout(False)
        Me.tlp_Principal.PerformLayout()
        Me.tlp_Media.ResumeLayout(False)
        Me.tlp_Media.PerformLayout()
        CType(Me.picBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlp_Buttons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlp_Principal As TableLayoutPanel
    Friend WithEvents tlp_Media As TableLayoutPanel
    Friend WithEvents picBox As PictureBox
    Friend WithEvents lbl_Title As Label
    Friend WithEvents tlp_Buttons As TableLayoutPanel
    Friend WithEvents btton_View As Button
    Friend WithEvents btton_Edit As Button
    Friend WithEvents btton_Delete As Button
    Friend WithEvents tbox_Content As TextBox
End Class
