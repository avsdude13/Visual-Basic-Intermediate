Public Class CountryForm
    Structure Nation
        Dim name As String
        Dim continenet As String
        Dim area As Double
    End Structure

    Private Sub CountryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ContinentsListBox.Items.Add("North America")
        ContinentsListBox.Items.Add("South America")
        ContinentsListBox.Items.Add("Europe")
        ContinentsListBox.Items.Add("Asia")
        ContinentsListBox.Items.Add("Africa")
        ContinentsListBox.Items.Add("Australia")
        ContinentsListBox.Items.Add("Antarctica")
    End Sub

    Private Sub ContinentsListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ContinentsListBox.SelectedIndexChanged
        Dim country(11) As Nation
        Dim line, data() As String
        Dim raw_country() As String = IO.File.ReadAllLines("countries.txt")

        For i As Integer = 0 To 11
            line = raw_country(i)
            data = line.Split(","c)
            country(i).name = data(0)
            country(i).continenet = data(1)
            country(i).area = CDbl(data(2))
        Next

        Dim query = From place In country
                    Where place.continenet = ContinentsListBox.Text
                    Select place.name
                    Order By name Ascending

        CountriesListBox.DataSource = query.ToList
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