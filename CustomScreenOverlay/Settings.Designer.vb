<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Settings))
        Label1 = New Label()
        btnChangeColor = New Button()
        OverlayColorDialog = New ColorDialog()
        barOpacity = New TrackBar()
        Label2 = New Label()
        labelOpacity = New Label()
        Label3 = New Label()
        btnImage = New Button()
        Label4 = New Label()
        boxImageLayout = New ComboBox()
        Label5 = New Label()
        btnKeyColor = New Button()
        btnKeyColorClear = New Button()
        btnChangeColorClear = New Button()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        TabPage2 = New TabPage()
        RichTextBox1 = New RichTextBox()
        CType(barOpacity, ComponentModel.ISupportInitialize).BeginInit()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(42, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(42, 15)
        Label1.TabIndex = 0
        Label1.Text = "Color :"
        ' 
        ' btnChangeColor
        ' 
        btnChangeColor.BackColor = SystemColors.Control
        btnChangeColor.Location = New Point(177, 44)
        btnChangeColor.Name = "btnChangeColor"
        btnChangeColor.Size = New Size(104, 23)
        btnChangeColor.TabIndex = 1
        btnChangeColor.UseVisualStyleBackColor = False
        ' 
        ' OverlayColorDialog
        ' 
        OverlayColorDialog.FullOpen = True
        ' 
        ' barOpacity
        ' 
        barOpacity.BackColor = SystemColors.ControlLightLight
        barOpacity.Location = New Point(177, 89)
        barOpacity.Maximum = 100
        barOpacity.Name = "barOpacity"
        barOpacity.Size = New Size(113, 45)
        barOpacity.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(41, 89)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 15)
        Label2.TabIndex = 3
        Label2.Text = "Opacity :"
        ' 
        ' labelOpacity
        ' 
        labelOpacity.AutoSize = True
        labelOpacity.Location = New Point(288, 92)
        labelOpacity.Name = "labelOpacity"
        labelOpacity.Size = New Size(19, 15)
        labelOpacity.TabIndex = 4
        labelOpacity.Text = "50"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(41, 140)
        Label3.Name = "Label3"
        Label3.Size = New Size(46, 15)
        Label3.TabIndex = 5
        Label3.Text = "Image :"
        ' 
        ' btnImage
        ' 
        btnImage.Location = New Point(177, 140)
        btnImage.Name = "btnImage"
        btnImage.Size = New Size(134, 23)
        btnImage.TabIndex = 6
        btnImage.Text = "Choose Image"
        btnImage.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(42, 189)
        Label4.Name = "Label4"
        Label4.Size = New Size(85, 15)
        Label4.TabIndex = 7
        Label4.Text = "Image Layout :"
        ' 
        ' boxImageLayout
        ' 
        boxImageLayout.DropDownStyle = ComboBoxStyle.DropDownList
        boxImageLayout.FormattingEnabled = True
        boxImageLayout.Items.AddRange(New Object() {"None", "Center", "Stretch", "Tile", "Zoom"})
        boxImageLayout.Location = New Point(177, 189)
        boxImageLayout.Name = "boxImageLayout"
        boxImageLayout.Size = New Size(134, 23)
        boxImageLayout.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(41, 239)
        Label5.Name = "Label5"
        Label5.Size = New Size(114, 15)
        Label5.TabIndex = 9
        Label5.Text = "Transparency Color :"
        ' 
        ' btnKeyColor
        ' 
        btnKeyColor.BackColor = SystemColors.Control
        btnKeyColor.Location = New Point(177, 239)
        btnKeyColor.Name = "btnKeyColor"
        btnKeyColor.Size = New Size(104, 23)
        btnKeyColor.TabIndex = 10
        btnKeyColor.UseVisualStyleBackColor = False
        ' 
        ' btnKeyColorClear
        ' 
        btnKeyColorClear.Location = New Point(287, 239)
        btnKeyColorClear.Name = "btnKeyColorClear"
        btnKeyColorClear.Size = New Size(24, 23)
        btnKeyColorClear.TabIndex = 11
        btnKeyColorClear.Text = "✖️"
        btnKeyColorClear.UseVisualStyleBackColor = True
        ' 
        ' btnChangeColorClear
        ' 
        btnChangeColorClear.Location = New Point(287, 44)
        btnChangeColorClear.Name = "btnChangeColorClear"
        btnChangeColorClear.Size = New Size(24, 23)
        btnChangeColorClear.TabIndex = 12
        btnChangeColorClear.Text = "✖️"
        btnChangeColorClear.UseVisualStyleBackColor = True
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Location = New Point(0, 0)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(373, 334)
        TabControl1.TabIndex = 13
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(Label1)
        TabPage1.Controls.Add(btnChangeColorClear)
        TabPage1.Controls.Add(btnChangeColor)
        TabPage1.Controls.Add(btnKeyColorClear)
        TabPage1.Controls.Add(barOpacity)
        TabPage1.Controls.Add(btnKeyColor)
        TabPage1.Controls.Add(Label2)
        TabPage1.Controls.Add(Label5)
        TabPage1.Controls.Add(labelOpacity)
        TabPage1.Controls.Add(boxImageLayout)
        TabPage1.Controls.Add(Label3)
        TabPage1.Controls.Add(Label4)
        TabPage1.Controls.Add(btnImage)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(365, 306)
        TabPage1.TabIndex = 0
        TabPage1.Text = "General"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(RichTextBox1)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(365, 306)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Help"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BorderStyle = BorderStyle.None
        RichTextBox1.Location = New Point(5, 6)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.ReadOnly = True
        RichTextBox1.Size = New Size(354, 301)
        RichTextBox1.TabIndex = 1
        RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        ' 
        ' Settings
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(374, 336)
        Controls.Add(TabControl1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "Settings"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "Settings"
        TopMost = True
        CType(barOpacity, ComponentModel.ISupportInitialize).EndInit()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnChangeColor As Button
    Friend WithEvents OverlayColorDialog As ColorDialog
    Friend WithEvents barOpacity As TrackBar
    Friend WithEvents Label2 As Label
    Friend WithEvents labelOpacity As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnImage As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents boxImageLayout As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnKeyColor As Button
    Friend WithEvents btnKeyColorClear As Button
    Friend WithEvents btnChangeColorClear As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Preferences As TabPage
    Friend WithEvents Info As TabPage
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
