using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Jeevallucas
{
    internal class Tabel
    {
        private String namaTabel;
        private DataTable dt;
        private BindingSource bs;

        public Tabel(String namaTabel)
        {
            this.namaTabel = namaTabel;
            this.dt = new DataTable();
            this.bs = new BindingSource();
            isiDataTable();
            this.bs.DataSource = this.dt;
        }

        private void isiDataTable()
        {
            SqlConnectionStringBuilder strCon = new SqlConnectionStringBuilder();
            strCon.DataSource = ".\\SQLEXPRESS";
            strCon.InitialCatalog = "db_inventory";
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
            strCon.InitialCatalog = "db_inventory";
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

        public String eksekusiSQL_getID(String stringSQL)
        {
            SqlConnectionStringBuilder strCon = new SqlConnectionStringBuilder();
            strCon.DataSource = ".\\SQLEXPRESS";
            strCon.InitialCatalog = "db_inventory";
            strCon.IntegratedSecurity = true;

            SqlConnection con = new SqlConnection(strCon.ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand(stringSQL, con);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("SELECT @@IDENTITY", con);

            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();

            String nomorNotaBaru = dr.GetValue(0).ToString();

            con.Close();
            this.isiDataTable();

            return nomorNotaBaru;
        }
    }
}
