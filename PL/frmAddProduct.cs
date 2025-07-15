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
        BL.clsAddProduct add = new BL.clsAddProduct();
        DataTable dt = new DataTable();
        public frmAddProduct()
        {
            InitializeComponent();
            dt = add.getAllCategories();
            cmbCategories.DataSource = dt;
            cmbCategories.DisplayMember = "Name";
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
            if (txtProductName.Text != "" && txtStock.Text != "" && txtPrice.Text != "" && ptbImage.Image != null)
            {
                //
                MemoryStream ms = new MemoryStream();
                ptbImage.Image.Save(ms, ptbImage.Image.RawFormat);
                byte[] byteImage = ms.ToArray();
                //

                BL.clsAddProduct add = new BL.clsAddProduct();
                add.addProduct(txtProductName.Text, txtDescription.Text, int.Parse(txtStock.Text), int.Parse(txtPrice.Text), byteImage, cmbCategories.SelectedIndex + 1);
                MessageBox.Show("Product added successfully");
            }
            else
            {
                MessageBox.Show("Failed adding Product");
            }
        }
    }
}
