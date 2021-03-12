using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QTS_SimpleBilling.BAL;
using QTS_SimpleBilling.Model;

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
            TxtItemCode.Text = string.Empty;
            TxtItemName.Text = string.Empty;
            TxtItemCategory.Text = string.Empty;
            TxtUnitPrice.Text = string.Empty;
            TxtItemQuantity.Text = string.Empty;
            TxtItemDiscount.Text = string.Empty;
            TxtItemSubTotal.Text = string.Empty;
            TxtItemTotal.Text = string.Empty;
            TxtTotalDiscount.Text = string.Empty;
            TxtTotal.Text = string.Empty;

            ItemCodeAutocomplete();
        }

        private void ItemCodeAutocomplete()
        {
            AutoCompleteStringCollection Code = new AutoCompleteStringCollection();

            using (BillingContext db = new BillingContext())
            {
                var data = db.Items.Select(c => c.ItemCode).ToList();
                Code.AddRange(data.ToArray());
                TxtItemCode.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                TxtItemCode.AutoCompleteSource = AutoCompleteSource.CustomSource;
                TxtItemCode.AutoCompleteCustomSource = Code;
            }
        }

        private void TxtItemDiscount_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                string query = TxtItemDiscount.Text.Trim();
                if (!string.IsNullOrEmpty(query))
                {

                    double Total = Convert.ToInt32(TxtItemQuantity.Text.Trim()) * (Convert.ToInt32(TxtUnitPrice.Text.Trim()) - Convert.ToInt32(TxtItemDiscount.Text.Trim()));
                    TxtItemTotal.Text = Total.ToString();


                }
                else
                {
                    

                    TxtItemTotal.Text = string.Empty;

                }
            }
            catch
            {
                MessageBox.Show("Add valid Discount OR valid Quantity..!");
                

            }
        }

        private void TxtItemQuantity_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                string query = TxtItemQuantity.Text.Trim();
                if (!string.IsNullOrEmpty(query))
                {
                    if (!string.IsNullOrEmpty(TxtItemDiscount.Text.Trim()))
                    {
                        double subTotal = Convert.ToInt32(TxtItemQuantity.Text.Trim()) * Convert.ToDouble(TxtUnitPrice.Text.Trim());
                        TxtItemSubTotal.Text = subTotal.ToString();


                        double Total = Convert.ToInt32(TxtItemQuantity.Text.Trim()) * (Convert.ToDouble(TxtUnitPrice.Text.Trim()) - Convert.ToInt32(TxtItemDiscount.Text.Trim()));
                        TxtItemTotal.Text = Total.ToString();

                    }
                    else
                    {
                        double subTotal = Convert.ToInt32(TxtItemQuantity.Text.Trim()) * Convert.ToDouble(TxtUnitPrice.Text.Trim());
                        TxtItemSubTotal.Text = subTotal.ToString();
                    }


                }
                else
                {
                    TxtItemSubTotal.Text = string.Empty;
                    

                }
            }
            catch
            {
                MessageBox.Show("Add valid Quantity..!");
                TxtItemQuantity.Text = string.Empty;
            }
        }

        private void AddToDGV()
        {
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(DGVInvoice);
            newRow.Cells[0].Value = TxtItemCode.Text;
            newRow.Cells[1].Value = TxtItemName.Text;
            newRow.Cells[2].Value = TxtItemQuantity.Text;
            newRow.Cells[3].Value = TxtUnitPrice.Text;
            newRow.Cells[4].Value = TxtItemDiscount.Text;
            newRow.Cells[5].Value = TxtItemTotal.Text;
            DGVInvoice.Rows.Add(newRow);

        }

        private void CalculateFinalTotals()
        {
            if (TxtTotal.Text == "" || TxtTotalDiscount.Text == "")
            {
                TxtTotalDiscount.Text = TxtItemDiscount.Text.Trim();
                TxtTotal.Text = TxtItemTotal.Text.Trim();

            }

            else
            {
                TxtTotalDiscount.Text = (Convert.ToDouble(TxtTotalDiscount.Text.Trim()) + Convert.ToDouble(TxtItemDiscount.Text.Trim())).ToString();
                TxtTotal.Text = (Convert.ToDouble(TxtTotal.Text.Trim()) + Convert.ToDouble(TxtItemTotal.Text.Trim())).ToString();
            }

        }

        private void TxtItemDiscount_KeyDown(object sender, KeyEventArgs e)
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

        private void TxtItemCode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string query = TxtItemCode.Text.Trim();
                TxtItemQuantity.Text = string.Empty;
                TxtItemDiscount.Text = string.Empty;
                TxtItemSubTotal.Text = string.Empty;
                TxtItemTotal.Text = string.Empty;

                if (!string.IsNullOrEmpty(query))
                {

                    using (BillingContext db = new BillingContext())
                    {
                        var data = (from i in db.Items
                                    join s in db.Shelves on i.Shelf.ShelfId equals s.ShelfId
                                    join c in db.Categories on i.ItemCategory.CategoryId equals c.CategoryId
                                    join p in db.SellingPrices on i.ItemId equals p.SellingPriceItem.ItemId
                                    select new
                                    {
                                        i.ItemId,
                                        i.ItemName,
                                        i.ItemCode,
                                        i.Shelf.ShelfName,
                                        i.ItemCategory.CategoryName,
                                        p.Price
                                    }).FirstOrDefault(c => c.ItemCode == query);

                        if (data == null)
                        {
                            TxtItemName.Text = "";

                            TxtUnitPrice.Text = "";
                            TxtItemCategory.Text = "";
                        }
                        else
                        {
                            TxtItemName.Text = data.ItemName;

                            TxtUnitPrice.Text = data.Price.ToString();
                            TxtItemCategory.Text = data.CategoryName;
                        }

                    }


                }
            }
            catch (Exception ex)
            {
                Exc.ErMessage(ex);
            }
        }

        private void TxtItemQuantity_KeyDown(object sender, KeyEventArgs e)
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
