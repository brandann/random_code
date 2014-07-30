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
        Me.timeJump = New System.Windows.Forms.Timer(Me.components)
        Me.picBowser = New System.Windows.Forms.PictureBox()
        Me.timeWalkRight = New System.Windows.Forms.Timer(Me.components)
        Me.surPlatform = New System.Windows.Forms.PictureBox()
        Me.surGround = New System.Windows.Forms.PictureBox()
        Me.timeWalkLeft = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picBowser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.surPlatform, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.surGround, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'timeJump
        '
        Me.timeJump.Interval = 25
        '
        'picBowser
        '
        Me.picBowser.BackColor = System.Drawing.Color.Transparent
        Me.picBowser.Image = Global.Character_Control_Test.My.Resources.Resources.BowserRight
        Me.picBowser.Location = New System.Drawing.Point(153, 337)
        Me.picBowser.Name = "picBowser"
        Me.picBowser.Size = New System.Drawing.Size(71, 64)
        Me.picBowser.TabIndex = 0
        Me.picBowser.TabStop = False
        '
        'timeWalkRight
        '
        Me.timeWalkRight.Interval = 35
        '
        'surPlatform
        '
        Me.surPlatform.Image = Global.Character_Control_Test.My.Resources.Resources.Platform
        Me.surPlatform.Location = New System.Drawing.Point(311, 290)
        Me.surPlatform.Name = "surPlatform"
        Me.surPlatform.Size = New System.Drawing.Size(96, 32)
        Me.surPlatform.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.surPlatform.TabIndex = 3
        Me.surPlatform.TabStop = False
        '
        'surGround
        '
        Me.surGround.BackgroundImage = Global.Character_Control_Test.My.Resources.Resources.Ground_Platform
        Me.surGround.Location = New System.Drawing.Point(117, 401)
        Me.surGround.Name = "surGround"
        Me.surGround.Size = New System.Drawing.Size(485, 32)
        Me.surGround.TabIndex = 5
        Me.surGround.TabStop = False
        '
        'timeWalkLeft
        '
        Me.timeWalkLeft.Interval = 35
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Character_Control_Test.My.Resources.Resources.sky
        Me.ClientSize = New System.Drawing.Size(715, 432)
        Me.Controls.Add(Me.surGround)
        Me.Controls.Add(Me.surPlatform)
        Me.Controls.Add(Me.picBowser)
        Me.Name = "Form1"
        CType(Me.picBowser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.surPlatform, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.surGround, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picBowser As System.Windows.Forms.PictureBox
    Friend WithEvents timeJump As System.Windows.Forms.Timer
    Friend WithEvents timeWalkRight As System.Windows.Forms.Timer
    Friend WithEvents surPlatform As System.Windows.Forms.PictureBox
    Friend WithEvents surGround As System.Windows.Forms.PictureBox
    Friend WithEvents timeWalkLeft As System.Windows.Forms.Timer

End Class
