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
                DGVEmployee.DataSource = empRepo.View();
            }
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

        private void BtnEdit_Click(object sender, EventArgs e)
        {

        }

        private void DGVEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            emp.EmployeeId = Convert.ToInt32(DGVEmployee.SelectedRows[0].Cells[0].Value.ToString());
            emp.EmployeeName = DGVEmployee.SelectedRows[0].Cells[1].Value.ToString();
            emp.Contact = DGVEmployee.SelectedRows[0].Cells[2].ToString();
            emp.Email = DGVEmployee.SelectedRows[0].Cells[3].ToString();
            emp.Address = DGVEmployee.SelectedRows[0].Cells[4].ToString();
            emp.Status = Convert.ToInt32(DGVEmployee.SelectedRows[0].Cells[5].Value.ToString());
            emp.EmployeeCode = DGVEmployee.SelectedRows[0].Cells[6].ToString();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            tableLayoutPanel2.Enabled = false;
            DGVEmployee.DataSource = empRepo.View();
        }
    }
}
