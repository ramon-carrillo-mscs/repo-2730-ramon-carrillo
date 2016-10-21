' Name:	Ch4 Lesson B, If statements, message boxes
' Purpose: Currency, Tea, Electric, Quotient
' Programmer: Ramon Carrillo on 10/17/2016




Public Class Form1
    Private Sub btneq_Click(sender As Object, e As EventArgs) Handles btneq.Click

        ' vonver American dollars to the Euro, the
        ' British pound, and the South African rand


        Const dblERURO_RATE As Double = 0.9
        Const dblPOUND_RATE As Double = 0.79
        Const dblRAND_RATE As Double = 13.89
        Dim dblAmDollar As Double
        Dim dblEuro As Double
        Dim dblPound As Double
        Dim dblRand As Double

        lblEuros.Text = String.Empty
        lblPounds.Text = String.Empty
        lblRand.Text = String.Empty

        If txtAmDollar.Text = String.Empty Then
            MessageBox.Show("Please enter the number of American dollars",
            "Currency Converter", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Double.TryParse(txtAmDollar.Text, dblAmDollar)
            Double.TryParse(lblEuros.Text, dblEuro)
            Double.TryParse(lblPounds.Text, dblPound)
            Double.TryParse(lblRand.Text, dblRand)

            dblEuro = dblAmDollar * dblERURO_RATE
            dblPound = dblAmDollar * dblPOUND_RATE
            dblRand = dblAmDollar * dblRAND_RATE

            lblEuros.Text = dblEuro.ToString("c2")
            lblPounds.Text = dblPound.ToString("c2")
            lblRand.Text = dblRand.ToString("c2")

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalTea.Click

        Dim dblPound As Double
        Dim dblPrice As Double
        Dim dblTotaldue As Double
        Const dblShipping As Double = 15



        If MessageBox.Show("Charge shipping?", "Shipping",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) =
                           DialogResult.Yes Then

            Double.TryParse(txtOrder.Text, dblPound)
            Double.TryParse(txtPrice.Text, dblPrice)

            dblTotaldue = (dblPound * dblPrice) + dblShipping

            lblTotalDue.Text = dblTotaldue.ToString("c2")

        Else
            Double.TryParse(txtOrder.Text, dblPound)
            Double.TryParse(txtPrice.Text, dblPrice)

            dblTotaldue = (dblPound * dblPrice)

            lblTotalDue.Text = dblTotaldue.ToString("c2")


        End If

    End Sub

    Private Sub btnCalElectric_Click(sender As Object, e As EventArgs) Handles btnCalElectric.Click

        Dim dblPrevious As Double
        Dim dblCurrent As Double
        Dim dblBill As Double
        Const dblCharge As Double = 0.13

        If txtPrevious.Text > txtCurrent.Text Then
            MessageBox.Show("Current amount has to be greater then the previous amount",
                          "Triple Electric", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf txtPrevious.Text = String.Empty Or txtCurrent.Text = String.Empty Then
            MessageBox.Show("Current amount has to be greater then the previous amount",
                          "Triple Electric", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else

            Double.TryParse(txtPrevious.Text, dblPrevious)
            Double.TryParse(txtCurrent.Text, dblCurrent)

            dblBill = (dblCurrent - dblPrevious) * dblCharge

            lblMonthlyBill.Text = dblBill.ToString("c2")

        End If



    End Sub

    Private Sub btnCalAnswer_Click(sender As Object, e As EventArgs) Handles btnCalAnswer.Click

        Dim dblNum1 As Double
        Dim dblNum2 As Double
        Dim dblAnswer As Double

        Integer.TryParse(txtNum1.Text, dblNum1)
        Integer.TryParse(txtNum2.Text, dblNum2)



        If dblNum2 > dblNum1 Then
            Dim intTemp As Integer
            intTemp = dblNum2
            dblNum2 = dblNum1
            dblNum1 = intTemp

            dblAnswer = dblNum1 / dblNum2

            lblAnswer.Text = dblAnswer.ToString("n2")

        ElseIf txtNum2.Text = 0 Then
            MessageBox.Show("Cannot divide by 0",
                         "Calcultor", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            dblAnswer = dblNum1 / dblNum2

            lblAnswer.Text = dblAnswer.ToString("n2")


        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
