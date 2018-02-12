<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TemperatureForm
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
        Me.TempLabel = New System.Windows.Forms.Label()
        Me.ToCelRadioButton = New System.Windows.Forms.RadioButton()
        Me.ToFarRadioButton = New System.Windows.Forms.RadioButton()
        Me.TempLabel2 = New System.Windows.Forms.Label()
        Me.EntryTextBox = New System.Windows.Forms.TextBox()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.ResultTextBox = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TempLabel
        '
        Me.TempLabel.AutoSize = True
        Me.TempLabel.Location = New System.Drawing.Point(12, 32)
        Me.TempLabel.Name = "TempLabel"
        Me.TempLabel.Size = New System.Drawing.Size(112, 13)
        Me.TempLabel.TabIndex = 1
        Me.TempLabel.Text = "Enter the current temp"
        '
        'ToCelRadioButton
        '
        Me.ToCelRadioButton.AutoSize = True
        Me.ToCelRadioButton.Location = New System.Drawing.Point(24, 101)
        Me.ToCelRadioButton.Name = "ToCelRadioButton"
        Me.ToCelRadioButton.Size = New System.Drawing.Size(59, 17)
        Me.ToCelRadioButton.TabIndex = 4
        Me.ToCelRadioButton.TabStop = True
        Me.ToCelRadioButton.Text = "Celcius"
        Me.ToCelRadioButton.UseVisualStyleBackColor = True
        '
        'ToFarRadioButton
        '
        Me.ToFarRadioButton.AutoSize = True
        Me.ToFarRadioButton.Location = New System.Drawing.Point(115, 101)
        Me.ToFarRadioButton.Name = "ToFarRadioButton"
        Me.ToFarRadioButton.Size = New System.Drawing.Size(75, 17)
        Me.ToFarRadioButton.TabIndex = 5
        Me.ToFarRadioButton.TabStop = True
        Me.ToFarRadioButton.Text = "Fahrenheit"
        Me.ToFarRadioButton.UseVisualStyleBackColor = True
        '
        'TempLabel2
        '
        Me.TempLabel2.AutoSize = True
        Me.TempLabel2.Location = New System.Drawing.Point(12, 85)
        Me.TempLabel2.Name = "TempLabel2"
        Me.TempLabel2.Size = New System.Drawing.Size(128, 13)
        Me.TempLabel2.TabIndex = 3
        Me.TempLabel2.Text = "Change to which system?"
        '
        'EntryTextBox
        '
        Me.EntryTextBox.Location = New System.Drawing.Point(15, 48)
        Me.EntryTextBox.Name = "EntryTextBox"
        Me.EntryTextBox.Size = New System.Drawing.Size(197, 20)
        Me.EntryTextBox.TabIndex = 2
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(70, 124)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(75, 23)
        Me.CalculateButton.TabIndex = 6
        Me.CalculateButton.Text = "Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'ResultTextBox
        '
        Me.ResultTextBox.Enabled = False
        Me.ResultTextBox.Location = New System.Drawing.Point(15, 162)
        Me.ResultTextBox.Name = "ResultTextBox"
        Me.ResultTextBox.Size = New System.Drawing.Size(197, 20)
        Me.ResultTextBox.TabIndex = 7
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(226, 24)
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
        'TemperatureForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(226, 194)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ResultTextBox)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.EntryTextBox)
        Me.Controls.Add(Me.TempLabel2)
        Me.Controls.Add(Me.ToFarRadioButton)
        Me.Controls.Add(Me.ToCelRadioButton)
        Me.Controls.Add(Me.TempLabel)
        Me.Name = "TemperatureForm"
        Me.Text = "Temperature"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TempLabel As System.Windows.Forms.Label
    Friend WithEvents ToCelRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents ToFarRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents TempLabel2 As System.Windows.Forms.Label
    Friend WithEvents EntryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CalculateButton As System.Windows.Forms.Button
    Friend WithEvents ResultTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelectorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
