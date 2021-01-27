Public Class Form1
    Dim rand As New Random
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Timer1.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        DrawEllipse()

        DrawEllipse()

        DrawEllipse()

        DrawEllipse()


    End Sub

    Public Function DrawEllipse()
        Dim OurPen As Pen
        OurPen = New Pen(Color.FromArgb(255, rand.Next(255), rand.Next(255), rand.Next(255)), 7)
        Dim MyGraphics As Graphics = Me.CreateGraphics
        Dim n As Integer
        Dim a As Integer
        n = 1500

        MyGraphics.DrawEllipse(OurPen, CInt(Math.Ceiling(Rnd() * n)) + 1, CInt(Math.Ceiling(Rnd() * n)) + 1, 50, 25)
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        DrawEllipse()
    End Sub
End Class
