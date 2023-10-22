using System.Data;
using System.Data.SqlClient;

namespace praktikum_apb_tugas4
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
            "= anime; integrated security = true";

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM anime_table", con);
            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = cmd;
            da.Fill(dt);

            bs.DataSource = dt;
            dgvAnime.DataSource = bs;

            ikat();
        }

        private void modeEdit()
        {
            txtIDAnime.Enabled = true;
            txtNameAnime.Enabled = true;

            txtIDAnime.Focus();

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
            txtIDAnime.Enabled = false;
            txtNameAnime.Enabled = false;

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
            string stringSQL, idAnime, nameAnime;
            idAnime = txtIDAnime.Text;
            nameAnime = txtNameAnime.Text;

            if (baru)
            {
                stringSQL = "Anime ID: {0}\nAnime Name: {1}\n";
                stringSQL = String.Format(stringSQL, idAnime, nameAnime);
            }

            else
            {
                stringSQL = "Anime ID: {0}\nAnime Name: {1}\n";
                stringSQL = String.Format(stringSQL, idAnime, nameAnime);
            }

            MessageBox.Show("Periksa terlebih dahulu.\n\n" + stringSQL);
            modeSave();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            modeEdit();

            this.baru = false;
            this.kodeLama = txtIDAnime.Text;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            modeEdit();

            txtIDAnime.Text = "";
            txtNameAnime.Text = "";

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
                stringSQL = "Anime ID: {0}\nAnime Name: {1}\n";
                stringSQL = String.Format(stringSQL, txtIDAnime.Text,
                    txtNameAnime.Text);
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
            txtIDAnime.DataBindings.Add("Text", bs, "id_anime");
            txtNameAnime.DataBindings.Add("Text", bs, "name_anime");
        }

        private void lepas()
        {
            txtIDAnime.DataBindings.Clear();
            txtNameAnime.DataBindings.Clear();
        }
    }
}