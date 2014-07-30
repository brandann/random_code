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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ClearBtn = New System.Windows.Forms.Button()
        Me.Calcbtn = New System.Windows.Forms.Button()
        Me.Exitbtn = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.InchBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.FeetBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.risebox = New System.Windows.Forms.TextBox()
        Me.Archresult = New System.Windows.Forms.Label()
        Me.TotalLengthLbl = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LblSlope = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ClearBtn
        '
        Me.ClearBtn.Location = New System.Drawing.Point(12, 227)
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.Size = New System.Drawing.Size(75, 23)
        Me.ClearBtn.TabIndex = 20
        Me.ClearBtn.Text = "Clear"
        Me.ClearBtn.UseVisualStyleBackColor = True
        '
        'Calcbtn
        '
        Me.Calcbtn.Location = New System.Drawing.Point(12, 198)
        Me.Calcbtn.Name = "Calcbtn"
        Me.Calcbtn.Size = New System.Drawing.Size(75, 23)
        Me.Calcbtn.TabIndex = 19
        Me.Calcbtn.Text = "&Calculate"
        Me.Calcbtn.UseVisualStyleBackColor = True
        '
        'Exitbtn
        '
        Me.Exitbtn.Location = New System.Drawing.Point(197, 227)
        Me.Exitbtn.Name = "Exitbtn"
        Me.Exitbtn.Size = New System.Drawing.Size(75, 23)
        Me.Exitbtn.TabIndex = 18
        Me.Exitbtn.Text = "&Exit"
        Me.Exitbtn.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(69, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 13)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Inch"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Feet"
        '
        'InchBox
        '
        Me.InchBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InchBox.Location = New System.Drawing.Point(61, 38)
        Me.InchBox.Name = "InchBox"
        Me.InchBox.Size = New System.Drawing.Size(44, 20)
        Me.InchBox.TabIndex = 27
        Me.InchBox.Text = "0"
        Me.InchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(40, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(12, 13)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "/"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "12"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(111, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Run"
        '
        'FeetBox
        '
        Me.FeetBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FeetBox.Location = New System.Drawing.Point(11, 38)
        Me.FeetBox.Name = "FeetBox"
        Me.FeetBox.Size = New System.Drawing.Size(44, 20)
        Me.FeetBox.TabIndex = 23
        Me.FeetBox.Text = "0"
        Me.FeetBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(111, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Slope (Rise/Run)"
        '
        'risebox
        '
        Me.risebox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.risebox.Location = New System.Drawing.Point(12, 12)
        Me.risebox.Name = "risebox"
        Me.risebox.Size = New System.Drawing.Size(30, 20)
        Me.risebox.TabIndex = 21
        Me.risebox.Text = "1"
        Me.risebox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Archresult
        '
        Me.Archresult.AutoSize = True
        Me.Archresult.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Archresult.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Archresult.Location = New System.Drawing.Point(176, 207)
        Me.Archresult.Name = "Archresult"
        Me.Archresult.Size = New System.Drawing.Size(45, 13)
        Me.Archresult.TabIndex = 33
        Me.Archresult.Text = "Label9"
        Me.Archresult.Visible = False
        '
        'TotalLengthLbl
        '
        Me.TotalLengthLbl.AutoSize = True
        Me.TotalLengthLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalLengthLbl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TotalLengthLbl.Location = New System.Drawing.Point(176, 190)
        Me.TotalLengthLbl.Name = "TotalLengthLbl"
        Me.TotalLengthLbl.Size = New System.Drawing.Size(77, 13)
        Me.TotalLengthLbl.TabIndex = 32
        Me.TotalLengthLbl.Text = "Roof Length"
        Me.TotalLengthLbl.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(36, 79)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(218, 103)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'LblSlope
        '
        Me.LblSlope.AutoSize = True
        Me.LblSlope.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSlope.Location = New System.Drawing.Point(98, 192)
        Me.LblSlope.Name = "LblSlope"
        Me.LblSlope.Size = New System.Drawing.Size(80, 24)
        Me.LblSlope.TabIndex = 35
        Me.LblSlope.Text = "Length:"
        Me.LblSlope.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(194, 249)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 12)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "By: Brandan Haertel"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.LblSlope)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Archresult)
        Me.Controls.Add(Me.TotalLengthLbl)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.InchBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.FeetBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.risebox)
        Me.Controls.Add(Me.ClearBtn)
        Me.Controls.Add(Me.Calcbtn)
        Me.Controls.Add(Me.Exitbtn)
        Me.Name = "Form1"
        Me.Text = "Rise Run Calculator"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ClearBtn As System.Windows.Forms.Button
    Friend WithEvents Calcbtn As System.Windows.Forms.Button
    Friend WithEvents Exitbtn As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents InchBox As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents FeetBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents risebox As System.Windows.Forms.TextBox
    Friend WithEvents Archresult As System.Windows.Forms.Label
    Friend WithEvents TotalLengthLbl As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LblSlope As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label

End Class
