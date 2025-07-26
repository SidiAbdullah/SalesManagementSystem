using SalesManagementSystem_wf.BL;
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
    public partial class frmCustomersList : Form
    {
        clsAdd add = new clsAdd();
        public frmCustomersList()
        {
            InitializeComponent();
            this.dgvCustomers.DataSource = add.getAllCustomers();
            this.dgvCustomers.Columns[0].Visible = false;
            this.dgvCustomers.Columns[5].Visible = false;
        }

        private void dgvCustomers_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
