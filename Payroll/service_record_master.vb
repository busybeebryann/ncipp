Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.OleDb
Imports Excel = Microsoft.Office.Interop.Excel

Public Class service_record_master
    Dim objSettings As New GlobalSettings
    Dim conn As New SqlConnection(objSettings.GlobalStringConnetion)
    Dim da As SqlDataAdapter = Nothing
    Dim dt As New DataTable
    Dim SQL As String = ""
    Public EmpId As String = ""
    Public mpSal As String = ""

    Dim xlApp As New Excel.Application
    Dim xlWorkBook As Excel.Workbook
    Dim xlWorkSheet As Excel.Worksheet
    Dim ROW_INX As Integer

    Private Sub service_record_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEmployeeID()
    End Sub

    Private Sub LoadEmployeeID()
        Try
            cbEmployee.Tag = "False"

            cbEmployee.DisplayMember = "emp_id"
            cbEmployee.ValueMember = "user_id"
            cbEmployee.DataSource = GetDataAsTable("select  user_id,emp_id from tbl_user")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cbEmployee.Tag = "True"
        If (cbEmployee.Items.Count > 0) Then
            cbEmployee.SelectedIndex = 0
            LoadServiceRecords()
        End If
    End Sub

    Private Sub LoadServiceRecords()
        Try
            If (cbEmployee.Tag.ToString() = "False") Then Exit Sub

            dgvServiceRecords.DataSource = GetDataAsTable _
                    ("select s.ID,u.emp_id,u.first_name,s.designation,s.appointmentstatus,s.monthlysalary," + _
                    "s.annualsalary,s.officeassignment,s.remarks,s.fromdate,s.todate from tservice s join tbl_user u " + _
                    "on s.employeeid=u.user_id where s.employeeid=" + cbEmployee.SelectedValue.ToString())
            dgvServiceRecords.Columns(0).Visible = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim objService As New serviceform
        objService.myStatus = "NEW"
        objService.myEmployeeID = cbEmployee.SelectedValue.ToString()
        objService.ShowDialog()

    End Sub

    Private Sub cbEmployee_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEmployee.SelectedIndexChanged
        If (cbEmployee.SelectedIndex >= 0) Then
            Try
                tName.Text = GetAStringValue("Select first_name+' '+last_name as 'fullname' from tbl_user where user_id=" + cbEmployee.SelectedValue.ToString())
                LoadServiceRecords()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (dgvServiceRecords.Rows.Count <= 0) Then
            MessageBox.Show("There is NO Record to Update")
            Exit Sub
        End If

        If (dgvServiceRecords.CurrentRow.Index >= 0) Then
            Dim objService As New serviceform
            objService.myStatus = "EDIT"
            objService.myEmployeeID = cbEmployee.SelectedValue.ToString()
            objService.myServiceID = dgvServiceRecords.Rows(dgvServiceRecords.CurrentRow.Index).Cells("ID").Value.ToString()
            objService.ShowDialog()
        Else
            MessageBox.Show("Please Select a Record to Update", sProjectTitle)
        End If
    End Sub

    Private Sub bClose_Click(sender As Object, e As EventArgs) Handles bClose.Click
        Me.Close()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        If (dgvServiceRecords.Rows.Count <= 0) Then
            MessageBox.Show("There is NO Record to Print")
            Exit Sub
        End If

        If (dgvServiceRecords.CurrentRow.Index >= 0) Then
            Dim rptServiceRecords As DataTable
            Dim sQuery As String
            Dim sEmpID As String
            Dim sNewFileName As String
            Try

                sEmpID = cbEmployee.SelectedValue.ToString()

                sQuery = "SELECT U.User_id,U.Emp_id,U.first_name,U.last_name,U.middle_name,U.b_date,U.Address," + _
                    "S.Designation, S.AppointmentStatus, S.MonthlySalary,S.AnnualSalary,S.Remarks, S.OfficeAssignment," + _
                    "S.FromDate, S.ToDate,U.assigned_place,U.Tax,U.gsis_no,U.philhealth " + _
                    "from tbl_user U join tService S on U.User_id=S.EmployeeID where S.Employeeid=" + sEmpID

                rptServiceRecords = GetDataAsTable(sQuery)

                ''MessageBox.Show("Data Fetched")
                If (rptServiceRecords.Rows.Count > 0) Then

                    sNewFileName = Application.StartupPath & "\Reports\Service_" & rptServiceRecords.Rows(0)(1).ToString() & ".xls"
                    IO.File.Copy(Application.StartupPath & "\Reports\Service.xls", sNewFileName, True)
                    xlWorkBook = xlApp.Workbooks.Open(sNewFileName)
                    ''xlWorkBook.SaveCopyAs("\Reports\Service1.xls")
                    xlWorkSheet = xlWorkBook.Sheets(1)
                    Dim dc As DataColumn
                    Dim dr As DataRow

                    With xlWorkSheet
                        Dim myRange, row As Excel.Range
                        Dim sheet = xlWorkBook.ActiveSheet
                        Dim str_text As String

                        'Populating data from table
                        'First Name
                        myRange = sheet.Range("B10")
                        myRange.Value = rptServiceRecords.Rows(0)(2).ToString()
                        'Givven name
                        myRange = sheet.Range("D10")
                        myRange.Value = rptServiceRecords.Rows(0)(3).ToString()
                        'Middle Name
                        myRange = sheet.Range("H10")
                        myRange.Value = rptServiceRecords.Rows(0)(4).ToString()
                        'Date of Birth
                        myRange = sheet.Range("B13")
                        myRange.Value = rptServiceRecords.Rows(0)(5).ToString()
                        'Place
                        myRange = sheet.Range("E13")
                        myRange.Value = rptServiceRecords.Rows(0)(15).ToString()
                        'TIN - A15
                        myRange = sheet.Range("A15")
                        myRange.Value = rptServiceRecords.Rows(0)("Tax").ToString()
                        'GSIS - E15
                        myRange = sheet.Range("E15")
                        myRange.Value = "TIN No." + rptServiceRecords.Rows(0)("gsis_no").ToString()
                        'Philhealth - H15
                        myRange = sheet.Range("H15")
                        myRange.Value = "PHIC No." + rptServiceRecords.Rows(0)("philhealth").ToString()
                        'Date Prepared - A53
                        myRange = sheet.Range("A53")
                        myRange.Value = DateTime.Now.ToString("MMM d,yyyy")


                        ROW_INX = 19

                        For Each dr In rptServiceRecords.Rows
                            .Cells(ROW_INX, "A") = dr("FromDate").ToString()  'From Date
                            .Cells(ROW_INX, "B") = dr("ToDate").ToString()  'To Date
                            .Cells(ROW_INX, "C") = dr("Designation").ToString()  'Designation
                            .Cells(ROW_INX, "D") = dr("AppointmentStatus").ToString()  'Appointment Status
                            .Cells(ROW_INX, "E") = dr("MonthlySalary").ToString()  'Salary Month
                            .Cells(ROW_INX, "F") = dr("AnnualSalary").ToString()  'Salary Annual
                            .Cells(ROW_INX, "G") = dr("OfficeAssignment").ToString()  'Office Assignment
                            ''.Cells(ROW_INX, "H") = dr("FromDate").ToString()  'Branch
                            ''.Cells(ROW_INX, "I") = dr("FromDate").ToString()  'LWOP
                            .Cells(ROW_INX, "J") = dr("Remarks").ToString()  'Remarks

                            ROW_INX = ROW_INX + 1

                        Next
                    End With
                    MessageBox.Show("Report Generated Successfully")

                    xlApp.Visible = True
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            ''xlWorkSheet = Nothing
            ''xlWorkBook = Nothing
            ''xlApp.Quit()
            ''xlApp = Nothing

        Else
            MessageBox.Show("Please Select a Record to Update", sProjectTitle)
        End If

        'MessageBox.Show("Yet to develope....!!!")
       
    End Sub
End Class