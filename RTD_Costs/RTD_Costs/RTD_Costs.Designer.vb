<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RTD_Costs
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
        Me.TripsLabel = New System.Windows.Forms.Label()
        Me.PerDayTextBox = New System.Windows.Forms.TextBox()
        Me.PerMonthTextBox = New System.Windows.Forms.TextBox()
        Me.DaysLabel = New System.Windows.Forms.Label()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.CostLabel = New System.Windows.Forms.Label()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TripsLabel
        '
        Me.TripsLabel.AutoSize = True
        Me.TripsLabel.Location = New System.Drawing.Point(12, 9)
        Me.TripsLabel.Name = "TripsLabel"
        Me.TripsLabel.Size = New System.Drawing.Size(70, 13)
        Me.TripsLabel.TabIndex = 0
        Me.TripsLabel.Text = "Trips per Day"
        '
        'PerDayTextBox
        '
        Me.PerDayTextBox.Location = New System.Drawing.Point(25, 26)
        Me.PerDayTextBox.Name = "PerDayTextBox"
        Me.PerDayTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PerDayTextBox.TabIndex = 1
        '
        'PerMonthTextBox
        '
        Me.PerMonthTextBox.Location = New System.Drawing.Point(158, 26)
        Me.PerMonthTextBox.Name = "PerMonthTextBox"
        Me.PerMonthTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PerMonthTextBox.TabIndex = 3
        '
        'DaysLabel
        '
        Me.DaysLabel.AutoSize = True
        Me.DaysLabel.Location = New System.Drawing.Point(145, 9)
        Me.DaysLabel.Name = "DaysLabel"
        Me.DaysLabel.Size = New System.Drawing.Size(82, 13)
        Me.DaysLabel.TabIndex = 2
        Me.DaysLabel.Text = "Days per Month"
        '
        'TotalTextBox
        '
        Me.TotalTextBox.Location = New System.Drawing.Point(25, 94)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(233, 20)
        Me.TotalTextBox.TabIndex = 5
        '
        'CostLabel
        '
        Me.CostLabel.AutoSize = True
        Me.CostLabel.Location = New System.Drawing.Point(12, 77)
        Me.CostLabel.Name = "CostLabel"
        Me.CostLabel.Size = New System.Drawing.Size(55, 13)
        Me.CostLabel.TabIndex = 4
        Me.CostLabel.Text = "Total Cost"
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(72, 52)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(131, 23)
        Me.CalculateButton.TabIndex = 6
        Me.CalculateButton.Text = "Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'RTD_Costs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(279, 134)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.TotalTextBox)
        Me.Controls.Add(Me.CostLabel)
        Me.Controls.Add(Me.PerMonthTextBox)
        Me.Controls.Add(Me.DaysLabel)
        Me.Controls.Add(Me.PerDayTextBox)
        Me.Controls.Add(Me.TripsLabel)
        Me.Name = "RTD_Costs"
        Me.Text = "RTD Costs"
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TripsLabel As System.Windows.Forms.Label
    Friend WithEvents PerDayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PerMonthTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DaysLabel As System.Windows.Forms.Label
    Friend WithEvents TotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CostLabel As System.Windows.Forms.Label
    Friend WithEvents CalculateButton As System.Windows.Forms.Button

End Class
