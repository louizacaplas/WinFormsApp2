Imports System.Reflection.Emit

Public Class Form6
    Dim playerPosition As Integer = 1
    Dim isDone As Boolean = False
    Private Sub START_Click(sender As Object, e As EventArgs) Handles START.Click
        TILE1.Enabled = True
        TILE2.Enabled = True
        START.Enabled = False
        .Text = ""
    End Sub
End Class