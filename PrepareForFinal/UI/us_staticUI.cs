using PrepareForFinal.BSLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrepareForFinal.UI
{
    public partial class us_staticUI : UserControl
    {
        public us_staticUI()
        {
            InitializeComponent();
            loadData();
        }

        DataTable dtStatis = null;
        Statistic dbStatis = new Statistic();

        public void loadData()
        {
            dbStatis.getProduct(cbNameProduct);
            
            
        }



        private void btn_productGroupButton_Click(object sender, EventArgs e)
        {

        }

        private void btn_ProStas_Click(object sender, EventArgs e)
        {
            try
            {
                dtStatis = new DataTable();
                DataSet myAccountDataSet = new DataSet();
                // Lấy data đưa vào dataset
                myAccountDataSet = dbStatis.GetProductMonth(dbStatis.getProductID(cbNameProduct), Convert.ToInt32(cbMonth.Text), Convert.ToInt32(txt_year.Text.Trim()));
                // Đưa dữ liệu từ dataset vào table
                dtStatis = myAccountDataSet.Tables[0];
                // Đổ data vào datagridview
                dgv_statistic.DataSource = dtStatis;
                // Tùy chỉnh giao diện cho cái list
                dgv_statistic.AllowUserToAddRows = false;
                dgv_statistic.Columns[0].HeaderText = "Số lượng mua";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
          
        }

        private void btn_BillStatistic_Click(object sender, EventArgs e)
        {
            try
            {
                dtStatis = new DataTable();
                DataSet ds = new DataSet();
                ds = dbStatis.getBillOfCustomer();
                dtStatis = ds.Tables[0];
                dgv_statistic.DataSource = dtStatis;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
