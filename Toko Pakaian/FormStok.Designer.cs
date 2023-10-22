namespace Toko_Pakaian
{
    partial class FormStok
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.db_toko_bajuDataSet1 = new Toko_Pakaian.db_toko_bajuDataSet1();
            this.vReportStokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vReportStokTableAdapter = new Toko_Pakaian.db_toko_bajuDataSet1TableAdapters.vReportStokTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.db_toko_bajuDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vReportStokBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "dsStok";
            reportDataSource3.Value = this.vReportStokBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Toko_Pakaian.ReportStok.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // db_toko_bajuDataSet1
            // 
            this.db_toko_bajuDataSet1.DataSetName = "db_toko_bajuDataSet1";
            this.db_toko_bajuDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vReportStokBindingSource
            // 
            this.vReportStokBindingSource.DataMember = "vReportStok";
            this.vReportStokBindingSource.DataSource = this.db_toko_bajuDataSet1;
            // 
            // vReportStokTableAdapter
            // 
            this.vReportStokTableAdapter.ClearBeforeFill = true;
            // 
            // FormStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormStok";
            this.Text = "FormStok";
            this.Load += new System.EventHandler(this.FormStok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_toko_bajuDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vReportStokBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private db_toko_bajuDataSet1 db_toko_bajuDataSet1;
        private System.Windows.Forms.BindingSource vReportStokBindingSource;
        private db_toko_bajuDataSet1TableAdapters.vReportStokTableAdapter vReportStokTableAdapter;
    }
}