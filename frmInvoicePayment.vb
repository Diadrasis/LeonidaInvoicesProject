Public Class frmInvoicePayment
    Public invId As Integer
    Public invForm As frmInvoices
    Private Sub TblInvoicesByIDPaymentBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblInvoicesByIDPaymentBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblInvoicesByIDPaymentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.leonidaDBDataSet)
        invForm.RefreshDataGrid()

    End Sub

    Private Sub frmInvoicePayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'leonidaDBDataSet.tblInvoicePaymentTypes' table. You can move, or remove it, as needed.
        Me.TblInvoicePaymentTypesTableAdapter.Fill(Me.leonidaDBDataSet.tblInvoicePaymentTypes)
        'TODO: This line of code loads data into the 'leonidaDBDataSet.tblInvoiceResponsibles' table. You can move, or remove it, as needed.
        Me.TblInvoiceResponsiblesTableAdapter.Fill(Me.leonidaDBDataSet.tblInvoiceResponsibles)
        'TODO: This line of code loads data into the 'leonidaDBDataSet.tblInvoices' table. You can move, or remove it, as needed.
        'Me.TblInvoicesTableAdapter.Fill(Me.leonidaDBDataSet.tblInvoices)

        'TODO: This line of code loads data into the 'leonidaDBDataSet.tblProject' table. You can move, or remove it, as needed.
        Me.TblProjectTableAdapter.Fill(Me.leonidaDBDataSet.tblProject)
        'TODO: This line of code loads data into the 'leonidaDBDataSet.tblInvoiceTypes' table. You can move, or remove it, as needed.
        Me.TblInvoiceTypesTableAdapter.Fill(Me.leonidaDBDataSet.tblInvoiceTypes)
        Try
            Me.TblInvoicesByIDPaymentTableAdapter.Fill(Me.leonidaDBDataSet.tblInvoicesByIDPayment, invId)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        If InvoicePaidCheckBox.Checked = False Then
            Me.PayDateDateTimePicker.Enabled = False
            Me.PayDateDateTimePicker.CustomFormat = " "
            Me.PayDateDateTimePicker.Format = DateTimePickerFormat.Custom

        End If

    End Sub

    Private Sub InvoicePaidCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles InvoicePaidCheckBox.CheckedChanged
        If Me.InvoicePaidCheckBox.Checked = False Then
            Me.PayDateDateTimePicker.Enabled = False
            Me.PayDateDateTimePicker.CustomFormat = " "
            Me.PayDateDateTimePicker.Format = DateTimePickerFormat.Custom
            Me.PayDateDateTimePicker.ResetText()
        Else
            Me.PayDateDateTimePicker.Enabled = True
            Me.PayDateDateTimePicker.Format = DateTimePickerFormat.Long
        End If
    End Sub

    Private Sub PayDateDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles PayDateDateTimePicker.ValueChanged

    End Sub

    Private Sub InvresIDLabel_Click(sender As Object, e As EventArgs)

    End Sub
End Class