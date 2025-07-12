using System;
using System.Data;
using System.Data.SqlClient;

namespace SalesManagementSystem_wf.DAL
{
    class DataAccessLayer
    {
        SqlConnection connection;

        public DataAccessLayer()
        {
            connection = new SqlConnection("Server = .; DataBase = SalesManagmentDB; User = sa; Password = 123456");
        }
        public void open()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void close()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
        // read
        public DataTable selectData(string stored_procedure, SqlParameter[] parameters)
        {
            DataTable dt = new DataTable();
            connection = new SqlConnection("Server = .; DataBase = SalesManagmentDB; User = sa; Password = 123456");
            SqlCommand command = new SqlCommand(stored_procedure, connection);
            command.CommandType = CommandType.StoredProcedure;
            if (parameters != null) { command.Parameters.AddRange(parameters); }
            open();
            SqlDataReader reader = command.ExecuteReader();
            dt.Load(reader);
            reader.Close();
            close();
            return dt;
        }
        // insert, modify and delete
        public void excuteCommand(string stored_procedure, SqlParameter[] parameters)
        {
            SqlCommand command = new SqlCommand(stored_procedure, connection);
            command.CommandType = CommandType.StoredProcedure;
            if (parameters != null) { command.Parameters.AddRange(parameters); }
            open();
            command.ExecuteNonQuery();
            close();
        }
    }
}