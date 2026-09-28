<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        lblSignUp = New Label()
        lblPassword = New Label()
        lblUser = New Label()
        txtPassword = New TextBox()
        txtUser = New TextBox()
        lblReenter = New Label()
        txtReenter = New TextBox()
        chkbxAgree = New CheckBox()
        llblTerms = New LinkLabel()
        btnSignup = New Button()
        picbxArrow = New PictureBox()
        CType(picbxArrow, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblSignUp
        ' 
        lblSignUp.AutoSize = True
        lblSignUp.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSignUp.Location = New Point(231, 64)
        lblSignUp.Name = "lblSignUp"
        lblSignUp.Size = New Size(206, 65)
        lblSignUp.TabIndex = 1
        lblSignUp.Text = "Sign Up"
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPassword.Location = New Point(127, 258)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(115, 32)
        lblPassword.TabIndex = 13
        lblPassword.Text = "Password"
        ' 
        ' lblUser
        ' 
        lblUser.AutoSize = True
        lblUser.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUser.Location = New Point(127, 146)
        lblUser.Name = "lblUser"
        lblUser.Size = New Size(124, 32)
        lblUser.TabIndex = 12
        lblUser.Text = "Username"
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(127, 314)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(395, 31)
        txtPassword.TabIndex = 11
        ' 
        ' txtUser
        ' 
        txtUser.Location = New Point(127, 195)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(395, 31)
        txtUser.TabIndex = 10
        ' 
        ' lblReenter
        ' 
        lblReenter.AutoSize = True
        lblReenter.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblReenter.Location = New Point(127, 382)
        lblReenter.Name = "lblReenter"
        lblReenter.Size = New Size(217, 32)
        lblReenter.TabIndex = 14
        lblReenter.Text = "Re-enter Password"
        ' 
        ' txtReenter
        ' 
        txtReenter.Location = New Point(127, 429)
        txtReenter.Name = "txtReenter"
        txtReenter.Size = New Size(395, 31)
        txtReenter.TabIndex = 15
        ' 
        ' chkbxAgree
        ' 
        chkbxAgree.AutoSize = True
        chkbxAgree.Location = New Point(146, 486)
        chkbxAgree.Name = "chkbxAgree"
        chkbxAgree.Size = New Size(160, 29)
        chkbxAgree.TabIndex = 16
        chkbxAgree.Text = "I agree with the"
        chkbxAgree.UseVisualStyleBackColor = True
        ' 
        ' llblTerms
        ' 
        llblTerms.AutoSize = True
        llblTerms.LinkColor = Color.Black
        llblTerms.Location = New Point(297, 487)
        llblTerms.Name = "llblTerms"
        llblTerms.Size = New Size(180, 25)
        llblTerms.TabIndex = 17
        llblTerms.TabStop = True
        llblTerms.Text = "terms and conditions"
        ' 
        ' btnSignup
        ' 
        btnSignup.Location = New Point(285, 554)
        btnSignup.Name = "btnSignup"
        btnSignup.Size = New Size(112, 34)
        btnSignup.TabIndex = 18
        btnSignup.Text = "Sign Up"
        btnSignup.UseVisualStyleBackColor = True
        ' 
        ' picbxArrow
        ' 
        picbxArrow.Image = CType(resources.GetObject("picbxArrow.Image"), Image)
        picbxArrow.Location = New Point(47, 85)
        picbxArrow.Name = "picbxArrow"
        picbxArrow.Size = New Size(32, 19)
        picbxArrow.SizeMode = PictureBoxSizeMode.StretchImage
        picbxArrow.TabIndex = 19
        picbxArrow.TabStop = False
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(688, 708)
        Controls.Add(picbxArrow)
        Controls.Add(btnSignup)
        Controls.Add(llblTerms)
        Controls.Add(chkbxAgree)
        Controls.Add(txtReenter)
        Controls.Add(lblReenter)
        Controls.Add(lblPassword)
        Controls.Add(lblUser)
        Controls.Add(txtPassword)
        Controls.Add(txtUser)
        Controls.Add(lblSignUp)
        Name = "Form6"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Claim It"
        CType(picbxArrow, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblSignUp As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents lblReenter As Label
    Friend WithEvents txtReenter As TextBox
    Friend WithEvents chkbxAgree As CheckBox
    Friend WithEvents llblTerms As LinkLabel
    Friend WithEvents btnSignup As Button
    Friend WithEvents picbxArrow As PictureBox
End Class
