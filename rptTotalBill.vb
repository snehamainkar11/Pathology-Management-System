Imports System.Data
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class rptTotalBill
    Dim cn As SqlConnection
    Dim cm As SqlCommand
    Dim dr As SqlDataReader
    Dim dt, dt2 As New DataTable
    Dim crd As New ReportDocument
    Dim x As New ClassCon

    Private Sub rptTotalBill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn = New SqlConnection(x.s)
        cn.Open()
        dt = New DataTable()
        see()
    End Sub
    Private Sub see()
        dt.Clear()
        cm = New SqlCommand("select * from FinalBill", cn)
        dr = cm.ExecuteReader()
        dt.Load(dr)
        dr.Close()
        cmbBillNo.DataSource = dt
        cmbBillNo.DisplayMember = "BillNo"
        cmbBillNo.ValueMember = "BillNo"
        crd.Load(x.r & "FBill.rpt")
        CrystalReportViewer1.ReportSource = crd
        CrystalReportViewer1.RefreshReport()
        crd.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = crd
        CrystalReportViewer1.RefreshReport()

    End Sub

    Private Sub cmbBillNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBillNo.SelectedIndexChanged
        Try
            dt2.Clear()
            cm = New SqlCommand("select * from FinalBill where BillNo=" & CInt(cmbBillNo.Text), cn)
            dr = cm.ExecuteReader()
            dt2.Load(dr)
            dr.Close()
            crd.Load(x.r & "FBill.rpt")
            CrystalReportViewer1.ReportSource = crd
            CrystalReportViewer1.RefreshReport()
            crd.SetDataSource(dt2)
            CrystalReportViewer1.ReportSource = crd
            CrystalReportViewer1.RefreshReport()


        Catch ex As Exception

        End Try

    End Sub

   
    Private Sub btnShwRec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShwRec.Click
        see()
    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class