using System;
using System.Windows.Forms;

namespace SalesManagementSystem_wf.PL
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public void enabeld_tsms()
        {
            tsmProducts.Enabled = true;
            tsmCustomers.Enabled = true;
            tsmUsers.Enabled = true;
            ftsm_createBackup.Enabled = true;
            ftsm_restoreBackup.Enabled = true;
            logputToolStripMenuItem.Enabled = true;
        }
        public void desabeld_tsms()
        {
            tsmProducts.Enabled =  false;
            tsmCustomers.Enabled = false;
            tsmUsers.Enabled =     false;
            ftsm_createBackup.Enabled =  false;
            ftsm_restoreBackup.Enabled = false;
            logputToolStripMenuItem.Enabled = false;
        }
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frmLog = new frmLogin(this);
            frmLog.ShowDialog();
        }
        private void logputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You logged out!");
            this.desabeld_tsms();
        }
        private void newProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddProduct product = new frmAddProduct();
            product.ShowDialog();
        }

        private void manageProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMenageProducts frmMenage = new frmMenageProducts();
            frmMenage.ShowDialog();
        }
    }
}
