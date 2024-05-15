using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrepareForFinal.BSLayer;
using Microsoft.Office.Interop.Word;
using Word = Microsoft.Office.Interop.Word;
using System.IO;
using DevExpress.XtraReports.Parameters;
using Newtonsoft.Json.Linq;
using PrepareForFinal.DBLayer;
using System.Data.SqlClient;

namespace PrepareForFinal.UI
{
    public partial class frm_billList : Form
    {
        Bill myBill;
        DataSet myBillDataSet;
        System.Data.DataTable myDataTable;
        Detail myDetail;
        // Khai báo đối tượng Application của Microsoft Word
        Microsoft.Office.Interop.Word.Application wordApp;
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
            if (dtgv_billList.Columns.Count > 0)
            {
                dtgv_billList.Columns[0].HeaderText = "Mã HĐ";
                dtgv_billList.Columns[1].HeaderText = "Ngày Lập";
                dtgv_billList.Columns[2].HeaderText = "Tổng Tiền";
                dtgv_billList.Columns[3].HeaderText = "Mã NV";
                dtgv_billList.Columns[4].HeaderText = "Mã KH";
                if (dtgv_billList.Columns.Count > 6)
                {
                    dtgv_billList.Columns[6].HeaderText = "Hình Thức Thanh Toán";
                }
                dtgv_billList.Columns[2].DefaultCellStyle.Format = "n0"; // Hiển thị VNĐ, 0 số thập phân
            }
        }


