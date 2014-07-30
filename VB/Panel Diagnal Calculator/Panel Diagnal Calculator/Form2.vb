Public Class Calcform
     
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles systemcombo.SelectedIndexChanged
        If systemcombo.SelectedItem = "EF Panel System" Then
            EFcombo.Visible = True
            sidescombo.Visible = False
            sidescombo.SelectedItem = "1 Face"
        Else
            EFcombo.Visible = False
            sidescombo.Visible = True
        End If

        If systemcombo.SelectedItem <> "Select A Panel System" Then
            systemcombo.Items.Remove("Select A Panel System")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
        Welcomeform.Close()
    End Sub

    Private Sub sidescombo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sidescombo.SelectedIndexChanged
        If sidescombo.SelectedItem = "1 Face" Then
            w1box.Visible = True
            w1lbl.Visible = True

            w2box.Visible = False
            w2lbl.Visible = False

            w3box.Visible = False
            w3lbl.Visible = False

            w4box.Visible = False
            w4lbl.Visible = False
        End If
        If sidescombo.SelectedItem = "2 Face" Then
            w1box.Visible = True
            w1lbl.Visible = True

            w2box.Visible = True
            w2lbl.Visible = True

            w3box.Visible = False
            w3lbl.Visible = False

            w4box.Visible = False
            w4lbl.Visible = False
        End If
        If sidescombo.SelectedItem = "3 Face" Then
            w1box.Visible = True
            w1lbl.Visible = True

            w2box.Visible = True
            w2lbl.Visible = True

            w3box.Visible = True
            w3lbl.Visible = True

            w4box.Visible = False
            w4lbl.Visible = False
        End If
        If sidescombo.SelectedItem = "4 Face" Then
            w1box.Visible = True
            w1lbl.Visible = True

            w2box.Visible = True
            w2lbl.Visible = True

            w3box.Visible = True
            w3lbl.Visible = True

            w4box.Visible = True
            w4lbl.Visible = True
        End If
    End Sub
End Class