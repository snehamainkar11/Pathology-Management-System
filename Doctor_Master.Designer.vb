<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Doctor_Master
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Doctor_Master))
        Me.Paneldoc = New System.Windows.Forms.Panel
        Me.btnnewid = New System.Windows.Forms.Button
        Me.lblDoctorId = New System.Windows.Forms.Label
        Me.txtdocqual = New System.Windows.Forms.TextBox
        Me.lblDocqual = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.rdbFemale = New System.Windows.Forms.RadioButton
        Me.rdbMale = New System.Windows.Forms.RadioButton
        Me.txtdocContact = New System.Windows.Forms.TextBox
        Me.lbldocContact = New System.Windows.Forms.Label
        Me.lbldocAddrs = New System.Windows.Forms.Label
        Me.txtdocAge = New System.Windows.Forms.TextBox
        Me.txtDoctName = New System.Windows.Forms.TextBox
        Me.txtDoctorId = New System.Windows.Forms.TextBox
        Me.txtdoctadd = New System.Windows.Forms.TextBox
        Me.lbldocgender = New System.Windows.Forms.Label
        Me.lbldocAge = New System.Windows.Forms.Label
        Me.lblDoctorname = New System.Windows.Forms.Label
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
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lbldocdet = New System.Windows.Forms.Label
        Me.Paneldoc.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PnlCustOperations.SuspendLayout()
        Me.PnlCustNavigation.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Paneldoc
        '
        Me.Paneldoc.BackColor = System.Drawing.Color.Transparent
        Me.Paneldoc.BackgroundImage = Global.Pathology.My.Resources.Resources.MdiImage
        Me.Paneldoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Paneldoc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Paneldoc.Controls.Add(Me.btnnewid)
        Me.Paneldoc.Controls.Add(Me.lblDoctorId)
        Me.Paneldoc.Controls.Add(Me.txtdocqual)
        Me.Paneldoc.Controls.Add(Me.lblDocqual)
        Me.Paneldoc.Controls.Add(Me.Panel2)
        Me.Paneldoc.Controls.Add(Me.txtdocContact)
        Me.Paneldoc.Controls.Add(Me.lbldocContact)
        Me.Paneldoc.Controls.Add(Me.lbldocAddrs)
        Me.Paneldoc.Controls.Add(Me.txtdocAge)
        Me.Paneldoc.Controls.Add(Me.txtDoctName)
        Me.Paneldoc.Controls.Add(Me.txtDoctorId)
        Me.Paneldoc.Controls.Add(Me.txtdoctadd)
        Me.Paneldoc.Controls.Add(Me.lbldocgender)
        Me.Paneldoc.Controls.Add(Me.lbldocAge)
        Me.Paneldoc.Controls.Add(Me.lblDoctorname)
        Me.Paneldoc.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Paneldoc.ForeColor = System.Drawing.Color.White
        Me.Paneldoc.Location = New System.Drawing.Point(23, 92)
        Me.Paneldoc.Name = "Paneldoc"
        Me.Paneldoc.Size = New System.Drawing.Size(520, 489)
        Me.Paneldoc.TabIndex = 10
        '
        'btnnewid
        '
        Me.btnnewid.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnnewid.BackColor = System.Drawing.Color.Black
        Me.btnnewid.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnewid.ForeColor = System.Drawing.Color.White
        Me.btnnewid.Location = New System.Drawing.Point(332, 27)
        Me.btnnewid.Name = "btnnewid"
        Me.btnnewid.Size = New System.Drawing.Size(102, 33)
        Me.btnnewid.TabIndex = 19
        Me.btnnewid.Text = "New Id"
        Me.btnnewid.UseVisualStyleBackColor = False
        '
        'lblDoctorId
        '
        Me.lblDoctorId.AutoSize = True
        Me.lblDoctorId.BackColor = System.Drawing.Color.Transparent
        Me.lblDoctorId.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDoctorId.ForeColor = System.Drawing.Color.White
        Me.lblDoctorId.Location = New System.Drawing.Point(54, 31)
        Me.lblDoctorId.Name = "lblDoctorId"
        Me.lblDoctorId.Size = New System.Drawing.Size(98, 22)
        Me.lblDoctorId.TabIndex = 20
        Me.lblDoctorId.Text = "Doctor ID:"
        '
        'txtdocqual
        '
        Me.txtdocqual.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdocqual.Location = New System.Drawing.Point(213, 436)
        Me.txtdocqual.Name = "txtdocqual"
        Me.txtdocqual.Size = New System.Drawing.Size(223, 29)
        Me.txtdocqual.TabIndex = 6
        '
        'lblDocqual
        '
        Me.lblDocqual.AutoSize = True
        Me.lblDocqual.BackColor = System.Drawing.Color.Transparent
        Me.lblDocqual.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocqual.ForeColor = System.Drawing.Color.White
        Me.lblDocqual.Location = New System.Drawing.Point(54, 439)
        Me.lblDocqual.Name = "lblDocqual"
        Me.lblDocqual.Size = New System.Drawing.Size(111, 22)
        Me.lblDocqual.TabIndex = 17
        Me.lblDocqual.Text = "Qulification:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.rdbFemale)
        Me.Panel2.Controls.Add(Me.rdbMale)
        Me.Panel2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(211, 243)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(223, 52)
        Me.Panel2.TabIndex = 3
        '
        'rdbFemale
        '
        Me.rdbFemale.AutoSize = True
        Me.rdbFemale.Location = New System.Drawing.Point(119, 12)
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
        Me.rdbMale.Location = New System.Drawing.Point(15, 12)
        Me.rdbMale.Name = "rdbMale"
        Me.rdbMale.Size = New System.Drawing.Size(70, 26)
        Me.rdbMale.TabIndex = 0
        Me.rdbMale.TabStop = True
        Me.rdbMale.Text = "Male"
        Me.rdbMale.UseVisualStyleBackColor = True
        '
        'txtdocContact
        '
        Me.txtdocContact.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdocContact.Location = New System.Drawing.Point(213, 378)
        Me.txtdocContact.MaxLength = 10
        Me.txtdocContact.Name = "txtdocContact"
        Me.txtdocContact.Size = New System.Drawing.Size(223, 29)
        Me.txtdocContact.TabIndex = 5
        '
        'lbldocContact
        '
        Me.lbldocContact.AutoSize = True
        Me.lbldocContact.BackColor = System.Drawing.Color.Transparent
        Me.lbldocContact.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldocContact.ForeColor = System.Drawing.Color.White
        Me.lbldocContact.Location = New System.Drawing.Point(54, 381)
        Me.lbldocContact.Name = "lbldocContact"
        Me.lbldocContact.Size = New System.Drawing.Size(109, 22)
        Me.lbldocContact.TabIndex = 14
        Me.lbldocContact.Text = "Contact No:"
        '
        'lbldocAddrs
        '
        Me.lbldocAddrs.AutoSize = True
        Me.lbldocAddrs.BackColor = System.Drawing.Color.Transparent
        Me.lbldocAddrs.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldocAddrs.ForeColor = System.Drawing.Color.White
        Me.lbldocAddrs.Location = New System.Drawing.Point(54, 164)
        Me.lbldocAddrs.Name = "lbldocAddrs"
        Me.lbldocAddrs.Size = New System.Drawing.Size(142, 22)
        Me.lbldocAddrs.TabIndex = 13
        Me.lbldocAddrs.Text = "Doctor Address:"
        '
        'txtdocAge
        '
        Me.txtdocAge.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdocAge.Location = New System.Drawing.Point(213, 325)
        Me.txtdocAge.Name = "txtdocAge"
        Me.txtdocAge.Size = New System.Drawing.Size(100, 29)
        Me.txtdocAge.TabIndex = 4
        '
        'txtDoctName
        '
        Me.txtDoctName.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDoctName.Location = New System.Drawing.Point(211, 91)
        Me.txtDoctName.Name = "txtDoctName"
        Me.txtDoctName.Size = New System.Drawing.Size(223, 29)
        Me.txtDoctName.TabIndex = 1
        '
        'txtDoctorId
        '
        Me.txtDoctorId.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDoctorId.Location = New System.Drawing.Point(211, 28)
        Me.txtDoctorId.Name = "txtDoctorId"
        Me.txtDoctorId.Size = New System.Drawing.Size(100, 29)
        Me.txtDoctorId.TabIndex = 0
        '
        'txtdoctadd
        '
        Me.txtdoctadd.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdoctadd.Location = New System.Drawing.Point(211, 148)
        Me.txtdoctadd.Multiline = True
        Me.txtdoctadd.Name = "txtdoctadd"
        Me.txtdoctadd.Size = New System.Drawing.Size(223, 64)
        Me.txtdoctadd.TabIndex = 2
        '
        'lbldocgender
        '
        Me.lbldocgender.AutoSize = True
        Me.lbldocgender.BackColor = System.Drawing.Color.Transparent
        Me.lbldocgender.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldocgender.ForeColor = System.Drawing.Color.White
        Me.lbldocgender.Location = New System.Drawing.Point(54, 252)
        Me.lbldocgender.Name = "lbldocgender"
        Me.lbldocgender.Size = New System.Drawing.Size(76, 22)
        Me.lbldocgender.TabIndex = 5
        Me.lbldocgender.Text = "Gender:"
        '
        'lbldocAge
        '
        Me.lbldocAge.AutoSize = True
        Me.lbldocAge.BackColor = System.Drawing.Color.Transparent
        Me.lbldocAge.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldocAge.ForeColor = System.Drawing.Color.White
        Me.lbldocAge.Location = New System.Drawing.Point(54, 328)
        Me.lbldocAge.Name = "lbldocAge"
        Me.lbldocAge.Size = New System.Drawing.Size(47, 22)
        Me.lbldocAge.TabIndex = 3
        Me.lbldocAge.Text = "Age:"
        '
        'lblDoctorname
        '
        Me.lblDoctorname.AutoSize = True
        Me.lblDoctorname.BackColor = System.Drawing.Color.Transparent
        Me.lblDoctorname.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDoctorname.ForeColor = System.Drawing.Color.White
        Me.lblDoctorname.Location = New System.Drawing.Point(54, 89)
        Me.lblDoctorname.Name = "lblDoctorname"
        Me.lblDoctorname.Size = New System.Drawing.Size(125, 22)
        Me.lblDoctorname.TabIndex = 1
        Me.lblDoctorname.Text = "Doctor Name:"
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
        Me.PnlCustOperations.Location = New System.Drawing.Point(549, 178)
        Me.PnlCustOperations.Name = "PnlCustOperations"
        Me.PnlCustOperations.Size = New System.Drawing.Size(445, 85)
        Me.PnlCustOperations.TabIndex = 133
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(332, 26)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(91, 38)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(119, 26)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(104, 38)
        Me.btnUpdate.TabIndex = 12
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(13, 26)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(103, 38)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(229, 26)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(97, 38)
        Me.btnDelete.TabIndex = 13
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
        Me.PnlCustNavigation.Location = New System.Drawing.Point(549, 92)
        Me.PnlCustNavigation.Name = "PnlCustNavigation"
        Me.PnlCustNavigation.Size = New System.Drawing.Size(445, 80)
        Me.PnlCustNavigation.TabIndex = 134
        '
        'BtnNext
        '
        Me.BtnNext.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNext.Location = New System.Drawing.Point(229, 22)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(97, 39)
        Me.BtnNext.TabIndex = 9
        Me.BtnNext.Text = "Next>>"
        Me.BtnNext.UseVisualStyleBackColor = True
        '
        'BtnLast
        '
        Me.BtnLast.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLast.Location = New System.Drawing.Point(332, 22)
        Me.BtnLast.Name = "BtnLast"
        Me.BtnLast.Size = New System.Drawing.Size(91, 39)
        Me.BtnLast.TabIndex = 10
        Me.BtnLast.Text = "Last"
        Me.BtnLast.UseVisualStyleBackColor = True
        '
        'BtnPrev
        '
        Me.BtnPrev.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrev.Location = New System.Drawing.Point(119, 22)
        Me.BtnPrev.Name = "BtnPrev"
        Me.BtnPrev.Size = New System.Drawing.Size(104, 39)
        Me.BtnPrev.TabIndex = 8
        Me.BtnPrev.Text = "<<Prev"
        Me.BtnPrev.UseVisualStyleBackColor = True
        '
        'BtnFirst
        '
        Me.BtnFirst.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFirst.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnFirst.Location = New System.Drawing.Point(13, 22)
        Me.BtnFirst.Name = "BtnFirst"
        Me.BtnFirst.Size = New System.Drawing.Size(100, 39)
        Me.BtnFirst.TabIndex = 7
        Me.BtnFirst.Text = "First"
        Me.BtnFirst.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(549, 269)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(698, 312)
        Me.DataGridView1.TabIndex = 101
        '
        'lbldocdet
        '
        Me.lbldocdet.AutoSize = True
        Me.lbldocdet.BackColor = System.Drawing.Color.Transparent
        Me.lbldocdet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbldocdet.Font = New System.Drawing.Font("Palatino Linotype", 40.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldocdet.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.lbldocdet.Location = New System.Drawing.Point(324, -2)
        Me.lbldocdet.Name = "lbldocdet"
        Me.lbldocdet.Size = New System.Drawing.Size(391, 74)
        Me.lbldocdet.TabIndex = 140
        Me.lbldocdet.Text = "Doctor Details"
        '
        'Doctor_Master
        '
        Me.AcceptButton = Me.btnnewid
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.BackgroundImage = Global.Pathology.My.Resources.Resources.MdiImage
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1279, 698)
        Me.Controls.Add(Me.lbldocdet)
        Me.Controls.Add(Me.PnlCustOperations)
        Me.Controls.Add(Me.PnlCustNavigation)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Paneldoc)
        Me.Name = "Doctor_Master"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Doctor_Master"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Paneldoc.ResumeLayout(False)
        Me.Paneldoc.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.PnlCustOperations.ResumeLayout(False)
        Me.PnlCustNavigation.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Paneldoc As System.Windows.Forms.Panel
    Friend WithEvents lblDocqual As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents rdbFemale As System.Windows.Forms.RadioButton
    Friend WithEvents rdbMale As System.Windows.Forms.RadioButton
    Friend WithEvents txtdocContact As System.Windows.Forms.TextBox
    Friend WithEvents lbldocContact As System.Windows.Forms.Label
    Friend WithEvents lbldocAddrs As System.Windows.Forms.Label
    Friend WithEvents txtdocAge As System.Windows.Forms.TextBox
    Friend WithEvents txtDoctName As System.Windows.Forms.TextBox
    Friend WithEvents txtDoctorId As System.Windows.Forms.TextBox
    Friend WithEvents txtdoctadd As System.Windows.Forms.TextBox
    Friend WithEvents lbldocgender As System.Windows.Forms.Label
    Friend WithEvents lbldocAge As System.Windows.Forms.Label
    Friend WithEvents lblDoctorname As System.Windows.Forms.Label
    Friend WithEvents txtdocqual As System.Windows.Forms.TextBox
    Friend WithEvents lblDoctorId As System.Windows.Forms.Label
    Friend WithEvents btnnewid As System.Windows.Forms.Button
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
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lbldocdet As System.Windows.Forms.Label
End Class
