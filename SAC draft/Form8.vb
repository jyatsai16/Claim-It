Public Class Form8
    Public CurrentUser As String
    'when arrow clicked, this gone form5 show
    Private Sub picbxArrow_Click(sender As Object, e As EventArgs) Handles picbxArrow.Click
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'check if filled correctuly
        If String.IsNullOrWhiteSpace(txtUser.Text) Then
            MessageBox.Show("Please enter your username")
            Exit Sub
        End If
        'check if filled correctuly
        If String.IsNullOrWhiteSpace(txtEnter.Text) Or String.IsNullOrWhiteSpace(txtReenter.Text) Then
            MessageBox.Show("Please enter new password twice")
            Exit Sub
        End If
        'check if filled correctuly
        If txtEnter.Text <> txtReenter.Text Then
            MessageBox.Show("Passwords do not match. Please try again.")
            txtEnter.Clear()
            txtReenter.Clear()
            Exit Sub
        End If

        Dim filePath As String = Application.StartupPath & "\users.txt"
        Dim lines() As String = IO.File.ReadAllLines(filePath)
        Dim updated As Boolean = False
        ' find username and only replace password
        For i As Integer = 0 To lines.Length - 1
            Dim parts() As String = lines(i).Split(","c)
            If parts.Length >= 2 Then
                If parts(0) = txtUser.Text Then
                    lines(i) = parts(0) & "," & txtEnter.Text
                    updated = True
                    Exit For
                End If
            End If
        Next

        If updated Then
            IO.File.WriteAllLines(filePath, lines)
            MessageBox.Show("Password has been reset.")
            Form5.Show()
            Me.Hide()
        Else
            MessageBox.Show("User not found. Please sign in first or sign up.")
        End If
    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class