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
    public partial class frmMain : Form
    {
        private static frmMain frm;
        static void frm_FormCLosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static frmMain getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new frmMain();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormCLosed);
                }
                return frm;
            }
        }
        public frmMain()
        {
            if (frm == null) { frm = this; }
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
            frmLogin frmLog = new frmLogin();
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

    }
}
