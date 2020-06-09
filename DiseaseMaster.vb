
Imports System.Data
Imports System.Data.SqlClient
Public Class DiseaseMaster

    Dim cn As SqlConnection
    Dim cm As SqlCommand
    Dim dr As SqlDataReader
    Dim dt, dt2 As DataTable
    Dim n, c As Integer
    Dim x As New ClassCon
    Private Sub DiseaseMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatholabDBDataSet22.Disease' table. You can move, or remove it, as needed.
        'Me.DiseaseTableAdapter.Fill(Me.PatholabDBDataSet22.Disease)

        cn = New SqlConnection(x.s)
        cn.Open()
        dt2 = New DataTable()
        see1()
        dt = New DataTable()
        see()
        btnnewid.Focus()
    End Sub
    Private Sub EachRecord()

        txtDisId.Text = dt.Rows(c).Item(0).ToString()
        txtDisNm.Text = dt.Rows(c).Item(1).ToString()

        Dim l As String = dt.Rows(c).Item(2).ToString()
        Dim lt() As String = l.Split(",")
        Dim j, k As Integer
        j = 0
        k = 0
        'For j = 0 To LstTestNm.Items.Count - 1
        '    LstTestNm.SetSelected(j, False)
        'Next
        'Dim ie As IEnumerable = LstTestNm.Items
        'Dim e1 As IEnumerator = ie.GetEnumerator()
        ' Dim f As Integer = 0
        'LstTestNm.DataBindings.Clear()
        'dt2.Clear()
        ' LstTestNm.DataSource = dt2


        Try
            If LstTestNm.Items.Count > 0 Then
                LstTestNm.Items.Clear()

            End If
            For k = 0 To lt.Length - 1
                LstTestNm.Items.Add(lt(k))

            Next

        Catch ex As Exception
            ' dt2.Clear()
            


        End Try


    End Sub
    Private Sub clear()

        txtDisNm.Text = ""
        txtDisId.Text = ""
        LstTestNm.Text = ""
        LstTestNm.Items.Clear()

    End Sub

    Private Sub see()
        dt.Clear()
        cm = New SqlCommand("select * from Disease order by DId", cn)
        dr = cm.ExecuteReader()
        dt.Load(dr)
        dr.Close()
        n = dt.Rows.Count - 1
        DataGridView1.DataSource = dt

    End Sub
    Private Sub see1()
        dt2.Clear()
        cm = New SqlCommand("select * from TestRecord", cn)
        dr = cm.ExecuteReader()
        dt2.Load(dr)
        dr.Close()
        'LstTestNm.DataSource = dt2
        'LstTestNm.ValueMember = "TestName"
        LstTestNm.DisplayMember = "TestName"
        Dim h As Integer = 0
        LstTestNm.Items.Clear()

        For h = 0 To dt2.Rows.Count - 1
            LstTestNm.Items.Add(dt2.Rows(h).Item(2).ToString())
        Next
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
        cm = New SqlCommand("select max(DId) from Disease", cn)
        dr = cm.ExecuteReader()
        If dr.Read() Then
            txtDisId.Text = CInt(dr(0) + 1)
        End If
        dr.Close()
        txtDisNm.Text = ""
        LstTestNm.Items.Clear()
    End Sub
    Private Sub cnt()
        cm = New SqlCommand("select count(DId) from Disease", cn)
        dr = cm.ExecuteReader()
        If dr.Read() Then
            MsgBox("No. of Records=" & CInt(dr(0)), MsgBoxStyle.Information)
        End If
        dr.Close()

    End Sub
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        clear()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        txtDisId.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()
        txtDisNm.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString()
        Dim l As String = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString()
        Dim lt() As String = l.Split(",")
        Dim j, k As Integer
        j = 0
        k = 0

        Try
            If LstTestNm.Items.Count > 0 Then
                LstTestNm.Items.Clear()

            End If
            For k = 0 To lt.Length - 1
                LstTestNm.Items.Add(lt(k))

            Next

        Catch ex As Exception
            ' dt2.Clear()



        End Try

    End Sub

    Private Sub txtDisId_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDisId.KeyPress
        If Not IsNumeric(e.KeyChar) = True And e.KeyChar <> vbBack Then
            e.Handled = True
            ToolTip1.Show("Only Number", txtDisId)
        Else
            ToolTip1.Hide(txtDisId)
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try

            Dim x As String = ""
            Dim s As String = ""
            Dim j As Integer = 0
            While j < LstTestNm.Items.Count - 1
                If LstTestNm.GetSelected(j) Then
                    s &= LstTestNm.Items(j).ToString() & ","
                End If

                j += 1
            End While
            x &= s.Substring(0, s.Length - 1)
            cm = New SqlCommand("insert into Disease values(@DId,@Disease,@TestName)", cn)
            cm.Parameters.Add("@DId", SqlDbType.Int).Value = CInt(txtDisId.Text)
            cm.Parameters.Add("@Disease", SqlDbType.VarChar).Value = (txtDisNm.Text)
            cm.Parameters.Add("@TestName", SqlDbType.NVarChar).Value = x
            Dim r As Integer = cm.ExecuteNonQuery()
            If r = 1 Then
                MsgBox("Record Inserted Successfully", MsgBoxStyle.Exclamation)
            Else
                MsgBox("Error while Inserting Record", MsgBoxStyle.RetryCancel)
            End If
            see()
            cnt()
            clear()

        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            Dim x As String = ""
            Dim s As String = ""
            Dim j As Integer = 0
            While j < LstTestNm.Items.Count - 1
                If LstTestNm.GetSelected(j) Then
                    s &= LstTestNm.Items(j).ToString() & ","
                End If

                j += 1
            End While
            x &= s.Substring(0, s.Length - 1)
            cm = New SqlCommand("update Disease set Disease=@Disease,TestName=@TestName where DId=@DId", cn)
            cm.Parameters.Add("@DId", SqlDbType.Int).Value = CInt(txtDisId.Text)
            cm.Parameters.Add("@Disease", SqlDbType.VarChar).Value = (txtDisNm.Text)
            cm.Parameters.Add("@TestName", SqlDbType.NVarChar).Value = x
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
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try

            If MsgBox("Do You want to delete ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                cm = New SqlCommand("delete from Disease where DId=@DId", cn)
                cm.Parameters.AddWithValue("@DId", (txtDisId.Text))

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

   

    Private Sub LstTestNm_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstTestNm.SelectedIndexChanged
        Try

            cm = New SqlCommand("select TestName from TestRecord where TestName= " & (LstTestNm.Text), cn)
            dr = cm.ExecuteReader()
            If dr.Read() Then

                Dim xx As String = dr(0).ToString
                Dim yy() As String = xx.Split(",")
                LstTestNm.Items.Clear()

                For Each z In yy
                    LstTestNm.Items.Add(z)

                Next

            End If
            dr.Close()
        Catch ex As Exception

        End Try
    End Sub




    Private Sub btnTestFill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTestFill.Click
        see1()

    End Sub

   

    
End Class