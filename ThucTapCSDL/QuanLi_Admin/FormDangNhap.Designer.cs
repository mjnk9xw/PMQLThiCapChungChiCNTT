namespace QuanLi_Admin
{
    partial class FormDangNhap
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
            this.bt_DangNhap = new System.Windows.Forms.Button();
            this.tx_TaiKhoan = new System.Windows.Forms.TextBox();
            this.tx_MatKhau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_DangNhap
            // 
            this.bt_DangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_DangNhap.Location = new System.Drawing.Point(181, 177);
            this.bt_DangNhap.Name = "bt_DangNhap";
            this.bt_DangNhap.Size = new System.Drawing.Size(106, 31);
            this.bt_DangNhap.TabIndex = 0;
            this.bt_DangNhap.Text = "Đăng nhập";
            this.bt_DangNhap.UseVisualStyleBackColor = true;
            this.bt_DangNhap.Click += new System.EventHandler(this.bt_DangNhap_Click);
            // 
            // tx_TaiKhoan
            // 
            this.tx_TaiKhoan.Location = new System.Drawing.Point(154, 72);
            this.tx_TaiKhoan.Name = "tx_TaiKhoan";
            this.tx_TaiKhoan.Size = new System.Drawing.Size(211, 20);
            this.tx_TaiKhoan.TabIndex = 1;
            // 
            // tx_MatKhau
            // 
            this.tx_MatKhau.Location = new System.Drawing.Point(154, 126);
            this.tx_MatKhau.Name = "tx_MatKhau";
            this.tx_MatKhau.PasswordChar = '*';
            this.tx_MatKhau.Size = new System.Drawing.Size(211, 20);
            this.tx_MatKhau.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(176, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Đăng Nhập";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 242);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tx_MatKhau);
            this.Controls.Add(this.tx_TaiKhoan);
            this.Controls.Add(this.bt_DangNhap);
            this.Name = "FormDangNhap";
            this.Load += new System.EventHandler(this.FormDangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_DangNhap;
        private System.Windows.Forms.TextBox tx_TaiKhoan;
        private System.Windows.Forms.TextBox tx_MatKhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

