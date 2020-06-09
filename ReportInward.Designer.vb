<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportInward
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportInward))
        Me.lbldocdet = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnnewid = New System.Windows.Forms.Button
        Me.lblRInID = New System.Windows.Forms.Label
        Me.lblPatAddr = New System.Windows.Forms.Label
        Me.txtPatAddr = New System.Windows.Forms.TextBox
        Me.txtRInId = New System.Windows.Forms.TextBox
        Me.lblPatientName = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.lblDocNm = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.lstTest = New System.Windows.Forms.ListBox
        Me.txtDisease = New System.Windows.Forms.TextBox
        Me.lblDisease = New System.Windows.Forms.Label
        Me.DTPRprtDlvryDte = New System.Windows.Forms.DateTimePicker
        Me.cmbRcvBy = New System.Windows.Forms.ComboBox
        Me.txtRmarkByDr = New System.Windows.Forms.TextBox
        Me.lblRmarkByDr = New System.Windows.Forms.Label
        Me.lblRDeliverDte = New System.Windows.Forms.Label
        Me.lblRcvBY = New System.Windows.Forms.Label
        Me.txtDoc = New System.Windows.Forms.TextBox
        Me.cmbPatNm = New System.Windows.Forms.ComboBox
        Me.txtContact = New System.Windows.Forms.TextBox
        Me.dtpRInDte = New System.Windows.Forms.DateTimePicker
        Me.lblRIndate = New System.Windows.Forms.Label
        Me.lblContct = New System.Windows.Forms.Label
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.PatholabDBDataSet13 = New Pathology.patholabDBDataSet13
        Me.RInwrdBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RInwrdTableAdapter = New Pathology.patholabDBDataSet13TableAdapters.RInwrdTableAdapter
        Me.Panel1.SuspendLayout()
        Me.PnlCustNavigation.SuspendLayout()
        Me.PnlCustOperations.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatholabDBDataSet13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RInwrdBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbldocdet
        '
        Me.lbldocdet.AutoSize = True
        Me.lbldocdet.BackColor = System.Drawing.Color.Transparent
        Me.lbldocdet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbldocdet.Font = New System.Drawing.Font("Palatino Linotype", 40.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldocdet.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.lbldocdet.Location = New System.Drawing.Point(541, -1)
        Me.lbldocdet.Name = "lbldocdet"
        Me.lbldocdet.Size = New System.Drawing.Size(387, 74)
        Me.lbldocdet.TabIndex = 139
        Me.lbldocdet.Text = "Report Inward"
        '
        'btnnewid
        '
        Me.btnnewid.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnnewid.BackColor = System.Drawing.Color.Black
        Me.btnnewid.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnewid.ForeColor = System.Drawing.Color.White
        Me.btnnewid.Location = New System.Drawing.Point(285, 56)
        Me.btnnewid.Name = "btnnewid"
        Me.btnnewid.Size = New System.Drawing.Size(96, 36)
        Me.btnnewid.TabIndex = 134
        Me.btnnewid.Text = "New Id"
        Me.btnnewid.UseVisualStyleBackColor = False
        '
        'lblRInID
        '
        Me.lblRInID.AutoSize = True
        Me.lblRInID.BackColor = System.Drawing.Color.Transparent
        Me.lblRInID.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRInID.ForeColor = System.Drawing.Color.White
        Me.lblRInID.Location = New System.Drawing.Point(22, 64)
        Me.lblRInID.Name = "lblRInID"
        Me.lblRInID.Size = New System.Drawing.Size(63, 22)
        Me.lblRInID.TabIndex = 0
        Me.lblRInID.Text = "RInId:"
        '
        'lblPatAddr
        '
        Me.lblPatAddr.AutoSize = True
        Me.lblPatAddr.BackColor = System.Drawing.Color.Transparent
        Me.lblPatAddr.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatAddr.ForeColor = System.Drawing.Color.White
        Me.lblPatAddr.Location = New System.Drawing.Point(22, 208)
        Me.lblPatAddr.Name = "lblPatAddr"
        Me.lblPatAddr.Size = New System.Drawing.Size(108, 22)
        Me.lblPatAddr.TabIndex = 1
        Me.lblPatAddr.Text = "Pt. Address:"
        '
        'txtPatAddr
        '
        Me.txtPatAddr.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatAddr.Location = New System.Drawing.Point(167, 180)
        Me.txtPatAddr.Multiline = True
        Me.txtPatAddr.Name = "txtPatAddr"
        Me.txtPatAddr.Size = New System.Drawing.Size(214, 82)
        Me.txtPatAddr.TabIndex = 2
        '
        'txtRInId
        '
        Me.txtRInId.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRInId.Location = New System.Drawing.Point(167, 58)
        Me.txtRInId.Name = "txtRInId"
        Me.txtRInId.Size = New System.Drawing.Size(92, 29)
        Me.txtRInId.TabIndex = 0
        '
        'lblPatientName
        '
        Me.lblPatientName.AutoSize = True
        Me.lblPatientName.BackColor = System.Drawing.Color.Transparent
        Me.lblPatientName.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientName.ForeColor = System.Drawing.Color.White
        Me.lblPatientName.Location = New System.Drawing.Point(22, 128)
        Me.lblPatientName.Name = "lblPatientName"
        Me.lblPatientName.Size = New System.Drawing.Size(126, 22)
        Me.lblPatientName.TabIndex = 21
        Me.lblPatientName.Text = "Patient Name:"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(342, 643)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(158, 32)
        Me.TextBox1.TabIndex = 28
        '
        'lblDocNm
        '
        Me.lblDocNm.AutoSize = True
        Me.lblDocNm.BackColor = System.Drawing.Color.Transparent
        Me.lblDocNm.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocNm.ForeColor = System.Drawing.Color.White
        Me.lblDocNm.Location = New System.Drawing.Point(22, 344)
        Me.lblDocNm.Name = "lblDocNm"
        Me.lblDocNm.Size = New System.Drawing.Size(93, 22)
        Me.lblDocNm.TabIndex = 30
        Me.lblDocNm.Text = "Dr. Name:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lstTest)
        Me.Panel1.Controls.Add(Me.txtDisease)
        Me.Panel1.Controls.Add(Me.lblDisease)
        Me.Panel1.Controls.Add(Me.DTPRprtDlvryDte)
        Me.Panel1.Controls.Add(Me.cmbRcvBy)
        Me.Panel1.Controls.Add(Me.txtRmarkByDr)
        Me.Panel1.Controls.Add(Me.lblRmarkByDr)
        Me.Panel1.Controls.Add(Me.lblRDeliverDte)
        Me.Panel1.Controls.Add(Me.lblRcvBY)
        Me.Panel1.Controls.Add(Me.txtDoc)
        Me.Panel1.Controls.Add(Me.cmbPatNm)
        Me.Panel1.Controls.Add(Me.txtContact)
        Me.Panel1.Controls.Add(Me.dtpRInDte)
        Me.Panel1.Controls.Add(Me.lblRIndate)
        Me.Panel1.Controls.Add(Me.lblContct)
        Me.Panel1.Controls.Add(Me.btnnewid)
        Me.Panel1.Controls.Add(Me.lblDocNm)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.lblPatientName)
        Me.Panel1.Controls.Add(Me.txtRInId)
        Me.Panel1.Controls.Add(Me.txtPatAddr)
        Me.Panel1.Controls.Add(Me.lblPatAddr)
        Me.Panel1.Controls.Add(Me.lblRInID)
        Me.Panel1.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(10, 88)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(810, 457)
        Me.Panel1.TabIndex = 136
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(425, 208)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 22)
        Me.Label1.TabIndex = 149
        Me.Label1.Text = "Test Name:"
        '
        'lstTest
        '
        Me.lstTest.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTest.FormattingEnabled = True
        Me.lstTest.ItemHeight = 22
        Me.lstTest.Location = New System.Drawing.Point(574, 180)
        Me.lstTest.Name = "lstTest"
        Me.lstTest.ScrollAlwaysVisible = True
        Me.lstTest.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstTest.Size = New System.Drawing.Size(214, 114)
        Me.lstTest.TabIndex = 148
        '
        'txtDisease
        '
        Me.txtDisease.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisease.Location = New System.Drawing.Point(574, 125)
        Me.txtDisease.Name = "txtDisease"
        Me.txtDisease.Size = New System.Drawing.Size(214, 29)
        Me.txtDisease.TabIndex = 7
        '
        'lblDisease
        '
        Me.lblDisease.AutoSize = True
        Me.lblDisease.BackColor = System.Drawing.Color.Transparent
        Me.lblDisease.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisease.ForeColor = System.Drawing.Color.White
        Me.lblDisease.Location = New System.Drawing.Point(425, 132)
        Me.lblDisease.Name = "lblDisease"
        Me.lblDisease.Size = New System.Drawing.Size(78, 22)
        Me.lblDisease.TabIndex = 148
        Me.lblDisease.Text = "Disease:"
        '
        'DTPRprtDlvryDte
        '
        Me.DTPRprtDlvryDte.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPRprtDlvryDte.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPRprtDlvryDte.Location = New System.Drawing.Point(574, 63)
        Me.DTPRprtDlvryDte.Name = "DTPRprtDlvryDte"
        Me.DTPRprtDlvryDte.Size = New System.Drawing.Size(214, 29)
        Me.DTPRprtDlvryDte.TabIndex = 6
        '
        'cmbRcvBy
        '
        Me.cmbRcvBy.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRcvBy.FormattingEnabled = True
        Me.cmbRcvBy.Location = New System.Drawing.Point(574, 329)
        Me.cmbRcvBy.Name = "cmbRcvBy"
        Me.cmbRcvBy.Size = New System.Drawing.Size(214, 30)
        Me.cmbRcvBy.TabIndex = 9
        '
        'txtRmarkByDr
        '
        Me.txtRmarkByDr.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRmarkByDr.Location = New System.Drawing.Point(256, 387)
        Me.txtRmarkByDr.Multiline = True
        Me.txtRmarkByDr.Name = "txtRmarkByDr"
        Me.txtRmarkByDr.Size = New System.Drawing.Size(446, 56)
        Me.txtRmarkByDr.TabIndex = 10
        '
        'lblRmarkByDr
        '
        Me.lblRmarkByDr.AutoSize = True
        Me.lblRmarkByDr.BackColor = System.Drawing.Color.Transparent
        Me.lblRmarkByDr.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRmarkByDr.ForeColor = System.Drawing.Color.White
        Me.lblRmarkByDr.Location = New System.Drawing.Point(142, 402)
        Me.lblRmarkByDr.Name = "lblRmarkByDr"
        Me.lblRmarkByDr.Size = New System.Drawing.Size(82, 22)
        Me.lblRmarkByDr.TabIndex = 140
        Me.lblRmarkByDr.Text = "Remark:"
        '
        'lblRDeliverDte
        '
        Me.lblRDeliverDte.AutoSize = True
        Me.lblRDeliverDte.BackColor = System.Drawing.Color.Transparent
        Me.lblRDeliverDte.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRDeliverDte.ForeColor = System.Drawing.Color.White
        Me.lblRDeliverDte.Location = New System.Drawing.Point(425, 63)
        Me.lblRDeliverDte.Name = "lblRDeliverDte"
        Me.lblRDeliverDte.Size = New System.Drawing.Size(127, 22)
        Me.lblRDeliverDte.TabIndex = 142
        Me.lblRDeliverDte.Text = "Delivery Date:"
        '
        'lblRcvBY
        '
        Me.lblRcvBY.AutoSize = True
        Me.lblRcvBY.BackColor = System.Drawing.Color.Transparent
        Me.lblRcvBY.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRcvBY.ForeColor = System.Drawing.Color.White
        Me.lblRcvBY.Location = New System.Drawing.Point(425, 337)
        Me.lblRcvBY.Name = "lblRcvBY"
        Me.lblRcvBY.Size = New System.Drawing.Size(143, 22)
        Me.lblRcvBY.TabIndex = 141
        Me.lblRcvBY.Text = "Received By Dr:"
        '
        'txtDoc
        '
        Me.txtDoc.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDoc.Location = New System.Drawing.Point(167, 337)
        Me.txtDoc.Name = "txtDoc"
        Me.txtDoc.Size = New System.Drawing.Size(214, 29)
        Me.txtDoc.TabIndex = 4
        '
        'cmbPatNm
        '
        Me.cmbPatNm.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPatNm.FormattingEnabled = True
        Me.cmbPatNm.Location = New System.Drawing.Point(167, 122)
        Me.cmbPatNm.Name = "cmbPatNm"
        Me.cmbPatNm.Size = New System.Drawing.Size(214, 30)
        Me.cmbPatNm.TabIndex = 1
        '
        'txtContact
        '
        Me.txtContact.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.Location = New System.Drawing.Point(167, 282)
        Me.txtContact.MaxLength = 10
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(214, 29)
        Me.txtContact.TabIndex = 3
        '
        'dtpRInDte
        '
        Me.dtpRInDte.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpRInDte.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpRInDte.Location = New System.Drawing.Point(598, 7)
        Me.dtpRInDte.Name = "dtpRInDte"
        Me.dtpRInDte.Size = New System.Drawing.Size(190, 29)
        Me.dtpRInDte.TabIndex = 5
        '
        'lblRIndate
        '
        Me.lblRIndate.AutoSize = True
        Me.lblRIndate.BackColor = System.Drawing.Color.Transparent
        Me.lblRIndate.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRIndate.ForeColor = System.Drawing.Color.White
        Me.lblRIndate.Location = New System.Drawing.Point(525, 7)
        Me.lblRIndate.Name = "lblRIndate"
        Me.lblRIndate.Size = New System.Drawing.Size(54, 22)
        Me.lblRIndate.TabIndex = 41
        Me.lblRIndate.Text = "Date:"
        '
        'lblContct
        '
        Me.lblContct.AutoSize = True
        Me.lblContct.BackColor = System.Drawing.Color.Transparent
        Me.lblContct.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContct.ForeColor = System.Drawing.Color.White
        Me.lblContct.Location = New System.Drawing.Point(21, 282)
        Me.lblContct.Name = "lblContct"
        Me.lblContct.Size = New System.Drawing.Size(109, 22)
        Me.lblContct.TabIndex = 40
        Me.lblContct.Text = "Contact No:"
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
        Me.PnlCustNavigation.Location = New System.Drawing.Point(826, 88)
        Me.PnlCustNavigation.Name = "PnlCustNavigation"
        Me.PnlCustNavigation.Size = New System.Drawing.Size(461, 91)
        Me.PnlCustNavigation.TabIndex = 145
        '
        'BtnNext
        '
        Me.BtnNext.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNext.Location = New System.Drawing.Point(235, 22)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(97, 39)
        Me.BtnNext.TabIndex = 13
        Me.BtnNext.Text = "Next>>"
        Me.BtnNext.UseVisualStyleBackColor = True
        '
        'BtnLast
        '
        Me.BtnLast.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLast.Location = New System.Drawing.Point(338, 22)
        Me.BtnLast.Name = "BtnLast"
        Me.BtnLast.Size = New System.Drawing.Size(101, 39)
        Me.BtnLast.TabIndex = 14
        Me.BtnLast.Text = "Last"
        Me.BtnLast.UseVisualStyleBackColor = True
        '
        'BtnPrev
        '
        Me.BtnPrev.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrev.Location = New System.Drawing.Point(127, 22)
        Me.BtnPrev.Name = "BtnPrev"
        Me.BtnPrev.Size = New System.Drawing.Size(102, 39)
        Me.BtnPrev.TabIndex = 12
        Me.BtnPrev.Text = "<<Prev"
        Me.BtnPrev.UseVisualStyleBackColor = True
        '
        'BtnFirst
        '
        Me.BtnFirst.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFirst.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnFirst.Location = New System.Drawing.Point(16, 22)
        Me.BtnFirst.Name = "BtnFirst"
        Me.BtnFirst.Size = New System.Drawing.Size(105, 39)
        Me.BtnFirst.TabIndex = 11
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
        Me.PnlCustOperations.Location = New System.Drawing.Point(826, 178)
        Me.PnlCustOperations.Name = "PnlCustOperations"
        Me.PnlCustOperations.Size = New System.Drawing.Size(461, 89)
        Me.PnlCustOperations.TabIndex = 144
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(338, 26)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(101, 38)
        Me.btnClear.TabIndex = 18
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(127, 26)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(102, 38)
        Me.btnUpdate.TabIndex = 16
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(16, 26)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(105, 38)
        Me.btnAdd.TabIndex = 15
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(235, 26)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(97, 38)
        Me.btnDelete.TabIndex = 17
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(826, 270)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(528, 244)
        Me.DataGridView1.TabIndex = 146
        '
        'PatholabDBDataSet13
        '
        Me.PatholabDBDataSet13.DataSetName = "patholabDBDataSet13"
        Me.PatholabDBDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RInwrdBindingSource
        '
        Me.RInwrdBindingSource.DataMember = "RInwrd"
        Me.RInwrdBindingSource.DataSource = Me.PatholabDBDataSet13
        '
        'RInwrdTableAdapter
        '
        Me.RInwrdTableAdapter.ClearBeforeFill = True
        '
        'ReportInward
        '
        Me.AcceptButton = Me.btnnewid
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1366, 746)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.PnlCustNavigation)
        Me.Controls.Add(Me.PnlCustOperations)
        Me.Controls.Add(Me.lbldocdet)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ReportInward"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ReportInward"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PnlCustNavigation.ResumeLayout(False)
        Me.PnlCustOperations.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatholabDBDataSet13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RInwrdBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbldocdet As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnnewid As System.Windows.Forms.Button
    Friend WithEvents lblRInID As System.Windows.Forms.Label
    Friend WithEvents lblPatAddr As System.Windows.Forms.Label
    Friend WithEvents txtPatAddr As System.Windows.Forms.TextBox
    Friend WithEvents txtRInId As System.Windows.Forms.TextBox
    Friend WithEvents lblPatientName As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lblDocNm As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents dtpRInDte As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblRIndate As System.Windows.Forms.Label
    Friend WithEvents lblContct As System.Windows.Forms.Label
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
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents cmbPatNm As System.Windows.Forms.ComboBox
    Friend WithEvents txtDoc As System.Windows.Forms.TextBox
    Friend WithEvents DTPRprtDlvryDte As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbRcvBy As System.Windows.Forms.ComboBox
    Friend WithEvents txtRmarkByDr As System.Windows.Forms.TextBox
    Friend WithEvents lblRDeliverDte As System.Windows.Forms.Label
    Friend WithEvents lblRcvBY As System.Windows.Forms.Label
    Friend WithEvents lblRmarkByDr As System.Windows.Forms.Label
    Friend WithEvents txtDisease As System.Windows.Forms.TextBox
    Friend WithEvents lblDisease As System.Windows.Forms.Label
    Friend WithEvents PatholabDBDataSet13 As Pathology.patholabDBDataSet13
    Friend WithEvents RInwrdBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RInwrdTableAdapter As Pathology.patholabDBDataSet13TableAdapters.RInwrdTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstTest As System.Windows.Forms.ListBox
End Class
