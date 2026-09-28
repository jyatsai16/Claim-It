Public Class Form6
    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click
        Dim username As String = txtUser.Text.Trim()
        Dim password As String = txtPassword.Text
        'check if filled correctuly
        If String.IsNullOrWhiteSpace(txtUser.Text) Then
            MsgBox("Please enter a username")
            Return
        End If
        'check if filled correctuly
        If String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MsgBox("Please enter a password")
            Return
        End If
        'check if filled correctuly
        If txtPassword.Text <> txtReenter.Text Then
            MsgBox("Passwords do not match")
            Return
        End If
        'check if filled correctuly
        If chkbxAgree.Checked = False Then
            MsgBox("Please agree to the terms and conditions to sign up")
            Return
        End If

        Dim filePath As String = Application.StartupPath & "\users.txt"
        'stop sign in if user already exits
        If IO.File.Exists(filePath) Then
            Dim lines() As String = IO.File.ReadAllLines(filePath)
            For Each line As String In lines
                Dim parts() As String = line.Split(","c)
                If parts.Length >= 1 AndAlso parts(0).ToLower() = username.ToLower() Then
                    MsgBox("That username is already taken")
                    Exit Sub
                End If
            Next
        End If
        'save new acct
        IO.File.AppendAllText(filePath, username & "," & password & Environment.NewLine)
        MsgBox("Account created. You can now sign in.")

    End Sub

    'terms and conditons clicked, this gone form7 show
    Private Sub llblTerms_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblTerms.LinkClicked
        Form7.Show()
        Me.Hide()
    End Sub
    'arrow clicked, this gone form5 show
    Private Sub picbxArrow_Click(sender As Object, e As EventArgs) Handles picbxArrow.Click
        Form5.Show()
        Me.Hide()
    End Sub

    'allows keyboard shortcut
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AcceptButton = btnSignup
    End Sub
End Class