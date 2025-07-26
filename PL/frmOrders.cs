using SalesManagementSystem_wf.BL;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SalesManagementSystem_wf.PL
{
    public partial class frmOrders : Form
    {
        clsAdd order = new clsAdd();
        public frmOrders()
        {
            InitializeComponent();
        }

        private void btnNewSalle_Click(object sender, EventArgs e)
        {
            txtBillNumber.Text = order.getLastID().Rows[0][0].ToString();
            btnSaveSell.Enabled = true;
            btnNewSalle.Enabled = false;
        }
        private void btnSearchCustomers_Click(object sender, EventArgs e)
        {
            frmCustomersList customers = new frmCustomersList();
            customers.ShowDialog();
            txtCustomerID.Text = customers.dgvCustomers.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = customers.dgvCustomers.CurrentRow.Cells[1].Value.ToString() + " " +
                customers.dgvCustomers.CurrentRow.Cells[2].Value.ToString();
            txtPhone.Text = customers.dgvCustomers.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = customers.dgvCustomers.CurrentRow.Cells[4].Value.ToString();
            if (customers.dgvCustomers.CurrentRow.Cells[5].Value != DBNull.Value)
            {
                byte[] pic = (byte[])customers.dgvCustomers.CurrentRow.Cells[5].Value;
                MemoryStream ms = new MemoryStream(pic);
                ptbCustomer.Image = Image.FromStream(ms);
            }
            else
            {
                ptbCustomer.Image = null;
            }
        }
    }
}