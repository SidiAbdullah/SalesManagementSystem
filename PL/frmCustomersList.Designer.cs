namespace SalesManagementSystem_wf.PL
{
    partial class frmCustomersList
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
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.grbCustomersList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // grbCustomersList
            // 
            this.grbCustomersList.Controls.Add(this.dgvCustomers);
            this.grbCustomersList.Location = new System.Drawing.Point(12, 39);
            this.grbCustomersList.Name = "grbCustomersList";
            this.grbCustomersList.Size = new System.Drawing.Size(758, 352);
            this.grbCustomersList.TabIndex = 0;
            this.grbCustomersList.TabStop = false;
            this.grbCustomersList.Text = "Customers List";
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(0, 43);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowHeadersWidth = 62;
            this.dgvCustomers.RowTemplate.Height = 28;
            this.dgvCustomers.Size = new System.Drawing.Size(758, 309);
            this.dgvCustomers.TabIndex = 0;
            this.dgvCustomers.DoubleClick += new System.EventHandler(this.dgvCustomers_DoubleClick);
            // 
            // frmCustomersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 695);
            this.Controls.Add(this.grbCustomersList);
            this.Name = "frmCustomersList";
            this.Text = "frmCustomersList";
            this.grbCustomersList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.GroupBox grbCustomersList;
        public System.Windows.Forms.DataGridView dgvCustomers;
    }
}