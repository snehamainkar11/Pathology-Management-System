Imports System.Data
Imports System.Data.SqlClient


Public Class Patient_Checkup

    Dim cn As SqlConnection
    Dim cm As SqlCommand
    Dim dr As SqlDataReader
    Dim dt, dt1, dt2, dt3 As DataTable
    Dim n, c As Integer
    Dim x As New ClassCon
    Private Sub Patient_Checkup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''TODO: This line of code loads data into the 'PatholabDBDataSet2.PatntCheckup' table. You can move, or remove it, as needed.
        'Me.PatntCheckupTableAdapter.Fill(Me.PatholabDBDataSet2.PatntCheckup)
        btnnewid.Focus()
        cn = New SqlConnection(x.s)
        cn.Open()
        dt1 = New DataTable()
        seePM()
        dt2 = New DataTable()
        seeDoct()
        dt3 = New DataTable()
        seeTest()
        dt = New DataTable()
        see()

    End Sub

    Private Sub seePM()
        dt1.Clear()
        cm = New SqlCommand("select * from PatntMaster", cn)
        dr = cm.ExecuteReader()
        dt1.Load(dr)
        dr.Close()
        CmbPatId.DataSource = dt1
        CmbPatId.ValueMember = "PtId"
        CmbPatId.DisplayMember = "PtId"


    End Sub
    Private Sub seeDoct()
        dt2.Clear()
        cm = New SqlCommand("select * from EmpMaster ", cn)
        dr = cm.ExecuteReader()
        dt2.Load(dr)
        dr.Close()
        CmbSampleBy.DataSource = dt2
        CmbSampleBy.ValueMember = "EName"
        CmbSampleBy.DisplayMember = "EName"


    End Sub
    Private Sub seeTest()
        dt3.Clear()
        cm = New SqlCommand("select * from Disease ", cn)
        dr = cm.ExecuteReader()
        dt3.Load(dr)
        dr.Close()
        CmbDisease.DataSource = dt3
        CmbDisease.ValueMember = "Disease"
        CmbDisease.DisplayMember = "Disease"


    End Sub

    Private Sub see()
        dt.Clear()
        cm = New SqlCommand("select * from PatntCheckup order by PId", cn)
        dr = cm.ExecuteReader()
        dt.Load(dr)
        dr.Close()
        n = dt.Rows.Count - 1
        DataGridView1.DataSource = dt

    End Sub

    Private Sub EachRecord()
        txtPatChkpId.Text = dt.Rows(c).Item(0).ToString
        CmbPatId.Text = dt.Rows(c).Item(1).ToString
        txtPatientName.Text = dt.Rows(c).Item(2).ToString
        txtPatientAddress.Text = dt.Rows(c).Item(3).ToString
        txtEmail.Text = dt.Rows(c).Item(4).ToString
        Dim s As String = dt.Rows(c).Item(5).ToString()
        If s = "Male" Then
            rdbmale.Checked = True
        ElseIf s = "Female" Then
            rdbFemale.Checked = True
        End If
        txtAge.Text = dt.Rows(c).Item(6).ToString
        txtContact.Text = dt.Rows(c).Item(7).ToString
        CmbSampleBy.Text = dt.Rows(c).Item(8).ToString
        CmbDisease.Text = dt.Rows(c).Item(9).ToString
        Dim l As String = dt.Rows(c).Item(10).ToString
        Dim lt() As String = l.Split(",")
        Dim j, k As Integer
        j = 0
        k = 0

        Try
            If lstTestNm.Items.Count > 0 Then
                lstTestNm.Items.Clear()
            End If
            For k = 0 To lt.Length - 1
                lstTestNm.Items.Add(lt(k))
            Next
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
        cm = New SqlCommand("select max(PId) from PatntCheckup", cn)
        dr = cm.ExecuteReader()
        If dr.Read() Then
            txtPatChkpId.Text = CInt(dr(0) + 1)
        End If
        dr.Close()
        CmbPatId.Text = ""
        txtPatientName.Text = ""
        txtPatientAddress.Text = ""
        txtEmail.Text = ""
        rdbFemale.Checked = False
        rdbmale.Checked = False
        txtAge.Text = ""
        txtContact.Text = ""
        CmbSampleBy.Text = ""
        CmbDisease.Text = ""
        lstTestNm.Items.Clear()


    End Sub
    Private Sub cnt()
        cm = New SqlCommand("select count(PId) from PatntCheckup", cn)
        dr = cm.ExecuteReader()
        If dr.Read() Then
            MsgBox("No. of Records=" & CInt(dr(0)), MsgBoxStyle.Information)
        End If
    End Sub
    Private Sub clear()
        txtPatChkpId.Text = ""
        CmbPatId.Text = ""
        txtPatientName.Text = ""
        txtPatientAddress.Text = ""
        txtEmail.Text = ""
        rdbFemale.Checked = False
        rdbmale.Checked = False
        txtAge.Text = ""
        txtContact.Text = ""
        CmbSampleBy.Text = ""
        CmbDisease.Text = ""
        lstTestNm.Items.Clear()

    End Sub

    Private Sub txtPatChkpId_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPatChkpId.KeyPress
        If Not IsNumeric(e.KeyChar) = True And e.KeyChar <> vbBack Then
            e.Handled = True
            ToolTip1.Show("Only Number", txtPatChkpId)
        Else
            ToolTip1.Hide(txtPatChkpId)
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
    Dim s As String
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        txtPatChkpId.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()
        CmbPatId.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString()
        txtPatientName.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString()
        txtPatientAddress.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString()
        txtEmail.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString()
        s = DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString()
        If s = "Male" Then
            rdbmale.Checked = True
        ElseIf s = "Female" Then
            rdbFemale.Checked = True
        End If
        txtAge.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString()
        txtContact.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value.ToString()
        CmbSampleBy.Text = DataGridView1.Rows(e.RowIndex).Cells(8).Value.ToString()
        CmbDisease.Text = DataGridView1.Rows(e.RowIndex).Cells(9).Value.ToString()
        Dim l As String = DataGridView1.Rows(e.RowIndex).Cells(10).Value.ToString()

        Dim lt() As String = l.Split(",")
        Dim j, k As Integer
        j = 0
        k = 0

        Try
            If lstTestNm.Items.Count > 0 Then
                lstTestNm.Items.Clear()
            End If
            For k = 0 To lt.Length - 1
                lstTestNm.Items.Add(lt(k))
            Next
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
     Try

            Dim x As String = ""
            Dim s As String = ""
            Dim j As Integer = 0
            While j < lstTestNm.Items.Count
                If lstTestNm.GetSelected(j) Then
                    s &= lstTestNm.Items(j).ToString() & ","
                End If

                j += 1
            End While
            x &= s.Substring(0, s.Length - 1)
            cm = New SqlCommand("insert into PatntCheckup values(@PId,@PtId,@PName,@PAddr,@Email,@PGen,@PAge,@PContact,@SampleBy,@Disease,@SugTest)", cn)
            cm.Parameters.Add("@PId", SqlDbType.Int).Value = CInt(txtPatChkpId.Text)
            cm.Parameters.Add("@PtId", SqlDbType.Int).Value = CInt(CmbPatId.Text)
            cm.Parameters.Add("@PName", SqlDbType.VarChar).Value = (txtPatientName.Text)
            cm.Parameters.Add("@PAddr", SqlDbType.NVarChar).Value = (txtPatientAddress.Text)
            cm.Parameters.Add("@Email", SqlDbType.NVarChar).Value = (txtEmail.Text)
            Dim a As String = ""
            If rdbmale.Checked = True Then
                a = "Male"
            ElseIf rdbFemale.Checked = True Then
                a = "Female"
            End If
            cm.Parameters.Add("@PGen", SqlDbType.VarChar).Value = a
            cm.Parameters.Add("@PAge", SqlDbType.Int).Value = CInt(txtAge.Text)
            cm.Parameters.Add("@PContact", SqlDbType.BigInt).Value = CLng(txtContact.Text)
            cm.Parameters.Add("@SampleBy", SqlDbType.VarChar).Value = (CmbSampleBy.Text)
            cm.Parameters.Add("@Disease", SqlDbType.VarChar).Value = (CmbDisease.Text)
            cm.Parameters.Add("@SugTest", SqlDbType.NVarChar).Value = x

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
            'Dim ii As IEnumerator = lstTest.SelectedItems.GetEnumerator()
            'Dim s As String = ""
            'While ii.MoveNext
            '    s &= ii.Current.ToString() & ","
            'End While

            Dim x As String = ""
            Dim s As String = ""
            Dim j As Integer = 0
            While j < lstTestNm.Items.Count
                If lstTestNm.GetSelected(j) Then
                    s &= lstTestNm.Items(j).ToString() & ","
                End If
                j += 1
            End While
            x &= s.Substring(0, s.Length - 1)
            cm = New SqlCommand("update PatntCheckup set PtId=@PtId,PName=@PName,PAddr=@PAddr,Email=@Email,PGen=@PGen,PAge=@PAge,PContact=@PContact,SampleBy=@SampleBy,Disease=@Disease,SugTest=@SugTest where PId=@PId", cn)
            cm.Parameters.Add("@PId", SqlDbType.Int).Value = CInt(txtPatChkpId.Text)
            cm.Parameters.Add("@PtId", SqlDbType.Int).Value = CInt(CmbPatId.Text)
            cm.Parameters.Add("@PName", SqlDbType.VarChar).Value = (txtPatientName.Text)
            cm.Parameters.Add("@PAddr", SqlDbType.NVarChar).Value = (txtPatientAddress.Text)
            cm.Parameters.Add("@Email", SqlDbType.NVarChar).Value = (txtEmail.Text)
            Dim a As String = ""
            If rdbmale.Checked = True Then
                a = "Male"
            ElseIf rdbFemale.Checked = True Then
                a = "Female"
            End If
            cm.Parameters.Add("@PGen", SqlDbType.VarChar).Value = a
            cm.Parameters.Add("@PAge", SqlDbType.Int).Value = CInt(txtAge.Text)
            cm.Parameters.Add("@PContact", SqlDbType.BigInt).Value = CLng(txtContact.Text)
            cm.Parameters.Add("@SampleBy", SqlDbType.VarChar).Value = (CmbSampleBy.Text)
            cm.Parameters.Add("@Disease", SqlDbType.VarChar).Value = (CmbDisease.Text)
            cm.Parameters.Add("@SugTest", SqlDbType.NVarChar).Value = x

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
                cm = New SqlCommand("delete from PatntCheckup where PId=@PId", cn)
                cm.Parameters.AddWithValue("@PId", (txtPatChkpId.Text))
                Dim r As Integer = cm.ExecuteNonQuery()
                If r = 1 Then
                    MsgBox("Record deleted Successfully", MsgBoxStyle.Exclamation)
                Else
                    MsgBox("Error while deleting record", MsgBoxStyle.RetryCancel)
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
    Private Sub cmbDisease_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbDisease.SelectedIndexChanged
        Try
            cm = New SqlCommand("select TestName from Disease where Disease='" & (CmbDisease.Text) & "'", cn)
            dr = cm.ExecuteReader()
            If dr.Read() Then

                Dim xx As String = dr(0).ToString
                Dim yy() As String = xx.Split(",")
                lstTestNm.Items.Clear()

                For Each z In yy
                    lstTestNm.Items.Add(z)

                Next

            End If

            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try
    End Sub

    Private Sub CmbPatId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbPatId.SelectedIndexChanged
        Try
            cm = New SqlCommand("select PNm,PAddr,Email,PGndr,Age,Contact from PatntMaster where PtId=" & CInt(CmbPatId.Text), cn)
            dr = cm.ExecuteReader()
            If dr.Read() Then
                txtPatientName.Text = dr(0).ToString()
                txtPatientAddress.Text = dr(1).ToString()
                txtEmail.Text = dr(2).ToString()
                Dim a As String = dr(3).ToString()
                If a = "Male" Then
                    rdbmale.Checked = True
                ElseIf a = "Female" Then
                    rdbFemale.Checked = True
                End If
                a = dr(3).ToString()
                txtAge.Text = dr(4).ToString()
                txtContact.Text = dr(5).ToString()
            End If
            dr.Close()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtEmail_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEmail.LostFocus
        Dim m As String = txtEmail.Text
        If Not m.Contains("@") Or Not m.Contains(".") Or (m.LastIndexOf(".") < m.IndexOf("@")) Then
            ToolTip1.Show("Error in Email Id", txtEmail)
        Else
            ToolTip1.Hide(txtEmail)
        End If
    End Sub


    Private Sub CmbSampleBy_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSampleBy.SelectedIndexChanged
        Try
            cm = New SqlCommand("select EName from EmpMaster where EName=" & (CmbPatId.Text) & "'", cn)
            dr = cm.ExecuteReader()
            If dr.Read() Then
                CmbSampleBy.Text = dr(0).ToString()
            End If
            dr.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lblLnkPrint_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblLnkPrint.LinkClicked
        Me.Hide()
        rptPatCheckup.Show()
    End Sub
End Class