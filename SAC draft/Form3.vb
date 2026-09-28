Public Class Form3
    'map clicked, this gone form1 show
    Private Sub btnMap_Click(sender As Object, e As EventArgs) Handles btnMap.Click
        Form1.Show()
        Me.Hide()
    End Sub
    'track clicked, thsi gone form2 show
    Private Sub btnTrack_Click(sender As Object, e As EventArgs) Handles btnTrack.Click
        Form2.Show()
        Me.Hide()
    End Sub
    'count ea users claimed tiles and show place, username, territory
    Sub UpdateDGV()

        DataGridView1.Rows.Clear()

        Dim claimsFile As String = Application.StartupPath & "\claims.txt"

        If Not IO.File.Exists(claimsFile) Then Exit Sub

        Dim territoryCounts As New Dictionary(Of String, Integer)

        Dim lines() As String = IO.File.ReadAllLines(claimsFile)

        ' format username, x, y
        For Each line As String In lines

            Dim parts() As String = line.Split(","c)

            If parts.Length >= 3 Then

                Dim username As String = parts(0)

                If territoryCounts.ContainsKey(username) Then
                    territoryCounts(username) += 1
                Else
                    territoryCounts.Add(username, 1)
                End If

            End If

        Next

        'highest number of tiles first
        Dim place As Integer = 1

        For Each item In territoryCounts.OrderByDescending(Function(x) x.Value)

            DataGridView1.Rows.Add(place, item.Key, item.Value)

            place += 1

        Next

    End Sub
    'fill table when opened
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateDGV()
    End Sub
    'fill table agian
    Private Sub Form3_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        UpdateDGV()
    End Sub
    'when menu clicked, this gone form4 show make this previous form
    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Form4.PreviousForm = Me
        Form4.Show()
        Me.Hide()
    End Sub
End Class