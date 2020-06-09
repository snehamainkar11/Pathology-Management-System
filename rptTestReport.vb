Imports System.Data
Imports CrystalDecisions
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Enterprise
Public Class rptTestReport
    Dim cn As SqlConnection
    Dim cm As SqlCommand
    Dim dr As SqlDataReader
    Dim dt, dt1, dt2 As New DataTable
    Dim crd As New ReportDocument
    Private Sub rptTestReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Htc\Documents\Visual Studio 2008\Projects\Pathology\Pathology\patholabDB.mdf;Integrated Security=True;User Instance=True")
        cn.Open()
        dt = New DataTable()
        see()
    End Sub
   
    Private Sub see()
        Try
            dt.Clear()
            cm = New SqlCommand("select RCreate.RCId,RCreate.PName,RCreate.PAddr,RCreate.Contact,RCreate.DrNm,ReportResult.RCId,RCreate.Disease,RCreate.RefBy ,RCreate.RemarkByDoctor,RCreate.RDate,ReportResult.TestNo,ReportResult.TestName,ReportResult.Result from RCreate ,ReportResult where RCreate.RCId=ReportResult.RCId order by RCreate.RCId ", cn)

            'cm = New SqlCommand("select  * from RCreate ,ReportResult where RCreate.RCId=ReportResult.RCId order by RCreate.RCId ", cn)

            dr = cm.ExecuteReader()
            dt.Load(dr)
            dr.Close()
            DataGridView1.DataSource = dt
            crd.Load("C:\Users\Htc\Documents\Visual Studio 2008\Projects\Pathology\Pathology\CrystalReport2.rpt")
            CrystalReportViewer1.ReportSource = crd
            CrystalReportViewer1.RefreshReport()
            crd.SetDataSource(dt)
            CrystalReportViewer1.ReportSource = crd
            CrystalReportViewer1.RefreshReport()

            dt1.Clear()

            cm = New SqlCommand("select distinct(RCId) from RCreate", cn)
            dr = cm.ExecuteReader()
            dt1.Load(dr)
            dr.Close()
            cmbRCId.DataSource = dt1
            cmbRCId.DisplayMember = "RCId"
            cmbRCId.ValueMember = "RCId"
        
        Catch ex As Exception
            'MsgBox(ex.ToString)
        End Try
    End Sub


    Private Sub cmbRCId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRCId.SelectedIndexChanged
        Try
            dt2.Clear()
            cm = New SqlCommand("select  RCreate.RCId,RCreate.PName,RCreate.PAddr,RCreate.Contact,RCreate.DrNm,RCreate.Disease,RCreate.RefBy ,RCreate.RemarkByDoctor,RCreate.RDate,ReportResult.RCId,ReportResult.TestNo,ReportResult.TestName,ReportResult.Result  from  RCreate , ReportResult where RCreate.RCId =ReportResult.RCId and RCreate.RCId=" & CInt(cmbRCId.Text), cn)
            'cm = New SqlCommand("select  *  from  RCreate , ReportResult where RCreate.RCId =ReportResult.RCId and RCreate.RCId=" & CInt(cmbRCId.Text), cn)

            dr = cm.ExecuteReader()
            dt2.Load(dr)
            dr.Close()
            DataGridView1.DataSource = dt2
            crd.Load("C:\Users\Htc\Documents\Visual Studio 2008\Projects\Pathology\Pathology\CrystalReport2.rpt")
            CrystalReportViewer1.ReportSource = crd
            CrystalReportViewer1.RefreshReport()
            crd.SetDataSource(dt2)
            CrystalReportViewer1.ReportSource = crd
            CrystalReportViewer1.RefreshReport()

        Catch ex As Exception
            'MsgBox(ex.ToString())
        End Try
    End Sub


  
End Class