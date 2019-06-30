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
    public partial class frmStatisticiAngajat : Form
    {
        public frmStatisticiAngajat(string nume)
        {
            InitializeComponent();
            lblNume.Text = nume;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmRaportAngajatA frm = new frmRaportAngajatA(lblNume.Text);
            frm.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frmRaportDomenii frm = new frmRaportDomenii();
            frm.Show();
        }
    }
}
