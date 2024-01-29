<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Login = New Button()
        txtUser = New Label()
        txtpass = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        SuspendLayout()
        ' 
        ' Login
        ' 
        Login.Location = New Point(408, 292)
        Login.Name = "Login"
        Login.Size = New Size(75, 23)
        Login.TabIndex = 0
        Login.Text = "Login"
        Login.UseVisualStyleBackColor = True
        ' 
        ' txtUser
        ' 
        txtUser.AutoSize = True
        txtUser.Location = New Point(111, 92)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(60, 15)
        txtUser.TabIndex = 1
        txtUser.Text = "Username"
        ' 
        ' txtpass
        ' 
        txtpass.AutoSize = True
        txtpass.Location = New Point(101, 220)
        txtpass.Name = "txtpass"
        txtpass.Size = New Size(57, 15)
        txtpass.TabIndex = 2
        txtpass.Text = "password"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(296, 92)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(310, 23)
        TextBox1.TabIndex = 3
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(296, 202)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(310, 23)
        TextBox2.TabIndex = 4
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(701, 450)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(txtpass)
        Controls.Add(txtUser)
        Controls.Add(Login)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Login As Button
    Friend WithEvents txtUser As Label
    Friend WithEvents txtpass As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox

End Class
