<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptInvoice
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.rptInvoiceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.leonidaDBDataSet = New leonida.leonidaDBDataSet()
        Me.tblInvoiceItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.rptInvoiceTableAdapter = New leonida.leonidaDBDataSetTableAdapters.rptInvoiceTableAdapter()
        Me.tblInvoiceItemsTableAdapter = New leonida.leonidaDBDataSetTableAdapters.tblInvoiceItemsTableAdapter()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.rptInvoiceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leonidaDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblInvoiceItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rptInvoiceBindingSource
        '
        Me.rptInvoiceBindingSource.DataMember = "rptInvoice"
        Me.rptInvoiceBindingSource.DataSource = Me.leonidaDBDataSet
        '
        'leonidaDBDataSet
        '
        Me.leonidaDBDataSet.DataSetName = "leonidaDBDataSet"
        Me.leonidaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tblInvoiceItemsBindingSource
        '
        Me.tblInvoiceItemsBindingSource.DataMember = "tblInvoiceItems"
        Me.tblInvoiceItemsBindingSource.DataSource = Me.leonidaDBDataSet
        '
        'rptInvoiceTableAdapter
        '
        Me.rptInvoiceTableAdapter.ClearBeforeFill = True
        '
        'tblInvoiceItemsTableAdapter
        '
        Me.tblInvoiceItemsTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.rptInvoiceBindingSource
        ReportDataSource2.Name = "DataSet2"
        ReportDataSource2.Value = Me.tblInvoiceItemsBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "leonida.rptInvoiceLeonida.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1252, 730)
        Me.ReportViewer1.TabIndex = 0
        '
        'rptInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1252, 730)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "rptInvoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "rptInvoicevb"
        CType(Me.rptInvoiceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leonidaDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblInvoiceItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rptInvoiceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents leonidaDBDataSet As leonida.leonidaDBDataSet
    Friend WithEvents rptInvoiceTableAdapter As leonida.leonidaDBDataSetTableAdapters.rptInvoiceTableAdapter
    Friend WithEvents tblInvoiceItemsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents tblInvoiceItemsTableAdapter As leonida.leonidaDBDataSetTableAdapters.tblInvoiceItemsTableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
