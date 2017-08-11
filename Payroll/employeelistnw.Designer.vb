<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class employeelistnew
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(employeelistnew))
        Me.bUpdate = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bClose = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.bRefresh = New System.Windows.Forms.Button()
        Me.bAdd = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bUpdate
        '
        Me.bUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bUpdate.ForeColor = System.Drawing.Color.White
        Me.bUpdate.Image = Global.WindowsApplication1.My.Resources.Resources.blankpage
        Me.bUpdate.Location = New System.Drawing.Point(555, 122)
        Me.bUpdate.Name = "bUpdate"
        Me.bUpdate.Size = New System.Drawing.Size(118, 32)
        Me.bUpdate.TabIndex = 46
        Me.bUpdate.Text = "Update"
        Me.bUpdate.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 16)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Keyword"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(12, 125)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(328, 29)
        Me.TextBox1.TabIndex = 42
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(11, 160)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1056, 512)
        Me.DataGridView1.TabIndex = 41
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(17, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 18)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "List Of Employee"
        '
        'bClose
        '
        Me.bClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bClose.ForeColor = System.Drawing.Color.White
        Me.bClose.Image = Global.WindowsApplication1.My.Resources.Resources.blankpage
        Me.bClose.Location = New System.Drawing.Point(679, 122)
        Me.bClose.Name = "bClose"
        Me.bClose.Size = New System.Drawing.Size(118, 32)
        Me.bClose.TabIndex = 48
        Me.bClose.Text = "Close"
        Me.bClose.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.NCIP
        Me.PictureBox1.Location = New System.Drawing.Point(940, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(127, 121)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 110
        Me.PictureBox1.TabStop = False
        '
        'bRefresh
        '
        Me.bRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bRefresh.ForeColor = System.Drawing.Color.White
        Me.bRefresh.Image = Global.WindowsApplication1.My.Resources.Resources.blankpage
        Me.bRefresh.Location = New System.Drawing.Point(803, 122)
        Me.bRefresh.Name = "bRefresh"
        Me.bRefresh.Size = New System.Drawing.Size(118, 32)
        Me.bRefresh.TabIndex = 111
        Me.bRefresh.Text = "Refresh"
        Me.bRefresh.UseVisualStyleBackColor = True
        '
        'bAdd
        '
        Me.bAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bAdd.ForeColor = System.Drawing.Color.White
        Me.bAdd.Image = Global.WindowsApplication1.My.Resources.Resources.blankpage
        Me.bAdd.Location = New System.Drawing.Point(431, 122)
        Me.bAdd.Name = "bAdd"
        Me.bAdd.Size = New System.Drawing.Size(118, 32)
        Me.bAdd.TabIndex = 112
        Me.bAdd.Text = "Add"
        Me.bAdd.UseVisualStyleBackColor = True
        '
        'employeelistnew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.blankpage
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1079, 738)
        Me.Controls.Add(Me.bAdd)
        Me.Controls.Add(Me.bRefresh)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.bClose)
        Me.Controls.Add(Me.bUpdate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "employeelistnew"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NCIP-CAR Employee_List"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bUpdate As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bClose As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents bRefresh As System.Windows.Forms.Button
    Friend WithEvents bAdd As System.Windows.Forms.Button
End Class
