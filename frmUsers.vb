Public Class frmUsers

    Dim dgv As DataGridView
    Dim dbn As BindingNavigator

    Private Sub TblLoginBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblLoginBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblLoginBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.leonidaDBDataSet)

    End Sub

    Private Sub frmUsers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'leonidaDBDataSet.tblLogin' table. You can move, or remove it, as needed.
        Me.TblLoginTableAdapter.Fill(Me.leonidaDBDataSet.tblLogin)

        Me.Text = "Χρήστες"

        dgv = Me.TblLoginDataGridView
        dbn = Me.TblLoginBindingNavigator

        DesignDataGridView(dgv)
        DesignDataGridNavigator(dbn)

        DesignColumn(dgv, "loginId", False)
        DesignColumn(dgv, "loginUsername", "Όνομα Χρήστη", 150)
        DesignColumn(dgv, "loginPassword", "Κωδικός", 150)
        DesignColumn(dgv, "loginName", "Όνομα", 200)
        DesignColumn(dgv, "loginSurname", "Επώνυμο", 200)
        DesignColumn(dgv, "themeId", False)

    End Sub

End Class
