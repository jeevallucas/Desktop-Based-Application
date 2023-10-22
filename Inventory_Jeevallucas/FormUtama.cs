using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Jeevallucas
{
    public partial class FormUtama : Form
    {
        public FormUtama()
        {
            InitializeComponent();
        }

        private void FormUtama_Load(object sender, EventArgs e)
        {
            barangToolStripMenuItem.Enabled = FormLogin.barang;
            supplierToolStripMenuItem.Enabled = FormLogin.supplier;
            pembelianToolStripMenuItem.Enabled = FormLogin.nota_beli;

            lblUsername.Text = "Hello, " + FormLogin.username1 + ".";
        }

        private void barangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formBarang frm = new formBarang();
            frm.ShowDialog();
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formSupplier frm = new formSupplier();
            frm.ShowDialog();
        }

        private void pembelianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPembelian frm = new FormPembelian();
            frm.ShowDialog();
        }
    }
}
