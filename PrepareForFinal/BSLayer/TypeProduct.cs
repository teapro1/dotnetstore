using PrepareForFinal.DBLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrepareForFinal.BSLayer
{
    public class TypeProduct
    {
        MyData db = null;
        SqlCommand cmd;

        public TypeProduct()
        {
            db = new MyData();
        }


        public DataSet GetTypeProduct()
        {
            return db.ExecuteQueryDataSet("SELECT t_id AS N'ID', t_name AS N'Tên'" +
                "FROM Type_Product WHERE t_status = 0", CommandType.Text);
        }

        public bool addType(string tid, string name)
        {
            cmd = new SqlCommand("EXEC usp_AddType @id, @name", db.getSqlConn);
            cmd.Parameters.AddWithValue("id", tid);
            cmd.Parameters.AddWithValue("name", name);

            db.openConnectionManager();
            if (cmd.ExecuteNonQuery() == 1)
            {
                db.closeConnectionManager();
                return true;
            }
            else
            {
                db.closeConnectionManager();
                return false;
            }
        }
        public bool updateType(string tid, string name)
        {
            cmd = new SqlCommand("EXEC usp_UpdateTypeProduct @id, @name", db.getSqlConn);
            cmd.Parameters.AddWithValue("id", tid);
            cmd.Parameters.AddWithValue("name", name);

            db.openConnectionManager();
            if (cmd.ExecuteNonQuery() == 1)
            {
                db.closeConnectionManager();
                return true;
            }
            else
            {
                db.closeConnectionManager();
                return false;
            }
        }
        public bool deleteType(string tid)
        {
            cmd = new SqlCommand("usp_DeleteTypeProduct @id", db.getSqlConn);
            cmd.Parameters.AddWithValue("@id", tid);

            db.openConnectionManager();
            if (cmd.ExecuteNonQuery() == 1)
            {
                db.closeConnectionManager();
                return true;
            }
            else
            {
                db.closeConnectionManager();
                return false;
            }
        }
        public DataSet findType(string textFind)
        {
            DataSet ds = new DataSet();
            try
            {
                cmd = new SqlCommand("usp_FindTypeProduct @sql_findTypeProduct", db.getSqlConn);
                cmd.Parameters.AddWithValue("@sql_findTypeProduct", textFind);
                db.openConnectionManager();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
                db.closeConnectionManager();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                db.closeConnectionManager();
            }
            return ds;
        }

        public String autoGenerateID()
        {
            return db.autoGenerateID("SELECT dbo.[uf_AutoGenerateID]('Type')");
        }

    }
}
