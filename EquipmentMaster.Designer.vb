<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EquipmentMaster
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EquipmentMaster))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lbldocdet = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtSpecification = New System.Windows.Forms.TextBox
        Me.txtEquipNm = New System.Windows.Forms.TextBox
        Me.dtpPurDetail = New System.Windows.Forms.DateTimePicker
        Me.LblPurDetDate = New System.Windows.Forms.Label
        Me.btnnewid = New System.Windows.Forms.Button
        Me.txtRate = New System.Windows.Forms.TextBox
        Me.LblPurDetRate = New System.Windows.Forms.Label
        Me.LblEqupName = New System.Windows.Forms.Label
        Me.txtCompany = New System.Windows.Forms.TextBox
        Me.LblPurDetSrNo = New System.Windows.Forms.Label
        Me.LblDealerName = New System.Windows.Forms.Label
        Me.txtEqipId = New System.Windows.Forms.TextBox
        Me.LblPurchaseId = New System.Windows.Forms.Label
        Me.PnlCustNavigation = New System.Windows.Forms.Panel
        Me.BtnNext = New System.Windows.Forms.Button
        Me.BtnLast = New System.Windows.Forms.Button
        Me.BtnPrev = New System.Windows.Forms.Button
        Me.BtnFirst = New System.Windows.Forms.Button
        Me.PnlCustOperations = New System.Windows.Forms.Panel
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.PnlCustNavigation.SuspendLayout()
        Me.PnlCustOperations.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbldocdet
        '
        Me.lbldocdet.AutoSize = True
        Me.lbldocdet.BackColor = System.Drawing.Color.Transparent
        Me.lbldocdet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbldocdet.Font = New System.Drawing.Font("Palatino Linotype", 40.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldocdet.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.lbldocdet.Location = New System.Drawing.Point(323, -7)
        Me.lbldocdet.Name = "lbldocdet"
        Me.lbldocdet.Size = New System.Drawing.Size(483, 74)
        Me.lbldocdet.TabIndex = 148
        Me.lbldocdet.Text = "Equipment Details"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(588, 287)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(644, 263)
        Me.DataGridView1.TabIndex = 146
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.txtSpecification)
        Me.Panel1.Controls.Add(Me.txtEquipNm)
        Me.Panel1.Controls.Add(Me.dtpPurDetail)
        Me.Panel1.Controls.Add(Me.LblPurDetDate)
        Me.Panel1.Controls.Add(Me.btnnewid)
        Me.Panel1.Controls.Add(Me.txtRate)
        Me.Panel1.Controls.Add(Me.LblPurDetRate)
        Me.Panel1.Controls.Add(Me.LblEqupName)
        Me.Panel1.Controls.Add(Me.txtCompany)
        Me.Panel1.Controls.Add(Me.LblPurDetSrNo)
        Me.Panel1.Controls.Add(Me.LblDealerName)
        Me.Panel1.Controls.Add(Me.txtEqipId)
        Me.Panel1.Controls.Add(Me.LblPurchaseId)
        Me.Panel1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.Transparent
        Me.Panel1.Location = New System.Drawing.Point(48, 89)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(534, 461)
        Me.Panel1.TabIndex = 147
        '
        'txtSpecification
        '
        Me.txtSpecification.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.txtSpecification.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSpecification.Location = New System.Drawing.Point(248, 283)
        Me.txtSpecification.Multiline = True
        Me.txtSpecification.Name = "txtSpecification"
        Me.txtSpecification.Size = New System.Drawing.Size(229, 90)
        Me.txtSpecification.TabIndex = 3
        '
        'txtEquipNm
        '
        Me.txtEquipNm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.txtEquipNm.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEquipNm.Location = New System.Drawing.Point(250, 155)
        Me.txtEquipNm.Name = "txtEquipNm"
        Me.txtEquipNm.Size = New System.Drawing.Size(229, 29)
        Me.txtEquipNm.TabIndex = 1
        '
        'dtpPurDetail
        '
        Me.dtpPurDetail.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpPurDetail.Location = New System.Drawing.Point(260, 13)
        Me.dtpPurDetail.Name = "dtpPurDetail"
        Me.dtpPurDetail.Size = New System.Drawing.Size(258, 27)
        Me.dtpPurDetail.TabIndex = 98
        '
        'LblPurDetDate
        '
        Me.LblPurDetDate.AutoSize = True
        Me.LblPurDetDate.BackColor = System.Drawing.Color.Transparent
        Me.LblPurDetDate.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPurDetDate.ForeColor = System.Drawing.Color.Transparent
        Me.LblPurDetDate.Location = New System.Drawing.Point(181, 13)
        Me.LblPurDetDate.Name = "LblPurDetDate"
        Me.LblPurDetDate.Size = New System.Drawing.Size(54, 22)
        Me.LblPurDetDate.TabIndex = 99
        Me.LblPurDetDate.Text = "Date:"
        '
        'btnnewid
        '
        Me.btnnewid.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnnewid.BackColor = System.Drawing.Color.Black
        Me.btnnewid.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnewid.ForeColor = System.Drawing.Color.White
        Me.btnnewid.Location = New System.Drawing.Point(381, 86)
        Me.btnnewid.Name = "btnnewid"
        Me.btnnewid.Size = New System.Drawing.Size(106, 35)
        Me.btnnewid.TabIndex = 97
        Me.btnnewid.Text = "New Id"
        Me.btnnewid.UseVisualStyleBackColor = False
        '
        'txtRate
        '
        Me.txtRate.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.txtRate.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRate.Location = New System.Drawing.Point(248, 404)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(229, 29)
        Me.txtRate.TabIndex = 4
        '
        'LblPurDetRate
        '
        Me.LblPurDetRate.AutoSize = True
        Me.LblPurDetRate.BackColor = System.Drawing.Color.Transparent
        Me.LblPurDetRate.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPurDetRate.ForeColor = System.Drawing.Color.Transparent
        Me.LblPurDetRate.Location = New System.Drawing.Point(33, 411)
        Me.LblPurDetRate.Name = "LblPurDetRate"
        Me.LblPurDetRate.Size = New System.Drawing.Size(49, 22)
        Me.LblPurDetRate.TabIndex = 94
        Me.LblPurDetRate.Text = "Rate"
        '
        'LblEqupName
        '
        Me.LblEqupName.AutoSize = True
        Me.LblEqupName.BackColor = System.Drawing.Color.Transparent
        Me.LblEqupName.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEqupName.ForeColor = System.Drawing.Color.Transparent
        Me.LblEqupName.Location = New System.Drawing.Point(33, 322)
        Me.LblEqupName.Name = "LblEqupName"
        Me.LblEqupName.Size = New System.Drawing.Size(120, 22)
        Me.LblEqupName.TabIndex = 93
        Me.LblEqupName.Text = "Specification:"
        '
        'txtCompany
        '
        Me.txtCompany.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.txtCompany.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompany.Location = New System.Drawing.Point(250, 223)
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.Size = New System.Drawing.Size(229, 29)
        Me.txtCompany.TabIndex = 2
        '
        'LblPurDetSrNo
        '
        Me.LblPurDetSrNo.AutoSize = True
        Me.LblPurDetSrNo.BackColor = System.Drawing.Color.Transparent
        Me.LblPurDetSrNo.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPurDetSrNo.ForeColor = System.Drawing.Color.Transparent
        Me.LblPurDetSrNo.Location = New System.Drawing.Point(33, 223)
        Me.LblPurDetSrNo.Name = "LblPurDetSrNo"
        Me.LblPurDetSrNo.Size = New System.Drawing.Size(146, 22)
        Me.LblPurDetSrNo.TabIndex = 92
        Me.LblPurDetSrNo.Text = "Company Name:"
        '
        'LblDealerName
        '
        Me.LblDealerName.AutoSize = True
        Me.LblDealerName.BackColor = System.Drawing.Color.Transparent
        Me.LblDealerName.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDealerName.ForeColor = System.Drawing.Color.Transparent
        Me.LblDealerName.Location = New System.Drawing.Point(33, 155)
        Me.LblDealerName.Name = "LblDealerName"
        Me.LblDealerName.Size = New System.Drawing.Size(161, 22)
        Me.LblDealerName.TabIndex = 90
        Me.LblDealerName.Text = "Equipment  Name:"
        '
        'txtEqipId
        '
        Me.txtEqipId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.txtEqipId.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEqipId.Location = New System.Drawing.Point(250, 90)
        Me.txtEqipId.Name = "txtEqipId"
        Me.txtEqipId.Size = New System.Drawing.Size(116, 29)
        Me.txtEqipId.TabIndex = 0
        '
        'LblPurchaseId
        '
        Me.LblPurchaseId.AutoSize = True
        Me.LblPurchaseId.BackColor = System.Drawing.Color.Transparent
        Me.LblPurchaseId.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPurchaseId.ForeColor = System.Drawing.Color.Transparent
        Me.LblPurchaseId.Location = New System.Drawing.Point(33, 90)
        Me.LblPurchaseId.Name = "LblPurchaseId"
        Me.LblPurchaseId.Size = New System.Drawing.Size(125, 22)
        Me.LblPurchaseId.TabIndex = 89
        Me.LblPurchaseId.Text = "Equipment Id:"
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
        Me.PnlCustNavigation.Location = New System.Drawing.Point(588, 89)
        Me.PnlCustNavigation.Name = "PnlCustNavigation"
        Me.PnlCustNavigation.Size = New System.Drawing.Size(445, 80)
        Me.PnlCustNavigation.TabIndex = 150
        '
        'BtnNext
        '
        Me.BtnNext.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNext.Location = New System.Drawing.Point(229, 22)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(97, 39)
        Me.BtnNext.TabIndex = 7
        Me.BtnNext.Text = "Next>>"
        Me.BtnNext.UseVisualStyleBackColor = True
        '
        'BtnLast
        '
        Me.BtnLast.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLast.Location = New System.Drawing.Point(332, 22)
        Me.BtnLast.Name = "BtnLast"
        Me.BtnLast.Size = New System.Drawing.Size(91, 39)
        Me.BtnLast.TabIndex = 8
        Me.BtnLast.Text = "Last"
        Me.BtnLast.UseVisualStyleBackColor = True
        '
        'BtnPrev
        '
        Me.BtnPrev.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrev.Location = New System.Drawing.Point(119, 22)
        Me.BtnPrev.Name = "BtnPrev"
        Me.BtnPrev.Size = New System.Drawing.Size(104, 39)
        Me.BtnPrev.TabIndex = 6
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
        Me.BtnFirst.TabIndex = 5
        Me.BtnFirst.Text = "First"
        Me.BtnFirst.UseVisualStyleBackColor = True
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
        Me.PnlCustOperations.Location = New System.Drawing.Point(588, 183)
        Me.PnlCustOperations.Name = "PnlCustOperations"
        Me.PnlCustOperations.Size = New System.Drawing.Size(445, 85)
        Me.PnlCustOperations.TabIndex = 149
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(332, 26)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(91, 38)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(119, 26)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(104, 38)
        Me.btnUpdate.TabIndex = 10
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(13, 26)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(103, 38)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(229, 26)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(97, 38)
        Me.btnDelete.TabIndex = 11
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'EquipmentMaster
        '
        Me.AcceptButton = Me.btnnewid
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Pathology.My.Resources.Resources.MdiImage
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1276, 694)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PnlCustNavigation)
        Me.Controls.Add(Me.PnlCustOperations)
        Me.Controls.Add(Me.lbldocdet)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "EquipmentMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "EquipmentMaster"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PnlCustNavigation.ResumeLayout(False)
        Me.PnlCustOperations.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dtpPurDetail As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblPurDetDate As System.Windows.Forms.Label
    Friend WithEvents btnnewid As System.Windows.Forms.Button
    Friend WithEvents txtRate As System.Windows.Forms.TextBox
    Friend WithEvents LblPurDetRate As System.Windows.Forms.Label
    Friend WithEvents LblEqupName As System.Windows.Forms.Label
    Friend WithEvents txtCompany As System.Windows.Forms.TextBox
    Friend WithEvents LblPurDetSrNo As System.Windows.Forms.Label
    Friend WithEvents LblDealerName As System.Windows.Forms.Label
    Friend WithEvents txtEqipId As System.Windows.Forms.TextBox
    Friend WithEvents LblPurchaseId As System.Windows.Forms.Label
    Friend WithEvents BtnLast As System.Windows.Forms.Button
    Friend WithEvents BtnPrev As System.Windows.Forms.Button
    Friend WithEvents BtnFirst As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents BtnNext As System.Windows.Forms.Button
    Friend WithEvents PnlCustNavigation As System.Windows.Forms.Panel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PnlCustOperations As System.Windows.Forms.Panel
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents lbldocdet As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtSpecification As System.Windows.Forms.TextBox
    Friend WithEvents txtEquipNm As System.Windows.Forms.TextBox
End Class
