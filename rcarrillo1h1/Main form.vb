




Option Strict On

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        lblGross.Text = Format(Val(txtHours.Text) * Val(txtPayRate.Text), "fixed")
        lblFWT.Text = Format(Val(lblGross.Text) * 0.2, "fixed")
        lblFICA.Text = Format(Val(lblGross.Text) * 0.08, "fixed")
        lblState.Text = Format(Val(lblGross.Text) * 0.03, "fixed")
        lblNet.Text = Format(Val(lblGross.Text) - Val(lblFWT.Text) - Val(lblFICA.Text) - Val(lblState.Text), "fixed")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtName.Text = String.Empty
        txtHours.Text = "0.00"
        txtPayRate.Text = "0.00"
        lblGross.Text = String.Empty
        lblFWT.Text = String.Empty
        lblFICA.Text = String.Empty
        lblState.Text = String.Empty
        lblNet.Text = String.Empty
        txtName.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
