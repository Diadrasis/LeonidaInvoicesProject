Public Class frmChooseProject

    Public pEmpID As Integer      

    Private Sub frmChooseProject_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'leonidaDBDataSet.tblProject' table. You can move, or remove it, as needed.
        Me.TblProjectTableAdapter.Fill(Me.leonidaDBDataSet.tblProject)

        Me.Text = "Επιλέξτε Έργο"

        Me.RadioButton2.Checked = True
        Me.ComboBox1.Enabled = False
    End Sub

    Function getProjectStaffCategory(ByVal pId As Integer) As String
        Dim myConnection As New System.Data.SqlClient.SqlConnection
        myConnection.ConnectionString = My.Settings.leonidaDBConnectionString
        Dim myCommand As New System.Data.SqlClient.SqlCommand

        myCommand.Connection = myConnection
        myCommand.CommandType = CommandType.Text

        myCommand.CommandText = "SELECT projectStaffCategory FROM tblProjectStaff WHERE projectId = " & pId & " AND staffId = " & Me.pEmpID

        Dim category As String = ""
        Try
            myConnection.Open()

            If myCommand.ExecuteScalar() IsNot System.DBNull.Value Then
                category = myCommand.ExecuteScalar()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            myConnection.Close()
        End Try


        Return category

    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If Me.RadioButton1.Checked = False Then
            Me.ComboBox1.Enabled = False
        Else
            Me.ComboBox1.Enabled = True
        End If
    End Sub
End Class