' Name: Cranston Berries Project
'Purpose: Calculates project sales
'Author: Ramon Carrillo on 10/9/16



Option Strict On
Option Explicit On
Option Infer Off

Public Class frmMain


    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click


        Dim decProjInc As Decimal
        Dim decStraw As Decimal
        Dim decBlue As Decimal
        Dim decRas As Decimal
        Dim decProjStraw As Decimal
        Dim decProjBlue As Decimal
        Dim decProjRas As Decimal

        Decimal.TryParse(txtStraw.Text, decStraw)
        Decimal.TryParse(txtBlue.Text, decBlue)
        Decimal.TryParse(txtRas.Text, decRas)
        Decimal.TryParse(txtProjIncrease.Text, decProjInc)

        decProjStraw = (decProjInc * decStraw) + decStraw
        decProjBlue = (decProjInc * decBlue) + decBlue
        decProjRas = (decProjInc * decRas) + decRas


        lblProjStraw.Text = decProjStraw.ToString("C2")
        lblProjBlue.Text = decProjBlue.ToString("C2")
        lblProjRas.Text = decProjRas.ToString("C2")





        'lblProjStraw.Text = Format((1 + Val(txtProjIncrease.Text)) * Val(txtStraw.Text), "currency")
        'lblProjBlue.Text = Format((1 + Val(txtProjIncrease.Text)) * Val(txtBlue.Text), "currency")
        'lblProjRas.Text = Format((1 + Val(txtProjIncrease.Text)) * Val(txtRas.Text), "currency")

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

    Private Sub btnRetirement_Click(sender As Object, e As EventArgs) Handles btnRetirement.Click
        frmRetirement.Show()
    End Sub
End Class
