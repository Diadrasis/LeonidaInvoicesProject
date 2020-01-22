Public Class frmChooseTheme
    Dim tId As Integer = getThemeId(userId)

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If MessageBox.Show("Είστε σίγουροι ότι θέλετε να αλλάξετε θέμα; Η εφαρμογή θα χρειαστεί να επανεκκινήσει και όλες οι μη αποθηκευμένες αλλαγές θα χαθούν.", "Αλλαγή Θέματος", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            setColor(tId)
            restartApplication()
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        tId = 0
        colorForm(Me, tId)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        tId = 1
        colorForm(Me, tId)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        tId = 2
        colorForm(Me, tId)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        tId = 3
        colorForm(Me, tId)
    End Sub

    Private Sub frmChooseTheme_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim i As Integer = frmColorThemes.Keys.Count * 2
        Dim j As Integer = frmColorThemes.Keys.Count - 1
        For Each lb As Control In Me.Controls
            If TypeOf lb Is Label Then
                If i Mod 2 <> 0 Then
                    lb.BackColor = frmColorThemes.Item(j)
                    lb.ForeColor = frmColorThemes.Item(j)
                    j -= 1
                Else
                    lb.BackColor = btnColorThemes.Item(j)
                    lb.ForeColor = btnColorThemes.Item(j)                                       
                End If
                i -= 1
            End If           
        Next
        ' The above piece of code doing this
        'Me.Label1.BackColor = frmColorThemes.Item(0)
        'Me.Label2.BackColor = btnColorThemes.Item(0)

        'Me.Label3.BackColor = frmColorThemes.Item(1)
        'Me.Label4.BackColor = btnColorThemes.Item(1)

        'Me.Label1.ForeColor = frmColorThemes.Item(0)
        'Me.Label2.ForeColor = btnColorThemes.Item(0)

        'Me.Label3.ForeColor = frmColorThemes.Item(1)
        'Me.Label4.ForeColor = btnColorThemes.Item(1)
        '                   ...
        '                   ...
        '                   ...
        '                   ...
        '                   ...

        Me.Text = "Επιλογή Θέματος"

    End Sub

End Class
