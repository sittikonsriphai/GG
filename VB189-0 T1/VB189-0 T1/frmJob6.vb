Public Class frmJob6
    Dim total, total1, add1, add2, add3, add4, free1, free2, free3, s_total As Integer


    Private Sub chkICarForme_CheckedChanged(sender As Object, e As EventArgs) Handles chkICarForme.CheckedChanged

    End Sub

    Private Sub frmJob6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Enabled = False
        GroupBox2.Enabled = False

    End Sub

    Private Sub chkFree1_Click(sender As Object, e As EventArgs) Handles chkFree1.Click
        If chkFree1.Checked = True Then

            lblPaidPrice.Text = Val(lblPaidPrice.Text) - Val(lblFree1.Text)
        Else lblPaidPrice.Text = Val(lblPaidPrice.Text) + Val(lblFree1.Text)

        End If
    End Sub

    Private Sub chkFree2_Click(sender As Object, e As EventArgs) Handles chkFree2.Click
        If chkFree2.Checked = True Then

            lblPaidPrice.Text = Val(lblPaidPrice.Text) - Val(lblFree2.Text)
        Else lblPaidPrice.Text = Val(lblPaidPrice.Text) + Val(lblFree2.Text)

        End If
    End Sub

    Private Sub chkFree3_Click(sender As Object, e As EventArgs) Handles chkFree3.Click
        If chkFree3.Checked = True Then

            lblPaidPrice.Text = Val(lblPaidPrice.Text) - Val(lblFree3.Text)
        Else lblPaidPrice.Text = Val(lblPaidPrice.Text) + Val(lblFree3.Text)

        End If
    End Sub
    '------------------------------------------------------------------------------------------
    '------------------------------------------------------------------------------------------
    '------------------------------------------------------------------------------------------

    Private Sub chkItemsAdd1_Click(sender As Object, e As EventArgs) Handles chkItemsAdd1.Click
        If chkItemsAdd1.Checked = True Then
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + Val(lblItemsPrice1.Text)
        Else lblPaidPrice.Text = Val(lblPaidPrice.Text) - Val(lblItemsPrice1.Text)

        End If

    End Sub
    Private Sub chkItemsAdd2_Click(sender As Object, e As EventArgs) Handles chkItemsAdd2.Click
        If chkItemsAdd2.Checked = True Then
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + Val(lblItemsPrice2.Text)
        Else lblPaidPrice.Text = Val(lblPaidPrice.Text) - Val(lblItemsPrice2.Text)

        End If
    End Sub

    Private Sub chkItemsAdd3_Click(sender As Object, e As EventArgs) Handles chkItemsAdd3.Click
        If chkItemsAdd3.Checked = True Then
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + Val(lblItemsPrice3.Text)
        Else lblPaidPrice.Text = Val(lblPaidPrice.Text) - Val(lblItemsPrice3.Text)

        End If
    End Sub

    Private Sub chkItemsAdd4_Click(sender As Object, e As EventArgs) Handles chkItemsAdd4.Click
        If chkItemsAdd4.Checked = True Then
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + Val(lblItemsPrice4.Text)
        Else lblPaidPrice.Text = Val(lblPaidPrice.Text) - Val(lblItemsPrice4.Text)

        End If
    End Sub



    Private Sub chkcarforme_Click(sender As Object, e As EventArgs) Handles chkICarForme.Click
        lblStartPrice.Text = "1250000"

        If chkICarForme.Checked = True Then
            GroupBox1.Enabled = True
            GroupBox2.Enabled = True
            total = Val(lblStartPrice.Text) + Val(lblFree1.Text) + Val(lblFree2.Text) + Val(lblFree3.Text)
            lblPaidPrice.Text = total

        End If



        If chkICarForme.Checked = False Then
            Dim result As DialogResult
            result = MessageBox.Show("ต้องการยกเลิก", "คุณแน่ใจแล้วใช่ไหม", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
                chkICarForme.Checked = True


            End If

            If result = DialogResult.Yes Then
                GroupBox1.Enabled = False
                GroupBox2.Enabled = False
                lblPaidPrice.Text = ""
                lblStartPrice.Text = ""
                chkFree1.Checked = False
                chkFree2.Checked = False
                chkFree3.Checked = False
                chkItemsAdd1.Checked = False
                chkItemsAdd2.Checked = False
                chkItemsAdd3.Checked = False
                chkItemsAdd4.Checked = False

            End If




        End If

    End Sub


End Class
