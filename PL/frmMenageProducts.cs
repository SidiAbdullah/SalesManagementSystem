using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagementSystem_wf.PL
{
    public partial class frmMenageProducts : Form
    {
        BL.clsAddProduct displayProducts = new BL.clsAddProduct();
        public frmMenageProducts()
        {
            InitializeComponent();
            this.dgvProducts.DataSource =  displayProducts.getAllProducts();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.dgvProducts.DataSource = displayProducts.getProductsStartsWith(txtSearch.Text);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            frmAddProduct frmAdd = new frmAddProduct(this);
            frmAdd.ShowDialog();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Delete product", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                displayProducts.deleteProduct((int)dgvProducts.CurrentRow.Cells[0].Value);
                MessageBox.Show("Product deleted succussfully!", "Deleting", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dgvProducts.DataSource =  displayProducts.getAllProducts();
            }
            else
            {
                MessageBox.Show("Canceled deleting Product!", "Deleting", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            int productID = (int)this.dgvProducts.CurrentRow.Cells[0].Value;
            frmAddProduct add = new frmAddProduct(this, productID);
            // we can access all the properties because we set modifires to public
            add.Text = "Update product";
            add.btnAdd.Text = "Update";
            add.txtProductName.Text = this.dgvProducts.CurrentRow.Cells[1].Value.ToString();
            add.txtDescription.Text = this.dgvProducts.CurrentRow.Cells[2].Value.ToString();
            add.txtStock.Text = this.dgvProducts.CurrentRow.Cells[3].Value.ToString();
            add.txtPrice.Text = this.dgvProducts.CurrentRow.Cells[4].Value.ToString();
            add.cmbCategories.Text = this.dgvProducts.CurrentRow.Cells[5].Value.ToString();
            byte[] image = (byte[])displayProducts.getImageProduct(productID).Rows[0][0];
            MemoryStream ms = new MemoryStream(image);
            add.ptbImage.Image = Image.FromStream(ms);
            add.ShowDialog();
        }

        private void btnProductPhoto_Click(object sender, EventArgs e)
        {
            frmShowImage showImage = new frmShowImage();
            int productID = (int)this.dgvProducts.CurrentRow.Cells[0].Value;
            byte[] image = (byte[])displayProducts.getImageProduct(productID).Rows[0][0];
            MemoryStream ms = new MemoryStream(image);
            showImage.ptbProductImage.Image = Image.FromStream(ms);
            showImage.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}