Public Class VB_ATest1
    Private Sub VB_ATest1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lblTotalyear.Text = txtSalary.Text * 12
        lblTax.Text = lblTotalyear.Text * 5 / 100
        lblSutti.Text = lblTotalyear.Text - lblTax.Text


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class