using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCafe
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frmlap = new Form2();
            String nm = txtfilter.Text;
            frmlap.isi(nm);
            frmlap.ShowDialog();
            frmlap.Dispose();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
        }
    }
}
