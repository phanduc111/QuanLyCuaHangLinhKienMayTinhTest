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
    public partial class frm_Case : Form
    {
        public frm_Case()
        {
            InitializeComponent();
        }

        string sql = "Select * from [dbo].[CASE]";
        LopDungChung lopchung = new LopDungChung();
        string imgFileName = "";

        private void frm_Case_Load(object sender, EventArgs e)
        {
            grid_Case.DataSource = lopchung.LoadDL(sql);
            string sqlmain = "Select * from MBFORMFACTOR";
            cb_HoTroMainboard.DataSource = lopchung.LoadDL(sqlmain);
            cb_HoTroMainboard.ValueMember = "TieuChuan";
            string sqlpsu = "Select * from PSUFORMFACTOR";
            cb_HoTroPSU.DataSource = lopchung.LoadDL(sqlpsu);
            cb_HoTroPSU.ValueMember = "TieuChuan";
        }

        private void btn_ChonAnh_Click(object sender, EventArgs e)
        {
            try
            {
                string path = lopchung.PicPath();
                imgFileName = Path.GetFileName(path);
                Image image = Image.FromFile(path);
                pic_Case.Image = image;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void grid_Case_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaCase.Text = grid_Case.CurrentRow.Cells["MaCase"].Value.ToString();
            txt_TenCase.Text = grid_Case.CurrentRow.Cells["TenCase"].Value.ToString();
            txt_ChieuDai.Text = grid_Case.CurrentRow.Cells["ChieuDai"].Value.ToString();
            txt_ChieuRong.Text = grid_Case.CurrentRow.Cells["ChieuRong"].Value.ToString();
            txt_ChieuCao.Text = grid_Case.CurrentRow.Cells["ChieuCao"].Value.ToString();
            cb_HoTroMainboard.SelectedValue = grid_Case.CurrentRow.Cells["HoTroMainboard"].Value.ToString();
            cb_HoTroPSU.SelectedValue = grid_Case.CurrentRow.Cells["HoTroPSU"].Value.ToString();
            txt_HoTroTanCPU.Text = grid_Case.CurrentRow.Cells["HoTroTanCPU"].Value.ToString();
            txt_HoTroGPU.Text = grid_Case.CurrentRow.Cells["HoTroGPU"].Value.ToString();
            txt_HoTroFan.Text = grid_Case.CurrentRow.Cells["HoTroFan"].Value.ToString();
            txt_DonGia.Text = grid_Case.CurrentRow.Cells["DonGia"].Value.ToString();
            txt_SoLuong.Text = grid_Case.CurrentRow.Cells["SoLuong"].Value.ToString();
            try
            {
                pic_Case.Image = Image.FromFile(lopchung.ImgFolderPath
                                               + grid_Case.CurrentRow.Cells["HinhAnh"].Value.ToString());
            }
            catch (Exception)
            {
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlinsert = "Insert into [dbo].[CASE] values ('" + txt_MaCase.Text + "','" + txt_TenCase.Text +
                        "','" + txt_ChieuDai.Text + "','" + txt_ChieuRong.Text + "','" + txt_ChieuCao.Text + "','" + cb_HoTroMainboard.SelectedValue + "','" + cb_HoTroPSU.SelectedValue +
                        "','" + txt_HoTroTanCPU.Text + "','" + txt_HoTroGPU.Text + "','" + txt_HoTroFan.Text + "','" + imgFileName + "','" + txt_DonGia.Text + "','" + txt_SoLuong.Text + "')";
                int kq = lopchung.ThemXoaSua(sqlinsert);
                if (kq >= 1) MessageBox.Show("Thêm Case thành công");
                else MessageBox.Show("Thêm Case thất bại");
                grid_Case.DataSource = lopchung.LoadDL(sql);
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
                string sqlupdate = "update [dbo].[CASE] set TenCase='" + txt_TenCase.Text +
                        "',ChieuDai='" + txt_ChieuDai.Text + "',ChieuRong='" + txt_ChieuRong.Text + "',ChieuCao='" + txt_ChieuCao.Text + "',HoTroMainboard='" + cb_HoTroMainboard.SelectedValue + "',HoTroPSU='" + cb_HoTroPSU.SelectedValue +
                        "',HoTroTanCPU='" + txt_HoTroTanCPU.Text + "',HoTroGPU='" + txt_HoTroGPU.Text + "',HoTroFan='" + txt_HoTroFan.Text + "',DonGia='" + txt_DonGia.Text + "',SoLuong='" + txt_SoLuong.Text +
                        "' where MaCase='" + txt_MaCase.Text + "'";
                int kq = lopchung.ThemXoaSua(sqlupdate);
                if (kq >= 1) MessageBox.Show("Cập nhật Case thành công");
                else MessageBox.Show("Cập nhật Case thất bại");
                grid_Case.DataSource = lopchung.LoadDL(sql);
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
                string sqldelete = "Delete [dbo].[CASE] where MaCase = '" + txt_MaCase.Text + "'";
                DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn xóa Case này không?", "Chú Ý!", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    int kq = lopchung.ThemXoaSua(sqldelete);
                    if (kq >= 1) MessageBox.Show("Xoá Case thành công");
                    else MessageBox.Show("Xoá Case thất bại");
                    grid_Case.DataSource = lopchung.LoadDL(sql);
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
    }
}
