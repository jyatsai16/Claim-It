<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        btnAccount = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button1 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        Button8 = New Button()
        Button9 = New Button()
        Button10 = New Button()
        Button11 = New Button()
        Button12 = New Button()
        lblSettings = New Label()
        picbxArrow = New PictureBox()
        CType(picbxArrow, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnAccount
        ' 
        btnAccount.Location = New Point(21, 96)
        btnAccount.Name = "btnAccount"
        btnAccount.RightToLeft = RightToLeft.No
        btnAccount.Size = New Size(646, 48)
        btnAccount.TabIndex = 0
        btnAccount.Text = " Account Information"
        btnAccount.TextAlign = ContentAlignment.MiddleLeft
        btnAccount.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(21, 233)
        Button2.Name = "Button2"
        Button2.Size = New Size(646, 48)
        Button2.TabIndex = 1
        Button2.Text = "...."
        Button2.TextAlign = ContentAlignment.MiddleLeft
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(21, 187)
        Button3.Name = "Button3"
        Button3.Size = New Size(646, 48)
        Button3.TabIndex = 2
        Button3.Text = "Visibility "
        Button3.TextAlign = ContentAlignment.MiddleLeft
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(21, 142)
        Button4.Name = "Button4"
        Button4.Size = New Size(646, 48)
        Button4.TabIndex = 3
        Button4.Text = "Brightness "
        Button4.TextAlign = ContentAlignment.MiddleLeft
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(21, 323)
        Button1.Name = "Button1"
        Button1.Size = New Size(646, 48)
        Button1.TabIndex = 7
        Button1.Text = "...."
        Button1.TextAlign = ContentAlignment.MiddleLeft
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(21, 368)
        Button5.Name = "Button5"
        Button5.Size = New Size(646, 48)
        Button5.TabIndex = 6
        Button5.Text = "...."
        Button5.TextAlign = ContentAlignment.MiddleLeft
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(21, 414)
        Button6.Name = "Button6"
        Button6.Size = New Size(646, 48)
        Button6.TabIndex = 5
        Button6.Text = "...."
        Button6.TextAlign = ContentAlignment.MiddleLeft
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(21, 277)
        Button7.Name = "Button7"
        Button7.RightToLeft = RightToLeft.No
        Button7.Size = New Size(646, 48)
        Button7.TabIndex = 4
        Button7.Text = "...."
        Button7.TextAlign = ContentAlignment.MiddleLeft
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.Location = New Point(21, 506)
        Button8.Name = "Button8"
        Button8.Size = New Size(646, 48)
        Button8.TabIndex = 11
        Button8.Text = "...."
        Button8.TextAlign = ContentAlignment.MiddleLeft
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Button9
        ' 
        Button9.Location = New Point(21, 551)
        Button9.Name = "Button9"
        Button9.Size = New Size(646, 48)
        Button9.TabIndex = 10
        Button9.Text = "Change Account"
        Button9.TextAlign = ContentAlignment.MiddleLeft
        Button9.UseVisualStyleBackColor = True
        ' 
        ' Button10
        ' 
        Button10.Location = New Point(21, 597)
        Button10.Name = "Button10"
        Button10.Size = New Size(646, 48)
        Button10.TabIndex = 9
        Button10.Text = "Log Out "
        Button10.TextAlign = ContentAlignment.MiddleLeft
        Button10.UseVisualStyleBackColor = True
        ' 
        ' Button11
        ' 
        Button11.Location = New Point(21, 460)
        Button11.Name = "Button11"
        Button11.RightToLeft = RightToLeft.No
        Button11.Size = New Size(646, 48)
        Button11.TabIndex = 8
        Button11.Text = "...."
        Button11.TextAlign = ContentAlignment.MiddleLeft
        Button11.UseVisualStyleBackColor = True
        ' 
        ' Button12
        ' 
        Button12.Location = New Point(21, 639)
        Button12.Name = "Button12"
        Button12.Size = New Size(646, 48)
        Button12.TabIndex = 12
        Button12.Text = "Delete Account"
        Button12.TextAlign = ContentAlignment.MiddleLeft
        Button12.UseVisualStyleBackColor = True
        ' 
        ' lblSettings
        ' 
        lblSettings.AutoSize = True
        lblSettings.Font = New Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSettings.Location = New Point(243, 26)
        lblSettings.Name = "lblSettings"
        lblSettings.Size = New Size(205, 65)
        lblSettings.TabIndex = 13
        lblSettings.Text = "Settings"
        ' 
        ' picbxArrow
        ' 
        picbxArrow.Image = CType(resources.GetObject("picbxArrow.Image"), Image)
        picbxArrow.Location = New Point(21, 57)
        picbxArrow.Name = "picbxArrow"
        picbxArrow.Size = New Size(32, 19)
        picbxArrow.SizeMode = PictureBoxSizeMode.StretchImage
        picbxArrow.TabIndex = 14
        picbxArrow.TabStop = False
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(688, 708)
        Controls.Add(picbxArrow)
        Controls.Add(lblSettings)
        Controls.Add(Button12)
        Controls.Add(Button8)
        Controls.Add(Button9)
        Controls.Add(Button10)
        Controls.Add(Button11)
        Controls.Add(Button1)
        Controls.Add(Button5)
        Controls.Add(Button6)
        Controls.Add(Button7)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(btnAccount)
        Name = "Form4"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Claim It"
        CType(picbxArrow, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnAccount As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents lblSettings As Label
    Friend WithEvents picbxArrow As PictureBox
End Class
