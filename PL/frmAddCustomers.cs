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
        public void dgvRefresh()
        {
            this.dgvCustomers.DataSource = customer.getAllCustomers();
        }
        public frmAddCustomers()
        {
            InitializeComponent();
            dgvRefresh();
        }
        public byte[] imgToByteArray()
        {
            MemoryStream ms = new MemoryStream();
            ptbImage.Image.Save(ms, ptbImage.Image.RawFormat);
            return ms.ToArray();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnNew.Enabled = false;
            txtFirstName.Focus();
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            byte[] pic = imgToByteArray();
            customer.insertCustomer(txtFirstName.Text, txtLastName.Text, txtPhone.Text, txtEmail.Text, pic);
            dgvRefresh();
            btnAdd.Enabled = false;
            btnNew.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            byte[] pic = imgToByteArray();
            customer.updateCustomer(txtFirstName.Text, txtLastName.Text, txtPhone.Text, txtEmail.Text, pic);
            dgvRefresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            customer.deleteCustomer(txtPhone.Text);
            dgvRefresh();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ptbImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Types | *.JPG; *.svg; *.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ptbImage.Image = Image.FromFile(ofd.FileName);
            }
        }
        // we have to solve no image issue and improve ux by sliding on textBoxes by enter and complete update and moves buttons
    }
}
