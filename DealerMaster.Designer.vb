<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DealerMaster
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DealerMaster))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
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
        Me.lbldocdet = New System.Windows.Forms.Label
        Me.LblDBankDet = New System.Windows.Forms.Label
        Me.PnlBankDet = New System.Windows.Forms.Panel
        Me.LblBranchName = New System.Windows.Forms.Label
        Me.TxtIFSC = New System.Windows.Forms.TextBox
        Me.TxtBranchName = New System.Windows.Forms.TextBox
        Me.LblIFSC = New System.Windows.Forms.Label
        Me.TxtBankName = New System.Windows.Forms.TextBox
        Me.LblBankName = New System.Windows.Forms.Label
        Me.TxtAccName = New System.Windows.Forms.TextBox
        Me.LblAccName = New System.Windows.Forms.Label
        Me.TxtAccNo = New System.Windows.Forms.TextBox
        Me.LblAccNo = New System.Windows.Forms.Label
        Me.pnlDealer = New System.Windows.Forms.Panel
        Me.btnnewid = New System.Windows.Forms.Button
        Me.TxtCompany = New System.Windows.Forms.TextBox
        Me.lblCompany = New System.Windows.Forms.Label
        Me.TxtDealerEmail = New System.Windows.Forms.TextBox
        Me.LblDEmail = New System.Windows.Forms.Label
        Me.TxtDealerContactNo = New System.Windows.Forms.TextBox
        Me.LblDContactNo = New System.Windows.Forms.Label
        Me.TxtDealerAddress = New System.Windows.Forms.TextBox
        Me.LbDealerAddress = New System.Windows.Forms.Label
        Me.TxtDealerName = New System.Windows.Forms.TextBox
        Me.LblDealerName = New System.Windows.Forms.Label
        Me.TxtDealerId = New System.Windows.Forms.TextBox
        Me.LblDealerId = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlCustOperations.SuspendLayout()
        Me.PnlCustNavigation.SuspendLayout()
        Me.PnlBankDet.SuspendLayout()
        Me.pnlDealer.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(638, 283)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(599, 398)
        Me.DataGridView1.TabIndex = 135
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
        Me.PnlCustOperations.Location = New System.Drawing.Point(638, 177)
        Me.PnlCustOperations.Name = "PnlCustOperations"
        Me.PnlCustOperations.Size = New System.Drawing.Size(445, 85)
        Me.PnlCustOperations.TabIndex = 136
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(332, 26)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(91, 38)
        Me.btnClear.TabIndex = 18
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(119, 26)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(104, 38)
        Me.btnUpdate.TabIndex = 16
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(13, 26)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(103, 38)
        Me.btnAdd.TabIndex = 15
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(229, 26)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(97, 38)
        Me.btnDelete.TabIndex = 17
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
        Me.PnlCustNavigation.Location = New System.Drawing.Point(638, 77)
        Me.PnlCustNavigation.Name = "PnlCustNavigation"
        Me.PnlCustNavigation.Size = New System.Drawing.Size(445, 80)
        Me.PnlCustNavigation.TabIndex = 137
        '
        'BtnNext
        '
        Me.BtnNext.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNext.Location = New System.Drawing.Point(229, 22)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(97, 39)
        Me.BtnNext.TabIndex = 13
        Me.BtnNext.Text = "Next>>"
        Me.BtnNext.UseVisualStyleBackColor = True
        '
        'BtnLast
        '
        Me.BtnLast.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLast.Location = New System.Drawing.Point(332, 22)
        Me.BtnLast.Name = "BtnLast"
        Me.BtnLast.Size = New System.Drawing.Size(91, 39)
        Me.BtnLast.TabIndex = 14
        Me.BtnLast.Text = "Last"
        Me.BtnLast.UseVisualStyleBackColor = True
        '
        'BtnPrev
        '
        Me.BtnPrev.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrev.Location = New System.Drawing.Point(119, 22)
        Me.BtnPrev.Name = "BtnPrev"
        Me.BtnPrev.Size = New System.Drawing.Size(104, 39)
        Me.BtnPrev.TabIndex = 12
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
        Me.BtnFirst.TabIndex = 11
        Me.BtnFirst.Text = "First"
        Me.BtnFirst.UseVisualStyleBackColor = True
        '
        'lbldocdet
        '
        Me.lbldocdet.AutoSize = True
        Me.lbldocdet.BackColor = System.Drawing.Color.Transparent
        Me.lbldocdet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbldocdet.Font = New System.Drawing.Font("Palatino Linotype", 40.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldocdet.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.lbldocdet.Location = New System.Drawing.Point(359, 0)
        Me.lbldocdet.Name = "lbldocdet"
        Me.lbldocdet.Size = New System.Drawing.Size(382, 74)
        Me.lbldocdet.TabIndex = 141
        Me.lbldocdet.Text = "Dealer Details"
        '
        'LblDBankDet
        '
        Me.LblDBankDet.AutoSize = True
        Me.LblDBankDet.BackColor = System.Drawing.Color.Transparent
        Me.LblDBankDet.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDBankDet.ForeColor = System.Drawing.Color.SkyBlue
        Me.LblDBankDet.Location = New System.Drawing.Point(210, 0)
        Me.LblDBankDet.Name = "LblDBankDet"
        Me.LblDBankDet.Size = New System.Drawing.Size(124, 24)
        Me.LblDBankDet.TabIndex = 153
        Me.LblDBankDet.Text = "Bank Details"
        '
        'PnlBankDet
        '
        Me.PnlBankDet.AutoScroll = True
        Me.PnlBankDet.BackgroundImage = CType(resources.GetObject("PnlBankDet.BackgroundImage"), System.Drawing.Image)
        Me.PnlBankDet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlBankDet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlBankDet.Controls.Add(Me.LblBranchName)
        Me.PnlBankDet.Controls.Add(Me.LblDBankDet)
        Me.PnlBankDet.Controls.Add(Me.TxtIFSC)
        Me.PnlBankDet.Controls.Add(Me.TxtBranchName)
        Me.PnlBankDet.Controls.Add(Me.LblIFSC)
        Me.PnlBankDet.Controls.Add(Me.TxtBankName)
        Me.PnlBankDet.Controls.Add(Me.LblBankName)
        Me.PnlBankDet.Controls.Add(Me.TxtAccName)
        Me.PnlBankDet.Controls.Add(Me.LblAccName)
        Me.PnlBankDet.Controls.Add(Me.TxtAccNo)
        Me.PnlBankDet.Controls.Add(Me.LblAccNo)
        Me.PnlBankDet.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PnlBankDet.Location = New System.Drawing.Point(54, 424)
        Me.PnlBankDet.Name = "PnlBankDet"
        Me.PnlBankDet.Size = New System.Drawing.Size(578, 257)
        Me.PnlBankDet.TabIndex = 147
        '
        'LblBranchName
        '
        Me.LblBranchName.AutoSize = True
        Me.LblBranchName.BackColor = System.Drawing.Color.Transparent
        Me.LblBranchName.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBranchName.ForeColor = System.Drawing.Color.White
        Me.LblBranchName.Location = New System.Drawing.Point(30, 165)
        Me.LblBranchName.Name = "LblBranchName"
        Me.LblBranchName.Size = New System.Drawing.Size(128, 22)
        Me.LblBranchName.TabIndex = 20
        Me.LblBranchName.Text = "Branch Name:"
        '
        'TxtIFSC
        '
        Me.TxtIFSC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.TxtIFSC.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIFSC.Location = New System.Drawing.Point(247, 210)
        Me.TxtIFSC.Name = "TxtIFSC"
        Me.TxtIFSC.Size = New System.Drawing.Size(228, 29)
        Me.TxtIFSC.TabIndex = 10
        '
        'TxtBranchName
        '
        Me.TxtBranchName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.TxtBranchName.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBranchName.Location = New System.Drawing.Point(247, 165)
        Me.TxtBranchName.Name = "TxtBranchName"
        Me.TxtBranchName.Size = New System.Drawing.Size(228, 29)
        Me.TxtBranchName.TabIndex = 9
        '
        'LblIFSC
        '
        Me.LblIFSC.AutoSize = True
        Me.LblIFSC.BackColor = System.Drawing.Color.Transparent
        Me.LblIFSC.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIFSC.ForeColor = System.Drawing.Color.White
        Me.LblIFSC.Location = New System.Drawing.Point(30, 210)
        Me.LblIFSC.Name = "LblIFSC"
        Me.LblIFSC.Size = New System.Drawing.Size(107, 22)
        Me.LblIFSC.TabIndex = 16
        Me.LblIFSC.Text = "IFSC Code:"
        '
        'TxtBankName
        '
        Me.TxtBankName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.TxtBankName.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBankName.Location = New System.Drawing.Point(247, 120)
        Me.TxtBankName.Name = "TxtBankName"
        Me.TxtBankName.Size = New System.Drawing.Size(228, 29)
        Me.TxtBankName.TabIndex = 8
        '
        'LblBankName
        '
        Me.LblBankName.AutoSize = True
        Me.LblBankName.BackColor = System.Drawing.Color.Transparent
        Me.LblBankName.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBankName.ForeColor = System.Drawing.Color.White
        Me.LblBankName.Location = New System.Drawing.Point(30, 120)
        Me.LblBankName.Name = "LblBankName"
        Me.LblBankName.Size = New System.Drawing.Size(112, 22)
        Me.LblBankName.TabIndex = 14
        Me.LblBankName.Text = "Bank Name:"
        '
        'TxtAccName
        '
        Me.TxtAccName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.TxtAccName.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAccName.Location = New System.Drawing.Point(247, 75)
        Me.TxtAccName.Name = "TxtAccName"
        Me.TxtAccName.Size = New System.Drawing.Size(228, 29)
        Me.TxtAccName.TabIndex = 7
        '
        'LblAccName
        '
        Me.LblAccName.AutoSize = True
        Me.LblAccName.BackColor = System.Drawing.Color.Transparent
        Me.LblAccName.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAccName.ForeColor = System.Drawing.Color.White
        Me.LblAccName.Location = New System.Drawing.Point(30, 75)
        Me.LblAccName.Name = "LblAccName"
        Me.LblAccName.Size = New System.Drawing.Size(135, 22)
        Me.LblAccName.TabIndex = 12
        Me.LblAccName.Text = "Account Name:"
        '
        'TxtAccNo
        '
        Me.TxtAccNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.TxtAccNo.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAccNo.Location = New System.Drawing.Point(247, 34)
        Me.TxtAccNo.Name = "TxtAccNo"
        Me.TxtAccNo.Size = New System.Drawing.Size(228, 29)
        Me.TxtAccNo.TabIndex = 6
        '
        'LblAccNo
        '
        Me.LblAccNo.AutoSize = True
        Me.LblAccNo.BackColor = System.Drawing.Color.Transparent
        Me.LblAccNo.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAccNo.ForeColor = System.Drawing.Color.White
        Me.LblAccNo.Location = New System.Drawing.Point(30, 34)
        Me.LblAccNo.Name = "LblAccNo"
        Me.LblAccNo.Size = New System.Drawing.Size(153, 22)
        Me.LblAccNo.TabIndex = 10
        Me.LblAccNo.Text = "Account Number:"
        '
        'pnlDealer
        '
        Me.pnlDealer.BackgroundImage = CType(resources.GetObject("pnlDealer.BackgroundImage"), System.Drawing.Image)
        Me.pnlDealer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlDealer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlDealer.Controls.Add(Me.btnnewid)
        Me.pnlDealer.Controls.Add(Me.TxtCompany)
        Me.pnlDealer.Controls.Add(Me.lblCompany)
        Me.pnlDealer.Controls.Add(Me.TxtDealerEmail)
        Me.pnlDealer.Controls.Add(Me.LblDEmail)
        Me.pnlDealer.Controls.Add(Me.TxtDealerContactNo)
        Me.pnlDealer.Controls.Add(Me.LblDContactNo)
        Me.pnlDealer.Controls.Add(Me.TxtDealerAddress)
        Me.pnlDealer.Controls.Add(Me.LbDealerAddress)
        Me.pnlDealer.Controls.Add(Me.TxtDealerName)
        Me.pnlDealer.Controls.Add(Me.LblDealerName)
        Me.pnlDealer.Controls.Add(Me.TxtDealerId)
        Me.pnlDealer.Controls.Add(Me.LblDealerId)
        Me.pnlDealer.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlDealer.ForeColor = System.Drawing.Color.White
        Me.pnlDealer.Location = New System.Drawing.Point(54, 77)
        Me.pnlDealer.Name = "pnlDealer"
        Me.pnlDealer.Size = New System.Drawing.Size(578, 341)
        Me.pnlDealer.TabIndex = 154
        '
        'btnnewid
        '
        Me.btnnewid.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnnewid.BackColor = System.Drawing.Color.Black
        Me.btnnewid.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnewid.ForeColor = System.Drawing.Color.White
        Me.btnnewid.Location = New System.Drawing.Point(363, 18)
        Me.btnnewid.Name = "btnnewid"
        Me.btnnewid.Size = New System.Drawing.Size(112, 32)
        Me.btnnewid.TabIndex = 165
        Me.btnnewid.Text = "New Id"
        Me.btnnewid.UseVisualStyleBackColor = False
        '
        'TxtCompany
        '
        Me.TxtCompany.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.TxtCompany.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCompany.Location = New System.Drawing.Point(247, 297)
        Me.TxtCompany.Name = "TxtCompany"
        Me.TxtCompany.Size = New System.Drawing.Size(228, 29)
        Me.TxtCompany.TabIndex = 5
        '
        'lblCompany
        '
        Me.lblCompany.AutoSize = True
        Me.lblCompany.BackColor = System.Drawing.Color.Transparent
        Me.lblCompany.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompany.ForeColor = System.Drawing.Color.White
        Me.lblCompany.Location = New System.Drawing.Point(30, 300)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(93, 22)
        Me.lblCompany.TabIndex = 164
        Me.lblCompany.Text = "Company:"
        '
        'TxtDealerEmail
        '
        Me.TxtDealerEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.TxtDealerEmail.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDealerEmail.Location = New System.Drawing.Point(247, 250)
        Me.TxtDealerEmail.Name = "TxtDealerEmail"
        Me.TxtDealerEmail.Size = New System.Drawing.Size(228, 29)
        Me.TxtDealerEmail.TabIndex = 4
        '
        'LblDEmail
        '
        Me.LblDEmail.AutoSize = True
        Me.LblDEmail.BackColor = System.Drawing.Color.Transparent
        Me.LblDEmail.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDEmail.ForeColor = System.Drawing.Color.White
        Me.LblDEmail.Location = New System.Drawing.Point(30, 253)
        Me.LblDEmail.Name = "LblDEmail"
        Me.LblDEmail.Size = New System.Drawing.Size(89, 22)
        Me.LblDEmail.TabIndex = 162
        Me.LblDEmail.Text = "Email ID:"
        '
        'TxtDealerContactNo
        '
        Me.TxtDealerContactNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.TxtDealerContactNo.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDealerContactNo.Location = New System.Drawing.Point(247, 204)
        Me.TxtDealerContactNo.MaxLength = 10
        Me.TxtDealerContactNo.Name = "TxtDealerContactNo"
        Me.TxtDealerContactNo.Size = New System.Drawing.Size(228, 29)
        Me.TxtDealerContactNo.TabIndex = 3
        '
        'LblDContactNo
        '
        Me.LblDContactNo.AutoSize = True
        Me.LblDContactNo.BackColor = System.Drawing.Color.Transparent
        Me.LblDContactNo.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDContactNo.ForeColor = System.Drawing.Color.White
        Me.LblDContactNo.Location = New System.Drawing.Point(30, 204)
        Me.LblDContactNo.Name = "LblDContactNo"
        Me.LblDContactNo.Size = New System.Drawing.Size(151, 22)
        Me.LblDContactNo.TabIndex = 161
        Me.LblDContactNo.Text = "Contact Number:"
        '
        'TxtDealerAddress
        '
        Me.TxtDealerAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.TxtDealerAddress.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDealerAddress.Location = New System.Drawing.Point(247, 118)
        Me.TxtDealerAddress.Multiline = True
        Me.TxtDealerAddress.Name = "TxtDealerAddress"
        Me.TxtDealerAddress.Size = New System.Drawing.Size(228, 65)
        Me.TxtDealerAddress.TabIndex = 2
        '
        'LbDealerAddress
        '
        Me.LbDealerAddress.AutoSize = True
        Me.LbDealerAddress.BackColor = System.Drawing.Color.Transparent
        Me.LbDealerAddress.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDealerAddress.ForeColor = System.Drawing.Color.White
        Me.LbDealerAddress.Location = New System.Drawing.Point(30, 143)
        Me.LbDealerAddress.Name = "LbDealerAddress"
        Me.LbDealerAddress.Size = New System.Drawing.Size(140, 22)
        Me.LbDealerAddress.TabIndex = 160
        Me.LbDealerAddress.Text = "Dealer Address:"
        '
        'TxtDealerName
        '
        Me.TxtDealerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.TxtDealerName.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDealerName.Location = New System.Drawing.Point(247, 73)
        Me.TxtDealerName.Name = "TxtDealerName"
        Me.TxtDealerName.Size = New System.Drawing.Size(228, 29)
        Me.TxtDealerName.TabIndex = 1
        '
        'LblDealerName
        '
        Me.LblDealerName.AutoSize = True
        Me.LblDealerName.BackColor = System.Drawing.Color.Transparent
        Me.LblDealerName.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDealerName.ForeColor = System.Drawing.Color.White
        Me.LblDealerName.Location = New System.Drawing.Point(30, 76)
        Me.LblDealerName.Name = "LblDealerName"
        Me.LblDealerName.Size = New System.Drawing.Size(123, 22)
        Me.LblDealerName.TabIndex = 159
        Me.LblDealerName.Text = "Dealer Name:"
        '
        'TxtDealerId
        '
        Me.TxtDealerId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.TxtDealerId.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDealerId.Location = New System.Drawing.Point(247, 21)
        Me.TxtDealerId.Name = "TxtDealerId"
        Me.TxtDealerId.Size = New System.Drawing.Size(100, 29)
        Me.TxtDealerId.TabIndex = 0
        '
        'LblDealerId
        '
        Me.LblDealerId.AutoSize = True
        Me.LblDealerId.BackColor = System.Drawing.Color.Transparent
        Me.LblDealerId.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDealerId.ForeColor = System.Drawing.Color.White
        Me.LblDealerId.Location = New System.Drawing.Point(30, 21)
        Me.LblDealerId.Name = "LblDealerId"
        Me.LblDealerId.Size = New System.Drawing.Size(96, 22)
        Me.LblDealerId.TabIndex = 158
        Me.LblDealerId.Text = "Dealer ID:"
        '
        'DealerMaster
        '
        Me.AcceptButton = Me.btnnewid
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1309, 746)
        Me.Controls.Add(Me.pnlDealer)
        Me.Controls.Add(Me.PnlBankDet)
        Me.Controls.Add(Me.lbldocdet)
        Me.Controls.Add(Me.PnlCustOperations)
        Me.Controls.Add(Me.PnlCustNavigation)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "DealerMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "DealerMaster"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlCustOperations.ResumeLayout(False)
        Me.PnlCustNavigation.ResumeLayout(False)
        Me.PnlBankDet.ResumeLayout(False)
        Me.PnlBankDet.PerformLayout()
        Me.pnlDealer.ResumeLayout(False)
        Me.pnlDealer.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents lbldocdet As System.Windows.Forms.Label
    Friend WithEvents LblDBankDet As System.Windows.Forms.Label
    Friend WithEvents PnlBankDet As System.Windows.Forms.Panel
    Friend WithEvents LblBranchName As System.Windows.Forms.Label
    Friend WithEvents TxtIFSC As System.Windows.Forms.TextBox
    Friend WithEvents TxtBranchName As System.Windows.Forms.TextBox
    Friend WithEvents LblIFSC As System.Windows.Forms.Label
    Friend WithEvents TxtBankName As System.Windows.Forms.TextBox
    Friend WithEvents LblBankName As System.Windows.Forms.Label
    Friend WithEvents TxtAccName As System.Windows.Forms.TextBox
    Friend WithEvents LblAccName As System.Windows.Forms.Label
    Friend WithEvents TxtAccNo As System.Windows.Forms.TextBox
    Friend WithEvents LblAccNo As System.Windows.Forms.Label
    Friend WithEvents pnlDealer As System.Windows.Forms.Panel
    Friend WithEvents TxtDealerEmail As System.Windows.Forms.TextBox
    Friend WithEvents LblDEmail As System.Windows.Forms.Label
    Friend WithEvents TxtDealerContactNo As System.Windows.Forms.TextBox
    Friend WithEvents LblDContactNo As System.Windows.Forms.Label
    Friend WithEvents TxtDealerAddress As System.Windows.Forms.TextBox
    Friend WithEvents LbDealerAddress As System.Windows.Forms.Label
    Friend WithEvents TxtDealerName As System.Windows.Forms.TextBox
    Friend WithEvents LblDealerName As System.Windows.Forms.Label
    Friend WithEvents TxtDealerId As System.Windows.Forms.TextBox
    Friend WithEvents LblDealerId As System.Windows.Forms.Label
    Friend WithEvents TxtCompany As System.Windows.Forms.TextBox
    Friend WithEvents lblCompany As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnnewid As System.Windows.Forms.Button
End Class
