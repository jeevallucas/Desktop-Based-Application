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
    public partial class formBarang : Form
    {
        DataTable dt = new DataTable();
        BindingSource bs = new BindingSource();
        private Boolean baru;
        private string kodeLama;
        private Tabel barang = new Tabel("barang");

        public formBarang()
        {
            InitializeComponent();
        }

        private void formBarang_Load(object sender, EventArgs e)
        {
            dgvBarang.DataSource = this.barang.getBs();
            modeSave();
        }

        void modeEdit()
        {
            txtKodeBarang.Enabled = true;
            txtNamaBarang.Enabled = true;
            txtHargaBeli.Enabled = true;
            txtHargaJual.Enabled = true;
            txtStok.Enabled = true;
            txtSatuan.Enabled = true;

            txtKodeBarang.Focus();

            btnTop.Enabled = false;
            btnBack.Enabled = false;
            btnNext.Enabled = false;
            btnEnd.Enabled = false;
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
            txtKodeBarang.Enabled = false;
            txtNamaBarang.Enabled = false;
            txtHargaBeli.Enabled = false;
            txtHargaJual.Enabled = false;
            txtStok.Enabled = false;
            txtSatuan.Enabled = false;

            btnTop.Enabled = true;
            btnBack.Enabled = true;
            btnNext.Enabled = true;
            btnEnd.Enabled = true;
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
            this.barang.getBs().MoveFirst();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.barang.getBs().MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.barang.getBs().MoveNext();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.barang.getBs().MoveLast();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int brs = this.barang.getBs().Find("kodeBarang", txtKodeBarang.Text);

            string stringSQL, kode, nama, beli, jual, stok, satuan;
            kode = txtKodeBarang.Text;
            nama = txtNamaBarang.Text;
            beli = txtHargaBeli.Text;
            jual = txtHargaJual.Text;
            stok = txtStok.Text;
            satuan = txtSatuan.Text;

            if (baru)
            {
                stringSQL = "INSERT INTO barang VALUES ('{0}', '{1}', '{2}', '{3}',";
                stringSQL += "'{4}', '{5}')";
                stringSQL = string.Format(stringSQL, kode, nama, beli, jual,
                    stok, satuan);
            }

            else
            {
                stringSQL = "UPDATE barang SET kodeBarang = '{0}', nama = '{1}', ";
                stringSQL += "hargaBeli = '{2}', hargaJual = '{3}', stok = '{4}', ";
                stringSQL += "satuan = '{5}' WHERE kodeBarang = '{6}'";
                stringSQL = string.Format(stringSQL, kode, nama, beli, jual,
                    stok, satuan, this.kodeLama);
            }

            /*kirimSQL(stringSQL);*/
            this.barang.eksekusiSQL(stringSQL);
            
            modeSave();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            modeEdit();

            this.baru = false;
            this.kodeLama = txtKodeBarang.Text;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            modeEdit();

            txtKodeBarang.Text = "";
            txtNamaBarang.Text = "";
            txtHargaBeli.Text = "0";
            txtHargaJual.Text = "0";
            txtStok.Text = "0";
            txtSatuan.Text = "Exemplar";

            this.baru = true;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult jawab;

            jawab = MessageBox.Show("Apakah Anda yakin menghapus data ini?",
                "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(jawab == System.Windows.Forms.DialogResult.Yes)
            {
                string stringSQL = "DELETE FROM barang WHERE kodeBarang = '{0}'";
                stringSQL = string.Format(stringSQL, txtKodeBarang.Text);
                MessageBox.Show("Periksa terlebih dahulu: " + stringSQL);

                this.barang.eksekusiSQL(stringSQL);

                MessageBox.Show("Penghapusan telah dilaksanakan...");
            }

            else
            {
                MessageBox.Show("Penghapusan dibatalkan...");
            }
        }

        private void ikat()
        {
            txtKodeBarang.DataBindings.Add("Text", barang.getBs(), "kodeBarang");
            txtNamaBarang.DataBindings.Add("Text", barang.getBs(), "nama");
            txtHargaBeli.DataBindings.Add("Text", barang.getBs(), "hargaBeli");
            txtHargaJual.DataBindings.Add("Text", barang.getBs(), "hargaJual");
            txtStok.DataBindings.Add("Text", barang.getBs(), "stok");
            txtSatuan.DataBindings.Add("Text", barang.getBs(), "satuan");
        }

        private void lepas()
        {
            txtKodeBarang.DataBindings.Clear();
            txtNamaBarang.DataBindings.Clear();
            txtHargaBeli.DataBindings.Clear();
            txtHargaJual.DataBindings.Clear();
            txtStok.DataBindings.Clear();
            txtSatuan.DataBindings.Clear();
        }

        private void kirimSQL(string strSQL)
        {
            SqlConnectionStringBuilder strCon = new SqlConnectionStringBuilder();
            strCon.DataSource = ".\\SQLEXPRESS";
            strCon.InitialCatalog = "db_inventory";
            strCon.IntegratedSecurity = true;

            SqlConnection con = new SqlConnection(strCon.ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("SELECT * FROM barang", con);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            dt.Clear();
            da.Fill(dt);
            con.Close();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            modeSave();
        }
    }
}
