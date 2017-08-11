Public Class ManageDepartment

    Private Sub bClose_Click(sender As Object, e As EventArgs) Handles bClose.Click
        Me.Close()
    End Sub

    Private Sub bClear_Click(sender As Object, e As EventArgs) Handles bClear.Click
        ClearForm()
    End Sub
    Private Sub ClearForm()
        dgvDepartments.DataSource = GetDataAsTable("Select ID,DeptName from tDepartment")
        lID.Tag = "0"
        lID.Text = GetLastID("Select max(ID) from tDepartment")
        tName.Clear()
        tName.Focus()
    End Sub

    Private Sub bDelete_Click(sender As Object, e As EventArgs) Handles bDelete.Click
        If (lID.Text = "") Then
            MessageBox.Show("Please SELECT Department to Delete")
        Else
            Dim sRt As String = ""
            sRt = ExecuteDML("Delete from tDepartment where ID=" + lID.Text)
            If sRt = "True" Then
                MessageBox.Show("Department Deleted Successfully")
                ClearForm()
            Else
                MessageBox.Show("Error : " + sRt)
            End If
        End If
    End Sub

    Private Sub ManageDepartment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearForm()
    End Sub

    Private Sub bSave_Click(sender As Object, e As EventArgs) Handles bSave.Click

        If (tName.Text = "") Then
            MessageBox.Show("Please Enter Department Name ")
            tName.Focus()
            Exit Sub
        End If

        Dim sQuery, sMessage As String
        
        If (lID.Tag.ToString() = "0") Then
            sQuery = "Insert into tDepartment values('" + tName.Text + "',getdate(),getdate())"
            sMessage = "Department ADDED Successfully"
        Else
            sQuery = "Update tDepartment set deptname='" + tName.Text +
                         "',modifiedon=getdate() where ID=" + lID.Text
            sMessage = "Department UPDATED Successfully"
        End If

        Dim sRt As String = ""
        sRt = ExecuteDML(sQuery)
        If sRt = "True" Then
            MessageBox.Show(sMessage)
            ClearForm()
        Else
            MessageBox.Show("Error : " + sRt)
        End If

    End Sub

    Private Sub dgvDepartments_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDepartments.CellClick
        If (e.RowIndex >= 0) Then
            lID.Text = dgvDepartments.Rows(e.RowIndex).Cells("cID").Value
            lID.Tag = dgvDepartments.Rows(e.RowIndex).Cells("cID").Value
            tName.Text = dgvDepartments.Rows(e.RowIndex).Cells("cName").Value
        End If
    End Sub
End Class