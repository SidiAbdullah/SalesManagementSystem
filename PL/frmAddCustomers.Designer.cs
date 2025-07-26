namespace SalesManagementSystem_wf.PL
{
    partial class frmAddCustomers
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
            this.grbCustomersList = new System.Windows.Forms.GroupBox();
            this.lblSearchForCustomer = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.grbCustomers = new System.Windows.Forms.GroupBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.ptbImage = new System.Windows.Forms.PictureBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.grbCustomersList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.grbCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // grbCustomersList
            // 
            this.grbCustomersList.Controls.Add(this.lblSearchForCustomer);
            this.grbCustomersList.Controls.Add(this.txtSearch);
            this.grbCustomersList.Controls.Add(this.dgvCustomers);
            this.grbCustomersList.Location = new System.Drawing.Point(583, 12);
            this.grbCustomersList.Name = "grbCustomersList";
            this.grbCustomersList.Size = new System.Drawing.Size(717, 290);
            this.grbCustomersList.TabIndex = 0;
            this.grbCustomersList.TabStop = false;
            this.grbCustomersList.Text = "Cutomers List";
            // 
            // lblSearchForCustomer
            // 
            this.lblSearchForCustomer.AutoSize = true;
            this.lblSearchForCustomer.Location = new System.Drawing.Point(29, 28);
            this.lblSearchForCustomer.Name = "lblSearchForCustomer";
            this.lblSearchForCustomer.Size = new System.Drawing.Size(169, 20);
            this.lblSearchForCustomer.TabIndex = 10;
            this.lblSearchForCustomer.Text = "Search For Customer :";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(213, 28);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(335, 26);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(3, 65);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowHeadersWidth = 62;
            this.dgvCustomers.RowTemplate.Height = 28;
            this.dgvCustomers.Size = new System.Drawing.Size(714, 225);
            this.dgvCustomers.TabIndex = 0;
            this.dgvCustomers.DoubleClick += new System.EventHandler(this.dgvCustomers_DoubleClick);
            // 
            // grbCustomers
            // 
            this.grbCustomers.Controls.Add(this.lblPosition);
            this.grbCustomers.Controls.Add(this.btnLast);
            this.grbCustomers.Controls.Add(this.btnNext);
            this.grbCustomers.Controls.Add(this.btnPrevious);
            this.grbCustomers.Controls.Add(this.btnFirst);
            this.grbCustomers.Controls.Add(this.btnExit);
            this.grbCustomers.Controls.Add(this.btnAdd);
            this.grbCustomers.Controls.Add(this.btnUpdate);
            this.grbCustomers.Controls.Add(this.btnDelete);
            this.grbCustomers.Controls.Add(this.btnNew);
            this.grbCustomers.Controls.Add(this.ptbImage);
            this.grbCustomers.Controls.Add(this.txtEmail);
            this.grbCustomers.Controls.Add(this.lblEmail);
            this.grbCustomers.Controls.Add(this.label1);
            this.grbCustomers.Controls.Add(this.txtPhone);
            this.grbCustomers.Controls.Add(this.lblPhone);
            this.grbCustomers.Controls.Add(this.txtLastName);
            this.grbCustomers.Controls.Add(this.lblLastName);
            this.grbCustomers.Controls.Add(this.txtFirstName);
            this.grbCustomers.Controls.Add(this.lblFirstName);
            this.grbCustomers.Location = new System.Drawing.Point(12, 12);
            this.grbCustomers.Name = "grbCustomers";
            this.grbCustomers.Size = new System.Drawing.Size(565, 290);
            this.grbCustomers.TabIndex = 1;
            this.grbCustomers.TabStop = false;
            this.grbCustomers.Text = "Customers Infos";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(174, 200);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(27, 20);
            this.lblPosition.TabIndex = 29;
            this.lblPosition.Text = "??";
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(298, 193);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(49, 34);
            this.btnLast.TabIndex = 28;
            this.btnLast.Text = ">>|";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(225, 193);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(49, 34);
            this.btnNext.TabIndex = 27;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(101, 193);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(49, 34);
            this.btnPrevious.TabIndex = 26;
            this.btnPrevious.Text = "<<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(28, 193);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(49, 34);
            this.btnFirst.TabIndex = 25;
            this.btnFirst.Text = "|<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(482, 246);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 34);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(140, 246);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 34);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(254, 246);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 34);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(368, 246);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 34);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(26, 246);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 34);
            this.btnNew.TabIndex = 20;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // ptbImage
            // 
            this.ptbImage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ptbImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbImage.Location = new System.Drawing.Point(371, 47);
            this.ptbImage.Name = "ptbImage";
            this.ptbImage.Size = new System.Drawing.Size(188, 180);
            this.ptbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbImage.TabIndex = 9;
            this.ptbImage.TabStop = false;
            this.ptbImage.Click += new System.EventHandler(this.ptbImage_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(135, 161);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(211, 26);
            this.txtEmail.TabIndex = 8;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(25, 161);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Click and select image";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(135, 123);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(211, 26);
            this.txtPhone.TabIndex = 5;
            this.txtPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPhone_KeyDown);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(25, 123);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(55, 20);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Phone";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(135, 83);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(211, 26);
            this.txtLastName.TabIndex = 3;
            this.txtLastName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLastName_KeyDown);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(25, 85);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(86, 20);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(135, 44);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(211, 26);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFirstName_KeyDown);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(25, 47);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(86, 20);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // frmAddCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 320);
            this.Controls.Add(this.grbCustomers);
            this.Controls.Add(this.grbCustomersList);
            this.Name = "frmAddCustomers";
            this.Text = "frmAddCustomers";
            this.grbCustomersList.ResumeLayout(false);
            this.grbCustomersList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.grbCustomers.ResumeLayout(false);
            this.grbCustomers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbCustomersList;
        private System.Windows.Forms.GroupBox grbCustomers;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.PictureBox ptbImage;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSearchForCustomer;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
    }
}