Imports System.Data
Imports System.Data.SqlClient
Public Class EquipmentMaster

    Private cn As SqlConnection
    Private cm As SqlCommand
    Private dr As SqlDataReader
    Private dt, dtable1 As New DataTable
    Dim c, l, i As Integer

    Dim x As New ClassCon
    Private Sub EquipmentMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatholabDBDataSet25.Equipment' table. You can move, or remove it, as needed.
        ' Me.EquipmentTableAdapter.Fill(Me.PatholabDBDataSet25.Equipment)
        cn = New SqlConnection(x.s)
        cn.Open()
        dt = New DataTable()
        see()
        btnnewid.Focus()
    End Sub

    Private Sub txtEqipId_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEqipId.KeyPress
        If Not IsNumeric(e.KeyChar) = True And e.KeyChar <> vbBack Then
            e.Handled = True
            ToolTip1.Show("Only Number", txtEqipId)
        Else
            ToolTip1.Hide(txtEqipId)
        End If
    End Sub

    Private Sub txtRate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRate.KeyPress
        If Not IsNumeric(e.KeyChar) = True And e.KeyChar <> vbBack Then
            e.Handled = True
            ToolTip1.Show("Only Number", txtRate)
        Else
            ToolTip1.Hide(txtRate)
        End If
    End Sub

    Private Sub clear()
        txtEqipId.Text = ""
        txtEquipNm.Text = ""
        txtSpecification.Text = ""
        txtCompany.Text = ""
        txtRate.Text = ""

    End Sub

    Private Sub see()
        dt.Clear()
        cm = New SqlCommand("select * from Equipment order by EqupId", cn)
        dr = cm.ExecuteReader()
        dt.Load(dr)
        dr.Close()
        l = dt.Rows.Count - 1
        DataGridView1.DataSource = dt
    End Sub
    Private Sub EachRecord()
        txtEqipId.Text = dt.Rows(c).Item(0).ToString()
        txtEquipNm.Text = dt.Rows(c).Item(1).ToString()
        txtCompany.Text = dt.Rows(c).Item(2).ToString()
        txtSpecification.Text = (dt.Rows(c).Item(3).ToString())
        txtRate.Text = dt.Rows(c).Item(4).ToString()


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
        cm = New SqlCommand("select count(EqupId) from Equipment", cn)
        dr = cm.ExecuteReader()
        If dr.Read() Then
            MsgBox("No. of  Equipment=" & CInt(dr(0)), MsgBoxStyle.Information)
        End If
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            cm = New SqlCommand("insert into Equipment values(@EqupId,@EqupNm,@Company,@Specification,@Rate)", cn)
            cm.Parameters.Add("@EqupId", SqlDbType.Int).Value = CInt(txtEqipId.Text)
            cm.Parameters.Add("@EqupNm", SqlDbType.VarChar).Value = (txtEquipNm.Text)
            cm.Parameters.Add("@Company", SqlDbType.VarChar).Value = (txtCompany.Text)
            cm.Parameters.Add("@Specification", SqlDbType.NVarChar).Value = (txtSpecification.Text)
            cm.Parameters.Add("@Rate", SqlDbType.Float).Value = CSng(txtRate.Text)
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

        End Try
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            cm = New SqlCommand("update Equipment set EqupNm=@EqupNm,Company=@Company,Specification=@Specification,Rate=@Rate where EqupId=@EqupId", cn)
            cm.Parameters.Add("@EqupId", SqlDbType.Int).Value = CInt(txtEqipId.Text)
            cm.Parameters.Add("@EqupNm", SqlDbType.VarChar).Value = (txtEquipNm.Text)
            cm.Parameters.Add("@Company", SqlDbType.VarChar).Value = (txtCompany.Text)
            cm.Parameters.Add("@Specification", SqlDbType.NVarChar).Value = (txtSpecification.Text)
            cm.Parameters.Add("@Rate", SqlDbType.Float).Value = CSng(txtRate.Text)
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

        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If MsgBox("Do You want to delete ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                cm = New SqlCommand("delete from Equipment where EqupId=@EqupId", cn)
                cm.Parameters.Add("@EqupId", SqlDbType.Int).Value = CInt(txtEqipId.Text)
                Dim x As Integer = cm.ExecuteNonQuery()
                If x = 1 Then
                    MsgBox("Record deleted successfully", MsgBoxStyle.Exclamation)
                Else
                    MsgBox("Error while deleting record", MsgBoxStyle.Critical)
                End If

                see()
                cnt()
                clear()

            Else
                clear()
            End If
            dr.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        clear()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        txtEqipId.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()
        txtEquipNm.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString()
        txtCompany.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString()
        txtSpecification.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString()
        txtRate.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString()

    End Sub

    Private Sub btnnewid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnewid.Click
        cm = New SqlCommand("select max(EqupId) from Equipment", cn)
        dr = cm.ExecuteReader()
        If dr.Read() Then
            txtEqipId.Text = CInt(dr(0) + 1)
        End If
        dr.Close()
        txtEquipNm.Text = ""
        txtSpecification.Text = ""
        txtCompany.Text = ""
        txtRate.Text = ""

    End Sub

End Class