Imports System.Runtime.InteropServices

Public Class OverlayForm
    Private isResizing As Boolean = False
    Private isDragging As Boolean = False
    Private lastMousePosition As Point
    Private moveStep As Integer = 1 ' Number of pixels to move with each arrow key press
    Public imageLoaded As Boolean = False

    ' Windows API constants and methods to allow click through
    Private Const WS_EX_TRANSPARENT As Integer = &H20
    Private Const GWL_EXSTYLE As Integer = -20

    <DllImport("user32.dll", SetLastError:=True)>
    Private Shared Function GetWindowLong(ByVal hWnd As IntPtr, ByVal nIndex As Integer) As Integer
    End Function

    <DllImport("user32.dll", SetLastError:=True)>
    Private Shared Function SetWindowLong(ByVal hWnd As IntPtr, ByVal nIndex As Integer, ByVal dwNewLong As Integer) As Integer
    End Function

    Protected Overrides Sub OnLoad(ByVal e As EventArgs)
        MyBase.OnLoad(e)

        ' Set the form to be click-through initially
        SetClickThrough(True)

    End Sub

    Private Sub SetClickThrough(enable As Boolean)
        Dim style As Integer = GetWindowLong(Me.Handle, GWL_EXSTYLE)
        If enable Then
            SetWindowLong(Me.Handle, GWL_EXSTYLE, style Or WS_EX_TRANSPARENT)
        Else
            SetWindowLong(Me.Handle, GWL_EXSTYLE, style And Not WS_EX_TRANSPARENT)
        End If
    End Sub

    Protected Overrides Sub OnActivated(ByVal e As EventArgs)
        MyBase.OnActivated(e)
        ' Disable click-through when the form is focused to allow resizing and repositioning
        SetClickThrough(False)
    End Sub

    Protected Overrides Sub OnDeactivate(ByVal e As EventArgs)
        MyBase.OnDeactivate(e)
        ' Enable click-through when the form loses focus
        SetClickThrough(True)
    End Sub

    Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
        If e.Button = MouseButtons.Right Then
            ' Show context menu on right-click
            ContextMenu.Show(Me, e.Location)
        ElseIf e.Button = MouseButtons.Left Then
            ' Check if the mouse is near the edges to resize
            If e.X >= Me.ClientSize.Width - 10 AndAlso e.Y >= Me.ClientSize.Height - 10 Then
                isResizing = True
                lastMousePosition = e.Location
            Else
                ' Initiate dragging
                isDragging = True
                lastMousePosition = e.Location
            End If
        End If
        MyBase.OnMouseDown(e)
    End Sub

    Protected Overrides Sub OnMouseMove(ByVal e As MouseEventArgs)
        If isResizing Then
            ' Calculate the new size
            Dim newWidth As Integer = Me.Width + (e.X - lastMousePosition.X)
            Dim newHeight As Integer = Me.Height + (e.Y - lastMousePosition.Y)

            ' Set the new size
            Me.Size = New Size(Math.Max(newWidth, MinimumSize.Width), Math.Max(newHeight, MinimumSize.Height))
            lastMousePosition = e.Location
        ElseIf isDragging Then
            ' Update the form's position based on mouse movement
            Me.Location = New Point(Me.Location.X + (e.X - lastMousePosition.X), Me.Location.Y + (e.Y - lastMousePosition.Y))
        Else
            ' Change the cursor to indicate resizing
            If e.X >= Me.ClientSize.Width - 10 AndAlso e.Y >= Me.ClientSize.Height - 10 Then
                Me.Cursor = Cursors.SizeNWSE
            Else
                Me.Cursor = Cursors.Default
            End If
        End If
        MyBase.OnMouseMove(e)
    End Sub

    Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            isResizing = False
            isDragging = False
        End If
        MyBase.OnMouseUp(e)
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        Select Case keyData
            Case Keys.Up
                Me.Location = New Point(Me.Location.X, Me.Location.Y - moveStep)
                Return True
            Case Keys.Down
                Me.Location = New Point(Me.Location.X, Me.Location.Y + moveStep)
                Return True
            Case Keys.Left
                Me.Location = New Point(Me.Location.X - moveStep, Me.Location.Y)
                Return True
            Case Keys.Right
                Me.Location = New Point(Me.Location.X + moveStep, Me.Location.Y)
                Return True
        End Select

        Return MyBase.ProcessCmdKey(msg, keyData) ' Call base class to process other keys
    End Function

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        ' Open the customization form
        Dim customizeForm As New Settings(Me)
        customizeForm.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

End Class
