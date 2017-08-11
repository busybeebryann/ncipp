Imports System.Data
Imports System.Data.SqlClient

Public Class Login
    Dim objSettings As New GlobalSettings
    Dim acsconn As New SqlConnection
    Dim acsdr As SqlDataReader
    Dim strsql As String
    Dim a_lvl As String
    Dim id As String
    Dim a As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        TextBox1.Text = TextBox1.Text.Replace("'", "")
        TextBox2.Text = TextBox2.Text.Replace("'", "")
        a = a + 1
        Dim objSettings1 As New GlobalSettings
        Panel1.Visible = False
        Dim con As New SqlConnection(mySQLConnection)
        Dim cmd As SqlCommand = New SqlCommand("SELECT * FROM tbl_logindetails WHERE user_name = '" & TextBox1.Text & "' AND pass_word = '" & TextBox2.Text & "'", con)
        con.Open()
        Dim sdr As SqlDataReader = cmd.ExecuteReader()

        If (sdr.Read() = True) Then
            Panel1.Visible = True
            Label2.Visible = False
            Try
                acsconn.ConnectionString = mySQLConnection
                acsconn.Open()
                strsql = "SELECT * from tbl_user U JOIN tbl_logindetails L ON U.user_id=L.empid WHERE L.user_name = '" + TextBox1.Text + "'"
                Dim acscmdr As New SqlCommand
                acscmdr.CommandText = strsql
                acscmdr.Connection = acsconn
                acsdr = acscmdr.ExecuteReader
                While (acsdr.Read())
                    a_lvl = acsdr("access_lvl")
                    a_lvl = a_lvl.Trim

                    iUserID = acsdr("empid")
                    sUserName = acsdr("first_name").trim + " " + acsdr("last_name").trim

                    mainform.Label1.Text = sUserName
                    mainform.Label2.Text = acsdr("job_pos").trim

                    mainform.Label3.Text = acsdr("first_name").trim + " " + acsdr("last_name").trim
                    mainform.Label5.Text = acsdr("job_pos").trim
                    
                    id = iUserID
                    id = id.Trim
                    Try
                        mainform.PictureBox2.Image = Image.FromFile(Application.StartupPath & "\images\" + id + ".jpg")
                        mainform.PictureBox9.Image = Image.FromFile(Application.StartupPath & "\images\" + id + ".jpg")
                    Catch ex As Exception
                        mainform.PictureBox2.Image = Image.FromFile(Application.StartupPath & "\images\default.png")
                        mainform.PictureBox9.Image = Image.FromFile(Application.StartupPath & "\images\default.png")
                    End Try

                    If (a_lvl = "1") Then

                        mainform.Panel7.Visible = False
                        mainform.Panel1.BringToFront()
                        mainform.Panel1.Visible = True
                    Else

                        mainform.Panel1.Visible = False
                        mainform.Panel7.BringToFront()
                        mainform.Panel7.Visible = True
                    End If

                End While
                acscmdr.Dispose()
                acsdr.Close()
                acsconn.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            mainform.Show()
            Me.Hide()

        Else
            Label2.Visible = True
            Panel1.Visible = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = TimeOfDay
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitialSettings()

        Timer1.Start()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Manual_Attendance.Show()
    End Sub
    Private Sub TextBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.GotFocus
        If TextBox1.Text = "Username" Then
            TextBox1.ForeColor = Color.Black
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus
        If TextBox1.Text = "" Then
            TextBox1.ForeColor = Color.Gray
            TextBox1.Text = "Username"
        Else
            TextBox1.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBox2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.GotFocus
        If TextBox2.Text = "Password" Then
            TextBox2.ForeColor = Color.Black
            TextBox2.Text = ""
        End If
    End Sub

    Private Sub TextBox2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.LostFocus
        If TextBox2.Text = "" Then
            TextBox2.ForeColor = Color.Gray
            TextBox2.Text = "Password"
        Else
            TextBox2.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub


End Class
