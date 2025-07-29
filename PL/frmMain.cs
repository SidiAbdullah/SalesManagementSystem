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

        private void manageCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMenageCategories menageCategories = new frmMenageCategories();
            menageCategories.ShowDialog();
        }
        private void manageCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddCustomers frmCustomers = new frmAddCustomers();
            frmCustomers.ShowDialog();
        }

        private void manageSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrders orders = new frmOrders();
            orders.ShowDialog();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUser addUser = new frmAddUser();
            addUser.ShowDialog();
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMenageUsers menageUsers = new frmMenageUsers();
            menageUsers.ShowDialog();
        }

        private void ftsm_createBackup_Click(object sender, EventArgs e)
        {
            frmBackUpDB backUpDB = new frmBackUpDB();
            backUpDB.ShowDialog();
        }

        private void ftsm_restoreBackup_Click(object sender, EventArgs e)
        {
            frmRestoreDB restoreDB = new frmRestoreDB();
            restoreDB.ShowDialog();
        }
    }
}
