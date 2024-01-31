Public Class Form3
    Private Sub Calculator_Click(sender As Object, e As EventArgs) Handles Calculator.Click
        Form2.Show()
        Me.Close()

    End Sub

    Private Sub Janken_Click(sender As Object, e As EventArgs) Handles Janken.Click
        Form4.Show()
        Me.Close()
    End Sub

    Private Sub GlassGame_Click(sender As Object, e As EventArgs) Handles GlassGame.Click
        Form6.Show()
        Me.Close()
    End Sub
End Class