
Imports System.Data
Imports System.Data.SqlClient
Public Class Employee_Master
    Dim cn As SqlConnection
    Dim cm As SqlCommand
    Dim dr As SqlDataReader
    Dim dt As DataTable
    Dim n, c As Integer
    Dim x As New ClassCon
    Private Sub Employee_Master_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatholabDBDataSet5.EmpMaster' table. You can move, or remove it, as needed.
        'Me.EmpMasterTableAdapter.Fill(Me.PatholabDBDataSet5.EmpMaster)
        cn = New SqlConnection(x.s)
        cn.Open()
        dt = New DataTable()
        see()
        btnnewid.Focus()
    End Sub
    Private Sub EachRecord()
        TxtEmpId.Text = dt.Rows(c).Item(0).ToString()
        TxtEmpName.Text = dt.Rows(c).Item(1).ToString()
        TxtEmpAddress.Text = dt.Rows(c).Item(2).ToString()
        TxtEmpContactNo.Text = dt.Rows(c).Item(3).ToString()
        TxtEmpQuali.Text = dt.Rows(c).Item(4).ToString()
        TxtSal.Text = dt.Rows(c).Item(5).ToString()
        dtpJoin.Text = dt.Rows(c).Item(6).ToString()
        dtpDOB.Text = dt.Rows(c).Item(7).ToString()
    End Sub
    Private Sub see()
        dt.Clear()
        cm = New SqlCommand("select * from EmpMaster order by EId", cn)
        dr = cm.ExecuteReader()
        dt.Load(dr)
        dr.Close()
        n = dt.Rows.Count - 1
        DataGridView1.DataSource = dt

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
        TxtEmpId.Text = ""
        TxtEmpName.Text = ""
        TxtEmpAddress.Text = ""
        TxtEmpContactNo.Text = ""
        TxtEmpQuali.Text = ""
        TxtSal.Text = ""
        dtpJoin.Text = ""
        dtpDOB.Text = ""
    End Sub
    Private Sub btnnewid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnewid.Click
        cm = New SqlCommand("select max(EId) from EmpMaster", cn)
        dr = cm.ExecuteReader()
        If dr.Read() Then
            TxtEmpId.Text = CInt(dr(0) + 1)
        End If
        dr.Close()
        TxtEmpName.Text = ""
        TxtEmpAddress.Text = ""
        TxtEmpContactNo.Text = ""
        TxtEmpQuali.Text = ""
        TxtSal.Text = ""
        dtpJoin.Text = ""
        dtpDOB.Text = ""
    End Sub
    Private Sub cnt()
        cm = New SqlCommand("select count(EId) from EmpMaster", cn)
        dr = cm.ExecuteReader()
        If dr.Read() Then
            MsgBox("No. of Employee  Records=" & CInt(dr(0)), MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        TxtEmpId.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()
        TxtEmpName.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString()
        TxtEmpAddress.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString()
        TxtEmpContactNo.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString()
        TxtEmpQuali.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString()
        TxtSal.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString()
        dtpJoin.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString()
        dtpDOB.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value.ToString()

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            cm = New SqlCommand("insert into EmpMaster values(@EId,@EName,@EAddr,@ECntct,@EQual,@Esal,@EJoinDte,@EDOB)", cn)
            cm.Parameters.Add("@EId", SqlDbType.Int).Value = CInt(TxtEmpId.Text)
            cm.Parameters.Add("@EName", SqlDbType.VarChar).Value = (TxtEmpName.Text)
            cm.Parameters.Add("@ECntct", SqlDbType.BigInt).Value = CLng(TxtEmpContactNo.Text)
            cm.Parameters.Add("@EAddr", SqlDbType.NVarChar).Value = (TxtEmpAddress.Text)
            cm.Parameters.Add("@EQual", SqlDbType.VarChar).Value = (TxtEmpQuali.Text)
            cm.Parameters.Add("@Esal", SqlDbType.Float).Value = CSng(TxtSal.Text)
            cm.Parameters.Add("@EJoinDte", SqlDbType.DateTime).Value = CDate(dtpJoin.Value)
            cm.Parameters.Add("@EDOB", SqlDbType.DateTime).Value = CDate(dtpDOB.Value)
            Dim x As Integer = cm.ExecuteNonQuery()
            If x = 1 Then
                MsgBox("Record inserted successfully", MsgBoxStyle.Exclamation)
            Else
                MsgBox("Error while inserting record", MsgBoxStyle.Critical)
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
            cm = New SqlCommand("Update EmpMaster set EName=@EName,EAddr=@EAddr,ECntct=@ECntct,EQual=@EQual,Esal=@Esal,EJoinDte=@EJoinDte,EDOB=@EDOB where EId=@EId", cn)
            cm.Parameters.Add("@EId", SqlDbType.Int).Value = CInt(TxtEmpId.Text)
            cm.Parameters.Add("@EName", SqlDbType.VarChar).Value = (TxtEmpName.Text)
            cm.Parameters.Add("@ECntct", SqlDbType.BigInt).Value = CLng(TxtEmpContactNo.Text)
            cm.Parameters.Add("@EAddr", SqlDbType.NVarChar).Value = (TxtEmpAddress.Text)
            cm.Parameters.Add("@EQual", SqlDbType.VarChar).Value = (TxtEmpQuali.Text)
            cm.Parameters.Add("@Esal", SqlDbType.Float).Value = CSng(TxtSal.Text)
            cm.Parameters.Add("@EJoinDte", SqlDbType.DateTime).Value = CDate(dtpJoin.Value)
            cm.Parameters.Add("@EDOB", SqlDbType.DateTime).Value = CDate(dtpDOB.Value)
            Dim x As Integer = cm.ExecuteNonQuery()
            If x = 1 Then
                MsgBox("Record updated successfully", MsgBoxStyle.Exclamation)
            Else
                MsgBox("Error while updating record", MsgBoxStyle.Critical)
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
                cm = New SqlCommand("Delete from EmpMaster where EId=@EId", cn)
                cm.Parameters.Add("@EId", SqlDbType.Int).Value = CInt(TxtEmpId.Text)
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
            dr.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TxtEmpId_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtEmpId.KeyPress
        If Not IsNumeric(e.KeyChar) = True And e.KeyChar <> vbBack Then
            e.Handled = True
            ToolTip1.Show("Only Number", TxtEmpId)
        Else
            ToolTip1.Hide(TxtEmpId)
        End If
    End Sub

    Private Sub TxtEmpContactNo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtEmpContactNo.GotFocus

        TxtEmpContactNo.BackColor = Color.Yellow
        TxtEmpContactNo.Focus()
    End Sub

   Private Sub TxtEmpContactNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtEmpContactNo.KeyPress
        If Not IsNumeric(e.KeyChar) = True And e.KeyChar <> vbBack Then
            e.Handled = True
            ToolTip1.Show("Only Number", TxtEmpContactNo)
        Else
            ToolTip1.Hide(TxtEmpContactNo)
        End If
    End Sub

    Private Sub TxtEmpContactNo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtEmpContactNo.LostFocus
        Dim s As String = TxtEmpContactNo.Text
        TxtEmpContactNo.BackColor = Color.White
        If s.Length <> 10 Then
            MsgBox("Enter exact 10 Digit")
            TxtEmpContactNo.Focus()
        End If
    End Sub

   
End Class