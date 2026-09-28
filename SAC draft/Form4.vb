Public Class Form4
    Public PreviousForm As Form
    'if arrow clicked, show previous form
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles picbxArrow.Click
        If PreviousForm IsNot Nothing Then
            PreviousForm.Show()
        End If
        Me.Hide()
    End Sub
    'deletes account
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim confirm As DialogResult = MessageBox.Show(
            "Delete account'" & Form5.CurrentUser & "'? This cannot be undone.",
            "Delete Account",
            MessageBoxButtons.YesNo)

        If confirm <> DialogResult.Yes Then Exit Sub

        Dim filePath As String = Application.StartupPath & "\users.txt"
        If Not IO.File.Exists(filePath) Then
            MsgBox("No user file found.")
            Exit Sub
        End If

        ' Keep every line except the current user
        Dim lines As New List(Of String)(IO.File.ReadAllLines(filePath))
        Dim newLines As New List(Of String)

        For Each line As String In lines
            Dim parts() As String = line.Split(","c)
            If parts.Length >= 1 AndAlso parts(0).Trim() <> Form5.CurrentUser Then
                newLines.Add(line)
            End If
        Next

        IO.File.WriteAllLines(filePath, newLines.ToArray())

        'removes thier tile.
        Dim claimsFile As String = Application.StartupPath & "\claims.txt"
        If IO.File.Exists(claimsFile) Then
            Dim claimLines As New List(Of String)
            For Each line As String In IO.File.ReadAllLines(claimsFile)
                Dim parts() As String = line.Split(","c)
                If parts.Length >= 1 AndAlso parts(0).Trim() <> Form5.CurrentUser Then
                    claimLines.Add(line)
                End If
            Next
            IO.File.WriteAllLines(claimsFile, claimLines.ToArray())
        End If

        Form5.CurrentUser = ""
        MsgBox("Account deleted.")
        Form5.Show()
        Me.Hide()
    End Sub

End Class