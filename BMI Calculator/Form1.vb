'Program BMI Calculator Final Project
' Wesley Barron

Option Strict On

Public Class frmBMI
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Variable declerations
        Dim strWeight As String = txtBoxWeight.Text
        Dim decWeight As Decimal
        Dim strFeet As String = txtBoxFeet.Text
        Dim strInches As String = txtBoxInches.Text
        Dim decFeet As Decimal
        Dim decInches As Decimal
        Dim decHeight As Decimal
        Dim decTotalHeight As Decimal
        Dim _cintCoversionFactor As Integer = 703
        Dim bmiReturn As Decimal
        Dim strAge As String = comBoxAge.Text
        Dim fatCategory As String
        'Start of Exception handling
        Try
            'Checking to see if the user inputs are in the correct format
            If IsNumeric(strFeet) And IsNumeric(strInches) And IsNumeric(strWeight) Then
                decFeet = Convert.ToDecimal(strFeet)
                decInches = Convert.ToDecimal(strInches)
                decWeight = Convert.ToDecimal(strWeight)
                'Checking to make sure the user values are greater than 0
                If decFeet > 0 Or decInches > 0 Then
                    decHeight = (decFeet * 12) + decInches
                    decTotalHeight = decHeight * decHeight
                    bmiReturn = (decWeight / decTotalHeight) * _cintCoversionFactor
                    'Checking for age 18 and up
                    If Convert.ToInt32(strAge) > 17 Then
                        'Checking BMI conditions
                        If bmiReturn < 16 Then
                            fatCategory = "Severe Underweight"
                        ElseIf bmiReturn > 16 And bmiReturn < 18.6 Then
                            fatCategory = "Underweight"
                        ElseIf bmiReturn > 18.5 And bmiReturn < 26 Then
                            fatCategory = "Normal"
                        ElseIf bmiReturn > 25 And bmiReturn < 31 Then
                            fatCategory = "Overweight"
                        ElseIf bmiReturn > 30 Then
                            fatCategory = "Obese"
                        Else
                            fatCategory = "Error"
                            MsgBox("Could not compute fat category", , "Error")
                        End If
                        lblResult.Text = "Your total BMI is " & bmiReturn.ToString("N") & " (Height: " & decHeight.ToString("N") & " in.)" & vbCrLf & "This is " & fatCategory & " for the age of " & strAge
                        clearFields()
                    End If
                Else
                    MsgBox("Please enter a number greater than 0", , "Error")
                End If
            Else
                MsgBox("Please enter a valid number greater than 0", , "Error")
            End If
        Catch Exception As FormatException
            MsgBox("Please enter a valid number", , Exception)
        Catch Exception As OverflowException
            MsgBox("Please enter a reasonable number", , Exception)
        Catch Exception As SystemException
            MsgBox("Entry invalid. Please enter a valid number", , Exception)
        End Try

    End Sub

    Private Sub frmBMI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'For Loop for the age dropdown
        For i As Integer = 18 To 120
            comBoxAge.Items.Add(i)
        Next
        lblResult.Text = ""
    End Sub

    'Clear fields procedure
    Private Sub clearFields()
        comBoxAge.Text = "Age"
        txtBoxFeet.Text = "Feet"
        txtBoxInches.Text = "Inches"
        txtBoxWeight.Text = "Weight"
        comBoxGender.Text = "Gender"
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clearFields()
        lblResult.Text = ""
    End Sub

    'Clears the placeholder when clicked
    Private Sub txtBoxFeet_Click(sender As Object, e As EventArgs) Handles txtBoxFeet.Click
        txtBoxFeet.Text = ""
    End Sub

    'Clears the placeholder when clicked
    Private Sub txtBoxInches_Click(sender As Object, e As EventArgs) Handles txtBoxInches.Click
        txtBoxInches.Text = ""
    End Sub

    'Clears the placeholder when clicked
    Private Sub txtBoxWeight_Click(sender As Object, e As EventArgs) Handles txtBoxWeight.Click
        txtBoxWeight.Text = ""
    End Sub

End Class
