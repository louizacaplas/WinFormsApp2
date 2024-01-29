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
        START = New Button()
        TILE1 = New Button()
        TILE2 = New Button()
        TILE3 = New Button()
        TILE4 = New Button()
        TILE5 = New Button()
        TILE6 = New Button()
        Button8 = New Button()
        TILE7 = New Button()
        TILE8 = New Button()
        TILR9 = New Button()
        TILE10 = New Button()
        TILE11 = New Button()
        TILE12 = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' START
        ' 
        START.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        START.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        START.Location = New Point(12, 131)
        START.Name = "START"
        START.Size = New Size(42, 261)
        START.TabIndex = 0
        START.Text = "START"
        START.UseVisualStyleBackColor = False
        ' 
        ' TILE1
        ' 
        TILE1.BackColor = Color.White
        TILE1.Location = New Point(89, 109)
        TILE1.Name = "TILE1"
        TILE1.Size = New Size(80, 68)
        TILE1.TabIndex = 1
        TILE1.UseVisualStyleBackColor = False
        ' 
        ' TILE2
        ' 
        TILE2.BackColor = Color.White
        TILE2.Location = New Point(89, 316)
        TILE2.Name = "TILE2"
        TILE2.Size = New Size(80, 76)
        TILE2.TabIndex = 2
        TILE2.UseVisualStyleBackColor = False
        ' 
        ' TILE3
        ' 
        TILE3.Location = New Point(229, 118)
        TILE3.Name = "TILE3"
        TILE3.Size = New Size(80, 68)
        TILE3.TabIndex = 3
        TILE3.UseVisualStyleBackColor = True
        ' 
        ' TILE4
        ' 
        TILE4.Location = New Point(229, 303)
        TILE4.Name = "TILE4"
        TILE4.Size = New Size(76, 72)
        TILE4.TabIndex = 4
        TILE4.UseVisualStyleBackColor = True
        ' 
        ' TILE5
        ' 
        TILE5.Location = New Point(354, 137)
        TILE5.Name = "TILE5"
        TILE5.Size = New Size(76, 72)
        TILE5.TabIndex = 5
        TILE5.UseVisualStyleBackColor = True
        ' 
        ' TILE6
        ' 
        TILE6.Location = New Point(354, 332)
        TILE6.Name = "TILE6"
        TILE6.Size = New Size(76, 76)
        TILE6.TabIndex = 6
        TILE6.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button8.Font = New Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button8.Location = New Point(819, 164)
        Button8.Name = "Button8"
        Button8.Size = New Size(42, 211)
        Button8.TabIndex = 7
        Button8.Text = "END"
        Button8.UseVisualStyleBackColor = False
        ' 
        ' TILE7
        ' 
        TILE7.Location = New Point(473, 91)
        TILE7.Name = "TILE7"
        TILE7.Size = New Size(75, 70)
        TILE7.TabIndex = 9
        TILE7.UseVisualStyleBackColor = True
        ' 
        ' TILE8
        ' 
        TILE8.Location = New Point(473, 303)
        TILE8.Name = "TILE8"
        TILE8.Size = New Size(75, 72)
        TILE8.TabIndex = 10
        TILE8.UseVisualStyleBackColor = True
        ' 
        ' TILR9
        ' 
        TILR9.Location = New Point(581, 131)
        TILR9.Name = "TILR9"
        TILR9.Size = New Size(75, 75)
        TILR9.TabIndex = 11
        TILR9.UseVisualStyleBackColor = True
        ' 
        ' TILE10
        ' 
        TILE10.Location = New Point(593, 332)
        TILE10.Name = "TILE10"
        TILE10.Size = New Size(75, 76)
        TILE10.TabIndex = 13
        TILE10.UseVisualStyleBackColor = True
        ' 
        ' TILE11
        ' 
        TILE11.Location = New Point(723, 89)
        TILE11.Name = "TILE11"
        TILE11.Size = New Size(75, 72)
        TILE11.TabIndex = 14
        TILE11.UseVisualStyleBackColor = True
        ' 
        ' TILE12
        ' 
        TILE12.Location = New Point(723, 303)
        TILE12.Name = "TILE12"
        TILE12.Size = New Size(75, 76)
        TILE12.TabIndex = 15
        TILE12.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.White
        Label1.Location = New Point(189, 441)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 15)
        Label1.TabIndex = 16
        Label1.Text = "Label1"
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(873, 519)
        Controls.Add(Label1)
        Controls.Add(TILE12)
        Controls.Add(TILE11)
        Controls.Add(TILE10)
        Controls.Add(TILR9)
        Controls.Add(TILE8)
        Controls.Add(TILE7)
        Controls.Add(Button8)
        Controls.Add(TILE6)
        Controls.Add(TILE5)
        Controls.Add(TILE4)
        Controls.Add(TILE3)
        Controls.Add(TILE2)
        Controls.Add(TILE1)
        Controls.Add(START)
        Name = "Form6"
        Text = "Form6"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents START As Button
    Friend WithEvents TILE1 As Button
    Friend WithEvents TILE2 As Button
    Friend WithEvents TILE3 As Button
    Friend WithEvents TILE4 As Button
    Friend WithEvents TILE5 As Button
    Friend WithEvents TILE6 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents TILE7 As Button
    Friend WithEvents TILE8 As Button
    Friend WithEvents TILR9 As Button
    Friend WithEvents TILE10 As Button
    Friend WithEvents TILE11 As Button
    Friend WithEvents TILE12 As Button
    Friend WithEvents Label1 As Label
End Class
