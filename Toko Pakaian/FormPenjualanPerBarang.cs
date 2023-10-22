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
    public partial class FormPenjualanPerBarang : Form
    {
        public FormPenjualanPerBarang()
        {
            InitializeComponent();
        }

        private void FormPenjualanPerBarang_Load(object sender, EventArgs e)
        {
            this.vReportPenjualanPerBarangTableAdapter.Fill(this.db_toko_bajuDataSet.vReportPenjualanPerBarang);
        }

        public void isi(String nm)
        {
            db_toko_bajuDataSet a = new db_toko_bajuDataSet();
            SqlConnectionStringBuilder strCon = new SqlConnectionStringBuilder();
            strCon.DataSource = ".\\SQLEXPRESS";
            strCon.InitialCatalog = "db_toko_baju";
            strCon.IntegratedSecurity = true;
            SqlConnection con = new SqlConnection(strCon.ToString());
            if (nm == "")
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM vReportPenjualanPerBarang", con);
                da.Fill(a, a.Tables[0].TableName);
            }
            else
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM vReportPenjualanPerBarang where nm_baju LIKE '%" + nm + "%'", con);
                da.Fill(a, a.Tables[0].TableName);
            }

            ReportDataSource rds = new ReportDataSource("dsPenjualanPerBarang", a.Tables[0]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }
    }
}
