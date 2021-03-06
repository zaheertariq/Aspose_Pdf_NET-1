//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;
using Aspose.Pdf.Devices;

namespace CSharp.AsposePdf.Images
{
    public class PageToPNG
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Images();

            //open document
            Document pdfDocument = new Document(dataDir + "PageToPNG.pdf");


            using (FileStream imageStream = new FileStream(dataDir + "aspose-logo.png", FileMode.Create))
            {
                //create Resolution object
                Resolution resolution = new Resolution(300);
                //create PNG device with specified attributes (Width, Height, Resolution)
                PngDevice pngDevice = new PngDevice(resolution);

                //convert a particular page and save the image to stream
                pngDevice.Process(pdfDocument.Pages[1], imageStream);

                //close stream
                imageStream.Close();


            }
        }
    }
}