
using System;
using System.Windows.Forms;

namespace QTSSimple_Billing
{
    partial class CustomerForm
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
            this.CustomerData = new System.Windows.Forms.DataGridView();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnDelet = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CustomerTXT = new System.Windows.Forms.TextBox();
            this.ContactTXT = new System.Windows.Forms.TextBox();
            this.EmailTXT = new System.Windows.Forms.TextBox();
            this.CustomerCodeTXT = new System.Windows.Forms.TextBox();
            this.TLPCRUD = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerData)).BeginInit();
            this.TLPCRUD.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomerData
            // 
            this.CustomerData.BackgroundColor = System.Drawing.SystemColors.Control;
            this.CustomerData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerData.Location = new System.Drawing.Point(12, 408);
            this.CustomerData.Name = "CustomerData";
            this.CustomerData.RowHeadersWidth = 51;
            this.CustomerData.RowTemplate.Height = 29;
            this.CustomerData.Size = new System.Drawing.Size(1058, 185);
            this.CustomerData.TabIndex = 0;
            this.CustomerData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerData_CellContentClick);
            // 
            // BtnCreate
            // 
            this.BtnCreate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCreate.Location = new System.Drawing.Point(229, 347);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(125, 37);
            this.BtnCreate.TabIndex = 1;
            this.BtnCreate.Text = "ADD";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSave.Location = new System.Drawing.Point(407, 347);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(125, 37);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.Text = "SAVE";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnDelet
            // 
            this.BtnDelet.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnDelet.Location = new System.Drawing.Point(582, 347);
            this.BtnDelet.Name = "BtnDelet";
            this.BtnDelet.Size = new System.Drawing.Size(125, 37);
            this.BtnDelet.TabIndex = 3;
            this.BtnDelet.Text = "DELET";
            this.BtnDelet.UseVisualStyleBackColor = true;
            this.BtnDelet.Click += new System.EventHandler(this.BtnDelet_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnReset.Location = new System.Drawing.Point(752, 347);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(125, 37);
            this.BtnReset.TabIndex = 4;
            this.BtnReset.Text = "RESET";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(217, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(216, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Contact";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(216, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(216, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "Customer Code";
            // 
            // CustomerTXT
            // 
            this.CustomerTXT.Location = new System.Drawing.Point(474, 23);
            this.CustomerTXT.Name = "CustomerTXT";
            this.CustomerTXT.Size = new System.Drawing.Size(277, 27);
            this.CustomerTXT.TabIndex = 9;
            // 
            // ContactTXT
            // 
            this.ContactTXT.Location = new System.Drawing.Point(474, 116);
            this.ContactTXT.Name = "ContactTXT";
            this.ContactTXT.Size = new System.Drawing.Size(277, 27);
            this.ContactTXT.TabIndex = 10;
            this.ContactTXT.TextChanged += new System.EventHandler(this.ContactTXT_TextChanged);
            // 
            // EmailTXT
            // 
            this.EmailTXT.Location = new System.Drawing.Point(474, 170);
            this.EmailTXT.Name = "EmailTXT";
            this.EmailTXT.Size = new System.Drawing.Size(277, 27);
            this.EmailTXT.TabIndex = 11;
            // 
            // CustomerCodeTXT
            // 
            this.CustomerCodeTXT.Location = new System.Drawing.Point(474, 224);
            this.CustomerCodeTXT.Name = "CustomerCodeTXT";
            this.CustomerCodeTXT.Size = new System.Drawing.Size(277, 27);
            this.CustomerCodeTXT.TabIndex = 12;
            // 
            // TLPCRUD
            // 
            this.TLPCRUD.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TLPCRUD.Controls.Add(this.CustomerTXT);
            this.TLPCRUD.Controls.Add(this.textBox1);
            this.TLPCRUD.Controls.Add(this.label1);
            this.TLPCRUD.Controls.Add(this.label5);
            this.TLPCRUD.Controls.Add(this.ContactTXT);
            this.TLPCRUD.Controls.Add(this.EmailTXT);
            this.TLPCRUD.Controls.Add(this.CustomerCodeTXT);
            this.TLPCRUD.Controls.Add(this.label2);
            this.TLPCRUD.Controls.Add(this.label4);
            this.TLPCRUD.Controls.Add(this.label3);
            this.TLPCRUD.Location = new System.Drawing.Point(12, 12);
            this.TLPCRUD.Name = "TLPCRUD";
            this.TLPCRUD.Size = new System.Drawing.Size(1027, 282);
            this.TLPCRUD.TabIndex = 13;
            this.TLPCRUD.TabStop = false;
            this.TLPCRUD.Text = "FORM";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(474, 67);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 27);
            this.textBox1.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(216, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 27);
            this.label5.TabIndex = 13;
            this.label5.Text = "Address";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(475, 300);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(277, 27);
            this.textBox2.TabIndex = 16;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(363, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 27);
            this.label6.TabIndex = 15;
            this.label6.Text = "Search";
            this.label6.Click += new System.EventHandler(this.label6_KeyUp);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1082, 605);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnDelet);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.CustomerData);
            this.Controls.Add(this.TLPCRUD);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Model";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerData)).EndInit();
            this.TLPCRUD.ResumeLayout(false);
            this.TLPCRUD.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        #endregion

        private System.Windows.Forms.DataGridView CustomerData;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnDelet;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CustomerTXT;
        private System.Windows.Forms.TextBox ContactTXT;
        private System.Windows.Forms.TextBox EmailTXT;
        private System.Windows.Forms.TextBox CustomerCodeTXT;
        private GroupBox TLPCRUD;
        private TextBox textBox2;
        private Label label6;
        private TextBox textBox1;
        private Label label5;
    }
}

