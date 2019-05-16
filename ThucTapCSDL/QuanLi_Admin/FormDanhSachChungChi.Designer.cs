namespace QuanLi_Admin
{
    partial class FormDanhSachChungChi
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
            this.cb_SBD = new System.Windows.Forms.ComboBox();
            this.tx_SoVaoSo = new System.Windows.Forms.TextBox();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_SBD
            // 
            this.cb_SBD.FormattingEnabled = true;
            this.cb_SBD.Location = new System.Drawing.Point(118, 70);
            this.cb_SBD.Name = "cb_SBD";
            this.cb_SBD.Size = new System.Drawing.Size(174, 21);
            this.cb_SBD.TabIndex = 45;
            this.cb_SBD.SelectedIndexChanged += new System.EventHandler(this.cb_SBD_SelectedIndexChanged);
            // 
            // tx_SoVaoSo
            // 
            this.tx_SoVaoSo.Location = new System.Drawing.Point(118, 101);
            this.tx_SoVaoSo.Name = "tx_SoVaoSo";
            this.tx_SoVaoSo.Size = new System.Drawing.Size(174, 20);
            this.tx_SoVaoSo.TabIndex = 40;
            // 
            // btn_Huy
            // 
            this.btn_Huy.Location = new System.Drawing.Point(223, 146);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(69, 23);
            this.btn_Huy.TabIndex = 37;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "SBD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Số vào sổ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 31);
            this.label1.TabIndex = 34;
            this.label1.Text = "Chứng chỉ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(118, 146);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(73, 23);
            this.btn_Luu.TabIndex = 33;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // FormDanhSachChungChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 208);
            this.Controls.Add(this.cb_SBD);
            this.Controls.Add(this.tx_SoVaoSo);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Luu);
            this.Name = "FormDanhSachChungChi";
            this.Text = "FormDanhSachChungChi";
            this.Load += new System.EventHandler(this.FormDanhSachChungChi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_SBD;
        private System.Windows.Forms.TextBox tx_SoVaoSo;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Luu;
    }
}