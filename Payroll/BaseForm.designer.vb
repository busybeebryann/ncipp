<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BaseForm
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
        Me.LabelOfForm = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.save = New System.Windows.Forms.Button()
        Me.edit = New System.Windows.Forms.Button()
        Me.delete = New System.Windows.Forms.Button()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelOfForm
        '
        Me.LabelOfForm.AutoSize = True
        Me.LabelOfForm.BackColor = System.Drawing.Color.Transparent
        Me.LabelOfForm.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelOfForm.ForeColor = System.Drawing.Color.White
        Me.LabelOfForm.Location = New System.Drawing.Point(12, 9)
        Me.LabelOfForm.Name = "LabelOfForm"
        Me.LabelOfForm.Size = New System.Drawing.Size(106, 22)
        Me.LabelOfForm.TabIndex = 37
        Me.LabelOfForm.Text = "Base Form"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.WindowsApplication1.My.Resources.Resources.NCIP
        Me.PictureBox3.Location = New System.Drawing.Point(652, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(127, 121)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 111
        Me.PictureBox3.TabStop = False
        '
        'save
        '
        Me.save.Location = New System.Drawing.Point(455, 163)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(75, 23)
        Me.save.TabIndex = 112
        Me.save.Text = "Button1"
        Me.save.UseVisualStyleBackColor = True
        '
        'edit
        '
        Me.edit.Location = New System.Drawing.Point(540, 163)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(75, 23)
        Me.edit.TabIndex = 113
        Me.edit.Text = "Button2"
        Me.edit.UseVisualStyleBackColor = True
        '
        'delete
        '
        Me.delete.Location = New System.Drawing.Point(621, 163)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(75, 23)
        Me.delete.TabIndex = 114
        Me.delete.Text = "Button3"
        Me.delete.UseVisualStyleBackColor = True
        '
        'BaseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.blankpage
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(791, 636)
        Me.Controls.Add(Me.delete)
        Me.Controls.Add(Me.edit)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.LabelOfForm)
        Me.Name = "BaseForm"
        Me.Text = "BaseForm"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelOfForm As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents save As System.Windows.Forms.Button
    Friend WithEvents edit As System.Windows.Forms.Button
    Friend WithEvents delete As System.Windows.Forms.Button
End Class
