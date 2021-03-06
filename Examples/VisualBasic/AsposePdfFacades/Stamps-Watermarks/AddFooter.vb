'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Pdf. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Pdf
Imports Aspose.Pdf.Facades
Imports System.Drawing

Namespace VisualBasic.AsposePDFFacades.StampsWatermarks
    Public Class AddFooter
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_StampsWatermarks()
            'open document
            Dim fileStamp As New PdfFileStamp(dataDir & "AddFooter.pdf", dataDir & "AddFooter_out.pdf")

            'create formatted text for page number
            Dim formattedText As New FormattedText("Aspose - Your File Format Experts!", System.Drawing.Color.Blue, System.Drawing.Color.Gray, Aspose.Pdf.Facades.FontStyle.Courier, EncodingType.Winansi, False, 14)

            'add footer
            fileStamp.AddFooter(formattedText, 10)

            'save updated PDF file
            fileStamp.Close()



        End Sub
    End Class
End Namespace