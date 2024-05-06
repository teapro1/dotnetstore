using PrepareForFinal.BSLayer;
using PrepareForFinal.DBLayer;
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
    public partial class frm_login : Form
    {
        public frm_main mainForm = null;

        Account account = new Account();

        public static object TabPages { get; private set; }

        public frm_login()
        { 
            InitializeComponent();
        }

        private void frm_login_Load(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            bool check = account.testLogin(txt_username.Text.Trim(), txt_password.Text.Trim());
            if (check)
            {
                DataSet ds =  account.GetAccount(txt_username.Text.Trim(), txt_password.Text.Trim());
                DataTable dt = new DataTable();
                dt= ds.Tables[0];
                account = new Account(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString(), (bool)dt.Rows[0][4]);
                mainForm = new frm_main();
                mainForm.tk = account;
                mainForm.isRole = account.isRole;
                mainForm.Show();
                MessageBox.Show("Đăng Nhập Thành Công");
                this.Reset();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Đăng Nhập Thất Bại");
            }

        }
        private void Reset()
        {
            txt_username.ResetText();
            txt_password.ResetText();
        }

        private void lb_header_Click(object sender, EventArgs e)
        {

        }

        private void lb_username_Click(object sender, EventArgs e)
        {

        }
    }
}