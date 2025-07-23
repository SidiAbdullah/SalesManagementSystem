using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SalesManagementSystem_wf.PL
{
    public partial class frmMenageCategories : Form
    {
        BL.clsAddProduct add = new BL.clsAddProduct();
        // we will use this event method on the constructor to Bind DataGridView data to TextBoxes
        private void dgvCategories_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCategories.CurrentRow != null)
            {
                txtCategoryID.Text = dgvCategories.CurrentRow.Cells["CategoryID"].Value.ToString();
                txtCategoryDesc.Text = dgvCategories.CurrentRow.Cells["Name"].Value.ToString();
            }
        }
        SqlConnection connection = new SqlConnection("Server = .; DataBase = SalesManagmentDB; User = sa; Password = 123456");
        DataTable dt = new DataTable();
        //
        BindingManagerBase bmb;
        public frmMenageCategories()
        {
            InitializeComponent();
            connection.Open();
            SqlCommand command = new SqlCommand("Select * from Categories", connection);
            SqlDataReader reader = command.ExecuteReader();
            dt.Load(reader);
            this.dgvCategories.DataSource = dt;
            reader.Close();
            connection.Close();

            // Method 1: Bind DataGridView data directly to TextBoxes using DataBindings  
            //txtCategoryID.DataBindings.Add("text", dgvCategories.DataSource, "CategoryID");
            //txtCategoryDesc.DataBindings.Add("text", dgvCategories.DataSource, "Name");

            // Method 2: Bind DataGridView data to TextBoxes manually using SelectionChanged event  
            dgvCategories.SelectionChanged += dgvCategories_SelectionChanged; // see the event method below

            bmb = this.BindingContext[dt];
            lblPosition.Text = bmb.Position + 1 + " / " + bmb.Count;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bmb.Position++;
            lblPosition.Text = bmb.Position + 1 + " / " + bmb.Count;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            bmb.Position--;
            lblPosition.Text = bmb.Position + 1 + " / " + bmb.Count;
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            bmb.Position = 0;
            lblPosition.Text = bmb.Position + 1 + " / " + bmb.Count;
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            bmb.Position = bmb.Count;
            lblPosition.Text = bmb.Position + 1 + " / " + bmb.Count;
        }
        private void btnNewCategory_Click(object sender, EventArgs e)
        {
            btnAddCategory.Enabled = true;
            btnNewCategory.Enabled = false;
            int ID = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0]) + 1;
            txtCategoryID.Text = ID.ToString();
            txtCategoryDesc.Text = "";
            txtCategoryDesc.Focus();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            btnAddCategory.Enabled = false;
            btnNewCategory.Enabled = true;
            if (txtCategoryDesc.Text != "")
            {
                if (MessageBox.Show("Are you sure", "Adding Category", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    add.insertCategory(int.Parse(txtCategoryID.Text), txtCategoryDesc.Text);
                    dt = add.getAllCategories();
                    bmb = this.BindingContext[dt];
                    this.dgvCategories.DataSource = dt;
                    lblPosition.Text = bmb.Position + 1 + " / " + bmb.Count;
                }
            }
            else
            {
                MessageBox.Show("Category description can't be empty", "Adding Category", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtCategoryID.Text);
            string Name = txtCategoryDesc.Text;

            if (MessageBox.Show("Are you sure?", "Editing a category", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                add.editCategory(ID, Name);
                MessageBox.Show("Edited successfully");
                dt = add.getAllCategories();
                bmb = this.BindingContext[dt];
                this.dgvCategories.DataSource = dt;
                lblPosition.Text = bmb.Position + 1 + " / " + bmb.Count;
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Deleting a category", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                add.deleteCategory(int.Parse(txtCategoryID.Text));
                MessageBox.Show("Deleted successfully");
                dt = add.getAllCategories();
                bmb = this.BindingContext[dt];
                this.dgvCategories.DataSource = dt;
                lblPosition.Text = bmb.Position + 1 + " / " + bmb.Count;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
