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
    public partial class FormSortByDate : Form
    {
        public FormSortByDate()
        {
            InitializeComponent();
        }

        private void FormSortByDate_Load(object sender, EventArgs e)
        {
            this.vReportSortByDateTableAdapter.Fill(this.db_toko_bajuDataSet1.vReportSortByDate);

            this.reportViewer1.RefreshReport();
        }

        public void isi(String nmAwal, String nmAkhir)
        {
            db_toko_bajuDataSet1 a = new db_toko_bajuDataSet1();
            SqlConnectionStringBuilder strCon = new SqlConnectionStringBuilder();
            strCon.DataSource = ".\\SQLEXPRESS";
            strCon.InitialCatalog = "db_toko_baju";
            strCon.IntegratedSecurity = true;
            SqlConnection con = new SqlConnection(strCon.ToString());
            if (nmAwal != "" && nmAkhir != "")
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM vReportSortByDate WHERE " +
                    "tgl_trans BETWEEN (CONVERT(datetime, '" + nmAwal + "', 103)) AND (CONVERT(datetime, '" + nmAkhir + "', 103))", con);
                da.Fill(a, a.Tables[0].TableName);
            }

            /*else
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM vReportSortByDate where tgl_trans = '" + nm + "'", con);
                da.Fill(a, a.Tables[0].TableName);
            }*/


            ReportDataSource rds = new ReportDataSource("dsSortByDate", a.Tables[0]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }
    }
}
