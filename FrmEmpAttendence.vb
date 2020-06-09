Imports System.Data
Imports System.Data.SqlClient
Public Class FrmEmpAttendence
    Dim cn As SqlConnection
    Dim cm As SqlCommand
    Dim dr As SqlDataReader
    Dim dt, dt1 As DataTable
    Dim n, c As Integer
    Dim x As New ClassCon
    Private Sub FrmEmpAttendance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatholabDBDataSet16.EmpAttendence' table. You can move, or remove it, as needed.
        'Me.EmpAttendenceTableAdapter.Fill(Me.PatholabDBDataSet16.EmpAttendence)

        cn = New SqlConnection(x.s)
        cn.Open()
        dt = New DataTable()

        dt1 = New DataTable()
        see1()
        see()
        btnAdd.Focus()
    End Sub
    Private Sub showRec()
        CmbEmpId.Text = dt1.Rows(c).Item(0).ToString()
    End Sub
    Private Sub EachRecord()
        Try

       
            CmbEmpId.Text = dt.Rows(c).Item(0).ToString()
            TxtEmpName.Text = dt.Rows(c).Item(1).ToString()
            dtpAttend.Text = CDate(dt.Rows(c).Item(2).ToString())
            Dim s As String = dt.Rows(c).Item(3).ToString()
            If s = "Absent" Then
                rdbAbsent.Checked = True
            ElseIf s = "Present" Then
                rdbPresent.Checked = True
            End If
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub
    Private Sub see1()
        dt1.Clear()
        cm = New SqlCommand("select * from EmpMaster order by EId", cn)
        dr = cm.ExecuteReader()
        dt1.Load(dr)
        dr.Close()
        CmbEmpId.DataSource = dt1
        CmbEmpId.ValueMember = "EId"
        CmbEmpId.DisplayMember = "EId"

    End Sub
    Private Sub see()
        Try
            dt.Clear()
            cm = New SqlCommand("select * from EmpAttendence  where EId = " & CInt(CmbEmpId.Text), cn)
            dr = cm.ExecuteReader()
            dt.Load(dr)
            dr.Close()
            n = dt.Rows.Count - 1
            DataGridView1.DataSource = dt
        Catch ex As Exception
            dr.Close()

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
        CmbEmpId.Text = ""
        TxtEmpName.Text = ""
        rdbAbsent.Checked = False
        rdbPresent.Checked = False
        dtpAttend.Text = ""
    End Sub
   


    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            cm = New SqlCommand("insert into EmpAttendence values(@EId,@EName,@EDate,@Attendence,@IDate)", cn)
            cm.Parameters.Add("@EId", SqlDbType.Int).Value = CInt(CmbEmpId.Text)
            cm.Parameters.Add("@EName", SqlDbType.VarChar).Value = (TxtEmpName.Text)
            cm.Parameters.Add("@EDate", SqlDbType.DateTime).Value = CDate(dtpAttend.Value.ToShortDateString())
            Dim s As String = ""
            If rdbAbsent.Checked = True Then
                s = "Absent"
            ElseIf rdbPresent.Checked = True Then
                s = "Present"
            End If
            cm.Parameters.Add("@Attendence", SqlDbType.VarChar).Value = s
            cm.Parameters.Add("@IDate", SqlDbType.NVarChar).Value = CmbEmpId.Text & (dtpAttend.Value.ToShortDateString())
            Dim x As Integer = cm.ExecuteNonQuery()
            If x = 1 Then
                MsgBox("Record inserted successfully", MsgBoxStyle.Exclamation)
            Else
                MsgBox("Error in inserting records", MsgBoxStyle.Critical)
            End If
            see()
            clear()
            dr.Close()
        Catch ex As Exception
            MsgBox("Attendance already done ,please update to change", MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        ' dt.Clear()
        Try
            cm = New SqlCommand("update EmpAttendence set EName=@EName,Attendence=@Attendence where EId=@EId and EDate=@EDate", cn)
            cm.Parameters.Add("@EId", SqlDbType.Int).Value = CInt(CmbEmpId.Text)
            cm.Parameters.Add("@EName", SqlDbType.VarChar).Value = (TxtEmpName.Text)
            cm.Parameters.Add("@EDate", SqlDbType.DateTime).Value = CDate(dtpAttend.Value.ToShortDateString())
            Dim s As String = ""
            If rdbAbsent.Checked = True Then
                s = "Absent"
            ElseIf rdbPresent.Checked = True Then
                s = "Present"
            End If

            cm.Parameters.Add("@Attendence", SqlDbType.VarChar).Value = s
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
        ' dt.Clear()
        Try
            If MsgBox("Do You want to delete ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                cm = New SqlCommand("Delete from EmpAttendence where  EId=@EId and EDate=@EDate", cn)
                cm.Parameters.Add("@EId", SqlDbType.Int).Value = CInt(CmbEmpId.Text)
                cm.Parameters.Add("@EDate", SqlDbType.DateTime).Value = CDate(dtpAttend.Value.ToShortDateString())
                Dim x As Integer = cm.ExecuteNonQuery()
                If x = 1 Then
                    MsgBox("Record deleted successfully", MsgBoxStyle.Exclamation)
                    'Else
                    '    MsgBox("Error while deleting record", MsgBoxStyle.Critical)
                End If
                see()
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
        Try

            CmbEmpId.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()
            TxtEmpName.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString()
            dtpAttend.Text = CDate(DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString())
            Dim s As String = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString()
            If s = "Absent" Then
                rdbAbsent.Checked = True
            ElseIf s = "Present" Then
                rdbPresent.Checked = True
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub CmbEmpId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbEmpId.SelectedIndexChanged
        Try
            cm = New SqlCommand("select EName from EmpMaster where EId=" & CInt(CmbEmpId.Text), cn)
            dr = cm.ExecuteReader()
            If dr.Read() Then
                TxtEmpName.Text = dr(0).ToString()
            End If

            dr.Close()
            see()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub rdbAbsent_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbAbsent.CheckedChanged

    End Sub
End Class