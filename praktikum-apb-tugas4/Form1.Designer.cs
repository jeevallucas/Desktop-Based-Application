namespace praktikum_apb_tugas4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClose = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnTop = new System.Windows.Forms.Button();
            this.dgvAnime = new System.Windows.Forms.DataGridView();
            this.txtIDAnime = new System.Windows.Forms.TextBox();
            this.txtNameAnime = new System.Windows.Forms.TextBox();
            this.lblNameAnime = new System.Windows.Forms.Label();
            this.lblIDAnime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnime)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Image = global::praktikum_apb_tugas4.Properties.Resources.wzclose;
            this.btnClose.Location = new System.Drawing.Point(743, 341);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 45);
            this.btnClose.TabIndex = 33;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::praktikum_apb_tugas4.Properties.Resources.wzedit;
            this.btnEdit.Location = new System.Drawing.Point(420, 341);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(45, 45);
            this.btnEdit.TabIndex = 32;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Image = global::praktikum_apb_tugas4.Properties.Resources.wznew;
            this.btnNew.Location = new System.Drawing.Point(369, 341);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(45, 45);
            this.btnNew.TabIndex = 31;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDel
            // 
            this.btnDel.Image = global::praktikum_apb_tugas4.Properties.Resources.wzdelete;
            this.btnDel.Location = new System.Drawing.Point(471, 341);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(45, 45);
            this.btnDel.TabIndex = 30;
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Image = global::praktikum_apb_tugas4.Properties.Resources.wzundo;
            this.btnUndo.Location = new System.Drawing.Point(420, 392);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(45, 45);
            this.btnUndo.TabIndex = 29;
            this.btnUndo.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Image = global::praktikum_apb_tugas4.Properties.Resources.wzsave;
            this.btnSave.Location = new System.Drawing.Point(369, 392);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(45, 45);
            this.btnSave.TabIndex = 28;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnFind
            // 
            this.btnFind.Image = global::praktikum_apb_tugas4.Properties.Resources.wzlocate;
            this.btnFind.Location = new System.Drawing.Point(318, 341);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(45, 45);
            this.btnFind.TabIndex = 27;
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::praktikum_apb_tugas4.Properties.Resources.wzprint;
            this.btnPrint.Location = new System.Drawing.Point(267, 341);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(45, 45);
            this.btnPrint.TabIndex = 26;
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnEnd
            // 
            this.btnEnd.Image = global::praktikum_apb_tugas4.Properties.Resources.wzend;
            this.btnEnd.Location = new System.Drawing.Point(165, 341);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(45, 45);
            this.btnEnd.TabIndex = 25;
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnNext
            // 
            this.btnNext.Image = global::praktikum_apb_tugas4.Properties.Resources.wznext;
            this.btnNext.Location = new System.Drawing.Point(114, 341);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(45, 45);
            this.btnNext.TabIndex = 24;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.Image = global::praktikum_apb_tugas4.Properties.Resources.wzback;
            this.btnBack.Location = new System.Drawing.Point(63, 341);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(45, 45);
            this.btnBack.TabIndex = 23;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnTop
            // 
            this.btnTop.Image = global::praktikum_apb_tugas4.Properties.Resources.wztop;
            this.btnTop.Location = new System.Drawing.Point(12, 341);
            this.btnTop.Name = "btnTop";
            this.btnTop.Size = new System.Drawing.Size(45, 45);
            this.btnTop.TabIndex = 22;
            this.btnTop.UseVisualStyleBackColor = true;
            this.btnTop.Click += new System.EventHandler(this.btnTop_Click);
            // 
            // dgvAnime
            // 
            this.dgvAnime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnime.Location = new System.Drawing.Point(12, 92);
            this.dgvAnime.Name = "dgvAnime";
            this.dgvAnime.RowTemplate.Height = 25;
            this.dgvAnime.Size = new System.Drawing.Size(776, 243);
            this.dgvAnime.TabIndex = 21;
            // 
            // txtIDAnime
            // 
            this.txtIDAnime.Location = new System.Drawing.Point(95, 14);
            this.txtIDAnime.Name = "txtIDAnime";
            this.txtIDAnime.Size = new System.Drawing.Size(100, 23);
            this.txtIDAnime.TabIndex = 20;
            // 
            // txtNameAnime
            // 
            this.txtNameAnime.Location = new System.Drawing.Point(95, 53);
            this.txtNameAnime.Name = "txtNameAnime";
            this.txtNameAnime.Size = new System.Drawing.Size(693, 23);
            this.txtNameAnime.TabIndex = 19;
            // 
            // lblNameAnime
            // 
            this.lblNameAnime.AutoSize = true;
            this.lblNameAnime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNameAnime.Location = new System.Drawing.Point(12, 56);
            this.lblNameAnime.Name = "lblNameAnime";
            this.lblNameAnime.Size = new System.Drawing.Size(79, 15);
            this.lblNameAnime.TabIndex = 18;
            this.lblNameAnime.Text = "Anime Name";
            // 
            // lblIDAnime
            // 
            this.lblIDAnime.AutoSize = true;
            this.lblIDAnime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIDAnime.Location = new System.Drawing.Point(12, 17);
            this.lblIDAnime.Name = "lblIDAnime";
            this.lblIDAnime.Size = new System.Drawing.Size(59, 15);
            this.lblIDAnime.TabIndex = 17;
            this.lblIDAnime.Text = "Anime ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnTop);
            this.Controls.Add(this.dgvAnime);
            this.Controls.Add(this.txtIDAnime);
            this.Controls.Add(this.txtNameAnime);
            this.Controls.Add(this.lblNameAnime);
            this.Controls.Add(this.lblIDAnime);
            this.Name = "Form1";
            this.Text = "Anime Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnClose;
        private Button btnEdit;
        private Button btnNew;
        private Button btnDel;
        private Button btnUndo;
        private Button btnSave;
        private Button btnFind;
        private Button btnPrint;
        private Button btnEnd;
        private Button btnNext;
        private Button btnBack;
        private Button btnTop;
        private DataGridView dgvAnime;
        private TextBox txtIDAnime;
        private TextBox txtNameAnime;
        private Label lblNameAnime;
        private Label lblIDAnime;
    }
}