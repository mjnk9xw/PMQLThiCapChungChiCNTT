namespace QuanLi_Admin
{
    partial class FormHoiDongThi
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
            this.btn_Huy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.cb_NhiemVu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Huy
            // 
            this.btn_Huy.Location = new System.Drawing.Point(295, 99);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(75, 23);
            this.btn_Huy.TabIndex = 11;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nhiệm vụ cán bộ";
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(188, 99);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(75, 23);
            this.btn_Luu.TabIndex = 9;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // cb_NhiemVu
            // 
            this.cb_NhiemVu.FormattingEnabled = true;
            this.cb_NhiemVu.Location = new System.Drawing.Point(105, 60);
            this.cb_NhiemVu.Name = "cb_NhiemVu";
            this.cb_NhiemVu.Size = new System.Drawing.Size(266, 21);
            this.cb_NhiemVu.TabIndex = 12;
            this.cb_NhiemVu.SelectedIndexChanged += new System.EventHandler(this.cb_NhiemVu_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nhiệm vụ";
            // 
            // FormHoiDongThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 156);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_NhiemVu);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Luu);
            this.Name = "FormHoiDongThi";
            this.Load += new System.EventHandler(this.FormHoiDongThi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.ComboBox cb_NhiemVu;
        private System.Windows.Forms.Label label2;
    }
}