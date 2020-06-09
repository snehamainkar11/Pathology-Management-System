<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmlogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.lnkSignUp = New System.Windows.Forms.LinkLabel
        Me.lnkFrgtPasswrd = New System.Windows.Forms.LinkLabel
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnLogin = New System.Windows.Forms.Button
        Me.btnCncl = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtUser = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.chkShwPasswrd = New System.Windows.Forms.CheckBox
        Me.txtPass = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel3.BackgroundImage = Global.Pathology.My.Resources.Resources.testing
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.lnkSignUp)
        Me.Panel3.Controls.Add(Me.lnkFrgtPasswrd)
        Me.Panel3.Location = New System.Drawing.Point(368, 443)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(731, 108)
        Me.Panel3.TabIndex = 35
        '
        'lnkSignUp
        '
        Me.lnkSignUp.AutoSize = True
        Me.lnkSignUp.BackColor = System.Drawing.Color.Transparent
        Me.lnkSignUp.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkSignUp.ForeColor = System.Drawing.Color.Navy
        Me.lnkSignUp.Location = New System.Drawing.Point(289, 18)
        Me.lnkSignUp.Name = "lnkSignUp"
        Me.lnkSignUp.Size = New System.Drawing.Size(99, 25)
        Me.lnkSignUp.TabIndex = 4
        Me.lnkSignUp.TabStop = True
        Me.lnkSignUp.Text = "Sign Up"
        '
        'lnkFrgtPasswrd
        '
        Me.lnkFrgtPasswrd.AutoSize = True
        Me.lnkFrgtPasswrd.BackColor = System.Drawing.Color.Transparent
        Me.lnkFrgtPasswrd.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkFrgtPasswrd.ForeColor = System.Drawing.Color.Red
        Me.lnkFrgtPasswrd.Location = New System.Drawing.Point(238, 56)
        Me.lnkFrgtPasswrd.Name = "lnkFrgtPasswrd"
        Me.lnkFrgtPasswrd.Size = New System.Drawing.Size(241, 25)
        Me.lnkFrgtPasswrd.TabIndex = 5
        Me.lnkFrgtPasswrd.TabStop = True
        Me.lnkFrgtPasswrd.Text = "Forgot a Password???"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ProgressBar1.ForeColor = System.Drawing.Color.Navy
        Me.ProgressBar1.Location = New System.Drawing.Point(470, 591)
        Me.ProgressBar1.Maximum = 1000
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(552, 31)
        Me.ProgressBar1.Step = 200
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 6
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.SystemColors.Control
        Me.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnLogin.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnLogin.Location = New System.Drawing.Point(356, 204)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(143, 39)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.Text = "&Login"
        Me.ToolTip1.SetToolTip(Me.btnLogin, "Click to Login")
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'btnCncl
        '
        Me.btnCncl.BackColor = System.Drawing.SystemColors.Control
        Me.btnCncl.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCncl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCncl.Location = New System.Drawing.Point(562, 204)
        Me.btnCncl.Name = "btnCncl"
        Me.btnCncl.Size = New System.Drawing.Size(143, 39)
        Me.btnCncl.TabIndex = 3
        Me.btnCncl.Text = "&Cancel"
        Me.ToolTip1.SetToolTip(Me.btnCncl, "Cancel")
        Me.btnCncl.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(352, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 30)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Password:"
        Me.ToolTip1.SetToolTip(Me.Label3, "Password ")
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(347, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 30)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "User  Name:"
        Me.ToolTip1.SetToolTip(Me.Label4, " Username")
        '
        'txtUser
        '
        Me.txtUser.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.Location = New System.Drawing.Point(481, 28)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(224, 32)
        Me.txtUser.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.txtUser, "Enter Username")
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.Pathology.My.Resources.Resources.login
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.chkShwPasswrd)
        Me.Panel1.Controls.Add(Me.btnLogin)
        Me.Panel1.Controls.Add(Me.txtPass)
        Me.Panel1.Controls.Add(Me.btnCncl)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtUser)
        Me.Panel1.Location = New System.Drawing.Point(368, 165)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(731, 272)
        Me.Panel1.TabIndex = 36
        '
        'chkShwPasswrd
        '
        Me.chkShwPasswrd.AutoSize = True
        Me.chkShwPasswrd.Font = New System.Drawing.Font("Modern No. 20", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShwPasswrd.ForeColor = System.Drawing.Color.Indigo
        Me.chkShwPasswrd.Location = New System.Drawing.Point(516, 149)
        Me.chkShwPasswrd.Name = "chkShwPasswrd"
        Me.chkShwPasswrd.Size = New System.Drawing.Size(167, 26)
        Me.chkShwPasswrd.TabIndex = 49
        Me.chkShwPasswrd.Text = "Show Password"
        Me.chkShwPasswrd.UseVisualStyleBackColor = True
        '
        'txtPass
        '
        Me.txtPass.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.Location = New System.Drawing.Point(481, 94)
        Me.txtPass.MaxLength = 8
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(224, 32)
        Me.txtPass.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Pathology.My.Resources.Resources.key
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(319, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(143, 107)
        Me.PictureBox1.TabIndex = 46
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.PowderBlue
        Me.Label2.Location = New System.Drawing.Point(464, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(367, 85)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Login Form"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.Pathology.My.Resources.Resources.changepasswords1
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(94, 167)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(270, 384)
        Me.PictureBox2.TabIndex = 49
        Me.PictureBox2.TabStop = False
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(608, 558)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(257, 30)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Please wait while loading....."
        Me.Label1.Visible = False
        '
        'frmlogin
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.BackgroundImage = Global.Pathology.My.Resources.Resources.MdiImage
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1226, 694)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.Name = "frmlogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmlogin"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lnkSignUp As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkFrgtPasswrd As System.Windows.Forms.LinkLabel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents btnCncl As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents chkShwPasswrd As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
End Class
