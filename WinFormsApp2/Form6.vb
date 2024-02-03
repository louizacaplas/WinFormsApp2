Imports System.Reflection.Emit

Public Class Form6
    Dim playerPosition As Integer = 1
    Dim isDone As Boolean = False

    Private Sub START_Click(sender As Object, e As EventArgs) Handles START.Click
        TILE1.Enabled = True
        TILE2.Enabled = True
        START.Enabled = False
        TILE3.Enabled = False
        TILE4.Enabled = False
        TILE5.Enabled = False
        TILE6.Enabled = False
        TILE7.Enabled = False
        TILE8.Enabled = False
        TILR9.Enabled = False
        TILE10.Enabled = False
        TILE11.Enabled = False
        TILE12.Enabled = False
        Label1.Text = ""
    End Sub

    Private Sub TILE1_Click(sender As Object, e As EventArgs) Handles TILE1.Click
        TILE1.Enabled = False
        TILE2.Enabled = False
        TILE3.Enabled = True
        TILE4.Enabled = True
        TILE5.Enabled = False
        TILE6.Enabled = False
        TILE7.Enabled = False
        TILE8.Enabled = False
        TILR9.Enabled = False
        TILE10.Enabled = False
        TILE11.Enabled = False
        TILE12.Enabled = False
        randomFoot()
    End Sub

    Private Sub TILE2_Click(sender As Object, e As EventArgs) Handles TILE2.Click
        TILE1.Enabled = False
        TILE2.Enabled = False
        TILE3.Enabled = True
        TILE4.Enabled = True
        TILE5.Enabled = False
        TILE6.Enabled = False
        TILE7.Enabled = False
        TILE8.Enabled = False
        TILR9.Enabled = False
        TILE10.Enabled = False
        TILE11.Enabled = False
        TILE12.Enabled = False
        randomFoot()
    End Sub

    Private Sub TILE3_Click(sender As Object, e As EventArgs) Handles TILE3.Click
        TILE1.Enabled = False
        TILE2.Enabled = False
        TILE3.Enabled = False
        TILE4.Enabled = False
        TILE5.Enabled = True
        TILE6.Enabled = True
        TILE7.Enabled = False
        TILE8.Enabled = False
        TILR9.Enabled = False
        TILE10.Enabled = False
        TILE11.Enabled = False
        TILE12.Enabled = False
        randomFoot()
    End Sub

    Private Sub TILE4_Click(sender As Object, e As EventArgs) Handles TILE4.Click
        TILE1.Enabled = False
        TILE2.Enabled = False
        TILE3.Enabled = False
        TILE4.Enabled = False
        TILE5.Enabled = True
        TILE6.Enabled = True
        TILE7.Enabled = False
        TILE8.Enabled = False
        TILR9.Enabled = False
        TILE10.Enabled = False
        TILE11.Enabled = False
        TILE12.Enabled = False
        randomFoot()
    End Sub

    Private Sub TILE5_Click(sender As Object, e As EventArgs) Handles TILE5.Click
        TILE1.Enabled = False
        TILE2.Enabled = False
        TILE3.Enabled = False
        TILE4.Enabled = False
        TILE5.Enabled = False
        TILE6.Enabled = False
        TILE7.Enabled = True
        TILE8.Enabled = True
        TILR9.Enabled = False
        TILE10.Enabled = False
        TILE11.Enabled = False
        TILE12.Enabled = False
        randomFoot()
    End Sub

    Private Sub TILE6_Click(sender As Object, e As EventArgs) Handles TILE6.Click
        TILE1.Enabled = False
        TILE2.Enabled = False
        TILE3.Enabled = False
        TILE4.Enabled = False
        TILE5.Enabled = False
        TILE6.Enabled = False
        TILE7.Enabled = True
        TILE8.Enabled = True
        TILR9.Enabled = False
        TILE10.Enabled = False
        TILE11.Enabled = False
        TILE12.Enabled = False
        randomFoot()
    End Sub

    Private Sub TILE7_Click(sender As Object, e As EventArgs) Handles TILE7.Click
        TILE1.Enabled = False
        TILE2.Enabled = False
        TILE3.Enabled = False
        TILE4.Enabled = False
        TILE5.Enabled = False
        TILE6.Enabled = False
        TILE7.Enabled = False
        TILE8.Enabled = False
        TILR9.Enabled = True
        TILE10.Enabled = True
        TILE11.Enabled = False
        TILE12.Enabled = False
        randomFoot()
    End Sub

    Private Sub TILE8_Click(sender As Object, e As EventArgs) Handles TILE8.Click
        TILE1.Enabled = False
        TILE2.Enabled = False
        TILE3.Enabled = False
        TILE4.Enabled = False
        TILE5.Enabled = False
        TILE6.Enabled = False
        TILE7.Enabled = False
        TILE8.Enabled = False
        TILR9.Enabled = True
        TILE10.Enabled = True
        TILE11.Enabled = False
        TILE12.Enabled = False
        randomFoot()
    End Sub

    Private Sub TILR9_Click(sender As Object, e As EventArgs) Handles TILR9.Click
        TILE1.Enabled = False
        TILE2.Enabled = False
        TILE3.Enabled = False
        TILE4.Enabled = False
        TILE5.Enabled = False
        TILE6.Enabled = False
        TILE7.Enabled = False
        TILE8.Enabled = False
        TILR9.Enabled = False
        TILE10.Enabled = False
        TILE11.Enabled = True
        TILE12.Enabled = True
        randomFoot()
    End Sub

    Private Sub TILE10_Click(sender As Object, e As EventArgs) Handles TILE10.Click
        TILE1.Enabled = False
        TILE2.Enabled = False
        TILE3.Enabled = False
        TILE4.Enabled = False
        TILE5.Enabled = False
        TILE6.Enabled = False
        TILE7.Enabled = False
        TILE8.Enabled = False
        TILR9.Enabled = False
        TILE10.Enabled = False
        TILE11.Enabled = True
        TILE12.Enabled = True
        randomFoot()
    End Sub

    Private Sub TILE11_Click(sender As Object, e As EventArgs) Handles TILE11.Click

        lastGlas()
    End Sub

    Private Sub TILE12_Click(sender As Object, e As EventArgs) Handles TILE12.Click

        lastGlas()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Label1.Text = "You Won!"
        resetGame()
    End Sub

    Private Sub gameOver()
        isDone = True
        If isDone Then
            Label1.Text = "You Lose!"
            resetGame()
        End If
    End Sub

    Private Sub randomFoot()
        Dim rando As Integer = GetRandom(1, 3)
        If rando = 1 Then
            gameOver()
        Else
            Label1.Text = "👍"
        End If

    End Sub
    Private Sub lastGlas()
        Dim rando As Integer = GetRandom(1, 3)
        If rando = 1 Then
            gameOver()
        Else
            TILE11.Enabled = False
            TILE12.Enabled = False
            label2.Enabled = True
            ENDED.Enabled = True


        End If

    End Sub

    Private Sub resetGame()
        START.Enabled = True
        TILE1.Enabled = False
        TILE2.Enabled = False
        TILE3.Enabled = False
        TILE4.Enabled = False
        TILE5.Enabled = False
        TILE6.Enabled = False
        TILE7.Enabled = False
        TILE8.Enabled = False
        TILR9.Enabled = False
        TILE10.Enabled = False
        TILE11.Enabled = False
        TILE12.Enabled = False
        label2.Enabled = False
    End Sub
    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Dim Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)
    End Function

    Private Sub EXITT_Click(sender As Object, e As EventArgs) Handles EXITT.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        START.Enabled = True
        TILE1.Enabled = False
        TILE2.Enabled = False
        TILE3.Enabled = False
        TILE4.Enabled = False
        TILE5.Enabled = False
        TILE6.Enabled = False
        TILE7.Enabled = False
        TILE8.Enabled = False
        TILR9.Enabled = False
        TILE10.Enabled = False
        TILE11.Enabled = False
        TILE12.Enabled = False
        label2.Enabled = False
        ENDED.Enabled = False
    End Sub

    Private Sub label2_Click(sender As Object, e As EventArgs) Handles label2.Click

    End Sub

    Private Sub ENDED_Click(sender As Object, e As EventArgs) Handles ENDED.Click
        ENDED.Enabled = False
        label2.Enabled = False
        resetGame()
    End Sub
End Class

