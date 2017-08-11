Public Class AttendanceDTO
    Private _employeeId As String
    Private _timein As DateTime
    Private _timeout As DateTime
    Private _stimein As String
    Private _stimeout As String
    Private _regularhours As Decimal
    Private _overtime As Decimal
    Private _nd As Decimal
    Private _attendancedate As DateTime
    Private _status As String
    Private _tAttendance As DataTable
    Private Sub New()
        Try
            _tAttendance = GetDataAsTable("SELECT att_id,emp_id,stime_in,stime_out,reg_hr,OT,ND,att_date,status FROM tAttendance")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Public Property Attendance As DataTable
        Get
            Return _tAttendance
        End Get
        Set(ByVal value As DataTable)
            _tAttendance = value
        End Set
    End Property

    Public Property EmployeeId() As String
        Get
            Return _employeeId
        End Get
        Set(ByVal value As String)
            _employeeId = value
        End Set
    End Property
    Public Property TimeIn() As String
        Get
            Return _stimein
        End Get
        Set(ByVal value As String)
            _stimein = value
        End Set
    End Property

    Public Property TimeOut() As String
        Get
            Return _stimeout
        End Get
        Set(ByVal value As String)
            _stimeout = value
        End Set
    End Property
    Public Property RegularHours() As String
        Get
            Return _regularhours
        End Get
        Set(ByVal value As String)
            _regularhours = value
        End Set
    End Property
    Public Property Overtime() As String
        Get
            Return _overtime
        End Get
        Set(ByVal value As String)
            _overtime = value
        End Set
    End Property
    Public Property ND() As String
        Get
            Return _nd
        End Get
        Set(ByVal value As String)
            _nd = value
        End Set
    End Property
    Public Property Status() As String
        Get
            Return _status
        End Get
        Set(ByVal value As String)
            _status = value
        End Set
    End Property
End Class
