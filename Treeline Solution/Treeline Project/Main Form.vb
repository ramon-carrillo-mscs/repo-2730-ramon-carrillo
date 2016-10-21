﻿' Name:         Treeline Project
' Purpose:      Display the total room charge, tax, 
'               total resort fee, and total due
' Programmer:   Ramon Carrillo 10/16/2016

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub ClearLabels(sender As Object, e As EventArgs) _
        Handles txtRooms.TextChanged, txtNights.TextChanged,
        txtAdults.TextChanged, txtChildren.TextChanged
        ' clear calculated amounts

        lblRoomChg.Text = String.Empty
        lblTax.Text = String.Empty
        lblResortFee.Text = String.Empty
        lblTotalDue.Text = String.Empty
    End Sub

    Private Sub lblTotalDue_Click(sender As Object, e As EventArgs) Handles lblTotalDue.Click

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'calculate and display total room charge,
        'tax, total resort fee, and total due

        Const intMax_Per_Room As Integer = 6
        Const dblDIALY_ROOM_CHG As Double = 225.5
        Const dblTAX_RATE As Double = 0.1625
        Const dblDAILY_RESORT_FEE As Double = 12.5
        Const strMSG As String =
            "You have exceeded the maximum guests per room."
        Dim intRoomsReserved As Integer
        Dim intNights As Integer
        Dim intAdults As Integer
        Dim intChildren As Integer
        Dim intNumGuests As Integer
        Dim dblRoomsRequired As Double
        Dim dblTotalRoomChg As Double
        Dim dblTax As Double
        Dim dblTotalResortFee As Double
        Dim dblTotalDue As Double

        ' store input in variables
        Integer.TryParse(txtRooms.Text, intRoomsReserved)
        Integer.TryParse(txtNights.Text, intNights)
        Integer.TryParse(txtAdults.Text, intAdults)
        Integer.TryParse(txtChildren.Text, intChildren)

        ' calculate total number of guests
        intNumGuests = intAdults + intChildren
        ' calculate number of rooms required
        dblRoomsRequired = intNumGuests / intMax_Per_Room

        ' determine whether number of reserved rooms is
        ' adequate and then wither display a message or
        ' calculate and display the  charges
        If intRoomsReserved < dblRoomsRequired Then
            MessageBox.Show(strMSG, "Treeline Resort",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        Else
            ' calculate charges
            dblTotalRoomChg = intRoomsReserved *
                intNights * dblDIALY_ROOM_CHG
            dblTax = dblTotalRoomChg * dblTAX_RATE
            dblTotalResortFee = intRoomsReserved *
                intNights * dblDAILY_RESORT_FEE
            dblTotalDue = dblTotalRoomChg +
                dblTax + dblTotalResortFee

            'diplay charges
            lblRoomChg.Text = dblTotalRoomChg.ToString("n2")
            lblTax.Text = dblTax.ToString("n2")
            lblResortFee.Text = dblTotalResortFee.ToString("n2")
            lblTotalDue.Text = dblTotalDue.ToString("c2")

        End If
    End Sub

    Private Sub CancelKeys(sender As Object, e As KeyPressEventArgs) _
        Handles txtRooms.KeyPress, txtNights.KeyPress, txtAdults.KeyPress, txtChildren.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
        e.KeyChar <> ControlChars.Back Then
            'cancel the key
            e.Handled = True
        End If

    End Sub

    Private Sub txtRooms_Enter(sender As Object, e As EventArgs) Handles txtRooms.Enter
        txtRooms.Select()
    End Sub

    Private Sub txtNights_Enter(sender As Object, e As EventArgs) Handles txtNights.Enter
        txtNights.Select()
    End Sub

    Private Sub txtAdults_Enter(sender As Object, e As EventArgs) Handles txtAdults.Enter
        txtAdults.Select()
    End Sub

    Private Sub txtChildren_Enter(sender As Object, e As EventArgs) Handles txtChildren.Enter
        txtChildren.Select()
    End Sub
End Class
