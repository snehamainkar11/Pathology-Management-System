<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptBill
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.TotalBill1 = New Pathology.TotalBill
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BillDataSet = New Pathology.BillDataSet
        Me.cmbBillno = New System.Windows.Forms.ComboBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BillDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.TotalBill1
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1306, 561)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'BindingSource1
        '
        Me.BindingSource1.DataSource = Me.BillDataSet
        Me.BindingSource1.Position = 0
        '
        'BillDataSet
        '
        Me.BillDataSet.DataSetName = "BillDataSet"
        Me.BillDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbBillno
        '
        Me.cmbBillno.FormattingEnabled = True
        Me.cmbBillno.Location = New System.Drawing.Point(1094, 27)
        Me.cmbBillno.Name = "cmbBillno"
        Me.cmbBillno.Size = New System.Drawing.Size(121, 21)
        Me.cmbBillno.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(30, 35)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(237, 137)
        Me.DataGridView1.TabIndex = 2
        '
        'rptBill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1306, 561)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cmbBillno)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "rptBill"
        Me.Text = "rptBill"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BillDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents cmbBillno As System.Windows.Forms.ComboBox
    Friend WithEvents BillDataSet As Pathology.BillDataSet
    Friend WithEvents TotalBill1 As Pathology.TotalBill
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
