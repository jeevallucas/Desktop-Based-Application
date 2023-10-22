namespace Toko_Pakaian
{
    partial class FormSortByDate
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.vReportSortByDateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_toko_bajuDataSet1 = new Toko_Pakaian.db_toko_bajuDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.vReportSortByDateTableAdapter = new Toko_Pakaian.db_toko_bajuDataSet1TableAdapters.vReportSortByDateTableAdapter();
            this.db_toko_bajuDataSet2 = new Toko_Pakaian.db_toko_bajuDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.vReportSortByDateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_toko_bajuDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_toko_bajuDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // vReportSortByDateBindingSource
            // 
            this.vReportSortByDateBindingSource.DataMember = "vReportSortByDate";
            this.vReportSortByDateBindingSource.DataSource = this.db_toko_bajuDataSet1;
            // 
            // db_toko_bajuDataSet1
            // 
            this.db_toko_bajuDataSet1.DataSetName = "db_toko_bajuDataSet1";
            this.db_toko_bajuDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsSortByDate";
            reportDataSource1.Value = this.vReportSortByDateBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Toko_Pakaian.ReportSortByDate.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // vReportSortByDateTableAdapter
            // 
            this.vReportSortByDateTableAdapter.ClearBeforeFill = true;
            // 
            // db_toko_bajuDataSet2
            // 
            this.db_toko_bajuDataSet2.DataSetName = "db_toko_bajuDataSet";
            this.db_toko_bajuDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormSortByDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormSortByDate";
            this.Text = "Form Sort By Date";
            this.Load += new System.EventHandler(this.FormSortByDate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vReportSortByDateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_toko_bajuDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_toko_bajuDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private db_toko_bajuDataSet1 db_toko_bajuDataSet1;
        private System.Windows.Forms.BindingSource vReportSortByDateBindingSource;
        private db_toko_bajuDataSet1TableAdapters.vReportSortByDateTableAdapter vReportSortByDateTableAdapter;
        private db_toko_bajuDataSet db_toko_bajuDataSet2;
    }
}