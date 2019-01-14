Public Class frmJob4
    Const decR_Bonus As Decimal = 0.2
    Const decR_Tax As Decimal = 0.07

    Dim saraly, sale As Double
    Dim dblToYearSaraly As Double
    Dim dblBonus As Double
    Dim dblAllowance As Double
    Dim dblIncome As Double
    Dim dblTax As Double

    Private Sub radShortDate_CheckedChanged(sender As Object, e As EventArgs) Handles radShortDate.CheckedChanged
        lblDate.Text = Date.Now.ToShortDateString
    End Sub

    Private Sub radGeneralDate_CheckedChanged(sender As Object, e As EventArgs) Handles radGeneralDate.CheckedChanged
        lblDate.Text = Date.Now
    End Sub

    Private Sub radLongDate_CheckedChanged(sender As Object, e As EventArgs) Handles radLongDate.CheckedChanged
        lblDate.Text = Date.Now.ToLongDateString
    End Sub

    Private Sub frmJob4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        radGeneralDate.Checked = True
        Dim dateNowDate As Date = Date.Now
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtSalary.Clear()
        txtSale.Clear()
        lblYearSalary.ResetText()
        lblBonus.ResetText()
        lblAllIncome.ResetText()
        lblAllowance.ResetText()
        lblTax.ResetText()
    End Sub

    Private Sub btnCalTax_Click(sender As Object, e As EventArgs) Handles btnCalTax.Click
        dblToYearSaraly = Val(txtSalary.Text) * 12
        dblBonus = Val(txtSale.Text) * decR_Bonus
        dblIncome = dblToYearSaraly + dblBonus
        dblAllowance = dblIncome * 0.01
        dblTax = (dblIncome - dblAllowance) * decR_Tax


        lblYearSalary.Text = FormatNumber(dblToYearSaraly)

        lblBonus.Text = FormatNumber(dblBonus)

        lblAllIncome.Text = FormatNumber(dblIncome)
        lblAllowance.Text = FormatNumber(dblAllowance)

        lblTax.Text = FormatNumber(dblTax)
    End Sub
End Class