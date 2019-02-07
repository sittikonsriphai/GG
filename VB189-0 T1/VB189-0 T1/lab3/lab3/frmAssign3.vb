Public Class frmAssign3
    Private Sub btnHigh_Click(sender As Object, e As EventArgs) Handles btnHigh.Click

        Dim a, b As Double
        a = txtDisgis.Text
        b = a + 3
        txtDisgis.Text = b


    End Sub

    Private Sub btnLow_Click(sender As Object, e As EventArgs) Handles btnLow.Click
        Dim a, b As Double
        a = txtDisgis.Text
        b = a - 3
        txtDisgis.Text = b
    End Sub

    Private Sub lblFRed_Click(sender As Object, e As EventArgs) Handles lblFRed.Click
        txtDisgis.ForeColor = Color.Red
    End Sub

    Private Sub cboSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSelect.SelectedIndexChanged
        Dim size As Double
        Double.TryParse(cboSelect.Text, size)
        txtDisgis.Font = New Font(txtDisgis.Font.Name, size, txtDisgis.Font.Style, txtDisgis.Font.Unit)

    End Sub

    Private Sub txtDigis_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblFBlue_Click(sender As Object, e As EventArgs) Handles lblFBlue.Click
        txtDisgis.ForeColor = Color.Blue

    End Sub

    Private Sub lblFGreen_Click(sender As Object, e As EventArgs) Handles lblFGreen.Click
        txtDisgis.ForeColor = Color.Green
    End Sub

    Private Sub lblFViolet_Click(sender As Object, e As EventArgs) Handles lblFViolet.Click
        txtDisgis.ForeColor = Color.Violet

    End Sub

    Private Sub lblFBlack_Click(sender As Object, e As EventArgs) Handles lblFBlack.Click
        txtDisgis.ForeColor = Color.Black
    End Sub

    Private Sub lblFOrange_Click(sender As Object, e As EventArgs) Handles lblFOrange.Click
        txtDisgis.ForeColor = Color.Orange
    End Sub

    Private Sub lblFYellow_Click(sender As Object, e As EventArgs) Handles lblFYellow.Click
        txtDisgis.ForeColor = Color.Yellow
    End Sub

    Private Sub lblFBrows_Click(sender As Object, e As EventArgs) Handles lblFBrown.Click
        txtDisgis.ForeColor = Color.Brown
    End Sub

    Private Sub lblFWhite_Click(sender As Object, e As EventArgs) Handles lblFWhite.Click
        txtDisgis.ForeColor = Color.White
    End Sub

    Private Sub lblFSky_Click(sender As Object, e As EventArgs) Handles lblFSky.Click
        txtDisgis.ForeColor = Color.SkyBlue

    End Sub

    Private Sub lblRed_Click(sender As Object, e As EventArgs) Handles lblRed.Click
        txtDisgis.BackColor = Color.Red
    End Sub

    Private Sub lblBlue_Click(sender As Object, e As EventArgs) Handles lblBlue.Click
        txtDisgis.BackColor = Color.Blue
    End Sub

    Private Sub lblGreen_Click(sender As Object, e As EventArgs) Handles lblGreen.Click
        txtDisgis.BackColor = Color.Green
    End Sub

    Private Sub lblViolet_Click(sender As Object, e As EventArgs) Handles lblViolet.Click
        txtDisgis.BackColor = Color.Violet
    End Sub

    Private Sub lblBlack_Click(sender As Object, e As EventArgs) Handles lblBlack.Click
        txtDisgis.BackColor = Color.Black
    End Sub

    Private Sub lblOrange_Click(sender As Object, e As EventArgs) Handles lblOrange.Click
        txtDisgis.BackColor = Color.Orange
    End Sub

    Private Sub lblYellow_Click(sender As Object, e As EventArgs) Handles lblYellow.Click
        txtDisgis.BackColor = Color.Yellow
    End Sub

    Private Sub lblBrown_Click(sender As Object, e As EventArgs) Handles lblBrown.Click
        txtDisgis.BackColor = Color.Brown
    End Sub

    Private Sub lblWhite_Click(sender As Object, e As EventArgs) Handles lblWhite.Click
        txtDisgis.BackColor = Color.White
    End Sub

    Private Sub lblSky_Click(sender As Object, e As EventArgs) Handles lblSky.Click
        txtDisgis.BackColor = Color.SkyBlue
    End Sub

    Private Sub txtDisgis_TextChanged(sender As Object, e As EventArgs) Handles txtDisgis.TextChanged

    End Sub
End Class
