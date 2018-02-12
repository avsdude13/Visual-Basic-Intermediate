Public Class PresidentsForm
    Structure President
        Dim name As String
        Dim years As String
    End Structure
  
    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        Dim rawPres() As String = IO.File.ReadAllLines("presidents.txt")
        Dim line, data() As String
        Dim Pres(43) As President

        For i As Integer = 0 To 43
            line = rawPres(i)
            data = line.Split(","c)
            Pres(i).name = data(0)
            Pres(i).years = data(1).Trim
        Next

        Dim query = From person In Pres
                    Where FirstName(person.name) = FirstNameTextBox.Text
                    Select person.name, person.years

        OutputDataGridView.DataSource = query.ToList
    End Sub

    Function FirstName(fullname As String) As String
        Dim First() As String = fullname.Split(" "c)
        Return First(0)
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