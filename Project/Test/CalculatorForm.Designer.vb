<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalculatorForm
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
        Me.SecondNumberLabel = New System.Windows.Forms.Label()
        Me.FirstNumberLabel = New System.Windows.Forms.Label()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.OutputTextBox = New System.Windows.Forms.TextBox()
        Me.InputTextBox2 = New System.Windows.Forms.TextBox()
        Me.InputTextBox1 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MultButton = New System.Windows.Forms.Button()
        Me.SubButton = New System.Windows.Forms.Button()
        Me.DivButton = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SecondNumberLabel
        '
        Me.SecondNumberLabel.AutoSize = True
        Me.SecondNumberLabel.Location = New System.Drawing.Point(153, 24)
        Me.SecondNumberLabel.Name = "SecondNumberLabel"
        Me.SecondNumberLabel.Size = New System.Drawing.Size(84, 13)
        Me.SecondNumberLabel.TabIndex = 2
        Me.SecondNumberLabel.Text = "Second Number"
        '
        'FirstNumberLabel
        '
        Me.FirstNumberLabel.AutoSize = True
        Me.FirstNumberLabel.Location = New System.Drawing.Point(12, 24)
        Me.FirstNumberLabel.Name = "FirstNumberLabel"
        Me.FirstNumberLabel.Size = New System.Drawing.Size(66, 13)
        Me.FirstNumberLabel.TabIndex = 1
        Me.FirstNumberLabel.Text = "First Number"
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(12, 66)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(47, 23)
        Me.AddButton.TabIndex = 6
        Me.AddButton.Text = "+"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'OutputTextBox
        '
        Me.OutputTextBox.Enabled = False
        Me.OutputTextBox.Location = New System.Drawing.Point(12, 95)
        Me.OutputTextBox.Name = "OutputTextBox"
        Me.OutputTextBox.Size = New System.Drawing.Size(265, 20)
        Me.OutputTextBox.TabIndex = 7
        '
        'InputTextBox2
        '
        Me.InputTextBox2.Location = New System.Drawing.Point(156, 40)
        Me.InputTextBox2.Name = "InputTextBox2"
        Me.InputTextBox2.Size = New System.Drawing.Size(119, 20)
        Me.InputTextBox2.TabIndex = 5
        '
        'InputTextBox1
        '
        Me.InputTextBox1.Location = New System.Drawing.Point(12, 40)
        Me.InputTextBox1.Name = "InputTextBox1"
        Me.InputTextBox1.Size = New System.Drawing.Size(119, 20)
        Me.InputTextBox1.TabIndex = 3
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(289, 24)
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
        'MultButton
        '
        Me.MultButton.Location = New System.Drawing.Point(84, 66)
        Me.MultButton.Name = "MultButton"
        Me.MultButton.Size = New System.Drawing.Size(47, 23)
        Me.MultButton.TabIndex = 9
        Me.MultButton.Text = "x"
        Me.MultButton.UseVisualStyleBackColor = True
        '
        'SubButton
        '
        Me.SubButton.Location = New System.Drawing.Point(156, 66)
        Me.SubButton.Name = "SubButton"
        Me.SubButton.Size = New System.Drawing.Size(47, 23)
        Me.SubButton.TabIndex = 10
        Me.SubButton.Text = "-"
        Me.SubButton.UseVisualStyleBackColor = True
        '
        'DivButton
        '
        Me.DivButton.Location = New System.Drawing.Point(228, 66)
        Me.DivButton.Name = "DivButton"
        Me.DivButton.Size = New System.Drawing.Size(47, 23)
        Me.DivButton.TabIndex = 11
        Me.DivButton.Text = "/"
        Me.DivButton.UseVisualStyleBackColor = True
        '
        'CalculatorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(289, 129)
        Me.Controls.Add(Me.DivButton)
        Me.Controls.Add(Me.SubButton)
        Me.Controls.Add(Me.MultButton)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.SecondNumberLabel)
        Me.Controls.Add(Me.FirstNumberLabel)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.OutputTextBox)
        Me.Controls.Add(Me.InputTextBox2)
        Me.Controls.Add(Me.InputTextBox1)
        Me.Name = "CalculatorForm"
        Me.Text = "Calculator"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SecondNumberLabel As System.Windows.Forms.Label
    Friend WithEvents FirstNumberLabel As System.Windows.Forms.Label
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents OutputTextBox As System.Windows.Forms.TextBox
    Friend WithEvents InputTextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents InputTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelectorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MultButton As System.Windows.Forms.Button
    Friend WithEvents SubButton As System.Windows.Forms.Button
    Friend WithEvents DivButton As System.Windows.Forms.Button
End Class
