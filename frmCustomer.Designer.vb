<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomer))
        Me.leonidaDBDataSet = New leonida.leonidaDBDataSet()
        Me.TblCustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblCustomerTableAdapter = New leonida.leonidaDBDataSetTableAdapters.tblCustomerTableAdapter()
        Me.TableAdapterManager = New leonida.leonidaDBDataSetTableAdapters.TableAdapterManager()
        Me.TblCustomerBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
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
        Me.TblCustomerBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TblCustomerDataGridView = New System.Windows.Forms.DataGridView()
        Me.customerId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.isDiadrasis = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.customerTitle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customerSurname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customerCompany = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customerAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customerCity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customerZIP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customerTelephone1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customerTelephone2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customerAFM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customerDOY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customerProfession = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customerComments = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.leonidaDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCustomerBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblCustomerBindingNavigator.SuspendLayout()
        CType(Me.TblCustomerDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'leonidaDBDataSet
        '
        Me.leonidaDBDataSet.DataSetName = "leonidaDBDataSet"
        Me.leonidaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblCustomerBindingSource
        '
        Me.TblCustomerBindingSource.DataMember = "tblCustomer"
        Me.TblCustomerBindingSource.DataSource = Me.leonidaDBDataSet
        '
        'TblCustomerTableAdapter
        '
        Me.TblCustomerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblAgreementTableAdapter = Nothing
        Me.TableAdapterManager.tblAgreementTypeTableAdapter = Nothing
        Me.TableAdapterManager.tblCustomerTableAdapter = Me.TblCustomerTableAdapter
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
        'TblCustomerBindingNavigator
        '
        Me.TblCustomerBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblCustomerBindingNavigator.BindingSource = Me.TblCustomerBindingSource
        Me.TblCustomerBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblCustomerBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblCustomerBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.TblCustomerBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblCustomerBindingNavigatorSaveItem})
        Me.TblCustomerBindingNavigator.Location = New System.Drawing.Point(243, 244)
        Me.TblCustomerBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblCustomerBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblCustomerBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblCustomerBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblCustomerBindingNavigator.Name = "TblCustomerBindingNavigator"
        Me.TblCustomerBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblCustomerBindingNavigator.Size = New System.Drawing.Size(278, 25)
        Me.TblCustomerBindingNavigator.TabIndex = 2
        Me.TblCustomerBindingNavigator.Text = "BindingNavigator1"
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
        'TblCustomerBindingNavigatorSaveItem
        '
        Me.TblCustomerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblCustomerBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblCustomerBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblCustomerBindingNavigatorSaveItem.Name = "TblCustomerBindingNavigatorSaveItem"
        Me.TblCustomerBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TblCustomerBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TblCustomerDataGridView
        '
        Me.TblCustomerDataGridView.AllowUserToAddRows = False
        Me.TblCustomerDataGridView.AutoGenerateColumns = False
        Me.TblCustomerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblCustomerDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.customerId, Me.isDiadrasis, Me.customerTitle, Me.customerSurname, Me.customerCompany, Me.customerAddress, Me.customerCity, Me.customerZIP, Me.customerTelephone1, Me.customerTelephone2, Me.customerAFM, Me.customerDOY, Me.customerProfession, Me.customerComments})
        Me.TblCustomerDataGridView.DataSource = Me.TblCustomerBindingSource
        Me.TblCustomerDataGridView.Location = New System.Drawing.Point(243, 303)
        Me.TblCustomerDataGridView.Name = "TblCustomerDataGridView"
        Me.TblCustomerDataGridView.Size = New System.Drawing.Size(754, 220)
        Me.TblCustomerDataGridView.TabIndex = 3
        '
        'customerId
        '
        Me.customerId.DataPropertyName = "customerId"
        Me.customerId.HeaderText = "customerId"
        Me.customerId.Name = "customerId"
        Me.customerId.ReadOnly = True
        '
        'isDiadrasis
        '
        Me.isDiadrasis.DataPropertyName = "isDiadrasis"
        Me.isDiadrasis.HeaderText = "isDiadrasis"
        Me.isDiadrasis.Name = "isDiadrasis"
        '
        'customerTitle
        '
        Me.customerTitle.DataPropertyName = "customerTitle"
        Me.customerTitle.HeaderText = "customerTitle"
        Me.customerTitle.Name = "customerTitle"
        '
        'customerSurname
        '
        Me.customerSurname.DataPropertyName = "customerSurname"
        Me.customerSurname.HeaderText = "customerSurname"
        Me.customerSurname.Name = "customerSurname"
        '
        'customerCompany
        '
        Me.customerCompany.DataPropertyName = "customerCompany"
        Me.customerCompany.HeaderText = "customerCompany"
        Me.customerCompany.Name = "customerCompany"
        '
        'customerAddress
        '
        Me.customerAddress.DataPropertyName = "customerAddress"
        Me.customerAddress.HeaderText = "customerAddress"
        Me.customerAddress.Name = "customerAddress"
        '
        'customerCity
        '
        Me.customerCity.DataPropertyName = "customerCity"
        Me.customerCity.HeaderText = "customerCity"
        Me.customerCity.Name = "customerCity"
        '
        'customerZIP
        '
        Me.customerZIP.DataPropertyName = "customerZIP"
        Me.customerZIP.HeaderText = "customerZIP"
        Me.customerZIP.Name = "customerZIP"
        '
        'customerTelephone1
        '
        Me.customerTelephone1.DataPropertyName = "customerTelephone1"
        Me.customerTelephone1.HeaderText = "customerTelephone1"
        Me.customerTelephone1.Name = "customerTelephone1"
        '
        'customerTelephone2
        '
        Me.customerTelephone2.DataPropertyName = "customerTelephone2"
        Me.customerTelephone2.HeaderText = "customerTelephone2"
        Me.customerTelephone2.Name = "customerTelephone2"
        '
        'customerAFM
        '
        Me.customerAFM.DataPropertyName = "customerAFM"
        Me.customerAFM.HeaderText = "customerAFM"
        Me.customerAFM.Name = "customerAFM"
        '
        'customerDOY
        '
        Me.customerDOY.DataPropertyName = "customerDOY"
        Me.customerDOY.HeaderText = "customerDOY"
        Me.customerDOY.Name = "customerDOY"
        '
        'customerProfession
        '
        Me.customerProfession.DataPropertyName = "customerProfession"
        Me.customerProfession.HeaderText = "customerProfession"
        Me.customerProfession.Name = "customerProfession"
        '
        'customerComments
        '
        Me.customerComments.DataPropertyName = "customerComments"
        Me.customerComments.HeaderText = "customerComments"
        Me.customerComments.Name = "customerComments"
        '
        'frmCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1252, 730)
        Me.Controls.Add(Me.TblCustomerDataGridView)
        Me.Controls.Add(Me.TblCustomerBindingNavigator)
        Me.Name = "frmCustomer"
        Me.Controls.SetChildIndex(Me.TblCustomerBindingNavigator, 0)
        Me.Controls.SetChildIndex(Me.TblCustomerDataGridView, 0)
        CType(Me.leonidaDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCustomerBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblCustomerBindingNavigator.ResumeLayout(False)
        Me.TblCustomerBindingNavigator.PerformLayout()
        CType(Me.TblCustomerDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents leonidaDBDataSet As leonida.leonidaDBDataSet
    Friend WithEvents TblCustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblCustomerTableAdapter As leonida.leonidaDBDataSetTableAdapters.tblCustomerTableAdapter
    Friend WithEvents TableAdapterManager As leonida.leonidaDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblCustomerBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents TblCustomerBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TblCustomerDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customerName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customerId As DataGridViewTextBoxColumn
    Friend WithEvents isDiadrasis As DataGridViewCheckBoxColumn
    Friend WithEvents customerTitle As DataGridViewTextBoxColumn
    Friend WithEvents customerSurname As DataGridViewTextBoxColumn
    Friend WithEvents customerCompany As DataGridViewTextBoxColumn
    Friend WithEvents customerAddress As DataGridViewTextBoxColumn
    Friend WithEvents customerCity As DataGridViewTextBoxColumn
    Friend WithEvents customerZIP As DataGridViewTextBoxColumn
    Friend WithEvents customerTelephone1 As DataGridViewTextBoxColumn
    Friend WithEvents customerTelephone2 As DataGridViewTextBoxColumn
    Friend WithEvents customerAFM As DataGridViewTextBoxColumn
    Friend WithEvents customerDOY As DataGridViewTextBoxColumn
    Friend WithEvents customerProfession As DataGridViewTextBoxColumn
    Friend WithEvents customerComments As DataGridViewTextBoxColumn
End Class
