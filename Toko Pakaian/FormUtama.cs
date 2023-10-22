using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toko_Pakaian
{
    public partial class FormUtama : Form
    {
        public FormUtama()
        {
            InitializeComponent();
        }

        private void FormUtama_Load(object sender, EventArgs e)
        {
            pakaianToolStripMenuItem.Enabled = FormLogin.pakaian;
            penjualanToolStripMenuItem.Enabled = FormLogin.penjualan;
            filterToolStripMenuItem.Enabled = FormLogin.laporan;

            lblUsername.Text = "Hello, " + FormLogin.username1 + "!";
        }

        private void pakaianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPakaian frm = new FormPakaian();
            frm.ShowDialog();
        }

        private void laporanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFilter frm = new FormFilter();
            frm.ShowDialog();
        }

        private void penjualanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPenjualan frm = new FormPenjualan();
            frm.ShowDialog();
        }
    }
}
