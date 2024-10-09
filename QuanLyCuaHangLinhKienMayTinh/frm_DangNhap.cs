using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangLinhKienMayTinh
{
    public partial class frm_DangNhap : Form
    {
        public frm_DangNhap()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bạn thật sự có muốn thoát hay không", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        LopDungChung lopchung = new LopDungChung();
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
                string sql1 = "Select COUNT (*) from ACCOUNT where TenTK = '" + txt_TenNguoiDung.Text + "' and MatKhau = '" + txt_MatKhau.Text + "'";
                int kq1 = (int)lopchung.LayGT(sql1);
                if (kq1 >= 1)
                {
                    MessageBox.Show("Đăng nhập thành công!");
                    frm_QuanLyLinhKien ql = new frm_QuanLyLinhKien();
                    ql.Show();
                }
                else MessageBox.Show("Đăng nhập thất bại!");
            
        }
    }
}
