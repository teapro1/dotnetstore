using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using PrepareForFinal.DBLayer;
using System.Windows.Forms;

namespace PrepareForFinal.BSLayer
{
    public class Employee
    {
        MyData db = null; //Lớp dữ liệu thực hiện các thao tác đóng, mở kết nối, lấy chuỗi, lấy dữ liệu
        SqlCommand cmd;
        public Employee()
        {
            db = new MyData();

        }
        public DataSet GetEmployee()
        {

            return db.ExecuteQueryDataSet("Select * from Employee where e_status = 0", CommandType.Text);
        }

        public DataSet findEmployee(string pname)
        {
            db.openConnectionManager();
            DataSet ds = new DataSet();
            try
            {

                cmd = new SqlCommand("usp_FindEmloyee", db.getSqlConn);
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

        public bool addEmployee(string id, string name, string gender, DateTime date, string address, string phone, int position, DateTime hireDate, float salary)
        {
            cmd = new SqlCommand("EXEC usp_AddEmployee @id, @name, @gender, @date, @address, @phone, @position, @hireDate,@salary", db.getSqlConn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@position", position);
            cmd.Parameters.AddWithValue("@hireDate", hireDate);
            cmd.Parameters.AddWithValue("@salary", salary);

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

        public bool deleteEmployee(string eid)
        {
            cmd = new SqlCommand("Exec usp_DeleteEmployee @id", db.getSqlConn);
            cmd.Parameters.AddWithValue("@id", eid);

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

        public bool updateEmployee(string id, string name, string gender, DateTime date, string address, string phone,
            int position, DateTime hireDate, float salary)
        {

            cmd = new SqlCommand("EXEC usp_UpdateEmployee @id, @name, @gender, @date, @address, @phone, @position, @hireDate,@salary", db.getSqlConn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@position", position);
            cmd.Parameters.AddWithValue("@hireDate", hireDate);
            cmd.Parameters.AddWithValue("@salary", salary);

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


        public String getPositionToDB(ComboBox cb)
        {
            string selectedItem = cb.SelectedItem.ToString();
            if (selectedItem == "Quản lí")
                return "1";
            else
                return "0";

        }
        public String ConvertGenderToDB(RadioButton rdb_male, RadioButton rdb_Female)
        {
            if (rdb_male.Checked || rdb_Female.Checked == true)
                return "1";
            else
                return "0";
        }

        public int CountEmployee()
        {
            cmd.CommandText = "Select count(*) from Employee";
            return (int)cmd.ExecuteScalar();
        }

        public String getEmployeeID(string eName)
        {
            db = new MyData();
            db.openConnectionManager();
            cmd = new SqlCommand("Select e_id from Employee where e_name=@eName and e_status=0", db.getSqlConn);
            cmd.Parameters.AddWithValue("@eName", eName);
            SqlDataReader DR = cmd.ExecuteReader();
            String eid = "";
            while (DR.Read())
            {
                eid = DR[0].ToString();
            }
            db.closeConnectionManager();
            return eid;
        }
        public String autoGenerateID()
        {
            return db.autoGenerateID("SELECT dbo.[uf_AutoGenerateID]('Employee')");
        }

        public String getEmployeeRole(string eName)
        {
            db = new MyData();
            db.openConnectionManager();
            cmd = new SqlCommand("Select e_position from Employee where e_name=@eName and e_status=0", db.getSqlConn);
            cmd.Parameters.AddWithValue("@eName", eName);
            SqlDataReader DR = cmd.ExecuteReader();
            String eRole = "";
            while (DR.Read())
            {
                eRole = DR[0].ToString();
            }
            db.closeConnectionManager();
            return eRole;
        }
    }
}
