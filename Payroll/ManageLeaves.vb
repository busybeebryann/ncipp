Imports System.Data.SqlClient
Imports WindowsApplication1.Enums
Imports WindowsApplication1.Extensions
Public Class ManageLeaves
    Property DTO As LeaveDTO
    Public sUserID As String
    Dim objSettings As New GlobalSettings
    Dim acsconn As New SqlConnection
    Dim acsdr As SqlDataReader
    Dim strsql As String
    Dim count As Integer
    Dim sickCredits As Decimal
    Dim vacCredits As Decimal
    Dim dtSearched As DataTable

    Private Sub GetEmployee()
        Try
            Dim sGetQry As String
            sGetQry = "select user_id,emp_id,first_name,last_name,job_pos,dept,status,basic_pay,b_date,date_hired from tbl_user where user_id= '" + sUserID + "'"

            dtSearched = GetDataAsTable(sGetQry)

            If (dtSearched.Rows.Count > 0) Then

                txtempid.Text = dtSearched.Rows(0)("emp_id").ToString()
                txtFirstname.Text = dtSearched.Rows(0)("first_name").ToString()
                txtLastname.Text = dtSearched.Rows(0)("last_name").ToString()
                txtPosition.Text = dtSearched.Rows(0)("job_pos").ToString()
                txtDepartment.Text = dtSearched.Rows(0)("dept").ToString()
            End If

            If Not txtempid.Text = "" Then
 
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, sProjectTitle)
        End Try
    End Sub
    Private Sub loadLeaveTypes()
        For Each item In [Enum].GetValues(GetType(LeaveType))
            cbLeaveType.Items.Add(item)
        Next
        If (cbLeaveType.Items.Count > 0) Then cbLeaveType.SelectedIndex = -1
    End Sub
    Private Sub btnLookup_Click(sender As Object, e As EventArgs) Handles btnLookup.Click
        Dim objSearch As New SearchRecord
        Dim sSearchedID1 As String = ""
        Try

            objSearch.sSearchedID = ""
            objSearch.sSearchQry = "select user_id,emp_id,first_name,last_name,dept,job_pos,marital_status,basic_pay from tbl_user where user_id!=" + iUserID.ToString()
            objSearch.sSearchKey = "last_name"
            objSearch.sSearchOrder = "order by dept,job_pos,first_name"
            objSearch.ShowDialog()
            sSearchedID1 = objSearch.sSearchedID
            sUserID = sSearchedID1
            ''MessageBox.Show("Selected Employee is : " + objSearch.sSearchedID)
            objSearch.Dispose()
            'ClearForm()
            GetEmployee()
            loadLeaveTypes()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub MapToDTO()
        With DTO

        End With
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'get number of days
        If txtempid.Text = "" Or cbLeaveType.SelectedIndex = -1 Then
            MessageBox.Show("Please Select Employee and Leave Type")
            Exit Sub
        Else
            lName.Text = txtFirstname.Text + " " + txtLastname.Text
            lPost.Text = txtPosition.Text
            lDept.Text = txtDepartment.Text
            lEmpId.Text = txtempid.Text
            lAppointment.Text = dtSearched.Rows(0)("job_pos").ToString()
            lBirthdate.Text = dtSearched.Rows(0)("b_date").ToString()
            lLeaveType.Text = cbLeaveType.Text
            lDatehire.Text = dtSearched.Rows(0)("date_hired").ToString()
            lDate.Text = dptStartDate.Value.ToString("MM/dd/yyyy")
        End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim sQuery, sMessage As String
        Try


            If lEmpId.Text = "" Then
                MessageBox.Show("Summarize the application before saving")
                Exit Sub
            Else

                If lLeaveType.Text = "Sick" Then
                    sickCredits = nSLBalance.Value
                    vacCredits = 0.0
                ElseIf lLeaveType.Text = "Vacation" Then
                    vacCredits = nVLBalance.Value
                    sickCredits = 0.0
                End If


                sQuery = String.Format("INSERT INTO tLeave (emp_id,leave_type,no_days,no_paid,start_date,end_date,slcredits,vlcredits,remark,modifiedon,createdon) " + _
                                       "VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}',getdate(),getdate())", _
                                    lEmpId.Text, cbLeaveType.Text, lDatehire.Text, lDate.Text, dptStartDate.Value, dtEndDate.Value, sickCredits, vacCredits, txtRemarks.Text)
                sMessage = "Leaves record ADDED Successfully"
            End If

            Dim sRt As String = ""
            sRt = ExecuteDML(sQuery)
            If sRt = "True" Then
                MessageBox.Show(sMessage)
                ' ClearForm()
                'check/update sl and vl earned for the next month
            Else
                MessageBox.Show("Error : " + sRt)
            End If
        Catch ex As Exception
            MessageBox.Show("Error : " + ex.Message)
        End Try
    End Sub

    Private Sub cbLeaveType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbLeaveType.SelectedIndexChanged
        If cbLeaveType.SelectedIndex = 0 Then
            nSLBalance.Enabled = True
            nVLBalance.Enabled = False
        ElseIf cbLeaveType.SelectedIndex = 1 Then
            nSLBalance.Enabled = False
            nVLBalance.Enabled = True
        Else
            nSLBalance.Enabled = True
            nVLBalance.Enabled = True
        End If
    End Sub

End Class
