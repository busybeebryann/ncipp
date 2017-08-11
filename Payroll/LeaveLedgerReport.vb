Imports System.Data.SqlClient
Imports System.Data
Imports System.Text.RegularExpressions
Imports System.Data.OleDb
Imports Excel = Microsoft.Office.Interop.Excel

Public Class LeaveLedgerReport
    Dim LedgerBO As New Ledger
    Dim objSettings As New GlobalSettings
   
    Dim strsql As String
    Dim drange As String
    Dim cdrange As String = "none"
    Dim datenow As DateTime
    Dim mnow As String = ""
    Dim firstDayOfMonth, LastDayOfMonth As Date
    Dim sPeriod As String = ""
    Dim sUserID As String = ""
    Dim oEmployeeID As String = ""
    Dim dtSearched As DataTable
    Private Sub getEmployee()
        Try
            Dim sGetQry As String
            sGetQry = "select user_id,emp_id,first_name,last_name,job_pos,dept,status,basic_pay,b_date,date_hired from tbl_user where user_id= '" + sUserID + "'"

            dtSearched = GetDataAsTable(sGetQry)

            If (dtSearched.Rows.Count > 0) Then

                txtempid.Text = dtSearched.Rows(0)("emp_id").ToString()
                txtFirstname.Text = dtSearched.Rows(0)("first_name").ToString()
                txtLastname.Text = dtSearched.Rows(0)("last_name").ToString()
            End If

            If Not txtempid.Text = "" Then

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, sProjectTitle)
        End Try
    End Sub

    Private Sub LeaveLedgerReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub LoadMonthandYear()
        Dim firstDayOfMonth As Date
        Dim stringMonth As String
        'MessageBox.Show(firstDayOfMonth.ToString("MMM") + " " + firstDayOfMonth.Day.ToString() + "-" + LastDayOfMonth.Day.ToString() + " " + Year(firstDayOfMonth).ToString)
        Dim iMonth As Integer
        For iMonth = 1 To 12
            firstDayOfMonth = Convert.ToDateTime(DateTime.Now.Year.ToString() + "-" + iMonth.ToString() + "-" + "1")
            stringMonth = firstDayOfMonth.ToString("MMMM")
            ' cbMonth.Items.Add(stringMonth)
        Next

        Dim iYear As Integer
        For iYear = 2010 To Today.Year
            cbYear.Items.Add(iYear.ToString())
        Next

        If (cbYear.Items.Count > 0) Then cbYear.SelectedIndex = -1

    End Sub

    Private Sub bClose_Click(sender As Object, e As EventArgs) Handles bClose.Click
        Me.Close()
    End Sub

    Private Sub bGenerate_Click(sender As Object, e As EventArgs) Handles bGenerate.Click
        Try
            With LedgerBO
                .EmployeeId = txtempid.Text
                .sYear = cbYear.Text
                .GenerateLeaveLedger()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
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
            getEmployee()
            LoadMonthandYear()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class