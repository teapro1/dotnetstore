using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Store_DL
{
    public class DBConnect
    {
        public SqlConnection connection;

        public void OpenConnect()
        {
            string connectionString = "Data Source=BLACKDANG;" + "Initial Catalog=QLCUAHANG;" + "Integrated Security=True;";
            if (connection == null)
            {
                connection = new SqlConnection(connectionString);
            }
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
        }
        public void CloseConnection()
        {
            if (connection != null)
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
        }

        // insert, update, delete
        public void ExecuteNonQuery(string strSql)
        {
            try
            {
                OpenConnect();
                SqlCommand cmd = new SqlCommand(strSql, connection);
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
            catch (Exception e)
            {
                // Thêm thông báo
            }
        }

        // select --> table
        public DataTable ExecuteQuery(string strSql)
        {
            try
            {
                OpenConnect();
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(strSql, connection);
                adapter.Fill(dt);
                return dt;
                CloseConnection();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public string GetValue(string strSql)
        {

            try
            {
                string value = null;
                OpenConnect();
                SqlCommand cmd = new SqlCommand(strSql, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    value= reader[0].ToString();
                return value;
                CloseConnection();
            }
            catch(Exception e)
            {
                return null;
            }
        }
    }
}
