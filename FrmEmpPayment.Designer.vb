<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmpPayment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEmpPayment))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.TxtEmpName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.CmbEmpId = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.CmbPaidBy = New System.Windows.Forms.ComboBox
        Me.LblPaidBy = New System.Windows.Forms.Label
        Me.TxtPayment = New System.Windows.Forms.TextBox
        Me.LblPayment = New System.Windows.Forms.Label
        Me.TxtPresentDays = New System.Windows.Forms.TextBox
        Me.LblPresentDays = New System.Windows.Forms.Label
        Me.StartDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.EndTimePicker = New System.Windows.Forms.DateTimePicker
        Me.LblEnd = New System.Windows.Forms.Label
        Me.LblStart = New System.Windows.Forms.Label
        Me.TxtBasicSal = New System.Windows.Forms.TextBox
        Me.LblBasicSal = New System.Windows.Forms.Label
        Me.lbldocdet = New System.Windows.Forms.Label
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.TxtEmpName)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.CmbEmpId)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.CmbPaidBy)
        Me.Panel1.Controls.Add(Me.LblPaidBy)
        Me.Panel1.Controls.Add(Me.TxtPayment)
        Me.Panel1.Controls.Add(Me.LblPayment)
        Me.Panel1.Controls.Add(Me.TxtPresentDays)
        Me.Panel1.Controls.Add(Me.LblPresentDays)
        Me.Panel1.Controls.Add(Me.StartDateTimePicker)
        Me.Panel1.Controls.Add(Me.EndTimePicker)
        Me.Panel1.Controls.Add(Me.LblEnd)
        Me.Panel1.Controls.Add(Me.LblStart)
        Me.Panel1.Controls.Add(Me.TxtBasicSal)
        Me.Panel1.Controls.Add(Me.LblBasicSal)
        Me.Panel1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(23, 75)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(545, 485)
        Me.Panel1.TabIndex = 122
        '
        'TxtEmpName
        '
        Me.TxtEmpName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.TxtEmpName.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmpName.Location = New System.Drawing.Point(260, 69)
        Me.TxtEmpName.Name = "TxtEmpName"
        Me.TxtEmpName.Size = New System.Drawing.Size(259, 29)
        Me.TxtEmpName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(64, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 22)
        Me.Label1.TabIndex = 141
        Me.Label1.Text = "Employee Id:"
        '
        'CmbEmpId
        '
        Me.CmbEmpId.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbEmpId.FormattingEnabled = True
        Me.CmbEmpId.Location = New System.Drawing.Point(260, 19)
        Me.CmbEmpId.Name = "CmbEmpId"
        Me.CmbEmpId.Size = New System.Drawing.Size(122, 30)
        Me.CmbEmpId.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(64, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 22)
        Me.Label2.TabIndex = 140
        Me.Label2.Text = "Employee Name:"
        '
        'CmbPaidBy
        '
        Me.CmbPaidBy.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbPaidBy.FormattingEnabled = True
        Me.CmbPaidBy.Location = New System.Drawing.Point(257, 417)
        Me.CmbPaidBy.Name = "CmbPaidBy"
        Me.CmbPaidBy.Size = New System.Drawing.Size(259, 30)
        Me.CmbPaidBy.TabIndex = 7
        '
        'LblPaidBy
        '
        Me.LblPaidBy.AutoSize = True
        Me.LblPaidBy.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPaidBy.ForeColor = System.Drawing.Color.White
        Me.LblPaidBy.Location = New System.Drawing.Point(64, 422)
        Me.LblPaidBy.Name = "LblPaidBy"
        Me.LblPaidBy.Size = New System.Drawing.Size(79, 22)
        Me.LblPaidBy.TabIndex = 132
        Me.LblPaidBy.Text = "Paid By:"
        '
        'TxtPayment
        '
        Me.TxtPayment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.TxtPayment.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPayment.Location = New System.Drawing.Point(260, 358)
        Me.TxtPayment.Name = "TxtPayment"
        Me.TxtPayment.Size = New System.Drawing.Size(256, 29)
        Me.TxtPayment.TabIndex = 6
        '
        'LblPayment
        '
        Me.LblPayment.AutoSize = True
        Me.LblPayment.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPayment.ForeColor = System.Drawing.Color.White
        Me.LblPayment.Location = New System.Drawing.Point(64, 361)
        Me.LblPayment.Name = "LblPayment"
        Me.LblPayment.Size = New System.Drawing.Size(86, 22)
        Me.LblPayment.TabIndex = 131
        Me.LblPayment.Text = "Payment:"
        '
        'TxtPresentDays
        '
        Me.TxtPresentDays.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.TxtPresentDays.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPresentDays.Location = New System.Drawing.Point(260, 298)
        Me.TxtPresentDays.Name = "TxtPresentDays"
        Me.TxtPresentDays.Size = New System.Drawing.Size(256, 29)
        Me.TxtPresentDays.TabIndex = 5
        '
        'LblPresentDays
        '
        Me.LblPresentDays.AutoSize = True
        Me.LblPresentDays.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPresentDays.ForeColor = System.Drawing.Color.White
        Me.LblPresentDays.Location = New System.Drawing.Point(64, 301)
        Me.LblPresentDays.Name = "LblPresentDays"
        Me.LblPresentDays.Size = New System.Drawing.Size(123, 22)
        Me.LblPresentDays.TabIndex = 130
        Me.LblPresentDays.Text = "Present Days:"
        '
        'StartDateTimePicker
        '
        Me.StartDateTimePicker.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.StartDateTimePicker.Location = New System.Drawing.Point(260, 186)
        Me.StartDateTimePicker.Name = "StartDateTimePicker"
        Me.StartDateTimePicker.Size = New System.Drawing.Size(259, 27)
        Me.StartDateTimePicker.TabIndex = 3
        '
        'EndTimePicker
        '
        Me.EndTimePicker.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EndTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.EndTimePicker.Location = New System.Drawing.Point(260, 239)
        Me.EndTimePicker.Name = "EndTimePicker"
        Me.EndTimePicker.Size = New System.Drawing.Size(259, 27)
        Me.EndTimePicker.TabIndex = 4
        '
        'LblEnd
        '
        Me.LblEnd.AutoSize = True
        Me.LblEnd.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEnd.ForeColor = System.Drawing.Color.White
        Me.LblEnd.Location = New System.Drawing.Point(64, 239)
        Me.LblEnd.Name = "LblEnd"
        Me.LblEnd.Size = New System.Drawing.Size(92, 22)
        Me.LblEnd.TabIndex = 129
        Me.LblEnd.Text = "End Date:"
        '
        'LblStart
        '
        Me.LblStart.AutoSize = True
        Me.LblStart.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStart.ForeColor = System.Drawing.Color.White
        Me.LblStart.Location = New System.Drawing.Point(64, 186)
        Me.LblStart.Name = "LblStart"
        Me.LblStart.Size = New System.Drawing.Size(100, 22)
        Me.LblStart.TabIndex = 128
        Me.LblStart.Text = "Start Date:"
        '
        'TxtBasicSal
        '
        Me.TxtBasicSal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.TxtBasicSal.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBasicSal.Location = New System.Drawing.Point(260, 122)
        Me.TxtBasicSal.Name = "TxtBasicSal"
        Me.TxtBasicSal.Size = New System.Drawing.Size(256, 29)
        Me.TxtBasicSal.TabIndex = 2
        '
        'LblBasicSal
        '
        Me.LblBasicSal.AutoSize = True
        Me.LblBasicSal.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBasicSal.ForeColor = System.Drawing.Color.White
        Me.LblBasicSal.Location = New System.Drawing.Point(64, 129)
        Me.LblBasicSal.Name = "LblBasicSal"
        Me.LblBasicSal.Size = New System.Drawing.Size(118, 22)
        Me.LblBasicSal.TabIndex = 127
        Me.LblBasicSal.Text = "Basic Salary:"
        '
        'lbldocdet
        '
        Me.lbldocdet.AutoSize = True
        Me.lbldocdet.BackColor = System.Drawing.Color.Transparent
        Me.lbldocdet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbldocdet.Font = New System.Drawing.Font("Palatino Linotype", 40.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldocdet.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.lbldocdet.Location = New System.Drawing.Point(282, -2)
        Me.lbldocdet.Name = "lbldocdet"
        Me.lbldocdet.Size = New System.Drawing.Size(493, 74)
        Me.lbldocdet.TabIndex = 132
        Me.lbldocdet.Text = "Employee Payment"
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
        Me.PnlCustOperations.Location = New System.Drawing.Point(574, 171)
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
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
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
        Me.PnlCustNavigation.Location = New System.Drawing.Point(574, 75)
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
        Me.BtnNext.TabIndex = 10
        Me.BtnNext.Text = "Next>>"
        Me.BtnNext.UseVisualStyleBackColor = True
        '
        'BtnLast
        '
        Me.BtnLast.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLast.Location = New System.Drawing.Point(332, 22)
        Me.BtnLast.Name = "BtnLast"
        Me.BtnLast.Size = New System.Drawing.Size(91, 39)
        Me.BtnLast.TabIndex = 11
        Me.BtnLast.Text = "Last"
        Me.BtnLast.UseVisualStyleBackColor = True
        '
        'BtnPrev
        '
        Me.BtnPrev.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrev.Location = New System.Drawing.Point(119, 22)
        Me.BtnPrev.Name = "BtnPrev"
        Me.BtnPrev.Size = New System.Drawing.Size(104, 39)
        Me.BtnPrev.TabIndex = 9
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
        Me.BtnFirst.TabIndex = 8
        Me.BtnFirst.Text = "First"
        Me.BtnFirst.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(574, 280)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(643, 280)
        Me.DataGridView1.TabIndex = 133
        '
        'lblLnkPrint
        '
        Me.lblLnkPrint.AutoSize = True
        Me.lblLnkPrint.BackColor = System.Drawing.Color.Lavender
        Me.lblLnkPrint.Font = New System.Drawing.Font("Perpetua Titling MT", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLnkPrint.ForeColor = System.Drawing.Color.White
        Me.lblLnkPrint.Location = New System.Drawing.Point(851, 40)
        Me.lblLnkPrint.Name = "lblLnkPrint"
        Me.lblLnkPrint.Size = New System.Drawing.Size(105, 32)
        Me.lblLnkPrint.TabIndex = 168
        Me.lblLnkPrint.TabStop = True
        Me.lblLnkPrint.Text = "Print"
        '
        'FrmEmpPayment
        '
        Me.AcceptButton = Me.btnAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1276, 645)
        Me.Controls.Add(Me.lblLnkPrint)
        Me.Controls.Add(Me.PnlCustOperations)
        Me.Controls.Add(Me.PnlCustNavigation)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lbldocdet)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Name = "FrmEmpPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FrmEmpPayment"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PnlCustOperations.ResumeLayout(False)
        Me.PnlCustNavigation.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CmbPaidBy As System.Windows.Forms.ComboBox
    Friend WithEvents LblPaidBy As System.Windows.Forms.Label
    Friend WithEvents TxtPayment As System.Windows.Forms.TextBox
    Friend WithEvents LblPayment As System.Windows.Forms.Label
    Friend WithEvents TxtPresentDays As System.Windows.Forms.TextBox
    Friend WithEvents LblPresentDays As System.Windows.Forms.Label
    Friend WithEvents StartDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents EndTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblEnd As System.Windows.Forms.Label
    Friend WithEvents LblStart As System.Windows.Forms.Label
    Friend WithEvents TxtBasicSal As System.Windows.Forms.TextBox
    Friend WithEvents LblBasicSal As System.Windows.Forms.Label
    Friend WithEvents lbldocdet As System.Windows.Forms.Label
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
    Friend WithEvents TxtEmpName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbEmpId As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents lblLnkPrint As System.Windows.Forms.LinkLabel
End Class
