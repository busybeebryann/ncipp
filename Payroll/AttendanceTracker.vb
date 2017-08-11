Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.OleDb
Imports Excel = Microsoft.Office.Interop.Excel
Public Class AttendanceTracker
    Dim objSettings As New GlobalSettings
    Dim da As SqlDataAdapter = Nothing
    Dim dt As New DataTable
    Dim SQL As String = ""
    Public EmpId As String = ""
    Public mpSal As String = ""

    Dim xlApp As New Excel.Application
    Dim xlWorkBook As Excel.Workbook
    Dim xlWorkSheet As Excel.Worksheet
    Dim ROW_INX As Integer
    
    Private Sub AttendanceTracker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAttendance()
    End Sub

    Private Sub LoadAttendance()
        Try
            dgvAttendance.DataSource = GetDataAsTable("Select * from tbl_AttPayroll")
            dgvAttendance.Columns(0).Visible = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class