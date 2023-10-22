using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCafe
{
    public class Tabel
    {
        private String namaTabel;
        private DataTable dt;
        private BindingSource bs;
        public Tabel(String namaTabel)
        {
            this.namaTabel = namaTabel;
            this.dt = new DataTable();
            this.bs = new BindingSource();
            this.bs.DataSource = this.dt;
            this.isiDataTable();
        }
        private void isiDataTable()
        {
            SqlConnectionStringBuilder strCon = new SqlConnectionStringBuilder();
            strCon.DataSource = ".\\SQLEXPRESS";
            strCon.InitialCatalog = "pembelian_toko_besi";
            strCon.IntegratedSecurity = true;
            SqlConnection con = new SqlConnection(strCon.ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM " + this.namaTabel, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            this.dt.Clear(); //kosongkan dulu
            da.Fill(this.dt);
            con.Close();
        }
        public void eksekusiSQL(String stringSQL)
        {
            SqlConnectionStringBuilder strCon = new SqlConnectionStringBuilder();
            strCon.DataSource = ".\\SQLEXPRESS";
            strCon.InitialCatalog = "pembelian_toko_besi";
            strCon.IntegratedSecurity = true;
            SqlConnection con = new SqlConnection(strCon.ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand(stringSQL, con);
            cmd.ExecuteNonQuery();
            con.Close();
            this.isiDataTable();
        }
        public BindingSource getBs()
        {
            return this.bs;
        }
    }
}
