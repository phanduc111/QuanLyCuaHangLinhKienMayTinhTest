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
    public partial class frm_QuanLyLinhKien : Form
    {
        public frm_QuanLyLinhKien()
        {
            InitializeComponent();
        }

        private void cPUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_CPU"] == null)
            {
                frm_CPU cpu = new frm_CPU();
                cpu.MdiParent = this;
                cpu.Show();
            }
        }

        private void gPUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_GPU"] == null)
            {
                frm_GPU gpu = new frm_GPU();
                gpu.MdiParent = this;
                gpu.Show();
            }
        }

        private void rAMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_RAM"] == null)
            {
                frm_RAM ram = new frm_RAM();
                ram.MdiParent = this;
                ram.Show();
            }
        }

        private void motherboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_MB"] == null)
            {
                frm_MB mb = new frm_MB();
                mb.MdiParent = this;
                mb.Show();
            }
        }

        private void nguồnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_PSU"] == null)
            {
                frm_PSU psu = new frm_PSU();
                psu.MdiParent = this;
                psu.Show();
            }
        }

        private void caseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_Case"] == null)
            {
                frm_Case cases = new frm_Case();
                cases.MdiParent = this;
                cases.Show();
            }
        }

        private void ổCứngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_STO"] == null)
            {
                frm_STO sto = new frm_STO();
                sto.MdiParent = this;
                sto.Show();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
