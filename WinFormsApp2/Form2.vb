Imports System.Configuration

Public Class Form2
    Dim first As Double
    Dim second As Double
    Dim operand As String
    Dim operator_selector As Boolean = False
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text = TextBox1.Text & sender.text

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = TextBox1.Text & sender.text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = TextBox1.Text & sender.text

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = TextBox1.Text & sender.text

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = TextBox1.Text & sender.text

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = TextBox1.Text & sender.text

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = TextBox1.Text & sender.text

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Text = TextBox1.Text & sender.text

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Text = TextBox1.Text & sender.text

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox1.Text = TextBox1.Text & sender.text

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        first = Val(TextBox1.Text)
        TextBox1.Text = ""
        TextBox1.Focus()
        operand = "+"

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        first = Val(TextBox1.Text)
        TextBox1.Text = ""
        TextBox1.Focus()
        operand = "-"

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        first = Val(TextBox1.Text)
        TextBox1.Text = ""
        TextBox1.Focus()
        operand = "/"

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        first = Val(TextBox1.Text)
        TextBox1.Text = ""
        operator_selector = True
        operand = "*"

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim Result As Double
        second = Val(TextBox1.Text)

        Select Case operand
            Case "+"
                Result = first + second
                TextBox1.Text = Result.ToString()
            Case "-"
                Result = first - second
                TextBox1.Text = Result.ToString()
            Case "*"
                Result = first * second
                TextBox1.Text = Result.ToString()
            Case "/"
                Result = first / second
                TextBox1.Text = Result.ToString()
        End Select


    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Form3.Show()
        Me.Hide()

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class