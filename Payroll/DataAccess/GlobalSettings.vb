Imports System.Data.SqlClient
'Imports Word = Microsoft.Office.Interop.Word
Imports System.Runtime.InteropServices
Imports System.Net.Mail
Imports System.Text
Imports System.Xml
Imports System.Text.RegularExpressions

Public Class GlobalSettings

    Public ds As New DataSet
    Public da As New SqlDataAdapter
    Public sqlcon As New SqlConnection
    Public sqlcom As New SqlCommand
    Public reader As SqlDataReader
    Public errorlist As List(Of String)
    Public RefNo As String
    Public ControlNo As String
    Public sent As String

    Public LoggedBy As String
    Public TemplateName As String
    Public pYear As Date
    Public pDay As Date
    Public pMonth As Date

    Public timestamp As DateTime
    Public start As Date
    Public Endate As Date
    Public DBSserver As String = "(Local)/SQLEXPRESS"
    Public DB As String = "payroll_db"
    Public DBUser As String = "sa"
    Public DBPassword As String = "mainpass"
    Public GlobalStringConnetion As String
    Public SQLConnectionString As String
    Public GlobalsConnString As String
    Public amountPERA As Decimal = 2000
    Public Mode As Integer

    Public Sub New()

        SQLConnectionString = mySQLConnection
        GlobalStringConnetion = mySQLConnection
        GlobalsConnString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\report.accdb"
    End Sub
    Public Sub EmptyForm(ByVal Frm As Form)
        Dim Ctl As Control
        For Each Ctl In Frm.Controls
            If TypeOf Ctl Is TextBox Then Ctl.Text = ""
            If TypeOf Ctl Is GroupBox Then
                Dim Ctl1 As Control
                For Each Ctl1 In Ctl.Controls
                    If TypeOf Ctl1 Is TextBox Then
                        Ctl1.Text = ""
                    End If
                Next
            End If
        Next
    End Sub

    Private _name As String
    Public Property Bryann() As String
        Get
            Return _name
        End Get
        Private Set(ByVal value As String)
            _name = value
        End Set
    End Property
    Public Function validateEmail(ByVal emailAddress) As Boolean
        ' Dim email As New Regex("^(?<user>[^@]+)@(?<host>.+)$")
        Dim email As New Regex("([\w-+]+(?:\.[\w-+]+)*@(?:[\w-]+\.)+[a-zA-Z]{2,7})")
        If email.IsMatch(emailAddress) Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
