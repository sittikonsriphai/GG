Public Class frmLab8
    Dim sumScore As Double
    Dim sumCredit As Double
    Dim GPA As Decimal
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim YU As String

        If txtSubject.Text.Trim() = "" Or txtScore.Text.Trim() = "" Or txtCredit.Text.Trim() = "" Then
            MessageBox.Show("ป้อนข้อมูลไม่สมบูรณ์", "Error...", MessageBoxButtons.OK)
            txtSubject.Focus()
            Exit Sub
        Else

            YU = getGrade(Val(txtScore.Text))
            lstGrade.Items.Add(YU)
            lstSubject.Items.Add(txtSubject.Text)
            lstScore.Items.Add(Val(txtScore.Text))
            lstCredit.Items.Add(Val(txtCredit.Text))

            lstScore.SelectedIndex = lstSubject.Items.Count - 1
            lstSubject.SelectedIndex = lstSubject.Items.Count - 1
            lstCredit.SelectedIndex = lstSubject.Items.Count - 1
            lstGrade.SelectedIndex = lstSubject.Items.Count - 1

            Call Caldata()
            txtSubject.Text = ""
            txtScore.Text = ""
            txtCredit.Text = ""




        End If
    End Sub
    Private Function getGrade(ByVal score As String) As String
        Dim grad As String

        If score >= 80 Then
            grad = "A"
        ElseIf score >= 75 Then
            grad = "B+"
        ElseIf score >= 70 Then
            grad = "B"
        ElseIf score >= 65 Then
            grad = "C+"
        ElseIf score >= 60 Then
            grad = "C"
        ElseIf score >= 55 Then
            grad = "D+"
        ElseIf score >= 50 Then
            grad = "D"
        Else
            grad = "F"
        End If
        Return grad

    End Function


    Private Sub Caldata()
        Dim Grad2, C, Sum As Double
        sumScore = (lblOldTotalScore.Text)
        sumCredit = (lblOldTotalCredit.Text)


        For i = 0 To lstCredit.Items.Count - 1
            Sum = lstCredit.Items(i)

            If lstGrade.Items(i) = "A" Then
                Grad2 = 4
            ElseIf lstGrade.Items(i) = "B+" Then
                Grad2 = 3.5
            ElseIf lstGrade.Items(i) = "B" Then
                Grad2 = 3
            ElseIf lstGrade.Items(i) = "C+" Then
                Grad2 = 2.5
            ElseIf lstGrade.Items(i) = "C" Then
                Grad2 = 2
            ElseIf lstGrade.Items(i) = "D+" Then
                Grad2 = 1.5
            ElseIf lstGrade.Items(i) = "D" Then
                Grad2 = 1
            ElseIf lstGrade.Items(i) = "F" Then
                Grad2 = 0
            End If
            sumScore += Grad2 * Sum
            sumCredit += Sum
        Next
        C = sumScore / sumCredit
        lblNewGPA.Text = C.ToString("n")

    End Sub
    Private Sub frmLab8_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtSubject.Text = ""
        txtScore.Text = ""
        txtCredit.Text = ""
        lstSubject.Items.Clear()
        lstScore.Items.Clear()
        lstCredit.Items.Clear()
        lstGrade.Items.Clear()
        lblNewGPA.Text = ""

    End Sub

    Private Sub txtScore_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtScore.KeyPress
        Dim keyInt As Integer = Asc(e.KeyChar)
        If (keyInt >= 48 And keyInt <= 57) Or keyInt = 46 Or keyInt = 8 Then
            Exit Sub
        Else
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub txtCredit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCredit.KeyPress
        Dim keyInt As Integer = Asc(e.KeyChar)
        If (keyInt >= 48 And keyInt <= 57) Or keyInt = 46 Or keyInt = 8 Then
            Exit Sub
        Else
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub lstSubject_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSubject.SelectedIndexChanged

    End Sub
End Class