namespace Inventory_Jeevallucas
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
            this.txtIDPengguna = new System.Windows.Forms.TextBox();
            this.lblMetodePembayaran = new System.Windows.Forms.Label();
            this.lblIDPengguna = new System.Windows.Forms.Label();
            this.txtTanggalTransaksi = new System.Windows.Forms.TextBox();
            this.txtMetodePembayaran = new System.Windows.Forms.TextBox();
            this.lblTanggalTransaksi = new System.Windows.Forms.Label();
            this.txtTransaksi = new System.Windows.Forms.TextBox();
            this.lblIDTransaksi = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnTop = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvTransaksi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaksi)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIDPengguna
            // 
            this.txtIDPengguna.Enabled = false;
            this.txtIDPengguna.Location = new System.Drawing.Point(507, 38);
            this.txtIDPengguna.Name = "txtIDPengguna";
            this.txtIDPengguna.Size = new System.Drawing.Size(100, 20);
            this.txtIDPengguna.TabIndex = 28;
            // 
            // lblMetodePembayaran
            // 
            this.lblMetodePembayaran.AutoSize = true;
            this.lblMetodePembayaran.Location = new System.Drawing.Point(384, 16);
            this.lblMetodePembayaran.Name = "lblMetodePembayaran";
            this.lblMetodePembayaran.Size = new System.Drawing.Size(105, 13);
            this.lblMetodePembayaran.TabIndex = 20;
            this.lblMetodePembayaran.Text = "Metode Pembayaran";
            // 
            // lblIDPengguna
            // 
            this.lblIDPengguna.AutoSize = true;
            this.lblIDPengguna.Location = new System.Drawing.Point(384, 41);
            this.lblIDPengguna.Name = "lblIDPengguna";
            this.lblIDPengguna.Size = new System.Drawing.Size(70, 13);
            this.lblIDPengguna.TabIndex = 19;
            this.lblIDPengguna.Text = "ID Pengguna";
            // 
            // txtTanggalTransaksi
            // 
            this.txtTanggalTransaksi.Enabled = false;
            this.txtTanggalTransaksi.Location = new System.Drawing.Point(110, 37);
            this.txtTanggalTransaksi.Name = "txtTanggalTransaksi";
            this.txtTanggalTransaksi.Size = new System.Drawing.Size(242, 20);
            this.txtTanggalTransaksi.TabIndex = 26;
            // 
            // txtMetodePembayaran
            // 
            this.txtMetodePembayaran.Enabled = false;
            this.txtMetodePembayaran.Location = new System.Drawing.Point(507, 12);
            this.txtMetodePembayaran.Name = "txtMetodePembayaran";
            this.txtMetodePembayaran.Size = new System.Drawing.Size(100, 20);
            this.txtMetodePembayaran.TabIndex = 25;
            // 
            // lblTanggalTransaksi
            // 
            this.lblTanggalTransaksi.AutoSize = true;
            this.lblTanggalTransaksi.Location = new System.Drawing.Point(13, 40);
            this.lblTanggalTransaksi.Name = "lblTanggalTransaksi";
            this.lblTanggalTransaksi.Size = new System.Drawing.Size(95, 13);
            this.lblTanggalTransaksi.TabIndex = 18;
            this.lblTanggalTransaksi.Text = "Tanggal Transaksi";
            // 
            // txtTransaksi
            // 
            this.txtTransaksi.Enabled = false;
            this.txtTransaksi.Location = new System.Drawing.Point(110, 11);
            this.txtTransaksi.Name = "txtTransaksi";
            this.txtTransaksi.Size = new System.Drawing.Size(100, 20);
            this.txtTransaksi.TabIndex = 24;
            // 
            // lblIDTransaksi
            // 
            this.lblIDTransaksi.AutoSize = true;
            this.lblIDTransaksi.Location = new System.Drawing.Point(13, 14);
            this.lblIDTransaksi.Name = "lblIDTransaksi";
            this.lblIDTransaksi.Size = new System.Drawing.Size(67, 13);
            this.lblIDTransaksi.TabIndex = 23;
            this.lblIDTransaksi.Text = "ID Transaksi";
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::Inventory_Jeevallucas.Properties.Resources.wzedit;
            this.btnEdit.Location = new System.Drawing.Point(540, 343);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(45, 45);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Enabled = false;
            this.btnUndo.Image = global::Inventory_Jeevallucas.Properties.Resources.wzundo;
            this.btnUndo.Location = new System.Drawing.Point(540, 394);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(45, 45);
            this.btnUndo.TabIndex = 16;
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Visible = false;
            // 
            // btnDel
            // 
            this.btnDel.Image = global::Inventory_Jeevallucas.Properties.Resources.wzdelete;
            this.btnDel.Location = new System.Drawing.Point(591, 343);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(45, 45);
            this.btnDel.TabIndex = 15;
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Image = global::Inventory_Jeevallucas.Properties.Resources.wzsave;
            this.btnSave.Location = new System.Drawing.Point(489, 394);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(45, 45);
            this.btnSave.TabIndex = 14;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Image = global::Inventory_Jeevallucas.Properties.Resources.wznew;
            this.btnNew.Location = new System.Drawing.Point(489, 343);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(45, 45);
            this.btnNew.TabIndex = 13;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnFind
            // 
            this.btnFind.Image = global::Inventory_Jeevallucas.Properties.Resources.wzlocate;
            this.btnFind.Location = new System.Drawing.Point(438, 343);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(45, 45);
            this.btnFind.TabIndex = 12;
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::Inventory_Jeevallucas.Properties.Resources.wzprint;
            this.btnPrint.Location = new System.Drawing.Point(387, 343);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(45, 45);
            this.btnPrint.TabIndex = 11;
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnEnd
            // 
            this.btnEnd.Image = global::Inventory_Jeevallucas.Properties.Resources.wzend;
            this.btnEnd.Location = new System.Drawing.Point(165, 394);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(45, 45);
            this.btnEnd.TabIndex = 10;
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnNext
            // 
            this.btnNext.Image = global::Inventory_Jeevallucas.Properties.Resources.wznext;
            this.btnNext.Location = new System.Drawing.Point(114, 394);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(45, 45);
            this.btnNext.TabIndex = 9;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.Image = global::Inventory_Jeevallucas.Properties.Resources.wzback;
            this.btnBack.Location = new System.Drawing.Point(63, 394);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(45, 45);
            this.btnBack.TabIndex = 8;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnTop
            // 
            this.btnTop.Image = global::Inventory_Jeevallucas.Properties.Resources.wztop1;
            this.btnTop.Location = new System.Drawing.Point(12, 394);
            this.btnTop.Name = "btnTop";
            this.btnTop.Size = new System.Drawing.Size(45, 45);
            this.btnTop.TabIndex = 7;
            this.btnTop.UseVisualStyleBackColor = true;
            this.btnTop.Click += new System.EventHandler(this.btnTop_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::Inventory_Jeevallucas.Properties.Resources.wzclose;
            this.btnClose.Location = new System.Drawing.Point(743, 394);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 45);
            this.btnClose.TabIndex = 6;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvTransaksi
            // 
            this.dgvTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransaksi.Location = new System.Drawing.Point(12, 72);
            this.dgvTransaksi.Name = "dgvTransaksi";
            this.dgvTransaksi.Size = new System.Drawing.Size(776, 265);
            this.dgvTransaksi.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvTransaksi);
            this.Controls.Add(this.txtIDPengguna);
            this.Controls.Add(this.lblMetodePembayaran);
            this.Controls.Add(this.lblIDPengguna);
            this.Controls.Add(this.txtTanggalTransaksi);
            this.Controls.Add(this.txtMetodePembayaran);
            this.Controls.Add(this.lblTanggalTransaksi);
            this.Controls.Add(this.txtTransaksi);
            this.Controls.Add(this.lblIDTransaksi);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnTop);
            this.Controls.Add(this.btnClose);
            this.Name = "Form1";
            this.Text = "Form Transaksi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaksi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtIDPengguna;
        private System.Windows.Forms.Label lblMetodePembayaran;
        private System.Windows.Forms.Label lblIDPengguna;
        private System.Windows.Forms.TextBox txtTanggalTransaksi;
        private System.Windows.Forms.TextBox txtMetodePembayaran;
        private System.Windows.Forms.Label lblTanggalTransaksi;
        private System.Windows.Forms.TextBox txtTransaksi;
        private System.Windows.Forms.Label lblIDTransaksi;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnTop;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvTransaksi;
    }
}