Public Class frmProject

    Dim dgv As DataGridView
    Dim dbn As BindingNavigator
    Dim currentrow As Integer

    Private Sub TblProjectBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblProjectBindingNavigatorSaveItem.Click
        SaveChanges()
    End Sub

    Private Sub frmProject_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'leonidaDBDataSet.vwCustomerDiadrasis' table. You can move, or remove it, as needed.
        Me.VwCustomerDiadrasisTableAdapter.Fill(Me.leonidaDBDataSet.vwCustomerDiadrasis)
        'TODO: This line of code loads data into the 'leonidaDBDataSet.tblProjectType' table. You can move, or remove it, as needed.
        Me.TblProjectTypeTableAdapter.Fill(Me.leonidaDBDataSet.tblProjectType)
        'TODO: This line of code loads data into the 'leonidaDBDataSet.vwCustomer' table. You can move, or remove it, as needed.
        Me.VwCustomerTableAdapter.Fill(Me.leonidaDBDataSet.vwCustomer)
        'TODO: This line of code loads data into the 'leonidaDBDataSet.tblProject' table. You can move, or remove it, as needed.
        Me.TblProjectTableAdapter.FillByType(Me.leonidaDBDataSet.tblProject, 1)


        dgv = Me.TblProjectDataGridView
        dbn = Me.TblProjectBindingNavigator

        DesignDataGridView(dgv)
        DesignDataGridNavigator(dbn)




        Me.Text = "Έργα"

        DesignColumn(dgv, "projectId", False)
        DesignColumn(dgv, "projectName", "Ονομασία", 400, Color.LightCyan)
        DesignColumn(dgv, "customerId", "Πελάτης", 250, Color.LightYellow)
        dgv.Columns(getColIndex(dgv, "projectName")).Frozen = True
        dgv.Columns(getColIndex(dgv, "customerId")).Frozen = True

        dgv.Columns(getColIndex(dgv, "projectTypeId")).Visible = False

        DesignColumn(dgv, "projectComments", "Παρατηρήσεις", 150)



        'hide column for Leonida


        Me.ComboBox1.Location = New Point(dbn.Location.X + 300, dbn.Location.Y)



    End Sub

    Private Sub TblProjectDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblProjectDataGridView.CellContentClick
        If e.RowIndex > -1 Then


            If dgv.Rows(e.RowIndex).Cells("invoice").ColumnIndex = e.ColumnIndex Then
                SaveChanges()

                Dim newId As Integer = InsertInvoice(1, dgv.Rows(e.RowIndex).Cells("projectId").Value, "",
                                                     dgv.Rows(e.RowIndex).Cells("projectName").Value)
                Dim oform As New frmInvoiceData
                oform.invId = newId
                oform.Show()
            ElseIf dgv.Rows(e.RowIndex).Cells("CreditInvoice").ColumnIndex = e.ColumnIndex Then
                SaveChanges()
                Dim newId As Integer = InsertInvoice(5, dgv.Rows(e.RowIndex).Cells("projectId").Value, "",
                                                     dgv.Rows(e.RowIndex).Cells("projectName").Value)
                Dim oform As New frmInvoiceData
                oform.invId = newId
                oform.Show()
            ElseIf dgv.Rows(e.RowIndex).Cells("RetailReceipt").ColumnIndex = e.ColumnIndex Then
                SaveChanges()
                Dim newId As Integer = InsertInvoice(7, dgv.Rows(e.RowIndex).Cells("projectId").Value, "",
                                                     dgv.Rows(e.RowIndex).Cells("projectName").Value)
                Dim oform As New frmInvoiceData
                oform.invId = newId
                oform.Show()
            End If
        End If
    End Sub

    Private Sub TblProjectDataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblProjectDataGridView.CellClick
        If e.RowIndex > -1 Then

        End If
    End Sub

    Private Sub MonthCalendar1_DateSelected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Me.TblProjectTableAdapter.FillByType(Me.leonidaDBDataSet.tblProject, Me.ComboBox1.SelectedValue)
    End Sub

    Private Sub TblProjectDataGridView_RowValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblProjectDataGridView.RowValidated
        If e.RowIndex > -1 Then
            If IsDBNull(dgv.Rows(e.RowIndex).Cells("projectTypeId").Value) Then
                dgv.Rows(e.RowIndex).Cells("projectTypeId").Value = 1
            End If
        End If
    End Sub

    Private Sub SaveChanges()
        Me.Validate()
        Me.TblProjectBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.leonidaDBDataSet)
    End Sub

    Private Function InsertInvoice(ByVal tId As Integer, ByVal pId As Integer, ByVal comments As String, ByVal desc As String) As Integer
        Dim myConnection As New System.Data.SqlClient.SqlConnection
        myConnection.ConnectionString = My.Settings.leonidaDBConnectionString

        Dim myCommand As New System.Data.SqlClient.SqlCommand
        myCommand.Connection = myConnection

        myCommand.CommandType = CommandType.StoredProcedure
        myCommand.CommandText = "pInsertInvoice"

        myCommand.Parameters.Add("@typeId", SqlDbType.Int)
        myCommand.Parameters("@typeId").Value = tId

        myCommand.Parameters.Add("@projectId", SqlDbType.Int)
        myCommand.Parameters("@projectId").Value = pId

        myCommand.Parameters.Add("@invoiceComments", SqlDbType.NVarChar)
        myCommand.Parameters("@invoiceComments").Value = comments

        myCommand.Parameters.Add("@invDescription", SqlDbType.NVarChar)
        myCommand.Parameters("@invDescription").Value = desc

        myCommand.Parameters.Add("@RETURN", SqlDbType.Int)
        myCommand.Parameters("@RETURN").Direction = ParameterDirection.Output

        myConnection.Open()

        Try
            myCommand.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Η δημιουργία συναλλαγής ακυρώθηκε λόγω σφάλματος...")
            MessageBox.Show("Σφάλμα: " & ex.Message)
            myConnection.Close()
            Exit Function
        End Try

        Return myCommand.Parameters("@RETURN").Value
    End Function
End Class
