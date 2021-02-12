using QTS_SimpleBilling.Model;
using QTS_SimpleBilling.Repo.UserRepo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QTS_SimpleBilling.Forms.Master_Forms
{
    public partial class UserForm : Form
    {
        readonly User u = new User();
        readonly UserRepo userRepo = new UserRepo();
        public UserForm()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CRUD.Enabled = true;

        }
        private User GetUser()
        {
           u.UserName = TxtUserName.Text.Trim();
           u.Password = TxtPass.Text.Trim();
           u.UserType = TxtUsertype.Text.Trim();
           u.EmployeeID = int.Parse(TxtEmpID.Text);

            return u;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            TxtUserName.Text = string.Empty;
            TxtPass.Text = string.Empty;
            TxtUsertype.Text = string.Empty;
            TxtEmpID.Text = string.Empty;
            u.EmployeeID = 0;
            u.UserID = 0;

        }

        private void btnDlt_Click(object sender, EventArgs e)
        {
            try
            {
                userRepo.Delete(GetUser());
            }
            catch (Exception ex)
            {
                BAL.Exc.ErMessage(ex);
            }
            finally
            {
                CRUD.Enabled = false;
                dataGridView.DataSource = userRepo.View();
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                userRepo.Create(GetUser());
            }
            catch (Exception ex)
            {
                BAL.Exc.ErMessage(ex);
            }
            finally
            {
                CRUD.Enabled = false;
               dataGridView.DataSource = userRepo.View();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchtextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string query = TxtSearchUsers.Text.Trim();
                if (!string.IsNullOrEmpty(query))
                {
                    dataGridView.DataSource = userRepo.Search(query);
                }
                else
                {
                    dataGridView.DataSource = userRepo.View();
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            CRUD.Enabled = false;
            dataGridView.DataSource = userRepo.View();

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CRUD.Enabled = true;
            u.UserID = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value.ToString());
            u.UserName = dataGridView.SelectedRows[0].Cells[1].Value.ToString();
            u.UserType= dataGridView.SelectedRows[0].Cells[2].Value.ToString();
            u.Password = dataGridView.SelectedRows[0].Cells[3].Value.ToString();
            u.EmployeeID = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value.ToString());

            u.EmployeeID = int.Parse(TxtEmpID.Text);

            TxtUserName.Text = u.UserName;
            TxtPass.Text = u.Password;
            TxtUsertype.Text = u.UserType;
            //TxtEmpID.Text= u.EmployeeID;
           


        }
    }
}
