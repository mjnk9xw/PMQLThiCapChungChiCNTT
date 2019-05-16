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
        public FormHoiDongThi(string i, DataGridViewCellCollection dt)
        {
               
                InitializeComponent();
        }

        private void FormHoiDongThi_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
          
        }

        private void cb_NhiemVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
