<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExpences
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmExpences))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label3 = New System.Windows.Forms.Label
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.CmbPaidby = New System.Windows.Forms.ComboBox
        Me.LblPaid_By = New System.Windows.Forms.Label
        Me.dtpExpDate = New System.Windows.Forms.DateTimePicker
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.rdbCsh = New System.Windows.Forms.RadioButton
        Me.rdbChq = New System.Windows.Forms.RadioButton
        Me.txtAmt = New System.Windows.Forms.TextBox
        Me.txtExpDetl = New System.Windows.Forms.TextBox
        Me.txtExpTo = New System.Windows.Forms.TextBox
        Me.txtExpId = New System.Windows.Forms.TextBox
        Me.btnnewid = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblamt = New System.Windows.Forms.Label
        Me.lblpaytype = New System.Windows.Forms.Label
        Me.lblto = New System.Windows.Forms.Label
        Me.lbldet = New System.Windows.Forms.Label
        Me.lbldate = New System.Windows.Forms.Label
        Me.lblexpenceid = New System.Windows.Forms.Label
        Me.pnlChqDetail = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpChqDate = New System.Windows.Forms.DateTimePicker
        Me.txtBranch = New System.Windows.Forms.TextBox
        Me.lblbank = New System.Windows.Forms.Label
        Me.txtBnk = New System.Windows.Forms.TextBox
        Me.lblbranch = New System.Windows.Forms.Label
        Me.txtChqNo = New System.Windows.Forms.TextBox
        Me.lblcheqdate = New System.Windows.Forms.Label
        Me.lblcheqno = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.ExpenceTblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PatholabDBDataSet6 = New Pathology.patholabDBDataSet6
        Me.ExpenceTblTableAdapter = New Pathology.patholabDBDataSet6TableAdapters.ExpenceTblTableAdapter
        Me.lblLnkPrint = New System.Windows.Forms.LinkLabel
        Me.PnlCustNavigation.SuspendLayout()
        Me.PnlCustOperations.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnlChqDetail.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExpenceTblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatholabDBDataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(421, 229)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 143
        '
        'lbldocdet
        '
        Me.lbldocdet.AutoSize = True
        Me.lbldocdet.BackColor = System.Drawing.Color.Transparent
        Me.lbldocdet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbldocdet.Font = New System.Drawing.Font("Palatino Linotype", 40.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldocdet.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.lbldocdet.Location = New System.Drawing.Point(346, -10)
        Me.lbldocdet.Name = "lbldocdet"
        Me.lbldocdet.Size = New System.Drawing.Size(439, 74)
        Me.lbldocdet.TabIndex = 147
        Me.lbldocdet.Text = "Expences Details"
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
        Me.PnlCustNavigation.Location = New System.Drawing.Point(696, 91)
        Me.PnlCustNavigation.Name = "PnlCustNavigation"
        Me.PnlCustNavigation.Size = New System.Drawing.Size(463, 80)
        Me.PnlCustNavigation.TabIndex = 149
        '
        'BtnNext
        '
        Me.BtnNext.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNext.Location = New System.Drawing.Point(241, 25)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(97, 39)
        Me.BtnNext.TabIndex = 12
        Me.BtnNext.Text = "Next>>"
        Me.BtnNext.UseVisualStyleBackColor = True
        '
        'BtnLast
        '
        Me.BtnLast.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLast.Location = New System.Drawing.Point(344, 25)
        Me.BtnLast.Name = "BtnLast"
        Me.BtnLast.Size = New System.Drawing.Size(91, 39)
        Me.BtnLast.TabIndex = 13
        Me.BtnLast.Text = "Last"
        Me.BtnLast.UseVisualStyleBackColor = True
        '
        'BtnPrev
        '
        Me.BtnPrev.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrev.Location = New System.Drawing.Point(131, 25)
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
        Me.BtnFirst.Location = New System.Drawing.Point(25, 25)
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
        Me.PnlCustOperations.Location = New System.Drawing.Point(696, 177)
        Me.PnlCustOperations.Name = "PnlCustOperations"
        Me.PnlCustOperations.Size = New System.Drawing.Size(463, 85)
        Me.PnlCustOperations.TabIndex = 148
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(344, 25)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(91, 38)
        Me.btnClear.TabIndex = 17
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(131, 25)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(104, 38)
        Me.btnUpdate.TabIndex = 15
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(25, 25)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(103, 38)
        Me.btnAdd.TabIndex = 14
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(241, 25)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(97, 38)
        Me.btnDelete.TabIndex = 16
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.CmbPaidby)
        Me.Panel1.Controls.Add(Me.LblPaid_By)
        Me.Panel1.Controls.Add(Me.dtpExpDate)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.txtAmt)
        Me.Panel1.Controls.Add(Me.txtExpDetl)
        Me.Panel1.Controls.Add(Me.txtExpTo)
        Me.Panel1.Controls.Add(Me.txtExpId)
        Me.Panel1.Controls.Add(Me.btnnewid)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.lblamt)
        Me.Panel1.Controls.Add(Me.lblpaytype)
        Me.Panel1.Controls.Add(Me.lblto)
        Me.Panel1.Controls.Add(Me.lbldet)
        Me.Panel1.Controls.Add(Me.lbldate)
        Me.Panel1.Controls.Add(Me.lblexpenceid)
        Me.Panel1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(47, 67)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(643, 316)
        Me.Panel1.TabIndex = 144
        '
        'CmbPaidby
        '
        Me.CmbPaidby.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbPaidby.ForeColor = System.Drawing.Color.Black
        Me.CmbPaidby.FormattingEnabled = True
        Me.CmbPaidby.Location = New System.Drawing.Point(226, 277)
        Me.CmbPaidby.Name = "CmbPaidby"
        Me.CmbPaidby.Size = New System.Drawing.Size(200, 30)
        Me.CmbPaidby.TabIndex = 5
        '
        'LblPaid_By
        '
        Me.LblPaid_By.AutoSize = True
        Me.LblPaid_By.BackColor = System.Drawing.Color.Transparent
        Me.LblPaid_By.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPaid_By.ForeColor = System.Drawing.Color.White
        Me.LblPaid_By.Location = New System.Drawing.Point(56, 280)
        Me.LblPaid_By.Name = "LblPaid_By"
        Me.LblPaid_By.Size = New System.Drawing.Size(79, 22)
        Me.LblPaid_By.TabIndex = 140
        Me.LblPaid_By.Text = "Paid By:"
        '
        'dtpExpDate
        '
        Me.dtpExpDate.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpExpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpExpDate.Location = New System.Drawing.Point(489, 6)
        Me.dtpExpDate.Name = "dtpExpDate"
        Me.dtpExpDate.Size = New System.Drawing.Size(126, 29)
        Me.dtpExpDate.TabIndex = 11
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.rdbCsh)
        Me.Panel2.Controls.Add(Me.rdbChq)
        Me.Panel2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(226, 211)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(287, 51)
        Me.Panel2.TabIndex = 4
        '
        'rdbCsh
        '
        Me.rdbCsh.AutoSize = True
        Me.rdbCsh.BackColor = System.Drawing.Color.Transparent
        Me.rdbCsh.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rdbCsh.Location = New System.Drawing.Point(172, 15)
        Me.rdbCsh.Name = "rdbCsh"
        Me.rdbCsh.Size = New System.Drawing.Size(97, 26)
        Me.rdbCsh.TabIndex = 1
        Me.rdbCsh.TabStop = True
        Me.rdbCsh.Text = "By Cash"
        Me.rdbCsh.UseVisualStyleBackColor = False
        '
        'rdbChq
        '
        Me.rdbChq.AutoSize = True
        Me.rdbChq.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rdbChq.Location = New System.Drawing.Point(3, 15)
        Me.rdbChq.Name = "rdbChq"
        Me.rdbChq.Size = New System.Drawing.Size(150, 26)
        Me.rdbChq.TabIndex = 0
        Me.rdbChq.TabStop = True
        Me.rdbChq.Text = "By DD/Cheque"
        Me.rdbChq.UseVisualStyleBackColor = True
        '
        'txtAmt
        '
        Me.txtAmt.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmt.ForeColor = System.Drawing.Color.Black
        Me.txtAmt.Location = New System.Drawing.Point(226, 176)
        Me.txtAmt.Name = "txtAmt"
        Me.txtAmt.Size = New System.Drawing.Size(200, 29)
        Me.txtAmt.TabIndex = 3
        '
        'txtExpDetl
        '
        Me.txtExpDetl.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExpDetl.ForeColor = System.Drawing.Color.Black
        Me.txtExpDetl.Location = New System.Drawing.Point(226, 131)
        Me.txtExpDetl.Multiline = True
        Me.txtExpDetl.Name = "txtExpDetl"
        Me.txtExpDetl.Size = New System.Drawing.Size(287, 39)
        Me.txtExpDetl.TabIndex = 2
        '
        'txtExpTo
        '
        Me.txtExpTo.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExpTo.ForeColor = System.Drawing.Color.Black
        Me.txtExpTo.Location = New System.Drawing.Point(226, 92)
        Me.txtExpTo.Name = "txtExpTo"
        Me.txtExpTo.Size = New System.Drawing.Size(200, 29)
        Me.txtExpTo.TabIndex = 1
        '
        'txtExpId
        '
        Me.txtExpId.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExpId.ForeColor = System.Drawing.Color.Black
        Me.txtExpId.Location = New System.Drawing.Point(226, 44)
        Me.txtExpId.Name = "txtExpId"
        Me.txtExpId.Size = New System.Drawing.Size(91, 29)
        Me.txtExpId.TabIndex = 0
        '
        'btnnewid
        '
        Me.btnnewid.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnnewid.BackColor = System.Drawing.Color.Black
        Me.btnnewid.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnewid.ForeColor = System.Drawing.Color.White
        Me.btnnewid.Location = New System.Drawing.Point(336, 37)
        Me.btnnewid.Name = "btnnewid"
        Me.btnnewid.Size = New System.Drawing.Size(90, 41)
        Me.btnnewid.TabIndex = 138
        Me.btnnewid.Text = "New Id"
        Me.btnnewid.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(293, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 22)
        Me.Label8.TabIndex = 13
        '
        'lblamt
        '
        Me.lblamt.AutoSize = True
        Me.lblamt.BackColor = System.Drawing.Color.Transparent
        Me.lblamt.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblamt.ForeColor = System.Drawing.Color.White
        Me.lblamt.Location = New System.Drawing.Point(54, 183)
        Me.lblamt.Name = "lblamt"
        Me.lblamt.Size = New System.Drawing.Size(79, 22)
        Me.lblamt.TabIndex = 12
        Me.lblamt.Text = "Amount:"
        '
        'lblpaytype
        '
        Me.lblpaytype.AutoSize = True
        Me.lblpaytype.BackColor = System.Drawing.Color.Transparent
        Me.lblpaytype.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpaytype.ForeColor = System.Drawing.Color.White
        Me.lblpaytype.Location = New System.Drawing.Point(54, 232)
        Me.lblpaytype.Name = "lblpaytype"
        Me.lblpaytype.Size = New System.Drawing.Size(131, 22)
        Me.lblpaytype.TabIndex = 11
        Me.lblpaytype.Text = "Payment Type:"
        '
        'lblto
        '
        Me.lblto.AutoSize = True
        Me.lblto.BackColor = System.Drawing.Color.Transparent
        Me.lblto.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblto.ForeColor = System.Drawing.Color.White
        Me.lblto.Location = New System.Drawing.Point(56, 97)
        Me.lblto.Name = "lblto"
        Me.lblto.Size = New System.Drawing.Size(36, 22)
        Me.lblto.TabIndex = 10
        Me.lblto.Text = "To:"
        '
        'lbldet
        '
        Me.lbldet.AutoSize = True
        Me.lbldet.BackColor = System.Drawing.Color.Transparent
        Me.lbldet.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldet.ForeColor = System.Drawing.Color.White
        Me.lbldet.Location = New System.Drawing.Point(56, 135)
        Me.lbldet.Name = "lbldet"
        Me.lbldet.Size = New System.Drawing.Size(72, 22)
        Me.lbldet.TabIndex = 9
        Me.lbldet.Text = "Details:"
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.BackColor = System.Drawing.Color.Transparent
        Me.lbldate.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.ForeColor = System.Drawing.Color.White
        Me.lbldate.Location = New System.Drawing.Point(418, 6)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(54, 22)
        Me.lbldate.TabIndex = 8
        Me.lbldate.Text = "Date:"
        '
        'lblexpenceid
        '
        Me.lblexpenceid.AutoSize = True
        Me.lblexpenceid.BackColor = System.Drawing.Color.Transparent
        Me.lblexpenceid.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblexpenceid.ForeColor = System.Drawing.Color.White
        Me.lblexpenceid.Location = New System.Drawing.Point(56, 47)
        Me.lblexpenceid.Name = "lblexpenceid"
        Me.lblexpenceid.Size = New System.Drawing.Size(106, 22)
        Me.lblexpenceid.TabIndex = 7
        Me.lblexpenceid.Text = "Expence Id:"
        '
        'pnlChqDetail
        '
        Me.pnlChqDetail.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlChqDetail.BackgroundImage = Global.Pathology.My.Resources.Resources.MdiImage
        Me.pnlChqDetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlChqDetail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlChqDetail.Controls.Add(Me.Label1)
        Me.pnlChqDetail.Controls.Add(Me.dtpChqDate)
        Me.pnlChqDetail.Controls.Add(Me.txtBranch)
        Me.pnlChqDetail.Controls.Add(Me.lblbank)
        Me.pnlChqDetail.Controls.Add(Me.txtBnk)
        Me.pnlChqDetail.Controls.Add(Me.lblbranch)
        Me.pnlChqDetail.Controls.Add(Me.txtChqNo)
        Me.pnlChqDetail.Controls.Add(Me.lblcheqdate)
        Me.pnlChqDetail.Controls.Add(Me.lblcheqno)
        Me.pnlChqDetail.Font = New System.Drawing.Font("Times New Roman", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlChqDetail.Location = New System.Drawing.Point(47, 382)
        Me.pnlChqDetail.Name = "pnlChqDetail"
        Me.pnlChqDetail.Size = New System.Drawing.Size(645, 217)
        Me.pnlChqDetail.TabIndex = 145
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 26.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label1.Location = New System.Drawing.Point(188, -6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(225, 47)
        Me.Label1.TabIndex = 150
        Me.Label1.Text = "Bank Details"
        '
        'dtpChqDate
        '
        Me.dtpChqDate.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpChqDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpChqDate.Location = New System.Drawing.Point(228, 174)
        Me.dtpChqDate.Name = "dtpChqDate"
        Me.dtpChqDate.Size = New System.Drawing.Size(290, 29)
        Me.dtpChqDate.TabIndex = 9
        '
        'txtBranch
        '
        Me.txtBranch.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBranch.Location = New System.Drawing.Point(228, 85)
        Me.txtBranch.Name = "txtBranch"
        Me.txtBranch.Size = New System.Drawing.Size(290, 29)
        Me.txtBranch.TabIndex = 7
        '
        'lblbank
        '
        Me.lblbank.AutoSize = True
        Me.lblbank.BackColor = System.Drawing.Color.Transparent
        Me.lblbank.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbank.ForeColor = System.Drawing.Color.White
        Me.lblbank.Location = New System.Drawing.Point(58, 47)
        Me.lblbank.Name = "lblbank"
        Me.lblbank.Size = New System.Drawing.Size(59, 22)
        Me.lblbank.TabIndex = 28
        Me.lblbank.Text = "Bank:"
        '
        'txtBnk
        '
        Me.txtBnk.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBnk.Location = New System.Drawing.Point(228, 47)
        Me.txtBnk.Name = "txtBnk"
        Me.txtBnk.Size = New System.Drawing.Size(290, 29)
        Me.txtBnk.TabIndex = 6
        '
        'lblbranch
        '
        Me.lblbranch.AutoSize = True
        Me.lblbranch.BackColor = System.Drawing.Color.Transparent
        Me.lblbranch.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbranch.ForeColor = System.Drawing.Color.White
        Me.lblbranch.Location = New System.Drawing.Point(58, 88)
        Me.lblbranch.Name = "lblbranch"
        Me.lblbranch.Size = New System.Drawing.Size(75, 22)
        Me.lblbranch.TabIndex = 29
        Me.lblbranch.Text = "Branch:"
        '
        'txtChqNo
        '
        Me.txtChqNo.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChqNo.Location = New System.Drawing.Point(228, 127)
        Me.txtChqNo.Name = "txtChqNo"
        Me.txtChqNo.Size = New System.Drawing.Size(290, 29)
        Me.txtChqNo.TabIndex = 8
        '
        'lblcheqdate
        '
        Me.lblcheqdate.AutoSize = True
        Me.lblcheqdate.BackColor = System.Drawing.Color.Transparent
        Me.lblcheqdate.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcheqdate.ForeColor = System.Drawing.Color.White
        Me.lblcheqdate.Location = New System.Drawing.Point(58, 174)
        Me.lblcheqdate.Name = "lblcheqdate"
        Me.lblcheqdate.Size = New System.Drawing.Size(154, 22)
        Me.lblcheqdate.TabIndex = 1
        Me.lblcheqdate.Text = "DD/Cheque Date:"
        '
        'lblcheqno
        '
        Me.lblcheqno.AutoSize = True
        Me.lblcheqno.BackColor = System.Drawing.Color.Transparent
        Me.lblcheqno.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcheqno.ForeColor = System.Drawing.Color.White
        Me.lblcheqno.Location = New System.Drawing.Point(58, 134)
        Me.lblcheqno.Name = "lblcheqno"
        Me.lblcheqno.Size = New System.Drawing.Size(139, 22)
        Me.lblcheqno.TabIndex = 0
        Me.lblcheqno.Text = "DD/Cheque No:"
        '
        'DataGridView1
        '
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(696, 277)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(526, 322)
        Me.DataGridView1.TabIndex = 146
        '
        'ExpenceTblBindingSource
        '
        Me.ExpenceTblBindingSource.DataMember = "ExpenceTbl"
        Me.ExpenceTblBindingSource.DataSource = Me.PatholabDBDataSet6
        '
        'PatholabDBDataSet6
        '
        Me.PatholabDBDataSet6.DataSetName = "patholabDBDataSet6"
        Me.PatholabDBDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ExpenceTblTableAdapter
        '
        Me.ExpenceTblTableAdapter.ClearBeforeFill = True
        '
        'lblLnkPrint
        '
        Me.lblLnkPrint.AutoSize = True
        Me.lblLnkPrint.BackColor = System.Drawing.Color.Lavender
        Me.lblLnkPrint.Font = New System.Drawing.Font("Perpetua Titling MT", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLnkPrint.ForeColor = System.Drawing.Color.White
        Me.lblLnkPrint.Location = New System.Drawing.Point(913, 56)
        Me.lblLnkPrint.Name = "lblLnkPrint"
        Me.lblLnkPrint.Size = New System.Drawing.Size(105, 32)
        Me.lblLnkPrint.TabIndex = 168
        Me.lblLnkPrint.TabStop = True
        Me.lblLnkPrint.Text = "Print"
        '
        'frmExpences
        '
        Me.AcceptButton = Me.btnnewid
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1303, 746)
        Me.Controls.Add(Me.lblLnkPrint)
        Me.Controls.Add(Me.PnlCustNavigation)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.PnlCustOperations)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbldocdet)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlChqDetail)
        Me.Name = "frmExpences"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmExpences"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PnlCustNavigation.ResumeLayout(False)
        Me.PnlCustOperations.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.pnlChqDetail.ResumeLayout(False)
        Me.pnlChqDetail.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExpenceTblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatholabDBDataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PnlCustNavigation As System.Windows.Forms.Panel
    Friend WithEvents BtnNext As System.Windows.Forms.Button
    Friend WithEvents BtnLast As System.Windows.Forms.Button
    Friend WithEvents BtnPrev As System.Windows.Forms.Button
    Friend WithEvents BtnFirst As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents dtpChqDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtBranch As System.Windows.Forms.TextBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents PnlCustOperations As System.Windows.Forms.Panel
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents txtBnk As System.Windows.Forms.TextBox
    Friend WithEvents lblbank As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents LblPaid_By As System.Windows.Forms.Label
    Friend WithEvents dtpExpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents CmbPaidby As System.Windows.Forms.ComboBox
    Friend WithEvents rdbChq As System.Windows.Forms.RadioButton
    Friend WithEvents lblcheqdate As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents rdbCsh As System.Windows.Forms.RadioButton
    Friend WithEvents txtAmt As System.Windows.Forms.TextBox
    Friend WithEvents txtExpDetl As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtExpTo As System.Windows.Forms.TextBox
    Friend WithEvents lbldocdet As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtExpId As System.Windows.Forms.TextBox
    Friend WithEvents btnnewid As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblamt As System.Windows.Forms.Label
    Friend WithEvents lblpaytype As System.Windows.Forms.Label
    Friend WithEvents lblto As System.Windows.Forms.Label
    Friend WithEvents lbldet As System.Windows.Forms.Label
    Friend WithEvents lbldate As System.Windows.Forms.Label
    Friend WithEvents lblexpenceid As System.Windows.Forms.Label
    Friend WithEvents lblbranch As System.Windows.Forms.Label
    Friend WithEvents pnlChqDetail As System.Windows.Forms.Panel
    Friend WithEvents txtChqNo As System.Windows.Forms.TextBox
    Friend WithEvents lblcheqno As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PatholabDBDataSet6 As Pathology.patholabDBDataSet6
    Friend WithEvents ExpenceTblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ExpenceTblTableAdapter As Pathology.patholabDBDataSet6TableAdapters.ExpenceTblTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblLnkPrint As System.Windows.Forms.LinkLabel
End Class
