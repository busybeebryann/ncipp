Public Class PayrollDTO

    Private _salaryId As String
    Private _employeeId As String
    Private _lastname As String
    Private _firstname As String
    Private _status As String
    Private _position As String
    Private _department As String
    Private _dependents As String

    Private _PERA As Decimal

    Private _basicpay As Decimal
    Private _gross As Decimal
    Private _policyloan As Decimal
    Private _ecard As Decimal
    Private _emergencyloan As Decimal
    Private _consoloan As Decimal
    Private _hmdfloan As Decimal
    Private _hmdfhsloan As Decimal
    Private _ncipealoan As Decimal
    Private _lbploan As Decimal
    Private _educassistance As Decimal
    Private _uoli As Decimal
    Private _gsissocial As Decimal
    Private _ncipmand As Decimal
    Private _ncipmember As Decimal
    Private _phic As Decimal
    Private _hmdf As Decimal
    Private _netpay As Decimal
    Private _wt As Decimal
    Private _salarygrade As String

    Public Property SalaryGrade() As String
        Get
            Return _salarygrade
        End Get
        Set(ByVal value As String)
            _salarygrade = value
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
    Public Property LastName() As String
        Get
            Return _lastname
        End Get
        Set(ByVal value As String)
            _lastname = value
        End Set
    End Property
    Public Property FirstName() As String
        Get
            Return _firstname
        End Get
        Set(ByVal value As String)
            _firstname = value
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
    Public Property Dependents() As String
        Get
            Return _dependents
        End Get
        Set(ByVal value As String)
            _dependents = value
        End Set
    End Property
    Public Property Position() As String
        Get
            Return _position
        End Get
        Set(ByVal value As String)
            _position = value
        End Set
    End Property
    Public Property Department() As String
        Get
            Return _department
        End Get
        Set(ByVal value As String)
            _department = value
        End Set
    End Property
    Public Property SalaryId() As String
        Get
            Return _salaryId
        End Get
        Set(ByVal value As String)
            _salaryId = value
        End Set
    End Property
    Public Property Gross() As Decimal
        Get
            Return _gross
        End Get
        Set(ByVal value As Decimal)
            _gross = value
        End Set
    End Property
    Public Property Basic() As Decimal
        Get
            Return _basicpay
        End Get
        Set(ByVal value As Decimal)
            _basicpay = value
        End Set
    End Property
    Public Property Net() As Decimal
        Get
            Return _netpay
        End Get
        Set(ByVal value As Decimal)
            _netpay = value
        End Set
    End Property
    Public Property PERA() As Decimal
        Get
            Return _PERA
        End Get
        Set(ByVal value As Decimal)
            _PERA = value
        End Set
    End Property
    Public Property PolicyLoan() As Decimal
        Get
            Return _policyloan
        End Get
        Set(ByVal value As Decimal)
            _policyloan = value
        End Set
    End Property
    Public Property ECard() As Decimal
        Get
            Return _ecard
        End Get
        Set(ByVal value As Decimal)
            _ecard = value
        End Set
    End Property
    Public Property EmergencyLoan() As Decimal
        Get
            Return _emergencyloan
        End Get
        Set(ByVal value As Decimal)
            _emergencyloan = value
        End Set
    End Property
    Public Property ConsoLoan() As Decimal
        Get
            Return _consoloan
        End Get
        Set(ByVal value As Decimal)
            _consoloan = value
        End Set
    End Property
    Public Property HMDFHSLoan() As Decimal
        Get
            Return _hmdfhsloan
        End Get
        Set(ByVal value As Decimal)
            _hmdfhsloan = value
        End Set
    End Property
    Public Property HMDFLoan() As Decimal
        Get
            Return _hmdfloan
        End Get
        Set(ByVal value As Decimal)
            _hmdfloan = value
        End Set
    End Property
    Public Property NCIPAELoan() As Decimal
        Get
            Return _ncipealoan
        End Get
        Set(ByVal value As Decimal)
            _ncipealoan = value
        End Set
    End Property
    Public Property LBPLoan() As Decimal
        Get
            Return _lbploan
        End Get
        Set(ByVal value As Decimal)
            _lbploan = value
        End Set
    End Property
    Public Property EducAssistance() As Decimal
        Get
            Return _educassistance
        End Get
        Set(ByVal value As Decimal)
            _educassistance = value
        End Set
    End Property
    Public Property UOLI() As Decimal
        Get
            Return _uoli
        End Get
        Set(ByVal value As Decimal)
            _uoli = value
        End Set
    End Property
    Public Property GSISSOCIAL() As Decimal
        Get
            Return _gsissocial
        End Get
        Set(ByVal value As Decimal)
            _gsissocial = value
        End Set
    End Property
    Public Property NCIPMAND() As Decimal
        Get
            Return _ncipmand
        End Get
        Set(ByVal value As Decimal)
            _ncipmand = value
        End Set
    End Property
    Public Property NCIPMEMBER() As Decimal
        Get
            Return _ncipmember
        End Get
        Set(ByVal value As Decimal)
            _ncipmember = value
        End Set
    End Property
    Public Property PHIC() As Decimal
        Get
            Return _phic
        End Get
        Set(ByVal value As Decimal)
            _phic = value
        End Set
    End Property
    Public Property HDMF() As Decimal
        Get
            Return _hmdf
        End Get
        Set(ByVal value As Decimal)
            _hmdf = value
        End Set
    End Property
    Public Property WT() As Decimal
        Get
            Return _wt
        End Get
        Set(ByVal value As Decimal)
            _wt = value
        End Set
    End Property
End Class
