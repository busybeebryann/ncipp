Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace Extensions
    Public NotInheritable Class MoneyHelper

        Public Shared Function ToDecimal(amount As String) As Decimal
            Return Decimal.Parse(amount)
        End Function


        Public Shared Function ToDouble(amount As String) As Double
            Return Double.Parse(amount)
        End Function

        Public Shared Function ToMoney(ByVal srcCurr As String) As String
            ToMoney = Format(IIf(Trim(srcCurr) = "", 0, CSng(srcCurr)), "#,##0.00")
        End Function

    End Class
End Namespace

