Imports System.IO
Public Class FrmMDI
  

    Private Sub ChangePasswordToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePasswordToolStripMenuItem1.Click
        Dim fc As New Frmchngpass
        fc.MdiParent = Me
        fc.Show()
    End Sub

    Private Sub CreateNewUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateNewUserToolStripMenuItem.Click
        Dim cu As New frmnewuser
        cu.MdiParent = Me
        cu.Show()
    End Sub

    Private Sub DealerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DealerToolStripMenuItem.Click
        Dim d As New DealerMaster
        d.MdiParent = Me
        d.Show()
    End Sub

    Private Sub DoctorToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DoctorToolStripMenuItem2.Click
        Dim dm As New Doctor_Master
        dm.MdiParent = Me
        dm.Show()
    End Sub
    Private Sub EquipmentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EquipmentToolStripMenuItem.Click
        Dim eqp As New EquipmentMaster
        eqp.MdiParent = Me
        eqp.Show()
    End Sub
    Private Sub EmployeeToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeToolStripMenuItem2.Click
        Dim em As New Employee_Master
        em.MdiParent = Me
        em.Show()
    End Sub

    Private Sub ChemicalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChemicalToolStripMenuItem.Click
        Dim cm As New Chemical_Master
        cm.MdiParent = Me
        cm.Show()
    End Sub

    Private Sub PatientToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PatientToolStripMenuItem1.Click
        Dim pm As New Patient_Master
        pm.MdiParent = Me
        pm.Show()
    End Sub
    Private Sub EmployeeAttendenceToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeAttendenceToolStripMenuItem1.Click
        Dim ea As New FrmEmpAttendence
        ea.MdiParent = Me
        ea.Show()
    End Sub

    Private Sub EmployeePaymentToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeePaymentToolStripMenuItem1.Click
        Dim ep As New FrmEmpPayment
        ep.MdiParent = Me
        ep.Show()
    End Sub

    Private Sub PatientCheckupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PatientCheckupToolStripMenuItem.Click
        Dim pc As New Patient_Checkup
        pc.MdiParent = Me
        pc.Show()
    End Sub

    Private Sub TestReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TestReportToolStripMenuItem.Click
        Dim ep1 As New Reports
        ep1.MdiParent = Me
        ep1.Show()
    End Sub

    Private Sub ReportForwordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportForwordToolStripMenuItem.Click
        Dim fp As New ReportForward
        fp.MdiParent = Me
        fp.Show()
    End Sub

    Private Sub ReportInwardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportInwardToolStripMenuItem.Click
        Dim ip As New ReportInward
        ip.MdiParent = Me
        ip.Show()
    End Sub

    Private Sub PurchaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseToolStripMenuItem.Click
        Dim p As New Purchase
        p.MdiParent = Me
        p.Show()
    End Sub

   
    Private Sub BillToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BillToolStripMenuItem.Click
        Dim b As New Bill
        b.MdiParent = Me
        b.Show()
    End Sub

   
    Private Sub PatikupentChecToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim rp As New rptPatCheckup
        rp.MdiParent = Me
        rp.Show()

    End Sub

    Private Sub EmployeeDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim re As New rptEmpPayment
        re.MdiParent = Me
        re.Show()
    End Sub


    Private Sub ReportForwardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim rf As New rptForward
        rf.MdiParent = Me
        rf.Show()

    End Sub

    Private Sub TestReportToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim rt As New rptTest
        rt.MdiParent = Me
        rt.Show()
    End Sub

    Private Sub BillToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim rb As New rptTotalBill
        rb.MdiParent = Me
        rb.Show()
    End Sub

    Private Sub ExpencesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim rex As New rptExpence
        rex.MdiParent = Me
        rex.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        If MsgBox("Do You want to Exit ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            End
        End If
    End Sub

   

    Private Sub AdminToolStripMenuItem_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles AdminToolStripMenuItem.MouseHover
        lblstatus.Text = "Admin"
    End Sub

    Private Sub MasterToolStripMenuItem_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles MasterToolStripMenuItem.MouseHover
        lblstatus.Text = "Master"
    End Sub


    Private Sub EmployeeToolStripMenuItem3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles EmployeeToolStripMenuItem3.MouseHover
        lblstatus.Text = "Employee"
    End Sub

  Private Sub DoctorToolStripMenuItem3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles DoctorToolStripMenuItem3.MouseHover
        lblstatus.Text = "Doctor"
    End Sub

    Private Sub TransactionsToolStripMenuItem_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles TransactionsToolStripMenuItem.MouseHover
        lblstatus.Text = "Transaction"
    End Sub

       Private Sub ReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportsToolStripMenuItem.Click

    End Sub


   

    Private Sub PurchaseDetailsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim rpd As New rptPurDetails
        rpd.MdiParent = Me
        rpd.Show()
    End Sub

    Private Sub TestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TestToolStripMenuItem.Click
        Dim tst As New TestMaster
        tst.MdiParent = Me
        tst.Show()
    End Sub

    Private Sub DiseaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiseaseToolStripMenuItem.Click
        Dim ds As New DiseaseMaster
        ds.MdiParent = Me
        ds.Show()
    End Sub
   
   
    Private Sub BackUpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackUpToolStripMenuItem.Click
        ' Try
        Dim sr As StreamReader

        sr = File.OpenText("C:\Users\Htc\Documents\Visual Studio 2008\Projects\Pathology\Pathology\patholabDB.mdf")
        Dim s As String = sr.ReadToEnd()
        Dim sw As StreamWriter = File.CreateText("D:\Backup\patholabDB.mdf")
        sw.Write(s)
        sr.Close()
        sw.Close()
        MsgBox("Backup Successfully Stored!!!", MsgBoxStyle.Information)


        'Catch ex As Exception


            'End Try
    End Sub

    Private Sub RestoreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestoreToolStripMenuItem.Click
        Try

            Dim sr As StreamReader

            sr = System.IO.File.OpenText("D:\Backup\patholabDB.mdf")
            Dim s As String = sr.ReadToEnd()

            Dim sw As StreamWriter = File.CreateText("C:\Users\Htc\Documents\Visual Studio 2008\Projects\Pathology\Pathology\patholabDB.mdf")

            sw.Write(s)
            sr.Close()
            sw.Close()
            MsgBox("Backup Successfully Restored!!!", MsgBoxStyle.Information)

        Catch ex As Exception


        End Try

    End Sub
  
    Private Sub StockToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockToolStripMenuItem1.Click
        Dim stk As New StockMaster
        stk.MdiParent = Me
        stk.Show()
    End Sub

    Private Sub ExpencesToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExpencesToolStripMenuItem2.Click
        Dim e1 As New frmExpences
        e1.MdiParent = Me
        e1.Show()
    End Sub

    Private Sub ChemicalUsedDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChemicalUsedDetailsToolStripMenuItem.Click
        Dim cu As New ChemicalUsed
        cu.MdiParent = Me
        cu.Show()
    End Sub


    Private Sub PatikupentChecToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PatikupentChecToolStripMenuItem.Click
        Dim rp As New rptPatCheckup
        rp.MdiParent = Me
        rp.Show()
    End Sub

    Private Sub PurchaseDetailsToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseDetailsToolStripMenuItem1.Click
        Dim rpd As New rptPurDetails
        rpd.MdiParent = Me
        rpd.Show()
    End Sub

   

    Private Sub ReportForwardToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportForwardToolStripMenuItem.Click
        Dim rf As New rptForward
        rf.MdiParent = Me
        rf.Show()
    End Sub

    Private Sub TestReportToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TestReportToolStripMenuItem1.Click
        Dim rt As New rptTest
        rt.MdiParent = Me
        rt.Show()
    End Sub

    Private Sub BillToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BillToolStripMenuItem1.Click
        Dim rtb As New rptTotalBill
        rtb.MdiParent = Me
        rtb.Show()
    End Sub

    Private Sub ExpencesToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExpencesToolStripMenuItem1.Click
        Dim re As New rptExpence
        re.MdiParent = Me
        re.Show()
    End Sub

    Private Sub EmployeeDetailsToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeDetailsToolStripMenuItem.Click
        Dim rePM As New rptEmpPayment
        rePM.MdiParent = Me
        rePM.Show()
    End Sub

    Private Sub ReportsToolStripMenuItem_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReportsToolStripMenuItem.MouseHover
        lblstatus.Text = "Reports"
    End Sub

   

    Private Sub OthersToolStripMenuItem_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles OthersToolStripMenuItem.MouseHover
        lblstatus.Text = "Other"
    End Sub
End Class