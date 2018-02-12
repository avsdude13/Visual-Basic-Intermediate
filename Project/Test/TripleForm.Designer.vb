<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TripleForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayListBox = New System.Windows.Forms.ListBox()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.FirstDigitTextBox = New System.Windows.Forms.TextBox()
        Me.SecondDigitTextBox = New System.Windows.Forms.TextBox()
        Me.Digit1Label = New System.Windows.Forms.Label()
        Me.Digit2Label = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(282, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectorToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'SelectorToolStripMenuItem
        '
        Me.SelectorToolStripMenuItem.Name = "SelectorToolStripMenuItem"
        Me.SelectorToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.SelectorToolStripMenuItem.Text = "&Selector"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'DisplayListBox
        '
        Me.DisplayListBox.FormattingEnabled = True
        Me.DisplayListBox.Location = New System.Drawing.Point(24, 134)
        Me.DisplayListBox.Name = "DisplayListBox"
        Me.DisplayListBox.Size = New System.Drawing.Size(234, 95)
        Me.DisplayListBox.TabIndex = 9
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(102, 102)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(75, 23)
        Me.CalculateButton.TabIndex = 10
        Me.CalculateButton.Text = "Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'FirstDigitTextBox
        '
        Me.FirstDigitTextBox.Location = New System.Drawing.Point(24, 70)
        Me.FirstDigitTextBox.Name = "FirstDigitTextBox"
        Me.FirstDigitTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FirstDigitTextBox.TabIndex = 11
        '
        'SecondDigitTextBox
        '
        Me.SecondDigitTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.SecondDigitTextBox.Location = New System.Drawing.Point(158, 70)
        Me.SecondDigitTextBox.Name = "SecondDigitTextBox"
        Me.SecondDigitTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SecondDigitTextBox.TabIndex = 12
        '
        'Digit1Label
        '
        Me.Digit1Label.AutoSize = True
        Me.Digit1Label.Location = New System.Drawing.Point(24, 51)
        Me.Digit1Label.Name = "Digit1Label"
        Me.Digit1Label.Size = New System.Drawing.Size(78, 13)
        Me.Digit1Label.TabIndex = 13
        Me.Digit1Label.Text = "Enter First Digit"
        '
        'Digit2Label
        '
        Me.Digit2Label.AutoSize = True
        Me.Digit2Label.Location = New System.Drawing.Point(155, 51)
        Me.Digit2Label.Name = "Digit2Label"
        Me.Digit2Label.Size = New System.Drawing.Size(96, 13)
        Me.Digit2Label.TabIndex = 14
        Me.Digit2Label.Text = "Enter Second Digit"
        '
        'TripleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 249)
        Me.Controls.Add(Me.Digit2Label)
        Me.Controls.Add(Me.Digit1Label)
        Me.Controls.Add(Me.SecondDigitTextBox)
        Me.Controls.Add(Me.FirstDigitTextBox)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.DisplayListBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "TripleForm"
        Me.Text = "Triple"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelectorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisplayListBox As System.Windows.Forms.ListBox
    Friend WithEvents CalculateButton As System.Windows.Forms.Button
    Friend WithEvents FirstDigitTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SecondDigitTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Digit1Label As System.Windows.Forms.Label
    Friend WithEvents Digit2Label As System.Windows.Forms.Label
End Class
