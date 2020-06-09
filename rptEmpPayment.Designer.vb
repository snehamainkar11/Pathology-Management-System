<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptEmpPayment
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
        Me.EmpPaymentDataSet = New Pathology.EmpPaymentDataSet
        Me.cmbEmpId = New System.Windows.Forms.ComboBox
        Me.btnShwRec = New System.Windows.Forms.Button
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.EmpPay1 = New Pathology.EmpPay
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpPaymentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingSource1
        '
        Me.BindingSource1.DataSource = Me.EmpPaymentDataSet
        Me.BindingSource1.Position = 0
        '
        'EmpPaymentDataSet
        '
        Me.EmpPaymentDataSet.DataSetName = "EmpPaymentDataSet"
        Me.EmpPaymentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbEmpId
        '
        Me.cmbEmpId.FormattingEnabled = True
        Me.cmbEmpId.Location = New System.Drawing.Point(960, 20)
        Me.cmbEmpId.Name = "cmbEmpId"
        Me.cmbEmpId.Size = New System.Drawing.Size(121, 21)
        Me.cmbEmpId.TabIndex = 1
        '
        'btnShwRec
        '
        Me.btnShwRec.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShwRec.Location = New System.Drawing.Point(488, 20)
        Me.btnShwRec.Name = "btnShwRec"
        Me.btnShwRec.Size = New System.Drawing.Size(175, 29)
        Me.btnShwRec.TabIndex = 2
        Me.btnShwRec.Text = "Show All Recods"
        Me.btnShwRec.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.EmpPay1
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1285, 746)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'rptEmpPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1285, 746)
        Me.Controls.Add(Me.btnShwRec)
        Me.Controls.Add(Me.cmbEmpId)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "rptEmpPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "rptEmpPayment"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpPaymentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents EmpPaymentDataSet As Pathology.EmpPaymentDataSet
    Friend WithEvents EmpPay1 As Pathology.EmpPay
    Friend WithEvents cmbEmpId As System.Windows.Forms.ComboBox
    Friend WithEvents btnShwRec As System.Windows.Forms.Button
End Class
