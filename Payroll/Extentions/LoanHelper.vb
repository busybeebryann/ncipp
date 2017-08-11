Imports WindowsApplication1.Enums
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace Extensions
    Public NotInheritable Class LoanHelper
        Public Shared Function IsGSISLoan(ByRef ltype As GSIS) As Boolean

            Select Case ltype
                Case GSIS.Policy
                    Return True
                Case GSIS.Educational
                    Return True
                Case GSIS.Conso
                    Return True
                Case GSIS.Emergency
                    Return True
                Case Else
                    Return False

            End Select
        End Function
        Public Shared Function IsHDMFLoan(ByRef ltype As HDMF) As Boolean
            Select Case ltype

                Case HDMF.Housing
                    Return True
                Case HDMF.Mandatory
                    Return True
                Case Else
                    Return False

            End Select
        End Function
        Public Shared Function IsLBPLoan(ByRef ltype As LBP) As Boolean
            Select Case ltype

                Case LBP.Mandatory
                    Return True
                Case Else
                    Return False

            End Select
        End Function
        Public Shared Function IsNCIPEALoan(ByRef ltype As NCIPEA) As Boolean
            Select Case ltype

                Case NCIPEA.Mandatory
                    Return True
                Case Else
                    Return False
            End Select
        End Function
        Public Shared Function IsZeroBalance(ByVal sField As String, Optional ByVal sEmpId As String = "") As Boolean
            Dim sValue As Decimal
            Dim sSql As String
            If sEmpId = "" Then
                sSql = String.Format("SELECT {0} FROM tLoan", sField)
            Else
                sSql = String.Format("SELECT {0} FROM tLoan WHERE EmployeeID ='{1}'", sField, sEmpId)
            End If

            sValue = GetFieldValue(sSql, sField)
            If sValue = 0.0 Then
                Return True
            Else
                Return False
            End If
        End Function
    End Class
 
End Namespace
