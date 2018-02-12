Public Class WaltDisneyWorld

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        Dim days As Integer = CInt(DaysTextBox.Text)
        Dim adults As Integer = CInt(AdultsTextBox.Text)
        Dim children As Integer = CInt(ChildrenTextBox.Text)
        Dim total As Integer

        If (days = 1 Or days = 2) Then
            total = (adults * 101) + (children * 96)
        ElseIf (days = 3) Then
            total = (adults * 96) + (children * 91)
        ElseIf (days = 4) Then
            total = (adults * 80) + (children * 75)
        ElseIf (days = 5 Or days = 6) Then
            total = (adults * 60) + (children * 55)
        Else
            total = (adults * 45) + (children * 40)
        End If

        TicketPriceTextBox.Text = FormatCurrency(total)
    End Sub
End Class