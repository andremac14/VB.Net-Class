Public Class Sandovala_SemesterAverages
    Dim average1 As Double = 0
    Dim average2 As Double = 0
    Dim average3 As Double = 0
    Dim sum1 As Integer = 0
    Dim sum2 As Integer = 0
    Dim sum3 As Integer = 0
    Dim word As String = ""
    Dim words(15) As String

    Private Sub btn_DisplayAverage_Click(sender As Object, e As EventArgs) Handles btn_DisplayAverage.Click
        Dim sr As New IO.StreamReader("F:/Data.TXT")
        Dim i As Integer = 0

        Dim average1 As Integer = 0
        Dim average2 As Integer = 0
        Dim average3 As Integer = 0

        'Loads the values intp the array
        Do Until sr.Peek = -1
            word = sr.ReadLine()
            words(i) = word
            i = i + 1
        Loop

        'Print statement
        lst_Display.Items.Add("Soc Sec. No.      Average")
        lst_Display.Items.Add("123-45-6789         " & CalculateAverage())
        lst_Display.Items.Add("111-11-1111         " & CalculateAverage2())
        lst_Display.Items.Add("123-32-1234         " & CalculateAverage3())

    End Sub

    'Calculates the average for the first social security number
    Function CalculateAverage()
        For i = 1 To 4
            sum1 = CInt(words(i)) + sum1

        Next
        average1 = sum1 / 4
        Return average1
    End Function

    'Calculates the average for the second social security number
    Function CalculateAverage2()
        For i = 6 To 9
            sum2 = CInt(words(i)) + sum2

        Next
        average2 = sum2 / 4
        Return average2
    End Function

    'Calculates the average for the third social security number
    Function CalculateAverage3()
        For i = 11 To 15
            sum3 = CInt(words(i)) + sum3

        Next
        average3 = sum3 / 4
        Return average3
    End Function

    Private Sub btn_Reset_Click(sender As Object, e As EventArgs) Handles btn_Reset.Click
        'Clears all the values 
        average1 = 0
        average2 = 0
        average3 = 0
        sum1 = 0
        sum2 = 0
        sum3 = 0
        'Clears the textbox
        lst_Display.Items.Clear()
    End Sub

    Private Sub btn_Quit_Click(sender As Object, e As EventArgs) Handles btn_Quit.Click
        End
    End Sub

End Class
