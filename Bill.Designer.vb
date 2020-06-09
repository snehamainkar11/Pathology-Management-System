<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bill
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bill))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cmbPaidBy = New System.Windows.Forms.ComboBox
        Me.btnnewid = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtPatNm = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.LblSerBillDate = New System.Windows.Forms.Label
        Me.dtpBill = New System.Windows.Forms.DateTimePicker
        Me.txtBillNo = New System.Windows.Forms.TextBox
        Me.LblSerBillNo = New System.Windows.Forms.Label
        Me.CmbPatId = New System.Windows.Forms.ComboBox
        Me.LblSerBillPatName = New System.Windows.Forms.Label
        Me.btnTestUpdate = New System.Windows.Forms.Button
        Me.btnTestAdd = New System.Windows.Forms.Button
        Me.btnTestDel = New System.Windows.Forms.Button
        Me.lbldocdet = New System.Windows.Forms.Label
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.LblSerBillrate = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.txtCost = New System.Windows.Forms.TextBox
        Me.txtTestNo = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.LblSerName = New System.Windows.Forms.Label
        Me.cmbTest = New System.Windows.Forms.ComboBox
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.btnTotal = New System.Windows.Forms.Button
        Me.btnNewTestNo = New System.Windows.Forms.Button
        Me.lblLnkPrint = New System.Windows.Forms.LinkLabel
        Me.BtnFirst = New System.Windows.Forms.Button
        Me.BtnPrev = New System.Windows.Forms.Button
        Me.BtnLast = New System.Windows.Forms.Button
        Me.BtnNext = New System.Windows.Forms.Button
        Me.PnlCustNavigation = New System.Windows.Forms.Panel
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.PnlCustOperations = New System.Windows.Forms.Panel
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.PnlCustNavigation.SuspendLayout()
        Me.PnlCustOperations.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(596, 270)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(679, 317)
        Me.DataGridView1.TabIndex = 98
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.Pathology.My.Resources.Resources.MdiImage
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.cmbPaidBy)
        Me.Panel1.Controls.Add(Me.btnnewid)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtPatNm)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.LblSerBillDate)
        Me.Panel1.Controls.Add(Me.dtpBill)
        Me.Panel1.Controls.Add(Me.txtBillNo)
        Me.Panel1.Controls.Add(Me.LblSerBillNo)
        Me.Panel1.Controls.Add(Me.CmbPatId)
        Me.Panel1.Controls.Add(Me.LblSerBillPatName)
        Me.Panel1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(10, 87)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(580, 267)
        Me.Panel1.TabIndex = 99
        '
        'cmbPaidBy
        '
        Me.cmbPaidBy.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPaidBy.FormattingEnabled = True
        Me.cmbPaidBy.Location = New System.Drawing.Point(223, 214)
        Me.cmbPaidBy.Name = "cmbPaidBy"
        Me.cmbPaidBy.Size = New System.Drawing.Size(243, 30)
        Me.cmbPaidBy.TabIndex = 3
        '
        'btnnewid
        '
        Me.btnnewid.AllowDrop = True
        Me.btnnewid.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnnewid.BackColor = System.Drawing.Color.Black
        Me.btnnewid.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnewid.ForeColor = System.Drawing.Color.White
        Me.btnnewid.Location = New System.Drawing.Point(356, 48)
        Me.btnnewid.Name = "btnnewid"
        Me.btnnewid.Size = New System.Drawing.Size(138, 36)
        Me.btnnewid.TabIndex = 155
        Me.btnnewid.Text = "New Bill No"
        Me.btnnewid.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(54, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 22)
        Me.Label4.TabIndex = 148
        Me.Label4.Text = "Paid By:"
        '
        'txtPatNm
        '
        Me.txtPatNm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.txtPatNm.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatNm.Location = New System.Drawing.Point(223, 164)
        Me.txtPatNm.Name = "txtPatNm"
        Me.txtPatNm.Size = New System.Drawing.Size(243, 29)
        Me.txtPatNm.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(54, 164)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 22)
        Me.Label1.TabIndex = 144
        Me.Label1.Text = "Patient Name:"
        '
        'LblSerBillDate
        '
        Me.LblSerBillDate.AutoSize = True
        Me.LblSerBillDate.BackColor = System.Drawing.Color.Transparent
        Me.LblSerBillDate.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSerBillDate.ForeColor = System.Drawing.Color.White
        Me.LblSerBillDate.Location = New System.Drawing.Point(299, 13)
        Me.LblSerBillDate.Name = "LblSerBillDate"
        Me.LblSerBillDate.Size = New System.Drawing.Size(54, 22)
        Me.LblSerBillDate.TabIndex = 113
        Me.LblSerBillDate.Text = "Date:"
        '
        'dtpBill
        '
        Me.dtpBill.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpBill.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpBill.Location = New System.Drawing.Point(374, 8)
        Me.dtpBill.Name = "dtpBill"
        Me.dtpBill.Size = New System.Drawing.Size(133, 29)
        Me.dtpBill.TabIndex = 112
        '
        'txtBillNo
        '
        Me.txtBillNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.txtBillNo.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBillNo.Location = New System.Drawing.Point(223, 52)
        Me.txtBillNo.Name = "txtBillNo"
        Me.txtBillNo.Size = New System.Drawing.Size(110, 29)
        Me.txtBillNo.TabIndex = 0
        '
        'LblSerBillNo
        '
        Me.LblSerBillNo.AutoSize = True
        Me.LblSerBillNo.BackColor = System.Drawing.Color.Transparent
        Me.LblSerBillNo.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSerBillNo.ForeColor = System.Drawing.Color.White
        Me.LblSerBillNo.Location = New System.Drawing.Point(54, 55)
        Me.LblSerBillNo.Name = "LblSerBillNo"
        Me.LblSerBillNo.Size = New System.Drawing.Size(72, 22)
        Me.LblSerBillNo.TabIndex = 109
        Me.LblSerBillNo.Text = "Bill No:"
        '
        'CmbPatId
        '
        Me.CmbPatId.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbPatId.FormattingEnabled = True
        Me.CmbPatId.Location = New System.Drawing.Point(223, 107)
        Me.CmbPatId.Name = "CmbPatId"
        Me.CmbPatId.Size = New System.Drawing.Size(110, 30)
        Me.CmbPatId.TabIndex = 1
        '
        'LblSerBillPatName
        '
        Me.LblSerBillPatName.AutoSize = True
        Me.LblSerBillPatName.BackColor = System.Drawing.Color.Transparent
        Me.LblSerBillPatName.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSerBillPatName.ForeColor = System.Drawing.Color.White
        Me.LblSerBillPatName.Location = New System.Drawing.Point(54, 110)
        Me.LblSerBillPatName.Name = "LblSerBillPatName"
        Me.LblSerBillPatName.Size = New System.Drawing.Size(44, 22)
        Me.LblSerBillPatName.TabIndex = 106
        Me.LblSerBillPatName.Text = "PId:"
        '
        'btnTestUpdate
        '
        Me.btnTestUpdate.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTestUpdate.Location = New System.Drawing.Point(446, 143)
        Me.btnTestUpdate.Name = "btnTestUpdate"
        Me.btnTestUpdate.Size = New System.Drawing.Size(104, 38)
        Me.btnTestUpdate.TabIndex = 9
        Me.btnTestUpdate.Text = "Update"
        Me.btnTestUpdate.UseVisualStyleBackColor = True
        '
        'btnTestAdd
        '
        Me.btnTestAdd.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTestAdd.Location = New System.Drawing.Point(446, 99)
        Me.btnTestAdd.Name = "btnTestAdd"
        Me.btnTestAdd.Size = New System.Drawing.Size(104, 38)
        Me.btnTestAdd.TabIndex = 8
        Me.btnTestAdd.Text = "Add"
        Me.btnTestAdd.UseVisualStyleBackColor = True
        '
        'btnTestDel
        '
        Me.btnTestDel.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTestDel.Location = New System.Drawing.Point(446, 187)
        Me.btnTestDel.Name = "btnTestDel"
        Me.btnTestDel.Size = New System.Drawing.Size(104, 38)
        Me.btnTestDel.TabIndex = 10
        Me.btnTestDel.Text = "Delete"
        Me.btnTestDel.UseVisualStyleBackColor = True
        '
        'lbldocdet
        '
        Me.lbldocdet.AutoSize = True
        Me.lbldocdet.BackColor = System.Drawing.Color.Transparent
        Me.lbldocdet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbldocdet.Font = New System.Drawing.Font("Palatino Linotype", 40.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldocdet.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.lbldocdet.Location = New System.Drawing.Point(386, 0)
        Me.lbldocdet.Name = "lbldocdet"
        Me.lbldocdet.Size = New System.Drawing.Size(313, 74)
        Me.lbldocdet.TabIndex = 140
        Me.lbldocdet.Text = "Bill Details"
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(14, 83)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(390, 161)
        Me.DataGridView2.TabIndex = 141
        '
        'LblSerBillrate
        '
        Me.LblSerBillrate.AutoSize = True
        Me.LblSerBillrate.BackColor = System.Drawing.Color.Transparent
        Me.LblSerBillrate.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSerBillrate.ForeColor = System.Drawing.Color.White
        Me.LblSerBillrate.Location = New System.Drawing.Point(316, 10)
        Me.LblSerBillrate.Name = "LblSerBillrate"
        Me.LblSerBillrate.Size = New System.Drawing.Size(53, 22)
        Me.LblSerBillrate.TabIndex = 108
        Me.LblSerBillrate.Text = "Cost:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(10, 264)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 22)
        Me.Label2.TabIndex = 145
        Me.Label2.Text = "Total Amount:"
        '
        'txtTotal
        '
        Me.txtTotal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.txtTotal.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(160, 261)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(243, 29)
        Me.txtTotal.TabIndex = 146
        '
        'txtCost
        '
        Me.txtCost.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.txtCost.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCost.Location = New System.Drawing.Point(291, 43)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(110, 29)
        Me.txtCost.TabIndex = 7
        '
        'txtTestNo
        '
        Me.txtTestNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.txtTestNo.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTestNo.Location = New System.Drawing.Point(16, 44)
        Me.txtTestNo.Name = "txtTestNo"
        Me.txtTestNo.Size = New System.Drawing.Size(78, 29)
        Me.txtTestNo.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 22)
        Me.Label3.TabIndex = 150
        Me.Label3.Text = "Test No:"
        '
        'LblSerName
        '
        Me.LblSerName.AutoSize = True
        Me.LblSerName.BackColor = System.Drawing.Color.Transparent
        Me.LblSerName.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSerName.ForeColor = System.Drawing.Color.White
        Me.LblSerName.Location = New System.Drawing.Point(143, 10)
        Me.LblSerName.Name = "LblSerName"
        Me.LblSerName.Size = New System.Drawing.Size(107, 22)
        Me.LblSerName.TabIndex = 152
        Me.LblSerName.Text = "Test  Name:"
        '
        'cmbTest
        '
        Me.cmbTest.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTest.FormattingEnabled = True
        Me.cmbTest.Location = New System.Drawing.Point(100, 43)
        Me.cmbTest.Name = "cmbTest"
        Me.cmbTest.Size = New System.Drawing.Size(185, 30)
        Me.cmbTest.TabIndex = 6
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.Pathology.My.Resources.Resources.MdiImage
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.btnTotal)
        Me.Panel3.Controls.Add(Me.btnNewTestNo)
        Me.Panel3.Controls.Add(Me.btnTestDel)
        Me.Panel3.Controls.Add(Me.DataGridView2)
        Me.Panel3.Controls.Add(Me.LblSerName)
        Me.Panel3.Controls.Add(Me.btnTestUpdate)
        Me.Panel3.Controls.Add(Me.cmbTest)
        Me.Panel3.Controls.Add(Me.btnTestAdd)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.txtTotal)
        Me.Panel3.Controls.Add(Me.LblSerBillrate)
        Me.Panel3.Controls.Add(Me.txtCost)
        Me.Panel3.Controls.Add(Me.txtTestNo)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(12, 360)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(578, 308)
        Me.Panel3.TabIndex = 154
        '
        'btnTotal
        '
        Me.btnTotal.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTotal.Location = New System.Drawing.Point(446, 252)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(104, 38)
        Me.btnTotal.TabIndex = 11
        Me.btnTotal.Text = "Total"
        Me.btnTotal.UseVisualStyleBackColor = True
        '
        'btnNewTestNo
        '
        Me.btnNewTestNo.AllowDrop = True
        Me.btnNewTestNo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnNewTestNo.BackColor = System.Drawing.Color.Black
        Me.btnNewTestNo.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewTestNo.ForeColor = System.Drawing.Color.White
        Me.btnNewTestNo.Location = New System.Drawing.Point(407, 43)
        Me.btnNewTestNo.Name = "btnNewTestNo"
        Me.btnNewTestNo.Size = New System.Drawing.Size(161, 36)
        Me.btnNewTestNo.TabIndex = 4
        Me.btnNewTestNo.Text = "New Test No"
        Me.btnNewTestNo.UseVisualStyleBackColor = False
        '
        'lblLnkPrint
        '
        Me.lblLnkPrint.AutoSize = True
        Me.lblLnkPrint.BackColor = System.Drawing.Color.Lavender
        Me.lblLnkPrint.Font = New System.Drawing.Font("Perpetua Titling MT", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLnkPrint.ForeColor = System.Drawing.Color.White
        Me.lblLnkPrint.Location = New System.Drawing.Point(785, 58)
        Me.lblLnkPrint.Name = "lblLnkPrint"
        Me.lblLnkPrint.Size = New System.Drawing.Size(105, 32)
        Me.lblLnkPrint.TabIndex = 167
        Me.lblLnkPrint.TabStop = True
        Me.lblLnkPrint.Text = "Print"
        '
        'BtnFirst
        '
        Me.BtnFirst.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFirst.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnFirst.Location = New System.Drawing.Point(13, 22)
        Me.BtnFirst.Name = "BtnFirst"
        Me.BtnFirst.Size = New System.Drawing.Size(100, 39)
        Me.BtnFirst.TabIndex = 16
        Me.BtnFirst.Text = "First"
        Me.BtnFirst.UseVisualStyleBackColor = True
        '
        'BtnPrev
        '
        Me.BtnPrev.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrev.Location = New System.Drawing.Point(119, 22)
        Me.BtnPrev.Name = "BtnPrev"
        Me.BtnPrev.Size = New System.Drawing.Size(104, 39)
        Me.BtnPrev.TabIndex = 17
        Me.BtnPrev.Text = "<<Prev"
        Me.BtnPrev.UseVisualStyleBackColor = True
        '
        'BtnLast
        '
        Me.BtnLast.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLast.Location = New System.Drawing.Point(332, 25)
        Me.BtnLast.Name = "BtnLast"
        Me.BtnLast.Size = New System.Drawing.Size(91, 36)
        Me.BtnLast.TabIndex = 19
        Me.BtnLast.Text = "Last"
        Me.BtnLast.UseVisualStyleBackColor = True
        '
        'BtnNext
        '
        Me.BtnNext.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNext.Location = New System.Drawing.Point(229, 22)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(97, 39)
        Me.BtnNext.TabIndex = 18
        Me.BtnNext.Text = "Next>>"
        Me.BtnNext.UseVisualStyleBackColor = True
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
        Me.PnlCustNavigation.Location = New System.Drawing.Point(596, 93)
        Me.PnlCustNavigation.Name = "PnlCustNavigation"
        Me.PnlCustNavigation.Size = New System.Drawing.Size(445, 80)
        Me.PnlCustNavigation.TabIndex = 125
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(229, 26)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(97, 38)
        Me.btnDelete.TabIndex = 14
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(13, 26)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(103, 38)
        Me.btnAdd.TabIndex = 12
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(119, 26)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(104, 38)
        Me.btnUpdate.TabIndex = 13
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(332, 26)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(91, 38)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
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
        Me.PnlCustOperations.Location = New System.Drawing.Point(596, 179)
        Me.PnlCustOperations.Name = "PnlCustOperations"
        Me.PnlCustOperations.Size = New System.Drawing.Size(445, 79)
        Me.PnlCustOperations.TabIndex = 124
        '
        'Bill
        '
        Me.AcceptButton = Me.btnnewid
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackgroundImage = Global.Pathology.My.Resources.Resources.MdiImage
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1306, 742)
        Me.Controls.Add(Me.lblLnkPrint)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.lbldocdet)
        Me.Controls.Add(Me.PnlCustOperations)
        Me.Controls.Add(Me.PnlCustNavigation)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Bill"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = " Bill"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.PnlCustNavigation.ResumeLayout(False)
        Me.PnlCustOperations.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtBillNo As System.Windows.Forms.TextBox
    Friend WithEvents LblSerBillNo As System.Windows.Forms.Label
    Friend WithEvents CmbPatId As System.Windows.Forms.ComboBox
    Friend WithEvents LblSerBillPatName As System.Windows.Forms.Label
    Friend WithEvents LblSerBillDate As System.Windows.Forms.Label
    Friend WithEvents dtpBill As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbldocdet As System.Windows.Forms.Label
    Friend WithEvents txtPatNm As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents btnTestUpdate As System.Windows.Forms.Button
    Friend WithEvents btnTestAdd As System.Windows.Forms.Button
    Friend WithEvents btnTestDel As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbTest As System.Windows.Forms.ComboBox
    Friend WithEvents LblSerName As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTestNo As System.Windows.Forms.TextBox
    Friend WithEvents txtCost As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LblSerBillrate As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnnewid As System.Windows.Forms.Button
    Friend WithEvents btnNewTestNo As System.Windows.Forms.Button
    Friend WithEvents btnTotal As System.Windows.Forms.Button
    Friend WithEvents cmbPaidBy As System.Windows.Forms.ComboBox
    Friend WithEvents lblLnkPrint As System.Windows.Forms.LinkLabel
    Friend WithEvents BtnFirst As System.Windows.Forms.Button
    Friend WithEvents BtnPrev As System.Windows.Forms.Button
    Friend WithEvents BtnLast As System.Windows.Forms.Button
    Friend WithEvents BtnNext As System.Windows.Forms.Button
    Friend WithEvents PnlCustNavigation As System.Windows.Forms.Panel
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents PnlCustOperations As System.Windows.Forms.Panel
End Class
