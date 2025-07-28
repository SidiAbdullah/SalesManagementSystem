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
    public partial class frmAddUser : Form
    {
        public frmAddUser()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" || txtPass.Text == "" || txtConfirm.Text == "" || cmbUserType.Text == "")
            {
                MessageBox.Show("Fill all the fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtPass.Text != txtConfirm.Text)
            {
                MessageBox.Show("Passwords don't match", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
                clsLogin login = new clsLogin();
            if (btnAddUser.Text == "Add")
            {
                login.addUser(txtUserName.Text, txtPass.Text, cmbUserType.Text);
                MessageBox.Show("User Added succussfully", "Adding User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // reset
                txtUserName.Text = "";
                txtPass.Text = "";
                txtConfirm.Text = "";
                cmbUserType.Text = "";
            }
            else if (btnAddUser.Text == "Edit")
            {
                login.editUser(txtUserName.Text, txtPass.Text, cmbUserType.Text);
                MessageBox.Show("User Edited succussfully", "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            
        }
    }
}
