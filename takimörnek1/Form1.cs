using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace takimörnek1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTrabzontakim_Click(object sender, EventArgs e)
        {
            lbltakim.Text = "TRABZONTAKİM";
            lbltakim.BackColor = Color.Red;
            lbltakim.ForeColor = Color.Blue;
              
        }

        private void btnGalatasaray_Click(object sender, EventArgs e)
        {
            lbltakim.Text = "GALATASARAY";
            lbltakim.BackColor = Color.Red;
            lbltakim.ForeColor = Color.Yellow;
        }

        private void btnfenerbahce_Click(object sender, EventArgs e)
        {
            lbltakim.Text = "FENERBAHÇE";
            lbltakim.BackColor = Color.Yellow;
            lbltakim.ForeColor = Color.Blue;

        }

        private void btnBesiktas_Click(object sender, EventArgs e)
        {
            lbltakim.Text = "BEŞİKTAŞ";
            lbltakim.BackColor = Color.Black;
            lbltakim.ForeColor = Color.White;
        }
    }
}
