Public Class Form1
    Public Sub calcfeet()
        If TextBox_input.Text = "" Then
            TextBox_input.Text = "0"
        End If
        TextBox1.Text = Int(TextBox1.Text) + Int(TextBox_input.Text)
        TextBox_input.Text = ""
        ToolStripStatusLabel1.Text = "Enter Inches"
    End Sub
    Public Sub calcinch()
        If TextBox_input.Text = "" Then
            TextBox_input.Text = "0"
        End If
        TextBox2.Text = Int(TextBox2.Text) + Int(TextBox_input.Text)
        TextBox_input.Text = ""
        ToolStripStatusLabel1.Text = "Enter Fractional or Decimal Inch"
    End Sub
    Public Sub calcfractionordecimal(ByVal toolval)
        If TextBox_input.Text = "" Then
            TextBox_input.Text = "0"
        End If
        If TextBox_input.Text.Contains("/") Then
            Dim problem As String = TextBox_input.Text
            Dim problemparts() As String = problem.Split(New Char() {"/"c})
            Dim lnum As String = problemparts(0)
            Dim rnum As String = problemparts(1)
            Dim result As Double = Format(Int(lnum) / Int(rnum), "0.0000")
            TextBox3.Text = Int(TextBox3.Text) + result
        ElseIf TextBox_input.Text.Contains(".") Then
            Dim result As Double = TextBox_input.Text
            TextBox3.Text = Int(TextBox3.Text) + result
            ' Else
            '   Try
            'TextBox3.Text = Int(TextBox3.Text) + Int(TextBox_input.Text)
            '  Catch ex As Exception

            '  End Try
        End If
        TextBox_input.Text = ""
        ToolStripStatusLabel1.Text = "Enter " & toolval
    End Sub
    Public Sub calcfractionordecimal2(ByVal toolval)
        If TextBox_input.Text = "" Then
            TextBox_input.Text = "0"
        End If
        If TextBox_input.Text.Contains("/") Then
            TextBox3.Text = " " & TextBox_input.Text
            If Pick_Box.Text = "Architectural(Addition)" Then
                MessageBox.Show("Sorry I cannot add fractions at this time...", "Sorry")
            End If
        ElseIf TextBox_input.Text.Contains(".") Then
            Dim result As Double = TextBox_input.Text
            TextBox3.Text = Int(TextBox3.Text) + result
            ' Else
            '  Try
            'TextBox3.Text = Int(TextBox3.Text) + Int(TextBox_input.Text)
            '  Catch ex As Exception

            '  End Try

        End If
        TextBox_input.Text = ""
        ToolStripStatusLabel1.Text = "Enter " & toolval
    End Sub
    Public Sub calcinchtofeet(ByVal toolval)
        Dim feet As Integer = TextBox_input.Text / 12
        Dim inch As Integer = TextBox_input.Text - (feet * 12)
        TextBox1.Text = Int(TextBox1.Text) + feet
        TextBox2.Text = Int(TextBox1.Text) + inch
        TextBox_input.Text = ""
        ToolStripStatusLabel1.Text = "Enter " & toolval
    End Sub
    Public Sub subtractfractionordecimal(ByVal toolval)
        If TextBox_input.Text = "" Then
            TextBox_input.Text = "0"
        End If
        If TextBox_input.Text.Contains("/") Then
            TextBox3.Text = " " & TextBox_input.Text
            If Pick_Box.Text = "Architectural(Addition)" Then
                MessageBox.Show("Sorry I cannot add fractions at this time...", "Sorry")
            End If
        ElseIf TextBox_input.Text.Contains(".") Then
            Dim result As Double = TextBox_input.Text
            TextBox3.Text = Int(TextBox3.Text) - result
            'Else
            'Try
            ' TextBox3.Text = Int(TextBox3.Text) - Int(TextBox_input.Text)
            ' Catch ex As Exception

            ' End Try

        End If
        TextBox_input.Text = ""
        ToolStripStatusLabel1.Text = "Enter " & toolval
    End Sub
    Public Sub subtractcalcfeet()
        If TextBox_input.Text = "" Then
            TextBox_input.Text = "0"
        End If
        TextBox1.Text = Int(TextBox1.Text) - Int(TextBox_input.Text)
        TextBox_input.Text = ""
        ToolStripStatusLabel1.Text = "Enter Inches"
    End Sub
    Public Sub subtractcalcinch()
        If TextBox_input.Text = "" Then
            TextBox_input.Text = "0"
        End If
        TextBox2.Text = Int(TextBox2.Text) - Int(TextBox_input.Text)
        TextBox_input.Text = ""
        ToolStripStatusLabel1.Text = "Enter Fractional or Decimal Inch"
    End Sub
    Public Sub MasterProgram()
        If Pick_Box.Text = "Architectural to Decimal" Then
            If ToolStripStatusLabel1.Text = "Enter Feet" Then
                calcfeet()
            ElseIf ToolStripStatusLabel1.Text = "Enter Inches" Then
                calcinch()
            ElseIf ToolStripStatusLabel1.Text = "Enter Fractional or Decimal Inch" Then
                calcfractionordecimal("Feet")
                ListBox1.Items.Add((Int(TextBox1.Text) * 12) + Int(TextBox2.Text) + Int(TextBox3.Text))
                cleartextbox()
            End If




        ElseIf Pick_Box.Text = "Fractional Inch to Decimal" Then
            If ToolStripStatusLabel1.Text = "Enter Inches" Then
                calcinch()
            ElseIf ToolStripStatusLabel1.Text = "Enter Fractional or Decimal Inch" Then
                calcfractionordecimal("Inches")
            End If

            ListBox1.Items.Add(Int(TextBox2.Text) + Int(TextBox3.Text))
            cleartextbox()


        ElseIf Pick_Box.Text = "Fractional Inch to Architectural" Then
            If ToolStripStatusLabel1.Text = "Enter Inches" Then
                calcinchtofeet("Enter Fractional or Decimal Inch")
            ElseIf ToolStripStatusLabel1.Text = "Enter Fractional or Decimal Inch" Then
                calcfractionordecimal2("Inches")
            End If

            Dim result As String = TextBox1.Text & "'-" & TextBox2.Text & TextBox3.Text
            ListBox1.Items.Add(result)
            cleartextbox()


        ElseIf Pick_Box.Text = "Decimal Inch to Architectural" Then
            If ToolStripStatusLabel1.Text = "Enter Inches" Then
                calcinchtofeet("Enter Fractional or Decimal Inch")
            ElseIf ToolStripStatusLabel1.Text = "Enter Fractional or Decimal Inch" Then
                calcfractionordecimal2("Inches")
            End If

            Dim result As String = TextBox1.Text & "'-" & TextBox2.Text & TextBox3.Text
            ListBox1.Items.Add(result)
            cleartextbox()


        ElseIf Pick_Box.Text = "Architectural(Addition)" Then
            If ToolStripStatusLabel1.Text = "Enter Feet" Then
                calcfeet()
            ElseIf ToolStripStatusLabel1.Text = "Enter Inches" Then
                calcinch()
            ElseIf ToolStripStatusLabel1.Text = "Enter Fractional or Decimal Inch" Then
                calcfractionordecimal2("Feet")
            End If

            Dim result As String = TextBox1.Text & "'-" & TextBox2.Text & TextBox3.Text
            ListBox1.Items.Add(result)



        ElseIf Pick_Box.Text = "Architectural(Subtraction) " Then
            If ToolStripStatusLabel1.Text = "Enter Feet" Then
                subtractcalcfeet()
            ElseIf ToolStripStatusLabel1.Text = "Enter Inches" Then
                subtractcalcinch()
            ElseIf ToolStripStatusLabel1.Text = "Enter Fractional or Decimal Inch" Then
                subtractfractionordecimal("Feet")
            End If

            Dim result As String = TextBox1.Text & "'-" & TextBox2.Text & TextBox3.Text
            ListBox1.Items.Add(result)


        ElseIf Pick_Box.Text = "Equal Modular Panels" Then
            If ToolStripStatusLabel1.Text = "Enter Total Span of Panels (Feet)" Then
                calcfeet()
            ElseIf ToolStripStatusLabel1.Text = "Enter Total Span of Panels (Inches)" Then
                calcinch()
            ElseIf ToolStripStatusLabel1.Text = "Enter Total Span of Panels (Fractional or Decimal)" Then
                calcfractionordecimal("Enter Number of Panels to Divide")
            ElseIf ToolStripStatusLabel1.Text = "Enter Number of Panels to Divide" Then
                TextBox5.Text = TextBox_input.Text
            ElseIf ToolStripStatusLabel1.Text = "Enter Panel Lap Distance" Then
                If TextBox_input.Text = "" Then
                    TextBox_input.Text = "0"
                End If
                If TextBox_input.Text.Contains("/") Then
                    Dim problem As String = TextBox_input.Text
                    Dim problemparts() As String = problem.Split(New Char() {"/"c})
                    Dim lnum As String = problemparts(0)
                    Dim rnum As String = problemparts(1)
                    Dim result As Double = Format(Int(lnum) / Int(rnum), "0.0000")
                    TextBox4.Text = Int(TextBox4.Text) + result
                ElseIf TextBox_input.Text.Contains(".") Then
                    Dim result As Double = TextBox_input.Text
                    TextBox4.Text = Int(TextBox4.Text) + result
                Else
                    TextBox4.Text = TextBox_input.Text

                End If
                TextBox_input.Text = ""
                ToolStripStatusLabel1.Text = "Enter Total Span of Panels (Feet)"
            End If
            Dim feet As Double = TextBox1.Text
            Dim inch As Double = TextBox2.Text
            Dim fraction As Double = TextBox3.Text
            Dim gap As Double = TextBox4.Text
            Dim qty As Integer = TextBox5.Text - 1

            Dim span As Double = (feet * 12) + inch + fraction
            Dim totalgap As Double = qty * gap
            Dim combinedpanelspan As Double = span - totalgap
            Dim panelsize As Double = combinedpanelspan / qty
            Dim note As String = qty + 1 & "Panels @" & panelsize & "Each"

            ListBox1.Items.Add(note)
            cleartextbox()


        ElseIf Pick_Box.Text = "Equal Lapped Panels" Then
            If ToolStripStatusLabel1.Text = "Enter Total Span of Panels (Feet)" Then
                calcfeet()
                ToolStripStatusLabel1.Text = "Enter Total Span of Panels (Inches)"
            ElseIf ToolStripStatusLabel1.Text = "Enter Total Span of Panels (Inches)" Then
                calcinch()
            ElseIf ToolStripStatusLabel1.Text = "Enter Total Span of Panels (Fractional or Decimal)" Then
                calcfractionordecimal("Enter Number of Panels to Divide")
                ToolStripStatusLabel1.Text = "Enter Number of Panels to Divide"
            ElseIf ToolStripStatusLabel1.Text = "Enter Number of Panels to Divide" Then
                TextBox5.Text = TextBox_input.Text
                ToolStripStatusLabel1.Text = "Enter Panel Lap Distance"
                TextBox_input.Text = ""
            ElseIf ToolStripStatusLabel1.Text = "Enter Panel Lap Distance" Then
                If TextBox_input.Text = "" Then
                    TextBox_input.Text = "0"
                End If
                If TextBox_input.Text.Contains("/") Then
                    Dim problem As String = TextBox_input.Text
                    Dim problemparts() As String = problem.Split(New Char() {"/"c})
                    Dim lnum As String = problemparts(0)
                    Dim rnum As String = problemparts(1)
                    Dim result As Double = Format(Int(lnum) / Int(rnum), "0.0000")
                    TextBox4.Text = Int(TextBox4.Text) + result
                ElseIf TextBox_input.Text.Contains(".") Then
                    Dim result As Double = TextBox_input.Text
                    TextBox4.Text = Int(TextBox4.Text) + result
                Else
                    TextBox4.Text = TextBox_input.Text

                End If
                TextBox_input.Text = ""
                ToolStripStatusLabel1.Text = "Enter Total Span of Panels (Feet)"
            End If
            Dim feet As Double = TextBox1.Text
            Dim inch As Double = TextBox2.Text
            Dim fraction As Double = TextBox3.Text
            Dim gap As Double = TextBox4.Text
            Dim qty As Integer = TextBox5.Text - 1

            Dim span As Double = (feet * 12) + inch + fraction
            Dim totalgap As Double = qty * gap
            Dim combinedpanelspan As Double = span + totalgap
            Dim panelsize As Double = combinedpanelspan / qty
            Dim note As String = qty + 1 & "Panels @" & panelsize & "Each"

            ListBox1.Items.Add(note)
            cleartextbox()


        ElseIf Pick_Box.Text = "Rise-Run Calculator" Then
            If ToolStripStatusLabel1.Text = "Enter Rise" Then
                TextBox6.Text = TextBox_input.Text
                TextBox7.Text = "12"
                ToolStripStatusLabel1.Text = "Enter Plan Span of Roof (Feet)"
            ElseIf ToolStripStatusLabel1.Text = "Enter Plan Span of Roof (Feet)" Then
                calcfeet()
                ToolStripStatusLabel1.Text = "Enter Plan Span of Roof (Inches)"
            ElseIf ToolStripStatusLabel1.Text = "Enter Plan Span of Roof (Inches)" Then
                calcinch()
                ToolStripStatusLabel1.Text = "Enter Plan Span of Roof (Fractional or Decimal)"
            ElseIf ToolStripStatusLabel1.Text = "Enter Plan Span of Roof (Fractional or Decimal)" Then
                calcfractionordecimal("Enter Rise")

            End If
            Dim feet As Double = TextBox1.Text
            Dim inch As Double = TextBox2.Text
            Dim fraction As Double = TextBox3.Text
            Dim span As Double = (feet * 12) + inch + fraction
            Dim rise As Double = (Int(TextBox6.Text) / 12) * span
            Dim totalrooflength As Double = Math.Sqrt((span ^ 2) + (rise ^ 2))
            Dim note As String = "Roof Length =" & totalrooflength

            ListBox1.Items.Add(note)
            cleartextbox()
        End If

    End Sub
    Public Sub HideTextBox()
        TextBox1.Visible = False
        TextBox2.Visible = False
        TextBox3.Visible = False
        TextBox4.Visible = False
        TextBox5.Visible = False
        TextBox6.Visible = False
        TextBox7.Visible = False
    End Sub

    Public Sub HideLabels()
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = False
    End Sub
    Public Sub cleartextbox()
        TextBox1.Text = "0"
        TextBox2.Text = "0"
        TextBox3.Text = "0"
        TextBox4.Text = "0"
        TextBox5.Text = "0"
        TextBox6.Text = "0"
        TextBox7.Text = "0"
    End Sub
    Public Sub clearform()
        ListBox1.Items.Clear()
        TextBox_input.Text = ""
        cleartextbox()

    End Sub
    Public Sub addbtn(ByVal character)
        TextBox_input.Text = TextBox_input.Text & character
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btn_quit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_quit.Click
        Close()

    End Sub

    Private Sub Btn_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Clear.Click
        clearform()

    End Sub

    Private Sub btn_enter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_enter.Click
        MasterProgram()

    End Sub

    Private Sub btn0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn0.Click
        addbtn("0")

    End Sub

    Private Sub btn_dot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_dot.Click
        addbtn(".")
    End Sub

    Private Sub btn_Slash_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Slash.Click
        addbtn("/")
    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        addbtn("1")
    End Sub

    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        addbtn("2")
    End Sub

    Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
        addbtn("3")
    End Sub

    Private Sub btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn4.Click
        addbtn("4")
    End Sub

    Private Sub btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5.Click
        addbtn("5")
    End Sub

    Private Sub btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn6.Click
        addbtn("6")
    End Sub

    Private Sub btn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn7.Click
        addbtn("7")
    End Sub

    Private Sub btn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn8.Click
        addbtn("8")
    End Sub

    Private Sub btn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn9.Click
        addbtn("9")
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.NumPad0 Then
            addbtn("0")
        End If
        If e.KeyCode = Keys.NumPad1 Then
            addbtn("1")
        End If
        If e.KeyCode = Keys.NumPad2 Then
            addbtn("2")
        End If
        If e.KeyCode = Keys.NumPad3 Then
            addbtn("3")
        End If
        If e.KeyCode = Keys.NumPad4 Then
            addbtn("4")
        End If
        If e.KeyCode = Keys.NumPad5 Then
            addbtn("5")
        End If
        If e.KeyCode = Keys.NumPad6 Then
            addbtn("6")
        End If
        If e.KeyCode = Keys.NumPad7 Then
            addbtn("7")
        End If
        If e.KeyCode = Keys.NumPad8 Then
            addbtn("8")
        End If
        If e.KeyCode = Keys.NumPad9 Then
            addbtn("9")
        End If
        If e.KeyCode = 47 Then
            addbtn("/")
        End If
        If e.KeyCode = 46 Then
            addbtn(".")
        End If
        If e.KeyCode = Keys.Enter Then
            MasterProgram()

        End If


    End Sub

    Private Sub Pick_Box_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pick_Box.SelectedIndexChanged
        HideLabels()
        HideTextBox()
        clearform()


        If Pick_Box.SelectedItem = "Architectural to Decimal" Then
            ToolStripStatusLabel1.Text = "Enter Feet"
            TextBox1.Visible = True
            TextBox2.Visible = True
            TextBox3.Visible = True

            Label1.Visible = True
            Label2.Visible = True
            Label3.Visible = True

        ElseIf Pick_Box.SelectedItem = "Fractional Inch to Decimal" Then
            ToolStripStatusLabel1.Text = "Enter Inches"
            TextBox2.Visible = True
            TextBox3.Visible = True


            Label2.Visible = True
            Label3.Visible = True


        ElseIf Pick_Box.SelectedItem = "Fractional Inch to Architectural" Then
            ToolStripStatusLabel1.Text = "Enter Inches"
            TextBox2.Visible = True
            TextBox3.Visible = True



            Label2.Visible = True
            Label3.Visible = True


        ElseIf Pick_Box.SelectedItem = "Decimal Inch to Architectural" Then
            ToolStripStatusLabel1.Text = "Enter Inches"
            TextBox2.Visible = True
            TextBox3.Visible = True



            Label2.Visible = True
            Label3.Visible = True


        ElseIf Pick_Box.SelectedItem = "Architectural(Addition)" Then
            ToolStripStatusLabel1.Text = "Enter Feet"
            TextBox1.Visible = True
            TextBox2.Visible = True
            TextBox3.Visible = True


            Label1.Visible = True
            Label2.Visible = True
            Label3.Visible = True


        ElseIf Pick_Box.SelectedItem = "Architectural(Subtraction)" Then
            ToolStripStatusLabel1.Text = "Enter Feet"
            TextBox1.Visible = True
            TextBox2.Visible = True
            TextBox3.Visible = True


            Label1.Visible = True
            Label2.Visible = True
            Label3.Visible = True


        ElseIf Pick_Box.SelectedItem = "Equal Modular Panels" Then
            ToolStripStatusLabel1.Text = "Enter Total Span of Panels (Feet)"
            TextBox1.Visible = True
            TextBox2.Visible = True
            TextBox3.Visible = True
            TextBox4.Visible = True
            TextBox5.Visible = True


            Label1.Visible = True
            Label2.Visible = True
            Label3.Visible = True
            Label4.Visible = True
            Label5.Visible = True


        ElseIf Pick_Box.SelectedItem = "Equal Lapped Panels" Then
            ToolStripStatusLabel1.Text = "Enter Total Span of Panels (Feet)"
            TextBox1.Visible = True
            TextBox2.Visible = True
            TextBox3.Visible = True
            TextBox4.Visible = True
            TextBox5.Visible = True


            Label1.Visible = True
            Label2.Visible = True
            Label3.Visible = True
            Label4.Visible = True
            Label5.Visible = True


        ElseIf Pick_Box.SelectedItem = "Rise-Run Calculator" Then
            ToolStripStatusLabel1.Text = "Enter Rise"
            TextBox1.Visible = True
            TextBox2.Visible = True
            TextBox3.Visible = True

            TextBox6.Visible = True
            TextBox7.Visible = True

            Label1.Visible = True
            Label2.Visible = True
            Label3.Visible = True

            Label6.Visible = True
            Label7.Visible = True


        End If



    End Sub
End Class
