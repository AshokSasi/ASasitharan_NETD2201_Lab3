﻿'Name: Ashok Sasitharan 100745484
'Date: Feb 20 2020
'Description: This program takes in integers that represents shipped units for 3 employees 
'for 7 days and calculates the average for each employee and the overall total average.

Option Strict On
Public Class frmAverageUnitsShipped
    'Global Variables
    Dim dayCount As Integer = 0
    Dim employeeNum As Integer = 0
    Dim unitsArray(2, 6) As Integer
    Dim totalAverage As Double = 0
    Dim textboxArray() As TextBox
    Dim outputLabelArray() As Label
    Dim totalUnits As Integer
    Dim averageUnits As Double
    Const maxDays = 7
    Const totalEmployees = 3

    ''' <summary>
    ''' The exit button closes the application when clicked
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    ''' <summary>
    ''' when the form loads the textbox and output label arrays are created and the employee 1 label is bolded
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmAverageUnitsShipped_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'textbox array
        textboxArray = {txtUnitDisplay1, txtUnitDisplay2, txtUnitDisplay3}
        'output label array
        outputLabelArray = {lblEmployee1Average, lblEmployee2Average, lblEmployee3Average}
        'set the employee 1 label to bold
        lblEmployee1.Font = New Font(lblEmployee1.Font, FontStyle.Bold)
    End Sub

    ''' <summary>
    ''' The enter button that validates and enters the users input as well as calculates the employee and total average
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        'run if current employee is 2
        If employeeNum + 1 = 2 Then
            'set employee 2 label to bold
            lblEmployee2.Font = New Font(lblEmployee2.Font, FontStyle.Bold)
            'unbold employee 1 label
            lblEmployee1.Font = New Font(lblEmployee1.Font, FontStyle.Regular)
            'unbold employee 3 label
            lblEmployee3.Font = New Font(lblEmployee3.Font, FontStyle.Regular)

            'run if current employee is 3
        ElseIf employeeNum + 1 = 3 Then
            'set employee 3 label to bold
            lblEmployee3.Font = New Font(lblEmployee3.Font, FontStyle.Bold)
            'unbold employee label 2
            lblEmployee2.Font = New Font(lblEmployee2.Font, FontStyle.Regular)
            'unbold employee label 1
            lblEmployee1.Font = New Font(lblEmployee1.Font, FontStyle.Regular)
        End If

        'run if input is an integer
        If Integer.TryParse(txtUnitsInput.Text, unitsArray(employeeNum, dayCount)) Then
            'run if the inputted number is greater than or equal to  0 and less than or equal to 5000
            If unitsArray(employeeNum, dayCount) >= 0 And unitsArray(employeeNum, dayCount) <= 5000 Then
                ' Output the new temperature value
                textboxArray(employeeNum).Text &= unitsArray(employeeNum, dayCount) & vbCrLf
                'increment day by one
                dayCount += 1
                'output the current day in label
                lblDay.Text = "Day " & (dayCount + 1)
                'clear the unit input textbox
                txtUnitsInput.Clear()

                'run if the current day is 7
                If dayCount = maxDays Then
                    'set total units to 0
                    totalUnits = 0
                    'for loop that loops through the array for the current employee
                    For count As Integer = 0 To maxDays - 1
                        'add the number to total units
                        totalUnits += unitsArray(employeeNum, count)
                    Next

                    'calculate the average for the emplyee
                    averageUnits = Math.Round(totalUnits / maxDays, 2)
                    'display the employees average in textbox. To string shows trailing zeros
                    outputLabelArray(employeeNum).Text = "Average: " & averageUnits.ToString("0.00")

                    ' Increment the employee number up by 1
                    employeeNum += 1

                    ' Reset the day counter to 0
                    dayCount = 0
                    'display the day in day label
                    lblDay.Text = "Day " & (dayCount + 1)

                    'run if the employee number is 3
                    If employeeNum = totalEmployees Then
                        'set total units to 0
                        totalUnits = 0

                        'run through the array
                        For Each dayCount In unitsArray
                            'add up all of the units into totalUnits
                            totalUnits += dayCount
                        Next

                        'calculate the total average
                        totalAverage = Math.Round(totalUnits / unitsArray.Length, 2)
                        'display the total average in the totalAverage label
                        lblTotalAverage.Text = "Average per day: " & totalAverage.ToString("0.00")
                        'print done in the day label
                        lblDay.Text = "Done."
                        'set employee 1 label to bold
                        lblEmployee1.Font = New Font(lblEmployee1.Font, FontStyle.Bold)
                        'unbold employee 2
                        lblEmployee2.Font = New Font(lblEmployee2.Font, FontStyle.Regular)
                        'unbold employee 3
                        lblEmployee3.Font = New Font(lblEmployee3.Font, FontStyle.Regular)

                        ' disable the unit input textbox
                        txtUnitsInput.Enabled = False
                        'disable the enter button
                        btnEnter.Enabled = False
                        'set the focus to the reset button
                        btnReset.Focus()


                    End If

                End If

                'run if the input is not between 0 and 5000
            Else
                'display error message
                MessageBox.Show("Units entered must be between 0 and 5000 inclusive.")
                'select the input in the input textbox
                txtUnitsInput.SelectAll()
                'set the focus to the input textbox
                txtUnitsInput.Focus()
            End If
            'run if the input is not numeric
        Else
            'display error message
            MessageBox.Show("Units must be entered as a whole number")
            'select the input in the input textbox
            txtUnitsInput.SelectAll()
            'set the focus to the input textbox
            txtUnitsInput.Focus()
        End If



    End Sub

    ''' <summary>
    ''' The reset button resets the form to its defualt state by clearing textboxes and labels
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click


        'set all of the average output labels to empty
        lblEmployee1Average.Text = String.Empty
        lblEmployee2Average.Text = String.Empty
        lblEmployee3Average.Text = String.Empty
        lblTotalAverage.Text = String.Empty


        'reset variables to have default values
        dayCount = 0
        employeeNum = 0
        lblDay.Text = "Day " & (dayCount + 1)
        totalAverage = 0
        averageUnits = 0

        'clear all of the textboxes
        txtUnitsInput.Clear()
        txtUnitDisplay1.Clear()
        txtUnitDisplay2.Clear()
        txtUnitDisplay3.Clear()


        ' set unit input textbox to enabled
        txtUnitsInput.Enabled = True
        'set enter button to enabled
        btnEnter.Enabled = True
        'set the employee 1 label to bold
        lblEmployee1.Font = New Font(lblEmployee1.Font, FontStyle.Bold)
        'unbold employee 2 label
        lblEmployee2.Font = New Font(lblEmployee2.Font, FontStyle.Regular)
        'unbold employee 3 label
        lblEmployee3.Font = New Font(lblEmployee3.Font, FontStyle.Regular)
        ' Set focus to unit input textbox
        txtUnitsInput.Focus()

    End Sub
End Class
