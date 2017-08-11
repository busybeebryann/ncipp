Imports System.Data.SqlClient
Imports System.Data
Imports System.Text.RegularExpressions
Imports WindowsApplication1.Extensions
Public Class Payroll_computation
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
    Dim dtDeductions As DataTable
    Private Sub Payroll_computation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPayrollPeriod()
        LoadEmployee()
    End Sub
    Private Sub LoadPayrollPeriod()
     
        'MessageBox.Show(firstDayOfMonth.ToString("MMM") + " " + firstDayOfMonth.Day.ToString() + "-" + LastDayOfMonth.Day.ToString() + " " + Year(firstDayOfMonth).ToString)
        Dim iMonth As Integer
        For iMonth = 1 To 12
            firstDayOfMonth = Convert.ToDateTime(DateTime.Now.Year.ToString() + "-" + iMonth.ToString() + "-" + "1")
            LastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1)
            sPeriod = firstDayOfMonth.ToString("MMM") + " " + firstDayOfMonth.Day.ToString() + "-" + LastDayOfMonth.Day.ToString() + " " + DateTime.Now.Year.ToString()
            cbPeriod.Items.Add(sPeriod)
        Next

        cbPeriod.SelectedIndex = -1
    End Sub
    Private Sub LoadEmployee()
        dgvEmployees.DataSource = GetDataAsTable("select user_id,emp_id,first_name,last_name from tbl_user where status='Active'")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        LoadPayrollPeriod()
    End Sub

    Private Sub dgvEmployees_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmployees.CellClick

        Me.ClearComputaionForm()

        If e.RowIndex >= 0 Then

            bCompute.Enabled = True
            sUserID = dgvEmployees.Rows(e.RowIndex).Cells("EmpID").Value.ToString()
        Else
            bCompute.Enabled = False
            Exit Sub
        End If
        Try

            Dim dtEmployee As DataTable
            dtEmployee = GetDataAsTable("select U.user_id,U.emp_id,U.first_name,U.last_name,U.c_no,U.deptid,P.PositionName,P.DeptName,U.positionid,U.dependents," + _
                                    "U.basic_pay from tbl_user U,tPosition P where U.positionid=P.id and U.emp_id= '" + sUserID + "'")

            If dtEmployee.Rows.Count > 0 Then
                oEmployeeID = dtEmployee.Rows(0)("emp_id").ToString()
                lName.Text = String.Format("{1},{0}", dtEmployee.Rows(0)("last_name").ToString(), dtEmployee.Rows(0)("first_name").ToString())
                lEmpID.Text = dtEmployee.Rows(0)("emp_id").ToString()
                lCivil.Text = dtEmployee.Rows(0)("c_no").ToString()
                lDependents.Text = dtEmployee.Rows(0)("dependents").ToString()
                lDept.Text = dtEmployee.Rows(0)("DeptName").ToString()
                lPosition.Text = dtEmployee.Rows(0)("PositionName").ToString()
                lRate.Text = dtEmployee.Rows(0)("basic_pay").ToString()
            End If

         

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub bClose_Click(sender As Object, e As EventArgs) Handles bClose.Click
        Me.Close()
    End Sub


    Private Sub bSave_Click(sender As Object, e As EventArgs) Handles bSave.Click

        ''VALIDATE FORM
        If ValidateForm() Then

            Dim sDMQry, sMessage As String
            Dim sReturend As String = ""
            'use tbl_payroll, add month_computed, date_computed , time_computed

            datenow = Date.Now()
            mnow = datenow.ToString("MMMM")

            strsql = String.Format("select province from tbl_user where emp_id ='{0}'", oEmployeeID)
            Dim strProvince As String = GetAStringValue(strsql)
            sPeriod = cbPeriod.Text

            Try
                'Insert
                sDMQry = "insert into tPayroll values('" + lEmpID.Text + "','" + lName.Text + _
                                   "','" + lPosition.Text + "','" + lDept.Text + _
                                   "','" + sPeriod + "','" + lCivil.Text + "','" + lDependents.Text + _
                                   "','rate_day','rate_houre',0.00,0.00,0.00," + lBasic.Text + _
                                    "," + lPERA.Text + "," + lGrossPay.Text + "," + lPolicyLoan.Text + _
                                    "," + lECard.Text + "," + lEmergencyLoan.Text + _
                                    "," + lConsoLaon.Text + "," + lPAGIBIGLoan.Text + "," + lPAGIBIGHouse.Text + _
                                    "," + lNCIPAELoan.Text + "," + lLBPLoan.Text + "," + lEducAssistance.Text + _
                                    "," + lUOLI.Text + "," + lGSISSocial.Text + "," + lNCIPMandatory.Text + _
                                    "," + lNCIPMembership.Text + "," + lPHIC.Text + "," + lHDMF.Text + _
                                    "," + lWT.Text + "," + lNetPay.Text + ",'additional_deduction',0.00" + _
                                    ",'" + datenow.ToString + "','" + mnow + "','" + TimeOfDay + _
                                    "','tDed','" + strProvince + "',getdate(),getdate())"
                sMessage = "Computation Added Successfully"
                'Update

                sReturend = ExecuteDML(sDMQry)
                If sReturend <> "True" Then
                    MessageBox.Show(sReturend)
                    Exit Sub
                Else
                    MessageBox.Show(sMessage, sProjectTitle)

                End If


            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                If sReturend = "True" Then
                    updateTableLoans()
                End If

            End Try
        Else
            Exit Sub
        End If

    End Sub

    Private Function ValidateForm() As Boolean
        Dim bReturn As Boolean = True
        'Add Form  Validation Here

        Return bReturn
    End Function
    Private Sub updateTableLoans()
        objBiz.UpdateLoanPayments(dtDeductions)
        objBiz.UpdateLoanBalance(dtDeductions)
    End Sub
    Private Sub ClearComputaionForm()
        lBasic.Text = "0.00"
        lPERA.Text = "0.00"
        lGrossPay.Text = "0.00"
        lPolicyLoan.Text = "0.00"
        lECard.Text = "0.00"
        lEmergencyLoan.Text = "0.00"
        lConsoLaon.Text = "0.00"
        lPAGIBIGLoan.Text = "0.00"
        lPAGIBIGHouse.Text = "0.00"
        lNCIPAELoan.Text = "0.00"
        lLBPLoan.Text = "0.00"
        lEducAssistance.Text = "0.00"
        lUOLI.Text = "0.00"
        lGSISSocial.Text = "0.00"
        lNCIPMandatory.Text = "0.00"
        lNCIPMembership.Text = "0.00"
        lPHIC.Text = "0.00"
        lHDMF.Text = "0.00"
        lWT.Text = "0.00"
    End Sub

    Private Sub bCompute_Click(sender As Object, e As EventArgs) Handles bCompute.Click
        'check balances
        ' Dim policyLoan, emergency, conso, pLoan, pHouse, ncipeaLoan, lbp, educAssistance As Decimal
        dtDeductions = GetDataAsTable("SELECT EmployeeID,basicPay,gsis_ouli, gsis_ec, gsis_ee, gsis_er,gsis_cl_monAm,gsis_cloan, gsis_el_monAm, gsis_eloan,gsis_edu_monAm " + _
                                      ",gsis_pl_monAm,gsis_ploan,gsis_eduloan,hdmf_hs_monAm,hdmf_mp_monAm" + _
                                      ",hdmf_hsloan,hdmf_mploan,lbp_gloan,ncipea_mandatory,lbp_monAm" + _
                                      ",ncipea_monAm,ncipea_amount,ncipea_loan,phic_ee,phic_er,hdmf_ee,wt_amount FROM tLoan WHERE EmployeeID ='" + sUserID + "'")

        If dtDeductions.Rows.Count > 0 Then
            With dtDeductions
                lBasic.Text = .Rows(0)("basicPay").ToString
                lPERA.Text = objSettings.amountPERA.ToString
                lGrossPay.Text = .Rows(0)("basicPay").ToString

                lPolicyLoan.Text = IIf(LoanHelper.IsZeroBalance("gsis_pl_balance", sUserID), "0.00", .Rows(0)("gsis_pl_monAm").ToString)
                lECard.Text = "0.00"
                lEmergencyLoan.Text = IIf(LoanHelper.IsZeroBalance("gsis_el_balance", sUserID), "0.00", .Rows(0)("gsis_el_monAm").ToString)
                lConsoLaon.Text = IIf(LoanHelper.IsZeroBalance("gsis_cl_balance", sUserID), "0.00", .Rows(0)("gsis_cl_monAm").ToString)
                lPAGIBIGLoan.Text = IIf(LoanHelper.IsZeroBalance("hdmf_mp_balance", sUserID), "0.00", .Rows(0)("hdmf_mp_monAm").ToString)
                lPAGIBIGHouse.Text = IIf(LoanHelper.IsZeroBalance("hdmf_hs_balance", sUserID), "0.00", .Rows(0)("hdmf_hs_monAm").ToString)
                lNCIPAELoan.Text = IIf(LoanHelper.IsZeroBalance("ncipea_balance", sUserID), "0.00", .Rows(0)("ncipea_monAm").ToString)
                lLBPLoan.Text = IIf(LoanHelper.IsZeroBalance("lbp_balance", sUserID), "0.00", .Rows(0)("lbp_monAm").ToString)
                lEducAssistance.Text = IIf(LoanHelper.IsZeroBalance("gsis_edu_balance", sUserID), "0.00", .Rows(0)("gsis_edu_monAm").ToString)

                lUOLI.Text = .Rows(0)("gsis_ouli").ToString
                lGSISSocial.Text = .Rows(0)("gsis_ec").ToString
                lNCIPMandatory.Text = .Rows(0)("ncipea_mandatory").ToString
                lNCIPMembership.Text = .Rows(0)("ncipea_amount").ToString
                lPHIC.Text = .Rows(0)("phic_ee").ToString
                lHDMF.Text = .Rows(0)("hdmf_ee").ToString
                lWT.Text = .Rows(0)("wt_amount").ToString
            End With

        End If

        lNetPay.Text = objBiz.GetNet(dtDeductions).ToString()

    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ClearComputaionForm()
    End Sub
End Class