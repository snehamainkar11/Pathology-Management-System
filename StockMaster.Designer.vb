<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StockMaster
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StockMaster))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtChmStk = New System.Windows.Forms.TextBox
        Me.cmbChmclNm = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpPurDetail = New System.Windows.Forms.DateTimePicker
        Me.LblPurDetDate = New System.Windows.Forms.Label
        Me.LblEqupName = New System.Windows.Forms.Label
        Me.LblPurDetSrNo = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.lbldocdet = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.txtChmStk)
        Me.Panel1.Controls.Add(Me.cmbChmclNm)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.dtpPurDetail)
        Me.Panel1.Controls.Add(Me.LblPurDetDate)
        Me.Panel1.Controls.Add(Me.LblEqupName)
        Me.Panel1.Controls.Add(Me.LblPurDetSrNo)
        Me.Panel1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.Transparent
        Me.Panel1.Location = New System.Drawing.Point(151, 110)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(531, 231)
        Me.Panel1.TabIndex = 149
        '
        'txtChmStk
        '
        Me.txtChmStk.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.txtChmStk.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChmStk.Location = New System.Drawing.Point(208, 157)
        Me.txtChmStk.Name = "txtChmStk"
        Me.txtChmStk.Size = New System.Drawing.Size(209, 29)
        Me.txtChmStk.TabIndex = 1
        '
        'cmbChmclNm
        '
        Me.cmbChmclNm.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbChmclNm.FormattingEnabled = True
        Me.cmbChmclNm.Location = New System.Drawing.Point(208, 63)
        Me.cmbChmclNm.Name = "cmbChmclNm"
        Me.cmbChmclNm.Size = New System.Drawing.Size(209, 30)
        Me.cmbChmclNm.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(33, 157)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 22)
        Me.Label1.TabIndex = 100
        Me.Label1.Text = "Available Stock:"
        '
        'dtpPurDetail
        '
        Me.dtpPurDetail.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpPurDetail.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPurDetail.Location = New System.Drawing.Point(351, 14)
        Me.dtpPurDetail.Name = "dtpPurDetail"
        Me.dtpPurDetail.Size = New System.Drawing.Size(157, 27)
        Me.dtpPurDetail.TabIndex = 98
        '
        'LblPurDetDate
        '
        Me.LblPurDetDate.AutoSize = True
        Me.LblPurDetDate.BackColor = System.Drawing.Color.Transparent
        Me.LblPurDetDate.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPurDetDate.ForeColor = System.Drawing.Color.Transparent
        Me.LblPurDetDate.Location = New System.Drawing.Point(279, 19)
        Me.LblPurDetDate.Name = "LblPurDetDate"
        Me.LblPurDetDate.Size = New System.Drawing.Size(54, 22)
        Me.LblPurDetDate.TabIndex = 99
        Me.LblPurDetDate.Text = "Date:"
        '
        'LblEqupName
        '
        Me.LblEqupName.AutoSize = True
        Me.LblEqupName.BackColor = System.Drawing.Color.Transparent
        Me.LblEqupName.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEqupName.ForeColor = System.Drawing.Color.Transparent
        Me.LblEqupName.Location = New System.Drawing.Point(33, 322)
        Me.LblEqupName.Name = "LblEqupName"
        Me.LblEqupName.Size = New System.Drawing.Size(0, 22)
        Me.LblEqupName.TabIndex = 93
        '
        'LblPurDetSrNo
        '
        Me.LblPurDetSrNo.AutoSize = True
        Me.LblPurDetSrNo.BackColor = System.Drawing.Color.Transparent
        Me.LblPurDetSrNo.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPurDetSrNo.ForeColor = System.Drawing.Color.Transparent
        Me.LblPurDetSrNo.Location = New System.Drawing.Point(33, 66)
        Me.LblPurDetSrNo.Name = "LblPurDetSrNo"
        Me.LblPurDetSrNo.Size = New System.Drawing.Size(145, 22)
        Me.LblPurDetSrNo.TabIndex = 92
        Me.LblPurDetSrNo.Text = "Chemical Name:"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(688, 110)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(230, 231)
        Me.DataGridView1.TabIndex = 105
        '
        'lbldocdet
        '
        Me.lbldocdet.AutoSize = True
        Me.lbldocdet.BackColor = System.Drawing.Color.Transparent
        Me.lbldocdet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbldocdet.Font = New System.Drawing.Font("Palatino Linotype", 40.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldocdet.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.lbldocdet.Location = New System.Drawing.Point(353, -3)
        Me.lbldocdet.Name = "lbldocdet"
        Me.lbldocdet.Size = New System.Drawing.Size(372, 74)
        Me.lbldocdet.TabIndex = 150
        Me.lbldocdet.Text = "Stock Details:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'StockMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Pathology.My.Resources.Resources.MdiImage
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1307, 559)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbldocdet)
        Me.Name = "StockMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Stock_Master"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dtpPurDetail As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblPurDetDate As System.Windows.Forms.Label
    Friend WithEvents LblEqupName As System.Windows.Forms.Label
    Friend WithEvents LblPurDetSrNo As System.Windows.Forms.Label
    Friend WithEvents lbldocdet As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbChmclNm As System.Windows.Forms.ComboBox
    Friend WithEvents txtChmStk As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
