Imports System.IO

Public Class Form1
    Dim randomInt As Random = New Random()

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim intResX As Integer = Screen.PrimaryScreen.Bounds.Width - 900
        Dim intResY As Integer = Screen.PrimaryScreen.Bounds.Height
        Me.Left = intResX
        Me.Top = 0
        Timer1.Enabled = True

        PictureBox1.Image = System.Drawing.Image.FromFile(GetRandomImageFilePath())
        PictureBox2.Image = System.Drawing.Image.FromFile(GetRandomImageFilePath())
        PictureBox3.Image = System.Drawing.Image.FromFile(GetRandomImageFilePath())
        PictureBox4.Image = System.Drawing.Image.FromFile(GetRandomImageFilePath())
        PictureBox5.Image = System.Drawing.Image.FromFile(GetRandomImageFilePath())
        PictureBox6.Image = System.Drawing.Image.FromFile(GetRandomImageFilePath())
        PictureBox7.Image = System.Drawing.Image.FromFile(GetRandomImageFilePath())
        PictureBox8.Image = System.Drawing.Image.FromFile(GetRandomImageFilePath())
        PictureBox9.Image = System.Drawing.Image.FromFile(GetRandomImageFilePath())
        PictureBox10.Image = System.Drawing.Image.FromFile(GetRandomImageFilePath())
        PictureBox11.Image = System.Drawing.Image.FromFile(GetRandomImageFilePath())
        PictureBox12.Image = System.Drawing.Image.FromFile(GetRandomImageFilePath())
        PictureBox13.Image = System.Drawing.Image.FromFile(GetRandomImageFilePath())
    End Sub

    Public Function GetRandomImageFilePath() As String
        Dim userName1 As String = System.Environment.UserDomainName
        Dim userName As String = userName1.Substring(0, userName1.Length - 3)
        Dim files() As String = Directory.GetFiles("C:\Users\TNinja\Dropbox\Camera Uploads", "*.jpg")
        Dim random As Random = New Random()
        Return files(random.Next(0, files.Length - 1))
    End Function

    Public Sub ChangePicture()
        Select Case randomInt.Next(1, 15)
            Case 1
                PictureBox1.Image = System.Drawing.Image.FromFile(GetRandomImageFilePath())
            Case 2
                PictureBox2.Image = System.Drawing.Image.FromFile(GetRandomImageFilePath())
            Case 3
                PictureBox3.Image = System.Drawing.Image.FromFile(GetRandomImageFilePath())
            Case 4
                PictureBox4.Image = System.Drawing.Image.FromFile(GetRandomImageFilePath())
            Case 5
                PictureBox5.Image = System.Drawing.Image.FromFile(GetRandomImageFilePath())
            Case 6
                PictureBox6.Image = System.Drawing.Image.FromFile(GetRandomImageFilePath())
            Case 7
                PictureBox7.Image = System.Drawing.Image.FromFile(GetRandomImageFilePath())
            Case 8
                PictureBox8.Image = System.Drawing.Image.FromFile(GetRandomImageFilePath())
            Case 9
                PictureBox9.Image = System.Drawing.Image.FromFile(GetRandomImageFilePath())
            Case 10
                PictureBox10.Image = System.Drawing.Image.FromFile(GetRandomImageFilePath())
            Case 11
                PictureBox11.Image = System.Drawing.Image.FromFile(GetRandomImageFilePath())
            Case 12
                PictureBox12.Image = System.Drawing.Image.FromFile(GetRandomImageFilePath())
            Case 13
                PictureBox13.Image = System.Drawing.Image.FromFile(GetRandomImageFilePath())
        End Select
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        ChangePicture()
    End Sub
End Class
