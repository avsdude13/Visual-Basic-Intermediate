<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CountryForm
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
        Me.ContinentsListBox = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContinentsLabel = New System.Windows.Forms.Label()
        Me.CountriesLabel = New System.Windows.Forms.Label()
        Me.CountriesListBox = New System.Windows.Forms.ListBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContinentsListBox
        '
        Me.ContinentsListBox.FormattingEnabled = True
        Me.ContinentsListBox.Location = New System.Drawing.Point(12, 44)
        Me.ContinentsListBox.Name = "ContinentsListBox"
        Me.ContinentsListBox.Size = New System.Drawing.Size(120, 95)
        Me.ContinentsListBox.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(271, 24)
        Me.MenuStrip1.TabIndex = 10
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
        'ContinentsLabel
        '
        Me.ContinentsLabel.AutoSize = True
        Me.ContinentsLabel.Location = New System.Drawing.Point(12, 28)
        Me.ContinentsLabel.Name = "ContinentsLabel"
        Me.ContinentsLabel.Size = New System.Drawing.Size(57, 13)
        Me.ContinentsLabel.TabIndex = 11
        Me.ContinentsLabel.Text = "Continents"
        '
        'CountriesLabel
        '
        Me.CountriesLabel.AutoSize = True
        Me.CountriesLabel.Location = New System.Drawing.Point(138, 28)
        Me.CountriesLabel.Name = "CountriesLabel"
        Me.CountriesLabel.Size = New System.Drawing.Size(51, 13)
        Me.CountriesLabel.TabIndex = 13
        Me.CountriesLabel.Text = "Countries"
        '
        'CountriesListBox
        '
        Me.CountriesListBox.FormattingEnabled = True
        Me.CountriesListBox.Location = New System.Drawing.Point(138, 44)
        Me.CountriesListBox.Name = "CountriesListBox"
        Me.CountriesListBox.Size = New System.Drawing.Size(120, 95)
        Me.CountriesListBox.TabIndex = 12
        '
        'CountryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(271, 152)
        Me.Controls.Add(Me.CountriesLabel)
        Me.Controls.Add(Me.CountriesListBox)
        Me.Controls.Add(Me.ContinentsLabel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ContinentsListBox)
        Me.Name = "CountryForm"
        Me.Text = "Countries"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContinentsListBox As System.Windows.Forms.ListBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelectorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContinentsLabel As System.Windows.Forms.Label
    Friend WithEvents CountriesLabel As System.Windows.Forms.Label
    Friend WithEvents CountriesListBox As System.Windows.Forms.ListBox
End Class
