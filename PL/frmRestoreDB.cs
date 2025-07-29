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
    public partial class frmRestoreDB : Form
    {
        public frmRestoreDB()
        {
            InitializeComponent();
        }
        private void btnPath_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = openFileDialog1.FileName;
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (txtPath.Text == "")
            {
                MessageBox.Show("Please select the backup file path.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                string query = $@"ALTER DATABASE SalesManagmentDB SET OFFLINE WITH ROLLBACK IMMEDIATE;
                                RESTORE DATABASE SalesManagmentDB
                                FROM DISK = N'{txtPath.Text}'
                                WITH REPLACE,
                                MOVE 'SalesManagmentDB' TO 'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\SalesManagmentDB.mdf',
                                MOVE 'SalesManagmentDB_log' TO 'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\SalesManagmentDB_log.ldf';
                                ALTER DATABASE SalesManagmentDB SET ONLINE;
";

                SqlConnection connection = new SqlConnection("Server=.;Database=master;User=sa;Password=123456");
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Database restored successfully!", "Restore", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during restore:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
