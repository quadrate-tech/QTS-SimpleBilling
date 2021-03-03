using QTS_SimpleBilling.EmpRepo;
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

namespace QTSSimple_Billing
{
    public partial class CustomerForm : Form
    {
        readonly Customer cmp = new Customer();
        readonly CustomerRepo cmpRepo = new CustomerRepo();
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            TLPCRUD.Enabled = true;
        }
        private Customer GetEmp()
        {
            cmp.CustomerName = CustomerTXT.Text.Trim();
            cmp.Email = EmailTXT.Text.Trim();
            cmp.Address = textBox1.Text.Trim();
            cmp.Contact = ContactTXT.Text.Trim();
            cmp.CustomerCode = CustomerCodeTXT.Text.Trim();
            return cmp;
        }


        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                cmpRepo.Create(GetEmp());
            }
            catch (Exception ex)
            {
                BAL.Exc.ErMessage(ex);
            }
            finally
            {
                TLPCRUD.Enabled = true;
                CustomerData.DataSource = cmpRepo.View();
            }
        }

        private void BtnDelet_Click(object sender, EventArgs e)
        {
            try
            {
                cmpRepo.Delete(GetEmp());
            }
            catch (Exception ex)
            {
                BAL.Exc.ErMessage(ex);
            }
            finally
            {
                TLPCRUD.Enabled = false;
                CustomerData.DataSource = cmpRepo.View();
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            CustomerTXT.Text = string.Empty;
            ContactTXT.Text = string.Empty;
            EmailTXT.Text = string.Empty;
            CustomerCodeTXT.Text = string.Empty;
            textBox1.Text = string.Empty;
            cmp.CustomerId = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TLPCRUD.Enabled = false;
            CustomerData.DataSource = cmpRepo.View();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ContactTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_KeyUp(object sender, EventArgs e)
        {
            try
            {
                string query = textBox2.Text.Trim();
                if (!string.IsNullOrEmpty(query))
                {
                    CustomerData.DataSource = cmpRepo.Search(query);
                }
                else
                {
                    CustomerData.DataSource = cmpRepo.View();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CustomerData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
