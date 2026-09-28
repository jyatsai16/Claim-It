<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        lblTerritory1 = New Label()
        lblDistance1 = New Label()
        Label3 = New Label()
        btnMap = New Button()
        btnTrack = New Button()
        btnLeader = New Button()
        btnStart = New Button()
        btnEnd = New Button()
        Timer1 = New Timer(components)
        lblTime2 = New Label()
        lblDistance2 = New Label()
        Label1 = New Label()
        btnMenu = New Button()
        lblTerritory2 = New Label()
        SuspendLayout()
        ' 
        ' lblTerritory1
        ' 
        lblTerritory1.AutoSize = True
        lblTerritory1.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTerritory1.Location = New Point(95, 130)
        lblTerritory1.Name = "lblTerritory1"
        lblTerritory1.Size = New Size(98, 45)
        lblTerritory1.TabIndex = 0
        lblTerritory1.Text = "Block"
        ' 
        ' lblDistance1
        ' 
        lblDistance1.AutoSize = True
        lblDistance1.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDistance1.Location = New Point(89, 229)
        lblDistance1.Name = "lblDistance1"
        lblDistance1.Size = New Size(145, 45)
        lblDistance1.TabIndex = 1
        lblDistance1.Text = "Distance"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(102, 349)
        Label3.Name = "Label3"
        Label3.Size = New Size(91, 45)
        Label3.TabIndex = 2
        Label3.Text = "Time"
        ' 
        ' btnMap
        ' 
        btnMap.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnMap.Location = New Point(0, 642)
        btnMap.Name = "btnMap"
        btnMap.Size = New Size(261, 65)
        btnMap.TabIndex = 7
        btnMap.Text = "Map"
        btnMap.UseVisualStyleBackColor = True
        ' 
        ' btnTrack
        ' 
        btnTrack.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold)
        btnTrack.Location = New Point(257, 642)
        btnTrack.Name = "btnTrack"
        btnTrack.Size = New Size(175, 65)
        btnTrack.TabIndex = 9
        btnTrack.Text = "Track"
        btnTrack.UseVisualStyleBackColor = True
        ' 
        ' btnLeader
        ' 
        btnLeader.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold)
        btnLeader.Location = New Point(429, 642)
        btnLeader.Name = "btnLeader"
        btnLeader.Size = New Size(261, 65)
        btnLeader.TabIndex = 10
        btnLeader.Text = "Leaderboard"
        btnLeader.UseVisualStyleBackColor = True
        ' 
        ' btnStart
        ' 
        btnStart.Location = New Point(283, 573)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(112, 34)
        btnStart.TabIndex = 11
        btnStart.Text = "Start!"
        btnStart.UseVisualStyleBackColor = True
        ' 
        ' btnEnd
        ' 
        btnEnd.Location = New Point(283, 573)
        btnEnd.Name = "btnEnd"
        btnEnd.Size = New Size(112, 34)
        btnEnd.TabIndex = 12
        btnEnd.Text = "End"
        btnEnd.UseVisualStyleBackColor = True
        ' 
        ' Timer1
        ' 
        ' 
        ' lblTime2
        ' 
        lblTime2.AutoSize = True
        lblTime2.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold)
        lblTime2.Location = New Point(488, 349)
        lblTime2.Name = "lblTime2"
        lblTime2.Size = New Size(0, 45)
        lblTime2.TabIndex = 13
        ' 
        ' lblDistance2
        ' 
        lblDistance2.AutoSize = True
        lblDistance2.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold)
        lblDistance2.Location = New Point(488, 229)
        lblDistance2.Name = "lblDistance2"
        lblDistance2.Size = New Size(0, 45)
        lblDistance2.TabIndex = 14
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 28F, FontStyle.Bold)
        Label1.Location = New Point(-15, 573)
        Label1.Name = "Label1"
        Label1.Size = New Size(745, 74)
        Label1.TabIndex = 15
        Label1.Text = "_______________________________"
        ' 
        ' btnMenu
        ' 
        btnMenu.Location = New Point(643, 12)
        btnMenu.Name = "btnMenu"
        btnMenu.Size = New Size(33, 35)
        btnMenu.TabIndex = 16
        btnMenu.Text = "☰"
        btnMenu.UseVisualStyleBackColor = True
        ' 
        ' lblTerritory2
        ' 
        lblTerritory2.AutoSize = True
        lblTerritory2.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold)
        lblTerritory2.Location = New Point(488, 146)
        lblTerritory2.Name = "lblTerritory2"
        lblTerritory2.Size = New Size(0, 45)
        lblTerritory2.TabIndex = 17
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(688, 708)
        Controls.Add(lblTerritory2)
        Controls.Add(btnMenu)
        Controls.Add(lblDistance2)
        Controls.Add(lblTime2)
        Controls.Add(btnLeader)
        Controls.Add(btnTrack)
        Controls.Add(btnMap)
        Controls.Add(Label3)
        Controls.Add(lblDistance1)
        Controls.Add(lblTerritory1)
        Controls.Add(btnEnd)
        Controls.Add(btnStart)
        Controls.Add(Label1)
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Claim It"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTerritory1 As Label
    Friend WithEvents lblDistance1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnMap As Button
    Friend WithEvents btnTrack As Button
    Friend WithEvents btnLeader As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents btnEnd As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblTime2 As Label
    Friend WithEvents lblDistance2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnMenu As Button
    Friend WithEvents lblTerritory2 As Label
End Class
