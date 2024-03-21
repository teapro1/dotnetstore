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

namespace PrepareForFinal.UI
{
    public partial class us_accountUI : UserControl
    {
        DataTable myDataTable;
        DataSet myAccountDataSet;
        bool isAdd = false;

        Account dbAccount = new Account();


        public us_accountUI()
        {
            InitializeComponent();
        }

        private void us_accountUI_Load(object sender, EventArgs e)
        {
            btn_accountCancel.Enabled = false;
            btn_accountDelete.Enabled = false;
            btn_accountSave.Enabled = false;
            txt_accountUsername.Enabled = false;
            txt_accountPassword.Enabled = false;
            txt_accountEID.Enabled = false;
            rb_employee.Enabled = false;
            rb_manger.Enabled = false;
            cb_accountEName.Enabled = false;
            LoadData();
        }

        void ResetContent()
        {
            txt_accountUsername.ResetText();
            txt_accountPassword.ResetText();
            txt_accountEID.ResetText();
            rb_manger.Checked = false;
            rb_employee.Checked = false;
        }
        private void btn_accountAdd_Click(object sender, EventArgs e)
        {
            btn_accountAdd.Enabled = false;
            btn_accountUpdate.Enabled = false;
            btn_accountSave.Enabled = true;
            btn_accountCancel.Enabled = true;
            txt_accountUsername.Enabled = true;
            txt_accountPassword.Enabled = true;
            cb_accountEName.Enabled = true;
            isAdd = true;
            Bill myBill = new Bill();
            cb_accountEName.Items.Clear();
            myBill.getEmployeeName(cb_accountEName);
            ResetContent();
        }

