<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvoices
    Inherits leonida.frmTemplate

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInvoices))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.leonidaDBDataSet = New leonida.leonidaDBDataSet()
        Me.RptInvoiceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RptInvoiceTableAdapter = New leonida.leonidaDBDataSetTableAdapters.rptInvoiceTableAdapter()
        Me.TableAdapterManager = New leonida.leonidaDBDataSetTableAdapters.TableAdapterManager()
        Me.RptInvoiceBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.RptInvoiceDataGridView = New System.Windows.Forms.DataGridView()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.VwCustomerDiadrasisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.VwCustomerDiadrasisTableAdapter = New leonida.leonidaDBDataSetTableAdapters.vwCustomerDiadrasisTableAdapter()
        Me.invoiceId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.invoiceCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.invoiceDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.invoiceTypeDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customerId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customerCompany = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.invoiceDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.invoiceComments = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.invoicePaid = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customerProfession = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Clone = New System.Windows.Forms.DataGridViewImageColumn()
        Me.invoice = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Payment = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.leonidaDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RptInvoiceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RptInvoiceBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RptInvoiceBindingNavigator.SuspendLayout()
        CType(Me.RptInvoiceDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwCustomerDiadrasisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'leonidaDBDataSet
        '
        Me.leonidaDBDataSet.DataSetName = "leonidaDBDataSet"
        Me.leonidaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RptInvoiceBindingSource
        '
        Me.RptInvoiceBindingSource.DataMember = "rptInvoice"
        Me.RptInvoiceBindingSource.DataSource = Me.leonidaDBDataSet
        '
        'RptInvoiceTableAdapter
        '
        Me.RptInvoiceTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.tblAgreementTableAdapter = Nothing
        Me.TableAdapterManager.tblAgreementTypeTableAdapter = Nothing
        Me.TableAdapterManager.tblCustomerTableAdapter = Nothing
        Me.TableAdapterManager.tblDepartmentsTableAdapter = Nothing
        Me.TableAdapterManager.tblEducationTableAdapter = Nothing
        Me.TableAdapterManager.tblFPATableAdapter = Nothing
        Me.TableAdapterManager.tblInspectionScedulesTableAdapter = Nothing
        Me.TableAdapterManager.tblInspectionsReportTableAdapter = Nothing
        Me.TableAdapterManager.tblInspectionsTableAdapter = Nothing
        Me.TableAdapterManager.tblInvoiceItemsTableAdapter = Nothing
        Me.TableAdapterManager.tblInvoicePaymentTypesTableAdapter = Nothing
        Me.TableAdapterManager.tblInvoiceResponsibles1TableAdapter = Nothing
        Me.TableAdapterManager.tblInvoiceResponsiblesTableAdapter = Nothing
        Me.TableAdapterManager.tblInvoicesByIDPaymentTableAdapter = Nothing
        Me.TableAdapterManager.tblInvoicesTableAdapter = Nothing
        Me.TableAdapterManager.tblInvoiceTypesTableAdapter = Nothing
        Me.TableAdapterManager.tblLoginTableAdapter = Nothing
        Me.TableAdapterManager.tblMonthsTableAdapter = Nothing
        Me.TableAdapterManager.tblNonConformances_TableAdapter = Nothing
        Me.TableAdapterManager.tblNonConformanceTypes_TableAdapter = Nothing
        Me.TableAdapterManager.tblProjectPhasesTableAdapter = Nothing
        Me.TableAdapterManager.tblProjectStaffTableAdapter = Nothing
        Me.TableAdapterManager.tblProjectTableAdapter = Nothing
        Me.TableAdapterManager.tblProjectTypeTableAdapter = Nothing
        Me.TableAdapterManager.tblQACustomerSatisfactionCriteriaTableAdapter = Nothing
        Me.TableAdapterManager.tblQACustomerSatisfactionMarksTableAdapter = Nothing
        Me.TableAdapterManager.tblQACustomerSatisfactionSurveyDetailsTableAdapter = Nothing
        Me.TableAdapterManager.tblQACustomerSatisfactionSurveysTableAdapter = Nothing
        Me.TableAdapterManager.tblQADocumentsTableAdapter = Nothing
        Me.TableAdapterManager.tblQADocumentTypesTableAdapter = Nothing
        Me.TableAdapterManager.tblQADurationsTableAdapter = Nothing
        Me.TableAdapterManager.tblQAEmployeeEvaluationCriteriaTableAdapter = Nothing
        Me.TableAdapterManager.tblQAEmployeeEvaluationDetailsTableAdapter = Nothing
        Me.TableAdapterManager.tblQAEmployeeEvaluationMarksTableAdapter = Nothing
        Me.TableAdapterManager.tblQAEmployeeEvaluationsTableAdapter = Nothing
        Me.TableAdapterManager.tblQAResponsibilitiesTableAdapter = Nothing
        Me.TableAdapterManager.tblQASupplierSatisfactionCriteriaTableAdapter = Nothing
        Me.TableAdapterManager.tblQASupplierSatisfactionMarksTableAdapter = Nothing
        Me.TableAdapterManager.tblQASupplierSatisfactionSurveyDetailsTableAdapter = Nothing
        Me.TableAdapterManager.tblQASupplierSatisfactionSurveysTableAdapter = Nothing
        Me.TableAdapterManager.tblRevComitMeetingRecommedationsTableAdapter = Nothing
        Me.TableAdapterManager.tblRevComitMeetingsTableAdapter = Nothing
        Me.TableAdapterManager.tblRevComitMeetingTopicsTableAdapter = Nothing
        Me.TableAdapterManager.tblRevComitMeetingTopicTypeTableAdapter = Nothing
        Me.TableAdapterManager.tblStaffTableAdapter = Nothing
        Me.TableAdapterManager.tblSupplierEvalTableAdapter = Nothing
        Me.TableAdapterManager.tblSupplierTableAdapter = Nothing
        Me.TableAdapterManager.tblSupplierTypeTableAdapter = Nothing
        Me.TableAdapterManager.tblTaskReasonsTableAdapter = Nothing
        Me.TableAdapterManager.tblTaskTableAdapter = Nothing
        Me.TableAdapterManager.tblTrainningEmployeesTableAdapter = Nothing
        Me.TableAdapterManager.tblTrainningProgrammesTableAdapter = Nothing
        Me.TableAdapterManager.tblTrainningTopicTableAdapter = Nothing
        Me.TableAdapterManager.tblTrainningTopicTraineesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = leonida.leonidaDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RptInvoiceBindingNavigator
        '
        Me.RptInvoiceBindingNavigator.AddNewItem = Nothing
        Me.RptInvoiceBindingNavigator.BindingSource = Me.RptInvoiceBindingSource
        Me.RptInvoiceBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.RptInvoiceBindingNavigator.DeleteItem = Nothing
        Me.RptInvoiceBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.RptInvoiceBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.RptInvoiceBindingNavigator.Location = New System.Drawing.Point(48, 187)
        Me.RptInvoiceBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.RptInvoiceBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.RptInvoiceBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.RptInvoiceBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.RptInvoiceBindingNavigator.Name = "RptInvoiceBindingNavigator"
        Me.RptInvoiceBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.RptInvoiceBindingNavigator.Size = New System.Drawing.Size(209, 25)
        Me.RptInvoiceBindingNavigator.TabIndex = 3
        Me.RptInvoiceBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'RptInvoiceDataGridView
        '
        Me.RptInvoiceDataGridView.AllowUserToAddRows = False
        Me.RptInvoiceDataGridView.AllowUserToDeleteRows = False
        Me.RptInvoiceDataGridView.AllowUserToOrderColumns = True
        Me.RptInvoiceDataGridView.AutoGenerateColumns = False
        Me.RptInvoiceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RptInvoiceDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.invoiceId, Me.invoiceCode, Me.invoiceDate, Me.invoiceTypeDescription, Me.customerId, Me.customerCompany, Me.invoiceDescription, Me.invoiceComments, Me.invoicePaid, Me.Column1, Me.customerProfession, Me.Clone, Me.invoice, Me.Payment})
        Me.RptInvoiceDataGridView.DataSource = Me.RptInvoiceBindingSource
        Me.RptInvoiceDataGridView.Location = New System.Drawing.Point(28, 260)
        Me.RptInvoiceDataGridView.Name = "RptInvoiceDataGridView"
        Me.RptInvoiceDataGridView.Size = New System.Drawing.Size(1247, 220)
        Me.RptInvoiceDataGridView.TabIndex = 4
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Εκδοθείσες", "Προσωρινά Αποθηκευμένες"})
        Me.ComboBox1.Location = New System.Drawing.Point(286, 186)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(177, 21)
        Me.ComboBox1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(283, 164)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Κατάσταση "
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(874, 164)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 48)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Refresh"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(480, 186)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 8
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.leonida.My.Resources.Resources.search
        Me.PictureBox4.InitialImage = Global.leonida.My.Resources.Resources.search
        Me.PictureBox4.Location = New System.Drawing.Point(480, 140)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(32, 37)
        Me.PictureBox4.TabIndex = 9
        Me.PictureBox4.TabStop = False
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.VwCustomerDiadrasisBindingSource
        Me.ComboBox2.DisplayMember = "customerTitle"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(609, 185)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(150, 21)
        Me.ComboBox2.TabIndex = 10
        Me.ComboBox2.ValueMember = "customerId"
        '
        'VwCustomerDiadrasisBindingSource
        '
        Me.VwCustomerDiadrasisBindingSource.DataMember = "vwCustomerDiadrasis"
        Me.VwCustomerDiadrasisBindingSource.DataSource = Me.leonidaDBDataSet
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(606, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Πελάτης "
        '
        'VwCustomerDiadrasisTableAdapter
        '
        Me.VwCustomerDiadrasisTableAdapter.ClearBeforeFill = True
        '
        'invoiceId
        '
        Me.invoiceId.DataPropertyName = "invoiceId"
        Me.invoiceId.HeaderText = "invoiceId"
        Me.invoiceId.Name = "invoiceId"
        '
        'invoiceCode
        '
        Me.invoiceCode.DataPropertyName = "invoiceCode"
        Me.invoiceCode.HeaderText = "invoiceCode"
        Me.invoiceCode.Name = "invoiceCode"
        Me.invoiceCode.ReadOnly = True
        '
        'invoiceDate
        '
        Me.invoiceDate.DataPropertyName = "invoiceDate"
        Me.invoiceDate.HeaderText = "invoiceDate"
        Me.invoiceDate.Name = "invoiceDate"
        Me.invoiceDate.ReadOnly = True
        '
        'invoiceTypeDescription
        '
        Me.invoiceTypeDescription.DataPropertyName = "invoiceTypeDescription"
        Me.invoiceTypeDescription.HeaderText = "invoiceTypeDescription"
        Me.invoiceTypeDescription.Name = "invoiceTypeDescription"
        Me.invoiceTypeDescription.ReadOnly = True
        '
        'customerId
        '
        Me.customerId.DataPropertyName = "customerId"
        Me.customerId.HeaderText = "customerId"
        Me.customerId.Name = "customerId"
        '
        'customerCompany
        '
        Me.customerCompany.DataPropertyName = "customerCompany"
        Me.customerCompany.HeaderText = "customerCompany"
        Me.customerCompany.Name = "customerCompany"
        Me.customerCompany.ReadOnly = True
        '
        'invoiceDescription
        '
        Me.invoiceDescription.DataPropertyName = "invoiceDescription"
        Me.invoiceDescription.HeaderText = "invoiceDescription"
        Me.invoiceDescription.Name = "invoiceDescription"
        Me.invoiceDescription.ReadOnly = True
        '
        'invoiceComments
        '
        Me.invoiceComments.DataPropertyName = "invoiceComments"
        Me.invoiceComments.HeaderText = "invoiceComments"
        Me.invoiceComments.Name = "invoiceComments"
        Me.invoiceComments.ReadOnly = True
        '
        'invoicePaid
        '
        Me.invoicePaid.DataPropertyName = "invoicePaid"
        Me.invoicePaid.HeaderText = "invoicePaid"
        Me.invoicePaid.Name = "invoicePaid"
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "payDate"
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column1.HeaderText = "payDate"
        Me.Column1.Name = "Column1"
        '
        'customerProfession
        '
        Me.customerProfession.DataPropertyName = "payComments"
        Me.customerProfession.HeaderText = "payComments"
        Me.customerProfession.Name = "customerProfession"
        '
        'Clone
        '
        Me.Clone.HeaderText = "Κλώνος"
        Me.Clone.Image = Global.leonida.My.Resources.Resources.clone
        Me.Clone.Name = "Clone"
        '
        'invoice
        '
        Me.invoice.HeaderText = "Εκτύπωση"
        Me.invoice.Image = Global.leonida.My.Resources.Resources.documentation
        Me.invoice.Name = "invoice"
        '
        'Payment
        '
        Me.Payment.HeaderText = "Πληρωμή"
        Me.Payment.Image = Global.leonida.My.Resources.Resources.banknotes
        Me.Payment.Name = "Payment"
        Me.Payment.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Payment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'frmInvoices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1370, 739)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.RptInvoiceDataGridView)
        Me.Controls.Add(Me.RptInvoiceBindingNavigator)
        Me.Name = "frmInvoices"
        Me.Controls.SetChildIndex(Me.RptInvoiceBindingNavigator, 0)
        Me.Controls.SetChildIndex(Me.RptInvoiceDataGridView, 0)
        Me.Controls.SetChildIndex(Me.ComboBox1, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Button1, 0)
        Me.Controls.SetChildIndex(Me.TextBox1, 0)
        Me.Controls.SetChildIndex(Me.PictureBox4, 0)
        Me.Controls.SetChildIndex(Me.ComboBox2, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        CType(Me.leonidaDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RptInvoiceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RptInvoiceBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RptInvoiceBindingNavigator.ResumeLayout(False)
        Me.RptInvoiceBindingNavigator.PerformLayout()
        CType(Me.RptInvoiceDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwCustomerDiadrasisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents leonidaDBDataSet As leonida.leonidaDBDataSet
    Friend WithEvents RptInvoiceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RptInvoiceTableAdapter As leonida.leonidaDBDataSetTableAdapters.rptInvoiceTableAdapter
    Friend WithEvents TableAdapterManager As leonida.leonidaDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RptInvoiceBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RptInvoiceDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn45 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn42 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn43 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn40 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn47 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents VwCustomerDiadrasisBindingSource As BindingSource
    Friend WithEvents VwCustomerDiadrasisTableAdapter As leonidaDBDataSetTableAdapters.vwCustomerDiadrasisTableAdapter
    Friend WithEvents invoiceId As DataGridViewTextBoxColumn
    Friend WithEvents invoiceCode As DataGridViewTextBoxColumn
    Friend WithEvents invoiceDate As DataGridViewTextBoxColumn
    Friend WithEvents invoiceTypeDescription As DataGridViewTextBoxColumn
    Friend WithEvents customerId As DataGridViewTextBoxColumn
    Friend WithEvents customerCompany As DataGridViewTextBoxColumn
    Friend WithEvents invoiceDescription As DataGridViewTextBoxColumn
    Friend WithEvents invoiceComments As DataGridViewTextBoxColumn
    Friend WithEvents invoicePaid As DataGridViewCheckBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents customerProfession As DataGridViewTextBoxColumn
    Friend WithEvents Clone As DataGridViewImageColumn
    Friend WithEvents invoice As DataGridViewImageColumn
    Friend WithEvents Payment As DataGridViewImageColumn
End Class
