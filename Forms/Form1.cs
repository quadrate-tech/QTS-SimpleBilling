using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QTS_SimpleBilling;
using QTS_SimpleBilling.BAL;
using QTS_SimpleBilling.Model; 

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        readonly Item emp = new Item();
        readonly ItemRepo itemRepo = new ItemRepo();
    
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

      
        }

        private void TxtItemName_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                string query = TxtItemName.Text.Trim();
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
                                    }).Where(c => c.ItemCode.Contains(itemRepo.Search(query)[0].ItemId.ToString())).ToList();

                        TxtItemCode.Text = data[0].ItemCode;
                        
                        TxtUnitPrice.Text = data[0].Price.ToString();
                        TxtItemCategory.Text = data[0].CategoryName;
                    }


                }
                else
                {
                   
                    TxtItemCode.Text = string.Empty;
                    TxtItemName.Text = string.Empty;
                    TxtItemCategory.Text = string.Empty;
                    TxtUnitPrice.Text = string.Empty;
                    TxtItemQuantity.Text = string.Empty;
                    TxtItemDiscount.Text = string.Empty;
                    TxtItemSubTotal.Text = string.Empty;
                    TxtItemTotal.Text = string.Empty;
                }
            }
            catch 
            {
                MessageBox.Show("Item Not Found..!");
            }
        }

        private void TxtItemCode_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                string query = TxtItemCode.Text.Trim();
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
                                    }).Where(c => c.ItemCode.Contains(itemRepo.Search(query)[0].ItemId.ToString())).ToList();

                        TxtItemName.Text = data[0].ItemName;
                        
                        TxtUnitPrice.Text = data[0].Price.ToString();
                        TxtItemCategory.Text = data[0].CategoryName;
                    }


                }
                else
                {
                    
                    TxtItemCode.Text = string.Empty;
                    TxtItemName.Text = string.Empty;
                    TxtItemCategory.Text = string.Empty;
                    TxtUnitPrice.Text = string.Empty;
                    TxtItemQuantity.Text = string.Empty;
                    TxtItemDiscount.Text = string.Empty;
                    TxtItemSubTotal.Text = string.Empty;
                    TxtItemTotal.Text = string.Empty;

                }
            }
            catch
            {
                MessageBox.Show("Item Not Found..!");
            }
        }

        private void TxtItemDiscount_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                string query = TxtItemDiscount.Text.Trim();
                if (!string.IsNullOrEmpty(query))
                {

                    float Total = Convert.ToInt32(TxtItemQuantity.Text.Trim()) * ( Convert.ToInt32(TxtUnitPrice.Text.Trim()) - Convert.ToInt32(TxtItemDiscount.Text.Trim()));
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
                TxtItemDiscount.Text = string.Empty;

            }
        }

        private void TxtItemQuantity_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                string query = TxtItemQuantity.Text.Trim();
                if (!string.IsNullOrEmpty(query))
                {
                    if(!string.IsNullOrEmpty(TxtItemDiscount.Text.Trim()))
                    {
                        float subTotal = Convert.ToInt32(TxtItemQuantity.Text.Trim()) * Convert.ToInt32(TxtUnitPrice.Text.Trim());
                        TxtItemSubTotal.Text = subTotal.ToString();


                        float Total = Convert.ToInt32(TxtItemQuantity.Text.Trim()) * (Convert.ToInt32(TxtUnitPrice.Text.Trim()) - Convert.ToInt32(TxtItemDiscount.Text.Trim()));
                        TxtItemTotal.Text = Total.ToString();

                    }
                    else
                    {
                        float subTotal = Convert.ToInt32(TxtItemQuantity.Text.Trim()) * Convert.ToInt32(TxtUnitPrice.Text.Trim());
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
    }
}
