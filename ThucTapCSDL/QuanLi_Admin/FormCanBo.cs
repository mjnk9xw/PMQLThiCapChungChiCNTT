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
    public partial class FormCanBo : Form
    {
        private Process pr = new Process();
        private string insertOrUpdate = "";
        private DataGridViewCellCollection data;
        public FormCanBo(string i, DataGridViewCellCollection dt)
        {
            // i == 0 -> insert
            // i > 0 -> id cần để update
            data = dt;
            insertOrUpdate = i;
            InitializeComponent();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string hoten = tx_Hoten.Text;
            string capbac = tx_CapBac.Text;
            string donvi = tx_DonVi.Text;
            string ghichu = tx_GhiChu.Text;
            if (hoten == "" || capbac == "" || donvi == "")
            {
                MessageBox.Show("Không được để trống !");
                return;
            }
            bool resp = true;
            if (insertOrUpdate == "0")
            {
                resp = pr.InsertCanBo(hoten, donvi, capbac, ghichu);
            }
            else
            {
                resp = pr.UpdateCanBo(insertOrUpdate, hoten, donvi, capbac, ghichu);
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

        private void FormCanBo_Load(object sender, EventArgs e)
        {
            if (insertOrUpdate != "0")
            {
                tx_Hoten.Text = data[1].Value.ToString();
                tx_DonVi.Text = data[2].Value.ToString();
                tx_CapBac.Text = data[3].Value.ToString();
                tx_GhiChu.Text = data[4].Value.ToString();
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
