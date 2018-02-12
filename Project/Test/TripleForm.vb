Public Class TripleForm

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        Dim FirstDigit, SecondDigit As Double

        GetNumbers(FirstDigit, SecondDigit)

        DisplayListBox.Items.Add("Original Number 1 was " & FirstDigit)
        DisplayListBox.Items.Add("Original Number 2 was " & SecondDigit)

        Triple(FirstDigit, SecondDigit)
    End Sub

    Sub GetNumbers(ByRef Digit1 As Double, ByRef Digit2 As Double)
        If (FirstDigitTextBox.Text = "" Or SecondDigitTextBox.Text = "") Then
            MessageBox.Show("Missing Entry")
        Else
            Digit1 = FirstDigitTextBox.Text
            Digit2 = SecondDigitTextBox.Text
        End If
    End Sub

    Sub Triple(Digit1 As Double, Digit2 As Double)
        Digit1 = Digit1 * 3
        Digit2 = Digit2 * 3
        DisplayListBox.Items.Add("New Number 1 is " & Digit1)
        DisplayListBox.Items.Add("New Number 2 is " & Digit2)
    End Sub

    Private Sub SelectorToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SelectorToolStripMenuItem.Click
        SelectorForm.Show()
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        about.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class