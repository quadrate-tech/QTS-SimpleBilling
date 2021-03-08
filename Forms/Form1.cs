using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Stripe;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {


        public static DataSet ds = new DataSet();
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"workstation id=qts-simple-billing.mssql.somee.com; 
                                        packet size=4096;
                                        user id=quadrate_SQLLogin_1; 
                                        pwd=dv7p4lkpzl; 
                                        data source=qts-simple-billing.mssql.somee.com;
                                        persist security info=False;
                                        initial catalog=qts-simple-billing");
        
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

        private void CustomerMobile_TextChanged(object sender, EventArgs e)
        {
            
            connection.Open();
            string sqlSelectQuery = "SELECT" * FROM Customer WHERE PhoneNumber = "+string.Parse(CustomerMobile_TextChanged.Text)";
            SqlCommand cmd = new SqlCommand(sqlSelectQuery, connection);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                CustomerName.Text = (dr["Name"].ToString());
                Address.Text = (dr["Address"].ToString());
            }
            connection.Close();
        }
    }
}
