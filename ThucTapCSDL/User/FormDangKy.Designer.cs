namespace User
{
    partial class Form_DangKi
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
            System.Windows.Forms.Label Email_Address;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            this.label1 = new System.Windows.Forms.Label();
            this.tx_Email = new System.Windows.Forms.TextBox();
            this.tx_Name = new System.Windows.Forms.TextBox();
            this.tx_CMT = new System.Windows.Forms.TextBox();
            this.tx_Phone = new System.Windows.Forms.TextBox();
            this.tx_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.rd_Nam = new System.Windows.Forms.RadioButton();
            this.rd_Nu = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rd_ChiThamGiaThi = new System.Windows.Forms.RadioButton();
            this.rd_OnLuyenVaThi = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cb_CNTTNangCao = new System.Windows.Forms.CheckBox();
            this.cb_CNTTCoBan = new System.Windows.Forms.CheckBox();
            this.bt_DangKi = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rd_KhongThuocHV = new System.Windows.Forms.RadioButton();
            this.rd_ThuocHV = new System.Windows.Forms.RadioButton();
            Email_Address = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Email_Address
            // 
            Email_Address.AutoSize = true;
            Email_Address.Location = new System.Drawing.Point(31, 74);
            Email_Address.Name = "Email_Address";
            Email_Address.Size = new System.Drawing.Size(72, 13);
            Email_Address.TabIndex = 1;
            Email_Address.Text = "Email address";
            Email_Address.Click += new System.EventHandler(this.label2_Click);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(31, 124);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(54, 13);
            label2.TabIndex = 3;
            label2.Text = "Họ và tên";
            label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(31, 265);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(78, 13);
            label3.TabIndex = 5;
            label3.Text = "Số chứng minh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(31, 311);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(91, 13);
            label4.TabIndex = 7;
            label4.Text = "Điện thoại liên lạc";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(31, 181);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(54, 13);
            label5.TabIndex = 9;
            label5.Text = "Ngày sinh";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(31, 222);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(47, 13);
            label6.TabIndex = 14;
            label6.Text = "Giới tính";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(31, 359);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(48, 13);
            label7.TabIndex = 17;
            label7.Text = "Nhu cầu";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(31, 408);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(47, 13);
            label8.TabIndex = 20;
            label8.Text = "Trình độ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(31, 482);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(53, 13);
            label9.TabIndex = 23;
            label9.Text = "Đối tượng";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phiếu đăng kí";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tx_Email
            // 
            this.tx_Email.Location = new System.Drawing.Point(121, 71);
            this.tx_Email.Name = "tx_Email";
            this.tx_Email.Size = new System.Drawing.Size(347, 20);
            this.tx_Email.TabIndex = 2;
            // 
            // tx_Name
            // 
            this.tx_Name.Location = new System.Drawing.Point(121, 121);
            this.tx_Name.Name = "tx_Name";
            this.tx_Name.Size = new System.Drawing.Size(347, 20);
            this.tx_Name.TabIndex = 4;
            // 
            // tx_CMT
            // 
            this.tx_CMT.Location = new System.Drawing.Point(121, 262);
            this.tx_CMT.Name = "tx_CMT";
            this.tx_CMT.Size = new System.Drawing.Size(347, 20);
            this.tx_CMT.TabIndex = 6;
            // 
            // tx_Phone
            // 
            this.tx_Phone.Location = new System.Drawing.Point(121, 308);
            this.tx_Phone.Name = "tx_Phone";
            this.tx_Phone.Size = new System.Drawing.Size(347, 20);
            this.tx_Phone.TabIndex = 8;
            // 
            // tx_NgaySinh
            // 
            this.tx_NgaySinh.CustomFormat = "dd/MM/yyyy";
            this.tx_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tx_NgaySinh.Location = new System.Drawing.Point(120, 174);
            this.tx_NgaySinh.MaxDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.tx_NgaySinh.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.tx_NgaySinh.Name = "tx_NgaySinh";
            this.tx_NgaySinh.Size = new System.Drawing.Size(347, 20);
            this.tx_NgaySinh.TabIndex = 11;
            this.tx_NgaySinh.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.tx_NgaySinh.ValueChanged += new System.EventHandler(this.tx_NgaySinh_ValueChanged);
            // 
            // rd_Nam
            // 
            this.rd_Nam.AutoSize = true;
            this.rd_Nam.Checked = true;
            this.rd_Nam.Location = new System.Drawing.Point(6, 9);
            this.rd_Nam.Name = "rd_Nam";
            this.rd_Nam.Size = new System.Drawing.Size(47, 17);
            this.rd_Nam.TabIndex = 12;
            this.rd_Nam.TabStop = true;
            this.rd_Nam.Text = "Nam";
            this.rd_Nam.UseVisualStyleBackColor = true;
            // 
            // rd_Nu
            // 
            this.rd_Nu.AutoSize = true;
            this.rd_Nu.Location = new System.Drawing.Point(151, 9);
            this.rd_Nu.Name = "rd_Nu";
            this.rd_Nu.Size = new System.Drawing.Size(39, 17);
            this.rd_Nu.TabIndex = 13;
            this.rd_Nu.Text = "Nữ";
            this.rd_Nu.UseVisualStyleBackColor = true;
            this.rd_Nu.CheckedChanged += new System.EventHandler(this.rd_Nu_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rd_Nu);
            this.groupBox1.Controls.Add(this.rd_Nam);
            this.groupBox1.Location = new System.Drawing.Point(121, 211);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 32);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rd_ChiThamGiaThi);
            this.groupBox2.Controls.Add(this.rd_OnLuyenVaThi);
            this.groupBox2.Location = new System.Drawing.Point(120, 350);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 32);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // rd_ChiThamGiaThi
            // 
            this.rd_ChiThamGiaThi.AutoSize = true;
            this.rd_ChiThamGiaThi.Location = new System.Drawing.Point(151, 9);
            this.rd_ChiThamGiaThi.Name = "rd_ChiThamGiaThi";
            this.rd_ChiThamGiaThi.Size = new System.Drawing.Size(97, 17);
            this.rd_ChiThamGiaThi.TabIndex = 13;
            this.rd_ChiThamGiaThi.Text = "Chỉ tham gia thi";
            this.rd_ChiThamGiaThi.UseVisualStyleBackColor = true;
            // 
            // rd_OnLuyenVaThi
            // 
            this.rd_OnLuyenVaThi.AutoSize = true;
            this.rd_OnLuyenVaThi.Checked = true;
            this.rd_OnLuyenVaThi.Location = new System.Drawing.Point(12, 9);
            this.rd_OnLuyenVaThi.Name = "rd_OnLuyenVaThi";
            this.rd_OnLuyenVaThi.Size = new System.Drawing.Size(96, 17);
            this.rd_OnLuyenVaThi.TabIndex = 12;
            this.rd_OnLuyenVaThi.TabStop = true;
            this.rd_OnLuyenVaThi.Text = "Ôn luyện và thi";
            this.rd_OnLuyenVaThi.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cb_CNTTNangCao);
            this.groupBox3.Controls.Add(this.cb_CNTTCoBan);
            this.groupBox3.Location = new System.Drawing.Point(120, 399);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(347, 66);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            // 
            // cb_CNTTNangCao
            // 
            this.cb_CNTTNangCao.AutoSize = true;
            this.cb_CNTTNangCao.Location = new System.Drawing.Point(12, 43);
            this.cb_CNTTNangCao.Name = "cb_CNTTNangCao";
            this.cb_CNTTNangCao.Size = new System.Drawing.Size(237, 17);
            this.cb_CNTTNangCao.TabIndex = 1;
            this.cb_CNTTNangCao.Text = "Chứng chỉ chuẩn ứng dụng CNTT Nâng cao";
            this.cb_CNTTNangCao.UseVisualStyleBackColor = true;
            // 
            // cb_CNTTCoBan
            // 
            this.cb_CNTTCoBan.AutoSize = true;
            this.cb_CNTTCoBan.Location = new System.Drawing.Point(12, 15);
            this.cb_CNTTCoBan.Name = "cb_CNTTCoBan";
            this.cb_CNTTCoBan.Size = new System.Drawing.Size(223, 17);
            this.cb_CNTTCoBan.TabIndex = 0;
            this.cb_CNTTCoBan.Text = "Chứng chỉ chuẩn ứng dụng CNTT cơ bản";
            this.cb_CNTTCoBan.UseVisualStyleBackColor = true;
            // 
            // bt_DangKi
            // 
            this.bt_DangKi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_DangKi.Location = new System.Drawing.Point(178, 524);
            this.bt_DangKi.Name = "bt_DangKi";
            this.bt_DangKi.Size = new System.Drawing.Size(147, 45);
            this.bt_DangKi.TabIndex = 22;
            this.bt_DangKi.Text = "Đăng kí";
            this.bt_DangKi.UseVisualStyleBackColor = true;
            this.bt_DangKi.Click += new System.EventHandler(this.bt_DangKi_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rd_KhongThuocHV);
            this.groupBox4.Controls.Add(this.rd_ThuocHV);
            this.groupBox4.Location = new System.Drawing.Point(120, 473);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(347, 32);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            // 
            // rd_KhongThuocHV
            // 
            this.rd_KhongThuocHV.AutoSize = true;
            this.rd_KhongThuocHV.Location = new System.Drawing.Point(152, 9);
            this.rd_KhongThuocHV.Name = "rd_KhongThuocHV";
            this.rd_KhongThuocHV.Size = new System.Drawing.Size(132, 17);
            this.rd_KhongThuocHV.TabIndex = 13;
            this.rd_KhongThuocHV.Text = "Không thuộc Học viện";
            this.rd_KhongThuocHV.UseVisualStyleBackColor = true;
            // 
            // rd_ThuocHV
            // 
            this.rd_ThuocHV.AutoSize = true;
            this.rd_ThuocHV.Checked = true;
            this.rd_ThuocHV.Location = new System.Drawing.Point(12, 9);
            this.rd_ThuocHV.Name = "rd_ThuocHV";
            this.rd_ThuocHV.Size = new System.Drawing.Size(102, 17);
            this.rd_ThuocHV.TabIndex = 12;
            this.rd_ThuocHV.TabStop = true;
            this.rd_ThuocHV.Text = "Thuộc Học viện";
            this.rd_ThuocHV.UseVisualStyleBackColor = true;
            // 
            // Form_DangKi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 581);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(label9);
            this.Controls.Add(this.bt_DangKi);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(label7);
            this.Controls.Add(label6);
            this.Controls.Add(this.tx_NgaySinh);
            this.Controls.Add(label5);
            this.Controls.Add(this.tx_Phone);
            this.Controls.Add(label4);
            this.Controls.Add(this.tx_CMT);
            this.Controls.Add(label3);
            this.Controls.Add(this.tx_Name);
            this.Controls.Add(label2);
            this.Controls.Add(this.tx_Email);
            this.Controls.Add(Email_Address);
            this.Controls.Add(this.label1);
            this.Name = "Form_DangKi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tx_Email;
        private System.Windows.Forms.TextBox tx_Name;
        private System.Windows.Forms.TextBox tx_CMT;
        private System.Windows.Forms.TextBox tx_Phone;
        private System.Windows.Forms.DateTimePicker tx_NgaySinh;
        private System.Windows.Forms.RadioButton rd_Nam;
        private System.Windows.Forms.RadioButton rd_Nu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rd_ChiThamGiaThi;
        private System.Windows.Forms.RadioButton rd_OnLuyenVaThi;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cb_CNTTNangCao;
        private System.Windows.Forms.CheckBox cb_CNTTCoBan;
        private System.Windows.Forms.Button bt_DangKi;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rd_KhongThuocHV;
        private System.Windows.Forms.RadioButton rd_ThuocHV;
    }
}

