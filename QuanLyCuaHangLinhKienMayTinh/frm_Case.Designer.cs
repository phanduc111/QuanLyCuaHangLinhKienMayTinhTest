namespace QuanLyCuaHangLinhKienMayTinh
{
    partial class frm_Case
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cb_HoTroMainboard = new System.Windows.Forms.ComboBox();
            this.btn_ChonAnh = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Xóa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.pic_Case = new System.Windows.Forms.PictureBox();
            this.cb_HoTroPSU = new System.Windows.Forms.ComboBox();
            this.txt_TenCase = new System.Windows.Forms.TextBox();
            this.txt_ChieuDai = new System.Windows.Forms.TextBox();
            this.txt_MaCase = new System.Windows.Forms.TextBox();
            this.txt_HoTroTanCPU = new System.Windows.Forms.TextBox();
            this.txt_DonGia = new System.Windows.Forms.TextBox();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grid_Case = new System.Windows.Forms.DataGridView();
            this.txt_ChieuCao = new System.Windows.Forms.TextBox();
            this.txt_ChieuRong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_HoTroGPU = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_HoTroFan = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Case)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Case)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_HoTroMainboard
            // 
            this.cb_HoTroMainboard.FormattingEnabled = true;
            this.cb_HoTroMainboard.Location = new System.Drawing.Point(109, 122);
            this.cb_HoTroMainboard.Name = "cb_HoTroMainboard";
            this.cb_HoTroMainboard.Size = new System.Drawing.Size(121, 21);
            this.cb_HoTroMainboard.TabIndex = 124;
            // 
            // btn_ChonAnh
            // 
            this.btn_ChonAnh.Location = new System.Drawing.Point(852, 172);
            this.btn_ChonAnh.Name = "btn_ChonAnh";
            this.btn_ChonAnh.Size = new System.Drawing.Size(75, 23);
            this.btn_ChonAnh.TabIndex = 123;
            this.btn_ChonAnh.Text = "Chọn ảnh";
            this.btn_ChonAnh.UseVisualStyleBackColor = true;
            this.btn_ChonAnh.Click += new System.EventHandler(this.btn_ChonAnh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(778, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 122;
            this.label4.Text = "Hình ảnh";
            // 
            // btn_Xóa
            // 
            this.btn_Xóa.Location = new System.Drawing.Point(666, 86);
            this.btn_Xóa.Name = "btn_Xóa";
            this.btn_Xóa.Size = new System.Drawing.Size(49, 27);
            this.btn_Xóa.TabIndex = 121;
            this.btn_Xóa.Text = "Xóa";
            this.btn_Xóa.UseVisualStyleBackColor = true;
            this.btn_Xóa.Click += new System.EventHandler(this.btn_Xóa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(594, 86);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(49, 27);
            this.btn_Sua.TabIndex = 120;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(524, 86);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(49, 27);
            this.btn_Them.TabIndex = 119;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // pic_Case
            // 
            this.pic_Case.Location = new System.Drawing.Point(781, 33);
            this.pic_Case.Name = "pic_Case";
            this.pic_Case.Size = new System.Drawing.Size(146, 133);
            this.pic_Case.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Case.TabIndex = 118;
            this.pic_Case.TabStop = false;
            // 
            // cb_HoTroPSU
            // 
            this.cb_HoTroPSU.FormattingEnabled = true;
            this.cb_HoTroPSU.Location = new System.Drawing.Point(109, 149);
            this.cb_HoTroPSU.Name = "cb_HoTroPSU";
            this.cb_HoTroPSU.Size = new System.Drawing.Size(121, 21);
            this.cb_HoTroPSU.TabIndex = 117;
            // 
            // txt_TenCase
            // 
            this.txt_TenCase.Location = new System.Drawing.Point(109, 40);
            this.txt_TenCase.Name = "txt_TenCase";
            this.txt_TenCase.Size = new System.Drawing.Size(121, 20);
            this.txt_TenCase.TabIndex = 116;
            // 
            // txt_ChieuDai
            // 
            this.txt_ChieuDai.Location = new System.Drawing.Point(12, 90);
            this.txt_ChieuDai.Name = "txt_ChieuDai";
            this.txt_ChieuDai.Size = new System.Drawing.Size(46, 20);
            this.txt_ChieuDai.TabIndex = 115;
            // 
            // txt_MaCase
            // 
            this.txt_MaCase.Location = new System.Drawing.Point(109, 14);
            this.txt_MaCase.Name = "txt_MaCase";
            this.txt_MaCase.Size = new System.Drawing.Size(121, 20);
            this.txt_MaCase.TabIndex = 114;
            // 
            // txt_HoTroTanCPU
            // 
            this.txt_HoTroTanCPU.Location = new System.Drawing.Point(351, 14);
            this.txt_HoTroTanCPU.Name = "txt_HoTroTanCPU";
            this.txt_HoTroTanCPU.Size = new System.Drawing.Size(121, 20);
            this.txt_HoTroTanCPU.TabIndex = 113;
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.Location = new System.Drawing.Point(594, 14);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.Size = new System.Drawing.Size(121, 20);
            this.txt_DonGia.TabIndex = 112;
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Location = new System.Drawing.Point(594, 40);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(121, 20);
            this.txt_SoLuong.TabIndex = 111;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(521, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 13);
            this.label13.TabIndex = 110;
            this.label13.Text = "Số lượng tồn";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(521, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 109;
            this.label12.Text = "Giá bán";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 108;
            this.label8.Text = "Hỗ trợ PSU";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 107;
            this.label7.Text = "Hỗ trợ main";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 106;
            this.label5.Text = "Hỗ trợ tản CPU";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 105;
            this.label3.Text = "Mã Case";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 104;
            this.label2.Text = "Kích thước (mm)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 103;
            this.label1.Text = "Tên Case";
            // 
            // grid_Case
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_Case.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_Case.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_Case.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid_Case.Location = new System.Drawing.Point(18, 201);
            this.grid_Case.Name = "grid_Case";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_Case.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid_Case.Size = new System.Drawing.Size(935, 276);
            this.grid_Case.TabIndex = 102;
            this.grid_Case.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_Case_CellClick);
            // 
            // txt_ChieuCao
            // 
            this.txt_ChieuCao.Location = new System.Drawing.Point(182, 90);
            this.txt_ChieuCao.Name = "txt_ChieuCao";
            this.txt_ChieuCao.Size = new System.Drawing.Size(46, 20);
            this.txt_ChieuCao.TabIndex = 125;
            // 
            // txt_ChieuRong
            // 
            this.txt_ChieuRong.Location = new System.Drawing.Point(93, 90);
            this.txt_ChieuRong.Name = "txt_ChieuRong";
            this.txt_ChieuRong.Size = new System.Drawing.Size(46, 20);
            this.txt_ChieuRong.TabIndex = 126;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(145, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 127;
            this.label6.Text = "Rộng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(234, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 128;
            this.label9.Text = "Cao";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(64, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 13);
            this.label10.TabIndex = 129;
            this.label10.Text = "Dài";
            // 
            // txt_HoTroGPU
            // 
            this.txt_HoTroGPU.Location = new System.Drawing.Point(351, 40);
            this.txt_HoTroGPU.Name = "txt_HoTroGPU";
            this.txt_HoTroGPU.Size = new System.Drawing.Size(121, 20);
            this.txt_HoTroGPU.TabIndex = 131;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(266, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 130;
            this.label11.Text = "Hỗ trợ GPU";
            // 
            // txt_HoTroFan
            // 
            this.txt_HoTroFan.Location = new System.Drawing.Point(351, 67);
            this.txt_HoTroFan.Name = "txt_HoTroFan";
            this.txt_HoTroFan.Size = new System.Drawing.Size(121, 20);
            this.txt_HoTroFan.TabIndex = 133;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(266, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 13);
            this.label14.TabIndex = 132;
            this.label14.Text = "Hỗ trợ Fan";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(478, 17);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(23, 13);
            this.label17.TabIndex = 136;
            this.label17.Text = "mm";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(478, 43);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(23, 13);
            this.label15.TabIndex = 137;
            this.label15.Text = "mm";
            // 
            // frm_Case
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 494);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txt_HoTroFan);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_HoTroGPU);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_ChieuRong);
            this.Controls.Add(this.txt_ChieuCao);
            this.Controls.Add(this.cb_HoTroMainboard);
            this.Controls.Add(this.btn_ChonAnh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Xóa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.pic_Case);
            this.Controls.Add(this.cb_HoTroPSU);
            this.Controls.Add(this.txt_TenCase);
            this.Controls.Add(this.txt_ChieuDai);
            this.Controls.Add(this.txt_MaCase);
            this.Controls.Add(this.txt_HoTroTanCPU);
            this.Controls.Add(this.txt_DonGia);
            this.Controls.Add(this.txt_SoLuong);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grid_Case);
            this.Name = "frm_Case";
            this.Text = "frm_Case";
            this.Load += new System.EventHandler(this.frm_Case_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Case)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Case)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_HoTroMainboard;
        private System.Windows.Forms.Button btn_ChonAnh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Xóa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.PictureBox pic_Case;
        private System.Windows.Forms.ComboBox cb_HoTroPSU;
        private System.Windows.Forms.TextBox txt_TenCase;
        private System.Windows.Forms.TextBox txt_ChieuDai;
        private System.Windows.Forms.TextBox txt_MaCase;
        private System.Windows.Forms.TextBox txt_HoTroTanCPU;
        private System.Windows.Forms.TextBox txt_DonGia;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grid_Case;
        private System.Windows.Forms.TextBox txt_ChieuCao;
        private System.Windows.Forms.TextBox txt_ChieuRong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_HoTroGPU;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_HoTroFan;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
    }
}