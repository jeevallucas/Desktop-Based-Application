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
    public partial class FormFilter : Form
    {
        public FormFilter()
        {
            InitializeComponent();
        }

        private void btnPenjualan_Click(object sender, EventArgs e)
        {
            FormPenjualanPerBarang frmlap = new FormPenjualanPerBarang();
            String nm = tbPencarianPenjualan.Text;
            frmlap.isi(nm);
            frmlap.ShowDialog();
            frmlap.Dispose();

            tbPencarianPenjualan.Clear();
        }

        private void btnSortByDate_Click(object sender, EventArgs e)
        {
            FormSortByDate frmlap = new FormSortByDate();
            String nmAwal = dtpAwal.Text;
            String nmAkhir = dtpAkhir.Text;
            frmlap.isi(nmAwal, nmAkhir);
            frmlap.ShowDialog();
            frmlap.Dispose();

            dtpAwal.Text = "";
            dtpAkhir.Text = "";
        }

        private void btnStok_Click(object sender, EventArgs e)
        {
            FormStok frmlap = new FormStok();
            String nmNamaBaju = tbNamaBaju.Text;
            String nmStok = tbStok.Text;
            frmlap.isi(nmNamaBaju, nmStok);
            frmlap.ShowDialog();
            frmlap.Dispose();

            if (tbStok.Enabled == false)
                tbStok.Enabled = true;

            if (tbNamaBaju.Enabled == false)
                tbNamaBaju.Enabled = true;

            tbNamaBaju.Clear();
            tbStok.Clear();

            button1.Visible = false;
        }

        private void tbNamaBaju_MouseClick(object sender, MouseEventArgs e)
        {
            tbStok.Enabled = false;
            button1.Visible = true;
        }

        private void tbStok_MouseClick(object sender, MouseEventArgs e)
        {
            tbNamaBaju.Enabled = false;
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbNamaBaju.Enabled = true;
            tbStok.Enabled = true;

            tbNamaBaju.Clear();
            tbStok.Clear();

            button1.Visible = false;
        }

        private void FormFilter_Load(object sender, EventArgs e)
        {
            button1.Visible = false;
        }
    }
}
