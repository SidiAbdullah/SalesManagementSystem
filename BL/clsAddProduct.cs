using SalesManagementSystem_wf.DAL;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Xml.Linq;

namespace SalesManagementSystem_wf.BL
{
    class clsAddProduct
    {
        DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
        public DataTable getAllCategories()
        {
            DataTable dt = new DataTable();
            dt = DAL.selectData("getAllCategories", null);
            return dt;
        }
        public void addProduct(string Name, int Stock, int Price, byte[] ProductImage, int CategoryID)
        {
            SqlParameter[] parameters = new SqlParameter[5];
            parameters[0] = new SqlParameter("@name", Name);
            parameters[1] = new SqlParameter("@Stock", Stock);
            parameters[2] = new SqlParameter("@Price", Price);
            parameters[3] = new SqlParameter("@ProductImage", ProductImage);
            parameters[4] = new SqlParameter("@CategoryID", CategoryID);
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.excuteCommand("addProduct", parameters);
        }
        public DataTable getAllProducts()
        {
            DataTable dt = new DataTable();
            dt = DAL.selectData("getAllProducts", null);
            return dt;
        }
    }
}
