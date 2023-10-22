using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Jeevallucas
{
    public partial class formSupplier : Form
    {
        private Boolean baru;
        private string kodeLama;
        private Tabel supplier = new Tabel("supplier");

        public formSupplier()
        {
            InitializeComponent();
        }

        private void formSupplier_Load(object sender, EventArgs e)
        {
            dgvSupplier.DataSource = supplier.getBs();
            ikat();
        }

        void modeEdit()
        {
            txtKodeSupplier.Enabled = true;
            txtNamaSupplier.Enabled = true;
            txtAlamat.Enabled = true;
            txtKota.Enabled = true;
            txtTelpon.Enabled = true;

            txtKodeSupplier.Focus();

            btnTop.Enabled = false;
            btnBack.Enabled = false;
            btnNext.Enabled = false;
            btnEnd.Enabled = false;
            btnPrint.Enabled = false;
            btnFind.Enabled = false;
            btnNew.Enabled = false;
            btnEdit.Enabled = false;

            btnSave.Enabled = true;
            btnUndo.Enabled = true;

            btnDel.Enabled = false;
            btnClose.Enabled = false;

            btnSave.Visible = true;
            btnUndo.Visible = true;

            lepas();
        }

        void modeSave()
        {
            txtKodeSupplier.Enabled = false;
            txtNamaSupplier.Enabled = false;
            txtAlamat.Enabled = false;
            txtKota.Enabled = false;
            txtTelpon.Enabled = false;

            btnTop.Enabled = true;
            btnBack.Enabled = true;
            btnNext.Enabled = true;
            btnEnd.Enabled = true;
            btnPrint.Enabled = true;
            btnFind.Enabled = true;
            btnNew.Enabled = true;
            btnEdit.Enabled = true;

            btnSave.Enabled = false;
            btnUndo.Enabled = false;

            btnDel.Enabled = true;
            btnClose.Enabled = true;

            btnSave.Visible = false;
            btnUndo.Visible = false;

            ikat();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            this.supplier.getBs().MoveFirst();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.supplier.getBs().MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.supplier.getBs().MoveNext();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.supplier.getBs().MoveLast();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string stringSQL, kode, nama, alamat, kota, telpon;
            kode = txtKodeSupplier.Text;
            nama = txtNamaSupplier.Text;
            alamat = txtAlamat.Text;
            kota = txtKota.Text;
            telpon = txtTelpon.Text;

            if (baru)
            {
                stringSQL = "INSERT INTO supplier VALUES ('{0}', '{1}', '{2}', '{3}',";
                stringSQL += "'{4}')";
                stringSQL = string.Format(stringSQL, kode, nama, alamat, kota,
                    telpon);
            }

            else
            {
                stringSQL = "UPDATE supplier SET kodeSupplier = '{0}', namaSupplier = '{1}', ";
                stringSQL += "alamat = '{2}', kota = '{3}', telpon = '{4}'";
                stringSQL += "WHERE kodeSupplier = '{5}'";
                stringSQL = string.Format(stringSQL, kode, nama, alamat, kota,
                    telpon, this.kodeLama);
            }

            MessageBox.Show("Periksa terlebih dahulu: " + stringSQL);

            this.supplier.eksekusiSQL(stringSQL);
            modeSave();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            modeEdit();

            this.baru = false;
            this.kodeLama = txtKodeSupplier.Text;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            modeEdit();

            txtKodeSupplier.Text = "";
            txtNamaSupplier.Text = "";
            txtAlamat.Text = "0";
            txtKota.Text = "0";
            txtTelpon.Text = "0";

            this.baru = true;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            String stringSQL = "DELETE FROM supplier WHERE kodeSupplier='{0}'";
            stringSQL = string.Format(stringSQL, txtKodeSupplier.Text);
            DialogResult jawab = MessageBox.Show("Apakah Anda yakin menghapus data ini?", "konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (jawab == System.Windows.Forms.DialogResult.Yes)
            {
                this.supplier.eksekusiSQL(stringSQL);
                MessageBox.Show("Data sudah dihapus");

            }
            else
            {
                MessageBox.Show("Penghapusan dibatalkan"); //<-- feedback
            }
        }

        private void ikat()
        {
            txtKodeSupplier.DataBindings.Add("Text", supplier.getBs(), "kodeSupplier");
            txtNamaSupplier.DataBindings.Add("Text", supplier.getBs(), "namaSupplier");
            txtAlamat.DataBindings.Add("Text", supplier.getBs(), "alamat");
            txtKota.DataBindings.Add("Text", supplier.getBs(), "kota");
            txtTelpon.DataBindings.Add("Text", supplier.getBs(), "telpon");
        }

        private void lepas()
        {
            txtKodeSupplier.DataBindings.Clear();
            txtNamaSupplier.DataBindings.Clear();
            txtAlamat.DataBindings.Clear();
            txtKota.DataBindings.Clear();
            txtTelpon.DataBindings.Clear();
        }
    }
}
