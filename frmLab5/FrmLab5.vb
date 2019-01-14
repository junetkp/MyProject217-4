Public Class frmLab5
    Dim decTotal, decDiscount, decNet, decCredit As Decimal

    Private Sub radMember_CheckedChanged(sender As Object, e As EventArgs) Handles radMember.CheckedChanged
        grpPaid.Enabled = True

        lblDiscount.ResetText()
        lblPaid.ResetText()
        lblCredit.ResetText()
    End Sub

    Private Sub frmLab5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grpPaid.Enabled = False
    End Sub

    Private Sub radOther_CheckedChanged(sender As Object, e As EventArgs) Handles radOther.CheckedChanged
        radPaid.Checked = True
        grpPaid.Enabled = False

        lblDiscount.ResetText()
        lblPaid.ResetText()
        lblCredit.ResetText()
    End Sub

    Private Sub radPaid_CheckedChanged(sender As Object, e As EventArgs) Handles radPaid.CheckedChanged
        lblDiscount.ResetText()
        lblPaid.ResetText()
        lblCredit.ResetText()
    End Sub

    Private Sub radCredit_CheckedChanged(sender As Object, e As EventArgs) Handles radCredit.CheckedChanged
        lblDiscount.ResetText()
        lblPaid.ResetText()
        lblCredit.ResetText()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        lblTotal.Text = Val(txtPrice.Text) * Val(txtUnit.Text)
        decTotal = FormatNumber(lblTotal.Text, 2)
        Dim totalprice As Double

        If txtProduct.Text = "" Then
            MessageBox.Show("ข้อมูลไม่สมบูรณ์")
        End If
        If txtPrice.Text = "0" Then
            MessageBox.Show("ข้อมูลไม่สมบูรณ์")
        End If

        If radMember.Checked Then
            If radPaid.Checked = True Then
                decNet = decTotal - decDiscount
                decCredit = 0
                If decTotal < 1000 Then
                    decDiscount = 0
                    totalprice = lblTotal.Text
                ElseIf decTotal < 5000 Then
                    decDiscount = decTotal * 0.05
                    totalprice = Val(lblTotal.Text) - decDiscount
                ElseIf decTotal < 10000 Then
                    decDiscount = decTotal * 0.1
                    totalprice = Val(lblTotal.Text) - decDiscount
                ElseIf decTotal >= 10000 Then
                    decDiscount = decTotal * 0.15
                    totalprice = Val(lblTotal.Text) - decDiscount
                End If
            ElseIf radCredit.Checked = True Then
                decDiscount = 0
                decNet = 0
                decCredit = decTotal
            End If
        ElseIf radOther.Checked Then
            lblPaid.Text = lblTotal.Text
            lblDiscount.Text = "0"
            lblCredit.Text = "0"
            Exit sub
        End If

        lblDiscount.Text = decDiscount
        lblPaid.Text = totalprice
        lblCredit.Text = decCredit

    End Sub

    Private Sub txtUnit_TextChanged(sender As Object, e As EventArgs) Handles txtUnit.TextChanged
        Call btnCalculate_Click(sender, e)
    End Sub

    Private Sub txtPrice_TextChanged(sender As Object, e As EventArgs) Handles txtPrice.TextChanged
        Call btnCalculate_Click(sender, e)
    End Sub
End Class
