using Microsoft.EntityFrameworkCore.Metadata.Internal;
using QTS_SimpleBilling.CustRepo;
using QTS_SimpleBilling.Model;
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
        readonly Customer cus = new Customer();
        readonly CustomerRepo cusRepo = new CustomerRepo();
        AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();

        public Form1()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();


        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
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

        private void CustomerMobile_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
                {
                    e.Handled = true;
                }

                string term = CustomerMobile.Text.Trim();

                    if (!string.IsNullOrEmpty(term))
                    {
                        List<Customer> customer = new List<Customer>();
                        customer = cusRepo.Search(term);
                        foreach (var c in customer)
                        {
                            MyCollection.Add(c.Contact);
                        }

                        CustomerMobile.AutoCompleteCustomSource = MyCollection;

                        CustomerName.Text = customer[0].CustomerName.ToString();
                        Address.Text = customer[0].Address.ToString();
                    }

                    else
                    {
                        MessageBox.Show("Not Matching Results Found!");
                    }
                }

            catch (Exception ex)
            {
                MessageBox.Show("Not Matching Results Found!");
            }
        }
        

        private void CustomerMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = !char.IsDigit(e.KeyChar);
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
