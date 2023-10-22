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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Tabel master = new Tabel("v_Master");
        Tabel detil = new Tabel("v_detil");

        private void ikat()
        {
            tbid.DataBindings.Add("Text", master.getBs(), "id"); ;
            tbtgl.DataBindings.Add("Text", master.getBs(), "tgl");
            tbnama.DataBindings.Add("Text", master.getBs(), "nm_peng");
            tbalamat.DataBindings.Add("Text", master.getBs(), "alamat");
            tbtelpon.DataBindings.Add("Text", master.getBs(), "no_telp");
            dgvcafe.DataSource = detil.getBs();
            tampil();
        }

        private void tampil()
        {
            detil.getBs().Filter = "id=" + tbid.Text;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ikat();
        }

        private void btnend_Click(object sender, EventArgs e)
        {
            master.getBs().MoveLast();
            tampil();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            master.getBs().MoveNext();
            tampil();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            master.getBs().MovePrevious();
            tampil();

        }

        private void btntop_Click(object sender, EventArgs e)
        {
            master.getBs().MoveLast();
            tampil();
        }
    }
}
