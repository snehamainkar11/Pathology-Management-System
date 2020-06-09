<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportForward
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportForward))
        Me.btnnewid = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lbldocdet = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtRcvBy = New System.Windows.Forms.TextBox
        Me.lstTest = New System.Windows.Forms.ListBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtRmarkByDr = New System.Windows.Forms.TextBox
        Me.txtDises = New System.Windows.Forms.TextBox
        Me.lblRmarkByDr = New System.Windows.Forms.Label
        Me.txtDocNm = New System.Windows.Forms.TextBox
        Me.txtPatNm = New System.Windows.Forms.TextBox
        Me.dtpRprtDlvryDte = New System.Windows.Forms.DateTimePicker
        Me.lblRDeliverDte = New System.Windows.Forms.Label
        Me.txtContact = New System.Windows.Forms.TextBox
        Me.lblContct = New System.Windows.Forms.Label
        Me.dtpRFDate = New System.Windows.Forms.DateTimePicker
        Me.LblDate = New System.Windows.Forms.Label
        Me.txtFrwdCntct = New System.Windows.Forms.TextBox
        Me.txtFrwdLbAddr = New System.Windows.Forms.TextBox
        Me.lblFrwdCntct = New System.Windows.Forms.Label
        Me.txtFrwdToLb = New System.Windows.Forms.TextBox
        Me.txtFrwdRsn = New System.Windows.Forms.TextBox
        Me.lblFrwdToLb = New System.Windows.Forms.Label
        Me.lblFrwdLbAddr = New System.Windows.Forms.Label
        Me.lblFrwdRsn = New System.Windows.Forms.Label
        Me.cmbRInId = New System.Windows.Forms.ComboBox
        Me.txtRFId = New System.Windows.Forms.TextBox
        Me.lblRFId = New System.Windows.Forms.Label
        Me.lblDocNm = New System.Windows.Forms.Label
        Me.lblDisease = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.lblPatientName = New System.Windows.Forms.Label
        Me.txtPatAddr = New System.Windows.Forms.TextBox
        Me.lblRcvBY = New System.Windows.Forms.Label
        Me.lblPatAddr = New System.Windows.Forms.Label
        Me.lblRInID = New System.Windows.Forms.Label
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
        Me.lblLnkPrint = New System.Windows.Forms.LinkLabel
        Me.Panel1.SuspendLayout()
        Me.PnlCustOperations.SuspendLayout()
        Me.PnlCustNavigation.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnnewid
        '
        Me.btnnewid.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnnewid.BackColor = System.Drawing.Color.Black
        Me.btnnewid.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnewid.ForeColor = System.Drawing.Color.White
        Me.btnnewid.Location = New System.Drawing.Point(293, 64)
        Me.btnnewid.Name = "btnnewid"
        Me.btnnewid.Size = New System.Drawing.Size(97, 35)
        Me.btnnewid.TabIndex = 140
        Me.btnnewid.Text = "New Id"
        Me.btnnewid.UseVisualStyleBackColor = False
        '
        'lbldocdet
        '
        Me.lbldocdet.AutoSize = True
        Me.lbldocdet.BackColor = System.Drawing.Color.Transparent
        Me.lbldocdet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbldocdet.Font = New System.Drawing.Font("Palatino Linotype", 40.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldocdet.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.lbldocdet.Location = New System.Drawing.Point(346, -2)
        Me.lbldocdet.Name = "lbldocdet"
        Me.lbldocdet.Size = New System.Drawing.Size(417, 74)
        Me.lbldocdet.TabIndex = 145
        Me.lbldocdet.Text = "Report Forward"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.txtRcvBy)
        Me.Panel1.Controls.Add(Me.lstTest)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtRmarkByDr)
        Me.Panel1.Controls.Add(Me.txtDises)
        Me.Panel1.Controls.Add(Me.lblRmarkByDr)
        Me.Panel1.Controls.Add(Me.txtDocNm)
        Me.Panel1.Controls.Add(Me.txtPatNm)
        Me.Panel1.Controls.Add(Me.dtpRprtDlvryDte)
        Me.Panel1.Controls.Add(Me.lblRDeliverDte)
        Me.Panel1.Controls.Add(Me.txtContact)
        Me.Panel1.Controls.Add(Me.lblContct)
        Me.Panel1.Controls.Add(Me.dtpRFDate)
        Me.Panel1.Controls.Add(Me.LblDate)
        Me.Panel1.Controls.Add(Me.txtFrwdCntct)
        Me.Panel1.Controls.Add(Me.txtFrwdLbAddr)
        Me.Panel1.Controls.Add(Me.lblFrwdCntct)
        Me.Panel1.Controls.Add(Me.txtFrwdToLb)
        Me.Panel1.Controls.Add(Me.btnnewid)
        Me.Panel1.Controls.Add(Me.txtFrwdRsn)
        Me.Panel1.Controls.Add(Me.lblFrwdToLb)
        Me.Panel1.Controls.Add(Me.lblFrwdLbAddr)
        Me.Panel1.Controls.Add(Me.lblFrwdRsn)
        Me.Panel1.Controls.Add(Me.cmbRInId)
        Me.Panel1.Controls.Add(Me.txtRFId)
        Me.Panel1.Controls.Add(Me.lblRFId)
        Me.Panel1.Controls.Add(Me.lblDocNm)
        Me.Panel1.Controls.Add(Me.lblDisease)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.lblPatientName)
        Me.Panel1.Controls.Add(Me.txtPatAddr)
        Me.Panel1.Controls.Add(Me.lblRcvBY)
        Me.Panel1.Controls.Add(Me.lblPatAddr)
        Me.Panel1.Controls.Add(Me.lblRInID)
        Me.Panel1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(14, 94)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(839, 527)
        Me.Panel1.TabIndex = 146
        '
        'txtRcvBy
        '
        Me.txtRcvBy.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRcvBy.Location = New System.Drawing.Point(600, 121)
        Me.txtRcvBy.Name = "txtRcvBy"
        Me.txtRcvBy.Size = New System.Drawing.Size(197, 29)
        Me.txtRcvBy.TabIndex = 9
        '
        'lstTest
        '
        Me.lstTest.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTest.FormattingEnabled = True
        Me.lstTest.ItemHeight = 22
        Me.lstTest.Location = New System.Drawing.Point(179, 432)
        Me.lstTest.Name = "lstTest"
        Me.lstTest.ScrollAlwaysVisible = True
        Me.lstTest.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstTest.Size = New System.Drawing.Size(210, 70)
        Me.lstTest.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(26, 445)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 22)
        Me.Label1.TabIndex = 154
        Me.Label1.Text = "Test Name:"
        '
        'txtRmarkByDr
        '
        Me.txtRmarkByDr.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRmarkByDr.Location = New System.Drawing.Point(600, 164)
        Me.txtRmarkByDr.Multiline = True
        Me.txtRmarkByDr.Name = "txtRmarkByDr"
        Me.txtRmarkByDr.Size = New System.Drawing.Size(197, 40)
        Me.txtRmarkByDr.TabIndex = 10
        '
        'txtDises
        '
        Me.txtDises.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDises.Location = New System.Drawing.Point(179, 371)
        Me.txtDises.Name = "txtDises"
        Me.txtDises.Size = New System.Drawing.Size(212, 29)
        Me.txtDises.TabIndex = 6
        '
        'lblRmarkByDr
        '
        Me.lblRmarkByDr.AutoSize = True
        Me.lblRmarkByDr.BackColor = System.Drawing.Color.Transparent
        Me.lblRmarkByDr.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRmarkByDr.ForeColor = System.Drawing.Color.White
        Me.lblRmarkByDr.Location = New System.Drawing.Point(440, 177)
        Me.lblRmarkByDr.Name = "lblRmarkByDr"
        Me.lblRmarkByDr.Size = New System.Drawing.Size(82, 22)
        Me.lblRmarkByDr.TabIndex = 152
        Me.lblRmarkByDr.Text = "Remark:"
        '
        'txtDocNm
        '
        Me.txtDocNm.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocNm.Location = New System.Drawing.Point(179, 324)
        Me.txtDocNm.Name = "txtDocNm"
        Me.txtDocNm.Size = New System.Drawing.Size(212, 29)
        Me.txtDocNm.TabIndex = 5
        '
        'txtPatNm
        '
        Me.txtPatNm.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatNm.Location = New System.Drawing.Point(179, 164)
        Me.txtPatNm.Name = "txtPatNm"
        Me.txtPatNm.Size = New System.Drawing.Size(210, 29)
        Me.txtPatNm.TabIndex = 2
        '
        'dtpRprtDlvryDte
        '
        Me.dtpRprtDlvryDte.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpRprtDlvryDte.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpRprtDlvryDte.Location = New System.Drawing.Point(599, 66)
        Me.dtpRprtDlvryDte.Name = "dtpRprtDlvryDte"
        Me.dtpRprtDlvryDte.Size = New System.Drawing.Size(181, 29)
        Me.dtpRprtDlvryDte.TabIndex = 8
        '
        'lblRDeliverDte
        '
        Me.lblRDeliverDte.AutoSize = True
        Me.lblRDeliverDte.BackColor = System.Drawing.Color.Transparent
        Me.lblRDeliverDte.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRDeliverDte.ForeColor = System.Drawing.Color.White
        Me.lblRDeliverDte.Location = New System.Drawing.Point(439, 66)
        Me.lblRDeliverDte.Name = "lblRDeliverDte"
        Me.lblRDeliverDte.Size = New System.Drawing.Size(83, 44)
        Me.lblRDeliverDte.TabIndex = 147
        Me.lblRDeliverDte.Text = "Delivery " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Date:"
        '
        'txtContact
        '
        Me.txtContact.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.Location = New System.Drawing.Point(179, 280)
        Me.txtContact.MaxLength = 10
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(212, 29)
        Me.txtContact.TabIndex = 4
        '
        'lblContct
        '
        Me.lblContct.AutoSize = True
        Me.lblContct.BackColor = System.Drawing.Color.Transparent
        Me.lblContct.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContct.ForeColor = System.Drawing.Color.White
        Me.lblContct.Location = New System.Drawing.Point(26, 280)
        Me.lblContct.Name = "lblContct"
        Me.lblContct.Size = New System.Drawing.Size(80, 22)
        Me.lblContct.TabIndex = 145
        Me.lblContct.Text = "Contact:"
        '
        'dtpRFDate
        '
        Me.dtpRFDate.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpRFDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpRFDate.Location = New System.Drawing.Point(667, 7)
        Me.dtpRFDate.Name = "dtpRFDate"
        Me.dtpRFDate.Size = New System.Drawing.Size(130, 29)
        Me.dtpRFDate.TabIndex = 143
        '
        'LblDate
        '
        Me.LblDate.AutoSize = True
        Me.LblDate.BackColor = System.Drawing.Color.Transparent
        Me.LblDate.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDate.ForeColor = System.Drawing.Color.White
        Me.LblDate.Location = New System.Drawing.Point(592, 12)
        Me.LblDate.Name = "LblDate"
        Me.LblDate.Size = New System.Drawing.Size(54, 22)
        Me.LblDate.TabIndex = 142
        Me.LblDate.Text = "Date:"
        '
        'txtFrwdCntct
        '
        Me.txtFrwdCntct.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFrwdCntct.Location = New System.Drawing.Point(600, 371)
        Me.txtFrwdCntct.MaxLength = 10
        Me.txtFrwdCntct.Name = "txtFrwdCntct"
        Me.txtFrwdCntct.Size = New System.Drawing.Size(196, 29)
        Me.txtFrwdCntct.TabIndex = 13
        '
        'txtFrwdLbAddr
        '
        Me.txtFrwdLbAddr.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFrwdLbAddr.Location = New System.Drawing.Point(600, 432)
        Me.txtFrwdLbAddr.Multiline = True
        Me.txtFrwdLbAddr.Name = "txtFrwdLbAddr"
        Me.txtFrwdLbAddr.Size = New System.Drawing.Size(197, 68)
        Me.txtFrwdLbAddr.TabIndex = 14
        '
        'lblFrwdCntct
        '
        Me.lblFrwdCntct.AutoSize = True
        Me.lblFrwdCntct.BackColor = System.Drawing.Color.Transparent
        Me.lblFrwdCntct.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrwdCntct.ForeColor = System.Drawing.Color.White
        Me.lblFrwdCntct.Location = New System.Drawing.Point(439, 384)
        Me.lblFrwdCntct.Name = "lblFrwdCntct"
        Me.lblFrwdCntct.Size = New System.Drawing.Size(109, 44)
        Me.lblFrwdCntct.TabIndex = 54
        Me.lblFrwdCntct.Text = "Forwarded" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Contact No:"
        '
        'txtFrwdToLb
        '
        Me.txtFrwdToLb.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFrwdToLb.Location = New System.Drawing.Point(600, 314)
        Me.txtFrwdToLb.Name = "txtFrwdToLb"
        Me.txtFrwdToLb.Size = New System.Drawing.Size(197, 29)
        Me.txtFrwdToLb.TabIndex = 12
        '
        'txtFrwdRsn
        '
        Me.txtFrwdRsn.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFrwdRsn.Location = New System.Drawing.Point(599, 224)
        Me.txtFrwdRsn.Multiline = True
        Me.txtFrwdRsn.Name = "txtFrwdRsn"
        Me.txtFrwdRsn.Size = New System.Drawing.Size(198, 65)
        Me.txtFrwdRsn.TabIndex = 11
        '
        'lblFrwdToLb
        '
        Me.lblFrwdToLb.AutoSize = True
        Me.lblFrwdToLb.BackColor = System.Drawing.Color.Transparent
        Me.lblFrwdToLb.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrwdToLb.ForeColor = System.Drawing.Color.White
        Me.lblFrwdToLb.Location = New System.Drawing.Point(437, 314)
        Me.lblFrwdToLb.Name = "lblFrwdToLb"
        Me.lblFrwdToLb.Size = New System.Drawing.Size(111, 44)
        Me.lblFrwdToLb.TabIndex = 50
        Me.lblFrwdToLb.Text = "Forwarded  " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "To Lab:"
        '
        'lblFrwdLbAddr
        '
        Me.lblFrwdLbAddr.AutoSize = True
        Me.lblFrwdLbAddr.BackColor = System.Drawing.Color.Transparent
        Me.lblFrwdLbAddr.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrwdLbAddr.ForeColor = System.Drawing.Color.White
        Me.lblFrwdLbAddr.Location = New System.Drawing.Point(439, 445)
        Me.lblFrwdLbAddr.Name = "lblFrwdLbAddr"
        Me.lblFrwdLbAddr.Size = New System.Drawing.Size(117, 44)
        Me.lblFrwdLbAddr.TabIndex = 49
        Me.lblFrwdLbAddr.Text = "Forwarded" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Lab Address:"
        '
        'lblFrwdRsn
        '
        Me.lblFrwdRsn.AutoSize = True
        Me.lblFrwdRsn.BackColor = System.Drawing.Color.Transparent
        Me.lblFrwdRsn.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrwdRsn.ForeColor = System.Drawing.Color.White
        Me.lblFrwdRsn.Location = New System.Drawing.Point(439, 237)
        Me.lblFrwdRsn.Name = "lblFrwdRsn"
        Me.lblFrwdRsn.Size = New System.Drawing.Size(87, 44)
        Me.lblFrwdRsn.TabIndex = 48
        Me.lblFrwdRsn.Text = "Forward " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Reason:"
        '
        'cmbRInId
        '
        Me.cmbRInId.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRInId.FormattingEnabled = True
        Me.cmbRInId.Location = New System.Drawing.Point(183, 113)
        Me.cmbRInId.Name = "cmbRInId"
        Me.cmbRInId.Size = New System.Drawing.Size(98, 30)
        Me.cmbRInId.TabIndex = 1
        '
        'txtRFId
        '
        Me.txtRFId.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRFId.Location = New System.Drawing.Point(183, 68)
        Me.txtRFId.Name = "txtRFId"
        Me.txtRFId.Size = New System.Drawing.Size(92, 29)
        Me.txtRFId.TabIndex = 0
        '
        'lblRFId
        '
        Me.lblRFId.AutoSize = True
        Me.lblRFId.BackColor = System.Drawing.Color.Transparent
        Me.lblRFId.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRFId.ForeColor = System.Drawing.Color.White
        Me.lblRFId.Location = New System.Drawing.Point(26, 75)
        Me.lblRFId.Name = "lblRFId"
        Me.lblRFId.Size = New System.Drawing.Size(58, 22)
        Me.lblRFId.TabIndex = 45
        Me.lblRFId.Text = "RFId:"
        '
        'lblDocNm
        '
        Me.lblDocNm.AutoSize = True
        Me.lblDocNm.BackColor = System.Drawing.Color.Transparent
        Me.lblDocNm.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocNm.ForeColor = System.Drawing.Color.White
        Me.lblDocNm.Location = New System.Drawing.Point(26, 328)
        Me.lblDocNm.Name = "lblDocNm"
        Me.lblDocNm.Size = New System.Drawing.Size(125, 22)
        Me.lblDocNm.TabIndex = 30
        Me.lblDocNm.Text = "Doctor Name:"
        '
        'lblDisease
        '
        Me.lblDisease.AutoSize = True
        Me.lblDisease.BackColor = System.Drawing.Color.Transparent
        Me.lblDisease.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisease.ForeColor = System.Drawing.Color.White
        Me.lblDisease.Location = New System.Drawing.Point(26, 378)
        Me.lblDisease.Name = "lblDisease"
        Me.lblDisease.Size = New System.Drawing.Size(78, 22)
        Me.lblDisease.TabIndex = 29
        Me.lblDisease.Text = "Disease:"
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
        'lblPatientName
        '
        Me.lblPatientName.AutoSize = True
        Me.lblPatientName.BackColor = System.Drawing.Color.Transparent
        Me.lblPatientName.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientName.ForeColor = System.Drawing.Color.White
        Me.lblPatientName.Location = New System.Drawing.Point(26, 164)
        Me.lblPatientName.Name = "lblPatientName"
        Me.lblPatientName.Size = New System.Drawing.Size(126, 22)
        Me.lblPatientName.TabIndex = 21
        Me.lblPatientName.Text = "Patient Name:"
        '
        'txtPatAddr
        '
        Me.txtPatAddr.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatAddr.Location = New System.Drawing.Point(179, 209)
        Me.txtPatAddr.Multiline = True
        Me.txtPatAddr.Name = "txtPatAddr"
        Me.txtPatAddr.Size = New System.Drawing.Size(212, 54)
        Me.txtPatAddr.TabIndex = 3
        '
        'lblRcvBY
        '
        Me.lblRcvBY.AutoSize = True
        Me.lblRcvBY.BackColor = System.Drawing.Color.Transparent
        Me.lblRcvBY.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRcvBY.ForeColor = System.Drawing.Color.White
        Me.lblRcvBY.Location = New System.Drawing.Point(439, 126)
        Me.lblRcvBY.Name = "lblRcvBY"
        Me.lblRcvBY.Size = New System.Drawing.Size(71, 22)
        Me.lblRcvBY.TabIndex = 3
        Me.lblRcvBY.Text = "Ref By:"
        '
        'lblPatAddr
        '
        Me.lblPatAddr.AutoSize = True
        Me.lblPatAddr.BackColor = System.Drawing.Color.Transparent
        Me.lblPatAddr.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatAddr.ForeColor = System.Drawing.Color.White
        Me.lblPatAddr.Location = New System.Drawing.Point(26, 224)
        Me.lblPatAddr.Name = "lblPatAddr"
        Me.lblPatAddr.Size = New System.Drawing.Size(143, 22)
        Me.lblPatAddr.TabIndex = 1
        Me.lblPatAddr.Text = "Patient Address:"
        '
        'lblRInID
        '
        Me.lblRInID.AutoSize = True
        Me.lblRInID.BackColor = System.Drawing.Color.Transparent
        Me.lblRInID.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRInID.ForeColor = System.Drawing.Color.White
        Me.lblRInID.Location = New System.Drawing.Point(26, 121)
        Me.lblRInID.Name = "lblRInID"
        Me.lblRInID.Size = New System.Drawing.Size(63, 22)
        Me.lblRInID.TabIndex = 0
        Me.lblRInID.Text = "RInId:"
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
        Me.PnlCustOperations.Location = New System.Drawing.Point(859, 180)
        Me.PnlCustOperations.Name = "PnlCustOperations"
        Me.PnlCustOperations.Size = New System.Drawing.Size(457, 85)
        Me.PnlCustOperations.TabIndex = 147
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(335, 27)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(102, 38)
        Me.btnClear.TabIndex = 22
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(121, 27)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(104, 38)
        Me.btnUpdate.TabIndex = 20
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(13, 26)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(102, 38)
        Me.btnAdd.TabIndex = 19
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(231, 27)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(98, 38)
        Me.btnDelete.TabIndex = 21
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
        Me.PnlCustNavigation.Location = New System.Drawing.Point(859, 94)
        Me.PnlCustNavigation.Name = "PnlCustNavigation"
        Me.PnlCustNavigation.Size = New System.Drawing.Size(457, 80)
        Me.PnlCustNavigation.TabIndex = 148
        '
        'BtnNext
        '
        Me.BtnNext.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNext.Location = New System.Drawing.Point(231, 19)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(98, 39)
        Me.BtnNext.TabIndex = 17
        Me.BtnNext.Text = "Next>>"
        Me.BtnNext.UseVisualStyleBackColor = True
        '
        'BtnLast
        '
        Me.BtnLast.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLast.Location = New System.Drawing.Point(335, 19)
        Me.BtnLast.Name = "BtnLast"
        Me.BtnLast.Size = New System.Drawing.Size(102, 39)
        Me.BtnLast.TabIndex = 18
        Me.BtnLast.Text = "Last"
        Me.BtnLast.UseVisualStyleBackColor = True
        '
        'BtnPrev
        '
        Me.BtnPrev.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrev.Location = New System.Drawing.Point(121, 19)
        Me.BtnPrev.Name = "BtnPrev"
        Me.BtnPrev.Size = New System.Drawing.Size(104, 39)
        Me.BtnPrev.TabIndex = 16
        Me.BtnPrev.Text = "<<Prev"
        Me.BtnPrev.UseVisualStyleBackColor = True
        '
        'BtnFirst
        '
        Me.BtnFirst.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFirst.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnFirst.Location = New System.Drawing.Point(13, 19)
        Me.BtnFirst.Name = "BtnFirst"
        Me.BtnFirst.Size = New System.Drawing.Size(102, 39)
        Me.BtnFirst.TabIndex = 15
        Me.BtnFirst.Text = "First"
        Me.BtnFirst.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(859, 273)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(466, 348)
        Me.DataGridView1.TabIndex = 149
        '
        'lblLnkPrint
        '
        Me.lblLnkPrint.AutoSize = True
        Me.lblLnkPrint.BackColor = System.Drawing.Color.Lavender
        Me.lblLnkPrint.Font = New System.Drawing.Font("Perpetua Titling MT", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLnkPrint.ForeColor = System.Drawing.Color.White
        Me.lblLnkPrint.Location = New System.Drawing.Point(1014, 59)
        Me.lblLnkPrint.Name = "lblLnkPrint"
        Me.lblLnkPrint.Size = New System.Drawing.Size(105, 32)
        Me.lblLnkPrint.TabIndex = 168
        Me.lblLnkPrint.TabStop = True
        Me.lblLnkPrint.Text = "Print"
        '
        'ReportForward
        '
        Me.AcceptButton = Me.btnnewid
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1366, 746)
        Me.Controls.Add(Me.lblLnkPrint)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.PnlCustOperations)
        Me.Controls.Add(Me.PnlCustNavigation)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbldocdet)
        Me.Name = "ReportForward"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ReportForward"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PnlCustOperations.ResumeLayout(False)
        Me.PnlCustNavigation.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnnewid As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lbldocdet As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblDocNm As System.Windows.Forms.Label
    Friend WithEvents lblDisease As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lblPatientName As System.Windows.Forms.Label
    Friend WithEvents txtPatAddr As System.Windows.Forms.TextBox
    Friend WithEvents lblPatAddr As System.Windows.Forms.Label
    Friend WithEvents lblRInID As System.Windows.Forms.Label
    Friend WithEvents txtRFId As System.Windows.Forms.TextBox
    Friend WithEvents lblRFId As System.Windows.Forms.Label
    Friend WithEvents cmbRInId As System.Windows.Forms.ComboBox
    Friend WithEvents txtFrwdCntct As System.Windows.Forms.TextBox
    Friend WithEvents txtFrwdLbAddr As System.Windows.Forms.TextBox
    Friend WithEvents lblFrwdCntct As System.Windows.Forms.Label
    Friend WithEvents txtFrwdToLb As System.Windows.Forms.TextBox
    Friend WithEvents txtFrwdRsn As System.Windows.Forms.TextBox
    Friend WithEvents lblFrwdToLb As System.Windows.Forms.Label
    Friend WithEvents lblFrwdLbAddr As System.Windows.Forms.Label
    Friend WithEvents lblFrwdRsn As System.Windows.Forms.Label
    Friend WithEvents lblRcvBY As System.Windows.Forms.Label
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
    Friend WithEvents LblDate As System.Windows.Forms.Label
    Friend WithEvents dtpRFDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents lblContct As System.Windows.Forms.Label
    Friend WithEvents dtpRprtDlvryDte As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblRDeliverDte As System.Windows.Forms.Label
    Friend WithEvents txtDises As System.Windows.Forms.TextBox
    Friend WithEvents txtDocNm As System.Windows.Forms.TextBox
    Friend WithEvents txtPatNm As System.Windows.Forms.TextBox
    Friend WithEvents lstTest As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRcvBy As System.Windows.Forms.TextBox
    Friend WithEvents txtRmarkByDr As System.Windows.Forms.TextBox
    Friend WithEvents lblRmarkByDr As System.Windows.Forms.Label
    Friend WithEvents lblLnkPrint As System.Windows.Forms.LinkLabel
End Class
