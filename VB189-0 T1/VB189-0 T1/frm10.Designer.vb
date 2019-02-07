<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm10
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lstData = New System.Windows.Forms.ListBox()
        Me.txtSaleC = New System.Windows.Forms.TextBox()
        Me.txtSaleB = New System.Windows.Forms.TextBox()
        Me.txtSaleA = New System.Windows.Forms.TextBox()
        Me.txtSaleName = New System.Windows.Forms.TextBox()
        Me.cboIndex = New System.Windows.Forms.ComboBox()
        Me.lblMaxSaleName = New System.Windows.Forms.Label()
        Me.lblMaxSaleAmount = New System.Windows.Forms.Label()
        Me.lblSumC = New System.Windows.Forms.Label()
        Me.lblSumB = New System.Windows.Forms.Label()
        Me.lblSumA = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.โปรแกรมคำนวณยอดขายจากอาร์เรย์ = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.dataG = New System.Windows.Forms.DataGridView()
        Me.ผลรวม = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dataG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstData
        '
        Me.lstData.BackColor = System.Drawing.Color.White
        Me.lstData.FormattingEnabled = True
        Me.lstData.Location = New System.Drawing.Point(47, 74)
        Me.lstData.Margin = New System.Windows.Forms.Padding(2)
        Me.lstData.Name = "lstData"
        Me.lstData.Size = New System.Drawing.Size(152, 134)
        Me.lstData.TabIndex = 28
        '
        'txtSaleC
        '
        Me.txtSaleC.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtSaleC.Location = New System.Drawing.Point(293, 314)
        Me.txtSaleC.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSaleC.Name = "txtSaleC"
        Me.txtSaleC.Size = New System.Drawing.Size(58, 20)
        Me.txtSaleC.TabIndex = 27
        '
        'txtSaleB
        '
        Me.txtSaleB.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtSaleB.Location = New System.Drawing.Point(232, 314)
        Me.txtSaleB.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSaleB.Name = "txtSaleB"
        Me.txtSaleB.Size = New System.Drawing.Size(58, 20)
        Me.txtSaleB.TabIndex = 26
        '
        'txtSaleA
        '
        Me.txtSaleA.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtSaleA.Location = New System.Drawing.Point(174, 314)
        Me.txtSaleA.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSaleA.Name = "txtSaleA"
        Me.txtSaleA.Size = New System.Drawing.Size(54, 20)
        Me.txtSaleA.TabIndex = 25
        '
        'txtSaleName
        '
        Me.txtSaleName.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtSaleName.Location = New System.Drawing.Point(43, 315)
        Me.txtSaleName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSaleName.Name = "txtSaleName"
        Me.txtSaleName.Size = New System.Drawing.Size(109, 20)
        Me.txtSaleName.TabIndex = 24
        '
        'cboIndex
        '
        Me.cboIndex.BackColor = System.Drawing.SystemColors.Control
        Me.cboIndex.FormattingEnabled = True
        Me.cboIndex.Location = New System.Drawing.Point(44, 270)
        Me.cboIndex.Margin = New System.Windows.Forms.Padding(2)
        Me.cboIndex.Name = "cboIndex"
        Me.cboIndex.Size = New System.Drawing.Size(111, 21)
        Me.cboIndex.TabIndex = 23
        '
        'lblMaxSaleName
        '
        Me.lblMaxSaleName.BackColor = System.Drawing.Color.White
        Me.lblMaxSaleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMaxSaleName.Location = New System.Drawing.Point(353, 197)
        Me.lblMaxSaleName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMaxSaleName.Name = "lblMaxSaleName"
        Me.lblMaxSaleName.Size = New System.Drawing.Size(53, 22)
        Me.lblMaxSaleName.TabIndex = 21
        '
        'lblMaxSaleAmount
        '
        Me.lblMaxSaleAmount.BackColor = System.Drawing.Color.Lime
        Me.lblMaxSaleAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMaxSaleAmount.Location = New System.Drawing.Point(353, 236)
        Me.lblMaxSaleAmount.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMaxSaleAmount.Name = "lblMaxSaleAmount"
        Me.lblMaxSaleAmount.Size = New System.Drawing.Size(53, 22)
        Me.lblMaxSaleAmount.TabIndex = 20
        '
        'lblSumC
        '
        Me.lblSumC.BackColor = System.Drawing.Color.Lime
        Me.lblSumC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSumC.Location = New System.Drawing.Point(353, 153)
        Me.lblSumC.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSumC.Name = "lblSumC"
        Me.lblSumC.Size = New System.Drawing.Size(53, 25)
        Me.lblSumC.TabIndex = 19
        '
        'lblSumB
        '
        Me.lblSumB.BackColor = System.Drawing.Color.White
        Me.lblSumB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSumB.Location = New System.Drawing.Point(353, 112)
        Me.lblSumB.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSumB.Name = "lblSumB"
        Me.lblSumB.Size = New System.Drawing.Size(53, 25)
        Me.lblSumB.TabIndex = 18
        '
        'lblSumA
        '
        Me.lblSumA.BackColor = System.Drawing.Color.Lime
        Me.lblSumA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSumA.Location = New System.Drawing.Point(353, 70)
        Me.lblSumA.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSumA.Name = "lblSumA"
        Me.lblSumA.Size = New System.Drawing.Size(53, 22)
        Me.lblSumA.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(42, 254)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "พนังงานคนที่"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(301, 298)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 13)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "ยอดขาย C"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(242, 298)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "ยอดขาย B"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(183, 298)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "ยอดขาย A"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 299)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "ชื่อพนังงานขาย"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("TH SarabunPSK", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(242, 236)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 22)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "เป็นเงิน"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("TH SarabunPSK", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(242, 197)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 22)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "ผู้ที่ทำยอดขายสุดสูง"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("TH SarabunPSK", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(238, 115)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 22)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "รวมยอดขายสินค้าB"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("TH SarabunPSK", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(238, 156)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 22)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "รวมยอดขายสินค้า C"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(63, 56)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "รายการข้อมูล"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("TH SarabunPSK", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(238, 70)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 22)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "รวมยอดขายสินค้าA"
        '
        'โปรแกรมคำนวณยอดขายจากอาร์เรย์
        '
        Me.โปรแกรมคำนวณยอดขายจากอาร์เรย์.AutoSize = True
        Me.โปรแกรมคำนวณยอดขายจากอาร์เรย์.Font = New System.Drawing.Font("TH SarabunPSK", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.โปรแกรมคำนวณยอดขายจากอาร์เรย์.ForeColor = System.Drawing.Color.Black
        Me.โปรแกรมคำนวณยอดขายจากอาร์เรย์.Location = New System.Drawing.Point(115, 9)
        Me.โปรแกรมคำนวณยอดขายจากอาร์เรย์.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.โปรแกรมคำนวณยอดขายจากอาร์เรย์.Name = "โปรแกรมคำนวณยอดขายจากอาร์เรย์"
        Me.โปรแกรมคำนวณยอดขายจากอาร์เรย์.Size = New System.Drawing.Size(308, 39)
        Me.โปรแกรมคำนวณยอดขายจากอาร์เรย์.TabIndex = 22
        Me.โปรแกรมคำนวณยอดขายจากอาร์เรย์.Text = "โปรแกรมคำนวณยอดขายจากอาร์เรย์"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Red
        Me.btnAdd.Location = New System.Drawing.Point(374, 298)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(59, 39)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'dataG
        '
        Me.dataG.AllowUserToAddRows = False
        Me.dataG.AllowUserToDeleteRows = False
        Me.dataG.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Red
        Me.dataG.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dataG.CausesValidation = False
        Me.dataG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ผลรวม, Me.ColumnA, Me.ColumnB, Me.ColumnC, Me.Column1, Me.Column2})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataG.DefaultCellStyle = DataGridViewCellStyle2
        Me.dataG.Location = New System.Drawing.Point(455, 70)
        Me.dataG.Name = "dataG"
        Me.dataG.RowHeadersVisible = False
        Me.dataG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataG.Size = New System.Drawing.Size(455, 138)
        Me.dataG.TabIndex = 29
        '
        'ผลรวม
        '
        Me.ผลรวม.HeaderText = "ชื่อพนักงาน"
        Me.ผลรวม.Name = "ผลรวม"
        Me.ผลรวม.Width = 70
        '
        'ColumnA
        '
        Me.ColumnA.HeaderText = "สินค้าA"
        Me.ColumnA.Name = "ColumnA"
        Me.ColumnA.Width = 70
        '
        'ColumnB
        '
        Me.ColumnB.HeaderText = "สินค้าB"
        Me.ColumnB.Name = "ColumnB"
        Me.ColumnB.Width = 70
        '
        'ColumnC
        '
        Me.ColumnC.HeaderText = "สินค้าC"
        Me.ColumnC.Name = "ColumnC"
        Me.ColumnC.Width = 70
        '
        'Column1
        '
        Me.Column1.HeaderText = "เป็นเงิน"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 70
        '
        'Column2
        '
        Me.Column2.HeaderText = "ผู้ที่ทำยอดขายสูงสุด"
        Me.Column2.Name = "Column2"
        '
        'frm10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1056, 560)
        Me.Controls.Add(Me.dataG)
        Me.Controls.Add(Me.lstData)
        Me.Controls.Add(Me.txtSaleC)
        Me.Controls.Add(Me.txtSaleB)
        Me.Controls.Add(Me.txtSaleA)
        Me.Controls.Add(Me.txtSaleName)
        Me.Controls.Add(Me.cboIndex)
        Me.Controls.Add(Me.lblMaxSaleName)
        Me.Controls.Add(Me.lblMaxSaleAmount)
        Me.Controls.Add(Me.lblSumC)
        Me.Controls.Add(Me.lblSumB)
        Me.Controls.Add(Me.lblSumA)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.โปรแกรมคำนวณยอดขายจากอาร์เรย์)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "frm10"
        Me.Text = "frm9"
        CType(Me.dataG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstData As ListBox
    Friend WithEvents txtSaleC As TextBox
    Friend WithEvents txtSaleB As TextBox
    Friend WithEvents txtSaleA As TextBox
    Friend WithEvents txtSaleName As TextBox
    Friend WithEvents cboIndex As ComboBox
    Friend WithEvents lblMaxSaleName As Label
    Friend WithEvents lblMaxSaleAmount As Label
    Friend WithEvents lblSumC As Label
    Friend WithEvents lblSumB As Label
    Friend WithEvents lblSumA As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents โปรแกรมคำนวณยอดขายจากอาร์เรย์ As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents dataG As DataGridView
    Friend WithEvents ผลรวม As DataGridViewTextBoxColumn
    Friend WithEvents ColumnA As DataGridViewTextBoxColumn
    Friend WithEvents ColumnB As DataGridViewTextBoxColumn
    Friend WithEvents ColumnC As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
End Class
