<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class serviceform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(serviceform))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.bClose = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.tGSIS = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.tPhicNo = New System.Windows.Forms.TextBox()
        Me.tTIN = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.tFirstName = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.tMiddleName = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.tLastName = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.tPlace = New System.Windows.Forms.TextBox()
        Me.tEmployeeID = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.tDesignation = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tAnnualSalary = New System.Windows.Forms.TextBox()
        Me.tMonthlySalary = New System.Windows.Forms.TextBox()
        Me.tOffice = New System.Windows.Forms.TextBox()
        Me.tRemarks = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.cbAppointmentStatus = New System.Windows.Forms.ComboBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvServiceRecord = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.serviceID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvServiceRecord, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(17, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 18)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "New Service Record Form"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.NCIP
        Me.PictureBox1.Location = New System.Drawing.Point(912, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(118, 110)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 110
        Me.PictureBox1.TabStop = False
        '
        'bClose
        '
        Me.bClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bClose.ForeColor = System.Drawing.Color.White
        Me.bClose.Image = Global.WindowsApplication1.My.Resources.Resources.blankpage
        Me.bClose.Location = New System.Drawing.Point(890, 641)
        Me.bClose.Name = "bClose"
        Me.bClose.Size = New System.Drawing.Size(118, 32)
        Me.bClose.TabIndex = 11
        Me.bClose.Text = "Close"
        Me.bClose.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = Global.WindowsApplication1.My.Resources.Resources.blankpage
        Me.Button2.Location = New System.Drawing.Point(764, 641)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(118, 32)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Image = Global.WindowsApplication1.My.Resources.Resources.blankpage
        Me.Button1.Location = New System.Drawing.Point(640, 642)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 32)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1017, 501)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Service Record"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.Controls.Add(Me.GroupBox7)
        Me.GroupBox4.Controls.Add(Me.GroupBox6)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label38)
        Me.GroupBox4.Controls.Add(Me.Label36)
        Me.GroupBox4.Controls.Add(Me.GroupBox1)
        Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(6, -1)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1001, 496)
        Me.GroupBox4.TabIndex = 38
        Me.GroupBox4.TabStop = False
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.tGSIS)
        Me.GroupBox7.Controls.Add(Me.Label35)
        Me.GroupBox7.Controls.Add(Me.Label12)
        Me.GroupBox7.Controls.Add(Me.Label30)
        Me.GroupBox7.Controls.Add(Me.Label32)
        Me.GroupBox7.Controls.Add(Me.tPhicNo)
        Me.GroupBox7.Controls.Add(Me.tTIN)
        Me.GroupBox7.Controls.Add(Me.Label34)
        Me.GroupBox7.Controls.Add(Me.Label39)
        Me.GroupBox7.Controls.Add(Me.tFirstName)
        Me.GroupBox7.Controls.Add(Me.Label29)
        Me.GroupBox7.Controls.Add(Me.tMiddleName)
        Me.GroupBox7.Controls.Add(Me.Label16)
        Me.GroupBox7.Controls.Add(Me.tLastName)
        Me.GroupBox7.Controls.Add(Me.Label31)
        Me.GroupBox7.Controls.Add(Me.Label45)
        Me.GroupBox7.Controls.Add(Me.tPlace)
        Me.GroupBox7.Controls.Add(Me.tEmployeeID)
        Me.GroupBox7.Controls.Add(Me.Label17)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(14, 15)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(380, 312)
        Me.GroupBox7.TabIndex = 173
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Employee Information"
        '
        'tGSIS
        '
        Me.tGSIS.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tGSIS.Location = New System.Drawing.Point(167, 226)
        Me.tGSIS.Name = "tGSIS"
        Me.tGSIS.ReadOnly = True
        Me.tGSIS.Size = New System.Drawing.Size(184, 23)
        Me.tGSIS.TabIndex = 71
        Me.tGSIS.TabStop = False
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(25, 229)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(35, 15)
        Me.Label35.TabIndex = 70
        Me.Label35.Text = "GSIS"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Lucida Sans", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label12.Location = New System.Drawing.Point(262, 295)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(91, 13)
        Me.Label12.TabIndex = 69
        Me.Label12.Text = "XX-XXXXXXXXXX-X"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Lucida Sans", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label30.Location = New System.Drawing.Point(288, 253)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(61, 13)
        Me.Label30.TabIndex = 68
        Me.Label30.Text = "XXXXXXXXX"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Lucida Sans", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label32.Location = New System.Drawing.Point(286, 211)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(67, 13)
        Me.Label32.TabIndex = 63
        Me.Label32.Text = "XXX-XXX-XXX"
        '
        'tPhicNo
        '
        Me.tPhicNo.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tPhicNo.Location = New System.Drawing.Point(167, 270)
        Me.tPhicNo.Name = "tPhicNo"
        Me.tPhicNo.ReadOnly = True
        Me.tPhicNo.Size = New System.Drawing.Size(184, 23)
        Me.tPhicNo.TabIndex = 67
        Me.tPhicNo.TabStop = False
        '
        'tTIN
        '
        Me.tTIN.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tTIN.Location = New System.Drawing.Point(167, 187)
        Me.tTIN.Name = "tTIN"
        Me.tTIN.ReadOnly = True
        Me.tTIN.Size = New System.Drawing.Size(184, 23)
        Me.tTIN.TabIndex = 64
        Me.tTIN.TabStop = False
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(25, 270)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(61, 15)
        Me.Label34.TabIndex = 66
        Me.Label34.Text = "PHIC No:"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(25, 190)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(30, 15)
        Me.Label39.TabIndex = 65
        Me.Label39.Text = "TIN:"
        '
        'tFirstName
        '
        Me.tFirstName.Location = New System.Drawing.Point(167, 85)
        Me.tFirstName.Name = "tFirstName"
        Me.tFirstName.ReadOnly = True
        Me.tFirstName.Size = New System.Drawing.Size(199, 22)
        Me.tFirstName.TabIndex = 62
        Me.tFirstName.TabStop = False
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(25, 85)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(79, 16)
        Me.Label29.TabIndex = 61
        Me.Label29.Text = " First Name:"
        '
        'tMiddleName
        '
        Me.tMiddleName.Location = New System.Drawing.Point(167, 113)
        Me.tMiddleName.Name = "tMiddleName"
        Me.tMiddleName.ReadOnly = True
        Me.tMiddleName.Size = New System.Drawing.Size(199, 22)
        Me.tMiddleName.TabIndex = 60
        Me.tMiddleName.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(25, 113)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(89, 16)
        Me.Label16.TabIndex = 59
        Me.Label16.Text = "Middle Name"
        '
        'tLastName
        '
        Me.tLastName.Location = New System.Drawing.Point(167, 57)
        Me.tLastName.Name = "tLastName"
        Me.tLastName.ReadOnly = True
        Me.tLastName.Size = New System.Drawing.Size(199, 22)
        Me.tLastName.TabIndex = 58
        Me.tLastName.TabStop = False
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(25, 57)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(76, 16)
        Me.Label31.TabIndex = 57
        Me.Label31.Text = "Last Name:"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(25, 143)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(133, 16)
        Me.Label45.TabIndex = 54
        Me.Label45.Text = "Place of Assignment:"
        '
        'tPlace
        '
        Me.tPlace.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tPlace.Location = New System.Drawing.Point(167, 141)
        Me.tPlace.Name = "tPlace"
        Me.tPlace.ReadOnly = True
        Me.tPlace.Size = New System.Drawing.Size(186, 23)
        Me.tPlace.TabIndex = 53
        Me.tPlace.TabStop = False
        '
        'tEmployeeID
        '
        Me.tEmployeeID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tEmployeeID.Location = New System.Drawing.Point(167, 24)
        Me.tEmployeeID.Name = "tEmployeeID"
        Me.tEmployeeID.ReadOnly = True
        Me.tEmployeeID.Size = New System.Drawing.Size(151, 22)
        Me.tEmployeeID.TabIndex = 44
        Me.tEmployeeID.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(25, 24)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(89, 16)
        Me.Label17.TabIndex = 33
        Me.Label17.Text = "Employee ID:"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.GroupBox5)
        Me.GroupBox6.Controls.Add(Me.tDesignation)
        Me.GroupBox6.Controls.Add(Me.Label9)
        Me.GroupBox6.Controls.Add(Me.Label10)
        Me.GroupBox6.Controls.Add(Me.Label7)
        Me.GroupBox6.Controls.Add(Me.Label11)
        Me.GroupBox6.Controls.Add(Me.tAnnualSalary)
        Me.GroupBox6.Controls.Add(Me.tMonthlySalary)
        Me.GroupBox6.Controls.Add(Me.tOffice)
        Me.GroupBox6.Controls.Add(Me.tRemarks)
        Me.GroupBox6.Controls.Add(Me.Label33)
        Me.GroupBox6.Controls.Add(Me.cbAppointmentStatus)
        Me.GroupBox6.Controls.Add(Me.Label37)
        Me.GroupBox6.Location = New System.Drawing.Point(400, 15)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(593, 312)
        Me.GroupBox6.TabIndex = 170
        Me.GroupBox6.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.dtpFrom)
        Me.GroupBox5.Controls.Add(Me.dtpTo)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.Label28)
        Me.GroupBox5.Location = New System.Drawing.Point(346, 24)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(237, 194)
        Me.GroupBox5.TabIndex = 174
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Inclusive Dates of Employment"
        '
        'dtpFrom
        '
        Me.dtpFrom.CustomFormat = "M-dd-yyyy"
        Me.dtpFrom.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFrom.Location = New System.Drawing.Point(83, 43)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(93, 23)
        Me.dtpFrom.TabIndex = 7
        '
        'dtpTo
        '
        Me.dtpTo.CustomFormat = "M-dd-yyyy"
        Me.dtpTo.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTo.Location = New System.Drawing.Point(83, 81)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(97, 23)
        Me.dtpTo.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(25, 49)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(52, 15)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "FROM :"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(34, 85)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(32, 15)
        Me.Label28.TabIndex = 53
        Me.Label28.Text = "TO :"
        '
        'tDesignation
        '
        Me.tDesignation.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tDesignation.Location = New System.Drawing.Point(147, 29)
        Me.tDesignation.Name = "tDesignation"
        Me.tDesignation.Size = New System.Drawing.Size(172, 23)
        Me.tDesignation.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 15)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Designation :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 195)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(121, 15)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Office Assignment"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 146)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 15)
        Me.Label7.TabIndex = 171
        Me.Label7.Text = "Salary / Annum"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 232)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 15)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Remarks"
        '
        'tAnnualSalary
        '
        Me.tAnnualSalary.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tAnnualSalary.Location = New System.Drawing.Point(147, 146)
        Me.tAnnualSalary.Name = "tAnnualSalary"
        Me.tAnnualSalary.Size = New System.Drawing.Size(172, 23)
        Me.tAnnualSalary.TabIndex = 4
        '
        'tMonthlySalary
        '
        Me.tMonthlySalary.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tMonthlySalary.Location = New System.Drawing.Point(147, 110)
        Me.tMonthlySalary.Name = "tMonthlySalary"
        Me.tMonthlySalary.Size = New System.Drawing.Size(172, 23)
        Me.tMonthlySalary.TabIndex = 3
        '
        'tOffice
        '
        Me.tOffice.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tOffice.Location = New System.Drawing.Point(147, 195)
        Me.tOffice.Name = "tOffice"
        Me.tOffice.Size = New System.Drawing.Size(172, 23)
        Me.tOffice.TabIndex = 5
        '
        'tRemarks
        '
        Me.tRemarks.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tRemarks.Location = New System.Drawing.Point(147, 232)
        Me.tRemarks.Multiline = True
        Me.tRemarks.Name = "tRemarks"
        Me.tRemarks.Size = New System.Drawing.Size(436, 61)
        Me.tRemarks.TabIndex = 6
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(6, 68)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(123, 16)
        Me.Label33.TabIndex = 33
        Me.Label33.Text = "Appointment Status"
        '
        'cbAppointmentStatus
        '
        Me.cbAppointmentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAppointmentStatus.Items.AddRange(New Object() {"Tempory", "Permanent"})
        Me.cbAppointmentStatus.Location = New System.Drawing.Point(147, 68)
        Me.cbAppointmentStatus.Name = "cbAppointmentStatus"
        Me.cbAppointmentStatus.Size = New System.Drawing.Size(172, 24)
        Me.cbAppointmentStatus.TabIndex = 1
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(6, 110)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(99, 15)
        Me.Label37.TabIndex = 35
        Me.Label37.Text = "Salary / Month"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(596, 236)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 172
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Lucida Sans", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label38.Location = New System.Drawing.Point(945, 272)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(0, 13)
        Me.Label38.TabIndex = 40
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Lucida Sans", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label36.Location = New System.Drawing.Point(943, 233)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(0, 13)
        Me.Label36.TabIndex = 37
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvServiceRecord)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 327)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(975, 161)
        Me.GroupBox1.TabIndex = 174
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Individual Records"
        '
        'dgvServiceRecord
        '
        Me.dgvServiceRecord.AllowUserToAddRows = False
        Me.dgvServiceRecord.AllowUserToDeleteRows = False
        Me.dgvServiceRecord.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvServiceRecord.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvServiceRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvServiceRecord.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.serviceID, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column8, Me.Column7})
        Me.dgvServiceRecord.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvServiceRecord.Location = New System.Drawing.Point(12, 20)
        Me.dgvServiceRecord.Name = "dgvServiceRecord"
        Me.dgvServiceRecord.RowHeadersVisible = False
        Me.dgvServiceRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvServiceRecord.Size = New System.Drawing.Size(953, 132)
        Me.dgvServiceRecord.TabIndex = 8
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(5, 104)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1025, 527)
        Me.TabControl1.TabIndex = 167
        '
        'serviceID
        '
        Me.serviceID.DataPropertyName = "id"
        Me.serviceID.HeaderText = "ID"
        Me.serviceID.Name = "serviceID"
        Me.serviceID.Visible = False
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "fromdate"
        Me.Column1.HeaderText = "From"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 90
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "todate"
        Me.Column2.HeaderText = "To"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 90
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "designation"
        Me.Column3.HeaderText = "Designation"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "AppointmentStatus"
        Me.Column4.HeaderText = "Appointment Status"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 150
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "monthlysalary"
        Me.Column5.HeaderText = "Month Salary"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "annualsalary"
        Me.Column6.HeaderText = "Annual Salary"
        Me.Column6.Name = "Column6"
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "officeassignment"
        Me.Column8.HeaderText = "Office/Assignment"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 150
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "remarks"
        Me.Column7.HeaderText = "Remarks"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 200
        '
        'serviceform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.blankpage
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1035, 682)
        Me.Controls.Add(Me.bClose)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "serviceform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NCIP-CAR Service Record"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvServiceRecord, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents bClose As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvServiceRecord As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents tGSIS As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents tPhicNo As System.Windows.Forms.TextBox
    Friend WithEvents tTIN As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents tFirstName As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents tMiddleName As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents tLastName As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents tPlace As System.Windows.Forms.TextBox
    Friend WithEvents tEmployeeID As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents tDesignation As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tOffice As System.Windows.Forms.TextBox
    Friend WithEvents tRemarks As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents cbAppointmentStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents tAnnualSalary As System.Windows.Forms.TextBox
    Friend WithEvents tMonthlySalary As System.Windows.Forms.TextBox
    Friend WithEvents serviceID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
