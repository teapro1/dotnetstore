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
    public partial class frm_billList : Form
    {
        Bill myBill;
        DataSet myBillDataSet;
        DataTable myDataTable;
        Detail myDetail;
        
        public frm_billList()
        {
            InitializeComponent();
        }

        private void UnenableInputControl()
        {
            btn_billDelete.Enabled = false;
            txt_billProductPrice.Enabled = false; 
            txt_billCName.Enabled = false;
            txt_billEName.Enabled = false;
            txt_billID.Enabled = false;
            txt_billProductName.Enabled = false;
            txt_billProductPrice.Enabled = false;
            txt_billQuantity.Enabled = false;
            txt_billTotalPrice.Enabled = false;
            dtp_billDate.Enabled = false;
            txt_billTotalPay.Enabled = false;
        }

        private void ResetInputControl()
        {
            txt_billProductPrice.ResetText();
            txt_billCName.ResetText();
            txt_billEName.ResetText();
            txt_billID.ResetText();
            txt_billProductName.ResetText();
            txt_billProductPrice.ResetText();
            txt_billQuantity.ResetText();
            txt_billTotalPrice.ResetText();
            txt_billTotalPay.ResetText();
        }

        private void CustomeBillDataGridView()
        {
            dtgv_billList.AllowUserToAddRows = false;
            dtgv_billList.Columns[0].HeaderText = "Mã HĐ";
            dtgv_billList.Columns[1].HeaderText = "Ngày lập";
            dtgv_billList.Columns[2].HeaderText = "Tồng tiền";
            dtgv_billList.Columns[3].HeaderText = "Mã NV";
            dtgv_billList.Columns[4].HeaderText = "Mã KH";
        }

        private void CustomeDetailDataGridView()
        {
            dtgv_billDetailList.AllowUserToAddRows = false;
            dtgv_billDetailList.Columns[0].HeaderText = "Sản phẩm";
            dtgv_billDetailList.Columns[1].HeaderText = "Số lượng";
            dtgv_billDetailList.Columns[2].HeaderText = "Đơn giá";
            dtgv_billDetailList.Columns[3].HeaderText = "Thành tiền";
            dtgv_billDetailList.Columns[4].Visible= false;
            dtgv_billDetailList.Columns[5].Visible = false;
        }
        private void LoadData()
        {
            try
            {
                myDataTable = new DataTable();
                myBill = new Bill();
                myBillDataSet = new DataSet();
                // Lấy data đưa vào dataset
                myBillDataSet = myBill.GetData();
                // Đưa dữ liệu từ dataset vào table
                myDataTable = myBillDataSet.Tables[0];
                // Đổ data vào datagridview
                dtgv_billList.DataSource= myDataTable;
                // Tùy chỉnh giao diện cho cái list
                CustomeBillDataGridView();
                dtgv_billList.Columns[5].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi", "Không hiển thị được thông tin, Lỗi: " + ex.Message);
            }

        }
        private void frm_billList_Load(object sender, EventArgs e)
        {
            dtp_billDate.Value = DateTime.Today;
            UnenableInputControl();
            LoadData();
        }

        private void dtgv_billList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_billDelete.Enabled = false;
            // Lấy dòng đang được ấy
            if (dtgv_billList.Rows.Count<1)
            {
                return;
            }
            int row = dtgv_billList.CurrentCell.RowIndex;
            
            btn_billDelete.Enabled = true;

            // Lấy thông tin từ list đưa lên textbox
            txt_billID.Text = dtgv_billList.Rows[row].Cells[0].Value.ToString();
            dtp_billDate.Value = Convert.ToDateTime(dtgv_billList.Rows[row].Cells[1].Value.ToString());
            txt_billTotalPay.Text = dtgv_billList.Rows[row].Cells[2].Value.ToString();
            txt_billEName.Text = GetEName(dtgv_billList.Rows[row].Cells[3].Value.ToString());
            txt_billCName.Text = GetCName(dtgv_billList.Rows[row].Cells[4].Value.ToString());


            // Hiển thị thông tin chi tiết hóa đơn
            myDetail = new Detail();
            dtgv_billDetailList.DataSource = myDetail.GetData(txt_billID.Text.ToString()).Tables[0];
            CustomeDetailDataGridView();
        }

        private String GetEName(String eid)
        {
            String name=myBill.getEName(eid);
            return name;
        }

        private String GetCName(String cid)
        {
            String name = myBill.getCName(cid);
            return name;
        }

        private void btn_findBill_Click(object sender, EventArgs e)
        {
            btn_billDelete.Enabled = false;
            String findString = txt_findBill.Text.Trim();
            if(true) // txt_findBill.Text!=""
            {
                myDataTable = new DataTable();
                myDataTable.Clear();
                myBillDataSet = new DataSet();

                // Lấy data đưa vào dataset
                myBillDataSet = myBill.findBill(findString);
                // Đưa dữ liệu từ dataset vào table
                myDataTable = myBillDataSet.Tables[0];

                // Đổ data vào datagridview
                dtgv_billList.DataSource = myDataTable;

                // Tùy chỉnh giao diện của datagridview
                CustomeBillDataGridView();
                dtgv_billList.Columns[0].Visible = false;
                txt_findBill.Clear();
            }
            
        }

        private void btn_billDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult respone;
                respone = MessageBox.Show("Xác nhận xóa hóa đơn?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respone == DialogResult.Yes)
                {
                    if(myBill.deleteBill(this.txt_billID.Text.Trim()) == true)
                    {
                        // Thông báo 
                        MessageBox.Show("Đã xóa xong!");
                        // Cập nhật lại DataGridView 
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công!");
                    }
                }
                else
                {
                    // Thông báo 
                    MessageBox.Show("Không thực hiện việc xóa!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không xóa được. Lỗi:" + ex.Message);
            }
            UnenableInputControl();
            ResetInputControl();
        }

        private void dtgv_billDetailList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy dòng đang được ấy
            if (dtgv_billDetailList.Rows.Count < 1)
            {
                return;
            }
            int row = dtgv_billDetailList.CurrentCell.RowIndex;

            // Lấy thông tin từ list đưa lên textbox
            txt_billProductName.Text = dtgv_billDetailList.Rows[row].Cells[0].Value.ToString();
            txt_billQuantity.Text = dtgv_billDetailList.Rows[row].Cells[1].Value.ToString();
            txt_billProductPrice.Text = Math.Round((double)Double.Parse(dtgv_billDetailList.Rows[row].Cells[2].Value.ToString())).ToString();
            txt_billTotalPrice.Text = Math.Round((double)Double.Parse(dtgv_billDetailList.Rows[row].Cells[3].Value.ToString())).ToString();

            // Hiển thị thông tin chi tiết hóa đơn
            myDetail = new Detail();
            dtgv_billDetailList.DataSource = myDetail.GetData(txt_billID.Text.ToString()).Tables[0];
            CustomeDetailDataGridView();
        }

        private void lb_header_Click(object sender, EventArgs e)
        {

        }
    }
}
