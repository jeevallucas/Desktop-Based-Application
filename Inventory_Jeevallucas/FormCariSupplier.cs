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
    public partial class FormCariSupplier : Form
    {
        Tabel supplier = new Tabel("supplier");

        public FormCariSupplier()
        {
            InitializeComponent();
        }

        private void FormCariSupplier_Load(object sender, EventArgs e)
        {
            dgvSupplier.DataSource = supplier.getBs();
        }

        private String _kodeSupplier;

        public String kodeSupplier
        {
            get
            {
                return this._kodeSupplier;
            }
        }

        private void dgvSupplier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                int brs = dgvSupplier.SelectedCells[0].RowIndex;
                this._kodeSupplier = dgvSupplier.Rows[brs].Cells[0].Value.ToString();
                this.Visible = false;
            }
        }

        private void FormCariSupplier_FormClosed(object sender, FormClosedEventArgs e)
        {
            int brs = dgvSupplier.SelectedCells[0].RowIndex;
            this._kodeSupplier = dgvSupplier.Rows[brs].Cells[0].Value.ToString();
        }

        private void tbNamaSupplier_KeyUp(object sender, KeyEventArgs e)
        {
            supplier.getBs().Filter = "namaSupplier LIKE '%" + tbNamaSupplier.Text + "%'";
        }

        private void tbNamaSupplier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.Tab)
                dgvSupplier.Focus();
        }
    }
}
