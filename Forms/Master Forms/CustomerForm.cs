using QTS_SimpleBilling.CusRepo;
using QTS_SimpleBilling.Model;
using System;
using System.Windows.Forms;

namespace QTS_SimpleBilling.Forms.Master_Forms
{
    public partial class CustomerForm : Form
    {

        readonly Customer cus = new Customer();
        readonly CustomerRepo cusRepo = new CustomerRepo();

        public CustomerForm()
        {
            InitializeComponent();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            TLPCusCRUD.Enabled = true;
        }

        private Customer GetCus()
        {
            cus.CustomerName = TxtCusName.Text.Trim();
            cus.Contact = TxtCusContact.Text.Trim();
            cus.Email = TxtCusEmail.Text.Trim();    
            cus.Address = TxtCusAddress.Text.Trim();
          
            return cus;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {

                TxtCusName.Text = string.Empty;
                TxtCusContact.Text = string.Empty;
                TxtCusEmail.Text = string.Empty;
                TxtCusAddress.Text = string.Empty;
        }

        private void DGVCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TLPCusCRUD.Enabled = true;
            cus.CustomerId = Convert.ToInt32(DGVCustomer.SelectedRows[0].Cells[0].Value.ToString());
            cus.CustomerName = DGVCustomer.SelectedRows[0].Cells[1].Value.ToString();
            cus.Contact = DGVCustomer.SelectedRows[0].Cells[2].Value.ToString();
            cus.Email = DGVCustomer.SelectedRows[0].Cells[3].Value.ToString();
            cus.Address = DGVCustomer.SelectedRows[0].Cells[4].Value.ToString();
            
            
            TxtCusName.Text = cus.CustomerName;
            TxtCusContact.Text = cus.Contact;
            TxtCusEmail.Text = cus.Email;
            TxtCusAddress.Text = cus.Address;
         

        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            TLPCusCRUD.Enabled = false;
            DGVCustomer.DataSource = cusRepo.View();
        }


        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                cusRepo.Create(GetCus());
            }
            catch (Exception ex)
            {
                BAL.Exc.ErMessage(ex);
            }
            finally
            {
                TLPCusCRUD.Enabled = false;
                DGVCustomer.DataSource = cusRepo.View();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                cusRepo.Delete(GetCus());
            }
            catch (Exception ex)
            {
                BAL.Exc.ErMessage(ex);
            }
            finally
            {
                TLPCusCRUD.Enabled = false;
                DGVCustomer.DataSource = cusRepo.View();
            }
        }

        private void TxtSearchCustomers_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                string query = TxtSearchCustomers.Text.Trim();
                if (!string.IsNullOrEmpty(query))
                {
                    DGVCustomer.DataSource = cusRepo.Search(query);
                }
                else
                {
                    DGVCustomer.DataSource = cusRepo.View();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
