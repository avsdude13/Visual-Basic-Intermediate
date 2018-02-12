Public Class SelectorForm
    Private Sub SelectionBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SelectionBox.SelectedIndexChanged
        Dim Selector As String = SelectionBox.Text

        Select Case Selector
            Case "About"
                about.Show()
            Case "Calculator"
                CalculatorForm.Show()
            Case "Name"
                NameForm.Show()
            Case "Temperature"
                TemperatureForm.Show()
            Case "Grades"
                GradesForm.Show()
            Case "Date"
                DateForm.Show()
            Case "Math"
                MathForm.Show()
            Case "Triple"
                TripleForm.Show()
            Case "Powers"
                PowersForm.Show()
            Case "Password"
                PasswordForm.Show()
            Case "Factors"
                FactorsForm.Show()
            Case "Country"
                CountryForm.Show()
            Case "Presidents"
                PresidentsForm.Show()
            Case "United Nations"
                UnitedNationsForm.Show()
            Case "File Reader/Writer"
                FileReadWriteForm.Show()
        End Select
    End Sub

    Private Sub Selector_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SelectionBox.Items.Add("About")
        SelectionBox.Items.Add("Calculator")
        SelectionBox.Items.Add("Name")
        SelectionBox.Items.Add("Temperature")
        SelectionBox.Items.Add("Grades")
        SelectionBox.Items.Add("Date")
        SelectionBox.Items.Add("Math")
        SelectionBox.Items.Add("Triple")
        SelectionBox.Items.Add("Powers")
        SelectionBox.Items.Add("Password")
        SelectionBox.Items.Add("Factors")
        SelectionBox.Items.Add("Country")
        SelectionBox.Items.Add("Presidents")
        SelectionBox.Items.Add("United Nations")
        SelectionBox.Items.Add("File Reader/Writer")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class