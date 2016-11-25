

' Programmer: Ramon Carrillo 11/24/16

Option Explicit On
Option Infer Off
Option Strict On


Public Class Form1
    Private Sub pretestDoWhileButton_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lblEven.Text = "Pretest Do While" & ControlChars.NewLine
        Dim i As Integer = 2
        Do While i <= 20
            lblEven.Text = lblEven.Text & i.ToString & ControlChars.NewLine
            i += 2
        Loop
    End Sub

    Private Sub pretestDoUntilButton_Click(sender As Object, e As EventArgs) Handles Button2.Click
        lblEven.Text = "Pretest Do Until" & ControlChars.NewLine
        Dim i As Integer = 2
        Do Until i > 20
            lblEven.Text = lblEven.Text & i.ToString & ControlChars.NewLine
            i += 2
        Loop
    End Sub

    Private Sub posttestDoWhileButton_Click(sender As Object, e As EventArgs) Handles Button3.Click
        lblEven.Text = "Posttest Do While" & ControlChars.NewLine
        Dim i As Integer = 2
        Do
            lblEven.Text = lblEven.Text & i.ToString & ControlChars.NewLine
            i += 2
        Loop While i <= 20
    End Sub

    Private Sub posttestDoUntillButton_Click(sender As Object, e As EventArgs) Handles Button4.Click
        lblEven.Text = "Posttest Do Until" & ControlChars.NewLine
        Dim i As Integer = 2
        Do
            lblEven.Text = lblEven.Text & i.ToString & ControlChars.NewLine
            i += 2
        Loop Until i > 20
    End Sub

    Private Sub pretestFor_Click(sender As Object, e As EventArgs) Handles Button5.Click
        lblEven.Text = "Pretest For" & ControlChars.NewLine
        Dim i As Integer = 2
        For i = 2 To 20 Step 2
            lblEven.Text = lblEven.Text & i.ToString & ControlChars.NewLine
        Next
    End Sub

    Private Sub btnSumDoWhile_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'Clear screen
        lblList.Text = String.Empty
        lblCount.Text = String.Empty
        lblAvg.Text = String.Empty

        'calculates average
        Const strPROMPT As String =
            "Enter a number. " &
            ControlChars.NewLine &
            "Click Cancel or leave blank to end"
        Const strTITLE As String = "Number Entry"
        Dim strNum As String
        Dim intNum As Integer
        Dim intSum As Integer
        Dim intCount As Integer
        Dim dblAvg As Double

        'get first sales amount
        strNum = InputBox(strPROMPT, strTITLE, "0")

        ' *** Begin loop here: repeat as long as input is not empty
        Do While strNum <> String.Empty
            'convert the input to a number
            Int32.TryParse(strNum, intNum)

            'display the input in the text box
            lblList.Text = lblList.Text &
                 intNum.ToString & ControlChars.NewLine

            'update the counter and accumulator
            intCount = intCount + 1
            intSum = intSum + intNum

            '***Update control variable
            strNum = InputBox(strPROMPT, strTITLE)

            '*** End loop here
        Loop

        lblCount.Text = intCount.ToString

        'verify that the counter is greater than 0
        If intCount > 0 Then
            dblAvg = intSum / intCount
            lblAvg.Text = dblAvg.ToString("N2")
        Else
            lblAvg.Text = "N/A"
        End If
    End Sub

    Private Sub btnSumLoopUntil_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'Clear screen
        lblList.Text = String.Empty
        lblCount.Text = String.Empty
        lblAvg.Text = String.Empty

        'calculates average
        Const strPROMPT As String =
            "Enter a number. " &
            ControlChars.NewLine &
            "Click Cancel or leave blank to end"
        Const strTITLE As String = "Number Entry"
        Dim strNum As String
        Dim intNum As Integer
        Dim intSum As Integer
        Dim intCount As Integer
        Dim dblAvg As Double

        'get first sales amount
        strNum = InputBox(strPROMPT, strTITLE, "0")

        ' *** Begin loop here: repeat as long as input is not empty
        Do
            'convert the input to a number
            Int32.TryParse(strNum, intNum)

            'display the input in the text box
            lblList.Text = lblList.Text &
                 intNum.ToString & ControlChars.NewLine

            'update the counter and accumulator
            intCount = intCount + 1
            intSum = intSum + intNum

            '***Update control variable
            strNum = InputBox(strPROMPT, strTITLE)

            '*** End loop here
        Loop Until strNum = String.Empty

        lblCount.Text = intCount.ToString

        'verify that the counter is greater than 0
        If intCount > 0 Then
            dblAvg = intSum / intCount
            lblAvg.Text = dblAvg.ToString("N2")
        Else
            lblAvg.Text = "N/A"
        End If
    End Sub

    Private Sub btnSumForNext_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Const strCOUNT As String = "Enter count of values."
        Const strCOUNTTITLE As String = "Count"
        Const strPROMPT As String = "Enter an amount."
        Const strTITLE As String = "Sales Entry"
        Dim strNum As String
        Dim strInputNum As String
        Dim decSales As Decimal
        Dim intCount As Integer
        Dim intNum As Integer
        Dim decNum As Decimal
        Dim decAvg As Decimal

        'get first sales amount
        strNum = InputBox(strCOUNT, strCOUNTTITLE, "0")


        Integer.TryParse(strNum, intCount)

        ' *** Begin loop here: repeat as long as input is not empty
        For intX As Integer = 1 To intCount

            '***Update control variable
            strInputNum = InputBox(strPROMPT, strTITLE)

            'convert the input to a number
            Decimal.TryParse(strInputNum, decSales)

            'display the input in the text box
            lblList.Text = lblList.Text & decSales.ToString("N2") & ControlChars.NewLine

            'update the counter and accumulator
            intNum = intNum + 1
            decNum = decNum + decSales


            '*** End loop here
        Next intX

        lblCount.Text = intCount.ToString

        'verify that the counter is greater than 0
        If intNum > 0 Then
            decAvg = decNum / intNum
            lblAvg.Text = decAvg.ToString("N2")
        Else
            lblAvg.Text = "N/A"
        End If
    End Sub
End Class
