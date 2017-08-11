Public Class DailyTimeRecord
    Private _dataTable As DataTable
    Private Sub New()
        Try
            'all list
            _dataTable = GetDataAsTable("SELECT att_id,emp_id,time_in,time_out,reg_hr,OT,ND,att_date,status FROM tbl_AttPayroll")
        Catch ex As Exception

        End Try

    End Sub

    Public Property DTRList As DataTable
        Get
            Return _dataTable
        End Get
        Set(value As DataTable)
            _dataTable = value
        End Set
    End Property
End Class
