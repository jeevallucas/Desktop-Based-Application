namespace Praktikum_ABD_Tugas_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            rbJajarGenjang.Checked = true;
            cbRumus.SelectedIndex = 0;
        }

        private void rbJajarGenjang_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbRumus.SelectedIndex == 0)
            {
                label1.Text = "ALAS";
                label2.Text = "TINGGI";
            }

            else
            {
                label1.Text = "PANJANG";
                label2.Text = "LEBAR";
            }
        }

        private void rbLayangLayang_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbRumus.SelectedIndex == 0)
            {
                label1.Text = "DIAGONAL1";
                label2.Text = "DIAGONAL2";
            }

            else
            {
                label1.Text = "SISI A";
                label2.Text = "SISI C";
            }
        }

        private void cbRumus_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (rbJajarGenjang.Checked)
            {
                if (cbRumus.SelectedIndex == 0)
                {
                    label1.Text = "ALAS";
                    label2.Text = "TINGGI";
                }

                else
                {
                    label1.Text = "PANJANG";
                    label2.Text = "LEBAR";
                }
            }

            else
            {
                if (cbRumus.SelectedIndex == 0)
                {
                    label1.Text = "DIAGONAL1";
                    label2.Text = "DIAGONAL2";
                }

                else
                {
                    label1.Text = "SISI A";
                    label2.Text = "SISI C";
                }
            }
        }

        private void btnHitung_Click_1(object sender, EventArgs e)
        {
            double inputPertama = Double.Parse(textBox1.Text);
            double inputKedua = Double.Parse(textBox2.Text);

            if (rbJajarGenjang.Checked)
            {
                if (cbRumus.SelectedIndex == 0)
                {
                    double total = inputPertama * inputKedua;
                    MessageBox.Show("Luas Jajar Genjang dengan " + inputPertama + " ALAS dan " + inputKedua + " TINGGI adalah " + total.ToString() + ".");
                }

                else
                {
                    double total = 2.0 * inputPertama + 2.0 * inputKedua;
                    MessageBox.Show("Keliling Jajar Genjang dengan " + inputPertama + " ALAS dan " + inputKedua + " SISI MIRING adalah " + total.ToString() + ".");
                }
            }

            else
            {
                if (cbRumus.SelectedIndex == 0)
                {
                    double total = 0.5 * inputPertama * inputKedua;
                    MessageBox.Show("Luas Layang-Layang dengan " + inputPertama + " DIAGONAL1 dan " + inputKedua + " DIAGONAL2 adalah " + total.ToString() + ".");
                }

                else
                {
                    double total = 2.0 * (inputPertama + inputKedua);
                    MessageBox.Show("Keliling Layang-Layang dengan " + inputPertama + " SISI A dan " + inputKedua + " SISI C adalah " + total.ToString() + ".");
                }
            }
        }
    }
}