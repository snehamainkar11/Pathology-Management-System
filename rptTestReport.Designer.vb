<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptTestReport
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
        Me.cmbRCId = New System.Windows.Forms.ComboBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.RptCreateDataSet = New Pathology.RptCreateDataSet
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RptCreateDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbRCId
        '
        Me.cmbRCId.FormattingEnabled = True
        Me.cmbRCId.Location = New System.Drawing.Point(883, 12)
        Me.cmbRCId.Name = "cmbRCId"
        Me.cmbRCId.Size = New System.Drawing.Size(121, 21)
        Me.cmbRCId.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(30, 64)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView1.TabIndex = 2
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1307, 564)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'BindingSource1
        '
        Me.BindingSource1.DataSource = Me.RptCreateDataSet
        Me.BindingSource1.Position = 0
        '
        'RptCreateDataSet
        '
        Me.RptCreateDataSet.DataSetName = "RptCreateDataSet"
        Me.RptCreateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rptTestReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1307, 564)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cmbRCId)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "rptTestReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "rptTestReport"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RptCreateDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents RptCreateDataSet As Pathology.RptCreateDataSet
    Friend WithEvents cmbRCId As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView

End Class
