using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using NpgsqlTypes;

namespace ProiecteEconomice
{
    public partial class frmAdmin : Form
    {
        public frmAdmin(string nume, string prenume, int IdAngajat)
        {
            InitializeComponent();
            lblNume.Text = nume + " " + prenume;
            txtNumeAngajat.Text = nume;
            txtPrenumeAngajat.Text = prenume;
            txtIdAngajat.Text = IdAngajat.ToString();
        }

        private NpgsqlConnection conn;
        private string connstring = "Host = localhost; Username=postgres;Password=postgres;Database=licenta";

        private NpgsqlCommand cmd;
        private string sql = null;

        private void pcbLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmLogin().Show();
        }

        private void pcbLogout_MouseHover(object sender, EventArgs e)
        {
            pcbLogout.BackColor = Color.IndianRed;
        }

        private void pcbLogout_MouseLeave(object sender, EventArgs e)
        {
            pcbLogout.BackColor = Color.LightBlue;
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            conn.Open();

            sql = @"SELECT NumeJob FROM Job JOIN Angajat ON Job.IdJob=Angajat.IdAngajat WHERE IdAngajat='" + txtIdAngajat.Text + "'";
            cmd = new NpgsqlCommand(sql, conn);

            String result = Convert.ToString(cmd.ExecuteScalar());
            lblJob.Text = result;


            if (result == "Administrator")
            {
                lblJob.ForeColor = Color.DarkRed;
            }
            else
            {
                lblJob.ForeColor = Color.Green;
            }

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            frmStatistici frm = new frmStatistici();
            frm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            conn.Open();

            sql = @"SELECT IdAngajat FROM Angajat WHERE IdAngajat='" + txtIdAngajat.Text + "'";
            cmd = new NpgsqlCommand(sql, conn);

            string IdAngajat = Convert.ToString(cmd.ExecuteScalar());

            conn.Close();

            frmDate frm = new frmDate(IdAngajat);
            frm.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            conn.Open();

            sql = @"SELECT NumeJob FROM Job JOIN Angajat ON Job.IdJob=Angajat.IdAngajat WHERE IdAngajat='" + txtIdAngajat.Text + "'";
            cmd = new NpgsqlCommand(sql, conn);

            String result = Convert.ToString(cmd.ExecuteScalar());

            sql = @"SELECT IdAngajat FROM Angajat WHERE IdAngajat='" + txtIdAngajat.Text + "'";
            cmd = new NpgsqlCommand(sql, conn);

            string IdAngajat = Convert.ToString(cmd.ExecuteScalar());

            conn.Close();

            frmSarcini frm = new frmSarcini(result, IdAngajat);
            frm.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            conn.Open();

            sql = @"SELECT NumeJob FROM Job JOIN Angajat ON Job.IdJob=Angajat.IdAngajat WHERE IdAngajat='" + txtIdAngajat.Text + "'";
            cmd = new NpgsqlCommand(sql, conn);

            String result = Convert.ToString(cmd.ExecuteScalar());

            sql = @"SELECT IdAngajat FROM Angajat WHERE IdAngajat='" + txtIdAngajat.Text + "'";
            cmd = new NpgsqlCommand(sql, conn);

            string IdAngajat = Convert.ToString(cmd.ExecuteScalar());

            conn.Close();

            frmListaSarcini frm = new frmListaSarcini(IdAngajat);
            frm.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmDistributieSarcini frm = new frmDistributieSarcini();
            frm.Show();
        }
    }
}
