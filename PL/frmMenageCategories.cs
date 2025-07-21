using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SalesManagementSystem_wf.PL
{
    public partial class frmMenageCategories : Form
    {
        SqlConnection connection = new SqlConnection("Server = .; DataBase = SalesManagmentDB; User = sa; Password = 123456");
        public frmMenageCategories()
        {
            InitializeComponent();
            connection.Open();
            SqlCommand command = new SqlCommand("Select * from Categories", connection);
            SqlDataReader reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            this.dgvCategories.DataSource = dt;
            reader.Close();
            connection.Close();
            // Method 1: Bind DataGridView data directly to TextBoxes using DataBindings  
            //txtCategoryID.DataBindings.Add("text", dgvCategories.DataSource, "CategoryID");
            //txtCategoryDesc.DataBindings.Add("text", dgvCategories.DataSource, "Name");

            // Method 2: Bind DataGridView data to TextBoxes manually using SelectionChanged event  
            dgvCategories.SelectionChanged += dgvCategories_SelectionChanged; // see the event method below
        }
        private void dgvCategories_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCategories.CurrentRow != null)
            {
                txtCategoryID.Text = dgvCategories.CurrentRow.Cells["CategoryID"].Value.ToString();
                txtCategoryDesc.Text = dgvCategories.CurrentRow.Cells["Name"].Value.ToString();
            }
        }
    }
}
