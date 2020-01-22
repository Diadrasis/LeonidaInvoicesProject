Imports System.IO
Imports System.Data
Imports System.Text
Imports System.Drawing.Imaging
Imports System.Drawing.Printing
Imports System.Collections.Generic
Imports Microsoft.Reporting.WinForms

Public Class ManualPrinting
    Implements IDisposable

    Private m_currentPageIndex As Integer
    Private m_streams As IList(Of Stream)

    Private Function LoadSalesData() As DataTable
        Dim dataSet As New DataSet()
        dataSet.ReadXml("..\..\data.xml")
        Return dataSet.Tables(0)
    End Function

    Private Function CreateStream(ByVal name As String, _
       ByVal fileNameExtension As String, _
       ByVal encoding As Encoding, ByVal mimeType As String, _
       ByVal willSeek As Boolean) As Stream
        Dim stream As Stream = _
            New FileStream("..\..\" + _
             name + "." + fileNameExtension, FileMode.Create)
        m_streams.Add(stream)
        Return stream
    End Function

    Private Sub Export(ByVal report As LocalReport)
        Dim deviceInfo As String = _
          "<DeviceInfo>" + _
          "  <OutputFormat>EMF</OutputFormat>" + _
          "  <PageWidth>11in</PageWidth>" + _
          "  <PageHeight>8.5in</PageHeight>" + _
          "  <MarginTop>0.2in</MarginTop>" + _
          "  <MarginLeft>0.2in</MarginLeft>" + _
          "  <MarginRight>0.2in</MarginRight>" + _
          "  <MarginBottom>0.2in</MarginBottom>" + _
          "</DeviceInfo>"
        Dim warnings() As Warning = Nothing
        m_streams = New List(Of Stream)()
        report.Render("Image", deviceInfo, AddressOf CreateStream, _
           warnings)

        Dim stream As Stream
        For Each stream In m_streams
            stream.Position = 0
        Next
    End Sub

    Private Sub PrintPage(ByVal sender As Object, _
    ByVal ev As PrintPageEventArgs)
        Dim pageImage As New Metafile(m_streams(m_currentPageIndex))
        ev.Graphics.DrawImage(pageImage, ev.PageBounds)

        m_currentPageIndex += 1
        ev.HasMorePages = (m_currentPageIndex < m_streams.Count)
    End Sub

    Private Sub Print(ByVal prName As String)
        Dim printerName As String = prName

        If m_streams Is Nothing Or m_streams.Count = 0 Then
            Return
        End If

        Dim printDoc As New PrintDocument()
        printDoc.PrinterSettings.PrinterName = printerName
        printDoc.DefaultPageSettings.Landscape = True
        If Not printDoc.PrinterSettings.IsValid Then
            Dim msg As String = String.Format( _
                "Can't find printer ""{0}"".", printerName)
            Console.WriteLine(msg)
            Return
        End If
        AddHandler printDoc.PrintPage, AddressOf PrintPage
        printDoc.Print()
    End Sub

    Public Sub Run(ByVal printerName As String, ByVal invoiceID As Integer, ByVal invType As String)
        Dim report As LocalReport = New LocalReport()
        Dim parInvoiceType As New Microsoft.Reporting.WinForms.ReportParameter()

        report.ReportEmbeddedResource = "leonida.rptInvoiceOE.rdlc"

        Dim _reportDataSource1, _reportDataSource2 As New Microsoft.Reporting.WinForms.ReportDataSource

        _reportDataSource1.Name = "DataSet1"
        _reportDataSource1.Value = getData(invoiceID, False)
        _reportDataSource2.Name = "DataSet2"
        _reportDataSource2.Value = getData(invoiceID, True)

        report.DataSources.Add(_reportDataSource1)
        report.DataSources.Add(_reportDataSource2)

        parInvoiceType.Name = "pInvoiceType"
        parInvoiceType.Values.Add(invType)
        
        Dim parameters() As Microsoft.Reporting.WinForms.ReportParameter = {parInvoiceType}
        report.SetParameters(parameters)

        'Create Invoice for Accountants and for company        
        Export(report)
        m_currentPageIndex = 0
        Print(printerName)

    End Sub

    Private Function getData(ByVal invID As Integer, ByVal invItems As Boolean) As DataTable
        Dim myConnection As New System.Data.SqlClient.SqlConnection
        Dim myCommand As New System.Data.SqlClient.SqlCommand

        myConnection.ConnectionString = My.Settings.leonidaDBConnectionString

        Try
            myConnection.Open()
        Catch ex As Exception
            MessageBox.Show("Η σύνδεση με τη βάση δεδομένων δεν είναι δυνατή...")
            MessageBox.Show("Execute error: " & ex.Message)
        End Try

        If invItems Then
            myCommand.CommandText = "SELECT * FROM tblInvoiceItems WHERE invoiceId=" & invID.ToString()
            myCommand.Connection = myConnection

            Dim dt As New DataTable
            Try
                Dim dad As New SqlClient.SqlDataAdapter(myCommand)
                dad.Fill(dt)

                Return dt
            Catch ex As Exception
                Return Nothing
            End Try
        Else
            myCommand.CommandText = "SELECT * FROM rptInvoice WHERE invoiceId=" & invID.ToString()
            myCommand.Connection = myConnection

            Dim dt As New DataTable
            Try
                Dim dad As New SqlClient.SqlDataAdapter(myCommand)
                dad.Fill(dt)

                Return dt
            Catch ex As Exception
                Return Nothing
            End Try
        End If
    End Function

    Public Overloads Sub Dispose() Implements IDisposable.Dispose
        If Not (m_streams Is Nothing) Then
            Dim stream As Stream
            For Each stream In m_streams
                stream.Close()
            Next
            m_streams = Nothing
        End If
    End Sub
End Class