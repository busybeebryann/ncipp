Imports WindowsApplication1.Enums
Imports WindowsApplication1.Extensions
Public Class ManagePositions

    Private Sub ManagePositions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearForm()
    End Sub

    Private Sub bClose_Click(sender As Object, e As EventArgs) Handles bClose.Click
        Me.Close()
    End Sub

    Private Sub bClear_Click(sender As Object, e As EventArgs) Handles bClear.Click
        ClearForm()
    End Sub
    Private Sub LoadDepartment()
        cbDepartment.DisplayMember = "DeptName"
        cbDepartment.ValueMember = "ID"
        cbDepartment.DataSource = GetDataAsTable("Select ID,DeptName from tDepartment")
        If (cbDepartment.Items.Count > 0) Then cbDepartment.SelectedIndex = -1
    End Sub
    Private Sub ClearForm()
        dgvDepartments.DataSource = GetDataAsTable("Select ID,positionname,salarygrade,basicpay,deptid,DeptName from tPosition")
        LoadDepartment()
        loadSalaryGrades()
        lID.Tag = "0"
        lID.Text = GetLastID("Select max(ID) from tPosition")
        tName.Clear()
        tBasicPay.Clear()
        tName.Focus()
    End Sub
    Private Sub loadSalaryGrades()
        For Each item In [Enum].GetValues(GetType(SalaryGrade))
            cbSalaryGrade.Items.Add(item)
        Next
        If (cbSalaryGrade.Items.Count > 0) Then cbSalaryGrade.SelectedIndex = -1
    End Sub
    Private Sub tBasicPay_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tBasicPay.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or Asc(e.KeyChar) = 8)
    End Sub

    Private Sub bDelete_Click(sender As Object, e As EventArgs) Handles bDelete.Click
        If (lID.Text = "") Then
            MessageBox.Show("Please SELECT JOb Position to Delete")
        Else
            Dim sRt As String = ""
            sRt = ExecuteDML("Delete from tPosition where ID=" + lID.Text)
            If sRt = "True" Then
                MessageBox.Show("JOb Position Deleted Successfully")
                ClearForm()
            Else
                MessageBox.Show("Error : " + sRt)
            End If
        End If
    End Sub

    Private Sub dgvDepartments_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDepartments.CellClick
        If (e.RowIndex >= 0) Then
            lID.Text = dgvDepartments.Rows(e.RowIndex).Cells("cID").Value
            lID.Tag = dgvDepartments.Rows(e.RowIndex).Cells("cID").Value
            tName.Text = dgvDepartments.Rows(e.RowIndex).Cells("cPosition").Value
            tBasicPay.Text = MoneyHelper.ToMoney(dgvDepartments.Rows(e.RowIndex).Cells("cBasicPay").Value)
            cbSalaryGrade.Text = dgvDepartments.Rows(e.RowIndex).Cells("cSalaryGrade").Value
            cbDepartment.SelectedValue = dgvDepartments.Rows(e.RowIndex).Cells("cDeptID").Value
        End If
    End Sub

    Private Sub bSave_Click(sender As Object, e As EventArgs) Handles bSave.Click
        Dim sQuery, sMessage As String
        Try


            If (tName.Text = "") Then
                MessageBox.Show("Please Enter Job Title")
                tName.Focus()
                Exit Sub
            ElseIf (tBasicPay.Text = "") Then
                MessageBox.Show("Please Enter Basic Pay ")
                tBasicPay.Focus()
                Exit Sub
            End If

            Dim value As Decimal
            Dim StrBasicPay As String
            value = MoneyHelper.ToDecimal(tBasicPay.Text)
            StrBasicPay = value.ToString


            If (lID.Tag.ToString() = "0") Then
                sQuery = "Insert into tPosition values('" + tName.Text + "','" + cbSalaryGrade.Text + "'," + StrBasicPay + "," + cbDepartment.SelectedValue.ToString() +
                    ",'" + cbDepartment.Text + "',getdate(),getdate())"
                sMessage = "JOB Position ADDED Successfully"
            Else
                sQuery = "Update tPosition set PositionName='" + tName.Text + "',SalaryGrade = '" + cbSalaryGrade.Text + "',BasicPay=" + StrBasicPay +
                         ",DeptID=" + cbDepartment.SelectedValue.ToString() + ",DeptName='" + cbDepartment.Text +
                             "',modifiedon=getdate() where ID=" + lID.Text
                sMessage = "JOB Position UPDATED Successfully"
            End If

            Dim sRt As String = ""
            sRt = ExecuteDML(sQuery)
            If sRt = "True" Then
                MessageBox.Show(sMessage)
                ClearForm()
            Else
                MessageBox.Show("Error : " + sRt)
            End If
        Catch ex As Exception
            MessageBox.Show("Error : " + ex.Message)
        End Try
    End Sub

    Private Sub dgvDepartments_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDepartments.CellContentClick

    End Sub
End Class