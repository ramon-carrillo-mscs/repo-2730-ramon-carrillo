'Name: Average Project
'Purpose: Calculates Average Test Scores
'Author: Ramon Carrillo on 9/20/16





Option Strict On

Public Class frmMain

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        lblAveragetestscore.Text = Format((Val(txtScore1.Text) + Val(txtScore2.Text) + Val(txtScore3.Text)) / 3, "0.00")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtScore1.Text = String.Empty
        txtScore2.Text = String.Empty
        txtScore3.Text = String.Empty
        lblAveragetestscore.Text = String.Empty
        txtScore1.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
