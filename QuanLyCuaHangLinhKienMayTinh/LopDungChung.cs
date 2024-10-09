using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangLinhKienMayTinh
{
    class LopDungChung
    {
        SqlConnection conn;
        public string directory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;

        public LopDungChung()
        {
            conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+directory+@"\Database1.mdf;Integrated Security=True";
        }
        public object LayGT(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            object kq = comm.ExecuteScalar();
            conn.Close();
            return kq;
        }
        public int ThemXoaSua(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            int kq = comm.ExecuteNonQuery();
            conn.Close();
            return kq;
        }
        public DataTable LoadDL(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public string PicPath()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.ShowDialog();
            string filePath = open.FileName;
            return filePath;
        }
        
        public string ImgFolderPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"/image/";
    }
}
