Imports System.Data
Imports System.Data.SqlClient

Public Class frmnewuser
    Dim cn As SqlConnection
    Dim cm As SqlCommand
    Dim dr As SqlDataReader
    Dim dt As DataTable
    Dim n, c As Integer
    Dim x As New ClassCon
    Private Sub frmnewuser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn = New SqlConnection(x.s)
        cn.Open()
        dt = New DataTable()
        btnRegister.Focus()
    End Sub
    Private Sub txtEmail_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEmail.LostFocus
        Dim m As String = txtEmail.Text
        If Not m.Contains("@") Or Not m.Contains(".") Or (m.LastIndexOf(".") < m.IndexOf("@")) Then
            ToolTip1.Show("Error in Email Id", txtEmail)
        Else
            ToolTip1.Hide(txtEmail)
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
    Private Sub clear()
        Try
            txtage.Clear()
            txtContact.Clear()
            txtEmail.Clear()
            txtFavClr.Clear()
            txtEmail.Clear()
            txtpass.Clear()
            txtnewuser.Clear()
            rdbFemale.Checked = False
            rdbMale.Checked = False
        Catch ex As Exception
        End Try
    End Sub


    Private Sub btnCancl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancl.Click
        clear()
    End Sub

  

   
    Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click
        Try
            cm = New SqlCommand("insert into Registration values(@UName,@Password,@DOB,@Age,@Gender,@EmailId,@ContactNo,@FavColor)", cn)
            cm.Parameters.Add("@UName", SqlDbType.NVarChar).Value = (txtnewuser.Text)
            cm.Parameters.Add("@Password", SqlDbType.NVarChar).Value = (txtpass.Text)
            cm.Parameters.Add("@DOB", SqlDbType.DateTime).Value = CDate(dtpDOB.Text)
            cm.Parameters.Add("@Age", SqlDbType.Int).Value = CInt(txtage.Text)
            Dim a As String = ""
            If rdbMale.Checked = True Then
                a = "Male"
            ElseIf rdbFemale.Checked = True Then
                a = "Female"
            End If
            cm.Parameters.Add("@Gender", SqlDbType.VarChar).Value = a
            cm.Parameters.Add("@EmailId", SqlDbType.NVarChar).Value = (txtEmail.Text)
            cm.Parameters.Add("@ContactNo", SqlDbType.BigInt).Value = CLng(txtContact.Text)
            cm.Parameters.Add("@FavColor", SqlDbType.NVarChar).Value = (txtFavClr.Text)


            Dim x As Integer = cm.ExecuteNonQuery()
            If x = 1 Then
                MsgBox("Registration Successfull", MsgBoxStyle.Exclamation)
            Else
                MsgBox("Error While Creating User", MsgBoxStyle.Critical)
            End If
            clear()

        Catch ex As Exception

        End Try
    End Sub
End Class