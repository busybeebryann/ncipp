
Imports WindowsApplication1.Extensions
Public Class Payroll


    Private _sPeriod As String
    Public Property Period As String
        Get
            Return _sPeriod
        End Get
        Private Set(ByVal value As String)
            _sPeriod = value
        End Set
    End Property

#Region "PAYROLL COMPUTATION"
    Dim dtoBasic, dtoPERA,
    dtoPolicyLoan, dtoGrossPay, dtoECard, dtoEmerngyLoan, dtolECard, dtoConsoLaon,
    dtoPAGIBIGLoan, dtoPAGIBIGHouse, dtoNCIPAELoan, dtoLBPLoan, dtoEducAssistance, dtoOULI, dtoGSISSocial, dtoNCIPMandatory,
    dtoNCIPMembership, dtoPHIC, dtoHDMF, dtoWT As Decimal
    Dim DTGLedger As Object
    Dim curPolicyLoan, curEmerngyLoan, curConsoLaon, curPAGIBIGLoan, curPAGIBIGHouse, curNCIPAELoan, curLBPLoan, curEducAssistance As Object
    Public Function GetWitholdingTax(ByVal curSalary As Decimal, Optional ByRef rEmpId As String = "")

        Try
            Dim curMaxCompensation As Decimal
            Dim curMinCompensation As Decimal
            Dim curSSS, curGSIS, curPHIC, curHDMF As Decimal
            Dim curWTax As Decimal
            Dim dependents As String
            Dim strSQL, sSQL As String
            Dim dtMonthlyTax, dtSearchedEmployee As DataTable

            If Not String.IsNullOrEmpty(rEmpId) Then
                sSQL = String.Format("select emp_id,marital_status,dependents from tbl_user WHERE emp_id ='{0}'", rEmpId)
                dependents = GetFieldValue(sSQL, "dependents")
            Else
                dependents = "0"
            End If

            curMaxCompensation = GetFieldValue("SELECT Max(compensation1) AS MaxCompensation " _
                           & "FROM tMontWTax WHERE dependent = " & dependents, "MaxCompensation")

            curMinCompensation = GetFieldValue("SELECT Min(compensation1) AS MinCompensation " _
                        & "FROM tMontWTax WHERE dependent = " & dependents, "MinCompensation")

            If curSalary <= curMinCompensation Then
                GetWitholdingTax = 0
            ElseIf curSalary > curMaxCompensation Then
                strSQL = "SELECT compensation1, exemption, overam " _
                    & "FROM tMontWTax WHERE Dependent = " & dependents & " ORDER BY wTax_Id Desc"

                dtMonthlyTax = GetDataAsTable(strSQL)

                If (dtMonthlyTax.Rows.Count > 0) Then

                    curMaxCompensation = dtMonthlyTax.Rows(0)("compensation1")
                    Dim curExcessAmount As Decimal

                    curExcessAmount = curSalary - curMaxCompensation
                    curWTax = dtMonthlyTax.Rows(0)("exemption") + (curExcessAmount * dtMonthlyTax.Rows(0)("overam"))
                    GetWitholdingTax = curWTax

                End If
            Else
                strSQL = "SELECT compensation1, exemption, overam " _
                  & "FROM tMontWTax WHERE compensation1 <= " & curSalary & " AND compensation2 >= " & curSalary & " AND dependent = " & dependents

                dtMonthlyTax = GetDataAsTable(strSQL)

                If (dtMonthlyTax.Rows.Count > 0) Then

                    Dim curCompensation1 As Decimal = dtMonthlyTax.Rows(0)("compensation1")

                    Dim curExcessAmount As Decimal

                    curExcessAmount = curSalary - curCompensation1
                    curWTax = dtMonthlyTax.Rows(0)("exemption") + (curExcessAmount * dtMonthlyTax.Rows(0)("overam"))
                    GetWitholdingTax = curWTax

                End If


            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "General Error")
        End Try

    End Function

    Public Overridable Function GetNet(ByRef objData As DataTable, Optional ByRef objRow As Integer = 0) As Decimal

        Dim strSQL As String
        Dim refEmpid As String
        With objData
            refEmpid = .Rows(objRow)("EmployeeID")
            dtoBasic = .Rows(objRow)("basicPay")
            'Loans
            If LoanHelper.IsZeroBalance("gsis_pl_balance", refEmpid) Then
                dtoPolicyLoan = 0.0
            Else
                dtoPolicyLoan = .Rows(0)("gsis_pl_monAm")
            End If

            If LoanHelper.IsZeroBalance("gsis_el_balance", refEmpid) Then
                dtoEmerngyLoan = 0.0
            Else
                dtoEmerngyLoan = .Rows(0)("gsis_el_monAm")
            End If

            If LoanHelper.IsZeroBalance("gsis_cl_balance", refEmpid) Then
                dtoConsoLaon = 0.0
            Else
                dtoConsoLaon = .Rows(0)("gsis_cl_monAm")
            End If

            If LoanHelper.IsZeroBalance("gsis_edu_balance", refEmpid) Then
                dtoEducAssistance = 0.0
            Else
                dtoEducAssistance = .Rows(0)("gsis_edu_monAm")
            End If

            If LoanHelper.IsZeroBalance("hdmf_mp_balance", refEmpid) Then
                dtoPAGIBIGLoan = 0.0
            Else
                dtoPAGIBIGLoan = .Rows(0)("hdmf_mp_monAm")
            End If

            If LoanHelper.IsZeroBalance("hdmf_hs_balance", refEmpid) Then
                dtoPAGIBIGHouse = 0.0
            Else
                dtoPAGIBIGHouse = .Rows(0)("hdmf_hs_monAm")
            End If

            If LoanHelper.IsZeroBalance("ncipea_balance", refEmpid) Then
                dtoNCIPAELoan = 0.0
            Else
                dtoNCIPAELoan = .Rows(0)("ncipea_monAm")
            End If

            If LoanHelper.IsZeroBalance("lbp_balance", refEmpid) Then
                dtoLBPLoan = 0.0
            Else
                dtoLBPLoan = .Rows(0)("lbp_monAm")
            End If

            'Contributions
            dtoOULI = .Rows(objRow)("gsis_ouli")
            dtoGSISSocial = .Rows(objRow)("gsis_ec")
            dtoNCIPMandatory = .Rows(objRow)("ncipea_mandatory")
            dtoNCIPMembership = .Rows(objRow)("ncipea_amount")
            dtoPHIC = .Rows(objRow)("phic_ee")
            dtoHDMF = .Rows(objRow)("hdmf_ee")
            dtoWT = .Rows(objRow)("wt_amount")
        End With

        dtoPERA = 2000.0
        dtoGrossPay = dtoBasic + dtoPERA

        Dim loans As Decimal = getAllLoans(dtoPolicyLoan, dtoEmerngyLoan, dtoConsoLaon, dtoPAGIBIGLoan, dtoPAGIBIGHouse, _
                                           dtoNCIPAELoan, dtoLBPLoan, dtoEducAssistance)
        Dim Contributions As Decimal = getAllContributions(dtoOULI, dtoGSISSocial, dtoNCIPMandatory, dtoNCIPMembership, dtoPHIC, dtoHDMF)

        'witholding tax part

        Return dtoGrossPay - (loans + Contributions + dtoWT)

    End Function
    Private Function getAllLoans(ByVal a As Decimal, ByVal b As Decimal, ByVal c As Decimal, ByVal d As Decimal, ByVal e As Decimal, ByVal f As Decimal, ByVal g As Decimal, ByVal h As Decimal) As Decimal
        Return a + b + c + d + e + f + g + h
    End Function
    Private Function getAllContributions(ByVal a As Decimal, ByVal b As Decimal, ByVal c As Decimal, ByVal d As Decimal, ByVal e As Decimal, ByVal f As Decimal) As Decimal
        Return a + b + c + d + e + f
    End Function

    Public Sub UpdateLoanPayments(ByVal objData As DataTable, Optional ByRef objRow As Integer = 0)

        Dim strSQuery As String
        Dim sReturend As String = ""
        Dim paidPolicy, paidEmerngy, paidConso, paidEducAssistance, paidPAGIBIGHouse, paidPAGIBIGM, paidLBP, paidNCIPAE As Decimal
        Dim curEmployeeLoanRecord As DataTable
        curEmployeeLoanRecord = GetDataAsTable(String.Format("Select * from tLoan Where EmployeeID = '{0}'", objData.Rows(objRow)("EmployeeID").ToString))
        If (curEmployeeLoanRecord.Rows.Count > 0) Then
            'current paymernts 
            With curEmployeeLoanRecord
                curPolicyLoan = .Rows(0)("gsis_pl_totalpay")
                curEmerngyLoan = .Rows(0)("gsis_el_totalpay")
                curConsoLaon = .Rows(0)("gsis_cl_totalpay")
                curPAGIBIGLoan = .Rows(0)("hdmf_mp_totalpay")
                curPAGIBIGHouse = .Rows(0)("hdmf_hs_totalpay")
                curNCIPAELoan = .Rows(0)("ncipea_totalpay")
                curLBPLoan = .Rows(0)("lbp_totalpay")
                curEducAssistance = .Rows(0)("gsis_edu_totalpay")
            End With

        End If

        With objData

            curPolicyLoan += dtoPolicyLoan
            curEmerngyLoan += dtoEmerngyLoan
            curConsoLaon += dtoConsoLaon
            curEducAssistance += dtoEducAssistance
            curPAGIBIGHouse += dtoPAGIBIGHouse
            curPAGIBIGLoan += dtoPAGIBIGLoan
            curLBPLoan += dtoLBPLoan
            curNCIPAELoan += dtoNCIPAELoan

            If Not curPolicyLoan = 0.0 And Not dtoPolicyLoan = 0 Then
                paidPolicy = curPolicyLoan / dtoPolicyLoan
            End If
            If Not curEmerngyLoan = 0.0 And Not dtoEmerngyLoan = 0 Then
                paidEmerngy = curEmerngyLoan / dtoEmerngyLoan
            End If
            If Not curConsoLaon = 0.0 And Not dtoConsoLaon = 0 Then
                paidConso = curConsoLaon / dtoConsoLaon
            End If
            If Not curEducAssistance = 0.0 And Not dtoEducAssistance = 0 Then
                paidEducAssistance = curEducAssistance / dtoEducAssistance
            End If
            If Not curPAGIBIGLoan = 0.0 And Not dtoEducAssistance = 0 Then
                paidPAGIBIGM = curPAGIBIGLoan / dtoPAGIBIGLoan
            End If
            If Not curPAGIBIGHouse = 0.0 And Not dtoPAGIBIGHouse = 0 Then
                paidPAGIBIGHouse = curPAGIBIGHouse / dtoPAGIBIGHouse
            End If
            If Not curLBPLoan = 0.0 And Not dtoLBPLoan = 0 Then
                paidLBP = curLBPLoan / dtoLBPLoan
            End If
            If Not curNCIPAELoan = 0.0 And Not dtoNCIPAELoan = 0 Then
                paidNCIPAE = curNCIPAELoan / dtoNCIPAELoan
            End If

            strSQuery = "UPDATE tLoan SET " + _
            "gsis_cl_totalpay = " + curConsoLaon.ToString + _
            ",gsis_el_totalpay = " + curEmerngyLoan.ToString + _
            ",gsis_pl_totalpay = " + curPolicyLoan.ToString + _
            ",gsis_edu_totalpay = " + curEducAssistance.ToString + _
            ",hdmf_hs_totalpay = " + curPAGIBIGHouse.ToString + _
            ",hdmf_mp_totalpay = " + curPAGIBIGLoan.ToString + _
            ",lbp_totalpay = " + curLBPLoan.ToString + _
            ",ncipea_totalpay = " + curNCIPAELoan.ToString + _
            ",gsis_cl_paidAm = " + paidConso.ToString + _
            ",gsis_el_paidAm = " + paidEmerngy.ToString + _
             ",gsis_pl_paidAm = " + paidPolicy.ToString + _
              ",gsis_edu_paidAm = " + paidEducAssistance.ToString + _
               ",hdmf_hs_paidAm = " + paidPAGIBIGHouse.ToString + _
                ",hdmf_mp_paidAm = " + paidPAGIBIGM.ToString + _
                ",lbp_paidAm = " + paidLBP.ToString + _
                 ",ncipea_paidAm = " + paidNCIPAE.ToString + _
            ",modifiedon = getdate() " + _
            "WHERE EmployeeID = '" + .Rows(objRow)("EmployeeID").ToString + "'"
        End With

        sReturend = ExecuteDML(strSQuery)

        If (sReturend.StartsWith("Error")) Then
            MessageBox.Show(sReturend)
            Exit Sub
        End If

    End Sub

    Public Sub UpdateLoanBalance(ByVal objData As DataTable, Optional ByRef objRow As Integer = 0)

        Dim strSQuery As String
        Dim sReturend As String = ""

        Dim dPolicyLoan, dEmerngyLoan, dConsoLaon, dPAGIBIGLoan, dPAGIBIGHouse, dNCIPAELoan, dLBPLoan, dEducAssistance, _
            balPolicyLoan, balEmerngyLoan, balConsoLaon, balPAGIBIGLoan, balPAGIBIGHouse, balNCIPAELoan, balLBPLoan, balEducAssistance, _
            payPolicyLoan, payEmerngyLoan, payConsoLaon, payPAGIBIGLoan, payPAGIBIGHouse, payNCIPAELoan, payLBPLoan, payEducAssistance As Decimal

        Dim curEmployeeLoanRecord As DataTable
        curEmployeeLoanRecord = GetDataAsTable(String.Format("Select * from tLoan Where EmployeeID = '{0}'", objData.Rows(objRow)("EmployeeID").ToString))
        If (curEmployeeLoanRecord.Rows.Count > 0) Then
            'current paymernts 
            With curEmployeeLoanRecord
                dPolicyLoan = .Rows(0)("gsis_ploan")
                dEmerngyLoan = .Rows(0)("gsis_eloan")
                dConsoLaon = .Rows(0)("gsis_cloan")
                dPAGIBIGLoan = .Rows(0)("hdmf_mploan")
                dPAGIBIGHouse = .Rows(0)("hdmf_hsloan")
                dNCIPAELoan = .Rows(0)("ncipea_loan")
                dLBPLoan = .Rows(0)("lbp_gloan")
                dEducAssistance = .Rows(0)("gsis_eduloan")

                payPolicyLoan = .Rows(0)("gsis_pl_totalpay")
                payEmerngyLoan = .Rows(0)("gsis_el_totalpay")
                payConsoLaon = .Rows(0)("gsis_cl_totalpay")
                payPAGIBIGLoan = .Rows(0)("hdmf_mp_totalpay")
                payPAGIBIGHouse = .Rows(0)("hdmf_hs_totalpay")
                payNCIPAELoan = .Rows(0)("ncipea_totalpay")
                payLBPLoan = .Rows(0)("lbp_totalpay")
                payEducAssistance = .Rows(0)("gsis_edu_totalpay")
            End With

        End If
        'balance = total loans - payments
        With objData

            balPolicyLoan = dPolicyLoan - payPolicyLoan
            balEmerngyLoan = dEmerngyLoan - payEmerngyLoan
            balConsoLaon = dtoConsoLaon - payConsoLaon
            balEducAssistance = dEducAssistance - payEducAssistance
            balPAGIBIGHouse = dPAGIBIGHouse - payPAGIBIGHouse
            balPAGIBIGLoan = dPAGIBIGLoan - payPAGIBIGLoan
            balLBPLoan = dLBPLoan - payLBPLoan
            balNCIPAELoan = dNCIPAELoan - payNCIPAELoan

            strSQuery = "UPDATE tLoan SET " + _
            "gsis_cl_balance = " + balConsoLaon.ToString + _
            ",gsis_el_balance = " + balEmerngyLoan.ToString + _
            ",gsis_pl_balance = " + balPolicyLoan.ToString + _
            ",gsis_edu_balance = " + balEducAssistance.ToString + _
            ",hdmf_hs_balance = " + balPAGIBIGHouse.ToString + _
            ",hdmf_mp_balance = " + balPAGIBIGLoan.ToString + _
            ",lbp_balance = " + balLBPLoan.ToString + _
            ",ncipea_balance = " + balNCIPAELoan.ToString + _
            ",modifiedon = getdate() " + _
            "WHERE EmployeeID = '" + .Rows(objRow)("EmployeeID").ToString + "'"
        End With

        sReturend = ExecuteDML(strSQuery)

        If (sReturend.StartsWith("Error")) Then
            MessageBox.Show(sReturend + "on updating balance")
            Exit Sub
        End If

        'update monthly ammortization if balance already zero.
        Dim stringToExcute As String = ""
        With curEmployeeLoanRecord

            Dim strId As String = objData.Rows(objRow)("EmployeeID").ToString


            stringToExcute = "UPDATE tLoan SET " + _
            "gsis_pl_monAm = " + IIf(LoanHelper.IsZeroBalance("gsis_pl_balance", strId), "0.00", .Rows(0)("gsis_pl_monAm")) + _
            ",gsis_el_monAm = " + IIf(LoanHelper.IsZeroBalance("gsis_el_balance", strId), "0.00", .Rows(0)("gsis_el_monAm")) + _
            ",gsis_cl_monAm = " + IIf(LoanHelper.IsZeroBalance("gsis_cl_balance", strId), "0.00", .Rows(0)("gsis_cl_monAm")) + _
            ",gsis_edu_monAm = " + IIf(LoanHelper.IsZeroBalance("gsis_edu_balance", strId), "0.00", .Rows(0)("gsis_edu_monAm")) + _
            ",hdmf_hs_monAm = " + IIf(LoanHelper.IsZeroBalance("hdmf_hs_balance", strId), "0.00", .Rows(0)("hdmf_hs_monAm")) + _
            ",hdmf_mp_monAm = " + IIf(LoanHelper.IsZeroBalance("hdmf_mp_balance", strId), "0.00", .Rows(0)("hdmf_mp_monAm")) + _
            ",lbp_monAm = " + IIf(LoanHelper.IsZeroBalance("lbp_balance", strId), "0.00", .Rows(0)("lbp_monAm")) + _
            ",ncipea_monAm = " + IIf(LoanHelper.IsZeroBalance("ncipea_balance", strId), "0.00", .Rows(0)("ncipea_monAm")) + _
            ",modifiedon = getdate() " + _
             "WHERE EmployeeID = '" + strId + "'"

        End With

        sReturend = ExecuteDML(stringToExcute)
        If (sReturend.StartsWith("Error")) Then
            MessageBox.Show(sReturend + "on updating mopnthly amortization")
            Exit Sub
        End If

    End Sub

#End Region
End Class

