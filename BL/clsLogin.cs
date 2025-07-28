using SalesManagementSystem_wf.PL;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SalesManagementSystem_wf.BL
{
    class clsLogin
    {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
        public DataTable login(string UserName, string Password)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@UserName", UserName);
            parameters[1] = new SqlParameter("@Password", Password);
            dt = DAL.selectData("sp_login", parameters);
            return dt;
        }
        public DataTable getAllUsers()
        {
            return DAL.selectData("getAllUsers", null);
        }
        // add user
        public void addUser(string UserName, string Password, string UserType)
        {
            SqlParameter[] parameters = new SqlParameter[3];
            parameters[0] = new SqlParameter("@UserName", UserName);
            parameters[1] = new SqlParameter("@Password", Password);
            parameters[2] = new SqlParameter("@UserType", UserType);
            DAL.excuteCommand("addUser", parameters);
        }

        // delete user
        public void deleteUser(string UserName)
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@UserName", UserName);
            DAL.excuteCommand("deleteUser", parameters);
        }
        // edit user
        public void editUser(string UserName, string Password, string UserType)
        {
            SqlParameter[] parameters = new SqlParameter[3];
            parameters[0] = new SqlParameter("@UserName", UserName);
            parameters[1] = new SqlParameter("@Password", Password);
            parameters[2] = new SqlParameter("@UserType", UserType);
            DAL.excuteCommand("editUser", parameters);
        }
        // search user
        public DataTable searchUsers(string search)
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@search", search);
            return DAL.selectData("searchUsers", parameters);
        }
    }
}