namespace Inventory_Jeevallucas
{
    partial class FormPembelian
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblNoNotaBeli = new System.Windows.Forms.Label();
            this.tbNoNotaBeli = new System.Windows.Forms.TextBox();
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
            this.lblTanggal = new System.Windows.Forms.Label();
            this.tbTanggal = new System.Windows.Forms.TextBox();
            this.gbSupplier = new System.Windows.Forms.GroupBox();
            this.tbTelepon = new System.Windows.Forms.TextBox();
            this.lblTelepon = new System.Windows.Forms.Label();
            this.tbKota = new System.Windows.Forms.TextBox();
            this.lblKota = new System.Windows.Forms.Label();
            this.tbAlamat = new System.Windows.Forms.TextBox();
            this.lblAlamat = new System.Windows.Forms.Label();
            this.tbNamaSupplier = new System.Windows.Forms.TextBox();
            this.lblNamaSupplier = new System.Windows.Forms.Label();
            this.tbKodeSupplier = new System.Windows.Forms.TextBox();
            this.lblKodeSupplier = new System.Windows.Forms.Label();
            this.dgvDetailPembelian = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbItemDataEntry = new System.Windows.Forms.GroupBox();
            this.tbJumlah = new System.Windows.Forms.TextBox();
            this.lblJumlah = new System.Windows.Forms.Label();
            this.tbHarga = new System.Windows.Forms.TextBox();
            this.lblHarga = new System.Windows.Forms.Label();
            this.lblQTY = new System.Windows.Forms.Label();
            this.lblNamaBarang = new System.Windows.Forms.Label();
            this.lblKode = new System.Windows.Forms.Label();
            this.tbQTY = new System.Windows.Forms.TextBox();
            this.tbNamaBarang = new System.Windows.Forms.TextBox();
            this.tbKodeBarang = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.cbNoNotaBeli = new System.Windows.Forms.ComboBox();
            this.gbSupplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailPembelian)).BeginInit();
            this.gbItemDataEntry.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNoNotaBeli
            // 
            this.lblNoNotaBeli.AutoSize = true;
            this.lblNoNotaBeli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoNotaBeli.Location = new System.Drawing.Point(28, 24);
            this.lblNoNotaBeli.Name = "lblNoNotaBeli";
            this.lblNoNotaBeli.Size = new System.Drawing.Size(83, 13);
            this.lblNoNotaBeli.TabIndex = 16;
            this.lblNoNotaBeli.Text = "No. Nota Beli";
            // 
            // tbNoNotaBeli
            // 
            this.tbNoNotaBeli.Location = new System.Drawing.Point(117, 22);
            this.tbNoNotaBeli.Name = "tbNoNotaBeli";
            this.tbNoNotaBeli.Size = new System.Drawing.Size(100, 20);
            this.tbNoNotaBeli.TabIndex = 17;
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::Inventory_Jeevallucas.Properties.Resources.wzedit;
            this.btnEdit.Location = new System.Drawing.Point(433, 471);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(45, 45);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Image = global::Inventory_Jeevallucas.Properties.Resources.wzundo;
            this.btnUndo.Location = new System.Drawing.Point(433, 522);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(45, 45);
            this.btnUndo.TabIndex = 5;
            this.btnUndo.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Image = global::Inventory_Jeevallucas.Properties.Resources.wzdelete;
            this.btnDel.Location = new System.Drawing.Point(484, 471);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(45, 45);
            this.btnDel.TabIndex = 6;
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Image = global::Inventory_Jeevallucas.Properties.Resources.wzsave;
            this.btnSave.Location = new System.Drawing.Point(382, 522);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(45, 45);
            this.btnSave.TabIndex = 7;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Image = global::Inventory_Jeevallucas.Properties.Resources.wznew;
            this.btnNew.Location = new System.Drawing.Point(382, 471);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(45, 45);
            this.btnNew.TabIndex = 8;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnFind
            // 
            this.btnFind.Image = global::Inventory_Jeevallucas.Properties.Resources.wzlocate;
            this.btnFind.Location = new System.Drawing.Point(331, 471);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(45, 45);
            this.btnFind.TabIndex = 9;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::Inventory_Jeevallucas.Properties.Resources.wzprint;
            this.btnPrint.Location = new System.Drawing.Point(280, 471);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(45, 45);
            this.btnPrint.TabIndex = 10;
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnEnd
            // 
            this.btnEnd.Image = global::Inventory_Jeevallucas.Properties.Resources.wzend;
            this.btnEnd.Location = new System.Drawing.Point(167, 522);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(45, 45);
            this.btnEnd.TabIndex = 11;
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnNext
            // 
            this.btnNext.Image = global::Inventory_Jeevallucas.Properties.Resources.wznext;
            this.btnNext.Location = new System.Drawing.Point(116, 522);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(45, 45);
            this.btnNext.TabIndex = 12;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.Image = global::Inventory_Jeevallucas.Properties.Resources.wzback;
            this.btnBack.Location = new System.Drawing.Point(65, 522);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(45, 45);
            this.btnBack.TabIndex = 13;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnTop
            // 
            this.btnTop.Image = global::Inventory_Jeevallucas.Properties.Resources.wztop1;
            this.btnTop.Location = new System.Drawing.Point(14, 522);
            this.btnTop.Name = "btnTop";
            this.btnTop.Size = new System.Drawing.Size(45, 45);
            this.btnTop.TabIndex = 14;
            this.btnTop.UseVisualStyleBackColor = true;
            this.btnTop.Click += new System.EventHandler(this.btnTop_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::Inventory_Jeevallucas.Properties.Resources.wzclose;
            this.btnClose.Location = new System.Drawing.Point(745, 522);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 45);
            this.btnClose.TabIndex = 3;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTanggal
            // 
            this.lblTanggal.AutoSize = true;
            this.lblTanggal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTanggal.Location = new System.Drawing.Point(608, 27);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(53, 13);
            this.lblTanggal.TabIndex = 18;
            this.lblTanggal.Text = "Tanggal";
            // 
            // tbTanggal
            // 
            this.tbTanggal.Location = new System.Drawing.Point(667, 21);
            this.tbTanggal.Name = "tbTanggal";
            this.tbTanggal.Size = new System.Drawing.Size(115, 20);
            this.tbTanggal.TabIndex = 19;
            // 
            // gbSupplier
            // 
            this.gbSupplier.Controls.Add(this.tbTelepon);
            this.gbSupplier.Controls.Add(this.lblTelepon);
            this.gbSupplier.Controls.Add(this.tbKota);
            this.gbSupplier.Controls.Add(this.lblKota);
            this.gbSupplier.Controls.Add(this.tbAlamat);
            this.gbSupplier.Controls.Add(this.lblAlamat);
            this.gbSupplier.Controls.Add(this.tbNamaSupplier);
            this.gbSupplier.Controls.Add(this.lblNamaSupplier);
            this.gbSupplier.Controls.Add(this.tbKodeSupplier);
            this.gbSupplier.Controls.Add(this.lblKodeSupplier);
            this.gbSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSupplier.Location = new System.Drawing.Point(15, 66);
            this.gbSupplier.Name = "gbSupplier";
            this.gbSupplier.Size = new System.Drawing.Size(773, 125);
            this.gbSupplier.TabIndex = 22;
            this.gbSupplier.TabStop = false;
            this.gbSupplier.Text = "Supplier";
            // 
            // tbTelepon
            // 
            this.tbTelepon.Location = new System.Drawing.Point(525, 89);
            this.tbTelepon.Name = "tbTelepon";
            this.tbTelepon.ReadOnly = true;
            this.tbTelepon.Size = new System.Drawing.Size(242, 20);
            this.tbTelepon.TabIndex = 9;
            // 
            // lblTelepon
            // 
            this.lblTelepon.AutoSize = true;
            this.lblTelepon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelepon.Location = new System.Drawing.Point(466, 92);
            this.lblTelepon.Name = "lblTelepon";
            this.lblTelepon.Size = new System.Drawing.Size(53, 13);
            this.lblTelepon.TabIndex = 8;
            this.lblTelepon.Text = "Telepon";
            // 
            // tbKota
            // 
            this.tbKota.Location = new System.Drawing.Point(525, 56);
            this.tbKota.Name = "tbKota";
            this.tbKota.ReadOnly = true;
            this.tbKota.Size = new System.Drawing.Size(242, 20);
            this.tbKota.TabIndex = 7;
            // 
            // lblKota
            // 
            this.lblKota.AutoSize = true;
            this.lblKota.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKota.Location = new System.Drawing.Point(486, 59);
            this.lblKota.Name = "lblKota";
            this.lblKota.Size = new System.Drawing.Size(33, 13);
            this.lblKota.TabIndex = 6;
            this.lblKota.Text = "Kota";
            // 
            // tbAlamat
            // 
            this.tbAlamat.Location = new System.Drawing.Point(102, 89);
            this.tbAlamat.Name = "tbAlamat";
            this.tbAlamat.ReadOnly = true;
            this.tbAlamat.Size = new System.Drawing.Size(286, 20);
            this.tbAlamat.TabIndex = 5;
            // 
            // lblAlamat
            // 
            this.lblAlamat.AutoSize = true;
            this.lblAlamat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlamat.Location = new System.Drawing.Point(51, 92);
            this.lblAlamat.Name = "lblAlamat";
            this.lblAlamat.Size = new System.Drawing.Size(45, 13);
            this.lblAlamat.TabIndex = 4;
            this.lblAlamat.Text = "Alamat";
            // 
            // tbNamaSupplier
            // 
            this.tbNamaSupplier.Location = new System.Drawing.Point(102, 56);
            this.tbNamaSupplier.Name = "tbNamaSupplier";
            this.tbNamaSupplier.ReadOnly = true;
            this.tbNamaSupplier.Size = new System.Drawing.Size(286, 20);
            this.tbNamaSupplier.TabIndex = 3;
            // 
            // lblNamaSupplier
            // 
            this.lblNamaSupplier.AutoSize = true;
            this.lblNamaSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamaSupplier.Location = new System.Drawing.Point(7, 59);
            this.lblNamaSupplier.Name = "lblNamaSupplier";
            this.lblNamaSupplier.Size = new System.Drawing.Size(89, 13);
            this.lblNamaSupplier.TabIndex = 2;
            this.lblNamaSupplier.Text = "Nama Supplier";
            // 
            // tbKodeSupplier
            // 
            this.tbKodeSupplier.Location = new System.Drawing.Point(102, 27);
            this.tbKodeSupplier.Name = "tbKodeSupplier";
            this.tbKodeSupplier.ReadOnly = true;
            this.tbKodeSupplier.Size = new System.Drawing.Size(75, 20);
            this.tbKodeSupplier.TabIndex = 1;
            this.tbKodeSupplier.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbKodeSupplier_KeyUp);
            this.tbKodeSupplier.Validated += new System.EventHandler(this.tbKodeSupplier_Validated);
            // 
            // lblKodeSupplier
            // 
            this.lblKodeSupplier.AutoSize = true;
            this.lblKodeSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKodeSupplier.Location = new System.Drawing.Point(10, 30);
            this.lblKodeSupplier.Name = "lblKodeSupplier";
            this.lblKodeSupplier.Size = new System.Drawing.Size(86, 13);
            this.lblKodeSupplier.TabIndex = 0;
            this.lblKodeSupplier.Text = "Kode Supplier";
            // 
            // dgvDetailPembelian
            // 
            this.dgvDetailPembelian.AllowUserToAddRows = false;
            this.dgvDetailPembelian.AllowUserToDeleteRows = false;
            this.dgvDetailPembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailPembelian.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvDetailPembelian.Location = new System.Drawing.Point(14, 280);
            this.dgvDetailPembelian.Name = "dgvDetailPembelian";
            this.dgvDetailPembelian.ReadOnly = true;
            this.dgvDetailPembelian.Size = new System.Drawing.Size(773, 185);
            this.dgvDetailPembelian.TabIndex = 10;
            this.dgvDetailPembelian.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvDetailPembelian_KeyDown);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "idNotaBeli";
            this.Column1.HeaderText = "ID Nota Beli";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "noNotaBeli";
            this.Column2.HeaderText = "NO Nota Beli";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "kodeBarang";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column3.HeaderText = "Kode";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "nama";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle7;
            this.Column4.HeaderText = "Nama Barang";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 380;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "qty";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column5.HeaderText = "QTY";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 50;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "harga";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N0";
            dataGridViewCellStyle9.NullValue = null;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle9;
            this.Column6.HeaderText = "Harga";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "jumlah";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N0";
            dataGridViewCellStyle10.NullValue = null;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle10;
            this.Column7.HeaderText = "Jumlah";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // gbItemDataEntry
            // 
            this.gbItemDataEntry.Controls.Add(this.tbJumlah);
            this.gbItemDataEntry.Controls.Add(this.lblJumlah);
            this.gbItemDataEntry.Controls.Add(this.tbHarga);
            this.gbItemDataEntry.Controls.Add(this.lblHarga);
            this.gbItemDataEntry.Controls.Add(this.lblQTY);
            this.gbItemDataEntry.Controls.Add(this.lblNamaBarang);
            this.gbItemDataEntry.Controls.Add(this.lblKode);
            this.gbItemDataEntry.Controls.Add(this.tbQTY);
            this.gbItemDataEntry.Controls.Add(this.tbNamaBarang);
            this.gbItemDataEntry.Controls.Add(this.tbKodeBarang);
            this.gbItemDataEntry.Location = new System.Drawing.Point(15, 197);
            this.gbItemDataEntry.Name = "gbItemDataEntry";
            this.gbItemDataEntry.Size = new System.Drawing.Size(773, 77);
            this.gbItemDataEntry.TabIndex = 23;
            this.gbItemDataEntry.TabStop = false;
            this.gbItemDataEntry.Text = "Item Data Entry";
            // 
            // tbJumlah
            // 
            this.tbJumlah.Location = new System.Drawing.Point(652, 45);
            this.tbJumlah.Name = "tbJumlah";
            this.tbJumlah.ReadOnly = true;
            this.tbJumlah.Size = new System.Drawing.Size(93, 20);
            this.tbJumlah.TabIndex = 9;
            this.tbJumlah.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbJumlah.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbJumlah_KeyDown);
            // 
            // lblJumlah
            // 
            this.lblJumlah.AutoSize = true;
            this.lblJumlah.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJumlah.Location = new System.Drawing.Point(649, 29);
            this.lblJumlah.Name = "lblJumlah";
            this.lblJumlah.Size = new System.Drawing.Size(46, 13);
            this.lblJumlah.TabIndex = 8;
            this.lblJumlah.Text = "Jumlah";
            // 
            // tbHarga
            // 
            this.tbHarga.Location = new System.Drawing.Point(553, 45);
            this.tbHarga.Name = "tbHarga";
            this.tbHarga.Size = new System.Drawing.Size(93, 20);
            this.tbHarga.TabIndex = 7;
            this.tbHarga.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbHarga.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbHarga_KeyDown);
            this.tbHarga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHarga_KeyPress);
            this.tbHarga.Validated += new System.EventHandler(this.tbHarga_Validated);
            // 
            // lblHarga
            // 
            this.lblHarga.AutoSize = true;
            this.lblHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHarga.Location = new System.Drawing.Point(550, 29);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(41, 13);
            this.lblHarga.TabIndex = 6;
            this.lblHarga.Text = "Harga";
            // 
            // lblQTY
            // 
            this.lblQTY.AutoSize = true;
            this.lblQTY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQTY.Location = new System.Drawing.Point(497, 29);
            this.lblQTY.Name = "lblQTY";
            this.lblQTY.Size = new System.Drawing.Size(32, 13);
            this.lblQTY.TabIndex = 5;
            this.lblQTY.Text = "QTY";
            // 
            // lblNamaBarang
            // 
            this.lblNamaBarang.AutoSize = true;
            this.lblNamaBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamaBarang.Location = new System.Drawing.Point(120, 29);
            this.lblNamaBarang.Name = "lblNamaBarang";
            this.lblNamaBarang.Size = new System.Drawing.Size(83, 13);
            this.lblNamaBarang.TabIndex = 4;
            this.lblNamaBarang.Text = "Nama Barang";
            // 
            // lblKode
            // 
            this.lblKode.AutoSize = true;
            this.lblKode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKode.Location = new System.Drawing.Point(40, 29);
            this.lblKode.Name = "lblKode";
            this.lblKode.Size = new System.Drawing.Size(36, 13);
            this.lblKode.TabIndex = 3;
            this.lblKode.Text = "Kode";
            // 
            // tbQTY
            // 
            this.tbQTY.Location = new System.Drawing.Point(500, 45);
            this.tbQTY.Name = "tbQTY";
            this.tbQTY.Size = new System.Drawing.Size(47, 20);
            this.tbQTY.TabIndex = 2;
            this.tbQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbQTY.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbQTY_KeyDown);
            this.tbQTY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbQTY_KeyPress);
            this.tbQTY.Validated += new System.EventHandler(this.tbQTY_Validated);
            // 
            // tbNamaBarang
            // 
            this.tbNamaBarang.Location = new System.Drawing.Point(123, 45);
            this.tbNamaBarang.Name = "tbNamaBarang";
            this.tbNamaBarang.ReadOnly = true;
            this.tbNamaBarang.Size = new System.Drawing.Size(371, 20);
            this.tbNamaBarang.TabIndex = 1;
            // 
            // tbKodeBarang
            // 
            this.tbKodeBarang.Location = new System.Drawing.Point(43, 45);
            this.tbKodeBarang.Name = "tbKodeBarang";
            this.tbKodeBarang.Size = new System.Drawing.Size(71, 20);
            this.tbKodeBarang.TabIndex = 0;
            this.tbKodeBarang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbKodeBarang.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbKodeBarang_KeyUp);
            this.tbKodeBarang.Leave += new System.EventHandler(this.tbKodeBarang_Leave);
            this.tbKodeBarang.Validating += new System.ComponentModel.CancelEventHandler(this.tbKodeBarang_Validating);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(664, 494);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(36, 13);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "Total";
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(667, 471);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(100, 20);
            this.tbTotal.TabIndex = 24;
            this.tbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbNoNotaBeli
            // 
            this.cbNoNotaBeli.FormattingEnabled = true;
            this.cbNoNotaBeli.Location = new System.Drawing.Point(117, 21);
            this.cbNoNotaBeli.Name = "cbNoNotaBeli";
            this.cbNoNotaBeli.Size = new System.Drawing.Size(133, 21);
            this.cbNoNotaBeli.TabIndex = 25;
            this.cbNoNotaBeli.SelectedValueChanged += new System.EventHandler(this.cbNoNotaBeli_SelectedValueChanged);
            this.cbNoNotaBeli.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbNoNotaBeli_KeyDown);
            this.cbNoNotaBeli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbNoNotaBeli_KeyPress);
            // 
            // FormPembelian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 588);
            this.Controls.Add(this.cbNoNotaBeli);
            this.Controls.Add(this.dgvDetailPembelian);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.gbItemDataEntry);
            this.Controls.Add(this.gbSupplier);
            this.Controls.Add(this.tbTanggal);
            this.Controls.Add(this.lblTanggal);
            this.Controls.Add(this.tbNoNotaBeli);
            this.Controls.Add(this.lblNoNotaBeli);
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
            this.Name = "FormPembelian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Pembelian";
            this.Load += new System.EventHandler(this.FormPembelian_Load);
            this.gbSupplier.ResumeLayout(false);
            this.gbSupplier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailPembelian)).EndInit();
            this.gbItemDataEntry.ResumeLayout(false);
            this.gbItemDataEntry.PerformLayout();
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
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnTop;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblNoNotaBeli;
        private System.Windows.Forms.TextBox tbNoNotaBeli;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.TextBox tbTanggal;
        private System.Windows.Forms.GroupBox gbSupplier;
        private System.Windows.Forms.TextBox tbTelepon;
        private System.Windows.Forms.Label lblTelepon;
        private System.Windows.Forms.TextBox tbKota;
        private System.Windows.Forms.Label lblKota;
        private System.Windows.Forms.TextBox tbAlamat;
        private System.Windows.Forms.Label lblAlamat;
        private System.Windows.Forms.TextBox tbNamaSupplier;
        private System.Windows.Forms.Label lblNamaSupplier;
        private System.Windows.Forms.TextBox tbKodeSupplier;
        private System.Windows.Forms.Label lblKodeSupplier;
        private System.Windows.Forms.DataGridView dgvDetailPembelian;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.GroupBox gbItemDataEntry;
        private System.Windows.Forms.TextBox tbJumlah;
        private System.Windows.Forms.Label lblJumlah;
        private System.Windows.Forms.TextBox tbHarga;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.Label lblQTY;
        private System.Windows.Forms.Label lblNamaBarang;
        private System.Windows.Forms.Label lblKode;
        private System.Windows.Forms.TextBox tbQTY;
        private System.Windows.Forms.TextBox tbNamaBarang;
        private System.Windows.Forms.TextBox tbKodeBarang;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.ComboBox cbNoNotaBeli;
    }
}