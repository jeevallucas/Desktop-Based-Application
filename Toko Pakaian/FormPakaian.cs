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

namespace Toko_Pakaian
{
    public partial class FormPakaian : Form
    {
        DataTable dt = new DataTable();
        BindingSource bs = new BindingSource();

        private Boolean baru;
        private String kodeLama;
        private Tabel pakaian = new Tabel("pakaian");

        public FormPakaian()
        {
            InitializeComponent();
        }

        private void FormPakaian_Load(object sender, EventArgs e)
        {
            dgvPakaian.DataSource = this.pakaian.getBs();

            modeSave();
        }

        void modeEdit()
        {
            tbKodeBaju.Enabled = true;
            tbNamaBaju.Enabled = true;
            tbStok.Enabled = true;
            tbJenis.Enabled = true;
            tbStatus.Enabled = true;
            tbHargaJual.Enabled = true;

            tbKodeBaju.Focus();

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
            tbKodeBaju.Enabled = false;
            tbNamaBaju.Enabled = false;
            tbStok.Enabled = false;
            tbJenis.Enabled = false;
            tbStatus.Enabled = false;
            tbHargaJual.Enabled = false;

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

        private void lepas()
        {
            tbKodeBaju.DataBindings.Clear();
            tbNamaBaju.DataBindings.Clear();
            tbStatus.DataBindings.Clear();
            tbJenis.DataBindings.Clear();
            tbStatus.DataBindings.Clear();
            tbHargaJual.DataBindings.Clear();
        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            this.pakaian.getBs().MoveFirst();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.pakaian.getBs().MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.pakaian.getBs().MoveNext();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.pakaian.getBs().MoveLast();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            modeEdit();

            tbKodeBaju.Text = "";
            tbNamaBaju.Text = "";
            tbStok.DataBindings.Clear();
            tbJenis.Text = "";
            tbStatus.Text = "";
            tbHargaJual.Text = "0";

            this.baru = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            modeEdit();

            this.baru = false;
            this.kodeLama = tbKodeBaju.Text;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult jawab;

            jawab = MessageBox.Show("Apakah Anda yakin menghapus data ini?",
                "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (jawab == System.Windows.Forms.DialogResult.Yes)
            {
                string stringSQL = "DELETE FROM pakaian WHERE kd_baju = '{0}'";
                stringSQL = string.Format(stringSQL, tbKodeBaju.Text);

                this.pakaian.eksekusiSQL(stringSQL);

                MessageBox.Show("Penghapusan telah dilaksanakan...", "INFORMASI");
            }

            else
                MessageBox.Show("Penghapusan dibatalkan...", "INFORMASI");
        }

        private void kirimSQL(String strSQL)
        {
            SqlConnectionStringBuilder strCon = new SqlConnectionStringBuilder();
            strCon.DataSource = ".\\SQLEXPRESS";
            strCon.InitialCatalog = "db_toko_pakaian";
            strCon.IntegratedSecurity = true;

            SqlConnection con = new SqlConnection(strCon.ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("SELECT * FROM pakaian", con);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            dt.Clear();
            da.Fill(dt);
            con.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int brs = this.pakaian.getBs().Find("kd_baju", tbKodeBaju.Text);

            String stringSQL, kodeBaju, namaBaju, stok, jenis, status, harga_jual;

            kodeBaju = tbKodeBaju.Text;
            namaBaju = tbNamaBaju.Text;
            stok = tbStok.Text;
            jenis = tbJenis.Text;
            status = tbStatus.Text;
            harga_jual = tbHargaJual.Text;

            if (baru)
            {
                stringSQL = "INSERT INTO pakaian VALUES ('{0}', '{1}', '{2}', '{3}',";
                stringSQL += "'{4}', '{5}')";
                stringSQL = string.Format(stringSQL,
                    kodeBaju, namaBaju, stok, jenis, status, harga_jual);
            }

            else
            {
                stringSQL = "UPDATE pakaian SET kd_baju = '{0}'," +
                    "nm_baju = '{1}'," +
                    "stok = '{2}'," +
                    "jenis = '{3}'," +
                    "status = '{4}'," +
                    "harga_jual = '{5}'" +
                    "WHERE kd_baju = '{6}'";
                stringSQL = string.Format(stringSQL,
                    kodeBaju, namaBaju, stok, jenis, status, harga_jual,
                    this.kodeLama);
            }

            this.pakaian.eksekusiSQL(stringSQL);
            modeSave();
        }

        private void ikat()
        {
            tbKodeBaju.DataBindings.Add("Text", pakaian.getBs(), "kd_baju");
            tbNamaBaju.DataBindings.Add("Text", pakaian.getBs(), "nm_baju");
            tbStok.DataBindings.Clear();
            tbStok.DataBindings.Add("Text", pakaian.getBs(), "stok");
            tbJenis.DataBindings.Add("Text", pakaian.getBs(), "jenis");
            tbStatus.DataBindings.Add("Text", pakaian.getBs(), "status");
            tbHargaJual.DataBindings.Add("Text", pakaian.getBs(), "harga_jual");
        }
    }
}
