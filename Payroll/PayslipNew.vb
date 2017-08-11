Imports System.Data.SqlClient
Imports System.Data
Imports System.Text.RegularExpressions
Imports System.Data.OleDb
Imports Excel = Microsoft.Office.Interop.Excel

Public Class PayslipNew
    Dim objBiz As New Payroll
    Dim objSettings As New GlobalSettings
    ''Dim acsconn As New SqlConnection
    ''Dim acsdr As SqlDataReader
    Dim strsql As String
    Dim drange As String
    Dim cdrange As String = "none"
    Dim datenow As DateTime
    Dim mnow As String = ""
    Dim firstDayOfMonth, LastDayOfMonth As Date
    Dim sPeriod As String = ""
    Dim sUserID As String = ""
    Dim oEmployeeID As String = ""

    Dim xlApp As New Excel.Application
    Dim xlWorkBook As Excel.Workbook
    Dim xlWorkSheet As Excel.Worksheet
    Dim ROW_INX As Integer
    Private Sub PayslipNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMonthandYear()
        LoadEmployee()
    End Sub

    Private Sub LoadMonthandYear()
        Dim firstDayOfMonth As Date
        Dim stringMonth As String
        'MessageBox.Show(firstDayOfMonth.ToString("MMM") + " " + firstDayOfMonth.Day.ToString() + "-" + LastDayOfMonth.Day.ToString() + " " + Year(firstDayOfMonth).ToString)
        Dim iMonth As Integer
        For iMonth = 1 To 12
            firstDayOfMonth = Convert.ToDateTime(DateTime.Now.Year.ToString() + "-" + iMonth.ToString() + "-" + "1")
            stringMonth = firstDayOfMonth.ToString("MMMM")
            cbMonth.Items.Add(stringMonth)
        Next

        Dim iYear As Integer
        For iYear = 1900 To 2100
            cbYear.Items.Add(iYear.ToString())
        Next

        cbMonth.SelectedIndex = 0
        cbYear.SelectedIndex = 0

    End Sub

    Private Sub LoadEmployee()

        cbEmployee.DataSource = GetDataAsTable("select emp_id,first_name+ ' ' + last_name as name1 from tbl_user where status='Active'")
        cbEmployee.DisplayMember = "name1"
        cbEmployee.ValueMember = "emp_id"
    End Sub

    Private Sub bClose_Click(sender As Object, e As EventArgs) Handles bClose.Click
        Me.Close()
    End Sub

    Private Sub bGenerate_Click(sender As Object, e As EventArgs) Handles bGenerate.Click
        '  select * from tPayroll where emp_id='PL20170003' and daterange='Dec 1-31 2017'
        Dim rptServiceRecords As DataTable
        Dim sQuery As String
        Dim sEmpID, sPeriod As String
        Dim sNewFileName As String
        Try

            ' FINDING PERIOD FOR SELECTED MONTH AND YEAR
            firstDayOfMonth = Convert.ToDateTime(cbYear.Text + "-" + (cbMonth.SelectedIndex + 1).ToString() + "-" + "1")
            LastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1)
            sPeriod = firstDayOfMonth.ToString("MMM") + " " + firstDayOfMonth.Day.ToString() + "-" + LastDayOfMonth.Day.ToString() + " " + cbYear.Text

            sEmpID = cbEmployee.SelectedValue.ToString()

            sQuery = "select salary_id,emp_id,emp_name,position,department,daterange,civil_stat,dependents,rate_day,rate_hour,NH,OT,ND," + _
                "monthly_pay,PERA,Grosspay,policy_loan,e_card,emergency_loan,conso_loan,pagibig_loan,pagibig_housing,ncipae_loan," + _
                "lbp_loan,educ_loan,uoli_cont,gsis_social_cont,ncipae_man_fee,ncipae_mem_fee,Philhealth,Pagibig,TAX,net_pay," + _
                "additional_deductions,status,date_computed,month_computed,time_computed,tDed,province from " + _
                "tPayroll where emp_id='" + sEmpID + "' and daterange='" + sPeriod + "'"

            rptServiceRecords = GetDataAsTable(sQuery)

            ''MessageBox.Show("Data Fetched")
            If (rptServiceRecords.Rows.Count > 0) Then

                sNewFileName = Application.StartupPath & "\Reports\PaySlip_" & sEmpID & ".xls"
                IO.File.Copy(Application.StartupPath & "\Reports\PaySlip.xls", sNewFileName, True)
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
                    myRange = sheet.Range("A1")
                    myRange.Value = cbEmployee.Text 'rptServiceRecords.Rows(0)(2).ToString()
                    'Period
                    myRange = sheet.Range("J1")
                    myRange.Value = sPeriod

                    'I3  - Place of Assignment

                    'D3 Basic Monthly Salary

                    'C10 - Emergency Loan
                    myRange = sheet.Range("C10")
                    myRange.Value = rptServiceRecords.Rows(0)("emergency_loan").ToString()
                    ''C11 - Conso Loan
                    myRange = sheet.Range("C11")
                    myRange.Value = rptServiceRecords.Rows(0)("conso_loan").ToString()
                    '
                    '
                    ''C15 - Policy Loan
                    myRange = sheet.Range("C15")
                    myRange.Value = rptServiceRecords.Rows(0)("policy_loan").ToString()

                    ''I16 - Educ Loan
                    myRange = sheet.Range("I16")
                    myRange.Value = rptServiceRecords.Rows(0)("educ_loan").ToString()


                    'C17 - Pagibig Loan
                    myRange = sheet.Range("C17")
                    myRange.Value = rptServiceRecords.Rows(0)("pagibig_loan").ToString()

                    'I19 - LBP Loan
                    myRange = sheet.Range("I19")
                    myRange.Value = rptServiceRecords.Rows(0)("lbp_loan").ToString()


                    'I22 - Social
                    myRange = sheet.Range("I22")
                    myRange.Value = rptServiceRecords.Rows(0)("gsis_social_cont").ToString()


                    'C23 - Pagibig Cont 
                    myRange = sheet.Range("C23")
                    myRange.Value = rptServiceRecords.Rows(0)("Pagibig").ToString()
                    'I24 - PHIC Cont 
                    myRange = sheet.Range("I24")
                    myRange.Value = rptServiceRecords.Rows(0)("Philhealth").ToString()

                    'I25 - Pagibig Cont 
                    myRange = sheet.Range("I25")
                    myRange.Value = rptServiceRecords.Rows(0)("TAX").ToString()

                    'C26 - NCIPEA Cont 
                    myRange = sheet.Range("C26")
                    myRange.Value = rptServiceRecords.Rows(0)("ncipae_man_fee").ToString()


                End With
                MessageBox.Show("Report Generated Successfully")

                xlApp.Visible = True
            Else
                MessageBox.Show("NO Record(s) Found", sProjectTitle)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class