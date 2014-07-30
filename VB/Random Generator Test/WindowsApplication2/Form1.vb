Imports System.Threading

Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Timer1.Enabled = False Then
            Timer1.Enabled = True
        ElseIf Timer1.Enabled = True Then
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim randY As New Random
        Thread.Sleep(3)
        Dim randX As New Random
        Dim intRandY As Integer
        Dim intRandX As Integer
        intRandY = randY.Next(300)
        intRandX = randX.Next(300)
        Label1.Location = New Point(intRandX, intRandY)
    End Sub
End Class
