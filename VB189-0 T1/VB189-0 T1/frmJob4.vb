Public Class VB_L4
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If radShortDate.Checked = True Then
            lblDate.Text = Now.ToShortTimeString
        ElseIf radGenDate.Checked = True Then
            lblDate.Text = Format(Now, "MM/dd/yyyy h:mm:ss tt")

        ElseIf radLongDate.Checked = True Then
            lblDate.Text = Now.ToLongDateString

        End If
    End Sub

    Private Sub frmJob4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        radGenDate.Checked = True
    End Sub

    Private Sub btncalTax_Click(sender As Object, e As EventArgs) Handles btnCalculat.Click

        Dim decR_BONUS, decR_ALLOW, decR_TAX, dblYearSalary, dblBonus, dblAllIncome, dblAllowance, dblTax As Double
        decR_BONUS = 0.2
        decR_ALLOW = 0.01
        decR_TAX = 0.07

        dblYearSalary = Val(txtSalary.Text * 12)
        dblBonus = Val(txtSale.Text * decR_BONUS)
        dblAllIncome = dblYearSalary + dblBonus
        dblAllowance = dblAllIncome * decR_ALLOW
        dblTax = (dblAllIncome - dblAllowance) * decR_TAX




        lblYearSalary.Text = dblYearSalary
        lblBonus.Text = dblBonus
        lblAllincomes.Text = dblAllIncome
        lblAllowance.Text = dblAllowance
        lblTax.Text = dblTax

    End Sub
End Class