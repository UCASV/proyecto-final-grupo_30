using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace PROYECTO_BD_POO_FINAL.Controller
{
    class CreatePdf
    {
        public static void Save(string numDosis, string name, string dui, string place, string date,
            string time, string address)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Cita en PDF|*.pdf";
            saveFileDialog.Title = "Guardar Archivo";
            saveFileDialog.FileName = dui + "n" + numDosis;
            saveFileDialog.ShowDialog();

            var path = string.Empty;
            path = saveFileDialog.FileName;

            //PdfWriter writer = new PdfWriter($"..\\..\\..\\PDFs\\{dui}n{numDosis}.pdf");

            PdfWriter writer = new PdfWriter(path);
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);

            Paragraph header = new Paragraph("VACUNA COVID-19")
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontSize(20);
            document.Add(header);

            Paragraph subheader = new Paragraph($"Dosis #{numDosis}")
           .SetTextAlignment(TextAlignment.CENTER)
           .SetFontSize(15);
            document.Add(subheader);

            // Line separator
            LineSeparator ls = new LineSeparator(new SolidLine());
            document.Add(ls);

            //defining display data
            var pName = new Paragraph($"Nombre: {name}");
            var pDui = new Paragraph($"DUI: {dui}");
            var pPlace = new Paragraph($"Lugar de Vacunación: {place}");
            var pDate = new Paragraph($"Fecha: {date}");
            var pTime = new Paragraph($"Hora: {time}");
            var pAddress = new Paragraph($"Dirección: {address}");

            document.Add(pName);
            document.Add(pDui);
            document.Add(pPlace);
            document.Add(pDate);
            document.Add(pTime);
            document.Add(pAddress);
            document.Close();
        }
    }
}
