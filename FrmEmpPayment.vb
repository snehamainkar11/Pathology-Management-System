Imports System.Data
Imports System.Data.SqlClient
Public Class FrmEmpPayment

    Dim cn As SqlConnection
    Dim cm As SqlCommand
    Dim dr As SqlDataReader
    Dim dt, dt1, dt2 As DataTable
    Dim n, c As Integer
    Dim x As New ClassCon
    Private Sub FrmEmpPayment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatholabDBDataSet7.EmpPayment' table. You can move, or remove it, as needed.
        'Me.EmpPaymentTableAdapter.Fill(Me.PatholabDBDataSet7.EmpPayment)
        cn = New SqlConnection(x.s)
        cn.Open()
        dt1 = New DataTable()
        see1()
        
        dt2 = New DataTable()
        seeEmp()
        dt = New DataTable()
        see()
        btnAdd.Focus()
    End Sub
    Private Sub EachRecord()
        CmbEmpId.Text = dt.Rows(c).Item(0).ToString()
        TxtEmpName.Text = dt.Rows(c).Item(1).ToString()
        TxtBasicSal.Text = dt.Rows(c).Item(2).ToString()
        StartDateTimePicker.Text = dt.Rows(c).Item(3).ToString()
        EndTimePicker.Text = dt.Rows(c).Item(4).ToString()
        TxtPresentDays.Text = dt.Rows(c).Item(5).ToString()
        TxtPayment.Text = dt.Rows(c).Item(6).ToString()
        CmbPaidBy.Text = dt.Rows(c).Item(7).ToString()
    End Sub
    Private Sub see()
        dt.Clear()
        cm = New SqlCommand("select * from EmpPayment order by EId", cn)
        dr = cm.ExecuteReader()
        dt.Load(dr)
        dr.Close()
        n = dt.Rows.Count - 1
        DataGridView1.DataSource = dt

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
    Private Sub seeEmp()
        dt2.Clear()
        cm = New SqlCommand("select * from EmpMaster order by EId", cn)
        dr = cm.ExecuteReader()
        dt2.Load(dr)
        dr.Close()
        CmbPaidBy.DataSource = dt2
        CmbPaidBy.ValueMember = "EName"
        CmbPaidBy.DisplayMember = "EName"
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
        TxtBasicSal.Text = ""
        TxtPresentDays.Text = ""
        TxtPayment.Text = ""
        CmbPaidBy.Text = ""
        StartDateTimePicker.Text = ""
        EndTimePicker.Text = ""
    End Sub
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try

            CmbEmpId.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()
            TxtEmpName.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString()
            TxtBasicSal.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString()
            StartDateTimePicker.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString()
            EndTimePicker.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString()
            TxtPresentDays.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString()
            TxtPayment.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString()
            CmbPaidBy.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value.ToString()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            cm = New SqlCommand("insert into EmpPayment values(@EId,@EName,@Esal,@SDate,@EDate,@PresentDays,@Payment,@PaidBy)", cn)
            cm.Parameters.Add("@EId", SqlDbType.Int).Value = CInt(CmbEmpId.Text)
            cm.Parameters.Add("@EName", SqlDbType.VarChar).Value = (TxtEmpName.Text)
            cm.Parameters.Add("@Esal", SqlDbType.Float).Value = CSng(TxtBasicSal.Text)
            cm.Parameters.Add("@SDate", SqlDbType.DateTime).Value = CDate(StartDateTimePicker.Value.ToShortDateString)
            cm.Parameters.Add("@EDate", SqlDbType.DateTime).Value = CDate(EndTimePicker.Value.ToShortDateString)
            cm.Parameters.Add("@PresentDays", SqlDbType.Int).Value = CInt(TxtPresentDays.Text)
            cm.Parameters.Add("@Payment", SqlDbType.Float).Value = CSng(TxtPayment.Text)
            cm.Parameters.Add("@PaidBy", SqlDbType.VarChar).Value = (CmbPaidBy.Text)
            Dim x As Integer = cm.ExecuteNonQuery()
            If x = 1 Then
                MsgBox("Record inserted successfully", MsgBoxStyle.Exclamation)
            Else
                MsgBox("Error while inserting record", MsgBoxStyle.Critical)
            End If
            see()

            clear()
            dr.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            cm = New SqlCommand("Update EmpPayment set EName=@EName,Esal=@Esal,SDate=@SDate,EDate=@EDate,PresentDays=@PresentDays,Payment=@Payment,PaidBy=@PaidBy where EId=@EId", cn)
            cm.Parameters.Add("@EId", SqlDbType.Int).Value = CInt(CmbEmpId.Text)
            cm.Parameters.Add("@EName", SqlDbType.VarChar).Value = (TxtEmpName.Text)
            cm.Parameters.Add("@Esal", SqlDbType.Float).Value = CSng(TxtBasicSal.Text)
            cm.Parameters.Add("@SDate", SqlDbType.DateTime).Value = CDate(StartDateTimePicker.Value.ToShortDateString)
            cm.Parameters.Add("@EDate", SqlDbType.DateTime).Value = CDate(EndTimePicker.Value.ToShortDateString)
            cm.Parameters.Add("@PresentDays", SqlDbType.Int).Value = CInt(TxtPresentDays.Text)
            cm.Parameters.Add("@Payment", SqlDbType.Float).Value = CSng(TxtPayment.Text)
            cm.Parameters.Add("@PaidBy", SqlDbType.VarChar).Value = (CmbPaidBy.Text)
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
            dr.Close()
        End Try
    End Sub


    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If MsgBox("Do You want to delete ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                cm = New SqlCommand("Delete from EmpPayment where EId=@EId", cn)
                cm.Parameters.Add("@EId", SqlDbType.Int).Value = CInt(CmbEmpId.Text)
                Dim x As Integer = cm.ExecuteNonQuery()
                If x = 1 Then
                    MsgBox("Record deleted successfully", MsgBoxStyle.Exclamation)
                Else
                    MsgBox("Error while deleting record", MsgBoxStyle.Critical)
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


    Private Sub CmbEmpId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbEmpId.SelectedIndexChanged
        Try
            cm = New SqlCommand("select EName,Esal from EmpMaster where EId=" & CInt(CmbEmpId.Text), cn)
             dr = cm.ExecuteReader()
            If dr.Read() Then
                TxtEmpName.Text = dr(0).ToString()
                TxtBasicSal.Text = dr(1).ToString()
            End If
           
            dr.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub EndTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EndTimePicker.ValueChanged
        Try

            cm = New SqlCommand("select  count(EId)  from EmpAttendence where Attendence ='Present' and EDate between @d1 and @d2 and EId= " & CInt(CmbEmpId.Text), cn)
            cm.Parameters.Add("@d1", SqlDbType.DateTime).Value = CDate(StartDateTimePicker.Value.ToShortDateString)
            cm.Parameters.Add("@d2", SqlDbType.DateTime).Value = CDate(EndTimePicker.Value.ToShortDateString)
            dr = cm.ExecuteReader()
            If dr.Read() Then
                TxtPresentDays.Text = dr(0).ToString()
            End If
            dr.Close()
            TxtPayment.Text = Val(TxtPresentDays.Text) * CSng(TxtBasicSal.Text) / 30


        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub CmbPaidBy_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbPaidBy.SelectedIndexChanged
        Try


            cm = New SqlCommand("select EName from EmpMaster where EName=@EName", cn)

            dr = cm.ExecuteReader()
            If dr.Read() Then
                CmbPaidBy.Text = dr(0).ToString()
            End If

            dr.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lblLnkPrint_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblLnkPrint.LinkClicked
        Me.Hide()
        rptEmpPayment.Show()
    End Sub
End Class