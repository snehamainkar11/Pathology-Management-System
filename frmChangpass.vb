Imports System.Data
Imports System.Data.SqlClient
Public Class Frmchngpass
    Private cn As SqlConnection
    Private cm As SqlCommand
    Private dr As SqlDataReader
    Private dt As New DataTable
    Private l As String
    Dim x As New ClassCon
    Private Sub Frmchngpass_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn = New SqlConnection(x.s)
        cn.Open()
        dt = New DataTable()
        Display()
        btnChangepassword.Focus()
    End Sub
    Private Sub clr()
        Try
            txtusername.Clear()
            TxtOldPass.Clear()
            txtconfirmpass.Clear()
            txtnewpass.Clear()
        Catch ex As Exception
        End Try

    End Sub
    Private Sub Display()
        dt.Clear()
        cm = New SqlCommand("select * from Registration", cn)
        dr = cm.ExecuteReader()
        dt.Load(dr)
        dr.Close()
        l = dt.Rows.Count - 1
    End Sub

    Private Sub btnChangepassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangepassword.Click
        'Try


        cm = New SqlCommand("select * from Registration where Password='" & txtoldpass.Text & "' and UName=@UName", cn)
        cm.Parameters.Add("@UName", SqlDbType.VarChar).Value = (txtusername.Text)

        dr = cm.ExecuteReader()
        If dr.Read() Then
            If (txtnewpass.Text.Equals(txtconfirmpass.Text)) Then
                dr.Close()
                cm = New SqlCommand("update Registration set Password=@Password where UName=@UName", cn)
                cm.Parameters.Add("@UName", SqlDbType.VarChar).Value = (txtusername.Text)
                cm.Parameters.Add("@Password", SqlDbType.NVarChar).Value = (txtconfirmpass.Text)
                Dim x As Integer = cm.ExecuteNonQuery()
                If x = 1 Then

                    MsgBox("Password Changed successfully", MsgBoxStyle.Information)
                Else
                    MsgBox("Error while Changing Password", MsgBoxStyle.Critical)
                End If
            Else
                MsgBox("Given Password does not match..!!!", MsgBoxStyle.Critical)
            End If

        Else
            MsgBox("Old Password is Incorrect ", MsgBoxStyle.Critical)
        End If
        dr.Close()
        clr()
        'Catch ex As Exception

        'End Try

    End Sub

    Private Sub btnCan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCan.Click
        clr()
    End Sub


End Class