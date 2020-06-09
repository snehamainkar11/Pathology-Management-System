<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Patient_Checkup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Patient_Checkup))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.btnnewid = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.rdbFemale = New System.Windows.Forms.RadioButton
        Me.rdbmale = New System.Windows.Forms.RadioButton
        Me.lblPatId = New System.Windows.Forms.Label
        Me.txtAge = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lstTestNm = New System.Windows.Forms.ListBox
        Me.CmbPatId = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.CmbDisease = New System.Windows.Forms.ComboBox
        Me.CmbSampleBy = New System.Windows.Forms.ComboBox
        Me.lblDoctname = New System.Windows.Forms.Label
        Me.lblDisease = New System.Windows.Forms.Label
        Me.txtContact = New System.Windows.Forms.TextBox
        Me.lblContactno = New System.Windows.Forms.Label
        Me.lblPatientName = New System.Windows.Forms.Label
        Me.txtPatientName = New System.Windows.Forms.TextBox
        Me.txtPatChkpId = New System.Windows.Forms.TextBox
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.txtPatientAddress = New System.Windows.Forms.TextBox
        Me.lblgendr = New System.Windows.Forms.Label
        Me.lblAge = New System.Windows.Forms.Label
        Me.lblEmail = New System.Windows.Forms.Label
        Me.lblPatientAdd = New System.Windows.Forms.Label
        Me.lblPatientcheckupId = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lbldocdet = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
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
        Me.lblLnkPrint = New System.Windows.Forms.LinkLabel
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlCustNavigation.SuspendLayout()
        Me.PnlCustOperations.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnnewid
        '
        Me.btnnewid.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnnewid.BackColor = System.Drawing.Color.Black
        Me.btnnewid.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnewid.ForeColor = System.Drawing.Color.White
        Me.btnnewid.Location = New System.Drawing.Point(407, -2)
        Me.btnnewid.Name = "btnnewid"
        Me.btnnewid.Size = New System.Drawing.Size(125, 36)
        Me.btnnewid.TabIndex = 20
        Me.btnnewid.Text = "New Id"
        Me.btnnewid.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.rdbFemale)
        Me.Panel2.Controls.Add(Me.rdbmale)
        Me.Panel2.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(304, 243)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(228, 44)
        Me.Panel2.TabIndex = 5
        '
        'rdbFemale
        '
        Me.rdbFemale.AutoSize = True
        Me.rdbFemale.Location = New System.Drawing.Point(110, 7)
        Me.rdbFemale.Name = "rdbFemale"
        Me.rdbFemale.Size = New System.Drawing.Size(88, 26)
        Me.rdbFemale.TabIndex = 1
        Me.rdbFemale.TabStop = True
        Me.rdbFemale.Text = "Female"
        Me.rdbFemale.UseVisualStyleBackColor = True
        '
        'rdbmale
        '
        Me.rdbmale.AutoSize = True
        Me.rdbmale.Location = New System.Drawing.Point(3, 7)
        Me.rdbmale.Name = "rdbmale"
        Me.rdbmale.Size = New System.Drawing.Size(70, 26)
        Me.rdbmale.TabIndex = 5
        Me.rdbmale.TabStop = True
        Me.rdbmale.Text = "Male"
        Me.rdbmale.UseVisualStyleBackColor = True
        '
        'lblPatId
        '
        Me.lblPatId.AutoSize = True
        Me.lblPatId.BackColor = System.Drawing.Color.Transparent
        Me.lblPatId.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatId.ForeColor = System.Drawing.Color.White
        Me.lblPatId.Location = New System.Drawing.Point(70, 50)
        Me.lblPatId.Name = "lblPatId"
        Me.lblPatId.Size = New System.Drawing.Size(95, 22)
        Me.lblPatId.TabIndex = 13
        Me.lblPatId.Text = "Patient Id:"
        '
        'txtAge
        '
        Me.txtAge.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.Location = New System.Drawing.Point(304, 301)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(92, 29)
        Me.txtAge.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.lstTestNm)
        Me.Panel1.Controls.Add(Me.CmbPatId)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.CmbDisease)
        Me.Panel1.Controls.Add(Me.CmbSampleBy)
        Me.Panel1.Controls.Add(Me.lblDoctname)
        Me.Panel1.Controls.Add(Me.lblDisease)
        Me.Panel1.Controls.Add(Me.txtContact)
        Me.Panel1.Controls.Add(Me.lblContactno)
        Me.Panel1.Controls.Add(Me.btnnewid)
        Me.Panel1.Controls.Add(Me.lblPatientName)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.lblPatId)
        Me.Panel1.Controls.Add(Me.txtAge)
        Me.Panel1.Controls.Add(Me.txtPatientName)
        Me.Panel1.Controls.Add(Me.txtPatChkpId)
        Me.Panel1.Controls.Add(Me.txtEmail)
        Me.Panel1.Controls.Add(Me.txtPatientAddress)
        Me.Panel1.Controls.Add(Me.lblgendr)
        Me.Panel1.Controls.Add(Me.lblAge)
        Me.Panel1.Controls.Add(Me.lblEmail)
        Me.Panel1.Controls.Add(Me.lblPatientAdd)
        Me.Panel1.Controls.Add(Me.lblPatientcheckupId)
        Me.Panel1.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(20, 77)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(614, 533)
        Me.Panel1.TabIndex = 31
        '
        'lstTestNm
        '
        Me.lstTestNm.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTestNm.FormattingEnabled = True
        Me.lstTestNm.ItemHeight = 19
        Me.lstTestNm.Location = New System.Drawing.Point(304, 483)
        Me.lstTestNm.Name = "lstTestNm"
        Me.lstTestNm.ScrollAlwaysVisible = True
        Me.lstTestNm.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstTestNm.Size = New System.Drawing.Size(228, 42)
        Me.lstTestNm.TabIndex = 10
        '
        'CmbPatId
        '
        Me.CmbPatId.FormattingEnabled = True
        Me.CmbPatId.Location = New System.Drawing.Point(304, 47)
        Me.CmbPatId.Name = "CmbPatId"
        Me.CmbPatId.Size = New System.Drawing.Size(121, 30)
        Me.CmbPatId.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(70, 492)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 22)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Suggested Test:"
        '
        'CmbDisease
        '
        Me.CmbDisease.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbDisease.FormattingEnabled = True
        Me.CmbDisease.Location = New System.Drawing.Point(304, 442)
        Me.CmbDisease.Name = "CmbDisease"
        Me.CmbDisease.Size = New System.Drawing.Size(228, 30)
        Me.CmbDisease.TabIndex = 9
        '
        'CmbSampleBy
        '
        Me.CmbSampleBy.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSampleBy.FormattingEnabled = True
        Me.CmbSampleBy.Location = New System.Drawing.Point(304, 398)
        Me.CmbSampleBy.Name = "CmbSampleBy"
        Me.CmbSampleBy.Size = New System.Drawing.Size(228, 30)
        Me.CmbSampleBy.TabIndex = 8
        '
        'lblDoctname
        '
        Me.lblDoctname.AutoSize = True
        Me.lblDoctname.BackColor = System.Drawing.Color.Transparent
        Me.lblDoctname.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDoctname.ForeColor = System.Drawing.Color.White
        Me.lblDoctname.Location = New System.Drawing.Point(70, 401)
        Me.lblDoctname.Name = "lblDoctname"
        Me.lblDoctname.Size = New System.Drawing.Size(107, 22)
        Me.lblDoctname.TabIndex = 40
        Me.lblDoctname.Text = "Sample  By:"
        '
        'lblDisease
        '
        Me.lblDisease.AutoSize = True
        Me.lblDisease.BackColor = System.Drawing.Color.Transparent
        Me.lblDisease.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisease.ForeColor = System.Drawing.Color.White
        Me.lblDisease.Location = New System.Drawing.Point(70, 450)
        Me.lblDisease.Name = "lblDisease"
        Me.lblDisease.Size = New System.Drawing.Size(78, 22)
        Me.lblDisease.TabIndex = 39
        Me.lblDisease.Text = "Disease:"
        '
        'txtContact
        '
        Me.txtContact.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.Location = New System.Drawing.Point(304, 350)
        Me.txtContact.MaxLength = 10
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(228, 29)
        Me.txtContact.TabIndex = 7
        '
        'lblContactno
        '
        Me.lblContactno.AutoSize = True
        Me.lblContactno.BackColor = System.Drawing.Color.Transparent
        Me.lblContactno.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContactno.ForeColor = System.Drawing.Color.White
        Me.lblContactno.Location = New System.Drawing.Point(70, 350)
        Me.lblContactno.Name = "lblContactno"
        Me.lblContactno.Size = New System.Drawing.Size(109, 22)
        Me.lblContactno.TabIndex = 37
        Me.lblContactno.Text = "Contact No:"
        '
        'lblPatientName
        '
        Me.lblPatientName.AutoSize = True
        Me.lblPatientName.BackColor = System.Drawing.Color.Transparent
        Me.lblPatientName.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientName.ForeColor = System.Drawing.Color.White
        Me.lblPatientName.Location = New System.Drawing.Point(70, 97)
        Me.lblPatientName.Name = "lblPatientName"
        Me.lblPatientName.Size = New System.Drawing.Size(126, 22)
        Me.lblPatientName.TabIndex = 21
        Me.lblPatientName.Text = "Patient Name:"
        '
        'txtPatientName
        '
        Me.txtPatientName.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientName.Location = New System.Drawing.Point(304, 90)
        Me.txtPatientName.Name = "txtPatientName"
        Me.txtPatientName.Size = New System.Drawing.Size(228, 29)
        Me.txtPatientName.TabIndex = 2
        '
        'txtPatChkpId
        '
        Me.txtPatChkpId.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatChkpId.Location = New System.Drawing.Point(304, 3)
        Me.txtPatChkpId.Name = "txtPatChkpId"
        Me.txtPatChkpId.Size = New System.Drawing.Size(92, 29)
        Me.txtPatChkpId.TabIndex = 0
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(304, 196)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(228, 29)
        Me.txtEmail.TabIndex = 4
        '
        'txtPatientAddress
        '
        Me.txtPatientAddress.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientAddress.Location = New System.Drawing.Point(304, 129)
        Me.txtPatientAddress.Multiline = True
        Me.txtPatientAddress.Name = "txtPatientAddress"
        Me.txtPatientAddress.Size = New System.Drawing.Size(228, 54)
        Me.txtPatientAddress.TabIndex = 3
        '
        'lblgendr
        '
        Me.lblgendr.AutoSize = True
        Me.lblgendr.BackColor = System.Drawing.Color.Transparent
        Me.lblgendr.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgendr.ForeColor = System.Drawing.Color.White
        Me.lblgendr.Location = New System.Drawing.Point(70, 254)
        Me.lblgendr.Name = "lblgendr"
        Me.lblgendr.Size = New System.Drawing.Size(76, 22)
        Me.lblgendr.TabIndex = 5
        Me.lblgendr.Text = "Gender:"
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.BackColor = System.Drawing.Color.Transparent
        Me.lblAge.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.ForeColor = System.Drawing.Color.White
        Me.lblAge.Location = New System.Drawing.Point(70, 301)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(47, 22)
        Me.lblAge.TabIndex = 3
        Me.lblAge.Text = "Age:"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.White
        Me.lblEmail.Location = New System.Drawing.Point(70, 199)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(63, 22)
        Me.lblEmail.TabIndex = 2
        Me.lblEmail.Text = "Email:"
        '
        'lblPatientAdd
        '
        Me.lblPatientAdd.AutoSize = True
        Me.lblPatientAdd.BackColor = System.Drawing.Color.Transparent
        Me.lblPatientAdd.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientAdd.ForeColor = System.Drawing.Color.White
        Me.lblPatientAdd.Location = New System.Drawing.Point(70, 146)
        Me.lblPatientAdd.Name = "lblPatientAdd"
        Me.lblPatientAdd.Size = New System.Drawing.Size(143, 22)
        Me.lblPatientAdd.TabIndex = 1
        Me.lblPatientAdd.Text = "Patient Address:"
        '
        'lblPatientcheckupId
        '
        Me.lblPatientcheckupId.AutoSize = True
        Me.lblPatientcheckupId.BackColor = System.Drawing.Color.Transparent
        Me.lblPatientcheckupId.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientcheckupId.ForeColor = System.Drawing.Color.White
        Me.lblPatientcheckupId.Location = New System.Drawing.Point(70, 6)
        Me.lblPatientcheckupId.Name = "lblPatientcheckupId"
        Me.lblPatientcheckupId.Size = New System.Drawing.Size(39, 22)
        Me.lblPatientcheckupId.TabIndex = 0
        Me.lblPatientcheckupId.Text = "PId"
        '
        'lbldocdet
        '
        Me.lbldocdet.AutoSize = True
        Me.lbldocdet.BackColor = System.Drawing.Color.Transparent
        Me.lbldocdet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbldocdet.Font = New System.Drawing.Font("Palatino Linotype", 40.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldocdet.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.lbldocdet.Location = New System.Drawing.Point(382, 0)
        Me.lbldocdet.Name = "lbldocdet"
        Me.lbldocdet.Size = New System.Drawing.Size(429, 74)
        Me.lbldocdet.TabIndex = 133
        Me.lbldocdet.Text = "Patient Checkup"
        '
        'DataGridView1
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(640, 298)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Size = New System.Drawing.Size(699, 312)
        Me.DataGridView1.TabIndex = 147
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
        Me.PnlCustNavigation.Location = New System.Drawing.Point(642, 100)
        Me.PnlCustNavigation.Name = "PnlCustNavigation"
        Me.PnlCustNavigation.Size = New System.Drawing.Size(445, 96)
        Me.PnlCustNavigation.TabIndex = 149
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
        Me.PnlCustOperations.Location = New System.Drawing.Point(642, 202)
        Me.PnlCustOperations.Name = "PnlCustOperations"
        Me.PnlCustOperations.Size = New System.Drawing.Size(445, 93)
        Me.PnlCustOperations.TabIndex = 148
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
        'lblLnkPrint
        '
        Me.lblLnkPrint.AutoSize = True
        Me.lblLnkPrint.BackColor = System.Drawing.Color.Lavender
        Me.lblLnkPrint.Font = New System.Drawing.Font("Perpetua Titling MT", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLnkPrint.ForeColor = System.Drawing.Color.White
        Me.lblLnkPrint.Location = New System.Drawing.Point(882, 65)
        Me.lblLnkPrint.Name = "lblLnkPrint"
        Me.lblLnkPrint.Size = New System.Drawing.Size(105, 32)
        Me.lblLnkPrint.TabIndex = 166
        Me.lblLnkPrint.TabStop = True
        Me.lblLnkPrint.Text = "Print"
        '
        'Patient_Checkup
        '
        Me.AcceptButton = Me.btnnewid
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1362, 707)
        Me.Controls.Add(Me.lblLnkPrint)
        Me.Controls.Add(Me.PnlCustNavigation)
        Me.Controls.Add(Me.PnlCustOperations)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lbldocdet)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Patient_Checkup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Patient_checkup"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlCustNavigation.ResumeLayout(False)
        Me.PnlCustOperations.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnnewid As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents rdbFemale As System.Windows.Forms.RadioButton
    Friend WithEvents rdbmale As System.Windows.Forms.RadioButton
    Friend WithEvents lblPatId As System.Windows.Forms.Label
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtPatientName As System.Windows.Forms.TextBox
    Friend WithEvents txtPatChkpId As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtPatientAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblgendr As System.Windows.Forms.Label
    Friend WithEvents lblAge As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblPatientAdd As System.Windows.Forms.Label
    Friend WithEvents lblPatientcheckupId As System.Windows.Forms.Label
    Friend WithEvents lblPatientName As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lbldocdet As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbDisease As System.Windows.Forms.ComboBox
    Friend WithEvents CmbSampleBy As System.Windows.Forms.ComboBox
    Friend WithEvents lblDoctname As System.Windows.Forms.Label
    Friend WithEvents lblDisease As System.Windows.Forms.Label
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents lblContactno As System.Windows.Forms.Label
    Friend WithEvents CmbPatId As System.Windows.Forms.ComboBox
    Friend WithEvents lstTestNm As System.Windows.Forms.ListBox
    Friend WithEvents lblLnkPrint As System.Windows.Forms.LinkLabel
End Class
