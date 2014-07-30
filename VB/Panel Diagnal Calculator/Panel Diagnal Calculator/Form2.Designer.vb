<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calcform
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolLbl = New System.Windows.Forms.ToolStripStatusLabel()
        Me.systemcombo = New System.Windows.Forms.ComboBox()
        Me.thicknesscombo = New System.Windows.Forms.ComboBox()
        Me.hbox = New System.Windows.Forms.TextBox()
        Me.w2box = New System.Windows.Forms.TextBox()
        Me.w1box = New System.Windows.Forms.TextBox()
        Me.w3box = New System.Windows.Forms.TextBox()
        Me.w4box = New System.Windows.Forms.TextBox()
        Me.hlbl = New System.Windows.Forms.Label()
        Me.w1lbl = New System.Windows.Forms.Label()
        Me.w2lbl = New System.Windows.Forms.Label()
        Me.w3lbl = New System.Windows.Forms.Label()
        Me.w4lbl = New System.Windows.Forms.Label()
        Me.sidescombo = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.EFcombo = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolLbl})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 343)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusStrip1.Size = New System.Drawing.Size(859, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolLbl
        '
        Me.ToolLbl.Name = "ToolLbl"
        Me.ToolLbl.Size = New System.Drawing.Size(0, 17)
        '
        'systemcombo
        '
        Me.systemcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.systemcombo.FormattingEnabled = True
        Me.systemcombo.Location = New System.Drawing.Point(12, 12)
        Me.systemcombo.Name = "systemcombo"
        Me.systemcombo.Size = New System.Drawing.Size(276, 21)
        Me.systemcombo.TabIndex = 2
        '
        'thicknesscombo
        '
        Me.thicknesscombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.thicknesscombo.FormattingEnabled = True
        Me.thicknesscombo.Location = New System.Drawing.Point(12, 66)
        Me.thicknesscombo.Name = "thicknesscombo"
        Me.thicknesscombo.Size = New System.Drawing.Size(275, 21)
        Me.thicknesscombo.TabIndex = 3
        '
        'hbox
        '
        Me.hbox.Location = New System.Drawing.Point(13, 134)
        Me.hbox.Name = "hbox"
        Me.hbox.Size = New System.Drawing.Size(100, 20)
        Me.hbox.TabIndex = 4
        Me.hbox.Text = "0"
        Me.hbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'w2box
        '
        Me.w2box.Location = New System.Drawing.Point(13, 205)
        Me.w2box.Name = "w2box"
        Me.w2box.Size = New System.Drawing.Size(100, 20)
        Me.w2box.TabIndex = 5
        Me.w2box.Text = "0"
        Me.w2box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.w2box.Visible = False
        '
        'w1box
        '
        Me.w1box.Location = New System.Drawing.Point(13, 179)
        Me.w1box.Name = "w1box"
        Me.w1box.Size = New System.Drawing.Size(100, 20)
        Me.w1box.TabIndex = 6
        Me.w1box.Text = "0"
        Me.w1box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'w3box
        '
        Me.w3box.Location = New System.Drawing.Point(13, 232)
        Me.w3box.Name = "w3box"
        Me.w3box.Size = New System.Drawing.Size(100, 20)
        Me.w3box.TabIndex = 7
        Me.w3box.Text = "0"
        Me.w3box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.w3box.Visible = False
        '
        'w4box
        '
        Me.w4box.Location = New System.Drawing.Point(13, 259)
        Me.w4box.Name = "w4box"
        Me.w4box.Size = New System.Drawing.Size(100, 20)
        Me.w4box.TabIndex = 8
        Me.w4box.Text = "0"
        Me.w4box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.w4box.Visible = False
        '
        'hlbl
        '
        Me.hlbl.AutoSize = True
        Me.hlbl.Location = New System.Drawing.Point(119, 141)
        Me.hlbl.Name = "hlbl"
        Me.hlbl.Size = New System.Drawing.Size(38, 13)
        Me.hlbl.TabIndex = 9
        Me.hlbl.Text = "Height"
        '
        'w1lbl
        '
        Me.w1lbl.AutoSize = True
        Me.w1lbl.Location = New System.Drawing.Point(119, 186)
        Me.w1lbl.Name = "w1lbl"
        Me.w1lbl.Size = New System.Drawing.Size(70, 13)
        Me.w1lbl.TabIndex = 10
        Me.w1lbl.Text = "Width 1 (W1)"
        '
        'w2lbl
        '
        Me.w2lbl.AutoSize = True
        Me.w2lbl.Location = New System.Drawing.Point(119, 212)
        Me.w2lbl.Name = "w2lbl"
        Me.w2lbl.Size = New System.Drawing.Size(70, 13)
        Me.w2lbl.TabIndex = 11
        Me.w2lbl.Text = "Width 2 (W2)"
        Me.w2lbl.Visible = False
        '
        'w3lbl
        '
        Me.w3lbl.AutoSize = True
        Me.w3lbl.Location = New System.Drawing.Point(120, 238)
        Me.w3lbl.Name = "w3lbl"
        Me.w3lbl.Size = New System.Drawing.Size(70, 13)
        Me.w3lbl.TabIndex = 12
        Me.w3lbl.Text = "Width 3 (W3)"
        Me.w3lbl.Visible = False
        '
        'w4lbl
        '
        Me.w4lbl.AutoSize = True
        Me.w4lbl.Location = New System.Drawing.Point(120, 265)
        Me.w4lbl.Name = "w4lbl"
        Me.w4lbl.Size = New System.Drawing.Size(70, 13)
        Me.w4lbl.TabIndex = 13
        Me.w4lbl.Text = "Width 4 (W4)"
        Me.w4lbl.Visible = False
        '
        'sidescombo
        '
        Me.sidescombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.sidescombo.FormattingEnabled = True
        Me.sidescombo.Location = New System.Drawing.Point(12, 93)
        Me.sidescombo.Name = "sidescombo"
        Me.sidescombo.Size = New System.Drawing.Size(275, 21)
        Me.sidescombo.TabIndex = 14
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(173, 315)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Go"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(334, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(491, 276)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(535, 315)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(150, 23)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'EFcombo
        '
        Me.EFcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EFcombo.FormattingEnabled = True
        Me.EFcombo.Location = New System.Drawing.Point(12, 39)
        Me.EFcombo.Name = "EFcombo"
        Me.EFcombo.Size = New System.Drawing.Size(275, 21)
        Me.EFcombo.TabIndex = 18
        Me.EFcombo.Visible = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(354, 315)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(150, 23)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "Clear"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Calcform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 365)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.EFcombo)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.sidescombo)
        Me.Controls.Add(Me.w4lbl)
        Me.Controls.Add(Me.w3lbl)
        Me.Controls.Add(Me.w2lbl)
        Me.Controls.Add(Me.w1lbl)
        Me.Controls.Add(Me.hlbl)
        Me.Controls.Add(Me.w4box)
        Me.Controls.Add(Me.w3box)
        Me.Controls.Add(Me.w1box)
        Me.Controls.Add(Me.w2box)
        Me.Controls.Add(Me.hbox)
        Me.Controls.Add(Me.thicknesscombo)
        Me.Controls.Add(Me.systemcombo)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "Calcform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NorthClad Panel Size Conformation"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolLbl As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents systemcombo As System.Windows.Forms.ComboBox
    Friend WithEvents thicknesscombo As System.Windows.Forms.ComboBox
    Friend WithEvents hbox As System.Windows.Forms.TextBox
    Friend WithEvents w2box As System.Windows.Forms.TextBox
    Friend WithEvents w1box As System.Windows.Forms.TextBox
    Friend WithEvents w3box As System.Windows.Forms.TextBox
    Friend WithEvents w4box As System.Windows.Forms.TextBox
    Friend WithEvents hlbl As System.Windows.Forms.Label
    Friend WithEvents w1lbl As System.Windows.Forms.Label
    Friend WithEvents w2lbl As System.Windows.Forms.Label
    Friend WithEvents w3lbl As System.Windows.Forms.Label
    Friend WithEvents w4lbl As System.Windows.Forms.Label
    Friend WithEvents sidescombo As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents EFcombo As System.Windows.Forms.ComboBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
