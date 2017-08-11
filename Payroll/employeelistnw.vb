Imports System.Data.SqlClient
Imports System.Data

Public Class employeelistnew
    Dim objSettings As New GlobalSettings
    Dim conn As New SqlConnection(objSettings.GlobalStringConnetion)
    Dim conn2 As New SqlConnection()
    Dim da As SqlDataAdapter = Nothing
    Dim dt As New DataTable
    Dim SQL As String = ""

    Private Sub employeelistnew_load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtgv()
        'pos()
        'dept()
    End Sub
    Public Sub dtgv()
        dt.Clear()
        DataGridView1.DataSource = Nothing
        DataGridView1.RowHeadersVisible = False
        Try
            SQL = "SELECT user_id,emp_id AS Employee_id,last_name,first_name,address,b_date,c_no,TAX,lbp_number,gsis_no,pol_number,bp_number,pagibig,philhealth,date_hired,status from tbl_user WHERE  emp_id LIKE '%" + TextBox1.Text + "%' OR last_name LIKE '%" + TextBox1.Text + "%'  "
            conn.Open()
            da = New SqlDataAdapter(SQL, conn)
            da.Fill(dt)
            conn.Close()
            DataGridView1.DataSource = dt
            DataGridView1.CurrentCell = Nothing
            DataGridView1.Columns(0).Visible = False

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub
    Dim acsconn As New SqlConnection
    Dim acsdr As SqlDataReader
    Dim strsql As String
    ''  Dim name As String
    Dim combo As String
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        _employeeid = DataGridView1.CurrentCell.Value.ToString

    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        dtgv()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim newe As New Add_Employee
        newe.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles bClose.Click
        'mainform.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles bRefresh.Click
        dtgv()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles bAdd.Click
        Dim objForm As New ManageEmployee
        objForm.sMyStatus = "NEW"
        objForm.ShowDialog()

        ''Dim newe As New Add_Employee
        ''With newe
        ''    .FormMode = 0
        ''    .Show()
        ''End With
        dtgv()
    End Sub
    Private _employeeid As String
    Public Property EmployeeID() As String
        Get
            Return _employeeid
        End Get
        Private Set(ByVal value As String)
            _employeeid = value
        End Set
    End Property
    Public Sub DatagridView1_CellClick(sender As Object, e As EventArgs) Handles DataGridView1.CellClick

    End Sub

    Private Sub bUpdate_Click(sender As Object, e As EventArgs) Handles bUpdate.Click
        EditEmployeeDetails()
    End Sub
    Private Sub EditEmployeeDetails()
        If (DataGridView1.CurrentRow.Index < 0) Then
            MessageBox.Show("Please Select a employee", sProjectTitle)
            Exit Sub
        End If

        Dim iEmployeeId As String = ""
        iEmployeeId = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        Dim objForm As New ManageEmployee
        objForm.sMyID = iEmployeeId
        objForm.sMyStatus = "EDIT"
        objForm.ShowDialog()
    End Sub
    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        EditEmployeeDetails()
    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class