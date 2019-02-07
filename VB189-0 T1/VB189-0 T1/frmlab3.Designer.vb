<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lab3
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
        Me.txtDisgis = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblSky = New System.Windows.Forms.Label()
        Me.lblBlack = New System.Windows.Forms.Label()
        Me.lblWhite = New System.Windows.Forms.Label()
        Me.lblRed = New System.Windows.Forms.Label()
        Me.lblBrown = New System.Windows.Forms.Label()
        Me.lblBlue = New System.Windows.Forms.Label()
        Me.lblYellow = New System.Windows.Forms.Label()
        Me.lblGreen = New System.Windows.Forms.Label()
        Me.lblOrange = New System.Windows.Forms.Label()
        Me.lblViolet = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblFSky = New System.Windows.Forms.Label()
        Me.lblFWhite = New System.Windows.Forms.Label()
        Me.lblFBrown = New System.Windows.Forms.Label()
        Me.lblFYellow = New System.Windows.Forms.Label()
        Me.lblFOrange = New System.Windows.Forms.Label()
        Me.lblFBlack = New System.Windows.Forms.Label()
        Me.lblFViolet = New System.Windows.Forms.Label()
        Me.lblFGreen = New System.Windows.Forms.Label()
        Me.lblFBlue = New System.Windows.Forms.Label()
        Me.lblFRed = New System.Windows.Forms.Label()
        Me.cboSelect = New System.Windows.Forms.ComboBox()
        Me.btnLow = New System.Windows.Forms.Button()
        Me.btnHigh = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDisgis
        '
        Me.txtDisgis.AutoCompleteCustomSource.AddRange(New String() {"10", "14", "18", "22", "26", "30", "34", "38", "42", "46", "50", "54", "58", "62", "66", "70"})
        Me.txtDisgis.BackColor = System.Drawing.Color.Gray
        Me.txtDisgis.Font = New System.Drawing.Font("Angsana New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisgis.Location = New System.Drawing.Point(186, 106)
        Me.txtDisgis.Multiline = True
        Me.txtDisgis.Name = "txtDisgis"
        Me.txtDisgis.Size = New System.Drawing.Size(358, 85)
        Me.txtDisgis.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Angsana New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(416, 204)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 29)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "ขนาดฟอนด์"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblSky)
        Me.GroupBox2.Controls.Add(Me.lblBlack)
        Me.GroupBox2.Controls.Add(Me.lblWhite)
        Me.GroupBox2.Controls.Add(Me.lblRed)
        Me.GroupBox2.Controls.Add(Me.lblBrown)
        Me.GroupBox2.Controls.Add(Me.lblBlue)
        Me.GroupBox2.Controls.Add(Me.lblYellow)
        Me.GroupBox2.Controls.Add(Me.lblGreen)
        Me.GroupBox2.Controls.Add(Me.lblOrange)
        Me.GroupBox2.Controls.Add(Me.lblViolet)
        Me.GroupBox2.Location = New System.Drawing.Point(414, 265)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 80)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "BgColor"
        '
        'lblSky
        '
        Me.lblSky.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblSky.Location = New System.Drawing.Point(162, 47)
        Me.lblSky.Name = "lblSky"
        Me.lblSky.Size = New System.Drawing.Size(32, 25)
        Me.lblSky.TabIndex = 9
        '
        'lblBlack
        '
        Me.lblBlack.BackColor = System.Drawing.Color.Black
        Me.lblBlack.Location = New System.Drawing.Point(162, 16)
        Me.lblBlack.Name = "lblBlack"
        Me.lblBlack.Size = New System.Drawing.Size(32, 25)
        Me.lblBlack.TabIndex = 4
        '
        'lblWhite
        '
        Me.lblWhite.BackColor = System.Drawing.Color.White
        Me.lblWhite.Location = New System.Drawing.Point(124, 47)
        Me.lblWhite.Name = "lblWhite"
        Me.lblWhite.Size = New System.Drawing.Size(32, 25)
        Me.lblWhite.TabIndex = 8
        '
        'lblRed
        '
        Me.lblRed.BackColor = System.Drawing.Color.Red
        Me.lblRed.Location = New System.Drawing.Point(10, 16)
        Me.lblRed.Name = "lblRed"
        Me.lblRed.Size = New System.Drawing.Size(32, 25)
        Me.lblRed.TabIndex = 0
        '
        'lblBrown
        '
        Me.lblBrown.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblBrown.Location = New System.Drawing.Point(86, 47)
        Me.lblBrown.Name = "lblBrown"
        Me.lblBrown.Size = New System.Drawing.Size(32, 25)
        Me.lblBrown.TabIndex = 7
        '
        'lblBlue
        '
        Me.lblBlue.BackColor = System.Drawing.Color.Blue
        Me.lblBlue.Location = New System.Drawing.Point(48, 16)
        Me.lblBlue.Name = "lblBlue"
        Me.lblBlue.Size = New System.Drawing.Size(32, 25)
        Me.lblBlue.TabIndex = 1
        '
        'lblYellow
        '
        Me.lblYellow.BackColor = System.Drawing.Color.Yellow
        Me.lblYellow.Location = New System.Drawing.Point(48, 47)
        Me.lblYellow.Name = "lblYellow"
        Me.lblYellow.Size = New System.Drawing.Size(32, 25)
        Me.lblYellow.TabIndex = 6
        '
        'lblGreen
        '
        Me.lblGreen.BackColor = System.Drawing.Color.LimeGreen
        Me.lblGreen.Location = New System.Drawing.Point(86, 16)
        Me.lblGreen.Name = "lblGreen"
        Me.lblGreen.Size = New System.Drawing.Size(32, 25)
        Me.lblGreen.TabIndex = 2
        '
        'lblOrange
        '
        Me.lblOrange.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblOrange.Location = New System.Drawing.Point(10, 47)
        Me.lblOrange.Name = "lblOrange"
        Me.lblOrange.Size = New System.Drawing.Size(32, 25)
        Me.lblOrange.TabIndex = 5
        '
        'lblViolet
        '
        Me.lblViolet.BackColor = System.Drawing.Color.Fuchsia
        Me.lblViolet.Location = New System.Drawing.Point(124, 16)
        Me.lblViolet.Name = "lblViolet"
        Me.lblViolet.Size = New System.Drawing.Size(32, 25)
        Me.lblViolet.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblFSky)
        Me.GroupBox1.Controls.Add(Me.lblFWhite)
        Me.GroupBox1.Controls.Add(Me.lblFBrown)
        Me.GroupBox1.Controls.Add(Me.lblFYellow)
        Me.GroupBox1.Controls.Add(Me.lblFOrange)
        Me.GroupBox1.Controls.Add(Me.lblFBlack)
        Me.GroupBox1.Controls.Add(Me.lblFViolet)
        Me.GroupBox1.Controls.Add(Me.lblFGreen)
        Me.GroupBox1.Controls.Add(Me.lblFBlue)
        Me.GroupBox1.Controls.Add(Me.lblFRed)
        Me.GroupBox1.Location = New System.Drawing.Point(186, 259)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(208, 86)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ForColor"
        '
        'lblFSky
        '
        Me.lblFSky.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblFSky.Location = New System.Drawing.Point(158, 47)
        Me.lblFSky.Name = "lblFSky"
        Me.lblFSky.Size = New System.Drawing.Size(32, 25)
        Me.lblFSky.TabIndex = 9
        '
        'lblFWhite
        '
        Me.lblFWhite.BackColor = System.Drawing.Color.White
        Me.lblFWhite.Location = New System.Drawing.Point(120, 47)
        Me.lblFWhite.Name = "lblFWhite"
        Me.lblFWhite.Size = New System.Drawing.Size(32, 25)
        Me.lblFWhite.TabIndex = 8
        '
        'lblFBrown
        '
        Me.lblFBrown.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblFBrown.Location = New System.Drawing.Point(82, 47)
        Me.lblFBrown.Name = "lblFBrown"
        Me.lblFBrown.Size = New System.Drawing.Size(32, 25)
        Me.lblFBrown.TabIndex = 7
        '
        'lblFYellow
        '
        Me.lblFYellow.BackColor = System.Drawing.Color.Yellow
        Me.lblFYellow.Location = New System.Drawing.Point(44, 47)
        Me.lblFYellow.Name = "lblFYellow"
        Me.lblFYellow.Size = New System.Drawing.Size(32, 25)
        Me.lblFYellow.TabIndex = 6
        '
        'lblFOrange
        '
        Me.lblFOrange.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblFOrange.Location = New System.Drawing.Point(6, 47)
        Me.lblFOrange.Name = "lblFOrange"
        Me.lblFOrange.Size = New System.Drawing.Size(32, 25)
        Me.lblFOrange.TabIndex = 5
        '
        'lblFBlack
        '
        Me.lblFBlack.BackColor = System.Drawing.Color.Black
        Me.lblFBlack.Location = New System.Drawing.Point(158, 16)
        Me.lblFBlack.Name = "lblFBlack"
        Me.lblFBlack.Size = New System.Drawing.Size(32, 25)
        Me.lblFBlack.TabIndex = 4
        '
        'lblFViolet
        '
        Me.lblFViolet.BackColor = System.Drawing.Color.Fuchsia
        Me.lblFViolet.Location = New System.Drawing.Point(120, 16)
        Me.lblFViolet.Name = "lblFViolet"
        Me.lblFViolet.Size = New System.Drawing.Size(32, 25)
        Me.lblFViolet.TabIndex = 3
        '
        'lblFGreen
        '
        Me.lblFGreen.BackColor = System.Drawing.Color.LimeGreen
        Me.lblFGreen.Location = New System.Drawing.Point(82, 16)
        Me.lblFGreen.Name = "lblFGreen"
        Me.lblFGreen.Size = New System.Drawing.Size(32, 25)
        Me.lblFGreen.TabIndex = 2
        '
        'lblFBlue
        '
        Me.lblFBlue.BackColor = System.Drawing.Color.Blue
        Me.lblFBlue.Location = New System.Drawing.Point(44, 16)
        Me.lblFBlue.Name = "lblFBlue"
        Me.lblFBlue.Size = New System.Drawing.Size(32, 25)
        Me.lblFBlue.TabIndex = 1
        '
        'lblFRed
        '
        Me.lblFRed.BackColor = System.Drawing.Color.Red
        Me.lblFRed.Location = New System.Drawing.Point(6, 16)
        Me.lblFRed.Name = "lblFRed"
        Me.lblFRed.Size = New System.Drawing.Size(32, 25)
        Me.lblFRed.TabIndex = 0
        '
        'cboSelect
        '
        Me.cboSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSelect.FormattingEnabled = True
        Me.cboSelect.Items.AddRange(New Object() {"10", "14", "18", "22", "26", "30", "34", "38", "42", "46", "50", "54", "58", "62", "66", "70"})
        Me.cboSelect.Location = New System.Drawing.Point(503, 200)
        Me.cboSelect.Name = "cboSelect"
        Me.cboSelect.Size = New System.Drawing.Size(65, 33)
        Me.cboSelect.TabIndex = 12
        '
        'btnLow
        '
        Me.btnLow.Location = New System.Drawing.Point(543, 156)
        Me.btnLow.Name = "btnLow"
        Me.btnLow.Size = New System.Drawing.Size(47, 35)
        Me.btnLow.TabIndex = 11
        Me.btnLow.Text = "-"
        Me.btnLow.UseVisualStyleBackColor = True
        '
        'btnHigh
        '
        Me.btnHigh.Location = New System.Drawing.Point(543, 106)
        Me.btnHigh.Name = "btnHigh"
        Me.btnHigh.Size = New System.Drawing.Size(47, 44)
        Me.btnHigh.TabIndex = 10
        Me.btnHigh.Text = "+"
        Me.btnHigh.UseVisualStyleBackColor = True
        '
        'lab3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtDisgis)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cboSelect)
        Me.Controls.Add(Me.btnLow)
        Me.Controls.Add(Me.btnHigh)
        Me.Name = "lab3"
        Me.Text = "lab3"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDisgis As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblSky As Label
    Friend WithEvents lblBlack As Label
    Friend WithEvents lblWhite As Label
    Friend WithEvents lblRed As Label
    Friend WithEvents lblBrown As Label
    Friend WithEvents lblBlue As Label
    Friend WithEvents lblYellow As Label
    Friend WithEvents lblGreen As Label
    Friend WithEvents lblOrange As Label
    Friend WithEvents lblViolet As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblFSky As Label
    Friend WithEvents lblFWhite As Label
    Friend WithEvents lblFBrown As Label
    Friend WithEvents lblFYellow As Label
    Friend WithEvents lblFOrange As Label
    Friend WithEvents lblFBlack As Label
    Friend WithEvents lblFViolet As Label
    Friend WithEvents lblFGreen As Label
    Friend WithEvents lblFBlue As Label
    Friend WithEvents lblFRed As Label
    Friend WithEvents cboSelect As ComboBox
    Friend WithEvents btnLow As Button
    Friend WithEvents btnHigh As Button
End Class
