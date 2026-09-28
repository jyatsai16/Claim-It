<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        lblSignIn = New Label()
        txtUser = New TextBox()
        txtPassword = New TextBox()
        lblUser = New Label()
        lblPassword = New Label()
        btnLogin = New Button()
        lblAccount = New Label()
        llblSignup = New LinkLabel()
        llblForgot = New LinkLabel()
        SuspendLayout()
        ' 
        ' lblSignIn
        ' 
        lblSignIn.AutoSize = True
        lblSignIn.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSignIn.Location = New Point(231, 64)
        lblSignIn.Name = "lblSignIn"
        lblSignIn.Size = New Size(185, 65)
        lblSignIn.TabIndex = 0
        lblSignIn.Text = "Sign In"
        ' 
        ' txtUser
        ' 
        txtUser.Location = New Point(127, 236)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(395, 31)
        txtUser.TabIndex = 1
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(127, 376)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(395, 31)
        txtPassword.TabIndex = 2
        ' 
        ' lblUser
        ' 
        lblUser.AutoSize = True
        lblUser.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUser.Location = New Point(127, 189)
        lblUser.Name = "lblUser"
        lblUser.Size = New Size(124, 32)
        lblUser.TabIndex = 3
        lblUser.Text = "Username"
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPassword.Location = New Point(127, 332)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(115, 32)
        lblPassword.TabIndex = 4
        lblPassword.Text = "Password"
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(288, 528)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(112, 50)
        btnLogin.TabIndex = 6
        btnLogin.Text = "Log In"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' lblAccount
        ' 
        lblAccount.AutoSize = True
        lblAccount.Location = New Point(155, 602)
        lblAccount.Name = "lblAccount"
        lblAccount.Size = New Size(197, 25)
        lblAccount.TabIndex = 7
        lblAccount.Text = "Don't have an account?"
        ' 
        ' llblSignup
        ' 
        llblSignup.AutoSize = True
        llblSignup.Location = New Point(370, 602)
        llblSignup.Name = "llblSignup"
        llblSignup.Size = New Size(75, 25)
        llblSignup.TabIndex = 8
        llblSignup.TabStop = True
        llblSignup.Text = "Sign Up"
        ' 
        ' llblForgot
        ' 
        llblForgot.AutoSize = True
        llblForgot.LinkColor = Color.Black
        llblForgot.Location = New Point(127, 437)
        llblForgot.Name = "llblForgot"
        llblForgot.Size = New Size(197, 25)
        llblForgot.TabIndex = 9
        llblForgot.TabStop = True
        llblForgot.Text = "Forgot your password?"
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(688, 708)
        Controls.Add(llblForgot)
        Controls.Add(llblSignup)
        Controls.Add(lblAccount)
        Controls.Add(btnLogin)
        Controls.Add(lblPassword)
        Controls.Add(lblUser)
        Controls.Add(txtPassword)
        Controls.Add(txtUser)
        Controls.Add(lblSignIn)
        Name = "Form5"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Claim It"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblSignIn As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblUser As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents Label3l As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents llblSignup As LinkLabel
    Friend WithEvents llblForgot As LinkLabel
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblAccount As Label
End Class
