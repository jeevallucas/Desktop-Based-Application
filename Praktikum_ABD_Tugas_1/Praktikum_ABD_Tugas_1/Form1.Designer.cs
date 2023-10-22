namespace Praktikum_ABD_Tugas_1
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
            this.rbJajarGenjang = new System.Windows.Forms.RadioButton();
            this.rbLayangLayang = new System.Windows.Forms.RadioButton();
            this.cbRumus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnHitung = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // rbJajarGenjang
            // 
            this.rbJajarGenjang.AutoSize = true;
            this.rbJajarGenjang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbJajarGenjang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbJajarGenjang.ForeColor = System.Drawing.Color.White;
            this.rbJajarGenjang.Location = new System.Drawing.Point(12, 12);
            this.rbJajarGenjang.Name = "rbJajarGenjang";
            this.rbJajarGenjang.Size = new System.Drawing.Size(117, 19);
            this.rbJajarGenjang.TabIndex = 0;
            this.rbJajarGenjang.TabStop = true;
            this.rbJajarGenjang.Text = "JAJAR GENJANG";
            this.rbJajarGenjang.UseVisualStyleBackColor = false;
            this.rbJajarGenjang.CheckedChanged += new System.EventHandler(this.rbJajarGenjang_CheckedChanged_1);
            // 
            // rbLayangLayang
            // 
            this.rbLayangLayang.AutoSize = true;
            this.rbLayangLayang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbLayangLayang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbLayangLayang.ForeColor = System.Drawing.Color.White;
            this.rbLayangLayang.Location = new System.Drawing.Point(135, 12);
            this.rbLayangLayang.Name = "rbLayangLayang";
            this.rbLayangLayang.Size = new System.Drawing.Size(120, 19);
            this.rbLayangLayang.TabIndex = 1;
            this.rbLayangLayang.TabStop = true;
            this.rbLayangLayang.Text = "LAYANG-LAYANG";
            this.rbLayangLayang.UseVisualStyleBackColor = false;
            this.rbLayangLayang.CheckedChanged += new System.EventHandler(this.rbLayangLayang_CheckedChanged_1);
            // 
            // cbRumus
            // 
            this.cbRumus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbRumus.FormattingEnabled = true;
            this.cbRumus.Items.AddRange(new object[] {
            "Luas",
            "Keliling"});
            this.cbRumus.Location = new System.Drawing.Point(12, 37);
            this.cbRumus.Name = "cbRumus";
            this.cbRumus.Size = new System.Drawing.Size(243, 23);
            this.cbRumus.TabIndex = 2;
            this.cbRumus.Text = "Luas";
            this.cbRumus.SelectedIndexChanged += new System.EventHandler(this.cbRumus_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(299, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "ALAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(430, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "TINGGI";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(299, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "0";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(430, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "0";
            // 
            // btnHitung
            // 
            this.btnHitung.BackColor = System.Drawing.Color.White;
            this.btnHitung.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHitung.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHitung.Location = new System.Drawing.Point(299, 70);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(231, 23);
            this.btnHitung.TabIndex = 7;
            this.btnHitung.Text = "HITUNG";
            this.btnHitung.UseVisualStyleBackColor = false;
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 115);
            this.panel1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 111);
            this.Controls.Add(this.btnHitung);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbRumus);
            this.Controls.Add(this.rbLayangLayang);
            this.Controls.Add(this.rbJajarGenjang);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "JAJAR GENJANG dan LAYANG-LAYANG: Menghitung Luas dan Keliling";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton rbJajarGenjang;
        private RadioButton rbLayangLayang;
        private ComboBox cbRumus;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnHitung;
        private Panel panel1;
    }
}