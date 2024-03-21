using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrepareForFinal.BSLayer;
using RestSharp.Extensions;

namespace PrepareForFinal.UI
{
    public partial class us_customerUI : UserControl
    {
        public Account tk;
        public bool isRole;

        public us_customerUI()
        {
            InitializeComponent();
        }

        DataTable dtCustomer = new DataTable();
        Customer dbCustomer = new Customer();

        bool addFlag;

        public void setRole()
        {
            if (isRole == true)
            {
                btn_customerDelete.Enabled = true;
            }
            if (isRole == false)
            {
                btn_customerDelete.Enabled = false;
            }
        }

        void loadData()
        {
            try
            {
                dtCustomer = new DataTable();
                dtCustomer.Clear();
                DataSet ds = dbCustomer.GetCustomer();
                //Đưa dữ liệu vào Database
                dtCustomer = ds.Tables[0];

                //Đưa dữ liệu lên DataGridView từ DataTable
                dtgv_customerList.DataSource = dtCustomer;
                dtgv_customerList.AutoResizeColumnHeadersHeight();

                setDataGridView();
            }
            catch
            {
                MessageBox.Show("Không load được dữ liệu", MessageBoxIcon.Error.ToString());
            }

            //Cho về trạng thái ban đầu,un-Enabled và Clear dữ liệu trên các Textbox
            initial_Status();
        }

        void initial_Status()
        {
            not_fillingStatus();
            clearTextbox();

            btn_customerAdd.Enabled = true;
            btn_customerUpdate.Enabled = true;
            btn_customerDelete.Enabled = false;
            btn_customerSave.Enabled = false;
            btn_customerCancel.Enabled = false;
        }
        
        void setDataGridView()
        {
            if(dtgv_customerList != null)
            {
                //Set Header Text cho dtgv
                dtgv_customerList.Columns[0].HeaderText = "ID";
                dtgv_customerList.Columns[1].HeaderText = "Tên";
                dtgv_customerList.Columns[2].HeaderText = "Nam";
                dtgv_customerList.Columns[3].HeaderText = "Sinh nhật";
                dtgv_customerList.Columns[4].HeaderText = "Địa chỉ";
                dtgv_customerList.Columns[5].HeaderText = "Phone";
                dtgv_customerList.Columns[6].HeaderText = "Điểm";

                //Ẩn các cột: sinh nhật, địa chỉ, trang thái.
                for (int i = 0; i < dtgv_customerList.ColumnCount; i++)
                {
                    if (i == 3 || i == 4 || i == 7)
                        dtgv_customerList.Columns[i].Visible = false;
                }

                //Set chiều rộng cột
                int width = dtgv_customerList.Width;
                int n_column = dtgv_customerList.ColumnCount;
                dtgv_customerList.Columns[0].Width -= width / n_column;
                dtgv_customerList.Columns[1].Width -= width / n_column;
                dtgv_customerList.Columns[2].Width -= width / n_column;
                dtgv_customerList.Columns[3].Width -= width / n_column;
                dtgv_customerList.Columns[4].Width -= width / n_column;
                dtgv_customerList.Columns[5].Width -= width / n_column;
                dtgv_customerList.Columns[6].Width -= width / n_column;

                dtgv_customerList.AutoResizeColumns();
            }
        }

        void not_fillingStatus()
        {
            txt_customerID.Enabled = false;
            txt_customerName.Enabled = false;
            rb_customerMale.Enabled = false;
            rb_customerFemale.Enabled = false;
            dtp_customerBirthdate.Enabled = false;
            txt_customerAddress.Enabled = false;
            txt_customerPhone.Enabled = false;
            txt_customerPoint.Enabled = false;
        }
        
        void fillingStatus()
        {
            txt_customerID.Enabled = true;
            txt_customerName.Enabled = true;
            rb_customerMale.Enabled = true;
            rb_customerFemale.Enabled = true;
            dtp_customerBirthdate.Enabled = true;
            txt_customerAddress.Enabled = true;
            txt_customerPhone.Enabled = true;
            txt_customerPoint.Enabled = true;
        }

        void clearTextbox()
        {
            txt_customerID.Text = null;
            txt_customerName.Text = null;
            txt_customerAddress.Text = null;
            txt_customerPhone.Text = null;
            txt_customerPoint.Text = null;
            txt_findCustomer.Text = null;
        }

        public void us_customerUI_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btn_customerAdd_Click(object sender, EventArgs e)
        {
            addFlag = true;
            btn_customerAdd.Enabled = false;
            btn_customerSave.Enabled = true;
            btn_customerCancel.Enabled = true;
            btn_customerUpdate.Enabled =false;

            //Mở các ô cho phép điền thông tin\
            fillingStatus();
            clearTextbox();
            txt_customerID.Text = dbCustomer.autoGenerateID();
            txt_customerID.Enabled = false;
            txt_customerPoint.Text = "0";
            txt_customerPoint.Enabled = false;
        }

