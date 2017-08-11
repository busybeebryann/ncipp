Imports System.Data.SqlClient
Imports System.Globalization
Imports WindowsApplication1.Extensions
Imports WindowsApplication1.Enums
Public Class PayrollDateRange
    Property payrolldto As New PayrollDTO
    Dim PayrollBO As New Payroll
    Dim Settings As New GlobalSettings
    Dim dtEmployeelist As DataTable
    Dim dtPayrollList As New DataTable
    Dim _months As String
    Dim _sPeriod As String
    Dim datenow As Date
    Dim sDMQry, sMessage, strsql, mnow As String
    Dim sReturend As String = ""
    Private Sub PayrollDateRange_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvPayroll.DataSource = False
        loadMonthAndYearPeriod()
    End Sub
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        'before writing in data table , each row should be
        ' by employee number
        '1. get loans  wt and contribution of employee  - join tables
        '2 . compute the net for each employee - declare fields for table Payroll
        'write the date_range 

        If ValidateForm() Then
            dtEmployeelist = GetDataAsTable("select * from tbl_user a Join tLoan b on a.emp_id = b.EmployeeID")
            createDatagridTable()
            dgvPayroll.DataSource = dtPayrollList
            Try

    
            For iRow = 0 To dtEmployeelist.Rows.Count - 1

                ClearDTO()

                If (dtEmployeelist.Rows.Count > 0) Then

                    With dtEmployeelist

                        payrolldto.EmployeeId = .Rows(iRow)("emp_id")
                        payrolldto.LastName = .Rows(iRow)("last_name")
                        payrolldto.FirstName = .Rows(iRow)("first_name")
                        payrolldto.Status = .Rows(iRow)("marital_status")
                        payrolldto.Dependents = .Rows(iRow)("dependents")
                        payrolldto.Position = .Rows(iRow)("job_pos")
                        payrolldto.Department = .Rows(iRow)("dept")
                        payrolldto.Basic = .Rows(iRow)("basicPay")
                        payrolldto.PERA = Settings.amountPERA
                        payrolldto.Gross = .Rows(iRow)("basicPay")
                        payrolldto.PolicyLoan = IIf(LoanHelper.IsZeroBalance("gsis_pl_balance", payrolldto.EmployeeId), "0.00", .Rows(iRow)("gsis_pl_monAm"))
                        payrolldto.ECard = 0.0
                        payrolldto.EmergencyLoan = IIf(LoanHelper.IsZeroBalance("gsis_el_balance", payrolldto.EmployeeId), "0.00", .Rows(iRow)("gsis_el_monAm"))
                        payrolldto.ConsoLoan = IIf(LoanHelper.IsZeroBalance("gsis_cl_balance", payrolldto.EmployeeId), "0.00", .Rows(iRow)("gsis_cl_monAm"))
                        payrolldto.HMDFLoan = IIf(LoanHelper.IsZeroBalance("hdmf_mp_balance", payrolldto.EmployeeId), "0.00", .Rows(iRow)("hdmf_mp_monAm"))
                        payrolldto.HMDFHSLoan = IIf(LoanHelper.IsZeroBalance("hdmf_hs_balance", payrolldto.EmployeeId), "0.00", .Rows(iRow)("hdmf_hs_monAm"))
                        payrolldto.NCIPAELoan = IIf(LoanHelper.IsZeroBalance("ncipea_balance", payrolldto.EmployeeId), "0.00", .Rows(iRow)("ncipea_monAm"))
                        payrolldto.LBPLoan = IIf(LoanHelper.IsZeroBalance("lbp_balance", payrolldto.EmployeeId), "0.00", .Rows(iRow)("lbp_monAm"))
                        payrolldto.EducAssistance = IIf(LoanHelper.IsZeroBalance("gsis_edu_balance", payrolldto.EmployeeId), "0.00", .Rows(iRow)("gsis_edu_monAm"))
                        payrolldto.UOLI = .Rows(iRow)("gsis_ouli")
                        payrolldto.GSISSOCIAL = .Rows(iRow)("gsis_ec")
                        payrolldto.NCIPMAND = .Rows(iRow)("ncipea_mandatory")
                        payrolldto.NCIPMEMBER = .Rows(iRow)("ncipea_amount")
                        payrolldto.PHIC = .Rows(iRow)("phic_ee")
                        payrolldto.HDMF = .Rows(iRow)("hdmf_ee")
                        payrolldto.WT = .Rows(iRow)("wt_amount")

                    End With
                    'need to compute cont,loans,wt,net per row
                    payrolldto.Net = PayrollBO.GetNet(dtEmployeelist, iRow)
                    'save to table payroll per row - insert a row
                    InsertToTable()
                        ' PayrollBO.GetNet(dtEmployeelist.)
                        'dgvPayroll.DataSource = dtPayrollList '- filter by month and year 
                        ' dtPayrollList.Rows.Add(iRow + 1, )
                        InsertDataGridRow(iRow)

                        PayrollBO.UpdateLoanPayments(dtEmployeelist, iRow)

                        PayrollBO.UpdateLoanBalance(dtEmployeelist, iRow)

                    End If



                Next

                If sReturend <> "True" Then
                    MessageBox.Show(sReturend)
                    Exit Sub
                Else
                    MessageBox.Show(sMessage, sProjectTitle)

                End If

            Catch ex As Exception

            End Try


        Else
            MsgBox("Please select specific Month and Year")
            Exit Sub
        End If

     
    End Sub
    Private Sub InsertToTable()

        'use tbl_payroll, add month_computed, date_computed , time_computed
        Try
            datenow = Date.Now()
            mnow = datenow.ToString("MMMM")
            lblPeriod.Text = checkPeriod(cboMonth.SelectedIndex + 1)
            strsql = String.Format("select province from tbl_user where emp_id ='{0}'", payrolldto.EmployeeId)
            Dim strProvince As String = GetAStringValue(strsql)

            With payrolldto
                sDMQry = " INSERT INTO tPayroll " + _
                    " VALUES (" + _
                    " '" + .EmployeeId + _
                    "','" + .FirstName + " " + .LastName + _
                    "','" + .Position + _
                    "','" + .Department + _
                    "','" + lblPeriod.Text + _
                    "','" + .Status + _
                    "','" + .Dependents + _
                    "','rate_day'" + _
                    ",'rate_houre'" + _
                    ",0.00" + _
                    ",0.00" + _
                    ",0.00" + _
                    "," + .Basic.ToString + _
                    "," + .PERA.ToString + _
                    "," + .Gross.ToString + _
                    "," + .PolicyLoan.ToString + _
                    "," + .ECard.ToString + _
                    "," + .EmergencyLoan.ToString + _
                    "," + .ConsoLoan.ToString + _
                    "," + .HMDFLoan.ToString + _
                    "," + .HMDFHSLoan.ToString + _
                    "," + .NCIPAELoan.ToString + _
                    "," + .LBPLoan.ToString + _
                    "," + .EducAssistance.ToString + _
                    "," + .UOLI.ToString + _
                    "," + .GSISSOCIAL.ToString + _
                    "," + .NCIPMAND.ToString + _
                    "," + .NCIPMEMBER.ToString + _
                    "," + .PHIC.ToString + _
                    "," + .HDMF.ToString + _
                    "," + .WT.ToString + _
                    "," + .Net.ToString + _
                    ",'addtional'" + _
                    ",0.00" + _
                    ",'" + datenow.ToString + _
                    "','" + mnow + _
                    "','" + TimeOfDay + _
                    "','tDed" + _
                    "','" + strProvince + _
                    "',getdate(),getdate())"
            End With



            sMessage = "Computation Added Successfully"
            'Update

            sReturend = ExecuteDML(sDMQry)
            If sReturend <> "True" Then
                ' MessageBox.Show(sReturend)
                'sMessage = "E"
                sReturend = "False"
            Else
                ' MessageBox.Show(sMessage, sProjectTitle)

            End If


        Catch ex As Exception
            ' MessageBox.Show(ex.Message)
            sMessage = ex.Message
        Finally
            If sReturend = "True" Then

            End If

        End Try
    End Sub
    Private Function ValidateForm() As Boolean
        Dim bReturn As Boolean = True
        'Add Form  Validation Here

        If cboMonth.SelectedIndex = -1 Or cboYear.SelectedIndex = -1 Then
            Return bReturn = False
        Else
            Return bReturn = True
        End If

    End Function
    Private Sub createDatagridTable()
        With dtPayrollList
            .Columns.Add("No.")
            .Columns.Add("Employee Id")
            .Columns.Add("Name")
            .Columns.Add("Basic")
            .Columns.Add("PERA")
            .Columns.Add("Gross")
            .Columns.Add("Policy Loan")
            .Columns.Add("E Card")
            .Columns.Add("Emergency Loan")
            .Columns.Add("Conso Loan")
            .Columns.Add("Educational Assistance")
            .Columns.Add("Pag ibig Loan")
            .Columns.Add("Pag ibig Housing Loan")
            .Columns.Add("NCIPEA Loan")
            .Columns.Add("LBP Loan")
            .Columns.Add("UOLI")
            .Columns.Add("GSIS Social")
            .Columns.Add("NCIPEA Mandatory")
            .Columns.Add("NCIPEA Membership")
            .Columns.Add("PHIC")
            .Columns.Add("HMDF")
            .Columns.Add("Witholding Tax")
            .Columns.Add("Net Pay")
        End With
    End Sub
    Private Sub InsertDataGridRow(ByVal iRow As Integer)
        With payrolldto
            dtPayrollList.Rows.Add(
                iRow + 1,
               .EmployeeId,
               .FirstName + " " + .LastName,
               .Basic,
               .PERA,
               .Gross,
               .PolicyLoan,
               .ECard,
               .EmergencyLoan,
               .ConsoLoan,
               .EducAssistance,
               .HMDFLoan,
               .HMDFHSLoan,
               .NCIPAELoan,
               .LBPLoan,
               .UOLI,
               .GSISSOCIAL,
               .NCIPMAND,
               .NCIPMEMBER,
               .PHIC,
               .HDMF,
               .WT,
               .Net)
        End With
    End Sub
    Private Sub loadMonthAndYearPeriod()

        Dim iMonth As Integer
        For iMonth = 0 To 11
            _months = DateHelper.GetMonthName(iMonth)
            cboMonth.Items.Add(_months)
        Next

        Dim iYear As Integer
        For iYear = 2000 To Today.Year
            cboYear.Items.Add(iYear.ToString())
        Next

        cboMonth.SelectedIndex = -1
        cboYear.SelectedIndex = -1
    End Sub
    Private Function checkPeriod(ByRef iMonth As Integer) As String

        If Not cboMonth.SelectedIndex = -1 Or Not cboYear.SelectedIndex = -1 Then
            Dim firstDayOfMonth, LastDayOfMonth As Date
            firstDayOfMonth = Convert.ToDateTime(cboYear.Text + "-" + iMonth.ToString() + "-" + "1")
            LastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1)
            Return String.Format("{0} {1}-{2} {3}", firstDayOfMonth.ToString("MMM"), firstDayOfMonth.Day.ToString(), LastDayOfMonth.Day.ToString(), cboYear.Text)
        Else
            Return "Generated Payroll Data"
        End If
    End Function
    Private Sub ClearDTO()
        payrolldto = New PayrollDTO
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub
End Class