Public Class frm10
    Dim decSale(4, 2) As Decimal
    Dim saleName(4) As String
    Dim intIndex As Integer
    Dim decMaxSale, decSumSaleA, decSumSaleB, decSumSaleC, MAX As Decimal


    Private Sub Showdataz()
        Dim i As Integer

        For i = 0 To saleName.Length - 1
            dataG.Rows.Add()
            dataG.Item(0, i).Value = saleName(i)
            dataG.Item(1, i).Value = decSale(i, 0)
            dataG.Item(2, i).Value = decSale(i, 1)
            dataG.Item(3, i).Value = decSale(i, 2)

        Next

    End Sub
    Private Sub ShowData()

        Dim i, total As Decimal
        decSumSaleA = 0
        decSumSaleB = 0
        decSumSaleC = 0
        decMaxSale = 0
        lstData.Items.Clear()

        For i = 0 To saleName.Length - 1
            lstData.Items.Add(saleName(i) & "," & decSale(i, 0) & "," & decSale(i, 1) & "," & decSale(i, 2))
            decSumSaleA += decSale(i, 0)
            decSumSaleB += decSale(i, 1)
            decSumSaleC += decSale(i, 2)

            total = decSale(i, 0) + decSale(i, 1) + decSale(i, 2)

            If decMaxSale < total Then
                decMaxSale = total
                intIndex = i
            End If

        Next

        lblSumA.Text = decSumSaleA
        lblSumB.Text = decSumSaleB
        lblSumC.Text = decSumSaleC
        lblMaxSaleName.Text = saleName(intIndex)


        lblMaxSaleAmount.Text = decMaxSale

    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click


        If IsNumeric(txtSaleName.Text) Then
            MessageBox.Show("ข้อมูลไม่สมบูรณ์")
            txtSaleName.Clear()
            txtSaleName.Focus()
            Exit Sub
        ElseIf Not IsNumeric(txtSaleA.Text) Then
            MessageBox.Show("ป้อนค่าที่เป็นตัวเลข")
            txtSaleA.Clear()
            txtSaleA.Focus()
            Exit Sub
        ElseIf Not IsNumeric(txtSaleB.Text) Then
            MessageBox.Show("ป้อนค่าที่เป็นตัวเลข")
            txtSaleB.Clear()
            txtSaleB.Focus()
            Exit Sub
        ElseIf Not IsNumeric(txtSaleC.Text) Then
            MessageBox.Show("ป้อนค่าที่เป็นตัวเลข")
            txtSaleC.Clear()
            txtSaleC.Focus()
        Else
            saleName(cboIndex.SelectedIndex) = txtSaleName.Text
            decSale(cboIndex.SelectedIndex, 0) = Val(txtSaleA.Text)
            decSale(cboIndex.SelectedIndex, 1) = Val(txtSaleB.Text)
            decSale(cboIndex.SelectedIndex, 2) = Val(txtSaleC.Text)

            Call ShowData()
            Call Showdataz()

        End If
    End Sub

    Private Sub frm10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 0 To 4
            cboIndex.Items.Add(i + 1)
        Next




    End Sub


End Class