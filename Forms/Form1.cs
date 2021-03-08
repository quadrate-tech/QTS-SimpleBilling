using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table.Columns.Add("LINE ID", typeof(int));
            table.Columns.Add("ITEM CODE", typeof(int));
            table.Columns.Add("ITEM NAME", typeof(String));
            table.Columns.Add("UNIT PRICE", typeof(double));
            table.Columns.Add("QTY", typeof(double));
            table.Columns.Add("DISCOUNT", typeof(double));
            table.Columns.Add("SUB TOTAL", typeof(double));

            dataGridView1.DataSource = table;

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

        private void Quantity_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
        int x = 1;
        private void Discount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int lineId = x;
                table.Rows.Add(lineId, ItemCode.Text, ItemName.Text, UnitPrice.Text, Quantity.Text, Discount.Text, SubTotal.Text);
                dataGridView1.DataSource = table;
                x++;
                

            }
        }



        double tot = 0;

        private void Discount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SubTotal.Text = ((double.Parse(Quantity.Text) * double.Parse(UnitPrice.Text)) - double.Parse(Discount.Text)).ToString();
                tot = tot+double.Parse(SubTotal.Text);
                Total.Text = tot.ToString();


            }
            catch
            {

            }
            
        }
        

        private void SubTotal_TextChanged_1(object sender, EventArgs e)
        {

            
        }
    }
}
