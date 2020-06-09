Imports System.Data
Imports System.Data.SqlClient
Public Class StockMaster
    Dim cn As SqlConnection
    Dim cm As SqlCommand
    Dim dr As SqlDataReader
    Dim dt, dt1 As DataTable
    Dim n, c As Integer
    Dim x As New ClassCon
    Private Sub StockMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn = New SqlConnection(x.s)
        cn.Open()
        dt1 = New DataTable()
        seeChmcl()
        seePurDet()

    End Sub

   
    Private Sub seeChmcl()
        dt1.Clear()
        cm = New SqlCommand("select * from ChemMaster order by ChemId ", cn)
        dr = cm.ExecuteReader()
        dt1.Load(dr)
        dr.Close()
        cmbChmclNm.DataSource = dt1
        cmbChmclNm.ValueMember = "ChemNm"
        cmbChmclNm.DisplayMember = "ChemNm"
        n = dt1.Rows.Count - 1


    End Sub
    Dim p, u As Single
    Private Sub seePurDet()
        Dim dtt As New DataTable
        Dim drw As DataRow

        dtt.Columns.Add("Chemical")
        dtt.Columns.Add("Quantity")
        For i = 0 To n
            drw = dtt.NewRow()
            drw(0) = dt1.Rows(i).Item(1).ToString()
            Try

                cm = New SqlCommand("select sum(Quntity) from PurDet where ChemNm='" & dt1.Rows(i).Item(1) & "'", cn)
                dr = cm.ExecuteReader()
                If dr.Read() Then
                    p = CSng(dr(0))
                End If
                dr.Close()

            Catch ex As Exception
                p = 0
                dr.Close()
            End Try

            Try

                cm = New SqlCommand("select sum(Quantity) from ChemUsed where ChemNm='" & dt1.Rows(i).Item(1) & "'", cn)
                dr = cm.ExecuteReader()
                If dr.Read() Then
                    u = CSng(dr(0))
                End If
                dr.Close()

            Catch ex As Exception
                u = 0
                dr.Close()
            End Try
            drw(1) = p - u
            dtt.Rows.Add(drw)
        Next
        DataGridView1.DataSource = dtt

    End Sub
    Private Sub cmbChmclNm_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbChmclNm.SelectedIndexChanged
        Try
            Try

                cm = New SqlCommand("select sum(Quntity) from PurDet where ChemNm='" & cmbChmclNm.Text & "'", cn)
                dr = cm.ExecuteReader()
                If dr.Read() Then
                    p = CSng(dr(0))
                End If
                dr.Close()

            Catch ex As Exception
                p = 0
                dr.Close()
            End Try

            Try

                cm = New SqlCommand("select sum(Quantity) from ChemUsed where ChemNm='" & cmbChmclNm.Text & "'", cn)
                dr = cm.ExecuteReader()
                If dr.Read() Then
                    u = CSng(dr(0))
                End If
                dr.Close()

            Catch ex As Exception
                u = 0
                dr.Close()
            End Try
            txtChmStk.Text = (p - u)

        Catch ex As Exception
            txtChmStk.Text = "0"
        End Try
    End Sub

  
   
End Class