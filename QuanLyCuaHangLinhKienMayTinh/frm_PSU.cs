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
    public partial class frm_PSU : Form
    {
        public frm_PSU()
        {
            InitializeComponent();
        }

        string sql = "Select * from PSU";
        LopDungChung lopchung = new LopDungChung();

        private void frm_PSU_Load(object sender, EventArgs e)
        {
            grid_PSU.DataSource = lopchung.LoadDL(sql);
            string sqlkt = "Select * from PSUFORMFACTOR";
            cb_KichThuoc.DataSource = lopchung.LoadDL(sqlkt);
            cb_KichThuoc.ValueMember = "TieuChuan";
            string sql80 = "Select * from PSUVALIDATION";
            cb_80Plus.DataSource = lopchung.LoadDL(sql80);
            cb_80Plus.ValueMember = "TieuChuan";
        }

        string imgFileName ="";

        private void btn_ChonAnh_Click(object sender, EventArgs e)
        {
            try
            {
                string path = lopchung.PicPath();
                imgFileName = Path.GetFileName(path);
                Image image = Image.FromFile(path);
                pic_PSU.Image = image;
            }catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            
        }

        private void grid_PSU_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaPSU.Text = grid_PSU.CurrentRow.Cells["MaPSU"].Value.ToString();
            txt_TenPSU.Text = grid_PSU.CurrentRow.Cells["TenPSU"].Value.ToString();
            txt_HangPhanPhoi.Text = grid_PSU.CurrentRow.Cells["HangPhanPhoi"].Value.ToString();
            txt_CongSuat.Text = grid_PSU.CurrentRow.Cells["CongSuat"].Value.ToString();
            cb_KichThuoc.SelectedValue = grid_PSU.CurrentRow.Cells["ChuanKichThuoc"].Value.ToString();
            cb_80Plus.SelectedValue = grid_PSU.CurrentRow.Cells["ChuanNguon"].Value.ToString();
            txt_DonGia.Text = grid_PSU.CurrentRow.Cells["DonGia"].Value.ToString();
            txt_SoLuong.Text = grid_PSU.CurrentRow.Cells["SoLuong"].Value.ToString();
            try
            { 
                pic_PSU.Image = Image.FromFile(lopchung.ImgFolderPath
                                               + grid_PSU.CurrentRow.Cells["HinhAnh"].Value.ToString());
            }
            catch (Exception)
            {
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlinsert = "Insert into PSU values ('" + txt_MaPSU.Text + "','" + txt_TenPSU.Text +
                    "','" + txt_HangPhanPhoi.Text + "','" + txt_CongSuat.Text + "','" + cb_KichThuoc.SelectedValue + "','" + cb_80Plus.SelectedValue +
                    "','" + imgFileName + "','" + txt_DonGia.Text + "','" + txt_SoLuong.Text + "')";
                int kq = lopchung.ThemXoaSua(sqlinsert);
                if (kq >= 1) MessageBox.Show("Thêm PSU thành công");
                else MessageBox.Show("Thêm PSU thất bại");
                grid_PSU.DataSource = lopchung.LoadDL(sql);
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
                string sqlupdate = "update PSU set TenPSU='" + txt_TenPSU.Text + "',HangPhanPhoi='" + txt_HangPhanPhoi.Text + 
                    "',CongSuat='" + txt_CongSuat.Text + "',ChuanKichThuoc='" + cb_KichThuoc.SelectedValue + "',ChuanNguon='" + cb_80Plus.SelectedValue +
                    "',DonGia='" + txt_DonGia.Text + "',SoLuong='" + txt_SoLuong.Text + 
                    "' where MaPSU = '" + txt_MaPSU.Text + "'";
                int kq = lopchung.ThemXoaSua(sqlupdate);
                if (kq >= 1) MessageBox.Show("Cập nhật PSU thành công");
                else MessageBox.Show("Cập nhật PSU thất bại");
                grid_PSU.DataSource = lopchung.LoadDL(sql);
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
                string sqldelete = "Delete PSU where MaPSU = '" + txt_MaPSU.Text + "'";
                DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn xóa nguồn này không?", "Chú Ý!", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    int kq = lopchung.ThemXoaSua(sqldelete);
                    if (kq >= 1) MessageBox.Show("Xoá PSU thành công");
                    else MessageBox.Show("Xoá PSU thất bại");
                    grid_PSU.DataSource = lopchung.LoadDL(sql);
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
    }
}
