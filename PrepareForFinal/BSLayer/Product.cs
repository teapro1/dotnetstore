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
    public class Product
    {
        MyData db = null; //Lớp dữ liệu thực hiện các thao tác đóng, mở kết nối, lấy chuỗi, lấy dữ liệu
        SqlCommand cmd;

        public Product()
        {
            db = new MyData();
        }

        public DataSet GetProduct()
        {
            return db.ExecuteQueryDataSet("Select * from Product where p_status = 0", CommandType.Text);
        }

        public DataSet findProduct(string pname)
        {
            db = new MyData();
            db.openConnectionManager();
            DataSet ds = new DataSet();
            try
            {
                cmd = new SqlCommand("usp_FindProduct", db.getSqlConn);
                cmd.Parameters.AddWithValue("@sql_findName", pname);

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

        public bool addProduct(string pid, DateTime idate, DateTime vdate, string name, byte[] image, float price, float quantity, string tid)
        {
            cmd = new SqlCommand("EXEC usp_AddProduct @pid, @idate, @vdate, @name, @image, @price, @quantity, @tid", db.getSqlConn);
            cmd.Parameters.AddWithValue("@pid", pid);
            cmd.Parameters.AddWithValue("@idate", idate);
            cmd.Parameters.AddWithValue("@vdate", vdate);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@image", image.ToArray());
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@quantity", quantity);
            cmd.Parameters.AddWithValue("@tid", tid);

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

        public bool deleteProduct(string pid)
        {
            cmd = new SqlCommand("Exec usp_DeleteProduct @pid", db.getSqlConn);
            cmd.Parameters.AddWithValue("@pid", pid);

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

        public bool updateProduct(string pid, DateTime idate, DateTime vdate, string name, byte[] image, float price, float quantity, string tid)
        {

            cmd = new SqlCommand("EXEC usp_UpdateProduct @pid, @idate, @vdate, @name, @image, @price, @quantity, @tid", db.getSqlConn);
            cmd.Parameters.AddWithValue("@pid", pid);
            cmd.Parameters.AddWithValue("@idate", idate);
            cmd.Parameters.AddWithValue("@vdate", vdate);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@image", image.ToArray());
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@quantity", quantity);
            cmd.Parameters.AddWithValue("@tid", tid);

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

        //Dùng để lấy mã loại sản từ table Type_Product thông qua tên sản phẩm. Lấy mã loại sản phẩm
        //cho việc insert Product
        public string getTypeProductID(ComboBox cb_product)
        {
            MyData db = new MyData();
            db.openConnectionManager();
            string nameType = cb_product.Text;
            cmd = new SqlCommand("Select t_id from Type_Product where t_name = @nameType", db.getSqlConn);
            cmd.Parameters.AddWithValue("@nameType", nameType);
            SqlDataReader DR = cmd.ExecuteReader();
            DR.Read();
            db.closeConnectionManager();
            return DR[0].ToString();
        }

        /*Nối hai bảng để lấy tên loại sản phẩm thông qua tên sản phẩm.
        Mục đích: Khi chọn một dòng trên DataGridView thì combobox sẽ hiển thị loại sản phẩm tương ứng*/
        public void displayTypeProduct(ComboBox cb_product, string pname)
        {
            MyData db = new MyData();
            db.openConnectionManager();
            cmd = new SqlCommand("Select t_name from Product inner join Type_Product on Product.t_id = Type_Product.t_id where p_name = @pname", db.getSqlConn);
            cmd.Parameters.AddWithValue("@pname", pname);
            SqlDataReader DR = cmd.ExecuteReader();
            DR.Read();
            cb_product.Text = DR[0].ToString();
            db.closeConnectionManager();
        }

        public String getTypeID(string tName)
        {
            db = new MyData();
            db.openConnectionManager();
            cmd = new SqlCommand("Select t_id from Type_Product where t_name=@tName and t_status=0", db.getSqlConn);
            cmd.Parameters.AddWithValue("@tName", tName);
            SqlDataReader DR = cmd.ExecuteReader();
            String tid = "";
            while (DR.Read())
            {
                tid = DR[0].ToString();
            }
            db.closeConnectionManager();
            return tid;
        }

        public int getAmount(string pID)
        {
            db = new MyData();
            db.openConnectionManager();
            cmd = new SqlCommand("Select p_quantity from Product where p_id=@pID and p_status=0", db.getSqlConn);
            cmd.Parameters.AddWithValue("@pID", pID);
            SqlDataReader DR = cmd.ExecuteReader();
            int tid = 0;
            while (DR.Read())
            {
                tid = Int32.Parse(DR[0].ToString());
            }
            db.closeConnectionManager();
            return tid;
        }

        public String autoGenerateID()
        {
            return db.autoGenerateID("SELECT dbo.[uf_AutoGenerateID]('Product')");
        }
    }
}