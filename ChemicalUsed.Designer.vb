<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChemicalUsed
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChemicalUsed))
        Me.PnlCustOperations = New System.Windows.Forms.Panel
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.ChemUsIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChemNmDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChemUsedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PatholabDBDataSet31 = New Pathology.patholabDBDataSet31
        Me.BtnFirst = New System.Windows.Forms.Button
        Me.BtnLast = New System.Windows.Forms.Button
        Me.BtnPrev = New System.Windows.Forms.Button
        Me.txtQuantity = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbChemName = New System.Windows.Forms.ComboBox
        Me.dtpBillDetails = New System.Windows.Forms.DateTimePicker
        Me.BtnNext = New System.Windows.Forms.Button
        Me.LblPurDetDate = New System.Windows.Forms.Label
        Me.PnlCustNavigation = New System.Windows.Forms.Panel
        Me.LblEqupName = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnnewid = New System.Windows.Forms.Button
        Me.txtChemUsId = New System.Windows.Forms.TextBox
        Me.LblPurchaseId = New System.Windows.Forms.Label
        Me.lbldocdet = New System.Windows.Forms.Label
        Me.ChemUsedTableAdapter = New Pathology.patholabDBDataSet31TableAdapters.ChemUsedTableAdapter
        Me.PnlCustOperations.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChemUsedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatholabDBDataSet31, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlCustNavigation.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.PnlCustOperations.Location = New System.Drawing.Point(623, 180)
        Me.PnlCustOperations.Name = "PnlCustOperations"
        Me.PnlCustOperations.Size = New System.Drawing.Size(445, 85)
        Me.PnlCustOperations.TabIndex = 172
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(119, 26)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(103, 38)
        Me.btnUpdate.TabIndex = 8
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(332, 26)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(91, 38)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(13, 26)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(103, 38)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(229, 26)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(97, 38)
        Me.btnDelete.TabIndex = 9
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ChemUsIdDataGridViewTextBoxColumn, Me.CDateDataGridViewTextBoxColumn, Me.ChemNmDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ChemUsedBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(623, 277)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(542, 237)
        Me.DataGridView1.TabIndex = 169
        '
        'ChemUsIdDataGridViewTextBoxColumn
        '
        Me.ChemUsIdDataGridViewTextBoxColumn.DataPropertyName = "ChemUsId"
        Me.ChemUsIdDataGridViewTextBoxColumn.HeaderText = "ChemUsId"
        Me.ChemUsIdDataGridViewTextBoxColumn.Name = "ChemUsIdDataGridViewTextBoxColumn"
        '
        'CDateDataGridViewTextBoxColumn
        '
        Me.CDateDataGridViewTextBoxColumn.DataPropertyName = "CDate"
        Me.CDateDataGridViewTextBoxColumn.HeaderText = "CDate"
        Me.CDateDataGridViewTextBoxColumn.Name = "CDateDataGridViewTextBoxColumn"
        '
        'ChemNmDataGridViewTextBoxColumn
        '
        Me.ChemNmDataGridViewTextBoxColumn.DataPropertyName = "ChemNm"
        Me.ChemNmDataGridViewTextBoxColumn.HeaderText = "ChemNm"
        Me.ChemNmDataGridViewTextBoxColumn.Name = "ChemNmDataGridViewTextBoxColumn"
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        '
        'ChemUsedBindingSource
        '
        Me.ChemUsedBindingSource.DataMember = "ChemUsed"
        Me.ChemUsedBindingSource.DataSource = Me.PatholabDBDataSet31
        '
        'PatholabDBDataSet31
        '
        Me.PatholabDBDataSet31.DataSetName = "patholabDBDataSet31"
        Me.PatholabDBDataSet31.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BtnFirst
        '
        Me.BtnFirst.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFirst.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnFirst.Location = New System.Drawing.Point(13, 22)
        Me.BtnFirst.Name = "BtnFirst"
        Me.BtnFirst.Size = New System.Drawing.Size(100, 39)
        Me.BtnFirst.TabIndex = 3
        Me.BtnFirst.Text = "First"
        Me.BtnFirst.UseVisualStyleBackColor = True
        '
        'BtnLast
        '
        Me.BtnLast.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLast.Location = New System.Drawing.Point(332, 22)
        Me.BtnLast.Name = "BtnLast"
        Me.BtnLast.Size = New System.Drawing.Size(91, 39)
        Me.BtnLast.TabIndex = 6
        Me.BtnLast.Text = "Last"
        Me.BtnLast.UseVisualStyleBackColor = True
        '
        'BtnPrev
        '
        Me.BtnPrev.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrev.Location = New System.Drawing.Point(119, 22)
        Me.BtnPrev.Name = "BtnPrev"
        Me.BtnPrev.Size = New System.Drawing.Size(104, 39)
        Me.BtnPrev.TabIndex = 4
        Me.BtnPrev.Text = "<<Prev"
        Me.BtnPrev.UseVisualStyleBackColor = True
        '
        'txtQuantity
        '
        Me.txtQuantity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.txtQuantity.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(226, 188)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(263, 29)
        Me.txtQuantity.TabIndex = 5
        Me.txtQuantity.Text = "2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(31, 195)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 22)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "Quantity:"
        '
        'cmbChemName
        '
        Me.cmbChemName.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbChemName.FormattingEnabled = True
        Me.cmbChemName.Location = New System.Drawing.Point(226, 125)
        Me.cmbChemName.Name = "cmbChemName"
        Me.cmbChemName.Size = New System.Drawing.Size(261, 30)
        Me.cmbChemName.TabIndex = 1
        '
        'dtpBillDetails
        '
        Me.dtpBillDetails.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpBillDetails.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpBillDetails.Location = New System.Drawing.Point(341, 13)
        Me.dtpBillDetails.Name = "dtpBillDetails"
        Me.dtpBillDetails.Size = New System.Drawing.Size(177, 27)
        Me.dtpBillDetails.TabIndex = 98
        '
        'BtnNext
        '
        Me.BtnNext.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNext.Location = New System.Drawing.Point(229, 22)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(97, 39)
        Me.BtnNext.TabIndex = 5
        Me.BtnNext.Text = "Next>>"
        Me.BtnNext.UseVisualStyleBackColor = True
        '
        'LblPurDetDate
        '
        Me.LblPurDetDate.AutoSize = True
        Me.LblPurDetDate.BackColor = System.Drawing.Color.Transparent
        Me.LblPurDetDate.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPurDetDate.ForeColor = System.Drawing.Color.Transparent
        Me.LblPurDetDate.Location = New System.Drawing.Point(222, 17)
        Me.LblPurDetDate.Name = "LblPurDetDate"
        Me.LblPurDetDate.Size = New System.Drawing.Size(54, 22)
        Me.LblPurDetDate.TabIndex = 99
        Me.LblPurDetDate.Text = "Date:"
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
        Me.PnlCustNavigation.Location = New System.Drawing.Point(623, 94)
        Me.PnlCustNavigation.Name = "PnlCustNavigation"
        Me.PnlCustNavigation.Size = New System.Drawing.Size(445, 80)
        Me.PnlCustNavigation.TabIndex = 173
        '
        'LblEqupName
        '
        Me.LblEqupName.AutoSize = True
        Me.LblEqupName.BackColor = System.Drawing.Color.Transparent
        Me.LblEqupName.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEqupName.ForeColor = System.Drawing.Color.Transparent
        Me.LblEqupName.Location = New System.Drawing.Point(31, 128)
        Me.LblEqupName.Name = "LblEqupName"
        Me.LblEqupName.Size = New System.Drawing.Size(145, 22)
        Me.LblEqupName.TabIndex = 93
        Me.LblEqupName.Text = "Chemical Name:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btnnewid)
        Me.Panel1.Controls.Add(Me.txtQuantity)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cmbChemName)
        Me.Panel1.Controls.Add(Me.dtpBillDetails)
        Me.Panel1.Controls.Add(Me.LblPurDetDate)
        Me.Panel1.Controls.Add(Me.LblEqupName)
        Me.Panel1.Controls.Add(Me.txtChemUsId)
        Me.Panel1.Controls.Add(Me.LblPurchaseId)
        Me.Panel1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.Transparent
        Me.Panel1.Location = New System.Drawing.Point(44, 94)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(573, 305)
        Me.Panel1.TabIndex = 170
        '
        'btnnewid
        '
        Me.btnnewid.AllowDrop = True
        Me.btnnewid.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnnewid.BackColor = System.Drawing.Color.Black
        Me.btnnewid.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnewid.ForeColor = System.Drawing.Color.White
        Me.btnnewid.Location = New System.Drawing.Point(348, 61)
        Me.btnnewid.Name = "btnnewid"
        Me.btnnewid.Size = New System.Drawing.Size(191, 36)
        Me.btnnewid.TabIndex = 156
        Me.btnnewid.Text = "New Chemical Use Id"
        Me.btnnewid.UseVisualStyleBackColor = False
        '
        'txtChemUsId
        '
        Me.txtChemUsId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.txtChemUsId.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChemUsId.Location = New System.Drawing.Point(226, 66)
        Me.txtChemUsId.Name = "txtChemUsId"
        Me.txtChemUsId.Size = New System.Drawing.Size(116, 29)
        Me.txtChemUsId.TabIndex = 0
        '
        'LblPurchaseId
        '
        Me.LblPurchaseId.AutoSize = True
        Me.LblPurchaseId.BackColor = System.Drawing.Color.Transparent
        Me.LblPurchaseId.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPurchaseId.ForeColor = System.Drawing.Color.Transparent
        Me.LblPurchaseId.Location = New System.Drawing.Point(31, 66)
        Me.LblPurchaseId.Name = "LblPurchaseId"
        Me.LblPurchaseId.Size = New System.Drawing.Size(149, 22)
        Me.LblPurchaseId.TabIndex = 89
        Me.LblPurchaseId.Text = "Chemical Use Id:"
        '
        'lbldocdet
        '
        Me.lbldocdet.AutoSize = True
        Me.lbldocdet.BackColor = System.Drawing.Color.Transparent
        Me.lbldocdet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbldocdet.Font = New System.Drawing.Font("Palatino Linotype", 40.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldocdet.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.lbldocdet.Location = New System.Drawing.Point(387, 6)
        Me.lbldocdet.Name = "lbldocdet"
        Me.lbldocdet.Size = New System.Drawing.Size(416, 74)
        Me.lbldocdet.TabIndex = 171
        Me.lbldocdet.Text = "Chemicals Used"
        '
        'ChemUsedTableAdapter
        '
        Me.ChemUsedTableAdapter.ClearBeforeFill = True
        '
        'ChemicalUsed
        '
        Me.AcceptButton = Me.btnnewid
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Pathology.My.Resources.Resources.MdiImage
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1291, 680)
        Me.Controls.Add(Me.PnlCustOperations)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.PnlCustNavigation)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbldocdet)
        Me.Name = "ChemicalUsed"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Chemical_Used"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PnlCustOperations.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChemUsedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatholabDBDataSet31, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlCustNavigation.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PnlCustOperations As System.Windows.Forms.Panel
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BtnFirst As System.Windows.Forms.Button
    Friend WithEvents BtnLast As System.Windows.Forms.Button
    Friend WithEvents BtnPrev As System.Windows.Forms.Button
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbChemName As System.Windows.Forms.ComboBox
    Friend WithEvents dtpBillDetails As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnNext As System.Windows.Forms.Button
    Friend WithEvents LblPurDetDate As System.Windows.Forms.Label
    Friend WithEvents PnlCustNavigation As System.Windows.Forms.Panel
    Friend WithEvents LblEqupName As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtChemUsId As System.Windows.Forms.TextBox
    Friend WithEvents LblPurchaseId As System.Windows.Forms.Label
    Friend WithEvents lbldocdet As System.Windows.Forms.Label
    Friend WithEvents btnnewid As System.Windows.Forms.Button
    Friend WithEvents PatholabDBDataSet31 As Pathology.patholabDBDataSet31
    Friend WithEvents ChemUsedBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ChemUsedTableAdapter As Pathology.patholabDBDataSet31TableAdapters.ChemUsedTableAdapter
    Friend WithEvents ChemUsIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChemNmDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
