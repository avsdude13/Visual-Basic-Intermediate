<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MathForm
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
        Me.InputTextBox1 = New System.Windows.Forms.TextBox()
        Me.InputTextBox2 = New System.Windows.Forms.TextBox()
        Me.Input1Label = New System.Windows.Forms.Label()
        Me.Input2Label = New System.Windows.Forms.Label()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.ResultTextBox = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResultLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'InputTextBox1
        '
        Me.InputTextBox1.Location = New System.Drawing.Point(36, 67)
        Me.InputTextBox1.Name = "InputTextBox1"
        Me.InputTextBox1.Size = New System.Drawing.Size(210, 20)
        Me.InputTextBox1.TabIndex = 2
        '
        'InputTextBox2
        '
        Me.InputTextBox2.Location = New System.Drawing.Point(33, 119)
        Me.InputTextBox2.Name = "InputTextBox2"
        Me.InputTextBox2.Size = New System.Drawing.Size(213, 20)
        Me.InputTextBox2.TabIndex = 4
        '
        'Input1Label
        '
        Me.Input1Label.AutoSize = True
        Me.Input1Label.Location = New System.Drawing.Point(33, 51)
        Me.Input1Label.Name = "Input1Label"
        Me.Input1Label.Size = New System.Drawing.Size(111, 13)
        Me.Input1Label.TabIndex = 1
        Me.Input1Label.Text = "Input 1 to the power 3"
        '
        'Input2Label
        '
        Me.Input2Label.AutoSize = True
        Me.Input2Label.Location = New System.Drawing.Point(33, 103)
        Me.Input2Label.Name = "Input2Label"
        Me.Input2Label.Size = New System.Drawing.Size(111, 13)
        Me.Input2Label.TabIndex = 3
        Me.Input2Label.Text = "Input 2 to the power 2"
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(36, 158)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(75, 23)
        Me.CalculateButton.TabIndex = 5
        Me.CalculateButton.Text = "Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'ResultTextBox
        '
        Me.ResultTextBox.Location = New System.Drawing.Point(33, 206)
        Me.ResultTextBox.Name = "ResultTextBox"
        Me.ResultTextBox.Size = New System.Drawing.Size(213, 20)
        Me.ResultTextBox.TabIndex = 7
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 0
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
        Me.SelectorToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
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
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'ResultLabel
        '
        Me.ResultLabel.AutoSize = True
        Me.ResultLabel.Location = New System.Drawing.Point(33, 190)
        Me.ResultLabel.Name = "ResultLabel"
        Me.ResultLabel.Size = New System.Drawing.Size(130, 13)
        Me.ResultLabel.TabIndex = 6
        Me.ResultLabel.Text = "Result of Input 1 + Input 2"
        '
        'MathForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.ResultLabel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ResultTextBox)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.Input2Label)
        Me.Controls.Add(Me.Input1Label)
        Me.Controls.Add(Me.InputTextBox2)
        Me.Controls.Add(Me.InputTextBox1)
        Me.Name = "MathForm"
        Me.Text = "Math"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents InputTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents InputTextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Input1Label As System.Windows.Forms.Label
    Friend WithEvents Input2Label As System.Windows.Forms.Label
    Friend WithEvents CalculateButton As System.Windows.Forms.Button
    Friend WithEvents ResultTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelectorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResultLabel As System.Windows.Forms.Label
End Class
