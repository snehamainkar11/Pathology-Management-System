<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportCreation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportCreation))
        Me.lbldocdet = New System.Windows.Forms.Label
        Me.btnnewid = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblRInID = New System.Windows.Forms.Label
        Me.lblPatAddr = New System.Windows.Forms.Label
        Me.txtPatAddr = New System.Windows.Forms.TextBox
        Me.lblPatientName = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.lblContct = New System.Windows.Forms.Label
        Me.lblRIndate = New System.Windows.Forms.Label
        Me.DTPRInDte = New System.Windows.Forms.DateTimePicker
        Me.txtContact = New System.Windows.Forms.TextBox
        Me.lblRCId = New System.Windows.Forms.Label
        Me.txtRCId = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtRefBy = New System.Windows.Forms.TextBox
        Me.cmbRInId = New System.Windows.Forms.ComboBox
        Me.txtDisease = New System.Windows.Forms.TextBox
        Me.lblDisease = New System.Windows.Forms.Label
        Me.txtDoctor = New System.Windows.Forms.TextBox
        Me.txtRmarkByDr = New System.Windows.Forms.TextBox
        Me.lblRmarkByDr = New System.Windows.Forms.Label
        Me.lblDocNm = New System.Windows.Forms.Label
        Me.DTPRprtDlvryDte = New System.Windows.Forms.DateTimePicker
        Me.lblRDeliverDte = New System.Windows.Forms.Label
        Me.lblRcvBY = New System.Windows.Forms.Label
        Me.txtPatNm = New System.Windows.Forms.TextBox
        Me.txtResult = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
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
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btntestDel = New System.Windows.Forms.Button
        Me.btnNewTest = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtTestNo = New System.Windows.Forms.TextBox
        Me.btnTestUpdate = New System.Windows.Forms.Button
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.btnTestAdd = New System.Windows.Forms.Button
        Me.cmbTest = New System.Windows.Forms.ComboBox
        Me.Panel1.SuspendLayout()
        Me.PnlCustNavigation.SuspendLayout()
        Me.PnlCustOperations.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbldocdet
        '
        Me.lbldocdet.AutoSize = True
        Me.lbldocdet.BackColor = System.Drawing.Color.Transparent
        Me.lbldocdet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbldocdet.Font = New System.Drawing.Font("Palatino Linotype", 40.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldocdet.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.lbldocdet.Location = New System.Drawing.Point(433, 0)
        Me.lbldocdet.Name = "lbldocdet"
        Me.lbldocdet.Size = New System.Drawing.Size(309, 74)
        Me.lbldocdet.TabIndex = 145
        Me.lbldocdet.Text = "Test Report"
        '
        'btnnewid
        '
        Me.btnnewid.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnnewid.BackColor = System.Drawing.Color.Black
        Me.btnnewid.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnewid.ForeColor = System.Drawing.Color.White
        Me.btnnewid.Location = New System.Drawing.Point(290, 36)
        Me.btnnewid.Name = "btnnewid"
        Me.btnnewid.Size = New System.Drawing.Size(94, 36)
        Me.btnnewid.TabIndex = 140
        Me.btnnewid.Text = "New Id"
        Me.btnnewid.UseVisualStyleBackColor = False
        '
        'lblRInID
        '
        Me.lblRInID.AutoSize = True
        Me.lblRInID.BackColor = System.Drawing.Color.Transparent
        Me.lblRInID.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRInID.ForeColor = System.Drawing.Color.White
        Me.lblRInID.Location = New System.Drawing.Point(15, 96)
        Me.lblRInID.Name = "lblRInID"
        Me.lblRInID.Size = New System.Drawing.Size(63, 22)
        Me.lblRInID.TabIndex = 0
        Me.lblRInID.Text = "RInId:"
        '
        'lblPatAddr
        '
        Me.lblPatAddr.AutoSize = True
        Me.lblPatAddr.BackColor = System.Drawing.Color.Transparent
        Me.lblPatAddr.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatAddr.ForeColor = System.Drawing.Color.White
        Me.lblPatAddr.Location = New System.Drawing.Point(15, 212)
        Me.lblPatAddr.Name = "lblPatAddr"
        Me.lblPatAddr.Size = New System.Drawing.Size(143, 22)
        Me.lblPatAddr.TabIndex = 1
        Me.lblPatAddr.Text = "Patient Address:"
        '
        'txtPatAddr
        '
        Me.txtPatAddr.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatAddr.Location = New System.Drawing.Point(173, 199)
        Me.txtPatAddr.Multiline = True
        Me.txtPatAddr.Name = "txtPatAddr"
        Me.txtPatAddr.Size = New System.Drawing.Size(211, 60)
        Me.txtPatAddr.TabIndex = 4
        '
        'lblPatientName
        '
        Me.lblPatientName.AutoSize = True
        Me.lblPatientName.BackColor = System.Drawing.Color.Transparent
        Me.lblPatientName.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientName.ForeColor = System.Drawing.Color.White
        Me.lblPatientName.Location = New System.Drawing.Point(15, 145)
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
        'lblContct
        '
        Me.lblContct.AutoSize = True
        Me.lblContct.BackColor = System.Drawing.Color.Transparent
        Me.lblContct.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContct.ForeColor = System.Drawing.Color.White
        Me.lblContct.Location = New System.Drawing.Point(15, 281)
        Me.lblContct.Name = "lblContct"
        Me.lblContct.Size = New System.Drawing.Size(109, 22)
        Me.lblContct.TabIndex = 40
        Me.lblContct.Text = "Contact No:"
        '
        'lblRIndate
        '
        Me.lblRIndate.AutoSize = True
        Me.lblRIndate.BackColor = System.Drawing.Color.Transparent
        Me.lblRIndate.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRIndate.ForeColor = System.Drawing.Color.White
        Me.lblRIndate.Location = New System.Drawing.Point(546, 16)
        Me.lblRIndate.Name = "lblRIndate"
        Me.lblRIndate.Size = New System.Drawing.Size(54, 22)
        Me.lblRIndate.TabIndex = 41
        Me.lblRIndate.Text = "Date:"
        '
        'DTPRInDte
        '
        Me.DTPRInDte.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPRInDte.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPRInDte.Location = New System.Drawing.Point(620, 11)
        Me.DTPRInDte.Name = "DTPRInDte"
        Me.DTPRInDte.Size = New System.Drawing.Size(158, 29)
        Me.DTPRInDte.TabIndex = 42
        '
        'txtContact
        '
        Me.txtContact.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.Location = New System.Drawing.Point(173, 281)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(211, 29)
        Me.txtContact.TabIndex = 4
        '
        'lblRCId
        '
        Me.lblRCId.AutoSize = True
        Me.lblRCId.BackColor = System.Drawing.Color.Transparent
        Me.lblRCId.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRCId.ForeColor = System.Drawing.Color.White
        Me.lblRCId.Location = New System.Drawing.Point(15, 48)
        Me.lblRCId.Name = "lblRCId"
        Me.lblRCId.Size = New System.Drawing.Size(60, 22)
        Me.lblRCId.TabIndex = 45
        Me.lblRCId.Text = "RCId:"
        '
        'txtRCId
        '
        Me.txtRCId.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRCId.Location = New System.Drawing.Point(173, 41)
        Me.txtRCId.Name = "txtRCId"
        Me.txtRCId.Size = New System.Drawing.Size(111, 29)
        Me.txtRCId.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.txtRefBy)
        Me.Panel1.Controls.Add(Me.cmbRInId)
        Me.Panel1.Controls.Add(Me.txtDisease)
        Me.Panel1.Controls.Add(Me.lblDisease)
        Me.Panel1.Controls.Add(Me.txtDoctor)
        Me.Panel1.Controls.Add(Me.txtRmarkByDr)
        Me.Panel1.Controls.Add(Me.lblRmarkByDr)
        Me.Panel1.Controls.Add(Me.lblDocNm)
        Me.Panel1.Controls.Add(Me.DTPRprtDlvryDte)
        Me.Panel1.Controls.Add(Me.lblRDeliverDte)
        Me.Panel1.Controls.Add(Me.lblRcvBY)
        Me.Panel1.Controls.Add(Me.txtPatNm)
        Me.Panel1.Controls.Add(Me.txtRCId)
        Me.Panel1.Controls.Add(Me.lblRCId)
        Me.Panel1.Controls.Add(Me.txtContact)
        Me.Panel1.Controls.Add(Me.DTPRInDte)
        Me.Panel1.Controls.Add(Me.btnnewid)
        Me.Panel1.Controls.Add(Me.lblContct)
        Me.Panel1.Controls.Add(Me.lblRIndate)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.lblPatientName)
        Me.Panel1.Controls.Add(Me.txtPatAddr)
        Me.Panel1.Controls.Add(Me.lblPatAddr)
        Me.Panel1.Controls.Add(Me.lblRInID)
        Me.Panel1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(12, 77)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(805, 404)
        Me.Panel1.TabIndex = 142
        '
        'txtRefBy
        '
        Me.txtRefBy.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefBy.Location = New System.Drawing.Point(556, 209)
        Me.txtRefBy.Name = "txtRefBy"
        Me.txtRefBy.Size = New System.Drawing.Size(224, 29)
        Me.txtRefBy.TabIndex = 6
        '
        'cmbRInId
        '
        Me.cmbRInId.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRInId.FormattingEnabled = True
        Me.cmbRInId.Location = New System.Drawing.Point(173, 93)
        Me.cmbRInId.Name = "cmbRInId"
        Me.cmbRInId.Size = New System.Drawing.Size(111, 30)
        Me.cmbRInId.TabIndex = 1
        '
        'txtDisease
        '
        Me.txtDisease.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisease.Location = New System.Drawing.Point(173, 346)
        Me.txtDisease.Name = "txtDisease"
        Me.txtDisease.Size = New System.Drawing.Size(211, 29)
        Me.txtDisease.TabIndex = 4
        '
        'lblDisease
        '
        Me.lblDisease.AutoSize = True
        Me.lblDisease.BackColor = System.Drawing.Color.Transparent
        Me.lblDisease.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisease.ForeColor = System.Drawing.Color.White
        Me.lblDisease.Location = New System.Drawing.Point(15, 349)
        Me.lblDisease.Name = "lblDisease"
        Me.lblDisease.Size = New System.Drawing.Size(78, 22)
        Me.lblDisease.TabIndex = 164
        Me.lblDisease.Text = "Disease:"
        '
        'txtDoctor
        '
        Me.txtDoctor.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDoctor.Location = New System.Drawing.Point(554, 89)
        Me.txtDoctor.Name = "txtDoctor"
        Me.txtDoctor.Size = New System.Drawing.Size(224, 29)
        Me.txtDoctor.TabIndex = 5
        '
        'txtRmarkByDr
        '
        Me.txtRmarkByDr.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRmarkByDr.Location = New System.Drawing.Point(554, 261)
        Me.txtRmarkByDr.Multiline = True
        Me.txtRmarkByDr.Name = "txtRmarkByDr"
        Me.txtRmarkByDr.Size = New System.Drawing.Size(224, 110)
        Me.txtRmarkByDr.TabIndex = 7
        '
        'lblRmarkByDr
        '
        Me.lblRmarkByDr.AutoSize = True
        Me.lblRmarkByDr.BackColor = System.Drawing.Color.Transparent
        Me.lblRmarkByDr.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRmarkByDr.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblRmarkByDr.Location = New System.Drawing.Point(418, 286)
        Me.lblRmarkByDr.Name = "lblRmarkByDr"
        Me.lblRmarkByDr.Size = New System.Drawing.Size(82, 22)
        Me.lblRmarkByDr.TabIndex = 157
        Me.lblRmarkByDr.Text = "Remark:"
        '
        'lblDocNm
        '
        Me.lblDocNm.AutoSize = True
        Me.lblDocNm.BackColor = System.Drawing.Color.Transparent
        Me.lblDocNm.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocNm.ForeColor = System.Drawing.Color.White
        Me.lblDocNm.Location = New System.Drawing.Point(417, 96)
        Me.lblDocNm.Name = "lblDocNm"
        Me.lblDocNm.Size = New System.Drawing.Size(125, 22)
        Me.lblDocNm.TabIndex = 155
        Me.lblDocNm.Text = "Doctor Name:"
        '
        'DTPRprtDlvryDte
        '
        Me.DTPRprtDlvryDte.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPRprtDlvryDte.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPRprtDlvryDte.Location = New System.Drawing.Point(554, 144)
        Me.DTPRprtDlvryDte.Name = "DTPRprtDlvryDte"
        Me.DTPRprtDlvryDte.Size = New System.Drawing.Size(224, 29)
        Me.DTPRprtDlvryDte.TabIndex = 154
        '
        'lblRDeliverDte
        '
        Me.lblRDeliverDte.AutoSize = True
        Me.lblRDeliverDte.BackColor = System.Drawing.Color.Transparent
        Me.lblRDeliverDte.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRDeliverDte.ForeColor = System.Drawing.Color.White
        Me.lblRDeliverDte.Location = New System.Drawing.Point(415, 149)
        Me.lblRDeliverDte.Name = "lblRDeliverDte"
        Me.lblRDeliverDte.Size = New System.Drawing.Size(127, 22)
        Me.lblRDeliverDte.TabIndex = 151
        Me.lblRDeliverDte.Text = "Delivery Date:"
        '
        'lblRcvBY
        '
        Me.lblRcvBY.AutoSize = True
        Me.lblRcvBY.BackColor = System.Drawing.Color.Transparent
        Me.lblRcvBY.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRcvBY.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblRcvBY.Location = New System.Drawing.Point(417, 216)
        Me.lblRcvBY.Name = "lblRcvBY"
        Me.lblRcvBY.Size = New System.Drawing.Size(71, 22)
        Me.lblRcvBY.TabIndex = 150
        Me.lblRcvBY.Text = "Ref By:"
        '
        'txtPatNm
        '
        Me.txtPatNm.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatNm.Location = New System.Drawing.Point(173, 142)
        Me.txtPatNm.Name = "txtPatNm"
        Me.txtPatNm.Size = New System.Drawing.Size(211, 29)
        Me.txtPatNm.TabIndex = 2
        '
        'txtResult
        '
        Me.txtResult.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResult.Location = New System.Drawing.Point(346, 39)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(167, 29)
        Me.txtResult.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(377, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 22)
        Me.Label3.TabIndex = 162
        Me.Label3.Text = "Result:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(157, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 22)
        Me.Label2.TabIndex = 160
        Me.Label2.Text = "Suggested Test:"
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
        Me.PnlCustNavigation.Location = New System.Drawing.Point(823, 76)
        Me.PnlCustNavigation.Name = "PnlCustNavigation"
        Me.PnlCustNavigation.Size = New System.Drawing.Size(445, 95)
        Me.PnlCustNavigation.TabIndex = 148
        '
        'BtnNext
        '
        Me.BtnNext.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNext.Location = New System.Drawing.Point(229, 31)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(97, 39)
        Me.BtnNext.TabIndex = 18
        Me.BtnNext.Text = "Next>>"
        Me.BtnNext.UseVisualStyleBackColor = True
        '
        'BtnLast
        '
        Me.BtnLast.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLast.Location = New System.Drawing.Point(332, 31)
        Me.BtnLast.Name = "BtnLast"
        Me.BtnLast.Size = New System.Drawing.Size(91, 39)
        Me.BtnLast.TabIndex = 17
        Me.BtnLast.Text = "Last"
        Me.BtnLast.UseVisualStyleBackColor = True
        '
        'BtnPrev
        '
        Me.BtnPrev.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrev.Location = New System.Drawing.Point(119, 31)
        Me.BtnPrev.Name = "BtnPrev"
        Me.BtnPrev.Size = New System.Drawing.Size(104, 39)
        Me.BtnPrev.TabIndex = 19
        Me.BtnPrev.Text = "<<Prev"
        Me.BtnPrev.UseVisualStyleBackColor = True
        '
        'BtnFirst
        '
        Me.BtnFirst.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFirst.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnFirst.Location = New System.Drawing.Point(13, 31)
        Me.BtnFirst.Name = "BtnFirst"
        Me.BtnFirst.Size = New System.Drawing.Size(100, 39)
        Me.BtnFirst.TabIndex = 14
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
        Me.PnlCustOperations.Location = New System.Drawing.Point(823, 177)
        Me.PnlCustOperations.Name = "PnlCustOperations"
        Me.PnlCustOperations.Size = New System.Drawing.Size(445, 83)
        Me.PnlCustOperations.TabIndex = 147
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(332, 22)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(91, 38)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(119, 22)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(104, 38)
        Me.btnUpdate.TabIndex = 10
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(13, 22)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(103, 38)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(229, 22)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(97, 38)
        Me.btnDelete.TabIndex = 11
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(823, 266)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(513, 215)
        Me.DataGridView1.TabIndex = 149
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.Pathology.My.Resources.Resources.MdiImage
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.btntestDel)
        Me.Panel2.Controls.Add(Me.btnNewTest)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txtTestNo)
        Me.Panel2.Controls.Add(Me.btnTestUpdate)
        Me.Panel2.Controls.Add(Me.DataGridView2)
        Me.Panel2.Controls.Add(Me.btnTestAdd)
        Me.Panel2.Controls.Add(Me.cmbTest)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtResult)
        Me.Panel2.Location = New System.Drawing.Point(12, 487)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(805, 253)
        Me.Panel2.TabIndex = 167
        '
        'btntestDel
        '
        Me.btntestDel.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntestDel.Location = New System.Drawing.Point(554, 164)
        Me.btntestDel.Name = "btntestDel"
        Me.btntestDel.Size = New System.Drawing.Size(126, 38)
        Me.btntestDel.TabIndex = 172
        Me.btntestDel.Text = "Delete"
        Me.btntestDel.UseVisualStyleBackColor = True
        '
        'btnNewTest
        '
        Me.btnNewTest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnNewTest.BackColor = System.Drawing.Color.Black
        Me.btnNewTest.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewTest.ForeColor = System.Drawing.Color.White
        Me.btnNewTest.Location = New System.Drawing.Point(537, 34)
        Me.btnNewTest.Name = "btnNewTest"
        Me.btnNewTest.Size = New System.Drawing.Size(178, 36)
        Me.btnNewTest.TabIndex = 171
        Me.btnNewTest.Text = "New Test No:"
        Me.btnNewTest.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(26, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 22)
        Me.Label1.TabIndex = 169
        Me.Label1.Text = "Test No:"
        '
        'txtTestNo
        '
        Me.txtTestNo.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTestNo.Location = New System.Drawing.Point(19, 38)
        Me.txtTestNo.Name = "txtTestNo"
        Me.txtTestNo.Size = New System.Drawing.Size(104, 29)
        Me.txtTestNo.TabIndex = 9
        '
        'btnTestUpdate
        '
        Me.btnTestUpdate.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTestUpdate.Location = New System.Drawing.Point(556, 120)
        Me.btnTestUpdate.Name = "btnTestUpdate"
        Me.btnTestUpdate.Size = New System.Drawing.Size(124, 38)
        Me.btnTestUpdate.TabIndex = 10
        Me.btnTestUpdate.Text = "Update"
        Me.btnTestUpdate.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(19, 74)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(494, 128)
        Me.DataGridView2.TabIndex = 168
        '
        'btnTestAdd
        '
        Me.btnTestAdd.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTestAdd.Location = New System.Drawing.Point(554, 76)
        Me.btnTestAdd.Name = "btnTestAdd"
        Me.btnTestAdd.Size = New System.Drawing.Size(126, 38)
        Me.btnTestAdd.TabIndex = 9
        Me.btnTestAdd.Text = "Add"
        Me.btnTestAdd.UseVisualStyleBackColor = True
        '
        'cmbTest
        '
        Me.cmbTest.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTest.FormattingEnabled = True
        Me.cmbTest.Location = New System.Drawing.Point(129, 38)
        Me.cmbTest.Name = "cmbTest"
        Me.cmbTest.Size = New System.Drawing.Size(211, 30)
        Me.cmbTest.TabIndex = 10
        '
        'ReportCreation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Pathology.My.Resources.Resources.MdiImage
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1362, 742)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.PnlCustNavigation)
        Me.Controls.Add(Me.PnlCustOperations)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbldocdet)
        Me.Name = "ReportCreation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReportCreation"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PnlCustNavigation.ResumeLayout(False)
        Me.PnlCustOperations.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbldocdet As System.Windows.Forms.Label
    Friend WithEvents btnnewid As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lblRInID As System.Windows.Forms.Label
    Friend WithEvents lblPatAddr As System.Windows.Forms.Label
    Friend WithEvents txtPatAddr As System.Windows.Forms.TextBox
    Friend WithEvents lblPatientName As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lblContct As System.Windows.Forms.Label
    Friend WithEvents lblRIndate As System.Windows.Forms.Label
    Friend WithEvents DTPRInDte As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents lblRCId As System.Windows.Forms.Label
    Friend WithEvents txtRCId As System.Windows.Forms.TextBox
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
    Friend WithEvents txtPatNm As System.Windows.Forms.TextBox
    Friend WithEvents lblDocNm As System.Windows.Forms.Label
    Friend WithEvents DTPRprtDlvryDte As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblRDeliverDte As System.Windows.Forms.Label
    Friend WithEvents lblRcvBY As System.Windows.Forms.Label
    Friend WithEvents txtRmarkByDr As System.Windows.Forms.TextBox
    Friend WithEvents lblRmarkByDr As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtDoctor As System.Windows.Forms.TextBox
    Friend WithEvents txtDisease As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblDisease As System.Windows.Forms.Label
    Friend WithEvents txtResult As System.Windows.Forms.TextBox
    Friend WithEvents cmbRInId As System.Windows.Forms.ComboBox
    Friend WithEvents txtRefBy As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cmbTest As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents btnTestUpdate As System.Windows.Forms.Button
    Friend WithEvents btnTestAdd As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTestNo As System.Windows.Forms.TextBox
    Friend WithEvents btnNewTest As System.Windows.Forms.Button
    Friend WithEvents btntestDel As System.Windows.Forms.Button
End Class
