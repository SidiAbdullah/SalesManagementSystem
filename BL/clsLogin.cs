using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SalesManagementSystem_wf.BL
{
    class clsLogin
    {
        public DataTable login(string UserName, string Password)
        {
            DataTable dt = new DataTable();
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@UserName", UserName);
            parameters[1] = new SqlParameter("@Password", Password);
            dt = DAL.selectData("sp_login", parameters);
            if (dt.Rows.Count > 0)
            {
                Program.sellerName = dt.Rows[0][0].ToString();
            }
            else
            {
                Program.sellerName = "";
            }
                return dt;
        }
    }
}