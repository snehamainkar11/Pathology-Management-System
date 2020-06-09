Imports System.Data
Imports System.Data.SqlClient
Public Class Bill
    Dim cn As SqlConnection
    Dim cm As SqlCommand
    Dim dr As SqlDataReader
    Dim dt, dt1, dt2, dt3 As DataTable
    Dim n, c As Integer
    Dim x As New ClassCon
    Private Sub txtBillNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBillNo.KeyPress
        If Not IsNumeric(e.KeyChar) = True And e.KeyChar <> vbBack Then
            e.Handled = True
            ToolTip1.Show("Only Number", txtBillNo)
        Else
            ToolTip1.Hide(txtBillNo)
        End If
    End Sub
    Private Sub txtCost_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not IsNumeric(e.KeyChar) = True And e.KeyChar <> "." And e.KeyChar <> vbBack Then
            e.Handled = True
            ToolTip1.Show("Only Number", txtCost)
        Else
            ToolTip1.Hide(txtCost)
        End If
    End Sub
    Private Sub Bill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatholabDBDataSet24.BillCost' table. You can move, or remove it, as needed.
        'Me.BillCostTableAdapter.Fill(Me.PatholabDBDataSet24.BillCost)
       
        'TODO: This line of code loads data into the 'PatholabDBDataSet1.FinalBill' table. You can move, or remove it, as needed.
        'Me.FinalBillTableAdapter.Fill(Me.PatholabDBDataSet1.FinalBill)
       
        cn = New SqlConnection(x.s)
        cn.Open()
        dt = New DataTable()
        see()
        dt1 = New DataTable()
        see1()
        dt2 = New DataTable()
        seeData()
        dt3 = New DataTable()
        seeEmp()
        btnnewid.Focus()

    End Sub
    Private Sub see()
        dt.Clear()
        cm = New SqlCommand("select * from FinalBill", cn)
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

    Private Sub seeData()
        Try
            dt2.Clear()
            cm = New SqlCommand("select * from BillCost where BNo=" & CInt(txtBillNo.Text), cn)
            dr = cm.ExecuteReader()
            dt2.Load(dr)
            dr.Close()
            n = dt2.Rows.Count - 1
            DataGridView2.DataSource = dt2
        Catch ex As Exception

        End Try
    End Sub
    Private Sub see1()
        dt1.Clear()
        cm = New SqlCommand("select * from PatntCheckup ", cn)
        dr = cm.ExecuteReader()
        dt1.Load(dr)
        dr.Close()
        CmbPatId.DataSource = dt1
        CmbPatId.ValueMember = "PId"
        CmbPatId.DisplayMember = "PId"
    End Sub
   
    Private Sub EachRecord()
        Try
            txtBillNo.Text = dt.Rows(c).Item(0).ToString()
            CmbPatId.Text = dt.Rows(c).Item(1).ToString
            txtPatNm.Text = dt.Rows(c).Item(2).ToString()
            cmbPaidBy.Text = dt.Rows(c).Item(3).ToString()
            txtTotal.Text = dt.Rows(c).Item(4).ToString()
            dtpBill.Text = CDate(dt.Rows(c).Item(5).ToString())
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
   Private Sub clear()
        txtBillNo.Clear()
        txtPatNm.Text = ""
        CmbPatId.Text = ""
        txtTotal.Text = ""
        cmbPaidBy.Text = ""
        cmbTest.Text = ""
        txtTestNo.Text = ""
        txtCost.Text = ""
    End Sub
    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try

            cm = New SqlCommand("Update FinalBill set PId=@PId,PName=@PName,PaidBy=@PaidBy,Total=@Total,BDate=@BDate where BillNo=@BillNo", cn)
            cm.Parameters.Add("@BillNo", SqlDbType.Int).Value = CInt(txtBillNo.Text)
            cm.Parameters.Add("@PId", SqlDbType.Int).Value = CInt(CmbPatId.Text)
            cm.Parameters.Add("@PName", SqlDbType.VarChar).Value = (txtPatNm.Text)
            cm.Parameters.Add("@PaidBy", SqlDbType.VarChar).Value = (cmbPaidBy.Text)
            cm.Parameters.Add("@Total", SqlDbType.Float).Value = CSng(txtTotal.Text)
            cm.Parameters.Add("@BDate", SqlDbType.DateTime).Value = CDate(dtpBill.Value)
            Dim r As Integer = cm.ExecuteNonQuery()
            If r = 1 Then
                MsgBox("Record inserted Successfully", MsgBoxStyle.Exclamation)
            Else
                MsgBox("Error while inserted Record", MsgBoxStyle.RetryCancel)
            End If
            see()

            clear()


            dt2.Clear()
        Catch ex As Exception
            clear()
            dr.Close()
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            txtBillNo.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()
            CmbPatId.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString()
            txtPatNm.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString()
            cmbPaidBy.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString()
            txtTotal.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString()
            dtpBill.Value = CDate(DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString())
           
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

        Try

            cm = New SqlCommand("Update FinalBill set PId=@PId,PName=@PName,PaidBy=@PaidBy,Total=@Total,BDate=@BDate where BillNo=@BillNo", cn)
            cm.Parameters.Add("@BillNo", SqlDbType.Int).Value = CInt(txtBillNo.Text)
            cm.Parameters.Add("@PId", SqlDbType.Int).Value = CInt(CmbPatId.Text)
            cm.Parameters.Add("@PName", SqlDbType.VarChar).Value = (txtPatNm.Text)
            cm.Parameters.Add("@PaidBy", SqlDbType.VarChar).Value = (cmbPaidBy.Text)
            cm.Parameters.Add("@Total", SqlDbType.Float).Value = CSng(txtTotal.Text)
            cm.Parameters.Add("@BDate", SqlDbType.DateTime).Value = CDate(dtpBill.Value)
            Dim r As Integer = cm.ExecuteNonQuery()
            If r = 1 Then
                MsgBox("Record Updated Successfully", MsgBoxStyle.Exclamation)
            Else
                MsgBox("Error while Updating Record", MsgBoxStyle.RetryCancel)
            End If
            see()

            clear()


            dt2.Clear()
        Catch ex As Exception
            clear()
            dr.Close()
        End Try

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        Try
            If MsgBox("Do You want to delete ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                cm = New SqlCommand("delete from BillCost  where BNo=@BNo ", cn)
                cm.Parameters.AddWithValue("@BNo", (txtBillNo.Text))
                cm.ExecuteNonQuery()
                cm = New SqlCommand("delete from FinalBill  where BillNo=@BillNo ", cn)
                cm.Parameters.AddWithValue("@BillNo", (txtBillNo.Text))
                Dim r As Integer = cm.ExecuteNonQuery()
                If r = 1 Then
                    MsgBox("Record deleted Successfully", MsgBoxStyle.Exclamation)
                Else
                    MsgBox("Error", MsgBoxStyle.RetryCancel)
                End If

                see()
                seeData()
                clear()
                dr.Close()
            Else
                clear()
            End If

        Catch ex As Exception
            dr.Close()
        End Try
    End Sub
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        clear()
    End Sub

    Private Sub CmbPatId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbPatId.SelectedIndexChanged
        Try
            cm = New SqlCommand("select PName,SugTest from PatntCheckup where PId=" & CInt(CmbPatId.Text), cn)
            dr = cm.ExecuteReader()
            If dr.Read() Then

                txtPatNm.Text = dr(0).ToString()
                Dim xx As String = dr(1).ToString
                Dim yy() As String = xx.Split(",")
                cmbTest.Items.Clear()
                For Each z In yy
                    cmbTest.Items.Add(z)
                Next
                cmbPaidBy.Text = ""
                txtTotal.Text = ""
            End If
            dr.Close()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        Try
            txtTestNo.Text = DataGridView2.Rows(e.RowIndex).Cells(0).Value.ToString()
            txtBillNo.Text = DataGridView2.Rows(e.RowIndex).Cells(1).Value.ToString()
            cmbTest.Text = DataGridView2.Rows(e.RowIndex).Cells(2).Value.ToString()
            txtCost.Text = DataGridView2.Rows(e.RowIndex).Cells(3).Value.ToString()
        Catch ex As Exception

        End Try
    End Sub


    Private Sub btnTestUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTestUpdate.Click
        'try
        cm = New SqlCommand("update BillCost set TestName=@TestName,Cost=@Cost where TestNo=@TestNo and BNo=@BNo", cn)
        cm.Parameters.Add("@TestNo", SqlDbType.Int).Value = CInt(txtTestNo.Text)
        cm.Parameters.Add("@BNo", SqlDbType.Int).Value = CInt(txtBillNo.Text)
        cm.Parameters.Add("@TestName", SqlDbType.NVarChar).Value = (cmbTest.Text)
        cm.Parameters.Add("@Cost", SqlDbType.Float).Value = CSng(txtCost.Text)
        Dim r As Integer = cm.ExecuteNonQuery()
        If r = 1 Then
            MsgBox("Record updated successfully", MsgBoxStyle.Exclamation)
        Else
            MsgBox("Error while updating record", MsgBoxStyle.RetryCancel)

        End If

        seeData()
        txtCost.Clear()
        txtTestNo.Text = ""
        cmbTest.Text = ""
        txtCost.Text = ""
        dr.Close()
        'Catch ex As Exception
        '    dr.Close()
        'End Try


    End Sub

    Private Sub btnTestAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTestAdd.Click
        Try
            cm = New SqlCommand("insert into BillCost values(@TestNo,@BNo,@TestName,@Cost)", cn)
            cm.Parameters.Add("@TestNo", SqlDbType.Int).Value = CInt(txtTestNo.Text)
            cm.Parameters.Add("@BNo", SqlDbType.Int).Value = CInt(txtBillNo.Text)
            cm.Parameters.Add("@TestName", SqlDbType.NVarChar).Value = (cmbTest.Text)
            cm.Parameters.Add("@Cost", SqlDbType.Float).Value = CSng(txtCost.Text)
            Dim r As Integer = cm.ExecuteNonQuery()
            If r = 1 Then
                MsgBox("Record inserted successfully", MsgBoxStyle.Exclamation)
            Else
                MsgBox("Error while inserting record", MsgBoxStyle.RetryCancel)

            End If
            seeData()
            txtTestNo.Text = ""
            txtCost.Clear()
            txtTestNo.Clear()
            cmbTest.Text = ""
            dr.Close()

            'cm = New SqlCommand("update BillCost set TestName=@TestName,Cost=@Cost where TestNo=@TestNo and BNo=@BNo", cn)
            'cm.Parameters.Add("@TestNo", SqlDbType.Int).Value = CInt(txtTestNo.Text)
            'cm.Parameters.Add("@BNo", SqlDbType.Int).Value = CInt(txtBillNo.Text)
            'cm.Parameters.Add("@TestName", SqlDbType.NVarChar).Value = (cmbTest.Text)
            'cm.Parameters.Add("@Cost", SqlDbType.Float).Value = CSng(txtCost.Text)
            'Dim r As Integer = cm.ExecuteNonQuery()
            'If r = 1 Then
            '    MsgBox("Record inserted successfully", MsgBoxStyle.Exclamation)
            'Else
            '    MsgBox("Error while inserted record", MsgBoxStyle.RetryCancel)

            'End If

            'seeData()
            'txtCost.Clear()
            'txtTestNo.Text = ""
            'cmbTest.Text = ""
            'txtCost.Text = ""
            'dr.Close()

        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub btnTestDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTestDel.Click
        Try
            If MsgBox("Do You want to Delete ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                cm = New SqlCommand("delete from BillCost where TestNo=@TestNo and BNo=@BNo", cn)
                cm.Parameters.AddWithValue("@TestNo", (txtTestNo.Text))
                cm.Parameters.AddWithValue("@BNo", (txtBillNo.Text))

                Dim r As Integer = cm.ExecuteNonQuery()
                If r = 1 Then
                    MsgBox("Record deleted Successfully", MsgBoxStyle.Exclamation)
                Else
                    MsgBox("Error in deleting record", MsgBoxStyle.RetryCancel)
                End If
                seeData()
                dr.Close()
                txtTestNo.Text = ""
                cmbTest.Text = ""
                txtCost.Text = ""

            Else

            End If
        Catch ex As Exception

        End Try


    End Sub

    Private Sub cmbTest_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTest.SelectedIndexChanged
        Try

            cm = New SqlCommand("select Cost from TestRecord where TestName='" & (cmbTest.Text) & "'", cn)
            dr = cm.ExecuteReader()
            If dr.Read() Then

                txtCost.Text = dr(0).ToString()

            End If
            dr.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnnewid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnewid.Click
        Try

            cm = New SqlCommand("select max(BillNo) from FinalBill", cn)
            dr = cm.ExecuteReader()
            If dr.Read() Then
                txtBillNo.Text = CInt(dr(0) + 1)
            End If
            dr.Close()
            seeData()
            cmbPaidBy.Text = ""
            CmbPatId.Text = ""
            txtPatNm.Text = ""
            txtTotal.Text = ""
            cmbTest.Items.Clear()
        Catch ex As Exception
            'txtTestNo.Text = "1"
            dr.Close()
        End Try

        cm = New SqlCommand("insert into FinalBill(BillNo)values(" & CInt(txtBillNo.Text) & ")", cn)
        cm.ExecuteNonQuery()
    End Sub

    Private Sub btnNewTestNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewTestNo.Click

        Try
            cm = New SqlCommand("select max(TestNo) from BillCost where BNo=" & CInt(txtBillNo.Text), cn)
            dr = cm.ExecuteReader()
            If dr.Read() Then
                txtTestNo.Text = CInt(dr(0) + 1)
            End If
            dr.Close()
            seeData()
            txtCost.Text = ""
            cmbTest.Text = ""
        Catch ex As Exception
            txtTestNo.Text = "1"
            dr.Close()
        End Try
      
    End Sub

    Private Sub btnTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTotal.Click
        Try
            cm = New SqlCommand("select sum(Cost) from BillCost where BNo=" & CInt(txtBillNo.Text), cn)

            dr = cm.ExecuteReader()
            If dr.Read() Then
                txtTotal.Text = dr(0).ToString()
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

   
    Private Sub lblLnkPrint_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblLnkPrint.LinkClicked

        Me.Hide()
        rptTotalBill.Show()
    End Sub

    Private Sub PnlCustNavigation_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PnlCustNavigation.Paint

    End Sub
End Class
