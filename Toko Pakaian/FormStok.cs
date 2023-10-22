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

namespace Toko_Pakaian
{
    public partial class FormStok : Form
    {
        public FormStok()
        {
            InitializeComponent();
        }

        private void FormStok_Load(object sender, EventArgs e)
        {
            this.vReportStokTableAdapter.Fill(this.db_toko_bajuDataSet1.vReportStok);

            this.reportViewer1.RefreshReport();
        }

        public void isi(String nmNamaBaju, String nmStok)
        {
            db_toko_bajuDataSet1 a = new db_toko_bajuDataSet1();
            SqlConnectionStringBuilder strCon = new SqlConnectionStringBuilder();
            strCon.DataSource = ".\\SQLEXPRESS";
            strCon.InitialCatalog = "db_toko_baju";
            strCon.IntegratedSecurity = true;
            SqlConnection con = new SqlConnection(strCon.ToString());

            if (nmNamaBaju == "" && nmStok == "")
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM vReportStok", con);
                da.Fill(a, a.Tables[0].TableName);
            }

            else if (nmNamaBaju.Length > 0)
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM vReportStok where nm_baju LIKE '%" + nmNamaBaju + "%'", con);
                da.Fill(a, a.Tables[0].TableName);
            }

            else if (nmStok.Length > 0)
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM vReportStok where stok = '" + nmStok + "'", con);
                da.Fill(a, a.Tables[0].TableName);
            }

            ReportDataSource rds = new ReportDataSource("dsStok", a.Tables[0]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }
    }
}
