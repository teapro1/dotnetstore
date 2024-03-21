using PrepareForFinal.DBLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrepareForFinal.BSLayer
{
    public class Account
    {
        MyData db = null; //Lớp dữ liệu thực hiện các thao tác đóng, mở kết nối, lấy chuỗi, lấy dữ liệu
        SqlCommand cmd;
        public string username { get; set; }
        public string password { get; set; }
        public bool isRole { get; set; }
        public string name { get; set; }
        public string eid { get; set; }
        public Account(string Username, string Password, string Name, string Eid, bool Role)
        {
            username = Username;
            password = Password;
            name = Name;
            isRole = Role;
            eid = Eid;
        }
        public Account()
        {
            db = new MyData();
        }
        public bool testLogin(string username, string password)
        {
            db = new MyData();
            db.openConnectionManager();
            cmd = new SqlCommand("SELECT dbo.uf_CheckLogin(@a_username, @a_password)", db.getSqlConn);
            cmd.Parameters.AddWithValue("@a_username", username);
            cmd.Parameters.AddWithValue("@a_password", password);
            int result = (int)cmd.ExecuteScalar();
            if (result > 0)
            {
                return true;
            }

            return false;
        }
        public DataSet GetAccount(string username, string password)
        {
            return db.ExecuteQueryDataSet("Select * from dbo.uf_PermissionRole('" + username + "', '" + password + "')", CommandType.Text);
        }
        public bool getRole(string username, string password)
        {
            db.openConnectionManager();
            return true;
        }
        public DataSet GetData()
        {
            db = new MyData();
            DataSet ds = new DataSet();
            ds = db.ExecuteQueryDataSet("select * from V_AccountInfo where status = 0", CommandType.Text);
            return ds;
        }
        public DataSet findAccount(string aInfo)
        {
            db = new MyData();
            db.openConnectionManager();
            DataSet ds = new DataSet();
            try
            {
                cmd = new SqlCommand("usp_FindAccount", db.getSqlConn);
                cmd.Parameters.AddWithValue("@sql_findName", aInfo);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(); //Tạo một cầu nối giữa SQl command và Database
                da.SelectCommand = cmd;
                da.Fill(ds); //Đưa dữ liệu vừa gọi được vào DataSet
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }

        public bool addAccount(string username, string password, string eid)
        {
            db = new MyData();
            cmd = new SqlCommand("EXEC usp_AddAccount @username, @password, @eid", db.getSqlConn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@eid", eid);
            db.openConnectionManager();
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                db.closeConnectionManager();
            }
        }


        public bool updateAccount(string password, string eid)
        {
            db = new MyData();
            cmd = new SqlCommand("EXEC usp_UpdateAccount @password, @eid", db.getSqlConn);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@eid", eid);
            db.openConnectionManager();
            if ((cmd.ExecuteNonQuery() >= 1))
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
