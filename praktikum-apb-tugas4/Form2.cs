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

namespace praktikum_apb_tugas4
{
    public partial class Form2 : Form
    {
        DataTable dt = new DataTable();
        BindingSource bs = new BindingSource();
        private Boolean baru;
        private string kodeLama;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog" +
            "= anime; integrated security = true";

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT studio.dbo.studio_table.id_studio, studio.dbo.studio_table.name_studio\r\n" +
                "FROM dbo.anime_table INNER JOIN\r\n" +
                "studio.dbo.studio_table ON dbo.anime_table.id_anime = studio.dbo.studio_table.id_studio", con);
            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = cmd;
            da.Fill(dt);

            bs.DataSource = dt;
            dgvStudio.DataSource = bs;

            ikat();
        }

        private void modeEdit()
        {
            txtIDStudio.Enabled = true;
            txtNameStudio.Enabled = true;

            txtIDStudio.Focus();

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
            txtIDStudio.Enabled = false;
            txtNameStudio.Enabled = false;

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
            string stringSQL, idStudio, nameStudio;
            idStudio = txtIDStudio.Text;
            nameStudio = txtNameStudio.Text;

            if (baru)
            {
                stringSQL = "Anime ID: {0}\nAnime Name: {1}\n";
                stringSQL = String.Format(stringSQL, idStudio, nameStudio);
            }

            else
            {
                stringSQL = "Anime ID: {0}\nAnime Name: {1}\n";
                stringSQL = String.Format(stringSQL, idStudio, nameStudio);
            }

            MessageBox.Show("Periksa terlebih dahulu.\n\n" + stringSQL);
            modeSave();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            modeEdit();

            this.baru = false;
            this.kodeLama = txtIDStudio.Text;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            modeEdit();

            txtIDStudio.Text = "";
            txtNameStudio.Text = "";

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
                stringSQL = "Studio ID: {0}\nStudio Name: {1}\n";
                stringSQL = String.Format(stringSQL, txtIDStudio.Text,
                    txtNameStudio.Text);
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
            txtIDStudio.DataBindings.Add("Text", bs, "id_studio");
            txtNameStudio.DataBindings.Add("Text", bs, "name_studio");
        }

        private void lepas()
        {
            txtIDStudio.DataBindings.Clear();
            txtNameStudio.DataBindings.Clear();
        }
    }
}
