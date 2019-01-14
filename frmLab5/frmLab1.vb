Public Class frmLab1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim salary As Double = Val(txtSalary.Text) * 12
        lblNet.Text = salary
        lblTax.Text = salary * 0.05
        lblResult.Text = lblNet.Text - lblTax.Text
        lblNet.BackColor = Color.Green
        lblResult.BackColor = Color.Pink
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class