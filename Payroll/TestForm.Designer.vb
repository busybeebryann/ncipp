<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestForm
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.btnJobPos = New System.Windows.Forms.Button()
        Me.btnEmployee = New System.Windows.Forms.Button()
        Me.btnMLeaves = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(39, 108)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Loan Master"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(39, 79)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(137, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Payroll Master"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(39, 137)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(137, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Attendance Tracker"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(39, 166)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(137, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Manual Attendance"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(213, 79)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(137, 23)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Monthly Payroll"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(213, 108)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(137, 23)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Payroll Date Range"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'btnJobPos
        '
        Me.btnJobPos.Location = New System.Drawing.Point(213, 137)
        Me.btnJobPos.Name = "btnJobPos"
        Me.btnJobPos.Size = New System.Drawing.Size(137, 23)
        Me.btnJobPos.TabIndex = 6
        Me.btnJobPos.Text = "Salary Grade Check"
        Me.btnJobPos.UseVisualStyleBackColor = True
        '
        'btnEmployee
        '
        Me.btnEmployee.Location = New System.Drawing.Point(213, 166)
        Me.btnEmployee.Name = "btnEmployee"
        Me.btnEmployee.Size = New System.Drawing.Size(137, 23)
        Me.btnEmployee.TabIndex = 7
        Me.btnEmployee.Text = "Check Employee"
        Me.btnEmployee.UseVisualStyleBackColor = True
        '
        'btnMLeaves
        '
        Me.btnMLeaves.Location = New System.Drawing.Point(39, 195)
        Me.btnMLeaves.Name = "btnMLeaves"
        Me.btnMLeaves.Size = New System.Drawing.Size(137, 23)
        Me.btnMLeaves.TabIndex = 8
        Me.btnMLeaves.Text = "Manage Leaves"
        Me.btnMLeaves.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(39, 224)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(137, 23)
        Me.Button7.TabIndex = 9
        Me.Button7.Text = "Manage Leaves - Test Print"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'TestForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 413)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.btnMLeaves)
        Me.Controls.Add(Me.btnEmployee)
        Me.Controls.Add(Me.btnJobPos)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "TestForm"
        Me.Text = "TestLoanAmorntization"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents btnJobPos As System.Windows.Forms.Button
    Friend WithEvents btnEmployee As System.Windows.Forms.Button
    Friend WithEvents btnMLeaves As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
End Class
