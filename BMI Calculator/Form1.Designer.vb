<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBMI
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
        Me.picBMI = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.comBoxGender = New System.Windows.Forms.ComboBox()
        Me.txtBoxFeet = New System.Windows.Forms.TextBox()
        Me.txtBoxInches = New System.Windows.Forms.TextBox()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBoxWeight = New System.Windows.Forms.TextBox()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.comBoxAge = New System.Windows.Forms.ComboBox()
        CType(Me.picBMI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picBMI
        '
        Me.picBMI.Image = Global.BMI_Calculator.My.Resources.Resources.BMIAppPic
        Me.picBMI.Location = New System.Drawing.Point(2, -1)
        Me.picBMI.Name = "picBMI"
        Me.picBMI.Size = New System.Drawing.Size(306, 450)
        Me.picBMI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBMI.TabIndex = 0
        Me.picBMI.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(455, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(258, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "BMI Calculator"
        '
        'comBoxGender
        '
        Me.comBoxGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comBoxGender.FormattingEnabled = True
        Me.comBoxGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.comBoxGender.Location = New System.Drawing.Point(571, 125)
        Me.comBoxGender.Name = "comBoxGender"
        Me.comBoxGender.Size = New System.Drawing.Size(106, 28)
        Me.comBoxGender.TabIndex = 3
        Me.comBoxGender.Text = "Gender"
        '
        'txtBoxFeet
        '
        Me.txtBoxFeet.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxFeet.Location = New System.Drawing.Point(571, 164)
        Me.txtBoxFeet.Name = "txtBoxFeet"
        Me.txtBoxFeet.Size = New System.Drawing.Size(48, 26)
        Me.txtBoxFeet.TabIndex = 4
        Me.txtBoxFeet.Text = "Feet"
        '
        'txtBoxInches
        '
        Me.txtBoxInches.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxInches.Location = New System.Drawing.Point(619, 164)
        Me.txtBoxInches.Name = "txtBoxInches"
        Me.txtBoxInches.Size = New System.Drawing.Size(58, 26)
        Me.txtBoxInches.TabIndex = 5
        Me.txtBoxInches.Text = "Inches"
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeight.Location = New System.Drawing.Point(475, 170)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(53, 16)
        Me.lblHeight.TabIndex = 6
        Me.lblHeight.Text = "Height"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(472, 214)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Weight"
        '
        'txtBoxWeight
        '
        Me.txtBoxWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxWeight.Location = New System.Drawing.Point(571, 208)
        Me.txtBoxWeight.Name = "txtBoxWeight"
        Me.txtBoxWeight.Size = New System.Drawing.Size(106, 26)
        Me.txtBoxWeight.TabIndex = 8
        Me.txtBoxWeight.Text = "Pounds"
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.Location = New System.Drawing.Point(433, 92)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(95, 16)
        Me.lblAge.TabIndex = 9
        Me.lblAge.Text = "Age (18-120)"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Location = New System.Drawing.Point(469, 131)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(59, 16)
        Me.lblGender.TabIndex = 10
        Me.lblGender.Text = "Gender"
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.OrangeRed
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCalculate.Location = New System.Drawing.Point(397, 312)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(140, 43)
        Me.btnCalculate.TabIndex = 11
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnClear.Location = New System.Drawing.Point(619, 312)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(140, 43)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblResult.Location = New System.Drawing.Point(393, 382)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(68, 24)
        Me.lblResult.TabIndex = 13
        Me.lblResult.Text = "Result"
        '
        'comBoxAge
        '
        Me.comBoxAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comBoxAge.FormattingEnabled = True
        Me.comBoxAge.Location = New System.Drawing.Point(571, 86)
        Me.comBoxAge.Name = "comBoxAge"
        Me.comBoxAge.Size = New System.Drawing.Size(106, 28)
        Me.comBoxAge.TabIndex = 14
        Me.comBoxAge.Text = "Age"
        '
        'frmBMI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(851, 449)
        Me.Controls.Add(Me.comBoxAge)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.txtBoxWeight)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblHeight)
        Me.Controls.Add(Me.txtBoxInches)
        Me.Controls.Add(Me.txtBoxFeet)
        Me.Controls.Add(Me.comBoxGender)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picBMI)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "frmBMI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "B.M.I. Calculator"
        CType(Me.picBMI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picBMI As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents comBoxGender As ComboBox
    Friend WithEvents txtBoxFeet As TextBox
    Friend WithEvents txtBoxInches As TextBox
    Friend WithEvents lblHeight As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBoxWeight As TextBox
    Friend WithEvents lblAge As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblResult As Label
    Friend WithEvents comBoxAge As ComboBox
End Class
