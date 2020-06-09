Imports System.Data
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine



Public Class rptTest
    Dim cn As SqlConnection
    Dim cm As SqlCommand
    Dim dr As SqlDataReader
    Dim dt, dt2, dt1 As New DataTable
    Dim crd As New ReportDocument
    Dim x As New ClassCon

    Private Sub rptForward_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn = New SqlConnection(x.s)
        cn.Open()
        dt = New DataTable()
        see()
    End Sub

   
    Private Sub see()
        dt.Clear()
        cm = New SqlCommand("select * from TestReport", cn)
        dr = cm.ExecuteReader()
        dt.Load(dr)
        dr.Close()
        dt1.Clear()
        cm = New SqlCommand("select distinct(RCId) from TestReport", cn)
        dr = cm.ExecuteReader()
        dt1.Load(dr)
        dr.Close()
        cmbRCId.DataSource = dt1
        cmbRCId.DisplayMember = "RCId"
        cmbRCId.ValueMember = "RCId"

        crd.Load(x.r & "TReport.rpt")
        CrystalReportViewer1.ReportSource = crd
        CrystalReportViewer1.RefreshReport()
        crd.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = crd
        CrystalReportViewer1.RefreshReport()

    End Sub


    Private Sub cmbRCId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRCId.SelectedIndexChanged
        Try
            dt2.Clear()
            cm = New SqlCommand("select * from TestReport where RCId=" & CInt(cmbRCId.Text), cn)
            dr = cm.ExecuteReader()
            dt2.Load(dr)
            dr.Close()
            crd.Load(x.r & "TReport.rpt")
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
End Class
