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
    public partial class frm_RAM : Form
    {
        public frm_RAM()
        {
            InitializeComponent();
        }

        string sql = "Select * from MEMORY";
        LopDungChung lopchung = new LopDungChung();

        private void frm_RAM_Load(object sender, EventArgs e)
        {
            grid_RAM.DataSource = lopchung.LoadDL(sql);
            string sqldr = "Select * from MEMSTANDARD";
            cb_Chuan.DataSource = lopchung.LoadDL(sqldr);
            cb_Chuan.ValueMember = "TieuChuan";
        }

        private void grid_RAM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaRAM.Text = grid_RAM.CurrentRow.Cells["MaRAM"].Value.ToString();
            txt_TenRAM.Text = grid_RAM.CurrentRow.Cells["TenRAM"].Value.ToString();
            txt_HangPhanPhoi.Text = grid_RAM.CurrentRow.Cells["HangPhanPhoi"].Value.ToString();
            txt_HangSXChip.Text = grid_RAM.CurrentRow.Cells["HangSXChip"].Value.ToString();
            cb_Chuan.SelectedValue = grid_RAM.CurrentRow.Cells["Chuan"].Value.ToString();
            txt_DungLuong.Text = grid_RAM.CurrentRow.Cells["DungLuong"].Value.ToString();
            txt_Clock.Text = grid_RAM.CurrentRow.Cells["Clock"].Value.ToString();
            txt_DonGia.Text = grid_RAM.CurrentRow.Cells["DonGia"].Value.ToString();
            txt_SoLuong.Text = grid_RAM.CurrentRow.Cells["SoLuong"].Value.ToString();
            try
            {
                pic_RAM.Image = Image.FromFile(lopchung.ImgFolderPath
                                               + grid_RAM.CurrentRow.Cells["HinhAnh"].Value.ToString());
            }
            catch (Exception)
            {
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlinsert = "Insert into MEMORY values ('" + txt_MaRAM.Text + "','" + txt_TenRAM.Text +
                    "','" + cb_Chuan.SelectedValue + "','" + txt_Clock.Text + "','" + txt_DungLuong.Text + "','" + txt_HangSXChip.Text +
                    "','" + txt_HangPhanPhoi.Text + "','" + imgFileName + "','" + txt_DonGia.Text + "','" + txt_SoLuong.Text + "')";
                int kq = lopchung.ThemXoaSua(sqlinsert);
                if (kq >= 1) MessageBox.Show("Thêm RAM thành công");
                else MessageBox.Show("Thêm RAM thất bại");
                grid_RAM.DataSource = lopchung.LoadDL(sql);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        string imgFileName = "";

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlupdate = "update MEMORY set TenRAM='" + txt_TenRAM.Text +
                    "',Chuan='" + cb_Chuan.SelectedValue + "',Clock='" + txt_Clock.Text + "',DungLuong='" + txt_DungLuong.Text + "',HangSXChip='" + txt_HangSXChip.Text +
                    "',HangPhanPhoi='" + txt_HangPhanPhoi.Text + "',DonGia='" + txt_DonGia.Text + "',SoLuong='" + txt_SoLuong.Text +
                    "' where MaRAM = '" + txt_MaRAM.Text + "'";
                int kq = lopchung.ThemXoaSua(sqlupdate);
                if (kq >= 1) MessageBox.Show("Cập nhật RAM thành công");
                else MessageBox.Show("Cập nhật RAM thất bại");
                grid_RAM.DataSource = lopchung.LoadDL(sql);
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
                string sqldelete = "Delete MEMORY where MaRAM = '" + txt_MaRAM.Text + "'";
                DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn xóa RAM này không?", "Chú Ý!", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    int kq = lopchung.ThemXoaSua(sqldelete);
                    if (kq >= 1) MessageBox.Show("Xoá RAM thành công");
                    else MessageBox.Show("Xoá RAM thất bại");
                    grid_RAM.DataSource = lopchung.LoadDL(sql);
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void btn_ChonAnh_Click(object sender, EventArgs e)
        {
            try
            {
                string path = lopchung.PicPath();
                imgFileName = Path.GetFileName(path);
                Image image = Image.FromFile(path);
                pic_RAM.Image = image;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
    }
}
