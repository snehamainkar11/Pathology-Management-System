<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptPurDetails
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
        Me.cmbBillNo = New System.Windows.Forms.ComboBox
        Me.btnShwRec = New System.Windows.Forms.Button
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PurDetDataset = New Pathology.PurDetDataset
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.PurDetailsRpt1 = New Pathology.PurDetailsRpt
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurDetDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbBillNo
        '
        Me.cmbBillNo.FormattingEnabled = True
        Me.cmbBillNo.Location = New System.Drawing.Point(861, 20)
        Me.cmbBillNo.Name = "cmbBillNo"
        Me.cmbBillNo.Size = New System.Drawing.Size(121, 21)
        Me.cmbBillNo.TabIndex = 1
        '
        'btnShwRec
        '
        Me.btnShwRec.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShwRec.Location = New System.Drawing.Point(609, 12)
        Me.btnShwRec.Name = "btnShwRec"
        Me.btnShwRec.Size = New System.Drawing.Size(175, 29)
        Me.btnShwRec.TabIndex = 4
        Me.btnShwRec.Text = "Show All Recods"
        Me.btnShwRec.UseVisualStyleBackColor = True
        '
        'BindingSource1
        '
        Me.BindingSource1.DataSource = Me.PurDetDataset
        Me.BindingSource1.Position = 0
        '
        'PurDetDataset
        '
        Me.PurDetDataset.DataSetName = "PurDetDataset"
        Me.PurDetDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.PurDetailsRpt1
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1221, 746)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'rptPurDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1221, 746)
        Me.Controls.Add(Me.btnShwRec)
        Me.Controls.Add(Me.cmbBillNo)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "rptPurDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "+"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurDetDataset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents cmbBillNo As System.Windows.Forms.ComboBox
    Friend WithEvents btnShwRec As System.Windows.Forms.Button
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents PurDetDataset As Pathology.PurDetDataset
    Friend WithEvents PurDetailsRpt1 As Pathology.PurDetailsRpt
End Class
