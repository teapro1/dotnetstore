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
    public partial class us_paymentUI : UserControl
    {
        public frm_billList billListForm;
        public Bill myBill;
        public Detail myDetail;
        public Product myProduct;
        public DataTable myDataTable = new DataTable();
        public DataSet myDataSet;
        public List<Control> InputcontrolList = new List<Control>();
        public List<TemDetail> temDetail = new List<TemDetail>();
        float sum = 0;
        Product productList;
        DataSet prdataset;
        DataTable prDataTable;
        public Account tk = new Account();
        public bool isRole;


        public us_paymentUI()
        {
            InitializeComponent();
            InputControlLoad();
        }
        private void InputControlLoad()
        {
            InputcontrolList.Add(txt_billID);
            InputcontrolList.Add(dtp_billDate);
            InputcontrolList.Add(txtEmpName);
            InputcontrolList.Add(cb_billCustomerName);
            InputcontrolList.Add(cb_billTypeName);
            InputcontrolList.Add(num_billProductQuantity);
        }
        private void EnabledInputControl()
        {
            foreach (Control control in InputcontrolList)
            {
                control.Enabled = true;
            }
        }
        private void UnenabledInputControl()
        {
            foreach (Control control in InputcontrolList)
            {
                control.Enabled = false;
            }
        }

        private void ClearItems()
        {
            cb_billCustomerName.Items.Clear();
            cb_billTypeName.Items.Clear();
            txt_billID.Clear();
            txt_billProductPrice.Clear();
            txt_billFinalPay.Clear();
            txt_billTotalPrice.Clear();
            txt_billInitalPay.Clear();
            txt_customerPoint.Clear();
            num_billProductQuantity.Value = 1;
            txt_productName.Clear();
        }
        private void btn_billShowList_Click(object sender, EventArgs e)
        {
            this.billListForm = new frm_billList();
            this.billListForm.Show();
            this.billListForm.BringToFront();
        }

        public void us_paymentUI_Load(object sender, EventArgs e)
        {
            btn_billSave.Enabled = false;
            btn_billCancel.Enabled = false;
            btn_billDeleteDetail.Enabled = false;
            txt_billProductPrice.Enabled = false;
            txt_billFinalPay.Enabled = false;
            txt_billTotalPrice.Enabled = false;
            btn_billImportDetail.Enabled = false;
            dtp_billDate.Value = DateTime.Today;
            txtEmpName.Text = tk.name;
            txtEmpName.Enabled = false;
            txt_productFindString.Enabled = false;
            btn_findProduct.Enabled = false;
            btn_billAdd.Enabled = true;
            if (dtgv_billDetialList.Rows.Count >= 1)
            {
                temDetail.Clear();
                dtgv_billDetialList.DataSource = null;
            }
            if (dtgv_productList.Rows.Count >=1)
            {
                dtgv_productList.DataSource = null;
            }
            sum = 0;
            ClearItems();
            UnenabledInputControl();
        }

        private void btn_billSave_Click(object sender, EventArgs e)
        {
            try
            {
                String eid = tk.eid;
                String cid = myBill.getCustomerID(cb_billCustomerName.Text.ToString());

                if (txt_billID.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mã hõa đơn");
                }
                else
                {
                    if (cb_billCustomerName.Text == "")
                    {
                        MessageBox.Show("Vui lòng chọn khách hàng");
                    }
                    else
                    {
                        if (temDetail.Count < 1)
                        {
                            MessageBox.Show("Vui lòng chọn sản phẩm");
                        }
                        else
                        {
                            if (myBill.addBill(txt_billID.Text.Trim(), Convert.ToDateTime(dtp_billDate.Value), (float)0, eid, cid) == true)
                            {
                                foreach (TemDetail detail in temDetail)
                                {
                                    myProduct=new Product();
                                    if(myProduct.getAmount(myDetail.getProductID(detail.pname)) >= detail.amount)
                                    {
                                        if (myDetail.addDetail(detail.amount, txt_billID.Text, myDetail.getProductID(detail.pname)) == false)
                                        {
                                            MessageBox.Show("Thêm hóa đơn không thành công");
                                            return;
                                        }
                                    }
                                    else
                                    {
                                        DialogResult traloi;
                                        traloi = MessageBox.Show("Không đủ hàng có sẵn! Tiếp tục?", "Trả lời",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                        if (traloi == DialogResult.Yes)
                                        {
                                            myDetail.addDetail(detail.amount, txt_billID.Text, myDetail.getProductID(detail.pname));
                                        }
                                        else
                                        {
                                            MessageBox.Show("Không thực hiện!");
                                            continue;
                                        }
                                    }
                                }
                                MessageBox.Show("Thêm hóa đơn thành công");
                                btn_billAdd.Enabled = true;
                                btn_billSave.Enabled = false;
                                btn_billCancel.Enabled = false;
                                ClearItems();
                                UnenabledInputControl();
                                prDataTable.Clear();
                                temDetail.Clear();
                                dtgv_billDetialList.DataSource = ToDataTable(temDetail);
                                btn_billDeleteDetail.Enabled = false;
                                btn_billImportDetail.Enabled = false;
                                txt_productFindString.Enabled = false;
                                btn_findProduct.Enabled = false;
                                sum = 0;
                            }
                            else
                            {
                                MessageBox.Show("Thêm hóa đơn không thành công");
                            }
                        } 
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể lưu, lỗi: " + ex.Message);
            }

        }

        private void btn_billCancel_Click(object sender, EventArgs e)
        {
            btn_billAdd.Enabled = true;
            btn_billSave.Enabled = false;
            btn_billCancel.Enabled = false;
            txt_billFinalPay.Enabled = false;
            ClearItems();
            UnenabledInputControl();
            prDataTable.Clear();
            temDetail.Clear();
            dtgv_billDetialList.DataSource = ToDataTable(temDetail);
            btn_billDeleteDetail.Enabled = false;
            btn_billImportDetail.Enabled = false;
            txt_productFindString.Enabled = false;
            btn_findProduct.Enabled = false;
            sum = 0;
        }

        private void btn_billAdd_Click(object sender, EventArgs e)
        {
            btn_billAdd.Enabled = false;
            btn_billSave.Enabled = true;
            btn_billCancel.Enabled = true;
            btn_billImportDetail.Enabled = true;
            btn_findProduct.Enabled = true;
            myBill = new Bill();
            /*myBill.getEmployeeName(tk.name);*/
            myBill.getCustomerName(cb_billCustomerName);
            myBill.getTypeProduct(cb_billTypeName);
            txt_billFinalPay.Text = sum.ToString();
            txt_billInitalPay.Text = ((int)sum / 10000).ToString();
            EnabledInputControl();
            LoadProductList();
            txtEmpName.Enabled=false;
            txt_billID.Text = myBill.autoGenerateID();
            txt_billID.Enabled = false;
            txt_productFindString.Enabled = true;
            btn_findProduct.Enabled = true;
        }

        private void dtgv_billDetialList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_billDeleteDetail.Enabled = false;
            // Lấy dòng đang được ấy
            if (dtgv_billDetialList.Rows.Count < 1)
            {
                return;
            }
            int row = dtgv_billDetialList.CurrentCell.RowIndex;
            btn_billDeleteDetail.Enabled = true;
        }

        public bool IsList(List<String> list, string variable)
        {
            bool result = false;
            foreach (string item in list)
            {
                if (item.Contains(variable) == true)
                {
                    result = true;
                }
            }
            return result;
        }

        public DataTable ToDataTable(List<TemDetail> data)
        {
            List<String> productName = new List<String>();
            DataTable table = new DataTable();
            for (int i = 0; i < 4; i++)
            {
                table.Columns.Add();
            }
            foreach (TemDetail item in data)
            {
                productName.Add(item.pname);
            }
            foreach (TemDetail item in data)
            {
                table.Rows.Add(item.ToString());
            }
            return table;
        }

        private void AddToTemDetailList(List<TemDetail> data, TemDetail temDetail)
        {
            List<String> productName = new List<String>();
            foreach (TemDetail item in data)
            {
                productName.Add(item.pname);
            }
            if (IsList(productName, temDetail.pname) == false)
            {
                data.Add(temDetail);
                sum += temDetail.total;
            }
            else
            {
                foreach (TemDetail item in data)
                {
                    if (item.pname == temDetail.pname)
                    {
                        item.amount += temDetail.amount;
                        sum += temDetail.total;
                        item.total = item.amount * item.price;
                        break;
                    }
                }
            }
        }

        private void DeleteFromDetailList(List<TemDetail> data, string temDetail)
        {
            List<String> productName = new List<String>();
            foreach (TemDetail item in data)
            {
                productName.Add(item.pname);
            }
            foreach (TemDetail item in data)
            {
                if (item.pname == temDetail)
                {
                    data.Remove(item);
                    sum -= item.total;
                    break;
                }
            }
        }

        private void btn_billImportDetail_Click(object sender, EventArgs e)
        {
            String eid = tk.eid;
            String cid = myBill.getCustomerID(cb_billCustomerName.Text.ToString());

            if (txt_billProductPrice.Text != "" && txt_productName.Text != "" && txt_billTotalPrice.Text != "")
            {
                AddToTemDetailList(temDetail, new TemDetail((float)num_billProductQuantity.Value, float.Parse(txt_billProductPrice.Text), txt_productName.Text, float.Parse(txt_billTotalPrice.Text)));
            }
            
            var bindingList = new BindingList<TemDetail>(temDetail);
            var source = new BindingSource(bindingList, null);

            dtgv_billDetialList.DataSource = ToDataTable(temDetail);

            dtgv_billDetialList.Columns[0].HeaderText = "Sản phẩm";
            dtgv_billDetialList.Columns[1].HeaderText = "Số lượng";
            dtgv_billDetialList.Columns[2].HeaderText = "Đơn giá";
            dtgv_billDetialList.Columns[3].HeaderText = "Thành tiền";


            cb_billTypeName.ResetText();
            num_billProductQuantity.Value = 1;
            txt_billProductPrice.ResetText();
            txt_billTotalPrice.ResetText();
            txt_billFinalPay.Text = sum.ToString();
            txt_billInitalPay.Text = ((int)sum / 10000).ToString();
            CustomeDetailDataGridView();

            /*if (cb_billProductName.Text == "" || num_billProductQuantity.Value.ToString() == "" || txt_billProductPrice.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
            }
            else
            {
                if (txt_billID.Enabled == true)
                {
                    if (myBill.addBill(txt_billID.Text.Trim(), Convert.ToDateTime(dtp_billDate.Value), (float)0, eid, cid) &&
                    myDetail.addDetail((float)num_billProductQuantity.Value, txt_billID.Text, myDetail.getProductID(cb_billProductName.Text)))
                    {
                        MessageBox.Show("Thêm hàng thành công");
                        txt_billID.Enabled = false;
                        dtp_billDate.Enabled = false;
                        cb_billEmployeeName.Enabled = false;
                        cb_billCustomerName.Enabled = false;

                        cb_billProductName.ResetText();
                        num_billProductQuantity.Value = 1;
                        txt_billProductPrice.ResetText();
                        txt_billTotalPrice.ResetText();
                        txt_billFinalPay.Text = myBill.getBillTotal(txt_billID.Text);
                    }
                    else
                    {
                        MessageBox.Show("Thêm hàng không thành công");
                    }
                }
                else
                {
                    if (myDetail.addDetail((float)num_billProductQuantity.Value, txt_billID.Text, myDetail.getProductID(cb_billProductName.Text)))
                    {
                        MessageBox.Show("Thêm hàng thành công");
                        txt_billID.Enabled = false;
                        dtp_billDate.Enabled = false;
                        cb_billEmployeeName.Enabled = false;
                        cb_billCustomerName.Enabled = false;

                        cb_billProductName.ResetText();
                        num_billProductQuantity.Value = 1;
                        txt_billProductPrice.ResetText();
                        txt_billTotalPrice.ResetText();
                        txt_billFinalPay.Text = myBill.getBillTotal(txt_billID.Text);
                    }
                    else
                    {
                        MessageBox.Show("Thêm hàng không thành công");
                    }
                }
                LoadData();
                CustomeDetailDataGridView();
                txt_billFinalPay.Text = myBill.getBillTotal(txt_billID.Text);
                txt_billInitalPay.Text = myBill.getBillTotal(txt_billID.Text);
            }*/
        }

        private void cb_billProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            productList = new Product();
            prdataset = new DataSet();
            prDataTable = new DataTable();
            myProduct = new Product();
            prdataset = myProduct.findProduct(myProduct.getTypeID(cb_billTypeName.Text));
            prDataTable = prdataset.Tables[0];
            dtgv_productList.DataSource = prDataTable;

            dtgv_productList.AllowUserToAddRows = false;
            dtgv_productList.AllowUserToResizeColumns = false;

            for (int i = 0; i < 8; i++)
            {
                if (i == 6 || i == 3 || i == 5)
                    continue;
                dtgv_productList.Columns[i].Visible = false;
            }

            dtgv_productList.Columns[3].HeaderText = "Tên sản phẩm";
            dtgv_productList.Columns[5].HeaderText = "Giá Nhập";
            dtgv_productList.Columns[6].HeaderText = "Số lượng";
        }

        private void num_billProductQuantity_ValueChanged(object sender, EventArgs e)
        {

            myDetail = new Detail();
            if (txt_productName.Text != "")
            {
                double price = Convert.ToDouble(myDetail.getProductPrice(txt_productName.Text)) * 1.15;
                txt_billTotalPrice.Text = (price * (double)num_billProductQuantity.Value).ToString();
            }
        }

        private void LoadData()
        {
            try
            {
                myDataTable = new DataTable();
                myDetail = new Detail();
                myDataSet = new DataSet();
                // Lấy data đưa vào dataset
                myDataSet = myDetail.GetData(txt_billID.Text);
                // Đưa dữ liệu từ dataset vào table
                myDataTable = myDataSet.Tables[0];
                // Đổ data vào datagridview
                dtgv_billDetialList.DataSource = myDataTable;
                // Tùy chỉnh giao diện cho cái list
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi", "Không hiển thị được thông tin, Lỗi: " + ex.Message);
            }
        }

        private void CustomeDetailDataGridView()
        {
            dtgv_billDetialList.AllowUserToAddRows = false;
            dtgv_billDetialList.Columns[0].HeaderText = "Sản phẩm";
            dtgv_billDetialList.Columns[1].HeaderText = "Số lượng";
            dtgv_billDetialList.Columns[2].HeaderText = "Đơn giá";
            dtgv_billDetialList.Columns[3].HeaderText = "Thành tiền";
        }

        private void btn_billDeleteDetail_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgv_billDetialList.Rows.Count < 1)
                {
                    return;
                }
                int row = dtgv_billDetialList.CurrentCell.RowIndex;
                myDetail = new Detail();

                string pName = dtgv_billDetialList.Rows[row].Cells[0].Value.ToString();
                DeleteFromDetailList(temDetail, pName);
                dtgv_billDetialList.DataSource = ToDataTable(temDetail);
                txt_billFinalPay.Text = sum.ToString();
                txt_billInitalPay.Text = ((int)sum / 10000).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không xóa được. Lỗi:" + ex.Message);
            }
        }

        private void LoadProductList()
        {
            productList = new Product();
            prdataset = new DataSet();
            prDataTable = new DataTable();
            prdataset = productList.GetProduct();
            prDataTable = prdataset.Tables[0];
            dtgv_productList.DataSource = prDataTable;


            dtgv_productList.AllowUserToAddRows = false;
            dtgv_productList.AllowUserToResizeColumns = false;

            for (int i = 0; i < 9; i++)
            {
                if (i == 6 || i == 3 || i == 5)
                    continue;
                dtgv_productList.Columns[i].Visible = false;
            }

            dtgv_productList.Columns[3].HeaderText = "Tên sản phẩm";
            dtgv_productList.Columns[5].HeaderText = "Giá";
            dtgv_productList.Columns[6].HeaderText = "Số lượng";
        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void txt_billProductPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgv_productList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy dòng đang được ấy
            if (dtgv_productList.Rows.Count < 1)
            {
                return;
            }
            int row = dtgv_productList.CurrentCell.RowIndex;
            myDetail = new Detail();

            cb_billTypeName.Text = dtgv_productList.Rows[row].Cells[7].Value.ToString();
            txt_productName.Text = dtgv_productList.Rows[row].Cells[3].Value.ToString();
            double price = Convert.ToDouble(myDetail.getProductPrice(txt_productName.Text)) * 1.15;
            txt_billProductPrice.Text = price.ToString();
            txt_billTotalPrice.Text = (price * (double)num_billProductQuantity.Value).ToString();
        }

        private void btn_findProduct_Click(object sender, EventArgs e)
        {
            productList = new Product();
            prdataset = new DataSet();
            prDataTable = new DataTable();
            myProduct = new Product();
            prdataset = myProduct.findProduct(txt_productFindString.Text);
            prDataTable = prdataset.Tables[0];
            dtgv_productList.DataSource = prDataTable;

            dtgv_productList.AllowUserToAddRows = false;
            dtgv_productList.AllowUserToResizeColumns = false;

            for (int i = 0; i < 8; i++)
            {
                if (i == 6 || i == 3 || i == 5)
                    continue;
                dtgv_productList.Columns[i].Visible = false;
            }

            dtgv_productList.Columns[3].HeaderText = "Tên sản phẩm";
            dtgv_productList.Columns[5].HeaderText = "Giá Nhập";
            dtgv_productList.Columns[6].HeaderText = "Số lượng";
        }

        private void cb_billCustomerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_billCustomerName.Text != "")
            {
                myBill = new Bill();
                txt_customerPoint.Text = myBill.getCustomerPoint(cb_billCustomerName.Text);
            }
        }

        private void cb_billCustomerName_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cb_billCustomerName.Text != "")
            {
                myBill = new Bill();
                txt_customerPoint.Text = myBill.getCustomerPoint(cb_billCustomerName.Text);
            }
        }

        private void cb_billEmployeeName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
