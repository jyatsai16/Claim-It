Public Class Form7
    'back button clicked, this gone form6 show
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Form6.Show()
        Me.Hide()
    End Sub
End Class