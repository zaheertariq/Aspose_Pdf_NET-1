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
Imports Aspose.Pdf.Facades
Imports Aspose.Pdf.InteractiveFeatures.Forms
Imports System.Collections

Namespace VisualBasic.AsposePdf.SecuritySignatures
    Public Class DigitallySign
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_SecuritySignatures()

            Dim inFile As String = dataDir & "DigitallySign.pdf"
            Dim outFile As String = dataDir & "DigitallySign_out.pdf"
            Using document As New Document(inFile)
                Using signature As New PdfFileSignature(document)
                    Dim pkcs As New PKCS7("c:\test.pfx", "WebSales") ' Use PKCS7/PKCS7Detached objects
                    Dim docMdpSignature As New DocMDPSignature(pkcs, DocMDPAccessPermissions.FillingInForms)
                    Dim rect As New System.Drawing.Rectangle(100, 100, 200, 100)
                    'set signature appearance
                    signature.SignatureAppearance = dataDir & "aspose-logo.jpg"
                    'create any of the three signature types
                    signature.Certify(1, "Signature Reason", "Contact", "Location", True, rect, docMdpSignature)
                    'save output PDF file
                    signature.Save(outFile)
                End Using
            End Using

            Using document As New Document(outFile)
                Using signature As New PdfFileSignature(document)
                    Dim sigNames As IList = signature.GetSignNames()
                    If sigNames.Count > 0 Then ' Any signatures?
                        If signature.VerifySigned(TryCast(sigNames(0), String)) Then ' Verify first one
                            If signature.IsCertified Then ' Certified?
                                If signature.GetAccessPermissions() = DocMDPAccessPermissions.FillingInForms Then ' Get access permission
                                    ' Do something
                                End If
                            End If
                        End If
                    End If
                End Using
            End Using
        End Sub
    End Class
End Namespace