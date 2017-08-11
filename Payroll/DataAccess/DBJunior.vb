Imports System.Data.SqlClient
Imports System.Xml

Module DBJunior
    Public mySQLConnection As String
    Public iUserID As Integer
    Public sUserName As String
    Public sProjectTitle As String

    Public Sub InitialSettings()
        Dim rdrInfo As XmlReader

        rdrInfo = XmlReader.Create("myServers.xml", New XmlReaderSettings())
        Dim dsGet As DataSet = New DataSet()
        dsGet.ReadXml(rdrInfo)
        Dim DBSserver, DB, DBUser, DBPassword As String

        DBSserver = dsGet.Tables(0).Rows(0).ItemArray(0).ToString().Replace("\n", "")
        DB = dsGet.Tables(0).Rows(0).ItemArray(1).ToString().Replace("\n", "")
        DBUser = dsGet.Tables(0).Rows(0).ItemArray(2).ToString().Replace("\n", "")
        DBPassword = dsGet.Tables(0).Rows(0).ItemArray(3).ToString().Replace("\n", "")

        rdrInfo.Close()
        dsGet.Dispose()
        mySQLConnection = String.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3}", DBSserver, DB, DBUser, DBPassword)
        sProjectTitle = "National Commition of Indegenous People"

    End Sub
    Public Function ExecuteDML(sDMLQry As String) As String
        Dim bReturn As String = "False"

        Dim myCon As SqlConnection = New SqlConnection(mySQLConnection)
        Try
            myCon.Open()

            Dim myCmd As New SqlCommand
            Dim sInsert As String = sDMLQry

            myCmd.Connection = myCon
            myCmd.CommandText = sInsert

            myCmd.ExecuteNonQuery()
            myCon.Close()
            myCon.Dispose()

            bReturn = "True"

        Catch ex As Exception
            bReturn = "Error " + ex.Message
        Finally
            If (myCon.State = ConnectionState.Open) Then
                myCon.Close()
            End If
            myCon.Dispose()
        End Try

        Return bReturn

    End Function
    Public Function ExecuteWithValue(sDMLQry As String) As String
        Dim sReturn As String = "0"

        Dim myCon As SqlConnection = New SqlConnection(mySQLConnection)
        Try
            myCon.Open()

            Dim myCmd As New SqlCommand
            Dim sInsert As String = sDMLQry

            myCmd.Connection = myCon
            myCmd.CommandText = sInsert

            sReturn = myCmd.ExecuteScalar()
            myCon.Close()
            myCon.Dispose()

        Catch ex As Exception
            sReturn = "Error : " + ex.Message
        Finally
            If (myCon.State = ConnectionState.Open) Then
                myCon.Close()
            End If
            myCon.Dispose()
        End Try

        Return sReturn

    End Function
    Public Function GetDataAsTable(sSelectQry As String) As DataTable
        Dim returnTable As DataTable

        Dim myCon As SqlConnection = New SqlConnection(mySQLConnection)
        Try
            Dim myCmd As SqlCommand = New SqlCommand()
            myCmd.Connection = myCon
            myCmd.CommandText = sSelectQry
            Dim myAda As SqlDataAdapter = New SqlDataAdapter(myCmd)
            Dim myDS As New DataSet
            Dim myTable As DataTable
            myAda.Fill(myDS)
            myTable = myDS.Tables(0)

            returnTable = myTable

        Catch ex As Exception
            Throw ex
        Finally
            If (myCon.State = System.Data.ConnectionState.Open) Then
                myCon.Close()
            End If
            myCon.Dispose()
        End Try
        Return returnTable
    End Function
    Public Function GetLastID(sSQL As String) As String
        Dim sReturnValue As String = "1"

        Dim myCon As SqlConnection = New SqlConnection(mySQLConnection)
        Try
            myCon.Open()
            Dim oCmd As SqlCommand = New SqlCommand()
            oCmd.Connection = myCon
            oCmd.CommandText = sSQL
            Dim sReturn As String
            sReturn = oCmd.ExecuteScalar().ToString()

            If (sReturn <> "") Then
                sReturnValue = (Convert.ToInt32(sReturn) + 1).ToString()
            End If

        Catch ex As Exception
            sReturnValue = "Error : " + ex.Message
        Finally
            If (myCon.State = System.Data.ConnectionState.Open) Then
                myCon.Close()
            End If
            myCon.Dispose()
        End Try
        Return sReturnValue
    End Function
    Public Function GetAStringValue(sSQL As String) As String
        Dim sReturnValue As String = "N/A"

        Dim myCon As SqlConnection = New SqlConnection(mySQLConnection)
        Try
            myCon.Open()
            Dim oCmd As SqlCommand = New SqlCommand()
            oCmd.Connection = myCon
            oCmd.CommandText = sSQL

            sReturnValue = oCmd.ExecuteScalar().ToString()

        Catch ex As Exception
            sReturnValue = "Error : " + ex.Message
        Finally
            If (myCon.State = System.Data.ConnectionState.Open) Then
                myCon.Close()
            End If
            myCon.Dispose()
        End Try
        Return sReturnValue
    End Function
    Public Function IsRecordExist(sSQL As String) As Boolean
        Dim bReturnValue As Boolean = False
        Dim sReturn As String = 0

        Dim myCon As SqlConnection = New SqlConnection(mySQLConnection)
        Try
            myCon.Open()
            Dim oCmd As SqlCommand = New SqlCommand()
            oCmd.Connection = myCon
            oCmd.CommandText = sSQL

            sReturn = oCmd.ExecuteScalar().ToString()
            If Convert.ToInt16(sReturn) > 0 Then
                bReturnValue = True
            End If
        Catch ex As Exception
            bReturnValue = False
        Finally
            If (myCon.State = System.Data.ConnectionState.Open) Then
                myCon.Close()
            End If
            myCon.Dispose()
        End Try
        Return bReturnValue
    End Function
    Public Function ReadData(ByVal sSQL As String) As String

        Dim sReturnValue As String = ""

        Dim myCon As SqlConnection = New SqlConnection(mySQLConnection)

        Try
            myCon.Open()
            Dim sqlCmd As SqlCommand = New SqlCommand()
            sqlCmd.Connection = myCon
            sqlCmd.CommandText = sSQL
            Dim myData As SqlDataReader
            myData = sqlCmd.ExecuteReader
            sReturnValue = myData.ToString
        Catch ex As Exception
            sReturnValue = "Error : " + ex.Message
        Finally
            If (myCon.State = System.Data.ConnectionState.Open) Then
                myCon.Close()
            End If
            myCon.Dispose()
        End Try

        Return sReturnValue
    End Function

    Public Function GetFieldValue(ByVal srcSQL As String, ByVal strField As String)

        Dim myCon As SqlConnection = New SqlConnection(mySQLConnection)
        Try
            myCon.Open()
            Dim cmd As SqlCommand = New SqlCommand()
            cmd.Connection = myCon
            cmd.CommandText = srcSQL
            'create data reader
            Dim rdr As SqlDataReader = cmd.ExecuteReader

            'loop through result set
            rdr.Read()

            If rdr.HasRows Then GetFieldValue = rdr(strField).ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If (myCon.State = System.Data.ConnectionState.Open) Then
                myCon.Close()
            End If
            myCon.Dispose()
        End Try

    End Function
End Module
