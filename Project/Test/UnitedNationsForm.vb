Public Class UnitedNationsForm

    Private Sub UnitedNationsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OutputButton_Click(sender As Object, e As EventArgs) Handles OutputButton.Click
        Dim FileName As String
        Dim CountryName As String = CountryTextBox.Text

        FileName = OpenFileDialog1.FileName
        Dim UnitedNations() As String = IO.File.ReadAllLines(FileName)

        Dim query = From Line In UnitedNations
                    Let Data = Line.Split(","c)
                    Let Number = CInt(Data(0))
                    Let Country = Data(1)
                    Let Capital = Data(2)
                    Let Currency = Data(3)
                    Let Language = Data(4)
                    Where Country.ToUpper = CountryName.ToUpper
                    Select Capital, Currency, Language

        OutputDataGridView.DataSource = query.ToList
        OutputDataGridView.CurrentCell = Nothing
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