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
    public partial class FormDanhSachDiem : Form
    {
        private string SBD = "";
        private string DotThiID = "1";
        private Process pr = new Process();
        private DataGridViewCellCollection data;
        public FormDanhSachDiem(string dotThiID, string sbd, DataGridViewCellCollection dt)
        {
            SBD = sbd;
            data = dt;
            DotThiID = dotThiID;
            InitializeComponent();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            bool done = true;
            if (SBD == "")
            {
                done = pr.InsertKetQuaThi(cb_SBD.Items[cb_SBD.SelectedIndex].ToString(), tx_DiemTN.Text, tx_Word.Text, tx_Excel.Text, tx_PPT.Text);
            }
            else
            {
                done = pr.UpdateKetQuaThi(SBD, tx_DiemTN.Text, tx_Word.Text, tx_Excel.Text, tx_PPT.Text);
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tx_DonVi_TextChanged(object sender, EventArgs e)
        {
            if (tx_DiemTN.Text != "" && (System.Text.RegularExpressions.Regex.IsMatch(tx_DiemTN.Text, "[^0-9]") || Convert.ToInt32(tx_DiemTN.Text) > 10))
            {
                MessageBox.Show("Chỉ được điền số từ 0 đến 10.");
                tx_DiemTN.Text = tx_DiemTN.Text.Remove(tx_DiemTN.Text.Length - 1);
            }
        }

        private void tx_CapBac_TextChanged(object sender, EventArgs e)
        {
            if (tx_Word.Text != "" && (System.Text.RegularExpressions.Regex.IsMatch(tx_Word.Text, "[^0-9]") || Convert.ToInt32(tx_Word.Text) > 10))
            {
                MessageBox.Show("Chỉ được điền số từ 0 đến 10.");
                tx_Word.Text = tx_Word.Text.Remove(tx_Word.Text.Length - 1);
            }
        }

        private void tx_GhiChu_TextChanged(object sender, EventArgs e)
        {
            if (tx_Excel.Text != "" && (System.Text.RegularExpressions.Regex.IsMatch(tx_Excel.Text, "[^0-9]") || Convert.ToInt32(tx_Excel.Text) > 10))
            {
                MessageBox.Show("Chỉ được điền số từ 0 đến 10.");
                tx_Excel.Text = tx_Excel.Text.Remove(tx_Excel.Text.Length - 1);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tx_Hoten_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormDanhSachDiem_Load(object sender, EventArgs e)
        {
            if (SBD == "")
            {
                DataTable listSBD = pr.GetSBDnotyetKQ(DotThiID);
                for (int i = 0; i < listSBD.Rows.Count; i++)
                {
                    cb_SBD.Items.Add(listSBD.Rows[i][0].ToString());
                }
                cb_SBD.SelectedIndex = 0;
            }
            else
            {
                cb_SBD.Items.Add(SBD);
                cb_SBD.SelectedIndex = 0;
                DataTable kqt = pr.GetOnlyKetQuaThiBySBD(SBD);
                tx_DiemTN.Text = kqt.Rows[0][1].ToString();
                tx_Word.Text = kqt.Rows[0][2].ToString();
                tx_Excel.Text = kqt.Rows[0][3].ToString();
                tx_PPT.Text = kqt.Rows[0][4].ToString();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cb_SBD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tx_PPT_TextChanged(object sender, EventArgs e)
        {
            if (tx_PPT.Text != "" && (System.Text.RegularExpressions.Regex.IsMatch(tx_PPT.Text, "[^0-9]") || Convert.ToInt32(tx_PPT.Text) > 10))
            {
                MessageBox.Show("Chỉ được điền số từ 0 đến 10.");
                tx_PPT.Text = tx_PPT.Text.Remove(tx_PPT.Text.Length - 1);
            }
        }
    }
}
