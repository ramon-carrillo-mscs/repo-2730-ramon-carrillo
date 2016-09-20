' Name: Cranston Berries Project
'Purpose: Calculates project sales
'Author: Ramon Carrillo on 9/20/16



Option Strict On

Public Class frmMain
    Private Sub txtStraw_TextChanged(sender As Object, e As EventArgs) Handles txtStraw.TextChanged

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        lblProjStraw.Text = Format((1 + Val(txtProjIncrease.Text)) * Val(txtStraw.Text), "currency")
        lblProjBlue.Text = Format((1 + Val(txtProjIncrease.Text)) * Val(txtBlue.Text), "currency")
        lblProjRas.Text = Format((1 + Val(txtProjIncrease.Text)) * Val(txtRas.Text), "currency")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtStraw.Text = String.Empty
        txtBlue.Text = String.Empty
        txtRas.Text = String.Empty
        lblProjStraw.Text = String.Empty
        lblProjBlue.Text = String.Empty
        lblProjRas.Text = String.Empty
        txtProjIncrease.Focus()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class
