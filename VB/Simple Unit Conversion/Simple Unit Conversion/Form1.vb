Public Class Form1
    Public Sub mathconvert()
        If IdentifierLabel.Text = "Feet:" Then
            IdentifierLabel.Text = "Inches:"

            ConversionLabel.Visible = True
            ConversionLabel.Text = (TextBox1.Text * 12)
            TextBox1.Text = ""

        ElseIf IdentifierLabel.Text = "Inches:" Then
            IdentifierLabel.Text = "Fractional:"

            ConversionLabel.Text = Int(ConversionLabel.Text) + Int(TextBox1.Text)
            TextBox1.Text = ""

        ElseIf IdentifierLabel.Text = "Fractional:" Then
            IdentifierLabel.Text = "Feet:"
            If TextBox1.Text.Contains("/") Then
                Dim problem As String = TextBox1.Text
                Dim problemparts() As String = problem.Split(New Char() {"/"c})
                Dim lnum As String = problemparts(0)
                Dim rnum As String = problemparts(1)
                Dim result As Double = Format(Int(lnum) / Int(rnum), "0.0000")


                ConversionLabel.Text = Int(ConversionLabel.Text) + result
                ListBox1.Items.Add(ConversionLabel.Text)

                ConversionLabel.Visible = False
                TextBox1.Text = ""

            ElseIf TextBox1.Text.Contains(".") Then
                IdentifierLabel.Text = "Feet:"
                Dim problem As String = TextBox1.Text
                Dim result As Double = problem


                ConversionLabel.Text = Int(ConversionLabel.Text) + result
                ListBox1.Items.Add(ConversionLabel.Text)

                ConversionLabel.Visible = False
                TextBox1.Text = ""

            End If
        End If
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        mathconvert()


    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        


    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            mathconvert()

        End If
    End Sub

    Private Sub exitbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitbutton.Click
        Close()

    End Sub

    Private Sub clearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearButton.Click
        ListBox1.Items.Clear()
        TextBox1.Text = ""
        IdentifierLabel.Text = "Feet:"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim position As Integer = ListBox1.SelectedIndex
        ListBox1.Items.RemoveAt(position)
        TextBox1.Text = ""
        IdentifierLabel.Text = "Feet:"
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim filelocation As String = "y:/PanelSizeList.txt"
        Dim datalist As New System.IO.StreamWriter(filelocation)

        For Each panelSize In ListBox1.Items
            datalist.WriteLine(panelSize)

        Next
        datalist.Close()
        ListBox1.Items.Clear()
        System.Diagnostics.Process.Start(filelocation)
        MessageBox.Show(filelocation, "")


    End Sub
End Class
