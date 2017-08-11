<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportViewer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportViewer))
        Me.crvPayroll = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'crvPayroll
        '
        Me.crvPayroll.ActiveViewIndex = -1
        Me.crvPayroll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvPayroll.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvPayroll.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvPayroll.Location = New System.Drawing.Point(0, 0)
        Me.crvPayroll.Name = "crvPayroll"
        Me.crvPayroll.Size = New System.Drawing.Size(803, 501)
        Me.crvPayroll.TabIndex = 0
        '
        'ReportViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 501)
        Me.Controls.Add(Me.crvPayroll)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ReportViewer"
        Me.Text = "Payroll Reporting Services"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crvPayroll As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
