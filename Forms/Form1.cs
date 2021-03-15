using iText.Kernel.Colors;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Data;
using System.Windows.Forms;
using HorizontalAlignment = iText.Layout.Properties.HorizontalAlignment;



namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PrintOnly_Click(object sender, EventArgs e)
        {
            ExportInvoiceAsPDF();
        }

        private void ExportInvoiceAsPDF() {
            var path = @"C:\Invoice\invoice.pdf";
            using (PdfWriter wPdf = new PdfWriter(path, new WriterProperties().SetPdfVersion(PdfVersion.PDF_2_0)))
            {
                var pdfDocument = new PdfDocument(wPdf);

                var document = new Document(pdfDocument, PageSize.A4);
                document.SetMargins(10,40,10,40);
                document.SetBorder(new SolidBorder(ColorConstants.BLACK, 1));
                Table Bus = new Table(UnitValue.CreatePercentArray(new float[] { 15, 5 })).SetVerticalAlignment(VerticalAlignment.TOP).SetHorizontalAlignment(HorizontalAlignment.CENTER);
                Bus.SetWidth(UnitValue.CreatePercentValue(100));
                Bus.SetHorizontalAlignment(HorizontalAlignment.CENTER);
                Bus.SetFixedLayout();
                Bus.AddCell(new Cell(1, 1).SetBorder(Border.NO_BORDER).SetFontSize(18).SetFontColor(ColorConstants.BLUE).SetTextAlignment(TextAlignment.LEFT).Add(new Paragraph("INVOICE")));
                Bus.AddCell(new Cell(1, 1).SetBorder(Border.NO_BORDER).SetFontSize(8).SetTextAlignment(TextAlignment.LEFT).Add(new Paragraph("\n")));
                Bus.AddCell(new Cell(1, 1).SetBorder(Border.NO_BORDER).SetFontSize(12).SetTextAlignment(TextAlignment.LEFT).Add(new Paragraph("Quadate Tech Solutions" +"\n"+ "Gampaha")));
                Bus.AddCell(new Cell(1, 1).SetBorder(Border.NO_BORDER).SetFontSize(8).SetTextAlignment(TextAlignment.LEFT).Add(new Paragraph("\n")));
                Bus.AddCell(new Cell(1, 1).SetBorder(Border.NO_BORDER).SetFontSize(8).SetTextAlignment(TextAlignment.LEFT).Add(new Paragraph("\n")));
                Bus.AddCell(new Cell(1, 1).SetBorder(Border.NO_BORDER).SetFontSize(8).SetTextAlignment(TextAlignment.LEFT).Add(new Paragraph("\n")));
                Bus.AddCell(new Cell(1, 1).SetBorder(Border.NO_BORDER).SetFontSize(12).SetTextAlignment(TextAlignment.LEFT).Add(new Paragraph("Customer Name:" + " " + CustomerName.Text)));
                Bus.AddCell(new Cell(1, 1).SetBorder(Border.NO_BORDER).SetFontSize(8).SetTextAlignment(TextAlignment.LEFT).Add(new Paragraph("\n")));
                Bus.AddCell(new Cell(1, 1).SetBorder(Border.NO_BORDER).SetFontSize(12).SetTextAlignment(TextAlignment.LEFT).Add(new Paragraph("Customer Contact No:"+" "+ CustomerMobile.Text)));
                Bus.AddCell(new Cell(1, 1).SetBorder(Border.NO_BORDER).SetFontSize(8).SetTextAlignment(TextAlignment.LEFT).Add(new Paragraph("\n")));
                Bus.AddCell(new Cell(1, 1).SetBorder(Border.NO_BORDER).SetFontSize(12).SetTextAlignment(TextAlignment.LEFT).Add(new Paragraph("Customer Address:" + " "+Address.Text)));
                Bus.AddCell(new Cell(1, 1).SetBorder(Border.NO_BORDER).SetFontSize(8).SetTextAlignment(TextAlignment.LEFT).Add(new Paragraph("\n")));
                Bus.AddCell(new Cell(1, 1).SetBorder(Border.NO_BORDER).SetFontSize(8).SetTextAlignment(TextAlignment.LEFT).Add(new Paragraph("\n")));

                Table table = new Table(UnitValue.CreatePercentArray(new float[] { 5, 18, 4, 3, 4, 4, 4 })).SetVerticalAlignment(VerticalAlignment.TOP).SetHorizontalAlignment(HorizontalAlignment.CENTER);
                table.SetWidth(UnitValue.CreatePercentValue(100));
                table.SetHorizontalAlignment(HorizontalAlignment.CENTER);
                table.SetFixedLayout();
                table.AddCell(new Cell(1, 1).SetBorder(new SolidBorder(ColorConstants.LIGHT_GRAY, 1)).SetFontSize(12).SetTextAlignment(TextAlignment.LEFT).Add(new Paragraph("Item Code")));
                table.AddCell(new Cell(1, 1).SetBorder(new SolidBorder(ColorConstants.LIGHT_GRAY, 1)).SetFontSize(12).SetTextAlignment(TextAlignment.LEFT).Add(new Paragraph("Item Name")));
                table.AddCell(new Cell(1, 1).SetBorder(new SolidBorder(ColorConstants.LIGHT_GRAY, 1)).SetFontSize(12).SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph("Unit Price")));
                table.AddCell(new Cell(1, 1).SetBorder(new SolidBorder(ColorConstants.LIGHT_GRAY, 1)).SetFontSize(12).SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph("Qty")));
                table.AddCell(new Cell(1, 1).SetBorder(new SolidBorder(ColorConstants.LIGHT_GRAY, 1)).SetFontSize(12).SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph("Gross")));
                table.AddCell(new Cell(1, 1).SetBorder(new SolidBorder(ColorConstants.LIGHT_GRAY, 1)).SetFontSize(12).SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph("Disc.")));
                table.AddCell(new Cell(1, 1).SetBorder(new SolidBorder(ColorConstants.LIGHT_GRAY, 1)).SetFontSize(12).SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph("Net Total")));
                try
                {
                    foreach (DataRow d in dt.Rows)
                    {

                        table.AddCell(new Cell(1, 1).SetBorder(new SolidBorder(ColorConstants.LIGHT_GRAY, 1)).SetFontSize(8).SetTextAlignment(TextAlignment.LEFT).Add(new Paragraph(d[1].ToString())));
                        table.AddCell(new Cell(1, 1).SetBorder(new SolidBorder(ColorConstants.LIGHT_GRAY, 1)).SetFontSize(8).SetTextAlignment(TextAlignment.LEFT).Add(new Paragraph(d[2].ToString())));
                        table.AddCell(new Cell(1, 1).SetBorder(new SolidBorder(ColorConstants.LIGHT_GRAY, 1)).SetFontSize(8).SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph(d[3].ToString())));
                        table.AddCell(new Cell(1, 1).SetBorder(new SolidBorder(ColorConstants.LIGHT_GRAY, 1)).SetFontSize(8).SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph(d[4].ToString())));
                        table.AddCell(new Cell(1, 1).SetBorder(new SolidBorder(ColorConstants.LIGHT_GRAY, 1)).SetFontSize(8).SetTextAlignment(TextAlignment.RIGHT).Add(new Paragraph(d[5].ToString())));
                        table.AddCell(new Cell(1, 1).SetBorder(new SolidBorder(ColorConstants.LIGHT_GRAY, 1)).SetFontSize(8).SetTextAlignment(TextAlignment.RIGHT).Add(new Paragraph(d[6].ToString())));
                        table.AddCell(new Cell(1, 1).SetBorder(new SolidBorder(ColorConstants.LIGHT_GRAY, 1)).SetFontSize(8).SetTextAlignment(TextAlignment.RIGHT).Add(new Paragraph(d[7].ToString())));
                    }

                }
                catch (Exception Ex) {
                    
                }
                
                Table footer = new Table(UnitValue.CreatePercentArray(new float[] { 15, 5 })).SetVerticalAlignment(VerticalAlignment.TOP).SetHorizontalAlignment(HorizontalAlignment.CENTER);
                footer.SetWidth(UnitValue.CreatePercentValue(100));
                footer.SetHorizontalAlignment(HorizontalAlignment.CENTER);
                footer.SetFixedLayout();
                footer.AddCell(new Cell(1, 1).SetBorder(Border.NO_BORDER).SetFontSize(8).SetTextAlignment(TextAlignment.LEFT).Add(new Paragraph("\n")));
                footer.AddCell(new Cell(1, 1).SetBorder(Border.NO_BORDER).SetFontSize(8).SetTextAlignment(TextAlignment.LEFT).Add(new Paragraph("\n")));
                footer.AddCell(new Cell(1, 1).SetBorder(Border.NO_BORDER).SetFontSize(12).SetTextAlignment(TextAlignment.LEFT).Add(new Paragraph("Sub Total:" + "        " + TotalValue.Text)));
                footer.AddCell(new Cell(1, 1).SetBorder(Border.NO_BORDER).SetFontSize(8).SetTextAlignment(TextAlignment.LEFT).Add(new Paragraph("\n")));
                footer.AddCell(new Cell(1, 1).SetBorder(Border.NO_BORDER).SetFontSize(12).SetTextAlignment(TextAlignment.LEFT).Add(new Paragraph("Total Discount:" + " " + TotalDiscount.Text)));
                footer.AddCell(new Cell(1, 1).SetBorder(Border.NO_BORDER).SetFontSize(8).SetTextAlignment(TextAlignment.LEFT).Add(new Paragraph("\n")));
                footer.AddCell(new Cell(1, 1).SetBorder(Border.NO_BORDER).SetFontSize(12).SetTextAlignment(TextAlignment.LEFT).Add(new Paragraph("Net Total:" + "         " + FinalTotal.Text)));


                document.Add(Bus);
                document.Add(table);
                document.Add(footer);
                document.Close();
            
                

                MessageBox.Show("Pdf was created successfully" + path);
            }
        }



    }
 }


