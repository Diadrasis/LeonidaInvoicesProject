Public Class frmLogin
    Private Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Me.TextBox1.Text <> "" And Me.TextBox2.Text <> "" Then
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

            myCommand.CommandText = "Select loginPassword from tblLogin where loginUsername=" & "'" & Me.TextBox1.Text & "'"
            myCommand.Connection = myConnection

            Try
                myCommand.ExecuteScalar()

                If myCommand.ExecuteScalar() = Me.TextBox2.Text Then
                    Dim oform As New frmMenu
                    oform.Show()
                    Me.Close()
                Else
                    MsgBox("Λάθος όνομα - κωδικός χρήστη")
                    Me.TextBox1.Text = ""
                    Me.TextBox2.Text = ""
                End If
            Catch ex As Exception
            Finally
                myConnection.Close()
            End Try
        Else
            MsgBox("Καταχωρήστε όνομα και κωδικό χρήστη για την εισαγωγή στην εφαρμογή")
        End If
    End Sub
End Class
