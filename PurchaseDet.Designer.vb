<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PurchaseDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PurchaseDetails))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtBillNo = New System.Windows.Forms.TextBox
        Me.txtVAT = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtDealer = New System.Windows.Forms.TextBox
        Me.txtAmt = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtQuantity = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbChemName = New System.Windows.Forms.ComboBox
        Me.dtpPurDetail = New System.Windows.Forms.DateTimePicker
        Me.LblPurDetDate = New System.Windows.Forms.Label
        Me.txtPurDetRate = New System.Windows.Forms.TextBox
        Me.LblPurDetRate = New System.Windows.Forms.Label
        Me.LblEqupName = New System.Windows.Forms.Label
        Me.txtPurDetSrNo = New System.Windows.Forms.TextBox
        Me.LblPurDetSrNo = New System.Windows.Forms.Label
        Me.LblDealerName = New System.Windows.Forms.Label
        Me.txtPurchaseId = New System.Windows.Forms.TextBox
        Me.LblPurchaseId = New System.Windows.Forms.Label
        Me.lbldocdet = New System.Windows.Forms.Label
        Me.PnlCustNavigation = New System.Windows.Forms.Panel
        Me.BtnNext = New System.Windows.Forms.Button
        Me.BtnLast = New System.Windows.Forms.Button
        Me.BtnPrev = New System.Windows.Forms.Button
        Me.BtnFirst = New System.Windows.Forms.Button
        Me.PnlCustOperations = New System.Windows.Forms.Panel
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.lblLnkPrint = New System.Windows.Forms.LinkLabel
        Me.btnFnlBill = New System.Windows.Forms.Button
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.PnlCustNavigation.SuspendLayout()
        Me.PnlCustOperations.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(565, 309)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(644, 347)
        Me.DataGridView1.TabIndex = 81
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.txtBillNo)
        Me.Panel1.Controls.Add(Me.txtVAT)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtDealer)
        Me.Panel1.Controls.Add(Me.txtAmt)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtQuantity)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cmbChemName)
        Me.Panel1.Controls.Add(Me.dtpPurDetail)
        Me.Panel1.Controls.Add(Me.LblPurDetDate)
        Me.Panel1.Controls.Add(Me.txtPurDetRate)
        Me.Panel1.Controls.Add(Me.LblPurDetRate)
        Me.Panel1.Controls.Add(Me.LblEqupName)
        Me.Panel1.Controls.Add(Me.txtPurDetSrNo)
        Me.Panel1.Controls.Add(Me.LblPurDetSrNo)
        Me.Panel1.Controls.Add(Me.LblDealerName)
        Me.Panel1.Controls.Add(Me.txtPurchaseId)
        Me.Panel1.Controls.Add(Me.LblPurchaseId)
        Me.Panel1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.Transparent
        Me.Panel1.Location = New System.Drawing.Point(27, 88)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(532, 568)
        Me.Panel1.TabIndex = 82
        '
        'txtBillNo
        '
        Me.txtBillNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.txtBillNo.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBillNo.Location = New System.Drawing.Point(226, 121)
        Me.txtBillNo.Name = "txtBillNo"
        Me.txtBillNo.Size = New System.Drawing.Size(116, 29)
        Me.txtBillNo.TabIndex = 1
        '
        'txtVAT
        '
        Me.txtVAT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.txtVAT.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVAT.Location = New System.Drawing.Point(228, 460)
        Me.txtVAT.Name = "txtVAT"
        Me.txtVAT.Size = New System.Drawing.Size(226, 29)
        Me.txtVAT.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(33, 467)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 22)
        Me.Label4.TabIndex = 149
        Me.Label4.Text = "VAT Rate:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(31, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 22)
        Me.Label3.TabIndex = 107
        Me.Label3.Text = "Bill No:"
        '
        'txtDealer
        '
        Me.txtDealer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.txtDealer.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDealer.Location = New System.Drawing.Point(226, 175)
        Me.txtDealer.Name = "txtDealer"
        Me.txtDealer.Size = New System.Drawing.Size(228, 29)
        Me.txtDealer.TabIndex = 2
        '
        'txtAmt
        '
        Me.txtAmt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.txtAmt.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmt.Location = New System.Drawing.Point(228, 511)
        Me.txtAmt.Name = "txtAmt"
        Me.txtAmt.Size = New System.Drawing.Size(228, 29)
        Me.txtAmt.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(33, 518)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 22)
        Me.Label2.TabIndex = 104
        Me.Label2.Text = "Amount:"
        '
        'txtQuantity
        '
        Me.txtQuantity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.txtQuantity.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(226, 407)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(228, 29)
        Me.txtQuantity.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(33, 410)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 22)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "Quantity:"
        '
        'cmbChemName
        '
        Me.cmbChemName.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbChemName.FormattingEnabled = True
        Me.cmbChemName.Location = New System.Drawing.Point(228, 289)
        Me.cmbChemName.Name = "cmbChemName"
        Me.cmbChemName.Size = New System.Drawing.Size(226, 30)
        Me.cmbChemName.TabIndex = 4
        '
        'dtpPurDetail
        '
        Me.dtpPurDetail.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpPurDetail.Location = New System.Drawing.Point(260, 13)
        Me.dtpPurDetail.Name = "dtpPurDetail"
        Me.dtpPurDetail.Size = New System.Drawing.Size(258, 27)
        Me.dtpPurDetail.TabIndex = 9
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
        'txtPurDetRate
        '
        Me.txtPurDetRate.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.txtPurDetRate.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPurDetRate.Location = New System.Drawing.Point(228, 350)
        Me.txtPurDetRate.Name = "txtPurDetRate"
        Me.txtPurDetRate.Size = New System.Drawing.Size(228, 29)
        Me.txtPurDetRate.TabIndex = 5
        '
        'LblPurDetRate
        '
        Me.LblPurDetRate.AutoSize = True
        Me.LblPurDetRate.BackColor = System.Drawing.Color.Transparent
        Me.LblPurDetRate.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPurDetRate.ForeColor = System.Drawing.Color.Transparent
        Me.LblPurDetRate.Location = New System.Drawing.Point(33, 353)
        Me.LblPurDetRate.Name = "LblPurDetRate"
        Me.LblPurDetRate.Size = New System.Drawing.Size(54, 22)
        Me.LblPurDetRate.TabIndex = 94
        Me.LblPurDetRate.Text = "Rate:"
        '
        'LblEqupName
        '
        Me.LblEqupName.AutoSize = True
        Me.LblEqupName.BackColor = System.Drawing.Color.Transparent
        Me.LblEqupName.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEqupName.ForeColor = System.Drawing.Color.Transparent
        Me.LblEqupName.Location = New System.Drawing.Point(31, 292)
        Me.LblEqupName.Name = "LblEqupName"
        Me.LblEqupName.Size = New System.Drawing.Size(145, 22)
        Me.LblEqupName.TabIndex = 93
        Me.LblEqupName.Text = "Chemical Name:"
        '
        'txtPurDetSrNo
        '
        Me.txtPurDetSrNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.txtPurDetSrNo.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPurDetSrNo.Location = New System.Drawing.Point(226, 229)
        Me.txtPurDetSrNo.Name = "txtPurDetSrNo"
        Me.txtPurDetSrNo.Size = New System.Drawing.Size(228, 29)
        Me.txtPurDetSrNo.TabIndex = 3
        '
        'LblPurDetSrNo
        '
        Me.LblPurDetSrNo.AutoSize = True
        Me.LblPurDetSrNo.BackColor = System.Drawing.Color.Transparent
        Me.LblPurDetSrNo.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPurDetSrNo.ForeColor = System.Drawing.Color.Transparent
        Me.LblPurDetSrNo.Location = New System.Drawing.Point(31, 232)
        Me.LblPurDetSrNo.Name = "LblPurDetSrNo"
        Me.LblPurDetSrNo.Size = New System.Drawing.Size(134, 22)
        Me.LblPurDetSrNo.TabIndex = 92
        Me.LblPurDetSrNo.Text = "Serial Number:"
        '
        'LblDealerName
        '
        Me.LblDealerName.AutoSize = True
        Me.LblDealerName.BackColor = System.Drawing.Color.Transparent
        Me.LblDealerName.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDealerName.ForeColor = System.Drawing.Color.Transparent
        Me.LblDealerName.Location = New System.Drawing.Point(31, 175)
        Me.LblDealerName.Name = "LblDealerName"
        Me.LblDealerName.Size = New System.Drawing.Size(123, 22)
        Me.LblDealerName.TabIndex = 90
        Me.LblDealerName.Text = "Dealer Name:"
        '
        'txtPurchaseId
        '
        Me.txtPurchaseId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.txtPurchaseId.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPurchaseId.Location = New System.Drawing.Point(226, 66)
        Me.txtPurchaseId.Name = "txtPurchaseId"
        Me.txtPurchaseId.Size = New System.Drawing.Size(116, 29)
        Me.txtPurchaseId.TabIndex = 0
        '
        'LblPurchaseId
        '
        Me.LblPurchaseId.AutoSize = True
        Me.LblPurchaseId.BackColor = System.Drawing.Color.Transparent
        Me.LblPurchaseId.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPurchaseId.ForeColor = System.Drawing.Color.Transparent
        Me.LblPurchaseId.Location = New System.Drawing.Point(31, 66)
        Me.LblPurchaseId.Name = "LblPurchaseId"
        Me.LblPurchaseId.Size = New System.Drawing.Size(113, 22)
        Me.LblPurchaseId.TabIndex = 89
        Me.LblPurchaseId.Text = "Purchase Id:"
        '
        'lbldocdet
        '
        Me.lbldocdet.AutoSize = True
        Me.lbldocdet.BackColor = System.Drawing.Color.Transparent
        Me.lbldocdet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbldocdet.Font = New System.Drawing.Font("Palatino Linotype", 40.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldocdet.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.lbldocdet.Location = New System.Drawing.Point(294, -3)
        Me.lbldocdet.Name = "lbldocdet"
        Me.lbldocdet.Size = New System.Drawing.Size(442, 74)
        Me.lbldocdet.TabIndex = 131
        Me.lbldocdet.Text = "Purchase Details"
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
        Me.PnlCustNavigation.Location = New System.Drawing.Point(565, 88)
        Me.PnlCustNavigation.Name = "PnlCustNavigation"
        Me.PnlCustNavigation.Size = New System.Drawing.Size(445, 80)
        Me.PnlCustNavigation.TabIndex = 145
        '
        'BtnNext
        '
        Me.BtnNext.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNext.Location = New System.Drawing.Point(229, 22)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(97, 39)
        Me.BtnNext.TabIndex = 12
        Me.BtnNext.Text = "Next>>"
        Me.BtnNext.UseVisualStyleBackColor = True
        '
        'BtnLast
        '
        Me.BtnLast.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLast.Location = New System.Drawing.Point(332, 22)
        Me.BtnLast.Name = "BtnLast"
        Me.BtnLast.Size = New System.Drawing.Size(91, 39)
        Me.BtnLast.TabIndex = 13
        Me.BtnLast.Text = "Last"
        Me.BtnLast.UseVisualStyleBackColor = True
        '
        'BtnPrev
        '
        Me.BtnPrev.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrev.Location = New System.Drawing.Point(119, 22)
        Me.BtnPrev.Name = "BtnPrev"
        Me.BtnPrev.Size = New System.Drawing.Size(104, 39)
        Me.BtnPrev.TabIndex = 11
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
        Me.BtnFirst.TabIndex = 10
        Me.BtnFirst.Text = "First"
        Me.BtnFirst.UseVisualStyleBackColor = True
        '
        'PnlCustOperations
        '
        Me.PnlCustOperations.BackgroundImage = CType(resources.GetObject("PnlCustOperations.BackgroundImage"), System.Drawing.Image)
        Me.PnlCustOperations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PnlCustOperations.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlCustOperations.Controls.Add(Me.btnUpdate)
        Me.PnlCustOperations.Controls.Add(Me.btnClear)
        Me.PnlCustOperations.Controls.Add(Me.btnAdd)
        Me.PnlCustOperations.Controls.Add(Me.btnDelete)
        Me.PnlCustOperations.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PnlCustOperations.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PnlCustOperations.Location = New System.Drawing.Point(565, 174)
        Me.PnlCustOperations.Name = "PnlCustOperations"
        Me.PnlCustOperations.Size = New System.Drawing.Size(445, 85)
        Me.PnlCustOperations.TabIndex = 144
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(119, 26)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(103, 38)
        Me.btnUpdate.TabIndex = 15
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(332, 26)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(91, 38)
        Me.btnClear.TabIndex = 17
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(13, 26)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(103, 38)
        Me.btnAdd.TabIndex = 14
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(229, 26)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(97, 38)
        Me.btnDelete.TabIndex = 16
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'lblLnkPrint
        '
        Me.lblLnkPrint.AutoSize = True
        Me.lblLnkPrint.BackColor = System.Drawing.Color.Lavender
        Me.lblLnkPrint.Font = New System.Drawing.Font("Perpetua Titling MT", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLnkPrint.ForeColor = System.Drawing.Color.White
        Me.lblLnkPrint.Location = New System.Drawing.Point(818, 53)
        Me.lblLnkPrint.Name = "lblLnkPrint"
        Me.lblLnkPrint.Size = New System.Drawing.Size(105, 32)
        Me.lblLnkPrint.TabIndex = 167
        Me.lblLnkPrint.TabStop = True
        Me.lblLnkPrint.Text = "Print"
        '
        'btnFnlBill
        '
        Me.btnFnlBill.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFnlBill.ForeColor = System.Drawing.Color.Navy
        Me.btnFnlBill.Location = New System.Drawing.Point(686, 265)
        Me.btnFnlBill.Name = "btnFnlBill"
        Me.btnFnlBill.Size = New System.Drawing.Size(235, 39)
        Me.btnFnlBill.TabIndex = 18
        Me.btnFnlBill.Text = "Finalize Bill"
        Me.btnFnlBill.UseVisualStyleBackColor = True
        '
        'PurchaseDetails
        '
        Me.AcceptButton = Me.btnFnlBill
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1327, 746)
        Me.Controls.Add(Me.btnFnlBill)
        Me.Controls.Add(Me.lblLnkPrint)
        Me.Controls.Add(Me.PnlCustNavigation)
        Me.Controls.Add(Me.PnlCustOperations)
        Me.Controls.Add(Me.lbldocdet)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "PurchaseDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "PurchaseDetails"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PnlCustNavigation.ResumeLayout(False)
        Me.PnlCustOperations.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtPurDetRate As System.Windows.Forms.TextBox
    Friend WithEvents LblPurDetRate As System.Windows.Forms.Label
    Friend WithEvents LblEqupName As System.Windows.Forms.Label
    Friend WithEvents txtPurDetSrNo As System.Windows.Forms.TextBox
    Friend WithEvents LblPurDetSrNo As System.Windows.Forms.Label
    Friend WithEvents LblDealerName As System.Windows.Forms.Label
    Friend WithEvents txtPurchaseId As System.Windows.Forms.TextBox
    Friend WithEvents LblPurchaseId As System.Windows.Forms.Label
    Friend WithEvents lbldocdet As System.Windows.Forms.Label
    Friend WithEvents PnlCustNavigation As System.Windows.Forms.Panel
    Friend WithEvents BtnNext As System.Windows.Forms.Button
    Friend WithEvents BtnLast As System.Windows.Forms.Button
    Friend WithEvents BtnPrev As System.Windows.Forms.Button
    Friend WithEvents BtnFirst As System.Windows.Forms.Button
    Friend WithEvents PnlCustOperations As System.Windows.Forms.Panel
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents dtpPurDetail As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblPurDetDate As System.Windows.Forms.Label
    Friend WithEvents cmbChemName As System.Windows.Forms.ComboBox
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAmt As System.Windows.Forms.TextBox
    Friend WithEvents txtDealer As System.Windows.Forms.TextBox
    Friend WithEvents txtVAT As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents txtBillNo As System.Windows.Forms.TextBox
    Friend WithEvents lblLnkPrint As System.Windows.Forms.LinkLabel
    Friend WithEvents btnFnlBill As System.Windows.Forms.Button
End Class
