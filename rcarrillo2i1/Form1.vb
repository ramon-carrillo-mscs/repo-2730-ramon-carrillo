Public Class Form1
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        '#03: Insert

        Dim strWord As String = txt03RemoveInsert.Text
        strWord = strWord.Remove(0, 1)
        strWord = strWord.Insert(0, "cr")
        lbl03RemoveInsert.Text = strWord

        '#04: Substring:

        Dim strItem As String
        Dim strColor As String
        strItem = "YMBlueX"
        strColor = strItem.Substring(2, 4)
        lbl04Substring.Text = strColor

        '#05a Length:

        Dim strMsg As String
        strMsg = txt05aLength.Text
        lbl05aLength.Text = strMsg.Length

        '#05b Trim:
        Dim strState As String
        strState = txt05bTrim.Text.Trim
        lbl05bTrim.Text = strState

        '#05c Insert And Remove:
        Dim strWord2 As String = txt05cRemoveInsert.Text
        strWord2 = strWord2.Remove(1, 1)
        strWord2 = strWord2.Insert(1, "rit")
        lbl05cRemoveInsert.Text = strWord2

        '#05d Insert:
        Dim strWord3 As String = txt05dInsert.Text
        strWord3 = strWord3.Insert(0, "Mon")
        lbl05dInsert.Text = strWord3

        '#05e Pad:
        Dim strPay As String
        Dim decNet As Decimal
        Decimal.TryParse(txt05ePad.Text, decNet)
        strPay = decNet.ToString("n2")
        strPay = strPay.PadLeft(10, "*"c)
        lbl05ePad.Text = strPay

        '#06 Remove:
        Dim strAmount As String = txt06Remove.Text
        strAmount = strAmount.Remove(1, 1)
        strAmount = strAmount.Remove(4, 1)
        lbl06Remove.Text = strAmount

        '#07 Contains:
        Dim strAdress As String = "Jefferson Street"
        Dim blnIsContains As Boolean
        Dim strBox As String
        strBox = txt07Contains.Text
        blnIsContains = strAdress.ToUpper.ToLower.Contains(strBox)
        lbl07Contains.Text = blnIsContains


        '#12 Len/Remove:
        Dim dblNumber As Double = txt12LenRemove.Text



    End Sub
End Class
