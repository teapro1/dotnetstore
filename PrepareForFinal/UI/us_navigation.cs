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
    public partial class us_navigation : UserControl
    {
        public us_navigation()
        {
            InitializeComponent(); 

        }

        private void btn_showPaymentUI_Click(object sender, EventArgs e)
        {
            lb_notify.Text = "Đây là trang thanh toán";
            btn_showPaymentUI.BackColor = Color.FromArgb(242, 222, 186);

        }

        private void btn_showProductUI_Click(object sender, EventArgs e)
        {
            lb_notify.Text = "Đây là trang sản phẩm";
            btn_showProductUI.BackColor = Color.FromArgb(242, 222, 186);
        }

    }
}
