Public Class Form1
    Const NorthshoreJobFile As String = "P:\Job file\"
    Const NorthCladJobFile As String = "P:\Job file - NORTHCLAD\"
    '*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|
    '
    ' Main Panel
    '
    '*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|

    '--------------------------------------------------------------
    '
    ' My Functions
    '
    '--------------------------------------------------------------

    Public Sub SAVE_JOB()
        Dim day As String = boxDatePicker.SelectedItem

        If day = "Monday" Then
            'Dim daySetting As Object = My.Settings.MondayJobs
            Dim J1 As String = txtJob1.Text & "~" & txtHour1.Text & "~" & txtMinute1.Text & "~"
            Dim J2 As String = txtJob2.Text & "~" & txtHour1.Text & "~" & txtMinute1.Text & "~"
            Dim J3 As String = txtJob3.Text & "~" & txtHour1.Text & "~" & txtMinute1.Text & "~"
            Dim J4 As String = txtJob4.Text & "~" & txtHour1.Text & "~" & txtMinute1.Text & "~"
            Dim J5 As String = txtJob5.Text & "~" & txtHour1.Text & "~" & txtMinute1.Text

            Dim SAVESTRING As String = J1 & J2 & J3 & J4 & J5

            My.Settings.MondayJobs = SAVESTRING
        ElseIf day = "Tuesday" Then
            'Dim daySetting As Object = My.Settings.TuesdayJobs
            Dim J1 As String = txtJob1.Text & "~" & txtHour1.Text & "~" & txtMinute1.Text & "~"
            Dim J2 As String = txtJob2.Text & "~" & txtHour1.Text & "~" & txtMinute1.Text & "~"
            Dim J3 As String = txtJob3.Text & "~" & txtHour1.Text & "~" & txtMinute1.Text & "~"
            Dim J4 As String = txtJob4.Text & "~" & txtHour1.Text & "~" & txtMinute1.Text & "~"
            Dim J5 As String = txtJob5.Text & "~" & txtHour1.Text & "~" & txtMinute1.Text

            Dim SAVESTRING As String = J1 & J2 & J3 & J4 & J5

            My.Settings.TuesdayJobs = SAVESTRING
        ElseIf day = "Wednesday" Then
            ' Dim daySetting As Object = My.Settings.WednesdayJobs
            Dim J1 As String = txtJob1.Text & "~" & txtHour1.Text & "~" & txtMinute1.Text & "~"
            Dim J2 As String = txtJob2.Text & "~" & txtHour1.Text & "~" & txtMinute1.Text & "~"
            Dim J3 As String = txtJob3.Text & "~" & txtHour1.Text & "~" & txtMinute1.Text & "~"
            Dim J4 As String = txtJob4.Text & "~" & txtHour1.Text & "~" & txtMinute1.Text & "~"
            Dim J5 As String = txtJob5.Text & "~" & txtHour1.Text & "~" & txtMinute1.Text

            Dim SAVESTRING As String = J1 & J2 & J3 & J4 & J5

            My.Settings.WednesdayJobs = SAVESTRING
        ElseIf day = "Thursday" Then
            ' Dim daySetting As Object = My.Settings.ThursdayJobs
            Dim J1 As String = txtJob1.Text & "~" & txtHour1.Text & "~" & txtMinute1.Text & "~"
            Dim J2 As String = txtJob2.Text & "~" & txtHour1.Text & "~" & txtMinute1.Text & "~"
            Dim J3 As String = txtJob3.Text & "~" & txtHour1.Text & "~" & txtMinute1.Text & "~"
            Dim J4 As String = txtJob4.Text & "~" & txtHour1.Text & "~" & txtMinute1.Text & "~"
            Dim J5 As String = txtJob5.Text & "~" & txtHour1.Text & "~" & txtMinute1.Text

            Dim SAVESTRING As String = J1 & J2 & J3 & J4 & J5

            My.Settings.ThursdayJobs = SAVESTRING
        ElseIf day = "Friday" Then
            ' Dim daySetting As Object = My.Settings.FridayJobs
            Dim J1 As String = txtJob1.Text & "~" & txtHour1.Text & "~" & txtMinute1.Text & "~"
            Dim J2 As String = txtJob2.Text & "~" & txtHour1.Text & "~" & txtMinute1.Text & "~"
            Dim J3 As String = txtJob3.Text & "~" & txtHour1.Text & "~" & txtMinute1.Text & "~"
            Dim J4 As String = txtJob4.Text & "~" & txtHour1.Text & "~" & txtMinute1.Text & "~"
            Dim J5 As String = txtJob5.Text & "~" & txtHour1.Text & "~" & txtMinute1.Text

            Dim SAVESTRING As String = J1 & J2 & J3 & J4 & J5

            My.Settings.FridayJobs = SAVESTRING
        ElseIf day = "Saturday" Then
            ' Dim daySetting As Object = My.Settings.SaturdayJobs
            Dim J1 As String = txtJob1.Text & "~" & txtHour1.Text & "~" & txtMinute1.Text & "~"
            Dim J2 As String = txtJob2.Text & "~" & txtHour1.Text & "~" & txtMinute1.Text & "~"
            Dim J3 As String = txtJob3.Text & "~" & txtHour1.Text & "~" & txtMinute1.Text & "~"
            Dim J4 As String = txtJob4.Text & "~" & txtHour1.Text & "~" & txtMinute1.Text & "~"
            Dim J5 As String = txtJob5.Text & "~" & txtHour1.Text & "~" & txtMinute1.Text

            Dim SAVESTRING As String = J1 & J2 & J3 & J4 & J5

            My.Settings.SaturdayJobs = SAVESTRING
        ElseIf day = "Sunday" Then
            ' Dim daySetting As Object = My.Settings.SundayJobs
            Dim J1 As String = txtJob1.Text & "~" & txtHour1.Text & "~" & txtMinute1.Text & "~"
            Dim J2 As String = txtJob2.Text & "~" & txtHour2.Text & "~" & txtMinute2.Text & "~"
            Dim J3 As String = txtJob3.Text & "~" & txtHour3.Text & "~" & txtMinute3.Text & "~"
            Dim J4 As String = txtJob4.Text & "~" & txtHour4.Text & "~" & txtMinute4.Text & "~"
            Dim J5 As String = txtJob5.Text & "~" & txtHour5.Text & "~" & txtMinute5.Text

            Dim SAVESTRING As String = J1 & J2 & J3 & J4 & J5

            My.Settings.SundayJobs = SAVESTRING
        End If
        My.Settings.Save()
    End Sub

    ' Public Sub SAVE_JOB2(ByVal DAY As Object)
    'Dim J1 As String = txtJob1.Text & "~" & txtHour1.Text & "~" & txtMinute1.Text & "~"
    ' Dim J2 As String = txtJob2.Text & "~" & txtHour1.Text & "~" & txtMinute1.Text & "~"
    ' Dim J3 As String = txtJob3.Text & "~" & txtHour1.Text & "~" & txtMinute1.Text & "~"
    ' Dim J4 As String = txtJob4.Text & "~" & txtHour1.Text & "~" & txtMinute1.Text & "~"
    ' Dim J5 As String = txtJob5.Text & "~" & txtHour1.Text & "~" & txtMinute1.Text

    'Dim SAVESTRING As String = J1 & J2 & J3 & J4 & J5

    '   DAY = SAVESTRING


    ' End Sub

    Public Sub LOAD_JOBS()
        Dim day As String = boxDatePicker.SelectedItem

        ' txtJob1.Text = String.Empty
        ' txtHour1.Text = String.Empty
        ' txtMinute1.Text = String.Empty

        ' txtJob2.Text = String.Empty
        ' txtHour2.Text = String.Empty
        ' txtMinute2.Text = String.Empty

        ' txtJob3.Text = String.Empty
        ' txtHour3.Text = String.Empty
        'txtMinute3.Text = String.Empty

        ' txtJob4.Text = String.Empty
        ' txtHour4.Text = String.Empty
        ' txtMinute4.Text = String.Empty

        ' txtJob5.Text = String.Empty
        '  txtHour5.Text = String.Empty
        ' txtMinute5.Text = String.Empty
        If day = "Monday" Then
            Dim daysetting() As String = My.Settings.MondayJobs.Split("~")
            Try
                txtJob1.Text = daysetting(0)
                txtHour1.Text = daysetting(1)
                txtMinute1.Text = daysetting(2)

                txtJob2.Text = daysetting(3)
                txtHour2.Text = daysetting(4)
                txtMinute2.Text = daysetting(5)

                txtJob3.Text = daysetting(6)
                txtHour3.Text = daysetting(7)
                txtMinute3.Text = daysetting(8)

                txtJob4.Text = daysetting(9)
                txtHour4.Text = daysetting(10)
                txtMinute4.Text = daysetting(11)

                txtJob5.Text = daysetting(12)
                txtHour5.Text = daysetting(13)
                txtMinute5.Text = daysetting(14)
            Catch ex As Exception

            End Try
        ElseIf day = "Tuesday" Then
            Dim daysetting() As String = My.Settings.TuesdayJobs.Split("~")
            Try
                txtJob1.Text = daysetting(0)
                txtHour1.Text = daysetting(1)
                txtMinute1.Text = daysetting(2)

                txtJob2.Text = daysetting(3)
                txtHour2.Text = daysetting(4)
                txtMinute2.Text = daysetting(5)

                txtJob3.Text = daysetting(6)
                txtHour3.Text = daysetting(7)
                txtMinute3.Text = daysetting(8)

                txtJob4.Text = daysetting(9)
                txtHour4.Text = daysetting(10)
                txtMinute4.Text = daysetting(11)

                txtJob5.Text = daysetting(12)
                txtHour5.Text = daysetting(13)
                txtMinute5.Text = daysetting(14)
            Catch ex As Exception

            End Try
        ElseIf day = "Wednesday" Then
            Dim daysetting() As String = My.Settings.WednesdayJobs.Split("~")
            Try
                txtJob1.Text = daysetting(0)
                txtHour1.Text = daysetting(1)
                txtMinute1.Text = daysetting(2)

                txtJob2.Text = daysetting(3)
                txtHour2.Text = daysetting(4)
                txtMinute2.Text = daysetting(5)

                txtJob3.Text = daysetting(6)
                txtHour3.Text = daysetting(7)
                txtMinute3.Text = daysetting(8)

                txtJob4.Text = daysetting(9)
                txtHour4.Text = daysetting(10)
                txtMinute4.Text = daysetting(11)

                txtJob5.Text = daysetting(12)
                txtHour5.Text = daysetting(13)
                txtMinute5.Text = daysetting(14)
            Catch ex As Exception

            End Try
        ElseIf day = "Thursday" Then
            Dim daysetting() As String = My.Settings.ThursdayJobs.Split("~")
            Try
                txtJob1.Text = daysetting(0)
                txtHour1.Text = daysetting(1)
                txtMinute1.Text = daysetting(2)

                txtJob2.Text = daysetting(3)
                txtHour2.Text = daysetting(4)
                txtMinute2.Text = daysetting(5)

                txtJob3.Text = daysetting(6)
                txtHour3.Text = daysetting(7)
                txtMinute3.Text = daysetting(8)

                txtJob4.Text = daysetting(9)
                txtHour4.Text = daysetting(10)
                txtMinute4.Text = daysetting(11)

                txtJob5.Text = daysetting(12)
                txtHour5.Text = daysetting(13)
                txtMinute5.Text = daysetting(14)
            Catch ex As Exception

            End Try
        ElseIf day = "Friday" Then
            Dim daysetting() As String = My.Settings.FridayJobs.Split("~")
            Try
                txtJob1.Text = daysetting(0)
                txtHour1.Text = daysetting(1)
                txtMinute1.Text = daysetting(2)

                txtJob2.Text = daysetting(3)
                txtHour2.Text = daysetting(4)
                txtMinute2.Text = daysetting(5)

                txtJob3.Text = daysetting(6)
                txtHour3.Text = daysetting(7)
                txtMinute3.Text = daysetting(8)

                txtJob4.Text = daysetting(9)
                txtHour4.Text = daysetting(10)
                txtMinute4.Text = daysetting(11)

                txtJob5.Text = daysetting(12)
                txtHour5.Text = daysetting(13)
                txtMinute5.Text = daysetting(14)
            Catch ex As Exception

            End Try
        ElseIf day = "Saturday" Then
            Dim daysetting() As String = My.Settings.SaturdayJobs.Split("~")
            Try
                txtJob1.Text = daysetting(0)
                txtHour1.Text = daysetting(1)
                txtMinute1.Text = daysetting(2)

                txtJob2.Text = daysetting(3)
                txtHour2.Text = daysetting(4)
                txtMinute2.Text = daysetting(5)

                txtJob3.Text = daysetting(6)
                txtHour3.Text = daysetting(7)
                txtMinute3.Text = daysetting(8)

                txtJob4.Text = daysetting(9)
                txtHour4.Text = daysetting(10)
                txtMinute4.Text = daysetting(11)

                txtJob5.Text = daysetting(12)
                txtHour5.Text = daysetting(13)
                txtMinute5.Text = daysetting(14)
            Catch ex As Exception

            End Try
        ElseIf day = "Sunday" Then
            Dim daysetting() As String = My.Settings.SundayJobs.Split("~")
            Try
                txtJob1.Text = daysetting(0)
                txtHour1.Text = daysetting(1)
                txtMinute1.Text = daysetting(2)

                txtJob2.Text = daysetting(3)
                txtHour2.Text = daysetting(4)
                txtMinute2.Text = daysetting(5)

                txtJob3.Text = daysetting(6)
                txtHour3.Text = daysetting(7)
                txtMinute3.Text = daysetting(8)

                txtJob4.Text = daysetting(9)
                txtHour4.Text = daysetting(10)
                txtMinute4.Text = daysetting(11)

                txtJob5.Text = daysetting(12)
                txtHour5.Text = daysetting(13)
                txtMinute5.Text = daysetting(14)
            Catch ex As Exception

            End Try
        End If
    End Sub

    ' Public Sub LOAD_JOBS2(ByVal day As Object)
    '  txtJob1.Text = String.Empty
    ' txtJob2.Text = String.Empty
    ' txtJob3.Text = String.Empty
    ' txtJob4.Text = String.Empty
    ' txtJob5.Text = String.Empty

    '  Try
    '     txtJob1.Text = day.Split("~")(0)
    '    txtHour1.Text = day.split("~")(1)
    '   txtMinute1.Text = day.split("~")(2)

    '        txtJob2.Text = day.Split("~")(3)
    '       txtHour1.Text = day.split("~")(4)
    '      txtMinute1.Text = day.split("~")(5)

    '        txtJob3.Text = day.Split("~")(6)
    '       txtHour1.Text = day.split("~")(7)
    '      txtMinute1.Text = day.split("~")(8)

    '        txtJob4.Text = day.Split("~")(9)
    '       txtHour1.Text = day.split("~")(10)
    '      txtMinute1.Text = day.split("~")(11)

    '        txtJob5.Text = day.Split("~")(12)
    '       txtHour1.Text = day.split("~")(13)
    '      txtMinute1.Text = day.split("~")(14)
    ' Catch ex As Exception

    '    End Try
    'End Sub

    Public Sub START_SEARCH()
        pnlSearch.Visible = True
        tmrJob.Enabled = False

        txtJob1.ForeColor = Color.Black
        txtHour1.ForeColor = Color.Black
        txtMinute1.ForeColor = Color.Black

        txtJob2.ForeColor = Color.Black
        txtHour2.ForeColor = Color.Black
        txtMinute2.ForeColor = Color.Black

        txtJob3.ForeColor = Color.Black
        txtHour3.ForeColor = Color.Black
        txtMinute3.ForeColor = Color.Black

        txtJob4.ForeColor = Color.Black
        txtHour4.ForeColor = Color.Black
        txtMinute4.ForeColor = Color.Black

        txtJob5.ForeColor = Color.Black
        txtHour5.ForeColor = Color.Black
        txtMinute5.ForeColor = Color.Black

    End Sub

    Public Sub START_TIME(ByVal job, ByVal hour, ByVal minute)
        STOP_TIME()

        job.ForeColor = Color.CornflowerBlue
        hour.ForeColor = Color.CornflowerBlue
        minute.ForeColor = Color.CornflowerBlue
        tmrJob.Enabled = True
    End Sub

    Public Sub STOP_TIME()

        tmrJob.Enabled = False

        txtJob1.ForeColor = Color.Black
        txtHour1.ForeColor = Color.Black
        txtMinute1.ForeColor = Color.Black

        txtJob2.ForeColor = Color.Black
        txtHour2.ForeColor = Color.Black
        txtMinute2.ForeColor = Color.Black

        txtJob3.ForeColor = Color.Black
        txtHour3.ForeColor = Color.Black
        txtMinute3.ForeColor = Color.Black

        txtJob4.ForeColor = Color.Black
        txtHour4.ForeColor = Color.Black
        txtMinute4.ForeColor = Color.Black

        txtJob5.ForeColor = Color.Black
        txtHour5.ForeColor = Color.Black
        txtMinute5.ForeColor = Color.Black

    End Sub

    Public Sub APPLY_NEWJOB(ByVal StrPickedJob)
        If txtJob1.Text = String.Empty Then
            txtJob1.Text = StrPickedJob
        ElseIf txtJob2.Text = String.Empty Then
            txtJob2.Text = StrPickedJob
        ElseIf txtJob3.Text = String.Empty Then
            txtJob3.Text = StrPickedJob
        ElseIf txtJob4.Text = String.Empty Then
            txtJob4.Text = StrPickedJob
        ElseIf txtJob5.Text = String.Empty Then
            txtJob5.Text = StrPickedJob
        Else
            MessageBox.Show("I ran out of room to apply this new job...", "Sorry!")
        End If
    End Sub

    '--------------------------------------------------------------
    '
    ' Buttons
    '
    '--------------------------------------------------------------

    Private Sub btnTime1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTime1.Click
        If txtJob1.ForeColor = Color.Black Then
            START_TIME(txtJob1, txtHour1, txtMinute1)
        Else
            STOP_TIME()
        End If

    End Sub

    Private Sub btnTime2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTime2.Click
        If txtJob2.ForeColor = Color.Black Then
            START_TIME(txtJob2, txtHour2, txtMinute2)
        Else
            STOP_TIME()
        End If

    End Sub

    Private Sub btnTime3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTime3.Click
        If txtJob3.ForeColor = Color.Black Then
            START_TIME(txtJob3, txtHour3, txtMinute3)
        Else
            STOP_TIME()
        End If

    End Sub

    Private Sub btnTime4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTime4.Click
        If txtJob4.ForeColor = Color.Black Then
            START_TIME(txtJob4, txtHour4, txtMinute4)
        Else
            STOP_TIME()
        End If

    End Sub

    Private Sub btnTime5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTime5.Click
        If txtJob5.ForeColor = Color.Black Then
            START_TIME(txtJob5, txtHour5, txtMinute5)
        Else
            STOP_TIME()
        End If

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim loaddate As String = Now.DayOfWeek.ToString
        boxDatePicker.SelectedItem = loaddate

        LOAD_JOBS()
    End Sub

    Private Sub DateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        ' LOAD_JOBS()
    End Sub

    '*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|
    '
    ' Control Panel
    '
    '*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub pnlMain_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlMain.MouseHover
        pnlControl.Visible = True
        tmrControl.Enabled = False
    End Sub

    Private Sub pnlMain_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlMain.MouseLeave
        tmrControl.Enabled = True
    End Sub

    Private Sub tmrControl_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrControl.Tick
        pnlControl.Visible = False
        tmrControl.Enabled = False
    End Sub

    Private Sub pnlControl_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlControl.MouseHover
        tmrControl.Enabled = False
    End Sub

    Private Sub pnlControl_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlControl.MouseLeave
        tmrControl.Enabled = True
    End Sub

    '*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|
    '
    ' Search Panel
    '
    '*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|*|

    Private Sub btnSearch1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch1.Click
        START_SEARCH()

    End Sub


    Private Sub tmrJob_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrJob.Tick
        If txtJob1.ForeColor = Color.CornflowerBlue Then
            Dim min As Integer = txtMinute1.Text
            min += 1
            If min >= 60 Then
                Dim hour As Integer = txtHour1.Text
                hour += 1
                txtHour1.Text = hour
                txtMinute1.Text = 0
            Else
                txtMinute1.Text = min
            End If

        End If
    End Sub

    Private Sub btnNorthshore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNorthshore.Click
        ListBox1.Items.Clear()

        For Each i As String In My.Computer.FileSystem.GetDirectories(NorthshoreJobFile)
            ListBox1.Items.Add(i.Substring(12))
        Next
        ListBox1.Items.Remove("1-Closed Jobs")

        ListBox1.Items.Remove("1-Doc Templates")

        ListBox1.Items.Remove("1-Insurance Policies")

        ListBox1.Items.Remove("1-Job Template")
        ListBox1.Items.Remove("1-Mailing Log")
        ListBox1.Items.Remove("1-Master Contracts")
        ListBox1.Items.Remove("1-pre job info tracking")
        ListBox1.Items.Remove("1-Project Schedule File")
        ListBox1.Items.Remove("1-Small Jobs")
        ListBox1.Items.Remove("Hanging Folder lists")
        ListBox1.Items.Remove("MASTER SUBCONTRACTS")




    End Sub

    Private Sub btnNorthclad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNorthclad.Click
        ListBox1.Items.Clear()
        For Each i As String In My.Computer.FileSystem.GetDirectories(NorthCladJobFile)
            ListBox1.Items.Add(i.Substring(24))
        Next
        ListBox1.Items.RemoveAt(0)
        ListBox1.Items.RemoveAt(1)
    End Sub

    Private Sub btnOldNorthshore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOldNorthshore.Click
        ListBox1.Items.Clear()

        Dim OldNorthshore As String = "P:\Job File\1-Closed Jobs"

        For Each old As String In My.Computer.FileSystem.GetDirectories(OldNorthshore)
            For Each oldyear As String In My.Computer.FileSystem.GetDirectories(old)
                ListBox1.Items.Add(oldyear)
            Next
        Next



    End Sub

    Private Sub btnOldNorthclad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOldNorthclad.Click
        ListBox1.Items.Clear()

        Dim OldNorthclad As String = "P:\Job file - NORTHCLAD\1-NorthClad Closed Jobs"

        For Each old As String In My.Computer.FileSystem.GetDirectories(OldNorthclad)
            For Each oldyear As String In My.Computer.FileSystem.GetDirectories(old)
                ListBox1.Items.Add(oldyear)
            Next
        Next
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        ListBox1.Items.Clear()
        pnlSearch.Visible = False

    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Try
            APPLY_NEWJOB(ListBox1.SelectedItem)
            ListBox1.Items.Clear()
            pnlSearch.Visible = False
            SAVE_JOB()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub DateTimePicker_CloseUp(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LOAD_JOBS()
    End Sub

    Private Sub DateTimePicker_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SAVE_JOB()
    End Sub

    Private Sub boxDatePicker_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boxDatePicker.SelectedIndexChanged
        LOAD_JOBS()
    End Sub

    Private Sub txtJob5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMinute5.TextChanged, txtMinute4.TextChanged, txtMinute3.TextChanged, txtMinute2.TextChanged, txtMinute1.TextChanged, txtJob5.TextChanged, txtJob4.TextChanged, txtJob3.TextChanged, txtJob2.TextChanged, txtJob1.TextChanged, txtHour5.TextChanged, txtHour4.TextChanged, txtHour3.TextChanged, txtHour2.TextChanged, txtHour1.TextChanged
        SAVE_JOB()
    End Sub
End Class
