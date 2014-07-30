Public Class Form1

    Dim inputFile As String = String.Empty
    Dim outputFile As String = String.Empty

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        'Shell("java PizzaOrderBrandan")
        'Shell("java -jar GUI_1.jar")
        'Shell("java DateDriver 2 9 2013")

        Try
            Dim filestring As String = "java -jar PanelExtractionConsolidation.jar " & inputFile & " " & outputFile
            IO.Directory.SetCurrentDirectory("P:\Northshore Time Sheet\Tools\")
            Shell(filestring)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            MessageBox.Show("Looks like something went wronge, if you need some help, see Brandan")
        End Try

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()
        inputFile = OpenFileDialog1.FileName
        MessageBox.Show(inputFile)


    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        OpenFileDialog1.ShowDialog()
        outputFile = OpenFileDialog1.FileName
        MessageBox.Show(outputFile)
    End Sub
End Class
