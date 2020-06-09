Imports System.Data
Imports System.Data.SqlClient
Public Class TestMaster
    Dim cn As SqlConnection
    Dim cm As SqlCommand
    Dim dr As SqlDataReader
    Dim dt, dt1 As DataTable
    Dim n, c As Integer
    Dim x As New ClassCon
    Private Sub TestMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatholabDBDataSet19.TestRecord' table. You can move, or remove it, as needed.
        'Me.TestRecordTableAdapter.Fill(Me.PatholabDBDataSet19.TestRecord)
        cn = New SqlConnection(x.s)
        cn.Open()
        dt = New DataTable()
        see()
        btnnewid.Focus()
    End Sub
    Private Sub EachRecord()
        txtTestId.Text = dt.Rows(c).Item(0).ToString()
        txtTestGroup.Text = dt.Rows(c).Item(1).ToString()
        txtTest.Text = dt.Rows(c).Item(2).ToString()
        txtRange.Text = dt.Rows(c).Item(3).ToString()
        txtCost.Text = dt.Rows(c).Item(4).ToString()
    End Sub
    Private Sub clear()
        txtTestId.Text = ""
        txtTestGroup.Text = ""
        txtTest.Text = ""
        txtRange.Text = ""
        txtCost.Text = ""
    End Sub

    Private Sub see()
        dt.Clear()
        cm = New SqlCommand("select * from TestRecord order by TId", cn)
        dr = cm.ExecuteReader()
        dt.Load(dr)
        dr.Close()
        n = dt.Rows.Count - 1
        DataGridView1.DataSource = dt

    End Sub
    Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFirst.Click
        c = 0
        EachRecord()
    End Sub
    Private Sub btnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrev.Click
        If c > 0 Then
            c -= 1
            EachRecord()
        Else
            MsgBox("First Record")
        End If
    End Sub
    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNext.Click
        If c < n Then
            c += 1
            EachRecord()
        Else
            MsgBox("Last Record")
        End If
    End Sub
    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLast.Click
        c = n
        EachRecord()
    End Sub


    Private Sub btnnewid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnewid.Click
        cm = New SqlCommand("select max(TId) from TestRecord", cn)
        dr = cm.ExecuteReader()
        If dr.Read() Then
            txtTestId.Text = CInt(dr(0) + 1)
        End If
        dr.Close()

        txtTestGroup.Text = ""
        txtTest.Text = ""
        txtRange.Text = ""
        txtCost.Text = ""
    End Sub
    Private Sub cnt()
        cm = New SqlCommand("select count(TId) from TestRecord", cn)
        dr = cm.ExecuteReader()
        If dr.Read() Then
            MsgBox("No. of Records=" & CInt(dr(0)), MsgBoxStyle.Information)
        End If
    End Sub


    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try

            If MsgBox("Do You want to delete ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                cm = New SqlCommand("delete from TestRecord where TId=@TId", cn)
                cm.Parameters.AddWithValue("@TId", (txtTestId.Text))

                Dim r As Integer = cm.ExecuteNonQuery()
                If r = 1 Then
                    MsgBox("Record Deleted Successfully", MsgBoxStyle.Exclamation)
                Else
                    MsgBox("Error while Deleting Record", MsgBoxStyle.RetryCancel)
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
        txtTestId.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()
        txtTestGroup.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString()
        txtTest.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString()
        txtRange.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString()
        txtCost.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        'Try
        cm = New SqlCommand("Insert into TestRecord values(@TId,@TGroup,@TestName,@NormalRange,@Cost)", cn)
        cm.Parameters.Add("@TId", SqlDbType.Int).Value = CInt(txtTestId.Text)
        cm.Parameters.Add("@TGroup", SqlDbType.VarChar).Value = (txtTestGroup.Text)
        cm.Parameters.Add("@TestName", SqlDbType.NVarChar).Value = txtTest.Text
        cm.Parameters.Add("@NormalRange", SqlDbType.NVarChar).Value = txtRange.Text
        cm.Parameters.Add("@Cost", SqlDbType.Float).Value = CSng(txtCost.Text)
        Dim r As Integer = cm.ExecuteNonQuery()
        If r = 1 Then
            MsgBox("Record Inserted Successfully", MsgBoxStyle.Exclamation)
        Else
            MsgBox("Error while Inserting Record", MsgBoxStyle.RetryCancel)
        End If
        see()
        cnt()
        clear()
        dr.Close()

        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            cm = New SqlCommand("update TestRecord set TGroup=@TGroup,TestName=@TestName,NormalRange=@NormalRange,Cost=@Cost where  TId=@TId", cn)
            cm.Parameters.Add("@TId", SqlDbType.Int).Value = CInt(txtTestId.Text)
            cm.Parameters.Add("@TGroup", SqlDbType.VarChar).Value = (txtTestGroup.Text)
            cm.Parameters.Add("@TestName", SqlDbType.NVarChar).Value = txtTest.Text
            cm.Parameters.Add("@NormalRange", SqlDbType.NVarChar).Value = txtRange.Text
            cm.Parameters.Add("@Cost", SqlDbType.Float).Value = CSng(txtCost.Text)
            Dim r As Integer = cm.ExecuteNonQuery()
            If r = 1 Then
                MsgBox("Record updated Successfully", MsgBoxStyle.Exclamation)
            Else
                MsgBox("Error while  updating Record", MsgBoxStyle.RetryCancel)
            End If
            see()

            clear()
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub txtTestId_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTestId.KeyPress
        If Not IsNumeric(e.KeyChar) = True And e.KeyChar <> vbBack Then
            e.Handled = True
            ToolTip1.Show("Only Number", txtTestId)
        Else
            ToolTip1.Hide(txtTestId)
        End If
    End Sub

   
    Private Sub txtTestId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTestId.TextChanged

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class