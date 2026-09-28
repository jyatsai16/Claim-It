Public Class Form2

    Dim elapsedSeconds As Integer = 0 'total sexonds
    Dim secondsSinceLastBlock As Integer = 0 'seconds till next block
    Dim distance As Double = 0.0 'distance in km
    Dim sessionBlocks As Integer = 0 'blocks earned
    Const SecondsPerBlock As Integer = 60 '1 block every 60secs

    ' sets up track screen
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btnEnd.Visible = False
        ResetScreen()
        Timer1.Interval = 1000 'ticks every 1 second

    End Sub

    'resets time,distance and no. of blocks
    Private Sub ResetScreen()
        elapsedSeconds = 0
        secondsSinceLastBlock = 0
        distance = 0.0
        sessionBlocks = 0
        lblTime2.Text = "00:00:00"
        lblDistance2.Text = "0.00 km"
        lblTerritory2.Text = "0 blocks"
    End Sub
    'starts timer, start button gone  end appears
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        btnStart.Visible = False
        btnEnd.Visible = True
        Timer1.Start()
    End Sub

    'stops timer, end button gone start appears
    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click

        btnEnd.Visible = False
        btnStart.Visible = True
        Timer1.Stop()
        SaveBlocks()
        MsgBox("You earned " & sessionBlocks.ToString() & " block(s) this session.")
        ResetScreen()
        Form1.ReloadAfterRun()
    End Sub

    ' add new blocks to the user in users.txt
    'format username, password, blocks
    Private Sub SaveBlocks()
        If Form5.CurrentUser = "" Then
            MsgBox("No user is logged in")
            Exit Sub
        End If

        Dim filePath As String = Application.StartupPath & "\users.txt"
        If Not IO.File.Exists(filePath) Then
            MsgBox("No user file found")
            Exit Sub
        End If


        Dim lines As New List(Of String)(IO.File.ReadAllLines(filePath))
        Dim found As Boolean = False

        For i As Integer = 0 To lines.Count - 1
            Dim parts() As String = lines(i).Split(","c)

            If parts.Length >= 3 AndAlso parts(0) = Form5.CurrentUser Then
                Dim oldBlocks As Integer = 0
                Integer.TryParse(parts(2), oldBlocks)


                Dim newBlocks As Integer = oldBlocks + sessionBlocks
                parts(2) = newBlocks.ToString()

                lines(i) = String.Join(",", parts)
                found = True
                Exit For
            End If
        Next

        'If the user is not in the file, add them
        If Not found Then
            lines.Add(Form5.CurrentUser & ",," & sessionBlocks.ToString())
        End If

        IO.File.WriteAllLines(filePath, lines.ToArray())

    End Sub

    'Every second update time and distance, add block every minute
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        elapsedSeconds += 1
        secondsSinceLastBlock += 1

        ' format time as hrs:mins:secs
        Dim hours As Integer = elapsedSeconds \ 3600
        Dim minutes As Integer = (elapsedSeconds Mod 3600) \ 60
        Dim seconds As Integer = elapsedSeconds Mod 60
        lblTime2.Text = hours.ToString("00") & ":" & minutes.ToString("00") & ":" & seconds.ToString("00")

        '15 min per km - 1/900 km ea sec
        distance += (1.0 / 900.0)
        lblDistance2.Text = distance.ToString("0.00") & " km"

        'gie 1 block every 60sec
        If secondsSinceLastBlock >= SecondsPerBlock Then
            sessionBlocks += 1
            secondsSinceLastBlock = 0
            lblTerritory2.Text = sessionBlocks.ToString() & " blocks"
        End If
    End Sub

    'when map clicked, this form gone, form 1 reload and show
    Private Sub btnMap_Click(sender As Object, e As EventArgs) Handles btnMap.Click
        Form1.Show()
        Form1.ReloadAfterRun()
        Me.Hide()
    End Sub

    'when leaderboard clicked, this gone form3 show
    Private Sub btnLeader_Click(sender As Object, e As EventArgs) Handles btnLeader.Click
        Form3.Show()
        Me.Hide()
    End Sub

    'when leaderboard clicked, this gone form4 show
    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click

        Form4.PreviousForm = Me
        Form4.Show()
        Me.Hide()
    End Sub
End Class
