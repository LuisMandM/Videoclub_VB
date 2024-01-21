<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Form))
        Me.mstrip_Main = New System.Windows.Forms.MenuStrip()
        Me.smi_Visualizar = New System.Windows.Forms.ToolStripMenuItem()
        Me.smi_Crear = New System.Windows.Forms.ToolStripMenuItem()
        Me.smi_Pelicula = New System.Windows.Forms.ToolStripMenuItem()
        Me.smi_Actor = New System.Windows.Forms.ToolStripMenuItem()
        Me.smi_Director = New System.Windows.Forms.ToolStripMenuItem()
        Me.mstrip_Main.SuspendLayout()
        Me.SuspendLayout()
        '
        'mstrip_Main
        '
        Me.mstrip_Main.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mstrip_Main.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.smi_Visualizar, Me.smi_Crear})
        Me.mstrip_Main.Location = New System.Drawing.Point(0, 0)
        Me.mstrip_Main.Name = "mstrip_Main"
        Me.mstrip_Main.Size = New System.Drawing.Size(1282, 28)
        Me.mstrip_Main.TabIndex = 0
        Me.mstrip_Main.Text = "MenuStrip1"
        '
        'smi_Visualizar
        '
        Me.smi_Visualizar.Name = "smi_Visualizar"
        Me.smi_Visualizar.Size = New System.Drawing.Size(86, 24)
        Me.smi_Visualizar.Text = "Visualizar"
        '
        'smi_Crear
        '
        Me.smi_Crear.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.smi_Pelicula, Me.smi_Actor, Me.smi_Director})
        Me.smi_Crear.Name = "smi_Crear"
        Me.smi_Crear.Size = New System.Drawing.Size(58, 24)
        Me.smi_Crear.Text = "Crear"
        '
        'smi_Pelicula
        '
        Me.smi_Pelicula.Name = "smi_Pelicula"
        Me.smi_Pelicula.Size = New System.Drawing.Size(146, 26)
        Me.smi_Pelicula.Text = "Pelicula"
        '
        'smi_Actor
        '
        Me.smi_Actor.Name = "smi_Actor"
        Me.smi_Actor.Size = New System.Drawing.Size(146, 26)
        Me.smi_Actor.Text = "Actor"
        '
        'smi_Director
        '
        Me.smi_Director.Name = "smi_Director"
        Me.smi_Director.Size = New System.Drawing.Size(146, 26)
        Me.smi_Director.Text = "Director"
        '
        'Main_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1282, 553)
        Me.Controls.Add(Me.mstrip_Main)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mstrip_Main
        Me.MaximumSize = New System.Drawing.Size(1300, 600)
        Me.MinimumSize = New System.Drawing.Size(1300, 600)
        Me.Name = "Main_Form"
        Me.Text = "Main_Form"
        Me.mstrip_Main.ResumeLayout(False)
        Me.mstrip_Main.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mstrip_Main As MenuStrip
    Friend WithEvents smi_Visualizar As ToolStripMenuItem
    Friend WithEvents smi_Crear As ToolStripMenuItem
    Friend WithEvents smi_Pelicula As ToolStripMenuItem
    Friend WithEvents smi_Actor As ToolStripMenuItem
    Friend WithEvents smi_Director As ToolStripMenuItem
End Class
