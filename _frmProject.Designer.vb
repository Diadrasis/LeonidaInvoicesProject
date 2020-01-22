<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProject
    Inherits diadrasisProjects.frmTemplate

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProject))
        Me.TblProjectBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.TblProjectBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DiadrasisProjectsDBDataSet = New diadrasisProjects.diadrasisProjectsDBDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TblProjectBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TblProjectDataGridView = New System.Windows.Forms.DataGridView()
        Me.VwCustomerDiadrasisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VwCustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TblProjectTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblProjectTableAdapter = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.tblProjectTableAdapter()
        Me.TableAdapterManager = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.TableAdapterManager()
        Me.VwCustomerTableAdapter = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.vwCustomerTableAdapter()
        Me.TblProjectTypeTableAdapter = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.tblProjectTypeTableAdapter()
        Me.VwCustomerDiadrasisTableAdapter = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.vwCustomerDiadrasisTableAdapter()
        Me.projectId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customerId = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.projectName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.projectDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.projectDateStart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.projectDateEnd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.projectHumanMonths = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.projectBudget = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tasks = New System.Windows.Forms.DataGridViewImageColumn()
        Me.staff = New System.Windows.Forms.DataGridViewImageColumn()
        Me.invoice = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ProductInvoice = New System.Windows.Forms.DataGridViewImageColumn()
        Me.CreditInvoice = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ProformaInvoice = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Receipt = New System.Windows.Forms.DataGridViewImageColumn()
        Me.RetailReceipt = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colLeonida = New System.Windows.Forms.DataGridViewImageColumn()
        Me.projectTypeId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.projectComments = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.TblProjectBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblProjectBindingNavigator.SuspendLayout()
        CType(Me.TblProjectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiadrasisProjectsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblProjectDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwCustomerDiadrasisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwCustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblProjectTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TblProjectBindingNavigator
        '
        Me.TblProjectBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblProjectBindingNavigator.BindingSource = Me.TblProjectBindingSource
        Me.TblProjectBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblProjectBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblProjectBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.TblProjectBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblProjectBindingNavigatorSaveItem})
        Me.TblProjectBindingNavigator.Location = New System.Drawing.Point(102, 210)
        Me.TblProjectBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblProjectBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblProjectBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblProjectBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblProjectBindingNavigator.Name = "TblProjectBindingNavigator"
        Me.TblProjectBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblProjectBindingNavigator.Size = New System.Drawing.Size(278, 25)
        Me.TblProjectBindingNavigator.TabIndex = 2
        Me.TblProjectBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'TblProjectBindingSource
        '
        Me.TblProjectBindingSource.DataMember = "tblProject"
        Me.TblProjectBindingSource.DataSource = Me.DiadrasisProjectsDBDataSet
        '
        'DiadrasisProjectsDBDataSet
        '
        Me.DiadrasisProjectsDBDataSet.DataSetName = "diadrasisProjectsDBDataSet"
        Me.DiadrasisProjectsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
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
        'TblProjectBindingNavigatorSaveItem
        '
        Me.TblProjectBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblProjectBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblProjectBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblProjectBindingNavigatorSaveItem.Name = "TblProjectBindingNavigatorSaveItem"
        Me.TblProjectBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TblProjectBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TblProjectDataGridView
        '
        Me.TblProjectDataGridView.AutoGenerateColumns = False
        Me.TblProjectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblProjectDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.projectId, Me.customerId, Me.projectName, Me.projectDescription, Me.projectDateStart, Me.projectDateEnd, Me.projectHumanMonths, Me.projectBudget, Me.tasks, Me.staff, Me.invoice, Me.ProductInvoice, Me.CreditInvoice, Me.ProformaInvoice, Me.Receipt, Me.RetailReceipt, Me.colLeonida, Me.projectTypeId, Me.projectComments})
        Me.TblProjectDataGridView.DataSource = Me.TblProjectBindingSource
        Me.TblProjectDataGridView.Location = New System.Drawing.Point(37, 334)
        Me.TblProjectDataGridView.Name = "TblProjectDataGridView"
        Me.TblProjectDataGridView.Size = New System.Drawing.Size(1152, 220)
        Me.TblProjectDataGridView.TabIndex = 3
        '
        'VwCustomerDiadrasisBindingSource
        '
        Me.VwCustomerDiadrasisBindingSource.DataMember = "vwCustomerDiadrasis"
        Me.VwCustomerDiadrasisBindingSource.DataSource = Me.DiadrasisProjectsDBDataSet
        '
        'VwCustomerBindingSource
        '
        Me.VwCustomerBindingSource.DataMember = "vwCustomer"
        Me.VwCustomerBindingSource.DataSource = Me.DiadrasisProjectsDBDataSet
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(976, 179)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 4
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.TblProjectTypeBindingSource
        Me.ComboBox1.DisplayMember = "projectTypeName"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(395, 214)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(285, 21)
        Me.ComboBox1.TabIndex = 5
        Me.ComboBox1.ValueMember = "projectTypeId"
        '
        'TblProjectTypeBindingSource
        '
        Me.TblProjectTypeBindingSource.DataMember = "tblProjectType"
        Me.TblProjectTypeBindingSource.DataSource = Me.DiadrasisProjectsDBDataSet
        '
        'TblProjectTableAdapter
        '
        Me.TblProjectTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
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
        Me.TableAdapterManager.tblProjectTableAdapter = Me.TblProjectTableAdapter
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
        Me.TableAdapterManager.UpdateOrder = diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'VwCustomerTableAdapter
        '
        Me.VwCustomerTableAdapter.ClearBeforeFill = True
        '
        'TblProjectTypeTableAdapter
        '
        Me.TblProjectTypeTableAdapter.ClearBeforeFill = True
        '
        'VwCustomerDiadrasisTableAdapter
        '
        Me.VwCustomerDiadrasisTableAdapter.ClearBeforeFill = True
        '
        'projectId
        '
        Me.projectId.DataPropertyName = "projectId"
        Me.projectId.HeaderText = "projectId"
        Me.projectId.Name = "projectId"
        Me.projectId.ReadOnly = True
        '
        'customerId
        '
        Me.customerId.DataPropertyName = "customerId"
        Me.customerId.DataSource = Me.VwCustomerDiadrasisBindingSource
        Me.customerId.DisplayMember = "customerTitle"
        Me.customerId.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.customerId.HeaderText = "customerId"
        Me.customerId.Name = "customerId"
        Me.customerId.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.customerId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.customerId.ValueMember = "customerId"
        '
        'projectName
        '
        Me.projectName.DataPropertyName = "projectName"
        Me.projectName.HeaderText = "projectName"
        Me.projectName.MaxInputLength = 1000000
        Me.projectName.Name = "projectName"
        '
        'projectDescription
        '
        Me.projectDescription.DataPropertyName = "projectDescription"
        Me.projectDescription.HeaderText = "projectDescription"
        Me.projectDescription.MaxInputLength = 10000000
        Me.projectDescription.Name = "projectDescription"
        '
        'projectDateStart
        '
        Me.projectDateStart.DataPropertyName = "projectDateStart"
        Me.projectDateStart.HeaderText = "projectDateStart"
        Me.projectDateStart.Name = "projectDateStart"
        '
        'projectDateEnd
        '
        Me.projectDateEnd.DataPropertyName = "projectDateEnd"
        Me.projectDateEnd.HeaderText = "projectDateEnd"
        Me.projectDateEnd.Name = "projectDateEnd"
        '
        'projectHumanMonths
        '
        Me.projectHumanMonths.DataPropertyName = "projectHumanMonths"
        Me.projectHumanMonths.HeaderText = "projectHumanMonths"
        Me.projectHumanMonths.Name = "projectHumanMonths"
        '
        'projectBudget
        '
        Me.projectBudget.DataPropertyName = "projectBudget"
        Me.projectBudget.HeaderText = "projectBudget"
        Me.projectBudget.Name = "projectBudget"
        '
        'tasks
        '
        Me.tasks.HeaderText = "Εργασίες"
        Me.tasks.Image = Global.diadrasisProjects.My.Resources.Resources.tag_blue
        Me.tasks.Name = "tasks"
        '
        'staff
        '
        Me.staff.HeaderText = "staff"
        Me.staff.Image = Global.diadrasisProjects.My.Resources.Resources.users
        Me.staff.Name = "staff"
        '
        'invoice
        '
        Me.invoice.HeaderText = "Τιμολόγηση Υπηρεσιών"
        Me.invoice.Image = Global.diadrasisProjects.My.Resources.Resources.coins
        Me.invoice.Name = "invoice"
        '
        'ProductInvoice
        '
        Me.ProductInvoice.HeaderText = "Τιμολόγηση Προιόντος"
        Me.ProductInvoice.Image = Global.diadrasisProjects.My.Resources.Resources.coins
        Me.ProductInvoice.Name = "ProductInvoice"
        Me.ProductInvoice.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'CreditInvoice
        '
        Me.CreditInvoice.HeaderText = "Πιστωτικό"
        Me.CreditInvoice.Image = Global.diadrasisProjects.My.Resources.Resources.coins
        Me.CreditInvoice.Name = "CreditInvoice"
        '
        'ProformaInvoice
        '
        Me.ProformaInvoice.HeaderText = "ProfrmaInvoice"
        Me.ProformaInvoice.Image = Global.diadrasisProjects.My.Resources.Resources.coins
        Me.ProformaInvoice.Name = "ProformaInvoice"
        '
        'Receipt
        '
        Me.Receipt.HeaderText = "Receipt"
        Me.Receipt.Image = Global.diadrasisProjects.My.Resources.Resources.coins
        Me.Receipt.Name = "Receipt"
        '
        'RetailReceipt
        '
        Me.RetailReceipt.HeaderText = "Απόδειξη Λιανικής"
        Me.RetailReceipt.Image = Global.diadrasisProjects.My.Resources.Resources.coins
        Me.RetailReceipt.Name = "RetailReceipt"
        Me.RetailReceipt.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RetailReceipt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'colLeonida
        '
        Me.colLeonida.HeaderText = "ΔΠΥ"
        Me.colLeonida.Image = Global.diadrasisProjects.My.Resources.Resources.invoice
        Me.colLeonida.Name = "colLeonida"
        Me.colLeonida.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colLeonida.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'projectTypeId
        '
        Me.projectTypeId.DataPropertyName = "projectTypeId"
        Me.projectTypeId.HeaderText = "projectTypeId"
        Me.projectTypeId.Name = "projectTypeId"
        '
        'projectComments
        '
        Me.projectComments.DataPropertyName = "projectComments"
        Me.projectComments.HeaderText = "projectComments"
        Me.projectComments.Name = "projectComments"
        '
        'frmProject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1252, 730)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.TblProjectDataGridView)
        Me.Controls.Add(Me.TblProjectBindingNavigator)
        Me.Name = "frmProject"
        Me.Controls.SetChildIndex(Me.TblProjectBindingNavigator, 0)
        Me.Controls.SetChildIndex(Me.TblProjectDataGridView, 0)
        Me.Controls.SetChildIndex(Me.MonthCalendar1, 0)
        Me.Controls.SetChildIndex(Me.ComboBox1, 0)
        CType(Me.TblProjectBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblProjectBindingNavigator.ResumeLayout(False)
        Me.TblProjectBindingNavigator.PerformLayout()
        CType(Me.TblProjectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiadrasisProjectsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblProjectDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwCustomerDiadrasisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwCustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblProjectTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DiadrasisProjectsDBDataSet As diadrasisProjects.diadrasisProjectsDBDataSet
    Friend WithEvents TblProjectBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblProjectTableAdapter As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.tblProjectTableAdapter
    Friend WithEvents TableAdapterManager As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblProjectBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TblProjectBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TblProjectDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VwCustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VwCustomerTableAdapter As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.vwCustomerTableAdapter
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TblProjectTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblProjectTypeTableAdapter As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.tblProjectTypeTableAdapter
    Friend WithEvents VwCustomerDiadrasisBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VwCustomerDiadrasisTableAdapter As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.vwCustomerDiadrasisTableAdapter
    Friend WithEvents projectId As DataGridViewTextBoxColumn
    Friend WithEvents customerId As DataGridViewComboBoxColumn
    Friend WithEvents projectName As DataGridViewTextBoxColumn
    Friend WithEvents projectDescription As DataGridViewTextBoxColumn
    Friend WithEvents projectDateStart As DataGridViewTextBoxColumn
    Friend WithEvents projectDateEnd As DataGridViewTextBoxColumn
    Friend WithEvents projectHumanMonths As DataGridViewTextBoxColumn
    Friend WithEvents projectBudget As DataGridViewTextBoxColumn
    Friend WithEvents tasks As DataGridViewImageColumn
    Friend WithEvents staff As DataGridViewImageColumn
    Friend WithEvents invoice As DataGridViewImageColumn
    Friend WithEvents ProductInvoice As DataGridViewImageColumn
    Friend WithEvents CreditInvoice As DataGridViewImageColumn
    Friend WithEvents ProformaInvoice As DataGridViewImageColumn
    Friend WithEvents Receipt As DataGridViewImageColumn
    Friend WithEvents RetailReceipt As DataGridViewImageColumn
    Friend WithEvents colLeonida As DataGridViewImageColumn
    Friend WithEvents projectTypeId As DataGridViewTextBoxColumn
    Friend WithEvents projectComments As DataGridViewTextBoxColumn
End Class

