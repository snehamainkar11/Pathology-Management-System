Imports System.Data
Imports System.Data.SqlClient

Public Class frmExpences
    Dim cn As SqlConnection
    Dim cm As SqlCommand
    Dim dr As SqlDataReader
    Dim dt, dt3 As DataTable
    Dim n, c As Integer
    Dim x As New ClassCon
    Private Sub frmExpences_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatholabDBDataSet6.ExpenceTbl' table. You can move, or remove it, as needed.
        'Me.ExpenceTblTableAdapter.Fill(Me.PatholabDBDataSet6.ExpenceTbl)
        cn = New SqlConnection(x.s)
        cn.Open()
        dt = New DataTable()
        see()
        dt3 = New DataTable()
        seeEmp()
        btnnewid.Focus()
    End Sub
    Private Sub txtExpId_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtExpId.KeyPress
        If Not IsNumeric(e.KeyChar) = True And e.KeyChar <> vbBack Then
            e.Handled = True
            ToolTip1.Show("Only Number", txtExpId)
        Else
            ToolTip1.Hide(txtExpId)
        End If
    End Sub
    Private Sub EachRecord()
        Try
            txtExpId.Text = dt.Rows(c).Item(0).ToString()
            dtpExpDate.Value = CDate(dt.Rows(c).Item(1).ToString())
            txtExpTo.Text = dt.Rows(c).Item(2).ToString()
            txtExpDetl.Text = dt.Rows(c).Item(3).ToString()
            txtAmt.Text = dt.Rows(c).Item(4).ToString()
            Dim s As String = dt.Rows(c).Item(5).ToString()
            If s = "DD" Then
                rdbChq.Checked = True
            ElseIf s = "Cash" Then
                rdbCsh.Checked = True
            End If
            CmbPaidby.Text = dt.Rows(c).Item(6).ToString()
            txtChqNo.Text = dt.Rows(c).Item(7).ToString()
            dtpChqDate.Value = CDate(dt.Rows(c).Item(8).ToString())
            txtBnk.Text = dt.Rows(c).Item(9).ToString()
            txtBranch.Text = dt.Rows(c).Item(10).ToString()
        Catch ex As Exception

        End Try
    End Sub


    Private Sub see()
        dt.Clear()
        cm = New SqlCommand("select * from ExpenceTbl", cn)
        dr = cm.ExecuteReader()
        dt.Load(dr)
        dr.Close()
        n = dt.Rows.Count - 1
        DataGridView1.DataSource = dt

    End Sub
    Private Sub seeEmp()
        dt3.Clear()
        cm = New SqlCommand("select * from EmpMaster order by EId", cn)
        dr = cm.ExecuteReader()
        dt3.Load(dr)
        dr.Close()
        cmbPaidBy.DataSource = dt3
        cmbPaidBy.ValueMember = "EName"
        cmbPaidBy.DisplayMember = "EName"

    End Sub

    Private Sub btnnewid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnewid.Click
        cm = New SqlCommand("select max(ExpId) from ExpenceTbl", cn)
        dr = cm.ExecuteReader()
        If dr.Read() Then
            txtExpId.Text = CInt(dr(0) + 1)
        End If
        dr.Close()
        txtExpTo.Text = ""
        txtExpDetl.Text = ""
        txtAmt.Text = ""
        txtChqNo.Text = ""
        txtBnk.Text = ""
        txtBranch.Text = ""
        CmbPaidby.Text = ""
        rdbChq.Checked = False
        rdbCsh.Checked = False
    End Sub
    Private Sub cnt()
        cm = New SqlCommand("select count(ExpId) from ExpenceTbl", cn)
        dr = cm.ExecuteReader()
        If dr.Read() Then
            MsgBox("No. of Records=" & CInt(dr(0)), MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try

            txtExpId.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()
            dtpExpDate.Value = CDate(DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString())
            txtExpTo.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString()
            txtExpDetl.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString()
            txtAmt.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString()
            Dim s As String = DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString()
            If s = "DD" Then
                rdbChq.Checked = True
            ElseIf s = "Cash" Then
                rdbCsh.Checked = True
            End If
            CmbPaidby.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString()
            txtChqNo.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value.ToString()
            dtpChqDate.Value = CDate(DataGridView1.Rows(e.RowIndex).Cells(8).Value.ToString())
            txtBnk.Text = DataGridView1.Rows(e.RowIndex).Cells(9).Value.ToString()
            txtBranch.Text = DataGridView1.Rows(e.RowIndex).Cells(10).Value.ToString()

        Catch ex As Exception

        End Try

    End Sub
    Private Sub rdbChq_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbChq.CheckedChanged
        pnlChqDetail.Visible = True
    End Sub

    Private Sub rdbCsh_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbCsh.CheckedChanged
        pnlChqDetail.Visible = False
    End Sub

    Private Sub clear()
        dtpExpDate.Text = ""
        dtpChqDate.Text = ""
        txtExpId.Text = ""
        txtExpTo.Text = ""
        txtExpDetl.Text = ""
        CmbPaidby.Text = ""
        txtAmt.Text = ""
        txtBnk.Text = ""
        txtBranch.Text = ""
        txtChqNo.Text = ""
        rdbChq.Checked = False
        rdbCsh.Checked = False
    End Sub
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        clear()
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

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            Dim a As String = ""
            If rdbChq.Checked = True Then
                a = "DD"
            ElseIf rdbCsh.Checked = True Then
                a = "Cash"
            End If
            If rdbChq.Checked = True Then
                cm = New SqlCommand("insert into ExpenceTbl values(@ExpId,@EDate,@ExpTo,@Detail,@Amt,@PayType,@PayBy,@CqNo,@CqDte,@Bank,@Brnch)", cn)
                cm.Parameters.Add("@ExpId", SqlDbType.Int).Value = CInt(txtExpId.Text)
                cm.Parameters.Add("@EDate", SqlDbType.DateTime).Value = CDate(dtpExpDate.Value)
                cm.Parameters.Add("@ExpTo", SqlDbType.VarChar).Value = (txtExpTo.Text)
                cm.Parameters.Add("@Detail", SqlDbType.VarChar).Value = (txtExpDetl.Text)
                cm.Parameters.Add("@Amt", SqlDbType.Float).Value = CSng(txtAmt.Text)
                cm.Parameters.Add("@PayType", SqlDbType.VarChar).Value = a
                cm.Parameters.Add("@PayBy", SqlDbType.VarChar).Value = (CmbPaidby.Text)
                cm.Parameters.Add("@CqNo", SqlDbType.BigInt).Value = CLng(txtChqNo.Text)
                cm.Parameters.Add("@CqDte", SqlDbType.DateTime).Value = CDate(dtpChqDate.Value)
                cm.Parameters.Add("@Bank", SqlDbType.VarChar).Value = (txtBnk.Text)
                cm.Parameters.Add("@Brnch", SqlDbType.VarChar).Value = (txtBranch.Text)
                Dim x As Integer = cm.ExecuteNonQuery()
                If x = 1 Then
                    MsgBox("Record inserted successfully", MsgBoxStyle.Exclamation)
                Else
                    MsgBox("Error while inserting record", MsgBoxStyle.Critical)
                End If
            ElseIf rdbCsh.Checked = True Then
                cm = New SqlCommand("insert into ExpenceTbl(ExpId,EDate,ExpTo,Detail,Amt,PayType,PayBy) values(@ExpId,@EDate,@ExpTo,@Detail,@Amt,@PayType,@PayBy)", cn)
                cm.Parameters.Add("@ExpId", SqlDbType.Int).Value = CInt(txtExpId.Text)
                cm.Parameters.Add("@EDate", SqlDbType.DateTime).Value = CDate(dtpExpDate.Value)
                cm.Parameters.Add("@ExpTo", SqlDbType.VarChar).Value = (txtExpTo.Text)
                cm.Parameters.Add("@Detail", SqlDbType.VarChar).Value = (txtExpDetl.Text)
                cm.Parameters.Add("@Amt", SqlDbType.Float).Value = CSng(txtAmt.Text)
                cm.Parameters.Add("@PayType", SqlDbType.VarChar).Value = a
                cm.Parameters.Add("@PayBy", SqlDbType.VarChar).Value = (CmbPaidby.Text)

                Dim x As Integer = cm.ExecuteNonQuery()
                If x = 1 Then
                    MsgBox("Record inserted successfully", MsgBoxStyle.Exclamation)
                Else
                    MsgBox("Error while inserting record", MsgBoxStyle.Critical)
                End If
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
            Dim a As String = ""
            If rdbChq.Checked = True Then
                a = "DD"
            ElseIf rdbCsh.Checked = True Then
                a = "Cash"
            End If
            If rdbChq.Checked = True Then
                cm = New SqlCommand("update ExpenceTbl set EDate=@EDate,ExpTo=@ExpTo,Detail=@Detail,Amt=@Amt,PayType=@PayType,PayBy=@PayBy,CqNo=@CqNo,CqDte=@CqDte,Bank=@Bank,Brnch=@Brnch where ExpId=@ExpId", cn)
                cm.Parameters.Add("@ExpId", SqlDbType.Int).Value = CInt(txtExpId.Text)
                cm.Parameters.Add("@EDate", SqlDbType.DateTime).Value = CDate(dtpExpDate.Value)
                cm.Parameters.Add("@ExpTo", SqlDbType.VarChar).Value = (txtExpTo.Text)
                cm.Parameters.Add("@Detail", SqlDbType.VarChar).Value = (txtExpDetl.Text)
                cm.Parameters.Add("@Amt", SqlDbType.Float).Value = CSng(txtAmt.Text)
                cm.Parameters.Add("@PayType", SqlDbType.VarChar).Value = a
                cm.Parameters.Add("@PayBy", SqlDbType.VarChar).Value = (CmbPaidby.Text)
                cm.Parameters.Add("@CqNo", SqlDbType.BigInt).Value = CLng(txtChqNo.Text)
                cm.Parameters.Add("@CqDte", SqlDbType.DateTime).Value = CDate(dtpChqDate.Value)
                cm.Parameters.Add("@Bank", SqlDbType.VarChar).Value = (txtBnk.Text)
                cm.Parameters.Add("@Brnch", SqlDbType.VarChar).Value = (txtBranch.Text)
                Dim x As Integer = cm.ExecuteNonQuery()
                If x = 1 Then
                    MsgBox("Record updated successfully", MsgBoxStyle.Exclamation)
                Else
                    MsgBox("Error while updating record", MsgBoxStyle.Critical)
                End If
            ElseIf rdbCsh.Checked = True Then
                cm = New SqlCommand("update ExpenceTbl set EDate=@EDate,ExpTo=@ExpTo,Detail=@Detail,Amt=@Amt,PayType=@PayType,PayBy=@PayBy,CqNo=NULL,CqDte=NULL,Bank=NULL,Brnch=NULL where ExpId=@ExpId", cn)
                cm.Parameters.Add("@ExpId", SqlDbType.Int).Value = CInt(txtExpId.Text)
                cm.Parameters.Add("@EDate", SqlDbType.DateTime).Value = CDate(dtpExpDate.Value)
                cm.Parameters.Add("@ExpTo", SqlDbType.VarChar).Value = (txtExpTo.Text)
                cm.Parameters.Add("@Detail", SqlDbType.VarChar).Value = (txtExpDetl.Text)
                cm.Parameters.Add("@Amt", SqlDbType.Float).Value = CSng(txtAmt.Text)
                cm.Parameters.Add("@PayType", SqlDbType.VarChar).Value = a
                cm.Parameters.Add("@PayBy", SqlDbType.VarChar).Value = (CmbPaidby.Text)
                Dim x As Integer = cm.ExecuteNonQuery()
                If x = 1 Then
                    MsgBox("Record updated successfully", MsgBoxStyle.Exclamation)
                Else
                    MsgBox("Error while updating record", MsgBoxStyle.Critical)
                End If
            End If
            see()
            'cnt()
            clear()
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If MsgBox("Do You want to delete ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                cm = New SqlCommand("delete from ExpenceTbl where ExpId=@ExpId", cn)
                cm.Parameters.Add("@ExpId", SqlDbType.Int).Value = CInt(txtExpId.Text)
                Dim x As Integer = cm.ExecuteNonQuery()
                If x = 1 Then
                    MsgBox("Record deleted successfully", MsgBoxStyle.Exclamation)
                Else
                    MsgBox("Error while deleting record", MsgBoxStyle.Critical)
                End If
                clear()
                see()
            Else
                clear()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnClear_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        clear()
    End Sub

  
    Private Sub lblLnkPrint_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblLnkPrint.LinkClicked
        Me.Hide()
        rptExpence.Show()
    End Sub

    Private Sub CmbPaidby_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbPaidby.SelectedIndexChanged
        Try
            cm = New SqlCommand("select EName from EmpMaster where EName= '" & (CmbPaidby.Text) & "'", cn)

            dr = cm.ExecuteReader()
            If dr.Read() Then
                CmbPaidby.Text = dr(0).ToString()
            End If
            dr.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtAmt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAmt.KeyPress
        If Not IsNumeric(e.KeyChar) = True And e.KeyChar <> vbBack Then
            e.Handled = True
            ToolTip1.Show("Only Number", txtAmt)
        Else
            ToolTip1.Hide(txtAmt)
        End If
    End Sub

    Private Sub txtChqNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtChqNo.KeyPress
        If Not IsNumeric(e.KeyChar) = True And e.KeyChar <> vbBack Then
            e.Handled = True
            ToolTip1.Show("Only Number", txtChqNo)
        Else
            ToolTip1.Hide(txtChqNo)
        End If
    End Sub

    Private Sub PnlCustOperations_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PnlCustOperations.Paint

    End Sub
End Class
