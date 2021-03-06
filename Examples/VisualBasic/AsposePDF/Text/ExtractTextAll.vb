'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Pdf. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Pdf
Imports Aspose.Pdf.Text

Namespace VisualBasic.AsposePdf.Text
    Public Class ExtractTextAll
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Text()

            'open document
            Dim pdfDocument As New Document(dataDir & "ExtractTextAll.pdf")

            'create TextAbsorber object to extract text
            Dim textAbsorber As New TextAbsorber()

            'accept the absorber for all the pages
            pdfDocument.Pages.Accept(textAbsorber)

            'get the extracted text
            Dim extractedText As String = textAbsorber.Text

            ' create a writer and open the file
            Dim tw As TextWriter = New StreamWriter(dataDir & "extracted-text.txt")

            ' write a line of text to the file
            tw.WriteLine(extractedText)

            ' close the stream
            tw.Close()


        End Sub
    End Class
End Namespace