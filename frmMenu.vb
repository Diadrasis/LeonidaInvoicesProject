Public Class frmMenu

    Private Sub frmMenu_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text = "Κεντρικό Μενού"
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Dim oform As New frmMenuProduction
        oform.Show()
    End Sub
End Class
