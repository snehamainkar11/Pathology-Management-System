Imports System.Data
Imports System.Data.SqlClient
Public Class PurchaseDetails

    Private cn As SqlConnection
    Private cm As SqlCommand
    Private dr As SqlDataReader
    Private dt, dt1, dt2 As New DataTable
    Dim c, l, i As Integer
    Dim x As New ClassCon
    Private Sub PurchaseDet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatholabDBDataSet30.PurDet' table. You can move, or remove it, as needed.
        'Me.PurDetTableAdapter.Fill(Me.PatholabDBDataSet30.PurDet)
        'TODO: This line of code loads data into the 'PatholabDBDataSet10.PurDet' table. You can move, or remove it, as needed.
        'Me.PurDetTableAdapter.Fill(Me.PatholabDBDataSet10.PurDet)
        cn = New SqlConnection(x.s)
        cn.Open()
        dt2 = New DataTable()
        seeChem()
        dt = New DataTable()
        see()
        Srlshow()
        btnFnlBill.Focus()
    End Sub

    Private Sub TxtPurchaseId_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPurchaseId.KeyPress
        If Not IsNumeric(e.KeyChar) = True And e.KeyChar <> vbBack Then
            e.Handled = True
            ToolTip1.Show("Only Number", txtPurchaseId)
        Else
            ToolTip1.Hide(txtPurchaseId)
        End If
    End Sub
    Private Sub txtPurDetSrNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPurDetSrNo.KeyPress
        If Not IsNumeric(e.KeyChar) = True And e.KeyChar <> vbBack Then
            e.Handled = True
            ToolTip1.Show("Only Number", txtPurDetSrNo)
        Else
            ToolTip1.Hide(txtPurDetSrNo)
        End If
    End Sub
    Private Sub txtQuantity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQuantity.KeyPress
        If Not IsNumeric(e.KeyChar) = True And e.KeyChar <> vbBack Then
            e.Handled = True
            ToolTip1.Show("Only Number", txtQuantity)
        Else
            ToolTip1.Hide(txtQuantity)
        End If
    End Sub

    Private Sub txtAmt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not IsNumeric(e.KeyChar) = True And e.KeyChar <> vbBack Then
            e.Handled = True
            ToolTip1.Show("Only Number", txtAmt)
        Else
            ToolTip1.Hide(txtAmt)
        End If
    End Sub
    Private Sub clear()
        txtPurDetSrNo.Text = ""
        cmbChemName.Text = ""
        txtPurDetRate.Text = ""
        txtAmt.Text = ""
        txtQuantity.Text = ""
        txtVAT.Text = ""
    End Sub

    Public Sub see()
        Try


            dt.Clear()
            cm = New SqlCommand("select * from PurDet order by PurId", cn)
            dr = cm.ExecuteReader()
            dt.Load(dr)
            dr.Close()
            l = dt.Rows.Count - 1
            DataGridView1.DataSource = dt
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub seeChem()
        dt2.Clear()
        cm = New SqlCommand("select * from ChemMaster order by ChemId", cn)
        dr = cm.ExecuteReader()
        dt2.Load(dr)
        dr.Close()
        cmbChemName.DataSource = dt2
        cmbChemName.ValueMember = "ChemNm"
        cmbChemName.DisplayMember = "ChemNm"

    End Sub

    Private Sub EachRecord()
        txtPurchaseId.Text = dt.Rows(c).Item(0).ToString()
        txtBillNo.Text = dt.Rows(c).Item(1).ToString()
        txtDealer.Text = dt.Rows(c).Item(2).ToString()
        dtpPurDetail.Text = CDate(dt.Rows(c).Item(3).ToString())
        txtPurDetSrNo.Text = (dt.Rows(c).Item(4).ToString())
        cmbChemName.Text = dt.Rows(c).Item(5).ToString()
        txtPurDetRate.Text = dt.Rows(c).Item(6).ToString()
        txtQuantity.Text = dt.Rows(c).Item(7).ToString()
        txtVAT.Text = dt.Rows(c).Item(8).ToString()
        txtAmt.Text = dt.Rows(c).Item(9).ToString()

    End Sub


    Private Sub BtnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFirst.Click
        c = 0

        EachRecord()
    End Sub

    Private Sub BtnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNext.Click
        If c < l Then
            c += 1
            EachRecord()
        Else
            MsgBox("Last Record")
        End If
    End Sub

    Private Sub BtnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrev.Click
        If c > 0 Then
            c -= 1
            EachRecord()
        Else
            MsgBox("First Record")
        End If
    End Sub

    Private Sub BtnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLast.Click
        c = l
        EachRecord()
    End Sub


    Private Sub cnt()
        cm = New SqlCommand("select count(PurId) from PurDet", cn)
        dr = cm.ExecuteReader()
        If dr.Read() Then
            MsgBox("No. of Records=" & CInt(dr(0)), MsgBoxStyle.Information)
        End If
        dr.Close()

    End Sub


    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        clear()
        txtPurchaseId.Text = ""
        txtBillNo.Text = ""
        txtDealer.Text = ""

    End Sub

    Private Sub txtQuantity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQuantity.TextChanged
        Try
            txtAmt.Text = Val(txtPurDetRate.Text) * Val(txtQuantity.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtAmt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            txtAmt.Text = Val(txtPurDetRate.Text) * Val(txtQuantity.Text)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtVAT_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVAT.TextChanged
        Try
            txtAmt.Text = Val(txtAmt.Text) + Val(txtVAT.Text) * 4 / 100
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            cm = New SqlCommand("insert into PurDet values(@PurId,@BillNo,@Dealer,@PDate,@SrlNo,@ChemNm,@Rate,@Quntity,@VAT,@Amount)", cn)
            cm.Parameters.Add("@PurId", SqlDbType.Int).Value = CInt(txtPurchaseId.Text)
            cm.Parameters.Add("@BillNo", SqlDbType.Int).Value = CInt(txtBillNo.Text)
            cm.Parameters.Add("@Dealer", SqlDbType.VarChar).Value = (txtDealer.Text)
            cm.Parameters.Add("@PDate", SqlDbType.DateTime).Value = CDate(dtpPurDetail.Value)
            cm.Parameters.Add("@SrlNo", SqlDbType.Int).Value = CInt(txtPurDetSrNo.Text)
            cm.Parameters.Add("@ChemNm", SqlDbType.VarChar).Value = (cmbChemName.Text)
            cm.Parameters.Add("@Rate", SqlDbType.Float).Value = CSng(txtPurDetRate.Text)
            cm.Parameters.Add("@Quntity", SqlDbType.Int).Value = CInt(txtQuantity.Text)
            cm.Parameters.Add("@VAT", SqlDbType.Float).Value = CSng(txtVAT.Text)
            cm.Parameters.Add("@Amount", SqlDbType.Float).Value = CSng(txtAmt.Text)
            Dim r As Integer = cm.ExecuteNonQuery()
            If r = 1 Then
                MsgBox("Record Inserted Successfully", MsgBoxStyle.Exclamation)
            Else
                MsgBox("Error while Inserting record", MsgBoxStyle.RetryCancel)
            End If
            see()
            clear()
            dr.Close()
            Srlshow()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            cm = New SqlCommand("update PurDet set BillNo=@BillNo,Dealer=@Dealer,PDate=@PDate,ChemNm=@ChemNm,Rate=@Rate,Quntity=@Quntity,VAT=@VAT,Amount=@Amount where PurId=@PurId and SrlNo=@SrlNo", cn)
            cm.Parameters.Add("@PurId", SqlDbType.Int).Value = CInt(txtPurchaseId.Text)
            cm.Parameters.Add("@BillNo", SqlDbType.Int).Value = CInt(txtBillNo.Text)
            cm.Parameters.Add("@Dealer", SqlDbType.VarChar).Value = (txtDealer.Text)
            cm.Parameters.Add("@PDate", SqlDbType.DateTime).Value = CDate(dtpPurDetail.Value)
            cm.Parameters.Add("@SrlNo", SqlDbType.Int).Value = CInt(txtPurDetSrNo.Text)
            cm.Parameters.Add("@ChemNm", SqlDbType.VarChar).Value = (cmbChemName.Text)
            cm.Parameters.Add("@Rate", SqlDbType.Float).Value = CSng(txtPurDetRate.Text)
            cm.Parameters.Add("@Quntity", SqlDbType.Int).Value = CInt(txtQuantity.Text)
            cm.Parameters.Add("@VAT", SqlDbType.Float).Value = CSng(txtVAT.Text)
            cm.Parameters.Add("@Amount", SqlDbType.Float).Value = CSng(txtAmt.Text)
            Dim r As Integer = cm.ExecuteNonQuery()
            If r = 1 Then
                MsgBox("Record updated Successfully", MsgBoxStyle.Exclamation)
            Else
                MsgBox("Error while updating record", MsgBoxStyle.RetryCancel)
            End If
            see()
            clear()
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If MsgBox("Do You want to delete ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                cm = New SqlCommand("delete from PurDet where PurId=@PurId and SrlNo=@SrlNo", cn)
                cm.Parameters.Add("@PurId", SqlDbType.Int).Value = CInt(txtPurchaseId.Text)
                cm.Parameters.Add("@SrlNo", SqlDbType.Int).Value = CInt(txtPurDetSrNo.Text)

                Dim x As Integer = cm.ExecuteNonQuery()
                If x = 1 Then
                    MsgBox("Record deleted successfully", MsgBoxStyle.Exclamation)
                Else
                    MsgBox("Error while deleting record", MsgBoxStyle.Critical)
                End If

                see()
                cnt()
                clear()
                txtPurchaseId.Text = ""
                txtBillNo.Text = ""
                txtDealer.Text = ""
                dr.Close()

            Else
                clear()
            End If
            dr.Close()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        txtPurchaseId.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()
        txtBillNo.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString()
        txtDealer.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString()
        dtpPurDetail.Text = CDate(DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString())
        txtPurDetSrNo.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString()
        cmbChemName.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString()
        txtPurDetRate.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString()
        txtQuantity.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value.ToString()
        txtVAT.Text = DataGridView1.Rows(e.RowIndex).Cells(8).Value.ToString()
        txtAmt.Text = DataGridView1.Rows(e.RowIndex).Cells(9).Value.ToString()
    End Sub

    Private Sub lblLnkPrint_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblLnkPrint.LinkClicked
        Me.Hide()
        rptPurDetails.Show()
    End Sub

  
    Public Sub Srlshow()
        ' clear()
        Try
            cm = New SqlCommand("select max(SrlNo) from PurDet  where BillNo= " & CInt(txtBillNo.Text), cn)
            dr = cm.ExecuteReader()
            If dr.Read() Then

                txtPurDetSrNo.Text = (CInt(dr(0)) + 1)

            End If
            dr.Close()
        Catch ex As Exception
            txtPurDetSrNo.Text = "1"


        End Try

    End Sub

   
    Private Sub btnFnlBill_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFnlBill.Click
        Try
            cm = New SqlCommand("select sum(Amount) from PurDet where  PurId=" & (txtPurchaseId.Text), cn)
            dr = cm.ExecuteReader()
            If dr.Read() Then
                Purchase.TxtPurAmt.Text = dr(0).ToString()
                Purchase.TxtVATTax.Text = Val(dr(0) * 4) / 100
                Purchase.TxtNetAmt.Text = Val(dr(0)).ToString + Val(Val(dr(0)) * 4 / 100)
                Purchase.Visible = True
                Purchase.TxtPurchaseId.Text = txtPurchaseId.Text
                Me.Visible = False
            End If

            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try

    End Sub

    Private Sub cmbChemName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbChemName.SelectedIndexChanged

        Try
            cm = New SqlCommand("select Prc from ChemMaster where ChemNm='" & (cmbChemName.Text) & "'", cn)
            dr = cm.ExecuteReader()
            If dr.Read() Then
                txtPurDetRate.Text = dr(0).ToString()
            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

   
End Class