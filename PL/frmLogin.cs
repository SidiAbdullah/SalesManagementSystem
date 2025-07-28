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
                MessageBox.Show("You logged in succesfully!", "Log In", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _frmMain.enabeld_tsms();
                // see frmOrders
                Program.sellerName = dt.Rows[0][0].ToString();
                // see frmAddUser
                string UserType = dt.Rows[0][2].ToString();
                if (UserType == "Admin" || UserType == "admin")
                {
                    _frmMain.tsmUsers.Visible = true;
                }
                else if (UserType == "Normal User" || UserType == "normal user" || UserType == "Normal user")
                {
                    _frmMain.tsmUsers.Visible = false;
                }
                this.Close();
            }
            else
            {
                Program.sellerName = "";
                MessageBox.Show("Log in failed!", "Log In", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEnter_Click(sender, e);
            }
        }
    }
}
