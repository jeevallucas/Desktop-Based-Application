using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Jeevallucas
{
    public partial class FormPembelian : Form
    {
        public FormPembelian()
        {
            InitializeComponent();
        }

        Tabel master = new Tabel("view_pembelian");
        Tabel detail = new Tabel("view_detail_pembelian");

        void ikat()
        {
            tbNoNotaBeli.DataBindings.Add("Text", master.getBs(), "noNotaBeli");
            cbNoNotaBeli.DataBindings.Add("Text", master.getBs(), "noNotaBeli");
            tbTanggal.DataBindings.Add("Text", master.getBs(), "tanggal");
            tbKodeSupplier.DataBindings.Add("Text", master.getBs(), "kodeSupplier");
            tbNamaSupplier.DataBindings.Add("Text", master.getBs(), "namaSupplier");
            tbAlamat.DataBindings.Add("Text", master.getBs(), "alamat");
            tbKota.DataBindings.Add("Text", master.getBs(), "kota");
            tbTelepon.DataBindings.Add("Text", master.getBs(), "telpon");

            dgvDetailPembelian.DataSource = this.detail.getBs();
            tampil();
        }

        private void FormPembelian_Load(object sender, EventArgs e)
        {
            ikat();
        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            master.getBs().MoveFirst();
            tampil();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            master.getBs().MovePrevious();
            tampil();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            master.getBs().MoveNext();
            tampil();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            master.getBs().MoveLast();
            tampil();
        }

        void hapus()
        {
            tbKodeBarang.Clear();
            tbNamaBarang.Clear();
            tbQTY.Text = "0";
            tbHarga.Text = "0";
            tbJumlah.Text = "0";

            tbKodeBarang.Focus();
        }

        private void tbKodeBarang_Validating(object sender, CancelEventArgs e)
        {
            if (tbKodeBarang.Text.Length == 5)
            {
                Tabel barang = new Tabel("barang");
                string kodeCari = tbKodeBarang.Text;
                int ketemuBaris = barang.getBs().Find("kodeBarang", kodeCari);

                if (ketemuBaris >= 0)
                {
                    barang.getBs().Position = ketemuBaris;
                    tbNamaBarang.Text = ((DataRowView)barang.getBs().Current).Row["nama"].ToString();
                    tbHarga.Text = ((DataRowView)barang.getBs().Current).Row["hargaBeli"].ToString();
                    MessageBox.Show("Kode Barang " + kodeCari + " yang Anda cari ditemukan.");
                }

                else
                {
                    MessageBox.Show("Kode Barang " + kodeCari + " yang Anda cari tidak ditemukan.");
                    hapus();
                }
            }

            else if (tbKodeBarang.Text.Length > 0 && tbKodeBarang.Text.Length <= 5)
            {
                MessageBox.Show("Format Kode Barang salah.");
                tbKodeBarang.Clear();
                tbKodeBarang.Focus();
            }
        }

        private void tbKodeBarang_Leave(object sender, EventArgs e)
        {
            if (tbKodeBarang.Text.Length == 5)
                tbQTY.Focus();
        }

        private void tbKodeBarang_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 191)
            {
                FormCariBarang FrmCb = new FormCariBarang();

                FrmCb.ShowDialog();
                tbKodeBarang.Text = FrmCb.kodeBarang;
                FrmCb.Dispose();
            }

            if (tbKodeBarang.Text.Length == 5)
                tbQTY.Focus();
        }

        private void tbQTY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tbHarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tbQTY_Validated(object sender, EventArgs e)
        {
            tbJumlah.Text = (int.Parse(tbQTY.Text) * int.Parse(tbQTY.Text)).ToString();
        }

        private void tbHarga_Validated(object sender, EventArgs e)
        {
            tbJumlah.Text = (int.Parse(tbQTY.Text) * int.Parse(tbHarga.Text)).ToString();
            tbJumlah.Focus();
        }

        private void tbQTY_KeyDown(object sender, KeyEventArgs e)
        {
            if (tbQTY.Text.Length > 0)
                if (e.KeyData == Keys.Enter && int.Parse(tbQTY.Text) > 0)
                    tbHarga.Focus();
        }

        private void tbHarga_KeyDown(object sender, KeyEventArgs e)
        {
            if (tbHarga.Text.Length > 0)
                if (e.KeyData == Keys.Enter && int.Parse(tbQTY.Text) > 0)
                    tbJumlah.Focus();
        }
        
        void total()
        {
            int baris, total = 0;
            
            for (baris = 0; baris < dgvDetailPembelian.Rows.Count; baris++)
                total += int.Parse(dgvDetailPembelian.Rows[baris].Cells[6].Value.ToString());

            tbTotal.Text = total.ToString("Rp #,###");
        }

        void tampil()
        {
            detail.getBs().Filter = "noNotaBeli = " + tbNoNotaBeli.Text;
            total();
        }

        private void tbJumlah_KeyDown(object sender, KeyEventArgs e)
        {
            if(tbJumlah.Text.Length > 0)
                if(e.KeyData == Keys.Enter && int.Parse(tbJumlah.Text) > 0)
                {
                    String strSQL, noNotaBeli, kodeBarang, qty, harga;
                    noNotaBeli = tbNoNotaBeli.Text;
                    kodeBarang = tbKodeBarang.Text;
                    qty = tbQTY.Text;
                    harga = tbHarga.Text;

                    strSQL = "INSERT INTO itemNotaBeli (" +
                        "noNotaBeli, kodeBarang, qty, harga) " +
                        "VALUES('{0}', '{1}', '{2}', '{3}')";
                    strSQL = String.Format(strSQL, noNotaBeli, kodeBarang, qty, harga);

                    detail.eksekusiSQL(strSQL);
                    hapus();
                    total();
                }
        }

        private void dgvDetailPembelian_KeyDown(object sender, KeyEventArgs e)
        {
            int baris = dgvDetailPembelian.SelectedCells[0].RowIndex;

            if (e.KeyData == Keys.Back)
            {
                tbKodeBarang.Text = dgvDetailPembelian.Rows[baris].Cells[2].Value.ToString();
                tbNamaBarang.Text = dgvDetailPembelian.Rows[baris].Cells[3].Value.ToString();
                tbQTY.Text = dgvDetailPembelian.Rows[baris].Cells[4].Value.ToString();
                tbHarga.Text = dgvDetailPembelian.Rows[baris].Cells[5].Value.ToString();
                tbJumlah.Text = dgvDetailPembelian.Rows[baris].Cells[6].Value.ToString();

                tbKodeBarang.Focus();
            }

            if (e.KeyData == Keys.Delete || e.KeyData == Keys.Back)
            {
                MessageBox.Show("Anda akan menghapus ID Nota Beli: " + baris + ".");
                String idNotaBeli = dgvDetailPembelian.Rows[baris].Cells[0].Value.ToString();
                String strSQL = "DELETE FROM itemNotaBeli WHERE idNotaBeli = " + idNotaBeli;

                detail.eksekusiSQL(strSQL);
            }

            total();
        }

        void modeEdit()
        {
            tbKodeSupplier.ReadOnly = false;
            tbKodeSupplier.Focus();

            btnSave.Visible = true;
            btnTop.Enabled = false;
            btnBack.Enabled = false;
            btnNext.Enabled = false;
            btnEnd.Enabled = false;

            btnFind.Enabled = false;
            btnPrint.Enabled = false;
            btnDel.Enabled = false;
            btnNew.Enabled = false;
            btnSave.Enabled = true;

            btnEdit.Enabled = false;

            dgvDetailPembelian.Top = 280;
            dgvDetailPembelian.Height = 185;
        }

        void modeSave()
        {
            tbKodeSupplier.ReadOnly = true;
            tbKodeSupplier.Focus();

            btnSave.Visible = false;
            btnTop.Enabled = true;
            btnBack.Enabled = true;
            btnNext.Enabled = true;
            btnEnd.Enabled = true;

            btnFind.Enabled = true;
            btnPrint.Enabled = true;
            btnDel.Enabled = true;
            btnNew.Enabled = true;
            btnSave.Enabled = false;

            btnEdit.Enabled = true;

            dgvDetailPembelian.Top = 197;
            dgvDetailPembelian.Height = 268;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            String tanggal = DateTime.Now.ToString();
            String strSQL = "INSERT INTO notaBeli(tanggal) VALUES(CONVERT(datetime, '" + tanggal + "' , 103))";
            String nomorNotaBaru = master.eksekusiSQL_getID(strSQL);
            int posisi = master.getBs().Find("noNotaBeli", nomorNotaBaru);
                
            master.getBs().Position = posisi;
            tampil();
            modeEdit();
        }

        private void tbKodeSupplier_Validated(object sender, EventArgs e)
        {
            if (tbKodeSupplier.Text.Length == 0 || tbKodeSupplier.Text.Length == 3)
            {
                String strSQL, noNotaSekarang = tbNoNotaBeli.Text;
                Tabel supplier = new Tabel("supplier");
                int barisDitemukan = supplier.getBs().Find("kodeSupplier", tbKodeSupplier.Text);

                if (barisDitemukan >= 0)
                {
                    strSQL = "UPDATE notaBeli SET kodeSupplier = '{0}' WHERE noNotaBeli = '{1}'";
                    strSQL = String.Format(strSQL, tbKodeSupplier.Text, noNotaSekarang);
                    tbKodeBarang.Focus();
                }

                else
                {
                    MessageBox.Show("Supplier " + tbKodeSupplier.Text + " tidak ditemukan.");
                    strSQL = "UPDATE notaBeli SET kodeSupplier = NULL WHERE noNotaBeli = '{0}'";
                    strSQL = String.Format(strSQL, noNotaSekarang);

                    if (tbKodeSupplier.Text.Length != 0)
                        tbKodeSupplier.Focus();
                    else
                        tbKodeBarang.Focus();

                    tbKodeSupplier.Clear();
                }

                master.eksekusiSQL(strSQL);
                barisDitemukan = master.getBs().Find("noNotaBeli", noNotaSekarang);
                master.getBs().Position = barisDitemukan;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            modeEdit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            modeSave();
        }

        private void tbKodeSupplier_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 191)
            {
                FormCariSupplier FrmCs = new FormCariSupplier();
                FrmCs.ShowDialog();

                tbKodeSupplier.Text = FrmCs.kodeSupplier;
                FrmCs.Dispose();
            }

            if (tbKodeSupplier.Text.Length == 3 || e.KeyCode == Keys.Enter)
                tbKodeBarang.Focus();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult jawab;
            jawab = MessageBox.Show("Hapus Nota " + tbNoNotaBeli.Text + "?", "KONFIRMASI",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (jawab == DialogResult.Yes)
            {
                String nomorNota = tbNoNotaBeli.Text;
                String strSQL = "DELETE FROM itemNotaBeli WHERE noNotaBeli = '" + nomorNota + "'";
                detail.eksekusiSQL(strSQL);

                strSQL = "DELETE FROM notaBeli WHERE noNotaBeli = '" + nomorNota + "'";
                master.eksekusiSQL(strSQL);

                MessageBox.Show("Penghapusan selesai.", "INFORMASI", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                master.getBs().MoveLast();
                tampil();
            }

            else
            {
                MessageBox.Show("Penghapusan dibatalkan.", "INFORMASI", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void modeCari()
        {
            btnTop.Enabled = false;
            btnBack.Enabled = false;
            btnNext.Enabled = false;
            btnEnd.Enabled = false;

            btnPrint.Enabled = false;
            btnFind.Enabled = false;
            btnNew.Enabled = false;
            btnEdit.Enabled = false;
            btnDel.Enabled = false;
            btnUndo.Enabled = false;

            btnClose.Enabled = false;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            modeCari();
            String noNotaSekarang = tbNoNotaBeli.Text, noNotaBeli;

            cbNoNotaBeli.Visible = true;
            master.getBs().MoveFirst();
            cbNoNotaBeli.Items.Clear();
            cbNoNotaBeli.Text = noNotaSekarang;

            for (int n = 0; n < master.getBs().Count; n++)
            {
                noNotaBeli = ((DataRowView)master.getBs().Current).Row["noNotaBeli"].ToString();
                
                cbNoNotaBeli.Items.Add(noNotaBeli);
                master.getBs().MoveNext();
            }

            int posisi = master.getBs().Find("noNotaBeli", noNotaSekarang);
            master.getBs().Position = posisi;

            cbNoNotaBeli.Focus();
        }

        private void cbNoNotaBeli_SelectedValueChanged(object sender, EventArgs e)
        {
            master.getBs().Position = master.getBs().Find("noNotaBeli", cbNoNotaBeli.Text);
            tampil();

            cbNoNotaBeli.Visible = false;
            modeSave();
        }

        private void cbNoNotaBeli_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && cbNoNotaBeli.Text != "")
            {
                int baris = master.getBs().Find("noNotaBeli", cbNoNotaBeli.Text);

                if(baris >= 0)
                {
                    master.getBs().Position = baris;
                    tampil();

                    cbNoNotaBeli.Visible = false;
                    modeSave();
                }

                else
                {
                    MessageBox.Show("Nomor Nota Beli " + cbNoNotaBeli.Text + " tidak ditemukan.");
                    cbNoNotaBeli.Focus();
                }
            }
        }

        private void cbNoNotaBeli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
