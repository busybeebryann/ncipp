Public Class TestForm
    Private Sub TestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitialSettings()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim objLoan As New loan_record_master
        objLoan.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim objLoan As New Payroll_computation
        objLoan.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim objLoan As New AttendanceTracker
        objLoan.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim objLoan As New Manual_Attendance
        objLoan.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim objLoan As New Monthly_Payroll
        objLoan.ShowDialog()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim objLoan As New PayrollDateRange
        objLoan.ShowDialog()
    End Sub

    Private Sub btnJobPos_Click(sender As Object, e As EventArgs) Handles btnJobPos.Click
        Dim objLoan As New ManagePositions
        objLoan.ShowDialog()
    End Sub

    Private Sub btnEmployee_Click(sender As Object, e As EventArgs) Handles btnEmployee.Click
        Dim objForm As New employeelistnew
        objForm.ShowDialog()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnMLeaves.Click
        Dim objForm As New ManageLeaves
        objForm.ShowDialog()
    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        Dim objForm As New LeaveLedgerReport
        objForm.ShowDialog()
    End Sub
End Class