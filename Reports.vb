﻿Imports System.Data
Imports System.Data.SqlClient
Public Class Reports
    Private cn As SqlConnection
    Private cm As SqlCommand
    Private dr As SqlDataReader
    Private dt, dt1, dt2, dt3 As New DataTable
    Dim c, n, i As Integer
    Dim x As New ClassCon
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatholabDBDataSet28.Result' table. You can move, or remove it, as needed.
        'Me.ResultTableAdapter.Fill(Me.PatholabDBDataSet28.Result)
        'TODO: This line of code loads data into the 'PatholabDBDataSet18.Result' table. You can move, or remove it, as needed.
        'Me.ResultTableAdapter.Fill(Me.PatholabDBDataSet18.Result)
        cn = New SqlConnection(x.s)
        cn.Open()
        dt1 = New DataTable()
        seeData()
        dt = New DataTable()
        see()
        btnnewid.Focus()
        'dt3 = New DataTable()
        'see1()
    End Sub

    Private Sub txtRCId_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRCId.KeyPress
        If Not IsNumeric(e.KeyChar) = True And e.KeyChar <> vbBack Then
            e.Handled = True
            ToolTip1.Show("Only Number", txtRCId)
        Else
            ToolTip1.Hide(txtRCId)
        End If
    End Sub
    Private Sub txtRInId_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not IsNumeric(e.KeyChar) = True And e.KeyChar <> vbBack Then
            e.Handled = True
            ToolTip1.Show("Only Number", cmbRInId)
        Else
            ToolTip1.Hide(cmbRInId)
        End If
    End Sub
    Private Sub txtContact_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtContact.GotFocus
        txtContact.BackColor = Color.Yellow
        txtContact.Focus()
    End Sub
    Private Sub see()
        Try


            dt.Clear()
            cm = New SqlCommand("select * from TestReport  where RCId = '" & (txtRCId.Text) & "' ", cn)
            dr = cm.ExecuteReader()
            dt.Load(dr)
            dr.Close()
            n = dt.Rows.Count - 1
            DataGridView1.DataSource = dt
        Catch ex As Exception

        End Try
    End Sub



    Private Sub seeData()
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
        Try
            txtRCId.Text = dt.Rows(c).Item(0).ToString()
            cmbRInId.Text = dt.Rows(c).Item(1).ToString()
            txtPatNm.Text = dt.Rows(c).Item(2).ToString()
            txtPatAddr.Text = dt.Rows(c).Item(3).ToString()
            txtContact.Text = dt.Rows(c).Item(4).ToString()
            txtDoctor.Text = dt.Rows(c).Item(5).ToString()
            txtDisease.Text = dt.Rows(c).Item(6).ToString()
            txtTestNo.Text = dt.Rows(c).Item(7).ToString()
            cmbTest.Text = dt.Rows(c).Item(8).ToString()
            txtResult.Text = dt.Rows(c).Item(9).ToString()
            txtNRange.Text = dt.Rows(c).Item(10).ToString()
            DTPRprtDlvryDte.Text = CDate(dt.Rows(c).Item(11).ToString())
            txtRefBy.Text = dt.Rows(c).Item(12).ToString()
            txtRmarkByDr.Text = dt.Rows(c).Item(13).ToString()
            DTPRInDte.Text = CDate(dt.Rows(c).Item(14).ToString())
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
        Try

            cm = New SqlCommand("select max(RCId) from TestReport ", cn)
            dr = cm.ExecuteReader()
            If dr.Read() Then
                txtRCId.Text = CInt(dr(0) + 1)
            End If
            dr.Close()
            see()
            cmbTest.Text = ""
            cmbRInId.Text = ""
            txtPatNm.Text = ""
            txtPatAddr.Text = ""
            txtContact.Text = ""
            txtDisease.Text = ""
            txtResult.Text = ""
            txtRmarkByDr.Text = ""
            txtDoctor.Text = ""
            txtNRange.Text = ""
            txtRefBy.Text = ""

            DTPRprtDlvryDte.Text = ""
            txtTestNo.Text = ""
        Catch ex As Exception
            ' txtRCId.Text = "1"
            dr.Close()
        End Try

    End Sub

    Private Sub cnt()
        cm = New SqlCommand("select count(RCId) from TestReport", cn)
        dr = cm.ExecuteReader()
        If dr.Read() Then
            MsgBox("No. of records=" & CInt(dr(0)), MsgBoxStyle.Information)
        End If
    End Sub
    Private Sub clear()
        txtRCId.Text = ""
        cmbRInId.Text = ""
        txtPatNm.Text = ""
        txtPatAddr.Text = ""
        txtContact.Text = ""
        txtDisease.Text = ""
        txtResult.Text = ""
        txtRmarkByDr.Text = ""
        cmbTest.Text = ""
        txtTestNo.Text = ""
        txtResult.Text = ""
        txtRefBy.Text = ""
        txtDoctor.Text = ""
        txtRefBy.Text = ""
        txtNRange.Text = ""
        DTPRprtDlvryDte.Text = ""
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try

            cm = New SqlCommand("Insert into TestReport values(@RCId, @RInId,@PName,@PAddr,@Contact,@DrNm,@Disease,@TestNo,@TestName,@Result,@NRange,@DlvryDate,@RefBy,@RemarkByDoctor,@RDate)", cn)
            cm.Parameters.Add("@RCId", SqlDbType.Int).Value = CInt(txtRCId.Text)
            cm.Parameters.Add("@RInId", SqlDbType.Int).Value = CInt(cmbRInId.Text)
            cm.Parameters.Add("@PName", SqlDbType.VarChar).Value = (txtPatNm.Text)
            cm.Parameters.Add("@PAddr", SqlDbType.NVarChar).Value = (txtPatAddr.Text)
            cm.Parameters.Add("@Contact", SqlDbType.BigInt).Value = CLng(txtContact.Text)
            cm.Parameters.Add("@DrNm", SqlDbType.VarChar).Value = (txtDoctor.Text)
            cm.Parameters.Add("@Disease", SqlDbType.NVarChar).Value = (txtDisease.Text)
            cm.Parameters.Add("@TestNo", SqlDbType.Int).Value = CInt(txtTestNo.Text)
            cm.Parameters.Add("@TestName", SqlDbType.NVarChar).Value = (cmbTest.Text)
            cm.Parameters.Add("@Result", SqlDbType.Float).Value = CSng(txtResult.Text)
            cm.Parameters.Add("@NRange", SqlDbType.NVarChar).Value = (txtNRange.Text)
            cm.Parameters.Add("@DlvryDate", SqlDbType.DateTime).Value = CDate(DTPRprtDlvryDte.Value)
            cm.Parameters.Add("@RefBy", SqlDbType.VarChar).Value = (txtRefBy.Text)
            cm.Parameters.Add("@RemarkByDoctor", SqlDbType.NVarChar).Value = (txtRmarkByDr.Text)
            cm.Parameters.Add("@RDate", SqlDbType.DateTime).Value = CDate(DTPRInDte.Value)

            Dim r As Integer = cm.ExecuteNonQuery()
            If r = 1 Then
                MsgBox("Record inserted successfully", MsgBoxStyle.Exclamation)
            Else
                MsgBox("Error while inserting record", MsgBoxStyle.RetryCancel)

            End If
            see()
            txtTestNo.Text = ""
            cmbTest.Text = ""
            txtResult.Text = ""
            txtNRange.Text = ""

        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try

            cm = New SqlCommand("update TestReport set RInId=@RInId,PName=@PName,PAddr=@PAddr,Contact=@Contact,DrNm=@DrNm,Disease=@Disease,TestName=@TestName,Result=@Result,NRange=@NRange,DlvryDate=@DlvryDate,RefBy=@RefBy,RemarkByDoctor=@RemarkByDoctor,RDate=@RDate where RCId=@RCId and TestNo=@TestNo", cn)
            cm.Parameters.Add("@RCId", SqlDbType.Int).Value = CInt(txtRCId.Text)
            cm.Parameters.Add("@RInId", SqlDbType.Int).Value = CInt(cmbRInId.Text)
            cm.Parameters.Add("@PName", SqlDbType.VarChar).Value = (txtPatNm.Text)
            cm.Parameters.Add("@PAddr", SqlDbType.NVarChar).Value = (txtPatAddr.Text)
            cm.Parameters.Add("@Contact", SqlDbType.BigInt).Value = CLng(txtContact.Text)
            cm.Parameters.Add("@DrNm", SqlDbType.VarChar).Value = (txtDoctor.Text)
            cm.Parameters.Add("@Disease", SqlDbType.NVarChar).Value = (txtDisease.Text)
            cm.Parameters.Add("@TestNo", SqlDbType.Int).Value = CInt(txtTestNo.Text)
            cm.Parameters.Add("@TestName", SqlDbType.NVarChar).Value = (cmbTest.Text)
            cm.Parameters.Add("@Result", SqlDbType.Float).Value = CSng(txtResult.Text)
            cm.Parameters.Add("@NRange", SqlDbType.NVarChar).Value = (txtNRange.Text)
            cm.Parameters.Add("@DlvryDate", SqlDbType.DateTime).Value = CDate(DTPRprtDlvryDte.Value)
            cm.Parameters.Add("@RefBy", SqlDbType.VarChar).Value = (txtRefBy.Text)
            cm.Parameters.Add("@RemarkByDoctor", SqlDbType.NVarChar).Value = (txtRmarkByDr.Text)
            cm.Parameters.Add("@RDate", SqlDbType.DateTime).Value = CDate(DTPRInDte.Value)

            Dim r As Integer = cm.ExecuteNonQuery()
            If r = 1 Then
                MsgBox("Record updated successfully", MsgBoxStyle.Exclamation)
            Else
                MsgBox("Error while updating record", MsgBoxStyle.RetryCancel)

            End If
            see()

            clear()


        Catch ex As Exception
            dr.Close()
        End Try
    End Sub


    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try

            If MsgBox("Do You want to Delete ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                cm = New SqlCommand("delete from TestReport  where RCId=@RCId and TestNo=@TestNo ", cn)
                cm.Parameters.AddWithValue("@RCId", (txtRCId.Text))
                cm.Parameters.AddWithValue("@TestNo", (txtTestNo.Text))

                Dim r As Integer = cm.ExecuteNonQuery()
                If r = 1 Then
                    MsgBox("Record deleted Successfully", MsgBoxStyle.Exclamation)
                Else
                    MsgBox("Error in deleting record", MsgBoxStyle.RetryCancel)
                End If
                see()


                clear()
                dr.Close()

            Else
                clear()
                dr.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        clear()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try


            txtRCId.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()
            cmbRInId.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString()

            txtPatNm.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString()
            txtPatAddr.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString()
            txtContact.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString()
            txtDoctor.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString()
            txtDisease.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString()
            txtTestNo.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value.ToString()
            cmbTest.Text = DataGridView1.Rows(e.RowIndex).Cells(8).Value.ToString()
            txtResult.Text = DataGridView1.Rows(e.RowIndex).Cells(9).Value.ToString()
            txtNRange.Text = DataGridView1.Rows(e.RowIndex).Cells(10).Value.ToString()
            DTPRprtDlvryDte.Text = CDate(DataGridView1.Rows(e.RowIndex).Cells(11).Value.ToString())
            txtRefBy.Text = DataGridView1.Rows(e.RowIndex).Cells(12).Value.ToString()
            txtRmarkByDr.Text = DataGridView1.Rows(e.RowIndex).Cells(13).Value.ToString()
            DTPRInDte.Text = CDate(DataGridView1.Rows(e.RowIndex).Cells(14).Value.ToString())
        Catch ex As Exception

        End Try
    End Sub


    Private Sub cmbRInId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRInId.SelectedIndexChanged
        Try
            cm = New SqlCommand("select PNm,PAddr,ContactNo,DrNm,Disease,TestName,RcvBy,DlvryDate from RInwrd where RInId=" & CInt(cmbRInId.Text), cn)
            dr = cm.ExecuteReader()
            If dr.Read() Then
                txtPatNm.Text = dr(0).ToString()
                txtPatAddr.Text = dr(1).ToString()
                txtContact.Text = dr(2).ToString()
                txtDoctor.Text = dr(6).ToString()
                txtDisease.Text = dr(4).ToString()
                txtRefBy.Text = dr(3).ToString()
                DTPRprtDlvryDte.Text = dr(7).ToString()
                Dim xx As String = dr(5).ToString
                Dim yy() As String = xx.Split(",")

                cmbTest.Items.Clear()

                For Each z In yy

                    cmbTest.Items.Add(z)
                Next
                'see()
               
                ' txtRmarkByDr.Text = ""
                dr.Close()

            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try

    End Sub

    Private Sub btnNewTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewTest.Click
        Try

            cm = New SqlCommand("select max(TestNo) from TestReport where RCId= " & CInt(txtRCId.Text), cn)
            dr = cm.ExecuteReader()
            If dr.Read() Then
                txtTestNo.Text = CInt(dr(0) + 1)
            End If
            dr.Close()
            see()
            txtResult.Text = ""
            cmbTest.Text = ""
        Catch ex As Exception
            txtTestNo.Text = "1"
            dr.Close()
        End Try
    End Sub


    Private Sub lblLnkPrint_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblLnkPrint.LinkClicked
        Me.Hide()
        rptTest.Show()
    End Sub

    Private Sub cmbTest_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTest.SelectedIndexChanged
        Try

            cm = New SqlCommand("select NormalRange from TestRecord where TestName='" & (cmbTest.Text) & "'", cn)
            dr = cm.ExecuteReader()
            If dr.Read() Then

                txtNRange.Text = dr(0).ToString()

            End If
            dr.Close()

        Catch ex As Exception

        End Try
    End Sub

End Class

