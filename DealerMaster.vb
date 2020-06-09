Imports System.Data
Imports System.Data.SqlClient
Public Class DealerMaster
    Private cn As SqlConnection
    Private cm As SqlCommand
    Private dr As SqlDataReader
    Private dt, dtable1 As New DataTable
    Dim c, n, i As Integer
    Dim x As New ClassCon
    Private Sub DealerMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatholabDBDataSet17.Dealer' table. You can move, or remove it, as needed.
        'Me.DealerTableAdapter.Fill(Me.PatholabDBDataSet17.Dealer)
        cn = New SqlConnection(x.s)
        cn.Open()
        dt = New DataTable()
        see()
        btnnewid.Focus()
    End Sub
    Private Sub see()
        dt.Clear()
        cm = New SqlCommand("select * from Dealer order by DlrId", cn)
        dr = cm.ExecuteReader()
        dt.Load(dr)
        dr.Close()
        n = dt.Rows.Count - 1
        DataGridView1.DataSource = dt

    End Sub

    Private Sub EachRecord()
        Try

            TxtDealerId.Text = dt.Rows(c).Item(0).ToString()
            TxtDealerName.Text = dt.Rows(c).Item(1).ToString()
            TxtDealerAddress.Text = dt.Rows(c).Item(2).ToString()
            TxtDealerContactNo.Text = dt.Rows(c).Item(3).ToString()
            TxtDealerEmail.Text = dt.Rows(c).Item(4).ToString()
            TxtCompany.Text = dt.Rows(c).Item(5).ToString()
            TxtAccNo.Text = dt.Rows(c).Item(6).ToString()
            TxtAccName.Text = dt.Rows(c).Item(7).ToString()
            TxtBankName.Text = dt.Rows(c).Item(8).ToString()
            TxtBranchName.Text = dt.Rows(c).Item(9).ToString()
            TxtIFSC.Text = dt.Rows(c).Item(10).ToString()

        Catch ex As Exception

        End Try
    End Sub
    Private Sub BtnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFirst.Click
        c = 0
        EachRecord()
    End Sub
    Private Sub BtnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrev.Click
        If c > 0 Then
            c -= 1
            EachRecord()
        Else
            MsgBox("First Record")
        End If
    End Sub
    Private Sub BtnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNext.Click
        If c < n Then
            c += 1
            EachRecord()
        Else
            MsgBox("Last Record")
        End If
    End Sub
    Private Sub BtnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLast.Click
        c = n
        EachRecord()
    End Sub

    Private Sub btnnewid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnewid.Click
        cm = New SqlCommand("select max(DlrId) from Dealer", cn)
        dr = cm.ExecuteReader()
        If dr.Read() Then
            TxtDealerId.Text = CInt(dr(0) + 1)
        End If
        dr.Close()
        TxtDealerName.Text = ""
        TxtDealerAddress.Text = ""
        TxtDealerContactNo.Text = ""
        TxtDealerEmail.Text = ""
        TxtCompany.Text = ""
        TxtAccNo.Text = ""
        TxtAccName.Text = ""
        TxtBankName.Text = ""
        TxtBranchName.Text = ""
        TxtIFSC.Text = ""
    End Sub
    Private Sub cnt()
        cm = New SqlCommand("select count(DlrId) from Dealer", cn)
        dr = cm.ExecuteReader()
        If dr.Read() Then
            MsgBox("No. of Dealer Records=" & CInt(dr(0)), MsgBoxStyle.Information)
        End If
    End Sub
    Private Sub clear()
        TxtDealerId.Text = ""
        TxtDealerName.Text = ""
        TxtDealerAddress.Text = ""
        TxtDealerContactNo.Text = ""
        TxtDealerEmail.Text = ""
        TxtAccNo.Text = ""
        TxtAccName.Text = ""
        TxtBankName.Text = ""
        TxtBranchName.Text = ""
        TxtIFSC.Text = ""
        TxtCompany.Text = ""
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            cm = New SqlCommand("Insert into Dealer values(@DlrId,@DlrNm,@DlrAddr,@DlrCntct,@DlrEmail,@Company,@ACNo,@ACNm,@BankNm,@BrnchNm,@IFSC)", cn)
            cm.Parameters.Add("@DlrId", SqlDbType.Int).Value = CInt(TxtDealerId.Text)
            cm.Parameters.Add("@DlrNm", SqlDbType.VarChar).Value = (TxtDealerName.Text)
            cm.Parameters.Add("@DlrAddr", SqlDbType.NVarChar).Value = (TxtDealerAddress.Text)
            cm.Parameters.Add("@DlrCntct", SqlDbType.VarChar).Value = CLng(TxtDealerContactNo.Text)
            cm.Parameters.Add("@DlrEmail", SqlDbType.NVarChar).Value = (TxtDealerEmail.Text)
            cm.Parameters.Add("@Company", SqlDbType.VarChar).Value = (TxtCompany.Text)
            cm.Parameters.Add("@ACNo", SqlDbType.BigInt).Value = CLng(TxtAccNo.Text)
            cm.Parameters.Add("@ACNm", SqlDbType.VarChar).Value = (TxtAccName.Text)
            cm.Parameters.Add("@BankNm", SqlDbType.VarChar).Value = (TxtBankName.Text)
            cm.Parameters.Add("@BrnchNm", SqlDbType.VarChar).Value = (TxtBranchName.Text)
            cm.Parameters.Add("@IFSC", SqlDbType.NVarChar).Value = (TxtIFSC.Text)

            Dim r As Integer = cm.ExecuteNonQuery()
            If r = 1 Then
                MsgBox("Record inserted successfully", MsgBoxStyle.Exclamation)
            Else
                MsgBox("Error while inserting record", MsgBoxStyle.RetryCancel)

            End If
            see()
            cnt()
            clear()
            dr.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            cm = New SqlCommand("Update Dealer set DlrNm=@DlrNm,DlrAddr=@DlrAddr,DlrCntct=@DlrCntct,DlrEmail=@DlrEmail,Company=@Company,ACNo=@ACNo,ACNm=@ACNm,BankNm=@BankNm,BrnchNm=@BrnchNm,IFSC=@IFSC where DlrId=@DlrId", cn)
            cm.Parameters.Add("@DlrId", SqlDbType.Int).Value = CInt(TxtDealerId.Text)
            cm.Parameters.Add("@DlrNm", SqlDbType.VarChar).Value = (TxtDealerName.Text)
            cm.Parameters.Add("@DlrAddr", SqlDbType.NVarChar).Value = (TxtDealerAddress.Text)
            cm.Parameters.Add("@DlrCntct", SqlDbType.VarChar).Value = CLng(TxtDealerContactNo.Text)
            cm.Parameters.Add("@DlrEmail", SqlDbType.NVarChar).Value = (TxtDealerEmail.Text)
            cm.Parameters.Add("@Company", SqlDbType.VarChar).Value = (TxtCompany.Text)
            cm.Parameters.Add("@ACNo", SqlDbType.BigInt).Value = CLng(TxtAccNo.Text)
            cm.Parameters.Add("@ACNm", SqlDbType.VarChar).Value = (TxtAccName.Text)
            cm.Parameters.Add("@BankNm", SqlDbType.VarChar).Value = (TxtBankName.Text)
            cm.Parameters.Add("@BrnchNm", SqlDbType.VarChar).Value = (TxtBranchName.Text)
            cm.Parameters.Add("@IFSC", SqlDbType.NVarChar).Value = (TxtIFSC.Text)

            Dim r As Integer = cm.ExecuteNonQuery()
            If r = 1 Then
                MsgBox("Record updated successfully", MsgBoxStyle.Exclamation)
            Else
                MsgBox("Error while updating record", MsgBoxStyle.RetryCancel)

            End If
            see()

            clear()
            dr.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If MsgBox("Do You want to Delete ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                cm = New SqlCommand("delete from Dealer where DlrId=@DlrId", cn)
                cm.Parameters.AddWithValue("@DlrId", (TxtDealerId.Text))
                Dim r As Integer = cm.ExecuteNonQuery()
                If r = 1 Then
                    MsgBox("Record deleted Successfully", MsgBoxStyle.Exclamation)
                Else
                    MsgBox("Error in deleting record", MsgBoxStyle.RetryCancel)
                End If
                see()
                cnt()
                clear()
                dr.Close()
            Else
                clear()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        clear()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        TxtDealerId.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()
        TxtDealerName.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString()
        TxtDealerAddress.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString()
        TxtDealerContactNo.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString()
        TxtDealerEmail.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString()
        TxtCompany.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString()
        TxtAccNo.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString()
        TxtAccName.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value.ToString()
        TxtBankName.Text = DataGridView1.Rows(e.RowIndex).Cells(8).Value.ToString()
        TxtBranchName.Text = DataGridView1.Rows(e.RowIndex).Cells(9).Value.ToString()
        TxtIFSC.Text = DataGridView1.Rows(e.RowIndex).Cells(10).Value.ToString()
    End Sub

    Private Sub TxtDealerContactNo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtDealerContactNo.GotFocus
        TxtDealerContactNo.BackColor = Color.Yellow
        TxtDealerContactNo.Focus()

    End Sub

    Private Sub TxtDealerContactNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDealerContactNo.KeyPress

        If Not IsNumeric(e.KeyChar) = True And e.KeyChar <> vbBack Then
            e.Handled = True
            ToolTip1.Show("Only Number", TxtDealerContactNo)
        Else
            ToolTip1.Hide(TxtDealerContactNo)
        End If
    End Sub

    Private Sub TxtDealerContactNo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtDealerContactNo.LostFocus
        Dim s As String = TxtDealerContactNo.Text
        TxtDealerContactNo.BackColor = Color.White
        If s.Length <> 10 Then
            MsgBox("Enter exact 10 Digit")
            TxtDealerContactNo.Focus()
        End If
    End Sub

    Private Sub TxtDealerId_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDealerId.KeyPress
        If Not IsNumeric(e.KeyChar) = True And e.KeyChar <> vbBack Then
            e.Handled = True
            ToolTip1.Show("Only Number", TxtDealerId)
        Else
            ToolTip1.Hide(TxtDealerId)
        End If
    End Sub


    Private Sub TxtDealerEmail_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtDealerEmail.LostFocus
        Dim m As String = TxtDealerEmail.Text
        If Not m.Contains("@") Or Not m.Contains(".") Or (m.LastIndexOf(".") < m.IndexOf("@")) Then
            ToolTip1.Show("Error in Email Id", TxtDealerEmail)
        Else
            ToolTip1.Hide(TxtDealerEmail)
        End If
    End Sub


    Private Sub TxtAccNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAccNo.KeyPress
        If Not IsNumeric(e.KeyChar) = True And e.KeyChar <> vbBack Then
            e.Handled = True
            ToolTip1.Show("Only Number", TxtAccNo)
        Else
            ToolTip1.Hide(TxtAccNo)
        End If
    End Sub

 
   
    Private Sub TxtDealerContactNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDealerContactNo.TextChanged

    End Sub
End Class