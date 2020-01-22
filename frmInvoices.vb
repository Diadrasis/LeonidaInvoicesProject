Public Class frmInvoices
    Dim dgv As DataGridView
    Dim dbn As BindingNavigator
    Dim searchExpression1 As String
    Dim searchExpression2 As String
    Dim searchExpression3 As String

    Private Sub frmInvoicesvb_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'leonidaDBDataSet.vwCustomerDiadrasis' table. You can move, or remove it, as needed.
        Me.VwCustomerDiadrasisTableAdapter.Fill(Me.leonidaDBDataSet.vwCustomerDiadrasis)
        'TODO: This line of code loads data into the 'leonidaDBDataSet.rptInvoice' table. You can move, or remove it, as needed.
        Me.RptInvoiceTableAdapter.Fill(Me.leonidaDBDataSet.rptInvoice)

        dgv = Me.RptInvoiceDataGridView
        dbn = Me.RptInvoiceBindingNavigator

        DesignDataGridView(dgv)
        DesignDataGridNavigator(dbn)

        Me.Text = "Παραστατικά  και άλλα "

        DesignColumn(dgv, "invoiceId", False)
        DesignColumn(dgv, "invoiceCode", "Κωδικός", 65, Color.LightCyan)
        DesignColumn(dgv, "invoiceDate", "Ημερομηνία", 80, Color.LightCyan)
        dgv.Columns("invoiceDate").DefaultCellStyle.Format = "dd/MM/yyyy"
        dgv.Width = 1500

        DesignColumn(dgv, "invoiceTypeDescription", "Είδος", 150)
        DesignColumn(dgv, "customerCompany", "Αντισυμβαλλόμενος", 200)
        DesignColumn(dgv, "invoiceDescription", "Περιγραφή", 300)
        DesignColumn(dgv, "invoiceComments", "Παρατηρήσεις", 100)
        DesignColumn(dgv, "invoice", "Εκτύπωση", 70)

        DesignColumn(dgv, "invoicePaid", "Εξοφ.", 50)
        DesignColumn(dgv, "payDate", "Ημ. Εξοφ.", 90)
        DesignColumn(dgv, "payComments", "Σχόλια Πληρωμής", 100)
        DesignColumn(dgv, "payment", "Πληρωμή", 70)

        dgv.Columns(getColIndex(dgv, "payDate")).ReadOnly = True
        dgv.Columns(getColIndex(dgv, "invoicePaid")).ReadOnly = True
        dgv.Columns(getColIndex(dgv, "payDate")).ReadOnly = True
        dgv.Columns(getColIndex(dgv, "payComments")).ReadOnly = True

        dgv.Columns(getColIndex(dgv, "customerId")).Visible = False
        dgv.Columns(getColIndex(dgv, "invoiceComments")).Visible = False

        searchExpression2 = ""
        searchExpression3 = ""
        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedValue = 182
    End Sub

    Private Sub RptInvoiceDataGridView_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles RptInvoiceDataGridView.CellContentClick
        If e.RowIndex > -1 Then
            If dgv.Rows(e.RowIndex).Cells("invoice").ColumnIndex = e.ColumnIndex Then
                If ComboBox1.SelectedIndex = 0 Then
                    Dim oform As New rptInvoice
                    oform.invId = Convert.ToInt32(dgv.Rows(e.RowIndex).Cells("invoiceId").Value)
                    oform.isCopy = True
                    oform.Show()
                Else
                    Dim oform As New frmInvoiceData
                    oform.invId = dgv.Rows(e.RowIndex).Cells("invoiceId").Value
                    oform.Show()
                End If
            ElseIf dgv.Rows(e.RowIndex).Cells("Payment").ColumnIndex = e.ColumnIndex Then
                Dim paymentform As New frmInvoicePayment
                paymentform.invId = Convert.ToInt32(dgv.Rows(e.RowIndex).Cells("invoiceId").Value)
                paymentform.invForm = Me
                paymentform.Show()
            ElseIf dgv.Rows(e.RowIndex).Cells("Clone").ColumnIndex = e.ColumnIndex Then
                CloneInvoice(Convert.ToInt32(dgv.Rows(e.RowIndex).Cells("invoiceId").Value))
                RefreshDataGrid()
                ComboBox1.SelectedIndex = 1
            End If
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            dgv.Columns("invoice").HeaderText = "Εκτύπωση Αντιγράφου"
            searchExpression1 = "invoiceCompleted = 1 AND invoiceIssued = 1"

        Else
            dgv.Columns("invoice").HeaderText = "Επεξεργασία Παραστατικού"
            searchExpression1 = "invoiceCompleted = 0 AND invoiceIssued = 1"
        End If
        FilterData()
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        RefreshDataGrid()
    End Sub

    Public Sub RefreshDataGrid()
        dgv.Refresh()
        Me.RptInvoiceTableAdapter.Fill(Me.leonidaDBDataSet.rptInvoice)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If Me.TextBox1.Text = "" Then
            searchExpression2 = ""
            RptInvoiceBindingSource.RemoveFilter()
        Else
            searchExpression2 = "(invoiceCode Like '%" + Me.TextBox1.Text + "%' or customerCompany Like '%" + Me.TextBox1.Text + "%')"
        End If
        FilterData()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If Me.ComboBox2.SelectedValue = 182 Or ComboBox2.SelectedValue = Nothing Then
            searchExpression3 = ""
        Else
            searchExpression3 = "customerID =" + CStr(Me.ComboBox2.SelectedValue)
        End If
        FilterData()
    End Sub

    Private Sub CloneInvoice(ByVal invID As Integer)
        Dim myConnection As New System.Data.SqlClient.SqlConnection
        myConnection.ConnectionString = My.Settings.leonidaDBConnectionString

        Dim myCommand As New System.Data.SqlClient.SqlCommand
        myCommand.Connection = myConnection

        myCommand.CommandType = CommandType.StoredProcedure
        myCommand.CommandText = "pDuplicateInvoice"

        myCommand.Parameters.Add("@invId", SqlDbType.Int)
        myCommand.Parameters("@invId").Value = invID

        myConnection.Open()

        Try
            myCommand.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Η δημιουργία αντιγράφου ακυρώθηκε λόγω σφάλματος...")
            MessageBox.Show("Σφάλμα: " & ex.Message)
            myConnection.Close()
            Exit Sub
        End Try
        myConnection.Close()
        MessageBox.Show("Ο κλώνος δημιουργήσθηκε..")

    End Sub

    Private Sub FilterData()
        Dim searchExpression As String

        searchExpression = searchExpression1

        If searchExpression2 <> "" Then
            searchExpression = searchExpression + " And " + searchExpression2

        End If

        If searchExpression3 <> "" Then
            searchExpression = searchExpression + " And " + searchExpression3
        End If
        RptInvoiceBindingSource.Filter = searchExpression
    End Sub
End Class
