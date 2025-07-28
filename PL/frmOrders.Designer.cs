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
            this.components = new System.ComponentModel.Container();
            this.grbBillInfos = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSellerName = new System.Windows.Forms.TextBox();
            this.tdpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.lblSellDate = new System.Windows.Forms.Label();
            this.txtOrderDesc = new System.Windows.Forms.TextBox();
            this.lblBillDesc = new System.Windows.Forms.Label();
            this.lblBill = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
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
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteCurrentRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAllRowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtFinalPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrQuantity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnProductsList = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPricesSum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSaveSell = new System.Windows.Forms.Button();
            this.btnNewSalle = new System.Windows.Forms.Button();
            this.grbBillInfos.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCustomer)).BeginInit();
            this.grbProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbBillInfos
            // 
            this.grbBillInfos.Controls.Add(this.label10);
            this.grbBillInfos.Controls.Add(this.txtSellerName);
            this.grbBillInfos.Controls.Add(this.tdpOrderDate);
            this.grbBillInfos.Controls.Add(this.lblSellDate);
            this.grbBillInfos.Controls.Add(this.txtOrderDesc);
            this.grbBillInfos.Controls.Add(this.lblBillDesc);
            this.grbBillInfos.Controls.Add(this.lblBill);
            this.grbBillInfos.Controls.Add(this.txtOrderID);
            this.grbBillInfos.Location = new System.Drawing.Point(0, 21);
            this.grbBillInfos.Name = "grbBillInfos";
            this.grbBillInfos.Size = new System.Drawing.Size(480, 246);
            this.grbBillInfos.TabIndex = 0;
            this.grbBillInfos.TabStop = false;
            this.grbBillInfos.Text = "Bill Infos";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 204);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "Seller Name :";
            // 
            // txtSellerName
            // 
            this.txtSellerName.Location = new System.Drawing.Point(160, 201);
            this.txtSellerName.Name = "txtSellerName";
            this.txtSellerName.ReadOnly = true;
            this.txtSellerName.Size = new System.Drawing.Size(314, 26);
            this.txtSellerName.TabIndex = 6;
            // 
            // tdpOrderDate
            // 
            this.tdpOrderDate.Location = new System.Drawing.Point(160, 157);
            this.tdpOrderDate.Name = "tdpOrderDate";
            this.tdpOrderDate.Size = new System.Drawing.Size(314, 26);
            this.tdpOrderDate.TabIndex = 5;
            // 
            // lblSellDate
            // 
            this.lblSellDate.AutoSize = true;
            this.lblSellDate.Location = new System.Drawing.Point(15, 162);
            this.lblSellDate.Name = "lblSellDate";
            this.lblSellDate.Size = new System.Drawing.Size(82, 20);
            this.lblSellDate.TabIndex = 4;
            this.lblSellDate.Text = "Sell Date :";
            // 
            // txtOrderDesc
            // 
            this.txtOrderDesc.Location = new System.Drawing.Point(160, 87);
            this.txtOrderDesc.Multiline = true;
            this.txtOrderDesc.Name = "txtOrderDesc";
            this.txtOrderDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOrderDesc.Size = new System.Drawing.Size(314, 57);
            this.txtOrderDesc.TabIndex = 3;
            // 
            // lblBillDesc
            // 
            this.lblBillDesc.AutoSize = true;
            this.lblBillDesc.Location = new System.Drawing.Point(12, 100);
            this.lblBillDesc.Name = "lblBillDesc";
            this.lblBillDesc.Size = new System.Drawing.Size(141, 20);
            this.lblBillDesc.TabIndex = 2;
            this.lblBillDesc.Text = "Order Description :";
            // 
            // lblBill
            // 
            this.lblBill.AutoSize = true;
            this.lblBill.Location = new System.Drawing.Point(17, 37);
            this.lblBill.Name = "lblBill";
            this.lblBill.Size = new System.Drawing.Size(78, 20);
            this.lblBill.TabIndex = 1;
            this.lblBill.Text = "Order ID :";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(160, 34);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.ReadOnly = true;
            this.txtOrderID.Size = new System.Drawing.Size(314, 26);
            this.txtOrderID.TabIndex = 0;
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
            this.groupBox2.Location = new System.Drawing.Point(511, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(568, 246);
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
            this.ptbCustomer.Size = new System.Drawing.Size(198, 230);
            this.ptbCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbCustomer.TabIndex = 0;
            this.ptbCustomer.TabStop = false;
            // 
            // grbProducts
            // 
            this.grbProducts.Controls.Add(this.dgvProducts);
            this.grbProducts.Controls.Add(this.txtFinalPrice);
            this.grbProducts.Controls.Add(this.label9);
            this.grbProducts.Controls.Add(this.txtDiscount);
            this.grbProducts.Controls.Add(this.label8);
            this.grbProducts.Controls.Add(this.txtTotalPrice);
            this.grbProducts.Controls.Add(this.label7);
            this.grbProducts.Controls.Add(this.txtPrQuantity);
            this.grbProducts.Controls.Add(this.label6);
            this.grbProducts.Controls.Add(this.txtPrPrice);
            this.grbProducts.Controls.Add(this.label5);
            this.grbProducts.Controls.Add(this.txtPrName);
            this.grbProducts.Controls.Add(this.label4);
            this.grbProducts.Controls.Add(this.txtPrID);
            this.grbProducts.Controls.Add(this.label3);
            this.grbProducts.Controls.Add(this.btnProductsList);
            this.grbProducts.Controls.Add(this.label2);
            this.grbProducts.Location = new System.Drawing.Point(0, 285);
            this.grbProducts.Name = "grbProducts";
            this.grbProducts.Size = new System.Drawing.Size(1079, 270);
            this.grbProducts.TabIndex = 2;
            this.grbProducts.TabStop = false;
            this.grbProducts.Text = "Products";
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvProducts.Location = new System.Drawing.Point(45, 108);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersWidth = 62;
            this.dgvProducts.RowTemplate.Height = 28;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(992, 145);
            this.dgvProducts.TabIndex = 27;
            this.dgvProducts.DoubleClick += new System.EventHandler(this.dgvProducts_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.toolStripSeparator1,
            this.deleteCurrentRowToolStripMenuItem,
            this.deleteAllRowsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(237, 106);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(236, 32);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(233, 6);
            // 
            // deleteCurrentRowToolStripMenuItem
            // 
            this.deleteCurrentRowToolStripMenuItem.Name = "deleteCurrentRowToolStripMenuItem";
            this.deleteCurrentRowToolStripMenuItem.Size = new System.Drawing.Size(236, 32);
            this.deleteCurrentRowToolStripMenuItem.Text = "Delete Current Row";
            this.deleteCurrentRowToolStripMenuItem.Click += new System.EventHandler(this.deleteCurrentRowToolStripMenuItem_Click);
            // 
            // deleteAllRowsToolStripMenuItem
            // 
            this.deleteAllRowsToolStripMenuItem.Name = "deleteAllRowsToolStripMenuItem";
            this.deleteAllRowsToolStripMenuItem.Size = new System.Drawing.Size(236, 32);
            this.deleteAllRowsToolStripMenuItem.Text = "Delete All Rows";
            this.deleteAllRowsToolStripMenuItem.Click += new System.EventHandler(this.deleteAllRowsToolStripMenuItem_Click);
            // 
            // txtFinalPrice
            // 
            this.txtFinalPrice.Location = new System.Drawing.Point(887, 74);
            this.txtFinalPrice.Name = "txtFinalPrice";
            this.txtFinalPrice.ReadOnly = true;
            this.txtFinalPrice.Size = new System.Drawing.Size(148, 26);
            this.txtFinalPrice.TabIndex = 25;
            this.txtFinalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(887, 42);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(3);
            this.label9.Size = new System.Drawing.Size(148, 30);
            this.label9.TabIndex = 26;
            this.label9.Text = "Final Price";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(790, 74);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(95, 26);
            this.txtDiscount.TabIndex = 23;
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            this.txtDiscount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDiscount_KeyDown);
            this.txtDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscount_KeyPress);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(790, 42);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(3);
            this.label8.Size = new System.Drawing.Size(95, 30);
            this.label8.TabIndex = 24;
            this.label8.Text = "Discount";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(693, 74);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(95, 26);
            this.txtTotalPrice.TabIndex = 21;
            this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(693, 42);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(3);
            this.label7.Size = new System.Drawing.Size(95, 30);
            this.label7.TabIndex = 22;
            this.label7.Text = "Total Price";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPrQuantity
            // 
            this.txtPrQuantity.Location = new System.Drawing.Point(590, 74);
            this.txtPrQuantity.Name = "txtPrQuantity";
            this.txtPrQuantity.Size = new System.Drawing.Size(101, 26);
            this.txtPrQuantity.TabIndex = 19;
            this.txtPrQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrQuantity.TextChanged += new System.EventHandler(this.txtPrQuantity_TextChanged);
            this.txtPrQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrQuantity_KeyDown);
            this.txtPrQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrQuantity_KeyPress);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(590, 42);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(3);
            this.label6.Size = new System.Drawing.Size(101, 30);
            this.label6.TabIndex = 20;
            this.label6.Text = "Quantity";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPrPrice
            // 
            this.txtPrPrice.Location = new System.Drawing.Point(487, 74);
            this.txtPrPrice.Name = "txtPrPrice";
            this.txtPrPrice.ReadOnly = true;
            this.txtPrPrice.Size = new System.Drawing.Size(101, 26);
            this.txtPrPrice.TabIndex = 17;
            this.txtPrPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(487, 42);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(3);
            this.label5.Size = new System.Drawing.Size(101, 30);
            this.label5.TabIndex = 18;
            this.label5.Text = "Price";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPrName
            // 
            this.txtPrName.Location = new System.Drawing.Point(238, 74);
            this.txtPrName.Name = "txtPrName";
            this.txtPrName.ReadOnly = true;
            this.txtPrName.Size = new System.Drawing.Size(247, 26);
            this.txtPrName.TabIndex = 15;
            this.txtPrName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(238, 42);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(3);
            this.label4.Size = new System.Drawing.Size(247, 30);
            this.label4.TabIndex = 16;
            this.label4.Text = "Product Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPrID
            // 
            this.txtPrID.Location = new System.Drawing.Point(131, 74);
            this.txtPrID.Name = "txtPrID";
            this.txtPrID.ReadOnly = true;
            this.txtPrID.Size = new System.Drawing.Size(105, 26);
            this.txtPrID.TabIndex = 13;
            this.txtPrID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(131, 42);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(3);
            this.label3.Size = new System.Drawing.Size(105, 30);
            this.label3.TabIndex = 14;
            this.label3.Text = "Product ID";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnProductsList
            // 
            this.btnProductsList.Location = new System.Drawing.Point(45, 71);
            this.btnProductsList.Name = "btnProductsList";
            this.btnProductsList.Size = new System.Drawing.Size(85, 32);
            this.btnProductsList.TabIndex = 13;
            this.btnProductsList.Text = "Click";
            this.btnProductsList.UseVisualStyleBackColor = true;
            this.btnProductsList.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(46, 42);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(3);
            this.label2.Size = new System.Drawing.Size(83, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Search";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPricesSum
            // 
            this.txtPricesSum.Location = new System.Drawing.Point(869, 581);
            this.txtPricesSum.Name = "txtPricesSum";
            this.txtPricesSum.Size = new System.Drawing.Size(168, 26);
            this.txtPricesSum.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(800, 581);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Sum :";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(318, 581);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 37);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSaveSell
            // 
            this.btnSaveSell.Enabled = false;
            this.btnSaveSell.Location = new System.Drawing.Point(180, 581);
            this.btnSaveSell.Name = "btnSaveSell";
            this.btnSaveSell.Size = new System.Drawing.Size(94, 37);
            this.btnSaveSell.TabIndex = 16;
            this.btnSaveSell.Text = "Save Sell";
            this.btnSaveSell.UseVisualStyleBackColor = true;
            this.btnSaveSell.Click += new System.EventHandler(this.btnSaveSell_Click);
            // 
            // btnNewSalle
            // 
            this.btnNewSalle.Location = new System.Drawing.Point(42, 581);
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
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1083, 687);
            this.Controls.Add(this.btnNewSalle);
            this.Controls.Add(this.btnSaveSell);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPricesSum);
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
            this.grbProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbBillInfos;
        private System.Windows.Forms.Label lblBill;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox ptbCustomer;
        private System.Windows.Forms.Label lblSellDate;
        private System.Windows.Forms.TextBox txtOrderDesc;
        private System.Windows.Forms.Label lblBillDesc;
        private System.Windows.Forms.DateTimePicker tdpOrderDate;
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
        private System.Windows.Forms.TextBox txtPricesSum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSaveSell;
        private System.Windows.Forms.Button btnNewSalle;
        private System.Windows.Forms.Button btnProductsList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrID;
        private System.Windows.Forms.TextBox txtPrPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrQuantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFinalPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem deleteCurrentRowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAllRowsToolStripMenuItem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSellerName;
    }
}