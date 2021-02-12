
namespace QTS_SimpleBilling.Forms.Master_Forms
{
    partial class CustomerForm
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
            this.TxtSearchCustomers = new System.Windows.Forms.TextBox();
            this.TBLFilter = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TxtCusAddress = new System.Windows.Forms.TextBox();
            this.TxtCusEmail = new System.Windows.Forms.TextBox();
            this.TxtCusContact = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.TxtCusName = new System.Windows.Forms.TextBox();
            this.TLPCusCRUD = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DGVCustomer = new System.Windows.Forms.DataGridView();
            this.TBLFilter.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.TLPCusCRUD.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtSearchCustomers
            // 
            this.TxtSearchCustomers.BackColor = System.Drawing.Color.White;
            this.TxtSearchCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtSearchCustomers.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtSearchCustomers.Location = new System.Drawing.Point(246, 3);
            this.TxtSearchCustomers.Name = "TxtSearchCustomers";
            this.TxtSearchCustomers.Size = new System.Drawing.Size(562, 25);
            this.TxtSearchCustomers.TabIndex = 1;
            this.TxtSearchCustomers.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtSearchCustomers_KeyUp);
            // 
            // TBLFilter
            // 
            this.TBLFilter.ColumnCount = 2;
            this.TBLFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.TBLFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.TBLFilter.Controls.Add(this.label3, 0, 0);
            this.TBLFilter.Controls.Add(this.TxtSearchCustomers, 1, 0);
            this.TBLFilter.Location = new System.Drawing.Point(60, 159);
            this.TBLFilter.Name = "TBLFilter";
            this.TBLFilter.RowCount = 1;
            this.TBLFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TBLFilter.Size = new System.Drawing.Size(811, 30);
            this.TBLFilter.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(183, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Search";
            // 
            // BtnDelete
            // 
            this.BtnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnDelete.Location = new System.Drawing.Point(3, 75);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(214, 30);
            this.BtnDelete.TabIndex = 16;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSave.Location = new System.Drawing.Point(3, 111);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(214, 30);
            this.BtnSave.TabIndex = 17;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TxtCusAddress
            // 
            this.TxtCusAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtCusAddress.Location = new System.Drawing.Point(160, 111);
            this.TxtCusAddress.Name = "TxtCusAddress";
            this.TxtCusAddress.Size = new System.Drawing.Size(439, 23);
            this.TxtCusAddress.TabIndex = 11;
            // 
            // TxtCusEmail
            // 
            this.TxtCusEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtCusEmail.Location = new System.Drawing.Point(160, 75);
            this.TxtCusEmail.Name = "TxtCusEmail";
            this.TxtCusEmail.Size = new System.Drawing.Size(439, 23);
            this.TxtCusEmail.TabIndex = 10;
            // 
            // TxtCusContact
            // 
            this.TxtCusContact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtCusContact.Location = new System.Drawing.Point(160, 39);
            this.TxtCusContact.Name = "TxtCusContact";
            this.TxtCusContact.Size = new System.Drawing.Size(439, 23);
            this.TxtCusContact.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Right;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(106, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 36);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(91, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contact";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(30, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(88, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 36);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address";
            // 
            // BtnCreate
            // 
            this.BtnCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCreate.Location = new System.Drawing.Point(3, 3);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(214, 30);
            this.BtnCreate.TabIndex = 14;
            this.BtnCreate.Text = "Add";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnReset.Location = new System.Drawing.Point(3, 39);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(214, 30);
            this.BtnReset.TabIndex = 15;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.BtnCreate, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.BtnReset, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.BtnDelete, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.BtnSave, 0, 3);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(611, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 4;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(220, 144);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // TxtCusName
            // 
            this.TxtCusName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtCusName.Location = new System.Drawing.Point(160, 3);
            this.TxtCusName.Name = "TxtCusName";
            this.TxtCusName.Size = new System.Drawing.Size(439, 23);
            this.TxtCusName.TabIndex = 8;
            // 
            // TLPCusCRUD
            // 
            this.TLPCusCRUD.ColumnCount = 2;
            this.TLPCusCRUD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.68932F));
            this.TLPCusCRUD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.91262F));
            this.TLPCusCRUD.Controls.Add(this.TxtCusAddress, 1, 3);
            this.TLPCusCRUD.Controls.Add(this.TxtCusEmail, 1, 2);
            this.TLPCusCRUD.Controls.Add(this.TxtCusContact, 1, 1);
            this.TLPCusCRUD.Controls.Add(this.label5, 0, 2);
            this.TLPCusCRUD.Controls.Add(this.label2, 0, 1);
            this.TLPCusCRUD.Controls.Add(this.label1, 0, 0);
            this.TLPCusCRUD.Controls.Add(this.label4, 0, 3);
            this.TLPCusCRUD.Controls.Add(this.TxtCusName, 1, 0);
            this.TLPCusCRUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPCusCRUD.Location = new System.Drawing.Point(3, 3);
            this.TLPCusCRUD.Name = "TLPCusCRUD";
            this.TLPCusCRUD.RowCount = 4;
            this.TLPCusCRUD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.TLPCusCRUD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.TLPCusCRUD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.TLPCusCRUD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.TLPCusCRUD.Size = new System.Drawing.Size(602, 144);
            this.TLPCusCRUD.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.9963F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.0037F));
            this.tableLayoutPanel4.Controls.Add(this.TLPCusCRUD, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(60, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(834, 150);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.Controls.Add(this.DGVCustomer, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TBLFilter, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(955, 520);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // DGVCustomer
            // 
            this.DGVCustomer.AllowUserToAddRows = false;
            this.DGVCustomer.AllowUserToDeleteRows = false;
            this.DGVCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVCustomer.BackgroundColor = System.Drawing.Color.White;
            this.DGVCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVCustomer.Location = new System.Drawing.Point(60, 195);
            this.DGVCustomer.Name = "DGVCustomer";
            this.DGVCustomer.ReadOnly = true;
            this.DGVCustomer.RowTemplate.Height = 25;
            this.DGVCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVCustomer.Size = new System.Drawing.Size(834, 254);
            this.DGVCustomer.TabIndex = 0;
            this.DGVCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCustomer_CellClick);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 520);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.TBLFilter.ResumeLayout(false);
            this.TBLFilter.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.TLPCusCRUD.ResumeLayout(false);
            this.TLPCusCRUD.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtSearchCustomers;
        private System.Windows.Forms.TableLayoutPanel TBLFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TextBox TxtCusAddress;
        private System.Windows.Forms.TextBox TxtCusEmail;
        private System.Windows.Forms.TextBox TxtCusContact;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox TxtCusName;
        private System.Windows.Forms.TableLayoutPanel TLPCusCRUD;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView DGVCustomer;
    }
}