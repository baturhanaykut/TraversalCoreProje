﻿using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Mvc;


namespace TraversalCoreProje.Controllers
{
    public class PdfReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StaticPdfReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdfreports/" + "dosya1.pdf");
            var stream = new FileStream(path, FileMode.Create);

            Document document = new Document(PageSize.A4);

            PdfWriter.GetInstance(document,stream);

            document.Open();

            Paragraph paragraph = new Paragraph("Traversal Rezervasyon Pdf Raporu");

            document.Add(paragraph);
            document.Close();
            return File("/pdfreports/dosya1.pdf", "application/pdf", "dosya1.pdf");
        }

        public IActionResult StaticCustomerReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdfreports/" + "dosya2.pdf");
            var stream = new FileStream(path, FileMode.Create);

            Document document = new Document(PageSize.A4);

            PdfWriter.GetInstance(document, stream);

            document.Open();

            PdfPTable pdfPTable = new PdfPTable(3);

            pdfPTable.AddCell("Misafir Adı");
            pdfPTable.AddCell("Misafir Soyadı");
            pdfPTable.AddCell("Misafir TC");

            pdfPTable.AddCell("Baturhan");
            pdfPTable.AddCell("Aykut");
            pdfPTable.AddCell("12982436365");

            pdfPTable.AddCell("Gökçe");
            pdfPTable.AddCell("Aykut");
            pdfPTable.AddCell("12982436366");

            pdfPTable.AddCell("Yağız");
            pdfPTable.AddCell("Aykut");
            pdfPTable.AddCell("12982436367");

            document.Add(pdfPTable);

            document.Close();
            return File("/pdfreports/dosya2.pdf", "application/pdf", "dosya2.pdf");
        }

    }
}
