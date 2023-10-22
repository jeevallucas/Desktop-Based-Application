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
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        BindingSource bs = new BindingSource();
        private Boolean baru;
        private string kodeLama;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog" +
            "= db_cafe; integrated security = true";

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM transaksi", con);
            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = cmd;
            da.Fill(dt);

            bs.DataSource = dt;
            dgvTransaksi.DataSource = bs;

            ikat();
        }

        private void modeEdit()
        {
            txtTransaksi.Enabled = true;
            txtTanggalTransaksi.Enabled = true;
            txtMetodePembayaran.Enabled = true;
            txtIDPengguna.Enabled = true;

            txtTransaksi.Focus();

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

        private void modeSave()
        {
            txtTransaksi.Enabled = false;
            txtTanggalTransaksi.Enabled = false;
            txtMetodePembayaran.Enabled = false;
            txtIDPengguna.Enabled = false;

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
            bs.MoveFirst();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            bs.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            bs.MoveLast();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string stringSQL, idTransaksi, tanggalTransaksi, metodePembayaran, idPengguna;
            idTransaksi = txtTransaksi.Text;
            tanggalTransaksi = txtTanggalTransaksi.Text;
            metodePembayaran = txtMetodePembayaran.Text;
            idPengguna = txtIDPengguna.Text;

            if (baru)
            {
                stringSQL = "INSERT INTO barang VALUES ('{0}', '{1}', '{2}', '{3}',\";\r\n                stringSQL += \"'{4}', '{5}'";
                stringSQL = String.Format(stringSQL, idTransaksi);
            }

            else
            {
                stringSQL = "ID Transaksi: {0}";
                stringSQL = String.Format(stringSQL, idTransaksi);
            }

            MessageBox.Show("Periksa terlebih dahulu.\n\n" + stringSQL);
            modeSave();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            modeEdit();

            this.baru = false;
            this.kodeLama = txtTransaksi.Text;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            modeEdit();

            txtTransaksi.Text = "";
            txtTanggalTransaksi.Text = "";
            txtMetodePembayaran.Text = "";
            txtIDPengguna.Text = "";

            this.baru = true;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult jawab;
            string stringSQL;

            jawab = MessageBox.Show("Apakah Anda yakin menghapus data ini?",
                "Konfirmasi.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (jawab == System.Windows.Forms.DialogResult.Yes)
            {
                stringSQL = "ID Transaksi: {0}";
                stringSQL = String.Format(stringSQL, txtTransaksi);
                MessageBox.Show("Periksa terlebih dahulu.\n\n" + stringSQL);
                MessageBox.Show("Penghapusan telah dilakukan...");
            }

            else
            {
                MessageBox.Show("Penghapusan telah dibatalkan...");
            }
        }

        private void ikat()
        {
            txtTransaksi.DataBindings.Add("Text", bs, "id_transaksi");
            txtTanggalTransaksi.DataBindings.Add("Text", bs, "tanggal_transaksi");
            txtMetodePembayaran.DataBindings.Add("Text", bs, "metode_pembayaran");
            txtIDPengguna.DataBindings.Add("Text", bs, "id_pengguna");
        }

        private void lepas()
        {
            txtTransaksi.DataBindings.Clear();
            txtTanggalTransaksi.DataBindings.Clear();
            txtMetodePembayaran.DataBindings.Clear();
            txtIDPengguna.DataBindings.Clear();
        }
    }
}
