namespace QuanLi_Admin
{
    partial class FormDanhSachDiem
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tx_DiemTN = new System.Windows.Forms.TextBox();
            this.tx_Word = new System.Windows.Forms.TextBox();
            this.tx_Excel = new System.Windows.Forms.TextBox();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tx_PPT = new System.Windows.Forms.TextBox();
            this.cb_SBD = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Word";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Excel";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tx_DiemTN
            // 
            this.tx_DiemTN.Location = new System.Drawing.Point(116, 101);
            this.tx_DiemTN.Name = "tx_DiemTN";
            this.tx_DiemTN.Size = new System.Drawing.Size(174, 20);
            this.tx_DiemTN.TabIndex = 27;
            this.tx_DiemTN.TextChanged += new System.EventHandler(this.tx_DonVi_TextChanged);
            // 
            // tx_Word
            // 
            this.tx_Word.Location = new System.Drawing.Point(116, 137);
            this.tx_Word.Name = "tx_Word";
            this.tx_Word.Size = new System.Drawing.Size(174, 20);
            this.tx_Word.TabIndex = 26;
            this.tx_Word.TextChanged += new System.EventHandler(this.tx_CapBac_TextChanged);
            // 
            // tx_Excel
            // 
            this.tx_Excel.Location = new System.Drawing.Point(116, 176);
            this.tx_Excel.Name = "tx_Excel";
            this.tx_Excel.Size = new System.Drawing.Size(174, 20);
            this.tx_Excel.TabIndex = 25;
            this.tx_Excel.TextChanged += new System.EventHandler(this.tx_GhiChu_TextChanged);
            // 
            // btn_Huy
            // 
            this.btn_Huy.Location = new System.Drawing.Point(221, 248);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(69, 23);
            this.btn_Huy.TabIndex = 24;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "SBD";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Điểm trắc nghiệm";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 31);
            this.label1.TabIndex = 21;
            this.label1.Text = "Điểm Thi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(116, 248);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(73, 23);
            this.btn_Luu.TabIndex = 20;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "PPT";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tx_PPT
            // 
            this.tx_PPT.Location = new System.Drawing.Point(116, 209);
            this.tx_PPT.Name = "tx_PPT";
            this.tx_PPT.Size = new System.Drawing.Size(174, 20);
            this.tx_PPT.TabIndex = 30;
            this.tx_PPT.TextChanged += new System.EventHandler(this.tx_PPT_TextChanged);
            // 
            // cb_SBD
            // 
            this.cb_SBD.FormattingEnabled = true;
            this.cb_SBD.Location = new System.Drawing.Point(118, 70);
            this.cb_SBD.Name = "cb_SBD";
            this.cb_SBD.Size = new System.Drawing.Size(172, 21);
            this.cb_SBD.TabIndex = 32;
            this.cb_SBD.SelectedIndexChanged += new System.EventHandler(this.cb_SBD_SelectedIndexChanged);
            // 
            // FormDanhSachDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 314);
            this.Controls.Add(this.cb_SBD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tx_PPT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tx_DiemTN);
            this.Controls.Add(this.tx_Word);
            this.Controls.Add(this.tx_Excel);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Luu);
            this.Name = "FormDanhSachDiem";
            this.Load += new System.EventHandler(this.FormDanhSachDiem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tx_DiemTN;
        private System.Windows.Forms.TextBox tx_Word;
        private System.Windows.Forms.TextBox tx_Excel;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tx_PPT;
        private System.Windows.Forms.ComboBox cb_SBD;
    }
}