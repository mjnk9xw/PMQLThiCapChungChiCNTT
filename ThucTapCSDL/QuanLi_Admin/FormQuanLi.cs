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
            lb_NgayDotThi.Text = DateTime.Parse(DataDotThi[2][cb_DotThi.SelectedIndex]).ToString("dd/MM/yyyy");
            DotThiIDSelected = DataDotThi[0][cb_DotThi.SelectedIndex];
            Handler_ComboBox(btnClick);
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
            processEventClick(2);
            DataTable dt = processForm.GetDanhSachHoiDongThi(DotThiIDSelected);
            dtGVShow.DataSource = dt;
            dtGVShow.Columns["CanBoID"].Visible = false;
            dtGVShow.Columns["HoTen"].HeaderText = "Họ tên";
            dtGVShow.Columns["DonVi"].HeaderText = "Đơn vị";
            dtGVShow.Columns["CapBac"].HeaderText = "Cấp bậc";
            dtGVShow.Columns["TenNhiemVu"].HeaderText = "Nhiệm vụ";
            dtGVShow.Columns["GhiChu"].HeaderText = "Ghi chú";
            if (dtGVShow.SelectedRows.Count > 0)
            {
                dataRowSendForm = dtGVShow.SelectedRows[0].Cells;
            }

        }

        private void btn_CanBo_Click(object sender, EventArgs e)
        {
            processEventClick(3);
            DataTable dt = processForm.GetAllCanBo();
            dtGVShow.DataSource = dt;
            dtGVShow.Columns["CanBoID"].Visible = false;
            dtGVShow.Columns["Hoten"].HeaderText = "Họ tên";
            dtGVShow.Columns["DonVi"].HeaderText = "Đơn vị";
            dtGVShow.Columns["CapBac"].HeaderText = "Cấp bậc";
            dtGVShow.Columns["GhiChu"].HeaderText = "Ghi chú";
            if (dtGVShow.SelectedRows.Count > 0)
            {
                dataRowSendForm = dtGVShow.SelectedRows[0].Cells;
            }

        }

        private void btn_DanhSachDangKi_Click(object sender, EventArgs e)
        {
            processEventClick(4);
            DataTable dt = processForm.GetDanhSachDangKyByDotThiNull();
            dtGVShow.DataSource = dt;

            if (dtGVShow.SelectedRows.Count > 0)
            {
                dataRowSendForm = dtGVShow.SelectedRows[0].Cells;
            }

            dtGVShow.Columns["ThiSinhID"].Visible = false;
            dtGVShow.Columns["TenDanhSach"].Visible = false;
            dtGVShow.Columns["HoTen"].HeaderText = "Họ tên";
            dtGVShow.Columns["TenTrinhDo"].HeaderText = "Trình độ";
            dtGVShow.Columns["TenNhuCau"].HeaderText = "Nhu cầu";
            dtGVShow.Columns["GioiTinh"].HeaderText = "Giới tính";
            dtGVShow.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dtGVShow.Columns["DienThoai"].HeaderText = "SĐT";
            dtGVShow.Columns["TenDoiTuong"].HeaderText = "Đối tượng";
            dtGVShow.Columns["LePhi"].HeaderText = "Lệ phí";
            groupBox_SBD.Visible = true;



        }

        private void btn_DanhSachThi_Click(object sender, EventArgs e)
        {
            processEventClick(5);
            DataTable dt = processForm.GetDanhSachThi(DotThiIDSelected);
            dtGVShow.DataSource = dt;
            dtGVShow.Columns["HoTen"].HeaderText = "Họ tên";
            dtGVShow.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            if (dtGVShow.SelectedRows.Count > 0)
            {
                dataRowSendForm = dtGVShow.SelectedRows[0].Cells;
            }

        }

        private void btn_KetQuaThi_Click(object sender, EventArgs e)
        {
            processEventClick(6);
            DataTable dt = processForm.GetKetQuaByDotThi(DotThiIDSelected);
            dtGVShow.DataSource = dt;
            dtGVShow.Columns["HoTen"].HeaderText = "Họ tên";
            dtGVShow.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dtGVShow.Columns["DiemTracNghiem"].HeaderText = "Điểm trắc nghiệm";
            dtGVShow.Columns["DiemThucHanh"].HeaderText = "Điểm thực hành";
            if (dtGVShow.SelectedRows.Count > 0)
            {
                dataRowSendForm = dtGVShow.SelectedRows[0].Cells;
            }
        }

        private void btn_ChungChi_Click(object sender, EventArgs e)
        {
            processEventClick(7);
            DataTable dt = processForm.GetChungChiByDotThi(DotThiIDSelected);
            dtGVShow.DataSource = dt;
            dtGVShow.Columns["ChungChiID"].Visible = false;
            dtGVShow.Columns["HoTen"].HeaderText = "Họ tên";
            dtGVShow.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dtGVShow.Columns["TenDoiTuong"].HeaderText = "Đối tượng";
            dtGVShow.Columns["SoVaoSo"].HeaderText = "Số vào sổ";
            dtGVShow.Columns["SoVanBang"].HeaderText = "Số văn bằng";
            if (dtGVShow.SelectedRows.Count > 0)
            {
                dataRowSendForm = dtGVShow.SelectedRows[0].Cells;
            }



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
                case 2:
                    btn_CanBo_Click(sender, e);
                    break;
                case 3:
                    {
                        new FormCanBo(0.ToString(), null).ShowDialog();
                        btn_CanBo_Click(sender, e);
                        break;
                    }
                case 4:
                    {
                        new User.Form_DangKi("", null).Show();
                        btn_DanhSachDangKi_Click(sender, e);
                        break;
                    }
                case 5:
                    {
                        btn_DanhSachDangKi_Click(sender, e);
                        break;
                    }
                case 6:
                    {
                        new FormDanhSachDiem(DotThiIDSelected, "", null).ShowDialog();
                        btn_KetQuaThi_Click(sender, e);
                        break;
                    }
                case 7:
                    {
                        new FormDanhSachChungChi("", null).ShowDialog();
                        btn_ChungChi_Click(sender, e);
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
                    case 2:
                        {
                            new FormHoiDongThi(DotThiIDSelected, dataRowSendForm).ShowDialog();
                            btn_HoiDongThi_Click(sender, e);
                            break;
                        }
                    case 3:
                        {
                            new FormCanBo(rowClick, dataRowSendForm).ShowDialog();
                            btn_CanBo_Click(sender, e);
                            break;
                        }
                    case 4:
                        {
                            new User.Form_DangKi(rowClick, dataRowSendForm).ShowDialog();
                            btn_DanhSachDangKi_Click(sender, e);
                            break;
                        }
                    case 5:
                        {
                            funcUpdateSBD(rowClick);
                            btn_DanhSachThi_Click(sender, e);
                            break;
                        }
                    case 6:
                        {
                            new FormDanhSachDiem(DotThiIDSelected, rowClick, dataRowSendForm).ShowDialog();
                            btn_KetQuaThi_Click(sender, e);
                            break;
                        }
                    case 7:
                        {
                            new FormDanhSachChungChi(rowClick, dataRowSendForm).ShowDialog();
                            btn_ChungChi_Click(sender, e);
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
                        if (MessageBox.Show("Bạn có muốn xóa?", "Xóa Đợt Thi?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            resp = processForm.DeleteDotThiByID(rowClick);
                            btn_DotThi_Click(sender, e);
                        }

                        break;
                    }
                case 2:
                    {
                        resp = processForm.DeleteCanBoInHoiDongThi(DotThiIDSelected, rowClick);
                        btn_HoiDongThi_Click(sender, e);
                        if (MessageBox.Show("Bạn có muốn xóa?", "Xóa Cán Bộ Hội đồng coi thi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            resp = processForm.DeleteCanBoInHoiDongThi(DotThiIDSelected, rowClick);
                            btn_HoiDongThi_Click(sender, e);
                        }

                        break;
                    }
                case 3:
                    {
                        resp = processForm.DeleteCanBo(rowClick);
                        btn_CanBo_Click(sender, e);
                        break;
                    }
                case 4:
                    {
                        resp = processForm.DeleteThiSinh(rowClick);
                        btn_DanhSachDangKi_Click(sender, e);
                        break;
                    }
                case 5:
                    {
                        resp = processForm.DeleteSBDOfThiSinh(rowClick);
                        btn_DanhSachThi_Click(sender, e);
                        break;
                    }
                case 6:
                    {
                        resp = processForm.DeleteKetQuaThi(rowClick);
                        btn_KetQuaThi_Click(sender, e);
                        break;
                    }
                case 7:
                    {
                        resp = processForm.DeleteChungChi(rowClick);
                        btn_ChungChi_Click(sender, e);
                        break;
                    }
                    if (MessageBox.Show("Bạn có muốn xóa?", "Xóa Cán Bộ ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        resp = processForm.DeleteCanBo(rowClick);
                        btn_CanBo_Click(sender, e);
                    }
                    break;

            }
        }

        // liên quan đến sbd thi
        private void btx_ThemDSThi_Click(object sender, EventArgs e)
        {
            if (tx_SBDInsert.Text == "" || tx_SBDInsert.Text.Length > 10)
            {
                MessageBox.Show("SBD phải nhỏ hơn 10 kí tự!");
            }
            else
            {
                processForm.ProcessInsertThiSinhToDSThi(dataRowSendForm[0].Value.ToString(), DotThiIDSelected, tx_SBDInsert.Text.ToString());
                MessageBox.Show("Thành công!");
                btn_DanhSachDangKi_Click(sender, e);
            }
        }

        private void dtGVShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cb_NhiemVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            NhiemVuIDSelected = DataNhiemVu[0][cb_NhiemVu.SelectedIndex];
        }

        // liên quan đến thêm cán bộ cho hội đồng thi
        private void button1_Click_1(object sender, EventArgs e)
        {
            processForm.InsertCanBoToHoiDongThi(DotThiIDSelected, dataRowSendForm[0].Value.ToString(), NhiemVuIDSelected);
            MessageBox.Show("Thành công!");
            btn_HoiDongThi_Click(sender, e);
        }

        private void funcUpdateSBD(string sbd)
        {
            bool done = processForm.UpdateSBD(sbd, tx_SBDInsert.Text.ToString());
            if (done)
            {
                MessageBox.Show("Thành công!");
            }
            else
            {
                MessageBox.Show("Thất bại, SBD đã có kết quả thi!");
            }
        }

        private void tx_SBDInsert_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
