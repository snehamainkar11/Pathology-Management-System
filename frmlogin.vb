Imports System.Data
Imports System.Data.SqlClient

Public Class frmlogin
    Dim cn As SqlConnection
    Dim cm As SqlCommand
    Dim clrn, clrf As Color
    Dim dr As SqlDataReader
    Dim c, n As Integer
    Dim x As New ClassCon
    Private Sub chkShwPasswrd_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShwPasswrd.CheckedChanged
        If chkShwPasswrd.Checked = True Then
            txtPass.PasswordChar = ""
        Else
            txtPass.PasswordChar = "*"
        End If

    End Sub

    Private Sub frmlogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn = New SqlConnection(x.s)
        cn.Open()
        btnLogin.Focus()
    End Sub
    Private Sub ClearData()
        txtUser.Clear()
        txtPass.Clear()
        chkShwPasswrd.Checked = False

    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        cm = New SqlCommand(" Select * from Registration where UName= '" & txtUser.Text & "'and Password='" & txtPass.Text & "' ", cn)
        dr = cm.ExecuteReader

        If dr.Read Then
          

            MsgBox("Congratulation!!!!Login successfull...", MsgBoxStyle.Information)
            Timer1.Enabled = True
            ClearData()
            Label1.Visible = True
        Else
            MsgBox("Invalid login information !", MsgBoxStyle.Critical)
        ClearData()
        End If
        dr.Close()
    End Sub


    Private Sub btnCncl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCncl.Click
        ClearData()
    End Sub

    Private Sub lnkFrgtPasswrd_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkFrgtPasswrd.LinkClicked
        Me.Hide()
        forgotpass.Show()
      

    End Sub

    Private Sub lnkSignUp_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkSignUp.LinkClicked
        Me.Hide()
        frmnewuser.Show()

    End Sub





    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 1000 Then
            ProgressBar1.Value += 5
        Else
            Timer1.Enabled = False
            FrmMDI.Show()
            Me.Visible = False
        End If



    End Sub


    
End Class