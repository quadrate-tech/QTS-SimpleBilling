using QTS_SimpleBilling.EmpRepo;
using QTS_SimpleBilling.Model;
using System;
using System.Windows.Forms;

namespace QTS_SimpleBilling.Forms.Master_Forms
{
    public partial class EmployeeForm : Form
    {
        readonly Employee emp = new Employee();
        readonly EmployeeRepo empRepo = new EmployeeRepo();
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            TLPCRUD.Enabled = true;
        }

        private Employee GetEmp()
        {
            emp.EmployeeName = TxtEmpName.Text.Trim();
            emp.Email = TxtEmail.Text.Trim();
            emp.Contact = TxtContact.Text.Trim();
            emp.Address = TxtAddress.Text.Trim();
            emp.EmployeeCode = TxtEmpCode.Text.Trim();
            emp.Status = EmployeeStatus();
            return emp;
        }

        private int EmployeeStatus()
        {
            int status = 0;
            if (RDOActive.Checked == true)
                status = 1;
            else if (RDOInActive.Checked == true)
                status = 0;
            return status;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            TxtEmpName.Text = string.Empty;
            TxtContact.Text = string.Empty;
            TxtEmail.Text = string.Empty;
            TxtAddress.Text = string.Empty;
            TxtEmpCode.Text = string.Empty;
            emp.EmployeeId = 0;
        }

        private void DGVEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            emp.EmployeeId = Convert.ToInt32(DGVEmployee.SelectedRows[0].Cells[0].Value.ToString());
            emp.EmployeeName = DGVEmployee.SelectedRows[0].Cells[1].Value.ToString();
            emp.Contact = DGVEmployee.SelectedRows[0].Cells[2].Value.ToString();
            emp.Email = DGVEmployee.SelectedRows[0].Cells[3].Value.ToString();
            emp.Address = DGVEmployee.SelectedRows[0].Cells[4].Value.ToString();
            emp.Status = Convert.ToInt32(DGVEmployee.SelectedRows[0].Cells[5].Value.ToString());
            emp.EmployeeCode = DGVEmployee.SelectedRows[0].Cells[6].Value.ToString();
            TxtEmpName.Text = emp.EmployeeName;
            TxtContact.Text = emp.Contact;
            TxtEmail.Text = emp.Email;
            TxtAddress.Text = emp.Address;
            TxtEmpCode.Text = emp.EmployeeCode;
            if (emp.Status == 1)
                RDOActive.Checked = true;
            else
                RDOInActive.Checked = true;

        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            TLPCRUD.Enabled = false;
            DGVEmployee.DataSource = empRepo.View();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                empRepo.Create(GetEmp());
            }
            catch (Exception ex)
            {
                BAL.Exc.ErMessage(ex);
            }
            finally
            {
                TLPCRUD.Enabled = false;
                DGVEmployee.DataSource = empRepo.View();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                empRepo.Delete(GetEmp());
            }
            catch (Exception ex)
            {
                BAL.Exc.ErMessage(ex);
            }
            finally
            {
                TLPCRUD.Enabled = false;
                DGVEmployee.DataSource = empRepo.View();
            }
        }
    }
}
