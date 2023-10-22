namespace Toko_Pakaian
{
    partial class FormPakaian
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPakaian = new System.Windows.Forms.DataGridView();
            this.KodeBaju = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jenis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnTop = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblKodeBaju = new System.Windows.Forms.Label();
            this.lblNamaBaju = new System.Windows.Forms.Label();
            this.lblStok = new System.Windows.Forms.Label();
            this.lblJenis = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblHargaJual = new System.Windows.Forms.Label();
            this.tbKodeBaju = new System.Windows.Forms.TextBox();
            this.tbNamaBaju = new System.Windows.Forms.TextBox();
            this.tbJenis = new System.Windows.Forms.TextBox();
            this.tbStok = new System.Windows.Forms.TextBox();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.tbHargaJual = new System.Windows.Forms.TextBox();
            this.lblRp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPakaian)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPakaian
            // 
            this.dgvPakaian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPakaian.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KodeBaju,
            this.Nama,
            this.Stok,
            this.Jenis,
            this.Status,
            this.Harga});
            this.dgvPakaian.Location = new System.Drawing.Point(12, 111);
            this.dgvPakaian.Name = "dgvPakaian";
            this.dgvPakaian.Size = new System.Drawing.Size(775, 225);
            this.dgvPakaian.TabIndex = 15;
            // 
            // KodeBaju
            // 
            this.KodeBaju.DataPropertyName = "kd_baju";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.KodeBaju.DefaultCellStyle = dataGridViewCellStyle13;
            this.KodeBaju.HeaderText = "Kode";
            this.KodeBaju.Name = "KodeBaju";
            this.KodeBaju.Width = 75;
            // 
            // Nama
            // 
            this.Nama.DataPropertyName = "nm_baju";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Nama.DefaultCellStyle = dataGridViewCellStyle14;
            this.Nama.HeaderText = "Nama";
            this.Nama.Name = "Nama";
            this.Nama.Width = 310;
            // 
            // Stok
            // 
            this.Stok.DataPropertyName = "stok";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Stok.DefaultCellStyle = dataGridViewCellStyle15;
            this.Stok.HeaderText = "Stok";
            this.Stok.Name = "Stok";
            this.Stok.Width = 50;
            // 
            // Jenis
            // 
            this.Jenis.DataPropertyName = "jenis";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Jenis.DefaultCellStyle = dataGridViewCellStyle16;
            this.Jenis.HeaderText = "Jenis";
            this.Jenis.Name = "Jenis";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "status";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Status.DefaultCellStyle = dataGridViewCellStyle17;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.Width = 75;
            // 
            // Harga
            // 
            this.Harga.DataPropertyName = "harga_jual";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle18.Format = "N0";
            dataGridViewCellStyle18.NullValue = null;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Harga.DefaultCellStyle = dataGridViewCellStyle18;
            this.Harga.HeaderText = "Harga";
            this.Harga.Name = "Harga";
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::Toko_Pakaian.Properties.Resources.wzedit;
            this.btnEdit.Location = new System.Drawing.Point(539, 342);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(45, 45);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Enabled = false;
            this.btnUndo.Image = global::Toko_Pakaian.Properties.Resources.wzundo;
            this.btnUndo.Location = new System.Drawing.Point(539, 393);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(45, 45);
            this.btnUndo.TabIndex = 5;
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Visible = false;
            // 
            // btnDel
            // 
            this.btnDel.Image = global::Toko_Pakaian.Properties.Resources.wzdelete;
            this.btnDel.Location = new System.Drawing.Point(590, 342);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(45, 45);
            this.btnDel.TabIndex = 6;
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Image = global::Toko_Pakaian.Properties.Resources.wzsave;
            this.btnSave.Location = new System.Drawing.Point(488, 393);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(45, 45);
            this.btnSave.TabIndex = 7;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Image = global::Toko_Pakaian.Properties.Resources.wznew;
            this.btnNew.Location = new System.Drawing.Point(488, 342);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(45, 45);
            this.btnNew.TabIndex = 8;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnFind
            // 
            this.btnFind.Image = global::Toko_Pakaian.Properties.Resources.wzlocate;
            this.btnFind.Location = new System.Drawing.Point(437, 342);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(45, 45);
            this.btnFind.TabIndex = 9;
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // btnEnd
            // 
            this.btnEnd.Image = global::Toko_Pakaian.Properties.Resources.wzend;
            this.btnEnd.Location = new System.Drawing.Point(164, 393);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(45, 45);
            this.btnEnd.TabIndex = 11;
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnNext
            // 
            this.btnNext.Image = global::Toko_Pakaian.Properties.Resources.wznext;
            this.btnNext.Location = new System.Drawing.Point(113, 393);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(45, 45);
            this.btnNext.TabIndex = 12;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.Image = global::Toko_Pakaian.Properties.Resources.wzback;
            this.btnBack.Location = new System.Drawing.Point(62, 393);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(45, 45);
            this.btnBack.TabIndex = 13;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnTop
            // 
            this.btnTop.Image = global::Toko_Pakaian.Properties.Resources.wztop;
            this.btnTop.Location = new System.Drawing.Point(11, 393);
            this.btnTop.Name = "btnTop";
            this.btnTop.Size = new System.Drawing.Size(45, 45);
            this.btnTop.TabIndex = 14;
            this.btnTop.UseVisualStyleBackColor = true;
            this.btnTop.Click += new System.EventHandler(this.btnTop_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::Toko_Pakaian.Properties.Resources.wzclose;
            this.btnClose.Location = new System.Drawing.Point(742, 393);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 45);
            this.btnClose.TabIndex = 3;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblKodeBaju
            // 
            this.lblKodeBaju.AutoSize = true;
            this.lblKodeBaju.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKodeBaju.Location = new System.Drawing.Point(12, 13);
            this.lblKodeBaju.Name = "lblKodeBaju";
            this.lblKodeBaju.Size = new System.Drawing.Size(80, 13);
            this.lblKodeBaju.TabIndex = 16;
            this.lblKodeBaju.Text = "KODE BAJU:";
            // 
            // lblNamaBaju
            // 
            this.lblNamaBaju.AutoSize = true;
            this.lblNamaBaju.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamaBaju.Location = new System.Drawing.Point(12, 53);
            this.lblNamaBaju.Name = "lblNamaBaju";
            this.lblNamaBaju.Size = new System.Drawing.Size(35, 13);
            this.lblNamaBaju.TabIndex = 17;
            this.lblNamaBaju.Text = "Nama";
            // 
            // lblStok
            // 
            this.lblStok.AutoSize = true;
            this.lblStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStok.Location = new System.Drawing.Point(421, 13);
            this.lblStok.Name = "lblStok";
            this.lblStok.Size = new System.Drawing.Size(37, 13);
            this.lblStok.TabIndex = 18;
            this.lblStok.Text = "Stok:";
            // 
            // lblJenis
            // 
            this.lblJenis.AutoSize = true;
            this.lblJenis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJenis.Location = new System.Drawing.Point(421, 53);
            this.lblJenis.Name = "lblJenis";
            this.lblJenis.Size = new System.Drawing.Size(31, 13);
            this.lblJenis.TabIndex = 19;
            this.lblJenis.Text = "Jenis";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(276, 12);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(47, 13);
            this.lblStatus.TabIndex = 20;
            this.lblStatus.Text = "Status:";
            // 
            // lblHargaJual
            // 
            this.lblHargaJual.AutoSize = true;
            this.lblHargaJual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHargaJual.Location = new System.Drawing.Point(622, 53);
            this.lblHargaJual.Name = "lblHargaJual";
            this.lblHargaJual.Size = new System.Drawing.Size(41, 13);
            this.lblHargaJual.TabIndex = 21;
            this.lblHargaJual.Text = "Harga";
            // 
            // tbKodeBaju
            // 
            this.tbKodeBaju.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKodeBaju.Location = new System.Drawing.Point(98, 10);
            this.tbKodeBaju.Name = "tbKodeBaju";
            this.tbKodeBaju.Size = new System.Drawing.Size(90, 20);
            this.tbKodeBaju.TabIndex = 22;
            // 
            // tbNamaBaju
            // 
            this.tbNamaBaju.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNamaBaju.Location = new System.Drawing.Point(12, 69);
            this.tbNamaBaju.Name = "tbNamaBaju";
            this.tbNamaBaju.Size = new System.Drawing.Size(382, 20);
            this.tbNamaBaju.TabIndex = 23;
            // 
            // tbJenis
            // 
            this.tbJenis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbJenis.Location = new System.Drawing.Point(424, 69);
            this.tbJenis.Name = "tbJenis";
            this.tbJenis.Size = new System.Drawing.Size(150, 20);
            this.tbJenis.TabIndex = 24;
            // 
            // tbStok
            // 
            this.tbStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStok.Location = new System.Drawing.Point(464, 9);
            this.tbStok.Name = "tbStok";
            this.tbStok.Size = new System.Drawing.Size(45, 20);
            this.tbStok.TabIndex = 25;
            // 
            // tbStatus
            // 
            this.tbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStatus.Location = new System.Drawing.Point(329, 9);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(65, 20);
            this.tbStatus.TabIndex = 26;
            // 
            // tbHargaJual
            // 
            this.tbHargaJual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHargaJual.Location = new System.Drawing.Point(625, 69);
            this.tbHargaJual.Name = "tbHargaJual";
            this.tbHargaJual.Size = new System.Drawing.Size(75, 20);
            this.tbHargaJual.TabIndex = 27;
            this.tbHargaJual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblRp
            // 
            this.lblRp.AutoSize = true;
            this.lblRp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRp.Location = new System.Drawing.Point(660, 53);
            this.lblRp.Name = "lblRp";
            this.lblRp.Size = new System.Drawing.Size(27, 13);
            this.lblRp.TabIndex = 28;
            this.lblRp.Text = "(Rp)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(510, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "pcs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(701, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "/pcs";
            // 
            // FormPakaian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRp);
            this.Controls.Add(this.tbHargaJual);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.tbStok);
            this.Controls.Add(this.tbJenis);
            this.Controls.Add(this.tbNamaBaju);
            this.Controls.Add(this.tbKodeBaju);
            this.Controls.Add(this.lblHargaJual);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblJenis);
            this.Controls.Add(this.lblStok);
            this.Controls.Add(this.lblNamaBaju);
            this.Controls.Add(this.lblKodeBaju);
            this.Controls.Add(this.dgvPakaian);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnTop);
            this.Controls.Add(this.btnClose);
            this.Name = "FormPakaian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Pakaian";
            this.Load += new System.EventHandler(this.FormPakaian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPakaian)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnTop;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvPakaian;
        private System.Windows.Forms.Label lblKodeBaju;
        private System.Windows.Forms.Label lblNamaBaju;
        private System.Windows.Forms.Label lblStok;
        private System.Windows.Forms.Label lblJenis;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblHargaJual;
        private System.Windows.Forms.TextBox tbKodeBaju;
        private System.Windows.Forms.TextBox tbNamaBaju;
        private System.Windows.Forms.TextBox tbJenis;
        private System.Windows.Forms.TextBox tbStok;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.TextBox tbHargaJual;
        private System.Windows.Forms.Label lblRp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn KodeBaju;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stok;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jenis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Harga;
    }
}

