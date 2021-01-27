Public Class Form1

    Private Sub btn_Calculate_Click(sender As Object, e As EventArgs) Handles btn_Calculate.Click
        Dim tankCapacity As Double
        Dim milesPerTank As Double
        Dim milesPerGallon As Double

        tankCapacity = CDbl(txt_TankCapacity.Text)
        milesPerTank = CDbl(txt_MilesDriven.Text)

        milesPerGallon = milesPerTank / tankCapacity

        txt_MilesPerGallon.Text = CStr(FormatNumber(milesPerGallon, 2))

    End Sub

    Private Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click
        txt_TankCapacity.Clear()
        txt_MilesDriven.Clear()
        txt_MilesPerGallon.Clear()
    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Application.Exit()
    End Sub
End Class
