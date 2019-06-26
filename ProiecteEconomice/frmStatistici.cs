using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiecteEconomice
{
    public partial class frmStatistici : Form
    {
        public frmStatistici()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmRaportAngajati frm = new frmRaportAngajati();
            frm.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmRaportAngajat frm = new frmRaportAngajat();
            frm.Show();
        }
    }
}
