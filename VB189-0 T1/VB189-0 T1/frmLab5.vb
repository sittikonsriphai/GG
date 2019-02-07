Public Class frmLab5
    Dim total, total1, paid, discount, discount2, credit, d As Double
    Private Sub btnCalculat_Click(sender As Object, e As EventArgs) Handles btnCalculat.Click



        If txtProduct.Text = "" Or txtPrice.Text = "" Or txtUnit.Text = "" Then
            MessageBox.Show("ป้อนข้อมูลไม่สมบูรณ์")



        End If
        If radMember.Checked = True And radPaid.Checked = True Then
            If lblTotal.Text < 1000 Then
                discount = 0
                lblDiscount.Text = "0"

            ElseIf lblTotal.Text < 5000 Then
                discount = lblTotal.Text * 0.05
                total1 = lblTotal.Text - discount
                lblDiscount.Text = discount
                lblPaid.Text = total1


            ElseIf lblTotal.Text < 10000 Then
                discount = lblTotal.Text * 0.1
                total1 = lblTotal.Text - discount
                lblDiscount.Text = discount
                lblPaid.Text = total1
            Else
                discount = lblTotal.Text * 0.15
                total1 = lblTotal.Text - discount
                lblDiscount.Text = discount
                lblPaid.Text = total1
            End If
        End If
        'สมาชิก เคดิต 
        If radMember.Checked = True And radCredit.Checked = True Then
            lblPaid.Text = lblTotal.Text
            lblCredit.Text = lblTotal.Text
        End If

        'ลูกค้าทั่วไป
        If radOther.Checked = True Then
            lblPaid.Text = lblTotal.Text
        End If


    End Sub

    Private Sub radMember_CheckedChanged(sender As Object, e As EventArgs) Handles radMember.CheckedChanged
        If radMember.Checked = True Then
            gpbPrice.Enabled = True
        End If

        lblCredit.Text = ""
        lblDiscount.Text = ""
        lblPaid.Text = ""
    End Sub

    Private Sub radOther_CheckedChanged(sender As Object, e As EventArgs) Handles radOther.CheckedChanged
        If radOther.Checked = True Then
            gpbPrice.Enabled = False
            radPaid.Select()
        End If


        lblCredit.Text = ""
        lblDiscount.Text = ""
        lblPaid.Text = ""
    End Sub

    Private Sub radPaid_CheckedChanged(sender As Object, e As EventArgs) Handles radPaid.CheckedChanged
        lblCredit.Text = ""
        lblDiscount.Text = ""
        lblPaid.Text = ""
    End Sub

    Private Sub radCredit_CheckedChanged(sender As Object, e As EventArgs) Handles radCredit.CheckedChanged
        lblCredit.Text = ""
        lblDiscount.Text = ""
        lblPaid.Text = ""
    End Sub

    Private Sub txtProduct_TextChanged(sender As Object, e As EventArgs) Handles txtProduct.TextChanged

    End Sub

    Private Sub txtPrice_TextChanged(sender As Object, e As EventArgs) Handles txtPrice.TextChanged
        lblTotal.Text = txtPrice.Text

    End Sub



    Private Sub frmLab5_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub txtUnit_TextChanged(sender As Object, e As EventArgs) Handles txtUnit.TextChanged
        Dim P, U As Double
        P = txtPrice.Text
        U = txtUnit.Text
        lblTotal.Text = Val(txtPrice.Text * txtUnit.Text)

    End Sub
End Class