        private void btn_customerUpdate_Click(object sender, EventArgs e)
        {
            //Trường hợp khi người dùng chưa chọn Khách hàng cần sửa thông tin
            if(txt_customerID.Text == "" || txt_customerID.Text == null)
            {
                MessageBox.Show("Vui lòng chọn Khách hàng cần chỉnh sửa thông tin\n" +
                    "Hoặc nhập ID", "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            btn_customerAdd.Enabled = false;
            btn_customerSave.Enabled = true;
            btn_customerCancel.Enabled = true;
            btn_customerUpdate.Enabled = false;
            btn_customerDelete.Enabled = false;

            //Mở các ô cho phép điền thông tin\
            fillingStatus();
            txt_customerID.Enabled = false;
        }

        private void btn_customerSave_Click(object sender, EventArgs e)
        {
            if(txt_customerID.Text == "" || txt_customerName.Text == "" || txt_customerAddress.Text == ""
                || txt_customerPhone.Text == "" || dtp_customerBirthdate.Value.ToString() == "" ||
                (rb_customerMale.Checked == false && rb_customerFemale.Checked == false))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(addFlag == true) //Trường hợp thêm Khách hàng
            {
                try
                {
                    //Lấy giới tính
                    int isMale = rb_customerMale.Checked ? 1 : 0;

                    if(dbCustomer.addCustomer(txt_customerID.Text.Trim(), txt_customerName.Text.Trim(), isMale, Convert.ToDateTime(dtp_customerBirthdate.Value),txt_customerAddress.Text.Trim(), txt_customerPhone.Text.Trim(),
                        //Lấy giá trị điểm trong Textbox, nếu textbox không có dữ liệu thì cho nó bằng 0
                        0) == true)
                    {
                        MessageBox.Show("Thêm khách hàng thành công");
                        addFlag = false;
                    }
                    else
                    {
                        MessageBox.Show("Thêm khách hàng không thành công");
                    }
                    loadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else //Trường hợp người dùng nhấn update
            {
                try
                {
                    //Lấy giới tính
                    int isMale = rb_customerMale.Checked ? 1 : 0;
                    dbCustomer.updateCustomer(
                        txt_customerID.Text.Trim(),
                        txt_customerName.Text.Trim(),
                        isMale,
                        dtp_customerBirthdate.Value,
                        txt_customerAddress.Text.Trim(),
                        txt_customerPhone.Text.Trim(),
                        //Lấy giá trị điểm trong Textbox, nếu textbox không có dữ liệu thì cho nó bằng 0
                        txt_customerPoint.Text.Trim() != null ? (int)Convert.ToInt32(txt_customerPoint.Text.Trim()) : 0,
                        0);

                    MessageBox.Show("Cập nhật thông tin khách hàng thành công");
                    loadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            initial_Status();
        }

        private void btn_customerCancel_Click(object sender, EventArgs e)
        {
            initial_Status();
        }

        private void dtgv_customerList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Lấy vị trí dòng được chọn
            if (dtgv_customerList.Rows.Count < 1)
            {
                return;
            }
            int index = dtgv_customerList.CurrentCell.RowIndex;

            //Load thông tin từ Cell lên các Textbox
            this.txt_customerID.Text = dtgv_customerList.Rows[index].Cells[0].Value.ToString();
            this.txt_customerName.Text = dtgv_customerList.Rows[index].Cells[1].Value.ToString();
            this.dtp_customerBirthdate.Value = Convert.ToDateTime(dtgv_customerList.Rows[index].Cells[3].Value.ToString());
            this.txt_customerAddress.Text = dtgv_customerList.Rows[index].Cells[4].Value.ToString();
            this.txt_customerPhone.Text = dtgv_customerList.Rows[index].Cells[5].Value.ToString();
            this.txt_customerPoint.Text = dtgv_customerList.Rows[index].Cells[6].Value.ToString();
            //Lấy giới tính và gán lên RadioButton
            rb_customerMale.Checked = Convert.ToInt32(dtgv_customerList.Rows[index].Cells[2].Value) == 1 ? true : false;
            rb_customerFemale.Checked = !rb_customerMale.Checked;

            //Cho phép xóa khách hàng
            btn_customerDelete.Enabled = true;
        }

        private void btn_findCustomer_Click(object sender, EventArgs e)
        {
            if(txt_findCustomer.Text != "" && txt_findCustomer.Text != null)
            {
                try
                {
                    //Lấy dữ liệu
                    DataTable dtCustomer = new DataTable();
                    dtCustomer.Clear();
                    dtCustomer = dbCustomer.findCustomer(txt_findCustomer.Text.Trim()).Tables[0];

                    //Load lại dữ liệu
                    dtgv_customerList.DataSource = dtCustomer;
                    setDataGridView();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_customerDelete_Click(object sender, EventArgs e)
        {
            //kiểm tra khách hàng đã được chọn chưa
            if(txt_customerID.Text == "" || txt_customerID.Text == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Hỏi người dùng là có chắc chắn muốn xóa khách hàng không
                DialogResult respone = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                //Nếu đồng ý
                if (respone == DialogResult.Yes)
                {
                    try
                    {
                        dbCustomer.deleteCustomer(txt_customerID.Text);

                        loadData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    initial_Status();
                    return;
                }
            }
        }
    }
}
