' Name:         Multiplication Project
' Purpose:      Display a multiplication table that shows
'               the multiplicand, multiplier, and product
' Programmer:   Ramon Carrillo on 11/29/16

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Const dblTax As Double = 0.05

    Private Sub btnDoLoop_Click(sender As Object, e As EventArgs) Handles btnDoLoop.Click
        ' displays a multiplication table
        Dim number, product, count As Integer
        count = 1
        lstMultTable.Items.Clear()
        lstMultTable.Items.Add("For loop:")
        Integer.TryParse(txtNumber.Text, number)
        'Do loop
        Do While count >= 1 AndAlso count < 10
            product = number * count
            lstMultTable.Items.Add("     " & number.ToString() & " * " & count.ToString() & " = " & product.ToString())
            count = count + 1
        Loop
        'Add strOutput to ListBox

    End Sub

    Private Sub btnForNext_Click(sender As Object, e As EventArgs) Handles btnForNext.Click
        ' displays a multiplication table
        Dim number, product, count As Integer
        count = 1
        lstMultTable.Items.Clear()
        lstMultTable.Items.Add("For loop:")
        Integer.TryParse(txtNumber.Text, number)
        'For loop
        For i As Integer = 1 To 9
            product = number * count
            lstMultTable.Items.Add("     " & number.ToString() & " * " & count.ToString() & " = " & product.ToString())
            count = count + 1
        Next i
        'Add strOutput to ListBox


    End Sub

    Private Sub txtNumber_Enter(sender As Object, e As EventArgs) Handles txtNumber.Enter
        txtNumber.SelectAll()
    End Sub

    Private Sub txtNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumber.KeyPress
        ' allows only numbers and the Backspace

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNumber_TextChanged(sender As Object, e As EventArgs) Handles txtNumber.TextChanged
        'lstMultTable.Text = String.Empty
        lstMultTable.Items.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strSelectedItem As String
        Dim dblSelectedPrice As Double
        Dim dblTotalPrice As Double
        Dim dblPreTaxTotal As Double = 0
        Dim dblTaxAmount As Double


        For intLoadNum As Integer = 1 To 4
            lstPrices.Items.Add(intLoadNum.ToString("N2"))
        Next



        For intIndex As Integer = 0 To lstPrices.Items.Count - 1
            lstPrices.SelectedIndex = intIndex
            strSelectedItem = lstPrices.SelectedItem.ToString()
            Double.TryParse(strSelectedItem.ToString, dblSelectedPrice)
            dblPreTaxTotal = dblSelectedPrice + dblPreTaxTotal
        Next


        lblPretax.Text = dblPreTaxTotal.ToString("C2")
        dblTaxAmount = (dblPreTaxTotal * dblTax)
        lblTax.Text = dblTaxAmount.ToString("C2")
        dblTotalPrice = dblTaxAmount + dblPreTaxTotal
        lblTotal.Text = dblTotalPrice.ToString("C2")
        lstPrices.SelectedIndex = -1

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim strPrice As String = "Enter a Price" & ControlChars.NewLine &
            "Valid prices: 1.00 to 9.99"
        Dim strPrice2 As String = "Enter a Price" & ControlChars.NewLine &
            "Valid prices: 1.00 to 9.99"
        Dim strValid As String = "Price Entry"
        Dim strInvalid As String = "Invalid Price"
        Dim dblPrice As Double
        Dim dblPreTaxTotal As Double
        Dim dblTotalPrice As Double
        Dim strSelectedItem As String
        Dim dblSelectedPrice As Double
        Dim dblTaxAmount As Double


        strPrice = InputBox(strPrice, strValid, "0")
        Double.TryParse(strPrice, dblPrice)


        Do While dblPrice < 1 OrElse dblPrice > 9.99
            strPrice = InputBox(strPrice2, strInvalid, "0")
            Double.TryParse(strPrice, dblPrice)
        Loop


        lstPrices.Items.Add(dblPrice.ToString("N2"))


        For intIndex As Integer = 0 To lstPrices.Items.Count - 1
            lstPrices.SelectedIndex = intIndex
            strSelectedItem = lstPrices.SelectedItem.ToString()
            Double.TryParse(strSelectedItem.ToString, dblSelectedPrice)
            dblPreTaxTotal = dblSelectedPrice + dblPreTaxTotal
        Next



        lblPretax.Text = dblPreTaxTotal.ToString("C2")
        dblTaxAmount = (dblPreTaxTotal * dblTax)
        lblTax.Text = dblTaxAmount.ToString
        dblTotalPrice = dblTaxAmount + dblPreTaxTotal
        lblTotal.Text = dblTotalPrice.ToString("C2")
        lstPrices.SelectedIndex = -1


    End Sub
    Dim strSelectedItem As String
    Dim dblSelectedPrice As Double
    Dim dblTotalPrice As Double
    Dim dblPreTaxTotal As Double = 0
    Dim dblTaxAmount As Double

    Private Sub lstPrices_KeyDown(sender As Object, e As KeyEventArgs) Handles lstPrices.KeyDown
        If lstPrices.SelectedIndex >= 0 AndAlso (e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back) Then
            lstPrices.Items.RemoveAt(lstPrices.SelectedIndex)

            For intIndex As Integer = 0 To lstPrices.Items.Count - 1
                lstPrices.SelectedIndex = intIndex
                strSelectedItem = lstPrices.SelectedItem.ToString()
                Double.TryParse(strSelectedItem.ToString, dblSelectedPrice)
                dblPreTaxTotal = dblSelectedPrice + dblPreTaxTotal
            Next


            lblPretax.Text = dblPreTaxTotal.ToString("C2")
            dblTaxAmount = (dblPreTaxTotal * dblTax)
            lblTax.Text = dblTaxAmount.ToString("C2")
            dblTotalPrice = dblTaxAmount + dblPreTaxTotal
            lblTotal.Text = dblTotalPrice.ToString("C2")
            lstPrices.SelectedIndex = -1

        End If


    End Sub
End Class
