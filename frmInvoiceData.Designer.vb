<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvoiceData
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lbCode = New System.Windows.Forms.Label()
        Me.lbRow = New System.Windows.Forms.Label()
        Me.lbType = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbCustDOY = New System.Windows.Forms.Label()
        Me.lbCustAFM = New System.Windows.Forms.Label()
        Me.lbCustTelephone = New System.Windows.Forms.Label()
        Me.lbCustCityZIP = New System.Windows.Forms.Label()
        Me.lbCustAddress = New System.Windows.Forms.Label()
        Me.lbCustService = New System.Windows.Forms.Label()
        Me.lbCustCompany = New System.Windows.Forms.Label()
        Me.lbCustCode = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TblInvoiceItemsDataGridView = New System.Windows.Forms.DataGridView()
        Me.invoiceItemId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.invoiceItemAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.invoiceItemDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.invoiceUnit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.invoiceItemValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.invoiceItemFPA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FPAValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OverallValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.invoiceId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.invoiceItemComments = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblInvoiceItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.leonidaDBDataSet = New leonida.leonidaDBDataSet()
        Me.TblFPABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblFPATableAdapter = New leonida.leonidaDBDataSetTableAdapters.tblFPATableAdapter()
        Me.txtComments = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtPayment = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TblInvoiceItemsTableAdapter = New leonida.leonidaDBDataSetTableAdapters.tblInvoiceItemsTableAdapter()
        Me.TableAdapterManager = New leonida.leonidaDBDataSetTableAdapters.TableAdapterManager()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.TblInvoiceItemsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblInvoiceItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leonidaDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblFPABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.lbCode)
        Me.GroupBox1.Controls.Add(Me.lbRow)
        Me.GroupBox1.Controls.Add(Me.lbType)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(21, 134)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1219, 72)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Στοιχεία Παραστατικού"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(1066, 32)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(105, 22)
        Me.DateTimePicker1.TabIndex = 8
        '
        'lbCode
        '
        Me.lbCode.AutoSize = True
        Me.lbCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.lbCode.Location = New System.Drawing.Point(789, 32)
        Me.lbCode.Name = "lbCode"
        Me.lbCode.Size = New System.Drawing.Size(45, 15)
        Me.lbCode.TabIndex = 6
        Me.lbCode.Text = "Label7"
        '
        'lbRow
        '
        Me.lbRow.AutoSize = True
        Me.lbRow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.lbRow.Location = New System.Drawing.Point(506, 32)
        Me.lbRow.Name = "lbRow"
        Me.lbRow.Size = New System.Drawing.Size(45, 15)
        Me.lbRow.TabIndex = 5
        Me.lbRow.Text = "Label6"
        '
        'lbType
        '
        Me.lbType.AutoSize = True
        Me.lbType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.lbType.Location = New System.Drawing.Point(41, 32)
        Me.lbType.Name = "lbType"
        Me.lbType.Size = New System.Drawing.Size(45, 15)
        Me.lbType.TabIndex = 4
        Me.lbType.Text = "Label5"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label4.Location = New System.Drawing.Point(1099, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Ημερομηνία"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label3.Location = New System.Drawing.Point(784, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Αριθμός"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label2.Location = New System.Drawing.Point(506, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Σειρά"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Είδος"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbCustDOY)
        Me.GroupBox2.Controls.Add(Me.lbCustAFM)
        Me.GroupBox2.Controls.Add(Me.lbCustTelephone)
        Me.GroupBox2.Controls.Add(Me.lbCustCityZIP)
        Me.GroupBox2.Controls.Add(Me.lbCustAddress)
        Me.GroupBox2.Controls.Add(Me.lbCustService)
        Me.GroupBox2.Controls.Add(Me.lbCustCompany)
        Me.GroupBox2.Controls.Add(Me.lbCustCode)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(21, 212)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1219, 87)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Στοιχεία Αντισυμβαλλόμενου"
        '
        'lbCustDOY
        '
        Me.lbCustDOY.AutoSize = True
        Me.lbCustDOY.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.lbCustDOY.Location = New System.Drawing.Point(790, 66)
        Me.lbCustDOY.Name = "lbCustDOY"
        Me.lbCustDOY.Size = New System.Drawing.Size(10, 15)
        Me.lbCustDOY.TabIndex = 16
        Me.lbCustDOY.Text = ":"
        '
        'lbCustAFM
        '
        Me.lbCustAFM.AutoSize = True
        Me.lbCustAFM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.lbCustAFM.Location = New System.Drawing.Point(790, 49)
        Me.lbCustAFM.Name = "lbCustAFM"
        Me.lbCustAFM.Size = New System.Drawing.Size(10, 15)
        Me.lbCustAFM.TabIndex = 15
        Me.lbCustAFM.Text = ":"
        '
        'lbCustTelephone
        '
        Me.lbCustTelephone.AutoSize = True
        Me.lbCustTelephone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.lbCustTelephone.Location = New System.Drawing.Point(790, 32)
        Me.lbCustTelephone.Name = "lbCustTelephone"
        Me.lbCustTelephone.Size = New System.Drawing.Size(10, 15)
        Me.lbCustTelephone.TabIndex = 14
        Me.lbCustTelephone.Text = ":"
        '
        'lbCustCityZIP
        '
        Me.lbCustCityZIP.AutoSize = True
        Me.lbCustCityZIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.lbCustCityZIP.Location = New System.Drawing.Point(790, 15)
        Me.lbCustCityZIP.Name = "lbCustCityZIP"
        Me.lbCustCityZIP.Size = New System.Drawing.Size(10, 15)
        Me.lbCustCityZIP.TabIndex = 13
        Me.lbCustCityZIP.Text = ":"
        '
        'lbCustAddress
        '
        Me.lbCustAddress.AutoSize = True
        Me.lbCustAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.lbCustAddress.Location = New System.Drawing.Point(130, 66)
        Me.lbCustAddress.Name = "lbCustAddress"
        Me.lbCustAddress.Size = New System.Drawing.Size(10, 15)
        Me.lbCustAddress.TabIndex = 12
        Me.lbCustAddress.Text = ":"
        '
        'lbCustService
        '
        Me.lbCustService.AutoSize = True
        Me.lbCustService.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.lbCustService.Location = New System.Drawing.Point(130, 49)
        Me.lbCustService.Name = "lbCustService"
        Me.lbCustService.Size = New System.Drawing.Size(10, 15)
        Me.lbCustService.TabIndex = 11
        Me.lbCustService.Text = ":"
        '
        'lbCustCompany
        '
        Me.lbCustCompany.AutoSize = True
        Me.lbCustCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.lbCustCompany.Location = New System.Drawing.Point(130, 32)
        Me.lbCustCompany.Name = "lbCustCompany"
        Me.lbCustCompany.Size = New System.Drawing.Size(10, 15)
        Me.lbCustCompany.TabIndex = 10
        Me.lbCustCompany.Text = ":"
        '
        'lbCustCode
        '
        Me.lbCustCode.AutoSize = True
        Me.lbCustCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.lbCustCode.Location = New System.Drawing.Point(130, 15)
        Me.lbCustCode.Name = "lbCustCode"
        Me.lbCustCode.Size = New System.Drawing.Size(10, 15)
        Me.lbCustCode.TabIndex = 9
        Me.lbCustCode.Text = ":"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label12.Location = New System.Drawing.Point(692, 66)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 15)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Δ.Ο.Υ."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label11.Location = New System.Drawing.Point(692, 49)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 15)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Α.Φ.Μ."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label10.Location = New System.Drawing.Point(692, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 15)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Τηλέφωνο"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label9.Location = New System.Drawing.Point(692, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 15)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Πόλη / Τ.Κ."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label8.Location = New System.Drawing.Point(32, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 15)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Διεύθυνση"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label7.Location = New System.Drawing.Point(32, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 15)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Επάγγελμα"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label6.Location = New System.Drawing.Point(32, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 15)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Επωνυμία"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label5.Location = New System.Drawing.Point(32, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 15)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Κωδικός"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(610, 620)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(142, 44)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Έκδοση"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(386, 620)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(70, 44)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Ακύρωση"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.TblInvoiceItemsDataGridView)
        Me.GroupBox4.Location = New System.Drawing.Point(21, 302)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1219, 237)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Υπηρεσίες"
        '
        'TblInvoiceItemsDataGridView
        '
        Me.TblInvoiceItemsDataGridView.AutoGenerateColumns = False
        Me.TblInvoiceItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblInvoiceItemsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.invoiceItemId, Me.invoiceItemAmount, Me.invoiceItemDescription, Me.invoiceUnit, Me.invoiceItemValue, Me.invoiceItemFPA, Me.AmountValue, Me.FPAValue, Me.OverallValue, Me.invoiceId, Me.invoiceItemComments})
        Me.TblInvoiceItemsDataGridView.DataSource = Me.TblInvoiceItemsBindingSource
        Me.TblInvoiceItemsDataGridView.Location = New System.Drawing.Point(6, 19)
        Me.TblInvoiceItemsDataGridView.Name = "TblInvoiceItemsDataGridView"
        Me.TblInvoiceItemsDataGridView.Size = New System.Drawing.Size(1207, 212)
        Me.TblInvoiceItemsDataGridView.TabIndex = 0
        '
        'invoiceItemId
        '
        Me.invoiceItemId.DataPropertyName = "invoiceItemId"
        Me.invoiceItemId.HeaderText = "invoiceItemId"
        Me.invoiceItemId.Name = "invoiceItemId"
        Me.invoiceItemId.ReadOnly = True
        '
        'invoiceItemAmount
        '
        Me.invoiceItemAmount.DataPropertyName = "invoiceItemAmount"
        Me.invoiceItemAmount.HeaderText = "invoiceItemAmount"
        Me.invoiceItemAmount.Name = "invoiceItemAmount"
        '
        'invoiceItemDescription
        '
        Me.invoiceItemDescription.DataPropertyName = "invoiceItemDescription"
        Me.invoiceItemDescription.HeaderText = "invoiceItemDescription"
        Me.invoiceItemDescription.Name = "invoiceItemDescription"
        '
        'invoiceUnit
        '
        Me.invoiceUnit.DataPropertyName = "invoiceUnit"
        Me.invoiceUnit.HeaderText = "invoiceUnit"
        Me.invoiceUnit.Name = "invoiceUnit"
        '
        'invoiceItemValue
        '
        Me.invoiceItemValue.DataPropertyName = "invoiceItemValue"
        Me.invoiceItemValue.HeaderText = "invoiceItemValue"
        Me.invoiceItemValue.Name = "invoiceItemValue"
        '
        'invoiceItemFPA
        '
        Me.invoiceItemFPA.DataPropertyName = "invoiceItemFPA"
        Me.invoiceItemFPA.HeaderText = "invoiceItemFPA"
        Me.invoiceItemFPA.Name = "invoiceItemFPA"
        '
        'AmountValue
        '
        Me.AmountValue.HeaderText = "Αξία"
        Me.AmountValue.Name = "AmountValue"
        Me.AmountValue.ReadOnly = True
        '
        'FPAValue
        '
        Me.FPAValue.HeaderText = "Αξία με ΦΠΑ"
        Me.FPAValue.Name = "FPAValue"
        Me.FPAValue.ReadOnly = True
        '
        'OverallValue
        '
        Me.OverallValue.HeaderText = "Σύνολο"
        Me.OverallValue.Name = "OverallValue"
        Me.OverallValue.ReadOnly = True
        '
        'invoiceId
        '
        Me.invoiceId.DataPropertyName = "invoiceId"
        Me.invoiceId.HeaderText = "invoiceId"
        Me.invoiceId.Name = "invoiceId"
        '
        'invoiceItemComments
        '
        Me.invoiceItemComments.DataPropertyName = "invoiceItemComments"
        Me.invoiceItemComments.HeaderText = "invoiceItemComments"
        Me.invoiceItemComments.Name = "invoiceItemComments"
        '
        'TblInvoiceItemsBindingSource
        '
        Me.TblInvoiceItemsBindingSource.DataMember = "tblInvoiceItems"
        Me.TblInvoiceItemsBindingSource.DataSource = Me.leonidaDBDataSet
        '
        'leonidaDBDataSet
        '
        Me.leonidaDBDataSet.DataSetName = "leonidaDBDataSet"
        Me.leonidaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblFPABindingSource
        '
        Me.TblFPABindingSource.DataMember = "tblFPA"
        Me.TblFPABindingSource.DataSource = Me.leonidaDBDataSet
        '
        'TblFPATableAdapter
        '
        Me.TblFPATableAdapter.ClearBeforeFill = True
        '
        'txtComments
        '
        Me.txtComments.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtComments.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txtComments.Location = New System.Drawing.Point(27, 560)
        Me.txtComments.Multiline = True
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(269, 44)
        Me.txtComments.TabIndex = 13
        '
        'Label22
        '
        Me.Label22.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label22.Location = New System.Drawing.Point(24, 544)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(85, 15)
        Me.Label22.TabIndex = 12
        Me.Label22.Text = "Παρατηρήσεις"
        '
        'txtPayment
        '
        Me.txtPayment.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txtPayment.Location = New System.Drawing.Point(302, 560)
        Me.txtPayment.Multiline = True
        Me.txtPayment.Name = "txtPayment"
        Me.txtPayment.Size = New System.Drawing.Size(266, 44)
        Me.txtPayment.TabIndex = 15
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label13.Location = New System.Drawing.Point(299, 542)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(109, 15)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Τρόπος Πληρωμής"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(462, 620)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(142, 44)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Προσωρινή Αποθήκευση"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TblInvoiceItemsTableAdapter
        '
        Me.TblInvoiceItemsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblAgreementTableAdapter = Nothing
        Me.TableAdapterManager.tblAgreementTypeTableAdapter = Nothing
        Me.TableAdapterManager.tblCustomerTableAdapter = Nothing
        Me.TableAdapterManager.tblDepartmentsTableAdapter = Nothing
        Me.TableAdapterManager.tblEducationTableAdapter = Nothing
        Me.TableAdapterManager.tblFPATableAdapter = Me.TblFPATableAdapter
        Me.TableAdapterManager.tblInspectionScedulesTableAdapter = Nothing
        Me.TableAdapterManager.tblInspectionsReportTableAdapter = Nothing
        Me.TableAdapterManager.tblInspectionsTableAdapter = Nothing
        Me.TableAdapterManager.tblInvoiceItemsTableAdapter = Me.TblInvoiceItemsTableAdapter
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
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(574, 587)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox1.TabIndex = 17
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(758, 620)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(142, 44)
        Me.Button4.TabIndex = 18
        Me.Button4.Text = "Έκδοση Μαρία Λεωνίδα"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'frmInvoiceData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1252, 725)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txtPayment)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtComments)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmInvoiceData"
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.Button1, 0)
        Me.Controls.SetChildIndex(Me.Button2, 0)
        Me.Controls.SetChildIndex(Me.GroupBox4, 0)
        Me.Controls.SetChildIndex(Me.Label22, 0)
        Me.Controls.SetChildIndex(Me.txtComments, 0)
        Me.Controls.SetChildIndex(Me.Label13, 0)
        Me.Controls.SetChildIndex(Me.txtPayment, 0)
        Me.Controls.SetChildIndex(Me.Button3, 0)
        Me.Controls.SetChildIndex(Me.CheckBox1, 0)
        Me.Controls.SetChildIndex(Me.Button4, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.TblInvoiceItemsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblInvoiceItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leonidaDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblFPABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbCode As System.Windows.Forms.Label
    Friend WithEvents lbRow As System.Windows.Forms.Label
    Friend WithEvents lbType As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lbCustDOY As System.Windows.Forms.Label
    Friend WithEvents lbCustAFM As System.Windows.Forms.Label
    Friend WithEvents lbCustTelephone As System.Windows.Forms.Label
    Friend WithEvents lbCustCityZIP As System.Windows.Forms.Label
    Friend WithEvents lbCustAddress As System.Windows.Forms.Label
    Friend WithEvents lbCustService As System.Windows.Forms.Label
    Friend WithEvents lbCustCompany As System.Windows.Forms.Label
    Friend WithEvents lbCustCode As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents leonidaDBDataSet As leonida.leonidaDBDataSet
    Friend WithEvents TblFPABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblFPATableAdapter As leonida.leonidaDBDataSetTableAdapters.tblFPATableAdapter
    Friend WithEvents txtComments As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtPayment As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TblInvoiceItemsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblInvoiceItemsTableAdapter As leonida.leonidaDBDataSetTableAdapters.tblInvoiceItemsTableAdapter
    Friend WithEvents TableAdapterManager As leonida.leonidaDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblInvoiceItemsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents invoiceItemId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents invoiceItemAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents invoiceItemDescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents invoiceUnit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents invoiceItemValue As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents invoiceItemFPA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AmountValue As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FPAValue As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OverallValue As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents invoiceId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents invoiceItemComments As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Button4 As Button
End Class
