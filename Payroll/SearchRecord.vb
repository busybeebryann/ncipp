Public Class SearchRecord
    Public Property sSearchQry As String = ""
    Public Property sSearchKey As String = ""
    Public Property sSearchOrder As String = ""
    Public Property sSearchedID As String = ""

    Private Sub SearchRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillGrid(sSearchQry + " " + sSearchOrder)
    End Sub
    Private Sub FillGrid(sQuery As String)

        Try
            dataGridView1.DataSource = GetDataAsTable(sQuery)
            If (dataGridView1.Columns.Count > 0) Then
                dataGridView1.Columns(0).Visible = False
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtKey_TextChanged(sender As Object, e As EventArgs) Handles txtKey.TextChanged
        FillGrid(sSearchQry + " and " + sSearchKey + " like '%" + txtKey.Text.Replace("'", "") + "%'" + sSearchOrder)
    End Sub

    Private Sub SearchRecord_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub txtKey_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKey.KeyDown
        If (e.KeyCode = Keys.Down) Then dataGridView1.Focus()
    End Sub

    Private Sub dataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridView1.CellDoubleClick
        sSearchedID = dataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()
        Me.Close()
    End Sub

    Private Sub dataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles dataGridView1.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            sSearchedID = dataGridView1.Rows(dataGridView1.CurrentCell.RowIndex).Cells(0).Value.ToString()
            Me.Close()
        End If
    End Sub
End Class