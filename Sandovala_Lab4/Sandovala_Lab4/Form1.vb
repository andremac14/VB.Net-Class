Public Class Form1
    Dim pizzaCount As Integer
    Dim fryCount As Integer
    Dim softDrinkCount As Integer
    Dim total As Double

    Dim pizzaPrice As Double = 1.25
    Dim fryPrice As Double = 1.0
    Dim softDrinkPrice As Double = 0.75

    Private Sub btn_Compute_Click(sender As Object, e As EventArgs) Handles btn_Compute.Click
        Input()
        Calculate()
        Output()
    End Sub

    Public Sub Input()
        pizzaCount = txt_SliceCount.Text
        fryCount = txt_FryCount.Text
        softDrinkCount = txt_SoftDrink.Text
    End Sub

    Public Sub Output()
        lst_Box.Items.Add("Item                  Quantity             Price")
        lst_Box.Items.Add("pizza slices                  " & pizzaCount & "             " & FormatCurrency(pizzaPrice, 2))
        lst_Box.Items.Add("fries                              " & fryCount & "            " & FormatCurrency(fryPrice, 2))
        lst_Box.Items.Add("soft drinks                    " & softDrinkCount & "             " & FormatCurrency(softDrinkPrice, 2))
        lst_Box.Items.Add("")
        lst_Box.Items.Add("Totals                                        " & FormatCurrency(total, 2))

    End Sub

    Function Calculate() As Double
        total = pizzaCount * pizzaPrice + fryCount * fryPrice + softDrinkCount * softDrinkPrice
    End Function

    Private Sub btn_Quit_Click(sender As Object, e As EventArgs) Handles btn_Quit.Click
        End
    End Sub

    Private Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click
        txt_SliceCount.Clear()
        txt_FryCount.Clear()
        txt_SoftDrink.Clear()
        lst_Box.Items.Clear()
    End Sub

    Private Sub lst_Box_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_Box.SelectedIndexChanged

    End Sub
End Class
