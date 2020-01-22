Public Class frmInvoiceData
    Public invId As Integer

    Private invoiceCode, invoiceDescription, invoiceComments As String
    Private invoiceDate As DateTime

    Dim dgv As DataGridView
    Dim fpaValues As New List(Of String)

    Private Sub frmInvoiceData_Load1(sender As Object, e As System.EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'leonidaDBDataSet.tblInvoiceItems' table. You can move, or remove it, as needed.
        Me.TblInvoiceItemsTableAdapter.FillByInvoiceId(Me.leonidaDBDataSet.tblInvoiceItems, invId)
        'TODO: This line of code loads data into the 'leonidaDBDataSet.tblFPA' table. You can move, or remove it, as needed.
        Me.TblFPATableAdapter.Fill(Me.leonidaDBDataSet.tblFPA)

        dgv = TblInvoiceItemsDataGridView

        'hide Leonida button
        Me.Button4.Visible = False

        Dim myConnection As New System.Data.SqlClient.SqlConnection
        Dim myCommand As New System.Data.SqlClient.SqlCommand
        myConnection.ConnectionString = My.Settings.leonidaDBConnectionString

        Try
            myConnection.Open()
        Catch ex As Exception
            MessageBox.Show("Η σύνδεση με τη βάση δεδομένων δεν είναι δυνατή...")
            MessageBox.Show("Execute error: " & ex.Message)
            Me.Close()
        End Try


        myCommand.CommandText = "SELECT * FROM rptInvoice WHERE invoiceId = " & invId.ToString()
        myCommand.Connection = myConnection

        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = myCommand.ExecuteReader()
            While reader.Read()
                lbType.Text = reader("invoiceTypeDescription")
                lbRow.Text = ""
                lbCode.Text = reader("invoiceCode")
                'lbDate.Text = reader("invoiceDate")

                lbCustCode.Text = lbCustCode.Text & " " & reader("customerId").ToString()
                lbCustCompany.Text = lbCustCompany.Text & " " & reader("customerCompany")
                lbCustService.Text = lbCustService.Text & " " & reader("customerProfession")
                lbCustAddress.Text = lbCustAddress.Text & " " & reader("customerAddress")
                lbCustCityZIP.Text = lbCustCityZIP.Text & " " & reader("customerCity") & " " & reader("customerZIP")
                lbCustTelephone.Text = lbCustTelephone.Text & " " & reader("customerTelephone1") & "  " & reader("customerTelephone2")
                lbCustAFM.Text = lbCustAFM.Text & " " & reader("customerAFM")
                lbCustDOY.Text = lbCustDOY.Text & " " & reader("customerDOY")

                If reader("invoiceComments") IsNot System.DBNull.Value Then
                    txtComments.Text = reader("invoiceComments")
                End If

                If reader("invoicePayment") IsNot System.DBNull.Value Then
                    txtPayment.Text = reader("invoicePayment")
                End If
            End While
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

        DesignColumn(dgv, "invoiceItemId", False)
        DesignColumn(dgv, "invoiceId", False)
        DesignColumn(dgv, "invoiceItemComments", False)
        DesignColumn(dgv, "invoiceItemAmount", "Ποσότητα", 70)
        DesignColumn(dgv, "invoiceUnit", "ΜΜ", 70)
        DesignColumn(dgv, "invoiceItemDescription", "Υπηρεσία", 400)
        DesignColumn(dgv, "invoiceItemValue", "Αξία Μονάδας", 70)
        DesignColumn(dgv, "invoiceItemFPA", "ΦΠΑ", 70)
        DesignColumn(dgv, "AmountValue", "Αξία", 70, Color.LightGray)
        DesignColumn(dgv, "FPAValue", "Αξία με ΦΠΑ", 70, Color.LightGray)
        DesignColumn(dgv, "OverallValue", "Σύνολο", 70, Color.LightGray)

        getFPAValues()

        For Each row As DataGridViewRow In dgv.Rows
            If areValid(row) Then
                If row.Index <> dgv.Rows.Count - 1 Then
                    row.Cells("AmountValue").Value = (Convert.ToDouble(row.Cells("invoiceItemAmount").Value) * Convert.ToDouble(row.Cells("invoiceItemValue").Value)).ToString()
                    row.Cells("FPAValue").Value = (Convert.ToDouble(row.Cells("invoiceItemFPA").Value) * Convert.ToDouble(row.Cells("AmountValue").Value)).ToString()
                    row.Cells("OverallValue").Value = (Convert.ToDouble(row.Cells("AmountValue").Value) + Convert.ToDouble(row.Cells("FPAValue").Value)).ToString()
                End If
            End If
        Next

        Me.CheckBox1.Checked = False

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        saveItems()
        If UpdateInvoice(True) Then 'Invoice Completed      

            Dim oform As New rptInvoice
            oform.invId = Me.invId

            Try
                oform.Show()
                Close()
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        saveItems()
        UpdateInvoice(False) 'Invoice Saved    
    End Sub

    Private Sub saveItems()
        Validate()
        TblInvoiceItemsBindingSource.EndEdit()
        TblInvoiceItemsTableAdapter.Update(Me.leonidaDBDataSet)
    End Sub

    Private Sub InsertInvoiceItem(ByVal amount As Integer, ByVal desc As String, ByVal fpa As Double, ByVal itemVal As Double)
        Dim myConnection As New System.Data.SqlClient.SqlConnection
        myConnection.ConnectionString = My.Settings.leonidaDBConnectionString
        Dim myCommand As New System.Data.SqlClient.SqlCommand
        myCommand.Connection = myConnection

        myCommand.CommandType = CommandType.StoredProcedure
        myCommand.CommandText = "pInsertInvoiceItem"

        myCommand.Parameters.Add("@amount", SqlDbType.Float)
        myCommand.Parameters("@amount").Value = amount

        myCommand.Parameters.Add("@desc", SqlDbType.NVarChar)
        myCommand.Parameters("@desc").Value = desc

        myCommand.Parameters.Add("@fpa", SqlDbType.Float)
        myCommand.Parameters("@fpa").Value = fpa

        myCommand.Parameters.Add("@itemValue", SqlDbType.Float)
        myCommand.Parameters("@itemValue").Value = itemVal

        myCommand.Parameters.Add("@invId", SqlDbType.Int)
        myCommand.Parameters("@invId").Value = invId

        Try
            myConnection.Open()
            myCommand.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Η δημιουργία συναλλαγής ακυρώθηκε λόγω σφάλματος...")
            MessageBox.Show("Σφάλμα: " & ex.Message)
            myConnection.Close()
            Exit Sub
        End Try
    End Sub

    Private Function UpdateInvoice(ByVal completed As Boolean) As Boolean

        ' Is the user sure???...
        If completed Then
            If MessageBox.Show("Πρόκειται να εκδόσετε παραστατικό με ημερομηνία '" & _
                               DateTimePicker1.Value.ToShortDateString & "' στον αντισυμβαλλόμενο " & _
                               lbCustCompany.Text & ". Θέλετε να συνεχίσετε;", "Are you sure bro?...", _
                               MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Cancel Then
                Return False
            End If
        End If

        Dim myConnection As New System.Data.SqlClient.SqlConnection
        myConnection.ConnectionString = My.Settings.leonidaDBConnectionString

        Dim myCommand As New System.Data.SqlClient.SqlCommand
        myCommand.Connection = myConnection

        myCommand.CommandType = CommandType.StoredProcedure
        myCommand.CommandText = "pUpdateInvoice"

        myCommand.Parameters.Add("@invId", SqlDbType.Int)
        myCommand.Parameters("@invId").Value = invId

        myCommand.Parameters.Add("@invComments", SqlDbType.NVarChar)
        myCommand.Parameters("@invComments").Value = txtComments.Text

        myCommand.Parameters.Add("@invPayment", SqlDbType.NVarChar)
        myCommand.Parameters("@invPayment").Value = txtPayment.Text

        myCommand.Parameters.Add("@invDate", SqlDbType.DateTime)
        myCommand.Parameters("@invDate").Value = DateTimePicker1.Value

        myCommand.Parameters.Add("@invIssued", SqlDbType.Bit)
        myCommand.Parameters("@invIssued").Value = True

        myCommand.Parameters.Add("@invCompleted", SqlDbType.Bit)
        myCommand.Parameters("@invCompleted").Value = completed

        Try
            myConnection.Open()
            myCommand.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MessageBox.Show("Η δημιουργία συναλλαγής ακυρώθηκε λόγω σφάλματος...")
            MessageBox.Show("Σφάλμα: " & ex.Message)
            myConnection.Close()
            Return False
        End Try

    End Function

    Private Function areValid(ByVal r As DataGridViewRow) As Boolean
        If r.Cells("invoiceItemAmount").Value IsNot System.DBNull.Value And r.Cells("invoiceItemFPA").Value IsNot System.DBNull.Value And r.Cells("invoiceItemValue").Value IsNot System.DBNull.Value Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub computeCells(ByVal row As DataGridViewRow)
        If areValid(row) Then
            row.Cells("AmountValue").Value = (Convert.ToDouble(row.Cells("invoiceItemAmount").Value) * Convert.ToDouble(row.Cells("invoiceItemValue").Value)).ToString()
            row.Cells("FPAValue").Value = (Convert.ToDouble(row.Cells("invoiceItemFPA").Value) * Convert.ToDouble(row.Cells("AmountValue").Value)).ToString()
            row.Cells("OverallValue").Value = (Convert.ToDouble(row.Cells("AmountValue").Value) + Convert.ToDouble(row.Cells("FPAValue").Value)).ToString()
        End If
    End Sub

    Private Sub getFPAValues()
        Dim myConnection As New System.Data.SqlClient.SqlConnection
        Dim myCommand As New System.Data.SqlClient.SqlCommand

        myConnection.ConnectionString = My.Settings.leonidaDBConnectionString

        Try
            myConnection.Open()
        Catch ex As Exception
            MessageBox.Show("Η σύνδεση με τη βάση δεδομένων δεν είναι δυνατή...")
            MessageBox.Show("Execute error: " & ex.Message)
            Me.Close()
        End Try


        myCommand.CommandText = "SELECT * FROM tblFPA"
        myCommand.Connection = myConnection

        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = myCommand.ExecuteReader()

            While reader.Read()
                fpaValues.Add(reader("FPAValue").ToString())
            End While

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub TblInvoiceItemsDataGridView_CellValidated(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblInvoiceItemsDataGridView.CellValidated
        If e.RowIndex > -1 Then
            Dim row As DataGridViewRow = dgv.Rows(e.RowIndex)

            If e.ColumnIndex = row.Cells("invoiceItemFPA").ColumnIndex Then
                If row.Cells("invoiceItemFPA").Value Is System.DBNull.Value Then
                    If Me.CheckBox1.Checked = False Then
                        row.Cells("invoiceItemFPA").Value = fpaValues.First().ToString()
                    Else
                        row.Cells("invoiceItemFPA").Value = "0"
                    End If

                Else
                    If Not fpaValues.Contains(row.Cells("invoiceItemFPA").Value) Then
                        Dim msg As String = "Μη επιτρεπτή τιμή ΦΠΑ. Επιτρεπτές τιμές είναι οι < "
                        For Each s As String In fpaValues
                            msg = msg + s + "-"
                        Next
                        msg = Mid(msg, 1, msg.Length - 1) + " >"

                        MessageBox.Show(msg)
                    End If
                End If
            End If

            computeCells(row)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        saveItems()
        If UpdateInvoice(True) Then 'Invoice Completed      

            Dim oform As New rptInvoice
            oform.invId = Me.invId

            Try
                oform.Show()
                Close()
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If
    End Sub

    Private Sub TblInvoiceItemsDataGridView_RowValidated(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblInvoiceItemsDataGridView.RowValidated
        If e.RowIndex > -1 And e.RowIndex <> dgv.Rows.Count - 1 Then
            dgv.Rows(e.RowIndex).Cells("invoiceId").Value = invId.ToString()
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        Dim lastDate As DateTime
        Dim lastCode As String = ""

        Dim myConnection As New System.Data.SqlClient.SqlConnection
        Dim myCommand As New System.Data.SqlClient.SqlCommand

        myConnection.ConnectionString = My.Settings.leonidaDBConnectionString

        Try
            myConnection.Open()
        Catch ex As Exception
            MessageBox.Show("Η σύνδεση με τη βάση δεδομένων δεν είναι δυνατή...")
            MessageBox.Show("Execute error: " & ex.Message)
            Me.Close()
        End Try

        myCommand.CommandText = "SELECT TOP 1 invoiceCode, invoiceDate, invoiceDescription FROM tblInvoices " & _
        "WHERE invoiceCompleted <> 0 And invoiceIssued <> 0 ORDER BY invoiceDate DESC"

        myCommand.Connection = myConnection

        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = myCommand.ExecuteReader()

            While reader.Read()
                lastCode = reader("invoiceCode").ToString()
                lastDate = Convert.ToDateTime(reader("invoiceDate").ToString())
            End While

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

        ' Cast it to date because we don't want to compare times too.

        If Date.Compare(Date.Parse(DateTimePicker1.Value).ToShortDateString, Date.Parse(lastDate).ToShortDateString) < 0 Then
            MessageBox.Show("Προσπαθείτε να εκδόσετε παραστατικό με ημερομηνία προγενέστερη της επιτρεπτής. " & _
        "Το τελευταίο παραστατικό με κωδικό '" & lastCode & "' εκδόθηκε στις '" & _
            Date.Parse(lastDate).ToShortDateString & "'", "Be careful bro....", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'DateTimePicker1.Value = Date.Today
        End If


    End Sub
End Class