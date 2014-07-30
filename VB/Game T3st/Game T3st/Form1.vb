Imports System.Threading

Public Class Form1
    Dim WalkRight As Integer
    Dim WalkLeft As Integer
    Dim JumpTime As Integer
    Dim StepLeft As Integer = 0
    Dim StepRight As Integer = 0
    Dim LevelMulti As Integer = My.Settings.LevelMulti
    Dim MunnyCount As Integer
    Dim HealthDamage As Integer = My.Settings.HealthDamage
    Dim HealthMax As Integer = My.Settings.HealthMax
    Dim HealthCurrent As Integer = My.Settings.HealthCurrent


    Public Sub moveRight()
        Dim x1 As Integer = picBowser.Location.X
        Dim y1 As Integer = picBowser.Location.Y

        If WalkRight = 1 Then
            picBowser.Image = My.Resources.BowserRight1
            x1 += 4
            picBowser.Location = New Point(x1, y1)
        ElseIf WalkRight = 2 Then
            picBowser.Image = My.Resources.BowserRight2
            x1 += 5
            picBowser.Location = New Point(x1, y1)
        ElseIf WalkRight = 3 Then
            picBowser.Image = My.Resources.BowserRight3
            x1 += 5
            picBowser.Location = New Point(x1, y1)
        ElseIf WalkRight = 4 Then
            picBowser.Image = My.Resources.BowserRight4
            x1 += 6
            picBowser.Location = New Point(x1, y1)
        ElseIf WalkRight = 5 Then
            picBowser.Image = My.Resources.BowserRight5
            x1 += 5
            picBowser.Location = New Point(x1, y1)
        ElseIf WalkRight = 6 Then
            picBowser.Image = My.Resources.BowserRight6
            x1 += 4
            picBowser.Location = New Point(x1, y1)
        ElseIf WalkRight = 7 Then
            picBowser.Image = My.Resources.BowserRight7
            x1 += 2
            picBowser.Location = New Point(x1, y1)
        ElseIf WalkRight = 8 Then
            picBowser.Image = My.Resources.BowserRight8
            x1 += 3
            picBowser.Location = New Point(x1, y1)
        Else : picBowser.Image = My.Resources.BowserRight
            timeWalkRight.Enabled = False
            WalkRight = 0
            StepRight = 1
        End If
    End Sub
    Public Sub moveRight1()
        Dim x1 As Integer = picBowser.Location.X
        Dim y1 As Integer = picBowser.Location.Y

        If WalkRight = 1 Then
            picBowser.Image = My.Resources.BowserRight9
            x1 += 4
            picBowser.Location = New Point(x1, y1)
        ElseIf WalkRight = 2 Then
            picBowser.Image = My.Resources.BowserRight10
            x1 += 5
            picBowser.Location = New Point(x1, y1)
        ElseIf WalkRight = 3 Then
            picBowser.Image = My.Resources.BowserRight11
            x1 += 6
            picBowser.Location = New Point(x1, y1)
        ElseIf WalkRight = 4 Then
            picBowser.Image = My.Resources.BowserRight12
            x1 += 6
            picBowser.Location = New Point(x1, y1)
        ElseIf WalkRight = 5 Then
            picBowser.Image = My.Resources.BowserRight13
            x1 += 4
            picBowser.Location = New Point(x1, y1)
        ElseIf WalkRight = 6 Then
            picBowser.Image = My.Resources.BowserRight14
            x1 += 4
            picBowser.Location = New Point(x1, y1)
        ElseIf WalkRight = 7 Then
            picBowser.Image = My.Resources.BowserRight15
            x1 += 2
            picBowser.Location = New Point(x1, y1)
        Else : picBowser.Image = My.Resources.BowserRight
            timeWalkRight.Enabled = False
            WalkRight = 0
            StepRight = 0
        End If
    End Sub

    Public Sub moveLeft()
        Dim x1 As Integer = picBowser.Location.X
        Dim y1 As Integer = picBowser.Location.Y

        If WalkLeft = 1 Then
            picBowser.Image = My.Resources.BowserLeft1
            x1 -= 4
            picBowser.Location = New Point(x1, y1)
        ElseIf WalkLeft = 2 Then
            picBowser.Image = My.Resources.BowserLeft2
            x1 -= 5
            picBowser.Location = New Point(x1, y1)
        ElseIf WalkLeft = 3 Then
            picBowser.Image = My.Resources.BowserLeft3
            x1 -= 5
            picBowser.Location = New Point(x1, y1)
        ElseIf WalkLeft = 4 Then
            picBowser.Image = My.Resources.BowserLeft4
            x1 -= 6
            picBowser.Location = New Point(x1, y1)
        ElseIf WalkLeft = 5 Then
            picBowser.Image = My.Resources.BowserLeft5
            x1 -= 5
            picBowser.Location = New Point(x1, y1)
        ElseIf WalkLeft = 6 Then
            picBowser.Image = My.Resources.BowserLeft6
            x1 -= 4
            picBowser.Location = New Point(x1, y1)
        ElseIf WalkLeft = 7 Then
            picBowser.Image = My.Resources.BowserLeft7
            x1 -= 2
            picBowser.Location = New Point(x1, y1)
        ElseIf WalkLeft = 8 Then
            picBowser.Image = My.Resources.BowserLeft8
            x1 -= 2
            picBowser.Location = New Point(x1, y1)
        Else : picBowser.Image = My.Resources.BowserLeft
            timeWalkLeft.Enabled = False
            StepLeft = 1
            WalkLeft = 0
        End If
    End Sub
    Public Sub moveLeft1()
        Dim x1 As Integer = picBowser.Location.X
        Dim y1 As Integer = picBowser.Location.Y

        If WalkLeft = 1 Then
            picBowser.Image = My.Resources.BowserLeft9
            x1 -= 4
            picBowser.Location = New Point(x1, y1)
        ElseIf WalkLeft = 2 Then
            picBowser.Image = My.Resources.BowserLeft10
            x1 -= 5
            picBowser.Location = New Point(x1, y1)
        ElseIf WalkLeft = 3 Then
            picBowser.Image = My.Resources.BowserLeft11
            x1 -= 6
            picBowser.Location = New Point(x1, y1)
        ElseIf WalkLeft = 4 Then
            picBowser.Image = My.Resources.BowserLeft12
            x1 -= 6
            picBowser.Location = New Point(x1, y1)
        ElseIf WalkLeft = 5 Then
            picBowser.Image = My.Resources.BowserLeft13
            x1 -= 4
            picBowser.Location = New Point(x1, y1)
        ElseIf WalkLeft = 6 Then
            picBowser.Image = My.Resources.BowserLeft14
            x1 -= 4
            picBowser.Location = New Point(x1, y1)
        ElseIf WalkLeft = 7 Then
            picBowser.Image = My.Resources.BowserLeft15
            x1 -= 2
            picBowser.Location = New Point(x1, y1)
        Else : picBowser.Image = My.Resources.BowserLeft
            timeWalkLeft.Enabled = False
            WalkLeft = 0
            StepLeft = 0
        End If
    End Sub

    Public Sub Jump()
        Dim x1 As Integer = picBowser.Location.X
        Dim y1 As Integer = picBowser.Location.Y
        Dim xStart As Integer = picBowser.Location.X
        Dim yStart As Integer = picBowser.Location.Y
        Dim JumpLoop As Integer = 0
        Dim x2 As Double = 0
        Dim y2 As Double
        Dim a As Double = -0.16

        Do Until JumpLoop >= 51
            y2 = a * (((JumpTime - 25) ^ 2) - 625)
            y1 = yStart - y2
            picBowser.Location = New Point(x1, y1)
            Thread.Sleep(15)
            JumpLoop += 1
            JumpTime += 1
            CollectRupeeGreen()
        Loop
        JumpTime = 0
    End Sub
    Public Sub JumpLeft()
        Dim x1 As Integer = picBowser.Location.X
        Dim y1 As Integer = picBowser.Location.Y
        Dim xStart As Integer = picBowser.Location.X
        Dim yStart As Integer = picBowser.Location.Y
        Dim JumpLoop As Integer = 0
        Dim x2 As Double = 0
        Dim y2 As Double
        Dim a As Double = -0.16

        Do Until JumpLoop >= 51
            y2 = a * (((JumpTime - 25) ^ 2) - 625)
            y1 = yStart - y2
            x1 -= 3
            picBowser.Location = New Point(x1, y1)
            Thread.Sleep(15)
            JumpLoop += 1
            JumpTime += 1
            CollectRupeeGreen()
        Loop
        JumpTime = 0
    End Sub
    Public Sub JumpRight()
        Dim x1 As Integer = picBowser.Location.X
        Dim y1 As Integer = picBowser.Location.Y
        Dim xStart As Integer = picBowser.Location.X
        Dim yStart As Integer = picBowser.Location.Y
        Dim JumpLoop As Integer = 0
        Dim x2 As Double = 0
        Dim y2 As Double
        Dim a As Double = -0.16

        Do Until JumpLoop >= 51
            y2 = a * (((JumpTime - 25) ^ 2) - 625)
            y1 = yStart - y2
            x1 += 3
            picBowser.Location = New Point(x1, y1)
            Thread.Sleep(15)
            JumpLoop += 1
            JumpTime += 1
            CollectRupeeGreen()
        Loop
        JumpTime = 0
    End Sub
    Public Sub Interact()
        Collision()
        CollectRupeeGreen()
    End Sub
    Public Sub Collision()
        Dim BowserRight As Integer = picBowser.Location.X + 74
        Dim BowserLeft As Integer = picBowser.Location.X
        Dim BowserBottom As Integer = picBowser.Location.Y + 74
        Dim BowserTop As Integer = picBowser.Location.Y + 10
        Dim EnemyRight As Integer = Flame.Location.X + 28
        Dim EnemyLeft As Integer = Flame.Location.X
        Dim EnemyBottom As Integer = Flame.Location.Y + 42
        Dim EnemyTop As Integer = Flame.Location.Y
        Dim CollisionX As Boolean = False
        Dim CollisionY As Boolean = False

        If (EnemyRight > BowserLeft And BowserRight > EnemyRight) Or (EnemyLeft > BowserLeft And BowserRight > EnemyLeft) Then
            CollisionX = True
        End If
        If (EnemyBottom > BowserTop And BowserBottom > EnemyBottom) Or (EnemyTop > BowserTop And BowserBottom > EnemyTop) Then
            CollisionY = True
        End If

        If CollisionX = True And CollisionY = True Then
            HealthDamage += 10
            Health()
            CollisionX = False
            CollisionY = False
        End If
    End Sub

    Public Sub CollectRupeeGreen()
        Dim BowserRight As Integer = picBowser.Location.X + 60
        Dim BowserLeft As Integer = picBowser.Location.X + 33
        Dim BowserBottom As Integer = picBowser.Location.Y + 74
        Dim BowserTop As Integer = picBowser.Location.Y + 15
        Dim BowserHeadRight As Integer = picBowser.Location.X + 67
        Dim BowserHeadLeft As Integer = picBowser.Location.X + 7
        Dim BowserHeadBottom As Integer = picBowser.Location.Y + 47
        Dim BowserHeadTop As Integer = picBowser.Location.Y + 15
        Dim RupeeGreenRight As Integer = picRupeeGreen.Location.X + 18
        Dim RupeeGreenLeft As Integer = picRupeeGreen.Location.X + 3
        Dim RupeeGreenBottom As Integer = picRupeeGreen.Location.Y + 31
        Dim RupeeGreenTop As Integer = picRupeeGreen.Location.Y
        Dim RupeeGreen1Right As Integer = picRupeeGreen1.Location.X + 18
        Dim RupeeGreen1Left As Integer = picRupeeGreen1.Location.X + 3
        Dim RupeeGreen1Bottom As Integer = picRupeeGreen1.Location.Y + 31
        Dim RupeeGreen1Top As Integer = picRupeeGreen1.Location.Y

        Dim CollectX As Boolean = False
        Dim CollectY As Boolean = False
        Dim CollectX1 As Boolean = False
        Dim CollectY1 As Boolean = False

        If (RupeeGreenRight > BowserLeft And BowserRight > RupeeGreenRight) Or (RupeeGreenLeft > BowserLeft And BowserRight > RupeeGreenLeft) Then
            CollectX = True
        End If
        If (RupeeGreenBottom > BowserTop And BowserBottom > RupeeGreenBottom) Or (RupeeGreenTop > BowserTop And BowserBottom > RupeeGreenTop) Then
            CollectY = True
        End If
        If (RupeeGreen1Right > BowserLeft And BowserRight > RupeeGreen1Right) Or (RupeeGreen1Left > BowserLeft And BowserRight > RupeeGreen1Left) Then
            CollectX1 = True
        End If
        If (RupeeGreen1Bottom > BowserTop And BowserBottom > RupeeGreen1Bottom) Or (RupeeGreen1Top > BowserTop And BowserBottom > RupeeGreen1Top) Then
            CollectY1 = True
        End If
        If (RupeeGreenRight > BowserHeadLeft And BowserHeadRight > RupeeGreenRight) Or (RupeeGreenLeft > BowserHeadLeft And BowserHeadRight > RupeeGreenLeft) Then
            CollectX = True
        End If
        If (RupeeGreenBottom > BowserHeadTop And BowserHeadBottom > RupeeGreenBottom) Or (RupeeGreenTop > BowserHeadTop And BowserHeadBottom > RupeeGreenTop) Then
            CollectY = True
        End If
        If (RupeeGreen1Right > BowserHeadLeft And BowserHeadRight > RupeeGreen1Right) Or (RupeeGreen1Left > BowserHeadLeft And BowserHeadRight > RupeeGreen1Left) Then
            CollectX1 = True
        End If
        If (RupeeGreen1Bottom > BowserHeadTop And BowserHeadBottom > RupeeGreen1Bottom) Or (RupeeGreen1Top > BowserHeadTop And BowserHeadBottom > RupeeGreen1Top) Then
            CollectY1 = True
        End If

        If CollectX = True And CollectY = True Then
            picRupeeGreen.Visible = False
            picRupeeGreen.Location = New Point(-30, -30)
            'MunnyCount += 1
            lblMunny.Text += 1
            'Munny()
            CollectX = False
            CollectY = False
        End If

        If CollectX1 = True And CollectY1 = True Then
            picRupeeGreen1.Visible = False
            picRupeeGreen1.Location = New Point(-30, -30)
            'MunnyCount += 1
            lblMunny.Text += 1
            'Munny()
            CollectX1 = False
            CollectY1 = False
        End If
    End Sub

    'Public Sub Munny()
    'lblMunny.Text = MunnyCount
    'End Sub
    Public Sub Health()
        HealthCurrent = HealthMax - HealthDamage
        Dim HealthBar As Integer = (HealthCurrent * 2)
        lblHealth.Text = "Health " & HealthCurrent & "/" & HealthMax
        lblHealthBar.Size = New Size(HealthBar, 11)
        If HealthCurrent <= 0 Then
            MessageBox.Show("You have died," & vbCrLf & "You lose.", "DEAD", MessageBoxButtons.OK, MessageBoxIcon.Error)
            picBowser.Location = New Point(399, 209)
            Me.Close()
        End If
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Dim x1 As Integer = picBowser.Location.X
        Dim y1 As Integer = picBowser.Location.Y
        Dim xStart As Integer = picBowser.Location.X
        Dim yStart As Integer = picBowser.Location.Y
        Dim blnLeft As Boolean = False
        Dim blnRight As Boolean = False

        If e.KeyCode = Keys.Up Then
            timeJump.Enabled = True
            Collision()
            CollectRupeeGreen()

        ElseIf e.KeyCode = Keys.Right Then
            timeWalkRight.Enabled = True
            timeWalkLeft.Enabled = False
            Collision()
            CollectRupeeGreen()

        ElseIf e.KeyCode = Keys.Down Then
            y1 += 10
            picBowser.Location = New Point(x1, y1)
            Collision()
            CollectRupeeGreen()

        ElseIf e.KeyCode = Keys.Left Then
            timeWalkRight.Enabled = False
            timeWalkLeft.Enabled = True
            Collision()
            CollectRupeeGreen()

        ElseIf e.KeyCode = Keys.Z Then
            timeWalkRight.Enabled = False
            timeWalkLeft.Enabled = False
            timeJumpLeft.Enabled = True
            Collision()
            CollectRupeeGreen()

        ElseIf e.KeyCode = Keys.X Then
            timeWalkRight.Enabled = False
            timeWalkLeft.Enabled = False
            timeJumpRight.Enabled = True
            Collision()
            CollectRupeeGreen()
        End If


    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timeWalkRight.Tick
        WalkRight += 1
        If StepRight = 0 Then
            moveRight()
        ElseIf StepRight = 1 Then
            moveRight1()
        End If

    End Sub

    Private Sub timeWalkLeft_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timeWalkLeft.Tick
        WalkLeft += 1
        If StepLeft = 0 Then
            moveLeft()
        ElseIf StepLeft = 1 Then
            moveLeft1()
        End If

    End Sub

    Private Sub timeJump_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timeJump.Tick
        Dim JumpCount As Integer
        Jump()
        JumpCount += 1

        If JumpCount >= 1 Then
            JumpCount = 0
            timeJump.Enabled = False
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub timeJumpLeft_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timeJumpLeft.Tick
        Dim JumpCount As Integer
        JumpLeft()
        JumpCount += 1

        If JumpCount >= 1 Then
            JumpCount = 0
            timeJumpLeft.Enabled = False
        End If
    End Sub
    Private Sub timeJumpRight_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timeJumpRight.Tick
        Dim JumpCount As Integer
        JumpRight()
        JumpCount += 1

        If JumpCount >= 1 Then
            JumpCount = 0
            timeJumpRight.Enabled = False
        End If
    End Sub
End Class
