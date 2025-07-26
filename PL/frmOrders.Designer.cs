namespace SalesManagementSystem_wf.PL
{
    partial class frmOrders
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
            this.grbBillInfos = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblSellDate = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblBillDesc = new System.Windows.Forms.Label();
            this.lblBill = new System.Windows.Forms.Label();
            this.txtBillNumber = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.btnSearchCustomers = new System.Windows.Forms.Button();
            this.ptbCustomer = new System.Windows.Forms.PictureBox();
            this.grbProducts = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSaveSell = new System.Windows.Forms.Button();
            this.btnNewSalle = new System.Windows.Forms.Button();
            this.grbBillInfos.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCustomer)).BeginInit();
            this.grbProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbBillInfos
            // 
            this.grbBillInfos.Controls.Add(this.dateTimePicker1);
            this.grbBillInfos.Controls.Add(this.lblSellDate);
            this.grbBillInfos.Controls.Add(this.textBox1);
            this.grbBillInfos.Controls.Add(this.lblBillDesc);
            this.grbBillInfos.Controls.Add(this.lblBill);
            this.grbBillInfos.Controls.Add(this.txtBillNumber);
            this.grbBillInfos.Location = new System.Drawing.Point(0, 21);
            this.grbBillInfos.Name = "grbBillInfos";
            this.grbBillInfos.Size = new System.Drawing.Size(421, 223);
            this.grbBillInfos.TabIndex = 0;
            this.grbBillInfos.TabStop = false;
            this.grbBillInfos.Text = "Bill Infos";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(143, 158);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(272, 26);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // lblSellDate
            // 
            this.lblSellDate.AutoSize = true;
            this.lblSellDate.Location = new System.Drawing.Point(12, 158);
            this.lblSellDate.Name = "lblSellDate";
            this.lblSellDate.Size = new System.Drawing.Size(82, 20);
            this.lblSellDate.TabIndex = 4;
            this.lblSellDate.Text = "Sell Date :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(143, 87);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(272, 57);
            this.textBox1.TabIndex = 3;
            // 
            // lblBillDesc
            // 
            this.lblBillDesc.AutoSize = true;
            this.lblBillDesc.Location = new System.Drawing.Point(12, 93);
            this.lblBillDesc.Name = "lblBillDesc";
            this.lblBillDesc.Size = new System.Drawing.Size(121, 20);
            this.lblBillDesc.TabIndex = 2;
            this.lblBillDesc.Text = "Bill Description :";
            // 
            // lblBill
            // 
            this.lblBill.AutoSize = true;
            this.lblBill.Location = new System.Drawing.Point(12, 42);
            this.lblBill.Name = "lblBill";
            this.lblBill.Size = new System.Drawing.Size(97, 20);
            this.lblBill.TabIndex = 1;
            this.lblBill.Text = "Bill Number :";
            // 
            // txtBillNumber
            // 
            this.txtBillNumber.Location = new System.Drawing.Point(143, 36);
            this.txtBillNumber.Name = "txtBillNumber";
            this.txtBillNumber.ReadOnly = true;
            this.txtBillNumber.Size = new System.Drawing.Size(272, 26);
            this.txtBillNumber.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.lblEmail);
            this.groupBox2.Controls.Add(this.txtPhone);
            this.groupBox2.Controls.Add(this.lblPhone);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.lblName);
            this.groupBox2.Controls.Add(this.txtCustomerID);
            this.groupBox2.Controls.Add(this.lblCustomerID);
            this.groupBox2.Controls.Add(this.btnSearchCustomers);
            this.groupBox2.Controls.Add(this.ptbCustomer);
            this.groupBox2.Location = new System.Drawing.Point(436, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(513, 223);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer Infos";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(130, 158);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(228, 26);
            this.txtEmail.TabIndex = 12;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 164);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(56, 20);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Email :";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(130, 118);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(228, 26);
            this.txtPhone.TabIndex = 10;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(6, 124);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(63, 20);
            this.lblPhone.TabIndex = 9;
            this.lblPhone.Text = "Phone :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(130, 68);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(228, 26);
            this.txtName.TabIndex = 8;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 74);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 20);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Name :";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(130, 24);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(147, 26);
            this.txtCustomerID.TabIndex = 6;
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(6, 27);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(107, 20);
            this.lblCustomerID.TabIndex = 6;
            this.lblCustomerID.Text = "Customer ID :";
            // 
            // btnSearchCustomers
            // 
            this.btnSearchCustomers.Location = new System.Drawing.Point(283, 19);
            this.btnSearchCustomers.Name = "btnSearchCustomers";
            this.btnSearchCustomers.Size = new System.Drawing.Size(75, 37);
            this.btnSearchCustomers.TabIndex = 1;
            this.btnSearchCustomers.Text = "Search";
            this.btnSearchCustomers.UseVisualStyleBackColor = true;
            this.btnSearchCustomers.Click += new System.EventHandler(this.btnSearchCustomers_Click);
            // 
            // ptbCustomer
            // 
            this.ptbCustomer.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ptbCustomer.Location = new System.Drawing.Point(364, 10);
            this.ptbCustomer.Name = "ptbCustomer";
            this.ptbCustomer.Size = new System.Drawing.Size(143, 213);
            this.ptbCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbCustomer.TabIndex = 0;
            this.ptbCustomer.TabStop = false;
            // 
            // grbProducts
            // 
            this.grbProducts.Controls.Add(this.dataGridView1);
            this.grbProducts.Location = new System.Drawing.Point(0, 285);
            this.grbProducts.Name = "grbProducts";
            this.grbProducts.Size = new System.Drawing.Size(949, 230);
            this.grbProducts.TabIndex = 2;
            this.grbProducts.TabStop = false;
            this.grbProducts.Text = "Products";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(949, 187);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(719, 531);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(228, 26);
            this.textBox4.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(648, 534);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Sum :";
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(12, 521);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(138, 37);
            this.btnDeleteProduct.TabIndex = 13;
            this.btnDeleteProduct.Text = "Delete Product";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(593, 620);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 37);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnSaveSell
            // 
            this.btnSaveSell.Enabled = false;
            this.btnSaveSell.Location = new System.Drawing.Point(442, 620);
            this.btnSaveSell.Name = "btnSaveSell";
            this.btnSaveSell.Size = new System.Drawing.Size(94, 37);
            this.btnSaveSell.TabIndex = 16;
            this.btnSaveSell.Text = "Save Sell";
            this.btnSaveSell.UseVisualStyleBackColor = true;
            // 
            // btnNewSalle
            // 
            this.btnNewSalle.Location = new System.Drawing.Point(291, 620);
            this.btnNewSalle.Name = "btnNewSalle";
            this.btnNewSalle.Size = new System.Drawing.Size(94, 37);
            this.btnNewSalle.TabIndex = 17;
            this.btnNewSalle.Text = "New Sale";
            this.btnNewSalle.UseVisualStyleBackColor = true;
            this.btnNewSalle.Click += new System.EventHandler(this.btnNewSalle_Click);
            // 
            // frmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 687);
            this.Controls.Add(this.btnNewSalle);
            this.Controls.Add(this.btnSaveSell);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.grbProducts);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grbBillInfos);
            this.Name = "frmOrders";
            this.Text = "frmOrders";
            this.grbBillInfos.ResumeLayout(false);
            this.grbBillInfos.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCustomer)).EndInit();
            this.grbProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbBillInfos;
        private System.Windows.Forms.Label lblBill;
        private System.Windows.Forms.TextBox txtBillNumber;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox ptbCustomer;
        private System.Windows.Forms.Label lblSellDate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblBillDesc;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnSearchCustomers;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox grbProducts;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSaveSell;
        private System.Windows.Forms.Button btnNewSalle;
    }
}