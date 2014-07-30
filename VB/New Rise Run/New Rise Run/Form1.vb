Public Class Form1

    Private Sub Exitbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Exitbtn.Click
        Close()
    End Sub

    Private Sub Calcbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calcbtn.Click
        Dim length As Double = (FeetBox.Text * 12) + InchBox.Text
        Dim rise As Double = (risebox.Text / 12) * length
        Dim totalrooflength As Double = Math.Sqrt((length * length) + (rise * rise))

        LblSlope.Visible = True
        TotalLengthLbl.Text = Format(totalrooflength, "0.0000")
        TotalLengthLbl.Visible = True
        Archresult.Text = Int(totalrooflength / 12) & "'-" & Format((totalrooflength - (Int(totalrooflength / 12) * 12)), "0.0000")
        Archresult.Visible = True
    End Sub

    Private Sub ClearBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearBtn.Click
        risebox.Text = "1"
        FeetBox.Text = "0"
        InchBox.Text = "0"
        TotalLengthLbl.Text = "Roof Length"

        Archresult.Visible = False
        LblSlope.Visible = False
        TotalLengthLbl.Visible = False

    End Sub
End Class
