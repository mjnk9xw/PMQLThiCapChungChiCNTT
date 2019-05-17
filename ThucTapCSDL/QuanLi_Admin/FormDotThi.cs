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
    public partial class FormDotThi : Form
    {

        private Process pr = new Process();
        private string insertOrUpdate = "";
        private DataGridViewCellCollection data;
        public FormDotThi(string i, DataGridViewCellCollection dt)
        {
            // i == 0 -> insert
            // i > 0 -> id cần để update
            data = dt;
            insertOrUpdate = i;
            InitializeComponent();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string tenDotThi = tx_TenDotThi.Text;
            string ngayThi = tx_Ngay.Value.ToShortDateString();
            if (tenDotThi == "" || ngayThi == "")
            {
                MessageBox.Show("Không được để trống !");
                return;
            }
            bool resp = true;
            if (insertOrUpdate == "0")
            {
                resp = pr.InsertDotThi(tenDotThi, ngayThi);
            }
            else
            {
                resp = pr.UpdateDotThi(insertOrUpdate, tenDotThi, ngayThi);
            }
            if (resp)
            {
                MessageBox.Show("Thành công !");
                this.Close();
            }
            else
            {
                MessageBox.Show("Thất bại !");
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDotThi_Load(object sender, EventArgs e)
        {
            if (insertOrUpdate != "0")
            {
                tx_TenDotThi.Text = data[1].Value.ToString();
                tx_Ngay.Value = Convert.ToDateTime(data[2].Value.ToString());
                // MessageBox.Show(data[1].Value.ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tx_TenDotThi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
