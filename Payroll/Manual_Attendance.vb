Imports System.Data.SqlClient
Public Class Manual_Attendance
    Dim objSettings As New GlobalSettings
    Dim acsconn As New SqlConnection
    Dim acsdr As SqlDataReader
    Dim strsql As String
    Private Sub Manual_Attendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        lDateToday.Text = Date.Now.ToString("yyyy-M-dd")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lTimeToday.Text = TimeOfDay
    End Sub
    Dim nameemp As String
    Private Sub btnTimeIn_Click(sender As Object, e As EventArgs) Handles btnTimeIn.Click

        If txtEmpId.Text = "" And txtPassword.Text = "" Then
            MsgBox("Please fill in all the fields.", MsgBoxStyle.Exclamation, "NCIP-CAR")

        Else

            acsconn.ConnectionString = objSettings.GlobalStringConnetion
            Dim strGetSQL As String
            strGetSQL = String.Format("SELECT * FROM tbl_logindetails WHERE emp_id='{0}' AND pass_word='{1}'", txtEmpId.Text, txtPassword.Text)
            Dim cmd As SqlCommand = New SqlCommand(strGetSQL, acsconn)
            If acsconn.State() = ConnectionState.Open Then
                acsconn.Close()

            End If
            acsconn.Open()
            Dim sdr As SqlDataReader = cmd.ExecuteReader()
            cmd.Connection = acsconn
            If (sdr.Read() = True) Then
                If acsconn.State = ConnectionState.Closed Then
                    acsconn.Open()

                End If
                sdr.Close()
                strsql = String.Format("SELECT * from tbl_user JOIN tbl_logindetails ON tbl_user.emp_id = tbl_logindetails.emp_id WHERE tbl_user.emp_id = '{0}'", txtEmpId.Text)
                Dim acscmdr As New SqlCommand
                acscmdr.CommandText = strsql
                acscmdr.Connection = acsconn
                acsdr = acscmdr.ExecuteReader

                While (acsdr.Read())
                    nameemp = acsdr("first_name").trim + " " + acsdr("middle_name").trim + ". " + acsdr("last_name").trim
                End While

                acscmdr.Dispose()
                acsdr.Close()
                acsconn.Close()


                acsconn.ConnectionString = objSettings.GlobalStringConnetion & ";MultipleActiveResultSets=True"
                Dim cmdLs As SqlCommand = New SqlCommand("SELECT * FROM tAttendance WHERE emp_id = '" + txtEmpId.Text + "' AND att_date = '" & lDateToday.Text & "'", acsconn)
                acsconn.Open()
                Dim sdrLs As SqlDataReader = cmdLs.ExecuteReader()
                If (sdrLs.Read() = True) Then
                    MsgBox("Already Timed In! If you want to Time out press the Time Out Button.")

                ElseIf (sdrLs.Read() = False) Then

                    Dim cmds As SqlCommand = New SqlCommand("SELECT * FROM tbl_logindetails WHERE user_name='" + txtEmpId.Text + "' AND pass_word='" + txtPassword.Text + "'", acsconn)

                    If acsconn.State = ConnectionState.Closed Then
                        acsconn.Open()
                    End If

                    Try
                        Dim SqlCommand As New SqlCommand
                        Dim SqlQuery As String = "INSERT INTO tAttendance ([emp_id],[att_date],[stime_in],[time_in],[time_out],[reg_hr],[OT],[ND],[status],createdon,modifiedon) VALUES ('" + txtEmpId.Text + "','" + lDateToday.Text + "','" + lTimeToday.Text + "','" + String.Format(lTimeToday.Text, "H'h 'm'm 's's'") + "','" + lTimeToday.Text + "','" + "0" + "','" + "0" + "','" + "0" + "','" + "0" + "',getdate(),getdate())"
                        With SqlCommand
                            .CommandText = SqlQuery
                            .Connection = acsconn
                            .ExecuteNonQuery()
                            txtEmpId.Text = ""
                            txtPassword.Text = ""
                        End With
                        MessageBox.Show("Time In Successful! Welcome " + nameemp + "! Have a nice day.")
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                    acsconn.Close()
                Else
                    MsgBox("Wrong Employee ID")
                    txtEmpId.Text = ""
                    txtPassword.Text = ""
                End If
            End If
        End If
    End Sub
    Dim NH As String
    Dim OT As String
    Dim ND As String
    Dim realval As Integer
    Dim d1 As DateTime
    Dim d2 As DateTime
    Private Sub btnTimeOut_Click(sender As Object, e As EventArgs) Handles btnTimeOut.Click

        If txtEmpId.Text = "" And txtPassword.Text = "" Then
            MsgBox("Please fill in all the fields.", MsgBoxStyle.Exclamation, "NCIP-CAR")

        Else

            Try
                acsconn.ConnectionString = objSettings.GlobalStringConnetion
                acsconn.Open()
                strsql = String.Format("SELECT * from tAttendance WHERE emp_id = '{0}'", txtEmpId.Text)
                Dim acscmdr As New SqlCommand
                acscmdr.CommandText = strsql
                acscmdr.Connection = acsconn
                acsdr = acscmdr.ExecuteReader
                While (acsdr.Read())
                    dptIN.Text = acsdr("time_in")
                End While
                acscmdr.Dispose()
                acsdr.Close()
                acsconn.Close()
            Catch ex As Exception
                'MsgBox(ex.ToString)
            End Try

            d1 = dptIN.Text
            d2 = dtpOUT.Text

            realval = DateDiff("s", d1, d2) / 60 / 60

            If realval < 0.1 Then
                realval = 0
            End If

            If realval >= 9 Then
                NH = "8"
                OT = Val(realval) - 9
                ND = "0"
            ElseIf dptIN.Text >= #10:00:00 PM# Then
                realval = DateDiff("s", d2, d1)

                realval = Val(realval) / 60 / 60 / 2

                If realval >= 9 Then
                    ND = "8"
                    OT = Val(realval) - 9
                    NH = "0"
                ElseIf realval < 9 Then
                    ND = realval
                    OT = "0"
                    NH = "0"
                End If
            Else
                NH = realval
                OT = "0"
                ND = "0"
            End If


            Try
                Dim provider As String = objSettings.GlobalStringConnetion
                Dim con As New SqlConnection
                con.ConnectionString = provider
                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If
                Dim SqlCommand As New SqlCommand
                Dim SqlQuery As String = "UPDATE tAttendance SET stime_out = '" + String.Format(dtpOUT.Text, "H'h 'm'm 's's'") + "',time_out='" + dtpOUT.Text + "',reg_hr='" + NH + "', OT='" + OT + "',ND='" + ND + "',modifiedon = getdate() WHERE emp_id='" + txtEmpId.Text + "'"
                With SqlCommand
                    .CommandText = SqlQuery
                    .Connection = con
                    .ExecuteNonQuery()
                End With
                con.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)

            End Try
            MessageBox.Show("Successfully timed out for employee number " + txtEmpId.Text + "!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class