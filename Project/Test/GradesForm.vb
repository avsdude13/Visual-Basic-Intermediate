Public Class GradesForm
    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        Dim Entry As Double = 0
        If (EntryTextBox.Text = "") Then
            MessageBox.Show("Missing Entry")
        Else
            Entry = Double.Parse(EntryTextBox.Text)
        End If
        Dim Result As String = ""

        Select Case Entry
            Case Is >= 90
                ResultTextBox.Text = "You currently have an A"
            Case 80 To 90
                ResultTextBox.Text = "You currently have a B"
            Case 70 To 80
                ResultTextBox.Text = "You currently have a C"
            Case 60 To 70
                ResultTextBox.Text = "You currently have a D"
            Case Is < 60
                ResultTextBox.Text = "You are currently failing"
        End Select
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