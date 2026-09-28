<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        lblLeader = New Label()
        btnLeader = New Button()
        btnTrack = New Button()
        btnMap = New Button()
        lblLine = New Label()
        DataGridView1 = New DataGridView()
        dgvPlace = New DataGridViewTextBoxColumn()
        dgvUser = New DataGridViewTextBoxColumn()
        dgvArea = New DataGridViewTextBoxColumn()
        btnMenu = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblLeader
        ' 
        lblLeader.AutoSize = True
        lblLeader.Font = New Font("Segoe UI", 22F, FontStyle.Bold)
        lblLeader.Location = New Point(202, 9)
        lblLeader.Name = "lblLeader"
        lblLeader.Size = New Size(288, 60)
        lblLeader.TabIndex = 0
        lblLeader.Text = "Leaderboard"
        ' 
        ' btnLeader
        ' 
        btnLeader.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold)
        btnLeader.Location = New Point(428, 643)
        btnLeader.Name = "btnLeader"
        btnLeader.Size = New Size(261, 65)
        btnLeader.TabIndex = 18
        btnLeader.Text = "Leaderboard"
        btnLeader.UseVisualStyleBackColor = True
        ' 
        ' btnTrack
        ' 
        btnTrack.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold)
        btnTrack.Location = New Point(258, 642)
        btnTrack.Name = "btnTrack"
        btnTrack.Size = New Size(175, 65)
        btnTrack.TabIndex = 17
        btnTrack.Text = "Track"
        btnTrack.UseVisualStyleBackColor = True
        ' 
        ' btnMap
        ' 
        btnMap.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnMap.Location = New Point(0, 642)
        btnMap.Name = "btnMap"
        btnMap.Size = New Size(261, 65)
        btnMap.TabIndex = 16
        btnMap.Text = "Map"
        btnMap.UseVisualStyleBackColor = True
        ' 
        ' lblLine
        ' 
        lblLine.AutoSize = True
        lblLine.Font = New Font("Segoe UI", 28F, FontStyle.Bold)
        lblLine.Location = New Point(-23, 574)
        lblLine.Name = "lblLine"
        lblLine.Size = New Size(745, 74)
        lblLine.TabIndex = 19
        lblLine.Text = "_______________________________"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToResizeColumns = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {dgvPlace, dgvUser, dgvArea})
        DataGridView1.Location = New Point(37, 72)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(607, 554)
        DataGridView1.TabIndex = 20
        ' 
        ' dgvPlace
        ' 
        dgvPlace.HeaderText = "Place"
        dgvPlace.MinimumWidth = 8
        dgvPlace.Name = "dgvPlace"
        dgvPlace.ReadOnly = True
        dgvPlace.Width = 50
        ' 
        ' dgvUser
        ' 
        dgvUser.HeaderText = "Username"
        dgvUser.MinimumWidth = 8
        dgvUser.Name = "dgvUser"
        dgvUser.ReadOnly = True
        dgvUser.Width = 200
        ' 
        ' dgvArea
        ' 
        dgvArea.HeaderText = "Blocks Claimed"
        dgvArea.MinimumWidth = 8
        dgvArea.Name = "dgvArea"
        dgvArea.ReadOnly = True
        dgvArea.Width = 180
        ' 
        ' btnMenu
        ' 
        btnMenu.Location = New Point(643, 12)
        btnMenu.Name = "btnMenu"
        btnMenu.Size = New Size(33, 35)
        btnMenu.TabIndex = 21
        btnMenu.Text = "☰"
        btnMenu.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(688, 708)
        Controls.Add(btnMenu)
        Controls.Add(DataGridView1)
        Controls.Add(btnLeader)
        Controls.Add(btnTrack)
        Controls.Add(btnMap)
        Controls.Add(lblLeader)
        Controls.Add(lblLine)
        Name = "Form3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Claim It"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblLeader As Label
    Friend WithEvents btnLeader As Button
    Friend WithEvents btnTrack As Button
    Friend WithEvents btnMap As Button
    Friend WithEvents lblLine As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnMenu As Button
    Friend WithEvents dgvPlace As DataGridViewTextBoxColumn
    Friend WithEvents dgvUser As DataGridViewTextBoxColumn
    Friend WithEvents dgvArea As DataGridViewTextBoxColumn
End Class
