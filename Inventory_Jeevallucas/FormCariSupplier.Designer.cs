namespace Inventory_Jeevallucas
{
    partial class FormCariSupplier
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
            this.dgvSupplier = new System.Windows.Forms.DataGridView();
            this.lblNama = new System.Windows.Forms.Label();
            this.tbNamaSupplier = new System.Windows.Forms.TextBox();
            this.Kode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alamat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telepon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSupplier
            // 
            this.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kode,
            this.Nama,
            this.Kota,
            this.Alamat,
            this.Telepon});
            this.dgvSupplier.Location = new System.Drawing.Point(15, 39);
            this.dgvSupplier.Name = "dgvSupplier";
            this.dgvSupplier.Size = new System.Drawing.Size(360, 150);
            this.dgvSupplier.TabIndex = 0;
            this.dgvSupplier.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvSupplier_KeyDown);
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNama.Location = new System.Drawing.Point(12, 13);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(89, 13);
            this.lblNama.TabIndex = 1;
            this.lblNama.Text = "Nama Supplier";
            // 
            // tbNamaSupplier
            // 
            this.tbNamaSupplier.Location = new System.Drawing.Point(107, 10);
            this.tbNamaSupplier.Name = "tbNamaSupplier";
            this.tbNamaSupplier.Size = new System.Drawing.Size(268, 20);
            this.tbNamaSupplier.TabIndex = 2;
            this.tbNamaSupplier.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNamaSupplier_KeyDown);
            this.tbNamaSupplier.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbNamaSupplier_KeyUp);
            // 
            // Kode
            // 
            this.Kode.DataPropertyName = "kodeSupplier";
            this.Kode.HeaderText = "Kode";
            this.Kode.Name = "Kode";
            this.Kode.ReadOnly = true;
            // 
            // Nama
            // 
            this.Nama.DataPropertyName = "namaSupplier";
            this.Nama.HeaderText = "Nama";
            this.Nama.Name = "Nama";
            this.Nama.ReadOnly = true;
            // 
            // Kota
            // 
            this.Kota.DataPropertyName = "kota";
            this.Kota.HeaderText = "Kota";
            this.Kota.Name = "Kota";
            this.Kota.ReadOnly = true;
            // 
            // Alamat
            // 
            this.Alamat.DataPropertyName = "alamat";
            this.Alamat.HeaderText = "Alamat";
            this.Alamat.Name = "Alamat";
            this.Alamat.ReadOnly = true;
            this.Alamat.Visible = false;
            // 
            // Telepon
            // 
            this.Telepon.DataPropertyName = "telpon";
            this.Telepon.HeaderText = "Telepon";
            this.Telepon.Name = "Telepon";
            this.Telepon.ReadOnly = true;
            this.Telepon.Visible = false;
            // 
            // FormCariSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 201);
            this.Controls.Add(this.tbNamaSupplier);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.dgvSupplier);
            this.Name = "FormCariSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Mencari Supplier";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCariSupplier_FormClosed);
            this.Load += new System.EventHandler(this.FormCariSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSupplier;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.TextBox tbNamaSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alamat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telepon;
    }
}