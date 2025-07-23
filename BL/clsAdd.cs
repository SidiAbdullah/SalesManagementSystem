using SalesManagementSystem_wf.DAL;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SalesManagementSystem_wf.BL
{
    class clsAdd
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
        
        // let's add categories
        public void insertCategory(int ID, string Name)
        {
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@ID", ID);
            parameters[1] = new SqlParameter("@Name", Name);
            DAL.excuteCommand("insertCategory", parameters);
        }
        public void editCategory(int ID, string Name)
        {
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@ID", ID);
            parameters[1] = new SqlParameter("@Name", Name);
            DAL.excuteCommand("editCategory", parameters);
        }
        public void deleteCategory(int ID)
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@ID", ID);
            DAL.excuteCommand("deleteCategory", parameters);
        }
        // let's add customers
        public DataTable getAllCustomers()
        {
            return DAL.selectData("getAllCustomers", null);
        }
        public void insertCustomer(string FirstName, string LastName, string Phone, string Email, byte[] Image)
        {
            SqlParameter[] parameters = new SqlParameter[5];
            parameters[0] = new SqlParameter("@FirstName", FirstName);
            parameters[1] = new SqlParameter("@LastName", LastName);
            parameters[2] = new SqlParameter("@Phone", Phone);
            parameters[3] = new SqlParameter("@Email", Email);
            parameters[4] = new SqlParameter("@Image", Image);
            DAL.excuteCommand("insertCustomer", parameters);
        }
        public void updateCustomer(string FirstName, string LastName, string Phone, string Email, byte[] Image)
        {
            SqlParameter[] parameters = new SqlParameter[5];
            parameters[0] = new SqlParameter("@FirstName", FirstName);
            parameters[1] = new SqlParameter("@LastName", LastName);
            parameters[2] = new SqlParameter("@Phone", Phone);
            parameters[3] = new SqlParameter("@Email", Email);
            parameters[4] = new SqlParameter("@Image", Image);
            DAL.excuteCommand("updateCustomer", parameters);
        }
        public void deleteCustomer(string Phone)
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@Phone", Phone);
            DAL.excuteCommand("deleteCustomer", parameters);
        }
    }
}
