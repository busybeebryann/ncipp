Imports System.Data.SqlClient
Imports WindowsApplication1.Extensions

Public Class LoanForm
    Public sEmpID As String
    Private objBO As New Payroll
    Private LoanBO As New Loans
    Private _duration As New Object

    Private Property thisdate As Object

    Private Sub initialized(sender As Object, e As EventArgs) Handles MyBase.Load
        GetEmployee()
        LoanBO.SetLoanTable()
    End Sub

    Private Sub GetEmployee()



        Try
            If sEmpID = "" Then
                MessageBox.Show("Wrong Call.....!")
                Me.Close()
            End If

            LoanBO.SetEmployeeID(sEmpID)

            Dim sGetQry As String
            sGetQry = "select user_id,emp_id,first_name,last_name,status,basic_pay from tbl_user where emp_id= '" + sEmpID + "'"
            Dim dtSearched As DataTable
            dtSearched = GetDataAsTable(sGetQry)

            If (dtSearched.Rows.Count > 0) Then

                txtempid.Text = dtSearched.Rows(0)("emp_id").ToString()
                txtempid.Tag = sEmpID
                txtfname.Text = dtSearched.Rows(0)("first_name").ToString()
                txtlname.Text = dtSearched.Rows(0)("last_name").ToString()
                cdoStatus.SelectedItem = dtSearched.Rows(0)("status").ToString()
                numBasic.Value = dtSearched.Rows(0)("basic_pay").ToString()
            End If

            sGetQry = "select * from tLoan where EmployeeID= '" + sEmpID + "'"
            Dim dtSearchedDetails As DataTable
            dtSearchedDetails = GetDataAsTable(sGetQry)
            If (dtSearchedDetails.Rows.Count > 0) Then
                'policy loan
                txtgsis_pl_remarks.Text = dtSearchedDetails.Rows(0)("gsis_pl_remarks").ToString()
                ngsis_pl_totalpay.Value = dtSearchedDetails.Rows(0)("gsis_pl_totalpay").ToString()
                ngsis_pl_totalAm.Value = dtSearchedDetails.Rows(0)("gsis_pl_totalAm").ToString()
                ngsis_pl_monAm.Value = dtSearchedDetails.Rows(0)("gsis_pl_monAm").ToString()
                ngsis_ploan.Value = dtSearchedDetails.Rows(0)("gsis_ploan").ToString()
                dtgsis_pl_end.Value = dtSearchedDetails.Rows(0)("gsis_pl_end").ToString()
                dtgsis_pl_start.Value = dtSearchedDetails.Rows(0)("gsis_pl_start").ToString()
                dtgsis_pl_gdate.Value = dtSearchedDetails.Rows(0)("gsis_pl_gdate").ToString()
                ngsis_pl_paidAm.Value = dtSearchedDetails.Rows(0)("gsis_pl_paidAm").ToString()
                'contributions
                'ngsis_ouli.Value = dtSearchedDetails.Rows(0)("gsis_ouli").ToString()
                'ngsis_ec.Value = dtSearchedDetails.Rows(0)("gsis_ec").ToString()
                'ngsis_ee.Value = dtSearchedDetails.Rows(0)("gsis_ee").ToString()
                'ngsis_er.Value = dtSearchedDetails.Rows(0)("gsis_er").ToString()
                'txtgsis_cl_remarks.Text = dtSearchedDetails.Rows(0)("gsis_cl_remarks").ToString()
                'ngsis_cl_totalpay.Value = dtSearchedDetails.Rows(0)("gsis_cl_totalpay").ToString()
                'ngsis_cl_totalAm.Value = dtSearchedDetails.Rows(0)("gsis_cl_totalAm").ToString()
                'ngsis_cl_monAm.Value = dtSearchedDetails.Rows(0)("gsis_cl_monAm").ToString()
                'ngsis_cl_paidAm.Value = dtSearchedDetails.Rows(0)("gsis_cl_paidAm").ToString()
                'ngsis_cloan.Value = dtSearchedDetails.Rows(0)("gsis_cloan").ToString()
                'dtgsis_cl_end.Value = dtSearchedDetails.Rows(0)("gsis_cl_end").ToString()
                'dtgsis_cl_start.Value = dtSearchedDetails.Rows(0)("gsis_cl_start").ToString()
                'dtgsis_cl_gdate.Value = dtSearchedDetails.Rows(0)("gsis_cl_gdate").ToString()
                'txtgsis_el_remarks.Text = dtSearchedDetails.Rows(0)("gsis_el_remarks").ToString()
                'ngsis_el_totalpay.Value = dtSearchedDetails.Rows(0)("gsis_el_totalpay").ToString()
                'ngsis_el_totalAm.Value = dtSearchedDetails.Rows(0)("gsis_el_totalAm").ToString()
                'ngsis_el_monAm.Value = dtSearchedDetails.Rows(0)("gsis_el_monAm").ToString()
                'ngsis_el_paidAm.Value = dtSearchedDetails.Rows(0)("gsis_el_paidAm").ToString()
                'ngsis_eloan.Value = dtSearchedDetails.Rows(0)("gsis_eloan").ToString()
                'dtgsis_el_end.Value = dtSearchedDetails.Rows(0)("gsis_el_end").ToString()
                'dtgsis_el_start.Value = dtSearchedDetails.Rows(0)("gsis_el_start").ToString()
                'dtgsis_el_gdate.Value = dtSearchedDetails.Rows(0)("gsis_el_gdate").ToString()



                'txtgsis_edu_remarks.Text = dtSearchedDetails.Rows(0)("gsis_edu_remarks").ToString()
                'ngsis_edu_totalpay.Value = dtSearchedDetails.Rows(0)("gsis_edu_totalpay").ToString()
                'ngsis_edu_totalAm.Value = dtSearchedDetails.Rows(0)("gsis_edu_totalAm").ToString()
                'ngsis_edu_monAm.Value = dtSearchedDetails.Rows(0)("gsis_edu_monAm").ToString()
                'ngsis_edu_paidAm.Value = dtSearchedDetails.Rows(0)("gsis_edu_paidAm").ToString()
                'ngsis_eduloan.Value = dtSearchedDetails.Rows(0)("gsis_eduloan").ToString()
                'dtgsis_edu_end.Value = dtSearchedDetails.Rows(0)("gsis_edu_end").ToString()
                'dtgsis_edu_start.Value = dtSearchedDetails.Rows(0)("gsis_edu_start").ToString()
                'dtgsis_edu_gdate.Value = dtSearchedDetails.Rows(0)("gsis_edu_gdate").ToString()
                'txthdmf_hs_remarks.Text = dtSearchedDetails.Rows(0)("hdmf_hs_remarks").ToString()
                'nhdmf_hs_totalpay.Value = dtSearchedDetails.Rows(0)("hdmf_hs_totalpay").ToString()
                'nhdmf_hs_totalAm.Value = dtSearchedDetails.Rows(0)("hdmf_hs_totalAm").ToString()
                'nhdmf_hs_monAm.Value = dtSearchedDetails.Rows(0)("hdmf_hs_monAm").ToString()
                'nhdmf_hs_paidAm.Value = dtSearchedDetails.Rows(0)("hdmf_hs_paidAm").ToString()
                'nhdmf_hsloan.Value = dtSearchedDetails.Rows(0)("hdmf_hsloan").ToString()
                'dthdmf_hs_end.Value = dtSearchedDetails.Rows(0)("hdmf_hs_end").ToString()
                'dthdmf_hs_start.Value = dtSearchedDetails.Rows(0)("hdmf_hs_start").ToString()
                'dthdmf_hs_gdate.Value = dtSearchedDetails.Rows(0)("hdmf_hs_gdate").ToString()
                'txthdmf_mp_remarks.Text = dtSearchedDetails.Rows(0)("hdmf_mp_remarks").ToString()
                'nhdmf_mp_totalpay.Value = dtSearchedDetails.Rows(0)("hdmf_mp_totalpay").ToString()
                'nhdmf_mp_totalAm.Value = dtSearchedDetails.Rows(0)("hdmf_mp_totalAm").ToString()
                'nhdmf_mp_monAm.Value = dtSearchedDetails.Rows(0)("hdmf_mp_monAm").ToString()
                'nhdmf_mp_paidAm.Value = dtSearchedDetails.Rows(0)("hdmf_mp_paidAm").ToString()
                'nhdmf_mploan.Value = dtSearchedDetails.Rows(0)("hdmf_mploan").ToString()
                'dthdmf_mp_end.Value = dtSearchedDetails.Rows(0)("hdmf_mp_end").ToString()
                'dthdmf_mp_start.Value = dtSearchedDetails.Rows(0)("hdmf_mp_start").ToString()
                'dthdmf_mp_gdate.Value = dtSearchedDetails.Rows(0)("hdmf_mp_gdate").ToString()
                'nlbp_totalpay.Value = dtSearchedDetails.Rows(0)("lbp_totalpay").ToString()
                'nlbp_totalAm.Value = dtSearchedDetails.Rows(0)("lbp_totalAm").ToString()
                'nlbp_monAm.Value = dtSearchedDetails.Rows(0)("lbp_monAm").ToString()
                'nlbp_gloan.Value = dtSearchedDetails.Rows(0)("lbp_gloan").ToString()
                'nlbp_paidAm.Value = dtSearchedDetails.Rows(0)("lbp_paidAm").ToString()
                'dtlbp_end.Value = dtSearchedDetails.Rows(0)("lbp_end").ToString()
                'dtlbp_start.Value = dtSearchedDetails.Rows(0)("lbp_start").ToString()
                'dtlbp_gdate.Value = dtSearchedDetails.Rows(0)("lbp_gdate").ToString()
                'txtlbp_remarks.Text = dtSearchedDetails.Rows(0)("lbp_remarks").ToString()
                'ncipea_mandatory.Value = dtSearchedDetails.Rows(0)("ncipea_mandatory").ToString()
                'ncipea_amount.Value = dtSearchedDetails.Rows(0)("ncipea_amount").ToString()
                'ncipea_totalpay.Value = dtSearchedDetails.Rows(0)("ncipea_totalpay").ToString()
                'ncipea_totalAm.Value = dtSearchedDetails.Rows(0)("ncipea_totalAm").ToString()
                'ncipea_monAm.Value = dtSearchedDetails.Rows(0)("ncipea_monAm").ToString()
                'ncipea_loan.Value = dtSearchedDetails.Rows(0)("ncipea_loan").ToString()
                'ncipea_paidAm.Value = dtSearchedDetails.Rows(0)("ncipea_paidAm").ToString()
                'dtcipea_end.Value = dtSearchedDetails.Rows(0)("ncipea_end").ToString()
                'dtcipea_start.Value = dtSearchedDetails.Rows(0)("ncipea_start").ToString()
                'dtcipea_gdate.Value = dtSearchedDetails.Rows(0)("ncipea_gdate").ToString()
                'txtncipea_remarks.Text = dtSearchedDetails.Rows(0)("ncipea_remarks").ToString()
                'nphic_ee.Value = dtSearchedDetails.Rows(0)("phic_ee").ToString()
                'nphic_er.Value = dtSearchedDetails.Rows(0)("phic_er").ToString()
                'nhdmf_ee.Value = dtSearchedDetails.Rows(0)("hdmf_ee").ToString()
                'nhdmf_er.Value = dtSearchedDetails.Rows(0)("hdmf_er").ToString()
                ncipea_witholdingtax.Value = dtSearchedDetails.Rows(0)("wt_amount").ToString()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, sProjectTitle)
        End Try
    End Sub

    Private Sub _computeGSIS_EEER()

        Try
            ngsis_er.Value = numBasic.Value * 0.12
            ngsis_ee.Value = numBasic.Value * 0.09
        Catch ex As Exception

        End Try
    End Sub

    Private Sub numBasic_ValueChanged(sender As Object, e As EventArgs) Handles numBasic.ValueChanged

    End Sub



    Private Sub _updateGSISPolicyloan() Handles dtgsis_pl_start.ValueChanged, dtgsis_pl_end.ValueChanged

    End Sub

    Private Sub _updateGSISConsoloan() Handles dtgsis_cl_start.ValueChanged, dtgsis_cl_end.ValueChanged

    End Sub
    Private Sub _updateGSISEducloan() Handles dtgsis_edu_start.ValueChanged, dtgsis_edu_end.ValueChanged
 
    End Sub
    Private Sub _updateGSISEmergencyloan() Handles dtgsis_el_start.ValueChanged, dtgsis_el_end.ValueChanged

    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim sQuery As String
        Dim sReturend As String = ""
        sQuery = String.Format("Select Count(*) from tLoan Where EmployeeID= '{0}'", txtempid.Tag.ToString())

        If (Not IsRecordExist(sQuery)) Then
            sQuery = "INSERT INTO [tLoan]" + _
          "([EmployeeID],[LastName],[FirstName],[Status],[basicPay]) VALUES(" + _
          txtempid.Tag.ToString() + ",'" + txtlname.Text + "','" + txtfname.Text + "','" + cdoStatus.Text + "'," + numBasic.Value.ToString() + ")"

            sReturend = ExecuteDML(sQuery)
            If (sReturend.StartsWith("Error")) Then
                MessageBox.Show(sReturend)
                Exit Sub
            End If
        End If

        sQuery = "UPDATE [tLoan] SET [Status] ='" + cdoStatus.Text + _
      "',[basicPay] = " + numBasic.Value.ToString() + _
      ",[gsis_ouli] = " + ngsis_ouli.Value.ToString() + _
      ",[gsis_ec] = " + ngsis_ec.Value.ToString() + _
      ",[gsis_ee] = " + ngsis_ee.Value.ToString() + _
      ",[gsis_er] = " + ngsis_er.Value.ToString() + _
      ",[gsis_cl_remarks] = '" + txtgsis_cl_remarks.Text + _
      "',[gsis_cl_totalAm] = " + ngsis_cl_totalAm.Value.ToString() + _
      ",[gsis_cl_monAm] = " + ngsis_cl_monAm.Value.ToString() + _
      ",[gsis_cloan] = " + ngsis_cloan.Value.ToString() + _
      ",[gsis_cl_end] = '" + dtgsis_cl_end.Value.ToString("yyyy-MM-dd") + _
      "',[gsis_cl_start] = '" + dtgsis_cl_start.Value.ToString("yyyy-MM-dd") + _
      "',[gsis_cl_gdate] = '" + dtgsis_cl_gdate.Value.ToString("yyyy-MM-dd") + _
      "',[gsis_el_remarks] = '" + txtgsis_el_remarks.Text + _
      "',[gsis_el_totalAm] = " + ngsis_el_totalAm.Value.ToString() + _
      ",[gsis_el_monAm] = " + ngsis_el_monAm.Value.ToString() + _
      ",[gsis_eloan] = " + ngsis_eloan.Value.ToString() + _
      ",[gsis_el_end] = '" + dtgsis_el_end.Value.ToString("yyyy-MM-dd") + _
      "',[gsis_el_start] = '" + dtgsis_el_start.Value.ToString("yyyy-MM-dd") + _
      "',[gsis_el_gdate] = '" + dtgsis_el_gdate.Value.ToString("yyyy-MM-dd") + _
      "',[gsis_pl_remarks] = '" + txtgsis_pl_remarks.Text + _
      "',[gsis_pl_totalAm] = " + ngsis_pl_totalAm.Value.ToString() + _
      ",[gsis_pl_monAm] =  " + ngsis_pl_monAm.Value.ToString() + _
      ",[gsis_ploan] =  " + ngsis_ploan.Value.ToString() + _
      ",[gsis_pl_end] = '" + dtgsis_pl_end.Value.ToString("yyyy-MM-dd") + _
      "',[gsis_pl_start] ='" + dtgsis_pl_start.Value.ToString("yyyy-MM-dd") + _
      "',[gsis_pl_gdate] = '" + dtgsis_pl_gdate.Value.ToString("yyyy-MM-dd") + _
      "',[gsis_edu_remarks] = '" + txtgsis_edu_remarks.Text + _
      "',[gsis_edu_totalAm] =  " + ngsis_edu_totalAm.Value.ToString() + _
      ",[gsis_edu_monAm] =  " + ngsis_edu_monAm.Value.ToString() + _
      ",[gsis_eduloan] =  " + ngsis_eduloan.Value.ToString() + _
      ",[gsis_edu_end] = '" + dtgsis_edu_end.Value.ToString("yyyy-MM-dd") + _
      "',[gsis_edu_start] = '" + dtgsis_edu_start.Value.ToString("yyyy-MM-dd") + _
      "',[gsis_edu_gdate] = '" + dtgsis_edu_gdate.Value.ToString("yyyy-MM-dd") + _
      "',[hdmf_hs_remarks] = '" + txthdmf_hs_remarks.Text + _
      "',[hdmf_hs_totalAm] = " + nhdmf_hs_totalAm.Value.ToString() + _
      ",[hdmf_hs_monAm] =  " + nhdmf_hs_monAm.Value.ToString() + _
      ",[hdmf_hsloan] = " + nhdmf_hsloan.Value.ToString() + _
      ",[hdmf_hs_end] = '" + dthdmf_hs_end.Value.ToString("yyyy-MM-dd") + _
      "',[hdmf_hs_start] = '" + dthdmf_hs_start.Value.ToString("yyyy-MM-dd") + _
      "',[hdmf_hs_gdate] = '" + dthdmf_hs_gdate.Value.ToString("yyyy-MM-dd") + _
      "',[hdmf_mp_remarks] = '" + txthdmf_mp_remarks.Text + _
      "',[hdmf_mp_totalAm] =  " + nhdmf_mp_totalAm.Value.ToString() + _
      ",[hdmf_mp_monAm] = " + nhdmf_mp_monAm.Value.ToString() + _
      ",[hdmf_mploan] = " + nhdmf_mploan.Value.ToString() + _
      ",[hdmf_mp_end] = '" + dthdmf_mp_end.Value.ToString("yyyy-MM-dd") + _
      "',[hdmf_mp_start] = '" + dthdmf_mp_start.Value.ToString("yyyy-MM-dd") + _
      "',[hdmf_mp_gdate] = '" + dthdmf_mp_gdate.Value.ToString("yyyy-MM-dd") + _
      "',[lbp_totalAm] = " + nlbp_totalAm.Value.ToString() + _
      ",[lbp_monAm] = " + nlbp_monAm.Value.ToString() + _
      ",[lbp_gloan] = " + nlbp_gloan.Value.ToString() + _
      ",[lbp_end] = '" + dtlbp_end.Value.ToString("yyyy-MM-dd") + _
      "',[lbp_start] = '" + dtlbp_start.Value.ToString("yyyy-MM-dd") + _
      "',[lbp_gdate] = '" + dtlbp_gdate.Value.ToString("yyyy-MM-dd") + _
      "',[lbp_remarks] = '" + txtlbp_remarks.Text + _
      "',[ncipea_mandatory] = " + ncipea_mandatory.Value.ToString() + _
      ",[ncipea_amount] = " + ncipea_amount.Value.ToString() + _
      ",[ncipea_totalAm] = " + ncipea_totalAm.Value.ToString() + _
      ",[ncipea_monAm] = " + ncipea_monAm.Value.ToString() + _
      ",[ncipea_loan] = " + ncipea_loan.Value.ToString() + _
      ",[ncipea_end] = '" + dtcipea_end.Value.ToString("yyyy-MM-dd") + _
      "',[ncipea_start] = '" + dtcipea_start.Value.ToString("yyyy-MM-dd") + _
      "',[ncipea_gdate] ='" + dtcipea_gdate.Value.ToString("yyyy-MM-dd") + _
      "',[ncipea_remarks] = '" + txtncipea_remarks.Text + _
      "',[phic_ee] = " + nphic_ee.Value.ToString() + _
      ",[phic_er] = " + nphic_er.Value.ToString() + _
      ",[hdmf_ee] = " + nhdmf_ee.Value.ToString() + _
      ",[hdmf_er] = " + nhdmf_er.Value.ToString() + _
      ",[wt_amount] = " + ncipea_witholdingtax.Value.ToString() + _
      ",[gsis_cl_balance] = " + ngsis_cloan.Value.ToString() + _
      ",[gsis_el_balance] = " + ngsis_eloan.Value.ToString() + _
      ",[gsis_pl_balance] =  " + ngsis_ploan.Value.ToString() + _
      ",[gsis_edu_balance] =  " + ngsis_eduloan.Value.ToString() + _
      ",[hdmf_hs_balance] = " + nhdmf_hsloan.Value.ToString() + _
      ",[hdmf_mp_balance] = " + nhdmf_mploan.Value.ToString() + _
      ",[lbp_balance] = " + nlbp_gloan.Value.ToString() + _
      ",[ncipea_balance] = " + ncipea_loan.Value.ToString() + _
      ",[createdon] = getdate(),[modifiedon] = getdate() " + _
       "WHERE EmployeeID='" + txtempid.Tag.ToString() + "'"

        sReturend = ExecuteDML(sQuery)

        If (sReturend.StartsWith("Error")) Then
            MessageBox.Show(sReturend)
            Exit Sub
        End If

        MessageBox.Show("Loan Details Updated Successfully")

    End Sub

    Private Sub bClose_Click(sender As Object, e As EventArgs) Handles bClose.Click
        Me.Close()
    End Sub


    Private Sub bGet_Click(sender As Object, e As EventArgs) Handles bGet.Click
        Try
            ncipea_witholdingtax.Value = objBO.GetWitholdingTax(numBasic.Value, sEmpID)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Dim exisitngWT As Decimal = GetFieldValue(String.Format("select * from tLoan where EmployeeID ='{0}'", sEmpID), "wt_amount")
            If (ncipea_witholdingtax.Value = exisitngWT) Then
                MessageBox.Show("Already Updated")
            Else
                MessageBox.Show("Withoding Tax Updated Successfully")
            End If

        End Try

    End Sub

    Private Sub GroupBox12_Enter(sender As Object, e As EventArgs) Handles GroupBox12.Enter

    End Sub

    Private Sub Label42_Click(sender As Object, e As EventArgs) Handles Label42.Click

    End Sub

    Private Sub _PolicyLoanSchedule()
        Try

            With LoanBO
                .SetLoanBalance(Enums.GSIS.Policy, -1, -1, -1)
                .SetDurations(dtgsis_pl_start.Value, dtgsis_pl_end.Value)
                .SetAmortizationSched(ngsis_ploan.Value)
                ngsis_pl_monAm.Value = .MonthlyAmount
            End With
        Catch ex As Exception
            ex.Message.ToString()
        Finally
            If Not LoanBO.Principal = 0.0 And Not LoanBO.Duration = 0.0 Then
                Dim objForm As New gridLookup
                With objForm
                    .dgShedule.DataSource = LoanBO.ScheduleTable
                    .Show()
                End With
            Else
                MessageBox.Show("There is no schedule set.")
            End If
        End Try
    End Sub
    Private Sub _ConsoLoanSched()
        Try

            With LoanBO
                .SetLoanBalance(Enums.GSIS.Conso, -1, -1, -1)
                .SetDurations(dtgsis_cl_start.Value, dtgsis_cl_end.Value)
                .SetAmortizationSched(ngsis_cloan.Value)
                ngsis_cl_monAm.Value = .MonthlyAmount
            End With
        Catch ex As Exception
            ex.Message.ToString()
        Finally
            If Not LoanBO.Principal = 0.0 And Not LoanBO.Duration = 0.0 Then
                Dim objForm As New gridLookup
                With objForm
                    .dgShedule.DataSource = LoanBO.ScheduleTable
                    .Show()
                End With
            Else
                MessageBox.Show("There is no schedule set.")
            End If
        End Try
    End Sub
    Private Sub _EmergencyLoanSched()
        Try

            With LoanBO
                .SetLoanBalance(Enums.GSIS.Emergency, -1, -1, -1)
                .SetDurations(dtgsis_el_start.Value, dtgsis_el_end.Value)
                .SetAmortizationSched(ngsis_eloan.Value)
                ngsis_el_monAm.Value = .MonthlyAmount
            End With

        Catch ex As Exception
            ex.Message.ToString()
        Finally
            If Not LoanBO.Principal = 0.0 And Not LoanBO.Duration = 0.0 Then
                Dim objForm As New gridLookup
                With objForm
                    .dgShedule.DataSource = LoanBO.ScheduleTable
                    .Show()
                End With
            Else
                MessageBox.Show("There is no Schedule set.")
            End If
        End Try
    End Sub
    Private Sub _EducationalLoanSched()
        Try

            With LoanBO
                .SetLoanBalance(Enums.GSIS.Educational, -1, -1, -1)
                .SetDurations(dtgsis_edu_start.Value, dtgsis_edu_end.Value)
                .SetAmortizationSched(ngsis_eduloan.Value)
                ngsis_edu_monAm.Value = .MonthlyAmount
            End With

        Catch ex As Exception
            ex.Message.ToString()
        Finally
            If Not LoanBO.Principal = 0.0 And Not LoanBO.Duration = 0.0 Then
                Dim objForm As New gridLookup
                With objForm
                    .dgShedule.DataSource = LoanBO.ScheduleTable
                    .Show()
                End With
            Else
                MessageBox.Show("There is no Schedule set.")
            End If
        End Try
    End Sub
    Private Sub _Mulitpurpose()
        Try

            With LoanBO
                .SetLoanBalance(-1, Enums.HDMF.Mandatory, -1, -1)
                .SetDurations(dtgsis_el_start.Value, dtgsis_el_end.Value)
                .SetAmortizationSched(nhdmf_mploan.Value)
                nhdmf_mp_monAm.Value = .MonthlyAmount
            End With

        Catch ex As Exception
            ex.Message.ToString()
        Finally
            If Not LoanBO.Principal = 0.0 And Not LoanBO.Duration = 0.0 Then
                Dim objForm As New gridLookup
                With objForm
                    .dgShedule.DataSource = LoanBO.ScheduleTable
                    .Show()
                End With
            Else
                MessageBox.Show("There is no Schedule set.")
            End If
        End Try
    End Sub

    Private Sub _Housing()
        Try

            With LoanBO
                .SetLoanBalance(-1, Enums.HDMF.Housing, -1, -1)
                .SetDurations(dthdmf_hs_start.Value, dthdmf_hs_end.Value)
                .SetAmortizationSched(nhdmf_hsloan.Value)
                nhdmf_hs_monAm.Value = .MonthlyAmount
            End With

        Catch ex As Exception
            ex.Message.ToString()
        Finally
            If Not LoanBO.Principal = 0.0 And Not LoanBO.Duration = 0.0 Then
                Dim objForm As New gridLookup
                With objForm
                    .dgShedule.DataSource = LoanBO.ScheduleTable
                    .Show()
                End With
            Else
                MessageBox.Show("There is no Schedule set.")
            End If
        End Try
    End Sub

    Private Sub _LandBank()
        Try

            With LoanBO
                .SetLoanBalance(-1, -1, Enums.LBP.Mandatory, -1)
                .SetDurations(dtlbp_start.Value, dtlbp_end.Value)
                .SetAmortizationSched(nlbp_gloan.Value)
                nlbp_monAm.Value = .MonthlyAmount
            End With

        Catch ex As Exception
            ex.Message.ToString()
        Finally
            If Not LoanBO.Principal = 0.0 And Not LoanBO.Duration = 0.0 Then
                Dim objForm As New gridLookup
                With objForm
                    .dgShedule.DataSource = LoanBO.ScheduleTable
                    .Show()
                End With
            Else
                MessageBox.Show("There is no Schedule set.")
            End If
        End Try
    End Sub

    Private Sub _NCIPEALoans()
        Try

            With LoanBO
                .SetLoanBalance(-1, -1, -1, Enums.NCIPEA.Mandatory)
                .SetDurations(dtcipea_start.Value, dtcipea_end.Value)
                .SetAmortizationSched(ncipea_loan.Value)
                ncipea_monAm.Value = .MonthlyAmount
            End With

        Catch ex As Exception
            ex.Message.ToString()
        Finally
            If Not LoanBO.Principal = 0.0 And Not LoanBO.Duration = 0.0 Then
                Dim objForm As New gridLookup
                With objForm
                    .dgShedule.DataSource = LoanBO.ScheduleTable
                    .Show()
                End With
            Else
                MessageBox.Show("There is no Schedule set.")
            End If
        End Try
    End Sub

    Private Sub button_Click(sender As Object, e As EventArgs) Handles btnPolicy.Click
        _PolicyLoanSchedule()
    End Sub

    Private Sub btnEmergency_Click(sender As Object, e As EventArgs) Handles btnEmergency.Click
        _EmergencyLoanSched()
    End Sub

    Private Sub btnConso_Click(sender As Object, e As EventArgs) Handles btnConso.Click
        _ConsoLoanSched()
    End Sub
    Private Sub btnEducational_Click(sender As Object, e As EventArgs) Handles btnEducational.Click
        _EducationalLoanSched()
    End Sub
    Private Sub btnMultipurpose_Click(sender As Object, e As EventArgs) Handles btnMultipurpose.Click
        _Mulitpurpose()
    End Sub

    Private Sub btnHousing_Click(sender As Object, e As EventArgs) Handles btnHousing.Click
        _Housing()
    End Sub
    Private Sub btnLBP_Click(sender As Object, e As EventArgs) Handles btnLBP.Click
        _LandBank()

    End Sub

    Private Sub btnNCIPLoans_Click(sender As Object, e As EventArgs) Handles btnNCIPLoans.Click
        _NCIPEALoans()
    End Sub



 
End Class