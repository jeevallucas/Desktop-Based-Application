namespace WinFormsBioskop
{
    partial class formCetakData
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
            this.rtbFilm = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbFilm
            // 
            this.rtbFilm.Location = new System.Drawing.Point(12, 12);
            this.rtbFilm.Name = "rtbFilm";
            this.rtbFilm.Size = new System.Drawing.Size(776, 426);
            this.rtbFilm.TabIndex = 0;
            this.rtbFilm.Text = "";
            // 
            // formCetakData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbFilm);
            this.Name = "formCetakData";
            this.Text = "Form Cetak Data";
            this.Load += new System.EventHandler(this.formCetakData_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox rtbFilm;
    }
}