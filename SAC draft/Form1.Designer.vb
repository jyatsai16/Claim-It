<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        picbxAvatar = New PictureBox()
        btnLeader = New Button()
        btnTrack = New Button()
        btnMap = New Button()
        pnlMap = New Panel()
        lblUserBlocks = New Label()
        btnOut = New Button()
        btnMenu = New Button()
        btnIn = New Button()
        Label1 = New Label()
        CType(picbxAvatar, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picbxAvatar
        ' 
        picbxAvatar.Image = CType(resources.GetObject("picbxAvatar.Image"), Image)
        picbxAvatar.Location = New Point(622, 559)
        picbxAvatar.Name = "picbxAvatar"
        picbxAvatar.Size = New Size(31, 30)
        picbxAvatar.SizeMode = PictureBoxSizeMode.StretchImage
        picbxAvatar.TabIndex = 4
        picbxAvatar.TabStop = False
        ' 
        ' btnLeader
        ' 
        btnLeader.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold)
        btnLeader.Location = New Point(428, 642)
        btnLeader.Name = "btnLeader"
        btnLeader.Size = New Size(261, 65)
        btnLeader.TabIndex = 7
        btnLeader.Text = "Leaderboard"
        btnLeader.UseVisualStyleBackColor = True
        ' 
        ' btnTrack
        ' 
        btnTrack.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold)
        btnTrack.Location = New Point(259, 642)
        btnTrack.Name = "btnTrack"
        btnTrack.Size = New Size(175, 65)
        btnTrack.TabIndex = 8
        btnTrack.Text = "Track"
        btnTrack.UseVisualStyleBackColor = True
        ' 
        ' btnMap
        ' 
        btnMap.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnMap.Location = New Point(0, 642)
        btnMap.Name = "btnMap"
        btnMap.Size = New Size(261, 65)
        btnMap.TabIndex = 6
        btnMap.Text = "Map"
        btnMap.UseVisualStyleBackColor = True
        ' 
        ' pnlMap
        ' 
        pnlMap.AutoScroll = True
        pnlMap.BackgroundImage = My.Resources.Resources.DefaultMap
        pnlMap.BackgroundImageLayout = ImageLayout.Stretch
        pnlMap.Location = New Point(12, 12)
        pnlMap.Name = "pnlMap"
        pnlMap.Size = New Size(634, 496)
        pnlMap.TabIndex = 17
        ' 
        ' lblUserBlocks
        ' 
        lblUserBlocks.AutoSize = True
        lblUserBlocks.Font = New Font("Comic Sans MS", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUserBlocks.ForeColor = Color.Firebrick
        lblUserBlocks.Location = New Point(190, 550)
        lblUserBlocks.Name = "lblUserBlocks"
        lblUserBlocks.Size = New Size(267, 39)
        lblUserBlocks.TabIndex = 0
        lblUserBlocks.Text = "0 blocks available!"
        ' 
        ' btnOut
        ' 
        btnOut.Location = New Point(624, 93)
        btnOut.Name = "btnOut"
        btnOut.Size = New Size(22, 34)
        btnOut.TabIndex = 2
        btnOut.Text = "-"
        btnOut.UseVisualStyleBackColor = True
        ' 
        ' btnMenu
        ' 
        btnMenu.Location = New Point(652, 7)
        btnMenu.Name = "btnMenu"
        btnMenu.Size = New Size(33, 35)
        btnMenu.TabIndex = 0
        btnMenu.Text = "☰"
        btnMenu.UseVisualStyleBackColor = True
        ' 
        ' btnIn
        ' 
        btnIn.Location = New Point(622, 53)
        btnIn.Name = "btnIn"
        btnIn.Size = New Size(22, 34)
        btnIn.TabIndex = 1
        btnIn.Text = "+"
        btnIn.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 28F, FontStyle.Bold)
        Label1.Location = New Point(-14, 574)
        Label1.Name = "Label1"
        Label1.Size = New Size(745, 74)
        Label1.TabIndex = 18
        Label1.Text = "_______________________________"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Pink
        ClientSize = New Size(689, 708)
        Controls.Add(lblUserBlocks)
        Controls.Add(pnlMap)
        Controls.Add(btnTrack)
        Controls.Add(btnLeader)
        Controls.Add(btnMap)
        Controls.Add(btnOut)
        Controls.Add(btnIn)
        Controls.Add(btnMenu)
        Controls.Add(picbxAvatar)
        Controls.Add(Label1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Claim It"
        CType(picbxAvatar, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents picbxAvatar As PictureBox
    Friend WithEvents btnLeader As Button
    Friend WithEvents btnTrack As Button
    Friend WithEvents btnMap As Button
    Friend WithEvents pnlMap As Panel
    Friend WithEvents lblUserBlocks As Label
    Friend WithEvents btnOut As Button
    Friend WithEvents btnMenu As Button
    Friend WithEvents btnIn As Button
    Friend WithEvents Label1 As Label

End Class
