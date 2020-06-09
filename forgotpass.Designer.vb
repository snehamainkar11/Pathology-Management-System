<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class forgotpass
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtFavClr = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.txtcontact = New System.Windows.Forms.TextBox
        Me.lblcontact = New System.Windows.Forms.Label
        Me.lblEmail = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.txtusername = New System.Windows.Forms.TextBox
        Me.lblusername = New System.Windows.Forms.Label
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.btnSearch = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lbldocdet = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Castellar", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.HotPink
        Me.Label2.Location = New System.Drawing.Point(264, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(541, 35)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Answer the Hint Question..."
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SkyBlue
        Me.Panel1.BackgroundImage = Global.Pathology.My.Resources.Resources.MdiImage
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.txtFavClr)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtEmail)
        Me.Panel1.Controls.Add(Me.txtcontact)
        Me.Panel1.Controls.Add(Me.lblcontact)
        Me.Panel1.Controls.Add(Me.lblEmail)
        Me.Panel1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(373, 227)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(730, 209)
        Me.Panel1.TabIndex = 27
        '
        'txtFavClr
        '
        Me.txtFavClr.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFavClr.Location = New System.Drawing.Point(277, 147)
        Me.txtFavClr.Name = "txtFavClr"
        Me.txtFavClr.Size = New System.Drawing.Size(265, 29)
        Me.txtFavClr.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(65, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 22)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Favourite Color:"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(277, 32)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(265, 29)
        Me.txtEmail.TabIndex = 1
        '
        'txtcontact
        '
        Me.txtcontact.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcontact.Location = New System.Drawing.Point(277, 90)
        Me.txtcontact.MaxLength = 10
        Me.txtcontact.Name = "txtcontact"
        Me.txtcontact.Size = New System.Drawing.Size(265, 29)
        Me.txtcontact.TabIndex = 2
        '
        'lblcontact
        '
        Me.lblcontact.AutoSize = True
        Me.lblcontact.BackColor = System.Drawing.Color.Transparent
        Me.lblcontact.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcontact.ForeColor = System.Drawing.Color.White
        Me.lblcontact.Location = New System.Drawing.Point(65, 93)
        Me.lblcontact.Name = "lblcontact"
        Me.lblcontact.Size = New System.Drawing.Size(109, 22)
        Me.lblcontact.TabIndex = 27
        Me.lblcontact.Text = "Contact No:"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.White
        Me.lblEmail.Location = New System.Drawing.Point(65, 35)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(85, 22)
        Me.lblEmail.TabIndex = 26
        Me.lblEmail.Text = "Email Id:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Navy
        Me.Panel2.BackgroundImage = Global.Pathology.My.Resources.Resources.MdiImage
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.txtusername)
        Me.Panel2.Controls.Add(Me.lblusername)
        Me.Panel2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(409, 80)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(694, 81)
        Me.Panel2.TabIndex = 28
        '
        'txtusername
        '
        Me.txtusername.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.Location = New System.Drawing.Point(184, 19)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(247, 32)
        Me.txtusername.TabIndex = 0
        '
        'lblusername
        '
        Me.lblusername.BackColor = System.Drawing.Color.Transparent
        Me.lblusername.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusername.ForeColor = System.Drawing.Color.White
        Me.lblusername.Location = New System.Drawing.Point(23, 19)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(134, 32)
        Me.lblusername.TabIndex = 21
        Me.lblusername.Text = "Username:"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel6.BackgroundImage = Global.Pathology.My.Resources.Resources.vector
        Me.Panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel6.Controls.Add(Me.btnSearch)
        Me.Panel6.Controls.Add(Me.btnCancel)
        Me.Panel6.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel6.Location = New System.Drawing.Point(373, 442)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(730, 69)
        Me.Panel6.TabIndex = 32
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.SystemColors.Control
        Me.btnSearch.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSearch.Location = New System.Drawing.Point(150, 16)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(148, 35)
        Me.btnSearch.TabIndex = 32
        Me.btnSearch.Text = "&Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.Control
        Me.btnCancel.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(400, 16)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(142, 35)
        Me.btnCancel.TabIndex = 31
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BackgroundImage = Global.Pathology.My.Resources.Resources.forgot
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(125, 227)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(242, 284)
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox3.Image = Global.Pathology.My.Resources.Resources.back_and_forth_questions_md_wm_v2
        Me.PictureBox3.Location = New System.Drawing.Point(270, 80)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(141, 81)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 33
        Me.PictureBox3.TabStop = False
        '
        'lbldocdet
        '
        Me.lbldocdet.AutoSize = True
        Me.lbldocdet.BackColor = System.Drawing.Color.Transparent
        Me.lbldocdet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbldocdet.Font = New System.Drawing.Font("Palatino Linotype", 40.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldocdet.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.lbldocdet.Location = New System.Drawing.Point(396, -11)
        Me.lbldocdet.Name = "lbldocdet"
        Me.lbldocdet.Size = New System.Drawing.Size(443, 74)
        Me.lbldocdet.TabIndex = 133
        Me.lbldocdet.Text = "Forgot Password"
        '
        'forgotpass
        '
        Me.AcceptButton = Me.btnSearch
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.BackgroundImage = Global.Pathology.My.Resources.Resources.MdiImage
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1039, 573)
        Me.Controls.Add(Me.lbldocdet)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Name = "forgotpass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "forgot_Password"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtcontact As System.Windows.Forms.TextBox
    Friend WithEvents lblcontact As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents lblusername As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents txtFavClr As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents lbldocdet As System.Windows.Forms.Label
End Class
