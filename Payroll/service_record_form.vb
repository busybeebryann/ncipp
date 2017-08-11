Imports System.Data.SqlClient
Imports System.Data

Public Class serviceform
    Public myStatus As String
    Public myEmployeeID As String
    Public myServiceID As String
    Dim objSettings As New GlobalSettings
    Dim conn As New SqlConnection(objSettings.GlobalStringConnetion)
    Dim conn2 As New SqlConnection()
    Dim da As SqlDataAdapter = Nothing
    Dim dt As New DataTable
    Dim SQL As String = ""

    Private Sub serviceform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If myStatus = "" Or myEmployeeID = "" Then
            MessageBox.Show("Wrong Call...!")
            Me.Close()
        End If

        Dim sEmployeeQry As String
        sEmployeeQry = "select user_id,emp_id,first_name,middle_name,last_name,philhealth,din,gsis_no,assigned_place from tbl_user where emp_id=" + myEmployeeID
        Dim dtTemp As DataTable
        dtTemp = GetDataAsTable(sEmployeeQry)
        If (dtTemp.Rows.Count > 0) Then
            tEmployeeID.Text = dtTemp.Rows(0)("emp_id").ToString()
            tFirstName.Text = dtTemp.Rows(0)("first_name").ToString()
            tLastName.Text = dtTemp.Rows(0)("last_name").ToString()
            tMiddleName.Text = dtTemp.Rows(0)("middle_name").ToString()
            tPhicNo.Text = dtTemp.Rows(0)("philhealth").ToString()
            tTIN.Text = dtTemp.Rows(0)("din").ToString()
            tGSIS.Text = dtTemp.Rows(0)("gsis_no").ToString()
            tPlace.Text = dtTemp.Rows(0)("assigned_place").ToString()
        Else
            MessageBox.Show("Can't find Employee Details")
            Me.Close()
        End If
        ClearForm()
        If myStatus = "NEW" Then

        Else
            If (myServiceID = "") Then
                MessageBox.Show("Service ID Missing....!")
                Me.Close()
            End If
            LoadServiceDetails()
           
        End If
    End Sub
    Private Sub LoadServiceDetails()
        Dim sServiceQry As String
        sServiceQry = "select ID,Designation,AppointmentStatus,MonthlySalary,AnnualSalary,OfficeAssignment,Remarks,FromDate,ToDate from tservice where ID=" + myServiceID
        Dim dtTemp1 As DataTable
        dtTemp1 = GetDataAsTable(sServiceQry)
        If (dtTemp1.Rows.Count > 0) Then
            tDesignation.Text = dtTemp1.Rows(0)("Designation").ToString()
            tDesignation.Tag = dtTemp1.Rows(0)("ID").ToString()
            cbAppointmentStatus.SelectedItem = dtTemp1.Rows(0)("AppointmentStatus").ToString()
            tMonthlySalary.Text = Convert.ToDecimal(dtTemp1.Rows(0)("MonthlySalary").ToString())
            tAnnualSalary.Text = dtTemp1.Rows(0)("AnnualSalary").ToString()
            tRemarks.Text = dtTemp1.Rows(0)("Remarks").ToString()
            tOffice.Text = dtTemp1.Rows(0)("OfficeAssignment").ToString()
            dtpFrom.Value = dtTemp1.Rows(0)("FromDate").ToString()
            dtpTo.Value = dtTemp1.Rows(0)("ToDate").ToString()
        Else
            MessageBox.Show("Can't find Service Records")
        End If
    End Sub

    Private Function ValidateForm() As Boolean
        Dim bReturn As Boolean = False
        If (tDesignation.Text = "" Or tOffice.Text = "" Or tMonthlySalary.Text = "" _
            Or tAnnualSalary.Text = "") Then
            MessageBox.Show("Please enter valid data")
            bReturn = True
        End If

        If dtpFrom.Value = dtpTo.Value Or (dtpTo.Value < dtpFrom.Value) Then
            MessageBox.Show("Please Check Dates")
            bReturn = True
        End If

        Return bReturn
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ''VALIDATE FORM
        If ValidateForm() Then Exit Sub

        Dim sDMQry, sMessage As String
        Dim sReturend As String = ""

        Dim sdtFrom As String = dtpFrom.Value.ToString("dd-MMM-yyyy", System.Globalization.CultureInfo.InvariantCulture)
        Dim sdtTo As String = dtpTo.Value.ToString("dd-MMM-yyyy", System.Globalization.CultureInfo.InvariantCulture)
        Try

            If (tDesignation.Tag.ToString() = "0") Then
                'ADDING NEW RECORD  

                sDMQry = "insert into tservice values(" + myEmployeeID + ",'" + tDesignation.Text + _
                    "','" + cbAppointmentStatus.SelectedItem.ToString() + "'," + tMonthlySalary.Text + _
                    "," + tAnnualSalary.Text + ",'" + tOffice.Text + "','" + tRemarks.Text + _
                    "','" + sdtFrom + "','" + sdtTo + "',getdate(),getdate())"
                sMessage = "Service Record Added Successfully"
            Else
                'UPDATE FOR EXISTING RECORD  
                sDMQry = "update tservice set designation='" + tDesignation.Text + "',appointmentstatus='" + cbAppointmentStatus.SelectedItem.ToString() + _
                    "',monthlysalary=" + tMonthlySalary.Text + _
                    ",annualsalary=" + tAnnualSalary.Text + ",officeassignment='" + tOffice.Text + "',remarks='" + tRemarks.Text + _
                    "',fromdate='" + sdtFrom + "',todate='" + sdtTo + "',modifiedon=getdate() where id=" + tDesignation.Tag.ToString()
                sMessage = "Service Record UPDATED Successfully"
            End If

            sReturend = ExecuteDML(sDMQry)
            If sReturend <> "True" Then
                MessageBox.Show(sReturend)
                Exit Sub
            Else
                MessageBox.Show(sMessage, sProjectTitle)
                ClearForm()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        ClearForm()
    End Sub
    Private Sub ClearForm()
        tDesignation.Clear()
        tDesignation.Tag = "0"
        cbAppointmentStatus.SelectedIndex = 0
        tAnnualSalary.Clear()
        tMonthlySalary.Clear()
        tOffice.Clear()
        tRemarks.Clear()
        dtpFrom.Value = DateTime.Now
        dtpTo.Value = DateTime.Now
        LoadServiceRecords()
        tDesignation.Focus()
    End Sub
    Private Sub LoadServiceRecords()
        Try
            Dim sQry As String
            sQry = "select ID,EmployeeID,Designation,AppointmentStatus,MonthlySalary,AnnualSalary,OfficeAssignment,Remarks,FromDate,ToDate from tservice where employeeid=" + myEmployeeID
            dgvServiceRecord.DataSource = GetDataAsTable(sQry)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub bClose_Click(sender As Object, e As EventArgs) Handles bClose.Click
        Me.Close()
    End Sub

    Private Sub tMonthlySalary_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tMonthlySalary.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub tAnnualSalary_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tAnnualSalary.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub dgvServiceRecord_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvServiceRecord.CellClick
        If (e.RowIndex >= 0) Then
            myServiceID = dgvServiceRecord.Rows(e.RowIndex).Cells("serviceID").Value
            LoadServiceDetails()
        End If
    End Sub


End Class