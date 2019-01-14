Public Class frmLab8
    Dim sumScore, sumCredit As Decimal

    Private Sub frmLap8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblOldTotoalScore.Text = "150"
        lblOldTotalUnit.Text = "50"
        lblGrade.Text = "3.00"
    End Sub

    Private Function getGrade(ByVal score As Decimal) As String
        Dim grade As String

        If score >= 80 Then
            grade = "A"
        ElseIf score >= 75 Then
            grade = "B+"
        ElseIf score >= 70 Then
            grade = "B"
        ElseIf score >= 65 Then
            grade = "c+"
        ElseIf score >= 60 Then
            grade = "C"
        ElseIf score >= 55 Then
            grade = "D+"
        ElseIf score >= 50 Then
            grade = "D"
        Else
            grade = "F"
        End If

        Return grade
    End Function

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        txtScore.Text = txtScore.Text.Trim()
        txtUnit.Text = txtUnit.Text.Trim()
        txtObject.Text = txtObject.Text.Trim()

        Dim gpa As String


        If txtScore.Text = "" Or txtUnit.Text = "" Or txtObject.Text = "" Then
            MessageBox.Show("ข้อมูลใน TextBox ต้องไม่เป็นค่าว่าง")

        Else
            gpa = getGrade(Val(txtScore.Text))
            lstObject.Items.Add(txtObject.Text)
            lstScore.Items.Add(Val(txtScore.Text))
            lstUnit.Items.Add(Val(txtUnit.Text))
            lstGrade.Items.Add(gpa)

            lstObject.SelectedIndex = lstObject.Items.Count - 1
            lstScore.SelectedIndex = lstScore.Items.Count - 1
            lstUnit.SelectedIndex = lstUnit.Items.Count - 1
            lstGrade.SelectedIndex = lstGrade.Items.Count - 1

            callData()

            txtObject.Text = ""
            txtScore.Text = ""
            txtUnit.Text = ""

            txtObject.Select()

        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Clear()

        frmLap8_Load(sender, e)
    End Sub

    Private Sub callData()
        sumScore = Val(lblOldTotoalScore.Text)
        sumCredit = Val(lblOldTotalUnit.Text)

        Dim credit, grade As Double
        Dim gpa As Decimal

        For i = 0 To lstUnit.Items.Count - 1
            credit = lstUnit.Items(i)

            If lstGrade.Items(i) = "A" Then
                grade = 4
            ElseIf lstGrade.Items(i) = "B+" Then
                grade = 3.5
            ElseIf lstGrade.Items(i) = "B" Then
                grade = 3
            ElseIf lstGrade.Items(i) = "C+" Then
                grade = 2.5
            ElseIf lstGrade.Items(i) = "C" Then
                grade = 2
            ElseIf lstGrade.Items(i) = "D+" Then
                grade = 1.5
            ElseIf lstGrade.Items(i) = "D" Then
                grade = 1
            Else
                grade = 0
            End If

            sumScore += grade * credit
            sumCredit += credit
        Next
        gpa = sumScore / sumCredit
        lblNewGrade.Text = gpa.ToString("0.00")
    End Sub

    Private Sub Clear()
        txtObject.Text = ""
        txtScore.Text = ""
        txtUnit.Text = ""

        lstGrade.Items.Clear()
        lstObject.Items.Clear()
        lstScore.Items.Clear()
        lstUnit.Items.Clear()
    End Sub
End Class