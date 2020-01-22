Public Class frmTextbox

    Public _dgv As DataGridView
    Public _colName As String
    Public _row As Integer
    Public _content As String = Nothing

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub frmTextbox_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.TextBox1.Text = _content
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        _dgv.Rows(_row).Cells(_colName).Value = Me.TextBox1.Text

        Me.Close()
    End Sub
End Class