Public Class frmDocuments

    Dim dgv As DataGridView
    Dim dbn As BindingNavigator
    Dim currentrow As Integer

    Public pInternal As Boolean

    Private Sub TblQADocumentsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblQADocumentsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblQADocumentsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.leonidaDBDataSet)

    End Sub

    Private Sub frmDocuments_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'leonidaDBDataSet.tblQADocumentTypes' table. You can move, or remove it, as needed.
        Me.TblQADocumentTypesTableAdapter.Fill(Me.leonidaDBDataSet.tblQADocumentTypes)
        'TODO: This line of code loads data into the 'leonidaDBDataSet.vcResponibilities' table. You can move, or remove it, as needed.
        Me.VcResponibilitiesTableAdapter.Fill(Me.leonidaDBDataSet.vcResponibilities)
        'TODO: This line of code loads data into the 'leonidaDBDataSet.vcDurations' table. You can move, or remove it, as needed.
        Me.VcDurationsTableAdapter.Fill(Me.leonidaDBDataSet.vcDurations)
        'TODO: This line of code loads data into the 'leonidaDBDataSet.tblQADocuments' table. You can move, or remove it, as needed.
        Me.TblQADocumentsTableAdapter.Fill(Me.leonidaDBDataSet.tblQADocuments, pInternal)

        dgv = Me.TblQADocumentsDataGridView
        dbn = Me.TblQADocumentsBindingNavigator

        DesignDataGridView(dgv)
        DesignDataGridNavigator(dbn)

        Me.Text = "Έγγραφα Συστήματος Ποιότητας σε Ισχύ"

        DesignColumn(dgv, "docId", False)
        DesignColumn(dgv, "docInternal", False)
        DesignColumn(dgv, "docTitle", "Περιγραφή", 270)
        DesignColumn(dgv, "docCode", "Κωδικός", 80)
        'dgv.Columns(1).HeaderText = "Περιγραφή"
        DesignColumn(dgv, "docPublication", "Έκδοση", 80)
        DesignColumn(dgv, "docDate", "Ημερομηνία Έγκρισης", 80)
        DesignColumn(dgv, "docDuration", "Χρόνος Διατήρησης", 150, Color.LightYellow)
        DesignColumn(dgv, "docResponsible", "Υπεύθυνος Αρχειοθέτησης", 210, Color.LightYellow)
        DesignColumn(dgv, "docType", "Μορφή Αρχείου", 170, Color.LightYellow)
        DesignColumn(dgv, "docReview", "Προγραμματισμένη Ανασκόπιση", 115)
        DesignColumn(dgv, "docFile", "Θέση Αρχείου", 100)
        DesignColumn(dgv, "docFileLocation", "", 40)
        DesignColumn(dgv, "docFileOpen", "", 40)
        DesignColumn(dgv, "docFileOpen", "", 40)

    End Sub

    Private Sub TblQADocumentsDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblQADocumentsDataGridView.CellContentClick
        If e.RowIndex > -1 Then
            currentrow = e.RowIndex
            If e.ColumnIndex = Me.TblQADocumentsDataGridView.Columns("docFileLocation").Index Then
                dgv.Rows(e.RowIndex).Selected = True
                Me.OpenFileDialog1.ShowDialog()
            ElseIf e.ColumnIndex = Me.TblQADocumentsDataGridView.Columns("docFileOpen").Index Then
                Dim ViewerAPPLocation As String = Nothing
                Try
                    Process.Start(dgv.Rows(currentrow).Cells("docFile").Value)
                Catch
                    MessageBox.Show("There was an error loading your file", "File Error")
                End Try
            End If
        End If
    End Sub

    Private Sub TblQADocumentsDataGridView_RowValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblQADocumentsDataGridView.RowValidated
        If dgv.Rows(e.RowIndex).Cells("docInternal").Value Is System.DBNull.Value Then
            dgv.Rows(e.RowIndex).Cells("docType").Value = Me.pInternal
        End If
    End Sub



    Private Sub OpenFileDialog1_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles OpenFileDialog1.Disposed
        Me.OpenFileDialog1.FileName = Me.dgv.Rows(currentrow).Cells("docFile").Value
    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Me.dgv.Rows(currentrow).Cells("docFile").Value = Me.OpenFileDialog1.FileName
    End Sub

   
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        'search
        If Me.TextBox1.Text <> "" Then
            Me.TblQADocumentsBindingSource.Filter = "docTitle LIKE '%" & Me.TextBox1.Text & "%'"
        Else
            TblQADocumentsBindingSource.RemoveFilter()
        End If
    End Sub
End Class
