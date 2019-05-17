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
    public partial class FormQuanLi : Form
    {
        private Process processForm = new Process();
        private int btnClick = 0;
        private List<List<string>> DataDotThi;
        private List<List<string>> DataNhiemVu;
        private string DotThiIDSelected = "";
        private string NhiemVuIDSelected = "";
        private string rowClick = "1";
        private DataGridViewCellCollection dataRowSendForm;
        private bool btnUpdateSBD = false;
        public FormQuanLi()
        {
            InitializeComponent();
        }

        private void FormQuanLi_Load(object sender, EventArgs e)
        {
            // show combo box đợt thi
            DataDotThi = processForm.GetListDotThi();
            for (int i = 0; i < DataDotThi[1].Count; i++)
            {
                cb_DotThi.Items.Add(DataDotThi[1][i]);
            }
            cb_DotThi.SelectedIndex = 0;
            lb_NgayDotThi.Text = DateTime.Parse(DataDotThi[2][0]).ToString("dd/MM/yyyy");

            DataNhiemVu = processForm.GetListNhiemVu();
            for (int i = 0; i < DataNhiemVu[1].Count; i++)
            {
                cb_NhiemVu.Items.Add(DataNhiemVu[1][i]);
            }
            cb_NhiemVu.SelectedIndex = 0;
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_DotThi_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        private void Handler_ComboBox(int btn)
        {
            DataTable dt = new DataTable();
            switch (btn)
            {
                case 1:
                    dt = processForm.GetListDotThiTable();
                    break;
                case 2:
                    dt = processForm.GetDanhSachHoiDongThi(DotThiIDSelected);
                    break;
                case 3:
                    dt = processForm.GetAllCanBo();
                    break;
                case 4:
                    dt = processForm.GetDanhSachDangKyByDotThiNull();
                    break;
                case 5:
                    dt = processForm.GetDanhSachThi(DotThiIDSelected);
                    break;
                case 6:
                    dt = processForm.GetKetQuaByDotThi(DotThiIDSelected);
                    break;
                case 7:
                    dt = processForm.GetChungChiByDotThi(DotThiIDSelected);
                    break;

            }
            dtGVShow.DataSource = dt;
        }

        private void btn_DotThi_Click(object sender, EventArgs e)
        {
            processEventClick(1);

            DataTable dt = processForm.GetListDotThiTable();
            dtGVShow.DataSource = dt;
            dtGVShow.Columns["DotThiID"].Visible = false;
            dtGVShow.Columns["TenDotThi"].HeaderText = "Tên đợt thi";
            dtGVShow.Columns["Ngay"].HeaderText = "Ngày thi";
            if (dtGVShow.SelectedRows.Count > 0)
            {
                dataRowSendForm = dtGVShow.SelectedRows[0].Cells;
            }
        }

        private void btn_HoiDongThi_Click(object sender, EventArgs e)
        {
            

        }

        private void btn_CanBo_Click(object sender, EventArgs e)
        {
           

        }

        private void btn_DanhSachDangKi_Click(object sender, EventArgs e)
        {
            

        }

        private void btn_DanhSachThi_Click(object sender, EventArgs e)
        {
           

        }

        private void btn_KetQuaThi_Click(object sender, EventArgs e)
        {
           

        }

        private void btn_ChungChi_Click(object sender, EventArgs e)
        {
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void processEventClick(int i)
        {
            btx_ThemDSThi.Text = "Thêm DS thi";
            cb_DotThi.Text = DataDotThi[1][0];
            btnClick = i;
            Button[] lstBtn = { btn_DotThi, btn_HoiDongThi, btn_CanBo, btn_DanhSachDangKi, btn_DanhSachThi, btn_KetQuaThi, btn_ChungChi };
            for (int v = 0; v < lstBtn.Length; v++)
            {
                if (v == btnClick - 1)
                    lstBtn[v].Enabled = false;
                else
                {
                    lstBtn[v].Enabled = true;
                }
                if (btnClick - 1 == 0)
                {
                    cb_DotThi.Enabled = false;
                    cb_DotThi.Text = "";
                }
                else
                {
                    cb_DotThi.Enabled = true;
                }
                if (btnClick - 1 == 3 || btnClick == 5)
                {
                    groupBox_SBD.Visible = true;
                }
                else
                {
                    groupBox_SBD.Visible = false;
                }
                if (btnClick - 1 == 2)
                {
                    groupBox_ThemHDT.Visible = true;
                }
                else
                {
                    groupBox_ThemHDT.Visible = false;
                }
                if (btnClick == 5)
                {
                    btx_ThemDSThi.Visible = false;
                    btnUpdateSBD = true;
                }
                else
                {
                    btx_ThemDSThi.Visible = true;
                    btnUpdateSBD = false;
                }
                if (btnClick == 1)
                {
                    btn_Xoa.Enabled = false;
                }
                else
                {
                    btn_Xoa.Enabled = true;
                }

            }

            dtGVShow.DataSource = null;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            switch (btnClick)
            {
                // nếu thêm thì truyền 0
                // sửa thì truyền vào id cần sửa
                case 1:
                    {
                        new FormDotThi(0.ToString(), null).ShowDialog();
                        btn_DotThi_Click(sender, e);
                        break;
                    }

            }
        }

        // handler btn sửa
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (dataRowSendForm == null)
            {
                dataRowSendForm = dtGVShow.Rows[0].Cells;
            }
            if (rowClick != "")
            {
                switch (btnClick)
                {
                    // nếu thêm thì truyền 0
                    // sửa thì truyền vào id cần sửa
                    case 1:
                        {
                            new FormDotThi(rowClick, dataRowSendForm).ShowDialog();
                            btn_DotThi_Click(sender, e);
                            break;
                        }
                    
                }
            }

        }

            // event đánh số thứ tự cho các row in gridview
            private void dtGVShow_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
            {
                var grid = sender as DataGridView;
                var rowIdx = (e.RowIndex + 1).ToString();

                var centerFormat = new StringFormat()
                {
                    // right alignment might actually make more sense for numbers
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };

                var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
                e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
            }

        private void dtGVShow_Click(object sender, EventArgs e)
        {
            if (dtGVShow.SelectedRows.Count > 0)
            {
                rowClick = dtGVShow.SelectedRows[0].Cells[0].Value.ToString();
                dataRowSendForm = dtGVShow.SelectedRows[0].Cells;
            }
            else
            {
                //dataRowSendForm = dtGVShow.Rows[0].Cells;
            }
            if (btnUpdateSBD && btnClick == 5)
            {
                tx_SBDInsert.Text = rowClick;
            }
            else
            {
                tx_SBDInsert.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        // liên quan đến xóa
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            bool resp = true;
            switch (btnClick)
            {

                case 1:
                    {
                        resp = processForm.DeleteDotThiByID(rowClick);
                        btn_DotThi_Click(sender, e);
                        break;
                    }
            }
        }

        // liên quan đến sbd thi
        private void btx_ThemDSThi_Click(object sender, EventArgs e)
        {
           
        }

        private void dtGVShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cb_NhiemVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        // liên quan đến thêm cán bộ cho hội đồng thi
        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void funcUpdateSBD(string sbd)
        {
           
        }

        private void tx_SBDInsert_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