        private void CustomeDetailDataGridView()
        {
            dtgv_billDetailList.AllowUserToAddRows = false;
            dtgv_billDetailList.Columns[0].HeaderText = "Sản Phẩm";
            dtgv_billDetailList.Columns[1].HeaderText = "Số Lượng";
            dtgv_billDetailList.Columns[2].HeaderText = "Đơn Giá";
            dtgv_billDetailList.Columns[3].HeaderText = "Thành Tiền";
            dtgv_billDetailList.Columns[4].Visible = false;
            dtgv_billDetailList.Columns[5].Visible = false;
            dtgv_billDetailList.Columns[2].DefaultCellStyle.Format = "n0"; // Định dạng currency, 0 số thập phân
            dtgv_billDetailList.Columns[3].DefaultCellStyle.Format = "n0";


        }
        private void LoadData()
        {
            try
            {
                myDataTable = new System.Data.DataTable();
                myBill = new Bill();
                myBillDataSet = new DataSet();
                // Lấy data đưa vào dataset
                myBillDataSet = myBill.GetData();
                // Đưa dữ liệu từ dataset vào table
                myDataTable = myBillDataSet.Tables[0];
                // Đổ data vào datagridview
                dtgv_billList.DataSource = myDataTable;
                // Tùy chỉnh giao diện cho cái list
                CustomeBillDataGridView();
                dtgv_billList.Columns[5].Visible = false;
                dtgv_billList.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi", "Không hiển thị được thông tin, Lỗi: " + ex.Message);
            }

        }
        private void frm_billList_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            dtp_billDate.Value = DateTime.Today;
            UnenableInputControl();
            LoadData();
        }
        private void dtgv_billList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_billList.Rows.Count < 1)
            {
                return;
            }
            if (e.RowIndex < 0 || e.RowIndex >= dtgv_billList.Rows.Count)
            {
                return;
            }
            btn_billDelete.Enabled = true;
            int row = e.RowIndex;
            txt_billID.Text = dtgv_billList.Rows[row].Cells[0].Value.ToString();
            dtp_billDate.Value = Convert.ToDateTime(dtgv_billList.Rows[row].Cells[1].Value.ToString());
            txt_billTotalPay.Text = Math.Round((double)Double.Parse(dtgv_billList.Rows[row].Cells[2].Value.ToString())).ToString("n0") + " VNĐ"; // Hiển thị VNĐ, 0 số thập phân
            txt_billEName.Text = GetEName(dtgv_billList.Rows[row].Cells[3].Value.ToString());
            txt_billCName.Text = GetCName(dtgv_billList.Rows[row].Cells[4].Value.ToString());
            // Hiển thị thông tin chi tiết hóa đơn  
            myDetail = new Detail();
            dtgv_billDetailList.DataSource = myDetail.GetData(txt_billID.Text.ToString()).Tables[0];
            CustomeDetailDataGridView();
        }
        private String GetEName(String eid)
        {
            String name = myBill.getEName(eid);
            return name;
        }

        private String GetCName(String cid)
        {
            String name = myBill.getCName(cid);
            return name;
        }

        /* private void btn_findBill_Click(object sender, EventArgs e)
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
            
        }*/

        private void btn_billDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult respone;
                respone = MessageBox.Show("Xác nhận xóa hóa đơn?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respone == DialogResult.Yes)
                {
                    if (myBill.deleteBill(this.txt_billID.Text.Trim()) == true)
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
            if (dtgv_billDetailList.Rows.Count == 0)
            {
                return;
            }

            if (e.RowIndex < 0 || e.RowIndex >= dtgv_billDetailList.Rows.Count)
            {
                return;
            }

            int row = e.RowIndex;

            // Lấy thông tin từ list đưa lên textbox
            txt_billProductName.Text = dtgv_billDetailList.Rows[row].Cells[0].Value.ToString();
            txt_billQuantity.Text = dtgv_billDetailList.Rows[row].Cells[1].Value.ToString();
            txt_billProductPrice.Text = Math.Round((double)Double.Parse(dtgv_billDetailList.Rows[row].Cells[2].Value.ToString())).ToString("n0") + " VNĐ";
            txt_billTotalPrice.Text = Math.Round((double)Double.Parse(dtgv_billDetailList.Rows[row].Cells[3].Value.ToString())).ToString("n0") + " VNĐ";

            // Hiển thị thông tin chi tiết hóa đơn
            myDetail = new Detail();
            dtgv_billDetailList.DataSource = myDetail.GetData(txt_billID.Text.ToString()).Tables[0];
            CustomeDetailDataGridView();
        }


        private void lb_header_Click(object sender, EventArgs e)
        {

        }

        private void dtgv_billList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgv_billDetailList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_billPrint_Click(object sender, EventArgs e)
        {
            if (dtgv_billList.SelectedRows.Count > 0)
            {
                // Lấy thông tin của hóa đơn từ DataGridView
                int selectedRowIndex = dtgv_billList.SelectedRows[0].Index;
                string billID = dtgv_billList.Rows[selectedRowIndex].Cells[0].Value.ToString();
                string billDate = dtgv_billList.Rows[selectedRowIndex].Cells[1].Value.ToString();
                string totalPay = ConvertToCurrencyFormat(dtgv_billList.Rows[selectedRowIndex].Cells[2].Value.ToString());
                string employeeID = dtgv_billList.Rows[selectedRowIndex].Cells[3].Value.ToString();
                string customerID = dtgv_billList.Rows[selectedRowIndex].Cells[4].Value.ToString();

                // Lấy thông tin sản phẩm từ dtgv_billDetailList
                List<string> productNames = new List<string>();
                List<string> quantities = new List<string>();
                List<string> productPrices = new List<string>();
                List<string> sums = new List<string>(); // Danh sách tổng giá trị của mỗi sản phẩm
                foreach (DataGridViewRow row in dtgv_billDetailList.Rows)
                {
                    // Lấy thông tin từ mỗi hàng và thêm vào danh sách tương ứng
                    if (!row.IsNewRow) // Kiểm tra nếu không phải là dòng mới
                    {
                        productNames.Add(row.Cells[0].Value.ToString());
                        quantities.Add(row.Cells[1].Value.ToString());
                        double price = ConvertToDouble(row.Cells[2].Value.ToString()); // Chuyển đổi giá thành số thực
                        productPrices.Add(Math.Round(price).ToString("n0") + " VNĐ");
                        double quantity = Convert.ToDouble(row.Cells[1].Value); // Số lượng
                        double sum = quantity * price; // Tính tổng giá trị của mỗi sản phẩm
                        sums.Add(sum.ToString("n0") + " VNĐ"); // Thêm vào danh sách tổng giá trị
                    }
                }

                // Lấy tổng của các giá trị trong danh sách sums
                double allSum = 0;
                foreach (string sum in sums)
                {
                    double value = BackToDouble(sum);
                    allSum += value;
                }
                string txtAllSum = allSum.ToString("n0") + " VNĐ";

                // Lấy thông tin khách hàng từ CSDL
                string customerName = "";
                string address = "";
                string phoneNumber = "";
                // Kết nối với cơ sở dữ liệu
                string connectionString = @"Data Source=TEA\TEA;" +
                    "Initial Catalog=QLCUAHANG;" +
                    "Integrated Security=True;" + "MultipleActiveResultsets = true";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Tạo câu truy vấn SQL để lấy thông tin của khách hàng dựa trên customerID
                    string query = "SELECT c_name, c_address, c_phone FROM Customer WHERE c_id = @CustomerID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerID", customerID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Đọc thông tin của khách hàng từ kết quả truy vấn
                                customerName = reader["c_name"].ToString();
                                address = reader["c_address"].ToString();
                                phoneNumber = reader["c_phone"].ToString();
                            }
                        }
                    }

                    connection.Close();
                }

                // Khởi tạo ứng dụng Word
                Word.Application wordApp = new Word.Application();

                // Mở tài liệu Word
                Word.Document doc = wordApp.Documents.Open("C:/Users/Tea/Downloads/test.docx");

                // Thay thế các trường dữ liệu động trong tài liệu
                doc.Content.Find.Execute(FindText: "billID", ReplaceWith: billID);
                doc.Content.Find.Execute(FindText: "billDate", ReplaceWith: billDate);
                doc.Content.Find.Execute(FindText: "totalPay", ReplaceWith: totalPay);
                doc.Content.Find.Execute(FindText: "employeeID", ReplaceWith: employeeID);
                doc.Content.Find.Execute(FindText: "customerID", ReplaceWith: customerID);
                doc.Content.Find.Execute(FindText: "customerName", ReplaceWith: customerName);
                doc.Content.Find.Execute(FindText: "address", ReplaceWith: address);
                doc.Content.Find.Execute(FindText: "phoneNumber", ReplaceWith: phoneNumber);
                doc.Content.Find.Execute(FindText: "txt_allsum", ReplaceWith: txtAllSum); // Thay thế tổng của các txt_sum vào txt_allsum

                // Duyệt qua danh sách sản phẩm và thay thế vào văn bản
                int productIndex = 1;
                foreach (string productName in productNames)
                {
                    object findTextProductName = "txt_billProductName" + productIndex;
                    object findTextQuantity = "txt_billQuantity" + productIndex;
                    object findTextProductPrice = "txt_billProductPrice" + productIndex;
                    object findTextSum = "txt_sum" + productIndex;
                    object replaceTextProductName = productName;
                    object replaceTextQuantity = quantities[productIndex - 1];
                    object replaceTextProductPrice = productPrices[productIndex - 1];
                    object replaceTextSum = sums[productIndex - 1];

                    Word.Range findRangeProductName = doc.Content;
                    Word.Range findRangeQuantity = doc.Content;
                    Word.Range findRangeProductPrice = doc.Content;
                    Word.Range findRangeSum = doc.Content;

                    if (findRangeProductName.Find.Execute(FindText: findTextProductName))
                    {
                        findRangeProductName.Text = replaceTextProductName.ToString();
                    }

                    if (findRangeQuantity.Find.Execute(FindText: findTextQuantity))
                    {
                        findRangeQuantity.Text = replaceTextQuantity.ToString();
                    }

                    if (findRangeProductPrice.Find.Execute(FindText: findTextProductPrice))
                    {
                        findRangeProductPrice.Text = replaceTextProductPrice.ToString();
                    }
                    if (findRangeSum.Find.Execute(FindText: findTextSum))
                    {
                        // Nếu tìm thấy từ khóa của cột tổng giá trị, thực hiện thay thế
                        findRangeSum.Text = replaceTextSum.ToString();
                    }

                    productIndex++;
                }

                while (true)
                {
                    object findTextProductName = "txt_billProductName" + productIndex;
                    object findTextQuantity = "txt_billQuantity" + productIndex;
                    object findTextProductPrice = "txt_billProductPrice" + productIndex;
                    object findTextSum = "txt_sum" + productIndex;

                    Word.Range findRangeProductName = doc.Content;
                    Word.Range findRangeQuantity = doc.Content;
                    Word.Range findRangeProductPrice = doc.Content;
                    Word.Range findRangeSum = doc.Content;

                    if (findRangeProductName.Find.Execute(FindText: findTextProductName))
                    {
                        findRangeProductName.Paragraphs[1].Range.Delete();
                    }
                    else
                    {
                        break;
                    }

                    if (findRangeQuantity.Find.Execute(FindText: findTextQuantity))
                    {
                        findRangeQuantity.Paragraphs[1].Range.Delete();
                    }

                    if (findRangeProductPrice.Find.Execute(FindText: findTextProductPrice))
                    {
                        findRangeProductPrice.Paragraphs[1].Range.Delete();
                    }
                    if (findRangeSum.Find.Execute(FindText: findTextSum))
                    {
                        findRangeSum.Paragraphs[1].Range.Delete();
                    }

                    productIndex++;
                }


                // Lưu hoặc in tài liệu Word
                string pdfFileName = "HoaDon_" + DateTime.Now.ToString("ddMMyyy_HHmmss") + ".docx";
                string pdfFilePath = Path.Combine(@"C:/Users/Tea/Downloads/", pdfFileName);

                doc.SaveAs2(pdfFilePath);
                doc.PrintOut();

                // Đóng tài liệu và Word Application
                doc.Close();
                wordApp.Quit();

                MessageBox.Show("Hóa đơn đã được in và lưu thành công.", "Thông báo");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để in.", "Thông báo");
            }
        }

        private string ConvertToCurrencyFormat(string value)
        {
            double amount;
            if (double.TryParse(value, out amount))
            {
                return amount.ToString("n0") + " VNĐ";
            }
            else
            {
                return value;
            }
        }

        private double ConvertToDouble(string priceString)
        {
            string cleanPriceString = priceString.Replace(" VNĐ", "").Replace(",", "");

            double price;
            if (double.TryParse(cleanPriceString, out price))
            {
                // Trừ đi 5%
                price = price / 1.05;
                return price;
            }
            else
            {
                return 0;
            }
        }
        private double BackToDouble(string priceString)
        {
            string cleanPriceString = priceString.Replace(" VNĐ", "").Replace(",", "");

            double price;
            if (double.TryParse(cleanPriceString, out price))
            {
                // Trừ đi 5%
                return price;
            }
            else
            {
                return 0;
            }
        }
        private void frm_billList_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Đóng ứng dụng Word khi form đóng
            wordApp.Quit();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(searchTerm))
            {
                try
                {
                    myDataTable = new System.Data.DataTable();
                    myDataTable.Clear();
                    myBillDataSet = new DataSet();

                    // Lấy data đưa vào dataset
                    myBillDataSet = myBill.findBill(searchTerm);
                    // Đưa dữ liệu từ dataset vào table
                    myDataTable = myBillDataSet.Tables[0];

                    // Kiểm tra dữ liệu trước khi đổ vào DataGridView
                    if (myDataTable != null && myDataTable.Rows.Count > 0)
                    {
                        // Đổ data vào datagridview
                        dtgv_billList.DataSource = myDataTable;

                        // Tùy chỉnh giao diện của datagridview
                        CustomeBillDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy hóa đơn nào.", "Thông báo");
                    }

                    txtSearch.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không hiển thị được thông tin, Lỗi: " + ex.Message, "Lỗi");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã đơn hoặc tên khách hàng để tìm kiếm.", "Thông báo");
            }
        }
    }
}


