using System;
using System.Windows.Forms;
﻿
namespace QTS_SimpleBilling
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Discount = new System.Windows.Forms.TextBox();
            this.UnitPrice = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.CustomerName = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ItemName = new System.Windows.Forms.TextBox();
            this.ItemCode = new System.Windows.Forms.TextBox();
            this.CustomerMobile = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.SubTotal = new System.Windows.Forms.TextBox();
            this.Total = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.NewInvoice = new System.Windows.Forms.Button();
            this.SalesReturn = new System.Windows.Forms.Button();
            this.SavetoDraft = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LINEID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITEMCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITEMNM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UNITPRC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DISCOUN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUBTOT = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.BtnDeleteItems = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2409, 211);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Discount
            // 
            this.Discount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Discount.Location = new System.Drawing.Point(644, 261);
            this.Discount.Margin = new System.Windows.Forms.Padding(6);
            this.Discount.Name = "Discount";
            this.Discount.Size = new System.Drawing.Size(605, 39);
            this.Discount.TabIndex = 7;
            this.Discount.Text = "Discount";
            // 
            // UnitPrice
            // 
            this.UnitPrice.Location = new System.Drawing.Point(644, 91);
            this.UnitPrice.Margin = new System.Windows.Forms.Padding(6);
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.Size = new System.Drawing.Size(602, 39);
            this.UnitPrice.TabIndex = 6;
            this.UnitPrice.Text = "Unit Price";
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(644, 176);
            this.Quantity.Margin = new System.Windows.Forms.Padding(6);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(602, 39);
            this.Quantity.TabIndex = 5;
            this.Quantity.Text = "Quantity";
            // 
            // CustomerName
            // 
            this.CustomerName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomerName.Location = new System.Drawing.Point(644, 6);
            this.CustomerName.Margin = new System.Windows.Forms.Padding(6);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(605, 39);
            this.CustomerName.TabIndex = 4;
            this.CustomerName.Text = "Customer name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 91);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(622, 39);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Item Category";
            // 
            // ItemName
            // 
            this.ItemName.Location = new System.Drawing.Point(6, 261);
            this.ItemName.Margin = new System.Windows.Forms.Padding(6);
            this.ItemName.Name = "ItemName";
            this.ItemName.Size = new System.Drawing.Size(622, 39);
            this.ItemName.TabIndex = 2;
            this.ItemName.Text = "Item Name";
            // 
            // ItemCode
            // 
            this.ItemCode.Location = new System.Drawing.Point(6, 176);
            this.ItemCode.Margin = new System.Windows.Forms.Padding(6);
            this.ItemCode.Name = "ItemCode";
            this.ItemCode.Size = new System.Drawing.Size(622, 39);
            this.ItemCode.TabIndex = 1;
            this.ItemCode.Text = "Item Code";
            // 
            // CustomerMobile
            // 
            this.CustomerMobile.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.CustomerMobile.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.CustomerMobile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomerMobile.Location = new System.Drawing.Point(6, 6);
            this.CustomerMobile.Margin = new System.Windows.Forms.Padding(6);
            this.CustomerMobile.Name = "CustomerMobile";
            this.CustomerMobile.PlaceholderText = "Enter Customer Mobile Number";
            this.CustomerMobile.Size = new System.Drawing.Size(626, 39);
            this.CustomerMobile.TabIndex = 0;
            this.CustomerMobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CustomerMobile_KeyPress);
            this.CustomerMobile.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CustomerMobile_KeyUp);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.5219F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.61903F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.20829F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.65077F));
            this.tableLayoutPanel1.Controls.Add(this.CustomerMobile, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CustomerName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Discount, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.Address, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.NewInvoice, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.SalesReturn, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.SavetoDraft, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.ItemName, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ItemCode, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Quantity, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.UnitPrice, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 211);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(2409, 341);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.SubTotal, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Total, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1261, 261);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(571, 74);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // SubTotal
            // 
            this.SubTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubTotal.Location = new System.Drawing.Point(6, 6);
            this.SubTotal.Margin = new System.Windows.Forms.Padding(6);
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.Size = new System.Drawing.Size(273, 39);
            this.SubTotal.TabIndex = 0;
            this.SubTotal.Text = "SubTotal";
            // 
            // Total
            // 
            this.Total.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Total.Location = new System.Drawing.Point(291, 6);
            this.Total.Margin = new System.Windows.Forms.Padding(6);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(274, 39);
            this.Total.TabIndex = 1;
            this.Total.Text = "Total";
            // 
            // Address
            // 
            this.Address.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Address.Location = new System.Drawing.Point(1261, 6);
            this.Address.Margin = new System.Windows.Forms.Padding(6);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(571, 39);
            this.Address.TabIndex = 9;
            this.Address.Text = "Address";
            // 
            // NewInvoice
            // 
            this.NewInvoice.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NewInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewInvoice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NewInvoice.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.NewInvoice.Location = new System.Drawing.Point(1844, 6);
            this.NewInvoice.Margin = new System.Windows.Forms.Padding(6);
            this.NewInvoice.Name = "NewInvoice";
            this.NewInvoice.Size = new System.Drawing.Size(559, 73);
            this.NewInvoice.TabIndex = 10;
            this.NewInvoice.Text = "New Invoice";
            this.NewInvoice.UseVisualStyleBackColor = false;
            // 
            // SalesReturn
            // 
            this.SalesReturn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SalesReturn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalesReturn.Location = new System.Drawing.Point(1844, 91);
            this.SalesReturn.Margin = new System.Windows.Forms.Padding(6);
            this.SalesReturn.Name = "SalesReturn";
            this.SalesReturn.Size = new System.Drawing.Size(559, 73);
            this.SalesReturn.TabIndex = 11;
            this.SalesReturn.Text = "Sales Return";
            this.SalesReturn.UseVisualStyleBackColor = false;
            // 
            // SavetoDraft
            // 
            this.SavetoDraft.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SavetoDraft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SavetoDraft.Location = new System.Drawing.Point(1844, 176);
            this.SavetoDraft.Margin = new System.Windows.Forms.Padding(6);
            this.SavetoDraft.Name = "SavetoDraft";
            this.SavetoDraft.Size = new System.Drawing.Size(559, 73);
            this.SavetoDraft.TabIndex = 12;
            this.SavetoDraft.Text = "Save To Draft";
            this.SavetoDraft.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.18343F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.81657F));
            this.tableLayoutPanel3.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 552);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 621F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(2409, 621);
            this.tableLayoutPanel3.TabIndex = 3;
            this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LINEID,
            this.ITEMCD,
            this.ITEMNM,
            this.UNITPRC,
            this.QTY,
            this.DISCOUN,
            this.SUBTOT});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1823, 609);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // LINEID
            // 
            this.LINEID.HeaderText = "LINE ID";
            this.LINEID.MinimumWidth = 6;
            this.LINEID.Name = "LINEID";
            this.LINEID.Width = 125;
            // 
            // ITEMCD
            // 
            this.ITEMCD.HeaderText = "ITEM CODE";
            this.ITEMCD.MinimumWidth = 6;
            this.ITEMCD.Name = "ITEMCD";
            this.ITEMCD.Width = 125;
            // 
            // ITEMNM
            // 
            this.ITEMNM.HeaderText = "ITEM NAME";
            this.ITEMNM.MinimumWidth = 6;
            this.ITEMNM.Name = "ITEMNM";
            this.ITEMNM.Width = 200;
            // 
            // UNITPRC
            // 
            this.UNITPRC.HeaderText = "UNIT PRICE";
            this.UNITPRC.MinimumWidth = 6;
            this.UNITPRC.Name = "UNITPRC";
            this.UNITPRC.Width = 125;
            // 
            // QTY
            // 
            this.QTY.HeaderText = "QTY";
            this.QTY.MinimumWidth = 6;
            this.QTY.Name = "QTY";
            this.QTY.Width = 125;
            // 
            // DISCOUN
            // 
            this.DISCOUN.HeaderText = "DISCOUNT";
            this.DISCOUN.MinimumWidth = 6;
            this.DISCOUN.Name = "DISCOUN";
            this.DISCOUN.Width = 125;
            // 
            // SUBTOT
            // 
            this.SUBTOT.HeaderText = "SUB TOTAL";
            this.SUBTOT.MinimumWidth = 6;
            this.SUBTOT.Name = "SUBTOT";
            this.SUBTOT.Width = 145;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel4.Controls.Add(this.PrintSave, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.PrintOnly, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.Save, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.Clear, 0, 3);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(1841, 6);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(562, 609);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // PrintSave
            // 
            this.PrintSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PrintSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrintSave.Location = new System.Drawing.Point(6, 6);
            this.PrintSave.Margin = new System.Windows.Forms.Padding(6);
            this.PrintSave.Name = "PrintSave";
            this.PrintSave.Size = new System.Drawing.Size(550, 140);
            this.PrintSave.TabIndex = 0;
            this.PrintSave.Text = "Print & Save";
            this.PrintSave.UseVisualStyleBackColor = false;
            // 
            // PrintOnly
            // 
            this.PrintOnly.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PrintOnly.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrintOnly.Location = new System.Drawing.Point(6, 158);
            this.PrintOnly.Margin = new System.Windows.Forms.Padding(6);
            this.PrintOnly.Name = "PrintOnly";
            this.PrintOnly.Size = new System.Drawing.Size(550, 140);
            this.PrintOnly.TabIndex = 1;
            this.PrintOnly.Text = "Print Only";
            this.PrintOnly.UseVisualStyleBackColor = false;
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Save.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Save.Location = new System.Drawing.Point(6, 310);
            this.Save.Margin = new System.Windows.Forms.Padding(6);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(550, 140);
            this.Save.TabIndex = 2;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Clear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Clear.Location = new System.Drawing.Point(6, 462);
            this.Clear.Margin = new System.Windows.Forms.Padding(6);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(550, 141);
            this.Clear.TabIndex = 3;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.88349F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.1165F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 327F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 624F));
            this.tableLayoutPanel5.Controls.Add(this.TotalDiscount, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.FinalTotal, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.textBox2, 2, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 1173);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(2409, 113);
            this.tableLayoutPanel5.TabIndex = 4;
            // 
            // TotalDiscount
            // 
            this.TotalDiscount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TotalDiscount.Location = new System.Drawing.Point(1463, 6);
            this.TotalDiscount.Margin = new System.Windows.Forms.Padding(6);
            this.TotalDiscount.Name = "TotalDiscount";
            this.TotalDiscount.Size = new System.Drawing.Size(315, 39);
            this.TotalDiscount.TabIndex = 0;
            this.TotalDiscount.Text = "Total Discount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(1083, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Discount";
            // 
            // FinalTotal
            // 
            this.FinalTotal.AutoSize = true;
            this.FinalTotal.Dock = System.Windows.Forms.DockStyle.Top;
            this.FinalTotal.Location = new System.Drawing.Point(1083, 56);
            this.FinalTotal.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.FinalTotal.Name = "FinalTotal";
            this.FinalTotal.Size = new System.Drawing.Size(368, 32);
            this.FinalTotal.TabIndex = 2;
            this.FinalTotal.Text = "Total";
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox2.Location = new System.Drawing.Point(1463, 62);
            this.textBox2.Margin = new System.Windows.Forms.Padding(6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(315, 39);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Total";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(0, 1173);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(2409, 113);
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
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 620F));
            this.tableLayoutPanel6.Controls.Add(this.TotalDisco, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.TotalValue, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.BtnDeleteItems, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.textBox3, 2, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 1173);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(2409, 111);
            this.tableLayoutPanel6.TabIndex = 6;
            // 
            // TotalDisco
            // 
            this.TotalDisco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TotalDisco.Location = new System.Drawing.Point(1421, 6);
            this.TotalDisco.Margin = new System.Windows.Forms.Padding(6);
            this.TotalDisco.Name = "TotalDisco";
            this.TotalDisco.Size = new System.Drawing.Size(361, 39);
            this.TotalDisco.TabIndex = 0;
            this.TotalDisco.Text = "Total Discount";
            // 
            // TotalValue
            // 
            this.TotalValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TotalValue.Location = new System.Drawing.Point(1421, 61);
            this.TotalValue.Margin = new System.Windows.Forms.Padding(6);
            this.TotalValue.Name = "TotalValue";
            this.TotalValue.Size = new System.Drawing.Size(361, 39);
            this.TotalValue.TabIndex = 1;
            this.TotalValue.Text = "Total";
            // 
            // BtnDeleteItems
            // 
            this.BtnDeleteItems.Location = new System.Drawing.Point(6, 6);
            this.BtnDeleteItems.Margin = new System.Windows.Forms.Padding(6);
            this.BtnDeleteItems.Name = "BtnDeleteItems";
            this.BtnDeleteItems.Size = new System.Drawing.Size(258, 43);
            this.BtnDeleteItems.TabIndex = 2;
            this.BtnDeleteItems.Text = "Delete";
            this.BtnDeleteItems.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1794, 6);
            this.textBox3.Margin = new System.Windows.Forms.Padding(6);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(518, 39);
            this.textBox3.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2409, 1286);
            this.Controls.Add(this.tableLayoutPanel6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = " QTS Sample Billing System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.ResumeLayout(false);

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void CustomerMobile_KeyUp(object sender, KeyEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void CustomerMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Discount;
        private System.Windows.Forms.TextBox UnitPrice;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.TextBox CustomerName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox ItemName;
        private System.Windows.Forms.TextBox ItemCode;
        private System.Windows.Forms.TextBox CustomerMobile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox SubTotal;
        private System.Windows.Forms.TextBox Total;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.Button NewInvoice;
        private System.Windows.Forms.Button SalesReturn;
        private System.Windows.Forms.Button SavetoDraft;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn LINEID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEMCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEMNM;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNITPRC;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn DISCOUN;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUBTOT;
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
        private System.Windows.Forms.Button BtnDeleteItems;
        private System.Windows.Forms.TextBox textBox3;
    }
}
