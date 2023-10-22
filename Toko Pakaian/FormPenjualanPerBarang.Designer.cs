namespace Toko_Pakaian
{
    partial class FormPenjualanPerBarang
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.db_toko_bajuDataSet = new Toko_Pakaian.db_toko_bajuDataSet();
            this.vReportPenjualanPerBarangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vReportPenjualanPerBarangTableAdapter = new Toko_Pakaian.db_toko_bajuDataSetTableAdapters.vReportPenjualanPerBarangTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.db_toko_bajuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vReportPenjualanPerBarangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsPenjualanPerBarang";
            reportDataSource1.Value = this.vReportPenjualanPerBarangBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Toko_Pakaian.ReportPenjualan.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // db_toko_bajuDataSet
            // 
            this.db_toko_bajuDataSet.DataSetName = "db_toko_bajuDataSet";
            this.db_toko_bajuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vReportPenjualanPerBarangBindingSource
            // 
            this.vReportPenjualanPerBarangBindingSource.DataMember = "vReportPenjualanPerBarang";
            this.vReportPenjualanPerBarangBindingSource.DataSource = this.db_toko_bajuDataSet;
            // 
            // vReportPenjualanPerBarangTableAdapter
            // 
            this.vReportPenjualanPerBarangTableAdapter.ClearBeforeFill = true;
            // 
            // FormPenjualanPerBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormPenjualanPerBarang";
            this.Text = "Form Penjualan Per Barang";
            this.Load += new System.EventHandler(this.FormPenjualanPerBarang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_toko_bajuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vReportPenjualanPerBarangBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private db_toko_bajuDataSet db_toko_bajuDataSet;
        private System.Windows.Forms.BindingSource vReportPenjualanPerBarangBindingSource;
        private db_toko_bajuDataSetTableAdapters.vReportPenjualanPerBarangTableAdapter vReportPenjualanPerBarangTableAdapter;
    }
}