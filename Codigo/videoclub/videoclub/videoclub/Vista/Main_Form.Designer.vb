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
        Me.mstrip_Main = New System.Windows.Forms.MenuStrip()
        Me.VisualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mstrip_Main.SuspendLayout()
        Me.SuspendLayout()
        '
        'mstrip_Main
        '
        Me.mstrip_Main.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mstrip_Main.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VisualizarToolStripMenuItem, Me.CrearToolStripMenuItem})
        Me.mstrip_Main.Location = New System.Drawing.Point(0, 0)
        Me.mstrip_Main.Name = "mstrip_Main"
        Me.mstrip_Main.Size = New System.Drawing.Size(800, 28)
        Me.mstrip_Main.TabIndex = 0
        Me.mstrip_Main.Text = "MenuStrip1"
        '
        'VisualizarToolStripMenuItem
        '
        Me.VisualizarToolStripMenuItem.Name = "VisualizarToolStripMenuItem"
        Me.VisualizarToolStripMenuItem.Size = New System.Drawing.Size(86, 24)
        Me.VisualizarToolStripMenuItem.Text = "Visualizar"
        '
        'CrearToolStripMenuItem
        '
        Me.CrearToolStripMenuItem.Name = "CrearToolStripMenuItem"
        Me.CrearToolStripMenuItem.Size = New System.Drawing.Size(58, 24)
        Me.CrearToolStripMenuItem.Text = "Crear"
        '
        'Main_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.mstrip_Main)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mstrip_Main
        Me.Name = "Main_Form"
        Me.Text = "Main_Form"
        Me.mstrip_Main.ResumeLayout(False)
        Me.mstrip_Main.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mstrip_Main As MenuStrip
    Friend WithEvents VisualizarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CrearToolStripMenuItem As ToolStripMenuItem
End Class
