using System;
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
    public partial class us_supplyUI : UserControl
    {
        public us_supplyUI()
        {
            InitializeComponent();
            LoadData();
        }
        DataTable dtSupply = null;
        Supply dbSupply = new Supply();
        bool Flag;

        void LoadData()
        {
            this.txt_supplyID.Enabled = false;
            this.txt_supplyAddress.Enabled = false;
            this.txt_supplyName.Enabled = false;
            this.txt_supplyPhone.Enabled = false;
            this.cb_nameProduct.Enabled = false;
            this.txt_supplyID.ResetText();
            this.txt_supplyName.ResetText();
            this.txt_supplyPhone.ResetText();
            this.txt_supplyAddress.ResetText();
            this.cb_nameProduct.ResetText();

            try
            {
                dtSupply = new DataTable();
                dtSupply.Clear();
                DataSet ds = dbSupply.GetSupply(); // Lấy dữ liệu Employee đưa vào Dataset
                //Đưa dữ liệu vào Datatable 
                dtSupply = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView từ DataTable
                dtgv_supplyList.DataSource = dtSupply;
                // Thay đổi độ rộng cột 

                int width = dtgv_supplyList.Width / 5;
                dtgv_supplyList.AutoResizeColumns();
                for (int i = 0; i < dtgv_supplyList.Columns.Count - 1; i++)
                    dtgv_supplyList.Columns[i].Width = width;

                dtgv_supplyList.AllowUserToAddRows = false;

                /*dgv_product.RowHeadersVisible = false;*/
                //
                dtgv_supplyList.Columns[5].Visible = false;

                //Hiện thỉ danh sách sản phẩm thông qua combobox
                dbSupply.getListProduct(this.cb_nameProduct);


            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được sản phẩm");
            }


            btn_supplyAdd.Enabled = true;
            btn_supplyDelete.Enabled = true;
            btn_supplySave.Enabled = false;
            btn_supplyUpdate.Enabled = true;
            btn_findSupply.Enabled = false;
            btn_supplyCancel.Enabled = false;

        }
        private void us_supplyUI_Load(object sender, EventArgs e)
        {
            btn_supplySave.Enabled = false;
            btn_supplyCancel.Enabled = false;
            btn_supplyDelete.Enabled = false;
            btn_supplyDelete.Enabled = true;
        }

        private void btn_supplyAdd_Click(object sender, EventArgs e)
        {
            Flag = true;
            btn_supplySave.Enabled = true;
            btn_supplyCancel.Enabled = true;
            btn_supplyAdd.Enabled = false;
            btn_supplyUpdate.Enabled = false;

            this.txt_supplyID.ResetText();
            this.txt_supplyName.ResetText();
            this.txt_supplyPhone.ResetText();
            this.txt_supplyAddress.ResetText();
            this.cb_nameProduct.ResetText();

            this.txt_supplyID.Enabled = true;
            this.txt_supplyAddress.Enabled = true;
            this.txt_supplyName.Enabled = true;
            this.txt_supplyPhone.Enabled = true;
            this.cb_nameProduct.Enabled = true;

            txt_supplyID.Text = dbSupply.autoGenerateID();
            txt_supplyID.Enabled = false;
        }

        private void btn_supplyUpdate_Click(object sender, EventArgs e)
        {
            btn_supplySave.Enabled = true;
            btn_supplyCancel.Enabled = true;
            btn_supplyAdd.Enabled = false;
            btn_supplyUpdate.Enabled = false;
            txt_supplyID.Enabled = false;

            this.txt_supplyID.Enabled = false;
            this.txt_supplyAddress.Enabled = true;
            this.txt_supplyName.Enabled = true;
            this.txt_supplyPhone.Enabled = true;
            this.cb_nameProduct.Enabled = false;
            Flag = false;
        }

        private void btn_supplySave_Click(object sender, EventArgs e)
        {
            if (Flag == true)
            {
                try
                {
                    Console.WriteLine("Test = " + this.cb_nameProduct.Text + "/n");
                    Console.WriteLine("id = " + dbSupply.getProductID(this.cb_nameProduct));
                    dbSupply.addSupply(txt_supplyID.Text.Trim(), txt_supplyName.Text.Trim(), txt_supplyAddress.Text.Trim(),
                        txt_supplyPhone.Text.Trim(), dbSupply.getProductID(this.cb_nameProduct));

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
                    dbSupply.updateSupply(txt_supplyID.Text.Trim(), txt_supplyName.Text.Trim(), txt_supplyAddress.Text.Trim(),
                        txt_supplyPhone.Text.Trim(), dbSupply.getProductID(this.cb_nameProduct));
                    Flag = false;
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            btn_supplySave.Enabled = false;
            btn_supplyCancel.Enabled = false;
            btn_supplyAdd.Enabled = true;
            btn_supplyUpdate.Enabled = true;
            txt_supplyID.Enabled = true;

            this.txt_supplyID.Enabled = false;
            this.txt_supplyAddress.Enabled = false;
            this.txt_supplyName.Enabled = false;
            this.txt_supplyPhone.Enabled = false;
            this.cb_nameProduct.Enabled = false;

        }

        private void btn_supplyCancel_Click(object sender, EventArgs e)
        {
            btn_supplySave.Enabled = false;
            btn_supplyCancel.Enabled = false;
            btn_supplyAdd.Enabled = true;
            btn_supplyUpdate.Enabled = true;
            txt_supplyID.Enabled = true;

            this.txt_supplyID.Enabled = false;
            this.txt_supplyAddress.Enabled = false;
            this.txt_supplyName.Enabled = false;
            this.txt_supplyPhone.Enabled = false;
            this.cb_nameProduct.Enabled = false;

            LoadData();
            this.txt_findSupply.ResetText();
            this.btn_findSupply.Enabled = false;
        }

        

        private void btn_supplyDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Xác nhận xóa Nhà sản xuất?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    dbSupply.deleteSupply(this.txt_supplyID.Text);
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

        private void txt_findSupply_TextChanged(object sender, EventArgs e)
        {
            if (txt_findSupply.Enabled == true)
                btn_findSupply.Enabled = true;
            btn_supplyCancel.Enabled = true;
        }

        private void btn_findSupply_Click(object sender, EventArgs e)
        {
            if (txt_findSupply.Text != "")
            {
                dtSupply = new DataTable();
                dtSupply.Clear();
                dtSupply = dbSupply.findSupply(this.txt_findSupply.Text).Tables[0];
                dtgv_supplyList.DataSource = dtSupply;


                int width = dtgv_supplyList.Width / 5;
                dtgv_supplyList.AutoResizeColumns();
                dtgv_supplyList.Columns[0].Width = width;
                dtgv_supplyList.Columns[1].Width = width;
                dtgv_supplyList.Columns[2].Width = width;
                dtgv_supplyList.Columns[3].Width = width;
                dtgv_supplyList.AllowUserToAddRows = false;
                dbSupply.getListProduct(this.cb_nameProduct);
            }
            else
            {
                MessageBox.Show("Nhập tên sản phẩm cần tìm");
            }
        }

        private void dtgv_supplyList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dtgv_supplyList.CurrentCell.RowIndex;

            // Chuyển thông tin lên panel 
            this.txt_supplyID.Text = dtgv_supplyList.Rows[r].Cells[0].Value.ToString();
            this.txt_supplyName.Text = dtgv_supplyList.Rows[r].Cells[1].Value.ToString();
            this.txt_supplyAddress.Text = dtgv_supplyList.Rows[r].Cells[2].Value.ToString();
            this.txt_supplyPhone.Text = dtgv_supplyList.Rows[r].Cells[3].Value.ToString();
            dbSupply.displayNameProduct(this.cb_nameProduct, this.txt_supplyID.Text);
        }

        //public void DisplayNameProduct(ComboBox cb_product)
        //{

        //}

    }
}