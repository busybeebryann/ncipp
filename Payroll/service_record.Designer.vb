<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class service_record
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
        Me.CRsrviwer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CRsrviwer
        '
        Me.CRsrviwer.ActiveViewIndex = -1
        Me.CRsrviwer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRsrviwer.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRsrviwer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRsrviwer.Location = New System.Drawing.Point(0, 0)
        Me.CRsrviwer.Name = "CRsrviwer"
        Me.CRsrviwer.Size = New System.Drawing.Size(1028, 643)
        Me.CRsrviwer.TabIndex = 0
        '
        'service_record
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 643)
        Me.Controls.Add(Me.CRsrviwer)
        Me.Name = "service_record"
        Me.Text = "service_record"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CRsrviwer As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
