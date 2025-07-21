namespace SalesManagementSystem_wf.PL
{
    partial class frmMenageCategories
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
            this.grbCategories = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCategoryDesc = new System.Windows.Forms.Label();
            this.lblCategoryID = new System.Windows.Forms.Label();
            this.grbCategorisList = new System.Windows.Forms.GroupBox();
            this.dgvCategories = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.btnUpdateCategory = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnNewCategory = new System.Windows.Forms.Button();
            this.btnMoveLeft = new System.Windows.Forms.Button();
            this.btnToLeft = new System.Windows.Forms.Button();
            this.btnMid = new System.Windows.Forms.Button();
            this.btnToRight = new System.Windows.Forms.Button();
            this.btnMoveRight = new System.Windows.Forms.Button();
            this.grbCategories.SuspendLayout();
            this.grbCategorisList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // grbCategories
            // 
            this.grbCategories.Controls.Add(this.btnMoveRight);
            this.grbCategories.Controls.Add(this.btnToRight);
            this.grbCategories.Controls.Add(this.btnMid);
            this.grbCategories.Controls.Add(this.btnToLeft);
            this.grbCategories.Controls.Add(this.btnMoveLeft);
            this.grbCategories.Controls.Add(this.btnExit);
            this.grbCategories.Controls.Add(this.btnAddCategory);
            this.grbCategories.Controls.Add(this.btnUpdateCategory);
            this.grbCategories.Controls.Add(this.btnDeleteCategory);
            this.grbCategories.Controls.Add(this.btnNewCategory);
            this.grbCategories.Controls.Add(this.textBox2);
            this.grbCategories.Controls.Add(this.textBox1);
            this.grbCategories.Controls.Add(this.lblCategoryDesc);
            this.grbCategories.Controls.Add(this.lblCategoryID);
            this.grbCategories.Location = new System.Drawing.Point(34, 29);
            this.grbCategories.Name = "grbCategories";
            this.grbCategories.Size = new System.Drawing.Size(661, 324);
            this.grbCategories.TabIndex = 0;
            this.grbCategories.TabStop = false;
            this.grbCategories.Text = "Categories Infos :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(241, 99);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(376, 96);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(241, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(128, 26);
            this.textBox1.TabIndex = 2;
            // 
            // lblCategoryDesc
            // 
            this.lblCategoryDesc.AutoSize = true;
            this.lblCategoryDesc.Location = new System.Drawing.Point(53, 102);
            this.lblCategoryDesc.Name = "lblCategoryDesc";
            this.lblCategoryDesc.Size = new System.Drawing.Size(157, 20);
            this.lblCategoryDesc.TabIndex = 1;
            this.lblCategoryDesc.Text = "Category Description";
            // 
            // lblCategoryID
            // 
            this.lblCategoryID.AutoSize = true;
            this.lblCategoryID.Location = new System.Drawing.Point(53, 46);
            this.lblCategoryID.Name = "lblCategoryID";
            this.lblCategoryID.Size = new System.Drawing.Size(90, 20);
            this.lblCategoryID.TabIndex = 0;
            this.lblCategoryID.Text = "CategoryID";
            // 
            // grbCategorisList
            // 
            this.grbCategorisList.Controls.Add(this.dgvCategories);
            this.grbCategorisList.Location = new System.Drawing.Point(34, 359);
            this.grbCategorisList.Name = "grbCategorisList";
            this.grbCategorisList.Size = new System.Drawing.Size(661, 288);
            this.grbCategorisList.TabIndex = 1;
            this.grbCategorisList.TabStop = false;
            this.grbCategorisList.Text = "Categories List";
            // 
            // dgvCategories
            // 
            this.dgvCategories.AllowUserToAddRows = false;
            this.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategories.Location = new System.Drawing.Point(0, 36);
            this.dgvCategories.Name = "dgvCategories";
            this.dgvCategories.RowHeadersWidth = 62;
            this.dgvCategories.RowTemplate.Height = 28;
            this.dgvCategories.Size = new System.Drawing.Size(661, 246);
            this.dgvCategories.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(568, 269);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(49, 34);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(314, 269);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(51, 34);
            this.btnAddCategory.TabIndex = 12;
            this.btnAddCategory.Text = "Add";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.Location = new System.Drawing.Point(387, 269);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(71, 34);
            this.btnUpdateCategory.TabIndex = 11;
            this.btnUpdateCategory.Text = "Update";
            this.btnUpdateCategory.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Location = new System.Drawing.Point(480, 269);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(66, 34);
            this.btnDeleteCategory.TabIndex = 10;
            this.btnDeleteCategory.Text = "Delete";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            // 
            // btnNewCategory
            // 
            this.btnNewCategory.Location = new System.Drawing.Point(241, 269);
            this.btnNewCategory.Name = "btnNewCategory";
            this.btnNewCategory.Size = new System.Drawing.Size(51, 34);
            this.btnNewCategory.TabIndex = 9;
            this.btnNewCategory.Text = "New";
            this.btnNewCategory.UseVisualStyleBackColor = true;
            // 
            // btnMoveLeft
            // 
            this.btnMoveLeft.Location = new System.Drawing.Point(241, 216);
            this.btnMoveLeft.Name = "btnMoveLeft";
            this.btnMoveLeft.Size = new System.Drawing.Size(49, 34);
            this.btnMoveLeft.TabIndex = 14;
            this.btnMoveLeft.Text = "|<<";
            this.btnMoveLeft.UseVisualStyleBackColor = true;
            // 
            // btnToLeft
            // 
            this.btnToLeft.Location = new System.Drawing.Point(321, 216);
            this.btnToLeft.Name = "btnToLeft";
            this.btnToLeft.Size = new System.Drawing.Size(51, 34);
            this.btnToLeft.TabIndex = 15;
            this.btnToLeft.Text = "<<";
            this.btnToLeft.UseVisualStyleBackColor = true;
            // 
            // btnMid
            // 
            this.btnMid.Location = new System.Drawing.Point(403, 216);
            this.btnMid.Name = "btnMid";
            this.btnMid.Size = new System.Drawing.Size(51, 34);
            this.btnMid.TabIndex = 16;
            this.btnMid.Text = "???";
            this.btnMid.UseVisualStyleBackColor = true;
            // 
            // btnToRight
            // 
            this.btnToRight.Location = new System.Drawing.Point(485, 216);
            this.btnToRight.Name = "btnToRight";
            this.btnToRight.Size = new System.Drawing.Size(51, 34);
            this.btnToRight.TabIndex = 17;
            this.btnToRight.Text = ">>";
            this.btnToRight.UseVisualStyleBackColor = true;
            // 
            // btnMoveRight
            // 
            this.btnMoveRight.Location = new System.Drawing.Point(567, 216);
            this.btnMoveRight.Name = "btnMoveRight";
            this.btnMoveRight.Size = new System.Drawing.Size(49, 34);
            this.btnMoveRight.TabIndex = 18;
            this.btnMoveRight.Text = ">>|";
            this.btnMoveRight.UseVisualStyleBackColor = true;
            // 
            // frmMenageCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 688);
            this.Controls.Add(this.grbCategorisList);
            this.Controls.Add(this.grbCategories);
            this.Name = "frmMenageCategories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenageCategories";
            this.grbCategories.ResumeLayout(false);
            this.grbCategories.PerformLayout();
            this.grbCategorisList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbCategories;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblCategoryDesc;
        private System.Windows.Forms.Label lblCategoryID;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Button btnUpdateCategory;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnNewCategory;
        private System.Windows.Forms.GroupBox grbCategorisList;
        private System.Windows.Forms.DataGridView dgvCategories;
        private System.Windows.Forms.Button btnMoveRight;
        private System.Windows.Forms.Button btnToRight;
        private System.Windows.Forms.Button btnMid;
        private System.Windows.Forms.Button btnToLeft;
        private System.Windows.Forms.Button btnMoveLeft;
    }
}