Public Class RTD_Costs

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        Dim PerDay As Integer = CInt(PerDayTextBox.Text)
        Dim PerMonth As Integer = CInt(PerMonthTextBox.Text)
        Dim Total As Double = 0

        Select Case PerDay
            Case Is <= 2 And PerMonth < 22
                If ((PerDay * PerMonth) Mod 10 = 0) Then
                    Total = 23.5 * ((PerDay * PerMonth) \ 10)
                Else
                    Total = 23.5 * (((PerDay * PerMonth) \ 10) + 1)
                End If
            Case Is = 2 And PerMonth >= 22
                Total = 99.0
            Case Is >= 3 And PerMonth < 20
                Total = 5.2 * PerMonth
            Case Is >= 3 And PerMonth >= 20
                Total = 99.0
        End Select

        TotalTextBox.Text = CStr(FormatCurrency(Total))
    End Sub
End Class
