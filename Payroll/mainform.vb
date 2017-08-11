Public Class mainform

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub LinkLabel6_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub LinkLabel7_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

        Login.Show()
        Login.TextBox1.Text = ""
        Login.TextBox2.Text = ""
        Me.Close()

    End Sub

    Private Sub LinkLabel18_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Login.Show()
        Login.TextBox1.Text = ""
        Login.TextBox2.Text = ""
        Me.Close()
    End Sub

    Private Sub LinkLabel8_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub LinkLabel10_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub LinkLabel14_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LinkLabel9_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub LinkLabel11_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub
    Private Sub LinkLabel15_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub LinkLabel20_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub LinkLabel19_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub LinkLabel22_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub LinkLabel13_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub
    Dim pictureSlide As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        pictureSlide = pictureSlide + 1

        If pictureSlide = 1 Then
            PictureBox11.Image = My.Resources._1

        ElseIf pictureSlide = 2 Then
            PictureBox11.Image = My.Resources._2

        ElseIf pictureSlide = 3 Then
            PictureBox11.Image = My.Resources._3

        ElseIf pictureSlide = 4 Then
            PictureBox11.Image = My.Resources._6
        Else
            pictureSlide = 0
        End If
    End Sub

    Private Sub mainform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' ''pictureSlide = pictureSlide + 1

        ' ''If pictureSlide = 1 Then
        ' ''    PictureBox11.Image = My.Resources._1

        ' ''ElseIf pictureSlide = 2 Then
        ' ''    PictureBox11.Image = My.Resources._2

        ' ''ElseIf pictureSlide = 3 Then
        ' ''    PictureBox11.Image = My.Resources._3

        ' ''ElseIf pictureSlide = 4 Then
        ' ''    PictureBox11.Image = My.Resources._6
        ' ''Else
        ' ''    pictureSlide = 0
        ' ''End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim objJob As New ManagePositions
        objJob.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim objDept As New ManageDepartment
        objDept.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)


    End Sub


    Private Sub Button10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs)
        Login.Show()
        Login.TextBox1.Text = "Test"
        Login.TextBox2.Text = "Test"
        Me.Close()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles EmployeeMenu.Click

        If PanelEM.Visible = False Then
            PanelEM.Location = New Point(216, 288)
            PanelEM.Visible = True
            PanelM.Visible = False
            PanelAcc.Visible = False
            PanelProfile.Visible = False
            PanelRpt.Visible = False
        Else
            PanelEM.Visible = False
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Maintenance.Click
        If PanelM.Visible = False Then
            PanelM.Location = New Point(216, 370)
            PanelM.Visible = True
            PanelEM.Visible = False
            PanelAcc.Visible = False
            PanelRpt.Visible = False
            PanelProfile.Visible = False
            PanelRpt.Visible = False
        Else
            PanelM.Visible = False
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs)
 
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Accounting.Click
        If PanelAcc.Visible = False Then
            PanelAcc.Location = New Point(216, 360)
            PanelAcc.Visible = True
            PanelEM.Visible = False
            PanelM.Visible = False
            PanelProfile.Visible = False
            PanelRpt.Visible = False
        Else
            PanelAcc.Visible = False
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Profile.Click
        If PanelProfile.Visible = False Then
            PanelProfile.Location = New Point(216, 445)
            PanelProfile.Visible = True
            PanelEM.Visible = False
            PanelM.Visible = False
            PanelAcc.Visible = False
            PanelRpt.Visible = False
        Else
            PanelProfile.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAddEmp.Click
        Dim objEmployee As New employeelistnew
        objEmployee.Show()
        'Dim objForm As New ManageEmployee
        'objForm.sMyStatus = "NEW"
        'objForm.ShowDialog()
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Login.Show()
        Login.TextBox1.Text = ""
        Login.TextBox2.Text = ""
        Me.Close()
    End Sub

    Private Sub btnServiveRecord_Click(sender As Object, e As EventArgs) Handles btnService.Click
        Dim objForm As New service_record_master
        objForm.Show()
    End Sub

 
    Private Sub btnEditProfile_Click(sender As Object, e As EventArgs) Handles btnEditProfile.Click
        Dim objForm As New ManageEmployee
        objForm.sMyID = iUserID.ToString()
        objForm.sMyStatus = "EDIT"
        objForm.ShowDialog()
    End Sub

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim objComputation As New Payroll_computation
        objComputation.ShowDialog()
    End Sub

    Private Sub bExit_Click(sender As Object, e As EventArgs) Handles bExit.Click
        Application.Exit()
    End Sub

    Private Sub btnAddLoan_Click(sender As Object, e As EventArgs) Handles btnAddLoan.Click
        Dim objLoan As New loan_record_master
        objLoan.ShowDialog()
    End Sub

    Private Sub btnPayslip_Click(sender As Object, e As EventArgs) Handles btnPayslip.Click
        Dim objPayslip As New PayslipNew
        objPayslip.ShowDialog()
    End Sub

    Private Sub Reports_Click(sender As Object, e As EventArgs) Handles Reports.Click
        If PanelRpt.Visible = False Then
            PanelAcc.Location = New Point(216, 360)
            PanelAcc.Visible = False
            PanelEM.Visible = False
            PanelM.Visible = False
            PanelProfile.Visible = False
            PanelRpt.Visible = True
        Else
            PanelRpt.Visible = False
        End If
    End Sub

  
    Private Sub btnMonthlyPayroll_Click(sender As Object, e As EventArgs) Handles btnMonthlyPayroll.Click
        Dim objPayroll As New Monthly_Payroll
        objPayroll.ShowDialog()
    End Sub
End Class