Imports System
Imports System.Random


Public Class Form1
    Private Function RandomNumber(ByVal min As Integer, ByVal max As Integer) As Integer
        Dim random As New Random()
        Return random.Next(min, max)
    End Function 'RandomNumber

    Private Sub TimerBlue1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerBlue1.Tick
        

        Dim rw As Integer = CInt(Int((Me.Width * Rnd()) + 1)) - Label2.Width
        Dim ry As Integer = CInt(Int((Me.Height * Rnd()) + 1)) - Label2.Height



        Label2.Location = New Point(rw, ry)
    End Sub

    Private Sub TimerPink_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerPink.Tick
        Dim rw As Integer = CInt(Int((Me.Width * Rnd()) + 1)) - Label1.Width
        Dim ry As Integer = CInt(Int((Me.Height * Rnd()) + 1)) - Label1.Height



        Label1.Location = New Point(rw, ry)



    End Sub

    Private Sub TimerBlue3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerBlue3.Tick
        Dim rw As Integer = CInt(Int((Me.Width * Rnd()) + 1)) - Label4.Width
        Dim ry As Integer = CInt(Int((Me.Height * Rnd()) + 1)) - Label4.Height



        Label4.Location = New Point(rw, ry)
    End Sub

    Private Sub TimerBlue2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerBlue2.Tick
        Dim rw As Integer = CInt(Int((Me.Width * Rnd()) + 1)) - Label3.Width
        Dim ry As Integer = CInt(Int((Me.Height * Rnd()) + 1)) - Label3.Height



        Label3.Location = New Point(rw, ry)
    End Sub

    Private Sub TimerTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerTime.Tick
        'Dim i As Single = Label5.Text
        Label5.Text += 0.01
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TimerBlue1.Enabled = True
        TimerBlue2.Enabled = True
        TimerBlue3.Enabled = True
        TimerPink.Enabled = True
        TimerTime.Enabled = True

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        TimerBlue1.Enabled = False
        TimerBlue2.Enabled = False
        TimerBlue3.Enabled = False
        TimerPink.Enabled = False
        TimerTime.Enabled = False
        Label6.Visible = True

    End Sub

    Private Sub Label1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.DoubleClick
        TimerBlue1.Enabled = False
        TimerBlue2.Enabled = False
        TimerBlue3.Enabled = False
        TimerPink.Enabled = False
        TimerTime.Enabled = False
        Label6.Visible = True
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        TimerBlue1.Enabled = False
        TimerBlue2.Enabled = False
        TimerBlue3.Enabled = False
        TimerPink.Enabled = False
        TimerTime.Enabled = False
        Label6.Visible = True
    End Sub
End Class
