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

namespace PRAK_ABD_TES_KECIL_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void isi(String nm)
        {
            pembelian_toko_besiDataSet a = new pembelian_toko_besiDataSet();
            SqlConnectionStringBuilder strCon = new SqlConnectionStringBuilder();
            strCon.DataSource = ".\\SQLEXPRESS";
            strCon.InitialCatalog = "pembelian_toko_besi";
            strCon.IntegratedSecurity = true;
            SqlConnection con = new SqlConnection(strCon.ToString());

            if (nm == "")
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM v_laporan_pembelian_detil", con);
                da.Fill(a, a.Tables[0].TableName);
            }
            else
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM v_laporan_pembelian_detil WHERE nm_bar = '" + nm + "'", con);
                da.Fill(a, a.Tables[0].TableName);
            }

            ReportDataSource rds = new ReportDataSource("dataset_v_pembelian_toko_besi", a.Tables[0]);
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
