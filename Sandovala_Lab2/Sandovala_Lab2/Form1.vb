Public Class btn_Calculate


    Private Sub btn_CalculateTotals_Click_1(sender As Object, e As EventArgs) Handles btn_CalculateTotals.Click
        Dim pennyCount As Integer
        Dim nickelCount As Integer
        Dim dimeCount As Integer
        Dim quarterCount As Integer
        Dim halfDollarCount As Integer
        Dim total As Double

        pennyCount = txt_Penny.Text
        nickelCount = txt_Nickel.Text
        dimeCount = txt_Dime.Text
        quarterCount = txt_Quarter.Text
        halfDollarCount = txt_HalfDollar.Text

        total = TotPennies_amount(pennyCount) + TotNickles_amount(nickelCount) + TotDimes_amount(dimeCount) +
                TotQuarters_amount(quarterCount) + TotHalfDollars_amount(halfDollarCount)

        Output_totalAmount(total)

    End Sub

    Function TotPennies_amount(ByVal n) As Double
        Return 0.01 * n
    End Function

    Function TotNickles_amount(ByVal n) As Double
        Return 0.05 * n
    End Function

    Function TotDimes_amount(ByVal n) As Double
        Return 0.1 * n
    End Function

    Function TotQuarters_amount(ByVal n) As Double
        Return 0.25 * n
    End Function

    Function TotHalfDollars_amount(ByVal n) As Double
        Return 0.5 * n
    End Function
    Sub Output_totalAmount(ByVal DecTotal)
        txt_total.Text = CStr(FormatCurrency(DecTotal, 2))
    End Sub


    Private Sub btn_Reset_Click(sender As Object, e As EventArgs) Handles btn_Reset.Click
        txt_Penny.Clear()
        txt_Nickel.Clear()
        txt_Dime.Clear()
        txt_Quarter.Clear()
        txt_HalfDollar.Clear()
        txt_total.Clear()
    End Sub

    Private Sub btn_Quit_Click(sender As Object, e As EventArgs) Handles btn_Quit.Click
        Application.Exit()
    End Sub
End Class
