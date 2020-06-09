Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class rptBill
    Dim cn As SqlConnection
    Dim cm As SqlCommand
    Dim dr As SqlDataReader
    Dim dt, dt2, dt4 As New DataTable
    Dim crd As New ReportDocument

    Private Sub rptBill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Htc\Documents\Visual Studio 2008\Projects\Pathology\Pathology\patholabDB.mdf;Integrated Security=True;User Instance=True")
        cn.Open()
        dt = New DataTable()
        see()
      
    End Sub
    Private Sub see()
        dt4.Clear()
        cm = New SqlCommand("select distinct(BillNo) from FinalBill", cn)
        dr = cm.ExecuteReader()
        dt4.Load(dr)
        cmbBillno.DataSource = dt4
        cmbBillno.DisplayMember = "BillNo"
        cmbBillno.ValueMember = "BillNo"
        dt.Clear()
        cm = New SqlCommand("select FinalBill.BillNo, FinalBill.PId, FinalBill.PName,FinalBill.PaidBy, FinalBill.Total, FinalBill.BDate,BillCost.TestNo,BillCost.BNo,BillCost.TestName,BillCost.Cost from FinalBill,BillCost", cn)
        dr = cm.ExecuteReader()
        dt.Load(dr)
        dr.Close()
        DataGridView1.DataSource = dt
        crd.Load("C:\Users\Htc\Documents\Visual Studio 2008\Projects\Pathology\Pathology\TotalBill.rpt")
        CrystalReportViewer1.ReportSource = crd
        CrystalReportViewer1.RefreshReport()
        crd.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = crd
        CrystalReportViewer1.RefreshReport()

    End Sub

    Private Sub cmbBillno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBillno.SelectedIndexChanged
        Try

            dt2.Clear()
            cm = New SqlCommand("select  select FinalBill.BillNo, FinalBill.PId, FinalBill.PName,FinalBill.PaidBy, FinalBill.Total, FinalBill.BDate,BillCost.TestNo,BillCost.BNo,BillCost.TestName,BillCost.Cost from FinalBill,BillCost where FinalBill.BillNo =BillCost.BNo and FinalBill.BillNo=" & CInt(cmbBillno.Text), cn)
            dr = cm.ExecuteReader()
            dt2.Load(dr)
            dr.Close()
            DataGridView1.DataSource = dt2

            crd.Load("C:\Users\Htc\Documents\Visual Studio 2008\Projects\Pathology\Pathology\TotalBill.rpt")
            CrystalReportViewer1.ReportSource = crd
            CrystalReportViewer1.RefreshReport()
            crd.SetDataSource(dt2)
            CrystalReportViewer1.ReportSource = crd
            CrystalReportViewer1.RefreshReport()


        Catch ex As Exception

        End Try
      
    End Sub
End Class