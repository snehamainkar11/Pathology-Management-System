<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Patient_Master
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Patient_Master))
        Me.lbldocdet = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PnlCustOperations = New System.Windows.Forms.Panel
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.PnlCustNavigation = New System.Windows.Forms.Panel
        Me.BtnNext = New System.Windows.Forms.Button
        Me.BtnLast = New System.Windows.Forms.Button
        Me.BtnPrev = New System.Windows.Forms.Button
        Me.BtnFirst = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.lblPatientId = New System.Windows.Forms.Label
        Me.lblPatientName = New System.Windows.Forms.Label
        Me.lblpatBldgrup = New System.Windows.Forms.Label
        Me.lblpatAge = New System.Windows.Forms.Label
        Me.txtPatEmail = New System.Windows.Forms.TextBox
        Me.txtPatientId = New System.Windows.Forms.TextBox
        Me.txtpatAge = New System.Windows.Forms.TextBox
        Me.lblpatContact = New System.Windows.Forms.Label
        Me.txtpatContact = New System.Windows.Forms.TextBox
        Me.txtpatAddr = New System.Windows.Forms.TextBox
        Me.btnnewid = New System.Windows.Forms.Button
        Me.lblpatAddr = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.rdbFemale = New System.Windows.Forms.RadioButton
        Me.rdbMale = New System.Windows.Forms.RadioButton
        Me.lblpatgendr = New System.Windows.Forms.Label
        Me.txtPatNm = New System.Windows.Forms.TextBox
        Me.PnlCustOperations.SuspendLayout()
        Me.PnlCustNavigation.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbldocdet
        '
        Me.lbldocdet.AutoSize = True
        Me.lbldocdet.BackColor = System.Drawing.Color.Transparent
        Me.lbldocdet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbldocdet.Font = New System.Drawing.Font("Palatino Linotype", 40.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldocdet.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.lbldocdet.Location = New System.Drawing.Point(315, 0)
        Me.lbldocdet.Name = "lbldocdet"
        Me.lbldocdet.Size = New System.Drawing.Size(401, 74)
        Me.lbldocdet.TabIndex = 146
        Me.lbldocdet.Text = "Patient Details"
        '
        'PnlCustOperations
        '
        Me.PnlCustOperations.BackgroundImage = CType(resources.GetObject("PnlCustOperations.BackgroundImage"), System.Drawing.Image)
        Me.PnlCustOperations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PnlCustOperations.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlCustOperations.Controls.Add(Me.btnClear)
        Me.PnlCustOperations.Controls.Add(Me.btnUpdate)
        Me.PnlCustOperations.Controls.Add(Me.btnAdd)
        Me.PnlCustOperations.Controls.Add(Me.btnDelete)
        Me.PnlCustOperations.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PnlCustOperations.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PnlCustOperations.Location = New System.Drawing.Point(619, 172)
        Me.PnlCustOperations.Name = "PnlCustOperations"
        Me.PnlCustOperations.Size = New System.Drawing.Size(490, 85)
        Me.PnlCustOperations.TabIndex = 147
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(365, 26)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(98, 38)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(135, 26)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(113, 38)
        Me.btnUpdate.TabIndex = 13
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(13, 26)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(116, 38)
        Me.btnAdd.TabIndex = 12
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(254, 26)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(105, 38)
        Me.btnDelete.TabIndex = 14
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'PnlCustNavigation
        '
        Me.PnlCustNavigation.BackgroundImage = CType(resources.GetObject("PnlCustNavigation.BackgroundImage"), System.Drawing.Image)
        Me.PnlCustNavigation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PnlCustNavigation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlCustNavigation.Controls.Add(Me.BtnNext)
        Me.PnlCustNavigation.Controls.Add(Me.BtnLast)
        Me.PnlCustNavigation.Controls.Add(Me.BtnPrev)
        Me.PnlCustNavigation.Controls.Add(Me.BtnFirst)
        Me.PnlCustNavigation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PnlCustNavigation.Location = New System.Drawing.Point(619, 86)
        Me.PnlCustNavigation.Name = "PnlCustNavigation"
        Me.PnlCustNavigation.Size = New System.Drawing.Size(490, 80)
        Me.PnlCustNavigation.TabIndex = 148
        '
        'BtnNext
        '
        Me.BtnNext.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNext.Location = New System.Drawing.Point(254, 22)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(105, 39)
        Me.BtnNext.TabIndex = 10
        Me.BtnNext.Text = "Next>>"
        Me.BtnNext.UseVisualStyleBackColor = True
        '
        'BtnLast
        '
        Me.BtnLast.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLast.Location = New System.Drawing.Point(365, 22)
        Me.BtnLast.Name = "BtnLast"
        Me.BtnLast.Size = New System.Drawing.Size(98, 39)
        Me.BtnLast.TabIndex = 11
        Me.BtnLast.Text = "Last"
        Me.BtnLast.UseVisualStyleBackColor = True
        '
        'BtnPrev
        '
        Me.BtnPrev.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrev.Location = New System.Drawing.Point(135, 20)
        Me.BtnPrev.Name = "BtnPrev"
        Me.BtnPrev.Size = New System.Drawing.Size(113, 39)
        Me.BtnPrev.TabIndex = 9
        Me.BtnPrev.Text = "<<Prev"
        Me.BtnPrev.UseVisualStyleBackColor = True
        '
        'BtnFirst
        '
        Me.BtnFirst.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFirst.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnFirst.Location = New System.Drawing.Point(13, 22)
        Me.BtnFirst.Name = "BtnFirst"
        Me.BtnFirst.Size = New System.Drawing.Size(116, 39)
        Me.BtnFirst.TabIndex = 8
        Me.BtnFirst.Text = "First"
        Me.BtnFirst.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(619, 260)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(735, 329)
        Me.DataGridView1.TabIndex = 145
        '
        'lblPatientId
        '
        Me.lblPatientId.AutoSize = True
        Me.lblPatientId.BackColor = System.Drawing.Color.Transparent
        Me.lblPatientId.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientId.ForeColor = System.Drawing.Color.White
        Me.lblPatientId.Location = New System.Drawing.Point(36, 78)
        Me.lblPatientId.Name = "lblPatientId"
        Me.lblPatientId.Size = New System.Drawing.Size(95, 22)
        Me.lblPatientId.TabIndex = 0
        Me.lblPatientId.Text = "Patient Id:"
        '
        'lblPatientName
        '
        Me.lblPatientName.AutoSize = True
        Me.lblPatientName.BackColor = System.Drawing.Color.Transparent
        Me.lblPatientName.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientName.ForeColor = System.Drawing.Color.White
        Me.lblPatientName.Location = New System.Drawing.Point(36, 132)
        Me.lblPatientName.Name = "lblPatientName"
        Me.lblPatientName.Size = New System.Drawing.Size(126, 22)
        Me.lblPatientName.TabIndex = 1
        Me.lblPatientName.Text = "Patient Name:"
        '
        'lblpatBldgrup
        '
        Me.lblpatBldgrup.AutoSize = True
        Me.lblpatBldgrup.BackColor = System.Drawing.Color.Transparent
        Me.lblpatBldgrup.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpatBldgrup.ForeColor = System.Drawing.Color.White
        Me.lblpatBldgrup.Location = New System.Drawing.Point(36, 277)
        Me.lblpatBldgrup.Name = "lblpatBldgrup"
        Me.lblpatBldgrup.Size = New System.Drawing.Size(85, 22)
        Me.lblpatBldgrup.TabIndex = 2
        Me.lblpatBldgrup.Text = "Email Id:"
        '
        'lblpatAge
        '
        Me.lblpatAge.AutoSize = True
        Me.lblpatAge.BackColor = System.Drawing.Color.Transparent
        Me.lblpatAge.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpatAge.ForeColor = System.Drawing.Color.White
        Me.lblpatAge.Location = New System.Drawing.Point(36, 329)
        Me.lblpatAge.Name = "lblpatAge"
        Me.lblpatAge.Size = New System.Drawing.Size(47, 22)
        Me.lblpatAge.TabIndex = 3
        Me.lblpatAge.Text = "Age:"
        '
        'txtPatEmail
        '
        Me.txtPatEmail.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatEmail.Location = New System.Drawing.Point(244, 270)
        Me.txtPatEmail.Name = "txtPatEmail"
        Me.txtPatEmail.Size = New System.Drawing.Size(258, 29)
        Me.txtPatEmail.TabIndex = 3
        '
        'txtPatientId
        '
        Me.txtPatientId.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientId.Location = New System.Drawing.Point(244, 72)
        Me.txtPatientId.Name = "txtPatientId"
        Me.txtPatientId.Size = New System.Drawing.Size(91, 29)
        Me.txtPatientId.TabIndex = 0
        '
        'txtpatAge
        '
        Me.txtpatAge.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpatAge.Location = New System.Drawing.Point(244, 322)
        Me.txtpatAge.Name = "txtpatAge"
        Me.txtpatAge.Size = New System.Drawing.Size(91, 29)
        Me.txtpatAge.TabIndex = 4
        '
        'lblpatContact
        '
        Me.lblpatContact.AutoSize = True
        Me.lblpatContact.BackColor = System.Drawing.Color.Transparent
        Me.lblpatContact.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpatContact.ForeColor = System.Drawing.Color.White
        Me.lblpatContact.Location = New System.Drawing.Point(36, 449)
        Me.lblpatContact.Name = "lblpatContact"
        Me.lblpatContact.Size = New System.Drawing.Size(109, 22)
        Me.lblpatContact.TabIndex = 14
        Me.lblpatContact.Text = "Contact No:"
        '
        'txtpatContact
        '
        Me.txtpatContact.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpatContact.Location = New System.Drawing.Point(244, 442)
        Me.txtpatContact.MaxLength = 10
        Me.txtpatContact.Name = "txtpatContact"
        Me.txtpatContact.Size = New System.Drawing.Size(258, 29)
        Me.txtpatContact.TabIndex = 7
        '
        'txtpatAddr
        '
        Me.txtpatAddr.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpatAddr.Location = New System.Drawing.Point(244, 172)
        Me.txtpatAddr.Multiline = True
        Me.txtpatAddr.Name = "txtpatAddr"
        Me.txtpatAddr.Size = New System.Drawing.Size(258, 81)
        Me.txtpatAddr.TabIndex = 2
        '
        'btnnewid
        '
        Me.btnnewid.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnnewid.BackColor = System.Drawing.Color.Black
        Me.btnnewid.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnewid.ForeColor = System.Drawing.Color.White
        Me.btnnewid.Location = New System.Drawing.Point(354, 70)
        Me.btnnewid.Name = "btnnewid"
        Me.btnnewid.Size = New System.Drawing.Size(117, 36)
        Me.btnnewid.TabIndex = 107
        Me.btnnewid.Text = "New Id"
        Me.btnnewid.UseVisualStyleBackColor = False
        '
        'lblpatAddr
        '
        Me.lblpatAddr.AutoSize = True
        Me.lblpatAddr.BackColor = System.Drawing.Color.Transparent
        Me.lblpatAddr.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpatAddr.ForeColor = System.Drawing.Color.White
        Me.lblpatAddr.Location = New System.Drawing.Point(36, 189)
        Me.lblpatAddr.Name = "lblpatAddr"
        Me.lblpatAddr.Size = New System.Drawing.Size(148, 22)
        Me.lblpatAddr.TabIndex = 26
        Me.lblpatAddr.Text = "Patient  Address:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.lblpatgendr)
        Me.Panel1.Controls.Add(Me.txtPatNm)
        Me.Panel1.Controls.Add(Me.lblpatAddr)
        Me.Panel1.Controls.Add(Me.btnnewid)
        Me.Panel1.Controls.Add(Me.txtpatAddr)
        Me.Panel1.Controls.Add(Me.txtpatContact)
        Me.Panel1.Controls.Add(Me.lblpatContact)
        Me.Panel1.Controls.Add(Me.txtpatAge)
        Me.Panel1.Controls.Add(Me.txtPatientId)
        Me.Panel1.Controls.Add(Me.txtPatEmail)
        Me.Panel1.Controls.Add(Me.lblpatAge)
        Me.Panel1.Controls.Add(Me.lblpatBldgrup)
        Me.Panel1.Controls.Add(Me.lblPatientName)
        Me.Panel1.Controls.Add(Me.lblPatientId)
        Me.Panel1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(12, 86)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(601, 503)
        Me.Panel1.TabIndex = 144
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.rdbFemale)
        Me.Panel2.Controls.Add(Me.rdbMale)
        Me.Panel2.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(244, 374)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(258, 49)
        Me.Panel2.TabIndex = 5
        '
        'rdbFemale
        '
        Me.rdbFemale.AutoSize = True
        Me.rdbFemale.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rdbFemale.Location = New System.Drawing.Point(124, 10)
        Me.rdbFemale.Name = "rdbFemale"
        Me.rdbFemale.Size = New System.Drawing.Size(88, 26)
        Me.rdbFemale.TabIndex = 6
        Me.rdbFemale.TabStop = True
        Me.rdbFemale.Text = "Female"
        Me.rdbFemale.UseVisualStyleBackColor = True
        '
        'rdbMale
        '
        Me.rdbMale.AutoSize = True
        Me.rdbMale.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rdbMale.Location = New System.Drawing.Point(28, 10)
        Me.rdbMale.Name = "rdbMale"
        Me.rdbMale.Size = New System.Drawing.Size(70, 26)
        Me.rdbMale.TabIndex = 5
        Me.rdbMale.TabStop = True
        Me.rdbMale.Text = "Male"
        Me.rdbMale.UseVisualStyleBackColor = True
        '
        'lblpatgendr
        '
        Me.lblpatgendr.AutoSize = True
        Me.lblpatgendr.BackColor = System.Drawing.Color.Transparent
        Me.lblpatgendr.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpatgendr.ForeColor = System.Drawing.Color.White
        Me.lblpatgendr.Location = New System.Drawing.Point(36, 388)
        Me.lblpatgendr.Name = "lblpatgendr"
        Me.lblpatgendr.Size = New System.Drawing.Size(76, 22)
        Me.lblpatgendr.TabIndex = 139
        Me.lblpatgendr.Text = "Gender:"
        '
        'txtPatNm
        '
        Me.txtPatNm.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatNm.Location = New System.Drawing.Point(244, 129)
        Me.txtPatNm.Name = "txtPatNm"
        Me.txtPatNm.Size = New System.Drawing.Size(258, 29)
        Me.txtPatNm.TabIndex = 1
        '
        'Patient_Master
        '
        Me.AcceptButton = Me.btnnewid
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1366, 742)
        Me.Controls.Add(Me.PnlCustOperations)
        Me.Controls.Add(Me.PnlCustNavigation)
        Me.Controls.Add(Me.lbldocdet)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Patient_Master"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Patient_Master"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PnlCustOperations.ResumeLayout(False)
        Me.PnlCustNavigation.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbldocdet As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PnlCustOperations As System.Windows.Forms.Panel
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents PnlCustNavigation As System.Windows.Forms.Panel
    Friend WithEvents BtnNext As System.Windows.Forms.Button
    Friend WithEvents BtnLast As System.Windows.Forms.Button
    Friend WithEvents BtnPrev As System.Windows.Forms.Button
    Friend WithEvents BtnFirst As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents lblPatientId As System.Windows.Forms.Label
    Friend WithEvents lblPatientName As System.Windows.Forms.Label
    Friend WithEvents lblpatBldgrup As System.Windows.Forms.Label
    Friend WithEvents lblpatAge As System.Windows.Forms.Label
    Friend WithEvents txtPatEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtPatientId As System.Windows.Forms.TextBox
    Friend WithEvents txtpatAge As System.Windows.Forms.TextBox
    Friend WithEvents lblpatContact As System.Windows.Forms.Label
    Friend WithEvents txtpatContact As System.Windows.Forms.TextBox
    Friend WithEvents txtpatAddr As System.Windows.Forms.TextBox
    Friend WithEvents btnnewid As System.Windows.Forms.Button
    Friend WithEvents lblpatAddr As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtPatNm As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents rdbFemale As System.Windows.Forms.RadioButton
    Friend WithEvents rdbMale As System.Windows.Forms.RadioButton
    Friend WithEvents lblpatgendr As System.Windows.Forms.Label
End Class
