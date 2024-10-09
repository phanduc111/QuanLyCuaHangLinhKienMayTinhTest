using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangLinhKienMayTinh
{
    public partial class frm_GPU : Form
    {
        public frm_GPU()
        {
            InitializeComponent();
        }

        string sql = "Select * from GPU";
        LopDungChung lopchung = new LopDungChung();
        string imgFileName = "";

        private void frm_GPU_Load(object sender, EventArgs e)
        {
            grid_GPU.DataSource = lopchung.LoadDL(sql);
        }

        private void btn_ChonAnh_Click(object sender, EventArgs e)
        {
            try
            {
                string path = lopchung.PicPath();
                imgFileName = Path.GetFileName(path);
                Image image = Image.FromFile(path);
                pic_GPU.Image = image;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlinsert = "Insert into GPU values ('" + txt_TenGPU.Text + "','" + txt_HangSX.Text +
                        "','" + txt_Clock.Text + "','" + txt_VRAM.Text + "','" + txt_TDP.Text +
                        "','" + imgFileName + "','" + txt_DonGia.Text + "','" + txt_SoLuong.Text + "')";
                int kq = lopchung.ThemXoaSua(sqlinsert);
                if (kq >= 1) MessageBox.Show("Thêm GPU thành công");
                else MessageBox.Show("Thêm GPU thất bại");
                grid_GPU.DataSource = lopchung.LoadDL(sql);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlupdate = "update GPU set HangSX='" + txt_HangSX.Text +
                        "',Clock='" + txt_Clock.Text + "',VRAM='" + txt_VRAM.Text + "',TDP='" + txt_TDP.Text +
                        "',DonGia='" + txt_DonGia.Text + "',SoLuong='" + txt_SoLuong.Text +
                        "' where TenGPU='" + txt_TenGPU.Text + "'";
                int kq = lopchung.ThemXoaSua(sqlupdate);
                if (kq >= 1) MessageBox.Show("Cập nhật GPU thành công");
                else MessageBox.Show("Cập nhật GPU thất bại");
                grid_GPU.DataSource = lopchung.LoadDL(sql);
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
                string sqldelete = "Delete GPU where TenGPU = '" + txt_TenGPU.Text + "'";
                DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn xóa GPU này không?", "Chú Ý!", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    int kq = lopchung.ThemXoaSua(sqldelete);
                    if (kq >= 1) MessageBox.Show("Xoá GPU thành công");
                    else MessageBox.Show("Xoá GPU thất bại");
                    grid_GPU.DataSource = lopchung.LoadDL(sql);
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void grid_GPU_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_TenGPU.Text = grid_GPU.CurrentRow.Cells["TenGPU"].Value.ToString();
            txt_HangSX.Text = grid_GPU.CurrentRow.Cells["HangSX"].Value.ToString();
            txt_Clock.Text = grid_GPU.CurrentRow.Cells["Clock"].Value.ToString();
            txt_VRAM.Text = grid_GPU.CurrentRow.Cells["VRAM"].Value.ToString();
            txt_TDP.Text = grid_GPU.CurrentRow.Cells["TDP"].Value.ToString();
            txt_DonGia.Text = grid_GPU.CurrentRow.Cells["DonGia"].Value.ToString();
            txt_SoLuong.Text = grid_GPU.CurrentRow.Cells["SoLuong"].Value.ToString();
            try
            {
                pic_GPU.Image = Image.FromFile(lopchung.ImgFolderPath
                                               + grid_GPU.CurrentRow.Cells["HinhAnh"].Value.ToString());
            }
            catch (Exception)
            {
            }
        }
    }
}
