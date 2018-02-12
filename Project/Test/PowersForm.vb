Public Class PowersForm

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        If (InputTextBox.Text = "") Then
            MessageBox.Show("Please enter a base value.")
        Else
            Powers(Double.Parse(InputTextBox.Text))
        End If
    End Sub

    Sub Powers(value As Double)
        Dim power As Integer = 0

        Do While power <= 10
            ResultListBox.Items.Add(value ^ power)
            power += 1
        Loop
    End Sub

    Private Sub IncrementalButton_Click(sender As Object, e As EventArgs) Handles IncrementalButton.Click
        For i As Integer = 1 To 10
            ResultListBox.Items.Add(CStr(i ^ (i + 1)))
        Next
    End Sub

    Private Sub DivisibleButton_Click(sender As Object, e As EventArgs) Handles DivisibleButton.Click
        For i As Integer = 3 To InputTextBox.Text Step 3
            If InputTextBox.Text Mod i = 0 Then
                ResultListBox.Items.Add(i)
            End If
        Next
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