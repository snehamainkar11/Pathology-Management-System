Imports System.Data
Imports System.Data.SqlClient
Public Class forgotpass
    Private cn As SqlConnection
    Private cm As SqlCommand
    Private dr As SqlDataReader
    Private dt As New DataTable
    Private l As String
    Dim x As New ClassCon
    Private Sub txtcontact_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcontact.GotFocus

        txtcontact.BackColor = Color.Yellow
        txtcontact.Focus()
    End Sub

    Private Sub txtcontact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcontact.KeyPress
        If Not IsNumeric(e.KeyChar) = True And e.KeyChar <> vbBack Then
            e.Handled = True
            ToolTip1.Show("Only Number", txtcontact)
        Else
            ToolTip1.Hide(txtcontact)
        End If
    End Sub

    Private Sub txtcontact_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcontact.LostFocus
        Dim s As String = txtcontact.Text
        txtcontact.BackColor = Color.White
        If s.Length <> 10 Then
            MsgBox("Enter exact 10 Digit")
            txtcontact.Focus()
        End If
    End Sub


    Private Sub forgotpass_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn = New SqlConnection(x.s)
        cn.Open()
        dt = New DataTable()
        Display()
        btnSearch.Focus()
    End Sub
    Private Sub Display()
        dt.Clear()
        cm = New SqlCommand("select * from Registration", cn)
        dr = cm.ExecuteReader()
        dt.Load(dr)
        dr.Close()
        l = dt.Rows.Count - 1
    End Sub
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        Try
            cm = New SqlCommand("select Password from Registration where UName=@UName and EmailId=@EmailId and ContactNo=@ContactNo and FavColor=@FavColor ", cn)
            cm.Parameters.Add("@UName", SqlDbType.NVarChar).Value = (txtusername.Text)

            cm.Parameters.Add("@EmailId", SqlDbType.NVarChar).Value = (txtEmail.Text)
            cm.Parameters.Add("@ContactNo", SqlDbType.BigInt).Value = CLng(txtcontact.Text)
            cm.Parameters.Add("@FavColor", SqlDbType.VarChar).Value = (txtFavClr.Text)
            dr = cm.ExecuteReader()
            If dr.Read() Then

                MsgBox(" Your Password is  " & dr(0).ToString, MsgBoxStyle.Information)
                clearData()
            Else

                MsgBox("Hint Answers Are Incorrect", MsgBoxStyle.Critical)
            End If

            dr.Close()

        Catch ex As Exception

        End Try

    End Sub
    Private Sub clearData()
        Try
            txtEmail.Clear()
            txtcontact.Clear()
            txtFavClr.Clear()
            txtusername.Clear()

        Catch ex As Exception
        End Try
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        clearData()
    End Sub

    Private Sub txtEmail_LocationChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEmail.LocationChanged
        Try
            Dim m As String = txtEmail.Text
            If Not m.Contains("@") Or Not m.Contains(".") Or (m.LastIndexOf(".") < m.IndexOf("@")) Then
                ToolTip1.Show("Error in Email Id", txtEmail)
            Else
                ToolTip1.Hide(txtEmail)
            End If
        Catch ex As Exception

        End Try
    End Sub

   

  
End Class