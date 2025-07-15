namespace SalesManagementSystem_wf.PL
{
    partial class frmMenageProducts
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
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.grbProductList = new System.Windows.Forms.GroupBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.grbOpp = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSaveInExel = new System.Windows.Forms.Button();
            this.btnDisplayAll = new System.Windows.Forms.Button();
            this.btnDisplayProduct = new System.Windows.Forms.Button();
            this.btnProductPhoto = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.grbProductList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.grbOpp.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(134, 41);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(232, 20);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Enter the word to search about:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(421, 38);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(405, 26);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // grbProductList
            // 
            this.grbProductList.Controls.Add(this.dgvProducts);
            this.grbProductList.Location = new System.Drawing.Point(51, 97);
            this.grbProductList.Name = "grbProductList";
            this.grbProductList.Size = new System.Drawing.Size(981, 521);
            this.grbProductList.TabIndex = 2;
            this.grbProductList.TabStop = false;
            this.grbProductList.Text = "Products list";
            // 
            // dgvProducts
            // 
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(0, 25);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 62;
            this.dgvProducts.RowTemplate.Height = 28;
            this.dgvProducts.Size = new System.Drawing.Size(981, 276);
            this.dgvProducts.TabIndex = 0;
            // 
            // grbOpp
            // 
            this.grbOpp.Controls.Add(this.btnExit);
            this.grbOpp.Controls.Add(this.btnSaveInExel);
            this.grbOpp.Controls.Add(this.btnDisplayAll);
            this.grbOpp.Controls.Add(this.btnDisplayProduct);
            this.grbOpp.Controls.Add(this.btnProductPhoto);
            this.grbOpp.Controls.Add(this.btnUpdateProduct);
            this.grbOpp.Controls.Add(this.btnDeleteProduct);
            this.grbOpp.Controls.Add(this.btnAddProduct);
            this.grbOpp.Location = new System.Drawing.Point(51, 416);
            this.grbOpp.Name = "grbOpp";
            this.grbOpp.Size = new System.Drawing.Size(981, 152);
            this.grbOpp.TabIndex = 1;
            this.grbOpp.TabStop = false;
            this.grbOpp.Text = "Opperations";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(495, 93);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(128, 31);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnSaveInExel
            // 
            this.btnSaveInExel.Location = new System.Drawing.Point(340, 93);
            this.btnSaveInExel.Name = "btnSaveInExel";
            this.btnSaveInExel.Size = new System.Drawing.Size(128, 31);
            this.btnSaveInExel.TabIndex = 6;
            this.btnSaveInExel.Text = "Save in Exel";
            this.btnSaveInExel.UseVisualStyleBackColor = true;
            // 
            // btnDisplayAll
            // 
            this.btnDisplayAll.Location = new System.Drawing.Point(819, 37);
            this.btnDisplayAll.Name = "btnDisplayAll";
            this.btnDisplayAll.Size = new System.Drawing.Size(128, 31);
            this.btnDisplayAll.TabIndex = 5;
            this.btnDisplayAll.Text = "Display all";
            this.btnDisplayAll.UseVisualStyleBackColor = true;
            // 
            // btnDisplayProduct
            // 
            this.btnDisplayProduct.Location = new System.Drawing.Point(647, 37);
            this.btnDisplayProduct.Name = "btnDisplayProduct";
            this.btnDisplayProduct.Size = new System.Drawing.Size(128, 31);
            this.btnDisplayProduct.TabIndex = 4;
            this.btnDisplayProduct.Text = "Display product";
            this.btnDisplayProduct.UseVisualStyleBackColor = true;
            // 
            // btnProductPhoto
            // 
            this.btnProductPhoto.Location = new System.Drawing.Point(495, 37);
            this.btnProductPhoto.Name = "btnProductPhoto";
            this.btnProductPhoto.Size = new System.Drawing.Size(128, 31);
            this.btnProductPhoto.TabIndex = 3;
            this.btnProductPhoto.Text = "Show photo";
            this.btnProductPhoto.UseVisualStyleBackColor = true;
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Location = new System.Drawing.Point(340, 37);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(128, 31);
            this.btnUpdateProduct.TabIndex = 2;
            this.btnUpdateProduct.Text = "Update product";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(185, 37);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(128, 31);
            this.btnDeleteProduct.TabIndex = 1;
            this.btnDeleteProduct.Text = "Delete product";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(44, 37);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(109, 31);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "Add product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // frmMenageProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 672);
            this.Controls.Add(this.grbOpp);
            this.Controls.Add(this.grbProductList);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Name = "frmMenageProducts";
            this.Text = "frmMenageProducts";
            this.grbProductList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.grbOpp.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox grbProductList;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.GroupBox grbOpp;
        private System.Windows.Forms.Button btnProductPhoto;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSaveInExel;
        private System.Windows.Forms.Button btnDisplayAll;
        private System.Windows.Forms.Button btnDisplayProduct;
    }
}