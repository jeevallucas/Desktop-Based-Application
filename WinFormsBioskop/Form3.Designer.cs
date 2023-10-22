namespace WinFormsBioskop
{
    partial class formNavigasi
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
            this.lblKode = new System.Windows.Forms.Label();
            this.txtKode = new System.Windows.Forms.TextBox();
            this.lblNama = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.lblDurasi = new System.Windows.Forms.Label();
            this.txtDurasi = new System.Windows.Forms.TextBox();
            this.lblRating = new System.Windows.Forms.Label();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnTop = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKode
            // 
            this.lblKode.AutoSize = true;
            this.lblKode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKode.Location = new System.Drawing.Point(12, 9);
            this.lblKode.Name = "lblKode";
            this.lblKode.Size = new System.Drawing.Size(36, 15);
            this.lblKode.TabIndex = 0;
            this.lblKode.Text = "Kode";
            // 
            // txtKode
            // 
            this.txtKode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKode.Location = new System.Drawing.Point(58, 9);
            this.txtKode.Name = "txtKode";
            this.txtKode.Size = new System.Drawing.Size(75, 16);
            this.txtKode.TabIndex = 1;
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNama.Location = new System.Drawing.Point(12, 38);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(39, 15);
            this.lblNama.TabIndex = 0;
            this.lblNama.Text = "Nama";
            // 
            // txtNama
            // 
            this.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNama.Location = new System.Drawing.Point(57, 38);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(200, 16);
            this.txtNama.TabIndex = 1;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGenre.Location = new System.Drawing.Point(317, 9);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(42, 15);
            this.lblGenre.TabIndex = 0;
            this.lblGenre.Text = "Genre";
            // 
            // txtGenre
            // 
            this.txtGenre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGenre.Location = new System.Drawing.Point(361, 9);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(100, 16);
            this.txtGenre.TabIndex = 1;
            // 
            // lblDurasi
            // 
            this.lblDurasi.AutoSize = true;
            this.lblDurasi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDurasi.Location = new System.Drawing.Point(317, 38);
            this.lblDurasi.Name = "lblDurasi";
            this.lblDurasi.Size = new System.Drawing.Size(42, 15);
            this.lblDurasi.TabIndex = 0;
            this.lblDurasi.Text = "Durasi";
            // 
            // txtDurasi
            // 
            this.txtDurasi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDurasi.Location = new System.Drawing.Point(361, 38);
            this.txtDurasi.Name = "txtDurasi";
            this.txtDurasi.Size = new System.Drawing.Size(50, 16);
            this.txtDurasi.TabIndex = 1;
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRating.Location = new System.Drawing.Point(503, 9);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(43, 15);
            this.lblRating.TabIndex = 0;
            this.lblRating.Text = "Rating";
            // 
            // txtRating
            // 
            this.txtRating.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRating.Location = new System.Drawing.Point(547, 8);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(30, 16);
            this.txtRating.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(565, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnTop
            // 
            this.btnTop.Image = global::WinFormsBioskop.Properties.Resources.wztop;
            this.btnTop.Location = new System.Drawing.Point(12, 233);
            this.btnTop.Name = "btnTop";
            this.btnTop.Size = new System.Drawing.Size(40, 40);
            this.btnTop.TabIndex = 3;
            this.btnTop.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Image = global::WinFormsBioskop.Properties.Resources.wzback;
            this.btnBack.Location = new System.Drawing.Point(58, 233);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 40);
            this.btnBack.TabIndex = 3;
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Image = global::WinFormsBioskop.Properties.Resources.wznext;
            this.btnNext.Location = new System.Drawing.Point(104, 233);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(40, 40);
            this.btnNext.TabIndex = 3;
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnEnd
            // 
            this.btnEnd.Image = global::WinFormsBioskop.Properties.Resources.wzend;
            this.btnEnd.Location = new System.Drawing.Point(150, 233);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(40, 40);
            this.btnEnd.TabIndex = 3;
            this.btnEnd.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::WinFormsBioskop.Properties.Resources.wzprint;
            this.btnPrint.Location = new System.Drawing.Point(291, 233);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(40, 40);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnFind
            // 
            this.btnFind.Image = global::WinFormsBioskop.Properties.Resources.wzlocate;
            this.btnFind.Location = new System.Drawing.Point(337, 233);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(40, 40);
            this.btnFind.TabIndex = 3;
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Image = global::WinFormsBioskop.Properties.Resources.wznew;
            this.btnNew.Location = new System.Drawing.Point(383, 233);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(40, 40);
            this.btnNew.TabIndex = 3;
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::WinFormsBioskop.Properties.Resources.wzedit;
            this.btnEdit.Location = new System.Drawing.Point(429, 233);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(40, 40);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::WinFormsBioskop.Properties.Resources.wzdelete;
            this.btnDelete.Location = new System.Drawing.Point(475, 233);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(40, 40);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Image = global::WinFormsBioskop.Properties.Resources.wzsave;
            this.btnSave.Location = new System.Drawing.Point(383, 279);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(40, 40);
            this.btnSave.TabIndex = 3;
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnUndo
            // 
            this.btnUndo.Image = global::WinFormsBioskop.Properties.Resources.wzundo;
            this.btnUndo.Location = new System.Drawing.Point(429, 279);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(40, 40);
            this.btnUndo.TabIndex = 3;
            this.btnUndo.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Image = global::WinFormsBioskop.Properties.Resources.wzclose;
            this.btnClose.Location = new System.Drawing.Point(537, 233);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 3;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // formNavigasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnTop);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtDurasi);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.lblDurasi);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.txtRating);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.txtKode);
            this.Controls.Add(this.lblKode);
            this.Name = "formNavigasi";
            this.Text = "Form Navigasi";
            this.Load += new System.EventHandler(this.formNavigasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblKode;
        private TextBox txtKode;
        private Label lblNama;
        private TextBox txtNama;
        private Label lblGenre;
        private TextBox txtGenre;
        private Label lblDurasi;
        private TextBox txtDurasi;
        private Label lblRating;
        private TextBox txtRating;
        private DataGridView dataGridView1;
        private Button btnTop;
        private Button btnBack;
        private Button btnNext;
        private Button btnEnd;
        private Button btnPrint;
        private Button btnFind;
        private Button btnNew;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnSave;
        private Button btnUndo;
        private Button btnClose;
    }
}