Public Class Form1

    Private Sub TextBox1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)

    End Sub

    Private Sub exitbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitbtn.Click
        Close()
    End Sub

    Private Sub feetbox_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles feetbox.MouseClick
        feetbox.Text = ""
    End Sub

    Private Sub inchbox_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles inchbox.MouseClick
        inchbox.Text = ""
    End Sub

    Private Sub qtybox_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles qtybox.MouseClick
        qtybox.Text = ""
    End Sub

    Private Sub jtbox_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles jtbox.MouseClick
        jtbox.Text = ""
    End Sub

    Private Sub lapbox_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lapbox.MouseClick
        lapbox.Text = ""
    End Sub

    Private Sub resetbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles resetbtn.Click
        feetbox.Text = "0"
        inchbox.Text = "0"
        qtybox.Text = "0"
        jtbox.Text = "0"
        lapbox.Text = "0"
        resultbox.Text = ""
    End Sub

    Private Sub helpbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles helpbtn.Click
        MsgBox("Welcome to the equal panel calculator! Here you can enter a total span of panels (like from corner to corner), input how many panels, and the joint size or lapped distance for light gauge panels to come up with a magic number! Please note that inches must be done in decimal format, no fractions yet, sorry!/nsend all questions about the program, sugestions for improving the program, bugs you may have found, or even just ideas for new and exciting programs to: Brandan@Northshoresheetmetal.com Thank you")
    End Sub

    Private Sub calcmod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calcmod.Click
        resultbox.Text = (((feetbox.Text * 12) + inchbox.Text) - (jtbox.Text * (qtybox.Text - 1))) / qtybox.Text

    End Sub

    Private Sub calclap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calclap.Click
        resultbox.Text = (((feetbox.Text * 12) + inchbox.Text) + (lapbox.Text * (qtybox.Text - 1))) / qtybox.Text
    End Sub
End Class
