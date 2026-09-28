Public Class Form5
    Public CurrentUser As String
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUser.Text.Trim()
        Dim password As String = txtPassword.Text
        If String.IsNullOrWhiteSpace(txtUser.Text) Then   'If the box is left blank, message box appears
            MsgBox("Please enter a username")
            Return
        End If
        If String.IsNullOrWhiteSpace(txtPassword.Text) Then   'If the box is left blank, message box appears
            MsgBox("Please enter a password")
            Return
        End If
        Dim filePath As String = Application.StartupPath & "\users.txt"

        If Not IO.File.Exists(filePath) Then
            MsgBox("No accounts found. Please sign up first.")
            Exit Sub
        End If

        Dim found As Boolean = False
        Dim lines() As String = IO.File.ReadAllLines(filePath)

        For Each line As String In lines
            Dim parts() As String = line.Split(","c)
            If parts.Length >= 2 Then
                If parts(0) = username And parts(1) = password Then
                    found = True
                    Exit For
                End If
            End If
        Next

        If found Then
            Form1.Show()
            Me.Hide()
        Else
            MsgBox("Incorrect username or password")
            Return
        End If
        CurrentUser = username
    End Sub

    Private Sub llblSignup_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblSignup.LinkClicked
        Form6.Show() 'If sign up is clicked, form 6 shows and this form is gone
        Me.Hide()
    End Sub
    'if forgot link clicked, this gone form 8 show
    Private Sub llblForgot_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblForgot.LinkClicked
        Form8.Show()
        Me.Hide()
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AcceptButton = btnLogin
    End Sub
End Class