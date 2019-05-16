namespace QuanLi_Admin
{
    partial class FormQuanLi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_DotThi = new System.Windows.Forms.Button();
            this.btn_HoiDongThi = new System.Windows.Forms.Button();
            this.btn_CanBo = new System.Windows.Forms.Button();
            this.btn_DanhSachDangKi = new System.Windows.Forms.Button();
            this.bt_Exit = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_DanhSachThi = new System.Windows.Forms.Button();
            this.btn_KetQuaThi = new System.Windows.Forms.Button();
            this.btn_ChungChi = new System.Windows.Forms.Button();
            this.cb_DotThi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_NgayDotThi = new System.Windows.Forms.Label();
            this.dtGVShow = new System.Windows.Forms.DataGridView();
            this.tx_SBDInsert = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox_SBD = new System.Windows.Forms.GroupBox();
            this.btx_ThemDSThi = new System.Windows.Forms.Button();
            this.groupBox_ThemHDT = new System.Windows.Forms.GroupBox();
            this.cb_NhiemVu = new System.Windows.Forms.ComboBox();
            this.btn_ThemNhiemVu = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVShow)).BeginInit();
            this.groupBox_SBD.SuspendLayout();
            this.groupBox_ThemHDT.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_DotThi
            // 
            this.btn_DotThi.Location = new System.Drawing.Point(24, 85);
            this.btn_DotThi.Name = "btn_DotThi";
            this.btn_DotThi.Size = new System.Drawing.Size(82, 23);
            this.btn_DotThi.TabIndex = 0;
            this.btn_DotThi.Text = "Đợt thi";
            this.btn_DotThi.UseVisualStyleBackColor = true;
            this.btn_DotThi.Click += new System.EventHandler(this.btn_DotThi_Click);
            // 
            // btn_HoiDongThi
            // 
            this.btn_HoiDongThi.Location = new System.Drawing.Point(24, 134);
            this.btn_HoiDongThi.Name = "btn_HoiDongThi";
            this.btn_HoiDongThi.Size = new System.Drawing.Size(82, 23);
            this.btn_HoiDongThi.TabIndex = 1;
            this.btn_HoiDongThi.Text = "Hội đồng thi";
            this.btn_HoiDongThi.UseVisualStyleBackColor = true;
            this.btn_HoiDongThi.Click += new System.EventHandler(this.btn_HoiDongThi_Click);
            // 
            // btn_CanBo
            // 
            this.btn_CanBo.Location = new System.Drawing.Point(24, 178);
            this.btn_CanBo.Name = "btn_CanBo";
            this.btn_CanBo.Size = new System.Drawing.Size(82, 34);
            this.btn_CanBo.TabIndex = 2;
            this.btn_CanBo.Text = "Thông tin cán bộ";
            this.btn_CanBo.UseVisualStyleBackColor = true;
            this.btn_CanBo.Click += new System.EventHandler(this.btn_CanBo_Click);
            // 
            // btn_DanhSachDangKi
            // 
            this.btn_DanhSachDangKi.Location = new System.Drawing.Point(24, 237);
            this.btn_DanhSachDangKi.Name = "btn_DanhSachDangKi";
            this.btn_DanhSachDangKi.Size = new System.Drawing.Size(82, 37);
            this.btn_DanhSachDangKi.TabIndex = 3;
            this.btn_DanhSachDangKi.Text = "Danh sách đăng kí";
            this.btn_DanhSachDangKi.UseVisualStyleBackColor = true;
            this.btn_DanhSachDangKi.Click += new System.EventHandler(this.btn_DanhSachDangKi_Click);
            // 
            // bt_Exit
            // 
            this.bt_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Exit.Location = new System.Drawing.Point(833, 515);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(75, 23);
            this.bt_Exit.TabIndex = 4;
            this.bt_Exit.Text = "Thoát";
            this.bt_Exit.UseVisualStyleBackColor = true;
            this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Xoa.Location = new System.Drawing.Point(833, 477);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 6;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Sua.Location = new System.Drawing.Point(739, 477);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 23);
            this.btn_Sua.TabIndex = 7;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Them.Location = new System.Drawing.Point(641, 477);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 23);
            this.btn_Them.TabIndex = 8;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(706, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Giao diện quản lí thi cấp chứng chỉ chuẩn ứng dụng CNTT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_DanhSachThi
            // 
            this.btn_DanhSachThi.Location = new System.Drawing.Point(24, 301);
            this.btn_DanhSachThi.Name = "btn_DanhSachThi";
            this.btn_DanhSachThi.Size = new System.Drawing.Size(82, 24);
            this.btn_DanhSachThi.TabIndex = 10;
            this.btn_DanhSachThi.Text = "Danh sách thi";
            this.btn_DanhSachThi.UseVisualStyleBackColor = true;
            this.btn_DanhSachThi.Click += new System.EventHandler(this.btn_DanhSachThi_Click);
            // 
            // btn_KetQuaThi
            // 
            this.btn_KetQuaThi.Location = new System.Drawing.Point(24, 351);
            this.btn_KetQuaThi.Name = "btn_KetQuaThi";
            this.btn_KetQuaThi.Size = new System.Drawing.Size(82, 34);
            this.btn_KetQuaThi.TabIndex = 11;
            this.btn_KetQuaThi.Text = "Danh sách điểm";
            this.btn_KetQuaThi.UseVisualStyleBackColor = true;
            this.btn_KetQuaThi.Click += new System.EventHandler(this.btn_KetQuaThi_Click);
            // 
            // btn_ChungChi
            // 
            this.btn_ChungChi.Location = new System.Drawing.Point(24, 417);
            this.btn_ChungChi.Name = "btn_ChungChi";
            this.btn_ChungChi.Size = new System.Drawing.Size(82, 35);
            this.btn_ChungChi.TabIndex = 12;
            this.btn_ChungChi.Text = "Danh sách chứng chỉ";
            this.btn_ChungChi.UseVisualStyleBackColor = true;
            this.btn_ChungChi.Click += new System.EventHandler(this.btn_ChungChi_Click);
            // 
            // cb_DotThi
            // 
            this.cb_DotThi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_DotThi.FormattingEnabled = true;
            this.cb_DotThi.Location = new System.Drawing.Point(139, 86);
            this.cb_DotThi.Name = "cb_DotThi";
            this.cb_DotThi.Size = new System.Drawing.Size(527, 21);
            this.cb_DotThi.TabIndex = 13;
            this.cb_DotThi.SelectedIndexChanged += new System.EventHandler(this.cb_DotThi_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(698, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ngày :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lb_NgayDotThi
            // 
            this.lb_NgayDotThi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_NgayDotThi.AutoSize = true;
            this.lb_NgayDotThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NgayDotThi.Location = new System.Drawing.Point(763, 88);
            this.lb_NgayDotThi.Name = "lb_NgayDotThi";
            this.lb_NgayDotThi.Size = new System.Drawing.Size(73, 17);
            this.lb_NgayDotThi.TabIndex = 15;
            this.lb_NgayDotThi.Text = "label ngày";
            // 
            // dtGVShow
            // 
            this.dtGVShow.AllowUserToAddRows = false;
            this.dtGVShow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGVShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGVShow.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtGVShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVShow.GridColor = System.Drawing.SystemColors.Control;
            this.dtGVShow.Location = new System.Drawing.Point(139, 134);
            this.dtGVShow.MultiSelect = false;
            this.dtGVShow.Name = "dtGVShow";
            this.dtGVShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGVShow.Size = new System.Drawing.Size(769, 318);
            this.dtGVShow.TabIndex = 16;
            this.dtGVShow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGVShow_CellContentClick);
            this.dtGVShow.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dtGVShow_RowPostPaint);
            this.dtGVShow.Click += new System.EventHandler(this.dtGVShow_Click);
            // 
            // tx_SBDInsert
            // 
            this.tx_SBDInsert.Location = new System.Drawing.Point(77, 12);
            this.tx_SBDInsert.Name = "tx_SBDInsert";
            this.tx_SBDInsert.Size = new System.Drawing.Size(141, 20);
            this.tx_SBDInsert.TabIndex = 17;
            this.tx_SBDInsert.TextChanged += new System.EventHandler(this.tx_SBDInsert_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "SBD:";
            // 
            // groupBox_SBD
            // 
            this.groupBox_SBD.Controls.Add(this.btx_ThemDSThi);
            this.groupBox_SBD.Controls.Add(this.tx_SBDInsert);
            this.groupBox_SBD.Controls.Add(this.label3);
            this.groupBox_SBD.Location = new System.Drawing.Point(139, 470);
            this.groupBox_SBD.Name = "groupBox_SBD";
            this.groupBox_SBD.Size = new System.Drawing.Size(231, 68);
            this.groupBox_SBD.TabIndex = 19;
            this.groupBox_SBD.TabStop = false;
            this.groupBox_SBD.Visible = false;
            // 
            // btx_ThemDSThi
            // 
            this.btx_ThemDSThi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btx_ThemDSThi.Location = new System.Drawing.Point(143, 38);
            this.btx_ThemDSThi.Name = "btx_ThemDSThi";
            this.btx_ThemDSThi.Size = new System.Drawing.Size(75, 23);
            this.btx_ThemDSThi.TabIndex = 19;
            this.btx_ThemDSThi.Text = "Thêm DS thi";
            this.btx_ThemDSThi.UseVisualStyleBackColor = true;
            this.btx_ThemDSThi.Click += new System.EventHandler(this.btx_ThemDSThi_Click);
            // 
            // groupBox_ThemHDT
            // 
            this.groupBox_ThemHDT.Controls.Add(this.cb_NhiemVu);
            this.groupBox_ThemHDT.Controls.Add(this.btn_ThemNhiemVu);
            this.groupBox_ThemHDT.Controls.Add(this.label4);
            this.groupBox_ThemHDT.Location = new System.Drawing.Point(376, 470);
            this.groupBox_ThemHDT.Name = "groupBox_ThemHDT";
            this.groupBox_ThemHDT.Size = new System.Drawing.Size(231, 68);
            this.groupBox_ThemHDT.TabIndex = 20;
            this.groupBox_ThemHDT.TabStop = false;
            this.groupBox_ThemHDT.Visible = false;
            // 
            // cb_NhiemVu
            // 
            this.cb_NhiemVu.FormattingEnabled = true;
            this.cb_NhiemVu.Location = new System.Drawing.Point(76, 10);
            this.cb_NhiemVu.Name = "cb_NhiemVu";
            this.cb_NhiemVu.Size = new System.Drawing.Size(142, 21);
            this.cb_NhiemVu.TabIndex = 20;
            this.cb_NhiemVu.SelectedIndexChanged += new System.EventHandler(this.cb_NhiemVu_SelectedIndexChanged);
            // 
            // btn_ThemNhiemVu
            // 
            this.btn_ThemNhiemVu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ThemNhiemVu.Location = new System.Drawing.Point(122, 38);
            this.btn_ThemNhiemVu.Name = "btn_ThemNhiemVu";
            this.btn_ThemNhiemVu.Size = new System.Drawing.Size(96, 23);
            this.btn_ThemNhiemVu.TabIndex = 19;
            this.btn_ThemNhiemVu.Text = "Thêm vào đợt thi";
            this.btn_ThemNhiemVu.UseVisualStyleBackColor = true;
            this.btn_ThemNhiemVu.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Nhiệm vụ";
            // 
            // FormQuanLi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 578);
            this.Controls.Add(this.groupBox_ThemHDT);
            this.Controls.Add(this.groupBox_SBD);
            this.Controls.Add(this.bt_Exit);
            this.Controls.Add(this.dtGVShow);
            this.Controls.Add(this.lb_NgayDotThi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_DotThi);
            this.Controls.Add(this.btn_ChungChi);
            this.Controls.Add(this.btn_KetQuaThi);
            this.Controls.Add(this.btn_DanhSachThi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_DanhSachDangKi);
            this.Controls.Add(this.btn_CanBo);
            this.Controls.Add(this.btn_HoiDongThi);
            this.Controls.Add(this.btn_DotThi);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "FormQuanLi";
            this.Load += new System.EventHandler(this.FormQuanLi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGVShow)).EndInit();
            this.groupBox_SBD.ResumeLayout(false);
            this.groupBox_SBD.PerformLayout();
            this.groupBox_ThemHDT.ResumeLayout(false);
            this.groupBox_ThemHDT.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_DotThi;
        private System.Windows.Forms.Button btn_HoiDongThi;
        private System.Windows.Forms.Button btn_CanBo;
        private System.Windows.Forms.Button btn_DanhSachDangKi;
        private System.Windows.Forms.Button bt_Exit;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_DanhSachThi;
        private System.Windows.Forms.Button btn_KetQuaThi;
        private System.Windows.Forms.Button btn_ChungChi;
        private System.Windows.Forms.ComboBox cb_DotThi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_NgayDotThi;
        private System.Windows.Forms.DataGridView dtGVShow;
        private System.Windows.Forms.TextBox tx_SBDInsert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox_SBD;
        private System.Windows.Forms.Button btx_ThemDSThi;
        private System.Windows.Forms.GroupBox groupBox_ThemHDT;
        private System.Windows.Forms.ComboBox cb_NhiemVu;
        private System.Windows.Forms.Button btn_ThemNhiemVu;
        private System.Windows.Forms.Label label4;
    }
}