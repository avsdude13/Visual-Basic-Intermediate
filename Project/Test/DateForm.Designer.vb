<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DateForm
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
        Me.MonthListBox = New System.Windows.Forms.ListBox()
        Me.MonthLabel = New System.Windows.Forms.Label()
        Me.DaysLabel = New System.Windows.Forms.Label()
        Me.OutputTextBox = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MonthListBox
        '
        Me.MonthListBox.FormattingEnabled = True
        Me.MonthListBox.Location = New System.Drawing.Point(12, 53)
        Me.MonthListBox.Name = "MonthListBox"
        Me.MonthListBox.Size = New System.Drawing.Size(120, 95)
        Me.MonthListBox.TabIndex = 2
        '
        'MonthLabel
        '
        Me.MonthLabel.AutoSize = True
        Me.MonthLabel.Location = New System.Drawing.Point(12, 37)
        Me.MonthLabel.Name = "MonthLabel"
        Me.MonthLabel.Size = New System.Drawing.Size(37, 13)
        Me.MonthLabel.TabIndex = 1
        Me.MonthLabel.Text = "Month"
        '
        'DaysLabel
        '
        Me.DaysLabel.AutoSize = True
        Me.DaysLabel.Location = New System.Drawing.Point(159, 77)
        Me.DaysLabel.Name = "DaysLabel"
        Me.DaysLabel.Size = New System.Drawing.Size(83, 13)
        Me.DaysLabel.TabIndex = 3
        Me.DaysLabel.Text = "Number of Days"
        '
        'OutputTextBox
        '
        Me.OutputTextBox.Enabled = False
        Me.OutputTextBox.Location = New System.Drawing.Point(162, 93)
        Me.OutputTextBox.Name = "OutputTextBox"
        Me.OutputTextBox.Size = New System.Drawing.Size(53, 20)
        Me.OutputTextBox.TabIndex = 4
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(257, 24)
        Me.MenuStrip1.TabIndex = 5
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
        'DateForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(257, 162)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.OutputTextBox)
        Me.Controls.Add(Me.DaysLabel)
        Me.Controls.Add(Me.MonthLabel)
        Me.Controls.Add(Me.MonthListBox)
        Me.Name = "DateForm"
        Me.Text = "Date"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MonthListBox As System.Windows.Forms.ListBox
    Friend WithEvents MonthLabel As System.Windows.Forms.Label
    Friend WithEvents DaysLabel As System.Windows.Forms.Label
    Friend WithEvents OutputTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelectorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
