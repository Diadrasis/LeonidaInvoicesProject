Public Class frmProject

    Dim dgv As DataGridView
    Dim dbn As BindingNavigator
    Dim currentrow As Integer

    Private Sub TblProjectBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblProjectBindingNavigatorSaveItem.Click
        SaveChanges()
    End Sub

    Private Sub frmProject_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DiadrasisProjectsDBDataSet.vwCustomerDiadrasis' table. You can move, or remove it, as needed.
        Me.VwCustomerDiadrasisTableAdapter.Fill(Me.DiadrasisProjectsDBDataSet.vwCustomerDiadrasis)
        'TODO: This line of code loads data into the 'DiadrasisProjectsDBDataSet.tblProjectType' table. You can move, or remove it, as needed.
        Me.TblProjectTypeTableAdapter.Fill(Me.DiadrasisProjectsDBDataSet.tblProjectType)
        'TODO: This line of code loads data into the 'DiadrasisProjectsDBDataSet.vwCustomer' table. You can move, or remove it, as needed.
        Me.VwCustomerTableAdapter.Fill(Me.DiadrasisProjectsDBDataSet.vwCustomer)
        'TODO: This line of code loads data into the 'DiadrasisProjectsDBDataSet.tblProject' table. You can move, or remove it, as needed.
        Me.TblProjectTableAdapter.FillByType(Me.DiadrasisProjectsDBDataSet.tblProject, 1)


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

        DesignColumn(dgv, "projectDescription", "Περιγραφή", 200)

        DesignColumn(dgv, "projectDateStart", "Ημερομηνία Έναρξης", 120)
        dgv.Columns("projectDateStart").ReadOnly = True
        DesignColumn(dgv, "projectDateEnd", "Ημερομηνία Λήξης", 120)

        DesignColumn(dgv, "projectComments", "Παρατηρήσεις", 150)
        DesignColumn(dgv, "projectBudget", "Προϋπολογισμός", 150)
        DesignColumn(dgv, "staff", "Προσωπικό", 80)
        DesignColumn(dgv, "projectHumanMonths", "A/M", 50)
        DesignColumn(dgv, "projectTypeId", False)

        'hide column for Leonida
        dgv.Columns("colLeonida").Visible = False

        Me.ComboBox1.Location = New Point(dbn.Location.X + 300, dbn.Location.Y)

        Me.MonthCalendar1.Visible = False

    End Sub

    Private Sub TblProjectDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblProjectDataGridView.CellContentClick
        If e.RowIndex > -1 Then
            If dgv.Rows(e.RowIndex).Cells("tasks").ColumnIndex = e.ColumnIndex Then
                SaveChanges()

                Dim oform As New frmTask
                oform.pId = dgv.Rows(e.RowIndex).Cells("projectId").Value
                oform.Show()
            ElseIf dgv.Rows(e.RowIndex).Cells("invoice").ColumnIndex = e.ColumnIndex Then
                SaveChanges()

                Dim newId As Integer = InsertInvoice(1, dgv.Rows(e.RowIndex).Cells("projectId").Value, "",
                                                     dgv.Rows(e.RowIndex).Cells("projectName").Value)
                Dim oform As New frmInvoiceData
                oform.invId = newId
                oform.Show()
            ElseIf dgv.Rows(e.RowIndex).Cells("ProductInvoice").ColumnIndex = e.ColumnIndex Then
                SaveChanges()
                Dim newId As Integer = InsertInvoice(2, dgv.Rows(e.RowIndex).Cells("projectId").Value, "",
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
            ElseIf dgv.Rows(e.RowIndex).Cells("ProformaInvoice").ColumnIndex = e.ColumnIndex Then
                SaveChanges()
                Dim newId As Integer = InsertInvoice(4, dgv.Rows(e.RowIndex).Cells("projectId").Value, "",
                                                     dgv.Rows(e.RowIndex).Cells("projectName").Value)
                Dim oform As New frmInvoiceData
                oform.invId = newId
                oform.Show()
            ElseIf dgv.Rows(e.RowIndex).Cells("Receipt").ColumnIndex = e.ColumnIndex Then
                SaveChanges()
                Dim newId As Integer = InsertInvoice(6, dgv.Rows(e.RowIndex).Cells("projectId").Value, "",
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
            ElseIf dgv.Rows(e.RowIndex).Cells("colLeonida").ColumnIndex = e.ColumnIndex Then
                SaveChanges()
                Dim newId As Integer = InsertInvoice(8, dgv.Rows(e.RowIndex).Cells("projectId").Value, "",
                                                     dgv.Rows(e.RowIndex).Cells("projectName").Value)
                Dim oform As New frmInvoiceData
                oform.invId = newId
                oform.Show()
            End If
        End If
    End Sub

    Private Sub TblProjectDataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblProjectDataGridView.CellClick
        If e.RowIndex > -1 Then
            If dgv.Rows(e.RowIndex).Cells("projectDateStart").ColumnIndex = e.ColumnIndex Then
                currentrow = e.RowIndex
                If Me.MonthCalendar1.Visible = False Then
                    Me.MonthCalendar1.Visible = True
                    Me.MonthCalendar1.Location = New Point(MousePosition.X - Me.Location.X, MousePosition.Y - Me.Location.Y)

                    If dgv.Rows(e.RowIndex).Cells("projectDateStart").Value IsNot System.DBNull.Value Then
                        Me.MonthCalendar1.SetDate(CDate(dgv.Rows(e.RowIndex).Cells("projectDateStart").Value))
                    Else
                        Me.MonthCalendar1.SetDate(Date.Now)
                    End If
                Else
                    Me.MonthCalendar1.Visible = False
                End If
                'Me.MonthCalendar1.SetDate(CDate(dgv.Rows(e.RowIndex).Cells("columnDate").Value))
            ElseIf dgv.Rows(e.RowIndex).Cells("staff").ColumnIndex = e.ColumnIndex Then
                Dim oform As New frmProjectStaff
                oform.pId = dgv.Rows(e.RowIndex).Cells("projectId").Value
                oform.Show()
            End If
        End If
    End Sub

    Private Sub MonthCalendar1_DateSelected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        dgv.Rows(currentrow).Cells("projectDateStart").Value = Me.MonthCalendar1.SelectionRange.Start
        Me.MonthCalendar1.Visible = False
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Me.TblProjectTableAdapter.FillByType(Me.DiadrasisProjectsDBDataSet.tblProject, Me.ComboBox1.SelectedValue)
    End Sub

    Private Sub TblProjectDataGridView_RowValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblProjectDataGridView.RowValidated
        If e.RowIndex > -1 Then
            dgv.Rows(e.RowIndex).Cells("projectTypeId").Value = Me.ComboBox1.SelectedValue
        End If
    End Sub

    Private Sub SaveChanges()
        Me.Validate()
        Me.TblProjectBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DiadrasisProjectsDBDataSet)
    End Sub

    Private Function InsertInvoice(ByVal tId As Integer, ByVal pId As Integer, ByVal comments As String, ByVal desc As String) As Integer
        Dim myConnection As New System.Data.SqlClient.SqlConnection
        myConnection.ConnectionString = My.Settings.diadrasisProjectsDBConnectionString

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
