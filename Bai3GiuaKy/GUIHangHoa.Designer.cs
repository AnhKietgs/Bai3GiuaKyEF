namespace Bai3GiuaKy
{
    partial class GUIHangHoa
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.textBox_DGBan = new System.Windows.Forms.TextBox();
            this.textBox_TenHang = new System.Windows.Forms.TextBox();
            this.textBox_MHang = new System.Windows.Forms.TextBox();
            this.textBox_SLuong = new System.Windows.Forms.TextBox();
            this.textBox_DGNhap = new System.Windows.Forms.TextBox();
            this.comBoxMaCL = new System.Windows.Forms.ComboBox();
            this.textBox_GhiChu = new System.Windows.Forms.TextBox();
            this.textBox_Anh = new System.Windows.Forms.TextBox();
            this.dataGridView_tt = new System.Windows.Forms.DataGridView();
            this.button_them = new System.Windows.Forms.Button();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.button_Sua = new System.Windows.Forms.Button();
            this.button_Dong = new System.Windows.Forms.Button();
            this.button_MoAnh = new System.Windows.Forms.Button();
            this.button_TimKiem = new System.Windows.Forms.Button();
            this.button_boqua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tt)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(542, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH MỤC HÀNG HÓA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(82, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Hàng";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(82, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Hàng";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(82, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã Chất Liệu";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(82, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số Lượng";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(82, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "Đơn giá nhập";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(82, 415);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 32);
            this.label7.TabIndex = 6;
            this.label7.Text = "Đơn giá bán";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(610, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 32);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ảnh";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(610, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 32);
            this.label9.TabIndex = 8;
            this.label9.Text = "Ghi chú";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(1100, 133);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(417, 314);
            this.picBox.TabIndex = 9;
            this.picBox.TabStop = false;
            this.picBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBox_DGBan
            // 
            this.textBox_DGBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_DGBan.Location = new System.Drawing.Point(270, 415);
            this.textBox_DGBan.Name = "textBox_DGBan";
            this.textBox_DGBan.Size = new System.Drawing.Size(235, 39);
            this.textBox_DGBan.TabIndex = 10;
            this.textBox_DGBan.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox_TenHang
            // 
            this.textBox_TenHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TenHang.Location = new System.Drawing.Point(270, 164);
            this.textBox_TenHang.Name = "textBox_TenHang";
            this.textBox_TenHang.Size = new System.Drawing.Size(235, 39);
            this.textBox_TenHang.TabIndex = 11;
            this.textBox_TenHang.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox_MHang
            // 
            this.textBox_MHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_MHang.Location = new System.Drawing.Point(270, 98);
            this.textBox_MHang.Name = "textBox_MHang";
            this.textBox_MHang.Size = new System.Drawing.Size(235, 39);
            this.textBox_MHang.TabIndex = 12;
            this.textBox_MHang.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox_SLuong
            // 
            this.textBox_SLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SLuong.Location = new System.Drawing.Point(270, 283);
            this.textBox_SLuong.Name = "textBox_SLuong";
            this.textBox_SLuong.Size = new System.Drawing.Size(235, 39);
            this.textBox_SLuong.TabIndex = 13;
            this.textBox_SLuong.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox_DGNhap
            // 
            this.textBox_DGNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_DGNhap.Location = new System.Drawing.Point(271, 352);
            this.textBox_DGNhap.Name = "textBox_DGNhap";
            this.textBox_DGNhap.Size = new System.Drawing.Size(235, 39);
            this.textBox_DGNhap.TabIndex = 14;
            this.textBox_DGNhap.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // comBoxMaCL
            // 
            this.comBoxMaCL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBoxMaCL.FormattingEnabled = true;
            this.comBoxMaCL.Location = new System.Drawing.Point(270, 222);
            this.comBoxMaCL.Name = "comBoxMaCL";
            this.comBoxMaCL.Size = new System.Drawing.Size(235, 40);
            this.comBoxMaCL.TabIndex = 15;
            this.comBoxMaCL.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox_GhiChu
            // 
            this.textBox_GhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_GhiChu.Location = new System.Drawing.Point(616, 307);
            this.textBox_GhiChu.Multiline = true;
            this.textBox_GhiChu.Name = "textBox_GhiChu";
            this.textBox_GhiChu.Size = new System.Drawing.Size(410, 147);
            this.textBox_GhiChu.TabIndex = 16;
            this.textBox_GhiChu.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox_Anh
            // 
            this.textBox_Anh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Anh.Location = new System.Drawing.Point(616, 133);
            this.textBox_Anh.Multiline = true;
            this.textBox_Anh.Name = "textBox_Anh";
            this.textBox_Anh.Size = new System.Drawing.Size(360, 104);
            this.textBox_Anh.TabIndex = 17;
            this.textBox_Anh.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // dataGridView_tt
            // 
            this.dataGridView_tt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_tt.Location = new System.Drawing.Point(88, 471);
            this.dataGridView_tt.Name = "dataGridView_tt";
            this.dataGridView_tt.ReadOnly = true;
            this.dataGridView_tt.RowHeadersWidth = 62;
            this.dataGridView_tt.RowTemplate.Height = 28;
            this.dataGridView_tt.Size = new System.Drawing.Size(1429, 350);
            this.dataGridView_tt.TabIndex = 18;
            this.dataGridView_tt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_tt_CellContentClick);
            // 
            // button_them
            // 
            this.button_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_them.Location = new System.Drawing.Point(88, 850);
            this.button_them.Name = "button_them";
            this.button_them.Size = new System.Drawing.Size(144, 63);
            this.button_them.TabIndex = 19;
            this.button_them.Text = "Thêm";
            this.button_them.UseVisualStyleBackColor = true;
            this.button_them.Click += new System.EventHandler(this.button_them_Click);
            // 
            // button_Xoa
            // 
            this.button_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Xoa.Location = new System.Drawing.Point(238, 850);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(144, 63);
            this.button_Xoa.TabIndex = 20;
            this.button_Xoa.Text = "Xóa";
            this.button_Xoa.UseVisualStyleBackColor = true;
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click);
            // 
            // button_Sua
            // 
            this.button_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Sua.Location = new System.Drawing.Point(388, 850);
            this.button_Sua.Name = "button_Sua";
            this.button_Sua.Size = new System.Drawing.Size(144, 63);
            this.button_Sua.TabIndex = 21;
            this.button_Sua.Text = "Sửa";
            this.button_Sua.UseVisualStyleBackColor = true;
            this.button_Sua.Click += new System.EventHandler(this.button_Sua_Click);
            // 
            // button_Dong
            // 
            this.button_Dong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Dong.Location = new System.Drawing.Point(1373, 850);
            this.button_Dong.Name = "button_Dong";
            this.button_Dong.Size = new System.Drawing.Size(144, 63);
            this.button_Dong.TabIndex = 23;
            this.button_Dong.Text = "Đóng";
            this.button_Dong.UseVisualStyleBackColor = true;
            this.button_Dong.Click += new System.EventHandler(this.button_Dong_Click);
            // 
            // button_MoAnh
            // 
            this.button_MoAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_MoAnh.Location = new System.Drawing.Point(983, 152);
            this.button_MoAnh.Name = "button_MoAnh";
            this.button_MoAnh.Size = new System.Drawing.Size(111, 63);
            this.button_MoAnh.TabIndex = 24;
            this.button_MoAnh.Text = "Mở";
            this.button_MoAnh.UseVisualStyleBackColor = true;
            this.button_MoAnh.Click += new System.EventHandler(this.button_MoAnh_Click);
            // 
            // button_TimKiem
            // 
            this.button_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_TimKiem.Location = new System.Drawing.Point(538, 850);
            this.button_TimKiem.Name = "button_TimKiem";
            this.button_TimKiem.Size = new System.Drawing.Size(144, 63);
            this.button_TimKiem.TabIndex = 21;
            this.button_TimKiem.Text = "Tìm kiếm";
            this.button_TimKiem.UseVisualStyleBackColor = true;
            this.button_TimKiem.Click += new System.EventHandler(this.button_TimKiem_Click);
            // 
            // button_boqua
            // 
            this.button_boqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_boqua.Location = new System.Drawing.Point(688, 850);
            this.button_boqua.Name = "button_boqua";
            this.button_boqua.Size = new System.Drawing.Size(144, 63);
            this.button_boqua.TabIndex = 25;
            this.button_boqua.Text = "Bỏ qua";
            this.button_boqua.UseVisualStyleBackColor = true;
            this.button_boqua.Click += new System.EventHandler(this.button_boqua_Click);
            // 
            // GUIHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1558, 938);
            this.Controls.Add(this.button_boqua);
            this.Controls.Add(this.button_TimKiem);
            this.Controls.Add(this.button_MoAnh);
            this.Controls.Add(this.button_Dong);
            this.Controls.Add(this.button_Sua);
            this.Controls.Add(this.button_Xoa);
            this.Controls.Add(this.button_them);
            this.Controls.Add(this.dataGridView_tt);
            this.Controls.Add(this.textBox_Anh);
            this.Controls.Add(this.textBox_GhiChu);
            this.Controls.Add(this.comBoxMaCL);
            this.Controls.Add(this.textBox_DGNhap);
            this.Controls.Add(this.textBox_SLuong);
            this.Controls.Add(this.textBox_MHang);
            this.Controls.Add(this.textBox_TenHang);
            this.Controls.Add(this.textBox_DGBan);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GUIHangHoa";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GUIHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.TextBox textBox_DGBan;
        private System.Windows.Forms.TextBox textBox_TenHang;
        private System.Windows.Forms.TextBox textBox_MHang;
        private System.Windows.Forms.TextBox textBox_SLuong;
        private System.Windows.Forms.TextBox textBox_DGNhap;
        private System.Windows.Forms.ComboBox comBoxMaCL;
        private System.Windows.Forms.TextBox textBox_GhiChu;
        private System.Windows.Forms.TextBox textBox_Anh;
        private System.Windows.Forms.DataGridView dataGridView_tt;
        private System.Windows.Forms.Button button_them;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Button button_Sua;
        private System.Windows.Forms.Button button_Dong;
        private System.Windows.Forms.Button button_MoAnh;
        private System.Windows.Forms.Button button_TimKiem;
        private System.Windows.Forms.Button button_boqua;
    }
}

