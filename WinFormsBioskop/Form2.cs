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
    public partial class formCetakData : Form
    {
        public formCetakData()
        {
            InitializeComponent();
        }

        private void formCetakData_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder con = new SqlConnectionStringBuilder();
            con.DataSource = ".\\SQLEXPRESS";
            con.InitialCatalog = "bioskop";
            con.IntegratedSecurity = true;

            SqlConnection conn = new SqlConnection(con.ToString());
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM film", conn);
            SqlDataReader dr = cmd.ExecuteReader();

            if(dr.HasRows)
            {
                rtbFilm.Text += "Field table film: " + dr.FieldCount + " films\n\n";

                while(dr.Read())
                {
                    rtbFilm.Text += dr.GetValue(0) + "\t" + dr.GetValue(1) + "\n";
                }
            }
            
            else
            {
                rtbFilm.Text = "No rows found.";
                dr.Close();
                conn.Close();
            }
        }
    }
}
