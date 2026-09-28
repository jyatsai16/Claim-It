Public Class Form1
    'size of grid
    Private Const GridCols As Integer = 10
    Private Const GridRows As Integer = 6
    Private Const TileSizeConst As Integer = 40
    Private Const TileMarginConst As Integer = 3

    Private userBlocks As Integer = 0 'defult amount of blocks user has
    Private claims As New Dictionary(Of String, String)() 'set claim as "x,y", value = owner name
    'starts up the file where usernames and scores are stored
    Private ReadOnly UsersFile As String = Application.StartupPath & "\users.txt"
    Private ReadOnly ClaimsFile As String = Application.StartupPath & "\claims.txt"

    Private mapImage As Bitmap = Nothing 'full map picture used to crop ea. tile
    Private mapLoaded As Boolean = False 'true after the map image has loaded

    'called by form2 so this form can reload in the background
    Public Sub ReloadAfterRun()
        LoadClaims()
        LoadUserBlocks()
        RefreshGridVisuals()
    End Sub

    'runs when the form opens
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' create claims.txt if it doesn't exist yet
        If Not IO.File.Exists(ClaimsFile) Then IO.File.WriteAllText(ClaimsFile, "")
        'load map
        mapImage = New Bitmap(My.Resources.DefaultMap)
        mapLoaded = True
        pnlMap.BackgroundImage = CType(My.Resources.DefaultMap, Image)
        pnlMap.BackgroundImageLayout = ImageLayout.Zoom

        BuildGrid() 'create the tiles
        LoadClaims() 'load who owns each tile
        LoadUserBlocks() 'amount of tiles user has
        RefreshGridVisuals() 'draws the initals on the tiles

    End Sub

    'creates a picturebox for every tile 
    Private Sub BuildGrid()
        If pnlMap Is Nothing Then Return
        pnlMap.Controls.Clear()
        pnlMap.AutoScroll = True

        For r As Integer = 0 To GridRows - 1
            For c As Integer = 0 To GridCols - 1
                Dim pb As New PictureBox()
                pb.Width = TileSizeConst
                pb.Height = TileSizeConst
                pb.Left = c * (TileSizeConst + TileMarginConst)
                pb.Top = r * (TileSizeConst + TileMarginConst)
                pb.BorderStyle = BorderStyle.FixedSingle
                pb.BackColor = Color.LightGray
                pb.SizeMode = PictureBoxSizeMode.CenterImage
                pb.Tag = c.ToString() & "," & r.ToString() 'store tile as column, row
                pb.Cursor = Cursors.Hand
                AddHandler pb.Click, AddressOf Tile_Click 'clicking the tile claims it
                pnlMap.Controls.Add(pb)
            Next
        Next


        CenterGridInPanel()
    End Sub
    'moves grid so it sists in the middle of the panel
    Private Sub CenterGridInPanel()
        If pnlMap Is Nothing OrElse pnlMap.Controls.Count = 0 Then Return

        Dim gridWidth As Integer = GridCols * TileSizeConst + (GridCols - 1) * TileMarginConst
        Dim gridHeight As Integer = GridRows * TileSizeConst + (GridRows - 1) * TileMarginConst

        Dim offsetX As Integer = Math.Max(0, (pnlMap.ClientSize.Width - gridWidth) \ 2)
        Dim offsetY As Integer = Math.Max(0, (pnlMap.ClientSize.Height - gridHeight) \ 2)

        For Each ctrl As Control In pnlMap.Controls
            Dim pb As PictureBox = TryCast(ctrl, PictureBox)
            If pb Is Nothing Then Continue For
            pb.Left += offsetX
            pb.Top += offsetY
        Next
    End Sub

    'loads saved claims from claims.txt
    'format as username,x,y
    Private Sub LoadClaims()
        claims.Clear()
        If Not IO.File.Exists(ClaimsFile) Then Return

        Dim lines() As String = IO.File.ReadAllLines(ClaimsFile)
        For Each line As String In lines
            If String.IsNullOrWhiteSpace(line) Then Continue For
            Dim parts() As String = line.Split(","c)
            If parts.Length >= 3 Then
                Dim owner As String = parts(0).Trim()
                Dim x As String = parts(1).Trim()
                Dim y As String = parts(2).Trim()
                Dim key As String = x & "," & y
                If Not claims.ContainsKey(key) Then claims.Add(key, owner)
            End If
        Next
    End Sub

    'load saved claims from claims.txt
    'format as username, password, block
    Private Sub LoadUserBlocks()
        userBlocks = 0
        If Not IO.File.Exists(UsersFile) Then
            If lblUserBlocks IsNot Nothing Then lblUserBlocks.Text = "0 blocks"
            Return
        End If

        Dim lines() As String = IO.File.ReadAllLines(UsersFile)
        For Each line As String In lines
            If String.IsNullOrWhiteSpace(line) Then Continue For
            Dim parts() As String = line.Split(","c)
            If parts.Length >= 3 AndAlso parts(0).Trim() = Form5.CurrentUser Then
                Integer.TryParse(parts(2).Trim(), userBlocks)
                Exit For
            End If
        Next

        lblUserBlocks.Text = userBlocks.ToString() & " blocks"

    End Sub

    ' redraw tiles, mark if tile already claimed
    Private Sub RefreshGridVisuals()
        If pnlMap Is Nothing Then Return

        For Each ctrl As Control In pnlMap.Controls
            Dim pb As PictureBox = TryCast(ctrl, PictureBox)
            If pb Is Nothing Then Continue For
            Dim coords As String = CStr(pb.Tag)
            Dim parts() As String = coords.Split(","c)
            Dim x As Integer = Integer.Parse(parts(0))
            Dim y As Integer = Integer.Parse(parts(1))

            Dim baseBmp As Bitmap = Nothing
            If mapLoaded AndAlso mapImage IsNot Nothing Then
                baseBmp = CropMapForTile(mapImage, x, y, GridCols, GridRows, TileSizeConst, TileMarginConst)
            Else
                baseBmp = New Bitmap(TileSizeConst, TileSizeConst)
                Using g As Graphics = Graphics.FromImage(baseBmp)
                    g.Clear(Color.LightGreen)
                End Using
            End If


            If claims.ContainsKey(coords) Then
                Dim owner As String = claims(coords)
                Dim composed As Bitmap = ComposeClaimedTile(baseBmp, owner)
                pb.Image = composed
                baseBmp.Dispose()
                pb.BackColor = Color.Transparent
            Else
                pb.Image = baseBmp
                pb.BackColor = Color.Transparent
            End If
            pb.Refresh()
        Next
    End Sub

    ' when user clicks map on tile
    Private Sub Tile_Click(sender As Object, e As EventArgs)
        Dim pb As PictureBox = TryCast(sender, PictureBox)
        If pb Is Nothing Then Return

        Dim coords As String = CStr(pb.Tag) ' columns, row
        Dim parts() As String = coords.Split(","c)
        Dim x As Integer = Integer.Parse(parts(0))
        Dim y As Integer = Integer.Parse(parts(1))
        ' don't let user claim if already claimed
        If claims.ContainsKey(coords) Then
            Dim owner As String = claims(coords)
            MessageBox.Show("This tile is already claimed by " & owner, "Tile Claimed", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        'don't let user claim if they have no more blocks left
        If userBlocks <= 0 Then
            MessageBox.Show("You have no blocks to claim a tile. Earn blocks by running.", "No Blocks", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' confrim with user before claiming tile
        Dim confirm As DialogResult = MessageBox.Show("Claim tile (" & x.ToString() & "," & y.ToString() & ") for 1 block?", "Confirm Claim", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirm <> DialogResult.Yes Then Return

        ' -1 block from user after claim
        userBlocks -= 1
        If lblUserBlocks IsNot Nothing Then lblUserBlocks.Text = userBlocks.ToString() & " blocks"
        UpdateUserBlocksInFile(Form5.CurrentUser, userBlocks)

        ' save claim to file
        Dim claimLine As String = Form5.CurrentUser & "," & x.ToString() & "," & y.ToString()
        IO.File.AppendAllText(ClaimsFile, claimLine & Environment.NewLine)
        claims.Add(coords, Form5.CurrentUser)
        ' if every tile is taken, clear map
        If claims.Count >= GridCols * GridRows Then

            MessageBox.Show("The map is full! The map will reset for a new round.", "Map Full")

            claims.Clear()

            IO.File.WriteAllText(ClaimsFile, "")

            RefreshGridVisuals()

        End If


        ' redarw tile as claimed
        If pb.Image IsNot Nothing Then
            pb.Image.Dispose()
            pb.Image = Nothing
        End If
        Dim baseBmp As Bitmap = Nothing
        If mapLoaded AndAlso mapImage IsNot Nothing Then
            baseBmp = CropMapForTile(mapImage, x, y, GridCols, GridRows, TileSizeConst, TileMarginConst)
        Else
            baseBmp = New Bitmap(TileSizeConst, TileSizeConst)
            Using g As Graphics = Graphics.FromImage(baseBmp)
                g.Clear(Color.LightGreen)
            End Using
        End If
        pb.Image = ComposeClaimedTile(baseBmp, Form5.CurrentUser)
        baseBmp.Dispose()
        pb.Refresh()

        MessageBox.Show("Tile claimed. Remaining blocks: " & userBlocks.ToString(), "Claim Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' update blocks colum for user in users.txt
    Private Sub UpdateUserBlocksInFile(username As String, newBlocks As Integer)
        If Not IO.File.Exists(UsersFile) Then
            IO.File.WriteAllText(UsersFile, username & "," & "" & "," & newBlocks.ToString() & Environment.NewLine)
            Return
        End If

        Dim lines As New List(Of String)(IO.File.ReadAllLines(UsersFile))
        Dim found As Boolean = False
        For i As Integer = 0 To lines.Count - 1
            Dim parts() As String = lines(i).Split(","c)
            If parts.Length >= 3 AndAlso parts(0).Trim() = username Then
                parts(2) = newBlocks.ToString()
                lines(i) = String.Join(",", parts)
                found = True
                Exit For
            End If
        Next

        If Not found Then lines.Add(username & "," & "" & "," & newBlocks.ToString())
        IO.File.WriteAllLines(UsersFile, lines.ToArray())
    End Sub
    'creates matching piece of map for tile
    Private Function CropMapForTile(src As Bitmap, tileX As Integer, tileY As Integer, cols As Integer, rows As Integer, tileSize As Integer, tileMargin As Integer) As Bitmap

        Dim gridWidth As Integer = cols * tileSize + (cols - 1) * tileMargin
        Dim gridHeight As Integer = rows * tileSize + (rows - 1) * tileMargin

        ' scale tile position
        Dim scaleX As Double = src.Width / CDbl(gridWidth)
        Dim scaleY As Double = src.Height / CDbl(gridHeight)
        Dim srcLeft As Integer = CInt(Math.Round((tileX * (tileSize + tileMargin)) * scaleX))
        Dim srcTop As Integer = CInt(Math.Round((tileY * (tileSize + tileMargin)) * scaleY))
        Dim srcWidth As Integer = CInt(Math.Round(tileSize * scaleX))
        Dim srcHeight As Integer = CInt(Math.Round(tileSize * scaleY))

        ' keep the crop inside the image
        If srcLeft < 0 Then srcLeft = 0
        If srcTop < 0 Then srcTop = 0
        If srcLeft + srcWidth > src.Width Then srcWidth = src.Width - srcLeft
        If srcTop + srcHeight > src.Height Then srcHeight = src.Height - srcTop
        If srcWidth <= 0 OrElse srcHeight <= 0 Then
            Dim emptyBmp As New Bitmap(tileSize, tileSize)
            Using g As Graphics = Graphics.FromImage(emptyBmp)
                g.Clear(Color.LightGray)
            End Using
            Return emptyBmp
        End If

        Dim cropped As New Bitmap(tileSize, tileSize)
        Using g As Graphics = Graphics.FromImage(cropped)
            g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
            g.DrawImage(src, New Rectangle(0, 0, tileSize, tileSize), New Rectangle(srcLeft, srcTop, srcWidth, srcHeight), GraphicsUnit.Pixel)
        End Using
        Return cropped
    End Function

    ' make unclaimed tiles darker and owner's initial on tile when claimed
    Private Function ComposeClaimedTile(baseTile As Bitmap, owner As String) As Bitmap
        Dim bmp As New Bitmap(baseTile.Width, baseTile.Height)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.DrawImage(baseTile, 0, 0)

            Using overlayBrush As New SolidBrush(Color.FromArgb(140, Color.Black))
                g.FillRectangle(overlayBrush, 0, 0, bmp.Width, bmp.Height)
            End Using

            Dim initial As String = If(String.IsNullOrEmpty(owner), "?", owner.Substring(0, 1).ToUpper())
            Using f As New Font("Segoe UI", CInt(bmp.Width * 0.4), FontStyle.Bold, GraphicsUnit.Pixel)
                Dim sf As New StringFormat()
                sf.Alignment = StringAlignment.Center
                sf.LineAlignment = StringAlignment.Center
                g.DrawString(initial, f, Brushes.White, New RectangleF(0, 0, bmp.Width, bmp.Height), sf)
            End Using

            Using pen As New Pen(Color.FromArgb(200, Color.White), 2)
                g.DrawRectangle(pen, 1, 1, bmp.Width - 3, bmp.Height - 3)
            End Using
        End Using
        Return bmp
    End Function
    ' fress images from memory when the form closes
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If mapImage IsNot Nothing Then
            mapImage.Dispose()
            mapImage = Nothing
        End If
        If pnlMap IsNot Nothing Then
            For Each ctrl As Control In pnlMap.Controls
                Dim pb As PictureBox = TryCast(ctrl, PictureBox)
                If pb IsNot Nothing AndAlso pb.Image IsNot Nothing Then
                    pb.Image.Dispose()
                    pb.Image = Nothing
                End If
            Next
        End If
    End Sub
    'when track is clicked, this form gone form2 shows
    Private Sub btnTrack_Click(sender As Object, e As EventArgs) Handles btnTrack.Click
        Form2.Show()
        Me.Hide()
    End Sub
    'when leaderboard is clicked, this form gone form3 shows
    Private Sub btnLeader_Click(sender As Object, e As EventArgs) Handles btnLeader.Click
        Form3.Show()
        Me.Hide()
    End Sub
    'when menu clicked, this form gone form4 show
    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Form4.Show()
        Me.Hide()
    End Sub
    'turns on double buffering so map doesn't flash
    Public Sub New()
        InitializeComponent()
        Me.DoubleBuffered = True
        pnlMap.GetType().InvokeMember("DoubleBuffered",
            Reflection.BindingFlags.SetProperty Or Reflection.BindingFlags.Instance Or Reflection.BindingFlags.NonPublic,
            Nothing, pnlMap, New Object() {True})
    End Sub
    ' updates block count
    Private Sub ShowBlocks()
        Me.Text = "Claim It  -  " & userBlocks & " blocks"
        If lblUserBlocks IsNot Nothing Then
            lblUserBlocks.Text = userBlocks.ToString() & " blocks"
        End If
    End Sub
End Class

