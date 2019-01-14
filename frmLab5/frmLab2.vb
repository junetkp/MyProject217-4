Public Class frmLab2
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim vistra As Double = Val(txtVistra.Text)
        Dim frista As Double = Val(txtFrista.Text)
        Dim com1 As Double = vistra * 0.05
        Dim com2 As Double = frista * 0.1

        Dim sale As Double = vistra + frista
        lblSale.Text = sale
        lblSale.BackColor = Color.Pink

        Dim commissions As Double = com1 + com2
        lblCommissions.Text = commissions
        lblCommissions.BackColor = Color.Pink

        lblCom1.Text = com1
        lblCom2.Text = com2
        lblCom1.BackColor = Color.Pink
        lblCom2.BackColor = Color.Pink

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class