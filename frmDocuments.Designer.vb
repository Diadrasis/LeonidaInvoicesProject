<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDocuments
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDocuments))
        Me.TblQADocumentsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.TblQADocumentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.leonidaDBDataSet = New leonida.leonidaDBDataSet
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.TblQADocumentsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.TblQADocumentsDataGridView = New System.Windows.Forms.DataGridView
        Me.docID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.docInternal = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.docTitle = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.docCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.docPublication = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.docDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.docDuration = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.VcDurationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.docResponsible = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.VcResponibilitiesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.docType = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.TblQADocumentTypesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.docReview = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.docFile = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.docFileLocation = New System.Windows.Forms.DataGridViewImageColumn
        Me.docFileOpen = New System.Windows.Forms.DataGridViewImageColumn
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.Button4 = New System.Windows.Forms.Button
        Me.TblQADocumentsTableAdapter = New leonida.leonidaDBDataSetTableAdapters.tblQADocumentsTableAdapter
        Me.TableAdapterManager = New leonida.leonidaDBDataSetTableAdapters.TableAdapterManager
        Me.VcDurationsTableAdapter = New leonida.leonidaDBDataSetTableAdapters.vcDurationsTableAdapter
        Me.VcResponibilitiesTableAdapter = New leonida.leonidaDBDataSetTableAdapters.vcResponibilitiesTableAdapter
        Me.TblQADocumentTypesTableAdapter = New leonida.leonidaDBDataSetTableAdapters.tblQADocumentTypesTableAdapter
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        CType(Me.TblQADocumentsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblQADocumentsBindingNavigator.SuspendLayout()
        CType(Me.TblQADocumentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leonidaDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblQADocumentsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VcDurationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VcResponibilitiesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblQADocumentTypesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TblQADocumentsBindingNavigator
        '
        Me.TblQADocumentsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblQADocumentsBindingNavigator.BindingSource = Me.TblQADocumentsBindingSource
        Me.TblQADocumentsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblQADocumentsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblQADocumentsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblQADocumentsBindingNavigatorSaveItem})
        Me.TblQADocumentsBindingNavigator.Location = New System.Drawing.Point(0, 128)
        Me.TblQADocumentsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblQADocumentsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblQADocumentsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblQADocumentsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblQADocumentsBindingNavigator.Name = "TblQADocumentsBindingNavigator"
        Me.TblQADocumentsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblQADocumentsBindingNavigator.Size = New System.Drawing.Size(1252, 25)
        Me.TblQADocumentsBindingNavigator.TabIndex = 2
        Me.TblQADocumentsBindingNavigator.Text = "BindingNavigator1"
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
        'TblQADocumentsBindingSource
        '
        Me.TblQADocumentsBindingSource.DataMember = "tblQADocuments"
        Me.TblQADocumentsBindingSource.DataSource = Me.leonidaDBDataSet
        '
        'leonidaDBDataSet
        '
        Me.leonidaDBDataSet.DataSetName = "leonidaDBDataSet"
        Me.leonidaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TblQADocumentsBindingNavigatorSaveItem
        '
        Me.TblQADocumentsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblQADocumentsBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblQADocumentsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblQADocumentsBindingNavigatorSaveItem.Name = "TblQADocumentsBindingNavigatorSaveItem"
        Me.TblQADocumentsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TblQADocumentsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TblQADocumentsDataGridView
        '
        Me.TblQADocumentsDataGridView.AutoGenerateColumns = False
        Me.TblQADocumentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblQADocumentsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.docID, Me.docInternal, Me.docTitle, Me.docCode, Me.docPublication, Me.docDate, Me.docDuration, Me.docResponsible, Me.docType, Me.docReview, Me.docFile, Me.docFileLocation, Me.docFileOpen})
        Me.TblQADocumentsDataGridView.DataSource = Me.TblQADocumentsBindingSource
        Me.TblQADocumentsDataGridView.Location = New System.Drawing.Point(12, 235)
        Me.TblQADocumentsDataGridView.Name = "TblQADocumentsDataGridView"
        Me.TblQADocumentsDataGridView.Size = New System.Drawing.Size(1064, 220)
        Me.TblQADocumentsDataGridView.TabIndex = 3
        '
        'docID
        '
        Me.docID.DataPropertyName = "docID"
        Me.docID.HeaderText = "docID"
        Me.docID.Name = "docID"
        Me.docID.ReadOnly = True
        '
        'docInternal
        '
        Me.docInternal.DataPropertyName = "docInternal"
        Me.docInternal.HeaderText = "docInternal"
        Me.docInternal.Name = "docInternal"
        '
        'docTitle
        '
        Me.docTitle.DataPropertyName = "docTitle"
        Me.docTitle.HeaderText = "docTitle"
        Me.docTitle.Name = "docTitle"
        '
        'docCode
        '
        Me.docCode.DataPropertyName = "docCode"
        Me.docCode.HeaderText = "docCode"
        Me.docCode.Name = "docCode"
        '
        'docPublication
        '
        Me.docPublication.DataPropertyName = "docPublication"
        Me.docPublication.HeaderText = "docPublication"
        Me.docPublication.Name = "docPublication"
        '
        'docDate
        '
        Me.docDate.DataPropertyName = "docDate"
        Me.docDate.HeaderText = "docDate"
        Me.docDate.Name = "docDate"
        '
        'docDuration
        '
        Me.docDuration.DataPropertyName = "docDuration"
        Me.docDuration.DataSource = Me.VcDurationsBindingSource
        Me.docDuration.DisplayMember = "durDesc"
        Me.docDuration.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.docDuration.HeaderText = "docDuration"
        Me.docDuration.Name = "docDuration"
        Me.docDuration.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.docDuration.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.docDuration.ValueMember = "durID"
        '
        'VcDurationsBindingSource
        '
        Me.VcDurationsBindingSource.DataMember = "vcDurations"
        Me.VcDurationsBindingSource.DataSource = Me.leonidaDBDataSet
        '
        'docResponsible
        '
        Me.docResponsible.DataPropertyName = "docResponsible"
        Me.docResponsible.DataSource = Me.VcResponibilitiesBindingSource
        Me.docResponsible.DisplayMember = "respDesc"
        Me.docResponsible.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.docResponsible.HeaderText = "docResponsible"
        Me.docResponsible.Name = "docResponsible"
        Me.docResponsible.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.docResponsible.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.docResponsible.ValueMember = "respID"
        '
        'VcResponibilitiesBindingSource
        '
        Me.VcResponibilitiesBindingSource.DataMember = "vcResponibilities"
        Me.VcResponibilitiesBindingSource.DataSource = Me.leonidaDBDataSet
        '
        'docType
        '
        Me.docType.DataPropertyName = "docType"
        Me.docType.DataSource = Me.TblQADocumentTypesBindingSource
        Me.docType.DisplayMember = "doctypeDesc"
        Me.docType.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.docType.HeaderText = "docType"
        Me.docType.Name = "docType"
        Me.docType.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.docType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.docType.ValueMember = "doctypeID"
        '
        'TblQADocumentTypesBindingSource
        '
        Me.TblQADocumentTypesBindingSource.DataMember = "tblQADocumentTypes"
        Me.TblQADocumentTypesBindingSource.DataSource = Me.leonidaDBDataSet
        '
        'docReview
        '
        Me.docReview.DataPropertyName = "docReview"
        Me.docReview.HeaderText = "docReview"
        Me.docReview.Name = "docReview"
        '
        'docFile
        '
        Me.docFile.DataPropertyName = "docFile"
        Me.docFile.HeaderText = "docFile"
        Me.docFile.Name = "docFile"
        '
        'docFileLocation
        '
        Me.docFileLocation.HeaderText = "docFileLocation"
        Me.docFileLocation.Image = Global.leonida.My.Resources.Resources.save
        Me.docFileLocation.Name = "docFileLocation"
        '
        'docFileOpen
        '
        Me.docFileOpen.HeaderText = "docFileOpen"
        Me.docFileOpen.Image = Global.leonida.My.Resources.Resources.update
        Me.docFileOpen.Name = "docFileOpen"
        '
        'OpenFileDialog1
        '
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.Image = Global.leonida.My.Resources.Resources.list
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(1063, 138)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(177, 60)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Έντυπη Μορφή"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TblQADocumentsTableAdapter
        '
        Me.TblQADocumentsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblAgreementTableAdapter = Nothing
        Me.TableAdapterManager.tblAgreementTypeTableAdapter = Nothing
        Me.TableAdapterManager.tblCustomerTableAdapter = Nothing
        Me.TableAdapterManager.tblDepartmentsTableAdapter = Nothing
        Me.TableAdapterManager.tblInspectionScedulesTableAdapter = Nothing
        Me.TableAdapterManager.tblInspectionsReportTableAdapter = Nothing
        Me.TableAdapterManager.tblInspectionsTableAdapter = Nothing
        Me.TableAdapterManager.tblLoginTableAdapter = Nothing
        Me.TableAdapterManager.tblMonthsTableAdapter = Nothing
        Me.TableAdapterManager.tblNonConformances_TableAdapter = Nothing
        Me.TableAdapterManager.tblNonConformanceTypes_TableAdapter = Nothing
        Me.TableAdapterManager.tblProjectPhasesTableAdapter = Nothing
        Me.TableAdapterManager.tblProjectTableAdapter = Nothing
        Me.TableAdapterManager.tblQACustomerSatisfactionCriteriaTableAdapter = Nothing
        Me.TableAdapterManager.tblQACustomerSatisfactionMarksTableAdapter = Nothing
        Me.TableAdapterManager.tblQACustomerSatisfactionSurveyDetailsTableAdapter = Nothing
        Me.TableAdapterManager.tblQACustomerSatisfactionSurveysTableAdapter = Nothing
        Me.TableAdapterManager.tblQADocumentsTableAdapter = Me.TblQADocumentsTableAdapter
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
        'VcDurationsTableAdapter
        '
        Me.VcDurationsTableAdapter.ClearBeforeFill = True
        '
        'VcResponibilitiesTableAdapter
        '
        Me.VcResponibilitiesTableAdapter.ClearBeforeFill = True
        '
        'TblQADocumentTypesTableAdapter
        '
        Me.TblQADocumentTypesTableAdapter.ClearBeforeFill = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(359, 203)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(162, 20)
        Me.TextBox1.TabIndex = 7
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.leonida.My.Resources.Resources.search
        Me.PictureBox4.Location = New System.Drawing.Point(316, 196)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(37, 32)
        Me.PictureBox4.TabIndex = 8
        Me.PictureBox4.TabStop = False
        '
        'frmDocuments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1252, 730)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TblQADocumentsDataGridView)
        Me.Controls.Add(Me.TblQADocumentsBindingNavigator)
        Me.Name = "frmDocuments"
        Me.Controls.SetChildIndex(Me.TblQADocumentsBindingNavigator, 0)
        Me.Controls.SetChildIndex(Me.TblQADocumentsDataGridView, 0)
        Me.Controls.SetChildIndex(Me.Button4, 0)
        Me.Controls.SetChildIndex(Me.TextBox1, 0)
        Me.Controls.SetChildIndex(Me.PictureBox4, 0)
        CType(Me.TblQADocumentsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblQADocumentsBindingNavigator.ResumeLayout(False)
        Me.TblQADocumentsBindingNavigator.PerformLayout()
        CType(Me.TblQADocumentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leonidaDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblQADocumentsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VcDurationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VcResponibilitiesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblQADocumentTypesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents leonidaDBDataSet As leonida.leonidaDBDataSet
    Friend WithEvents TblQADocumentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblQADocumentsTableAdapter As leonida.leonidaDBDataSetTableAdapters.tblQADocumentsTableAdapter
    Friend WithEvents TableAdapterManager As leonida.leonidaDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblQADocumentsBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents TblQADocumentsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TblQADocumentsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents VcDurationsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VcDurationsTableAdapter As leonida.leonidaDBDataSetTableAdapters.vcDurationsTableAdapter
    Friend WithEvents VcResponibilitiesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VcResponibilitiesTableAdapter As leonida.leonidaDBDataSetTableAdapters.vcResponibilitiesTableAdapter
    Friend WithEvents TblQADocumentTypesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblQADocumentTypesTableAdapter As leonida.leonidaDBDataSetTableAdapters.tblQADocumentTypesTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents docID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents docInternal As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents docTitle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents docCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents docPublication As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents docDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents docDuration As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents docResponsible As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents docType As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents docReview As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents docFile As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents docFileLocation As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents docFileOpen As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox

End Class
