<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form7))
        lblTerms = New Label()
        RichTextBox1 = New RichTextBox()
        btnReturn = New Button()
        SuspendLayout()
        ' 
        ' lblTerms
        ' 
        lblTerms.AutoSize = True
        lblTerms.Font = New Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTerms.Location = New Point(105, -4)
        lblTerms.Name = "lblTerms"
        lblTerms.Size = New Size(453, 65)
        lblTerms.TabIndex = 0
        lblTerms.Text = "Terms + Conditions"
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New Point(12, 74)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.ReadOnly = True
        RichTextBox1.Size = New Size(664, 563)
        RichTextBox1.TabIndex = 1
        RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        ' 
        ' btnReturn
        ' 
        btnReturn.Location = New Point(248, 653)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(157, 34)
        btnReturn.TabIndex = 2
        btnReturn.Text = "Return"
        btnReturn.UseVisualStyleBackColor = True
        ' 
        ' Form7
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(688, 708)
        Controls.Add(btnReturn)
        Controls.Add(RichTextBox1)
        Controls.Add(lblTerms)
        Name = "Form7"
        Text = "Claim It"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTerms As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents btnReturn As Button
End Class
