using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User
{
    public partial class Form_DangKi : Form
    {
        private CallProcedure callProcedure = new CallProcedure();
        private List<List<string>> lstNhuCau;
        private List<List<string>> lstTrinhDo;
        private List<List<string>> lstDoiTuong;
        private void Init()
        {
            lstNhuCau = callProcedure.GetDataProcedureSimple("GetNhuCau", new string[] { "TenNhuCau" });
            rd_OnLuyenVaThi.Text = lstNhuCau[0][0];
            rd_ChiThamGiaThi.Text = lstNhuCau[0][1];

            lstTrinhDo = callProcedure.GetDataProcedureSimple("GetTrinhDo", new string[] { "TenTrinhDo" });
            cb_CNTTCoBan.Text = lstTrinhDo[0][0];
            cb_CNTTNangCao.Text = lstTrinhDo[0][1];

            lstDoiTuong = callProcedure.GetDataProcedureSimple("GetDoiTuong", new string[] { "TenDoiTuong" });
            rd_ThuocHV.Text = lstDoiTuong[0][1];
            rd_KhongThuocHV.Text = lstDoiTuong[0][0];
        }
        private string ThiSinhID = "";
        private DataGridViewCellCollection dataUpdate;
        public Form_DangKi(string tsID, DataGridViewCellCollection dtUpdate)
        {
            ThiSinhID = tsID;
            dataUpdate = dtUpdate;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void tx_NgaySinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Init();
            if (ThiSinhID == "")
            {
                label1.Text = "Phiếu đăng kí";
                bt_DangKi.Text = "Đăng kí";
            }
            else
            {
                label1.Text = "Thông tin";
                bt_DangKi.Text = "Sửa thông tin";
                tx_Name.Text = dataUpdate[1].Value.ToString();
                tx_Email.Text = dataUpdate[2].Value.ToString();
                tx_NgaySinh.Value = Convert.ToDateTime(dataUpdate[3].Value.ToString());
                if (dataUpdate[4].Value.ToString() == rd_Nam.Text.ToString())
                {
                    rd_Nam.Checked = true;
                }
                else
                {
                    rd_Nu.Checked = true;
                }
                tx_CMT.Text = dataUpdate[5].Value.ToString();
                tx_Phone.Text = dataUpdate[6].Value.ToString();
                // nhu cau , trinh do , doi tuong
                if (dataUpdate[7].Value.ToString() == lstNhuCau[0][0])
                {
                    rd_OnLuyenVaThi.Checked = true;
                }
                else
                {
                    rd_ChiThamGiaThi.Checked = true;
                }
                if (dataUpdate[8].Value.ToString() == lstTrinhDo[0][0])
                {
                    cb_CNTTCoBan.Checked = true;
                }
                else
                {
                    cb_CNTTNangCao.Checked = true;
                }
                if (dataUpdate[9].Value.ToString() == lstDoiTuong[0][0])
                {
                    rd_KhongThuocHV.Checked = true;
                }
                else
                {
                    rd_ThuocHV.Checked = true;
                }
            }

        }

        private void rd_Nu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bt_DangKi_Click(object sender, EventArgs e)
        {
            string name = tx_Name.Text;
            string email = tx_Email.Text;
            DateTime ngaySinh = tx_NgaySinh.Value;
            // MessageBox.Show(ngaySinh.ToString());
            string gioiTinh = "";
            if (rd_Nam.Checked == true)
            {
                gioiTinh = rd_Nam.Text;
            }
            else
            {
                gioiTinh = rd_Nu.Text;
            }

            string cmt = tx_CMT.Text;
            string phone = tx_Phone.Text;

            int nhuCau = 0;
            if (rd_OnLuyenVaThi.Checked == true)
            {
                nhuCau = 1;
            }
            else
            {
                nhuCau = 2;
            }

            int trinhDo = 0;
            if (cb_CNTTCoBan.Checked == true && cb_CNTTNangCao.Checked == true)
            {
                trinhDo = 2;
            }
            else if (cb_CNTTCoBan.Checked == true)
            {
                trinhDo = 1;
            }
            else
            {
                trinhDo = 2;
            }
            int doiTuong = 0;
            if (rd_KhongThuocHV.Checked == true)
            {
                doiTuong = 1;
            }
            else
            {
                doiTuong = 2;
            }
            bool done = true;
            if (ThiSinhID == "")
            {
                done = callProcedure.ExecuteProcedure(
                   "InsertThiSinh",
                   new string[] { "@hoTen", "@email", "@ngaySinh", "@gioiTinh", "@cmt", "@dienThoai", "@nhuCauID", "@doiTuongID", "@trinhDoID", "@maDanhSach" },
                   new string[] { name, email, ngaySinh.ToString(), gioiTinh, cmt, phone, nhuCau.ToString(), doiTuong.ToString(), trinhDo.ToString(), 1.ToString() }
               );
            }
            else
            {
                done = callProcedure.ExecuteProcedure(
                    "UpdateThiSinh",
                    new string[] { "@thiSinhID", "@hoTen", "@email", "@ngaySinh", "@gioiTinh", "@cmt", "@dienThoai", "@nhuCauID", "@doiTuongID", "@trinhDoID", "@maDanhSach" },
                    new string[] { ThiSinhID, name, email, ngaySinh.ToString(), gioiTinh, cmt, phone, nhuCau.ToString(), doiTuong.ToString(), trinhDo.ToString(), 1.ToString() }
                );
            }
            if (!done)
            {
                MessageBox.Show("Đăng kí không thành công, mời bạn kiểm tra lại thông tin!");
            }
            else
            {
                MessageBox.Show("Đăng kí thành công !");
                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
