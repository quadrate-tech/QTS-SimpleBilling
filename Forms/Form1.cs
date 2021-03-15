using Microsoft.EntityFrameworkCore.Metadata.Internal;
using QTS_SimpleBilling.CustRepo;
using QTS_SimpleBilling.BAL;
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

namespace QTS_SimpleBilling
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            ItemCode.Text = string.Empty;
            ItemName.Text = string.Empty;
            textBox1.Text = string.Empty;
            UnitPrice.Text = string.Empty;
            Quantity.Text = string.Empty;
            Discount.Text = string.Empty;
            SubTotal.Text = string.Empty;
            Total.Text = string.Empty;
            TotalDisco.Text = string.Empty;
            TotalValue.Text = string.Empty;
            ItemCodeAutocomplete();

        }

        private void ItemCodeAutocomplete()
        {
            AutoCompleteStringCollection Code = new AutoCompleteStringCollection();

            using (BillingContext db = new BillingContext())
            {
                var data = db.Items.Select(c => c.ItemCode).ToList();
                Code.AddRange(data.ToArray());
                ItemCode.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                ItemCode.AutoCompleteSource = AutoCompleteSource.CustomSource;
                ItemCode.AutoCompleteCustomSource = Code;
            }
        }

        private void Discount_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                string query = Discount.Text.Trim();
                if (!string.IsNullOrEmpty(query))
                {
                    
                    double total = Convert.ToInt32(Quantity.Text.Trim()) * (Convert.ToInt32(UnitPrice.Text.Trim()) - Convert.ToInt32(Discount.Text.Trim()));
                    Total.Text = total.ToString();
                }
                else
                {
                    Total.Text = string.Empty;
                }
            }
            catch
            {
                MessageBox.Show("Add valid Discount OR valid Quantity..!");
            }
        }

        private void Quantity_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                string query = Quantity.Text.Trim();
                if (!string.IsNullOrEmpty(query))
                {
                    if (!string.IsNullOrEmpty(Discount.Text.Trim()))
                    {
                        double subTotal = Convert.ToInt32(Quantity.Text.Trim()) * Convert.ToDouble(UnitPrice.Text.Trim());
                        SubTotal.Text = subTotal.ToString();

                        double total = Convert.ToInt32(Quantity.Text.Trim()) * (Convert.ToDouble(UnitPrice.Text.Trim()) - Convert.ToInt32(Discount.Text.Trim()));
                        Total.Text = total.ToString();

                    }
                    else
                    {
                        double subTotal = Convert.ToInt32(Quantity.Text.Trim()) * Convert.ToDouble(UnitPrice.Text.Trim());
                        SubTotal.Text = subTotal.ToString();
                    }
                }
                else
                {
                    SubTotal.Text = string.Empty;
                }
            }
            catch
            {
                MessageBox.Show("Add valid Quantity..!");
                Quantity.Text = string.Empty;
            }
        }

        private void AddToDGV()
        {
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.Cells[0].Value = ItemCode.Text;
            newRow.Cells[1].Value = ItemName.Text;
            newRow.Cells[2].Value = Quantity.Text;
            newRow.Cells[3].Value = UnitPrice.Text;
            newRow.Cells[4].Value = Discount.Text;
            newRow.Cells[5].Value = Total.Text;
        }

        private void CalculateFinalTotals()
        {
            if (TotalValue.Text == "" || TotalDisco.Text == "")
            {
                TotalDisco.Text = Discount.Text.Trim();
                TotalValue.Text = Total.Text.Trim();
            }

            else
            {
                TotalDisco.Text = (Convert.ToDouble(TotalDisco.Text.Trim()) + Convert.ToDouble(Discount.Text.Trim())).ToString();
                TotalValue.Text = (Convert.ToDouble(TotalValue.Text.Trim()) + Convert.ToDouble(Total.Text.Trim())).ToString();
            }

        }

        private void Discount_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    AddToDGV();
                    CalculateFinalTotals();
                }

            }
            catch (Exception ex)
            {
                Exc.ErMessage(ex);
            }
        }
        private void Quantity_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    AddToDGV();
                    CalculateFinalTotals();
                }
            }
            catch (Exception ex)
            {
                Exc.ErMessage(ex);
            }
        }
    }
}
