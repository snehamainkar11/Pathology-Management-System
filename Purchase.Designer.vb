<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Purchase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Purchase))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnlAmt = New System.Windows.Forms.Panel
        Me.cmbPaidBy = New System.Windows.Forms.ComboBox
        Me.TxtVATTax = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.LblPurAmt = New System.Windows.Forms.Label
        Me.TxtNetAmt = New System.Windows.Forms.TextBox
        Me.LblNetAmt = New System.Windows.Forms.Label
        Me.TxtPurAmt = New System.Windows.Forms.TextBox
        Me.LblVATTax = New System.Windows.Forms.Label
        Me.pnlPur = New System.Windows.Forms.Panel
        Me.txtContact = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtAddr = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtBillNo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpPurchase = New System.Windows.Forms.DateTimePicker
        Me.LblPurDate = New System.Windows.Forms.Label
        Me.btnnewid = New System.Windows.Forms.Button
        Me.CmbDealerName = New System.Windows.Forms.ComboBox
        Me.TxtPurchaseId = New System.Windows.Forms.TextBox
        Me.LblPurchaseId = New System.Windows.Forms.Label
        Me.LblDealerName = New System.Windows.Forms.Label
        Me.lbldocdet = New System.Windows.Forms.Label
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
        Me.BtnAddPurDet = New System.Windows.Forms.Button
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAmt.SuspendLayout()
        Me.pnlPur.SuspendLayout()
        Me.PnlCustNavigation.SuspendLayout()
        Me.PnlCustOperations.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(571, 257)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(644, 373)
        Me.DataGridView1.TabIndex = 56
        '
        'pnlAmt
        '
        Me.pnlAmt.BackColor = System.Drawing.Color.Transparent
        Me.pnlAmt.BackgroundImage = CType(resources.GetObject("pnlAmt.BackgroundImage"), System.Drawing.Image)
        Me.pnlAmt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlAmt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlAmt.Controls.Add(Me.cmbPaidBy)
        Me.pnlAmt.Controls.Add(Me.TxtVATTax)
        Me.pnlAmt.Controls.Add(Me.Label4)
        Me.pnlAmt.Controls.Add(Me.LblPurAmt)
        Me.pnlAmt.Controls.Add(Me.TxtNetAmt)
        Me.pnlAmt.Controls.Add(Me.LblNetAmt)
        Me.pnlAmt.Controls.Add(Me.TxtPurAmt)
        Me.pnlAmt.Controls.Add(Me.LblVATTax)
        Me.pnlAmt.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlAmt.ForeColor = System.Drawing.Color.Transparent
        Me.pnlAmt.Location = New System.Drawing.Point(40, 429)
        Me.pnlAmt.Name = "pnlAmt"
        Me.pnlAmt.Size = New System.Drawing.Size(525, 203)
        Me.pnlAmt.TabIndex = 58
        '
        'cmbPaidBy
        '
        Me.cmbPaidBy.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPaidBy.FormattingEnabled = True
        Me.cmbPaidBy.Location = New System.Drawing.Point(234, 153)
        Me.cmbPaidBy.Name = "cmbPaidBy"
        Me.cmbPaidBy.Size = New System.Drawing.Size(220, 30)
        Me.cmbPaidBy.TabIndex = 9
        '
        'TxtVATTax
        '
        Me.TxtVATTax.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.TxtVATTax.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtVATTax.Location = New System.Drawing.Point(234, 65)
        Me.TxtVATTax.Name = "TxtVATTax"
        Me.TxtVATTax.Size = New System.Drawing.Size(220, 29)
        Me.TxtVATTax.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(44, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 22)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Paid By:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblPurAmt
        '
        Me.LblPurAmt.AutoSize = True
        Me.LblPurAmt.BackColor = System.Drawing.Color.Transparent
        Me.LblPurAmt.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPurAmt.ForeColor = System.Drawing.Color.Transparent
        Me.LblPurAmt.Location = New System.Drawing.Point(42, 25)
        Me.LblPurAmt.Name = "LblPurAmt"
        Me.LblPurAmt.Size = New System.Drawing.Size(79, 22)
        Me.LblPurAmt.TabIndex = 47
        Me.LblPurAmt.Text = "Amount:"
        '
        'TxtNetAmt
        '
        Me.TxtNetAmt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.TxtNetAmt.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNetAmt.Location = New System.Drawing.Point(234, 107)
        Me.TxtNetAmt.Name = "TxtNetAmt"
        Me.TxtNetAmt.Size = New System.Drawing.Size(220, 29)
        Me.TxtNetAmt.TabIndex = 8
        '
        'LblNetAmt
        '
        Me.LblNetAmt.AutoSize = True
        Me.LblNetAmt.BackColor = System.Drawing.Color.Transparent
        Me.LblNetAmt.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNetAmt.ForeColor = System.Drawing.Color.Transparent
        Me.LblNetAmt.Location = New System.Drawing.Point(42, 114)
        Me.LblNetAmt.Name = "LblNetAmt"
        Me.LblNetAmt.Size = New System.Drawing.Size(112, 22)
        Me.LblNetAmt.TabIndex = 46
        Me.LblNetAmt.Text = "Net Amount:"
        '
        'TxtPurAmt
        '
        Me.TxtPurAmt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.TxtPurAmt.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPurAmt.Location = New System.Drawing.Point(234, 22)
        Me.TxtPurAmt.Name = "TxtPurAmt"
        Me.TxtPurAmt.Size = New System.Drawing.Size(220, 29)
        Me.TxtPurAmt.TabIndex = 6
        '
        'LblVATTax
        '
        Me.LblVATTax.AutoSize = True
        Me.LblVATTax.BackColor = System.Drawing.Color.Transparent
        Me.LblVATTax.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVATTax.ForeColor = System.Drawing.Color.Transparent
        Me.LblVATTax.Location = New System.Drawing.Point(43, 68)
        Me.LblVATTax.Name = "LblVATTax"
        Me.LblVATTax.Size = New System.Drawing.Size(86, 22)
        Me.LblVATTax.TabIndex = 45
        Me.LblVATTax.Text = "VAT Tax:"
        '
        'pnlPur
        '
        Me.pnlPur.BackgroundImage = CType(resources.GetObject("pnlPur.BackgroundImage"), System.Drawing.Image)
        Me.pnlPur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlPur.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlPur.Controls.Add(Me.txtContact)
        Me.pnlPur.Controls.Add(Me.Label2)
        Me.pnlPur.Controls.Add(Me.txtAddr)
        Me.pnlPur.Controls.Add(Me.Label3)
        Me.pnlPur.Controls.Add(Me.txtBillNo)
        Me.pnlPur.Controls.Add(Me.Label1)
        Me.pnlPur.Controls.Add(Me.dtpPurchase)
        Me.pnlPur.Controls.Add(Me.LblPurDate)
        Me.pnlPur.Controls.Add(Me.btnnewid)
        Me.pnlPur.Controls.Add(Me.CmbDealerName)
        Me.pnlPur.Controls.Add(Me.TxtPurchaseId)
        Me.pnlPur.Controls.Add(Me.LblPurchaseId)
        Me.pnlPur.Controls.Add(Me.LblDealerName)
        Me.pnlPur.Location = New System.Drawing.Point(40, 76)
        Me.pnlPur.Name = "pnlPur"
        Me.pnlPur.Size = New System.Drawing.Size(525, 307)
        Me.pnlPur.TabIndex = 59
        '
        'txtContact
        '
        Me.txtContact.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.txtContact.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.Location = New System.Drawing.Point(239, 261)
        Me.txtContact.MaxLength = 10
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(245, 29)
        Me.txtContact.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(43, 261)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 22)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Contact:"
        '
        'txtAddr
        '
        Me.txtAddr.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.txtAddr.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddr.Location = New System.Drawing.Point(239, 196)
        Me.txtAddr.Multiline = True
        Me.txtAddr.Name = "txtAddr"
        Me.txtAddr.Size = New System.Drawing.Size(245, 51)
        Me.txtAddr.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(43, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 22)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "Dealer Address:"
        '
        'txtBillNo
        '
        Me.txtBillNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.txtBillNo.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBillNo.Location = New System.Drawing.Point(239, 101)
        Me.txtBillNo.Name = "txtBillNo"
        Me.txtBillNo.Size = New System.Drawing.Size(107, 29)
        Me.txtBillNo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(43, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 22)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Bill No:"
        '
        'dtpPurchase
        '
        Me.dtpPurchase.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpPurchase.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPurchase.Location = New System.Drawing.Point(325, 18)
        Me.dtpPurchase.Name = "dtpPurchase"
        Me.dtpPurchase.Size = New System.Drawing.Size(172, 27)
        Me.dtpPurchase.TabIndex = 62
        '
        'LblPurDate
        '
        Me.LblPurDate.AutoSize = True
        Me.LblPurDate.BackColor = System.Drawing.Color.Transparent
        Me.LblPurDate.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPurDate.ForeColor = System.Drawing.Color.Transparent
        Me.LblPurDate.Location = New System.Drawing.Point(246, 22)
        Me.LblPurDate.Name = "LblPurDate"
        Me.LblPurDate.Size = New System.Drawing.Size(54, 22)
        Me.LblPurDate.TabIndex = 63
        Me.LblPurDate.Text = "Date:"
        '
        'btnnewid
        '
        Me.btnnewid.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnnewid.BackColor = System.Drawing.Color.Black
        Me.btnnewid.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnewid.ForeColor = System.Drawing.Color.White
        Me.btnnewid.Location = New System.Drawing.Point(360, 51)
        Me.btnnewid.Name = "btnnewid"
        Me.btnnewid.Size = New System.Drawing.Size(124, 37)
        Me.btnnewid.TabIndex = 60
        Me.btnnewid.Text = "New Id"
        Me.btnnewid.UseVisualStyleBackColor = False
        '
        'CmbDealerName
        '
        Me.CmbDealerName.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbDealerName.FormattingEnabled = True
        Me.CmbDealerName.Location = New System.Drawing.Point(239, 151)
        Me.CmbDealerName.Name = "CmbDealerName"
        Me.CmbDealerName.Size = New System.Drawing.Size(245, 30)
        Me.CmbDealerName.TabIndex = 2
        '
        'TxtPurchaseId
        '
        Me.TxtPurchaseId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.TxtPurchaseId.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPurchaseId.Location = New System.Drawing.Point(239, 56)
        Me.TxtPurchaseId.Name = "TxtPurchaseId"
        Me.TxtPurchaseId.Size = New System.Drawing.Size(107, 29)
        Me.TxtPurchaseId.TabIndex = 0
        '
        'LblPurchaseId
        '
        Me.LblPurchaseId.AutoSize = True
        Me.LblPurchaseId.BackColor = System.Drawing.Color.Transparent
        Me.LblPurchaseId.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPurchaseId.ForeColor = System.Drawing.Color.Transparent
        Me.LblPurchaseId.Location = New System.Drawing.Point(43, 56)
        Me.LblPurchaseId.Name = "LblPurchaseId"
        Me.LblPurchaseId.Size = New System.Drawing.Size(113, 22)
        Me.LblPurchaseId.TabIndex = 59
        Me.LblPurchaseId.Text = "Purchase Id:"
        '
        'LblDealerName
        '
        Me.LblDealerName.AutoSize = True
        Me.LblDealerName.BackColor = System.Drawing.Color.Transparent
        Me.LblDealerName.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDealerName.ForeColor = System.Drawing.Color.Transparent
        Me.LblDealerName.Location = New System.Drawing.Point(43, 159)
        Me.LblDealerName.Name = "LblDealerName"
        Me.LblDealerName.Size = New System.Drawing.Size(123, 22)
        Me.LblDealerName.TabIndex = 60
        Me.LblDealerName.Text = "Dealer Name:"
        Me.LblDealerName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbldocdet
        '
        Me.lbldocdet.AutoSize = True
        Me.lbldocdet.BackColor = System.Drawing.Color.Transparent
        Me.lbldocdet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbldocdet.Font = New System.Drawing.Font("Palatino Linotype", 40.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldocdet.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.lbldocdet.Location = New System.Drawing.Point(401, -1)
        Me.lbldocdet.Name = "lbldocdet"
        Me.lbldocdet.Size = New System.Drawing.Size(251, 74)
        Me.lbldocdet.TabIndex = 133
        Me.lbldocdet.Text = "Purchase"
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
        Me.PnlCustNavigation.Location = New System.Drawing.Point(571, 76)
        Me.PnlCustNavigation.Name = "PnlCustNavigation"
        Me.PnlCustNavigation.Size = New System.Drawing.Size(445, 80)
        Me.PnlCustNavigation.TabIndex = 143
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
        Me.PnlCustOperations.Controls.Add(Me.btnClear)
        Me.PnlCustOperations.Controls.Add(Me.btnUpdate)
        Me.PnlCustOperations.Controls.Add(Me.btnAdd)
        Me.PnlCustOperations.Controls.Add(Me.btnDelete)
        Me.PnlCustOperations.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PnlCustOperations.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PnlCustOperations.Location = New System.Drawing.Point(571, 162)
        Me.PnlCustOperations.Name = "PnlCustOperations"
        Me.PnlCustOperations.Size = New System.Drawing.Size(445, 85)
        Me.PnlCustOperations.TabIndex = 142
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
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(119, 26)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(104, 38)
        Me.btnUpdate.TabIndex = 15
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
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
        Me.btnDelete.Location = New System.Drawing.Point(229, 27)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(97, 39)
        Me.btnDelete.TabIndex = 16
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'BtnAddPurDet
        '
        Me.BtnAddPurDet.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddPurDet.ForeColor = System.Drawing.Color.Navy
        Me.BtnAddPurDet.Location = New System.Drawing.Point(132, 389)
        Me.BtnAddPurDet.Name = "BtnAddPurDet"
        Me.BtnAddPurDet.Size = New System.Drawing.Size(317, 34)
        Me.BtnAddPurDet.TabIndex = 5
        Me.BtnAddPurDet.Text = "Add Purchase Details >>"
        Me.BtnAddPurDet.UseVisualStyleBackColor = True
        '
        'Purchase
        '
        Me.AcceptButton = Me.BtnAddPurDet
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1303, 746)
        Me.Controls.Add(Me.BtnAddPurDet)
        Me.Controls.Add(Me.PnlCustNavigation)
        Me.Controls.Add(Me.PnlCustOperations)
        Me.Controls.Add(Me.lbldocdet)
        Me.Controls.Add(Me.pnlPur)
        Me.Controls.Add(Me.pnlAmt)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Purchase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Purchase"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAmt.ResumeLayout(False)
        Me.pnlAmt.PerformLayout()
        Me.pnlPur.ResumeLayout(False)
        Me.pnlPur.PerformLayout()
        Me.PnlCustNavigation.ResumeLayout(False)
        Me.PnlCustOperations.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents pnlAmt As System.Windows.Forms.Panel
    Friend WithEvents TxtVATTax As System.Windows.Forms.TextBox
    Friend WithEvents LblPurAmt As System.Windows.Forms.Label
    Friend WithEvents TxtNetAmt As System.Windows.Forms.TextBox
    Friend WithEvents LblNetAmt As System.Windows.Forms.Label
    Friend WithEvents TxtPurAmt As System.Windows.Forms.TextBox
    Friend WithEvents LblVATTax As System.Windows.Forms.Label
    Friend WithEvents pnlPur As System.Windows.Forms.Panel
    Friend WithEvents CmbDealerName As System.Windows.Forms.ComboBox
    Friend WithEvents TxtPurchaseId As System.Windows.Forms.TextBox
    Friend WithEvents LblPurchaseId As System.Windows.Forms.Label
    Friend WithEvents LblDealerName As System.Windows.Forms.Label
    Friend WithEvents btnnewid As System.Windows.Forms.Button
    Friend WithEvents lbldocdet As System.Windows.Forms.Label
    Friend WithEvents PnlCustNavigation As System.Windows.Forms.Panel
    Friend WithEvents BtnNext As System.Windows.Forms.Button
    Friend WithEvents BtnLast As System.Windows.Forms.Button
    Friend WithEvents BtnPrev As System.Windows.Forms.Button
    Friend WithEvents BtnFirst As System.Windows.Forms.Button
    Friend WithEvents PnlCustOperations As System.Windows.Forms.Panel
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents dtpPurchase As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblPurDate As System.Windows.Forms.Label
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAddr As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtBillNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbPaidBy As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BtnAddPurDet As System.Windows.Forms.Button
End Class
