
namespace QTS_SimpleBilling
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MasterForms = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItems = new System.Windows.Forms.ToolStripMenuItem();
            this.View = new System.Windows.Forms.ToolStripMenuItem();
            this.Tools = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuShelf = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuUnits = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCost = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSellingPrice = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MasterForms,
            this.View,
            this.Tools});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(978, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MasterForms
            // 
            this.MasterForms.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItems,
            this.MenuCategory,
            this.MenuShelf,
            this.MenuUnits,
            this.MenuCost,
            this.MenuSellingPrice});
            this.MasterForms.Name = "MasterForms";
            this.MasterForms.Size = new System.Drawing.Size(91, 20);
            this.MasterForms.Text = "Master Forms";
            // 
            // MenuItems
            // 
            this.MenuItems.Name = "MenuItems";
            this.MenuItems.Size = new System.Drawing.Size(189, 22);
            this.MenuItems.Text = "Manage Items";
            // 
            // View
            // 
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(44, 20);
            this.View.Text = "View";
            // 
            // Tools
            // 
            this.Tools.Name = "Tools";
            this.Tools.Size = new System.Drawing.Size(46, 20);
            this.Tools.Text = "Tools";
            // 
            // MenuCategory
            // 
            this.MenuCategory.Name = "MenuCategory";
            this.MenuCategory.Size = new System.Drawing.Size(189, 22);
            this.MenuCategory.Text = "Manage Category";
            // 
            // MenuShelf
            // 
            this.MenuShelf.Name = "MenuShelf";
            this.MenuShelf.Size = new System.Drawing.Size(189, 22);
            this.MenuShelf.Text = "Manage Shelves";
            // 
            // MenuUnits
            // 
            this.MenuUnits.Name = "MenuUnits";
            this.MenuUnits.Size = new System.Drawing.Size(189, 22);
            this.MenuUnits.Text = "Manage Units";
            // 
            // MenuCost
            // 
            this.MenuCost.Name = "MenuCost";
            this.MenuCost.Size = new System.Drawing.Size(189, 22);
            this.MenuCost.Text = "Manage Product Cost";
            // 
            // MenuSellingPrice
            // 
            this.MenuSellingPrice.Name = "MenuSellingPrice";
            this.MenuSellingPrice.Size = new System.Drawing.Size(189, 22);
            this.MenuSellingPrice.Text = "Manage Selling Price";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 723);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MasterForms;
        private System.Windows.Forms.ToolStripMenuItem MenuItems;
        private System.Windows.Forms.ToolStripMenuItem View;
        private System.Windows.Forms.ToolStripMenuItem Tools;
        private System.Windows.Forms.ToolStripMenuItem MenuCategory;
        private System.Windows.Forms.ToolStripMenuItem MenuShelf;
        private System.Windows.Forms.ToolStripMenuItem MenuUnits;
        private System.Windows.Forms.ToolStripMenuItem MenuCost;
        private System.Windows.Forms.ToolStripMenuItem MenuSellingPrice;
    }
}

