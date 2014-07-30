<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.timeWalkRight = New System.Windows.Forms.Timer(Me.components)
        Me.timeWalkLeft = New System.Windows.Forms.Timer(Me.components)
        Me.timeJump = New System.Windows.Forms.Timer(Me.components)
        Me.lblMoneyLabel = New System.Windows.Forms.Label()
        Me.lblMunny = New System.Windows.Forms.Label()
        Me.lblHealthBar = New System.Windows.Forms.Label()
        Me.lblHealth = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.picRupeeGreen1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.picRupeeGreen = New System.Windows.Forms.PictureBox()
        Me.Flame = New System.Windows.Forms.PictureBox()
        Me.picBowser = New System.Windows.Forms.PictureBox()
        Me.timeJumpLeft = New System.Windows.Forms.Timer(Me.components)
        Me.timeJumpRight = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picRupeeGreen1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRupeeGreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Flame, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBowser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'timeWalkRight
        '
        Me.timeWalkRight.Interval = 15
        '
        'timeWalkLeft
        '
        Me.timeWalkLeft.Interval = 15
        '
        'timeJump
        '
        Me.timeJump.Interval = 35
        '
        'lblMoneyLabel
        '
        Me.lblMoneyLabel.AutoSize = True
        Me.lblMoneyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoneyLabel.Location = New System.Drawing.Point(13, 13)
        Me.lblMoneyLabel.Name = "lblMoneyLabel"
        Me.lblMoneyLabel.Size = New System.Drawing.Size(130, 25)
        Me.lblMoneyLabel.TabIndex = 3
        Me.lblMoneyLabel.Text = "Munny       x"
        '
        'lblMunny
        '
        Me.lblMunny.AutoSize = True
        Me.lblMunny.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMunny.Location = New System.Drawing.Point(143, 11)
        Me.lblMunny.Name = "lblMunny"
        Me.lblMunny.Size = New System.Drawing.Size(29, 31)
        Me.lblMunny.TabIndex = 5
        Me.lblMunny.Text = "0"
        '
        'lblHealthBar
        '
        Me.lblHealthBar.BackColor = System.Drawing.Color.DarkRed
        Me.lblHealthBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHealthBar.Location = New System.Drawing.Point(13, 44)
        Me.lblHealthBar.Name = "lblHealthBar"
        Me.lblHealthBar.Size = New System.Drawing.Size(200, 11)
        Me.lblHealthBar.TabIndex = 7
        '
        'lblHealth
        '
        Me.lblHealth.BackColor = System.Drawing.Color.Transparent
        Me.lblHealth.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHealth.Location = New System.Drawing.Point(13, 55)
        Me.lblHealth.Name = "lblHealth"
        Me.lblHealth.Size = New System.Drawing.Size(206, 24)
        Me.lblHealth.TabIndex = 8
        Me.lblHealth.Text = "Health 100/100"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DarkGreen
        Me.Label1.Location = New System.Drawing.Point(302, 283)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(535, 99)
        Me.Label1.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.DarkGreen
        Me.Label2.Location = New System.Drawing.Point(-210, 283)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(400, 99)
        Me.Label2.TabIndex = 10
        '
        'picRupeeGreen1
        '
        Me.picRupeeGreen1.Image = Global.WindowsApplication1.My.Resources.Resources.RupeeGreen1
        Me.picRupeeGreen1.Location = New System.Drawing.Point(161, 109)
        Me.picRupeeGreen1.Name = "picRupeeGreen1"
        Me.picRupeeGreen1.Size = New System.Drawing.Size(21, 30)
        Me.picRupeeGreen1.TabIndex = 6
        Me.picRupeeGreen1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.RupeeGreen
        Me.PictureBox1.Location = New System.Drawing.Point(91, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(21, 30)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'picRupeeGreen
        '
        Me.picRupeeGreen.Image = Global.WindowsApplication1.My.Resources.Resources.RupeeGreen1
        Me.picRupeeGreen.Location = New System.Drawing.Point(161, 250)
        Me.picRupeeGreen.Name = "picRupeeGreen"
        Me.picRupeeGreen.Size = New System.Drawing.Size(21, 30)
        Me.picRupeeGreen.TabIndex = 2
        Me.picRupeeGreen.TabStop = False
        '
        'Flame
        '
        Me.Flame.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Flame.Image = Global.WindowsApplication1.My.Resources.Resources.flame_symbol31
        Me.Flame.Location = New System.Drawing.Point(65, 244)
        Me.Flame.Name = "Flame"
        Me.Flame.Size = New System.Drawing.Size(28, 42)
        Me.Flame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Flame.TabIndex = 1
        Me.Flame.TabStop = False
        '
        'picBowser
        '
        Me.picBowser.Image = Global.WindowsApplication1.My.Resources.Resources.BowserLeft15
        Me.picBowser.Location = New System.Drawing.Point(410, 212)
        Me.picBowser.Name = "picBowser"
        Me.picBowser.Size = New System.Drawing.Size(74, 74)
        Me.picBowser.TabIndex = 0
        Me.picBowser.TabStop = False
        '
        'timeJumpLeft
        '
        Me.timeJumpLeft.Interval = 35
        '
        'timeJumpRight
        '
        Me.timeJumpRight.Interval = 35
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(828, 378)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblHealth)
        Me.Controls.Add(Me.lblHealthBar)
        Me.Controls.Add(Me.picRupeeGreen1)
        Me.Controls.Add(Me.lblMunny)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblMoneyLabel)
        Me.Controls.Add(Me.picRupeeGreen)
        Me.Controls.Add(Me.Flame)
        Me.Controls.Add(Me.picBowser)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picRupeeGreen1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRupeeGreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Flame, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBowser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picBowser As System.Windows.Forms.PictureBox
    Friend WithEvents timeWalkRight As System.Windows.Forms.Timer
    Friend WithEvents timeWalkLeft As System.Windows.Forms.Timer
    Friend WithEvents Flame As System.Windows.Forms.PictureBox
    Friend WithEvents timeJump As System.Windows.Forms.Timer
    Friend WithEvents picRupeeGreen As System.Windows.Forms.PictureBox
    Friend WithEvents lblMoneyLabel As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblMunny As System.Windows.Forms.Label
    Friend WithEvents picRupeeGreen1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblHealthBar As System.Windows.Forms.Label
    Friend WithEvents lblHealth As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents timeJumpLeft As System.Windows.Forms.Timer
    Friend WithEvents timeJumpRight As System.Windows.Forms.Timer

End Class
