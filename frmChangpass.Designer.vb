<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmchngpass
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmchngpass))
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.btnCan = New System.Windows.Forms.Button
        Me.btnChangepassword = New System.Windows.Forms.Button
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.txtusername = New System.Windows.Forms.TextBox
        Me.txtoldpass = New System.Windows.Forms.TextBox
        Me.txtnewpass = New System.Windows.Forms.TextBox
        Me.txtconfirmpass = New System.Windows.Forms.TextBox
        Me.lblcnfmPas = New System.Windows.Forms.Label
        Me.lblnewPas = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblusername = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.lbldocdet = New System.Windows.Forms.Label
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel6.BackgroundImage = Global.Pathology.My.Resources.Resources.vector
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel6.Controls.Add(Me.btnCan)
        Me.Panel6.Controls.Add(Me.btnChangepassword)
        Me.Panel6.Location = New System.Drawing.Point(461, 413)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(564, 88)
        Me.Panel6.TabIndex = 16
        '
        'btnCan
        '
        Me.btnCan.BackColor = System.Drawing.SystemColors.Control
        Me.btnCan.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCan.Location = New System.Drawing.Point(367, 26)
        Me.btnCan.Name = "btnCan"
        Me.btnCan.Size = New System.Drawing.Size(124, 45)
        Me.btnCan.TabIndex = 31
        Me.btnCan.Text = "Cancel"
        Me.btnCan.UseVisualStyleBackColor = False
        '
        'btnChangepassword
        '
        Me.btnChangepassword.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnChangepassword.BackColor = System.Drawing.SystemColors.Control
        Me.btnChangepassword.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangepassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnChangepassword.Location = New System.Drawing.Point(52, 26)
        Me.btnChangepassword.Name = "btnChangepassword"
        Me.btnChangepassword.Size = New System.Drawing.Size(247, 45)
        Me.btnChangepassword.TabIndex = 30
        Me.btnChangepassword.Text = "Change Password"
        Me.btnChangepassword.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel5.BackgroundImage = CType(resources.GetObject("Panel5.BackgroundImage"), System.Drawing.Image)
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Controls.Add(Me.txtusername)
        Me.Panel5.Controls.Add(Me.txtoldpass)
        Me.Panel5.Controls.Add(Me.txtnewpass)
        Me.Panel5.Controls.Add(Me.txtconfirmpass)
        Me.Panel5.Controls.Add(Me.lblcnfmPas)
        Me.Panel5.Controls.Add(Me.lblnewPas)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.lblusername)
        Me.Panel5.Location = New System.Drawing.Point(461, 111)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(564, 296)
        Me.Panel5.TabIndex = 15
        '
        'txtusername
        '
        Me.txtusername.BackColor = System.Drawing.Color.White
        Me.txtusername.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.Location = New System.Drawing.Point(274, 34)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(208, 29)
        Me.txtusername.TabIndex = 0
        '
        'txtoldpass
        '
        Me.txtoldpass.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtoldpass.Location = New System.Drawing.Point(274, 96)
        Me.txtoldpass.Name = "txtoldpass"
        Me.txtoldpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtoldpass.Size = New System.Drawing.Size(208, 29)
        Me.txtoldpass.TabIndex = 1
        '
        'txtnewpass
        '
        Me.txtnewpass.BackColor = System.Drawing.Color.White
        Me.txtnewpass.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnewpass.Location = New System.Drawing.Point(274, 162)
        Me.txtnewpass.Name = "txtnewpass"
        Me.txtnewpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtnewpass.Size = New System.Drawing.Size(208, 29)
        Me.txtnewpass.TabIndex = 2
        '
        'txtconfirmpass
        '
        Me.txtconfirmpass.BackColor = System.Drawing.Color.White
        Me.txtconfirmpass.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtconfirmpass.Location = New System.Drawing.Point(274, 228)
        Me.txtconfirmpass.Name = "txtconfirmpass"
        Me.txtconfirmpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtconfirmpass.Size = New System.Drawing.Size(208, 29)
        Me.txtconfirmpass.TabIndex = 3
        '
        'lblcnfmPas
        '
        Me.lblcnfmPas.AutoSize = True
        Me.lblcnfmPas.BackColor = System.Drawing.Color.Transparent
        Me.lblcnfmPas.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcnfmPas.ForeColor = System.Drawing.Color.White
        Me.lblcnfmPas.Location = New System.Drawing.Point(58, 234)
        Me.lblcnfmPas.Name = "lblcnfmPas"
        Me.lblcnfmPas.Size = New System.Drawing.Size(171, 23)
        Me.lblcnfmPas.TabIndex = 15
        Me.lblcnfmPas.Text = "Confirm Password:"
        '
        'lblnewPas
        '
        Me.lblnewPas.AutoSize = True
        Me.lblnewPas.BackColor = System.Drawing.Color.Transparent
        Me.lblnewPas.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnewPas.ForeColor = System.Drawing.Color.White
        Me.lblnewPas.Location = New System.Drawing.Point(58, 164)
        Me.lblnewPas.Name = "lblnewPas"
        Me.lblnewPas.Size = New System.Drawing.Size(140, 23)
        Me.lblnewPas.TabIndex = 14
        Me.lblnewPas.Text = "New Password:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(58, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 23)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Old Password:"
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.BackColor = System.Drawing.Color.Transparent
        Me.lblusername.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusername.ForeColor = System.Drawing.Color.White
        Me.lblusername.Location = New System.Drawing.Point(58, 36)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(102, 23)
        Me.lblusername.TabIndex = 12
        Me.lblusername.Text = "Username:"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.Pathology.My.Resources.Resources.forgotpassword
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(108, 250)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(347, 251)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Castellar", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(30, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(281, 86)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Password " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Protection"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(108, 111)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(347, 153)
        Me.Panel3.TabIndex = 2
        '
        'lbldocdet
        '
        Me.lbldocdet.AutoSize = True
        Me.lbldocdet.BackColor = System.Drawing.Color.Transparent
        Me.lbldocdet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbldocdet.Font = New System.Drawing.Font("Palatino Linotype", 40.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldocdet.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.lbldocdet.Location = New System.Drawing.Point(388, -1)
        Me.lbldocdet.Name = "lbldocdet"
        Me.lbldocdet.Size = New System.Drawing.Size(462, 74)
        Me.lbldocdet.TabIndex = 133
        Me.lbldocdet.Text = "Change Password"
        '
        'Frmchngpass
        '
        Me.AcceptButton = Me.btnChangepassword
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1305, 565)
        Me.Controls.Add(Me.lbldocdet)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "Frmchngpass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Frmchangpass"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel6.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents btnCan As System.Windows.Forms.Button
    Friend WithEvents btnChangepassword As System.Windows.Forms.Button
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents txtoldpass As System.Windows.Forms.TextBox
    Friend WithEvents txtnewpass As System.Windows.Forms.TextBox
    Friend WithEvents txtconfirmpass As System.Windows.Forms.TextBox
    Friend WithEvents lblcnfmPas As System.Windows.Forms.Label
    Friend WithEvents lblnewPas As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblusername As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lbldocdet As System.Windows.Forms.Label
End Class
