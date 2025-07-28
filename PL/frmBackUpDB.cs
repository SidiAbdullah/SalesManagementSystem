using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagementSystem_wf.PL
{
    public partial class frmBackUpDB : Form
    {
        public frmBackUpDB()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }
        private void btnBackUp_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Server = .; DataBase = SalesManagmentDB; User = sa; Password = 123456");
            string query = "BACKUP  DataBase SalesManagmentDB to disk = '" + txtPath.Text + "//SalesManagmentDB.bak'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Back up done succussfully", "Back up", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
