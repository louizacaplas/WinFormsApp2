Public Class Form4

    Dim score As Integer = 0
    Dim rand As New Random
    Dim strcompture() As String = {"rock", "paper", "scissor"}

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Label1.Text = score
    End Sub

    Private Sub rock_Click(sender As Object, e As EventArgs) Handles rock.Click
        Dim rand As Integer = GetRandom(0, 3)
        Label3.Text = strcompture(rand)
        If rand = 0 Then
            MessageBox.Show("Tie")
            Label3.Text = ""
        ElseIf rand = 1 Then
            MessageBox.Show("You Lose!")
            Label3.Text = ""
        Else
            MessageBox.Show("You Won!")
            score += 1
            Label3.Text = ""
            Label1.Text = score
        End If



    End Sub

    Private Sub paper_Click(sender As Object, e As EventArgs) Handles paper.Click
        Dim rand As Integer = Getrandom(0, 3)
        Label3.Text = strcompture(rand)
        If rand = 0 Then
            MessageBox.Show("You Won!")
            score += 1
            Label3.Text = ""
            Label1.Text = score
        ElseIf rand = 1 Then
            MessageBox.Show("Tie")
            Label3.Text = ""
        Else
            MessageBox.Show("You Lose!")
            Label3.Text = ""

        End If
    End Sub

    Private Sub scissor_Click(sender As Object, e As EventArgs) Handles scissor.Click
        Dim rand As Integer = GetRandom(0, 3)
        Label3.Text = strcompture(rand)
        If rand = 0 Then
            MessageBox.Show("You Lose!")
            Label3.Text = ""
        ElseIf rand = 1 Then
            MessageBox.Show("You Won!")
            score += 1
            Label3.Text = ""
            Label1.Text = score
        Else
            MessageBox.Show("Tie")
            Label3.Text = ""
        End If

    End Sub
    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Dim Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)
    End Function


    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Form3.Show()
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Label1.Text = score
    End Sub
End Class