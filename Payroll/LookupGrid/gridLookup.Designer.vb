<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gridLookup
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgShedule = New System.Windows.Forms.DataGridView()
        Me.button = New System.Windows.Forms.Button()
        CType(Me.dgShedule, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 22)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Schedules"
        '
        'dgShedule
        '
        Me.dgShedule.AllowUserToAddRows = False
        Me.dgShedule.AllowUserToDeleteRows = False
        Me.dgShedule.AllowUserToResizeColumns = False
        Me.dgShedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgShedule.Location = New System.Drawing.Point(16, 124)
        Me.dgShedule.MultiSelect = False
        Me.dgShedule.Name = "dgShedule"
        Me.dgShedule.ReadOnly = True
        Me.dgShedule.RowHeadersVisible = False
        Me.dgShedule.Size = New System.Drawing.Size(758, 317)
        Me.dgShedule.TabIndex = 38
        '
        'button
        '
        Me.button.BackColor = System.Drawing.Color.Transparent
        Me.button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button.ForeColor = System.Drawing.Color.Transparent
        Me.button.Image = Global.WindowsApplication1.My.Resources.Resources.blankpage
        Me.button.Location = New System.Drawing.Point(657, 450)
        Me.button.Name = "button"
        Me.button.Size = New System.Drawing.Size(117, 23)
        Me.button.TabIndex = 212
        Me.button.Text = "Close"
        Me.button.UseVisualStyleBackColor = False
        '
        'gridLookup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.blankpage
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(786, 485)
        Me.ControlBox = False
        Me.Controls.Add(Me.button)
        Me.Controls.Add(Me.dgShedule)
        Me.Controls.Add(Me.Label1)
        Me.Name = "gridLookup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgShedule, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgShedule As System.Windows.Forms.DataGridView
    Friend WithEvents button As System.Windows.Forms.Button
End Class
