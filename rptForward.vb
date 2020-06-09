
Imports System.Data
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class rptForward
    Dim cn As SqlConnection
    Dim cm As SqlCommand
    Dim dr As SqlDataReader
    Dim dt, dt2 As New DataTable
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
        cm = New SqlCommand("select * from RFrwd", cn)
        dr = cm.ExecuteReader()
        dt.Load(dr)
        dr.Close()
        cmbFId.DataSource = dt
        cmbFId.DisplayMember = "RFId"
        cmbFId.ValueMember = "RFId"
        crd.Load(x.r & "RForword.rpt")
        CrystalReportViewer1.ReportSource = crd
        CrystalReportViewer1.RefreshReport()
        crd.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = crd
        CrystalReportViewer1.RefreshReport()

    End Sub
    
    Private Sub cmbFId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFId.SelectedIndexChanged
        Try
            dt2.Clear()
            cm = New SqlCommand("select * from RFrwd where RFId=" & CInt(cmbFId.Text), cn)
            dr = cm.ExecuteReader()
            dt2.Load(dr)
            dr.Close()
            crd.Load(x.r & "RForword.rpt")
            CrystalReportViewer1.ReportSource = crd
            CrystalReportViewer1.RefreshReport()
            crd.SetDataSource(dt2)
            CrystalReportViewer1.ReportSource = crd
            CrystalReportViewer1.RefreshReport()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub

    Private Sub btnShwRec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShwRec.Click
        see()
    End Sub
End Class