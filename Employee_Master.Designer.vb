<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employee_Master
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Employee_Master))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.dtpJoin = New System.Windows.Forms.DateTimePicker
        Me.LblEmpJoinDate = New System.Windows.Forms.Label
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker
        Me.btnnewid = New System.Windows.Forms.Button
        Me.LblDOB = New System.Windows.Forms.Label
        Me.TxtSal = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtEmpQuali = New System.Windows.Forms.TextBox
        Me.LblEmpQuali = New System.Windows.Forms.Label
        Me.TxtEmpContactNo = New System.Windows.Forms.TextBox
        Me.LblEmpContactNo = New System.Windows.Forms.Label
        Me.TxtEmpAddress = New System.Windows.Forms.TextBox
        Me.LblEmpAddress = New System.Windows.Forms.Label
        Me.TxtEmpName = New System.Windows.Forms.TextBox
        Me.LblEmpName = New System.Windows.Forms.Label
        Me.TxtEmpId = New System.Windows.Forms.TextBox
        Me.LblEmpId = New System.Windows.Forms.Label
        Me.lbldocdet = New System.Windows.Forms.Label
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
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.PnlCustOperations.SuspendLayout()
        Me.PnlCustNavigation.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(695, 268)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(599, 301)
        Me.DataGridView1.TabIndex = 107
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.dtpJoin)
        Me.Panel1.Controls.Add(Me.LblEmpJoinDate)
        Me.Panel1.Controls.Add(Me.dtpDOB)
        Me.Panel1.Controls.Add(Me.btnnewid)
        Me.Panel1.Controls.Add(Me.LblDOB)
        Me.Panel1.Controls.Add(Me.TxtSal)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TxtEmpQuali)
        Me.Panel1.Controls.Add(Me.LblEmpQuali)
        Me.Panel1.Controls.Add(Me.TxtEmpContactNo)
        Me.Panel1.Controls.Add(Me.LblEmpContactNo)
        Me.Panel1.Controls.Add(Me.TxtEmpAddress)
        Me.Panel1.Controls.Add(Me.LblEmpAddress)
        Me.Panel1.Controls.Add(Me.TxtEmpName)
        Me.Panel1.Controls.Add(Me.LblEmpName)
        Me.Panel1.Controls.Add(Me.TxtEmpId)
        Me.Panel1.Controls.Add(Me.LblEmpId)
        Me.Panel1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(43, 91)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(646, 478)
        Me.Panel1.TabIndex = 121
        '
        'dtpJoin
        '
        Me.dtpJoin.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpJoin.Location = New System.Drawing.Point(260, 373)
        Me.dtpJoin.Name = "dtpJoin"
        Me.dtpJoin.Size = New System.Drawing.Size(262, 27)
        Me.dtpJoin.TabIndex = 6
        '
        'LblEmpJoinDate
        '
        Me.LblEmpJoinDate.AutoSize = True
        Me.LblEmpJoinDate.BackColor = System.Drawing.Color.Transparent
        Me.LblEmpJoinDate.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEmpJoinDate.ForeColor = System.Drawing.Color.White
        Me.LblEmpJoinDate.Location = New System.Drawing.Point(46, 378)
        Me.LblEmpJoinDate.Name = "LblEmpJoinDate"
        Me.LblEmpJoinDate.Size = New System.Drawing.Size(119, 22)
        Me.LblEmpJoinDate.TabIndex = 158
        Me.LblEmpJoinDate.Text = "Joining Date:"
        '
        'dtpDOB
        '
        Me.dtpDOB.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDOB.Location = New System.Drawing.Point(260, 433)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(262, 27)
        Me.dtpDOB.TabIndex = 7
        '
        'btnnewid
        '
        Me.btnnewid.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnnewid.BackColor = System.Drawing.Color.Black
        Me.btnnewid.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnewid.ForeColor = System.Drawing.Color.White
        Me.btnnewid.Location = New System.Drawing.Point(387, 22)
        Me.btnnewid.Name = "btnnewid"
        Me.btnnewid.Size = New System.Drawing.Size(101, 34)
        Me.btnnewid.TabIndex = 21
        Me.btnnewid.Text = "New Id"
        Me.btnnewid.UseVisualStyleBackColor = False
        '
        'LblDOB
        '
        Me.LblDOB.AutoSize = True
        Me.LblDOB.BackColor = System.Drawing.Color.Transparent
        Me.LblDOB.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDOB.ForeColor = System.Drawing.Color.White
        Me.LblDOB.Location = New System.Drawing.Point(46, 433)
        Me.LblDOB.Name = "LblDOB"
        Me.LblDOB.Size = New System.Drawing.Size(127, 22)
        Me.LblDOB.TabIndex = 157
        Me.LblDOB.Text = "Date Of Birth:"
        '
        'TxtSal
        '
        Me.TxtSal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.TxtSal.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSal.Location = New System.Drawing.Point(260, 315)
        Me.TxtSal.Name = "TxtSal"
        Me.TxtSal.Size = New System.Drawing.Size(262, 29)
        Me.TxtSal.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(46, 322)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 22)
        Me.Label1.TabIndex = 154
        Me.Label1.Text = "Basic Salary:"
        '
        'TxtEmpQuali
        '
        Me.TxtEmpQuali.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.TxtEmpQuali.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmpQuali.Location = New System.Drawing.Point(260, 265)
        Me.TxtEmpQuali.Name = "TxtEmpQuali"
        Me.TxtEmpQuali.Size = New System.Drawing.Size(262, 29)
        Me.TxtEmpQuali.TabIndex = 4
        '
        'LblEmpQuali
        '
        Me.LblEmpQuali.AutoSize = True
        Me.LblEmpQuali.BackColor = System.Drawing.Color.Transparent
        Me.LblEmpQuali.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEmpQuali.ForeColor = System.Drawing.Color.White
        Me.LblEmpQuali.Location = New System.Drawing.Point(46, 268)
        Me.LblEmpQuali.Name = "LblEmpQuali"
        Me.LblEmpQuali.Size = New System.Drawing.Size(116, 22)
        Me.LblEmpQuali.TabIndex = 138
        Me.LblEmpQuali.Text = "Qualificaton:"
        '
        'TxtEmpContactNo
        '
        Me.TxtEmpContactNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.TxtEmpContactNo.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmpContactNo.Location = New System.Drawing.Point(260, 212)
        Me.TxtEmpContactNo.MaxLength = 10
        Me.TxtEmpContactNo.Name = "TxtEmpContactNo"
        Me.TxtEmpContactNo.Size = New System.Drawing.Size(262, 29)
        Me.TxtEmpContactNo.TabIndex = 3
        '
        'LblEmpContactNo
        '
        Me.LblEmpContactNo.AutoSize = True
        Me.LblEmpContactNo.BackColor = System.Drawing.Color.Transparent
        Me.LblEmpContactNo.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEmpContactNo.ForeColor = System.Drawing.Color.White
        Me.LblEmpContactNo.Location = New System.Drawing.Point(46, 212)
        Me.LblEmpContactNo.Name = "LblEmpContactNo"
        Me.LblEmpContactNo.Size = New System.Drawing.Size(165, 22)
        Me.LblEmpContactNo.TabIndex = 134
        Me.LblEmpContactNo.Text = "Employee Contact:"
        '
        'TxtEmpAddress
        '
        Me.TxtEmpAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.TxtEmpAddress.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmpAddress.Location = New System.Drawing.Point(260, 119)
        Me.TxtEmpAddress.Multiline = True
        Me.TxtEmpAddress.Name = "TxtEmpAddress"
        Me.TxtEmpAddress.Size = New System.Drawing.Size(262, 68)
        Me.TxtEmpAddress.TabIndex = 2
        '
        'LblEmpAddress
        '
        Me.LblEmpAddress.AutoSize = True
        Me.LblEmpAddress.BackColor = System.Drawing.Color.Transparent
        Me.LblEmpAddress.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEmpAddress.ForeColor = System.Drawing.Color.White
        Me.LblEmpAddress.Location = New System.Drawing.Point(46, 127)
        Me.LblEmpAddress.Name = "LblEmpAddress"
        Me.LblEmpAddress.Size = New System.Drawing.Size(165, 22)
        Me.LblEmpAddress.TabIndex = 133
        Me.LblEmpAddress.Text = "Employee Address:"
        '
        'TxtEmpName
        '
        Me.TxtEmpName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.TxtEmpName.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmpName.Location = New System.Drawing.Point(260, 70)
        Me.TxtEmpName.Name = "TxtEmpName"
        Me.TxtEmpName.Size = New System.Drawing.Size(262, 29)
        Me.TxtEmpName.TabIndex = 1
        '
        'LblEmpName
        '
        Me.LblEmpName.AutoSize = True
        Me.LblEmpName.BackColor = System.Drawing.Color.Transparent
        Me.LblEmpName.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEmpName.ForeColor = System.Drawing.Color.White
        Me.LblEmpName.Location = New System.Drawing.Point(46, 73)
        Me.LblEmpName.Name = "LblEmpName"
        Me.LblEmpName.Size = New System.Drawing.Size(148, 22)
        Me.LblEmpName.TabIndex = 132
        Me.LblEmpName.Text = "Employee Name:"
        '
        'TxtEmpId
        '
        Me.TxtEmpId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.TxtEmpId.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmpId.Location = New System.Drawing.Point(260, 22)
        Me.TxtEmpId.Name = "TxtEmpId"
        Me.TxtEmpId.Size = New System.Drawing.Size(95, 29)
        Me.TxtEmpId.TabIndex = 0
        '
        'LblEmpId
        '
        Me.LblEmpId.AutoSize = True
        Me.LblEmpId.BackColor = System.Drawing.Color.Transparent
        Me.LblEmpId.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEmpId.ForeColor = System.Drawing.Color.White
        Me.LblEmpId.Location = New System.Drawing.Point(46, 22)
        Me.LblEmpId.Name = "LblEmpId"
        Me.LblEmpId.Size = New System.Drawing.Size(121, 22)
        Me.LblEmpId.TabIndex = 131
        Me.LblEmpId.Text = "Employee ID:"
        '
        'lbldocdet
        '
        Me.lbldocdet.AutoSize = True
        Me.lbldocdet.BackColor = System.Drawing.Color.Transparent
        Me.lbldocdet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbldocdet.Font = New System.Drawing.Font("Palatino Linotype", 40.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldocdet.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.lbldocdet.Location = New System.Drawing.Point(389, 0)
        Me.lbldocdet.Name = "lbldocdet"
        Me.lbldocdet.Size = New System.Drawing.Size(456, 74)
        Me.lbldocdet.TabIndex = 132
        Me.lbldocdet.Text = "Employee Details"
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
        Me.PnlCustOperations.Location = New System.Drawing.Point(695, 177)
        Me.PnlCustOperations.Name = "PnlCustOperations"
        Me.PnlCustOperations.Size = New System.Drawing.Size(463, 85)
        Me.PnlCustOperations.TabIndex = 133
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(344, 25)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(91, 38)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(131, 25)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(104, 38)
        Me.btnUpdate.TabIndex = 13
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(25, 25)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(103, 38)
        Me.btnAdd.TabIndex = 12
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(241, 25)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(97, 38)
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
        Me.PnlCustNavigation.Location = New System.Drawing.Point(695, 91)
        Me.PnlCustNavigation.Name = "PnlCustNavigation"
        Me.PnlCustNavigation.Size = New System.Drawing.Size(463, 80)
        Me.PnlCustNavigation.TabIndex = 134
        '
        'BtnNext
        '
        Me.BtnNext.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNext.Location = New System.Drawing.Point(241, 25)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(97, 39)
        Me.BtnNext.TabIndex = 10
        Me.BtnNext.Text = "Next>>"
        Me.BtnNext.UseVisualStyleBackColor = True
        '
        'BtnLast
        '
        Me.BtnLast.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLast.Location = New System.Drawing.Point(344, 25)
        Me.BtnLast.Name = "BtnLast"
        Me.BtnLast.Size = New System.Drawing.Size(91, 39)
        Me.BtnLast.TabIndex = 11
        Me.BtnLast.Text = "Last"
        Me.BtnLast.UseVisualStyleBackColor = True
        '
        'BtnPrev
        '
        Me.BtnPrev.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrev.Location = New System.Drawing.Point(131, 25)
        Me.BtnPrev.Name = "BtnPrev"
        Me.BtnPrev.Size = New System.Drawing.Size(104, 39)
        Me.BtnPrev.TabIndex = 9
        Me.BtnPrev.Text = "<<Prev"
        Me.BtnPrev.UseVisualStyleBackColor = True
        '
        'BtnFirst
        '
        Me.BtnFirst.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFirst.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnFirst.Location = New System.Drawing.Point(25, 25)
        Me.BtnFirst.Name = "BtnFirst"
        Me.BtnFirst.Size = New System.Drawing.Size(100, 39)
        Me.BtnFirst.TabIndex = 8
        Me.BtnFirst.Text = "First"
        Me.BtnFirst.UseVisualStyleBackColor = True
        '
        'Employee_Master
        '
        Me.AcceptButton = Me.btnnewid
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1276, 671)
        Me.Controls.Add(Me.PnlCustOperations)
        Me.Controls.Add(Me.PnlCustNavigation)
        Me.Controls.Add(Me.lbldocdet)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Employee_Master"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee_Master"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PnlCustOperations.ResumeLayout(False)
        Me.PnlCustNavigation.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TxtEmpQuali As System.Windows.Forms.TextBox
    Friend WithEvents LblEmpQuali As System.Windows.Forms.Label
    Friend WithEvents TxtEmpContactNo As System.Windows.Forms.TextBox
    Friend WithEvents LblEmpContactNo As System.Windows.Forms.Label
    Friend WithEvents TxtEmpAddress As System.Windows.Forms.TextBox
    Friend WithEvents LblEmpAddress As System.Windows.Forms.Label
    Friend WithEvents TxtEmpName As System.Windows.Forms.TextBox
    Friend WithEvents LblEmpName As System.Windows.Forms.Label
    Friend WithEvents TxtEmpId As System.Windows.Forms.TextBox
    Friend WithEvents LblEmpId As System.Windows.Forms.Label
    Friend WithEvents btnnewid As System.Windows.Forms.Button
    Friend WithEvents TxtSal As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbldocdet As System.Windows.Forms.Label
    Friend WithEvents dtpJoin As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblEmpJoinDate As System.Windows.Forms.Label
    Friend WithEvents dtpDOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblDOB As System.Windows.Forms.Label
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
End Class
