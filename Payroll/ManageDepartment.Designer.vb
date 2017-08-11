<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageDepartment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageDepartment))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lID = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvDepartments = New System.Windows.Forms.DataGridView()
        Me.cID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.bClose = New System.Windows.Forms.Button()
        Me.bDelete = New System.Windows.Forms.Button()
        Me.bClear = New System.Windows.Forms.Button()
        Me.bSave = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvDepartments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(26, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 20)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Manage Department Details"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.WindowsApplication1.My.Resources.Resources.NCIP
        Me.PictureBox2.Location = New System.Drawing.Point(555, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(110, 98)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 113
        Me.PictureBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lID)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(294, 106)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(366, 260)
        Me.GroupBox1.TabIndex = 114
        Me.GroupBox1.TabStop = False
        '
        'tName
        '
        Me.tName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tName.Location = New System.Drawing.Point(134, 139)
        Me.tName.Name = "tName"
        Me.tName.Size = New System.Drawing.Size(216, 26)
        Me.tName.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Depart Name:"
        '
        'lID
        '
        Me.lID.AutoSize = True
        Me.lID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lID.ForeColor = System.Drawing.Color.Red
        Me.lID.Location = New System.Drawing.Point(134, 68)
        Me.lID.Name = "lID"
        Me.lID.Size = New System.Drawing.Size(42, 20)
        Me.lID.TabIndex = 1
        Me.lID.Text = "XXX"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 20)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Department ID :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvDepartments)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 106)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(279, 335)
        Me.GroupBox2.TabIndex = 114
        Me.GroupBox2.TabStop = False
        '
        'dgvDepartments
        '
        Me.dgvDepartments.AllowUserToAddRows = False
        Me.dgvDepartments.AllowUserToDeleteRows = False
        Me.dgvDepartments.AllowUserToOrderColumns = True
        Me.dgvDepartments.AllowUserToResizeColumns = False
        Me.dgvDepartments.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvDepartments.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDepartments.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cID, Me.cName})
        Me.dgvDepartments.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvDepartments.Location = New System.Drawing.Point(8, 16)
        Me.dgvDepartments.Name = "dgvDepartments"
        Me.dgvDepartments.RowHeadersVisible = False
        Me.dgvDepartments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvDepartments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDepartments.Size = New System.Drawing.Size(262, 310)
        Me.dgvDepartments.TabIndex = 5
        '
        'cID
        '
        Me.cID.DataPropertyName = "id"
        Me.cID.HeaderText = "ID"
        Me.cID.Name = "cID"
        Me.cID.Visible = False
        '
        'cName
        '
        Me.cName.DataPropertyName = "deptname"
        Me.cName.HeaderText = "Department Name"
        Me.cName.Name = "cName"
        Me.cName.ReadOnly = True
        Me.cName.Width = 225
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.bClose)
        Me.GroupBox3.Controls.Add(Me.bDelete)
        Me.GroupBox3.Controls.Add(Me.bClear)
        Me.GroupBox3.Controls.Add(Me.bSave)
        Me.GroupBox3.Location = New System.Drawing.Point(294, 372)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(366, 69)
        Me.GroupBox3.TabIndex = 114
        Me.GroupBox3.TabStop = False
        '
        'bClose
        '
        Me.bClose.BackgroundImage = CType(resources.GetObject("bClose.BackgroundImage"), System.Drawing.Image)
        Me.bClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bClose.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bClose.ForeColor = System.Drawing.Color.White
        Me.bClose.Location = New System.Drawing.Point(269, 19)
        Me.bClose.Name = "bClose"
        Me.bClose.Size = New System.Drawing.Size(81, 32)
        Me.bClose.TabIndex = 4
        Me.bClose.Text = "Close"
        Me.bClose.UseVisualStyleBackColor = True
        '
        'bDelete
        '
        Me.bDelete.BackgroundImage = CType(resources.GetObject("bDelete.BackgroundImage"), System.Drawing.Image)
        Me.bDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bDelete.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bDelete.ForeColor = System.Drawing.Color.White
        Me.bDelete.Location = New System.Drawing.Point(182, 19)
        Me.bDelete.Name = "bDelete"
        Me.bDelete.Size = New System.Drawing.Size(81, 32)
        Me.bDelete.TabIndex = 3
        Me.bDelete.Text = "Delete"
        Me.bDelete.UseVisualStyleBackColor = True
        '
        'bClear
        '
        Me.bClear.BackgroundImage = CType(resources.GetObject("bClear.BackgroundImage"), System.Drawing.Image)
        Me.bClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bClear.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bClear.ForeColor = System.Drawing.Color.White
        Me.bClear.Location = New System.Drawing.Point(95, 19)
        Me.bClear.Name = "bClear"
        Me.bClear.Size = New System.Drawing.Size(81, 32)
        Me.bClear.TabIndex = 2
        Me.bClear.Text = "Clear"
        Me.bClear.UseVisualStyleBackColor = True
        '
        'bSave
        '
        Me.bSave.BackgroundImage = CType(resources.GetObject("bSave.BackgroundImage"), System.Drawing.Image)
        Me.bSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bSave.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bSave.ForeColor = System.Drawing.Color.White
        Me.bSave.Location = New System.Drawing.Point(8, 19)
        Me.bSave.Name = "bSave"
        Me.bSave.Size = New System.Drawing.Size(81, 32)
        Me.bSave.TabIndex = 1
        Me.bSave.Text = "Save"
        Me.bSave.UseVisualStyleBackColor = True
        '
        'ManageDepartment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.blankpage
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(666, 447)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ManageDepartment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage Department Details"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvDepartments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents bSave As System.Windows.Forms.Button
    Friend WithEvents bClose As System.Windows.Forms.Button
    Friend WithEvents bDelete As System.Windows.Forms.Button
    Friend WithEvents bClear As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lID As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tName As System.Windows.Forms.TextBox
    Friend WithEvents dgvDepartments As System.Windows.Forms.DataGridView
    Friend WithEvents cID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cName As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
