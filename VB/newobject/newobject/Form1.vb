Public Class Form1
    Dim i As Integer = 0
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim btn As New Label
        Dim rand As New Random
        Dim randmaxX As Integer = Me.Width
        Dim randmaxY As Integer = Me.Height

        btn.Name = "Brandan" & i
        i += 1
        Me.Controls.Add(btn)
        btn.Location = New Point(rand.Next(randmaxX - btn.Width), rand.Next(randmaxY - btn.Height))
        btn.ForeColor = Color.Black
        btn.Text = "Hello"


    End Sub
End Class
