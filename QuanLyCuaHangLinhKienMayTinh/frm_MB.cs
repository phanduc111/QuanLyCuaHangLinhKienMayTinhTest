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
    public partial class frm_MB : Form
    {
        public frm_MB()
        {
            InitializeComponent();
        }

        string sql = "Select * from MOTHERBOARDS";
        LopDungChung lopchung = new LopDungChung();
        string imgFileName = "";

        private void btn_ChonAnh_Click(object sender, EventArgs e)
        {
            try
            {
                string path = lopchung.PicPath();
                imgFileName = Path.GetFileName(path);
                Image image = Image.FromFile(path);
                pic_MB.Image = image;
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
                string sqlinsert = "Insert into MOTHERBOARDS values ('" + txt_MaMB.Text + "','" + txt_TenMB.Text +
                        "','" + txt_Chipset.Text + "','" + cb_Socket.SelectedValue + "','" + cb_ChuanKichThuoc.SelectedValue + 
                        "','" + txt_HangSX.Text + "','" + imgFileName + "','" + txt_DonGia.Text + "','" + txt_SoLuong.Text + "')";
                int kq = lopchung.ThemXoaSua(sqlinsert);
                if (kq >= 1) MessageBox.Show("Thêm Mainboard thành công");
                else MessageBox.Show("Thêm Mainboard thất bại");
                grid_MB.DataSource = lopchung.LoadDL(sql);
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
                string sqlupdate = "update MOTHERBOARDS set TenMB='"  + txt_TenMB.Text +
                        "',Chipset='" + txt_Chipset.Text + "',Socket='" + cb_Socket.SelectedValue + "',ChuanKichThuoc='" + cb_ChuanKichThuoc.SelectedValue +
                        "',HangSX='" + txt_HangSX.Text + "',DonGia='" + txt_DonGia.Text + "',SoLuong='" + txt_SoLuong.Text + 
                        "' where MaMB='"+txt_MaMB.Text+"'";
                int kq = lopchung.ThemXoaSua(sqlupdate);
                if (kq >= 1) MessageBox.Show("Cập nhật Motherboard thành công");
                else MessageBox.Show("Cập nhật Motherboard thất bại");
                grid_MB.DataSource = lopchung.LoadDL(sql);
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
                string sqldelete = "Delete MOTHERBOARDS where MaMB = '" + txt_MaMB.Text + "'";
                DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn xóa main này không?", "Chú Ý!", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    int kq = lopchung.ThemXoaSua(sqldelete);
                    if (kq >= 1) MessageBox.Show("Xoá Motherboard thành công");
                    else MessageBox.Show("Xoá Motherboard thất bại");
                    grid_MB.DataSource = lopchung.LoadDL(sql);
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void frm_MB_Load(object sender, EventArgs e)
        {
            grid_MB.DataSource = lopchung.LoadDL(sql);
            string sqlkt = "Select * from MBFORMFACTOR";
            cb_ChuanKichThuoc.DataSource = lopchung.LoadDL(sqlkt);
            cb_ChuanKichThuoc.ValueMember = "TieuChuan";
            string sqlsk = "Select * from SOCKET";
            cb_Socket.DataSource = lopchung.LoadDL(sqlsk);
            cb_Socket.ValueMember = "Socket";
        }

        private void grid_MB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaMB.Text = grid_MB.CurrentRow.Cells["MaMB"].Value.ToString();
            txt_TenMB.Text = grid_MB.CurrentRow.Cells["TenMB"].Value.ToString();
            txt_HangSX.Text = grid_MB.CurrentRow.Cells["HangSX"].Value.ToString();
            txt_Chipset.Text = grid_MB.CurrentRow.Cells["Chipset"].Value.ToString();
            cb_Socket.SelectedValue = grid_MB.CurrentRow.Cells["Socket"].Value.ToString();
            cb_ChuanKichThuoc.SelectedValue = grid_MB.CurrentRow.Cells["ChuanKichThuoc"].Value.ToString();
            txt_DonGia.Text = grid_MB.CurrentRow.Cells["DonGia"].Value.ToString();
            txt_SoLuong.Text = grid_MB.CurrentRow.Cells["SoLuong"].Value.ToString();
            try
            {
                pic_MB.Image = Image.FromFile(lopchung.ImgFolderPath
                                               + grid_MB.CurrentRow.Cells["HinhAnh"].Value.ToString());
            }
            catch (Exception)
            {
            }
        }
    }
}
