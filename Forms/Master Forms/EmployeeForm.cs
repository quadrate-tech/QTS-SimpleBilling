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

namespace QTS_SimpleBilling.Forms.Master_Forms
{
    public partial class EmployeeForm : Form
    {
        Employee emp = new Employee();
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {

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
    }
}
