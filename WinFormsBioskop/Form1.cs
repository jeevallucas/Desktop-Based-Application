using System.Data;
using System.Data.SqlClient;

namespace WinFormsBioskop
{
    public partial class formFilm : Form
    {
        public formFilm()
        {
            InitializeComponent();
        }

        private void formFilm_Load(object sender, EventArgs e)
        {
            string cnn =
            "Data Source =.\\SQLEXPRESS;Database = bioskop;integrated security = true;";

            SqlConnection conn = new SqlConnection(cnn);
            SqlCommand cm = new SqlCommand("SELECT * FROM film", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cm;

            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvFilm.DataSource = dt;
        }
    }
}