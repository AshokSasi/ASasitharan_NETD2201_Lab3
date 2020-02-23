<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAverageUnitsShipped
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
        Me.components = New System.ComponentModel.Container()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.lblEmployee1 = New System.Windows.Forms.Label()
        Me.txtUnitsInput = New System.Windows.Forms.TextBox()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.lblEmployee2 = New System.Windows.Forms.Label()
        Me.lblEmployee3 = New System.Windows.Forms.Label()
        Me.txtUnitDisplay1 = New System.Windows.Forms.TextBox()
        Me.txtUnitDisplay2 = New System.Windows.Forms.TextBox()
        Me.txtUnitDisplay3 = New System.Windows.Forms.TextBox()
        Me.lblEmployee1Average = New System.Windows.Forms.Label()
        Me.lblEmployee2Average = New System.Windows.Forms.Label()
        Me.lblEmployee3Average = New System.Windows.Forms.Label()
        Me.lblTotalAverage = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.AverageunitsShippedToolTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDay.Location = New System.Drawing.Point(36, 29)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(43, 16)
        Me.lblDay.TabIndex = 0
        Me.lblDay.Text = "Day 1"
        '
        'lblEmployee1
        '
        Me.lblEmployee1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployee1.Location = New System.Drawing.Point(57, 115)
        Me.lblEmployee1.Name = "lblEmployee1"
        Me.lblEmployee1.Size = New System.Drawing.Size(95, 21)
        Me.lblEmployee1.TabIndex = 1
        Me.lblEmployee1.Text = "Employee 1"
        '
        'txtUnitsInput
        '
        Me.txtUnitsInput.Location = New System.Drawing.Point(99, 54)
        Me.txtUnitsInput.Multiline = True
        Me.txtUnitsInput.Name = "txtUnitsInput"
        Me.txtUnitsInput.Size = New System.Drawing.Size(53, 20)
        Me.txtUnitsInput.TabIndex = 1
        Me.AverageunitsShippedToolTips.SetToolTip(Me.txtUnitsInput, "Enter amount of shipped units here.")
        '
        'lblUnits
        '
        Me.lblUnits.AutoSize = True
        Me.lblUnits.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnits.Location = New System.Drawing.Point(36, 54)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(41, 16)
        Me.lblUnits.TabIndex = 5
        Me.lblUnits.Text = "Units:"
        '
        'lblEmployee2
        '
        Me.lblEmployee2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployee2.Location = New System.Drawing.Point(216, 115)
        Me.lblEmployee2.Name = "lblEmployee2"
        Me.lblEmployee2.Size = New System.Drawing.Size(92, 21)
        Me.lblEmployee2.TabIndex = 9
        Me.lblEmployee2.Text = "Employee 2"
        '
        'lblEmployee3
        '
        Me.lblEmployee3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployee3.Location = New System.Drawing.Point(386, 115)
        Me.lblEmployee3.Name = "lblEmployee3"
        Me.lblEmployee3.Size = New System.Drawing.Size(102, 21)
        Me.lblEmployee3.TabIndex = 10
        Me.lblEmployee3.Text = "Employee 3"
        '
        'txtUnitDisplay1
        '
        Me.txtUnitDisplay1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtUnitDisplay1.Location = New System.Drawing.Point(39, 139)
        Me.txtUnitDisplay1.Multiline = True
        Me.txtUnitDisplay1.Name = "txtUnitDisplay1"
        Me.txtUnitDisplay1.ReadOnly = True
        Me.txtUnitDisplay1.Size = New System.Drawing.Size(124, 140)
        Me.txtUnitDisplay1.TabIndex = 11
        Me.txtUnitDisplay1.TabStop = False
        Me.AverageunitsShippedToolTips.SetToolTip(Me.txtUnitDisplay1, "Employee 1's shipped units.")
        '
        'txtUnitDisplay2
        '
        Me.txtUnitDisplay2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtUnitDisplay2.Location = New System.Drawing.Point(199, 139)
        Me.txtUnitDisplay2.Multiline = True
        Me.txtUnitDisplay2.Name = "txtUnitDisplay2"
        Me.txtUnitDisplay2.ReadOnly = True
        Me.txtUnitDisplay2.Size = New System.Drawing.Size(124, 140)
        Me.txtUnitDisplay2.TabIndex = 12
        Me.txtUnitDisplay2.TabStop = False
        Me.AverageunitsShippedToolTips.SetToolTip(Me.txtUnitDisplay2, "Employee 2's shipped units.")
        '
        'txtUnitDisplay3
        '
        Me.txtUnitDisplay3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtUnitDisplay3.Location = New System.Drawing.Point(364, 139)
        Me.txtUnitDisplay3.Multiline = True
        Me.txtUnitDisplay3.Name = "txtUnitDisplay3"
        Me.txtUnitDisplay3.ReadOnly = True
        Me.txtUnitDisplay3.Size = New System.Drawing.Size(124, 140)
        Me.txtUnitDisplay3.TabIndex = 13
        Me.txtUnitDisplay3.TabStop = False
        Me.AverageunitsShippedToolTips.SetToolTip(Me.txtUnitDisplay3, "Employee 3's shipped units.")
        '
        'lblEmployee1Average
        '
        Me.lblEmployee1Average.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployee1Average.Location = New System.Drawing.Point(39, 294)
        Me.lblEmployee1Average.Name = "lblEmployee1Average"
        Me.lblEmployee1Average.Size = New System.Drawing.Size(127, 23)
        Me.lblEmployee1Average.TabIndex = 14
        Me.lblEmployee1Average.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AverageunitsShippedToolTips.SetToolTip(Me.lblEmployee1Average, "Employee 1's  average units shipped.")
        '
        'lblEmployee2Average
        '
        Me.lblEmployee2Average.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployee2Average.Location = New System.Drawing.Point(199, 294)
        Me.lblEmployee2Average.Name = "lblEmployee2Average"
        Me.lblEmployee2Average.Size = New System.Drawing.Size(127, 23)
        Me.lblEmployee2Average.TabIndex = 15
        Me.lblEmployee2Average.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AverageunitsShippedToolTips.SetToolTip(Me.lblEmployee2Average, "Employee 2's  average units shipped.")
        '
        'lblEmployee3Average
        '
        Me.lblEmployee3Average.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployee3Average.Location = New System.Drawing.Point(361, 294)
        Me.lblEmployee3Average.Name = "lblEmployee3Average"
        Me.lblEmployee3Average.Size = New System.Drawing.Size(127, 23)
        Me.lblEmployee3Average.TabIndex = 16
        Me.lblEmployee3Average.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AverageunitsShippedToolTips.SetToolTip(Me.lblEmployee3Average, "Employee 3's  average units shipped.")
        '
        'lblTotalAverage
        '
        Me.lblTotalAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalAverage.Location = New System.Drawing.Point(39, 331)
        Me.lblTotalAverage.Name = "lblTotalAverage"
        Me.lblTotalAverage.Size = New System.Drawing.Size(452, 23)
        Me.lblTotalAverage.TabIndex = 17
        Me.lblTotalAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AverageunitsShippedToolTips.SetToolTip(Me.lblTotalAverage, "The total average units shipped by all three employees.")
        '
        'btnEnter
        '
        Me.btnEnter.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnEnter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.Location = New System.Drawing.Point(36, 372)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(127, 35)
        Me.btnEnter.TabIndex = 2
        Me.btnEnter.Text = "&Enter"
        Me.AverageunitsShippedToolTips.SetToolTip(Me.btnEnter, "Enters the units.")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(199, 372)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(124, 35)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "&Reset"
        Me.AverageunitsShippedToolTips.SetToolTip(Me.btnReset, "Resets the form to default state.")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(364, 372)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(124, 35)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.AverageunitsShippedToolTips.SetToolTip(Me.btnExit, "Closes the form.")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmAverageUnitsShipped
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(517, 446)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblTotalAverage)
        Me.Controls.Add(Me.lblEmployee3Average)
        Me.Controls.Add(Me.lblEmployee2Average)
        Me.Controls.Add(Me.lblEmployee1Average)
        Me.Controls.Add(Me.txtUnitDisplay3)
        Me.Controls.Add(Me.txtUnitDisplay2)
        Me.Controls.Add(Me.txtUnitDisplay1)
        Me.Controls.Add(Me.lblEmployee3)
        Me.Controls.Add(Me.lblEmployee2)
        Me.Controls.Add(Me.lblUnits)
        Me.Controls.Add(Me.txtUnitsInput)
        Me.Controls.Add(Me.lblEmployee1)
        Me.Controls.Add(Me.lblDay)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAverageUnitsShipped"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped By Employee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDay As Label
    Friend WithEvents lblEmployee1 As Label
    Friend WithEvents txtUnitsInput As TextBox
    Friend WithEvents lblUnits As Label
    Friend WithEvents lblEmployee2 As Label
    Friend WithEvents lblEmployee3 As Label
    Friend WithEvents txtUnitDisplay1 As TextBox
    Friend WithEvents txtUnitDisplay2 As TextBox
    Friend WithEvents txtUnitDisplay3 As TextBox
    Friend WithEvents lblEmployee1Average As Label
    Friend WithEvents lblEmployee2Average As Label
    Friend WithEvents lblEmployee3Average As Label
    Friend WithEvents lblTotalAverage As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents AverageunitsShippedToolTips As ToolTip
End Class
