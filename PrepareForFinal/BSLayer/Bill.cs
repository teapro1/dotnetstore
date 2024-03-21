using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrepareForFinal.DBLayer;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.ComponentModel;

namespace PrepareForFinal.BSLayer
{
    public class Bill
    {
        public MyData db = null;
        public SqlCommand cm = null;
        SqlCommand cmd = new SqlCommand();
        public Bill()
        {
            db = new MyData();
        }

        public DataSet GetData()
        {
            DataSet ds = new DataSet();
            ds = db.ExecuteQueryDataSet("select * from Bill where b_status = 0", CommandType.Text);
            return ds;
        }

        // Tìm tên nhân viên theo mã nhân viên
        public String getEName(string eid)
        {
            try
            {
                db = new MyData();
                db.openConnectionManager();
                string sqlCommand = "Select e_name from Bill inner join Employee  on Bill.e_id=Employee.e_id where Bill.e_id=@eid";
                cm = new SqlCommand(sqlCommand, db.getSqlConn);
                cm.Parameters.AddWithValue("@eid", eid);
                SqlDataReader DR = cm.ExecuteReader();
                DR.Read();
                return DR[0].ToString();
                db.closeConnectionManager();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi truy xuất được tên nhân viên, lỗi: " + ex.Message);
                return eid;
            }
        }

        // Tìm tên khách hàng theo mã khách hàng
        public String getCName(string cid)
        {
            try
            {
                db = new MyData();
                db.openConnectionManager();
                string sqlCommand = "Select c_name from Bill inner join Customer  on Bill.c_id=Customer.c_id where Bill.c_id=@cid";
                cm = new SqlCommand(sqlCommand, db.getSqlConn);
                cm.Parameters.AddWithValue("@cid", cid);
                SqlDataReader DR = cm.ExecuteReader();
                DR.Read();
                return DR[0].ToString();
                db.closeConnectionManager();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi truy xuất được tên nhân viên, lỗi: " + ex.Message);
                return cid;
            }
        }

        // Tìm sản phẩm
        public DataSet findBill(string findString)
        {
            db = new MyData();
            db.openConnectionManager();
            DataSet ds = new DataSet();
            try
            {
                cm = new SqlCommand("usp_FindBill", db.getSqlConn);
                cm.Parameters.AddWithValue("@sql_findBill", findString);

                cm.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(); //Tạo một cầu nối giữa SQl command và Database
                da.SelectCommand = cm;
                da.Fill(ds); //Đưa dữ liệu vừa gọi được vào DataSet
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }

        public void getEmployeeName(ComboBox cb_product)
        {
            //Dùng để lấy loại sản phẩm để load lên combobox
            db = new MyData();
            string Sql = "Select e_name from Employee where e_status = 0";
            db.openConnectionManager();
            SqlCommand cmd = new SqlCommand(Sql, db.getSqlConn);
            SqlDataReader DR = cmd.ExecuteReader();

            while (DR.Read())
            {
                cb_product.Items.Add(DR[0]);
            }
            db.closeConnectionManager();
        }

        public void getCustomerName(ComboBox cb_product)
        {
            //Dùng để lấy loại sản phẩm để load lên combobox
            db = new MyData();
            string Sql = "Select c_name from Customer where c_status = 0";
            db.openConnectionManager();
            SqlCommand cmd = new SqlCommand(Sql, db.getSqlConn);
            SqlDataReader DR = cmd.ExecuteReader();

            while (DR.Read())
            {
                cb_product.Items.Add(DR[0]);
            }
            db.closeConnectionManager();
        }

        public String getCustomerPoint(string cName)
        {
            db = new MyData();
            db.openConnectionManager();
            cm = new SqlCommand("Select c_point from Customer where c_name=@cName and c_status=0", db.getSqlConn);
            cm.Parameters.AddWithValue("@cName", cName);
            SqlDataReader DR = cm.ExecuteReader();
            String cpoint = "";
            while (DR.Read())
            {
                cpoint = DR[0].ToString();
            }
            db.closeConnectionManager();
            return cpoint;
        }

        public void getProductName(ComboBox cb_product)
        {
            //Dùng để lấy loại sản phẩm để load lên combobox
            db = new MyData();
            string Sql = "Select p_name from Product where p_status = 0";
            db.openConnectionManager();
            SqlCommand cmd = new SqlCommand(Sql, db.getSqlConn);
            SqlDataReader DR = cmd.ExecuteReader();

            while (DR.Read())
            {
                cb_product.Items.Add(DR[0]);
            }
            db.closeConnectionManager();
        }

        public String getCustomerID(string cName)
        {
            db = new MyData();
            db.openConnectionManager();
            cm = new SqlCommand("Select c_id from Customer where c_name=@cName and c_status=0", db.getSqlConn);
            cm.Parameters.AddWithValue("@cName", cName);
            SqlDataReader DR = cm.ExecuteReader();
            String cid = "";
            while (DR.Read())
            {
                cid = DR[0].ToString();
            }
            db.closeConnectionManager();
            return cid;
        }

        public String getEmployeeID(string eName)
        {
            db = new MyData();
            db.openConnectionManager();
            cm = new SqlCommand("Select e_id from Employee where e_name=@eName and e_status=0", db.getSqlConn);
            cm.Parameters.AddWithValue("@eName", eName);
            SqlDataReader DR = cm.ExecuteReader();
            String cid = "";
            while (DR.Read())
            {
                cid = DR[0].ToString();
            }
            db.closeConnectionManager();
            return cid;
        }

        public bool addBill(string bid, DateTime bdate, float totalPay, String eid, String cid)
        {
            db = new MyData();
            cm = new SqlCommand("EXEC usp_AddBill @bid, @bdate, @totalPay, @eid, @cid", db.getSqlConn);
            cm.Parameters.AddWithValue("@bid", bid);
            cm.Parameters.AddWithValue("@bdate", bdate);
            cm.Parameters.AddWithValue("@totalPay", totalPay);
            cm.Parameters.AddWithValue("@eid", eid);
            cm.Parameters.AddWithValue("@cid", cid);
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

        public bool deleteBill(string bid)
        {
            db = new MyData();
            cm = new SqlCommand("Exec usp_DeleteBill @bid", db.getSqlConn);
            cm.Parameters.AddWithValue("@bid", bid);
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

        public String getBillTotal(string bid)
        {
            db = new MyData();
            db.openConnectionManager();
            cm = new SqlCommand("Select b_totalpay from Bill where b_id=@bid and b_status=0", db.getSqlConn);
            cm.Parameters.AddWithValue("@bid", bid);
            SqlDataReader DR = cm.ExecuteReader();
            String btotalPay = "";
            while (DR.Read())
            {
                btotalPay = DR[0].ToString();
            }
            db.closeConnectionManager();
            return btotalPay;
        }

        public void getTypeProduct(ComboBox cb_product)
        { //Dùng để lấy loại sản phẩm để load lên combobox
            MyData db = new MyData();
            string Sql = "Select * from Type_Product where t_status = 0";
            db.openConnectionManager();
            SqlCommand cmd = new SqlCommand(Sql, db.getSqlConn);
            SqlDataReader DR = cmd.ExecuteReader();

            while (DR.Read())
            {
                cb_product.Items.Add(DR[1]);
            }
            db.closeConnectionManager();
        }
        public String autoGenerateID()
        {
            return db.autoGenerateID("SELECT dbo.[uf_AutoGenerateID]('Bill')");
        }
    }
}
