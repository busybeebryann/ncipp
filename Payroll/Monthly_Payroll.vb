Imports System.Data.SqlClient
Imports System.Data
Imports System.Text.RegularExpressions
Imports System.Data.OleDb
Imports Excel = Microsoft.Office.Interop.Excel

Public Class Monthly_Payroll
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

    Private Sub Monthly_Payroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMonthandYear()
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
        For iYear = 1900 To Today.Year
            cbYear.Items.Add(iYear.ToString())
        Next

        cbMonth.SelectedIndex = 0
        cbYear.SelectedIndex = 0
        cbProvince.SelectedIndex = 0

    End Sub

    Private Sub bClose_Click(sender As Object, e As EventArgs) Handles bClose.Click
        Me.Close()
    End Sub

    Private Sub bGenerate_Click(sender As Object, e As EventArgs) Handles bGenerate.Click
        '  select * from tPayroll where emp_id='PL20170003' and daterange='Dec 1-31 2017'
        Dim rptServiceRecords As DataTable
        Dim sQuery As String
        Dim sPeriod As String
        Dim sNewFileName As String
        Dim firstDayOfMonth, LastDayOfMonth As Date

        Try
            ' FINDING PERIOD FOR SELECTED MONTH AND YEAR
            firstDayOfMonth = Convert.ToDateTime(cbYear.Text + "-" + (cbMonth.SelectedIndex + 1).ToString() + "-" + "1")
            LastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1)
            sPeriod = firstDayOfMonth.ToString("MMM") + " " + firstDayOfMonth.Day.ToString() + "-" + LastDayOfMonth.Day.ToString() + " " + cbYear.Text

            sQuery = "select salary_id,emp_id,emp_name,position,department,daterange,civil_stat,dependents,rate_day,rate_hour,NH,OT,ND," + _
                "monthly_pay,PERA,Grosspay,policy_loan,e_card,emergency_loan,conso_loan,pagibig_loan,pagibig_housing,ncipae_loan," + _
                "lbp_loan,educ_loan,uoli_cont,gsis_social_cont,ncipae_man_fee,ncipae_mem_fee,Philhealth,Pagibig,TAX,net_pay," + _
                "additional_deductions,status,date_computed,month_computed,time_computed,tDed,province from " + _
                "tPayroll where daterange='" + sPeriod + "' and province='" + cbProvince.Text + "'"

            rptServiceRecords = GetDataAsTable(sQuery)

            ''MessageBox.Show("Data Fetched")
            If (rptServiceRecords.Rows.Count > 0) Then

                sNewFileName = firstDayOfMonth.ToString("MMM") + "_" + firstDayOfMonth.Day.ToString() + "_" + LastDayOfMonth.Day.ToString() + "_" + cbYear.Text

                sNewFileName = Application.StartupPath & "\Reports\MonthPayroll_" & sNewFileName & ".xls"
                IO.File.Copy(Application.StartupPath & "\Reports\MonthPayroll1.xls", sNewFileName, True)
                xlWorkBook = xlApp.Workbooks.Open(sNewFileName)
                ''xlWorkBook.SaveCopyAs("\Reports\Service1.xls")
                xlWorkSheet = xlWorkBook.Sheets(1)
                ''Dim dc As DataColumn
                ''Dim dr As DataRow
                Dim iRow As Integer
                Dim iFillRow As Integer = 12

                With xlWorkSheet
                    Dim myRange, row As Excel.Range
                    Dim sheet = xlWorkBook.ActiveSheet
                    ''Dim str_text As String
                    myRange = sheet.Range("C4")
                    myRange.Value = "For the Month of " + sPeriod

                    For iRow = 0 To rptServiceRecords.Rows.Count - 1

                        iFillRow = iFillRow + iRow
                        'First Name
                        myRange = sheet.Range("D" + iFillRow.ToString())
                        myRange.Value = rptServiceRecords.Rows(iRow)("emp_name").ToString()

                        myRange = sheet.Range("E" + iFillRow.ToString())
                        myRange.Value = rptServiceRecords.Rows(iRow)("position").ToString()

                        myRange = sheet.Range("G" + iFillRow.ToString())
                        myRange.Value = rptServiceRecords.Rows(iRow)("monthly_pay").ToString()
                        myRange = sheet.Range("O" + iFillRow.ToString())
                        myRange.Value = rptServiceRecords.Rows(iRow)("policy_loan").ToString()
                        myRange = sheet.Range("P" + iFillRow.ToString())
                        myRange.Value = rptServiceRecords.Rows(iRow)("uoli_cont").ToString()
                        myRange = sheet.Range("Q" + iFillRow.ToString())
                        myRange.Value = rptServiceRecords.Rows(iRow)("emergency_loan").ToString()
                        myRange = sheet.Range("R" + iFillRow.ToString())
                        myRange.Value = rptServiceRecords.Rows(iRow)("conso_loan").ToString()
                        myRange = sheet.Range("S" + iFillRow.ToString())
                        myRange.Value = rptServiceRecords.Rows(iRow)("pagibig_loan").ToString()
                        myRange = sheet.Range("T" + iFillRow.ToString())
                        myRange.Value = rptServiceRecords.Rows(iRow)("pagibig_housing").ToString()
                        myRange = sheet.Range("U" + iFillRow.ToString())
                        myRange.Value = rptServiceRecords.Rows(iRow)("Pagibig").ToString()

                        myRange = sheet.Range("AD" + iFillRow.ToString())
                        myRange.Value = rptServiceRecords.Rows(iRow)("educ_loan").ToString()
                        myRange = sheet.Range("AF" + iFillRow.ToString())
                        myRange.Value = rptServiceRecords.Rows(iRow)("Philhealth").ToString()

                        myRange = sheet.Range("AI" + iFillRow.ToString())
                        myRange.Value = rptServiceRecords.Rows(iRow)("TAX").ToString()

                    Next
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