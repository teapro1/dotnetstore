using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrepareForFinal.DBLayer;
using System.Data.SqlClient;
using System.Data;

namespace PrepareForFinal.BSLayer
{
    public class Detail
    {
        public MyData db = null;
        public SqlCommand cm = null;
        DataSet ds = null;

        public Detail()
        {
            db = new MyData();
        }

        public DataSet GetData(String bid)
        {
            ds = new DataSet();
            db = new MyData();
            cm = new SqlCommand("select * from V_DetailInfo where status = 0 and bid = '" + bid + "'");
            ds = db.ExecuteQueryDataSet(cm.CommandText, CommandType.Text);
            return ds;
        }

        public bool addDetail(float amount, string bid, string pid)
        {
            db = new MyData();
            cm = new SqlCommand("EXEC usp_AddDetail @amount, @bid, @pid", db.getSqlConn);
            cm.Parameters.AddWithValue("@amount", amount);
            cm.Parameters.AddWithValue("@bid", bid);
            cm.Parameters.AddWithValue("@pid", pid);
            db.openConnectionManager();
            if (cm.ExecuteNonQuery()>=2)
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

        public String getProductID(string pName)
        {
            db = new MyData();
            db.openConnectionManager();
            cm = new SqlCommand("Select p_id from Product where p_name=@pName and p_status=0", db.getSqlConn);
            cm.Parameters.AddWithValue("@pName", pName);
            SqlDataReader DR = cm.ExecuteReader();
            String pid = "";
            while (DR.Read())
            {
                pid = DR[0].ToString();
            }
            db.closeConnectionManager();
            return pid;
        }

        public String getProductPrice(string pName)
        {
            db = new MyData();
            db.openConnectionManager();
            cm = new SqlCommand("Select p_price from Product where p_name=@pName and p_status=0", db.getSqlConn);
            cm.Parameters.AddWithValue("@pName", pName);
            SqlDataReader DR = cm.ExecuteReader();
            String pPrice = "";
            while (DR.Read())
            {
                pPrice = DR[0].ToString();
            }
            db.closeConnectionManager();
            return pPrice;
        }

        public bool deleteDetail(string bid, string pid)
        {
            db = new MyData();
            cm = new SqlCommand("Exec usp_DeleteDetail @bid, @pid", db.getSqlConn);
            cm.Parameters.AddWithValue("@bid", bid);
            cm.Parameters.AddWithValue("@pid", pid);
            db.openConnectionManager();
            if ((cm.ExecuteNonQuery() >= 1))
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

    }
}
