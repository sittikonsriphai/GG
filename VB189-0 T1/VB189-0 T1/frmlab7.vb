Public Class frmlab7
    Private Sub btnEnterPrice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        lstAdd.Items.Add(txtAdd.Text)
        lstAdd.SelectedIndex = lstAdd.Items.Count - 1
        txtAdd.Text = ""


    End Sub


    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtAdd.Text = ""
        lstAdd.Items.Clear()
        cboOutput.Items.Clear()
        lblOutput.Text = " "



    End Sub

    Private Sub btnToRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMove.Click
        Dim d As Integer
        If lstAdd.Items.Count = 0 Then
            MessageBox.Show("ไม่มีรายการ list box")

        Else
            d = lstAdd.SelectedIndex
            cboOutput.Items.Add(lstAdd.SelectedItem)

            If lstAdd.SelectedIndex = lstAdd.Items.Count - 1 Then
                lstAdd.Items.RemoveAt(lstAdd.SelectedIndex)
                lstAdd.SelectedIndex = lstAdd.Items.Count - 1
            Else
                lstAdd.Items.RemoveAt(lstAdd.SelectedIndex)
                lstAdd.SelectedIndex = d

            End If
            cboOutput.SelectedIndex = cboOutput.Items.Count - 1

        End If
    End Sub
    Private Sub frmAction7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnAdd.Enabled = False
    End Sub

    Private Sub txtEnterPrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAdd.TextChanged
        If txtAdd.Text = "" Then
            btnAdd.Enabled = False
        Else
            btnAdd.Enabled = True
        End If


    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub cboSelect_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboOutput.SelectedIndexChanged, lstAdd.SelectedIndexChanged
        lblOutput.Text = cboOutput.Text
    End Sub

    Private Sub btnToLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        If cboOutput.SelectedIndex < 0 Then
            MessageBox.Show("ไม่ได้เลือกรายการใน comboBox")
        Else
            Dim n As Integer
            n = cboOutput.SelectedIndex
            lstAdd.Items.Add(cboOutput.SelectedItem)

            If cboOutput.SelectedIndex = cboOutput.Items.Count - 1 Then
                cboOutput.Items.RemoveAt(cboOutput.SelectedIndex)
                cboOutput.SelectedIndex = cboOutput.Items.Count - 1
            Else
                cboOutput.Items.RemoveAt(cboOutput.SelectedIndex)
                cboOutput.SelectedIndex = n

            End If
            lstAdd.SelectedIndex = lstAdd.Items.Count - 1

            If cboOutput.Items.Count = 0 Then
                cboOutput.Text = ""

            End If
        End If
    End Sub


    Private Sub btnToLeftAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackAll.Click
        If cboOutput.Items.Count = 0 Then
            MessageBox.Show("ไม่มีรายการ combobox")

        Else
            Dim list As New List(Of Object)
            For Each item As Object In cboOutput.Items
                list.Add(item)
            Next
            For Each item As String In list
                lstAdd.Items.Add(item)
                cboOutput.Items.Remove(item)
                lstAdd.SelectedIndex = lstAdd.Items.Count - 1
            Next
        End If
    End Sub

    Private Sub btnToRightAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoveAll.Click
        If lstAdd.Items.Count = 0 Then
            MessageBox.Show("ไม่มีรายการ list box")

        Else
            For Each item As Object In lstAdd.Items
                cboOutput.Items.Add(item)

            Next
            lstAdd.Items.Clear()
        End If
    End Sub
End Class