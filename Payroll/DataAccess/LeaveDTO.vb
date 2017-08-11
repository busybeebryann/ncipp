Public Class LeaveDTO
    Private _leaves As DataTable
    Private _empid As String
    Private _leavetype As String
    Private _noofdays As String
    Private _noofdayspaid As String
    Private _startdate As DateTime
    Private _enddate As DateTime
    Private _sickleave As Decimal
    Private _vacation As Decimal
    Private _slearned As Decimal
    Private _vlearened As Decimal
    Private _remarks As String
    Private Sub New()
        Try
            'all list
            _leaves = GetDataAsTable("SELECT l_id,emp_id,leave_type,no_days,no_paid,start_date,end_date,sl_credits,vl_credits,sl_earned,vl_earned,remarks FROM tLeave")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Public Property LeaveTable As DataTable
        Get
            Return _leaves
        End Get
        Set(value As DataTable)
            _leaves = value
        End Set
    End Property
    Public Property EmployeeId() As String
        Get
            Return _empid
        End Get
        Set(ByVal value As String)
            _empid = value
        End Set
    End Property
    Public Property LeaveType() As Decimal
        Get
            Return _leavetype
        End Get
        Set(ByVal value As Decimal)
            _leavetype = value
        End Set
    End Property
    Public Property NoOfDays() As String
        Get
            Return _noofdays
        End Get
        Set(ByVal value As String)
            _noofdays = value
        End Set
    End Property
    Public Property NoOfPaid() As String
        Get
            Return _noofdayspaid
        End Get
        Set(ByVal value As String)
            _noofdayspaid = value
        End Set
    End Property
    Public Property StartDate() As DateTime
        Get
            Return _startdate
        End Get
        Set(value As DateTime)
            _startdate = value
        End Set
    End Property
    Public Property EndDate() As DateTime
        Get
            Return _enddate
        End Get
        Set(value As DateTime)
            _enddate = value
        End Set
    End Property
    Public Property SickLeave() As Decimal
        Get
            Return _sickleave
        End Get
        Set(value As Decimal)
            _sickleave = value
        End Set
    End Property
    Public Property VacationLeave() As Decimal
        Get
            Return _vacation
        End Get
        Set(value As Decimal)
            _vacation = value
        End Set
    End Property
    Public Property Remarks() As String
        Get
            Return _remarks
        End Get
        Set(ByVal value As String)
            _remarks = value
        End Set
    End Property
End Class
