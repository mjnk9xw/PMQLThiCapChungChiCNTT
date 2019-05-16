namespace QuanLi_Admin
{
    partial class FormCanBo
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.tx_Hoten = new System.Windows.Forms.TextBox();
            this.tx_GhiChu = new System.Windows.Forms.TextBox();
            this.tx_CapBac = new System.Windows.Forms.TextBox();
            this.tx_DonVi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Huy
            // 
            this.btn_Huy.Location = new System.Drawing.Point(337, 310);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(75, 23);
            this.btn_Huy.TabIndex = 13;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Họ tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Đơn vị";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Cán Bộ";
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(230, 310);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(75, 23);
            this.btn_Luu.TabIndex = 9;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // tx_Hoten
            // 
            this.tx_Hoten.Location = new System.Drawing.Point(108, 78);
            this.tx_Hoten.Name = "tx_Hoten";
            this.tx_Hoten.Size = new System.Drawing.Size(304, 20);
            this.tx_Hoten.TabIndex = 7;
            // 
            // tx_GhiChu
            // 
            this.tx_GhiChu.Location = new System.Drawing.Point(108, 255);
            this.tx_GhiChu.Name = "tx_GhiChu";
            this.tx_GhiChu.Size = new System.Drawing.Size(304, 20);
            this.tx_GhiChu.TabIndex = 14;
            // 
            // tx_CapBac
            // 
            this.tx_CapBac.Location = new System.Drawing.Point(108, 191);
            this.tx_CapBac.Name = "tx_CapBac";
            this.tx_CapBac.Size = new System.Drawing.Size(304, 20);
            this.tx_CapBac.TabIndex = 15;
            // 
            // tx_DonVi
            // 
            this.tx_DonVi.Location = new System.Drawing.Point(108, 132);
            this.tx_DonVi.Name = "tx_DonVi";
            this.tx_DonVi.Size = new System.Drawing.Size(304, 20);
            this.tx_DonVi.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Ghi chú";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Cấp bậc";
            // 
            // FormCanBo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 381);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tx_DonVi);
            this.Controls.Add(this.tx_CapBac);
            this.Controls.Add(this.tx_GhiChu);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.tx_Hoten);
            this.Name = "FormCanBo";
            this.Load += new System.EventHandler(this.FormCanBo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.TextBox tx_Hoten;
        private System.Windows.Forms.TextBox tx_GhiChu;
        private System.Windows.Forms.TextBox tx_CapBac;
        private System.Windows.Forms.TextBox tx_DonVi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}