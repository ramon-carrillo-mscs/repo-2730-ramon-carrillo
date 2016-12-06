' Name:         Conversion Solution
' Purpose:      Convert a measurement to either centimeters or inches
' Programmer:   Ramon Carrillo on 12/5/16

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain



    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtMeasurement_Enter(sender As Object, e As EventArgs) Handles txtMeasurement.Enter
        txtMeasurement.SelectAll()
    End Sub

    Private Sub txtMeasurement_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMeasurement.KeyPress
        ' allow only numbers, the period, and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub InputChanged(sender As Object, e As EventArgs) _
        Handles txtMeasurement.TextChanged, radSubCentimeters.CheckedChanged, radSubInches.CheckedChanged,
        radFuncCentimeters.CheckedChanged, radFuncInches.CheckedChanged

        Dim dblMeasurement As Double = 0.0
        Dim dblResult As Double = 0.0

        Double.TryParse(txtMeasurement.Text, dblMeasurement)

        If radSubCentimeters.Checked Then
            calcSubCentimeters(dblMeasurement, dblResult)
        ElseIf radSubInches.Checked Then
            calcSubInches(dblMeasurement, dblResult)
        ElseIf radFuncCentimeters.Checked Then
            dblResult = calcFuncCentimeters(dblMeasurement)
        ElseIf radFuncInches.Checked Then
            dblResult = calcFuncInches(dblMeasurement)
        End If
        lblResult.Text = dblResult.ToString("n2")
    End Sub

    Private Sub calcSubCentimeters(ByVal dblMeas As Double, ByRef dblRes As Double)
        dblRes = dblMeas * 2.54
    End Sub

    Private Sub calcSubInches(ByVal dblMeas As Double, ByRef dblRes As Double)
        dblRes = dblMeas / 2.54
    End Sub

    Private Function calcFuncCentimeters(ByVal dblMeas As Double) As Double
        Dim dblRes As Double = dblMeas * 2.54
        Return dblRes
    End Function

    Private Function calcFuncInches(ByVal dblMeas As Double) As Double
        Dim dblRes As Double = dblMeas / 2.54
        Return dblRes
    End Function

    'Add planets to cboPlanets
    'Set selected item to Earth
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        cboPlanets.Items.Add("Earth")
        cboPlanets.Items.Add("Jupiter")
        cboPlanets.Items.Add("Mars")
        cboPlanets.Items.Add("Mercury")
        cboPlanets.Items.Add("Neptune")
        cboPlanets.Items.Add("Pluto")
        cboPlanets.Items.Add("Saturn")
        cboPlanets.Items.Add("Uranus")
        cboPlanets.Items.Add("Venus")
        cboPlanets.SelectedItem = "Earth"
    End Sub

    'Allow only numbers and the Backspace
    Private Sub txtEarthWeight_KeyPress(sender As Object, e As KeyPressEventArgs) _
        Handles txtEarthWeight.KeyPress

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    'Select all text in txtEarthWeight
    Private Sub txtEarthWeight_Enter(sender As Object, e As EventArgs) Handles txtEarthWeight.Enter
        txtEarthWeight.SelectAll()
    End Sub

    'Set dblGravity according to selected text in cboPlanets
    'Calculate and return weight
    Private Function calcWeightFunc(ByVal intWeight As Integer) As Double
        Dim dblGravity As Double

        Select Case cboPlanets.Text
            Case "Earth"
                dblGravity = 1.0
            Case "Jupiter"
                dblGravity = 2.34
            Case "Mars"
                dblGravity = 0.38
            Case "Mercury"
                dblGravity = 0.38
            Case "Neptune"
                dblGravity = 1.14
            Case "Pluto"
                dblGravity = 0.06
            Case "Saturn"
                dblGravity = 1.06
            Case "Uranus"
                dblGravity = 0.92
            Case "Venus"
                dblGravity = 0.91
        End Select

        Dim dblWeight As Double = intWeight * dblGravity
        Return dblWeight
    End Function

    'Set dblGravity according to selected text in cboPlanets
    'Calculate weight
    Private Sub calcWeightSub(ByVal intWeight As Integer, ByRef dblWeight As Double)
        Dim dblGravity As Double

        Select Case cboPlanets.Text
            Case "Earth"
                dblGravity = 1.0
            Case "Jupiter"
                dblGravity = 2.34
            Case "Mars"
                dblGravity = 0.38
            Case "Mercury"
                dblGravity = 0.38
            Case "Neptune"
                dblGravity = 1.14
            Case "Pluto"
                dblGravity = 0.06
            Case "Saturn"
                dblGravity = 1.06
            Case "Uranus"
                dblGravity = 0.92
            Case "Venus"
                dblGravity = 0.91
        End Select
        dblWeight = intWeight * dblGravity
    End Sub

    Private Sub txtEarthWeight_TextChanged(sender As Object, e As EventArgs) Handles txtEarthWeight.TextChanged,
        rdoPlanetFunc.CheckedChanged, rdoPlanetSub.CheckedChanged, cboPlanets.SelectedIndexChanged
        Dim intWeight As Integer
        Dim dblWeight As Double
        'Parse value in txtEarthWeight
        Integer.TryParse(txtEarthWeight.Text, intWeight)

        'If user selected "sub" radio button
        '	Use Sub to calculate weight
        'ElseIf user selected "func" radio button
        '	Use Func to calculate weight
        If rdoPlanetSub.Checked Then
            calcWeightSub(intWeight, dblWeight)
        ElseIf rdoPlanetFunc.Checked Then
            dblWeight = calcWeightFunc(intWeight)
        End If

        lblWeight.Text = dblWeight.ToString("n2")
    End Sub

End Class
