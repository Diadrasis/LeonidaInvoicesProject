<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class resttext
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(resttext))
        Me.leonidaDBDataSet = New leonida.leonidaDBDataSet()
        Me.TblInvoiceResponsiblesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblInvoiceResponsiblesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TblInvoiceResponsiblesDataGridView = New System.Windows.Forms.DataGridView()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.TblInvoiceResponsiblesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        CType(Me.leonidaDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblInvoiceResponsiblesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblInvoiceResponsiblesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblInvoiceResponsiblesBindingNavigator.SuspendLayout()
        CType(Me.TblInvoiceResponsiblesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'leonidaDBDataSet
        '
        Me.leonidaDBDataSet.DataSetName = "leonidaDBDataSet"
        Me.leonidaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblInvoiceResponsiblesBindingSource
        '
        Me.TblInvoiceResponsiblesBindingSource.DataSource = Me.leonidaDBDataSet
        Me.TblInvoiceResponsiblesBindingSource.Position = 0
        '
        'TblInvoiceResponsiblesBindingNavigator
        '
        Me.TblInvoiceResponsiblesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblInvoiceResponsiblesBindingNavigator.BindingSource = Me.TblInvoiceResponsiblesBindingSource
        Me.TblInvoiceResponsiblesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblInvoiceResponsiblesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblInvoiceResponsiblesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblInvoiceResponsiblesBindingNavigatorSaveItem})
        Me.TblInvoiceResponsiblesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblInvoiceResponsiblesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblInvoiceResponsiblesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblInvoiceResponsiblesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblInvoiceResponsiblesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblInvoiceResponsiblesBindingNavigator.Name = "TblInvoiceResponsiblesBindingNavigator"
        Me.TblInvoiceResponsiblesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblInvoiceResponsiblesBindingNavigator.Size = New System.Drawing.Size(492, 25)
        Me.TblInvoiceResponsiblesBindingNavigator.TabIndex = 0
        Me.TblInvoiceResponsiblesBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorPositionItem.Text = "1"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TblInvoiceResponsiblesDataGridView
        '
        Me.TblInvoiceResponsiblesDataGridView.AutoGenerateColumns = False
        Me.TblInvoiceResponsiblesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblInvoiceResponsiblesDataGridView.DataSource = Me.TblInvoiceResponsiblesBindingSource
        Me.TblInvoiceResponsiblesDataGridView.Location = New System.Drawing.Point(27, 64)
        Me.TblInvoiceResponsiblesDataGridView.Name = "TblInvoiceResponsiblesDataGridView"
        Me.TblInvoiceResponsiblesDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.TblInvoiceResponsiblesDataGridView.TabIndex = 1
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
        'TblInvoiceResponsiblesBindingNavigatorSaveItem
        '
        Me.TblInvoiceResponsiblesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblInvoiceResponsiblesBindingNavigatorSaveItem.Enabled = False
        Me.TblInvoiceResponsiblesBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblInvoiceResponsiblesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblInvoiceResponsiblesBindingNavigatorSaveItem.Name = "TblInvoiceResponsiblesBindingNavigatorSaveItem"
        Me.TblInvoiceResponsiblesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TblInvoiceResponsiblesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'resttext
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 345)
        Me.Controls.Add(Me.TblInvoiceResponsiblesDataGridView)
        Me.Controls.Add(Me.TblInvoiceResponsiblesBindingNavigator)
        Me.Name = "resttext"
        Me.Text = "resttext"
        CType(Me.leonidaDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblInvoiceResponsiblesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblInvoiceResponsiblesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblInvoiceResponsiblesBindingNavigator.ResumeLayout(False)
        Me.TblInvoiceResponsiblesBindingNavigator.PerformLayout()
        CType(Me.TblInvoiceResponsiblesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents leonidaDBDataSet As leonidaDBDataSet
    Friend WithEvents TblInvoiceResponsiblesBindingSource As BindingSource
    Friend WithEvents TblInvoiceResponsiblesBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents TblInvoiceResponsiblesBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents TblInvoiceResponsiblesDataGridView As DataGridView
End Class
