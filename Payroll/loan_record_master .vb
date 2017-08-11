Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.OleDb
Public Class loan_record_master

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Dim objLoan As New LoanForm
        objLoan.ShowDialog()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmployees.CellContentClick

    End Sub

    Private Sub bClose_Click(sender As Object, e As EventArgs) Handles bClose.Click
        Me.Close()
    End Sub

    Private Sub loan_record_master_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshForm()
    End Sub

    Private Sub RefreshForm()
        cbEmpID.DisplayMember = "emp_id"
        cbEmpID.ValueMember = "user_id"
        cbEmpID.DataSource = GetDataAsTable("select user_id='0',emp_id='----ALL---' union all select user_id,emp_id from tbl_user")

        If (cbEmpID.Items.Count > 0) Then
            cbEmpID.SelectedIndex = 0
        End If
        RefreshGrid()

    End Sub
    Private Sub RefreshGrid()
        Dim sQry As String
        If (cbEmpID.SelectedIndex = 0) Then
            sQry = "select user_id,emp_id,first_name,last_name,status,basic_pay from tbl_user WHERE  first_name LIKE '%" + tbName.Text + "%' OR last_name LIKE '%" + tbName.Text + "%'  "
        Else
            sQry = "select user_id,emp_id,first_name,last_name,status,basic_pay from tbl_user where user_id=" + cbEmpID.SelectedValue.ToString()

        End If
        dgvEmployees.DataSource = GetDataAsTable(sQry)
        dgvEmployees.CurrentCell = Nothing
    End Sub

    Private Sub bRefresh_Click(sender As Object, e As EventArgs) Handles bRefresh.Click
        RefreshForm()
    End Sub

    Private Sub tbName_TextChanged(sender As Object, e As EventArgs) Handles tbName.TextChanged
        RefreshGrid()
    End Sub

    Private Sub cbEmpID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEmpID.SelectedIndexChanged
        RefreshGrid()
    End Sub

    Private Sub bAdd_Click(sender As Object, e As EventArgs) Handles bAdd.Click
        Try

            If IsNothing(dgvEmployees.CurrentRow) Then
                MessageBox.Show("Pleace Select Employee to Add Loan")
                Exit Sub
            End If

            If (dgvEmployees.CurrentCell.RowIndex < 0) Then
                MessageBox.Show("Pleace Select Employee to Add Loan")
                Exit Sub
            End If
            Dim sEmployeeID As String
            sEmployeeID = dgvEmployees.CurrentRow.Cells("EmployeeID").Value.ToString()
            Dim objLoanForm As New LoanForm
            objLoanForm.sEmpID = sEmployeeID
            objLoanForm.ShowDialog()

        Catch ex As Exception
            MessageBox.Show("Add error: " + ex.Message)
        End Try
    End Sub

    Private Sub dgvEmployees_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgvEmployees.MouseDoubleClick
        If (dgvEmployees.CurrentCell.RowIndex >= 0) Then
            Dim sEmployeeID As String
            sEmployeeID = dgvEmployees.CurrentRow.Cells("EmployeeID").Value.ToString()
            Dim objLoanForm As New LoanForm
            objLoanForm.sEmpID = sEmployeeID
            objLoanForm.ShowDialog()
        End If
    End Sub
End Class