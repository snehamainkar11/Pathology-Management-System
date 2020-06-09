<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Chemical_Master
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Chemical_Master))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.lbldocdet = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnnewid = New System.Windows.Forms.Button
        Me.PnlChemicalMaster = New System.Windows.Forms.Panel
        Me.cmbDealer = New System.Windows.Forms.ComboBox
        Me.txtChemName = New System.Windows.Forms.TextBox
        Me.txtPrice = New System.Windows.Forms.TextBox
        Me.lblPrice = New System.Windows.Forms.Label
        Me.cmbObsby = New System.Windows.Forms.ComboBox
        Me.lblObservedBy = New System.Windows.Forms.Label
        Me.lblDealer = New System.Windows.Forms.Label
        Me.dtpChem = New System.Windows.Forms.DateTimePicker
        Me.lbldatechange = New System.Windows.Forms.Label
        Me.LblChemicalName = New System.Windows.Forms.Label
        Me.txtChemicalId = New System.Windows.Forms.TextBox
        Me.lblChemicalId = New System.Windows.Forms.Label
        Me.PnlCustNavigation = New System.Windows.Forms.Panel
        Me.btnNext = New System.Windows.Forms.Button
        Me.btnLast = New System.Windows.Forms.Button
        Me.btnPrev = New System.Windows.Forms.Button
        Me.btnFirst = New System.Windows.Forms.Button
        Me.PnlCustOperations = New System.Windows.Forms.Panel
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlChemicalMaster.SuspendLayout()
        Me.PnlCustNavigation.SuspendLayout()
        Me.PnlCustOperations.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(753, 281)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(642, 310)
        Me.DataGridView1.TabIndex = 142
        '
        'lbldocdet
        '
        Me.lbldocdet.AutoSize = True
        Me.lbldocdet.BackColor = System.Drawing.Color.Transparent
        Me.lbldocdet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbldocdet.Font = New System.Drawing.Font("Palatino Linotype", 40.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldocdet.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.lbldocdet.Location = New System.Drawing.Point(413, 12)
        Me.lbldocdet.Name = "lbldocdet"
        Me.lbldocdet.Size = New System.Drawing.Size(449, 74)
        Me.lbldocdet.TabIndex = 139
        Me.lbldocdet.Text = "Chemical Details"
        '
        'btnnewid
        '
        Me.btnnewid.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnnewid.BackColor = System.Drawing.Color.Black
        Me.btnnewid.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnewid.ForeColor = System.Drawing.Color.White
        Me.btnnewid.Location = New System.Drawing.Point(409, 19)
        Me.btnnewid.Name = "btnnewid"
        Me.btnnewid.Size = New System.Drawing.Size(116, 36)
        Me.btnnewid.TabIndex = 138
        Me.btnnewid.Text = "New ID"
        Me.btnnewid.UseVisualStyleBackColor = False
        '
        'PnlChemicalMaster
        '
        Me.PnlChemicalMaster.BackgroundImage = CType(resources.GetObject("PnlChemicalMaster.BackgroundImage"), System.Drawing.Image)
        Me.PnlChemicalMaster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlChemicalMaster.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlChemicalMaster.Controls.Add(Me.cmbDealer)
        Me.PnlChemicalMaster.Controls.Add(Me.txtChemName)
        Me.PnlChemicalMaster.Controls.Add(Me.txtPrice)
        Me.PnlChemicalMaster.Controls.Add(Me.lblPrice)
        Me.PnlChemicalMaster.Controls.Add(Me.cmbObsby)
        Me.PnlChemicalMaster.Controls.Add(Me.lblObservedBy)
        Me.PnlChemicalMaster.Controls.Add(Me.btnnewid)
        Me.PnlChemicalMaster.Controls.Add(Me.lblDealer)
        Me.PnlChemicalMaster.Controls.Add(Me.dtpChem)
        Me.PnlChemicalMaster.Controls.Add(Me.lbldatechange)
        Me.PnlChemicalMaster.Controls.Add(Me.LblChemicalName)
        Me.PnlChemicalMaster.Controls.Add(Me.txtChemicalId)
        Me.PnlChemicalMaster.Controls.Add(Me.lblChemicalId)
        Me.PnlChemicalMaster.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PnlChemicalMaster.Location = New System.Drawing.Point(172, 103)
        Me.PnlChemicalMaster.Name = "PnlChemicalMaster"
        Me.PnlChemicalMaster.Size = New System.Drawing.Size(575, 333)
        Me.PnlChemicalMaster.TabIndex = 137
        '
        'cmbDealer
        '
        Me.cmbDealer.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDealer.FormattingEnabled = True
        Me.cmbDealer.Location = New System.Drawing.Point(235, 121)
        Me.cmbDealer.Name = "cmbDealer"
        Me.cmbDealer.Size = New System.Drawing.Size(290, 30)
        Me.cmbDealer.TabIndex = 2
        '
        'txtChemName
        '
        Me.txtChemName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.txtChemName.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChemName.Location = New System.Drawing.Point(235, 71)
        Me.txtChemName.Name = "txtChemName"
        Me.txtChemName.Size = New System.Drawing.Size(290, 29)
        Me.txtChemName.TabIndex = 1
        '
        'txtPrice
        '
        Me.txtPrice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.txtPrice.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(235, 176)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(290, 29)
        Me.txtPrice.TabIndex = 3
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.BackColor = System.Drawing.Color.Transparent
        Me.lblPrice.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.ForeColor = System.Drawing.Color.White
        Me.lblPrice.Location = New System.Drawing.Point(41, 176)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(58, 22)
        Me.lblPrice.TabIndex = 102
        Me.lblPrice.Text = "Price:"
        '
        'cmbObsby
        '
        Me.cmbObsby.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbObsby.FormattingEnabled = True
        Me.cmbObsby.Location = New System.Drawing.Point(235, 277)
        Me.cmbObsby.Name = "cmbObsby"
        Me.cmbObsby.Size = New System.Drawing.Size(290, 30)
        Me.cmbObsby.TabIndex = 5
        '
        'lblObservedBy
        '
        Me.lblObservedBy.AutoSize = True
        Me.lblObservedBy.BackColor = System.Drawing.Color.Transparent
        Me.lblObservedBy.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObservedBy.ForeColor = System.Drawing.Color.White
        Me.lblObservedBy.Location = New System.Drawing.Point(41, 285)
        Me.lblObservedBy.Name = "lblObservedBy"
        Me.lblObservedBy.Size = New System.Drawing.Size(120, 22)
        Me.lblObservedBy.TabIndex = 101
        Me.lblObservedBy.Text = "Observed By:"
        '
        'lblDealer
        '
        Me.lblDealer.AutoSize = True
        Me.lblDealer.BackColor = System.Drawing.Color.Transparent
        Me.lblDealer.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDealer.ForeColor = System.Drawing.Color.White
        Me.lblDealer.Location = New System.Drawing.Point(41, 121)
        Me.lblDealer.Name = "lblDealer"
        Me.lblDealer.Size = New System.Drawing.Size(70, 22)
        Me.lblDealer.TabIndex = 100
        Me.lblDealer.Text = "Dealer:"
        '
        'dtpChem
        '
        Me.dtpChem.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpChem.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpChem.Location = New System.Drawing.Point(235, 230)
        Me.dtpChem.Name = "dtpChem"
        Me.dtpChem.Size = New System.Drawing.Size(290, 29)
        Me.dtpChem.TabIndex = 4
        '
        'lbldatechange
        '
        Me.lbldatechange.AutoSize = True
        Me.lbldatechange.BackColor = System.Drawing.Color.Transparent
        Me.lbldatechange.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldatechange.ForeColor = System.Drawing.Color.White
        Me.lbldatechange.Location = New System.Drawing.Point(41, 230)
        Me.lbldatechange.Name = "lbldatechange"
        Me.lbldatechange.Size = New System.Drawing.Size(143, 22)
        Me.lbldatechange.TabIndex = 99
        Me.lbldatechange.Text = "Date of Change:"
        '
        'LblChemicalName
        '
        Me.LblChemicalName.AutoSize = True
        Me.LblChemicalName.BackColor = System.Drawing.Color.Transparent
        Me.LblChemicalName.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblChemicalName.ForeColor = System.Drawing.Color.White
        Me.LblChemicalName.Location = New System.Drawing.Point(41, 71)
        Me.LblChemicalName.Name = "LblChemicalName"
        Me.LblChemicalName.Size = New System.Drawing.Size(145, 22)
        Me.LblChemicalName.TabIndex = 98
        Me.LblChemicalName.Text = "Chemical Name:"
        '
        'txtChemicalId
        '
        Me.txtChemicalId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.txtChemicalId.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChemicalId.Location = New System.Drawing.Point(235, 24)
        Me.txtChemicalId.Name = "txtChemicalId"
        Me.txtChemicalId.Size = New System.Drawing.Size(146, 29)
        Me.txtChemicalId.TabIndex = 0
        '
        'lblChemicalId
        '
        Me.lblChemicalId.AutoSize = True
        Me.lblChemicalId.BackColor = System.Drawing.Color.Transparent
        Me.lblChemicalId.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChemicalId.ForeColor = System.Drawing.Color.White
        Me.lblChemicalId.Location = New System.Drawing.Point(41, 24)
        Me.lblChemicalId.Name = "lblChemicalId"
        Me.lblChemicalId.Size = New System.Drawing.Size(118, 22)
        Me.lblChemicalId.TabIndex = 97
        Me.lblChemicalId.Text = "Chemical ID:"
        '
        'PnlCustNavigation
        '
        Me.PnlCustNavigation.BackgroundImage = CType(resources.GetObject("PnlCustNavigation.BackgroundImage"), System.Drawing.Image)
        Me.PnlCustNavigation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PnlCustNavigation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlCustNavigation.Controls.Add(Me.btnNext)
        Me.PnlCustNavigation.Controls.Add(Me.btnLast)
        Me.PnlCustNavigation.Controls.Add(Me.btnPrev)
        Me.PnlCustNavigation.Controls.Add(Me.btnFirst)
        Me.PnlCustNavigation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PnlCustNavigation.Location = New System.Drawing.Point(753, 103)
        Me.PnlCustNavigation.Name = "PnlCustNavigation"
        Me.PnlCustNavigation.Size = New System.Drawing.Size(445, 80)
        Me.PnlCustNavigation.TabIndex = 141
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(229, 22)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(97, 39)
        Me.btnNext.TabIndex = 8
        Me.btnNext.Text = "Next>>"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLast.Location = New System.Drawing.Point(332, 22)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(91, 39)
        Me.btnLast.TabIndex = 9
        Me.btnLast.Text = "Last"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnPrev
        '
        Me.btnPrev.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrev.Location = New System.Drawing.Point(119, 22)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(104, 39)
        Me.btnPrev.TabIndex = 7
        Me.btnPrev.Text = "<<Prev"
        Me.btnPrev.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFirst.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnFirst.Location = New System.Drawing.Point(13, 22)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(100, 39)
        Me.btnFirst.TabIndex = 6
        Me.btnFirst.Text = "First"
        Me.btnFirst.UseVisualStyleBackColor = True
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
        Me.PnlCustOperations.Location = New System.Drawing.Point(753, 189)
        Me.PnlCustOperations.Name = "PnlCustOperations"
        Me.PnlCustOperations.Size = New System.Drawing.Size(445, 85)
        Me.PnlCustOperations.TabIndex = 140
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(332, 26)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(91, 38)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(119, 26)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(104, 38)
        Me.btnUpdate.TabIndex = 11
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(13, 26)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(103, 38)
        Me.btnAdd.TabIndex = 10
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(229, 26)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(97, 38)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.Pathology.My.Resources.Resources.Biochemist1Trans
        Me.PictureBox1.Location = New System.Drawing.Point(172, 442)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(575, 149)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 167
        Me.PictureBox1.TabStop = False
        '
        'Chemical_Master
        '
        Me.AcceptButton = Me.btnnewid
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1304, 612)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.PnlChemicalMaster)
        Me.Controls.Add(Me.PnlCustNavigation)
        Me.Controls.Add(Me.PnlCustOperations)
        Me.Controls.Add(Me.lbldocdet)
        Me.Name = "Chemical_Master"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Chemical_Master"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlChemicalMaster.ResumeLayout(False)
        Me.PnlChemicalMaster.PerformLayout()
        Me.PnlCustNavigation.ResumeLayout(False)
        Me.PnlCustOperations.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PnlChemicalMaster As System.Windows.Forms.Panel
    Friend WithEvents txtChemName As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents cmbObsby As System.Windows.Forms.ComboBox
    Friend WithEvents lblObservedBy As System.Windows.Forms.Label
    Friend WithEvents lblDealer As System.Windows.Forms.Label
    Friend WithEvents LblChemicalName As System.Windows.Forms.Label
    Friend WithEvents txtChemicalId As System.Windows.Forms.TextBox
    Friend WithEvents lblChemicalId As System.Windows.Forms.Label
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents PnlCustNavigation As System.Windows.Forms.Panel
    Friend WithEvents btnPrev As System.Windows.Forms.Button
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents PnlCustOperations As System.Windows.Forms.Panel
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents lbldocdet As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnnewid As System.Windows.Forms.Button
    Friend WithEvents cmbDealer As System.Windows.Forms.ComboBox
    Friend WithEvents dtpChem As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbldatechange As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
