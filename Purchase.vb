

Imports System.Data
Imports System.Data.SqlClient
Public Class Purchase
    Private cn As SqlConnection
    Private cm As SqlCommand
    Private dr As SqlDataReader
    Private dt, dt1, dt2 As New DataTable
    Dim c, l As Integer
    Dim x As New ClassCon
    Private Sub Purchase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatholabDBDataSet9.PurchaseTbl' table. You can move, or remove it, as needed.
        'Me.PurchaseTblTableAdapter.Fill(Me.PatholabDBDataSet9.PurchaseTbl)
        cn = New SqlConnection(x.s)
        cn.Open()
        see()
        seebill()
        dt1 = New DataTable()
        see1()
        dt2 = New DataTable()
        see2()
        dt = New DataTable()
         BtnAddPurDet.Focus()

    End Sub

    Private Sub TxtPurchaseId_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPurchaseId.KeyPress
        If Not IsNumeric(e.KeyChar) = True And e.KeyChar <> vbBack Then
            e.Handled = True
            ToolTip1.Show("Only Number", TxtPurchaseId)
        Else
            ToolTip1.Hide(TxtPurchaseId)
        End If
    End Sub

    Private Sub TxtPurAmt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPurAmt.KeyPress
        If Not IsNumeric(e.KeyChar) = True And e.KeyChar <> "." And e.KeyChar <> vbBack Then
            e.Handled = True
            ToolTip1.Show("Only Number", TxtPurAmt)
        Else
            ToolTip1.Hide(TxtPurAmt)
        End If
    End Sub

    Private Sub TxtVATTax_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtVATTax.KeyPress
        If Not IsNumeric(e.KeyChar) = True And e.KeyChar <> "." And e.KeyChar <> vbBack Then
            e.Handled = True
            ToolTip1.Show("Only Number", TxtVATTax)
        Else
            ToolTip1.Hide(TxtVATTax)
        End If
    End Sub

    Private Sub TxtNetAmt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNetAmt.KeyPress
        If Not IsNumeric(e.KeyChar) = True And e.KeyChar <> "." And e.KeyChar <> vbBack Then
            e.Handled = True
            ToolTip1.Show("Only Number", TxtNetAmt)
        Else
            ToolTip1.Hide(TxtNetAmt)
        End If
    End Sub

    Private Sub txtContact_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtContact.GotFocus

        txtContact.BackColor = Color.Gold
        txtContact.Focus()
    End Sub

    Private Sub txtContact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContact.KeyPress
        If Not IsNumeric(e.KeyChar) = True And e.KeyChar <> vbBack Then
            e.Handled = True
            ToolTip1.Show("Only Number", txtContact)
        Else
            ToolTip1.Hide(txtContact)
        End If
    End Sub
    Private Sub txtContact_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtContact.LostFocus
        Dim s As String = txtContact.Text
        txtContact.BackColor = Color.White
        If s.Length <> 10 Then
            MsgBox("Enter exact 10 Digit")
            txtContact.Focus()
        End If
    End Sub

    Private Sub clear()
        TxtPurchaseId.Clear()
        CmbDealerName.Text = ""
        TxtPurAmt.Clear()
        TxtVATTax.Clear()
        TxtNetAmt.Clear()
        txtBillNo.Text = ""
        cmbPaidBy.Text = ""
        txtAddr.Text = ""
        txtContact.Text = ""
    End Sub
    
    Private Sub see()
        dt.Clear()
        cm = New SqlCommand("select * from PurchaseTbl order by PurId", cn)
        dr = cm.ExecuteReader()
        dt.Load(dr)
        dr.Close()
        l = dt.Rows.Count - 1
        DataGridView1.DataSource = dt
    End Sub
    Private Sub see1()
        dt1.Clear()
        cm = New SqlCommand("select * from Dealer order by DlrId", cn)
        dr = cm.ExecuteReader()
        dt1.Load(dr)
        dr.Close()
        CmbDealerName.DataSource = dt1
        CmbDealerName.ValueMember = "DlrNm"
        CmbDealerName.DisplayMember = "DlrNm"

    End Sub
    Private Sub see2()
        dt2.Clear()
        cm = New SqlCommand("select * from EmpMaster order by EId", cn)
        dr = cm.ExecuteReader()
        dt2.Load(dr)
        dr.Close()
        cmbPaidBy.DataSource = dt2
        cmbPaidBy.ValueMember = "EName"
        cmbPaidBy.DisplayMember = "EName"
    End Sub
    Private Sub seebill()

        cm = New SqlCommand("select max(BillNo) from PurchaseTbl", cn)
        dr = cm.ExecuteReader()
        If dr.Read() Then
            txtBillNo.Text = CInt(dr(0) + 1)
        End If

        dr.Close()
    End Sub
    Private Sub cnt()
        cm = New SqlCommand("select count(PurId) from PurchaseTbl", cn)
        dr = cm.ExecuteReader()
        If dr.Read() Then
            MsgBox("No. of Records=" & CInt(dr(0)), MsgBoxStyle.Information)
        End If
    End Sub


    Private Sub EachRecord()
        Try

     
            TxtPurchaseId.Text = dt.Rows(c).Item(0).ToString()
            txtBillNo.Text = dt.Rows(c).Item(1).ToString()
            CmbDealerName.Text = dt.Rows(c).Item(2).ToString()
            txtAddr.Text = dt.Rows(c).Item(3).ToString()
            txtContact.Text = dt.Rows(c).Item(4).ToString()
            dtpPurchase.Value = CDate(dt.Rows(c).Item(5).ToString())
            TxtPurAmt.Text = dt.Rows(c).Item(6).ToString()
            TxtVATTax.Text = dt.Rows(c).Item(7).ToString()
            TxtNetAmt.Text = dt.Rows(c).Item(8).ToString()
            cmbPaidBy.Text = dt.Rows(c).Item(9).ToString()
        Catch ex As Exception
            dr.Close()
        End Try
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
    Private Sub TxtPurAmt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPurAmt.TextChanged
        Try
            TxtNetAmt.Text = Val(TxtPurAmt.Text) + Val(TxtVATTax.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TxtVATTax_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtVATTax.TextChanged
        Try
            TxtNetAmt.Text = Val(TxtPurAmt.Text) + Val(TxtVATTax.Text) * 4 / 100
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnnewid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnewid.Click
        cm = New SqlCommand("select max(PurId) from PurchaseTbl", cn)
        dr = cm.ExecuteReader()
        If dr.Read() Then
            TxtPurchaseId.Text = CInt(dr(0) + 1)
        End If
        dr.Close()
        seebill()
        TxtPurAmt.Text = ""
        CmbDealerName.Text = ""
        TxtVATTax.Text = ""
        dtpPurchase.Text = ""
        TxtNetAmt.Text = ""

        cmbPaidBy.Text = ""
        txtAddr.Text = ""
        txtContact.Text = ""
        cm = New SqlCommand("insert into PurchaseTbl(PurId)values(" & CInt(TxtPurchaseId.Text) & ")", cn)
        cm.ExecuteNonQuery()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            'cm = New SqlCommand("insert into PurchaseTbl values(@PurId,@BillNo,@Dealer,@DlrAddr,@Contact,@PDate,@Amt,@VTax,@NtAmt,@PaidBy)", cn)
            'cm.Parameters.Add("@PurId", SqlDbType.Int).Value = CInt(TxtPurchaseId.Text)
            'cm.Parameters.Add("@BillNo", SqlDbType.Int).Value = CInt(txtBillNo.Text)
            'cm.Parameters.Add("@Dealer", SqlDbType.VarChar).Value = (CmbDealerName.Text)
            'cm.Parameters.Add("@DlrAddr", SqlDbType.NVarChar).Value = (txtAddr.Text)
            'cm.Parameters.Add("@Contact", SqlDbType.BigInt).Value = CLng(txtContact.Text)
            'cm.Parameters.Add("@PDate", SqlDbType.DateTime).Value = CDate(dtpPurchase.Value)
            'cm.Parameters.Add("@Amt", SqlDbType.Float).Value = CSng(TxtPurAmt.Text)
            'cm.Parameters.Add("@VTax", SqlDbType.Float).Value = CSng(TxtVATTax.Text)
            'cm.Parameters.Add("@NtAmt", SqlDbType.Float).Value = CSng(TxtNetAmt.Text)
            'cm.Parameters.Add("@PaidBy", SqlDbType.VarChar).Value = (cmbPaidBy.Text)

            'Dim r As Integer = cm.ExecuteNonQuery()
            'If r = 1 Then
            '    MsgBox("Record inserted Successfully", MsgBoxStyle.Exclamation)
            'Else
            '    MsgBox("Error while inserting record", MsgBoxStyle.RetryCancel)
            'End If
            'see()
            'cnt()
            'clear()
            'dr.Close()
            cm = New SqlCommand("update PurchaseTbl set  BillNo=@BillNo,Dealer=@Dealer,DlrAddr=@DlrAddr,Contact=@Contact,PDate=@PDate,Amt=@Amt,VTax=@VTax,NtAmt=@NtAmt,PaidBy=@PaidBy where PurId=@PurId", cn)
            cm.Parameters.Add("@PurId", SqlDbType.Int).Value = CInt(TxtPurchaseId.Text)
            cm.Parameters.Add("@BillNo", SqlDbType.Int).Value = CInt(txtBillNo.Text)
            cm.Parameters.Add("@Dealer", SqlDbType.VarChar).Value = (CmbDealerName.Text)
            cm.Parameters.Add("@DlrAddr", SqlDbType.NVarChar).Value = (txtAddr.Text)
            cm.Parameters.Add("@Contact", SqlDbType.BigInt).Value = CLng(txtContact.Text)
            cm.Parameters.Add("@PDate", SqlDbType.DateTime).Value = CDate(dtpPurchase.Value)
            cm.Parameters.Add("@Amt", SqlDbType.Float).Value = CSng(TxtPurAmt.Text)
            cm.Parameters.Add("@VTax", SqlDbType.Float).Value = CSng(TxtVATTax.Text)
            cm.Parameters.Add("@NtAmt", SqlDbType.Float).Value = CSng(TxtNetAmt.Text)
            cm.Parameters.Add("@PaidBy", SqlDbType.VarChar).Value = (cmbPaidBy.Text)
            Dim r As Integer = cm.ExecuteNonQuery()
            If r = 1 Then
                MsgBox("Record inserted Successfully", MsgBoxStyle.Exclamation)
            Else
                MsgBox("Error while inserted record", MsgBoxStyle.RetryCancel)
            End If
            see()
            clear()
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try

    End Sub
    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            cm = New SqlCommand("update PurchaseTbl set  BillNo=@BillNo,Dealer=@Dealer,DlrAddr=@DlrAddr,Contact=@Contact,PDate=@PDate,Amt=@Amt,VTax=@VTax,NtAmt=@NtAmt,PaidBy=@PaidBy where PurId=@PurId", cn)
            cm.Parameters.Add("@PurId", SqlDbType.Int).Value = CInt(TxtPurchaseId.Text)
            cm.Parameters.Add("@BillNo", SqlDbType.Int).Value = CInt(txtBillNo.Text)
            cm.Parameters.Add("@Dealer", SqlDbType.VarChar).Value = (CmbDealerName.Text)
            cm.Parameters.Add("@DlrAddr", SqlDbType.NVarChar).Value = (txtAddr.Text)
            cm.Parameters.Add("@Contact", SqlDbType.BigInt).Value = CLng(txtContact.Text)
            cm.Parameters.Add("@PDate", SqlDbType.DateTime).Value = CDate(dtpPurchase.Value)
            cm.Parameters.Add("@Amt", SqlDbType.Float).Value = CSng(TxtPurAmt.Text)
            cm.Parameters.Add("@VTax", SqlDbType.Float).Value = CSng(TxtVATTax.Text)
            cm.Parameters.Add("@NtAmt", SqlDbType.Float).Value = CSng(TxtNetAmt.Text)
            cm.Parameters.Add("@PaidBy", SqlDbType.VarChar).Value = (cmbPaidBy.Text)
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
                cm = New SqlCommand("delete from PurDet where PurId=@PurId", cn)
                cm.Parameters.Add("@PurId", SqlDbType.Int).Value = CInt(TxtPurchaseId.Text)
                cm.ExecuteNonQuery()
                dr.Close()
                cm = New SqlCommand("delete from PurchaseTbl where PurId=@PurId", cn)
                cm.Parameters.Add("@PurId", SqlDbType.Int).Value = CInt(TxtPurchaseId.Text)
                Dim x As Integer = cm.ExecuteNonQuery()
                If x = 1 Then
                    MsgBox("Record deleted successfully", MsgBoxStyle.Exclamation)
                Else
                    MsgBox("Error while deleting record", MsgBoxStyle.Critical)
                End If
                see()
                cnt()
                clear()
                PurchaseDetails.see()
            Else
                clear()

            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        clear()
    End Sub
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try

        
            TxtPurchaseId.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()
            txtBillNo.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString()
            CmbDealerName.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString()
            txtAddr.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString()
            txtContact.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString()
            dtpPurchase.Value = CDate(DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString)
            TxtPurAmt.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString()
            TxtVATTax.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value.ToString()
            TxtNetAmt.Text = DataGridView1.Rows(e.RowIndex).Cells(8).Value.ToString()
            cmbPaidBy.Text = DataGridView1.Rows(e.RowIndex).Cells(9).Value.ToString()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub CmbDealerName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbDealerName.SelectedIndexChanged
        Try
            cm = New SqlCommand("select DlrAddr,DlrCntct from Dealer where DlrNm='" & (CmbDealerName.Text) & "'", cn)
            dr = cm.ExecuteReader()
            If dr.Read() Then
                txtAddr.Text = dr(0).ToString()
                txtContact.Text = dr(1).ToString()
            End If
            dr.Close()
        Catch ex As Exception

        End Try
    End Sub


    Private Sub cmbPaidBy_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPaidBy.SelectedIndexChanged
        Try
            cm = New SqlCommand("select EName from EmpMaster where EName= '" & (cmbPaidBy.Text) & "'", cn)

            dr = cm.ExecuteReader()
            If dr.Read() Then
                cmbPaidBy.Text = dr(0).ToString()
            End If
            dr.Close()
        Catch ex As Exception

        End Try
    End Sub

  
    Private Sub BtnAddPurDet_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddPurDet.Click
        PurchaseDetails.Show()
        PurchaseDetails.txtPurchaseId.Text = TxtPurchaseId.Text
        PurchaseDetails.txtDealer.Text = CmbDealerName.Text
        PurchaseDetails.txtBillNo.Text = txtBillNo.Text
        PurchaseDetails.Srlshow()
        ' Me.Hide()
    End Sub
End Class



