Public Class TemperatureForm
    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        If (ToCelRadioButton.Checked) Then
            ResultTextBox.Text = CStr(FtoC(Double.Parse(EntryTextBox.Text)))
        ElseIf (ToFarRadioButton.Checked) Then
            ResultTextBox.Text = CStr(CtoF(Double.Parse(EntryTextBox.Text)))
        Else
            MessageBox.Show("Missing Entry. Please try again.", "Error")
        End If
    End Sub

    Function CtoF(Ctemp As Double) As Double
        Return Ctemp * (9 / 5) + 32
    End Function

    Function FtoC(Ftemp As Double) As Double
        Return (Ftemp - 32) * (5 / 9)
    End Function

    Private Sub ToCelRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles ToCelRadioButton.CheckedChanged
        ToFarRadioButton.Checked = False
    End Sub

    Private Sub ToFarRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles ToFarRadioButton.CheckedChanged
        ToCelRadioButton.Checked = False
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