<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mid9
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
        Me.Rd1 = New System.Windows.Forms.RadioButton()
        Me.Rd2 = New System.Windows.Forms.RadioButton()
        Me.Rd3 = New System.Windows.Forms.RadioButton()
        Me.Rd4 = New System.Windows.Forms.RadioButton()
        Me.Chkgohome = New System.Windows.Forms.CheckBox()
        Me.lblTotal2 = New System.Windows.Forms.Label()
        Me.GB1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTotal1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblTotal3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GB1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Red
        Me.Label1.Font = New System.Drawing.Font("TH SarabunPSK", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(263, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "โปรแกรมคำนวณค่าเดินทาง"
        '
        'Rd1
        '
        Me.Rd1.AutoSize = True
        Me.Rd1.Location = New System.Drawing.Point(20, 31)
        Me.Rd1.Name = "Rd1"
        Me.Rd1.Size = New System.Drawing.Size(201, 32)
        Me.Rd1.TabIndex = 5
        Me.Rd1.TabStop = True
        Me.Rd1.Text = "รถจักรยานยนต์ กม.ละ 2 บาท"
        Me.Rd1.UseVisualStyleBackColor = True
        '
        'Rd2
        '
        Me.Rd2.AutoSize = True
        Me.Rd2.Location = New System.Drawing.Point(20, 66)
        Me.Rd2.Name = "Rd2"
        Me.Rd2.Size = New System.Drawing.Size(167, 32)
        Me.Rd2.TabIndex = 6
        Me.Rd2.TabStop = True
        Me.Rd2.Text = "รถกระบะ กม.ละ 4 บาท"
        Me.Rd2.UseVisualStyleBackColor = True
        '
        'Rd3
        '
        Me.Rd3.AutoSize = True
        Me.Rd3.Location = New System.Drawing.Point(20, 107)
        Me.Rd3.Name = "Rd3"
        Me.Rd3.Size = New System.Drawing.Size(148, 32)
        Me.Rd3.TabIndex = 7
        Me.Rd3.TabStop = True
        Me.Rd3.Text = "รถเก๋ง กม.ละ 6 บาท"
        Me.Rd3.UseVisualStyleBackColor = True
        '
        'Rd4
        '
        Me.Rd4.AutoSize = True
        Me.Rd4.Location = New System.Drawing.Point(20, 141)
        Me.Rd4.Name = "Rd4"
        Me.Rd4.Size = New System.Drawing.Size(156, 32)
        Me.Rd4.TabIndex = 8
        Me.Rd4.TabStop = True
        Me.Rd4.Text = "รถSUV กม.ละ 8 บาท"
        Me.Rd4.UseVisualStyleBackColor = True
        '
        'Chkgohome
        '
        Me.Chkgohome.AutoSize = True
        Me.Chkgohome.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chkgohome.Location = New System.Drawing.Point(311, 23)
        Me.Chkgohome.Name = "Chkgohome"
        Me.Chkgohome.Size = New System.Drawing.Size(67, 30)
        Me.Chkgohome.TabIndex = 9
        Me.Chkgohome.Text = "ไปกลับ"
        Me.Chkgohome.UseVisualStyleBackColor = True
        '
        'lblTotal2
        '
        Me.lblTotal2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblTotal2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal2.Location = New System.Drawing.Point(404, 178)
        Me.lblTotal2.Name = "lblTotal2"
        Me.lblTotal2.Size = New System.Drawing.Size(100, 23)
        Me.lblTotal2.TabIndex = 10
        Me.lblTotal2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GB1
        '
        Me.GB1.BackColor = System.Drawing.Color.Yellow
        Me.GB1.Controls.Add(Me.Rd4)
        Me.GB1.Controls.Add(Me.Rd3)
        Me.GB1.Controls.Add(Me.Rd2)
        Me.GB1.Controls.Add(Me.Rd1)
        Me.GB1.Font = New System.Drawing.Font("TH SarabunPSK", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB1.Location = New System.Drawing.Point(36, 23)
        Me.GB1.Name = "GB1"
        Me.GB1.Size = New System.Drawing.Size(253, 230)
        Me.GB1.TabIndex = 12
        Me.GB1.TabStop = False
        Me.GB1.Text = "ประเภทรถ"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(317, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 23)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "ระยะทาง"
        '
        'txt1
        '
        Me.txt1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt1.Location = New System.Drawing.Point(406, 70)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(81, 29)
        Me.txt1.TabIndex = 14
        Me.txt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(318, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 23)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "รวมค่าเดินทาง"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("TH SarabunPSK", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Coral
        Me.Button1.Location = New System.Drawing.Point(410, 218)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 32)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "คำนวณ"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(317, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 23)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "ค่าเเรกขึ้น"
        '
        'lblTotal1
        '
        Me.lblTotal1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTotal1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal1.Location = New System.Drawing.Point(403, 108)
        Me.lblTotal1.Name = "lblTotal1"
        Me.lblTotal1.Size = New System.Drawing.Size(100, 23)
        Me.lblTotal1.TabIndex = 16
        Me.lblTotal1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(486, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 23)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Km"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(509, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 23)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "บาท"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(509, 181)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 23)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "บาท"
        '
        'lblTotal3
        '
        Me.lblTotal3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTotal3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal3.Location = New System.Drawing.Point(403, 142)
        Me.lblTotal3.Name = "lblTotal3"
        Me.lblTotal3.Size = New System.Drawing.Size(100, 23)
        Me.lblTotal3.TabIndex = 17
        Me.lblTotal3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(508, 139)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 23)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "บาท"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(317, 145)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 23)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "ค่ารอคอย"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Lime
        Me.Panel1.Controls.Add(Me.lblTotal3)
        Me.Panel1.Controls.Add(Me.lblTotal1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.txt1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.GB1)
        Me.Panel1.Controls.Add(Me.lblTotal2)
        Me.Panel1.Controls.Add(Me.Chkgohome)
        Me.Panel1.Location = New System.Drawing.Point(45, 92)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(601, 320)
        Me.Panel1.TabIndex = 18
        '
        'Mid9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(719, 461)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Mid9"
        Me.Text = "Mid9"
        Me.GB1.ResumeLayout(False)
        Me.GB1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Rd1 As RadioButton
    Friend WithEvents Rd2 As RadioButton
    Friend WithEvents Rd3 As RadioButton
    Friend WithEvents Rd4 As RadioButton
    Friend WithEvents Chkgohome As CheckBox
    Friend WithEvents lblTotal2 As Label
    Friend WithEvents GB1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTotal1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblTotal3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel1 As Panel
End Class
