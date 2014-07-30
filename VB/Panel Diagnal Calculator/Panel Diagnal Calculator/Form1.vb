Public Class Welcomeform


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Calcform.Show()
        Me.Hide()

        Dim systemarray(3) As String
        systemarray(0) = "AL Panel System"
        systemarray(1) = "EF Panel System"
        systemarray(2) = "Knight Wall Panel System"
        systemarray(3) = "Acm Panel System"
        Array.Sort(systemarray)
        Calcform.systemcombo.Items.Add("Select A Panel System")
        Calcform.systemcombo.SelectedItem = "Select A Panel System"
        For Each strname As String In systemarray
            Calcform.systemcombo.Items.Add(strname)
        Next

        Dim sidearray(3) As String
        sidearray(0) = "1 Face"
        sidearray(1) = "2 Face"
        sidearray(2) = "3 Face"
        sidearray(3) = "4 Face"
        Array.Sort(sidearray)
        For Each strname As String In sidearray
            Calcform.sidescombo.Items.Add(strname)
        Next




    End Sub
End Class
