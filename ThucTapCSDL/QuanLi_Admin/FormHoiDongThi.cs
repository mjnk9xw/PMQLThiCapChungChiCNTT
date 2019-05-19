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
    public partial class FormHoiDongThi : Form
    {
        private Process processForm = new Process();
        private List<List<string>> DataNhiemVu;
        private string NhiemVuIDSelected = "1";
        private string insertOrUpdate = "";
        private DataGridViewCellCollection data;
        public FormHoiDongThi(string i, DataGridViewCellCollection dt)
        {
            data = dt;
            insertOrUpdate = i; // mã đợt thi
            InitializeComponent();
        }

        private void FormHoiDongThi_Load(object sender, EventArgs e)
        {
            DataNhiemVu = processForm.GetListNhiemVu();
            for (int i = 0; i < DataNhiemVu[1].Count; i++)
            {
                cb_NhiemVu.Items.Add(DataNhiemVu[1][i]);
            }
            cb_NhiemVu.SelectedIndex = 0;
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            bool done = processForm.UpdateCanBoToHoiDongThi(insertOrUpdate, data[0].Value.ToString(), NhiemVuIDSelected);
            if (done)
                MessageBox.Show("Thành công !");
            else
                MessageBox.Show("Không sửa được !");
            this.Close();
        }

        private void cb_NhiemVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            NhiemVuIDSelected = DataNhiemVu[0][cb_NhiemVu.SelectedIndex];
        }
    }
}
