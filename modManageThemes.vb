Module modManageThemes
    Public btnColorThemes As New Dictionary(Of Integer, Color)
    Public frmColorThemes As New Dictionary(Of Integer, Color)

    ''' <summary>
    ''' Εδώ δημιουργούμε τα θέματα που θέλουμε, βάζοντας δικά μας χρώματα
    ''' </summary>
    ''' <remarks></remarks>
    Sub initThemes()
        ' Theme #1
        btnColorThemes.Add(0, System.Drawing.SystemColors.Control)
        frmColorThemes.Add(0, System.Drawing.SystemColors.Control)
        ' Theme #2
        btnColorThemes.Add(1, Color.Beige)
        frmColorThemes.Add(1, System.Drawing.SystemColors.ActiveCaption)
        ' Theme #3
        btnColorThemes.Add(2, Color.IndianRed)
        frmColorThemes.Add(2, Color.AntiqueWhite)
        ' Theme #4
        btnColorThemes.Add(3, Color.Green)
        frmColorThemes.Add(3, System.Drawing.SystemColors.ControlText)
    End Sub

    ''' <summary>
    ''' Αυτή η συνάρτηση καλείται για να χρωματίσει τήν εκάστοτε φόρμα
    ''' </summary>
    ''' <param name="frm">Το αντικείμενο της φόρμας</param>
    ''' <param name="tId">Το Id του θέματος που θα φορτωθεί</param>
    ''' <remarks></remarks>
    Sub colorForm(ByVal frm As Form, ByVal tId As Integer)

        frm.BackColor = frmColorThemes.Item(tId)
        For Each btn As Control In frm.Controls
            If TypeOf btn Is Button Then                
                btn.BackColor = btnColorThemes.Item(tId)
                If tId = 0 Then
                    CType(btn, Button).UseVisualStyleBackColor = True
                End If
            End If
        Next

    End Sub

    ''' <summary>
    ''' Αποθηκεύει στη βάση την προτίμηση του χρήστη για το θέμα
    ''' </summary>
    ''' <param name="tId">Το Id του θέματος που θα κάνει update</param>
    ''' <remarks></remarks>
    Sub setColor(ByVal tId)
        'Dim myConnection As New System.Data.SqlClient.SqlConnection
        'myConnection.ConnectionString = My.Settings.leonidaDBConnectionString
        'Dim myCommand As New System.Data.SqlClient.SqlCommand

        'myCommand.Connection = myConnection
        'myCommand.CommandType = CommandType.Text

        'myCommand.CommandText = "UPDATE tblLogin SET themeId = " & tId & " WHERE loginId = " & userId

        'Try
        'myConnection.Open()

        'myCommand.ExecuteScalar()
        'Catch ex As Exception
        'MsgBox(ex.ToString)
        'Finally
        'myConnection.Close()
        'End Try

    End Sub

    ''' <summary>
    ''' Αντλεί από τη βάση το Id του θέματος που χρησιμοποιεί ο εκάστοτε χρήστης
    ''' </summary>
    ''' <param name="uId">Το userId</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function getThemeId(ByVal uId As Integer) As Integer
        'Dim myConnection As New System.Data.SqlClient.SqlConnection
        'myConnection.ConnectionString = My.Settings.leonidaDBConnectionString
        'Dim myCommand As New System.Data.SqlClient.SqlCommand

        'myCommand.Connection = myConnection
        'myCommand.CommandType = CommandType.Text

        'myCommand.CommandText = "SELECT themeId FROM tblLogin WHERE loginId = " & userId

        'Dim tId As String = ""
        'Try
        'myConnection.Open()

        'tId = myCommand.ExecuteScalar()
        'Catch ex As Exception
        'MsgBox(ex.ToString)
        'Finally
        'myConnection.Close()
        'End Try

        'Return tId
    End Function

    ''' <summary>
    ''' Κλείνει την εφαρμογή, αφού επιβεβαιωθεί η αλλαγή θέματος
    ''' </summary>
    ''' <remarks></remarks>
    Sub restartApplication()        
        'Application.Restart()
    End Sub

End Module
