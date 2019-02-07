Public Class Mid9
    Dim Motor1, car1, car2, carSuv
    Dim Total3

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txt1.Text = "" Then
            MessageBox.Show("กรุณาใส่ระยะทาง")
            lblTotal2.Text = ""
            Exit Sub
        End If

        Dim Raya, Total

        Raya = Val(txt1.Text)
        Total = lblTotal1.Text

        If Rd1.Checked = True Then
            Raya = Val(Raya * 2) + Total
            lblTotal2.Text = Val(Raya + Total3)

        ElseIf Rd2.Checked = True Then
            Raya = Val(Raya * 4) + Total
            lblTotal2.Text = Val(Raya + Total3)

        ElseIf Rd3.Checked = True Then
            Raya = Val(Raya * 6) + Total
            lblTotal2.Text = Val(Raya + Total3)

        ElseIf Rd4.Checked = True Then
            Raya = Val(Raya * 8) + Total
            lblTotal2.Text = Val(Raya + Total3)

        End If
        If Chkgohome.Checked = True Then
            Dim Total2
            Total2 = Val(lblTotal2.Text)
            lblTotal2.Text = Total2 * 2


        End If

    End Sub

    Private Sub Rd1_CheckedChanged(sender As Object, e As EventArgs) Handles Rd1.CheckedChanged

        Motor1 = Rd1.Text
        Motor1 = 20

        If Rd1.Checked = True Then
            lblTotal1.Text = Motor1
        End If

    End Sub

    Private Sub Chkgohome_CheckedChanged(sender As Object, e As EventArgs) Handles Chkgohome.CheckedChanged

    End Sub

    Private Sub CheckBox1_Click(sender As Object, e As EventArgs) Handles Chkgohome.Click


        If Chkgohome.Checked = True Then
            Total3 = 50
            lblTotal3.Text = Total3

        End If

        If Chkgohome.Checked = False Then
            Total3 = 0
            lblTotal3.Text = ""


        End If
    End Sub

    Private Sub Rd2_CheckedChanged(sender As Object, e As EventArgs) Handles Rd2.CheckedChanged
        car1 = Rd2.Text
        car1 = 50

        If Rd2.Checked = True Then
            lblTotal1.Text = car1
        End If
    End Sub

    Private Sub Rd3_CheckedChanged(sender As Object, e As EventArgs) Handles Rd3.CheckedChanged
        car1 = Rd3.Text
        car1 = 50

        If Rd3.Checked = True Then
            lblTotal1.Text = car1
        End If
    End Sub

    Private Sub Rd4_CheckedChanged(sender As Object, e As EventArgs) Handles Rd4.CheckedChanged
        car1 = Rd4.Text
        car1 = 50

        If Rd4.Checked = True Then
            lblTotal1.Text = car1
        End If
    End Sub
End Class