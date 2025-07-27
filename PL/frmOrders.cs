using SalesManagementSystem_wf.BL;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace SalesManagementSystem_wf.PL
{
    public partial class frmOrders : Form
    {
        DataTable dt = new DataTable();
        private void add_dgv_columns()
        {
            dt.Columns.Add("Product ID");
            dt.Columns.Add("Product Name");
            dt.Columns.Add("Price");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("Total price");
            dt.Columns.Add("Discount");
            dt.Columns.Add("Final Price");
            dgvProducts.DataSource = dt;
        }

        private void resize_dgv()
        {
            dgvProducts.RowHeadersWidth = 55;
            dgvProducts.Columns[0].Width = 73;
            dgvProducts.Columns[1].Width = 165;
            dgvProducts.Columns[2].Width = 70;
            dgvProducts.Columns[3].Width = 69;
            dgvProducts.Columns[4].Width = 63;
            dgvProducts.Columns[5].Width = 66;
            dgvProducts.Columns[6].Width = 97;
        }
        public frmOrders()
        {
            InitializeComponent();
            add_dgv_columns();
            resize_dgv();
        }

        clsAdd add = new clsAdd();
        private void btnNewSalle_Click(object sender, EventArgs e)
        {
            txtBillNumber.Text = add.getLastID().Rows[0][0].ToString();
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            frmProductsList products = new frmProductsList();
            products.dgvProductsList.DataSource = add.getAllProducts();
            products.ShowDialog();
            txtPrID.Text = products.dgvProductsList.CurrentRow.Cells[0].Value.ToString();
            txtPrName.Text = products.dgvProductsList.CurrentRow.Cells[1].Value.ToString();
            txtPrPrice.Text = products.dgvProductsList.CurrentRow.Cells[4].Value.ToString();
            txtPrQuantity.Focus();
        }
        private void txtPrQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txtPrQuantity.Text != "")
            {
                txtTotalPrice.Text = (int.Parse(txtPrPrice.Text) * int.Parse(txtPrQuantity.Text)).ToString();
            }
            else
            {
                txtTotalPrice.Text = "";
            }
        }
        private void txtPrQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void txtPrQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDiscount.Focus();
            }
        }
        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            if (txtTotalPrice.Text != "" && txtDiscount.Text != "" && int.Parse(txtDiscount.Text) <= 100 )
            {
                int totalPrice = int.Parse(txtTotalPrice.Text);
                int discount = int.Parse(txtDiscount.Text);
                txtFinalPrice.Text = (totalPrice - (totalPrice * discount) / 100).ToString();
            }
            else
            {
                txtFinalPrice.Text = "";
            }
        }
        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void reset_pr_txtBoxes()
        {
            txtPrID.Text = "";
            txtPrName.Text = "";
            txtPrPrice.Text = "";
            txtPrQuantity.Text = "";
            txtTotalPrice.Text = "";
            txtDiscount.Text = "";
            txtFinalPrice.Text = "";
        }
        private void SumOfFinalPrices()
        {
            int pricesSum = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int FinalPrice = Convert.ToInt32(dt.Rows[i][6]);
                pricesSum += FinalPrice;
            }
            txtPricesSum.Text = pricesSum.ToString();
        }
        private void txtDiscount_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtDiscount.Text != "" && e.KeyCode == Keys.Enter)
            {
                for (int i = 0; i < dgvProducts.Rows.Count; i++)
                {
                    if (txtPrID.Text == this.dgvProducts.Rows[i].Cells[0].Value.ToString())
                    {
                        MessageBox.Show("This Product is already there");
                        reset_pr_txtBoxes();
                        return;
                    }
                }
                dt.Rows.Add(txtPrID.Text, txtPrName.Text, txtPrPrice.Text, txtPrQuantity.Text, txtTotalPrice.Text, txtDiscount.Text, txtFinalPrice.Text);
                reset_pr_txtBoxes();
                dgvProducts.DataSource = dt;

                SumOfFinalPrices();
            }
        }

        private void dgvProducts_DoubleClick(object sender, EventArgs e)
        {
            txtPrID.Text = this.dgvProducts.CurrentRow.Cells[0].Value.ToString();
            txtPrName.Text = this.dgvProducts.CurrentRow.Cells[1].Value.ToString();
            txtPrPrice.Text = this.dgvProducts.CurrentRow.Cells[2].Value.ToString();
            txtPrQuantity.Text = this.dgvProducts.CurrentRow.Cells[3].Value.ToString();
            txtTotalPrice.Text = this.dgvProducts.CurrentRow.Cells[4].Value.ToString();
            txtDiscount.Text = this.dgvProducts.CurrentRow.Cells[5].Value.ToString();
            txtFinalPrice.Text = this.dgvProducts.CurrentRow.Cells[6].Value.ToString();
            this.dgvProducts.Rows.RemoveAt(this.dgvProducts.CurrentRow.Index);
            txtDiscount.Focus();
            SumOfFinalPrices();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvProducts_DoubleClick(sender, e);
        }

        private void deleteCurrentRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.dgvProducts.Rows.RemoveAt(this.dgvProducts.CurrentRow.Index);
        }

        private void deleteAllRowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dt.Clear();
            this.dgvProducts.Refresh();
        }
    }
}