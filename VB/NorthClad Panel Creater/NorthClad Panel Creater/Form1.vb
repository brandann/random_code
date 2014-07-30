Public Class Form1

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        picw1.Visible = True
        idlbl.Visible = True
        idtext.Visible = True
        qtylbl.Visible = True
        qtytext.Visible = True
        hlbl.Visible = True
        htext.Visible = True
        w1lbl.Visible = True
        w1text.Visible = True

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim submitpanel As String = idtext.Text & " Qty:" & qtytext.Text & " H:" & htext.Text & "x W:" & w1text.Text
        allist.Items.Add(submitpanel)

        idtext.Text = ""
        qtytext.Text = ""
        htext.Text = ""
        w1text.Text = ""


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class
