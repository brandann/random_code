Imports System
Imports System.Resources
Imports System.IO
Imports Microsoft.Office.Interop
Imports System.Threading

Public Class Form1
    Public strTop As String = String.Empty
    Dim strBottom2 As String = String.Empty
    Dim strBottom3 As String = String.Empty
    Dim strbottom4 As String = String.Empty
    Dim strbottom5 As String = String.Empty

    Dim col As Integer = 1 'Excel Column
    Dim row As Integer = 2 'Excel Row
    Dim Finish As Boolean = True

    Private Sub btnGetOld_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetOld.Click
        OpenFileDialog1.ShowDialog()
        lblOldFile.Text = OpenFileDialog1.FileName
        FileCheck()
    End Sub

    Private Sub btnSetNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetNew.Click
        SaveFileDialog1.AddExtension = True
        SaveFileDialog1.DefaultExt = ".csv"
        SaveFileDialog1.ShowDialog()
        lblNewFile.Text = SaveFileDialog1.FileName
        FileCheck()
    End Sub

    Public Sub FileCheck()
        If lblOldFile.Text <> "" And lblNewFile.Text <> "" Then
            lblDirection.Visible = True
            chkFormat.Visible = True
            lblNewFileNote.Visible = False

            Do Until Me.Height = 315
                Dim i As Integer = Me.Height
                i += 1
                Me.Height = i
                Thread.Sleep(3)
            Loop
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnStart.Enabled = False
        Me.Height = 154
    End Sub

    Private Sub chkFormat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFormat.CheckedChanged
        If chkFormat.CheckState = CheckState.Checked Then
            pnlWorkspace.Visible = True
            btnStart.Enabled = True
            chkFormat.Visible = False
            lblDirection.Visible = False
            Do Until Me.Height = 420
                Dim i As Integer = Me.Height
                i += 1
                Me.Height = i
                Thread.Sleep(3)
            Loop
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Public Sub PostTop()
        Dim strsplit() As String = strTop.Split(",")
        txtTopID.Text = strsplit(0)
        txtTopFace.Text = strsplit(1)
        txtTopW1.Text = strsplit(2)
        txtTopW2.Text = strsplit(3)
        txtTopW3.Text = strsplit(4)
        txtTopW4.Text = strsplit(5)
        txtTopHeight.Text = strsplit(6)
        txtTopSoffit.Text = strsplit(7)
        strTop = String.Empty
    End Sub

    Public Sub PostBottom2()
        Dim strSplit() As String = strBottom2.Split(",")
        txt2ID.Text = strSplit(0)
        txt2Face.Text = strSplit(1)
        txt2W1.Text = strSplit(2)
        strBottom2 = String.Empty
    End Sub

    Public Sub PostBottom3()
        Dim strSplit() As String = strBottom3.Split(",")
        txt3ID.Text = strSplit(0)
        txt3Face.Text = strSplit(1)
        txt3W1.Text = strSplit(2)
        strBottom3 = String.Empty
    End Sub

    Public Sub PostBottom4()
        Dim strSplit() As String = strbottom4.Split(",")
        txt4ID.Text = strSplit(0)
        txt4Face.Text = strSplit(1)
        txt4W1.Text = strSplit(2)
        strbottom4 = String.Empty
    End Sub

    Public Sub PostBottom5()
        Dim strSplit() As String = strbottom5.Split(",")
        txt5ID.Text = strSplit(0)
        txt5Face.Text = strSplit(1)
        txt5W1.Text = strSplit(2)
        strbottom5 = String.Empty
    End Sub

    Public Sub ComparePanels()
        If txtTopID.Text = txt2ID.Text Then
            If txt2Face.Text = "W2" Then
                txtTopW2.Text = txt2W1.Text
                row += 1
                If txt3Face.Text = "W3" Then
                    txtTopW3.Text = txt3W1.Text
                    row += 1
                    If txt4Face.Text = "W4" Then
                        txtTopW4.Text = txt4W1.Text
                        row += 1
                        If txt5Face.Text = "SR" Then
                            txtTopSoffit.Text = txt5W1.Text
                            row += 1
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Function SavePanel()
        Dim strNewPanel As String
        strNewPanel = txtTopID.Text & ","
        strNewPanel = strNewPanel & txtTopFace.Text & ","
        strNewPanel = strNewPanel & txtTopW1.Text & ","
        strNewPanel = strNewPanel & txtTopW2.Text & ","
        strNewPanel = strNewPanel & txtTopW3.Text & ","
        strNewPanel = strNewPanel & txtTopW4.Text & ","
        strNewPanel = strNewPanel & txtTopHeight.Text & ","
        strNewPanel = strNewPanel & txtTopSoffit.Text
        Return strNewPanel
    End Function

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        btnExit.Enabled = False
        btnStart.Enabled = False
        Dim EXLFILE As New Excel.Application
        Dim EXLWORKSHEET As Excel.Worksheet
        Dim EXLWORKBOOK As Excel.Workbook
        Dim EXLFILENAME As String
        Dim CSVFILE As System.IO.StreamWriter
        Dim CSVFILENAME As String = String.Empty
        Dim CSVNEWLINE As String = String.Empty
        EXLFILENAME = lblOldFile.Text
        EXLWORKBOOK = EXLFILE.Workbooks.Open(EXLFILENAME)
        EXLWORKSHEET = EXLWORKBOOK.Sheets.Item(1)
        CSVFILENAME = lblNewFile.Text
        CSVFILE = My.Computer.FileSystem.OpenTextFileWriter(CSVFILENAME, True)
        
        Do
            Do
                strTop = strTop & EXLWORKSHEET.Cells(row, col).value & ","
                strBottom2 = strBottom2 & EXLWORKSHEET.Cells(row + 1, col).value & ","
                strBottom3 = strBottom3 & EXLWORKSHEET.Cells(row + 2, col).value & ","
                strbottom4 = strbottom4 & EXLWORKSHEET.Cells(row + 3, col).value & ","
                strbottom5 = strbottom5 & EXLWORKSHEET.Cells(row + 4, col).value & ","
                col += 1
            Loop Until col = 8
            PostTop()
            PostBottom2()
            PostBottom3()
            PostBottom4()
            PostBottom5()
            ComparePanels()
            CSVFILE.WriteLine(SavePanel())
            col = 1
            row += 1
        Loop Until txtTopID.Text = ""

        CSVFILE.Close()
        EXLFILE.ActiveWorkbook.Close(False, CSVFILENAME)
        EXLFILE.Quit()
        If Finish = True Then
            MessageBox.Show("Thank you." & vbCrLf & "Your converted file will open in a new window" & vbCrLf & "This program will close when you click ok" & vbCrLf & vbCrLf & "If you have a suggestions please e-mail me at Brandan@Northshoresheetmetal.com", "Done", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Process.Start(CSVFILENAME)
            Me.Close()
        Else
            MessageBox.Show("An error occurred, Check your data & formatting", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
End Class
