using PrepareForFinal.BSLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrepareForFinal.UI
{
    public partial class us_employeeUI : UserControl
    {
        public us_employeeUI()
        {
            InitializeComponent();
            LoadData();
        }
        DataTable dtEmployee = null;
        Employee dbEmployee = new Employee();
        bool Flag;
         

        void LoadData()
        {
            this.txt_employeeID.Enabled = false;
            this.txt_employeeName.Enabled = false;
            this.txt_employeePhone.Enabled = false;
            this.txt_employeeAddress.Enabled = false;
            this.num_employeeSalary.Enabled = false;
            this.cb_employeeRole.Enabled = false;
            this.dtp_employeeBirthdate.Enabled = false;
            this.dtp_employeeHireDate.Enabled = false;
            this.rb_employeeFemale.Enabled = false;
            this.rb_employeeMale.Enabled = false;
            try
            {
                dtEmployee = new DataTable();
                dtEmployee.Clear();
                DataSet ds = dbEmployee.GetEmployee(); // Lấy dữ liệu Employee đưa vào Dataset
                //Đưa dữ liệu vào Datatable 
                dtEmployee = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView từ DataTable
                dgv_Employee.DataSource = dtEmployee;
                // Thay đổi độ rộng cột 

                int width = dgv_Employee.Width / 9;
                dgv_Employee.AutoResizeColumns();
                for(int i=0;i< dgv_Employee.Columns.Count; i++)
                    dgv_Employee.Columns[i].Width = width;
                
                dgv_Employee.AllowUserToAddRows = false;

                /*dgv_product.RowHeadersVisible = false;*/
                //
                for (int i = 0; i < 10; i++)
                {
                    if (i == 0 ||i==1 ||i== 5 ||i ==8 )
                        continue;
                    dgv_Employee.Columns[i].Visible = false;
                }

                for(int i=0;i< dgv_Employee.Rows.Count;i++)
                {
                    var cell = dgv_Employee.Rows[i].Cells[6];
                    /*if (Boolean.Parse(cell.Value))
                    {
                        dgv_Employee.Rows[i].Cells[6].Value= "Quản lý";
                    }
                    else
                    {
                        dgv_Employee.Rows[i].Cells[6].Value = "Nhân viên";
                    */
                    
                }


            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được sản phẩm");
            }

            this.txt_employeeID.ResetText();
            this.txt_employeeName.ResetText();
            this.txt_employeePhone.ResetText();
            this.txt_findEmployee.ResetText();
            this.txt_employeeAddress.ResetText();
            this.num_employeeSalary.ResetText();
            this.cb_employeeRole.ResetText();

            btn_employeeAdd.Enabled = true;
            btn_employeeDelete.Enabled = true;
            btn_employeeSave.Enabled = false;
            btn_employeeUpdate.Enabled = true;
            btn_findEmployee.Enabled = false;
            btn_employeeCancel.Enabled = false;
            
        }
        private void us_employeeUI_Load(object sender, EventArgs e)
        {
            this.cb_employeeRole.Items.AddRange(new object[]{
                "Nhân Viên",
                "Quản lí"
            });
            btn_employeeSave.Enabled = false;
            btn_employeeCancel.Enabled = false;
            btn_employeeDelete.Enabled = true;
            btn_findEmployee.Enabled = false;
        }

        private void btn_employeeAdd_Click(object sender, EventArgs e)
        {
            Flag = true;
            btn_employeeSave.Enabled = true;
            btn_employeeCancel.Enabled = true;
            btn_employeeAdd.Enabled = false;
            btn_employeeUpdate.Enabled = false;

            this.txt_employeeID.Enabled = true;
            this.txt_employeeName.Enabled = true;
            this.txt_employeePhone.Enabled = true;
            this.txt_employeeAddress.Enabled = true;
            this.num_employeeSalary.Enabled = true;
            this.cb_employeeRole.Enabled = true;
            this.dtp_employeeBirthdate.Enabled = true;
            this.dtp_employeeHireDate.Enabled = true;
            this.rb_employeeFemale.Enabled = true;
            this.rb_employeeMale.Enabled = true;

            this.txt_employeeID.ResetText();
            this.txt_employeeName.ResetText();
            this.txt_employeePhone.ResetText();
            this.txt_findEmployee.ResetText();
            this.txt_employeeAddress.ResetText();
            this.num_employeeSalary.ResetText();
            this.cb_employeeRole.ResetText();
            this.rb_employeeFemale.Checked = false;
            this.rb_employeeMale.Checked = false;

            txt_employeeID.Text = dbEmployee.autoGenerateID();
            txt_employeeID.Enabled = false;
        }

        private void btn_employeeUpdate_Click(object sender, EventArgs e)
        {
            this.txt_employeeID.Enabled = true;
            this.txt_employeeName.Enabled = true;
            this.txt_employeePhone.Enabled = true;
            this.txt_employeeAddress.Enabled = true;
            this.num_employeeSalary.Enabled = true;
            this.cb_employeeRole.Enabled = true;
            this.dtp_employeeBirthdate.Enabled = true;
            this.dtp_employeeHireDate.Enabled = true;
            this.rb_employeeFemale.Enabled = true;
            this.rb_employeeMale.Enabled = true;

            btn_employeeSave.Enabled = true;
            btn_employeeCancel.Enabled = true;
            btn_employeeAdd.Enabled = false;
            btn_employeeUpdate.Enabled = false;
            txt_employeeID.Enabled = false;
            Flag = false;
        }

        private void btn_employeeSave_Click(object sender, EventArgs e)
        {
            if (Flag == true)
            {
                try
                {
                    dbEmployee.addEmployee(txt_employeeID.Text.Trim(), txt_employeeName.Text.Trim(), (dbEmployee.ConvertGenderToDB(this.rb_employeeMale,this.rb_employeeFemale)), Convert.ToDateTime(dtp_employeeBirthdate.Value),
                        txt_employeeAddress.Text.Trim(), txt_employeePhone.Text.Trim(), Convert.ToInt32(dbEmployee.getPositionToDB(this.cb_employeeRole)),
                        Convert.ToDateTime(dtp_employeeHireDate.Value), (float)Convert.ToDouble(num_employeeSalary.Text.Trim()));
                    
                    Flag = false;
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    dbEmployee.updateEmployee(txt_employeeID.Text.Trim(), txt_employeeName.Text.Trim(), (dbEmployee.ConvertGenderToDB(this.rb_employeeMale,this.rb_employeeFemale)), Convert.ToDateTime(dtp_employeeBirthdate.Value),
                        txt_employeeAddress.Text.Trim(), txt_employeePhone.Text.Trim(), Convert.ToInt32(dbEmployee.getPositionToDB(this.cb_employeeRole)),
                    Convert.ToDateTime(dtp_employeeHireDate.Value), (float)Convert.ToDouble(num_employeeSalary.Text.Trim()));
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
            btn_employeeSave.Enabled = false;
            btn_employeeCancel.Enabled = false;
            btn_employeeAdd.Enabled = true;
            btn_employeeUpdate.Enabled = true;
            txt_employeeID.Enabled = true;

            this.txt_employeeID.Enabled = false;
            this.txt_employeeName.Enabled = false;
            this.txt_employeePhone.Enabled = false;
            this.txt_employeeAddress.Enabled = false;
            this.num_employeeSalary.Enabled = false;
            this.cb_employeeRole.Enabled = false;
            this.dtp_employeeBirthdate.Enabled = false;
            this.dtp_employeeHireDate.Enabled = false;
            this.rb_employeeFemale.Enabled = false;
            this.rb_employeeMale.Enabled = false;
        }

        private void btn_employeeCancel_Click(object sender, EventArgs e)
        {
            this.txt_employeeID.Enabled = false;
            this.txt_employeeName.Enabled = false;
            this.txt_employeePhone.Enabled = false;
            this.txt_employeeAddress.Enabled = false;
            this.num_employeeSalary.Enabled = false;
            this.cb_employeeRole.Enabled = false;
            this.dtp_employeeBirthdate.Enabled = false;
            this.dtp_employeeHireDate.Enabled = false;
            this.rb_employeeFemale.Enabled = false;
            this.rb_employeeMale.Enabled = false;

            btn_employeeSave.Enabled = false;
            btn_employeeCancel.Enabled = false;
            btn_employeeAdd.Enabled = true;
            btn_employeeUpdate.Enabled = true;
            LoadData();
            btn_findEmployee.Enabled = false;
            this.txt_findEmployee.ResetText();
            
        }

        private void dgv_Employee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Dòng hiện hành
            int r = dgv_Employee.CurrentCell.RowIndex;

            // Chuyển thông tin lên panel 
            this.txt_employeeID.Text = dgv_Employee.Rows[r].Cells[0].Value.ToString();
            this.txt_employeeName.Text = dgv_Employee.Rows[r].Cells[1].Value.ToString();

            if ((bool)(dgv_Employee.Rows[r].Cells[2].Value))
            {
                this.rb_employeeMale.Checked = true;
            }
            else
            {
                this.rb_employeeFemale.Checked = true;
            }
            this.txt_employeePhone.Text = dgv_Employee.Rows[r].Cells[5].Value.ToString();
            this.txt_employeeAddress.Text = dgv_Employee.Rows[r].Cells[4].Value.ToString();

            this.dtp_employeeBirthdate.Value = Convert.ToDateTime(dgv_Employee.Rows[r].Cells[3].Value.ToString());
            this.dtp_employeeHireDate.Value = Convert.ToDateTime(dgv_Employee.Rows[r].Cells[7].Value.ToString());

            if ((bool)(dgv_Employee.Rows[r].Cells[6].Value))
            {
                this.cb_employeeRole.Text = "Quản Lí";
            }
            else
            {
                this.cb_employeeRole.Text = "Nhân Viên";
            }

            this.num_employeeSalary.Value = Int32.Parse(dgv_Employee.Rows[r].Cells[8].Value.ToString());
        }

        private void btn_findEmployee_Click(object sender, EventArgs e)
        {
            if (txt_findEmployee.Text != "")
            {
                dtEmployee = new DataTable();
                dtEmployee.Clear();
                dtEmployee = dbEmployee.findEmployee(txt_findEmployee.Text).Tables[0];
                dgv_Employee.DataSource = dtEmployee;


                int width = dgv_Employee.Width / 5;
                dgv_Employee.AutoResizeColumns();
                dgv_Employee.Columns[0].Width = width;
                dgv_Employee.Columns[1].Width = width;
                dgv_Employee.Columns[5].Width = width;
                dgv_Employee.Columns[6].Width = width;
                dgv_Employee.Columns[8].Width = width;
                dgv_Employee.AllowUserToAddRows = false;
                for (int i = 0; i < 9; i++)
                {
                    if (i == 0 || i == 1 || i == 5 || i == 8)
                        continue;
                    dgv_Employee.Columns[i].Visible = false;
                }
                  
            }
            else
            {
                MessageBox.Show("Nhập tên sản phẩm cần tìm");
            }

        }

        private void btn_employeeDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Xác nhận xóa Nhân Viên?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    dbEmployee.deleteEmployee(this.txt_employeeID.Text);
                    // Cập nhật lại DataGridView 
                    LoadData();
                    // Thông báo 
                    MessageBox.Show("Đã xóa xong!");

                }
                else
                {
                    // Thông báo 
                    MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }
        }

        private void txt_findEmployee_TextChanged(object sender, EventArgs e)
        {
            if (txt_findEmployee.Enabled==true)
                btn_findEmployee.Enabled = true;
            btn_employeeCancel.Enabled = true;
        }
    }
}
