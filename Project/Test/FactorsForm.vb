Public Class FactorsForm

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        Dim result As Integer
        Dim entry As Integer = Integer.Parse(InputTextBox.Text)
        OutputListBox.Items.Clear()

        For i As Integer = 1 To entry
            If entry Mod i = 0 Then
                result = (entry / i)
                OutputListBox.Items.Add(i & " and " & result)
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