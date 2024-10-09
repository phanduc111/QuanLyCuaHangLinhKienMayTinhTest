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
    public partial class frm_STO : Form
    {
        public frm_STO()
        {
            InitializeComponent();
        }

        string sql = "Select * from STORAGE";
        LopDungChung lopchung = new LopDungChung();
        string imgFileName = "";

        private void frm_STO_Load(object sender, EventArgs e)
        {
            grid_STO.DataSource = lopchung.LoadDL(sql);
            string sqlchuan = "Select * from STRGSTANDARD";
            cb_Chuan.DataSource = lopchung.LoadDL(sqlchuan);
            cb_Chuan.ValueMember = "TieuChuan";
        }

        private void btn_ChonAnh_Click(object sender, EventArgs e)
        {
            try
            {
                string path = lopchung.PicPath();
                imgFileName = Path.GetFileName(path);
                Image image = Image.FromFile(path);
                pic_STO.Image = image;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void grid_STO_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_TenBoNho.Text = grid_STO.CurrentRow.Cells["TenBoNho"].Value.ToString();
            txt_HangSX.Text = grid_STO.CurrentRow.Cells["HangSX"].Value.ToString();
            txt_DungLuong.Text = grid_STO.CurrentRow.Cells["DungLuong"].Value.ToString();
            cb_Chuan.SelectedValue = grid_STO.CurrentRow.Cells["TieuChuan"].Value.ToString();
            txt_DonGia.Text = grid_STO.CurrentRow.Cells["DonGia"].Value.ToString();
            txt_SoLuong.Text = grid_STO.CurrentRow.Cells["SoLuong"].Value.ToString();
            try
            {
                pic_STO.Image = Image.FromFile(lopchung.ImgFolderPath
                                               + grid_STO.CurrentRow.Cells["HinhAnh"].Value.ToString());
            }
            catch (Exception)
            {
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlinsert = "Insert into STORAGE values ('" + txt_TenBoNho.Text + "','" + txt_HangSX.Text +
                        "','" + txt_DungLuong.Text + "','" + cb_Chuan.SelectedValue + "','"  + imgFileName + 
                        "','" + txt_DonGia.Text + "','" + txt_SoLuong.Text + "')";
                int kq = lopchung.ThemXoaSua(sqlinsert);
                if (kq >= 1) MessageBox.Show("Thêm Ổ cứng thành công");
                else MessageBox.Show("Thêm Ổ cứng thất bại");
                grid_STO.DataSource = lopchung.LoadDL(sql);
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
                string sqlupdate = "update STORAGE set HangSX='" + txt_HangSX.Text +
                        "',DungLuong='" + txt_DungLuong.Text + "',TieuChuan='" + cb_Chuan.SelectedValue +
                        "',DonGia='" + txt_DonGia.Text + "',SoLuong='" + txt_SoLuong.Text +
                        "' where TenBoNho='" + txt_TenBoNho.Text + "'";
                int kq = lopchung.ThemXoaSua(sqlupdate);
                if (kq >= 1) MessageBox.Show("Cập nhật Ổ cứng thành công");
                else MessageBox.Show("Cập nhật Ổ cứng thất bại");
                grid_STO.DataSource = lopchung.LoadDL(sql);
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
                string sqldelete = "Delete STORAGE where TenBoNho = '" + txt_TenBoNho.Text + "'";
                DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn xóa Ổ cứng này không?", "Chú Ý!", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    int kq = lopchung.ThemXoaSua(sqldelete);
                    if (kq >= 1) MessageBox.Show("Xoá Ổ cứng thành công");
                    else MessageBox.Show("Xoá ổ cứng thất bại");
                    grid_STO.DataSource = lopchung.LoadDL(sql);
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
    }
}
