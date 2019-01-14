Public Class FrmJob6
    Private Sub FrmJob6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Enabled = False
        GroupBox2.Enabled = False
    End Sub
    Dim car, price As Double
    Dim p1, p2, p3, p4, f1, f2, f3 As Double

    Private Sub chkFree1_Click(sender As Object, e As EventArgs) Handles chkFree1.Click
        If chkFree1.Checked Then
            price = price + Val(lblFree1.Text)
        Else
            price = price - Val(lblFree1.Text)
        End If

        lblPaidPrice.Text = price
    End Sub

    Private Sub chkFree2_Click(sender As Object, e As EventArgs) Handles chkFree2.Click
        If chkFree2.Checked Then
            price = price + Val(lblFree2.Text)
        Else
            price = price - Val(lblFree2.Text)
        End If

        lblPaidPrice.Text = price
    End Sub

    Private Sub chkFree3_Click(sender As Object, e As EventArgs) Handles chkFree3.Click
        If chkFree3.Checked Then
            price = price + Val(lblFree3.Text)
        Else
            price = price - Val(lblFree3.Text)
        End If

        lblPaidPrice.Text = price
    End Sub

    Private Sub chkItems4_Click(sender As Object, e As EventArgs) Handles chkItems4.Click
        If chkItems4.Checked Then
            price = price + Val(lblItemsPrice4.Text)
        Else
            price = price - Val(lblItemsPrice4.Text)
        End If

        lblPaidPrice.Text = price
    End Sub

    Private Sub chkItems3_Click(sender As Object, e As EventArgs) Handles chkItems3.Click
        If chkItems3.Checked Then
            price = price + Val(lblItemsPrice3.Text)
        Else
            price = price - Val(lblItemsPrice3.Text)
        End If

        lblPaidPrice.Text = price
    End Sub

    Private Sub chkItems2_Click(sender As Object, e As EventArgs) Handles chkItems2.Click
        If chkItems2.Checked Then
            price = price + Val(lblItemsPrice2.Text)
        Else
            price = price - Val(lblItemsPrice2.Text)
        End If

        lblPaidPrice.Text = price
    End Sub

    Private Sub chkItems1_Click(sender As Object, e As EventArgs) Handles chkItems1.Click
        If chkItems1.Checked Then
            price = price + Val(lblItemsPrice1.Text)
        Else
            price = price - Val(lblItemsPrice1.Text)
        End If

        lblPaidPrice.Text = price
    End Sub

    Private Sub chkCarForMe_Click(sender As Object, e As EventArgs) Handles chkCarForMe.Click
        GroupBox1.Enabled = True
        GroupBox2.Enabled = True

        If chkCarForMe.Checked Then
            chkFree1.Checked = True
            chkFree2.Checked = True
            chkFree3.Checked = True
            car = Val(lblStartPrice.Text)
            f1 = Val(lblFree1.Text)
            f2 = Val(lblFree2.Text)
            f3 = Val(lblFree3.Text)
            price = car + f1 + f2 + f3
            lblPaidPrice.Text = price
        Else
            Dim check As DialogResult
            check = MessageBox.Show("ต้องการยกเลิกการซื้อรถใช่หรือไม่", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If check = DialogResult.Yes Then
                chkCarForMe.Checked = False
                chkFree1.Checked = False
                chkFree2.Checked = False
                chkFree3.Checked = False
                GroupBox1.Enabled = False
                GroupBox2.Enabled = False
                lblPaidPrice.Text = ""
            Else
                chkCarForMe.Checked = True

            End If
        End If
    End Sub
End Class