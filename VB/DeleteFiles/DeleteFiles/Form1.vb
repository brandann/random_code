Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim nameMatch As String = TextBox1.Text
        Dim count As Integer = 0
        Dim max As Integer = Integer.Parse(countTextBox.Text)

        For Each foundFile As String In My.Computer.FileSystem.GetFiles(My.Computer.FileSystem.CurrentDirectory)
            If foundFile.Contains(nameMatch) Then
                'ListBox1.Items.Add(foundFile)
                My.Computer.FileSystem.DeleteFile(foundFile)
                count = count + 1
            End If
            If count > max Then
                MessageBox.Show(count & " Files Deleted!")
                Return
            End If
        Next
        MessageBox.Show(count & " Files Deleted!")
        Me.Close()

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        curDirLabel.Text = My.Computer.FileSystem.CurrentDirectory
    End Sub
End Class
