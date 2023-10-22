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
    public partial class FormPenjualan : Form
    {
        public FormPenjualan()
        {
            InitializeComponent();
        }

        Tabel master = new Tabel("vPenjualan");
        Tabel detail = new Tabel("vDetail");

        void total()
        {
            int baris, total = 0;

            for (baris = 0; baris < dgvDetail.Rows.Count; baris++)
                total += int.Parse(dgvDetail.Rows[baris].Cells[6].Value.ToString());

            tbTotal.Text = total.ToString("Rp #,###");
        }

        void tampil()
        {
            detail.getBs().Filter = "id_trans = " + tbIDTransaksi.Text;
            total();
        }

        void ikat()
        {
            tbIDTransaksi.DataBindings.Add("Text", master.getBs(), "id_trans");

            tbIDPegawai.DataBindings.Add("Text", master.getBs(), "id_pgw");
            tbNamaPegawai.DataBindings.Add("Text", detail.getBs(), "nm_pgw");

            dtpTanggal.DataBindings.Add("Text", master.getBs(), "tgl_trans");

            tbIDCustomer.DataBindings.Add("Text", master.getBs(), "id_customer");
            tbNamaCustomer.DataBindings.Add("Text", master.getBs(), "nm_customer");
            tbJenisKelamin.DataBindings.Add("Text", master.getBs(), "jk_customer");
            tbTelepon.DataBindings.Add("Text", master.getBs(), "no_telp");
            tbAlamat.DataBindings.Add("Text", master.getBs(), "alamat");
            tbKota.DataBindings.Add("Text", master.getBs(), "kota");

            dgvDetail.DataSource = this.detail.getBs();
            tampil();
        }

        private void FormPenjualan_Load(object sender, EventArgs e)
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
            tbKodeBaju.Clear();
            tbNamaBaju.Clear();
            tbQTY.Text = "0";
            tbJenis.Clear();
            tbStatus.Clear();
            tbHarga.Text = "0";
            tbJumlah.Text = "0";

            tbKodeBaju.Focus();
        }

        private void tbKodeBaju_Validating(object sender, CancelEventArgs e)
        {
            Tabel pakaian = new Tabel("pakaian");
            String kodeCari = tbKodeBaju.Text;
            int ketemuBaris = pakaian.getBs().Find("kd_baju", kodeCari);

            if (tbKodeBaju.Text.Length == 7 || tbKodeBaju.Text.Length == 8)
            {
                if (ketemuBaris >= 0)
                {
                    pakaian.getBs().Position = ketemuBaris;
                    tbNamaBaju.Text = ((DataRowView)pakaian.getBs().Current).Row["nm_baju"].ToString();
                    tbJenis.Text = ((DataRowView)pakaian.getBs().Current).Row["jenis"].ToString();
                    tbStatus.Text = ((DataRowView)pakaian.getBs().Current).Row["status"].ToString();
                    tbHarga.Text = ((DataRowView)pakaian.getBs().Current).Row["harga_jual"].ToString();
                }

                else
                {
                    MessageBox.Show("Kami tidak dapat menemukan pakaian " + kodeCari + " yang kamu cari...", "Maaf! :(", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    hapus();
                }
            }

            else if (tbKodeBaju.Text.Length > 0)
            {
                MessageBox.Show("Kami tidak dapat menemukan pakaian " + kodeCari + " yang kamu cari...", "Maaf! :(", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                tbKodeBaju.Clear();
                tbKodeBaju.Focus();
            }
        }

        void modeNew()
        {
            tbIDPegawai.Focus();

            tbIDPegawai.ReadOnly = false;

            dtpTanggal.Enabled = true;

            tbIDCustomer.ReadOnly = false;
            tbIDCustomer.Enabled = true;

            tbKodeBaju.ReadOnly = false;
            tbKodeBaju.Enabled = true;

            tbQTY.ReadOnly = false;
            tbQTY.Enabled = true;

            tbHarga.ReadOnly = false;
            tbHarga.Enabled = true;

            tbJumlah.ReadOnly = true;
            tbJumlah.Enabled = true;

            btnSave.Visible = true;
            btnTop.Enabled = false;
            btnBack.Enabled = false;
            btnNext.Enabled = false;
            btnEnd.Enabled = false;
            btnUndo.Enabled = true;

            btnDel.Enabled = false;
            btnNew.Enabled = false;
            btnSave.Enabled = true;

            btnEdit.Enabled = false;
            btnClose.Enabled = true;

            tbQTY.Text = "0";
            tbHarga.Text = "0";
            tbJumlah.Text = "0";
        }

        void modeEdit()
        {
            tbIDPegawai.Focus();

            tbIDPegawai.ReadOnly = false;

            dtpTanggal.Enabled = true;

            tbIDCustomer.ReadOnly = false;
            tbIDCustomer.Enabled = true;

            tbKodeBaju.ReadOnly = false;
            tbKodeBaju.Enabled = true;

            tbQTY.ReadOnly = false;
            tbQTY.Enabled = true;

            tbHarga.ReadOnly = false;
            tbHarga.Enabled = true;

            tbJumlah.ReadOnly = true;
            tbJumlah.Enabled = true;

            btnSave.Visible = true;
            btnTop.Enabled = false;
            btnBack.Enabled = false;
            btnNext.Enabled = false;
            btnEnd.Enabled = false;
            btnUndo.Enabled = true;

            btnDel.Enabled = false;
            btnNew.Enabled = false;
            btnSave.Enabled = true;

            btnEdit.Enabled = false;
            btnClose.Enabled = false;

            tbQTY.Text = "0";
            tbHarga.Text = "0";
            tbJumlah.Text = "0";
        }

        void modeSave()
        {
            btnTop.Focus();

            tbIDPegawai.ReadOnly = true;

            dtpTanggal.Enabled = false;

            tbIDCustomer.ReadOnly = true;
            tbIDCustomer.Enabled = false;

            tbKodeBaju.ReadOnly = true;
            tbKodeBaju.Enabled = false;

            tbQTY.ReadOnly = true;
            tbQTY.Enabled = false;

            tbHarga.ReadOnly = true;
            tbHarga.Enabled = false;

            tbJumlah.ReadOnly = true;
            tbJumlah.Enabled = false;

            btnTop.Enabled = true;
            btnBack.Enabled = true;
            btnNext.Enabled = true;
            btnEnd.Enabled = true;
            btnUndo.Enabled = false;

            btnDel.Enabled = true;
            btnNew.Enabled = true;
            btnSave.Enabled = false;

            btnEdit.Enabled = true;
            btnClose.Enabled = true;

            tbQTY.Clear();
            tbHarga.Clear();
            tbJumlah.Clear();
        }

        void modeUndo()
        {
            btnNew.Focus();

            dtpTanggal.Enabled = false;

            tbIDPegawai.ReadOnly = true;

            tbIDCustomer.ReadOnly = true;
            tbIDCustomer.Enabled = false;

            tbKodeBaju.ReadOnly = true;
            tbKodeBaju.Enabled = false;

            tbQTY.ReadOnly = true;
            tbQTY.Enabled = false;

            tbHarga.ReadOnly = true;
            tbHarga.Enabled = false;

            btnTop.Enabled = true;
            btnBack.Enabled = true;
            btnNext.Enabled = true;
            btnEnd.Enabled = true;
            btnUndo.Enabled = false;

            btnDel.Enabled = true;
            btnNew.Enabled = true;
            btnSave.Enabled = false;

            btnEdit.Enabled = true;
            btnClose.Enabled = true;

            tbQTY.Clear();
            tbHarga.Clear();
            tbJumlah.Clear();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            String tgl = DateTime.Now.ToString();
            String sql = "INSERT INTO transaksi (tgl_trans) VALUES(CONVERT(datetime, '" + tgl + "', 103))";
            String nomorNotaBaru = master.eksekusiSQL_getID(sql);
            int posisi = master.getBs().Find("id_trans", nomorNotaBaru);

            master.getBs().Position = posisi;
            tampil();
            modeNew();
        }

        private void tbKodeBaju_Leave(object sender, EventArgs e)
        {
            if (tbKodeBaju.Text.Length == 7 || tbKodeBaju.Text.Length == 8)
                tbQTY.Focus();
        }

        private void tbKodeBaju_KeyUp(object sender, KeyEventArgs e)
        {
            /*if (e.KeyValue == 191)
            {
                FormCariBarang FrmCb = new FormCariBarang();

                FrmCb.ShowDialog();
                tbKodeBarang.Text = FrmCb.kodeBarang;
                FrmCb.Dispose();
            }

            if (tbKodeBarang.Text.Length == 5)
                tbQTY.Focus();*/
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

        private void tbJumlah_KeyDown(object sender, KeyEventArgs e)
        {
            DialogResult jawab;

            if (tbJumlah.Text.Length > 0)
            {
                if (e.KeyData == Keys.Enter && int.Parse(tbJumlah.Text) > 0 && int.Parse(tbQTY.Text) > 0 && int.Parse(tbHarga.Text) > 0)
                {
                    jawab = MessageBox.Show("Kamu akan memasukkan data-data tersebut ke dalam tabel, periksalah kembali data-data tersebut.\n\n\n" +
                        "ID Pegawai: " + tbIDPegawai.Text + "\n" +
                        "Nama Pegawai: " + tbNamaPegawai.Text + "\n\n" +

                        "ID Customer: " + tbIDCustomer.Text + "\n" +
                        "Nama Customer: " + tbNamaCustomer.Text + "\n" +
                        "Jenis Kelamin: " + tbJenisKelamin.Text + "\n" +
                        "Telepon: " + tbTelepon.Text + "\n" +
                        "Alamat: " + tbAlamat.Text + "\n" +
                        "Kota: " + tbKota.Text + "\n\n" +

                        "Kode Baju: " + tbKodeBaju.Text + "\n" +
                        "Nama Baju: " + tbNamaBaju.Text + "\n" +
                        "Qty.: " + tbQTY.Text + " pcs" + "\n" +
                        "Jenis: " + tbJenis.Text + "\n" +
                        "Status: " + tbStatus.Text + "\n" +
                        "Harga: Rp " + tbHarga.Text + "\n" +

                        "\n\n\nApakah kamu sudah yakin?", "Periksa Kembali! :)", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                    if (jawab == DialogResult.Yes)
                    {
                        String strSQL, id_trans, kd_baju, harga, qty;
                        id_trans = tbIDTransaksi.Text;
                        kd_baju = tbKodeBaju.Text;
                        harga = tbHarga.Text;
                        qty = tbQTY.Text;

                        strSQL = "INSERT INTO detil_transaksi (" +
                            "id_trans, kd_baju, harga, qty) " +
                            "VALUES('{0}', '{1}', '{2}', '{3}')";
                        strSQL = String.Format(strSQL, id_trans, kd_baju, harga, qty);

                        detail.eksekusiSQL(strSQL);
                        hapus();
                        total();
                    }

                    else
                    {
                        tbIDPegawai.Focus();
                    }
                }

                else if (e.KeyData == Keys.Enter && int.Parse(tbHarga.Text) <= 10000)
                {
                    jawab = MessageBox.Show("Kamu akan memasukkan data-data tersebut ke dalam tabel, periksalah kembali..\n\n\n" +
                        "ID Pegawai: " + tbIDPegawai.Text + "\n" +
                        "Nama Pegawai: " + tbNamaPegawai.Text + "\n\n" +

                        "ID Customer: " + tbIDCustomer.Text + "\n" +
                        "Nama Customer: " + tbNamaCustomer.Text + "\n" +
                        "Jenis Kelamin: " + tbJenisKelamin.Text + "\n" +
                        "Telepon: " + tbTelepon.Text + "\n" +
                        "Alamat: " + tbAlamat.Text + "\n" +
                        "Kota: " + tbKota.Text + "\n\n" +

                        "Kode Baju: " + tbKodeBaju.Text + "\n" +
                        "Nama Baju: " + tbNamaBaju.Text + "\n" +
                        "Qty.: " + tbQTY.Text + " pcs" + "\n" +
                        "Jenis: " + tbJenis.Text + "\n" +
                        "Status: " + tbStatus.Text + "\n" +
                        "Harga: Rp " + tbHarga.Text + "\n" +

                        "\n\n\nApakah kamu sudah yakin?", "Periksa Kembali! :)", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                    if (jawab == DialogResult.Yes)
                    {
                        String strSQL, id_trans, kd_baju, harga, qty;
                        id_trans = tbIDTransaksi.Text;
                        kd_baju = tbKodeBaju.Text;
                        harga = tbHarga.Text;
                        qty = tbQTY.Text;

                        strSQL = "INSERT INTO detil_transaksi (" +
                            "id_trans, kd_baju, harga, qty) " +
                            "VALUES('{0}', '{1}', '{2}', '{3}')";
                        strSQL = String.Format(strSQL, id_trans, kd_baju, harga, qty);

                        detail.eksekusiSQL(strSQL);
                        hapus();
                        total();
                    }

                    else
                        tbHarga.Focus();
                }

                else if (e.KeyData == Keys.Enter && int.Parse(tbQTY.Text) <= 0)
                {
                    MessageBox.Show("Pakaian tidak boleh memiliki kuantitas 0...", "Maaf! :(", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    tbQTY.Focus();
                }
            }
        }

        private void tbQTY_Leave(object sender, EventArgs e)
        {
            tbHarga.Focus();
        }

        private void tbQTY_Validating(object sender, CancelEventArgs e)
        {
            tbJumlah.Text = (int.Parse(tbQTY.Text) * int.Parse(tbQTY.Text)).ToString();
        }

        private void tbHarga_Validating(object sender, CancelEventArgs e)
        {
            tbJumlah.Text = (int.Parse(tbQTY.Text) * int.Parse(tbHarga.Text)).ToString();
            tbJumlah.Focus();
        }

        private void tbIDPegawai_Validating(object sender, CancelEventArgs e)
        {
            if (tbIDPegawai.Text.Length == 3)
            {
                Tabel pegawai = new Tabel("pegawai");
                String kodeCari = tbIDPegawai.Text, strSQL, idTransaksiSekarang = tbIDTransaksi.Text;
                int ketemuBaris = pegawai.getBs().Find("id_pgw", kodeCari);

                if (ketemuBaris >= 0)
                {
                    pegawai.getBs().Position = ketemuBaris;
                    tbNamaPegawai.Text = ((DataRowView)pegawai.getBs().Current).Row["nm_pgw"].ToString();

                    strSQL = "UPDATE transaksi SET id_pgw = '{0}' WHERE id_trans = '{1}'";
                    strSQL = String.Format(strSQL, tbIDPegawai.Text, idTransaksiSekarang);
                    tbIDCustomer.Focus();
                }

                else
                {
                    MessageBox.Show("Kami tidak dapat menemukan pegawai " + tbIDPegawai.Text + " yang kamu cari...", "Maaf! :(", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    strSQL = "UPDATE transaksi SET id_pgw = NULL WHERE id_trans = '{0}'";
                    strSQL = String.Format(strSQL, idTransaksiSekarang);

                    if (tbIDPegawai.Text.Length != 0)
                        tbIDPegawai.Focus();
                    else
                        tbIDCustomer.Focus();

                    tbKodeBaju.Clear();
                }

                master.eksekusiSQL(strSQL);
                ketemuBaris = master.getBs().Find("id_trans", idTransaksiSekarang);
                master.getBs().Position = ketemuBaris;
            }

            else if (tbIDPegawai.Text.Length > 0)
            {
                MessageBox.Show("Kami tidak dapat menemukan pegawai " + tbIDPegawai.Text + " yang kamu cari...", "Maaf! :(", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tbIDPegawai.Clear();
                tbIDPegawai.Focus();
            }
        }

        private void dgvDetail_KeyDown(object sender, KeyEventArgs e)
        {
            int baris = dgvDetail.SelectedCells[0].RowIndex;
            DialogResult jawab;

            if (e.KeyData == Keys.Back)
            {
                tbKodeBaju.Text = dgvDetail.Rows[baris].Cells[2].Value.ToString();
                tbNamaBaju.Text = dgvDetail.Rows[baris].Cells[3].Value.ToString();
                tbHarga.Text = dgvDetail.Rows[baris].Cells[5].Value.ToString();
                tbQTY.Text = dgvDetail.Rows[baris].Cells[6].Value.ToString();
                tbJumlah.Text = dgvDetail.Rows[baris].Cells[7].Value.ToString();
                tbJenis.Text = dgvDetail.Rows[baris].Cells[8].Value.ToString();

                tbKodeBaju.Focus();
            }

            if (e.KeyData == Keys.Delete || e.KeyData == Keys.Back)
            {
                jawab = MessageBox.Show("Apakah kamu yakin akan menghapus pakaian " + dgvDetail.Rows[baris].Cells[3].Value.ToString() + "?", "Konfirmasi! :)",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (jawab == DialogResult.Yes)
                {
                    String id_detil = dgvDetail.Rows[baris].Cells[0].Value.ToString();
                    String strSQL = "DELETE FROM detil_transaksi WHERE id_detil = " + id_detil;

                    detail.eksekusiSQL(strSQL);

                    MessageBox.Show("Baiklah! :)\nPenghapusan telah kami laksanakan...", "Informasi!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Baiklah! :)\nPenghapusan telah kami batalkan...", "Informasi!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            total();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            modeSave();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            modeUndo();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            modeEdit();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult jawab;

            jawab = MessageBox.Show("Apakah kamu yakin akan menghapus transaksi ke-" + tbIDTransaksi.Text + "?", "Konfirmasi! :)",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (jawab == DialogResult.Yes)
            {
                String id_trans = tbIDTransaksi.Text;
                String strSQL = "DELETE FROM detil_transaksi WHERE id_trans = '" + id_trans + "'";
                detail.eksekusiSQL(strSQL);

                strSQL = "DELETE FROM transaksi WHERE id_trans = '" + id_trans + "'";
                master.eksekusiSQL(strSQL);

                MessageBox.Show("Baiklah! :)\nPenghapusan telah kami laksanakan...", "Informasi!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                master.getBs().MoveLast();
                tampil();
            }

            else
            {
                MessageBox.Show("Baiklah! :)\nPenghapusan telah kami batalkan...", "Informasi!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            total();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbIDCustomer_Validating(object sender, CancelEventArgs e)
        {
            if (tbIDCustomer.Text.Length == 3)
            {
                String strSQL, idTransaksiSekarang = tbIDTransaksi.Text;
                Tabel customer = new Tabel("customer");
                int barisDitemukan = customer.getBs().Find("id_customer", tbIDCustomer.Text);

                if (barisDitemukan >= 0)
                {
                    strSQL = "UPDATE transaksi SET id_customer = '{0}' WHERE id_trans = '{1}'";
                    strSQL = String.Format(strSQL, tbIDCustomer.Text, idTransaksiSekarang);
                    tbKodeBaju.Focus();
                }

                else
                {
                    strSQL = "UPDATE transaksi SET id_customer = NULL WHERE id_trans = '{0}'";
                    strSQL = String.Format(strSQL, idTransaksiSekarang);

                    if (tbIDCustomer.Text.Length >= 0)
                        tbIDCustomer.Focus();
                    else
                        tbKodeBaju.Focus();

                    tbIDCustomer.Clear();
                }

                master.eksekusiSQL(strSQL);
                barisDitemukan = master.getBs().Find("id_trans", idTransaksiSekarang);
                master.getBs().Position = barisDitemukan;
            }

            else if (tbIDCustomer.Text.Length > 0)
            {
                MessageBox.Show("Kami tidak dapat menemukan customer " + tbIDCustomer.Text + " yang kamu cari...", "Maaf! :(", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tbIDCustomer.Clear();
                tbIDCustomer.Focus();
            }
        }
    }
}
