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
        Calculator = New Button()
        Janken = New Button()
        GlassGame = New Button()
        SuspendLayout()
        ' 
        ' Calculator
        ' 
        Calculator.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        Calculator.Cursor = Cursors.SizeNESW
        Calculator.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Calculator.Location = New Point(97, 32)
        Calculator.Name = "Calculator"
        Calculator.Size = New Size(248, 91)
        Calculator.TabIndex = 0
        Calculator.Text = "Calculator"
        Calculator.UseVisualStyleBackColor = False
        ' 
        ' Janken
        ' 
        Janken.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        Janken.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Janken.Location = New Point(97, 171)
        Janken.Name = "Janken"
        Janken.Size = New Size(248, 87)
        Janken.TabIndex = 1
        Janken.Text = "Janken"
        Janken.UseVisualStyleBackColor = False
        ' 
        ' GlassGame
        ' 
        GlassGame.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        GlassGame.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        GlassGame.Location = New Point(97, 289)
        GlassGame.Name = "GlassGame"
        GlassGame.Size = New Size(248, 80)
        GlassGame.TabIndex = 2
        GlassGame.Text = "GlassGame"
        GlassGame.UseVisualStyleBackColor = False
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(450, 450)
        Controls.Add(GlassGame)
        Controls.Add(Janken)
        Controls.Add(Calculator)
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Calculator As Button
    Friend WithEvents Janken As Button
    Friend WithEvents GlassGame As Button
End Class
