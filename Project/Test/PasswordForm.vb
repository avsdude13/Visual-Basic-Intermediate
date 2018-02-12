Public Class PasswordForm

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Dim BothValid As Boolean = False
        Dim usernameEnty As String = ""
        Dim passwordEnry As String = ""

        Do
            usernameEnty = InputBox("Enter Username", "Input")
            passwordEnry = InputBox("Enter Password", "Input")

            BothValid = Validity(usernameEnty, passwordEnry)

            If (BothValid = False) Then
                MessageBox.Show("Invalid username or password. Please try again.")
            End If
        Loop Until BothValid

        MessageBox.Show("You have logged in successfully.")
    End Sub

    Function Validity(username As String, password As String) As Boolean
        Select Case username
            Case "admin"
                If (password = "password") Then
                    Return True
                Else
                    Return False
                End If
            Case "Guest"
                If (password = "unknown") Then
                    Return True
                Else
                    Return False
                End If
        End Select
        Return False
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