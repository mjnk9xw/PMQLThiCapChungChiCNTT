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
        public FormCanBo(string i, DataGridViewCellCollection dt)
        {
           
            InitializeComponent();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            
        }

        private void FormCanBo_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
