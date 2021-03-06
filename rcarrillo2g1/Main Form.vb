﻿' Name:         Jetters Project
' Purpose:      Display the discount and total due
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtPrice_Enter(sender As Object, e As EventArgs) Handles txtPrice.Enter
        txtPrice.SelectAll()
    End Sub

    Private Sub txtQuantity_Enter(sender As Object, e As EventArgs) Handles txtQuantity.Enter
        txtQuantity.SelectAll()
    End Sub

    Private Sub ClearLabel(sender As Object, e As EventArgs) Handles txtPrice.TextChanged, txtQuantity.TextChanged
        lblDiscount.Text = String.Empty
        lblTotalDue.Text = String.Empty
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalIf.Click
        ' calculate discount and total due

        Dim dblPrice As Double
        Dim intQuantity As Integer
        Dim dblRate As Double = 0.0
        Dim dblTotalWithoutDiscount As Double
        Dim dblDiscount As Double
        Dim dblTotalDue As Double

        Double.TryParse(txtPrice.Text, dblPrice)
        Integer.TryParse(txtQuantity.Text, intQuantity)

        If intQuantity > 0 AndAlso intQuantity <= 10 Then
            dblRate = 0.0
        End If

        If intQuantity > 10 AndAlso intQuantity <= 15 Then
            dblRate = 0.02
        End If

        If intQuantity > 15 AndAlso intQuantity <= 20 Then
            dblRate = 0.025
        End If

        If intQuantity > 20 Then
            dblRate = 0.03
        End If

        dblTotalWithoutDiscount = dblPrice * intQuantity
        dblDiscount = dblTotalWithoutDiscount * dblRate
        dblTotalDue = dblTotalWithoutDiscount - dblDiscount

        lblDiscount.Text = dblDiscount.ToString("C2")
        lblTotalDue.Text = dblTotalDue.ToString("C2")
    End Sub

    Private Sub txtQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantity.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
                e.KeyChar <> ControlChars.Back Then
            'cancel the key
            e.Handled = True
        End If
    End Sub

    Private Sub txtPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrice.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
               e.KeyChar <> ControlChars.Back AndAlso e.KeyChar = "." Then
            'cancel the key
            e.Handled = True
        End If
    End Sub

    Private Sub btnNestedIF_Click(sender As Object, e As EventArgs) Handles btnNestedIF.Click
        ' calculate discount and total due

        Dim dblPrice As Double
        Dim intQuantity As Integer
        Dim dblRate As Double = 0.0
        Dim dblTotalWithoutDiscount As Double
        Dim dblDiscount As Double
        Dim dblTotalDue As Double

        Double.TryParse(txtPrice.Text, dblPrice)
        Integer.TryParse(txtQuantity.Text, intQuantity)

        If intQuantity > 20 Then
            dblRate = 0.03
        Else
            If intQuantity > 15 Then
                dblRate = 0.025
            Else
                If intQuantity > 10 Then
                    dblRate = 0.02
                Else
                    If intQuantity > 0 Then
                        dblRate = 0.0
                    End If
                End If
            End If
        End If

        dblTotalWithoutDiscount = dblPrice * intQuantity
        dblDiscount = dblTotalWithoutDiscount * dblRate
        dblTotalDue = dblTotalWithoutDiscount - dblDiscount

        lblDiscount.Text = dblDiscount.ToString("C2")
        lblTotalDue.Text = dblTotalDue.ToString("C2")
    End Sub

    Private Sub btnCalIFElseIf_Click(sender As Object, e As EventArgs) Handles btnCalIFElseIf.Click
        ' calculate discount and total due

        Dim dblPrice As Double
        Dim intQuantity As Integer
        Dim dblRate As Double = 0.0
        Dim dblTotalWithoutDiscount As Double
        Dim dblDiscount As Double
        Dim dblTotalDue As Double

        Double.TryParse(txtPrice.Text, dblPrice)
        Integer.TryParse(txtQuantity.Text, intQuantity)

        If intQuantity > 20 Then
            dblRate = 0.03
        ElseIf intQuantity > 15 Then
            dblRate = 0.025
        ElseIf intQuantity > 10 Then
            dblRate = 0.02
        ElseIf intQuantity > 0 Then
            dblRate = 0.0
        End If

        dblTotalWithoutDiscount = dblPrice * intQuantity
        dblDiscount = dblTotalWithoutDiscount * dblRate
        dblTotalDue = dblTotalWithoutDiscount - dblDiscount

        lblDiscount.Text = dblDiscount.ToString("C2")
        lblTotalDue.Text = dblTotalDue.ToString("C2")
    End Sub

    Private Sub btnCalSelect_Click(sender As Object, e As EventArgs) Handles btnCalSelect.Click
        ' calculate discount and total due

        Dim dblPrice As Double
        Dim intQuantity As Integer
        Dim dblRate As Double = 0.0
        Dim dblTotalWithoutDiscount As Double
        Dim dblDiscount As Double
        Dim dblTotalDue As Double

        Double.TryParse(txtPrice.Text, dblPrice)
        Integer.TryParse(txtQuantity.Text, intQuantity)

        Select Case intQuantity
            Case Is > 20
                dblRate = 0.03
            Case Is > 15
                dblRate = 0.025
            Case Is > 10
                dblRate = 0.02
            Case 0 To 10
                dblRate = 0.0
        End Select

        dblTotalWithoutDiscount = dblPrice * intQuantity
        dblDiscount = dblTotalWithoutDiscount * dblRate
        dblTotalDue = dblTotalWithoutDiscount - dblDiscount

        lblDiscount.Text = dblDiscount.ToString("C2")
        lblTotalDue.Text = dblTotalDue.ToString("C2")
    End Sub
End Class
