Public Class Sandovala_Lab1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtFirst_TextChanged(sender As Object, e As EventArgs) Handles txtFirst.TextChanged
        txtFirst.ForeColor = Color.Blue
    End Sub

    Private Sub btnRed_Click(sender As Object, e As EventArgs) Handles btnRed.Click
        txtFirst.ForeColor = Color.Red
    End Sub

    Private Sub txtFirst_Leave(sender As Object, e As EventArgs) Handles txtFirst.Leave
        txtFirst.ForeColor = Color.Black
    End Sub
End Class
