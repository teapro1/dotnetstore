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
    public class Supply
    {
        MyData db = null; //Lớp dữ liệu thực hiện các thao tác đóng, mở kết nối, lấy chuỗi, lấy dữ liệu
        SqlCommand cmd;
        public Supply()
        {
            db = new MyData();

        }
        public DataSet GetSupply()
        {

            return db.ExecuteQueryDataSet("Select * from Supply where s_status = 0", CommandType.Text);
        }

        public DataSet findSupply(string pname)
        {
            db.openConnectionManager();
            DataSet ds = new DataSet();
            try
            {

                cmd = new SqlCommand("usp_FindSupply", db.getSqlConn);
                cmd.Parameters.AddWithValue("@sql_findSupply", pname);

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

        public bool addSupply(string s_id, string name, string address, string phone, string p_id)
        {
            Console.WriteLine("begin\n" + s_id + name + address + phone + p_id + "end");
            cmd = new SqlCommand("EXEC usp_AddSupply @s_id, @name, @address, @phone, @p_id", db.getSqlConn);
            cmd.Parameters.AddWithValue("@s_id", s_id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@p_id", p_id);

            db.openConnectionManager();
            if ((cmd.ExecuteNonQuery() == 1))
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

        public bool deleteSupply(string s_id)
        {
            cmd = new SqlCommand("Exec usp_DeleteSupply @id", db.getSqlConn);
            cmd.Parameters.AddWithValue("@id", s_id);

            db.openConnectionManager();
            if ((cmd.ExecuteNonQuery() == 1))
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

        public bool updateSupply(string sid, string name, string address, string phone, string pid)
        {

            cmd = new SqlCommand("EXEC usp_UpdateSupply @sid, @name, @address, @phone, @pid", db.getSqlConn);
            cmd.Parameters.AddWithValue("@sid", sid);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@pid", pid);
            
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


        public void displayNameProduct(ComboBox cb_product, string sname)
        {
            MyData db = new MyData();
            db.openConnectionManager();
            cmd = new SqlCommand("Select p_name from Product inner join Supply on Product.p_id = Supply.p_id where s_id = @sname", db.getSqlConn);
            cmd.Parameters.AddWithValue("@sname", sname);
            SqlDataReader DR = cmd.ExecuteReader();
            DR.Read();
            //DR.NextResult();
            cb_product.Text = DR[0].ToString();
            db.closeConnectionManager();
            
        }

        public String getProductID(ComboBox cb_product)
        {
            MyData db = new MyData();
            db.openConnectionManager();
            string nameProduct = cb_product.Text;
            cmd = new SqlCommand("Select p_id from Product where p_name = @nameProduct", db.getSqlConn);
            cmd.Parameters.AddWithValue("@nameProduct", nameProduct);
            cmd.CommandType = CommandType.Text;
            SqlDataReader DR = cmd.ExecuteReader();
            DR.Read();
            db.closeConnectionManager();
            return DR[0].ToString();
        }

        public void getListProduct(ComboBox cb_product)
        {
            //Dùng để lấy loại sản phẩm để load lên combobox
            cb_product.Items.Clear();
            MyData db = new MyData();
            string Sql = "Select * from Product where p_status = 0";
            db.openConnectionManager();
            SqlCommand cmd = new SqlCommand(Sql, db.getSqlConn);
            SqlDataReader DR = cmd.ExecuteReader();

            while (DR.Read())
            {
                cb_product.Items.Add(DR[3]);
            }
            db.closeConnectionManager();
        }

        public String autoGenerateID()
        {
            return db.autoGenerateID("SELECT dbo.[uf_AutoGenerateID]('Supply')");
        }
    }
}
