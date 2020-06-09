Imports System.Data
Imports System.Data.SqlClient
Public Class ReportInward
    Private cn As SqlConnection
    Private cm As SqlCommand
    Private dr As SqlDataReader
    Private dt, dt1, dt2 As New DataTable
    Dim c, n, i As Integer
    Private Sub ReportInward_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatholabDBDataSet13.RInwrd' table. You can move, or remove it, as needed.
        'Me.RInwrdTableAdapter.Fill(Me.PatholabDBDataSet13.RInwrd)

        cn = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Htc\Documents\Visual Studio 2008\Projects\Pathology\Pathology\patholabDB.mdf;Integrated Security=True;User Instance=True")
        cn.Open()
        dt1 = New DataTable()
        see1()
        dt2 = New DataTable()
        see2()
        dt = New DataTable()
        see()
        btnnewid.Focus()
    End Sub

    Private Sub txtRInId_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRInId.KeyPress
        If Not IsNumeric(e.KeyChar) = True And e.KeyChar <> vbBack Then
            e.Handled = True
            ToolTip1.Show("Only Number", txtRInId)
        Else
            ToolTip1.Hide(txtRInId)
        End If
    End Sub

    Private Sub txtContact_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtContact.GotFocus
        txtContact.BackColor = Color.Yellow
        txtContact.Focus()
    End Sub

    Private Sub txtContact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContact.KeyPress
        If Not IsNumeric(e.KeyChar) = True And e.KeyChar <> vbBack Then
            e.Handled = True
            ToolTip1.Show("Only Number", txtContact)
        Else
            ToolTip1.Hide(txtContact)
        End If
    End Sub

    Private Sub txtContact_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtContact.LostFocus
        Dim s As String = txtContact.Text
        txtContact.BackColor = Color.White
        If s.Length <> 10 Then
            MsgBox("Enter exact 10 Digit")
            txtContact.Focus()
        End If
    End Sub
    Private Sub see()
        dt.Clear()
        cm = New SqlCommand("select * from RInwrd order by RInId", cn)
        dr = cm.ExecuteReader()
        dt.Load(dr)
        dr.Close()
        n = dt.Rows.Count - 1
        DataGridView1.DataSource = dt

    End Sub
    Private Sub see1()
        dt1.Clear()
        cm = New SqlCommand("select * from PatntCheckup order by PId", cn)
        dr = cm.ExecuteReader()
        dt1.Load(dr)
        dr.Close()
        cmbPatNm.DataSource = dt1
        cmbPatNm.ValueMember = "PName"
        cmbPatNm.DisplayMember = "PName"

    End Sub
    Private Sub see2()
        dt2.Clear()
        cm = New SqlCommand("select * from DoctMaster order by DId", cn)
        dr = cm.ExecuteReader()
        dt2.Load(dr)
        dr.Close()
        cmbRcvBy.DataSource = dt2
        cmbRcvBy.ValueMember = "DName"
        cmbRcvBy.DisplayMember = "DName"

    End Sub
    Private Sub EachRecord()
        txtRInId.Text = dt.Rows(c).Item(0).ToString()
        cmbPatNm.Text = dt.Rows(c).Item(1).ToString()
        txtPatAddr.Text = dt.Rows(c).Item(2).ToString()
        dtpRInDte.Text = CDate(dt.Rows(c).Item(3).ToString())
        txtContact.Text = dt.Rows(c).Item(4).ToString()
        txtDoc.Text = dt.Rows(c).Item(5).ToString()
        txtDisease.Text = dt.Rows(c).Item(6).ToString()
        lstTest.Text = dt.Rows(c).Item(7).ToString()
        txtRmarkByDr.Text = dt.Rows(c).Item(8).ToString()
        DTPRprtDlvryDte.Text = CDate(dt.Rows(c).Item(9).ToString())
        cmbRcvBy.Text = dt.Rows(c).Item(10).ToString()



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
        cm = New SqlCommand("select max(RInId) from RInwrd", cn)
        dr = cm.ExecuteReader()
        If dr.Read() Then
            txtRInId.Text = CInt(dr(0) + 1)
        End If
        dr.Close()
        CmbPatNm.Text = ""
        txtPatAddr.Text = ""
        txtDisease.Text = ""
        txtRmarkByDr.Text = ""
        txtDoc.Text = ""
        cmbRcvBy.Text = ""
        txtContact.Text = ""
        lstTest.Items.Clear()
    End Sub
    Private Sub cnt()
        cm = New SqlCommand("select count(RInId) from RInwrd", cn)
        dr = cm.ExecuteReader()
        If dr.Read() Then
            MsgBox("No. of records=" & CInt(dr(0)), MsgBoxStyle.Information)
        End If
    End Sub
    Private Sub clear()
        txtRInId.Text = ""
        txtRInId.Text = ""
        CmbPatNm.Text = ""
        txtPatAddr.Text = ""
        txtDoc.Text = ""
        txtDisease.Text = ""
        txtRmarkByDr.Text = ""
        cmbRcvBy.Text = ""
        txtContact.Text = ""
        lstTest.Items.Clear()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            Dim ii As IEnumerator = lstTest.SelectedItems.GetEnumerator()
            Dim s As String = ""
            While ii.MoveNext
                s &= ii.Current & ",".ToString()
            End While
            Dim x As String = ""
            x &= s.Substring(0, s.Length - 1)
            cm = New SqlCommand("insert into RInwrd values(@RInId,@PNm,@PAddr,@RDate,@ContactNo,@DrNm,@Disease,@TestName,@RmrkByDoc,@DlvryDate,@RcvBy)", cn)
            cm.Parameters.Add("@RInId", SqlDbType.Int).Value = CInt(txtRInId.Text)
            cm.Parameters.Add("@PNm", SqlDbType.VarChar).Value = (cmbPatNm.Text)
            cm.Parameters.Add("@PAddr", SqlDbType.NVarChar).Value = (txtPatAddr.Text)
            cm.Parameters.Add("@RDate", SqlDbType.DateTime).Value = CDate(dtpRInDte.Value)
            cm.Parameters.Add("@ContactNo", SqlDbType.BigInt).Value = CLng(txtContact.Text)
            cm.Parameters.Add("@DrNm", SqlDbType.VarChar).Value = (txtDoc.Text)
            cm.Parameters.Add("@Disease", SqlDbType.VarChar).Value = (txtDisease.Text)
            cm.Parameters.Add("@TestName", SqlDbType.NVarChar).Value = x
            cm.Parameters.Add("@RmrkByDoc", SqlDbType.NVarChar).Value = (txtRmarkByDr.Text)
            cm.Parameters.Add("@DlvryDate", SqlDbType.DateTime).Value = CDate(DTPRprtDlvryDte.Value)
            cm.Parameters.Add("@RcvBy", SqlDbType.VarChar).Value = (cmbRcvBy.Text)
            Dim r As Integer = cm.ExecuteNonQuery()
            If r = 1 Then
                MsgBox("Record inserted successfully", MsgBoxStyle.Exclamation)
            Else
                MsgBox("Error while inserting record", MsgBoxStyle.RetryCancel)

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
            Dim ii As IEnumerator = lstTest.SelectedItems.GetEnumerator()
            Dim s As String = ""
            While ii.MoveNext
                s &= ii.Current & ",".ToString()
            End While
            Dim x As String = ""
            x &= s.Substring(0, s.Length - 1)
            cm = New SqlCommand("update RInwrd set PNm=@PNm,PAddr=@PAddr,RDate=@RDate,ContactNo=@ContactNo,DrNm=@DrNm,Disease=@Disease,TestName=@TestName,RmrkByDoc=@RmrkByDoc,DlvryDate=@DlvryDate,RcvBy=@RcvBy where RInId=@RInId", cn)
            cm.Parameters.Add("@RInId", SqlDbType.Int).Value = CInt(txtRInId.Text)
            cm.Parameters.Add("@PNm", SqlDbType.VarChar).Value = (cmbPatNm.Text)
            cm.Parameters.Add("@PAddr", SqlDbType.NVarChar).Value = (txtPatAddr.Text)
            cm.Parameters.Add("@RDate", SqlDbType.DateTime).Value = CDate(dtpRInDte.Value)
            cm.Parameters.Add("@ContactNo", SqlDbType.BigInt).Value = CLng(txtContact.Text)
            cm.Parameters.Add("@DrNm", SqlDbType.VarChar).Value = (txtDoc.Text)
            cm.Parameters.Add("@Disease", SqlDbType.VarChar).Value = (txtDisease.Text)
            cm.Parameters.Add("@TestName", SqlDbType.NVarChar).Value = x
            cm.Parameters.Add("@RmrkByDoc", SqlDbType.NVarChar).Value = (txtRmarkByDr.Text)
            cm.Parameters.Add("@DlvryDate", SqlDbType.DateTime).Value = CDate(DTPRprtDlvryDte.Value)
            cm.Parameters.Add("@RcvBy", SqlDbType.VarChar).Value = (cmbRcvBy.Text)

            Dim r As Integer = cm.ExecuteNonQuery()
            If r = 1 Then
                MsgBox("Record updated successfully", MsgBoxStyle.Exclamation)
            Else
                MsgBox("Error while updating record", MsgBoxStyle.RetryCancel)

            End If
            see()
            cnt()
            clear()
            dr.Close()
        Catch ex As Exception

        End Try
    End Sub


    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If MsgBox("Do You want to Delete ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                cm = New SqlCommand("delete from RInwrd where RInId=@RInId", cn)
                cm.Parameters.AddWithValue("@RInId", (txtRInId.Text))
                Dim r As Integer = cm.ExecuteNonQuery()
                If r = 1 Then
                    MsgBox("Record deleted Successfully", MsgBoxStyle.Exclamation)
                Else
                    MsgBox("Error in deleting record", MsgBoxStyle.RetryCancel)
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
        txtRInId.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()
        cmbPatNm.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString()
        txtPatAddr.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString()
        dtpRInDte.Text = CDate(DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString())
        txtContact.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString()
        txtDoc.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString()
        txtDisease.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString()
        lstTest.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value.ToString()
        txtRmarkByDr.Text = DataGridView1.Rows(e.RowIndex).Cells(8).Value.ToString()
        DTPRprtDlvryDte.Text = CDate(DataGridView1.Rows(e.RowIndex).Cells(9).Value.ToString())
        cmbRcvBy.Text = DataGridView1.Rows(e.RowIndex).Cells(10).Value.ToString()


    End Sub




    Private Sub cmbRcvBy_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            cm = New SqlCommand("select DName from DoctMaster where DName= " & (cmbRcvBy.Text), cn)
            dr = cm.ExecuteReader()
            If dr.Read() Then
                cmbRcvBy.Text = dr(0).ToString()

            End If
            dr.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmbPatNm_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPatNm.SelectedIndexChanged
        Try
            cm = New SqlCommand("select PAddr,PContact,Disease,SugTest from PatntCheckup where PName= '" & (cmbPatNm.Text) & "'", cn)
            dr = cm.ExecuteReader()
            If dr.Read() Then

                txtPatAddr.Text = dr(0).ToString()
                txtContact.Text = dr(1).ToString()

                txtDisease.Text = dr(2).ToString()

                Dim xx As String = dr(3).ToString
                Dim yy() As String = xx.Split(",")
                lstTest.Items.Clear()

                For Each z In yy
                    lstTest.Items.Add(z)

                Next

            End If
            dr.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmbRcvBy_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRcvBy.SelectedIndexChanged
        Try
            cm = New SqlCommand("select DName from DoctMstr where DName= '" & (cmbRcvBy.Text) & "'", cn)
            dr = cm.ExecuteReader()
            If dr.Read() Then

                cmbRcvBy.Text = dr(0).ToString()


            End If
            dr.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class