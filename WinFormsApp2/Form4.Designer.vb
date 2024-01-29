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
        rock = New Button()
        paper = New Button()
        scissor = New Button()
        Label3 = New Label()
        Label4 = New Label()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' rock
        ' 
        rock.BackColor = Color.FromArgb(CByte(128), CByte(64), CByte(64))
        rock.Font = New Font("Showcard Gothic", 48F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        rock.Location = New Point(117, 277)
        rock.Name = "rock"
        rock.Size = New Size(122, 90)
        rock.TabIndex = 4
        rock.Text = "👊"
        rock.UseVisualStyleBackColor = False
        ' 
        ' paper
        ' 
        paper.BackColor = Color.FromArgb(CByte(128), CByte(64), CByte(64))
        paper.Font = New Font("Algerian", 48F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        paper.Location = New Point(330, 277)
        paper.Name = "paper"
        paper.Size = New Size(129, 90)
        paper.TabIndex = 5
        paper.Text = "📜"
        paper.UseVisualStyleBackColor = False
        ' 
        ' scissor
        ' 
        scissor.BackColor = Color.FromArgb(CByte(128), CByte(64), CByte(64))
        scissor.Font = New Font("Stencil", 36F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        scissor.Location = New Point(519, 277)
        scissor.Name = "scissor"
        scissor.Size = New Size(135, 90)
        scissor.TabIndex = 6
        scissor.Text = "✂️"
        scissor.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(341, 86)
        Label3.Name = "Label3"
        Label3.Size = New Size(96, 47)
        Label3.TabIndex = 7
        Label3.Text = "view"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(632, 385)
        Label4.Name = "Label4"
        Label4.Size = New Size(87, 50)
        Label4.TabIndex = 8
        Label4.Text = "exit"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 27.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 385)
        Label1.Name = "Label1"
        Label1.Size = New Size(112, 50)
        Label1.TabIndex = 9
        Label1.Text = "Score"
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Salmon
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(scissor)
        Controls.Add(paper)
        Controls.Add(rock)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Form4"
        Text = "Form4"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents rock As Button
    Friend WithEvents paper As Button
    Friend WithEvents scissor As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
End Class
