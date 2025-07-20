using System;
using System.Data;
using System.Windows.Forms;

namespace SalesManagementSystem_wf.PL
{
    public partial class frmLogin : Form
    {
        private frmMain _frmMain;
        public frmLogin(frmMain frm)
        {
            InitializeComponent();
            _frmMain = frm;
        }
            
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            BL.clsLogin login = new BL.clsLogin();
            DataTable dt = login.login(txtUserName.Text, txtPassword.Text);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("You logged in succesfully!");
                _frmMain.enabeld_tsms();
                this.Close();
            }
            else
            {
                MessageBox.Show("Login in failed!");
            }
        }
    }
}
