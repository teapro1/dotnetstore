using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepareForFinal.DBLayer
{
    public class MyData
    {
        string strConnectionString = @"Data Source=TEA\SQLEXPRESS;" +
            "Initial Catalog=QLCUAHANG;" +
            "Integrated Security=True;" + "MultipleActiveResultsets = true";

        SqlConnection conn = null; //Đối tượng kết nối 
        SqlCommand comm = null; //Đối tượng truy vấn và cập nhật vào SQL Serverwd
        SqlDataAdapter da = null; //Đối tượng đưa dữ liệu vào DataTable

        public SqlConnection getSqlConn //Lấy chuỗi kết nối
        {
            get
            {
                return conn;
            }
        }

        public MyData() // Hàm khởi tạo: khởi tạo chuỗi kết nối và đối tượng truy vấn
        {
            conn = new SqlConnection(strConnectionString);
            comm = conn.CreateCommand();
        }

        public void openConnectionManager() //Mở kết nối
        {
            if ((conn.State == ConnectionState.Closed))
            {
                conn.Open();
            }
        }

        public void closeConnectionManager() //Đóng kết nối
        {
            if ((conn.State == ConnectionState.Closed))
            {
                conn.Close();
            }
        }

        public DataSet ExecuteQueryDataSet(string strSQL, CommandType ct) //Lấy data thông qua câu truy vấn đưa vào DataSet --> Load lên DataGridView
        {
            if (conn.State == ConnectionState.Open)//Nếu đang mở kết nối trước đó thì đóng lại
                conn.Close();
            conn.Open(); //Tạo một kết nối mới
            comm.CommandText = strSQL; //Đưa câu truy vấn vào SqlCommand
            comm.CommandType = ct; //Chọn kiểu 
            da = new SqlDataAdapter(comm); //Khởi tạo một instance mới với SQLcommand đã cho
            DataSet ds = new DataSet();
            da.Fill(ds); //Đưa dữ liệu truy vào Dataset
            return ds;
        }
        public String autoGenerateID(string strSQL)
        {
            string result = "";
            if (conn.State == ConnectionState.Open)//Nếu đang mở kết nối trước đó thì đóng lại
                conn.Close();
            conn.Open(); //Tạo một kết nối mới
            comm.CommandText = strSQL;
            comm.CommandType = CommandType.Text;
            SqlDataReader dr = comm.ExecuteReader();
            dr.Read();
            result = dr[0].ToString();
            dr.Close();
            conn.Close();
            return result;
        }
    }
}
