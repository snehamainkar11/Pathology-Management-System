Imports System.Data
Imports System.Data.SqlClient
Public Class Doctor_Master
    Dim cn As SqlConnection
    Dim cm As SqlCommand
    Dim dr As SqlDataReader
    Dim dt As DataTable
    Dim n, c As Integer
    Dim x As New ClassCon
    Private Sub txtDoctorId_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDoctorId.KeyPress
        If Not IsNumeric(e.KeyChar) = True And e.KeyChar <> vbBack Then
            e.Handled = True
            ToolTip1.Show("Only Number", txtDoctorId)
        Else
            ToolTip1.Hide(txtDoctorId)
        End If
    End Sub

    Private Sub txtdocContact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdocContact.KeyPress
        If Not IsNumeric(e.KeyChar) = True And e.KeyChar <> vbBack Then
            e.Handled = True
            ToolTip1.Show("Only Number", txtdocContact)
        Else
            ToolTip1.Hide(txtdocContact)
        End If
    End Sub
    Private Sub txtdocContact_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtdocContact.GotFocus
        txtdocContact.BackColor = Color.Yellow
        txtdocContact.Focus()

    End Sub

    Private Sub txtdocContact_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtdocContact.LostFocus
        Dim s As String = txtdocContact.Text
        txtdocContact.BackColor = Color.White
        If s.Length <> 10 Then
            MsgBox("Enter exact 10 Digit")
            txtdocContact.Focus()
        End If
    End Sub
    Private Sub Doctor_Master_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatholabDBDataSet4.DoctMaster' table. You can move, or remove it, as needed.
        'Me.DoctMasterTableAdapter.Fill(Me.PatholabDBDataSet4.DoctMaster)
        cn = New SqlConnection(x.s)
        cn.Open()
        dt = New DataTable()
        see()
        btnnewid.Focus()
    End Sub
    Private Sub EachRecord()
        txtDoctorId.Text = dt.Rows(c).Item(0).ToString()
        txtDoctName.Text = dt.Rows(c).Item(1).ToString
        txtdoctadd.Text = dt.Rows(c).Item(2).ToString()
        Dim s As String = dt.Rows(c).Item(3).ToString()
        If s = "Male" Then
            rdbMale.Checked = True
        ElseIf s = "Female" Then
            rdbFemale.Checked = True
        End If
        txtdocAge.Text = dt.Rows(c).Item(4).ToString()
        txtdocContact.Text = dt.Rows(c).Item(5).ToString()
        txtdocqual.Text = dt.Rows(c).Item(6).ToString()
        End Sub


    Private Sub see()
        dt.Clear()
        cm = New SqlCommand("select * from DoctMaster order by DId", cn)
        dr = cm.ExecuteReader()
        dt.Load(dr)
        dr.Close()
        n = dt.Rows.Count - 1
        DataGridView1.DataSource = dt

    End Sub
    Private Sub clear()
        txtDoctorId.Clear()
        txtDoctName.Clear()
        txtdoctadd.Text = ""
        txtdocAge.Text = ""
        txtdocContact.Text = ""
        txtdocqual.Text = ""
        rdbFemale.Checked = False
        rdbMale.Checked = False
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
        cm = New SqlCommand("select max(DId) from DoctMaster", cn)
        dr = cm.ExecuteReader()
        Try
            If dr.Read() Then
                txtDoctorId.Text = CInt(dr(0) + 1)
            End If
            dr.Close()
        Catch ex As Exception
            txtDoctorId.Text = 1
        End Try

        txtDoctName.Text = ""
        txtdoctadd.Text = ""
        txtdocAge.Text = ""
        txtdocContact.Text = ""
        txtdocqual.Text = ""
        rdbFemale.Checked = False
        rdbMale.Checked = False
    End Sub
    Private Sub cnt()
        cm = New SqlCommand("select count(DId) from DoctMaster", cn)
        dr = cm.ExecuteReader()
        If dr.Read() Then
            MsgBox("No. of Doctors=" & CInt(dr(0)), MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        txtDoctorId.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()
        txtDoctName.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString()
        txtdoctadd.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString()
        Dim s1 As String = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString()
        If s1 = "Male" Then
            rdbMale.Checked = True
        ElseIf s1 = "Female" Then
            rdbFemale.Checked = True
        End If
        txtdocAge.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString()
        txtdocContact.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString()
        txtdocqual.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString()
    End Sub


    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        Try
            cm = New SqlCommand("Insert into DoctMaster values(@DId,@DName,@DAddr,@DGndr,@DAge,@DCntct,@DQual)", cn)
            cm.Parameters.Add("@DId", SqlDbType.Int).Value = CInt(txtDoctorId.Text)
            cm.Parameters.Add("@DName", SqlDbType.VarChar).Value = (txtDoctName.Text)
            cm.Parameters.Add("@DAddr", SqlDbType.NVarChar).Value = (txtdoctadd.Text)
            Dim a As String = ""
            If rdbMale.Checked = True Then
                a = "Male"
            ElseIf rdbFemale.Checked = True Then
                a = "Female"
            End If
            cm.Parameters.Add("@DGndr", SqlDbType.VarChar).Value = a
            cm.Parameters.Add("@DAge", SqlDbType.Int).Value = CInt(txtdocAge.Text)
            cm.Parameters.Add("@DCntct", SqlDbType.BigInt).Value = CLng(txtdocContact.Text)
            cm.Parameters.Add("@DQual", SqlDbType.VarChar).Value = txtdocqual.Text

            Dim r As Integer = cm.ExecuteNonQuery()
            If r = 1 Then
                MsgBox("Record Inserted Successfully", MsgBoxStyle.Exclamation)
            Else
                MsgBox("Error while Inserting record", MsgBoxStyle.RetryCancel)

            End If
            see()
            cnt()
            clear()
            dr.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        clear()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try

            cm = New SqlCommand("Update DoctMaster set DName=@DName,DAddr=@DAddr,DAge=@DAge,DGndr=@DGndr ,DCntct=@DCntct,DQual=@DQual where DId=@DId", cn)
            cm.Parameters.Add("@DId", SqlDbType.Int).Value = CInt(txtDoctorId.Text)
            cm.Parameters.Add("@DName", SqlDbType.VarChar).Value = (txtDoctName.Text)
            cm.Parameters.Add("@DAddr", SqlDbType.VarChar).Value = (txtdoctadd.Text)
            cm.Parameters.Add("@DAge", SqlDbType.Int).Value = CInt(txtdocAge.Text)
            cm.Parameters.Add("@DCntct", SqlDbType.BigInt).Value = CLng(txtdocContact.Text)
            cm.Parameters.Add("@DQual", SqlDbType.VarChar).Value = txtdocqual.Text
            Dim a As String = ""
            If rdbMale.Checked = True Then
                a = "Male"
            ElseIf rdbFemale.Checked = True Then
                a = "Female"
            End If
            cm.Parameters.Add("@DGndr", SqlDbType.VarChar).Value = a

            Dim r As Integer = cm.ExecuteNonQuery()
            If r = 1 Then
                MsgBox("Record Updated Successfully", MsgBoxStyle.Exclamation)
            Else
                MsgBox("Error while Updating Record", MsgBoxStyle.RetryCancel)
            End If
            see()

            clear()
            dr.Close()
        Catch ex As Exception
            clear()
        End Try

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If MsgBox("Do You want to Delete ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                cm = New SqlCommand("delete from DoctMaster where DId=@DId", cn)
                cm.Parameters.AddWithValue("@DId", (txtDoctorId.Text))
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

End Class