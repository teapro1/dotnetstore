using PrepareForFinal.DBLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrepareForFinal.BSLayer
{
    public  class Statistic
    {
        MyData db = null; //Lớp dữ liệu thực hiện các thao tác đóng, mở kết nối, lấy chuỗi, lấy dữ liệu
        SqlCommand cmd;

        public Statistic()
        {
            db = new MyData();
        }
        public struct SalesSummary
        {
            public decimal TotalSales;
            public int TotalBills;
        }

        public SalesSummary GetTotalSales()
        {
            SalesSummary salesSummary = new SalesSummary();
            MyData db = new MyData();

            // Mở kết nối đến cơ sở dữ liệu
            db.openConnectionManager();

            // Chuỗi truy vấn SQL để lấy tổng số tiền từ bảng giao dịch và tổng số hóa đơn
            string queryTotalSales = "SELECT SUM(b_totalpay) FROM Bill";
            string queryTotalBills = "SELECT COUNT(b_id) FROM Bill";

            // Tạo đối tượng SqlCommand để thực thi truy vấn
            using (SqlCommand commandTotalSales = new SqlCommand(queryTotalSales, db.getSqlConn))
            using (SqlCommand commandTotalBills = new SqlCommand(queryTotalBills, db.getSqlConn))
            {
                // Thực thi truy vấn và lấy kết quả
                object resultTotalSales = commandTotalSales.ExecuteScalar();
                object resultTotalBills = commandTotalBills.ExecuteScalar();

                // Kiểm tra xem kết quả có null không và gán cho salesSummary
                if (resultTotalSales != null && resultTotalSales != DBNull.Value)
                {
                    salesSummary.TotalSales = Convert.ToDecimal(resultTotalSales);
                }

                if (resultTotalBills != null && resultTotalBills != DBNull.Value)
                {
                    salesSummary.TotalBills = Convert.ToInt32(resultTotalBills);
                }
            }

            return salesSummary;
        }


        public void getProduct(ComboBox cb_product)
        { //Dùng để lấy loại sản phẩm để load lên combobox
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

        public DataSet GetProductMonth(string id, int month, int year)
        {
            cmd = new SqlCommand("SELECT dbo.[uf_CountProductSale](@id, @month, @year)", db.getSqlConn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@month", month);
            cmd.Parameters.AddWithValue("@year", year);
            DataSet ds = new DataSet();
            SqlDataAdapter dataAdapter;
            try
            {
                db.openConnectionManager();
                dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(ds);
            }
            catch (Exception ex)
            {
                ds = null;
                MessageBox.Show(ex.Message);
            }
            return ds;

        }

        public string getProductID(ComboBox cb_productname)
        {
            MyData db = new MyData();
            db.openConnectionManager();
            string name = cb_productname.Text;
            cmd = new SqlCommand("Select p_id from Product where p_name = @name", db.getSqlConn);
            cmd.Parameters.AddWithValue("@name", name);
            SqlDataReader DR = cmd.ExecuteReader();
            DR.Read();
            db.closeConnectionManager();
            return DR[0].ToString();
        }

        public DataSet getBillOfCustomer()
        {
            cmd = new SqlCommand("SELECT * FROM v_BillOfCustomer", db.getSqlConn);
            DataSet ds = new DataSet();
            SqlDataAdapter dataAdapter;
            try
            {
                db.openConnectionManager();
                dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(ds);
            }
            catch (Exception ex)
            {
                ds = null;
                MessageBox.Show(ex.Message);
            }
            return ds;
        }
    }
}