        private void btn_accountSave_Click(object sender, EventArgs e)
        {
            if (isAdd == true)
            {
                try
                {
                    Employee employee = new Employee();
                    if (dbAccount.addAccount(txt_accountUsername.Text.Trim(), txt_accountPassword.Text.Trim(), employee.getEmployeeID(cb_accountEName.Text)) == true)
                    {
                        isAdd = false;
                    }
                    else
                    {
                        MessageBox.Show("Thêm tài khoản KHÔNG thành công");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm không được, lỗi: " + ex.Message);
                }
            }
            else
            {
                try
                {
                    Employee employee = new Employee();
                    if (dbAccount.updateAccount(txt_accountPassword.Text.Trim(), employee.getEmployeeID(cb_accountEName.Text)) == true)
                    {
                        isAdd = false;
                    }
                    else
                    {
                        MessageBox.Show("Đối mật khẩu thành công");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không đổi được lỗi, lỗi: " + ex.Message);
                }

            }
            btn_accountAdd.Enabled = true;
            btn_accountUpdate.Enabled = true;
            btn_accountSave.Enabled = false;
            btn_accountCancel.Enabled = false;
            txt_accountUsername.Enabled = true;
            txt_accountUsername.Enabled = false;
            txt_accountPassword.Enabled = false;
            txt_accountEID.Enabled = false;
            cb_accountEName.Enabled = false;

            isAdd = false;
            ResetContent();
            LoadData();
        }

        private void btn_accountCancel_Click(object sender, EventArgs e)
        {
            btn_accountAdd.Enabled = true;
            btn_accountUpdate.Enabled = true;
            btn_accountSave.Enabled = false;
            btn_accountCancel.Enabled = false;
            txt_accountUsername.Enabled = true;
            txt_accountUsername.Enabled = false;
            txt_accountPassword.Enabled = false;
            cb_accountEName.Enabled = false;
            cb_accountEName.Items.Clear();
            isAdd = false;
            ResetContent();
        }

        private void btn_accountUpdate_Click(object sender, EventArgs e)
        {
            btn_accountAdd.Enabled = false;
            btn_accountUpdate.Enabled = false;
            btn_accountSave.Enabled = true;
            btn_accountCancel.Enabled = true;
            txt_accountUsername.Enabled = false;
            txt_accountPassword.Enabled = true;
            cb_accountEName.Enabled = false;
            /*Bill myBill = new Bill();
            cb_accountEName.Items.Clear();
            myBill.getEmployeeName(cb_accountEName);*/
            isAdd = false;
        }
        private void CustomeAccountDataGridView()
        {
            dtgv_accountList.AllowUserToAddRows = false;
            dtgv_accountList.Columns[0].HeaderText = "Username";
            dtgv_accountList.Columns[1].HeaderText = "Password";
            dtgv_accountList.Columns[2].HeaderText = "Nhân viên";
            dtgv_accountList.Columns[3].Visible = false;
            dtgv_accountList.Columns[4].Visible = false;
            dtgv_accountList.Columns[5].Visible = false;
        }

        private void LoadData()
        {
            Account account = new Account();
            try
            {
                myDataTable = new DataTable();
                myAccountDataSet = new DataSet();
                // Lấy data đưa vào dataset
                myAccountDataSet = account.GetData();
                // Đưa dữ liệu từ dataset vào table
                myDataTable = myAccountDataSet.Tables[0];
                // Đổ data vào datagridview
                dtgv_accountList.DataSource = myDataTable;
                // Tùy chỉnh giao diện cho cái list
                CustomeAccountDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi", "Không hiển thị được thông tin, Lỗi: " + ex.Message);
            }

            cb_accountEName.Items.Clear();
            Bill myBill = new Bill();
            myBill.getEmployeeName(cb_accountEName);
        }

        private void dtgv_accountList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_accountDelete.Enabled = false;
            // Lấy dòng đang được ấy
            if (dtgv_accountList.Rows.Count < 1)
            {
                return;
            }
            int row = dtgv_accountList.CurrentCell.RowIndex;

            btn_accountDelete.Enabled = false;

            // Lấy thông tin từ list đưa lên textbox
            txt_accountUsername.Text = dtgv_accountList.Rows[row].Cells[0].Value.ToString();
            txt_accountPassword.Text = dtgv_accountList.Rows[row].Cells[1].Value.ToString();
            cb_accountEName.Text = dtgv_accountList.Rows[row].Cells[2].Value.ToString();
            txt_accountEID.Text = dtgv_accountList.Rows[row].Cells[5].Value.ToString();
            if ((bool)dtgv_accountList.Rows[row].Cells[3].Value == true)
            {
                rb_manger.Checked = true;
            }
            else
            {
                rb_employee.Checked = true;
            }
        }

        private void btn_findAccount_Click(object sender, EventArgs e)
        {
            if (txt_findAccount.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin tài khoản");
            }
            else
            {
                Account account = new Account();
                try
                {
                    myDataTable = new DataTable();
                    myDataTable.Clear();
                    myDataTable = dbAccount.findAccount(txt_findAccount.Text).Tables[0];

                    // Đổ data vào datagridview
                    dtgv_accountList.DataSource = myDataTable;
                    // Tùy chỉnh giao diện cho cái list
                    CustomeAccountDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi", "Không hiển thị được thông tin, Lỗi: " + ex.Message);
                }
            }
        }

        private void cb_accountEName_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bill bill=new Bill();
            Employee employee = new Employee();
            if (cb_accountEName.Text != "")
            {
                txt_accountEID.Text = bill.getEmployeeID(cb_accountEName.Text.Trim());
                if (employee.getEmployeeRole(cb_accountEName.Text) == "True")
                {
                    rb_manger.Checked = true;
                }
                else
                {
                    rb_employee.Checked = true;
                }
            }
        }

        private void cb_accountEName_SelectedValueChanged(object sender, EventArgs e)
        {
            Bill bill = new Bill();
            Employee employee = new Employee();
            if (cb_accountEName.Text != "")
            {
                txt_accountEID.Text = bill.getEmployeeID(cb_accountEName.Text.Trim());
                if (employee.getEmployeeRole(cb_accountEName.Text) == "1")
                {
                    rb_manger.Checked = true;
                }
                else
                {
                    rb_employee.Checked = true;
                }
            }
        }

        private void btn_customerInfo_Click(object sender, EventArgs e)
        {

        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}

