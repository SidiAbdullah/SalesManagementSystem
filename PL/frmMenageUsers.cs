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
    public partial class frmMenageUsers : Form
    {
        // CRUDS on Users DataBase
        clsLogin login = new clsLogin();
        private void refresh_dgv()
        {
            dgvUsers.DataSource = login.getAllUsers();
        }
        public frmMenageUsers()
        {
            InitializeComponent();
            refresh_dgv();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // add user
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddUser addUser = new frmAddUser();
            addUser.btnAddUser.Text = "Add";
            addUser.ShowDialog();
            refresh_dgv();
        }
        // delete user
        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure ?", "Delete User", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                login.deleteUser(dgvUsers.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("User deleted succussfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh_dgv();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmAddUser addUser = new frmAddUser();
            addUser.btnAddUser.Text = "Edit";
            addUser.txtUserName.Text = dgvUsers.CurrentRow.Cells[0].Value.ToString();
            addUser.txtPass.Text = dgvUsers.CurrentRow.Cells[1].Value.ToString();
            addUser.txtConfirm.Text = dgvUsers.CurrentRow.Cells[1].Value.ToString();
            addUser.cmbUserType.Text = dgvUsers.CurrentRow.Cells[2].Value.ToString();
            addUser.ShowDialog();
            refresh_dgv();
        }

        private void dgvUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit_Click(sender, e);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvUsers.DataSource = login.searchUsers(txtSearch.Text);
        }
    }
}
