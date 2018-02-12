<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WaltDisneyWorld
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
        Me.DaysLabel = New System.Windows.Forms.Label()
        Me.DaysTextBox = New System.Windows.Forms.TextBox()
        Me.AdultsTextBox = New System.Windows.Forms.TextBox()
        Me.AdultsLabel = New System.Windows.Forms.Label()
        Me.ChildrenTextBox = New System.Windows.Forms.TextBox()
        Me.ChildrenLabel = New System.Windows.Forms.Label()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.TicketPriceTextBox = New System.Windows.Forms.TextBox()
        Me.TicketsLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'DaysLabel
        '
        Me.DaysLabel.AutoSize = True
        Me.DaysLabel.Location = New System.Drawing.Point(12, 20)
        Me.DaysLabel.Name = "DaysLabel"
        Me.DaysLabel.Size = New System.Drawing.Size(83, 13)
        Me.DaysLabel.TabIndex = 0
        Me.DaysLabel.Text = "Number of Days"
        '
        'DaysTextBox
        '
        Me.DaysTextBox.Location = New System.Drawing.Point(25, 46)
        Me.DaysTextBox.Name = "DaysTextBox"
        Me.DaysTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DaysTextBox.TabIndex = 1
        '
        'AdultsTextBox
        '
        Me.AdultsTextBox.Location = New System.Drawing.Point(155, 46)
        Me.AdultsTextBox.Name = "AdultsTextBox"
        Me.AdultsTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AdultsTextBox.TabIndex = 3
        '
        'AdultsLabel
        '
        Me.AdultsLabel.AutoSize = True
        Me.AdultsLabel.Location = New System.Drawing.Point(142, 20)
        Me.AdultsLabel.Name = "AdultsLabel"
        Me.AdultsLabel.Size = New System.Drawing.Size(88, 13)
        Me.AdultsLabel.TabIndex = 2
        Me.AdultsLabel.Text = "Number of Adults"
        '
        'ChildrenTextBox
        '
        Me.ChildrenTextBox.Location = New System.Drawing.Point(288, 46)
        Me.ChildrenTextBox.Name = "ChildrenTextBox"
        Me.ChildrenTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ChildrenTextBox.TabIndex = 5
        '
        'ChildrenLabel
        '
        Me.ChildrenLabel.AutoSize = True
        Me.ChildrenLabel.Location = New System.Drawing.Point(275, 20)
        Me.ChildrenLabel.Name = "ChildrenLabel"
        Me.ChildrenLabel.Size = New System.Drawing.Size(97, 13)
        Me.ChildrenLabel.TabIndex = 4
        Me.ChildrenLabel.Text = "Number of Children"
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(15, 86)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(373, 23)
        Me.CalculateButton.TabIndex = 6
        Me.CalculateButton.Text = "Calculate Ticket Price"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'TicketPriceTextBox
        '
        Me.TicketPriceTextBox.Location = New System.Drawing.Point(155, 151)
        Me.TicketPriceTextBox.Name = "TicketPriceTextBox"
        Me.TicketPriceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TicketPriceTextBox.TabIndex = 8
        '
        'TicketsLabel
        '
        Me.TicketsLabel.AutoSize = True
        Me.TicketsLabel.Location = New System.Drawing.Point(142, 125)
        Me.TicketsLabel.Name = "TicketsLabel"
        Me.TicketsLabel.Size = New System.Drawing.Size(91, 13)
        Me.TicketsLabel.TabIndex = 7
        Me.TicketsLabel.Text = "Total Ticket Price"
        '
        'WaltDisneyWorld
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 188)
        Me.Controls.Add(Me.TicketPriceTextBox)
        Me.Controls.Add(Me.TicketsLabel)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.ChildrenTextBox)
        Me.Controls.Add(Me.ChildrenLabel)
        Me.Controls.Add(Me.AdultsTextBox)
        Me.Controls.Add(Me.AdultsLabel)
        Me.Controls.Add(Me.DaysTextBox)
        Me.Controls.Add(Me.DaysLabel)
        Me.Name = "WaltDisneyWorld"
        Me.Text = "Walt Disney World in Orlando"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DaysLabel As System.Windows.Forms.Label
    Friend WithEvents DaysTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AdultsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AdultsLabel As System.Windows.Forms.Label
    Friend WithEvents ChildrenTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ChildrenLabel As System.Windows.Forms.Label
    Friend WithEvents CalculateButton As System.Windows.Forms.Button
    Friend WithEvents TicketPriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TicketsLabel As System.Windows.Forms.Label

End Class
