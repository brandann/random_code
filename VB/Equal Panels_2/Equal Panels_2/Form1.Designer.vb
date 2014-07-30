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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.feetbox = New System.Windows.Forms.TextBox()
        Me.inchbox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.qtybox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.jtbox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lapbox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.resultbox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.calcmod = New System.Windows.Forms.Button()
        Me.calclap = New System.Windows.Forms.Button()
        Me.exitbtn = New System.Windows.Forms.Button()
        Me.helpbtn = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.resetbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Feet:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'feetbox
        '
        Me.feetbox.Location = New System.Drawing.Point(57, 6)
        Me.feetbox.Name = "feetbox"
        Me.feetbox.Size = New System.Drawing.Size(100, 20)
        Me.feetbox.TabIndex = 1
        Me.feetbox.Text = "0"
        Me.feetbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'inchbox
        '
        Me.inchbox.Location = New System.Drawing.Point(57, 32)
        Me.inchbox.Name = "inchbox"
        Me.inchbox.Size = New System.Drawing.Size(100, 20)
        Me.inchbox.TabIndex = 3
        Me.inchbox.Text = "0"
        Me.inchbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Inch:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'qtybox
        '
        Me.qtybox.Location = New System.Drawing.Point(94, 58)
        Me.qtybox.Name = "qtybox"
        Me.qtybox.Size = New System.Drawing.Size(63, 20)
        Me.qtybox.TabIndex = 5
        Me.qtybox.Text = "0"
        Me.qtybox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Panel Quanity:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'jtbox
        '
        Me.jtbox.Location = New System.Drawing.Point(57, 84)
        Me.jtbox.Name = "jtbox"
        Me.jtbox.Size = New System.Drawing.Size(64, 20)
        Me.jtbox.TabIndex = 7
        Me.jtbox.Text = "0"
        Me.jtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Joint:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lapbox
        '
        Me.lapbox.Location = New System.Drawing.Point(172, 84)
        Me.lapbox.Name = "lapbox"
        Me.lapbox.Size = New System.Drawing.Size(100, 20)
        Me.lapbox.TabIndex = 9
        Me.lapbox.Text = "0"
        Me.lapbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(138, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Lap:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'resultbox
        '
        Me.resultbox.Location = New System.Drawing.Point(129, 119)
        Me.resultbox.Name = "resultbox"
        Me.resultbox.Size = New System.Drawing.Size(143, 20)
        Me.resultbox.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Typical Panel Length:"
        '
        'calcmod
        '
        Me.calcmod.Location = New System.Drawing.Point(16, 154)
        Me.calcmod.Name = "calcmod"
        Me.calcmod.Size = New System.Drawing.Size(177, 23)
        Me.calcmod.TabIndex = 12
        Me.calcmod.Text = "Calculate Equal Modual Panels >"
        Me.calcmod.UseVisualStyleBackColor = True
        '
        'calclap
        '
        Me.calclap.Location = New System.Drawing.Point(16, 184)
        Me.calclap.Name = "calclap"
        Me.calclap.Size = New System.Drawing.Size(177, 23)
        Me.calclap.TabIndex = 13
        Me.calclap.Text = "Calculate Equal Lapped Panels >"
        Me.calclap.UseVisualStyleBackColor = True
        '
        'exitbtn
        '
        Me.exitbtn.Location = New System.Drawing.Point(202, 246)
        Me.exitbtn.Name = "exitbtn"
        Me.exitbtn.Size = New System.Drawing.Size(70, 23)
        Me.exitbtn.TabIndex = 14
        Me.exitbtn.Text = "Exit"
        Me.exitbtn.UseVisualStyleBackColor = True
        '
        'helpbtn
        '
        Me.helpbtn.Location = New System.Drawing.Point(232, 13)
        Me.helpbtn.Name = "helpbtn"
        Me.helpbtn.Size = New System.Drawing.Size(40, 23)
        Me.helpbtn.TabIndex = 15
        Me.helpbtn.Text = "Help"
        Me.helpbtn.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 243)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(184, 26)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Brandan Haertel" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Brandan@Northshoresheetmetal.com"
        '
        'resetbtn
        '
        Me.resetbtn.Location = New System.Drawing.Point(202, 217)
        Me.resetbtn.Name = "resetbtn"
        Me.resetbtn.Size = New System.Drawing.Size(70, 23)
        Me.resetbtn.TabIndex = 17
        Me.resetbtn.Text = "Reset"
        Me.resetbtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 281)
        Me.Controls.Add(Me.resetbtn)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.helpbtn)
        Me.Controls.Add(Me.exitbtn)
        Me.Controls.Add(Me.calclap)
        Me.Controls.Add(Me.calcmod)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.resultbox)
        Me.Controls.Add(Me.lapbox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.jtbox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.qtybox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.inchbox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.feetbox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Opacity = 0.97R
        Me.Text = "Equal Panels"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents feetbox As System.Windows.Forms.TextBox
    Friend WithEvents inchbox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents qtybox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents jtbox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lapbox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents resultbox As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents calcmod As System.Windows.Forms.Button
    Friend WithEvents calclap As System.Windows.Forms.Button
    Friend WithEvents exitbtn As System.Windows.Forms.Button
    Friend WithEvents helpbtn As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents resetbtn As System.Windows.Forms.Button

End Class
