using PrepareForFinal.BSLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrepareForFinal.UI
{
    public partial class us_productUI : UserControl
    {
        frm_typeList typeListForm;

        public Account tk;
        public bool isRole;

        public us_productUI()
        {
            InitializeComponent();

        }

        DataTable dtProduct = null;
        Product dbProduct = new Product();
        string imgLoc = "";

        /*Cờ đặt kiểm soát việc thêm, chình sửa. Nếu là true là đang ở chức năng thêm, 
        false là ở chức năng chỉnh sửa*/
        bool addFlag;
        private void btn_typeShowList_Click(object sender, EventArgs e)
        {
            this.typeListForm=new frm_typeList();
            this.typeListForm.Show();
        }

        public void setRole()
        {
            if (isRole == true)
            {
                btn_pdelete.Enabled = true;
                btn_pupdate.Enabled = true;
                btn_padd.Enabled = true;
            }
            if (isRole == false)
            {
                btn_pdelete.Enabled = false;
                btn_pupdate.Enabled = false;
                btn_padd.Enabled = false;
            }
        }

        void LoadData()
        {
            try
            {
                dtProduct = new DataTable();
                dtProduct.Clear();
                DataSet ds = dbProduct.GetProduct(); // Lấy dữ liệu sản phẩm đưa vào Dataset
                //Đưa dữ liệu vào Datatable 
                dtProduct = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView từ DataTable
                dgv_product.DataSource = dtProduct;
                // Thay đổi độ rộng cột 
                int width = dgv_product.Width / 5;
                dgv_product.AutoResizeColumns();
                dgv_product.Columns[0].Width = width;
                dgv_product.Columns[3].Width = width;
                dgv_product.Columns[5].Width = width;
                dgv_product.AllowUserToAddRows = false;
                /*dgv_product.RowHeadersVisible = false;*/
                //Chỉ hiện thị cột mã sản phẩm, tên sản phẩm, giá
                for (int i = 0; i < 9; i++)
                {
                    if (i == 0 || i == 3 || i == 5)
                        continue;
                    dgv_product.Columns[i].Visible = false;
                }

                //Hiện thỉ danh sách loại sản phẩm thông qua combobox
                this.cb_product.Items.Clear();
                dbProduct.getTypeProduct(this.cb_product);

            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được sản phẩm");
            }

            setRole();
            
            this.txt_pid.ResetText();
            this.txt_pname.ResetText();
            this.num_pprice.ResetText();
            this.num_pquantity.ResetText();

            this.txt_pfind.ResetText();
            
            txt_pid.Enabled = false;
            txt_pname.Enabled = false;
            txt_productImport.Enabled = false;
            num_pprice.Enabled = false;
            num_pquantity.Enabled = false;
            dtp_pidate.Enabled = false;
            dtp_pvdate.Enabled = false;
            cb_product.Enabled = false;
            btn_pfind.Enabled = true;
            btn_cancel.Enabled = false;
            btn_save.Enabled = false;
            btn_productImport.Enabled = false;
        }

        

        public void us_productUI_Load(object sender, EventArgs e)
        {
            LoadData();
            
        }

        private void btn_productAdd_Click(object sender, EventArgs e)
        {
            addFlag = true;
            btn_save.Enabled = true;
            btn_cancel.Enabled = true;
            btn_padd.Enabled = false;
            btn_pupdate.Enabled = false;
            btn_pdelete.Enabled = false;

            txt_pid.Enabled = true;
            txt_pname.Enabled = true;
            txt_productImport.Enabled = true;
            num_pprice.Enabled = true;
            num_pquantity.Enabled = true;
            btn_pupload.Enabled = true;
            dtp_pidate.Enabled = true;
            dtp_pvdate.Enabled = true;
            cb_product.Enabled = true;

            txt_pid.Text = dbProduct.autoGenerateID();
            txt_pid.Enabled = false;
        }

        private void btn_productUpdate_Click(object sender, EventArgs e)
        {
            addFlag = false;
            btn_save.Enabled = true;
            btn_cancel.Enabled = true;
            btn_padd.Enabled = false;
            btn_pupdate.Enabled = false;
            txt_pid.Enabled = false;
            btn_pdelete.Enabled = false;

            txt_pname.Enabled = true;
            txt_productImport.Enabled = true;
            num_pprice.Enabled = true;
            num_pquantity.Enabled = true;
            btn_pupload.Enabled = true;
            dtp_pidate.Enabled = true;
            dtp_pvdate.Enabled = true;
            cb_product.Enabled = true;
            btn_productImport.Enabled = true;
        }

        private void btn_productSave_Click(object sender, EventArgs e)
        {
            if (addFlag == true)
            {
                try
                {
                    byte[] img = null;
                    FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read); // Tạo file stream liên kết với ảnh đã chọn
                    img = new byte[fs.Length]; //Tạo một mảng byte với kích thước của file stream
                    fs.Read(img, 0, Convert.ToInt32(fs.Length)); //Đọc luồng tệp đã chọn vào mảng byte
                    dbProduct.addProduct(txt_pid.Text.Trim(), Convert.ToDateTime(dtp_pidate.Value), Convert.ToDateTime(dtp_pvdate.Value), txt_pname.Text.Trim(), img, (float)Convert.ToDouble(num_pprice.Text.Trim()), (float)Convert.ToDouble(num_pquantity.Text.Trim()), dbProduct.getTypeProductID(this.cb_product));
                    addFlag = false;
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
                    byte[] img = null;
                    FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                    img = new byte[fs.Length];
                    fs.Read(img, 0, Convert.ToInt32(fs.Length));
                    dbProduct.updateProduct(txt_pid.Text.Trim(), Convert.ToDateTime(dtp_pidate.Value), Convert.ToDateTime(dtp_pvdate.Value), txt_pname.Text.Trim(), img, (float)Convert.ToDouble(num_pprice.Text.Trim()), (float)Convert.ToDouble(num_pquantity.Text.Trim()), dbProduct.getTypeProductID(this.cb_product));
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
            btn_save.Enabled = false;
            btn_cancel.Enabled = false;
            btn_padd.Enabled = true;
            btn_pupdate.Enabled = true;
            txt_pid.Enabled = false;
        }

        private void btn_productCancel_Click(object sender, EventArgs e)
        {
            btn_save.Enabled = false;
            btn_cancel.Enabled = false;
            btn_padd.Enabled = true;
            btn_pupdate.Enabled = true;
            txt_pid.Enabled = false;
            btn_pdelete.Enabled = true;
            btn_cancel.Enabled = false;

            txt_pname.Enabled = false;
            txt_productImport.Enabled = false;
            num_pprice.Enabled = false;
            num_pquantity.Enabled = false;
            dtp_pidate.Enabled = false;
            dtp_pvdate.Enabled = false;
            cb_product.Enabled = false;

            txt_pid.ResetText();
        }

        private void dgv_product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Dòng hiện hành
            int r = dgv_product.CurrentCell.RowIndex;

            // Chuyển thông tin lên panel 
            this.txt_pid.Text = dgv_product.Rows[r].Cells[0].Value.ToString();
            this.txt_pname.Text = dgv_product.Rows[r].Cells[3].Value.ToString();
            this.num_pprice.Text = dgv_product.Rows[r].Cells[5].Value.ToString();
            this.num_pquantity.Text = dgv_product.Rows[r].Cells[6].Value.ToString();

            this.dtp_pidate.Value = Convert.ToDateTime(dgv_product.Rows[r].Cells[1].Value.ToString());
            this.dtp_pvdate.Value = Convert.ToDateTime(dgv_product.Rows[r].Cells[2].Value.ToString());

            DataRow row = dtProduct.Rows[r];
            ptb_pimage.Image = ConvertByteArraytoImage((byte[])row[4]);
            ptb_pimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            dbProduct.displayTypeProduct(cb_product, txt_pname.Text);
        }

        public Image ConvertByteArraytoImage(byte[] data) //Dùng để chuyển mảng bit ảnh thành ảnh để load lên form
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }

        private void btn_pupload_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                //Danh sách đuôi hình có thể upload
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.* |PNG Files (*.png)|*.png";
                dlg.Title = "Select Product Picture";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = dlg.FileName.ToString();
                    ptb_pimage.ImageLocation = imgLoc; //Chọn đường dẫn file hình để upload
                    ptb_pimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_pfind_Click(object sender, EventArgs e)
        {
            if (txt_pfind.Text != "")
            {
                dtProduct = new DataTable();
                dtProduct.Clear();
                dtProduct = dbProduct.findProduct(txt_pfind.Text).Tables[0];
                dgv_product.DataSource = dtProduct;


                int width = dgv_product.Width / 3;
                dgv_product.AutoResizeColumns();
                dgv_product.Columns[0].Width = width;
                dgv_product.Columns[3].Width = width;
                dgv_product.Columns[5].Width = width;
                dgv_product.AllowUserToAddRows = false;

                for (int i = 0; i < 8; i++)
                {
                    if (i == 0 || i == 3 || i == 5)
                        continue;
                    dgv_product.Columns[i].Visible = false;
                }

                dbProduct.getTypeProduct(this.cb_product);
            }
            else
            {
                MessageBox.Show("Nhập tên sản phẩm cần tìm");
            }
        }

        private void btn_pdelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Xác nhận xóa sản phẩm?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    dbProduct.deleteProduct(this.txt_pid.Text);
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

        private void btn_productGroupButton_Click(object sender, EventArgs e)
        {

        }

        private void cb_product_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_productImport_Click(object sender, EventArgs e)
        {
            try
            {

                double count;
                if (!double.TryParse(txt_productImport.Text, out count))
                {
                    MessageBox.Show("Nội dung nhập vào không hợp lệ");
                }
                else
                {
                    num_pquantity.Value = (decimal)count + num_pquantity.Value;
                }


                FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                byte[] img = new byte[fs.Length];
                fs.Read(img, 0, Convert.ToInt32(fs.Length));
                dbProduct.updateProduct(txt_pid.Text.Trim(), Convert.ToDateTime(dtp_pidate.Value), Convert.ToDateTime(dtp_pvdate.Value), txt_pname.Text.Trim(), img, (float)Convert.ToDouble(num_pprice.Text.Trim()), (float)Convert.ToDouble(num_pquantity.Text.Trim()), dbProduct.getTypeProductID(this.cb_product));
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            btn_save.Enabled = false;
            btn_cancel.Enabled = false;
            btn_padd.Enabled = true;
            btn_pupdate.Enabled = true;
            txt_pid.Enabled = false;
            txt_productImport.ResetText();
        }
    }
}
