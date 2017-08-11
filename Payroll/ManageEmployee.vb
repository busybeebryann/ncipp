Imports WindowsApplication1.Extensions

Public Class ManageEmployee
    Public sMyStatus As String
    Public sMyID As String
    Property payrollDTO As New PayrollDTO
    Private Sub ManageEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearForm()

        If (sMyStatus = "NEW") Then
            bSearch.Enabled = True
            bClear.Enabled = True
            Me.Text = "NCIP-CAR - Manage Employee Details"
            Label1.Text = "Manage Employee Details"
        Else
            Me.Text = "NCIP-CAR - My Profile View"
            Label1.Text = "Manage My Profile"
            PopulateEmployeeDetails(sMyID)
            bSearch.Enabled = False
            bClear.Enabled = False
            bDelete.Enabled = False
        End If

    End Sub

    Private Sub GetEmployeeID()
        Dim sID As String

        sID = GetLastID("SELECT IDENT_CURRENT('tbl_user')")
        tEmployeeID.Text = "PL" + Now.Year.ToString() + Convert.ToInt32(sID).ToString("0000")

    End Sub
    Private Sub LoadDepartment()
        Dim dtDept As DataTable
        cbDepartment.Tag = "False"
        dtDept = GetDataAsTable("Select * from tdepartment")
        cbDepartment.DisplayMember = "DeptName"
        cbDepartment.ValueMember = "ID"
        cbDepartment.DataSource = dtDept
        cbDepartment.Tag = "True"
        If cbDepartment.Items.Count > 0 Then
            cbDepartment.SelectedIndex = 0
            LoadPosition()
        End If
    End Sub
    Private Sub LoadPosition()
        If cbDepartment.Tag = "False" Then Exit Sub

        Dim dtDept As DataTable
        cbPosition.Tag = "False"
        dtDept = GetDataAsTable("Select * from tPosition where deptid=" + cbDepartment.SelectedValue.ToString())
        cbPosition.DisplayMember = "PositionName"
        cbPosition.ValueMember = "ID"
        cbPosition.DataSource = dtDept
        cbPosition.Tag = "True"

        If cbPosition.Items.Count > 0 Then
            cbPosition.SelectedIndex = 0
            LoadSalaryGrade()
        End If
    End Sub
    Private Sub LoadSalaryGrade()
        If cbPosition.Tag = "False" Then Exit Sub
        Dim dtPos As DataTable
        dtPos = GetDataAsTable("Select * from tPosition where ID =" + cbPosition.SelectedValue.ToString())
        payrollDTO.SalaryGrade = dtPos.Rows(0)("SalaryGrade")
        payrollDTO.Basic = dtPos.Rows(0)("BasicPay")
        lSalaryGrade.Text = payrollDTO.SalaryGrade
    End Sub
    Private Sub ClearForm()
        pbProfileImage.Tag = "0"
        pbProfileImage.Image = My.Resources._default
        tFirstName.Clear()
        tFirstName.BackColor = Color.White
        tFirstName.Tag = "0"
        tLastName.Clear()
        tLastName.BackColor = Color.White
        tMiddleName.Clear()
        tMiddleName.BackColor = Color.White
        rbMale.Checked = True
        dtpDOB.Value = DateTime.Now
        lblAge.Text = "Please Select Birthdate."
        cbMaritalStatus.SelectedIndex = 0
        cbDependents.SelectedIndex = -1
        cbPosition.SelectedIndex = -1
        tContactNo.Clear()
        tContactNo.BackColor = Color.White
        tBPNo.Clear()
        tBPNo.BackColor = Color.White
        tEmail.Clear()
        tEmail.BackColor = Color.White
        tLBPNo.Clear()
        tLBPNo.BackColor = Color.White
        tPolicyNo.Clear()
        tPolicyNo.BackColor = Color.White
        cbProvince.SelectedIndex = 0
        tAssignment.Clear()
        tAssignment.BackColor = Color.White
        tAddress.Clear()
        tAddress.BackColor = Color.White
        LoadDepartment()
        tBasic.Clear()
        tBasic.BackColor = Color.White
        dtpHired.Value = DateTime.Now
        GetEmployeeID()
        tTIN.Clear()
        tTIN.BackColor = Color.White
        tGsis.Clear()
        tGsis.BackColor = Color.White
        tPhilhealth.Clear()
        tPhilhealth.BackColor = Color.White
        tPagibig.Clear()
        tPagibig.BackColor = Color.White
        cbStatus.SelectedIndex = 0
        dtpStatus.Value = DateTime.Now
        bDelete.Enabled = False
        lSalaryGrade.Text = ""
        tFirstName.Focus()

    End Sub
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub tTIN_TextChanged(sender As Object, e As EventArgs) Handles tTIN.TextChanged



    End Sub


    Private Sub tContactNo_TextChanged(sender As Object, e As EventArgs) Handles tContactNo.TextChanged
        Dim myText As TextBox
        myText = sender
        myText.BackColor = Color.White
    End Sub

    Private Sub tPhilhealth_TextChanged(sender As Object, e As EventArgs) Handles tPhilhealth.TextChanged

    End Sub

    Private Sub tPagibig_TextChanged(sender As Object, e As EventArgs) Handles tPagibig.TextChanged

    End Sub

    Private Sub tSSS_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub tBPNo_TextChanged(sender As Object, e As EventArgs) Handles tBPNo.TextChanged

    End Sub

    Private Sub tLBPNo_TextChanged(sender As Object, e As EventArgs) Handles tLBPNo.TextChanged

    End Sub

    Private Sub tPolicyNo_TextChanged(sender As Object, e As EventArgs) Handles tPolicyNo.TextChanged

    End Sub
    Private Sub tAddress_TextChanged(sender As Object, e As EventArgs) Handles tAddress.TextChanged
        Dim myText As TextBox
        myText = sender
        myText.BackColor = Color.White
    End Sub

    Private Sub tGsis_TextChanged(sender As Object, e As EventArgs) Handles tGsis.TextChanged


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub bSave(sender As Object, e As EventArgs)

    End Sub
    ''Private Function ValidateForm() As Boolean
    ''    Dim bReturn As Boolean = False
    ''    If (tEmployeeID.Text <> "" And tFirstName.Text <> "" And tLastName.Text <> "" _
    ''        And tMiddleName.Text <> "" And dtpDOB.Text <> "" And lblAge.Text <> "Please Select Birthdate." _
    ''        And tContactNo.Text <> "" And tEmail.Text <> "" And tAddress.Text <> "" And cbPosition.Text <> "" _
    ''        And cbDepartment.Text <> "" And dtpHired.Text <> "" And cbMaritalStatus.Text <> "" _
    ''        And cbDependents.Text <> "" And tGsis.Text <> "" And tPhilhealth.Text <> "" And tPagibig.Text <> "" And tTIN.Text <> "") Then

    ''        bReturn = True
    ''    End If

    ''End Function

    Private Sub llAttach_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llAttach.LinkClicked
        Dim objDialog As New OpenFileDialog
        objDialog.Filter = "image file (*.jpg, *.bmp, *.png) | *.jpg; *.bmp; *.png| all files (*.*) | *.* "
        If objDialog.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            pbProfileImage.Image = Image.FromFile(objDialog.FileName)
            pbProfileImage.Tag = "1"
        End If
    End Sub

    Private Sub rbMale_CheckedChanged(sender As Object, e As EventArgs) Handles rbMale.CheckedChanged
        If (rbMale.Checked) Then
            rbMale.Tag = "Male"
        Else
            rbMale.Tag = "Female"
        End If
    End Sub

    Private Sub dtpDOB_ValueChanged(sender As Object, e As EventArgs) Handles dtpDOB.ValueChanged
        Dim iAge As Integer
        iAge = YearsBetweenDates(dtpDOB.Value, Now.Date)
        lblAge.Text = iAge.ToString()

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

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        ClearForm()
    End Sub

    Private Sub cbDepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDepartment.SelectedIndexChanged
        LoadPosition()
    End Sub
    Private Sub cbPosition_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPosition.SelectedIndexChanged
        LoadSalaryGrade()
    End Sub

    Private Sub tBPNo_KeyUp(sender As Object, e As KeyEventArgs) Handles tBPNo.KeyUp
        tBPNo.BackColor = Color.White
        If tBPNo.Text.Length = 14 Then
            tBPNo.ForeColor = Color.Green

        Else
            tBPNo.ForeColor = Color.Red
        End If

        If (e.KeyCode = Keys.Back Or e.KeyCode = Keys.Delete) Then
            Exit Sub
        End If

        If tBPNo.Text.Length = 4 Then
            tBPNo.Text = tBPNo.Text + "-"
            tBPNo.Select(tBPNo.Text.Length, 5)
        End If

        If tBPNo.Text.Length = 9 Then
            tBPNo.Text = tBPNo.Text + "-"
            tBPNo.Select(tBPNo.Text.Length, 10)
        End If
    End Sub

    Private Sub tLBPNo_KeyUp(sender As Object, e As KeyEventArgs) Handles tLBPNo.KeyUp
        tLBPNo.BackColor = Color.White

        If tLBPNo.Text.Length = 14 Then
            tLBPNo.ForeColor = Color.Green

        Else
            tLBPNo.ForeColor = Color.Red
        End If

        If (e.KeyCode = Keys.Back Or e.KeyCode = Keys.Delete) Then
            Exit Sub
        End If

        If tLBPNo.Text.Length = 4 Then
            tLBPNo.Text = tLBPNo.Text + "-"
            tLBPNo.Select(tLBPNo.Text.Length, 5)
        End If

        If tLBPNo.Text.Length = 9 Then
            tLBPNo.Text = tLBPNo.Text + "-"
            tLBPNo.Select(tLBPNo.Text.Length, 10)
        End If
    End Sub

    Private Sub tPolicyNo_KeyUp(sender As Object, e As KeyEventArgs) Handles tPolicyNo.KeyUp
        tPolicyNo.BackColor = Color.White
        If tPolicyNo.Text.Length = 14 Then
            tPolicyNo.ForeColor = Color.Green

        Else
            tPolicyNo.ForeColor = Color.Red
        End If

        If (e.KeyCode = Keys.Back Or e.KeyCode = Keys.Delete) Then
            Exit Sub
        End If



        If tPolicyNo.Text.Length = 4 Then
            tPolicyNo.Text = tPolicyNo.Text + "-"
            tPolicyNo.Select(tPolicyNo.Text.Length, 5)
        End If

        If tPolicyNo.Text.Length = 9 Then
            tPolicyNo.Text = tPolicyNo.Text + "-"
            tPolicyNo.Select(tPolicyNo.Text.Length, 10)
        End If
    End Sub

    Private Sub tTIN_KeyUp(sender As Object, e As KeyEventArgs) Handles tTIN.KeyUp
        tTIN.BackColor = Color.White
        If tTIN.Text.Length = 11 Then
            tTIN.ForeColor = Color.Green

        Else
            tTIN.ForeColor = Color.Red
        End If

        If (e.KeyCode = Keys.Back Or e.KeyCode = Keys.Delete) Then
            Exit Sub
        End If



        If tTIN.Text.Length = 3 Then
            tTIN.Text = tTIN.Text + "-"
            tTIN.Select(tTIN.Text.Length, 4)
        End If

        If tTIN.Text.Length = 7 Then
            tTIN.Text = tTIN.Text + "-"
            tTIN.Select(tTIN.Text.Length, 8)
        End If
    End Sub

    Private Sub tGsis_KeyUp(sender As Object, e As KeyEventArgs) Handles tGsis.KeyUp
        tGsis.BackColor = Color.White
        If tGsis.Text.Length = 15 Then
            tGsis.ForeColor = Color.Green
        Else
            tGsis.ForeColor = Color.Red
        End If

        If (e.KeyCode = Keys.Back Or e.KeyCode = Keys.Delete) Then
            Exit Sub
        End If


        If tGsis.Text.Length = 2 Then
            tGsis.Text = tGsis.Text + "-"
            tGsis.Select(tGsis.Text.Length, 3)
        End If

        If tGsis.Text.Length = 13 Then
            tGsis.Text = tGsis.Text + "-"
            tGsis.Select(tGsis.Text.Length, 14)
        End If


    End Sub

    Private Sub tPhilhealth_KeyUp(sender As Object, e As KeyEventArgs) Handles tPhilhealth.KeyUp
        tPhilhealth.BackColor = Color.White
        If tPhilhealth.Text.Length = 15 Then
            tPhilhealth.ForeColor = Color.Green
        Else
            tPhilhealth.ForeColor = Color.Red
        End If

        If (e.KeyCode = Keys.Back Or e.KeyCode = Keys.Delete) Then
            Exit Sub
        End If


        If tPhilhealth.Text.Length = 2 Then
            tPhilhealth.Text = tPhilhealth.Text + "-"
            tPhilhealth.Select(tPhilhealth.Text.Length, 3)
        End If

        If tPhilhealth.Text.Length = 13 Then
            tPhilhealth.Text = tPhilhealth.Text + "-"
            tPhilhealth.Select(tPhilhealth.Text.Length, 14)
        End If

    End Sub

    Private Sub tPagibig_KeyUp(sender As Object, e As KeyEventArgs) Handles tPagibig.KeyUp
        tPagibig.BackColor = Color.White
        If tPagibig.Text.Length = 14 Then
            tPagibig.ForeColor = Color.Green

        Else
            tPagibig.ForeColor = Color.Red
        End If

        If (e.KeyCode = Keys.Back Or e.KeyCode = Keys.Delete) Then
            Exit Sub
        End If



        If tPagibig.Text.Length = 4 Then
            tPagibig.Text = tPagibig.Text + "-"
            tPagibig.Select(tPagibig.Text.Length, 5)
        End If

        If tPagibig.Text.Length = 9 Then
            tPagibig.Text = tPagibig.Text + "-"
            tPagibig.Select(tPagibig.Text.Length, 10)
        End If
    End Sub

    Private Sub tSSS_KeyUp(sender As Object, e As KeyEventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles bClose.Click
        Me.Close()

    End Sub


    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles bClear.Click
        ClearForm()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Dim sQuery, sMessage, sDOB, sDOJ, sStatusDate As String

        ''VALIDATE FORM
        If ValidateForm() Then Exit Sub

        sDOB = dtpDOB.Value.ToString("dd-MMM-yyyy", System.Globalization.CultureInfo.InvariantCulture)
        sDOJ = dtpHired.Value.ToString("dd-MMM-yyyy", System.Globalization.CultureInfo.InvariantCulture)

        sStatusDate = "1900-01-01"
        If cbStatus.Text <> "Active" Then
            sStatusDate = dtpStatus.Value.ToString("dd-MMM-yyyy", System.Globalization.CultureInfo.InvariantCulture)
        End If

        Try

            If (tFirstName.Tag.ToString() = "0") Then

                sQuery = "Insert into tbl_user output INSERTED.user_id values('" + tEmployeeID.Text.Replace("'", "") + "','" + tFirstName.Text.Replace("'", "") +
                    "','" + tMiddleName.Text.Replace("'", "") + "','" + tLastName.Text.Replace("'", "") + "','" + rbMale.Tag.ToString() + "','" + sDOB +
                    "'," + lblAge.Text + ",'" + tContactNo.Text.Replace("'", "") + "','" + tEmail.Text.Replace("'", "") + "','" + tAddress.Text.Replace("'", "") + "','" +
                    cbPosition.Text + "','" + cbDepartment.Text + "','" + sDOJ + "','" + cbMaritalStatus.Text + "'," + cbDependents.Text +
                    ",'" + tPhilhealth.Text.Replace("'", "") + "','" + tPagibig.Text.Replace("'", "") + "','TAX','" + tTIN.Text.Replace("'", "") +
                    "'," + tBasic.Text.Replace("'", "") + ",'YES','" + cbProvince.Text + "','" + tGsis.Text.Replace("'", "") +
                    "','" + tBPNo.Text.Replace("'", "") + "','" + tLBPNo.Text.Replace("'", "") + "','" + tPolicyNo.Text.Replace("'", "") + "','" + cbStatus.Text + "','" + sStatusDate +
                    "','" + tAssignment.Text.Replace("'", "") + "'," + cbDepartment.SelectedValue.ToString() +
                    "," + cbPosition.SelectedValue.ToString() + ",getdate(),getdate())"

                Dim sReturend As String = ""
                sReturend = ExecuteWithValue(sQuery)

                If (sReturend.StartsWith("Error")) Then
                    MessageBox.Show(sReturend)
                    Exit Sub
                End If

                Dim iAddedID As Integer
                Dim sEmpID As String
                iAddedID = Convert.ToInt32(sReturend)
                sEmpID = "PL" + Now.Year.ToString() + iAddedID.ToString("0000")

                sQuery = "Insert into tbl_logindetails values('" + sEmpID + "','" + sEmpID + "','p@$$w0rd',2,''," +
                    iAddedID.ToString() + ",getdate(),getdate())"
                sReturend = ExecuteDML(sQuery)
                If sReturend <> "True" Then
                    MessageBox.Show("Error : " + sReturend)
                    Exit Sub
                End If

                sQuery = "Update tbl_user set emp_id='" + sEmpID + "' where user_id=" + iAddedID.ToString()
                sReturend = ExecuteDML(sQuery)
                If sReturend <> "True" Then
                    MessageBox.Show("Error : " + sReturend)
                    Exit Sub
                End If

                If (pbProfileImage.Tag = "1") Then
                    pbProfileImage.Image.Save(Application.StartupPath & "\images\" + iAddedID.ToString() + ".jpg", Imaging.ImageFormat.Png)
                End If

                sMessage = "Employee Details ADDED Successfully"
                MessageBox.Show(sMessage)
                ClearForm()
            Else
                sQuery = "Update tbl_user set first_name='" + tFirstName.Text.Replace("'", "") +
                         "',middle_name='" + tMiddleName.Text.Replace("'", "") + "',last_name='" + tLastName.Text.Replace("'", "") +
                         "',gender='" + rbMale.Tag.ToString() + "',b_date='" + sDOB + "',age=" + lblAge.Text +
                         ",c_no='" + tContactNo.Text.Replace("'", "") + "',email='" + tEmail.Text.Replace("'", "") + "',address='" + tAddress.Text.Replace("'", "") +
                         "',job_pos='" + cbPosition.Text + "',dept='" + cbDepartment.Text + "',date_hired='" + sDOJ + "',marital_status='" + cbMaritalStatus.Text +
                         "',dependents=" + cbDependents.Text + ",philhealth='" + tPhilhealth.Text.Replace("'", "") + "',pagibig='" + tPagibig.Text.Replace("'", "") +
                         "',din='" + tTIN.Text.Replace("'", "") + "',basic_pay=" + tBasic.Text.Replace("'", "") + ",province='" + cbProvince.Text +
                         "',gsis_no='" + tGsis.Text.Replace("'", "") + "',bp_number='" + tBPNo.Text.Replace("'", "") + "',lbp_number='" + tLBPNo.Text.Replace("'", "") +
                         "',pol_number='" + tPolicyNo.Text.Replace("'", "") + "',status='" + cbStatus.Text + "',status_date='" + sStatusDate +
                         "',assigned_place='" + tAssignment.Text.Replace("'", "") + "',deptid=" + cbDepartment.SelectedValue.ToString() +
                         ",positionid=" + cbPosition.SelectedValue.ToString() + ",modifiedon=getdate() where user_id=" + tFirstName.Tag.ToString()

                Dim sReturend As String = ""
                sReturend = ExecuteDML(sQuery)

                If (sReturend.StartsWith("Error")) Then
                    MessageBox.Show(sReturend)
                    Exit Sub
                End If

                If (pbProfileImage.Tag = "1") Then
                    pbProfileImage.Image.Save(Application.StartupPath & "\images\" + tFirstName.Tag.ToString() + ".jpg", Imaging.ImageFormat.Png)
                End If
                sMessage = "Employee Details UPDATED Successfully"
                MessageBox.Show(sMessage)
                Me.Close()
                ClearForm()
            End If

        Catch ex As Exception
            MessageBox.Show("Error : " + ex.Message)
        End Try
    End Sub
    Private Function ValidateForm() As Boolean
        Dim bReturn As Boolean = False
        If (tFirstName.Text = "" Or tLastName.Text = "" Or tMiddleName.Text = "" _
            Or lblAge.Text = "Please Select Birthdate." Or tContactNo.Text = "" Or tEmail.Text = "" _
            Or tAddress.Text = "" Or tGsis.Text = "" Or tPhilhealth.Text = "" Or tPagibig.Text = "" _
            Or tTIN.Text = "" Or tBasic.Text = "") Then

            MessageBox.Show("Please fill all the fields")
            If tFirstName.Text = "" Then tFirstName.BackColor = Color.Orange
            If tLastName.Text = "" Then tLastName.BackColor = Color.Orange
            If tMiddleName.Text = "" Then tMiddleName.BackColor = Color.Orange
            If tContactNo.Text = "" Then tContactNo.BackColor = Color.Orange
            If tEmail.Text = "" Then tEmail.BackColor = Color.Orange
            If tAddress.Text = "" Then tAddress.BackColor = Color.Orange
            If tGsis.Text = "" Then tGsis.BackColor = Color.Orange
            If tPhilhealth.Text = "" Then tPhilhealth.BackColor = Color.Orange
            If tPagibig.Text = "" Then tPagibig.BackColor = Color.Orange
            If tTIN.Text = "" Then tTIN.BackColor = Color.Orange
            If tBasic.Text = "" Then tBasic.BackColor = Color.Orange
            If tBPNo.Text = "" Then tBPNo.BackColor = Color.Orange
            If tLBPNo.Text = "" Then tLBPNo.BackColor = Color.Orange
            If tPolicyNo.Text = "" Then tPolicyNo.BackColor = Color.Orange
            If tAssignment.Text = "" Then tAssignment.BackColor = Color.Orange
            bReturn = True
        End If

        Return bReturn
    End Function

    Private Sub cbStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbStatus.SelectedIndexChanged
        If (cbStatus.Text = "Active") Then
            dtpStatus.Enabled = False
        Else
            dtpStatus.Enabled = True
        End If
    End Sub

    Private Sub tBasic_TextChanged(sender As Object, e As EventArgs) Handles tBasic.TextChanged, tFirstName.TextChanged, tMiddleName.TextChanged, tLastName.TextChanged, tAssignment.TextChanged, tEmail.TextChanged
        Dim myText As TextBox
        myText = sender
        myText.BackColor = Color.White
    End Sub
    Private Sub PopulateEmployeeDetails(sEmployeeID As String)
        Try


            If sEmployeeID = "" Then
                Exit Sub
            End If

            Dim sGetQry As String
            sGetQry = "Select * from tbl_user where user_id=" + sEmployeeID
            Dim dtSearched As DataTable
            dtSearched = GetDataAsTable(sGetQry)

            If (dtSearched.Rows.Count > 0) Then

                tFirstName.Tag = sEmployeeID
                tFirstName.Text = dtSearched.Rows(0)("first_name").ToString()
                tMiddleName.Text = dtSearched.Rows(0)("middle_name").ToString()
                tLastName.Text = dtSearched.Rows(0)("last_name").ToString()
                rbMale.Checked = True
                rbMale.Tag = "Male"
                If (dtSearched.Rows(0)("gender").ToString() = "Female") Then
                    rbFemale.Checked = True
                    rbMale.Tag = "Female"
                End If
                dtpDOB.Value = dtSearched.Rows(0)("b_date").ToString()
                cbMaritalStatus.SelectedItem = dtSearched.Rows(0)("marital_status").ToString()
                cbDependents.SelectedItem = dtSearched.Rows(0)("dependents").ToString()
                tContactNo.Text = dtSearched.Rows(0)("c_no").ToString()
                tBPNo.Text = dtSearched.Rows(0)("bp_number").ToString()
                tLBPNo.Text = dtSearched.Rows(0)("lbp_number").ToString()
                tPolicyNo.Text = dtSearched.Rows(0)("pol_number").ToString()
                tEmail.Text = dtSearched.Rows(0)("email").ToString()
                cbProvince.SelectedItem = dtSearched.Rows(0)("province").ToString()
                tAssignment.Text = dtSearched.Rows(0)("assigned_place").ToString()
                tAddress.Text = dtSearched.Rows(0)("address").ToString()
                cbDepartment.SelectedValue = dtSearched.Rows(0)("deptid").ToString()
                cbPosition.SelectedValue = dtSearched.Rows(0)("positionid").ToString()
                lSalaryGrade.Text = payrollDTO.SalaryGrade
                tBasic.Text = MoneyHelper.ToMoney(dtSearched.Rows(0)("basic_pay").ToString())
                dtpHired.Value = dtSearched.Rows(0)("date_hired").ToString()
                tEmployeeID.Text = dtSearched.Rows(0)("emp_id").ToString()
                cbStatus.SelectedItem = dtSearched.Rows(0)("status").ToString()
                If (cbStatus.Text <> "Active") Then
                    dtpStatus.Value = dtSearched.Rows(0)("status_date").ToString()
                End If
                tTIN.Text = dtSearched.Rows(0)("DIN").ToString()
                tGsis.Text = dtSearched.Rows(0)("gsis_no").ToString()
                tPhilhealth.Text = dtSearched.Rows(0)("philhealth").ToString()
                tPagibig.Text = dtSearched.Rows(0)("pagibig").ToString()

                If (IO.File.Exists(Application.StartupPath & "\images\" & tFirstName.Tag.ToString() & ".jpg")) Then
                    pbProfileImage.Image = Image.FromFile(Application.StartupPath & "\images\" & tFirstName.Tag.ToString() & ".jpg")
                End If
                bDelete.Enabled = True
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, sProjectTitle)
        End Try
    End Sub
    Private Sub bSearch_Click(sender As Object, e As EventArgs) Handles bSearch.Click
        Dim objSearch As New SearchRecord
        Dim sSearchedID1 As String = ""
        Try
            objSearch.sSearchedID = ""
            objSearch.sSearchQry = "select user_id,emp_id,first_name,middle_name,last_name,dept,job_pos from tbl_user where user_id!=" + iUserID.ToString()
            objSearch.sSearchKey = "first_name"
            objSearch.sSearchOrder = "order by dept,job_pos,first_name"
            objSearch.ShowDialog()
            sSearchedID1 = objSearch.sSearchedID
            ''MessageBox.Show("Selected Employee is : " + objSearch.sSearchedID)
            objSearch.Dispose()

            ClearForm()
            PopulateEmployeeDetails(sSearchedID1)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub bDelete_Click(sender As Object, e As EventArgs) Handles bDelete.Click

        If (MessageBox.Show("Are you Sure..?", sProjectTitle, MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No) Then Exit Sub

        If (tFirstName.Tag.ToString() = "0") Then
            MessageBox.Show("Please Select a Employee to DELETE")
        Else

            Dim sReturned, sQuery As String

            sQuery = "Delete tbl_logindetails where empid=" + tFirstName.Tag.ToString()
            sReturned = ExecuteDML(sQuery)

            If (sReturned.StartsWith("Error")) Then
                MessageBox.Show(sReturned)
                Exit Sub
            End If

            sQuery = "Delete tbl_user where user_id=" + tFirstName.Tag.ToString()
            sReturned = ExecuteDML(sQuery)

            If (sReturned.StartsWith("Error")) Then
                MessageBox.Show(sReturned)
                Exit Sub
            End If



            If (pbProfileImage.Tag = "1") Then
                pbProfileImage.Image.Save(Application.StartupPath & "\images\" + tFirstName.Tag.ToString() + ".jpg", Imaging.ImageFormat.Png)
            End If
            MessageBox.Show("Employee Detail DELETED Successfully")
            ClearForm()

        End If
    End Sub


End Class