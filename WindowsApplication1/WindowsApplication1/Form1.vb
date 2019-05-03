Public Class Form1



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        RectangleShape2.Width += 5
        If RectangleShape2.Width > 493 Then
            Form2.Show()
            Timer1.Stop()
            Timer1.Enabled = False
            Me.Hide()
        End If
    End Sub
End Class
