Module modCommonSubs
    Public userId As Integer = 1


    Public windowWidth As Integer = frmTemplate.Width
    Public borderWidth As Integer = 16         'The overall width of left and right border
    Public lrMargin As Integer = 9             'The margin from left and right borders of the window
    Public topMargin As Integer = 230          'The margin from top of the window

    Sub MarkDropDownColumns(ByVal dgv As DataGridView, ByVal name As String)
        dgv.Columns(name).DefaultCellStyle.BackColor = Color.GhostWhite
    End Sub

    Sub InactivateNavigator(ByVal nav As BindingNavigator)
        nav.AddNewItem.Visible = False
        nav.DeleteItem.Visible = False
        nav.Enabled = True
    End Sub

    Sub InactivateDataGrid(ByVal dgv As DataGridView)
        dgv.AllowUserToAddRows = False
        dgv.AllowUserToDeleteRows = False
    End Sub

    Sub DesignDataGridView(ByVal dg As DataGridView)
        dg.Location = New Point(lrMargin, topMargin)
        dg.Size = New Size(windowWidth - borderWidth - 2 * lrMargin, 437)       '2*margin = margin left and right
        dg.Font = New Font("Microsoft Sans Serif", 8.75)
        dg.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Top
        dg.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    ''' <summary>
    ''' Σχεδιάζει τον bindingNavigator
    ''' </summary>
    ''' <param name="dgn">bindingNavigator</param>
    ''' <remarks></remarks>
    Sub DesignDataGridNavigator(ByVal dgn As Windows.Forms.BindingNavigator)
        Dim marginDgv As Integer = 2            '2 = margin from dgv in pixels

        dgn.Location = New Point(lrMargin, topMargin - dgn.Height - marginDgv)
        dgn.Dock = DockStyle.None
    End Sub

    ''' <summary>
    ''' Παίρνει το index της column δίνοντας το όνομα του στοιχείου στη βάση
    ''' </summary>
    ''' <param name="dgv">Το datagridview</param>
    ''' <param name="name">Το όνομα της στήλης</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function getColIndex(ByVal dgv As DataGridView, ByVal name As String) As Integer

        For Each col As DataGridViewColumn In dgv.Columns
            If col.DataPropertyName = name Then
                Return col.Index
            End If
        Next

        'if column is not databounded, return -1
        Return -1

    End Function

    ''' <summary>
    ''' Δέχεται σχεδόν όλες τις παραμέτρους που χρησιμοποιούμε, ώστε να φτιάξει την column
    ''' </summary>
    ''' <param name="dgv">Το datagridview</param>
    ''' <param name="colName">Όνομα στήλης</param>
    ''' <param name="header">Επικεφαλίδα</param>
    ''' <param name="width">Πλάτος</param>    
    ''' <param name="backColor">Background χρώμα</param>
    ''' <remarks></remarks>
    Sub DesignColumn(ByVal dgv As DataGridView, ByVal colName As String, ByVal header As String, ByVal width As Integer, ByVal backColor As Color)
        Dim colId As Integer = getColIndex(dgv, colName)

        If colId <> -1 Then                                     'If column is databounded
            dgv.Columns(colId).HeaderText = header
            dgv.Columns(colId).Width = width
            dgv.Columns(colId).DefaultCellStyle.BackColor = backColor
            dgv.Columns(colId).Visible = True
        Else                                                    'If column isn't databounded
            dgv.Columns(colName).HeaderText = header
            dgv.Columns(colName).Width = width
            dgv.Columns(colName).DefaultCellStyle.BackColor = backColor
            dgv.Columns(colName).Visible = True
        End If
    End Sub

    ''' <summary>
    ''' Παίρνει τα απολύτως απαραίτητα, για να δημιουργήσει μία column
    ''' </summary>
    ''' <param name="dgv">το datagridview</param>
    ''' <param name="colName">Το όνομα της στήλης</param>
    ''' <param name="header">Η επικεφαλίδα</param>
    ''' <param name="width">Το πλάτος της στήλης</param>
    ''' <remarks></remarks>
    Sub DesignColumn(ByVal dgv As DataGridView, ByVal colName As String, ByVal header As String, ByVal width As Integer)
        Dim colId As Integer = getColIndex(dgv, colName)

        If colId <> -1 Then
            dgv.Columns(colId).HeaderText = header
            dgv.Columns(colId).Width = width
            dgv.Columns(colId).Visible = True
        Else
            dgv.Columns(colName).HeaderText = header
            dgv.Columns(colName).Width = width
            dgv.Columns(colName).Visible = True
        End If
    End Sub    


    ''' <summary>
    ''' Απλά κάνει μια column, not visible
    ''' </summary>
    ''' <param name="dgv">το datagridview</param>
    ''' <param name="colName">Όνομα Στήλης</param>
    ''' <param name="visible">visible ή όχι</param>
    ''' <remarks></remarks>
    Sub DesignColumn(ByVal dgv As DataGridView, ByVal colName As String, ByVal visible As Boolean)
        Dim colId As Integer = getColIndex(dgv, colName)

        If colId <> -1 Then
            dgv.Columns(colId).Visible = False
        Else
            dgv.Columns(colName).Visible = False
        End If
    End Sub

    ''' <summary>
    ''' Εμφανίζει το textbox για γρήγορο entry δεδομένων
    ''' </summary>
    ''' <param name="dgv">Datagridview</param>
    ''' <param name="colName">Όνομα Στήλης</param>
    ''' <param name="row">Σειρά</param>
    ''' <remarks></remarks>
    Sub showMultiTextbox(ByVal dialog As String, ByVal dgv As DataGridView, ByVal colName As String, ByVal row As Integer)
        Dim oform As New frmTextbox
        oform._dgv = dgv
        oform._colName = colName
        oform._row = row

        If dgv.Rows(row).Cells(getColIndex(dgv, colName)).Value IsNot System.DBNull.Value Then
            oform._content = dgv.Rows(row).Cells(getColIndex(dgv, colName)).Value
        End If

        oform.Text = dialog
        oform.Show()
    End Sub

End Module