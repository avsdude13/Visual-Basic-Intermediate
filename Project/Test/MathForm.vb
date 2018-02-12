Public Class MathForm
    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        If (InputTextBox1.Text = "" Or InputTextBox2.Text = "") Then
            MessageBox.Show("Please enter two values.")
        Else
            ResultTextBox.Text = CStr(Exponential(Double.Parse(InputTextBox1.Text), Double.Parse(InputTextBox2.Text)))
        End If
    End Sub

    Function Exponential(Value1 As Double, Value2 As Double) As Double
        Return (Value1 ^ 3 + Value2 ^ 2)
    End Function

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