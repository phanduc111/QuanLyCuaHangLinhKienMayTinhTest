namespace QuanLyCuaHangLinhKienMayTinh
{
    partial class frm_CPU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_CPU));
            this.grid_CPU = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.txt_DonGia = new System.Windows.Forms.TextBox();
            this.txt_L3Cache = new System.Windows.Forms.TextBox();
            this.txt_L2Cache = new System.Windows.Forms.TextBox();
            this.txt_L1Cache = new System.Windows.Forms.TextBox();
            this.txt_TDP = new System.Windows.Forms.TextBox();
            this.txt_BoostClock = new System.Windows.Forms.TextBox();
            this.txt_BaseClock = new System.Windows.Forms.TextBox();
            this.txt_Threads = new System.Windows.Forms.TextBox();
            this.txt_Cores = new System.Windows.Forms.TextBox();
            this.txt_TenCPU = new System.Windows.Forms.TextBox();
            this.cb_Socket = new System.Windows.Forms.ComboBox();
            this.cb_HangSX = new System.Windows.Forms.ComboBox();
            this.pic_Intel = new System.Windows.Forms.PictureBox();
            this.pic_AMD = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xóa = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_CPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Intel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_AMD)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_CPU
            // 
            this.grid_CPU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_CPU.Location = new System.Drawing.Point(12, 201);
            this.grid_CPU.Name = "grid_CPU";
            this.grid_CPU.Size = new System.Drawing.Size(935, 276);
            this.grid_CPU.TabIndex = 0;
            this.grid_CPU.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CPU_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên CPU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hãng Sản Xuất";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số Lõi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số Luồng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Xung Cơ Bản";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Xung Boost";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(283, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "TDP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(283, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "L1 Cache";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(283, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "L2 Cache";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(283, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "L3 Cache";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(283, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Socket";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(546, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Giá bán";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(546, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Số lượng tồn";
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Location = new System.Drawing.Point(619, 46);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(121, 20);
            this.txt_SoLuong.TabIndex = 14;
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.Location = new System.Drawing.Point(619, 20);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.Size = new System.Drawing.Size(121, 20);
            this.txt_DonGia.TabIndex = 15;
            // 
            // txt_L3Cache
            // 
            this.txt_L3Cache.Location = new System.Drawing.Point(352, 99);
            this.txt_L3Cache.Name = "txt_L3Cache";
            this.txt_L3Cache.Size = new System.Drawing.Size(121, 20);
            this.txt_L3Cache.TabIndex = 16;
            // 
            // txt_L2Cache
            // 
            this.txt_L2Cache.Location = new System.Drawing.Point(352, 73);
            this.txt_L2Cache.Name = "txt_L2Cache";
            this.txt_L2Cache.Size = new System.Drawing.Size(121, 20);
            this.txt_L2Cache.TabIndex = 17;
            // 
            // txt_L1Cache
            // 
            this.txt_L1Cache.Location = new System.Drawing.Point(352, 47);
            this.txt_L1Cache.Name = "txt_L1Cache";
            this.txt_L1Cache.Size = new System.Drawing.Size(121, 20);
            this.txt_L1Cache.TabIndex = 18;
            // 
            // txt_TDP
            // 
            this.txt_TDP.Location = new System.Drawing.Point(352, 20);
            this.txt_TDP.Name = "txt_TDP";
            this.txt_TDP.Size = new System.Drawing.Size(121, 20);
            this.txt_TDP.TabIndex = 19;
            // 
            // txt_BoostClock
            // 
            this.txt_BoostClock.Location = new System.Drawing.Point(110, 151);
            this.txt_BoostClock.Name = "txt_BoostClock";
            this.txt_BoostClock.Size = new System.Drawing.Size(121, 20);
            this.txt_BoostClock.TabIndex = 20;
            // 
            // txt_BaseClock
            // 
            this.txt_BaseClock.Location = new System.Drawing.Point(110, 125);
            this.txt_BaseClock.Name = "txt_BaseClock";
            this.txt_BaseClock.Size = new System.Drawing.Size(121, 20);
            this.txt_BaseClock.TabIndex = 21;
            // 
            // txt_Threads
            // 
            this.txt_Threads.Location = new System.Drawing.Point(110, 99);
            this.txt_Threads.Name = "txt_Threads";
            this.txt_Threads.Size = new System.Drawing.Size(121, 20);
            this.txt_Threads.TabIndex = 22;
            // 
            // txt_Cores
            // 
            this.txt_Cores.Location = new System.Drawing.Point(110, 73);
            this.txt_Cores.Name = "txt_Cores";
            this.txt_Cores.Size = new System.Drawing.Size(121, 20);
            this.txt_Cores.TabIndex = 23;
            // 
            // txt_TenCPU
            // 
            this.txt_TenCPU.Location = new System.Drawing.Point(110, 20);
            this.txt_TenCPU.Name = "txt_TenCPU";
            this.txt_TenCPU.Size = new System.Drawing.Size(121, 20);
            this.txt_TenCPU.TabIndex = 24;
            // 
            // cb_Socket
            // 
            this.cb_Socket.FormattingEnabled = true;
            this.cb_Socket.Location = new System.Drawing.Point(352, 125);
            this.cb_Socket.Name = "cb_Socket";
            this.cb_Socket.Size = new System.Drawing.Size(121, 21);
            this.cb_Socket.TabIndex = 25;
            // 
            // cb_HangSX
            // 
            this.cb_HangSX.FormattingEnabled = true;
            this.cb_HangSX.Location = new System.Drawing.Point(110, 46);
            this.cb_HangSX.Name = "cb_HangSX";
            this.cb_HangSX.Size = new System.Drawing.Size(121, 21);
            this.cb_HangSX.TabIndex = 26;
            this.cb_HangSX.SelectedValueChanged += new System.EventHandler(this.cb_HangSX_SelectedValueChanged);
            // 
            // pic_Intel
            // 
            this.pic_Intel.Image = ((System.Drawing.Image)(resources.GetObject("pic_Intel.Image")));
            this.pic_Intel.Location = new System.Drawing.Point(768, 20);
            this.pic_Intel.Name = "pic_Intel";
            this.pic_Intel.Size = new System.Drawing.Size(162, 159);
            this.pic_Intel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Intel.TabIndex = 27;
            this.pic_Intel.TabStop = false;
            // 
            // pic_AMD
            // 
            this.pic_AMD.Image = ((System.Drawing.Image)(resources.GetObject("pic_AMD.Image")));
            this.pic_AMD.Location = new System.Drawing.Point(768, 20);
            this.pic_AMD.Name = "pic_AMD";
            this.pic_AMD.Size = new System.Drawing.Size(162, 136);
            this.pic_AMD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_AMD.TabIndex = 28;
            this.pic_AMD.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(479, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(24, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "(W)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(479, 49);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(27, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "(KB)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(479, 76);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(27, 13);
            this.label16.TabIndex = 31;
            this.label16.Text = "(KB)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(479, 102);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 13);
            this.label17.TabIndex = 32;
            this.label17.Text = "(MB)";
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(549, 92);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(49, 27);
            this.btn_Them.TabIndex = 33;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(619, 92);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(49, 27);
            this.btn_Sua.TabIndex = 34;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xóa
            // 
            this.btn_Xóa.Location = new System.Drawing.Point(691, 92);
            this.btn_Xóa.Name = "btn_Xóa";
            this.btn_Xóa.Size = new System.Drawing.Size(49, 27);
            this.btn_Xóa.TabIndex = 35;
            this.btn_Xóa.Text = "Xóa";
            this.btn_Xóa.UseVisualStyleBackColor = true;
            this.btn_Xóa.Click += new System.EventHandler(this.btn_Xóa_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(237, 128);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 13);
            this.label18.TabIndex = 36;
            this.label18.Text = "(MHz)";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(237, 154);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(35, 13);
            this.label19.TabIndex = 37;
            this.label19.Text = "(MHz)";
            // 
            // frm_CPU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 489);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.btn_Xóa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.pic_AMD);
            this.Controls.Add(this.pic_Intel);
            this.Controls.Add(this.cb_HangSX);
            this.Controls.Add(this.cb_Socket);
            this.Controls.Add(this.txt_TenCPU);
            this.Controls.Add(this.txt_Cores);
            this.Controls.Add(this.txt_Threads);
            this.Controls.Add(this.txt_BaseClock);
            this.Controls.Add(this.txt_BoostClock);
            this.Controls.Add(this.txt_TDP);
            this.Controls.Add(this.txt_L1Cache);
            this.Controls.Add(this.txt_L2Cache);
            this.Controls.Add(this.txt_L3Cache);
            this.Controls.Add(this.txt_DonGia);
            this.Controls.Add(this.txt_SoLuong);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grid_CPU);
            this.Name = "frm_CPU";
            this.Text = "frm_CPU";
            this.Load += new System.EventHandler(this.frm_CPU_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_CPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Intel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_AMD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_CPU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.TextBox txt_DonGia;
        private System.Windows.Forms.TextBox txt_L3Cache;
        private System.Windows.Forms.TextBox txt_L2Cache;
        private System.Windows.Forms.TextBox txt_L1Cache;
        private System.Windows.Forms.TextBox txt_TDP;
        private System.Windows.Forms.TextBox txt_BoostClock;
        private System.Windows.Forms.TextBox txt_BaseClock;
        private System.Windows.Forms.TextBox txt_Threads;
        private System.Windows.Forms.TextBox txt_Cores;
        private System.Windows.Forms.TextBox txt_TenCPU;
        private System.Windows.Forms.ComboBox cb_Socket;
        private System.Windows.Forms.ComboBox cb_HangSX;
        private System.Windows.Forms.PictureBox pic_Intel;
        private System.Windows.Forms.PictureBox pic_AMD;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xóa;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
    }
}