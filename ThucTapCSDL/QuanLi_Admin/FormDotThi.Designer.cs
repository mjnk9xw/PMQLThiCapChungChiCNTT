namespace QuanLi_Admin
{
    partial class FormDotThi
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
            this.tx_TenDotThi = new System.Windows.Forms.TextBox();
            this.tx_Ngay = new System.Windows.Forms.DateTimePicker();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tx_TenDotThi
            // 
            this.tx_TenDotThi.Location = new System.Drawing.Point(101, 75);
            this.tx_TenDotThi.Name = "tx_TenDotThi";
            this.tx_TenDotThi.Size = new System.Drawing.Size(304, 20);
            this.tx_TenDotThi.TabIndex = 0;
            this.tx_TenDotThi.TextChanged += new System.EventHandler(this.tx_TenDotThi_TextChanged);
            // 
            // tx_Ngay
            // 
            this.tx_Ngay.CustomFormat = "dd/MM/yyyy";
            this.tx_Ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tx_Ngay.Location = new System.Drawing.Point(101, 130);
            this.tx_Ngay.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.tx_Ngay.MinDate = new System.DateTime(2000, 4, 4, 0, 0, 0, 0);
            this.tx_Ngay.Name = "tx_Ngay";
            this.tx_Ngay.Size = new System.Drawing.Size(304, 20);
            this.tx_Ngay.TabIndex = 1;
            this.tx_Ngay.Value = new System.DateTime(2019, 4, 25, 0, 0, 0, 0);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(227, 174);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(75, 23);
            this.btn_Luu.TabIndex = 2;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Đợt Thi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên đợt thi";
            // 
            // btn_Huy
            // 
            this.btn_Huy.Location = new System.Drawing.Point(330, 174);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(75, 23);
            this.btn_Huy.TabIndex = 6;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // FormDotThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 224);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.tx_Ngay);
            this.Controls.Add(this.tx_TenDotThi);
            this.Name = "FormDotThi";
            this.Load += new System.EventHandler(this.FormDotThi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_TenDotThi;
        private System.Windows.Forms.DateTimePicker tx_Ngay;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Huy;
    }
}