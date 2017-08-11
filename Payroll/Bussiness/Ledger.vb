Imports WindowsApplication1.Extensions
Imports System.Data.OleDb
Imports Excel = Microsoft.Office.Interop.Excel
Imports WindowsApplication1.Enums
Public Class Ledger
    Property Leaves As LeaveDTO
    Property Attendance As AttendanceDTO

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

    Dim dYear As Date
    Dim dtLeaveReport As DataTable
    Dim dtEarnings As DataTable
    Dim xlApp As New Excel.Application
    Dim xlWorkBook As Excel.Workbook
    Dim xlWorkSheet As Excel.Worksheet
    Dim ROW_INX As Integer
    Dim sNewFileName As String
    Dim sQuery As String
    Private Property _oEmployeeID As String
    Private Property _sYear As String
    Public Property EmployeeId() As String
        Get
            Return _oEmployeeID
        End Get
        Set(ByVal value As String)
            _oEmployeeID = value
        End Set
    End Property
    Public Property sYear() As String
        Get
            Return _sYear
        End Get
        Set(ByVal value As String)
            _sYear = value
        End Set
    End Property
    Public Sub New()

    End Sub
    Public Sub GenerateLeaveLedger()

        Try
            Dim sQuery As String
            sQuery = String.Format("SELECT U.emp_id,L.emp_id,U.last_name,U.first_name,U.middle_name,U.job_pos,U.b_date,U.assigned_place,L.slcredits,L.vlcredits,L.leave_type,L.createdon,DATENAME(yyyy,L.createdon ) AS Year  FROM tLeave L JOIN tbl_user U " + _
                    "ON L.emp_id = U.emp_id WHERE  U.emp_id = '{0}' AND  DATEPART(yyyy,L.createdon) = {1} ", _oEmployeeID, _sYear)
            dtLeaveReport = GetDataAsTable(sQuery)
            sQuery = ""

            sQuery = String.Format("SELECT emp_id,slbalance,vlbalance,modifiedon,createdon FROM tEarnedCredits WHERE emp_id ='{0}' ", _oEmployeeID, _sYear)
            dtEarnings = GetDataAsTable(sQuery)

            If (dtLeaveReport.Rows.Count > 0) Then
                firstDayOfMonth = dtLeaveReport.Rows(0)("createdon")
                sNewFileName = dtLeaveReport.Rows(0)("emp_id").ToString

                sNewFileName = Application.StartupPath & "\Reports\LeaveLedger_" & sNewFileName & ".xls"
                IO.File.Copy(Application.StartupPath & "\Reports\LeaveLedger.xls", sNewFileName, True)
                xlWorkBook = xlApp.Workbooks.Open(sNewFileName)
                xlWorkSheet = xlWorkBook.Sheets(1)
                Dim iRow As Integer
                Dim iFillRow As Integer
                Dim MonthRow As Integer = Date.Now.Month
                With xlWorkSheet

                    'Dim myRange, row As Excel.Range
                    Dim sheet = xlWorkBook.ActiveSheet
                    Dim getDate As New Date
                    ROW_INX = 13
                    .Cells(7, "B").Replace("<LASTNAME>", dtLeaveReport.Rows(0)("last_name"))
                    .Cells(7, "B").Replace("<FIRSTNAME>", dtLeaveReport.Rows(0)("first_name"))
                    .Cells(7, "B").Replace("<MIDDLENAME>", dtLeaveReport.Rows(0)("middle_name"))
                    .Cells(7, "F").Replace("<POST>", dtLeaveReport.Rows(0)("job_pos"))
                    .Cells(9, "F").Replace("<Appointment>", dtLeaveReport.Rows(0)("assigned_place"))
                    .Cells(10, "A").Replace("<Birthdate>", dtLeaveReport.Rows(0)("b_date"))
                    .Cells(13, "A").Replace("<YEAR>", Date.Now.Year.ToString())


                    Do While iFillRow < Date.Now.Month

                        .Cells(ROW_INX + iFillRow + 1, "B") = "1.25"
                        .Cells(ROW_INX + iFillRow + 1, "F") = "1.25"
                        iFillRow += 1
                    Loop


                    For Each dr In dtLeaveReport.Rows

                        'Earned Points
                        'check if sl of vl
                        'check the 'created on date for month and year
                        'write the credits on excel

                        getDate = dr("createdon")
                        'SL 'Total Earned - Beggning Balance - from pervious year
                        .Cells(ROW_INX + 1, "B") = dtEarnings.Rows(0)("slbalance").ToString()
                        'VL 'Total Earned - Beggning Balance - from pervious year
                        .Cells(ROW_INX + 1, "F") = dtEarnings.Rows(0)("vlbalance").ToString()

                        If dr("leave_type") = "Sick" Then
                            .Cells(ROW_INX + getDate.Month, "C") = dr("slcredits").ToString()
                        ElseIf dr("leave_type") = "Vacation" Then
                            .Cells(ROW_INX + getDate.Month, "G") = dr("vlcredits").ToString()
                        Else
                            .Cells(ROW_INX + getDate.Month, "C") = ""
                            .Cells(ROW_INX + getDate.Month, "G") = ""
                        End If


                    Next

                    'balance

                    Do While MonthRow < 12
                        iRow += 1
                        .Cells(ROW_INX + MonthRow, "E") = "0.00"
                        .Cells(ROW_INX + MonthRow, "I") = "0.00"
                        MonthRow += 1
                    Loop

                End With
                MessageBox.Show("Report Generated Successfully")
                xlApp.Visible = True

            Else
                MessageBox.Show("NO Record(s) Found", sProjectTitle)
            End If

        Catch ex As Exception

        End Try

    End Sub


End Class
