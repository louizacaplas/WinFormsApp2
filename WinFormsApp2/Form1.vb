﻿Public Class Form1
    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click

        If TextBox1.Text = "Admin" And TextBox2.Text = "123" Then
            MessageBox.Show("Login Success")
            Form3.Show()


        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
