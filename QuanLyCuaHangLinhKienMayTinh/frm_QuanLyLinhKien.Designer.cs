namespace QuanLyCuaHangLinhKienMayTinh
{
    partial class frm_QuanLyLinhKien
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loạiLinhKiệnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cPUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gPUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rAMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motherboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nguồnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ổCứngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loạiLinhKiệnToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1027, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loạiLinhKiệnToolStripMenuItem
            // 
            this.loạiLinhKiệnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cPUToolStripMenuItem,
            this.gPUToolStripMenuItem,
            this.rAMToolStripMenuItem,
            this.motherboardToolStripMenuItem,
            this.nguồnToolStripMenuItem,
            this.caseToolStripMenuItem,
            this.ổCứngToolStripMenuItem});
            this.loạiLinhKiệnToolStripMenuItem.Name = "loạiLinhKiệnToolStripMenuItem";
            this.loạiLinhKiệnToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.loạiLinhKiệnToolStripMenuItem.Text = "Loại Linh Kiện";
            // 
            // cPUToolStripMenuItem
            // 
            this.cPUToolStripMenuItem.Name = "cPUToolStripMenuItem";
            this.cPUToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cPUToolStripMenuItem.Text = "CPU";
            this.cPUToolStripMenuItem.Click += new System.EventHandler(this.cPUToolStripMenuItem_Click);
            // 
            // gPUToolStripMenuItem
            // 
            this.gPUToolStripMenuItem.Name = "gPUToolStripMenuItem";
            this.gPUToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gPUToolStripMenuItem.Text = "GPU";
            this.gPUToolStripMenuItem.Click += new System.EventHandler(this.gPUToolStripMenuItem_Click);
            // 
            // rAMToolStripMenuItem
            // 
            this.rAMToolStripMenuItem.Name = "rAMToolStripMenuItem";
            this.rAMToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rAMToolStripMenuItem.Text = "RAM";
            this.rAMToolStripMenuItem.Click += new System.EventHandler(this.rAMToolStripMenuItem_Click);
            // 
            // motherboardToolStripMenuItem
            // 
            this.motherboardToolStripMenuItem.Name = "motherboardToolStripMenuItem";
            this.motherboardToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.motherboardToolStripMenuItem.Text = "Motherboard";
            this.motherboardToolStripMenuItem.Click += new System.EventHandler(this.motherboardToolStripMenuItem_Click);
            // 
            // nguồnToolStripMenuItem
            // 
            this.nguồnToolStripMenuItem.Name = "nguồnToolStripMenuItem";
            this.nguồnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nguồnToolStripMenuItem.Text = "Nguồn";
            this.nguồnToolStripMenuItem.Click += new System.EventHandler(this.nguồnToolStripMenuItem_Click);
            // 
            // caseToolStripMenuItem
            // 
            this.caseToolStripMenuItem.Name = "caseToolStripMenuItem";
            this.caseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.caseToolStripMenuItem.Text = "Case";
            this.caseToolStripMenuItem.Click += new System.EventHandler(this.caseToolStripMenuItem_Click);
            // 
            // ổCứngToolStripMenuItem
            // 
            this.ổCứngToolStripMenuItem.Name = "ổCứngToolStripMenuItem";
            this.ổCứngToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ổCứngToolStripMenuItem.Text = "Ổ cứng";
            this.ổCứngToolStripMenuItem.Click += new System.EventHandler(this.ổCứngToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // frm_QuanLyLinhKien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 661);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_QuanLyLinhKien";
            this.Text = "Quản Lý Linh Kiện";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loạiLinhKiệnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cPUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gPUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rAMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motherboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nguồnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ổCứngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}