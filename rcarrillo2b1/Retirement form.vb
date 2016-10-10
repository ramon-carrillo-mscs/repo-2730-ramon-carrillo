Public Class frmRetirement


    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim decGrosspay As Decimal
        Dim decEmprate As Decimal
        Dim decEmplrate As Decimal
        Dim decEmpcon As Decimal
        Dim decEmplcon As Decimal
        Dim dectotal As Decimal

        Decimal.TryParse(txtweeklypay.Text, decGrosspay)
        Decimal.TryParse(txtEmployerrate.Text, decEmprate)
        Decimal.TryParse(txtEmployerrate.Text, decEmplrate)


        decEmpcon = (decGrosspay * decEmprate) * 52
        decEmplcon = (decGrosspay * decEmplrate) * 52

        lblEmployeecon.Text = decEmpcon.ToString("C2")
        lblEmployercon.Text = decEmplcon.ToString("C2")

        dectotal = decEmpcon + decEmplcon

        lblTotal.Text = dectotal.ToString("C2")




    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click

        txtweeklypay.Text = String.Empty
        txtEmployeerate.Text = String.Empty
        txtEmployerrate.Text = String.Empty
        lblEmployeecon.Text = String.Empty
        lblEmployercon.Text = String.Empty
        lblEmployercon.Text = String.Empty
        lblTotal.Text = String.Empty
        txtweeklypay.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class