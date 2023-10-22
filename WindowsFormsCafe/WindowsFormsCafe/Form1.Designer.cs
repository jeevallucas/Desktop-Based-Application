namespace WindowsFormsCafe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbtelpon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbalamat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbnama = new System.Windows.Forms.TextBox();
            this.tbid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbtgl = new System.Windows.Forms.TextBox();
            this.dgvcafe = new System.Windows.Forms.DataGridView();
            this.btntop = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.btnend = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnfind = new System.Windows.Forms.Button();
            this.btnundo = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.id_dtl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kd_min = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nm_min = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expr1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcafe)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbtelpon);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbalamat);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbnama);
            this.groupBox1.Location = new System.Drawing.Point(12, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pengguna";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(610, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "No. Telpon";
            // 
            // tbtelpon
            // 
            this.tbtelpon.Enabled = false;
            this.tbtelpon.Location = new System.Drawing.Point(672, 19);
            this.tbtelpon.Name = "tbtelpon";
            this.tbtelpon.Size = new System.Drawing.Size(98, 20);
            this.tbtelpon.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Alamat";
            // 
            // tbalamat
            // 
            this.tbalamat.Enabled = false;
            this.tbalamat.Location = new System.Drawing.Point(57, 45);
            this.tbalamat.Name = "tbalamat";
            this.tbalamat.Size = new System.Drawing.Size(529, 20);
            this.tbalamat.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nama";
            // 
            // tbnama
            // 
            this.tbnama.Enabled = false;
            this.tbnama.Location = new System.Drawing.Point(57, 19);
            this.tbnama.Name = "tbnama";
            this.tbnama.Size = new System.Drawing.Size(529, 20);
            this.tbnama.TabIndex = 5;
            // 
            // tbid
            // 
            this.tbid.Enabled = false;
            this.tbid.Location = new System.Drawing.Point(33, 49);
            this.tbid.Name = "tbid";
            this.tbid.Size = new System.Drawing.Size(66, 20);
            this.tbid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(622, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tanggal";
            // 
            // tbtgl
            // 
            this.tbtgl.Enabled = false;
            this.tbtgl.Location = new System.Drawing.Point(684, 49);
            this.tbtgl.Name = "tbtgl";
            this.tbtgl.Size = new System.Drawing.Size(100, 20);
            this.tbtgl.TabIndex = 3;
            // 
            // dgvcafe
            // 
            this.dgvcafe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcafe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_dtl,
            this.id,
            this.kd_min,
            this.nm_min,
            this.harga,
            this.Expr1});
            this.dgvcafe.Location = new System.Drawing.Point(12, 163);
            this.dgvcafe.Name = "dgvcafe";
            this.dgvcafe.Size = new System.Drawing.Size(776, 206);
            this.dgvcafe.TabIndex = 5;
            // 
            // btntop
            // 
            this.btntop.Location = new System.Drawing.Point(13, 388);
            this.btntop.Name = "btntop";
            this.btntop.Size = new System.Drawing.Size(62, 50);
            this.btntop.TabIndex = 6;
            this.btntop.Text = "<<";
            this.btntop.UseVisualStyleBackColor = true;
            this.btntop.Click += new System.EventHandler(this.btntop_Click);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(81, 388);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(62, 50);
            this.btnback.TabIndex = 7;
            this.btnback.Text = "<";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnend
            // 
            this.btnend.Location = new System.Drawing.Point(217, 388);
            this.btnend.Name = "btnend";
            this.btnend.Size = new System.Drawing.Size(62, 50);
            this.btnend.TabIndex = 9;
            this.btnend.Text = ">>";
            this.btnend.UseVisualStyleBackColor = true;
            this.btnend.Click += new System.EventHandler(this.btnend_Click);
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(149, 388);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(62, 50);
            this.btnnext.TabIndex = 8;
            this.btnnext.Text = ">";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(555, 388);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(62, 50);
            this.btndelete.TabIndex = 13;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(487, 388);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(62, 50);
            this.btnedit.TabIndex = 12;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(419, 388);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(62, 50);
            this.btnnew.TabIndex = 11;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = true;
            // 
            // btnprint
            // 
            this.btnprint.Location = new System.Drawing.Point(351, 388);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(62, 50);
            this.btnprint.TabIndex = 10;
            this.btnprint.Text = "Print";
            this.btnprint.UseVisualStyleBackColor = true;
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(726, 388);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(62, 50);
            this.btnclose.TabIndex = 17;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            // 
            // btnfind
            // 
            this.btnfind.Location = new System.Drawing.Point(623, 388);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(62, 50);
            this.btnfind.TabIndex = 16;
            this.btnfind.Text = "Find";
            this.btnfind.UseVisualStyleBackColor = true;
            // 
            // btnundo
            // 
            this.btnundo.Location = new System.Drawing.Point(487, 428);
            this.btnundo.Name = "btnundo";
            this.btnundo.Size = new System.Drawing.Size(62, 50);
            this.btnundo.TabIndex = 15;
            this.btnundo.Text = "Undo";
            this.btnundo.UseVisualStyleBackColor = true;
            this.btnundo.Visible = false;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(419, 428);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(62, 50);
            this.btnsave.TabIndex = 14;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Visible = false;
            // 
            // id_dtl
            // 
            this.id_dtl.DataPropertyName = "id_dtl";
            this.id_dtl.HeaderText = "id";
            this.id_dtl.Name = "id_dtl";
            this.id_dtl.Visible = false;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "idpk";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // kd_min
            // 
            this.kd_min.DataPropertyName = "kd_min";
            this.kd_min.HeaderText = "Kode";
            this.kd_min.Name = "kd_min";
            // 
            // nm_min
            // 
            this.nm_min.DataPropertyName = "nm_min";
            this.nm_min.HeaderText = "Nama Minuman";
            this.nm_min.Name = "nm_min";
            this.nm_min.Width = 210;
            // 
            // harga
            // 
            this.harga.DataPropertyName = "harga";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.harga.DefaultCellStyle = dataGridViewCellStyle1;
            this.harga.HeaderText = "Harga";
            this.harga.Name = "harga";
            this.harga.Width = 150;
            // 
            // Expr1
            // 
            this.Expr1.DataPropertyName = "Expr1";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.Expr1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Expr1.HeaderText = "Harga Menu";
            this.Expr1.Name = "Expr1";
            this.Expr1.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnfind);
            this.Controls.Add(this.btnundo);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.btnend);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btntop);
            this.Controls.Add(this.dgvcafe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbtgl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbid);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Transaksi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcafe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbtelpon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbalamat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbnama;
        private System.Windows.Forms.TextBox tbid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbtgl;
        private System.Windows.Forms.DataGridView dgvcafe;
        private System.Windows.Forms.Button btntop;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnend;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.Button btnundo;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_dtl;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn kd_min;
        private System.Windows.Forms.DataGridViewTextBoxColumn nm_min;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expr1;
    }
}

