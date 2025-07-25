using SalesManagementSystem_wf.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagementSystem_wf.PL
{
    public partial class frmAddCustomers : Form
    {
        BL.clsAdd customer = new BL.clsAdd();
        // dgvRefresh() because we will make a refresh after each CRUD
        public void dgvRefresh()
        {
            this.dgvCustomers.DataSource = customer.getAllCustomers();
            dgvCustomers.Columns[0].Visible = false;
            dgvCustomers.Columns[5].Visible = false;
        }
        public frmAddCustomers()
        {
            InitializeComponent();
            dgvRefresh();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnNew.Enabled = false;
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            ptbImage.Image = null;
            txtFirstName.Focus();
        }
        public byte[] imgToByteArray()
        {
            if (ptbImage == null || ptbImage.Image == null)
                return null;
            MemoryStream ms = new MemoryStream();
            ptbImage.Image.Save(ms, ptbImage.Image.RawFormat);
            return ms.ToArray();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnNew.Enabled = true;
            byte[] pic = imgToByteArray();
            string imageHandler = (pic == null) ? "noImage" : "withImage";
            customer.insertCustomer(txtFirstName.Text, txtLastName.Text, txtPhone.Text, txtEmail.Text, pic, imageHandler);
            dgvRefresh();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            byte[] pic = imgToByteArray();
            customer.updateCustomer(txtFirstName.Text, txtLastName.Text, txtPhone.Text, txtEmail.Text, pic);
            dgvRefresh();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int ID = (int)this.dgvCustomers.CurrentRow.Cells[0].Value;
            customer.deleteCustomer(ID);
            dgvRefresh();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ptbImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Types | *.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ptbImage.Image = Image.FromFile(ofd.FileName);
            }
        }
        // let's moves slidly when presing enter
        private void txtFirstName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtLastName.Focus();
            }
        }
        private void txtLastName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPhone.Focus();
            }
        }
        private void txtPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtEmail.Focus();
            }
        }
        private void dgvCustomers_DoubleClick(object sender, EventArgs e)
        {
            txtFirstName.Text = dgvCustomers.CurrentRow.Cells[1].Value.ToString();
            txtLastName.Text = dgvCustomers.CurrentRow.Cells[2].Value.ToString();
            txtPhone.Text = dgvCustomers.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dgvCustomers.CurrentRow.Cells[4].Value.ToString();
            if (dgvCustomers.CurrentRow.Cells[5].Value != DBNull.Value)
            {
                byte[] pic = (byte[])dgvCustomers.CurrentRow.Cells[5].Value;
                MemoryStream ms = new MemoryStream(pic);
                ptbImage.Image = Image.FromStream(ms);
            }
            else
            {
                ptbImage.Image = null;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            this.dgvCustomers.DataSource = customer.searchCustomers(txtSearch.Text);
        }

        // let's make moves buttons
    }
}
