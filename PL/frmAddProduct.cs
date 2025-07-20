using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SalesManagementSystem_wf.PL
{
    public partial class frmAddProduct : Form
    {
        private int _productID = -1; // for taking the productID from dgvProducts

        BL.clsAddProduct add = new BL.clsAddProduct();
        DataTable dt = new DataTable();
        public frmAddProduct()
        {
            InitializeComponent();
            dt = add.getAllCategories();
            cmbCategories.DataSource = dt;
            cmbCategories.DisplayMember = "Name";
        }
        public frmAddProduct(int productID)
        {
            InitializeComponent();
            dt = add.getAllCategories();
            cmbCategories.DataSource = dt;
            cmbCategories.DisplayMember = "Name";

            _productID = productID;
        }
        private void btnAddPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ptbImage.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text != "" && txtStock.Text != "" && txtPrice.Text != "")
            {
                //
                MemoryStream ms = new MemoryStream();
                ptbImage.Image.Save(ms, ptbImage.Image.RawFormat);
                byte[] byteImage = ms.ToArray();
                // 
                BL.clsAddProduct add = new BL.clsAddProduct();
                if (btnAdd.Text == "Add")
                {
                    add.addProduct(txtProductName.Text, txtDescription.Text, int.Parse(txtStock.Text), int.Parse(txtPrice.Text), byteImage, cmbCategories.SelectedIndex + 1);
                    MessageBox.Show("Product added successfully");
                    this.Close();
                }
                else if (btnAdd.Text == "Update")
                {
                    add.UpdateProduct(_productID, txtProductName.Text, txtDescription.Text, int.Parse(txtStock.Text), int.Parse(txtPrice.Text), cmbCategories.SelectedIndex + 1);
                    MessageBox.Show("Product updated successfully");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Failed adding Product");
            }
        }
    }
}
