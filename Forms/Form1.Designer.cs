
namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtItemDiscount = new System.Windows.Forms.TextBox();
            this.TxtUnitPrice = new System.Windows.Forms.TextBox();
            this.TxtItemQuantity = new System.Windows.Forms.TextBox();
            this.CustomerName = new System.Windows.Forms.TextBox();
            this.TxtItemCategory = new System.Windows.Forms.TextBox();
            this.TxtItemName = new System.Windows.Forms.TextBox();
            this.TxtItemCode = new System.Windows.Forms.TextBox();
            this.CustomerMobile = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.TxtItemSubTotal = new System.Windows.Forms.TextBox();
            this.TxtItemTotal = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.NewInvoice = new System.Windows.Forms.Button();
            this.SalesReturn = new System.Windows.Forms.Button();
            this.SavetoDraft = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.DGVInvoice = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.PrintSave = new System.Windows.Forms.Button();
            this.PrintOnly = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.TotalDiscount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FinalTotal = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.TotalDisco = new System.Windows.Forms.TextBox();
            this.TotalValue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVInvoice)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1482, 132);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TxtItemDiscount
            // 
            this.TxtItemDiscount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtItemDiscount.Location = new System.Drawing.Point(396, 163);
            this.TxtItemDiscount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtItemDiscount.Name = "TxtItemDiscount";
            this.TxtItemDiscount.Size = new System.Drawing.Size(373, 27);
            this.TxtItemDiscount.TabIndex = 7;
            this.TxtItemDiscount.Text = "Discount";
            this.TxtItemDiscount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtItemDiscount_KeyUp);
            // 
            // TxtUnitPrice
            // 
            this.TxtUnitPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtUnitPrice.Location = new System.Drawing.Point(396, 110);
            this.TxtUnitPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtUnitPrice.Name = "TxtUnitPrice";
            this.TxtUnitPrice.Size = new System.Drawing.Size(373, 27);
            this.TxtUnitPrice.TabIndex = 6;
            this.TxtUnitPrice.Text = "Unit Price";
            // 
            // TxtItemQuantity
            // 
            this.TxtItemQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtItemQuantity.Location = new System.Drawing.Point(396, 57);
            this.TxtItemQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtItemQuantity.Name = "TxtItemQuantity";
            this.TxtItemQuantity.Size = new System.Drawing.Size(373, 27);
            this.TxtItemQuantity.TabIndex = 5;
            this.TxtItemQuantity.Text = "Quantity";
            this.TxtItemQuantity.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtItemQuantity_KeyUp);
            // 
            // CustomerName
            // 
            this.CustomerName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomerName.Location = new System.Drawing.Point(396, 4);
            this.CustomerName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(373, 27);
            this.CustomerName.TabIndex = 4;
            this.CustomerName.Text = "Customer name";
            // 
            // TxtItemCategory
            // 
            this.TxtItemCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtItemCategory.Location = new System.Drawing.Point(3, 163);
            this.TxtItemCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtItemCategory.Name = "TxtItemCategory";
            this.TxtItemCategory.Size = new System.Drawing.Size(387, 27);
            this.TxtItemCategory.TabIndex = 3;
            this.TxtItemCategory.Text = "Item Category";
            // 
            // TxtItemName
            // 
            this.TxtItemName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtItemName.Location = new System.Drawing.Point(3, 110);
            this.TxtItemName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtItemName.Name = "TxtItemName";
            this.TxtItemName.Size = new System.Drawing.Size(387, 27);
            this.TxtItemName.TabIndex = 2;
            this.TxtItemName.Text = "Item Name";
            this.TxtItemName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtItemName_KeyUp);
            // 
            // TxtItemCode
            // 
            this.TxtItemCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtItemCode.Location = new System.Drawing.Point(3, 57);
            this.TxtItemCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtItemCode.Name = "TxtItemCode";
            this.TxtItemCode.Size = new System.Drawing.Size(387, 27);
            this.TxtItemCode.TabIndex = 1;
            this.TxtItemCode.Text = "Item Code";
            this.TxtItemCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtItemCode_KeyUp);
            // 
            // CustomerMobile
            // 
            this.CustomerMobile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomerMobile.Location = new System.Drawing.Point(3, 4);
            this.CustomerMobile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CustomerMobile.Name = "CustomerMobile";
            this.CustomerMobile.Size = new System.Drawing.Size(387, 27);
            this.CustomerMobile.TabIndex = 0;
            this.CustomerMobile.Text = "Customer Mobile";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.5219F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.61903F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.20829F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.65077F));
            this.tableLayoutPanel1.Controls.Add(this.CustomerMobile, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TxtItemCode, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TxtItemName, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.TxtItemCategory, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.CustomerName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TxtItemQuantity, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TxtUnitPrice, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.TxtItemDiscount, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.Address, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.NewInvoice, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.SalesReturn, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.SavetoDraft, 3, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 132);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1482, 214);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.TxtItemSubTotal, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.TxtItemTotal, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(775, 163);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(352, 47);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // TxtItemSubTotal
            // 
            this.TxtItemSubTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtItemSubTotal.Location = new System.Drawing.Point(3, 4);
            this.TxtItemSubTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtItemSubTotal.Name = "TxtItemSubTotal";
            this.TxtItemSubTotal.Size = new System.Drawing.Size(170, 27);
            this.TxtItemSubTotal.TabIndex = 0;
            this.TxtItemSubTotal.Text = "SubTotal";
            // 
            // TxtItemTotal
            // 
            this.TxtItemTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtItemTotal.Location = new System.Drawing.Point(179, 4);
            this.TxtItemTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtItemTotal.Name = "TxtItemTotal";
            this.TxtItemTotal.Size = new System.Drawing.Size(170, 27);
            this.TxtItemTotal.TabIndex = 1;
            this.TxtItemTotal.Text = "Total";
            // 
            // Address
            // 
            this.Address.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Address.Location = new System.Drawing.Point(775, 4);
            this.Address.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(352, 27);
            this.Address.TabIndex = 9;
            this.Address.Text = "Address";
            // 
            // NewInvoice
            // 
            this.NewInvoice.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NewInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewInvoice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NewInvoice.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.NewInvoice.Location = new System.Drawing.Point(1133, 4);
            this.NewInvoice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NewInvoice.Name = "NewInvoice";
            this.NewInvoice.Size = new System.Drawing.Size(346, 45);
            this.NewInvoice.TabIndex = 10;
            this.NewInvoice.Text = "New Invoice";
            this.NewInvoice.UseVisualStyleBackColor = false;
            // 
            // SalesReturn
            // 
            this.SalesReturn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SalesReturn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalesReturn.Location = new System.Drawing.Point(1133, 57);
            this.SalesReturn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SalesReturn.Name = "SalesReturn";
            this.SalesReturn.Size = new System.Drawing.Size(346, 45);
            this.SalesReturn.TabIndex = 11;
            this.SalesReturn.Text = "Sales Return";
            this.SalesReturn.UseVisualStyleBackColor = false;
            // 
            // SavetoDraft
            // 
            this.SavetoDraft.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SavetoDraft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SavetoDraft.Location = new System.Drawing.Point(1133, 110);
            this.SavetoDraft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SavetoDraft.Name = "SavetoDraft";
            this.SavetoDraft.Size = new System.Drawing.Size(346, 45);
            this.SavetoDraft.TabIndex = 12;
            this.SavetoDraft.Text = "Save To Draft";
            this.SavetoDraft.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.18343F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.81657F));
            this.tableLayoutPanel3.Controls.Add(this.DGVInvoice, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 346);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 388F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1482, 388);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // DGVInvoice
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVInvoice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVInvoice.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGVInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVInvoice.Location = new System.Drawing.Point(3, 4);
            this.DGVInvoice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DGVInvoice.Name = "DGVInvoice";
            this.DGVInvoice.RowHeadersWidth = 51;
            this.DGVInvoice.RowTemplate.Height = 24;
            this.DGVInvoice.Size = new System.Drawing.Size(1123, 380);
            this.DGVInvoice.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel4.Controls.Add(this.PrintSave, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.PrintOnly, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.Save, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.Clear, 0, 3);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(1132, 4);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(347, 380);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // PrintSave
            // 
            this.PrintSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PrintSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrintSave.Location = new System.Drawing.Point(3, 4);
            this.PrintSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PrintSave.Name = "PrintSave";
            this.PrintSave.Size = new System.Drawing.Size(341, 87);
            this.PrintSave.TabIndex = 0;
            this.PrintSave.Text = "Print & Save";
            this.PrintSave.UseVisualStyleBackColor = false;
            // 
            // PrintOnly
            // 
            this.PrintOnly.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PrintOnly.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrintOnly.Location = new System.Drawing.Point(3, 99);
            this.PrintOnly.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PrintOnly.Name = "PrintOnly";
            this.PrintOnly.Size = new System.Drawing.Size(341, 87);
            this.PrintOnly.TabIndex = 1;
            this.PrintOnly.Text = "Print Only";
            this.PrintOnly.UseVisualStyleBackColor = false;
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Save.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Save.Location = new System.Drawing.Point(3, 194);
            this.Save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(341, 87);
            this.Save.TabIndex = 2;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Clear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Clear.Location = new System.Drawing.Point(3, 289);
            this.Clear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(341, 87);
            this.Clear.TabIndex = 3;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.88349F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.1165F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 201F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 372F));
            this.tableLayoutPanel5.Controls.Add(this.TotalDiscount, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.FinalTotal, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.textBox2, 2, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 734);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1482, 70);
            this.tableLayoutPanel5.TabIndex = 4;
            // 
            // TotalDiscount
            // 
            this.TotalDiscount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TotalDiscount.Location = new System.Drawing.Point(911, 4);
            this.TotalDiscount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TotalDiscount.Name = "TotalDiscount";
            this.TotalDiscount.Size = new System.Drawing.Size(195, 27);
            this.TotalDiscount.TabIndex = 0;
            this.TotalDiscount.Text = "Total Discount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(674, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Discount";
            // 
            // FinalTotal
            // 
            this.FinalTotal.AutoSize = true;
            this.FinalTotal.Dock = System.Windows.Forms.DockStyle.Top;
            this.FinalTotal.Location = new System.Drawing.Point(674, 35);
            this.FinalTotal.Name = "FinalTotal";
            this.FinalTotal.Size = new System.Drawing.Size(231, 20);
            this.FinalTotal.TabIndex = 2;
            this.FinalTotal.Text = "Total";
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox2.Location = new System.Drawing.Point(911, 39);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(195, 27);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Total";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(0, 734);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1482, 70);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.AutoScroll = true;
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.10593F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.89407F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 369F));
            this.tableLayoutPanel6.Controls.Add(this.TotalDisco, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.TotalValue, 1, 1);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 734);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1482, 69);
            this.tableLayoutPanel6.TabIndex = 6;
            // 
            // TotalDisco
            // 
            this.TotalDisco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TotalDisco.Location = new System.Drawing.Point(883, 4);
            this.TotalDisco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TotalDisco.Name = "TotalDisco";
            this.TotalDisco.Size = new System.Drawing.Size(226, 27);
            this.TotalDisco.TabIndex = 0;
            this.TotalDisco.Text = "Total Discount";
            // 
            // TotalValue
            // 
            this.TotalValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TotalValue.Location = new System.Drawing.Point(883, 38);
            this.TotalValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TotalValue.Name = "TotalValue";
            this.TotalValue.Size = new System.Drawing.Size(226, 27);
            this.TotalValue.TabIndex = 1;
            this.TotalValue.Text = "Total";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 804);
            this.Controls.Add(this.tableLayoutPanel6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = " QTS Sample Billing System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVInvoice)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxtItemDiscount;
        private System.Windows.Forms.TextBox TxtUnitPrice;
        private System.Windows.Forms.TextBox TxtItemQuantity;
        private System.Windows.Forms.TextBox CustomerName;
        private System.Windows.Forms.TextBox TxtItemCategory;
        private System.Windows.Forms.TextBox TxtItemName;
        private System.Windows.Forms.TextBox TxtItemCode;
        private System.Windows.Forms.TextBox CustomerMobile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox TxtItemSubTotal;
        private System.Windows.Forms.TextBox TxtItemTotal;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.Button NewInvoice;
        private System.Windows.Forms.Button SalesReturn;
        private System.Windows.Forms.Button SavetoDraft;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView DGVInvoice;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button PrintSave;
        private System.Windows.Forms.Button PrintOnly;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox TotalDiscount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FinalTotal;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TextBox TotalDisco;
        private System.Windows.Forms.TextBox TotalValue;
    }
}

