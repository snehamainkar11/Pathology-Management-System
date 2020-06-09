
Imports System.Data
Imports System.Data.SqlClient
Public Class ReportForward
    Private cn As SqlConnection
    Private cm As SqlCommand
    Private dr As SqlDataReader
    Private dt, dt1 As New DataTable
    Dim c, n, i As Integer
    Dim x As New ClassCon
    Private Sub ReportForward_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatholabDBDataSet12.RFrwd' table. You can move, or remove it, as needed.
        'Me.RFrwdTableAdapter.Fill(Me.PatholabDBDataSet12.RFrwd)
        'TODO: This line of code loads data into the 'PatholabDBDataSet12.RFrwd' table. You can move, or remove it, as needed.
        'Me.RFrwdTableAdapter.Fill(Me.PatholabDBDataSet12.RFrwd)
        'TODO: This line of code loads data into the 'PatholabDBDataSet12.RFrwd' table. You can move, or remove it, as needed.
        'Me.RFrwdTableAdapter.Fill(Me.PatholabDBDataSet12.RFrwd)
        btnnewid.Focus()
        cn = New SqlConnection(x.s)
        cn.Open()
        dt1 = New DataTable()
        see1()
        dt = New DataTable()
        see()

    End Sub

    Private Sub txtRFId_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRFId.KeyPress
        If Not IsNumeric(e.KeyChar) = True And e.KeyChar <> vbBack Then
            e.Handled = True
            ToolTip1.Show("Only Number", txtRFId)
        Else
            ToolTip1.Hide(txtRFId)
        End If
    End Sub

    Private Sub see()
        dt.Clear()
        cm = New SqlCommand("select * from RFrwd order by RFId", cn)
        dr = cm.ExecuteReader()
        dt.Load(dr)
        dr.Close()
        n = dt.Rows.Count - 1
        DataGridView1.DataSource = dt

    End Sub
    Private Sub see1()
        dt1.Clear()
        cm = New SqlCommand("select * from RInwrd order by RInId", cn)
        dr = cm.ExecuteReader()
        dt1.Load(dr)
        dr.Close()
        cmbRInId.DataSource = dt1
        cmbRInId.ValueMember = "RInId"
        cmbRInId.DisplayMember = "RInId"
      
    End Sub
    Private Sub EachRecord()
        txtRFId.Text = dt.Rows(c).Item(0).ToString()
        cmbRInId.Text = dt.Rows(c).Item(1).ToString()
        txtPatNm.Text = dt.Rows(c).Item(2).ToString()
        txtPatAddr.Text = dt.Rows(c).Item(3).ToString()
        txtDocNm.Text = dt.Rows(c).Item(4).ToString()
        txtDises.Text = dt.Rows(c).Item(5).ToString()
        lstTest.SelectedIndex = dt.Rows(c).Item(6).ToString()
        txtRmarkByDr.Text = dt.Rows(c).Item(7).ToString()
        dtpRprtDlvryDte.Value = CDate(dt.Rows(c).Item(8).ToString())
        txtRcvBy.Text = dt.Rows(c).Item(9).ToString()
        dtpRFDate.Value = CDate(dt.Rows(c).Item(10).ToString())
        txtContact.Text = dt.Rows(c).Item(11).ToString()
        txtFrwdRsn.Text = dt.Rows(c).Item(12).ToString()
        txtFrwdToLb.Text = dt.Rows(c).Item(13).ToString()
        txtFrwdLbAddr.Text = dt.Rows(c).Item(14).ToString()
        txtFrwdCntct.Text = dt.Rows(c).Item(15).ToString()

    End Sub
    Private Sub cnt()
        cm = New SqlCommand("select count(RFId) from RFrwd", cn)
        dr = cm.ExecuteReader()
        If dr.Read() Then
            MsgBox("No. of records=" & CInt(dr(0)), MsgBoxStyle.Information)
        End If
    End Sub
    Private Sub clear()
        txtRFId.Text = ""
        cmbRInId.Text = ""
        txtPatNm.Text = ""
        txtPatAddr.Text = ""
        txtDises.Text = ""
        txtDocNm.Text = ""
        txtRcvBy.Text = ""
        txtRmarkByDr.Text = ""
        txtContact.Text = ""
        txtFrwdCntct.Text = ""
        txtFrwdLbAddr.Text = ""
        txtFrwdToLb.Text = ""
        txtFrwdRsn.Text = ""
        lstTest.Items.Clear()
    End Sub
    Private Sub BtnFirst_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFirst.Click
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
        cm = New SqlCommand("select max(RFId) from RFrwd", cn)
        dr = cm.ExecuteReader()
        If dr.Read() Then
            txtRFId.Text = CInt(dr(0) + 1)
        End If
        dr.Close()
        cmbRInId.Text = ""
        txtPatNm.Text = ""
        txtPatAddr.Text = ""
        txtDises.Text = ""
        lstTest.Items.Clear()
        txtRmarkByDr.Text = ""
        txtDises.Text = ""
        txtDocNm.Text = ""
        txtRcvBy.Text = ""
        txtContact.Text = ""
        txtFrwdCntct.Text = ""
        txtFrwdLbAddr.Text = ""
        txtFrwdToLb.Text = ""
        txtFrwdRsn.Text = ""
    End Sub
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        Try

        
            txtRFId.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()
            cmbRInId.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString()
            txtPatNm.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString()
            txtPatAddr.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString()
            txtDocNm.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString()
            txtDises.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString()
            lstTest.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString()
            txtRmarkByDr.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value.ToString()
            dtpRprtDlvryDte.Value = CDate(DataGridView1.Rows(e.RowIndex).Cells(8).Value.ToString())
            txtRcvBy.Text = DataGridView1.Rows(e.RowIndex).Cells(9).Value.ToString()
            dtpRFDate.Value = CDate(DataGridView1.Rows(e.RowIndex).Cells(10).Value.ToString())
            txtContact.Text = DataGridView1.Rows(e.RowIndex).Cells(11).Value.ToString()
            txtFrwdRsn.Text = DataGridView1.Rows(e.RowIndex).Cells(12).Value.ToString()
            txtFrwdToLb.Text = DataGridView1.Rows(e.RowIndex).Cells(13).Value.ToString()
            txtFrwdLbAddr.Text = DataGridView1.Rows(e.RowIndex).Cells(14).Value.ToString()
            txtFrwdCntct.Text = DataGridView1.Rows(e.RowIndex).Cells(15).Value.ToString()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            Dim ii As IEnumerator = lstTest.SelectedItems.GetEnumerator()
            Dim s As String = ""
            While ii.MoveNext
                s &= ii.Current & ",".ToString()
            End While
            Dim x As String = ""
            x &= s.Substring(0, s.Length - 1)
            cm = New SqlCommand("insert into RFrwd values(@RFId,@RInId,@PNm,@PAddr,@DrNm,@Disease,@TestName,@RmrkByDr,@RprtDlvryDate,@RefBy,@RDate,@Cntct,@FRsn,@FtoLab,@FLabAddr,@FCntct)", cn)
            cm.Parameters.Add("@RFId", SqlDbType.Int).Value = CInt(txtRFId.Text)
            cm.Parameters.Add("@RInId", SqlDbType.Int).Value = CInt(cmbRInId.Text)
            cm.Parameters.Add("@PNm", SqlDbType.VarChar).Value = (txtPatNm.Text)
            cm.Parameters.Add("@PAddr", SqlDbType.NVarChar).Value = (txtPatAddr.Text)
            cm.Parameters.Add("@DrNm", SqlDbType.VarChar).Value = (txtDocNm.Text)
            cm.Parameters.Add("@Disease", SqlDbType.VarChar).Value = (txtDises.Text)
            cm.Parameters.Add("@TestName", SqlDbType.NVarChar).Value = x
            cm.Parameters.Add("@RmrkByDr", SqlDbType.NVarChar).Value = (txtRmarkByDr.Text)
            cm.Parameters.Add("@RprtDlvryDate", SqlDbType.DateTime).Value = CDate(dtpRprtDlvryDte.Value)
            cm.Parameters.Add("@RefBy", SqlDbType.VarChar).Value = (txtRcvBy.Text)
            cm.Parameters.Add("@RDate", SqlDbType.DateTime).Value = CDate(dtpRFDate.Value)
            cm.Parameters.Add("@Cntct", SqlDbType.BigInt).Value = CLng(txtContact.Text)
            cm.Parameters.Add("@FRsn", SqlDbType.NVarChar).Value = (txtFrwdRsn.Text)
            cm.Parameters.Add("@FtoLab", SqlDbType.VarChar).Value = (txtFrwdToLb.Text)
            cm.Parameters.Add("@FLabAddr", SqlDbType.NVarChar).Value = (txtFrwdLbAddr.Text)
            cm.Parameters.Add("@FCntct", SqlDbType.BigInt).Value = (txtFrwdCntct.Text)

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


    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If MsgBox("Do You want to Delete ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                cm = New SqlCommand("delete from RFrwd where RFId=@RFId", cn)
                cm.Parameters.AddWithValue("@RFId", (txtRFId.Text))
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



    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try

            Dim ii As IEnumerator = lstTest.SelectedItems.GetEnumerator()
            Dim s As String = ""
            While ii.MoveNext
                s &= ii.Current & ",".ToString()
            End While
            Dim x As String = ""
            x &= s.Substring(0, s.Length - 1)
            cm = New SqlCommand("update RFrwd set RInId=@RInId,PNm=@PNm,PAddr=@PAddr,DrNm=@DrNm,Disease=@Disease,TestName=@TestName,RmrkByDr=@RmrkByDr,RprtDlvryDate=@RprtDlvryDate,RefBy=@RefBy,RDate=@RDate,Cntct=@Cntct,FRsn=@FRsn,FtoLab=@FtoLab,FLabAddr=@FLabAddr,FCntct=@FCntct where RFId=@RFId", cn)
            cm.Parameters.Add("@RFId", SqlDbType.Int).Value = CInt(txtRFId.Text)
            cm.Parameters.Add("@RInId", SqlDbType.Int).Value = CInt(cmbRInId.Text)
            cm.Parameters.Add("@PNm", SqlDbType.VarChar).Value = (txtPatNm.Text)
            cm.Parameters.Add("@PAddr", SqlDbType.NVarChar).Value = (txtPatAddr.Text)
            cm.Parameters.Add("@DrNm", SqlDbType.VarChar).Value = (txtDocNm.Text)
            cm.Parameters.Add("@Disease", SqlDbType.VarChar).Value = (txtDises.Text)
            cm.Parameters.Add("@TestName", SqlDbType.NVarChar).Value = x
            cm.Parameters.Add("@RmrkByDr", SqlDbType.NVarChar).Value = (txtRmarkByDr.Text)
            cm.Parameters.Add("@RprtDlvryDate", SqlDbType.DateTime).Value = CDate(dtpRprtDlvryDte.Value)
            cm.Parameters.Add("@RefBy", SqlDbType.VarChar).Value = (txtRcvBy.Text)
            cm.Parameters.Add("@RDate", SqlDbType.DateTime).Value = CDate(dtpRFDate.Value)
            cm.Parameters.Add("@Cntct", SqlDbType.BigInt).Value = CLng(txtContact.Text)
            cm.Parameters.Add("@FRsn", SqlDbType.NVarChar).Value = (txtFrwdRsn.Text)
            cm.Parameters.Add("@FtoLab", SqlDbType.VarChar).Value = (txtFrwdToLb.Text)
            cm.Parameters.Add("@FLabAddr", SqlDbType.NVarChar).Value = (txtFrwdLbAddr.Text)
            cm.Parameters.Add("@FCntct", SqlDbType.BigInt).Value = (txtFrwdCntct.Text)
            Dim r As Integer = cm.ExecuteNonQuery()
            If r = 1 Then
                MsgBox("Record updated successfully", MsgBoxStyle.Exclamation)
            Else
                MsgBox("Error while updating record", MsgBoxStyle.RetryCancel)

            End If
            see()
            'cnt()
            clear()
            dr.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtContact_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtContact.GotFocus
        txtContact.BackColor = Color.Yellow
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

    Private Sub txtFrwdCntct_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFrwdCntct.GotFocus
        txtFrwdCntct.BackColor = Color.Yellow
        txtFrwdCntct.Focus()
    End Sub

    Private Sub txtFrwdCntct_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFrwdCntct.KeyPress
        If Not IsNumeric(e.KeyChar) = True And e.KeyChar <> vbBack Then
            e.Handled = True
            ToolTip1.Show("Only Number", txtFrwdCntct)
        Else
            ToolTip1.Hide(txtFrwdCntct)
        End If
    End Sub

    Private Sub txtFrwdCntct_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFrwdCntct.LostFocus
        Dim s As String = txtFrwdCntct.Text
        txtFrwdCntct.BackColor = Color.White
        If s.Length <> 10 Then
            MsgBox("Enter exact 10 Digit")
            txtFrwdCntct.Focus()
        End If
    End Sub



    Private Sub cmbRInId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRInId.SelectedIndexChanged
        Try

            cm = New SqlCommand("select PNm,PAddr,ContactNo,DrNm,Disease,TestName,RcvBy from RInwrd where RInId=" & CInt(cmbRInId.Text), cn)
            dr = cm.ExecuteReader()
            If dr.Read() Then
                txtPatNm.Text = dr(0).ToString()
                txtPatAddr.Text = dr(1).ToString()
                txtContact.Text = dr(2).ToString()
                txtRcvBy.Text = dr(3).ToString()
                txtDises.Text = dr(4).ToString()
                txtDocNm.Text = dr(6).ToString()
                Dim xx As String = dr(5).ToString
                For Each x1 In lstTest.Items.Count.ToString
                    Dim yy() As String = xx.Split(",", x1)
                    lstTest.Items.Clear()

                    For Each z In yy
                        lstTest.Items.Add(z)
                    Next
                Next
            End If

           
            dr.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lblLnkPrint_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblLnkPrint.LinkClicked
        Me.Hide()
        rptForward.Show()
    End Sub

    Private Sub PnlCustNavigation_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PnlCustNavigation.Paint

    End Sub
End Class