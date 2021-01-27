Public Class Form1
    Dim actualPassword As String
    Dim guessedPassword As String
    Private Sub btn_Set_Click(sender As Object, e As EventArgs) Handles btn_Set.Click
        actualPassword = txt_InputPassword.Text
    End Sub

    Private Sub btn_Guess_Click(sender As Object, e As EventArgs) Handles btn_Guess.Click
        Dim J As Integer
        Dim passwordLength As Integer

        passwordLength = actualPassword.Length

        For J = 1 To passwordLength
            Dim actualPassword_char As Char = actualPassword.Substring(J - 1, 1)
            Dim i As Integer = 1
            Do While ((Chr(i) <> actualPassword_char) And (i <= 255))
                i = i + 1
            Loop
            guessedPassword &= actualPassword_char
        Next J
        txt_thePasswordIs.Text = guessedPassword
    End Sub

    Private Sub btn_Quit_Click(sender As Object, e As EventArgs) Handles btn_Quit.Click
        Application.Exit()
    End Sub

    Private Sub btn_Reset_Click(sender As Object, e As EventArgs) Handles btn_Reset.Click
        txt_InputPassword.Clear()
        txt_thePasswordIs.Clear()
        actualPassword = ""
        guessedPassword = ""
    End Sub

End Class
