Public Class Settings
    Private mainForm As OverlayForm

    Public Sub New(main As OverlayForm)
        InitializeComponent()
        mainForm = main
        ' Set the initial walues for the UI components
        btnChangeColor.BackColor = mainForm.BackColor
        btnKeyColor.BackColor = mainForm.TransparencyKey
        barOpacity.Value = mainForm.Opacity * 100
        labelOpacity.Text = barOpacity.Value
        boxImageLayout.SelectedItem = mainForm.BackgroundImageLayout.ToString()

        If mainForm.imageLoaded Then
            btnImage.Text = "Remove Image"
        Else
            btnImage.Text = "Choose Image"
        End If
    End Sub

    Private Sub btnChangeColor_Click(sender As Object, e As EventArgs) Handles btnChangeColor.Click
        If OverlayColorDialog.ShowDialog() = DialogResult.OK Then
            ' Set the main form's background color
            mainForm.BackColor = OverlayColorDialog.Color
            btnChangeColor.BackColor = mainForm.BackColor
        End If
    End Sub
    Private Sub btnChangeColorClear_Click(sender As Object, e As EventArgs) Handles btnChangeColorClear.Click
        ' Reset the main form's color to the default color
        mainForm.BackColor = Color.Black
        btnChangeColor.BackColor = Color.Black
    End Sub

    Private Sub OpacityBar_Scroll(sender As Object, e As EventArgs) Handles barOpacity.Scroll
        ' Adjust the opactiy of the main form
        mainForm.Opacity = barOpacity.Value / 100
        labelOpacity.Text = barOpacity.Value
    End Sub

    Private Sub btnImage_Click(sender As Object, e As EventArgs) Handles btnImage.Click

        If mainForm.imageLoaded = False Then
            ' Create an OpenFileDialog to select an image
            Dim openFileDialog As New OpenFileDialog()

            ' Set the filter for image files
            openFileDialog.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif"
            openFileDialog.Title = "Select a Background Image"

            ' Show the dialog and get the result
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                ' Load the selected image into a Bitmap
                Dim selectedImage As Image = Image.FromFile(openFileDialog.FileName)

                ' Set the form's background to the selected image
                mainForm.BackgroundImage = selectedImage
                btnImage.Text = "Remove Image"
                mainForm.imageLoaded = True
            End If
        Else
            mainForm.BackgroundImage = Nothing
            mainForm.BackColor = btnChangeColor.BackColor
            mainForm.TransparencyKey = Nothing
            mainForm.imageLoaded = False
            btnImage.Text = "Choose Image"
        End If
    End Sub

    Private Sub boxImageScale_SelectedIndexChanged(sender As Object, e As EventArgs) Handles boxImageLayout.SelectedIndexChanged
        ' Set the image layout to use for the main formed depending on which layout choice is selected.
        mainForm.BackgroundImageLayout = ImageLayout.Stretch
        Select Case boxImageLayout.SelectedItem?.ToString()
            Case "None"
                mainForm.BackgroundImageLayout = ImageLayout.None
            Case "Tile"
                mainForm.BackgroundImageLayout = ImageLayout.Tile
            Case "Center"
                mainForm.BackgroundImageLayout = ImageLayout.Center
            Case "Stretch"
                mainForm.BackgroundImageLayout = ImageLayout.Stretch
            Case "Zoom"
                mainForm.BackgroundImageLayout = ImageLayout.Zoom
            Case Else
                mainForm.BackgroundImageLayout = ImageLayout.None
        End Select
    End Sub

    Private Sub btnKeyColor_Click(sender As Object, e As EventArgs) Handles btnKeyColor.Click
        ' Set the transparency color using the color dialog
        If OverlayColorDialog.ShowDialog() = DialogResult.OK Then
            mainForm.TransparencyKey = OverlayColorDialog.Color
            btnKeyColor.BackColor = OverlayColorDialog.Color
        End If
    End Sub

    Private Sub btnKeyColorClear_Click(sender As Object, e As EventArgs) Handles btnKeyColorClear.Click
        ' Reset the transparency color to nothing
        mainForm.TransparencyKey = Nothing
        btnKeyColor.BackColor = Nothing
    End Sub

End Class