using System;
using System.Data;
using System.Windows.Forms;

namespace SalesManagementSystem_wf.PL
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
            
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        BL.clsLogin login = new BL.clsLogin();
        private void btnEnter_Click(object sender, EventArgs e)
        {
            DataTable dt = login.login(txtUserName.Text, txtPassword.Text);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("You logged in succesfully!");
                frmMain.getMainForm.enabeld_tsms();
                this.Close();
            }
            else
            {
                MessageBox.Show("Login in failed!");
            }
        }
    }
}
