<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManagePositions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManagePositions))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.bClose = New System.Windows.Forms.Button()
        Me.bDelete = New System.Windows.Forms.Button()
        Me.bClear = New System.Windows.Forms.Button()
        Me.bSave = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbDepartment = New System.Windows.Forms.ComboBox()
        Me.tBasicPay = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lID = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvDepartments = New System.Windows.Forms.DataGridView()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbSalaryGrade = New System.Windows.Forms.ComboBox()
        Me.cID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPosition = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cSalaryGrade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cBasicPay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cDeptID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvDepartments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.bClose)
        Me.GroupBox3.Controls.Add(Me.bDelete)
        Me.GroupBox3.Controls.Add(Me.bClear)
        Me.GroupBox3.Controls.Add(Me.bSave)
        Me.GroupBox3.Location = New System.Drawing.Point(654, 370)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(366, 69)
        Me.GroupBox3.TabIndex = 117
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
        Me.bClose.TabIndex = 6
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
        Me.bDelete.TabIndex = 5
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
        Me.bClear.TabIndex = 4
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
        Me.bSave.TabIndex = 3
        Me.bSave.Text = "Save"
        Me.bSave.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbSalaryGrade)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cbDepartment)
        Me.GroupBox1.Controls.Add(Me.tBasicPay)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lID)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(654, 104)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(366, 260)
        Me.GroupBox1.TabIndex = 118
        Me.GroupBox1.TabStop = False
        '
        'cbDepartment
        '
        Me.cbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDepartment.FormattingEnabled = True
        Me.cbDepartment.Location = New System.Drawing.Point(134, 87)
        Me.cbDepartment.Name = "cbDepartment"
        Me.cbDepartment.Size = New System.Drawing.Size(214, 21)
        Me.cbDepartment.TabIndex = 0
        '
        'tBasicPay
        '
        Me.tBasicPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tBasicPay.Location = New System.Drawing.Point(134, 200)
        Me.tBasicPay.Name = "tBasicPay"
        Me.tBasicPay.Size = New System.Drawing.Size(179, 26)
        Me.tBasicPay.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(38, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Basic Pay :"
        '
        'tName
        '
        Me.tName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tName.Location = New System.Drawing.Point(134, 123)
        Me.tName.Name = "tName"
        Me.tName.Size = New System.Drawing.Size(216, 26)
        Me.tName.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(48, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Job Title :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(319, 204)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 20)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Php"
        '
        'lID
        '
        Me.lID.AutoSize = True
        Me.lID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lID.ForeColor = System.Drawing.Color.Red
        Me.lID.Location = New System.Drawing.Point(134, 34)
        Me.lID.Name = "lID"
        Me.lID.Size = New System.Drawing.Size(42, 20)
        Me.lID.TabIndex = 1
        Me.lID.Text = "XXX"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Position ID :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(22, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 20)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Department :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(26, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 20)
        Me.Label1.TabIndex = 115
        Me.Label1.Text = "Manage Job Positions"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvDepartments)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 104)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(611, 335)
        Me.GroupBox2.TabIndex = 119
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
        Me.dgvDepartments.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cID, Me.cPosition, Me.cSalaryGrade, Me.cName, Me.cBasicPay, Me.cDeptID})
        Me.dgvDepartments.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvDepartments.Location = New System.Drawing.Point(25, 16)
        Me.dgvDepartments.Name = "dgvDepartments"
        Me.dgvDepartments.RowHeadersVisible = False
        Me.dgvDepartments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvDepartments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDepartments.Size = New System.Drawing.Size(577, 310)
        Me.dgvDepartments.TabIndex = 7
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.WindowsApplication1.My.Resources.Resources.NCIP
        Me.PictureBox2.Location = New System.Drawing.Point(909, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(110, 98)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 116
        Me.PictureBox2.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(14, 163)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 20)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Salary Grade :"
        '
        'cbSalaryGrade
        '
        Me.cbSalaryGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSalaryGrade.FormattingEnabled = True
        Me.cbSalaryGrade.Location = New System.Drawing.Point(136, 165)
        Me.cbSalaryGrade.Name = "cbSalaryGrade"
        Me.cbSalaryGrade.Size = New System.Drawing.Size(177, 21)
        Me.cbSalaryGrade.TabIndex = 5
        '
        'cID
        '
        Me.cID.DataPropertyName = "id"
        Me.cID.HeaderText = "ID"
        Me.cID.Name = "cID"
        Me.cID.Visible = False
        '
        'cPosition
        '
        Me.cPosition.DataPropertyName = "positionname"
        Me.cPosition.HeaderText = "Position"
        Me.cPosition.Name = "cPosition"
        Me.cPosition.Width = 150
        '
        'cSalaryGrade
        '
        Me.cSalaryGrade.DataPropertyName = "salarygrade"
        Me.cSalaryGrade.HeaderText = "Salary Grade"
        Me.cSalaryGrade.Name = "cSalaryGrade"
        Me.cSalaryGrade.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'cName
        '
        Me.cName.DataPropertyName = "deptname"
        Me.cName.HeaderText = "Department Name"
        Me.cName.Name = "cName"
        Me.cName.ReadOnly = True
        Me.cName.Width = 125
        '
        'cBasicPay
        '
        Me.cBasicPay.DataPropertyName = "basicpay"
        Me.cBasicPay.HeaderText = "Basic Pay"
        Me.cBasicPay.Name = "cBasicPay"
        '
        'cDeptID
        '
        Me.cDeptID.DataPropertyName = "deptid"
        Me.cDeptID.HeaderText = "DeptID"
        Me.cDeptID.Name = "cDeptID"
        Me.cDeptID.Visible = False
        '
        'ManagePositions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.blankpage
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1031, 443)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ManagePositions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage Job Positions"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvDepartments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents bClose As System.Windows.Forms.Button
    Friend WithEvents bDelete As System.Windows.Forms.Button
    Friend WithEvents bClear As System.Windows.Forms.Button
    Friend WithEvents bSave As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lID As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvDepartments As System.Windows.Forms.DataGridView
    Friend WithEvents cbDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tBasicPay As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbSalaryGrade As System.Windows.Forms.ComboBox
    Friend WithEvents cID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cPosition As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cSalaryGrade As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cBasicPay As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cDeptID As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
