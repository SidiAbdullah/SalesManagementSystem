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
        public void addProduct(string Name, string Description, int Stock, int Price, byte[] ProductImage, int CategoryID)
        {
            SqlParameter[] parameters = new SqlParameter[6];
            parameters[0] = new SqlParameter("@name", Name);
            parameters[1] = new SqlParameter("@Description", Description);
            parameters[2] = new SqlParameter("@Stock", Stock);
            parameters[3] = new SqlParameter("@Price", Price);
            parameters[4] = new SqlParameter("@ProductImage", ProductImage);
            parameters[5] = new SqlParameter("@CategoryID", CategoryID);
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.excuteCommand("addProduct", parameters);
        }
        public DataTable getAllProducts()
        {
            DataTable dt = new DataTable();
            dt = DAL.selectData("getAllProducts", null);
            return dt;
        }

        public DataTable getProductsStartsWith(string Name)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@Name", Name);
            dt = DAL.selectData("getProductsStartsWith", parameters);
            return dt;
        }
        public void deleteProduct(int ID)
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@ID", ID);
            DAL.excuteCommand("deleteProduct", parameters);
        }
        public void UpdateProduct(int ProductID, string Name, string Description, int Stock, int Price, byte[] image, int CategoryID)
        {
            SqlParameter[] parameters = new SqlParameter[7];
            parameters[0] = new SqlParameter("@ProductID", ProductID);
            parameters[1] = new SqlParameter("@Name", Name);
            parameters[2] = new SqlParameter("@Description", Description);
            parameters[3] = new SqlParameter("@Stock", Stock);
            parameters[4] = new SqlParameter("@Price", Price);
            parameters[5] = new SqlParameter("@image", image);
            parameters[6] = new SqlParameter("@CategoryID", CategoryID);
            DAL.excuteCommand("UpdateProduct", parameters);
        }
        public DataTable getImageProduct(int ID)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@ID", ID);
            dt = DAL.selectData("getImageProduct", parameters);
            return dt;
        }
    }
}
