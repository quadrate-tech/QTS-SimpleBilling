using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using WindowsFormsApp2;

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

        private void PrintSave_Click(object sender, EventArgs e)
        {

        }
        private void PrintOnly_Click(object sender, EventArgs e)
        {

            using (Bitmap b = new Bitmap(this.Width, this.Height))
            {
                using (Graphics g = Graphics.FromImage(b))
                {
                    g.CopyFromScreen(this.Location, new Point(0, 0), this.Size);

                }
                Document doc = new Document();
                iTextSharp.text.Image i = iTextSharp.text.Image.GetInstance(b, System.Drawing.Imaging.ImageFormat.Bmp);
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(@"C:\Invoice\invoice.pdf", FileMode.Create));
                doc.SetPageSize(new iTextSharp.text.Rectangle(this.Size.Width + doc.LeftMargin + doc.RightMargin, this.Size.Height + doc.TopMargin + doc.BottomMargin));

                doc.Open();
                doc.Add(i);
                doc.Close();

            }
        }


    }
}
