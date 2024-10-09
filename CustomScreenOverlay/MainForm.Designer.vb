<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OverlayForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(OverlayForm))
        ContextMenu = New ContextMenuStrip(components)
        SettingsToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        ContextMenu.SuspendLayout()
        SuspendLayout()
        ' 
        ' ContextMenu
        ' 
        ContextMenu.Items.AddRange(New ToolStripItem() {SettingsToolStripMenuItem, ExitToolStripMenuItem})
        ContextMenu.Name = "ContextMenu"
        ContextMenu.Size = New Size(117, 48)
        ' 
        ' SettingsToolStripMenuItem
        ' 
        SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        SettingsToolStripMenuItem.Size = New Size(116, 22)
        SettingsToolStripMenuItem.Text = "Settings"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(116, 22)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' OverlayForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        BackColor = Color.Black
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(550, 450)
        ControlBox = False
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "OverlayForm"
        Opacity = 0.5R
        ShowIcon = False
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterScreen
        Text = "Custom Screen Overlay"
        TopMost = True
        ContextMenu.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents ContextMenu As ContextMenuStrip
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
