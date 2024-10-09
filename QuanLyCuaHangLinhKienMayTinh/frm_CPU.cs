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
    public partial class frm_CPU : Form
    {
        public frm_CPU()
        {
            InitializeComponent();
        }

        string sql = "Select * from CPU";
        LopDungChung lopchung = new LopDungChung();

        private void frm_CPU_Load(object sender, EventArgs e)
        {
            grid_CPU.DataSource = lopchung.LoadDL(sql);
            string sqlhang = "Select * from HANGCPU";
            cb_HangSX.DataSource = lopchung.LoadDL(sqlhang);
            cb_HangSX.ValueMember = "TenHang";
            string sqlsk = "Select * from SOCKET";
            cb_Socket.DataSource = lopchung.LoadDL(sqlsk);
            cb_Socket.ValueMember = "Socket";
            pic_Intel.Hide();
        }

        private void grid_CPU_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_TenCPU.Text = grid_CPU.CurrentRow.Cells["TenCPU"].Value.ToString();
            cb_HangSX.SelectedValue = grid_CPU.CurrentRow.Cells["HangSX"].Value.ToString();
            txt_Cores.Text= grid_CPU.CurrentRow.Cells["Cores"].Value.ToString();
            txt_Threads.Text= grid_CPU.CurrentRow.Cells["Threads"].Value.ToString();
            txt_BaseClock.Text= grid_CPU.CurrentRow.Cells["BaseClock"].Value.ToString();
            txt_BoostClock.Text = grid_CPU.CurrentRow.Cells["BoostClock"].Value.ToString();
            txt_TDP.Text = grid_CPU.CurrentRow.Cells["TDP"].Value.ToString();
            txt_L1Cache.Text = grid_CPU.CurrentRow.Cells["L1Cache"].Value.ToString();
            txt_L2Cache.Text = grid_CPU.CurrentRow.Cells["L2Cache"].Value.ToString();
            txt_L3Cache.Text = grid_CPU.CurrentRow.Cells["L3Cache"].Value.ToString();
            cb_Socket.SelectedValue = grid_CPU.CurrentRow.Cells["Socket"].Value.ToString();
            txt_DonGia.Text = grid_CPU.CurrentRow.Cells["DonGia"].Value.ToString();
            txt_SoLuong.Text = grid_CPU.CurrentRow.Cells["SoLuong"].Value.ToString();
        }

        private void cb_HangSX_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cb_HangSX.SelectedValue.ToString()== "Intel")
            {
                pic_Intel.Show();
                pic_AMD.Hide();
            }
            else if (cb_HangSX.SelectedValue.ToString() == "AMD")
            {
                pic_AMD.Show();
                pic_Intel.Hide();
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlinsert = "Insert into CPU values ('" + txt_TenCPU.Text + "','" + cb_HangSX.SelectedValue +
                "','" + txt_Cores.Text + "','" + txt_Threads.Text + "','" + txt_BaseClock.Text + "','" + txt_BoostClock.Text +
                "','" + txt_TDP.Text + "','" + txt_L1Cache.Text + "','" + txt_L2Cache.Text + "','" + txt_L3Cache.Text +
                "','" + cb_Socket.SelectedValue + "','" + txt_DonGia.Text + "','" + txt_SoLuong.Text + "')";
                int kq = lopchung.ThemXoaSua(sqlinsert);
                if (kq >= 1) MessageBox.Show("Thêm CPU thành công");
                else MessageBox.Show("Thêm CPU thất bại");
                grid_CPU.DataSource = lopchung.LoadDL(sql);
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlupdate = "Update CPU set HangSX = '" + cb_HangSX.SelectedValue +
                                "',Cores='" + txt_Cores.Text + "',Threads='" + txt_Threads.Text + "',BaseClock ='" + txt_BaseClock.Text + "',BoostClock ='" + txt_BoostClock.Text +
                                "',TDP ='" + txt_TDP.Text + "',L1Cache ='" + txt_L1Cache.Text + "',L2Cache ='" + txt_L2Cache.Text + "',L3Cache ='" + txt_L3Cache.Text +
                                "',Socket='" + cb_Socket.SelectedValue + "',DonGia='" + txt_DonGia.Text + "',SoLuong='" + txt_SoLuong.Text + "' where TenCPU='" + txt_TenCPU.Text + "'";
                int kq = lopchung.ThemXoaSua(sqlupdate);
                if (kq >= 1) MessageBox.Show("Cập nhật CPU thành công");
                else MessageBox.Show("Cập Nhật CPU thất bại");
                grid_CPU.DataSource = lopchung.LoadDL(sql);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void btn_Xóa_Click(object sender, EventArgs e)
        {
            try
            {
                string sqldelete = "Delete CPU where TenCPU = '" + txt_TenCPU.Text + "'";
                DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn xóa CPU này không?", "Chú Ý!", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    int kq = lopchung.ThemXoaSua(sqldelete);
                    if (kq >= 1) MessageBox.Show("Xoá CPU thành công");
                    else MessageBox.Show("Xoá CPU thất bại");
                    grid_CPU.DataSource = lopchung.LoadDL(sql);
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
    }
}
