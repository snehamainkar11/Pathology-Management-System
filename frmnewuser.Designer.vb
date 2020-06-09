<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmnewuser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmnewuser))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtFavClr = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.rdbFemale = New System.Windows.Forms.RadioButton
        Me.rdbMale = New System.Windows.Forms.RadioButton
        Me.txtContact = New System.Windows.Forms.TextBox
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.lblgender = New System.Windows.Forms.Label
        Me.lblage = New System.Windows.Forms.Label
        Me.txtpass = New System.Windows.Forms.TextBox
        Me.txtage = New System.Windows.Forms.TextBox
        Me.txtnewuser = New System.Windows.Forms.TextBox
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker
        Me.lbldob = New System.Windows.Forms.Label
        Me.lblcontact = New System.Windows.Forms.Label
        Me.lblEmail = New System.Windows.Forms.Label
        Me.lblpass = New System.Windows.Forms.Label
        Me.lblnewuser = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PnlCustNavigation = New System.Windows.Forms.Panel
        Me.btnCancl = New System.Windows.Forms.Button
        Me.btnRegister = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.PnlCustNavigation.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.txtFavClr)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.txtContact)
        Me.Panel1.Controls.Add(Me.txtEmail)
        Me.Panel1.Controls.Add(Me.lblgender)
        Me.Panel1.Controls.Add(Me.lblage)
        Me.Panel1.Controls.Add(Me.txtpass)
        Me.Panel1.Controls.Add(Me.txtage)
        Me.Panel1.Controls.Add(Me.txtnewuser)
        Me.Panel1.Controls.Add(Me.dtpDOB)
        Me.Panel1.Controls.Add(Me.lbldob)
        Me.Panel1.Controls.Add(Me.lblcontact)
        Me.Panel1.Controls.Add(Me.lblEmail)
        Me.Panel1.Controls.Add(Me.lblpass)
        Me.Panel1.Controls.Add(Me.lblnewuser)
        Me.Panel1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(314, 101)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(667, 468)
        Me.Panel1.TabIndex = 0
        '
        'txtFavClr
        '
        Me.txtFavClr.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFavClr.Location = New System.Drawing.Point(286, 419)
        Me.txtFavClr.MaxLength = 10
        Me.txtFavClr.Name = "txtFavClr"
        Me.txtFavClr.Size = New System.Drawing.Size(282, 29)
        Me.txtFavClr.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(73, 422)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 22)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Favourite Color:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.rdbFemale)
        Me.Panel3.Controls.Add(Me.rdbMale)
        Me.Panel3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(286, 245)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(282, 41)
        Me.Panel3.TabIndex = 4
        '
        'rdbFemale
        '
        Me.rdbFemale.AutoSize = True
        Me.rdbFemale.ForeColor = System.Drawing.Color.White
        Me.rdbFemale.Location = New System.Drawing.Point(127, 5)
        Me.rdbFemale.Name = "rdbFemale"
        Me.rdbFemale.Size = New System.Drawing.Size(88, 26)
        Me.rdbFemale.TabIndex = 1
        Me.rdbFemale.TabStop = True
        Me.rdbFemale.Text = "Female"
        Me.rdbFemale.UseVisualStyleBackColor = True
        '
        'rdbMale
        '
        Me.rdbMale.AutoSize = True
        Me.rdbMale.ForeColor = System.Drawing.Color.White
        Me.rdbMale.Location = New System.Drawing.Point(25, 5)
        Me.rdbMale.Name = "rdbMale"
        Me.rdbMale.Size = New System.Drawing.Size(70, 26)
        Me.rdbMale.TabIndex = 0
        Me.rdbMale.TabStop = True
        Me.rdbMale.Text = "Male"
        Me.rdbMale.UseVisualStyleBackColor = True
        '
        'txtContact
        '
        Me.txtContact.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.Location = New System.Drawing.Point(286, 365)
        Me.txtContact.MaxLength = 10
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(282, 29)
        Me.txtContact.TabIndex = 6
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(286, 315)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(282, 29)
        Me.txtEmail.TabIndex = 5
        '
        'lblgender
        '
        Me.lblgender.AutoSize = True
        Me.lblgender.BackColor = System.Drawing.Color.Transparent
        Me.lblgender.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgender.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblgender.Location = New System.Drawing.Point(73, 254)
        Me.lblgender.Name = "lblgender"
        Me.lblgender.Size = New System.Drawing.Size(76, 22)
        Me.lblgender.TabIndex = 38
        Me.lblgender.Text = "Gender:"
        '
        'lblage
        '
        Me.lblage.AutoSize = True
        Me.lblage.BackColor = System.Drawing.Color.Transparent
        Me.lblage.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblage.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblage.Location = New System.Drawing.Point(76, 195)
        Me.lblage.Name = "lblage"
        Me.lblage.Size = New System.Drawing.Size(47, 22)
        Me.lblage.TabIndex = 37
        Me.lblage.Text = "Age:"
        '
        'txtpass
        '
        Me.txtpass.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpass.Location = New System.Drawing.Point(286, 76)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpass.Size = New System.Drawing.Size(282, 29)
        Me.txtpass.TabIndex = 1
        '
        'txtage
        '
        Me.txtage.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtage.Location = New System.Drawing.Point(286, 188)
        Me.txtage.Name = "txtage"
        Me.txtage.Size = New System.Drawing.Size(97, 29)
        Me.txtage.TabIndex = 3
        '
        'txtnewuser
        '
        Me.txtnewuser.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnewuser.Location = New System.Drawing.Point(286, 23)
        Me.txtnewuser.Name = "txtnewuser"
        Me.txtnewuser.Size = New System.Drawing.Size(282, 29)
        Me.txtnewuser.TabIndex = 0
        '
        'dtpDOB
        '
        Me.dtpDOB.CalendarFont = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDOB.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDOB.Location = New System.Drawing.Point(286, 133)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(282, 29)
        Me.dtpDOB.TabIndex = 2
        '
        'lbldob
        '
        Me.lbldob.AutoSize = True
        Me.lbldob.BackColor = System.Drawing.Color.Transparent
        Me.lbldob.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldob.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbldob.Location = New System.Drawing.Point(76, 140)
        Me.lbldob.Name = "lbldob"
        Me.lbldob.Size = New System.Drawing.Size(122, 22)
        Me.lbldob.TabIndex = 30
        Me.lbldob.Text = "Date of Birth:"
        '
        'lblcontact
        '
        Me.lblcontact.AutoSize = True
        Me.lblcontact.BackColor = System.Drawing.Color.Transparent
        Me.lblcontact.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcontact.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblcontact.Location = New System.Drawing.Point(73, 368)
        Me.lblcontact.Name = "lblcontact"
        Me.lblcontact.Size = New System.Drawing.Size(109, 22)
        Me.lblcontact.TabIndex = 29
        Me.lblcontact.Text = "Contact No:"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblEmail.Location = New System.Drawing.Point(76, 315)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(85, 22)
        Me.lblEmail.TabIndex = 28
        Me.lblEmail.Text = "Email Id:"
        '
        'lblpass
        '
        Me.lblpass.AutoSize = True
        Me.lblpass.BackColor = System.Drawing.Color.Transparent
        Me.lblpass.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpass.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblpass.Location = New System.Drawing.Point(73, 83)
        Me.lblpass.Name = "lblpass"
        Me.lblpass.Size = New System.Drawing.Size(95, 22)
        Me.lblpass.TabIndex = 26
        Me.lblpass.Text = "Password:"
        '
        'lblnewuser
        '
        Me.lblnewuser.AutoSize = True
        Me.lblnewuser.BackColor = System.Drawing.Color.Transparent
        Me.lblnewuser.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnewuser.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblnewuser.Location = New System.Drawing.Point(73, 26)
        Me.lblnewuser.Name = "lblnewuser"
        Me.lblnewuser.Size = New System.Drawing.Size(148, 22)
        Me.lblnewuser.TabIndex = 25
        Me.lblnewuser.Text = "New User Name:"
        '
        'PnlCustNavigation
        '
        Me.PnlCustNavigation.BackgroundImage = CType(resources.GetObject("PnlCustNavigation.BackgroundImage"), System.Drawing.Image)
        Me.PnlCustNavigation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PnlCustNavigation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlCustNavigation.Controls.Add(Me.btnCancl)
        Me.PnlCustNavigation.Controls.Add(Me.btnRegister)
        Me.PnlCustNavigation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PnlCustNavigation.Location = New System.Drawing.Point(314, 575)
        Me.PnlCustNavigation.Name = "PnlCustNavigation"
        Me.PnlCustNavigation.Size = New System.Drawing.Size(667, 70)
        Me.PnlCustNavigation.TabIndex = 137
        '
        'btnCancl
        '
        Me.btnCancl.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancl.Location = New System.Drawing.Point(355, 13)
        Me.btnCancl.Name = "btnCancl"
        Me.btnCancl.Size = New System.Drawing.Size(177, 39)
        Me.btnCancl.TabIndex = 19
        Me.btnCancl.Text = "&Cancel"
        Me.btnCancl.UseVisualStyleBackColor = True
        '
        'btnRegister
        '
        Me.btnRegister.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRegister.Location = New System.Drawing.Point(93, 13)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(201, 39)
        Me.btnRegister.TabIndex = 14
        Me.btnRegister.Text = "&Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Schoolbook", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label2.Location = New System.Drawing.Point(325, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(639, 77)
        Me.Label2.TabIndex = 138
        Me.Label2.Text = "Registration Form"
        '
        'frmnewuser
        '
        Me.AcceptButton = Me.btnRegister
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.BackgroundImage = Global.Pathology.My.Resources.Resources._51445246_Sign_up_hand_pressing_button_on_interface_with_blue_background__Stock_Photo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1291, 746)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PnlCustNavigation)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmnewuser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmnewuser"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.PnlCustNavigation.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtpass As System.Windows.Forms.TextBox
    Friend WithEvents txtage As System.Windows.Forms.TextBox
    Friend WithEvents txtnewuser As System.Windows.Forms.TextBox
    Friend WithEvents dtpDOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbldob As System.Windows.Forms.Label
    Friend WithEvents lblcontact As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblpass As System.Windows.Forms.Label
    Friend WithEvents lblnewuser As System.Windows.Forms.Label
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblgender As System.Windows.Forms.Label
    Friend WithEvents lblage As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents rdbFemale As System.Windows.Forms.RadioButton
    Friend WithEvents rdbMale As System.Windows.Forms.RadioButton
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PnlCustNavigation As System.Windows.Forms.Panel
    Friend WithEvents btnCancl As System.Windows.Forms.Button
    Friend WithEvents btnRegister As System.Windows.Forms.Button
    Friend WithEvents txtFavClr As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
