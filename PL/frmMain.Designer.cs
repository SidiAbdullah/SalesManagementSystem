namespace SalesManagementSystem_wf.PL
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ftsm_createBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.ftsm_restoreBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.logputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.newProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageCategoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.manageCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.manageSalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFile,
            this.tsmProducts,
            this.tsmCustomers,
            this.tsmUsers});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(903, 36);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmFile
            // 
            this.tsmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.ftsm_createBackup,
            this.ftsm_restoreBackup,
            this.logputToolStripMenuItem});
            this.tsmFile.Name = "tsmFile";
            this.tsmFile.Size = new System.Drawing.Size(54, 30);
            this.tsmFile.Text = "File";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(236, 34);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // ftsm_createBackup
            // 
            this.ftsm_createBackup.Enabled = false;
            this.ftsm_createBackup.Name = "ftsm_createBackup";
            this.ftsm_createBackup.Size = new System.Drawing.Size(270, 34);
            this.ftsm_createBackup.Text = "Create backup";
            this.ftsm_createBackup.Click += new System.EventHandler(this.ftsm_createBackup_Click);
            // 
            // ftsm_restoreBackup
            // 
            this.ftsm_restoreBackup.Enabled = false;
            this.ftsm_restoreBackup.Name = "ftsm_restoreBackup";
            this.ftsm_restoreBackup.Size = new System.Drawing.Size(236, 34);
            this.ftsm_restoreBackup.Text = "Restore backup";
            // 
            // logputToolStripMenuItem
            // 
            this.logputToolStripMenuItem.Enabled = false;
            this.logputToolStripMenuItem.Name = "logputToolStripMenuItem";
            this.logputToolStripMenuItem.Size = new System.Drawing.Size(236, 34);
            this.logputToolStripMenuItem.Text = "Logout";
            this.logputToolStripMenuItem.Click += new System.EventHandler(this.logputToolStripMenuItem_Click);
            // 
            // tsmProducts
            // 
            this.tsmProducts.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProductToolStripMenuItem,
            this.manageProductsToolStripMenuItem,
            this.manageCategoriesToolStripMenuItem});
            this.tsmProducts.Enabled = false;
            this.tsmProducts.Name = "tsmProducts";
            this.tsmProducts.Size = new System.Drawing.Size(98, 29);
            this.tsmProducts.Text = "Products";
            // 
            // newProductToolStripMenuItem
            // 
            this.newProductToolStripMenuItem.Name = "newProductToolStripMenuItem";
            this.newProductToolStripMenuItem.Size = new System.Drawing.Size(267, 34);
            this.newProductToolStripMenuItem.Text = "Add new product";
            this.newProductToolStripMenuItem.Click += new System.EventHandler(this.newProductToolStripMenuItem_Click);
            // 
            // manageProductsToolStripMenuItem
            // 
            this.manageProductsToolStripMenuItem.Name = "manageProductsToolStripMenuItem";
            this.manageProductsToolStripMenuItem.Size = new System.Drawing.Size(267, 34);
            this.manageProductsToolStripMenuItem.Text = "Manage products";
            this.manageProductsToolStripMenuItem.Click += new System.EventHandler(this.manageProductsToolStripMenuItem_Click);
            // 
            // manageCategoriesToolStripMenuItem
            // 
            this.manageCategoriesToolStripMenuItem.Name = "manageCategoriesToolStripMenuItem";
            this.manageCategoriesToolStripMenuItem.Size = new System.Drawing.Size(267, 34);
            this.manageCategoriesToolStripMenuItem.Text = "Manage Categories";
            this.manageCategoriesToolStripMenuItem.Click += new System.EventHandler(this.manageCategoriesToolStripMenuItem_Click);
            // 
            // tsmCustomers
            // 
            this.tsmCustomers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageCustomersToolStripMenuItem,
            this.toolStripSeparator1,
            this.manageSalesToolStripMenuItem});
            this.tsmCustomers.Enabled = false;
            this.tsmCustomers.Name = "tsmCustomers";
            this.tsmCustomers.Size = new System.Drawing.Size(113, 29);
            this.tsmCustomers.Text = "Customers";
            // 
            // manageCustomersToolStripMenuItem
            // 
            this.manageCustomersToolStripMenuItem.Name = "manageCustomersToolStripMenuItem";
            this.manageCustomersToolStripMenuItem.Size = new System.Drawing.Size(268, 34);
            this.manageCustomersToolStripMenuItem.Text = "Manage Customers";
            this.manageCustomersToolStripMenuItem.Click += new System.EventHandler(this.manageCustomersToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(265, 6);
            // 
            // manageSalesToolStripMenuItem
            // 
            this.manageSalesToolStripMenuItem.Name = "manageSalesToolStripMenuItem";
            this.manageSalesToolStripMenuItem.Size = new System.Drawing.Size(268, 34);
            this.manageSalesToolStripMenuItem.Text = "Manage Sales";
            this.manageSalesToolStripMenuItem.Click += new System.EventHandler(this.manageSalesToolStripMenuItem_Click);
            // 
            // tsmUsers
            // 
            this.tsmUsers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewUserToolStripMenuItem,
            this.manageUsersToolStripMenuItem});
            this.tsmUsers.Enabled = false;
            this.tsmUsers.Name = "tsmUsers";
            this.tsmUsers.Size = new System.Drawing.Size(71, 30);
            this.tsmUsers.Text = "Users";
            // 
            // addNewUserToolStripMenuItem
            // 
            this.addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            this.addNewUserToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.addNewUserToolStripMenuItem.Text = "Add new user";
            this.addNewUserToolStripMenuItem.Click += new System.EventHandler(this.addNewUserToolStripMenuItem_Click);
            // 
            // manageUsersToolStripMenuItem
            // 
            this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.manageUsersToolStripMenuItem.Text = "Manage users";
            this.manageUsersToolStripMenuItem.Click += new System.EventHandler(this.manageUsersToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Sales Management Project";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmFile;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ftsm_createBackup;
        private System.Windows.Forms.ToolStripMenuItem ftsm_restoreBackup;
        private System.Windows.Forms.ToolStripMenuItem logputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmProducts;
        private System.Windows.Forms.ToolStripMenuItem newProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageCategoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmCustomers;
        private System.Windows.Forms.ToolStripMenuItem manageCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem manageSalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem tsmUsers;
    }
}