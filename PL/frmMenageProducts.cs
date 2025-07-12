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
        public frmMenageProducts()
        {
            InitializeComponent();
            BL.clsAddProduct displayProducts = new BL.clsAddProduct();
            this.dgvProducts.DataSource =  displayProducts.getAllProducts();
        }
    }
}
