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
    public partial class FormDanhSachChungChi : Form
    {

        private string ChungChiID = "";
        private Process pr = new Process();
        private DataGridViewCellCollection data;
        public FormDanhSachChungChi(string chungChiID, DataGridViewCellCollection dt)
        {
            ChungChiID = chungChiID;
            data = dt;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormDanhSachChungChi_Load(object sender, EventArgs e)
        {
            if (ChungChiID == "")
            {
                DataTable listSBD = pr.GetSBDCanGetChungChi();
                for (int i = 0; i < listSBD.Rows.Count; i++)
                {
                    cb_SBD.Items.Add(listSBD.Rows[i][0].ToString());
                }
                cb_SBD.SelectedIndex = 0;
            }
            else
            {
                DataTable listSBD = pr.GetSBDbyChungChiID(ChungChiID);
                cb_SBD.Items.Add(listSBD.Rows[0][0].ToString());
                cb_SBD.SelectedIndex = 0;
                tx_SoVaoSo.Text = data[6].Value.ToString();
            }
        }

        private void cb_SBD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            bool done = true;
            if (ChungChiID == "")
            {
                done = pr.InsertChungChiBySBD(cb_SBD.Items[cb_SBD.SelectedIndex].ToString(), tx_SoVaoSo.Text.ToString());
            }
            else
            {
                done = pr.UpdateChungChiBySBD(cb_SBD.Items[cb_SBD.SelectedIndex].ToString(), tx_SoVaoSo.Text.ToString());
            }
            if (done)
            {
                MessageBox.Show("Thành công !");
            }
            else
            {
                MessageBox.Show("Thất bại !");
            }
            this.Close();
        }
    }
}
