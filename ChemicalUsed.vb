Imports System.Data.SqlClient
Public Class ChemicalUsed

    Private cn As SqlConnection
    Private cm As SqlCommand
    Private dr As SqlDataReader
    Private dt, dt1 As New DataTable
    Dim c, l, i As Integer
    Dim x As New ClassCon
    Private Sub BillDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatholabDBDataSet31.ChemUsed' table. You can move, or remove it, as needed.
        Me.ChemUsedTableAdapter.Fill(Me.PatholabDBDataSet31.ChemUsed)
        'TODO: This line of code loads data into the 'PatholabDBDataSet29.BillDetails' table. You can move, or remove it, as needed.
        'Me.BillDetailsTableAdapter.Fill(Me.PatholabDBDataSet29.BillDetails)
        cn = New SqlConnection(x.s)
        cn.Open()
        dt = New DataTable()
        see()
        dt1 = New DataTable()
        seeChem()
        btnnewid.Focus()

    End Sub

    Private Sub txtPurchaseId_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtChemUsId.KeyPress
        If Not IsNumeric(e.KeyChar) = True And e.KeyChar <> vbBack Then
            e.Handled = True
            ToolTip1.Show("Only Number", txtChemUsId)
        Else
            ToolTip1.Hide(txtChemUsId)
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
    Private Sub see()
        dt.Clear()
        cm = New SqlCommand("select * from ChemUsed order by ChemUsId", cn)
        dr = cm.ExecuteReader()
        dt.Load(dr)
        dr.Close()
        l = dt.Rows.Count - 1
        DataGridView1.DataSource = dt
    End Sub

    Private Sub seeChem()
        dt1.Clear()
        cm = New SqlCommand("select * from ChemMaster order by ChemId", cn)
        dr = cm.ExecuteReader()
        dt1.Load(dr)
        dr.Close()
        cmbChemName.DataSource = dt1
        cmbChemName.ValueMember = "ChemNm"
        cmbChemName.DisplayMember = "ChemNm"

    End Sub

    Private Sub EachRecord()
        txtChemUsId.Text = dt.Rows(c).Item(0).ToString()
        dtpBillDetails.Text = CDate(dt.Rows(c).Item(1).ToString())
        cmbChemName.Text = dt.Rows(c).Item(2).ToString()
        txtQuantity.Text = dt.Rows(c).Item(3).ToString()

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
        cm = New SqlCommand("select count(ChemUsId) from BillDetails", cn)
        dr = cm.ExecuteReader()
        If dr.Read() Then
            MsgBox("No. of Records=" & CInt(dr(0)), MsgBoxStyle.Information)
        End If
        dr.Close()

    End Sub
    Private Sub clear()
        txtChemUsId.Text = ""
        cmbChemName.Text = ""
        txtQuantity.Text = ""
        dtpBillDetails.Text = ""
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        clear()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            cm = New SqlCommand("insert into ChemUsed values(@ChemUsId,@CDate,@ChemNm,@Quantity)", cn)
            cm.Parameters.Add("@ChemUsId", SqlDbType.Int).Value = CInt(txtChemUsId.Text)
            cm.Parameters.Add("@CDate", SqlDbType.DateTime).Value = CDate(dtpBillDetails.Value)
            cm.Parameters.Add("@ChemNm", SqlDbType.VarChar).Value = (cmbChemName.Text)
            cm.Parameters.Add("@Quantity", SqlDbType.Int).Value = CInt(txtQuantity.Text)

            Dim r As Integer = cm.ExecuteNonQuery()
            If r = 1 Then
                MsgBox("Record Inserted Successfully", MsgBoxStyle.Exclamation)
            Else
                MsgBox("Error while Inserting record", MsgBoxStyle.RetryCancel)
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
            cm = New SqlCommand("update ChemUsed set CDate=@CDate,ChemNm=@ChemNm ,Quantity=@Quantity where ChemUsId=@ChemUsId", cn)
            cm.Parameters.Add("@ChemUsId", SqlDbType.Int).Value = CInt(txtChemUsId.Text)
            cm.Parameters.Add("@CDate", SqlDbType.DateTime).Value = CDate(dtpBillDetails.Value)
           cm.Parameters.Add("@ChemNm", SqlDbType.VarChar).Value = (cmbChemName.Text)
            cm.Parameters.Add("@Quantity", SqlDbType.Int).Value = CInt(txtQuantity.Text)

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
                cm = New SqlCommand("delete from ChemUsed where ChemUsId=@ChemUsId ", cn)
                cm.Parameters.Add("@ChemUsId", SqlDbType.Int).Value = CInt(txtChemUsId.Text)


                Dim x As Integer = cm.ExecuteNonQuery()
                If x = 1 Then
                    MsgBox("Record deleted successfully", MsgBoxStyle.Exclamation)
                Else
                    MsgBox("Error while deleting record", MsgBoxStyle.Critical)
                End If

                see()
                clear()
                dr.Close()
            Else
                clear()
            End If
            dr.Close()
        Catch ex As Exception

        End Try
    End Sub


    Private Sub btnnewid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnewid.Click
        Try
            cm = New SqlCommand("select max(ChemUsId) from ChemUsed", cn)
            dr = cm.ExecuteReader()
            If dr.Read() Then
                txtChemUsId.Text = (CInt(dr(0)) + 1)
            End If
            dr.Close()
            txtQuantity.Text = ""
            cmbChemName.Text = ""
        Catch ex As Exception
            txtChemUsId.Text = "1"


        End Try



    End Sub

    Private Sub cmbChemName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbChemName.SelectedIndexChanged
        'Try
        '    cm = New SqlCommand("select ChemId from ChemMaster where ChemNm= '" & (cmbChemName.Text) & "'", cn)

        '    dr = cm.ExecuteReader()
        '    If dr.Read() Then
        '        txtChemUsId.Text = dr(0).ToString()
        '    End If
        '    dr.Close()
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            txtChemUsId.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()
            dtpBillDetails.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString()
            cmbChemName.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString()
            txtQuantity.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString()

        Catch ex As Exception

        End Try
    End Sub
End Class