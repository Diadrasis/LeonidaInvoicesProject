Public Class rptInvoice
    Public invId As Integer
    Public isCopy As Boolean = False

    Private Sub rptInvoice_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'leonidaDBDataSet.rptInvoice' table. You can move, or remove it, as needed.
        'Me.rptInvoiceTableAdapter.Fill(Me.leonidaDBDataSet.rptInvoice)
        'TODO: This line of code loads data into the 'leonidaDBDataSet.tblInvoiceItems' table. You can move, or remove it, as needed.
        Me.tblInvoiceItemsTableAdapter.FillByInvoiceId(Me.leonidaDBDataSet.tblInvoiceItems, invId)
        'TODO: This line of code loads data into the 'leonidaDBDataSet.rptInvoice' table. You can move, or remove it, as needed.
        Me.rptInvoiceTableAdapter.FillByInvoiceId(Me.leonidaDBDataSet.rptInvoice, invId)

        Dim parInvoiceType As New Microsoft.Reporting.WinForms.ReportParameter()

        parInvoiceType.Name = "pInvoiceType"
        If isCopy Then
            parInvoiceType.Values.Add("Αντίγραφο")
        Else
            parInvoiceType.Values.Add("Πελάτης")
        End If

        Dim parameters() As Microsoft.Reporting.WinForms.ReportParameter = {parInvoiceType}
        'ReportViewer1.LocalReport.SetParameters(parameters)
        ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport
    End Sub

    Private Sub ReportViewer1_PrintingBegin(sender As Object, e As Microsoft.Reporting.WinForms.ReportPrintEventArgs) 
        If Not isCopy Then
            If MessageBox.Show("Θέλετε να εκτυπώσετε αντίγραφα για 'Στέλεχος' και 'Λογιστήριο' ;", "Αντίγραφο Παραστατικού", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                Using manPrint As ManualPrinting = New ManualPrinting()
                    manPrint.Run(e.PrinterSettings.PrinterName, invId, "Λογιστήριο")
                End Using

                Using manPrint As ManualPrinting = New ManualPrinting()
                    manPrint.Run(e.PrinterSettings.PrinterName, invId, "Στέλεχος")
                End Using
            End If
        End If
    End Sub
End Class