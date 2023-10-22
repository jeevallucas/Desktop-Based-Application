using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRAK_ABD_TES_KECIL_3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void tbNamaBarang_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            Form1 frmlap = new Form1();
            String nm = tbNamaBarang.Text;

            frmlap.isi(nm);
            frmlap.ShowDialog();
            frmlap.Dispose();
        }
    }
}
