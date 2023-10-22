namespace PRAK_ABD_TES_KECIL_3
{
    partial class Form1
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
            this.pembelian_toko_besiDataSet = new PRAK_ABD_TES_KECIL_3.pembelian_toko_besiDataSet();
            this.pembeliantokobesiDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_laporan_pembelian_detilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vlaporanpembeliandetilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_laporan_pembelian_detilTableAdapter = new PRAK_ABD_TES_KECIL_3.pembelian_toko_besiDataSetTableAdapters.v_laporan_pembelian_detilTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pembelian_toko_besiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pembeliantokobesiDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_laporan_pembelian_detilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlaporanpembeliandetilBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "dataset_v_pembelian_toko_besi";
            reportDataSource1.Value = this.vlaporanpembeliandetilBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PRAK_ABD_TES_KECIL_3.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-6, -1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(805, 453);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // pembelian_toko_besiDataSet
            // 
            this.pembelian_toko_besiDataSet.DataSetName = "pembelian_toko_besiDataSet";
            this.pembelian_toko_besiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pembeliantokobesiDataSetBindingSource
            // 
            this.pembeliantokobesiDataSetBindingSource.DataSource = this.pembelian_toko_besiDataSet;
            this.pembeliantokobesiDataSetBindingSource.Position = 0;
            // 
            // v_laporan_pembelian_detilBindingSource
            // 
            this.v_laporan_pembelian_detilBindingSource.DataMember = "v_laporan_pembelian_detil";
            this.v_laporan_pembelian_detilBindingSource.DataSource = this.pembelian_toko_besiDataSet;
            // 
            // vlaporanpembeliandetilBindingSource
            // 
            this.vlaporanpembeliandetilBindingSource.DataMember = "v_laporan_pembelian_detil";
            this.vlaporanpembeliandetilBindingSource.DataSource = this.pembeliantokobesiDataSetBindingSource;
            // 
            // v_laporan_pembelian_detilTableAdapter
            // 
            this.v_laporan_pembelian_detilTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pembelian_toko_besiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pembeliantokobesiDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_laporan_pembelian_detilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlaporanpembeliandetilBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource pembeliantokobesiDataSetBindingSource;
        private pembelian_toko_besiDataSet pembelian_toko_besiDataSet;
        private System.Windows.Forms.BindingSource v_laporan_pembelian_detilBindingSource;
        private System.Windows.Forms.BindingSource vlaporanpembeliandetilBindingSource;
        private pembelian_toko_besiDataSetTableAdapters.v_laporan_pembelian_detilTableAdapter v_laporan_pembelian_detilTableAdapter;
    }
}

