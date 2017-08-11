Imports WindowsApplication1.Enums
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Data
Imports Microsoft.VisualBasic

Namespace Extensions
    Public NotInheritable Class DateHelper
        Public Shared Function CurrentMonthName(dt As DateTime) As String
            Return DateHelper.GetMonthName(dt.Month)
        End Function
        Public Shared Function FirstDayOfMonth(dt As DateTime) As DateTime
            Return New DateTime(dt.Year, dt.Month, 1)
        End Function
        Public Shared Function GetMonthName(month As Integer) As String
            Return [Enum].GetName(GetType(Month), month)
        End Function
        Public Shared Function LastDayCurrentMonth(dt As DateTime) As DateTime
            Return dt.AddMonths(1).AddDays(-1)
        End Function
        Public Shared Function NumberOfMonthsByDate(dtStart As Date, dtEnd As Date) As Decimal
            Dim tNumber As Object = DateDiff(DateInterval.Month, dtStart, dtEnd)
            Return tNumber
        End Function
        Public Shared Function NumberOfDaysByDate(dtStart As Date, dtEnd As Date)
            Dim tNumber As Object = DateDiff(DateInterval.Day, dtStart, dtEnd)
            If tNumber <= 0 Then
                tNumber = 1
            Else
                tNumber += 1
            End If
            Return tNumber
        End Function
        Public Shared Function NumberOfWeeksByDate(dtStart As Date, dtEnd As Date)
            Dim tNumber As Object = DateDiff(DateInterval.Weekday, dtStart, dtEnd)
            Return tNumber
        End Function
        Public Shared Function DefaultEndDate(dtStart As Date)
            Dim tDate As Date = DateAdd(DateInterval.Month, 24, dtStart)
            Return tDate
        End Function
        Public Shared Function YearsBetweenDates(ByVal StartDate As DateTime, ByVal EndDate As DateTime) As Integer
            ' Returns the number of years between the passed dates
            If DateAndTime.Month(EndDate) < DateAndTime.Month(StartDate) Or _
               (DateAndTime.Month(EndDate) = DateAndTime.Month(StartDate) And _
               (EndDate.Day) < (StartDate.Day)) Then
                Return Year(EndDate) - Year(StartDate) - 1
            Else
                Return Year(EndDate) - Year(StartDate)
            End If
        End Function

    End Class
End Namespace
