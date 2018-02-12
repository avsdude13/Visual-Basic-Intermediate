Public Class FileReadWriteForm

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        Dim FileName As String
        Dim Variable As String

        OpenFileDialog1.ShowDialog()

        FileName = OpenFileDialog1.FileName

        Dim SRVariable As IO.StreamReader = IO.File.OpenText(FileName)
        Dim SWVariable As IO.StreamWriter = IO.File.AppendText("NewFile.txt")

        Do Until SRVariable.EndOfStream
            Variable = SRVariable.ReadLine
            OutputListBox.Items.Add(Variable)
            SWVariable.WriteLine(Variable)
        Loop

        SRVariable.Close()
        SWVariable.Close()
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