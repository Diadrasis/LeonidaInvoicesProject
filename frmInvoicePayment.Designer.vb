<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInvoicePayment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim InvoiceIdLabel As System.Windows.Forms.Label
        Dim ProjectIdLabel As System.Windows.Forms.Label
        Dim InvoiceTypeIdLabel As System.Windows.Forms.Label
        Dim InvoiceCodeLabel As System.Windows.Forms.Label
        Dim InvoiceDateLabel As System.Windows.Forms.Label
        Dim InvoicePaidLabel As System.Windows.Forms.Label
        Dim PayDateLabel As System.Windows.Forms.Label
        Dim PayCommentsLabel As System.Windows.Forms.Label
        Dim InvoiceCommentsLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim InvresIDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInvoicePayment))
        Dim InvPaymentTypeIDLabel As System.Windows.Forms.Label
        Me.leonidaDBDataSet = New leonida.leonidaDBDataSet()
        Me.TblInvoicesByIDPaymentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblInvoicesByIDPaymentTableAdapter = New leonida.leonidaDBDataSetTableAdapters.tblInvoicesByIDPaymentTableAdapter()
        Me.TableAdapterManager = New leonida.leonidaDBDataSetTableAdapters.TableAdapterManager()
        Me.TblInvoiceTypesTableAdapter = New leonida.leonidaDBDataSetTableAdapters.tblInvoiceTypesTableAdapter()
        Me.TblProjectTableAdapter = New leonida.leonidaDBDataSetTableAdapters.tblProjectTableAdapter()
        Me.TblInvoicesByIDPaymentBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.TblInvoicesByIDPaymentBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.InvoiceIdTextBox = New System.Windows.Forms.TextBox()
        Me.ProjectIdComboBox = New System.Windows.Forms.ComboBox()
        Me.TblProjectBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InvoiceTypeIdComboBox = New System.Windows.Forms.ComboBox()
        Me.TblInvoiceTypesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InvoiceCodeLabel1 = New System.Windows.Forms.Label()
        Me.InvoiceDateLabel1 = New System.Windows.Forms.Label()
        Me.InvoicePaidCheckBox = New System.Windows.Forms.CheckBox()
        Me.PayDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.VwProjectBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VwProjectTableAdapter = New leonida.leonidaDBDataSetTableAdapters.vwProjectTableAdapter()
        Me.PayCommentsTextBox = New System.Windows.Forms.TextBox()
        Me.InvoiceCommentsLabel1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.InvresIDComboBox = New System.Windows.Forms.ComboBox()
        Me.TblInvoiceResponsiblesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.leonidaDBDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblInvoiceResponsiblesTableAdapter = New leonida.leonidaDBDataSetTableAdapters.tblInvoiceResponsiblesTableAdapter()
        Me.InvPaymentTypeIDComboBox = New System.Windows.Forms.ComboBox()
        Me.TblInvoicePaymentTypesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblInvoicePaymentTypesTableAdapter = New leonida.leonidaDBDataSetTableAdapters.tblInvoicePaymentTypesTableAdapter()
        InvoiceIdLabel = New System.Windows.Forms.Label()
        ProjectIdLabel = New System.Windows.Forms.Label()
        InvoiceTypeIdLabel = New System.Windows.Forms.Label()
        InvoiceCodeLabel = New System.Windows.Forms.Label()
        InvoiceDateLabel = New System.Windows.Forms.Label()
        InvoicePaidLabel = New System.Windows.Forms.Label()
        PayDateLabel = New System.Windows.Forms.Label()
        PayCommentsLabel = New System.Windows.Forms.Label()
        InvoiceCommentsLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        InvresIDLabel = New System.Windows.Forms.Label()
        InvPaymentTypeIDLabel = New System.Windows.Forms.Label()
        CType(Me.leonidaDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblInvoicesByIDPaymentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblInvoicesByIDPaymentBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblInvoicesByIDPaymentBindingNavigator.SuspendLayout()
        CType(Me.TblProjectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblInvoiceTypesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwProjectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblInvoiceResponsiblesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leonidaDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblInvoicePaymentTypesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InvoiceIdLabel
        '
        InvoiceIdLabel.AutoSize = True
        InvoiceIdLabel.Location = New System.Drawing.Point(71, 20)
        InvoiceIdLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        InvoiceIdLabel.Name = "InvoiceIdLabel"
        InvoiceIdLabel.Size = New System.Drawing.Size(75, 17)
        InvoiceIdLabel.TabIndex = 2
        InvoiceIdLabel.Text = "invoice Id:"
        InvoiceIdLabel.Visible = False
        '
        'ProjectIdLabel
        '
        ProjectIdLabel.AutoSize = True
        ProjectIdLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        ProjectIdLabel.Location = New System.Drawing.Point(139, 103)
        ProjectIdLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ProjectIdLabel.Name = "ProjectIdLabel"
        ProjectIdLabel.Size = New System.Drawing.Size(45, 17)
        ProjectIdLabel.TabIndex = 4
        ProjectIdLabel.Text = "Έργο:"
        '
        'InvoiceTypeIdLabel
        '
        InvoiceTypeIdLabel.AutoSize = True
        InvoiceTypeIdLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        InvoiceTypeIdLabel.Location = New System.Drawing.Point(89, 139)
        InvoiceTypeIdLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        InvoiceTypeIdLabel.Name = "InvoiceTypeIdLabel"
        InvoiceTypeIdLabel.Size = New System.Drawing.Size(95, 17)
        InvoiceTypeIdLabel.TabIndex = 6
        InvoiceTypeIdLabel.Text = "Παραστατικό:"
        '
        'InvoiceCodeLabel
        '
        InvoiceCodeLabel.AutoSize = True
        InvoiceCodeLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        InvoiceCodeLabel.Location = New System.Drawing.Point(117, 180)
        InvoiceCodeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        InvoiceCodeLabel.Name = "InvoiceCodeLabel"
        InvoiceCodeLabel.Size = New System.Drawing.Size(67, 17)
        InvoiceCodeLabel.TabIndex = 10
        InvoiceCodeLabel.Text = "Αριθμός:"
        '
        'InvoiceDateLabel
        '
        InvoiceDateLabel.AutoSize = True
        InvoiceDateLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        InvoiceDateLabel.Location = New System.Drawing.Point(95, 211)
        InvoiceDateLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        InvoiceDateLabel.Name = "InvoiceDateLabel"
        InvoiceDateLabel.Size = New System.Drawing.Size(89, 17)
        InvoiceDateLabel.TabIndex = 12
        InvoiceDateLabel.Text = "Ημερομηνία:"
        '
        'InvoicePaidLabel
        '
        InvoicePaidLabel.AutoSize = True
        InvoicePaidLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        InvoicePaidLabel.Location = New System.Drawing.Point(107, 336)
        InvoicePaidLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        InvoicePaidLabel.Name = "InvoicePaidLabel"
        InvoicePaidLabel.Size = New System.Drawing.Size(90, 17)
        InvoicePaidLabel.TabIndex = 16
        InvoicePaidLabel.Text = "Εξοφλημένο:"
        '
        'PayDateLabel
        '
        PayDateLabel.AutoSize = True
        PayDateLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        PayDateLabel.Location = New System.Drawing.Point(31, 374)
        PayDateLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PayDateLabel.Name = "PayDateLabel"
        PayDateLabel.Size = New System.Drawing.Size(165, 17)
        PayDateLabel.TabIndex = 18
        PayDateLabel.Text = "Ημερομηνία Εξόφλησης:"
        '
        'PayCommentsLabel
        '
        PayCommentsLabel.AutoSize = True
        PayCommentsLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        PayCommentsLabel.Location = New System.Drawing.Point(71, 411)
        PayCommentsLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PayCommentsLabel.Name = "PayCommentsLabel"
        PayCommentsLabel.Size = New System.Drawing.Size(125, 17)
        PayCommentsLabel.TabIndex = 19
        PayCommentsLabel.Text = "Σχόλια Πληρωμής:"
        '
        'InvoiceCommentsLabel
        '
        InvoiceCommentsLabel.AutoSize = True
        InvoiceCommentsLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        InvoiceCommentsLabel.Location = New System.Drawing.Point(131, 252)
        InvoiceCommentsLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        InvoiceCommentsLabel.Name = "InvoiceCommentsLabel"
        InvoiceCommentsLabel.Size = New System.Drawing.Size(53, 17)
        InvoiceCommentsLabel.TabIndex = 20
        InvoiceCommentsLabel.Text = "Σχόλια:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Label3.Location = New System.Drawing.Point(30, 531)
        Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(166, 17)
        Label3.TabIndex = 24
        Label3.Text = "Αποθήκευση Πληρωμής:"
        '
        'InvresIDLabel
        '
        InvresIDLabel.AutoSize = True
        InvresIDLabel.Location = New System.Drawing.Point(107, 486)
        InvresIDLabel.Name = "InvresIDLabel"
        InvresIDLabel.Size = New System.Drawing.Size(84, 17)
        InvresIDLabel.TabIndex = 24
        InvresIDLabel.Text = "Υπεύθυνος:"
        AddHandler InvresIDLabel.Click, AddressOf Me.InvresIDLabel_Click
        '
        'leonidaDBDataSet
        '
        Me.leonidaDBDataSet.DataSetName = "leonidaDBDataSet"
        Me.leonidaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblInvoicesByIDPaymentBindingSource
        '
        Me.TblInvoicesByIDPaymentBindingSource.DataMember = "tblInvoicesByIDPayment"
        Me.TblInvoicesByIDPaymentBindingSource.DataSource = Me.leonidaDBDataSet
        '
        'TblInvoicesByIDPaymentTableAdapter
        '
        Me.TblInvoicesByIDPaymentTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tblInvoicesByIDPaymentTableAdapter = Me.TblInvoicesByIDPaymentTableAdapter
        Me.TableAdapterManager.tblInvoicesTableAdapter = Nothing
        Me.TableAdapterManager.tblInvoiceTypesTableAdapter = Me.TblInvoiceTypesTableAdapter
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
        Me.TableAdapterManager.UpdateOrder = leonida.leonidaDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblInvoiceTypesTableAdapter
        '
        Me.TblInvoiceTypesTableAdapter.ClearBeforeFill = True
        '
        'TblProjectTableAdapter
        '
        Me.TblProjectTableAdapter.ClearBeforeFill = True
        '
        'TblInvoicesByIDPaymentBindingNavigator
        '
        Me.TblInvoicesByIDPaymentBindingNavigator.AddNewItem = Nothing
        Me.TblInvoicesByIDPaymentBindingNavigator.BindingSource = Me.TblInvoicesByIDPaymentBindingSource
        Me.TblInvoicesByIDPaymentBindingNavigator.CountItem = Nothing
        Me.TblInvoicesByIDPaymentBindingNavigator.DeleteItem = Nothing
        Me.TblInvoicesByIDPaymentBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.TblInvoicesByIDPaymentBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TblInvoicesByIDPaymentBindingNavigatorSaveItem})
        Me.TblInvoicesByIDPaymentBindingNavigator.Location = New System.Drawing.Point(208, 531)
        Me.TblInvoicesByIDPaymentBindingNavigator.MoveFirstItem = Nothing
        Me.TblInvoicesByIDPaymentBindingNavigator.MoveLastItem = Nothing
        Me.TblInvoicesByIDPaymentBindingNavigator.MoveNextItem = Nothing
        Me.TblInvoicesByIDPaymentBindingNavigator.MovePreviousItem = Nothing
        Me.TblInvoicesByIDPaymentBindingNavigator.Name = "TblInvoicesByIDPaymentBindingNavigator"
        Me.TblInvoicesByIDPaymentBindingNavigator.PositionItem = Nothing
        Me.TblInvoicesByIDPaymentBindingNavigator.Size = New System.Drawing.Size(35, 25)
        Me.TblInvoicesByIDPaymentBindingNavigator.TabIndex = 0
        Me.TblInvoicesByIDPaymentBindingNavigator.Text = "BindingNavigator1"
        '
        'TblInvoicesByIDPaymentBindingNavigatorSaveItem
        '
        Me.TblInvoicesByIDPaymentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblInvoicesByIDPaymentBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblInvoicesByIDPaymentBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblInvoicesByIDPaymentBindingNavigatorSaveItem.Name = "TblInvoicesByIDPaymentBindingNavigatorSaveItem"
        Me.TblInvoicesByIDPaymentBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TblInvoicesByIDPaymentBindingNavigatorSaveItem.Text = "Save Data"
        '
        'InvoiceIdTextBox
        '
        Me.InvoiceIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblInvoicesByIDPaymentBindingSource, "invoiceId", True))
        Me.InvoiceIdTextBox.Location = New System.Drawing.Point(208, 13)
        Me.InvoiceIdTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.InvoiceIdTextBox.Name = "InvoiceIdTextBox"
        Me.InvoiceIdTextBox.Size = New System.Drawing.Size(265, 23)
        Me.InvoiceIdTextBox.TabIndex = 3
        Me.InvoiceIdTextBox.Visible = False
        '
        'ProjectIdComboBox
        '
        Me.ProjectIdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblInvoicesByIDPaymentBindingSource, "projectId", True))
        Me.ProjectIdComboBox.DataSource = Me.TblProjectBindingSource
        Me.ProjectIdComboBox.DisplayMember = "projectName"
        Me.ProjectIdComboBox.Enabled = False
        Me.ProjectIdComboBox.FormattingEnabled = True
        Me.ProjectIdComboBox.Location = New System.Drawing.Point(208, 99)
        Me.ProjectIdComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ProjectIdComboBox.Name = "ProjectIdComboBox"
        Me.ProjectIdComboBox.Size = New System.Drawing.Size(564, 25)
        Me.ProjectIdComboBox.TabIndex = 5
        Me.ProjectIdComboBox.ValueMember = "projectId"
        '
        'TblProjectBindingSource
        '
        Me.TblProjectBindingSource.DataMember = "tblProject"
        Me.TblProjectBindingSource.DataSource = Me.leonidaDBDataSet
        '
        'InvoiceTypeIdComboBox
        '
        Me.InvoiceTypeIdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblInvoicesByIDPaymentBindingSource, "invoiceTypeId", True))
        Me.InvoiceTypeIdComboBox.DataSource = Me.TblInvoiceTypesBindingSource
        Me.InvoiceTypeIdComboBox.DisplayMember = "invoiceTypeDescription"
        Me.InvoiceTypeIdComboBox.Enabled = False
        Me.InvoiceTypeIdComboBox.FormattingEnabled = True
        Me.InvoiceTypeIdComboBox.Location = New System.Drawing.Point(208, 135)
        Me.InvoiceTypeIdComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.InvoiceTypeIdComboBox.Name = "InvoiceTypeIdComboBox"
        Me.InvoiceTypeIdComboBox.Size = New System.Drawing.Size(265, 25)
        Me.InvoiceTypeIdComboBox.TabIndex = 7
        Me.InvoiceTypeIdComboBox.ValueMember = "invoiceTypeId"
        '
        'TblInvoiceTypesBindingSource
        '
        Me.TblInvoiceTypesBindingSource.DataMember = "tblInvoiceTypes"
        Me.TblInvoiceTypesBindingSource.DataSource = Me.leonidaDBDataSet
        '
        'InvoiceCodeLabel1
        '
        Me.InvoiceCodeLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblInvoicesByIDPaymentBindingSource, "invoiceCode", True))
        Me.InvoiceCodeLabel1.Location = New System.Drawing.Point(208, 180)
        Me.InvoiceCodeLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.InvoiceCodeLabel1.Name = "InvoiceCodeLabel1"
        Me.InvoiceCodeLabel1.Size = New System.Drawing.Size(267, 30)
        Me.InvoiceCodeLabel1.TabIndex = 11
        Me.InvoiceCodeLabel1.Text = "Label1"
        '
        'InvoiceDateLabel1
        '
        Me.InvoiceDateLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblInvoicesByIDPaymentBindingSource, "invoiceDate", True))
        Me.InvoiceDateLabel1.Location = New System.Drawing.Point(208, 211)
        Me.InvoiceDateLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.InvoiceDateLabel1.Name = "InvoiceDateLabel1"
        Me.InvoiceDateLabel1.Size = New System.Drawing.Size(267, 30)
        Me.InvoiceDateLabel1.TabIndex = 13
        Me.InvoiceDateLabel1.Text = "Label1"
        '
        'InvoicePaidCheckBox
        '
        Me.InvoicePaidCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TblInvoicesByIDPaymentBindingSource, "invoicePaid", True))
        Me.InvoicePaidCheckBox.Location = New System.Drawing.Point(208, 330)
        Me.InvoicePaidCheckBox.Margin = New System.Windows.Forms.Padding(4)
        Me.InvoicePaidCheckBox.Name = "InvoicePaidCheckBox"
        Me.InvoicePaidCheckBox.Size = New System.Drawing.Size(267, 31)
        Me.InvoicePaidCheckBox.TabIndex = 17
        Me.InvoicePaidCheckBox.UseVisualStyleBackColor = True
        '
        'PayDateDateTimePicker
        '
        Me.PayDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblInvoicesByIDPaymentBindingSource, "payDate", True))
        Me.PayDateDateTimePicker.Location = New System.Drawing.Point(208, 369)
        Me.PayDateDateTimePicker.Margin = New System.Windows.Forms.Padding(4)
        Me.PayDateDateTimePicker.Name = "PayDateDateTimePicker"
        Me.PayDateDateTimePicker.Size = New System.Drawing.Size(265, 23)
        Me.PayDateDateTimePicker.TabIndex = 19
        '
        'VwProjectBindingSource
        '
        Me.VwProjectBindingSource.DataMember = "vwProject"
        Me.VwProjectBindingSource.DataSource = Me.leonidaDBDataSet
        '
        'VwProjectTableAdapter
        '
        Me.VwProjectTableAdapter.ClearBeforeFill = True
        '
        'PayCommentsTextBox
        '
        Me.PayCommentsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblInvoicesByIDPaymentBindingSource, "payComments", True))
        Me.PayCommentsTextBox.Location = New System.Drawing.Point(208, 407)
        Me.PayCommentsTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PayCommentsTextBox.Name = "PayCommentsTextBox"
        Me.PayCommentsTextBox.Size = New System.Drawing.Size(564, 23)
        Me.PayCommentsTextBox.TabIndex = 20
        '
        'InvoiceCommentsLabel1
        '
        Me.InvoiceCommentsLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblInvoicesByIDPaymentBindingSource, "invoiceComments", True))
        Me.InvoiceCommentsLabel1.Location = New System.Drawing.Point(208, 252)
        Me.InvoiceCommentsLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.InvoiceCommentsLabel1.Name = "InvoiceCommentsLabel1"
        Me.InvoiceCommentsLabel1.Size = New System.Drawing.Size(133, 30)
        Me.InvoiceCommentsLabel1.TabIndex = 21
        Me.InvoiceCommentsLabel1.Text = "Label1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label1.Location = New System.Drawing.Point(208, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 16)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Στοιχεία Παραστατικού"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label2.Location = New System.Drawing.Point(205, 310)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 16)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Στοιχεία Πληρωμής"
        '
        'InvresIDComboBox
        '
        Me.InvresIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblInvoicesByIDPaymentBindingSource, "invresID", True))
        Me.InvresIDComboBox.DataSource = Me.TblInvoiceResponsiblesBindingSource
        Me.InvresIDComboBox.DisplayMember = "invresInit"
        Me.InvresIDComboBox.FormattingEnabled = True
        Me.InvresIDComboBox.Location = New System.Drawing.Point(208, 486)
        Me.InvresIDComboBox.Name = "InvresIDComboBox"
        Me.InvresIDComboBox.Size = New System.Drawing.Size(121, 25)
        Me.InvresIDComboBox.TabIndex = 25
        Me.InvresIDComboBox.ValueMember = "invresID"
        '
        'TblInvoiceResponsiblesBindingSource
        '
        Me.TblInvoiceResponsiblesBindingSource.DataMember = "tblInvoiceResponsibles"
        Me.TblInvoiceResponsiblesBindingSource.DataSource = Me.leonidaDBDataSet
        '
        'leonidaDBDataSetBindingSource
        '
        Me.leonidaDBDataSetBindingSource.DataSource = Me.leonidaDBDataSet
        Me.leonidaDBDataSetBindingSource.Position = 0
        '
        'TblInvoiceResponsiblesTableAdapter
        '
        Me.TblInvoiceResponsiblesTableAdapter.ClearBeforeFill = True
        '
        'InvPaymentTypeIDLabel
        '
        InvPaymentTypeIDLabel.AutoSize = True
        InvPaymentTypeIDLabel.Location = New System.Drawing.Point(52, 449)
        InvPaymentTypeIDLabel.Name = "InvPaymentTypeIDLabel"
        InvPaymentTypeIDLabel.Size = New System.Drawing.Size(133, 17)
        InvPaymentTypeIDLabel.TabIndex = 25
        InvPaymentTypeIDLabel.Text = "Τρόπος Πληρωμής:"
        '
        'InvPaymentTypeIDComboBox
        '
        Me.InvPaymentTypeIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblInvoicesByIDPaymentBindingSource, "invPaymentTypeID", True))
        Me.InvPaymentTypeIDComboBox.DataSource = Me.TblInvoicePaymentTypesBindingSource
        Me.InvPaymentTypeIDComboBox.DisplayMember = "invPaymentTypeDesc"
        Me.InvPaymentTypeIDComboBox.FormattingEnabled = True
        Me.InvPaymentTypeIDComboBox.Location = New System.Drawing.Point(209, 446)
        Me.InvPaymentTypeIDComboBox.Name = "InvPaymentTypeIDComboBox"
        Me.InvPaymentTypeIDComboBox.Size = New System.Drawing.Size(219, 25)
        Me.InvPaymentTypeIDComboBox.TabIndex = 26
        Me.InvPaymentTypeIDComboBox.ValueMember = "invPaymentTypeID"
        '
        'TblInvoicePaymentTypesBindingSource
        '
        Me.TblInvoicePaymentTypesBindingSource.DataMember = "tblInvoicePaymentTypes"
        Me.TblInvoicePaymentTypesBindingSource.DataSource = Me.leonidaDBDataSet
        '
        'TblInvoicePaymentTypesTableAdapter
        '
        Me.TblInvoicePaymentTypesTableAdapter.ClearBeforeFill = True
        '
        'frmInvoicePayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(831, 721)
        Me.Controls.Add(InvPaymentTypeIDLabel)
        Me.Controls.Add(Me.InvPaymentTypeIDComboBox)
        Me.Controls.Add(InvresIDLabel)
        Me.Controls.Add(Me.InvresIDComboBox)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(InvoiceCommentsLabel)
        Me.Controls.Add(Me.InvoiceCommentsLabel1)
        Me.Controls.Add(PayCommentsLabel)
        Me.Controls.Add(Me.PayCommentsTextBox)
        Me.Controls.Add(InvoiceIdLabel)
        Me.Controls.Add(Me.InvoiceIdTextBox)
        Me.Controls.Add(ProjectIdLabel)
        Me.Controls.Add(Me.ProjectIdComboBox)
        Me.Controls.Add(InvoiceTypeIdLabel)
        Me.Controls.Add(Me.InvoiceTypeIdComboBox)
        Me.Controls.Add(InvoiceCodeLabel)
        Me.Controls.Add(Me.InvoiceCodeLabel1)
        Me.Controls.Add(InvoiceDateLabel)
        Me.Controls.Add(Me.InvoiceDateLabel1)
        Me.Controls.Add(InvoicePaidLabel)
        Me.Controls.Add(Me.InvoicePaidCheckBox)
        Me.Controls.Add(PayDateLabel)
        Me.Controls.Add(Me.PayDateDateTimePicker)
        Me.Controls.Add(Me.TblInvoicesByIDPaymentBindingNavigator)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmInvoicePayment"
        Me.Text = "frmInvoicePayment"
        CType(Me.leonidaDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblInvoicesByIDPaymentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblInvoicesByIDPaymentBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblInvoicesByIDPaymentBindingNavigator.ResumeLayout(False)
        Me.TblInvoicesByIDPaymentBindingNavigator.PerformLayout()
        CType(Me.TblProjectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblInvoiceTypesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwProjectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblInvoiceResponsiblesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leonidaDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblInvoicePaymentTypesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents leonidaDBDataSet As leonidaDBDataSet
    Friend WithEvents TblInvoicesByIDPaymentBindingSource As BindingSource
    Friend WithEvents TblInvoicesByIDPaymentTableAdapter As leonidaDBDataSetTableAdapters.tblInvoicesByIDPaymentTableAdapter
    Friend WithEvents TableAdapterManager As leonidaDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblInvoicesByIDPaymentBindingNavigator As BindingNavigator
    Friend WithEvents TblInvoicesByIDPaymentBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents InvoiceIdTextBox As TextBox
    Friend WithEvents ProjectIdComboBox As ComboBox
    Friend WithEvents InvoiceTypeIdComboBox As ComboBox
    Friend WithEvents InvoiceCodeLabel1 As Label
    Friend WithEvents InvoiceDateLabel1 As Label
    Friend WithEvents InvoicePaidCheckBox As CheckBox
    Friend WithEvents PayDateDateTimePicker As DateTimePicker
    Friend WithEvents VwProjectBindingSource As BindingSource
    Friend WithEvents VwProjectTableAdapter As leonidaDBDataSetTableAdapters.vwProjectTableAdapter
    Friend WithEvents TblInvoiceTypesTableAdapter As leonidaDBDataSetTableAdapters.tblInvoiceTypesTableAdapter
    Friend WithEvents TblInvoiceTypesBindingSource As BindingSource
    Friend WithEvents TblProjectTableAdapter As leonidaDBDataSetTableAdapters.tblProjectTableAdapter
    Friend WithEvents TblProjectBindingSource As BindingSource
    Friend WithEvents PayCommentsTextBox As TextBox
    Friend WithEvents InvoiceCommentsLabel1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents InvresIDComboBox As ComboBox
    Friend WithEvents leonidaDBDataSetBindingSource As BindingSource
    Friend WithEvents TblInvoiceResponsiblesBindingSource As BindingSource
    Friend WithEvents TblInvoiceResponsiblesTableAdapter As leonidaDBDataSetTableAdapters.tblInvoiceResponsiblesTableAdapter
    Friend WithEvents InvPaymentTypeIDComboBox As ComboBox
    Friend WithEvents TblInvoicePaymentTypesBindingSource As BindingSource
    Friend WithEvents TblInvoicePaymentTypesTableAdapter As leonidaDBDataSetTableAdapters.tblInvoicePaymentTypesTableAdapter
End Class
