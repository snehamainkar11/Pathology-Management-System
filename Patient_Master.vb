Imports System.Data
Imports System.Data.SqlClient
Public Class Patient_Master
    Dim cn As SqlConnection
    Dim cm As SqlCommand
    Dim dr As SqlDataReader
    Dim dt As DataTable
    Dim n, c As Integer
    Dim x As New ClassCon
    Private Sub Patient_Master_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatholabDBDataSet8.PatntMaster' table. You can move, or remove it, as needed.
        'Me.PatntMasterTableAdapter.Fill(Me.PatholabDBDataSet8.PatntMaster)
        cn = New SqlConnection(x.s)
        cn.Open()
        dt = New DataTable()
        see()
        btnnewid.Focus()
    End Sub

    Private Sub txtpatContact_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtpatContact.GotFocus
        txtpatContact.BackColor = Color.Yellow
        txtpatContact.Focus()

    End Sub
    Private Sub txtpatContact_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtpatContact.LostFocus
        Dim s As String = txtpatContact.Text
        txtpatContact.BackColor = Color.White
        If s.Length <> 10 Then
            MsgBox("Enter exact 10 Digit")
            txtpatContact.Focus()
        End If
    End Sub
    Private Sub txtpatContact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpatContact.KeyPress
        If Not IsNumeric(e.KeyChar) = True And e.KeyChar <> vbBack Then
            e.Handled = True
            ToolTip1.Show("Only Number", txtpatContact)
        Else
            ToolTip1.Hide(txtpatContact)
        End If
    End Sub

    Private Sub txtPatientId_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPatientId.KeyPress
        If Not IsNumeric(e.KeyChar) = True And e.KeyChar <> vbBack Then
            e.Handled = True
            ToolTip1.Show("Only Number", txtPatientId)
        Else
            ToolTip1.Hide(txtPatientId)
        End If
    End Sub

   
    Private Sub see()
        dt.Clear()
        cm = New SqlCommand("select * from PatntMaster order by PtId", cn)
        dr = cm.ExecuteReader()
        dt.Load(dr)
        dr.Close()
        n = dt.Rows.Count - 1
        DataGridView1.DataSource = dt

    End Sub
   
    Private Sub EachRecord()
        Try

        
            txtPatientId.Text = dt.Rows(c).Item(0).ToString()
            txtPatNm.Text = dt.Rows(c).Item(1).ToString()
            txtpatAddr.Text = dt.Rows(c).Item(2).ToString()

            txtPatEmail.Text = dt.Rows(c).Item(3).ToString()
            Dim s1 As String = dt.Rows(c).Item(4).ToString()
            If s1 = "Male" Then
                rdbMale.Checked = True
            ElseIf s1 = "Female" Then
                rdbFemale.Checked = True
            End If
            txtpatAge.Text = dt.Rows(c).Item(5).ToString()
            txtpatContact.Text = dt.Rows(c).Item(6).ToString()
        Catch ex As Exception

        End Try

    End Sub
    Private Sub BtnFirst_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFirst.Click
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
        cm = New SqlCommand("select max(PtId) from PatntMaster", cn)
        dr = cm.ExecuteReader()
        If dr.Read() Then
            txtPatientId.Text = CInt(dr(0) + 1)
        End If
        dr.Close()
        txtPatNm.Text = ""
        txtpatAddr.Text = ""
        txtPatEmail.Text = ""
        txtpatAge.Text = ""
        txtpatContact.Text = ""
        rdbFemale.Checked = False
        rdbMale.Checked = False
    End Sub
    Private Sub cnt()
        cm = New SqlCommand("select count(PtId) from PatntMaster", cn)
        dr = cm.ExecuteReader()
        If dr.Read() Then
            MsgBox("No. of  Patient Records=" & CInt(dr(0)), MsgBoxStyle.Information)
        End If
    End Sub
    Private Sub clear()
        txtPatientId.Text = ""
        txtPatNm.Text = ""
        txtpatAddr.Text = ""
        txtPatEmail.Text = ""
        txtpatAge.Text = ""
        txtpatContact.Text = ""
        rdbFemale.Checked = False
        rdbMale.Checked = False

    End Sub

    Dim a As String
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try

            txtPatientId.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()
            txtPatNm.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString()
            txtpatAddr.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString()

            txtPatEmail.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString()
            a = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString()
            If a = "Male" Then
                rdbMale.Checked = True
            ElseIf a = "Female" Then
                rdbFemale.Checked = True
            End If
            txtpatAge.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString()
            txtpatContact.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString()

        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            cm = New SqlCommand("insert into PatntMaster values(@PtId,@PNm,@PAddr,@Email,@PGndr,@Age,@Contact)", cn)
            cm.Parameters.Add("@PtId", SqlDbType.Int).Value = CInt(txtPatientId.Text)
            cm.Parameters.Add("@PNm", SqlDbType.VarChar).Value = (txtPatNm.Text)
            cm.Parameters.Add("@PAddr", SqlDbType.NVarChar).Value = (txtpatAddr.Text)
            cm.Parameters.Add("@Email", SqlDbType.VarChar).Value = (txtPatEmail.Text)
            Dim a As String = ""
            If rdbMale.Checked = True Then
                a = "Male"
            ElseIf rdbFemale.Checked = True Then
                a = "Female"
            End If
            cm.Parameters.Add("@PGndr", SqlDbType.VarChar).Value = a
            cm.Parameters.Add("@Age", SqlDbType.Int).Value = CInt(txtpatAge.Text)
            cm.Parameters.Add("@Contact", SqlDbType.BigInt).Value = CLng(txtpatContact.Text)
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
            dr.Close()
        End Try
    End Sub
    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            cm = New SqlCommand("update PatntMaster set PNm=@PNm,PAddr=@PAddr,Email=@Email,PGndr=@PGndr,Age=@Age,Contact=@Contact where PtId=@PtId", cn)
            cm.Parameters.Add("@PtId", SqlDbType.Int).Value = CInt(txtPatientId.Text)
            cm.Parameters.Add("@PNm", SqlDbType.VarChar).Value = (txtPatNm.Text)
            cm.Parameters.Add("@PAddr", SqlDbType.NVarChar).Value = (txtpatAddr.Text)
            cm.Parameters.Add("@Email", SqlDbType.VarChar).Value = (txtPatEmail.Text)
            Dim a As String = ""
            If rdbMale.Checked = True Then
                a = "Male"
            ElseIf rdbFemale.Checked = True Then
                a = "Female"
            End If
            cm.Parameters.Add("@PGndr", SqlDbType.VarChar).Value = a
            cm.Parameters.Add("@Age", SqlDbType.Int).Value = CInt(txtpatAge.Text)
            cm.Parameters.Add("@Contact", SqlDbType.BigInt).Value = CLng(txtpatContact.Text)
            Dim r As Integer = cm.ExecuteNonQuery()
            If r = 1 Then
                MsgBox("Record updated successfully", MsgBoxStyle.Exclamation)
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
                cm = New SqlCommand("delete from PatntMaster where PtId=@PtId", cn)
                cm.Parameters.AddWithValue("@PtId", (txtPatientId.Text))

                Dim r As Integer = cm.ExecuteNonQuery()
                If r = 1 Then
                    MsgBox("Record deleted Successfully", MsgBoxStyle.Exclamation)
                Else
                    MsgBox("Error", MsgBoxStyle.RetryCancel)
                End If
                see()
                cnt()
                clear()
                dr.Close()
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


    Private Sub txtPatEmail_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPatEmail.LostFocus
       
        Try
            Dim m As String = txtPatEmail.Text
            If Not m.Contains("@") Or Not m.Contains(".") Or (m.LastIndexOf(".") < m.IndexOf("@")) Then
                ToolTip1.Show("Error in Email Id", txtPatEmail)
            Else
                ToolTip1.Hide(txtPatEmail)
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class