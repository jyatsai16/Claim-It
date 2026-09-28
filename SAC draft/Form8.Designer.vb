<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form8))
        lblReset = New Label()
        lblNew = New Label()
        lblReenter = New Label()
        txtEnter = New TextBox()
        txtReenter = New TextBox()
        btnReset = New Button()
        picbxArrow = New PictureBox()
        lblUser = New Label()
        txtUser = New TextBox()
        CType(picbxArrow, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblReset
        ' 
        lblReset.AutoSize = True
        lblReset.Font = New Font("Segoe UI Semibold", 20F, FontStyle.Bold)
        lblReset.Location = New Point(188, 44)
        lblReset.Name = "lblReset"
        lblReset.Size = New Size(301, 54)
        lblReset.TabIndex = 0
        lblReset.Text = "Reset Password"
        ' 
        ' lblNew
        ' 
        lblNew.AutoSize = True
        lblNew.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblNew.Location = New Point(126, 290)
        lblNew.Name = "lblNew"
        lblNew.Size = New Size(171, 32)
        lblNew.TabIndex = 1
        lblNew.Text = "New Password"
        ' 
        ' lblReenter
        ' 
        lblReenter.AutoSize = True
        lblReenter.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblReenter.Location = New Point(126, 433)
        lblReenter.Name = "lblReenter"
        lblReenter.Size = New Size(273, 32)
        lblReenter.TabIndex = 2
        lblReenter.Text = "Re-enter New Password"
        ' 
        ' txtEnter
        ' 
        txtEnter.Location = New Point(126, 337)
        txtEnter.Name = "txtEnter"
        txtEnter.Size = New Size(395, 31)
        txtEnter.TabIndex = 3
        ' 
        ' txtReenter
        ' 
        txtReenter.Location = New Point(126, 477)
        txtReenter.Name = "txtReenter"
        txtReenter.Size = New Size(395, 31)
        txtReenter.TabIndex = 4
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(263, 571)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(112, 34)
        btnReset.TabIndex = 5
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' picbxArrow
        ' 
        picbxArrow.Image = CType(resources.GetObject("picbxArrow.Image"), Image)
        picbxArrow.Location = New Point(33, 44)
        picbxArrow.Name = "picbxArrow"
        picbxArrow.Size = New Size(32, 19)
        picbxArrow.SizeMode = PictureBoxSizeMode.StretchImage
        picbxArrow.TabIndex = 15
        picbxArrow.TabStop = False
        ' 
        ' lblUser
        ' 
        lblUser.AutoSize = True
        lblUser.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUser.Location = New Point(126, 168)
        lblUser.Name = "lblUser"
        lblUser.Size = New Size(124, 32)
        lblUser.TabIndex = 17
        lblUser.Text = "Username"
        ' 
        ' txtUser
        ' 
        txtUser.Location = New Point(126, 215)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(395, 31)
        txtUser.TabIndex = 16
        ' 
        ' Form8
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(688, 708)
        Controls.Add(lblUser)
        Controls.Add(txtUser)
        Controls.Add(picbxArrow)
        Controls.Add(btnReset)
        Controls.Add(txtReenter)
        Controls.Add(txtEnter)
        Controls.Add(lblReenter)
        Controls.Add(lblNew)
        Controls.Add(lblReset)
        Name = "Form8"
        Text = "Claim It"
        CType(picbxArrow, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblReset As Label
    Friend WithEvents lblNew As Label
    Friend WithEvents lblReenter As Label
    Friend WithEvents txtEnter As TextBox
    Friend WithEvents txtReenter As TextBox
    Friend WithEvents btnReset As Button
    Friend WithEvents picbxArrow As PictureBox
    Friend WithEvents lblUser As Label
    Friend WithEvents txtUser As TextBox
End Class
