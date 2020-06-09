<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptTest
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
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TstResultDataSet = New Pathology.TstResultDataSet
        Me.cmbRCId = New System.Windows.Forms.ComboBox
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.TReport1 = New Pathology.TReport
        Me.btnShwRec = New System.Windows.Forms.Button
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TstResultDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingSource1
        '
        Me.BindingSource1.DataSource = Me.TstResultDataSet
        Me.BindingSource1.Position = 0
        '
        'TstResultDataSet
        '
        Me.TstResultDataSet.DataSetName = "TstResultDataSet"
        Me.TstResultDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbRCId
        '
        Me.cmbRCId.FormattingEnabled = True
        Me.cmbRCId.Location = New System.Drawing.Point(754, 21)
        Me.cmbRCId.Name = "cmbRCId"
        Me.cmbRCId.Size = New System.Drawing.Size(147, 21)
        Me.cmbRCId.TabIndex = 1
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.TReport1
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1306, 746)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'btnShwRec
        '
        Me.btnShwRec.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShwRec.Location = New System.Drawing.Point(468, 15)
        Me.btnShwRec.Name = "btnShwRec"
        Me.btnShwRec.Size = New System.Drawing.Size(187, 30)
        Me.btnShwRec.TabIndex = 2
        Me.btnShwRec.Text = "Show All Records"
        Me.btnShwRec.UseVisualStyleBackColor = True
        '
        'rptTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1306, 746)
        Me.Controls.Add(Me.btnShwRec)
        Me.Controls.Add(Me.cmbRCId)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "rptTest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "rptTest"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TstResultDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents cmbRCId As System.Windows.Forms.ComboBox
    Friend WithEvents btnShwRec As System.Windows.Forms.Button
    Friend WithEvents TstResultDataSet As Pathology.TstResultDataSet
    Friend WithEvents TReport1 As Pathology.TReport
End Class
