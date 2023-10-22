using Microsoft.Reporting.WinForms;
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

namespace WindowsFormsCafe
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        public void isi( String nm)
        {
            db_cafeDataSet a = new db_cafeDataSet();
            SqlConnectionStringBuilder strCon = new SqlConnectionStringBuilder();
            strCon.DataSource = ".\\SQLEXPRESS";
            strCon.InitialCatalog = "pembelian_toko_besi";
            strCon.IntegratedSecurity = true;
            SqlConnection con = new SqlConnection(strCon.ToString());
            if(nm == "")
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM v_laporan_pembelian_detil", con);
                da.Fill(a, a.Tables[0].TableName);
            }
            else
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM v_laporan_pembelian_detil WHERE nm_bar ='" + nm + "'", con);
                da.Fill(a, a.Tables[0].TableName);
            }
           
            
            ReportDataSource rds = new ReportDataSource("v_laporan_pembelian_detil", a.Tables[0]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
