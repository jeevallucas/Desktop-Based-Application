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

namespace WinFormsBioskop
{
    public partial class formNavigasi : Form
    {
        public formNavigasi()
        {
            InitializeComponent();
        }

        private void formNavigasi_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder con = new SqlConnectionStringBuilder();
            con.DataSource = ".\\SQLEXPRESS";
            con.InitialCatalog = "bioskop";
            con.IntegratedSecurity = true;

            SqlConnection conn = new SqlConnection(con.ToString());
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM film", conn);
            SqlDataReader dr = cmd.ExecuteReader();

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);

            conn.Close();

            BindingSource bs = new BindingSource();
            bs.DataSource = dt;

            txtKode.DataBindings.Add("Text", bs, "kd_film");
            txtKode.DataBindings.Add("Text", bs, "nm_film");
            txtKode.DataBindings.Add("Text", bs, "genre");
            txtKode.DataBindings.Add("Text", bs, "durasi");
            txtKode.DataBindings.Add("Text", bs, "rating");

            dataGridView1.DataSource = dt;
        }
    }
}
