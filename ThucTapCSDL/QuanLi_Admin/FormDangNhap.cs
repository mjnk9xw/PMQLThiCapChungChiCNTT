using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLi_Admin
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

       
        void DangNhap()
        {
            string tk = tx_TaiKhoan.Text;
            string pass = tx_MatKhau.Text;
            if (tk == "admin" && pass == "admin")
            {
                //    // call form quản lí
                tx_TaiKhoan.Clear();
                tx_MatKhau.Clear();
                new FormQuanLi().Show();

                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Tài khoản , mật khẩu không chính xác");
            }
        }
        private void bt_DangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

       

        private void tx_TaiKhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) DangNhap();

        }
    }
}
