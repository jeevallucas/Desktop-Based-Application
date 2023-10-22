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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        public static bool supplier = false;
        public static bool barang = false;
        public static bool nota_beli = false;
        public static string username1 = "";

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            SqlConnectionStringBuilder strCon = new SqlConnectionStringBuilder();
            strCon.DataSource = ".\\SQLEXPRESS";
            strCon.InitialCatalog = "db_inventory";
            strCon.IntegratedSecurity = true;
            SqlConnection con = new SqlConnection(strCon.ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM pengguna WHERE username = '"
                + username.Replace("'", "") + "'" + "AND password = '" + password.Replace("'", "") + "'", con);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                supplier = Boolean.Parse(dr["supplier"].ToString());
                barang = Boolean.Parse(dr["barang"].ToString());
                nota_beli = Boolean.Parse(dr["pembelian"].ToString());
                username1 = dr["username"].ToString();

                FormUtama frm = new FormUtama();
                frm.ShowDialog();

                tbUsername.Text = "";
                tbPassword.Text = "";

                tbUsername.Focus();
            }

            else
            {
                MessageBox.Show("Username atau Password salah. Silahkan memasukkan ulang.", "INFORMASI");

                tbUsername.Text = "";
                tbPassword.Text = "";
                tbUsername.Focus();
            }

            dr.Dispose();
            con.Close();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            tbUsername.Focus();
        }
    }
}
