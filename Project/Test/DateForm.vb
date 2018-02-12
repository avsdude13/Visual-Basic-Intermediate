Public Class DateForm
    Private Sub MonthListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MonthListBox.SelectedIndexChanged
        Dim Month As String = MonthListBox.Text

        Select Case Month
            Case "January", "March", "May", "July", "August", "October", "December"
                OutputTextBox.Text = "31"
            Case "April", "June", "September", "November"
                OutputTextBox.Text = "30"
            Case "February"
                OutputTextBox.Text = "28"
        End Select

    End Sub

    Private Sub DateForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MonthListBox.Items.Add("January")
        MonthListBox.Items.Add("February")
        MonthListBox.Items.Add("March")
        MonthListBox.Items.Add("April")
        MonthListBox.Items.Add("May")
        MonthListBox.Items.Add("June")
        MonthListBox.Items.Add("July")
        MonthListBox.Items.Add("August")
        MonthListBox.Items.Add("September")
        MonthListBox.Items.Add("October")
        MonthListBox.Items.Add("November")
        MonthListBox.Items.Add("December")
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