Imports System.Threading

Public Class Form1

    Public Sub colorchange()

        '  If Label1.BackColor = Color.Red Then
        'Label1.BackColor = Color.Blue
        'ElseIf Label1.BackColor = Color.Blue Then
        'Label1.BackColor = Color.Yellow
        'ElseIf Label1.BackColor = Color.Yellow Then
        '    Label1.BackColor = Color.Green
        '   ElseIf Label1.BackColor = Color.Green Then
        '  Label1.BackColor = Color.Black
        ' ElseIf Label1.BackColor = Color.Black Then
        '     Label1.BackColor = Color.Magenta
        '    ElseIf Label1.BackColor = Color.Magenta Then
        '   Label1.BackColor = Color.White
        '  Else
        '  Label1.BackColor = Color.Red
        ' End If
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Dim x1 As Integer = PictureBox2.Location.X
        Dim y1 As Integer = PictureBox2.Location.Y
        Dim color1 As Color = Color.Red
        Dim color2 As Color = Color.Blue

        If e.KeyCode = Keys.Up Then

            y1 -= 5
            Thread.Sleep(500)
            PictureBox1.Location = New Point(x1, y1)
            y1 -= 5

            Thread.Sleep(500)
            PictureBox1.Location = New Point(x1, y1)
            y1 += 5

            Thread.Sleep(500)
            PictureBox1.Location = New Point(x1, y1)
            y1 += 5
            'PictureBox1.Image = My.Resources.fox_side_scroller
            Thread.Sleep(500)
            PictureBox1.Location = New Point(x1, y1)
            colorchange()
        ElseIf e.KeyCode = Keys.Down Then
            y1 += 5
            PictureBox1.Location = New Point(x1, y1)
            colorchange()
        ElseIf e.KeyCode = Keys.Left Then
            x1 += 10
            PictureBox2.Location = New Point(x1, y1)
            colorchange()
        ElseIf e.KeyCode = Keys.Right Then
            x1 -= 10
            PictureBox2.Location = New Point(x1, y1)
            colorchange()

        End If

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
