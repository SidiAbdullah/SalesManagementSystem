using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            frmAddProduct frmAdd = new frmAddProduct();
            frmAdd.ShowDialog();
        }
    }
}
