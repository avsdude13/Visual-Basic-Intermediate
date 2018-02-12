<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PowersForm
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
        Me.EnterValueLabel = New System.Windows.Forms.Label()
        Me.InputTextBox = New System.Windows.Forms.TextBox()
        Me.ResultListBox = New System.Windows.Forms.ListBox()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IncrementalButton = New System.Windows.Forms.Button()
        Me.DivisibleButton = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'EnterValueLabel
        '
        Me.EnterValueLabel.AutoSize = True
        Me.EnterValueLabel.Location = New System.Drawing.Point(12, 35)
        Me.EnterValueLabel.Name = "EnterValueLabel"
        Me.EnterValueLabel.Size = New System.Drawing.Size(146, 13)
        Me.EnterValueLabel.TabIndex = 0
        Me.EnterValueLabel.Text = "Enter value to see its powers."
        '
        'InputTextBox
        '
        Me.InputTextBox.Location = New System.Drawing.Point(33, 61)
        Me.InputTextBox.Name = "InputTextBox"
        Me.InputTextBox.Size = New System.Drawing.Size(238, 20)
        Me.InputTextBox.TabIndex = 1
        '
        'ResultListBox
        '
        Me.ResultListBox.FormattingEnabled = True
        Me.ResultListBox.Location = New System.Drawing.Point(33, 126)
        Me.ResultListBox.Name = "ResultListBox"
        Me.ResultListBox.Size = New System.Drawing.Size(238, 134)
        Me.ResultListBox.TabIndex = 2
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(33, 87)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(75, 23)
        Me.CalculateButton.TabIndex = 3
        Me.CalculateButton.Text = "Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(325, 24)
        Me.MenuStrip1.TabIndex = 9
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
        'IncrementalButton
        '
        Me.IncrementalButton.Location = New System.Drawing.Point(114, 87)
        Me.IncrementalButton.Name = "IncrementalButton"
        Me.IncrementalButton.Size = New System.Drawing.Size(75, 23)
        Me.IncrementalButton.TabIndex = 10
        Me.IncrementalButton.Text = "Incremental"
        Me.IncrementalButton.UseVisualStyleBackColor = True
        '
        'DivisibleButton
        '
        Me.DivisibleButton.Location = New System.Drawing.Point(196, 87)
        Me.DivisibleButton.Name = "DivisibleButton"
        Me.DivisibleButton.Size = New System.Drawing.Size(75, 23)
        Me.DivisibleButton.TabIndex = 11
        Me.DivisibleButton.Text = "Divisibles"
        Me.DivisibleButton.UseVisualStyleBackColor = True
        '
        'PowersForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(325, 286)
        Me.Controls.Add(Me.DivisibleButton)
        Me.Controls.Add(Me.IncrementalButton)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.ResultListBox)
        Me.Controls.Add(Me.InputTextBox)
        Me.Controls.Add(Me.EnterValueLabel)
        Me.Name = "PowersForm"
        Me.Text = "Powers"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EnterValueLabel As System.Windows.Forms.Label
    Friend WithEvents InputTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ResultListBox As System.Windows.Forms.ListBox
    Friend WithEvents CalculateButton As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelectorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IncrementalButton As System.Windows.Forms.Button
    Friend WithEvents DivisibleButton As System.Windows.Forms.Button
End Class
