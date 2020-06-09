
Imports System.Data
Imports System.Data.SqlClient
Public Class Chemical_Master
    Dim cn As SqlConnection
    Dim cm As SqlCommand
    Dim dr As SqlDataReader
    Dim dt, dt1, dt2 As DataTable
    Dim n, c As Integer
    Dim x As New ClassCon
    Private Sub Chemical_Master_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatholabDBDataSet3.ChemMaster' table. You can move, or remove it, as needed.
        'Me.ChemMasterTableAdapter.Fill(Me.PatholabDBDataSet3.ChemMaster)
        cn = New SqlConnection(x.s)
        cn.Open()
        dt1 = New DataTable()
        see1()
        dt2 = New DataTable()
        see2()
        dt = New DataTable()
        see()
        btnnewid.Focus()
    End Sub
    Private Sub txtChemicalId_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtChemicalId.KeyPress
        If Not IsNumeric(e.KeyChar) = True And e.KeyChar <> vbBack Then
            e.Handled = True
            ToolTip1.Show("Only Number", txtChemicalId)
        Else
            ToolTip1.Hide(txtChemicalId)
        End If
    End Sub


    Private Sub EachRecord()
        txtChemicalId.Text = dt.Rows(c).Item(0).ToString
        txtChemName.Text = dt.Rows(c).Item(1).ToString
        cmbDealer.Text = dt.Rows(c).Item(2).ToString
        txtPrice.Text = dt.Rows(c).Item(3).ToString
        dtpChem.Text = CDate(dt.Rows(c).Item(4).ToString)
        cmbObsby.Text = dt.Rows(c).Item(5).ToString
    End Sub
  
    Private Sub see()
        dt.Clear()
        cm = New SqlCommand("select * from ChemMaster order by ChemId ", cn)
        dr = cm.ExecuteReader()
        dt.Load(dr)
        dr.Close()
        n = dt.Rows.Count - 1
        DataGridView1.DataSource = dt

    End Sub
    Private Sub see1()
        dt1.Clear()
        cm = New SqlCommand("select * from Dealer order by DlrId", cn)
        dr = cm.ExecuteReader()
        dt1.Load(dr)
        dr.Close()
        cmbDealer.DataSource = dt1
        cmbDealer.ValueMember = "DlrNm"
        cmbDealer.DisplayMember = "DlrNm"

    End Sub
    Private Sub see2()
        dt2.Clear()
        cm = New SqlCommand("select * from EmpMaster order by EId", cn)
        dr = cm.ExecuteReader()
        dt2.Load(dr)
        dr.Close()
        cmbObsby.DataSource = dt2
        cmbObsby.ValueMember = "EName"
        cmbObsby.DisplayMember = "EName"
    End Sub
    Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click
        c = 0
        EachRecord()
    End Sub
    Private Sub btnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrev.Click
        If c > 0 Then
            c -= 1
            EachRecord()
        Else
            MsgBox("First Record")
        End If
    End Sub
    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        If c < n Then
            c += 1
            EachRecord()
        Else
            MsgBox("Last Record")
        End If
    End Sub
    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        c = n
        EachRecord()
    End Sub
   
    Private Sub btnnewid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnewid.Click
        cm = New SqlCommand("select max(ChemId) from ChemMaster", cn)
        dr = cm.ExecuteReader()
        If dr.Read() Then
            txtChemicalId.Text = CInt(dr(0) + 1)
        End If
        dr.Close()
        txtChemName.Text = ""
        dtpChem.Text = ""
        cmbObsby.Text = ""
        txtChemName.Text = ""
        cmbDealer.Text = ""
        txtPrice.Text = ""
    End Sub
    Private Sub cnt()
        cm = New SqlCommand("select count(ChemId) from ChemMaster", cn)
        dr = cm.ExecuteReader()
        If dr.Read() Then
            MsgBox("No. of Chemicals=" & CInt(dr(0)), MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        txtChemicalId.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
        txtChemName.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
        cmbDealer.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
        txtPrice.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
        dtpChem.Text = CDate(DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString)
        cmbObsby.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString

    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        'Try

        cm = New SqlCommand("Insert into ChemMaster values(@ChemId,@ChemNm,@Dealer,@Prc,@DtChng,@ObsBy)", cn)
        cm.Parameters.Add("@ChemId", SqlDbType.Int).Value = CInt(txtChemicalId.Text)
        cm.Parameters.Add("@ChemNm", SqlDbType.VarChar).Value = txtChemName.Text
        cm.Parameters.Add("@Dealer", SqlDbType.VarChar).Value = (cmbDealer.Text)
        cm.Parameters.Add("@Prc", SqlDbType.Float).Value = CSng(txtPrice.Text)
        cm.Parameters.Add("@DtChng", SqlDbType.DateTime).Value = CDate(dtpChem.Text)
        cm.Parameters.Add("@ObsBy", SqlDbType.VarChar).Value = cmbObsby.Text
        Dim r As Integer = cm.ExecuteNonQuery()
        If r = 1 Then
            MsgBox("Record Inserted Successfully", MsgBoxStyle.Exclamation)
        Else
            MsgBox("Error", MsgBoxStyle.RetryCancel)
        End If
        see()
        cnt()
        clear()
        dr.Close()
        'Catch ex As Exception
        '    dr.Close()
        'End Try
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        'Try

        cm = New SqlCommand("Update ChemMaster set ChemNm=@ChemNm,Dealer=@Dealer,Prc=@Prc,DtChng=@DtChng,ObsBy=@ObsBy where ChemId=@ChemId", cn)
        cm.Parameters.Add("@ChemId", SqlDbType.Int).Value = CInt(txtChemicalId.Text)
        cm.Parameters.Add("@ChemNm", SqlDbType.VarChar).Value = txtChemName.Text
        cm.Parameters.Add("@Dealer", SqlDbType.VarChar).Value = (cmbDealer.Text)
        cm.Parameters.Add("@Prc", SqlDbType.Float).Value = CSng(txtPrice.Text)
        cm.Parameters.Add("@DtChng", SqlDbType.DateTime).Value = CDate(dtpChem.Text)
        cm.Parameters.Add("@ObsBy", SqlDbType.VarChar).Value = cmbObsby.Text
        Dim r As Integer = cm.ExecuteNonQuery()
        If r = 1 Then
            MsgBox("Record Updated Successfully", MsgBoxStyle.Exclamation)
        Else
            MsgBox("Error", MsgBoxStyle.RetryCancel)
        End If
        see()

        clear()
        dr.Close()
        'Catch ex As Exception
        '    dr.Close()
        'End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        ' Try

        If MsgBox("Do You want to delete ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            cm = New SqlCommand("delete from ChemMaster where ChemId=@ChemId", cn)
            cm.Parameters.AddWithValue("@ChemId", (txtChemicalId.Text))

            Dim r As Integer = cm.ExecuteNonQuery()
            If r = 1 Then
                MsgBox("Record deleted Successfully", MsgBoxStyle.Exclamation)
            Else
                MsgBox("Error", MsgBoxStyle.RetryCancel)
            End If
            see()
            cnt()
            clear()

        Else
            clear()
        End If
        dr.Close()
        'Catch ex As Exception

        'End Try
    End Sub
    Private Sub clear()
        txtChemicalId.Text = ""
        txtChemName.Text = ""
        dtpChem.Text = ""
        cmbObsby.Text = ""
        txtChemName.Text = ""
        cmbDealer.Text = ""
        txtPrice.Text = ""
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        clear()
    End Sub

  Private Sub cmbDealer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDealer.SelectedIndexChanged
        Try
            cm = New SqlCommand("select DlrNm from Dealer where DlrNm=" & CInt(cmbDealer.Text), cn)
            dr = cm.ExecuteReader()
            If dr.Read() Then
                cmbDealer.Text = dr(0).ToString()
            End If
            dr.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmbObsby_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbObsby.SelectedIndexChanged
        Try
            cm = New SqlCommand("select EName from EmpMaster where Ename= '" & (cmbDealer.Text) & "'", cn)
            dr = cm.ExecuteReader()
            If dr.Read() Then
                cmbObsby.Text = dr(0).ToString()
            End If
            dr.Close()
        Catch ex As Exception

        End Try
    End Sub
End Class