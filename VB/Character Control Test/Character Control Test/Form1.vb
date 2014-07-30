Public Class Form1
    Dim picBowserXStart As Integer
    Dim picBowserYStart As Integer
    Dim blnRight As Boolean = False
    Dim blnLeft As Boolean = False
    Dim JumpTime As Integer = 1
    Dim StepRight As Integer
    Dim StepLeft As Integer
    Dim countWalk As Integer = 0
    Dim blnPlatForm As Boolean
    Dim blnGround As Boolean

    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If ((picBowser.Right - 30) > surGround.Left And (picBowser.Right - 30) < surGround.Right) Or
            ((picBowser.Left + 15) > surGround.Left And (picBowser.Left + 15) < surGround.Right) Then
            blnGround = True
        Else
            blnGround = False
        End If
        If ((picBowser.Right - 30) > surPlatform.Left And (picBowser.Right - 30) < surPlatform.Right) Or
                ((picBowser.Left + 15) > surPlatform.Left And (picBowser.Left + 15) < surPlatform.Right) Then
            blnPlatForm = True
        Else
            blnPlatForm = False
        End If

        If (e.KeyCode = Keys.Up) And (timeJump.Enabled = False) Then
            picBowserXStart = picBowser.Location.X
            picBowserYStart = picBowser.Location.Y
            timeJump.Enabled = True
            timeWalkLeft.Enabled = False
            timeWalkRight.Enabled = False
            If blnLeft Then
                WalkLeft0(0)
            ElseIf blnRight Then
                WalkRight0(0)
            End If
        ElseIf (e.KeyCode = Keys.Right) And (timeJump.Enabled = False) Then
            timeWalkRight.Enabled = True
        ElseIf (e.KeyCode = Keys.Left) And (timeJump.Enabled = False) Then
            timeWalkLeft.Enabled = True
        End If

        If e.KeyCode = Keys.Right Then
            blnRight = True
        ElseIf e.KeyCode = Keys.Left Then
            blnLeft = True
        End If
    End Sub

    Private Sub timeJump_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timeJump.Tick
        Dim picBowserX As Integer = picBowser.Location.X
        Dim picBowserY As Integer = picBowser.Location.Y
        Dim x As Integer
        Dim a As Double = -0.35

        x = a * (((JumpTime - 20) ^ 2) - 400)
        picBowserY = picBowserYStart - x
        If blnRight = True Then
            picBowserX = picBowserX + 5
        ElseIf blnLeft = True Then
            picBowserX = picBowserX - 5
        End If
        picBowser.Location = New Point(picBowserX, picBowserY)
        JumpTime += 1
        If blnGround Then
            If picBowser.Bottom > surGround.Top Then
                timeJump.Enabled = False
                JumpTime = 0
                picBowser.Location = New Point(picBowserX, (surGround.Top - picBowser.Height))
            End If
        End If
        If blnPlatForm Then
            If (picBowser.Bottom > surPlatform.Top) And (picBowser.Bottom < (surPlatform.Top + 20)) Then
                timeJump.Enabled = False
                JumpTime = 0
                picBowser.Location = New Point(picBowserX, (surPlatform.Top - picBowser.Height))
            End If
        End If
    End Sub
    Private Sub Form1_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Right Then
            blnRight = False
        ElseIf e.KeyCode = Keys.Left Then
            blnLeft = False
        End If
    End Sub
    Private Sub timeWalkRight_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timeWalkRight.Tick

        If blnRight = True Then
            countWalk += 1
            If StepRight = 0 Then
                WalkRight0(countWalk)
            ElseIf StepRight = 1 Then
                WalkRight1(countWalk)
            End If
        Else
            WalkRight0(0)
            timeWalkRight.Enabled = False
        End If
    End Sub
    Public Sub WalkRight0(ByVal intWalkRight As Integer)
        Dim picBowserX As Integer = picBowser.Location.X
        Dim picBowserY As Integer = picBowser.Location.Y
        Dim intDist As Integer = 7

        Select Case intWalkRight
            Case 0
                picBowser.Image = My.Resources.BowserRight
            Case 1
                picBowser.Image = My.Resources.BowserRight1
                picBowserX += intDist
                picBowser.Location = New Point(picBowserX, picBowserY)
            Case 2
                picBowser.Image = My.Resources.BowserRight2
                picBowserX += intDist
                picBowser.Location = New Point(picBowserX, picBowserY)
            Case 3
                picBowser.Image = My.Resources.BowserRight3
                picBowserX += intDist
                picBowser.Location = New Point(picBowserX, picBowserY)
            Case 4
                picBowser.Image = My.Resources.BowserRight4
                picBowserX += intDist
                picBowser.Location = New Point(picBowserX, picBowserY)
                countWalk = 0
                StepRight = 1
                If blnRight = False Then
                    timeWalkRight.Enabled = False
                End If
        End Select
    End Sub
    Public Sub WalkRight1(ByVal intWalkRight As Integer)
        Dim picBowserX As Integer = picBowser.Location.X
        Dim picBowserY As Integer = picBowser.Location.Y
        Dim intDist As Integer = 7

        Select Case intWalkRight
            Case 0
                picBowser.Image = My.Resources.BowserRight
            Case 1
                picBowser.Image = My.Resources.BowserRight5
                picBowserX += intDist
                picBowser.Location = New Point(picBowserX, picBowserY)
            Case 2
                picBowser.Image = My.Resources.BowserRight6
                picBowserX += intDist
                picBowser.Location = New Point(picBowserX, picBowserY)
            Case 3
                picBowser.Image = My.Resources.BowserRight7
                picBowserX += intDist
                picBowser.Location = New Point(picBowserX, picBowserY)
            Case 4
                picBowser.Image = My.Resources.BowserRight8
                picBowserX += intDist
                picBowser.Location = New Point(picBowserX, picBowserY)
                countWalk = 0
                StepRight = 0
                If blnRight = False Then
                    timeWalkRight.Enabled = False
                End If
        End Select
    End Sub
    Public Sub WalkLeft0(ByVal intWalkLeft As Integer)
        Dim picBowserX As Integer = picBowser.Location.X
        Dim picBowserY As Integer = picBowser.Location.Y
        Dim intDist As Integer = -7

        Select Case intWalkLeft
            Case 0
                picBowser.Image = My.Resources.BowserLeft
            Case 1
                picBowser.Image = My.Resources.BowserLeft1
                picBowserX += intDist
                picBowser.Location = New Point(picBowserX, picBowserY)
            Case 2
                picBowser.Image = My.Resources.BowserLeft2
                picBowserX += intDist
                picBowser.Location = New Point(picBowserX, picBowserY)
            Case 3
                picBowser.Image = My.Resources.BowserLeft3
                picBowserX += intDist
                picBowser.Location = New Point(picBowserX, picBowserY)
            Case 4
                picBowser.Image = My.Resources.BowserLeft4
                picBowserX += intDist
                picBowser.Location = New Point(picBowserX, picBowserY)
                countWalk = 0
                StepLeft = 1
                If blnLeft = False Then
                    timeWalkLeft.Enabled = False
                End If
        End Select
    End Sub
    Public Sub WalkLeft1(ByVal intWalkLeft As Integer)
        Dim picBowserX As Integer = picBowser.Location.X
        Dim picBowserY As Integer = picBowser.Location.Y
        Dim intDist As Integer = -7

        Select Case intWalkLeft
            Case 0
                picBowser.Image = My.Resources.BowserLeft
            Case 1
                picBowser.Image = My.Resources.BowserLeft5
                picBowserX += intDist
                picBowser.Location = New Point(picBowserX, picBowserY)
            Case 2
                picBowser.Image = My.Resources.BowserLeft6
                picBowserX += intDist
                picBowser.Location = New Point(picBowserX, picBowserY)
            Case 3
                picBowser.Image = My.Resources.BowserLeft7
                picBowserX += intDist
                picBowser.Location = New Point(picBowserX, picBowserY)
            Case 4
                picBowser.Image = My.Resources.BowserLeft8
                picBowserX += intDist
                picBowser.Location = New Point(picBowserX, picBowserY)
                countWalk = 0
                StepLeft = 0
                If blnLeft = False Then
                    timeWalkLeft.Enabled = False
                End If
        End Select
    End Sub
    Private Sub timeWalkLeft_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timeWalkLeft.Tick
        If blnLeft = True Then
            countWalk += 1
            If StepLeft = 0 Then
                WalkLeft0(countWalk)
            ElseIf StepLeft = 1 Then
                WalkLeft1(countWalk)
            End If
        Else
            WalkLeft0(0)
            timeWalkLeft.Enabled = False
        End If
    End Sub
End Class
