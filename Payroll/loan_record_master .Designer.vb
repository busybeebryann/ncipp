<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loan_record_master
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loan_record_master))
        Me.dgvEmployees = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AppointmentStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BasicPay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bAdd = New System.Windows.Forms.Button()
        Me.ListBox23 = New System.Windows.Forms.ListBox()
        Me.ListBox22 = New System.Windows.Forms.ListBox()
        Me.ListBox21 = New System.Windows.Forms.ListBox()
        Me.ListBox20 = New System.Windows.Forms.ListBox()
        Me.ListBox19 = New System.Windows.Forms.ListBox()
        Me.ListBox18 = New System.Windows.Forms.ListBox()
        Me.ListBox17 = New System.Windows.Forms.ListBox()
        Me.ListBox16 = New System.Windows.Forms.ListBox()
        Me.ListBox15 = New System.Windows.Forms.ListBox()
        Me.ListBox14 = New System.Windows.Forms.ListBox()
        Me.ListBox13 = New System.Windows.Forms.ListBox()
        Me.ListBox12 = New System.Windows.Forms.ListBox()
        Me.ListBox11 = New System.Windows.Forms.ListBox()
        Me.ListBox10 = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ListBox9 = New System.Windows.Forms.ListBox()
        Me.ListBox8 = New System.Windows.Forms.ListBox()
        Me.ListBox7 = New System.Windows.Forms.ListBox()
        Me.ListBox6 = New System.Windows.Forms.ListBox()
        Me.ListBox5 = New System.Windows.Forms.ListBox()
        Me.ListBox4 = New System.Windows.Forms.ListBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.cbEmpID = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ListBox24 = New System.Windows.Forms.ListBox()
        Me.ListBox25 = New System.Windows.Forms.ListBox()
        Me.ListBox26 = New System.Windows.Forms.ListBox()
        Me.ListBox27 = New System.Windows.Forms.ListBox()
        Me.ListBox28 = New System.Windows.Forms.ListBox()
        Me.ListBox29 = New System.Windows.Forms.ListBox()
        Me.ListBox30 = New System.Windows.Forms.ListBox()
        Me.ListBox31 = New System.Windows.Forms.ListBox()
        Me.ListBox32 = New System.Windows.Forms.ListBox()
        Me.ListBox33 = New System.Windows.Forms.ListBox()
        Me.ListBox34 = New System.Windows.Forms.ListBox()
        Me.ListBox35 = New System.Windows.Forms.ListBox()
        Me.ListBox36 = New System.Windows.Forms.ListBox()
        Me.ListBox37 = New System.Windows.Forms.ListBox()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.bClose = New System.Windows.Forms.Button()
        Me.bRefresh = New System.Windows.Forms.Button()
        CType(Me.dgvEmployees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvEmployees
        '
        Me.dgvEmployees.AllowUserToAddRows = False
        Me.dgvEmployees.AllowUserToDeleteRows = False
        Me.dgvEmployees.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
        Me.dgvEmployees.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmployees.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.EmployeeID, Me.LastName, Me.FirstName, Me.AppointmentStatus, Me.BasicPay})
        Me.dgvEmployees.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvEmployees.Location = New System.Drawing.Point(13, 218)
        Me.dgvEmployees.MultiSelect = False
        Me.dgvEmployees.Name = "dgvEmployees"
        Me.dgvEmployees.RowHeadersVisible = False
        Me.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEmployees.Size = New System.Drawing.Size(1056, 454)
        Me.dgvEmployees.TabIndex = 110
        '
        'ID
        '
        Me.ID.DataPropertyName = "user_id"
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.Visible = False
        '
        'EmployeeID
        '
        Me.EmployeeID.DataPropertyName = "emp_id"
        Me.EmployeeID.HeaderText = "Employee ID"
        Me.EmployeeID.Name = "EmployeeID"
        Me.EmployeeID.Width = 150
        '
        'LastName
        '
        Me.LastName.DataPropertyName = "last_name"
        Me.LastName.HeaderText = "Last Name"
        Me.LastName.Name = "LastName"
        Me.LastName.Width = 200
        '
        'FirstName
        '
        Me.FirstName.DataPropertyName = "first_name"
        Me.FirstName.HeaderText = "First Name"
        Me.FirstName.Name = "FirstName"
        Me.FirstName.Width = 200
        '
        'AppointmentStatus
        '
        Me.AppointmentStatus.DataPropertyName = "status"
        Me.AppointmentStatus.HeaderText = "Appointment Status"
        Me.AppointmentStatus.Name = "AppointmentStatus"
        Me.AppointmentStatus.Width = 125
        '
        'BasicPay
        '
        Me.BasicPay.DataPropertyName = "basic_pay"
        Me.BasicPay.HeaderText = "Basic Pay"
        Me.BasicPay.Name = "BasicPay"
        Me.BasicPay.Width = 150
        '
        'bAdd
        '
        Me.bAdd.BackgroundImage = CType(resources.GetObject("bAdd.BackgroundImage"), System.Drawing.Image)
        Me.bAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bAdd.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bAdd.ForeColor = System.Drawing.Color.White
        Me.bAdd.Location = New System.Drawing.Point(737, 184)
        Me.bAdd.Name = "bAdd"
        Me.bAdd.Size = New System.Drawing.Size(106, 30)
        Me.bAdd.TabIndex = 145
        Me.bAdd.Text = "Add / Update"
        Me.bAdd.UseVisualStyleBackColor = True
        '
        'ListBox23
        '
        Me.ListBox23.FormattingEnabled = True
        Me.ListBox23.Location = New System.Drawing.Point(689, 372)
        Me.ListBox23.Name = "ListBox23"
        Me.ListBox23.Size = New System.Drawing.Size(47, 95)
        Me.ListBox23.TabIndex = 143
        '
        'ListBox22
        '
        Me.ListBox22.FormattingEnabled = True
        Me.ListBox22.Location = New System.Drawing.Point(636, 372)
        Me.ListBox22.Name = "ListBox22"
        Me.ListBox22.Size = New System.Drawing.Size(47, 95)
        Me.ListBox22.TabIndex = 142
        '
        'ListBox21
        '
        Me.ListBox21.FormattingEnabled = True
        Me.ListBox21.Location = New System.Drawing.Point(583, 372)
        Me.ListBox21.Name = "ListBox21"
        Me.ListBox21.Size = New System.Drawing.Size(47, 95)
        Me.ListBox21.TabIndex = 141
        '
        'ListBox20
        '
        Me.ListBox20.FormattingEnabled = True
        Me.ListBox20.Location = New System.Drawing.Point(530, 372)
        Me.ListBox20.Name = "ListBox20"
        Me.ListBox20.Size = New System.Drawing.Size(47, 95)
        Me.ListBox20.TabIndex = 140
        '
        'ListBox19
        '
        Me.ListBox19.FormattingEnabled = True
        Me.ListBox19.Location = New System.Drawing.Point(477, 372)
        Me.ListBox19.Name = "ListBox19"
        Me.ListBox19.Size = New System.Drawing.Size(47, 95)
        Me.ListBox19.TabIndex = 139
        '
        'ListBox18
        '
        Me.ListBox18.FormattingEnabled = True
        Me.ListBox18.Location = New System.Drawing.Point(424, 372)
        Me.ListBox18.Name = "ListBox18"
        Me.ListBox18.Size = New System.Drawing.Size(47, 95)
        Me.ListBox18.TabIndex = 138
        '
        'ListBox17
        '
        Me.ListBox17.FormattingEnabled = True
        Me.ListBox17.Location = New System.Drawing.Point(371, 372)
        Me.ListBox17.Name = "ListBox17"
        Me.ListBox17.Size = New System.Drawing.Size(47, 95)
        Me.ListBox17.TabIndex = 137
        '
        'ListBox16
        '
        Me.ListBox16.FormattingEnabled = True
        Me.ListBox16.Location = New System.Drawing.Point(318, 372)
        Me.ListBox16.Name = "ListBox16"
        Me.ListBox16.Size = New System.Drawing.Size(47, 95)
        Me.ListBox16.TabIndex = 136
        '
        'ListBox15
        '
        Me.ListBox15.FormattingEnabled = True
        Me.ListBox15.Location = New System.Drawing.Point(265, 372)
        Me.ListBox15.Name = "ListBox15"
        Me.ListBox15.Size = New System.Drawing.Size(47, 95)
        Me.ListBox15.TabIndex = 135
        '
        'ListBox14
        '
        Me.ListBox14.FormattingEnabled = True
        Me.ListBox14.Location = New System.Drawing.Point(212, 372)
        Me.ListBox14.Name = "ListBox14"
        Me.ListBox14.Size = New System.Drawing.Size(47, 95)
        Me.ListBox14.TabIndex = 134
        '
        'ListBox13
        '
        Me.ListBox13.FormattingEnabled = True
        Me.ListBox13.Location = New System.Drawing.Point(159, 372)
        Me.ListBox13.Name = "ListBox13"
        Me.ListBox13.Size = New System.Drawing.Size(47, 95)
        Me.ListBox13.TabIndex = 133
        '
        'ListBox12
        '
        Me.ListBox12.FormattingEnabled = True
        Me.ListBox12.Location = New System.Drawing.Point(742, 271)
        Me.ListBox12.Name = "ListBox12"
        Me.ListBox12.Size = New System.Drawing.Size(47, 95)
        Me.ListBox12.TabIndex = 132
        '
        'ListBox11
        '
        Me.ListBox11.FormattingEnabled = True
        Me.ListBox11.Location = New System.Drawing.Point(689, 271)
        Me.ListBox11.Name = "ListBox11"
        Me.ListBox11.Size = New System.Drawing.Size(47, 95)
        Me.ListBox11.TabIndex = 131
        '
        'ListBox10
        '
        Me.ListBox10.FormattingEnabled = True
        Me.ListBox10.Location = New System.Drawing.Point(636, 271)
        Me.ListBox10.Name = "ListBox10"
        Me.ListBox10.Size = New System.Drawing.Size(47, 95)
        Me.ListBox10.TabIndex = 130
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 218)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 9)
        Me.Label6.TabIndex = 129
        Me.Label6.Text = "Label6"
        '
        'ListBox9
        '
        Me.ListBox9.FormattingEnabled = True
        Me.ListBox9.Location = New System.Drawing.Point(583, 271)
        Me.ListBox9.Name = "ListBox9"
        Me.ListBox9.Size = New System.Drawing.Size(47, 95)
        Me.ListBox9.TabIndex = 128
        '
        'ListBox8
        '
        Me.ListBox8.FormattingEnabled = True
        Me.ListBox8.Location = New System.Drawing.Point(530, 271)
        Me.ListBox8.Name = "ListBox8"
        Me.ListBox8.Size = New System.Drawing.Size(47, 95)
        Me.ListBox8.TabIndex = 127
        '
        'ListBox7
        '
        Me.ListBox7.FormattingEnabled = True
        Me.ListBox7.Location = New System.Drawing.Point(477, 271)
        Me.ListBox7.Name = "ListBox7"
        Me.ListBox7.Size = New System.Drawing.Size(47, 95)
        Me.ListBox7.TabIndex = 126
        '
        'ListBox6
        '
        Me.ListBox6.FormattingEnabled = True
        Me.ListBox6.Location = New System.Drawing.Point(424, 271)
        Me.ListBox6.Name = "ListBox6"
        Me.ListBox6.Size = New System.Drawing.Size(47, 95)
        Me.ListBox6.TabIndex = 125
        '
        'ListBox5
        '
        Me.ListBox5.FormattingEnabled = True
        Me.ListBox5.Location = New System.Drawing.Point(371, 271)
        Me.ListBox5.Name = "ListBox5"
        Me.ListBox5.Size = New System.Drawing.Size(47, 95)
        Me.ListBox5.TabIndex = 124
        '
        'ListBox4
        '
        Me.ListBox4.FormattingEnabled = True
        Me.ListBox4.Location = New System.Drawing.Point(318, 271)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(47, 95)
        Me.ListBox4.TabIndex = 123
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Location = New System.Drawing.Point(265, 271)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(47, 95)
        Me.ListBox3.TabIndex = 122
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(212, 271)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(47, 95)
        Me.ListBox2.TabIndex = 121
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(159, 271)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(47, 95)
        Me.ListBox1.TabIndex = 120
        '
        'cbEmpID
        '
        Me.cbEmpID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEmpID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEmpID.FormattingEnabled = True
        Me.cbEmpID.Location = New System.Drawing.Point(12, 184)
        Me.cbEmpID.Name = "cbEmpID"
        Me.cbEmpID.Size = New System.Drawing.Size(220, 28)
        Me.cbEmpID.TabIndex = 115
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 20)
        Me.Label4.TabIndex = 113
        Me.Label4.Text = "Employee ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 20)
        Me.Label2.TabIndex = 111
        Me.Label2.Text = "Search By:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(16, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 20)
        Me.Label1.TabIndex = 109
        Me.Label1.Text = "Loans and Contributions"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.NCIP
        Me.PictureBox1.Location = New System.Drawing.Point(940, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(127, 121)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 146
        Me.PictureBox1.TabStop = False
        '
        'ListBox24
        '
        Me.ListBox24.FormattingEnabled = True
        Me.ListBox24.Location = New System.Drawing.Point(742, 372)
        Me.ListBox24.Name = "ListBox24"
        Me.ListBox24.Size = New System.Drawing.Size(47, 95)
        Me.ListBox24.TabIndex = 147
        '
        'ListBox25
        '
        Me.ListBox25.FormattingEnabled = True
        Me.ListBox25.Location = New System.Drawing.Point(516, 294)
        Me.ListBox25.Name = "ListBox25"
        Me.ListBox25.Size = New System.Drawing.Size(47, 95)
        Me.ListBox25.TabIndex = 148
        '
        'ListBox26
        '
        Me.ListBox26.FormattingEnabled = True
        Me.ListBox26.Location = New System.Drawing.Point(524, 302)
        Me.ListBox26.Name = "ListBox26"
        Me.ListBox26.Size = New System.Drawing.Size(47, 95)
        Me.ListBox26.TabIndex = 149
        '
        'ListBox27
        '
        Me.ListBox27.FormattingEnabled = True
        Me.ListBox27.Location = New System.Drawing.Point(532, 310)
        Me.ListBox27.Name = "ListBox27"
        Me.ListBox27.Size = New System.Drawing.Size(47, 95)
        Me.ListBox27.TabIndex = 150
        '
        'ListBox28
        '
        Me.ListBox28.FormattingEnabled = True
        Me.ListBox28.Location = New System.Drawing.Point(540, 318)
        Me.ListBox28.Name = "ListBox28"
        Me.ListBox28.Size = New System.Drawing.Size(47, 95)
        Me.ListBox28.TabIndex = 151
        '
        'ListBox29
        '
        Me.ListBox29.FormattingEnabled = True
        Me.ListBox29.Location = New System.Drawing.Point(548, 326)
        Me.ListBox29.Name = "ListBox29"
        Me.ListBox29.Size = New System.Drawing.Size(47, 95)
        Me.ListBox29.TabIndex = 152
        '
        'ListBox30
        '
        Me.ListBox30.FormattingEnabled = True
        Me.ListBox30.Location = New System.Drawing.Point(556, 334)
        Me.ListBox30.Name = "ListBox30"
        Me.ListBox30.Size = New System.Drawing.Size(47, 95)
        Me.ListBox30.TabIndex = 153
        '
        'ListBox31
        '
        Me.ListBox31.FormattingEnabled = True
        Me.ListBox31.Location = New System.Drawing.Point(564, 342)
        Me.ListBox31.Name = "ListBox31"
        Me.ListBox31.Size = New System.Drawing.Size(47, 95)
        Me.ListBox31.TabIndex = 154
        '
        'ListBox32
        '
        Me.ListBox32.FormattingEnabled = True
        Me.ListBox32.Location = New System.Drawing.Point(572, 350)
        Me.ListBox32.Name = "ListBox32"
        Me.ListBox32.Size = New System.Drawing.Size(47, 95)
        Me.ListBox32.TabIndex = 155
        '
        'ListBox33
        '
        Me.ListBox33.FormattingEnabled = True
        Me.ListBox33.Location = New System.Drawing.Point(580, 358)
        Me.ListBox33.Name = "ListBox33"
        Me.ListBox33.Size = New System.Drawing.Size(47, 95)
        Me.ListBox33.TabIndex = 156
        '
        'ListBox34
        '
        Me.ListBox34.FormattingEnabled = True
        Me.ListBox34.Location = New System.Drawing.Point(588, 366)
        Me.ListBox34.Name = "ListBox34"
        Me.ListBox34.Size = New System.Drawing.Size(47, 95)
        Me.ListBox34.TabIndex = 157
        '
        'ListBox35
        '
        Me.ListBox35.FormattingEnabled = True
        Me.ListBox35.Location = New System.Drawing.Point(596, 374)
        Me.ListBox35.Name = "ListBox35"
        Me.ListBox35.Size = New System.Drawing.Size(47, 95)
        Me.ListBox35.TabIndex = 158
        '
        'ListBox36
        '
        Me.ListBox36.FormattingEnabled = True
        Me.ListBox36.Location = New System.Drawing.Point(604, 382)
        Me.ListBox36.Name = "ListBox36"
        Me.ListBox36.Size = New System.Drawing.Size(47, 95)
        Me.ListBox36.TabIndex = 159
        '
        'ListBox37
        '
        Me.ListBox37.FormattingEnabled = True
        Me.ListBox37.Location = New System.Drawing.Point(612, 390)
        Me.ListBox37.Name = "ListBox37"
        Me.ListBox37.Size = New System.Drawing.Size(47, 95)
        Me.ListBox37.TabIndex = 160
        '
        'tbName
        '
        Me.tbName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbName.Location = New System.Drawing.Point(265, 184)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(233, 26)
        Me.tbName.TabIndex = 163
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(261, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 20)
        Me.Label3.TabIndex = 162
        Me.Label3.Text = "Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(260, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 20)
        Me.Label5.TabIndex = 161
        Me.Label5.Text = "Search By:"
        '
        'bClose
        '
        Me.bClose.BackgroundImage = CType(resources.GetObject("bClose.BackgroundImage"), System.Drawing.Image)
        Me.bClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bClose.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bClose.ForeColor = System.Drawing.Color.White
        Me.bClose.Location = New System.Drawing.Point(961, 184)
        Me.bClose.Name = "bClose"
        Me.bClose.Size = New System.Drawing.Size(106, 30)
        Me.bClose.TabIndex = 164
        Me.bClose.Text = "Close"
        Me.bClose.UseVisualStyleBackColor = True
        '
        'bRefresh
        '
        Me.bRefresh.BackgroundImage = CType(resources.GetObject("bRefresh.BackgroundImage"), System.Drawing.Image)
        Me.bRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bRefresh.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bRefresh.ForeColor = System.Drawing.Color.White
        Me.bRefresh.Location = New System.Drawing.Point(849, 184)
        Me.bRefresh.Name = "bRefresh"
        Me.bRefresh.Size = New System.Drawing.Size(106, 30)
        Me.bRefresh.TabIndex = 164
        Me.bRefresh.Text = "Refresh"
        Me.bRefresh.UseVisualStyleBackColor = True
        '
        'loan_record_master
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.blankpage
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1079, 682)
        Me.Controls.Add(Me.bRefresh)
        Me.Controls.Add(Me.bClose)
        Me.Controls.Add(Me.tbName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dgvEmployees)
        Me.Controls.Add(Me.ListBox37)
        Me.Controls.Add(Me.ListBox36)
        Me.Controls.Add(Me.ListBox35)
        Me.Controls.Add(Me.ListBox34)
        Me.Controls.Add(Me.ListBox33)
        Me.Controls.Add(Me.ListBox32)
        Me.Controls.Add(Me.ListBox31)
        Me.Controls.Add(Me.ListBox30)
        Me.Controls.Add(Me.ListBox29)
        Me.Controls.Add(Me.ListBox28)
        Me.Controls.Add(Me.ListBox27)
        Me.Controls.Add(Me.ListBox26)
        Me.Controls.Add(Me.ListBox25)
        Me.Controls.Add(Me.ListBox24)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.bAdd)
        Me.Controls.Add(Me.ListBox23)
        Me.Controls.Add(Me.ListBox22)
        Me.Controls.Add(Me.ListBox21)
        Me.Controls.Add(Me.ListBox20)
        Me.Controls.Add(Me.ListBox19)
        Me.Controls.Add(Me.ListBox18)
        Me.Controls.Add(Me.ListBox17)
        Me.Controls.Add(Me.ListBox16)
        Me.Controls.Add(Me.ListBox15)
        Me.Controls.Add(Me.ListBox14)
        Me.Controls.Add(Me.ListBox13)
        Me.Controls.Add(Me.ListBox12)
        Me.Controls.Add(Me.ListBox11)
        Me.Controls.Add(Me.ListBox10)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ListBox9)
        Me.Controls.Add(Me.ListBox8)
        Me.Controls.Add(Me.ListBox7)
        Me.Controls.Add(Me.ListBox6)
        Me.Controls.Add(Me.ListBox5)
        Me.Controls.Add(Me.ListBox4)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.cbEmpID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "loan_record_master"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NCIP-CAR  Loan Master"
        CType(Me.dgvEmployees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvEmployees As System.Windows.Forms.DataGridView
    Friend WithEvents bAdd As System.Windows.Forms.Button
    Friend WithEvents ListBox23 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox22 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox21 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox20 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox19 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox18 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox17 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox16 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox15 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox14 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox13 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox12 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox11 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox10 As System.Windows.Forms.ListBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ListBox9 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox8 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox7 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox6 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox5 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox4 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox3 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents cbEmpID As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ListBox24 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox25 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox26 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox27 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox28 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox29 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox30 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox31 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox32 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox33 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox34 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox35 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox36 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox37 As System.Windows.Forms.ListBox
    Friend WithEvents tbName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents bClose As System.Windows.Forms.Button
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmployeeID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AppointmentStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BasicPay As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bRefresh As System.Windows.Forms.Button
End Class
