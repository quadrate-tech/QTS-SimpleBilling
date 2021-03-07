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


        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

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
    }
    }
