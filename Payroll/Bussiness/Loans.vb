Imports WindowsApplication1.Extensions
Imports WindowsApplication1.Enums
Public Class Loans

    Public Sub New()

    End Sub
    Private _employeeId As String
    Public Property EmployeeID() As String
        Get
            Return _employeeId
        End Get
        Private Set(ByVal value As String)
            _employeeId = value
        End Set
    End Property
    Private _tLoan As DataTable
    Public Property LoansTable() As DataTable
        Get
            Return _tLoan
        End Get
        Private Set(ByVal value As DataTable)
            _tLoan = value

        End Set
    End Property

    Private _dt As DataTable
    Public Property ScheduleTable() As DataTable
        Get
            Return _dt
        End Get
        Private Set(ByVal value As DataTable)
            _dt = value
        End Set
    End Property

    Private _duration As Decimal
    Public Property Duration As Decimal
        Get
            Return _duration

        End Get
        Set(ByVal value As Decimal)
            _duration = value
        End Set
    End Property

    Private _principal As Decimal
    Public Property Principal As Decimal
        Get
            Return _principal

        End Get
        Set(ByVal value As Decimal)
            _principal = value
        End Set
    End Property
    Private _balance As Decimal
    Public Property Balance As Decimal
        Get
            Return _balance

        End Get
        Set(ByVal value As Decimal)
            _balance = value
        End Set
    End Property
    Private _monthly As Decimal
    Public Property MonthlyAmount As Decimal
        Get
            Return _monthly

        End Get
        Set(ByVal value As Decimal)
            _monthly = value
        End Set
    End Property
    Private _start As Date

    Public Sub SetAmortizationSched(ByVal sPrincipal As Decimal)
        If _duration = 0 And sPrincipal = 0 Then Exit Sub

        _principal = sPrincipal
        Dim interest As Double
        Dim principalLoan As Double
        Dim matValue As Double
        Dim MonthlyInterest As Double
        Dim Monthlyprincipal As Double
        Dim MonthlyRem As Double
        Dim matvalueWithRebate As Double


        'Dim dtoprincipal As String = "10000"
        Dim dtointerest As String
        Dim dtoRebates As String
        Dim dtoAmountInterest As String
        Dim dtoMatValue As String
        Dim dtoMatValueRebates As String
        Dim dtoOutsCapital As String
        Dim dtoUnEarnedInterest As String
        Dim dtoBalance As String
        Dim dtoBalanceRebates As String
        Dim dtoMonthlyRem As String = ""
        'Dim dtoDuration As String = "3"   _
        Dim dtoEffectiveDate As Date = DateValue(_start.ToString("MM/dd/yyyy"))
        Dim dtoMatDate As Date

        Dim effDate As Date
        Dim dueDate As Date
        Dim MatDate As Date
        Dim endDate As Date

        Dim dtoenddate As Date
        Dim rebates As Double

        principalLoan = _principal
        'Interest
        interest = principalLoan * (Val(dtointerest) / 100)
        rebates = principalLoan * (Val(dtointerest) / 100)

        dtoRebates = Format(rebates, "#,##0.00")
        dtoAmountInterest = Format(interest, "#,##0.00")
        'Maturity Value
        matValue = principalLoan + interest
        matvalueWithRebate = principalLoan + interest + rebates
        dtoMatValue = Format(matValue, "#,##0.00")
        dtoMatValueRebates = Format(matvalueWithRebate, "#,##0.00")
        'Maturity Date
        effDate = dtoEffectiveDate
        'MatDate = effDate.AddMonths(Val(_duration.Replace(",", "")))
        MatDate = effDate.AddMonths(Val(_duration))
        dtoMatDate = MatDate


        MonthlyInterest = (principalLoan * Val(dtointerest) / 100)
        '  MonthlyInterest = MonthlyInterest
        MonthlyInterest = Format(MonthlyInterest / Val(_duration), "#,##0.00")
        Monthlyprincipal = (principalLoan / Val(_duration))

        'Monthly Remittance
        MonthlyRem = matvalueWithRebate / Val(_duration)
        dtoMonthlyRem = Format(MonthlyRem, "#,##0.00")

        ' Outstanding Capital, Unearned Interest, Balance
        dtoOutsCapital = Format(principalLoan, "#,##0.00")
        dtoUnEarnedInterest = dtoAmountInterest
        dtoBalance = dtoMatValue
        dtoBalanceRebates = dtoMatValueRebates

        'Get the Ledger Value
        Dim i As Integer
        Dim weekInt As Integer
        Dim rule, newrule As Integer
        Dim uii, rff As Double
        Dim reverseduration As Integer
        Dim durations As Integer = Val(_duration)

        Dim totalexpectedbalance As Double = matvalueWithRebate
        Dim expectedBalance_uii As Double = interest
        Dim expectedBalance_rff As Double = rebates
        'dgw.Rows.Clear()
        ' DTGLedger.Rows.Clear()

        'Creaete datable instead of data grid
        Dim DTGLedger As New DataTable

        With DTGLedger
            .Columns.Add("No.")
            .Columns.Add("Due Date")
            .Columns.Add("Amortization")
            .Columns.Add("Principal")
            .Columns.Add("Interest")
            .Columns.Add("Balance")
            .Columns.Add("Rebates")
            .Columns.Add("Expected Balance")
        End With

        'expectedBalance = Format((expectedBalance), "#,##0.00")
        reverseduration = durations
        Dim a, b As Integer
        Do While a < durations
            a += 1
            b = b + a
        Loop
        rule = b

        Do While i < durations
            i += 1

            uii = interest * (reverseduration / rule)
            rff = rebates * (reverseduration / rule)
            weekInt += 1
            dueDate = effDate.AddMonths(weekInt)

            expectedBalance_uii = expectedBalance_uii - uii
            totalexpectedbalance = totalexpectedbalance - MonthlyRem

            DTGLedger.Rows.Add(i, dueDate.ToString("MM/dd/yyyy"), dtoMonthlyRem, Format((principalLoan / durations), "#,##0.00"), Format(uii, "#,##0.00"), Format(expectedBalance_uii, "#,##0.00"), Format(rff, "#,##0.00"), Format(totalexpectedbalance, "#,##0.00"))

            reverseduration -= 1

            endDate = dueDate.ToString("MM/dd/yyyy")
        Loop
        _monthly = dtoMonthlyRem
        dtoenddate = endDate.ToString("MM/dd/yyyy")
        _dt = DTGLedger
    End Sub

    Public Function UpdateBalance()

        Return True
    End Function
    Public Sub SetTotalAmount(ByVal decAmount As Decimal)
        _principal = decAmount
    End Sub
    Public Sub SetLoanTable()
        _tLoan = GetDataAsTable(String.Format("SELECT * FROM tLoan WHERE EmployeeID ='{0}'", _employeeId))
    End Sub
    Public Sub SetEmployeeID(ByRef strId As String)
        _employeeId = strId
    End Sub

    Public Sub SetDurations(ByVal dtStart As Date, ByVal dtEnd As Date)
        _start = dtStart
        _duration = DateHelper.NumberOfMonthsByDate(dtStart, dtEnd)
    End Sub
    Public Function GetEndDate(ByVal dtStart) As Date
        Return DateHelper.DefaultEndDate(dtStart)
    End Function
    Public Sub SetLoanBalance(Optional Catalog As GSIS = 0, Optional Catalog1 As HDMF = 0, Optional Catalog2 As LBP = 0, Optional Catalog3 As NCIPEA = 0)
        Dim strSQuery = "SELECT * FROM tLoan"

        Select Case Catalog
            Case GSIS.Policy
                _balance = GetFieldValue(strSQuery, "gsis_pl_balance")
            Case GSIS.Educational
                _balance = GetFieldValue(strSQuery, "gsis_el_balance")
            Case GSIS.Conso
                _balance = GetFieldValue(strSQuery, "gsis_cl_balance")
            Case GSIS.Emergency
                _balance = GetFieldValue(strSQuery, "gsis_edu_balance")
            Case Else

        End Select

        Select Case Catalog1
            Case HDMF.Housing
                _balance = GetFieldValue(strSQuery, "hdmf_hs_balance")
            Case HDMF.Mandatory
                _balance = GetFieldValue(strSQuery, "hdmf_mp_balance")
            Case Else

        End Select

        Select Case Catalog2
            Case LBP.Mandatory
                _balance = GetFieldValue(strSQuery, "lbp_balance")
            Case Else

        End Select

        Select Case Catalog3
            Case NCIPEA.Mandatory
                _balance = GetFieldValue(strSQuery, "ncipea_balance")
            Case Else

        End Select

    End Sub
    Public Sub SetLoanBalanceHDMF(Catalog As HDMF)
        Dim strSQuery = "SELECT * FROM tLoan"

        Select Case Catalog
            Case HDMF.Mandatory
                _balance = GetFieldValue(strSQuery, "gsis_pl_balance")
            Case HDMF.Housing
                _balance = GetFieldValue(strSQuery, "gsis_el_balance")
            Case Else
                _balance = 0.0
        End Select

    End Sub
    Public Sub SetLoanBalanceLBP(Catalog As GSIS)
        Dim strSQuery = "SELECT * FROM tLoan"

        Select Case Catalog
            Case GSIS.Policy
                _balance = GetFieldValue(strSQuery, "gsis_pl_balance")
            Case GSIS.Educational
                _balance = GetFieldValue(strSQuery, "gsis_el_balance")
            Case GSIS.Conso
                _balance = GetFieldValue(strSQuery, "gsis_cl_balance")
            Case GSIS.Emergency
                _balance = GetFieldValue(strSQuery, "gsis_edu_balance")
            Case Else
                _balance = 0.0
        End Select

    End Sub


End Class
