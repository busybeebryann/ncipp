Imports System.Data.SqlClient
Imports System.Data
Imports WindowsApplication1.Extensions
Public Class Add_Employee
    Dim objSettings As New GlobalSettings
    Public employeeid As String
    Dim age As Integer
    Dim gender As String = "none"
    Dim acsconn As New SqlConnection
    Dim acsdr As SqlDataReader
    Dim strsql As String
    Public Property FormMode As Integer
    Property payrollDto As New PayrollDTO
    Private Sub loadPosition()

    End Sub
    Private Sub Add_Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label44.Visible = False
        objSettings.Mode = FormMode
        AddorEdit()
    End Sub
    Private Sub AddorEdit()
        If objSettings.Mode = 1 Then
            objSettings.EmptyForm(Me)
            MapUser()
            pos()
            dept()
        Else
            pos()
            pos2()
            dept()
        End If
    End Sub
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dtpDOB.ValueChanged

        age = Date.Now.Year - dtpDOB.Value.Year
        If Date.Now.Month < dtpDOB.Value.Month Then
            age = age - 1
            lblAge.Text = age
        Else
            lblAge.Text = age
        End If
        lblAge.BackColor = Color.White
    End Sub
    Public Function YearsBetweenDates(ByVal StartDate As DateTime, _
       ByVal EndDate As DateTime) As Integer
        ' Returns the number of years between the passed dates
        If Month(EndDate) < Month(StartDate) Or _
           (Month(EndDate) = Month(StartDate) And _
           (EndDate.Day) < (StartDate.Day)) Then
            Return Year(EndDate) - Year(StartDate) - 1
        Else
            Return Year(EndDate) - Year(StartDate)
        End If
    End Function
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rbMale.CheckedChanged
        gender = "Male"
        rbMale.BackColor = Color.White
        rbFemale.BackColor = Color.White
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles rbFemale.CheckedChanged
        gender = "Female"
        rbMale.BackColor = Color.White
        rbFemale.BackColor = Color.White
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles tEmail.TextChanged
        If tEmail.Text.Contains("@") And tEmail.Text.Contains(".com") Or tEmail.Text.Contains(".net") Then
            tEmail.ForeColor = Color.Green
        Else
            tEmail.ForeColor = Color.Red
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        OpenFileDialog1.Filter = "image file (*.jpg, *.bmp, *.png) | *.jpg; *.bmp; *.png| all files (*.*) | *.* "
        If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Dim addemp As New Add_Employee
        addemp.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Public Sub pos()
        Try
            acsconn.ConnectionString = objSettings.GlobalStringConnetion
            acsconn.Open()
            strsql = "SELECT * from tbl_jobpos"
            Dim acscmdr As New SqlCommand
            acscmdr.CommandText = strsql
            acscmdr.Connection = acsconn
            acsdr = acscmdr.ExecuteReader
            While (acsdr.Read())
                'payrollDto.SalaryGrade = acsdr("salary_grade")
                'payrollDto.Position = acsdr("job_pos")
                cbPosition.Items.Add(acsdr("job_pos") + acsdr("salary_grade"))
            End While
            'payrollDto.SalaryGrade = acsdr("salary_grade")
            'payrollDto.Position = acsdr("job_pos")
            acscmdr.Dispose()
            acsdr.Close()
            acsconn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Dim totalcount As String
    Dim yearnow As String
    Dim existid As String
    Public Sub pos2()
        yearnow = Now.Year
        Try
            acsconn.ConnectionString = objSettings.GlobalStringConnetion
            acsconn.Open()
            strsql = "SELECT COUNT(*) as total from tbl_user"
            Dim acscmdr As New SqlCommand
            acscmdr.CommandText = strsql
            acscmdr.Connection = acsconn
            acsdr = acscmdr.ExecuteReader
            While (acsdr.Read())
                totalcount = acsdr("total")
            End While
            acscmdr.Dispose()
            acsdr.Close()
            acsconn.Close()

            acsconn.Open()
            strsql = "SELECT emp_id from tbl_user"
            acscmdr.CommandText = strsql
            acscmdr.Connection = acsconn
            acsdr = acscmdr.ExecuteReader
            While (acsdr.Read())
                existid = acsdr("emp_id")
            End While
            acscmdr.Dispose()
            acsdr.Close()
            acsconn.Close()


            totalcount = Val(totalcount) + 1
            If totalcount < 10 Then
                tEmployeeID.Text = "PL" + yearnow + "000" + totalcount
            ElseIf totalcount > 10 And totalcount < 100 Then
                tEmployeeID.Text = "PL" + yearnow + "00" + totalcount
            ElseIf totalcount >= 100 Then
                tEmployeeID.Text = "PL" + yearnow + "0" + totalcount
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub dept()
        Try
            acsconn.ConnectionString = objSettings.GlobalStringConnetion
            acsconn.Open()
            strsql = "SELECT * from tbl_department"
            Dim acscmdr As New SqlCommand
            acscmdr.CommandText = strsql
            acscmdr.Connection = acsconn
            acsdr = acscmdr.ExecuteReader
            While (acsdr.Read())
                cbDepartment.Items.Add(acsdr("dept_name"))
            End While
            acscmdr.Dispose()
            acsdr.Close()
            acsconn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub MapUser()
        Try

            tEmployeeID.Text = employeeid
            acsconn.ConnectionString = objSettings.GlobalStringConnetion
            acsconn.Open()
            strsql = "SELECT * from tbl_user WHERE emp_id='" + employeeid + "'"
            Dim acscmdr As New SqlCommand
            acscmdr.CommandText = strsql
            acscmdr.Connection = acsconn
            acsdr = acscmdr.ExecuteReader
            While (acsdr.Read())

                tFirstName.Text = acsdr("first_name").trim
                tLastName.Text = acsdr("last_name").trim
                mi.Text = acsdr("middle_name").trim
                gender = acsdr("gender").trim

                If gender = "Male" Then
                    rbMale.Checked = True
                    rbFemale.Checked = False
                ElseIf gender = "Female" Then
                    rbFemale.Checked = True
                    rbMale.Checked = False
                Else
                    rbMale.Checked = False
                    rbFemale.Checked = False
                End If

                dtpDOB.Value = acsdr("b_date")
                cbMaritalStatus.Text = acsdr("marital_status").trim
                tContactNo.Text = acsdr("c_no").trim
                tEmail.Text = acsdr("email").trim
                tAddress.Text = acsdr("address").trim


                cbDepartment.Text = acsdr("dept")
                cbPosition.Text = acsdr("job_pos") + acsdr("salary_grade")


                dtpHired.Value = acsdr("date_hired")
                tGsis.Text = acsdr("gsis_no").trim
                tPhilhealth.Text = acsdr("philhealth").trim
                tPagibig.Text = acsdr("pagibig").trim
                tTIN.Text = acsdr("TAX").trim
                tBasic.Text = acsdr("basic_pay").trim
                cbProvince.Text = acsdr("province").trim
                tBPNo.Text = acsdr("bp_number").trim
                tLBPNo.Text = acsdr("lbp_number").trim
                tPolicyNo.Text = acsdr("pol_number").trim
                tAssignment.Text = acsdr("assigned_place").trim
                cboStat.Text = acsdr("status").trim

            End While
            acscmdr.Dispose()
            acsdr.Close()
            acsconn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub insert()
        If (tEmployeeID.Text <> "" And tFirstName.Text <> "" And tLastName.Text <> "" And mi.Text <> "" And gender <> "" And dtpDOB.Text <> "" And lblAge.Text <> "Please Select Birthdate." And tContactNo.Text <> "" And tEmail.Text <> "" And tAddress.Text <> "" And cbPosition.Text <> "" And cbDepartment.Text <> "" And dtpHired.Text <> "" And cbMaritalStatus.Text <> "" And cbDependents.Text <> "" And tGsis.Text <> "" And tPhilhealth.Text <> "" And tPagibig.Text <> "" And tTIN.Text <> "") Then
            Try
                Dim provider As String = objSettings.GlobalStringConnetion
                'Dim provider As String = "Data Source=BUSYBEE-ARVI-PC\SQLEXPRESS;Initial Catalog=payroll_db;User ID=sa;Password=mainpass"
                Dim con As New SqlConnection
                con.ConnectionString = provider
                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If
                Dim SqlCommand As New SqlCommand
                Dim SqlQuery As String = "INSERT INTO tbl_user ([emp_id],[first_name],[last_name],[middle_name],[gender],[b_date],[age],[c_no],[email],[address],[job_pos],[dept],[date_hired],[marital_status],[dependents],[gsis_no],[philhealth],[pagibig],[TAX],[hr_pr_day],[basic_pay],[educ_loan],[province],[bp_number],[lbp_number],[pol_number],[assigned_place],[status]) " _
                                          & "VALUES ('" + tEmployeeID.Text + "','" + tFirstName.Text + "','" + tLastName.Text + "','" + mi.Text + "','" + gender + "','" + dtpDOB.Text + "','" + lblAge.Text + "','" + tContactNo.Text + "','" + tEmail.Text + "','" + tAddress.Text + "','" + payrollDto.Position + "" + payrollDto.SalaryGrade + "','" + cbDepartment.Text + "','" + dtpHired.Text + "','" + cbMaritalStatus.Text + "','" + cbDependents.Text + "','" + tGsis.Text + "','" + tPhilhealth.Text + "','" + tPagibig.Text + "','" + tTIN.Text + "','" + cbHours.Text + "','" + tBasic.Text + "','" + "Yes" + "','" + cbProvince.Text + "','" + tBPNo.Text + "','" + tLBPNo.Text + "','" + tPolicyNo.Text + "','" + tAssignment.Text + "','" + cboStat.Text + "')"
                With SqlCommand
                    .CommandText = SqlQuery
                    .Connection = con
                    .ExecuteNonQuery()
                End With
                con.Close()
                'MsgBox(SqlQuery)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            Try
                Dim provider As String = objSettings.GlobalStringConnetion
                'Dim provider As String = "Data Source=BUSYBEE-ARVI-PC\SQLEXPRESS;Initial Catalog=payroll_db;User ID=sa;Password=mainpass"
                Dim con As New SqlConnection
                con.ConnectionString = provider
                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If
                Dim SqlCommand As New SqlCommand
                Dim SqlQuery As String = "INSERT INTO tbl_logindetails ([user_name],[emp_id],[pass_word],[access_lvl]) VALUES ('" + tEmployeeID.Text + "','" + tEmployeeID.Text + "','p@$$w0rd','2')"
                With SqlCommand
                    .CommandText = SqlQuery
                    .Connection = con
                    .ExecuteNonQuery()
                End With
                con.Close()
                PictureBox1.Image.Save(Application.StartupPath & "\images\" + tEmployeeID.Text + ".jpg", Imaging.ImageFormat.Png)
                MessageBox.Show("Registration Successful", "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim addemp As New Add_Employee
                addemp.Show()
                Me.Close()

            Catch ex As Exception
                MsgBox(ex.ToString)

            End Try

        Else
            MessageBox.Show("Please Answer All the fields with color red marker!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If tFirstName.Text = "" Then
                tFirstName.BackColor = Color.IndianRed
            End If
            If mi.Text = "" Then
                mi.BackColor = Color.IndianRed
            End If
            If tLastName.Text = "" Then
                tLastName.BackColor = Color.IndianRed
            End If
            If gender = "" Then
                rbMale.BackColor = Color.IndianRed
                rbFemale.BackColor = Color.IndianRed
            End If
            If tEmployeeID.Text = "" Then
                tEmployeeID.BackColor = Color.IndianRed
            End If
            If lblAge.Text = "Please Select Birthdate." Then
                lblAge.BackColor = Color.IndianRed
            End If
            If cbMaritalStatus.Text = "" Then
                cbMaritalStatus.BackColor = Color.IndianRed
            End If
            If cbDependents.Text = "" Then
                cbDependents.BackColor = Color.IndianRed
            End If
            If tContactNo.Text = "" Then
                tContactNo.BackColor = Color.IndianRed
            End If
            If tEmail.Text = "" Then
                tEmail.BackColor = Color.IndianRed
            End If
            If tAddress.Text = "" Then
                tAddress.BackColor = Color.IndianRed
            End If
            If cbPosition.Text = "" Then
                cbPosition.BackColor = Color.IndianRed
            End If
            If cbDepartment.Text = "" Then
                cbDepartment.BackColor = Color.IndianRed
            End If
            If cbHours.Text = "" Then
                cbHours.BackColor = Color.IndianRed
            End If
            If tTIN.Text = "" Then
                tTIN.BackColor = Color.IndianRed
            End If
            If tSSS.Text = "" Then
                tSSS.BackColor = Color.IndianRed
            End If
            If tPhilhealth.Text = "" Then
                tPhilhealth.BackColor = Color.IndianRed
            End If
            If tPagibig.Text = "" Then
                tPagibig.BackColor = Color.IndianRed
            End If

        End If

    End Sub
    Public Sub addupdate()
        Try
            Dim provider As String = objSettings.GlobalStringConnetion
            Dim con As New SqlConnection
            con.ConnectionString = provider
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            Dim SqlCommand As New SqlCommand
            Dim SqlQuery As String = "UPDATE tbl_user SET first_name = '@firstname',last_name='@lastname',middle_name='@niddlename',gender='@gender',b_date='@bdate',marital_status='@marital',age='@age',c_no='@cno',email='@email',address='@address',job_pos='@job',dept='@dept',date_hired='@datehired',marital_status='@ms',dependents='@depe',gsis_no='@gsis',philhealth='@philh',pagibig='@hmdf',TAX='@tin',hr_pr_day='@perday',basic_pay='@basicpay',educ_loan='@edloan',province='@province',bp_number='@bpno',lbp_number='@lbpno',pol_number='@polno',assigned_place='@assignment',status='@status' WHERE emp_id='" + tEmployeeID.Text + "'"


            With SqlCommand
                .CommandText = SqlQuery
                .Parameters.AddWithValue("@firstname", tFirstName.Text)
                .Parameters.AddWithValue("@lastname", tLastName.Text)
                .Parameters.AddWithValue("@middlename", mi.Text)
                .Parameters.AddWithValue("@gender", GetStatusMF(rbMale.Checked, rbFemale.Checked))
                .Parameters.AddWithValue("@bdate", dtpDOB.Text)
                .Parameters.AddWithValue("@age", lblAge.Text)
                .Parameters.AddWithValue("@marital", cbMaritalStatus.Text)
                .Parameters.AddWithValue("@cno", tContactNo.Text)
                .Parameters.AddWithValue("@email", tEmployeeID.Text)
                .Parameters.AddWithValue("@address", tEmployeeID.Text)
                .Parameters.AddWithValue("@job", cbPosition.Text)
                .Parameters.AddWithValue("@dept", cbDepartment.Text)
                .Parameters.AddWithValue("@datehired", tEmployeeID.Text)
                .Parameters.AddWithValue("@ms", cbMaritalStatus.Text)
                .Parameters.AddWithValue("@depe", cbDependents.Text)
                .Parameters.AddWithValue("@gsis", tGsis.Text)
                .Parameters.AddWithValue("@philh", tPhilhealth.Text)
                .Parameters.AddWithValue("@hmdf", tPagibig.Text)
                .Parameters.AddWithValue("@tin", tTIN.Text)
                .Parameters.AddWithValue("@perday", "1")
                .Parameters.AddWithValue("@basicpay", tBasic.Text)
                .Parameters.AddWithValue("@edloan", "Yes")
                .Parameters.AddWithValue("@province", cbProvince.Text)
                .Parameters.AddWithValue("@bpno", tBPNo.Text)
                .Parameters.AddWithValue("@lbpno", tLBPNo.Text)
                .Parameters.AddWithValue("@polno", tPolicyNo.Text)
                .Parameters.AddWithValue("@assignment", tAssignment.Text)
                .Connection = con
                .ExecuteNonQuery()
            End With
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Try
            Dim provider As String = objSettings.GlobalStringConnetion
            Dim con As New SqlConnection
            con.ConnectionString = provider
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            Dim SqlCommand As New SqlCommand
            Dim SqlQuery As String = ""
            With SqlCommand
                .CommandText = SqlQuery
                .Connection = con
                .ExecuteNonQuery()
            End With
            con.Close()
            MessageBox.Show("Employee Profile Update Successful!", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub fn_TextChanged(sender As Object, e As EventArgs) Handles tFirstName.TextChanged, tLastName.TextChanged, mi.TextChanged, cbMaritalStatus.SelectedIndexChanged, tAddress.TextChanged, tContactNo.TextChanged
        Dim myText As TextBox
        myText = sender
        myText.BackColor = Color.White
    End Sub

    Private Sub dp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDependents.SelectedIndexChanged
        cbDependents.BackColor = Color.White
    End Sub

    Private Sub pi_TextChanged(sender As Object, e As EventArgs) Handles tPagibig.TextChanged
        tPagibig.BackColor = Color.White

        If tPagibig.Text.Length = 4 Then
            tPagibig.Text = tPagibig.Text + "-"
            tPagibig.Select(tPagibig.Text.Length, 5)
        End If

        If tPagibig.Text.Length = 9 Then
            tPagibig.Text = tPagibig.Text + "-"
            tPagibig.Select(tPagibig.Text.Length, 10)
        End If

        If tPagibig.Text.Length = 14 Then
            tPagibig.ForeColor = Color.Green

        Else
            tPagibig.ForeColor = Color.Red
        End If

    End Sub
    Private Sub ph_TextChanged(sender As Object, e As EventArgs) Handles tPhilhealth.TextChanged
        tPhilhealth.BackColor = Color.White

        If tPhilhealth.Text.Length = 2 Then
            tPhilhealth.Text = tPhilhealth.Text + "-"
            tPhilhealth.Select(tPhilhealth.Text.Length, 3)
        End If

        If tPhilhealth.Text.Length = 13 Then
            tPhilhealth.Text = tPhilhealth.Text + "-"
            tPhilhealth.Select(tPhilhealth.Text.Length, 14)
        End If

        If tPhilhealth.Text.Length = 15 Then
            tPhilhealth.ForeColor = Color.Green
        Else
            tPhilhealth.ForeColor = Color.Red
        End If

    End Sub
    Private Sub ss_TextChanged(sender As Object, e As EventArgs) Handles tSSS.TextChanged
        tSSS.BackColor = Color.White

        If tSSS.Text.Length = 2 Then
            tSSS.Text = tSSS.Text + "-"
            tSSS.Select(tSSS.Text.Length, 3)
        End If

        If tSSS.Text.Length = 13 Then
            tSSS.Text = tSSS.Text + "-"
            tSSS.Select(tSSS.Text.Length, 14)
        End If

        If tSSS.Text.Length = 15 Then
            tSSS.ForeColor = Color.Green
        Else
            tSSS.ForeColor = Color.Red
        End If


    End Sub
    Private Sub tn_TextChanged(sender As Object, e As EventArgs) Handles tTIN.TextChanged
        tTIN.BackColor = Color.White

        If tTIN.Text.Length = 3 Then
            tTIN.Text = tTIN.Text + "-"
            tTIN.Select(tTIN.Text.Length, 4)
        End If

        If tTIN.Text.Length = 7 Then
            tTIN.Text = tTIN.Text + "-"
            tTIN.Select(tTIN.Text.Length, 8)
        End If

        If tTIN.Text.Length = 11 Then
            tTIN.ForeColor = Color.Green

        Else
            tTIN.ForeColor = Color.Red
        End If
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbHours.SelectedIndexChanged
        cbHours.BackColor = Color.White
    End Sub
    Private Sub department_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDepartment.SelectedIndexChanged
        cbDepartment.BackColor = Color.White
        cbPosition.Items.Clear()
        tBasic.Text = ""
        Try
            acsconn.ConnectionString = objSettings.GlobalStringConnetion
            'acsconn.ConnectionString = "Data Source=BUSYBEE-ARVI-PC\SQLEXPRESS;Initial Catalog=payroll_db;User ID=sa;Password=mainpass"
            acsconn.Open()
            strsql = "SELECT * from tbl_jobpos WHERE department = '" + cbDepartment.Text + "'"
            Dim acscmdr As New SqlCommand
            acscmdr.CommandText = strsql
            acscmdr.Connection = acsconn
            acsdr = acscmdr.ExecuteReader
            While (acsdr.Read())
                cbPosition.Items.Add(acsdr("job_pos") + "" + acsdr("salary_grade"))
            End While
            acscmdr.Dispose()
            acsdr.Close()
            acsconn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    Private Sub position_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPosition.SelectedIndexChanged
        cbPosition.BackColor = Color.White
        Dim aString As String = cbPosition.Text
        payrollDto.Position = Mid(aString, 1, aString.Length - 3)
        payrollDto.SalaryGrade = Mid(aString, aString.Length - 3)
        Try
            acsconn.ConnectionString = objSettings.GlobalStringConnetion
            'acsconn.ConnectionString = "Data Source=BUSYBEE-ARVI-PC\SQLEXPRESS;Initial Catalog=payroll_db;User ID=sa;Password=mainpass"
            acsconn.Open()
            strsql = String.Format("SELECT * from tbl_jobpos Where job_pos ='{0}' and salary_grade ='{1}'", Trim(payrollDto.Position), Trim(payrollDto.SalaryGrade))
            Dim acscmdr As New SqlCommand
            acscmdr.CommandText = strsql
            acscmdr.Connection = acsconn
            acsdr = acscmdr.ExecuteReader
            While (acsdr.Read())
                tBasic.Text = MoneyHelper.ToMoney(acsdr("basic_pay"))
            End While
            acscmdr.Dispose()
            acsdr.Close()
            acsconn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        OpenFileDialog2.Filter = "image file (*.jpg, *.bmp, *.png) | *.jpg; *.bmp; *.png| all files (*.*) | *.* "
        If OpenFileDialog2.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            PictureBox2.Image = Image.FromFile(OpenFileDialog2.FileName)
        End If
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked

        If Panel1.Visible = False Then
            Panel1.Visible = True
            GroupBox1.Visible = False
            GroupBox2.Visible = False
            GroupBox3.Visible = False
            bSave.Visible = False
            bClose.Visible = False
            bClear.Visible = False
            Label1.Visible = True
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        If Panel1.Visible = True Then
            Panel1.Visible = False
            GroupBox1.Visible = True
            GroupBox2.Visible = True
            GroupBox3.Visible = True
            bSave.Visible = True
            bClose.Visible = True
            bClear.Visible = True
            Label1.Visible = True
            Label32.Visible = False
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If (TextBox1.Text = "") Then

            Label32.Text = "Please complete all fields!"
            Label32.Visible = True
        Else
            Try
                Dim provider As String = objSettings.GlobalStringConnetion
                'Dim provider As String = "Data Source=BUSYBEE-ARVI-PC\SQLEXPRESS;Initial Catalog=payroll_db;User ID=sa;Password=mainpass"
                Dim con As New SqlConnection
                con.ConnectionString = provider
                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If
                Dim SqlCommand As New SqlCommand
                Dim SqlQuery As String = "INSERT INTO tbl_docs ([emp_id],[category],[description]) VALUES ('" + tEmployeeID.Text.Trim + "','" + ComboBox2.Text.Trim + "','" + TextBox1.Text.Trim + "')"
                With SqlCommand
                    .CommandText = SqlQuery
                    .Connection = con
                    .ExecuteNonQuery()
                End With
                con.Close()

                'TextBox2.Text = SqlQuery

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            PictureBox2.Image.Save(Application.StartupPath & "\docs\" + tEmployeeID.Text + TextBox1.Text + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
            TextBox1.Text = ""
            PictureBox2.Image = Nothing
            MsgBox("Saved Successfully!", MsgBoxStyle.Information)

        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ComboBox2.SelectedIndex = 0
        PictureBox2.Image = Nothing
        TextBox1.Text = ""
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub cboStat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStat.SelectedIndexChanged
        StatusChanged()
    End Sub

    Public Sub StatusChanged()
        If cboStat.Text = "Active" Then
            dptTer.Enabled = False
            dptRet.Enabled = False
            dtpSep.Enabled = False
        End If
        If cboStat.Text = "Separated" Then
            dtpSep.Enabled = True
            dptTer.Enabled = False
            dptRet.Enabled = False
        End If
        If cboStat.Text = "Retired" Then
            dtpSep.Enabled = False
            dptTer.Enabled = False
            dptRet.Enabled = True
        End If
        If cboStat.Text = "Terminated" Then
            dtpSep.Enabled = False
            dptTer.Enabled = True
            dptRet.Enabled = False
        End If

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles bSave.Click
        If objSettings.Mode = 0 Then
            insert()
        Else
            addupdate()
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles bClose.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles bClear.Click
        tFirstName.Clear()
        cbMaritalStatus.SelectedIndex = 0
        dtpDOB.Value = DateTime.Now
        lblAge.Text = "Please Select Birthdate."
        If cbDepartment.Items.Count > 0 Then cbDepartment.SelectedIndex = 0

    End Sub
    Private Sub ClearForm()

    End Sub
    Private Function GetStatusMF(ByVal M As Boolean, ByVal F As Boolean) As String
        Dim str As String = ""
        If M Then
            str = "Male"
        End If

        If F Then
            str = "Female"
        End If

        Return str
    End Function
    Private Function NewDataSet(ByVal str)
        'Dim ds As New Data set
        'Dim sql As String = ""
        'Return resuslt
    End Function

    
End Class