Public Class CalculatorForm
    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        If (InputTextBox1.Text = "" Or InputTextBox2.Text = "") Then
            MessageBox.Show("Please enter two values.")
        Else
            Addition(Double.Parse(InputTextBox1.Text), Double.Parse(InputTextBox2.Text))
        End If
    End Sub

    Private Sub MultButton_Click(sender As Object, e As EventArgs) Handles MultButton.Click
        If (InputTextBox1.Text = "" Or InputTextBox2.Text = "") Then
            MessageBox.Show("Please enter two values.")
        Else
            Multiplication(Double.Parse(InputTextBox1.Text), Double.Parse(InputTextBox2.Text))
        End If
    End Sub

    Private Sub SubButton_Click(sender As Object, e As EventArgs) Handles SubButton.Click
        If (InputTextBox1.Text = "" Or InputTextBox2.Text = "") Then
            MessageBox.Show("Please enter two values.")
        Else
            Subtraction(Double.Parse(InputTextBox1.Text), Double.Parse(InputTextBox2.Text))
        End If
    End Sub

    Private Sub DivButton_Click(sender As Object, e As EventArgs) Handles DivButton.Click
        If (InputTextBox1.Text = "" Or InputTextBox2.Text = "") Then
            MessageBox.Show("Please enter two values.")
        Else
            Division(Double.Parse(InputTextBox1.Text), Double.Parse(InputTextBox2.Text))
        End If
    End Sub

    Sub Addition(Digit1 As Double, Digit2 As Double)
        Dim Result As Double = Digit1 + Digit2
        OutputTextBox.Text = CStr(Digit1 & " + " & Digit2 & " = " & Result)
    End Sub

    Sub Multiplication(Digit1 As Double, Digit2 As Double)
        Dim Result As Double = Digit1 * Digit2
        OutputTextBox.Text = CStr(Digit1 & " x " & Digit2 & " = " & Result)
    End Sub

    Sub Subtraction(Digit1 As Double, Digit2 As Double)
        Dim Result As Double = Digit1 - Digit2
        OutputTextBox.Text = CStr(Digit1 & " - " & Digit2 & " = " & Result)
    End Sub

    Sub Division(Digit1 As Double, Digit2 As Double)
        Dim Result As Double = Digit1 / Digit2
        OutputTextBox.Text = CStr(Digit1 & " / " & Digit2 & " = " & Result)
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