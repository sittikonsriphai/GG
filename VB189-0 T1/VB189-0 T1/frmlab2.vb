Public Class VB_Test_2
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim Vistra, Computer, sale, Vistra1, Com1, comtotal As Double

        Vistra = Val(txtVistra.Text)
        Computer = Val(txtCom.Text)

        sale = Vistra + Computer
        lblTotalSales.Text = sale

        Vistra1 = Vistra * 5 / 100
        lblVistra.Text = Vistra1

        Com1 = Computer * 10 / 100
        lblCom.Text = Com1

        comtotal = Vistra1 + Com1
        lblComTotal.Text = comtotal







    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub


End Class