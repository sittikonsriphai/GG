Public Class frmlab1
    Private Sub btnCal_Click(sender As Object, e As EventArgs) Handles btnCal.Click
        'ค่าจ้าง  = ชั่วโมงการทำงาน * อัตราค่าจ้างต่อชั่วโมง
        'ชั่วโมงการทำงาน = txtHour.Text
        'อัตราค่าจ้างต่อชั่วโมง = txtWage.Text
        'ค่าจ้าง =  lblPay.Text 

        lblTotal.Text = Val(txtHour.Text) * Val(txtPayRate.Text)

        lblTax.Text = Val(lblTotal.Text) * 3 / 100



    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim hours As Integer
        Dim payrate, total, tax As Double

        hours = Val(txtHour.Text)
        payrate = Val(txtPayRate.Text)

        total = hours * payrate
        tax = total * 0.03

        lblTotal.Text = total
        lblTax.Text = tax

    End Sub
End Class
