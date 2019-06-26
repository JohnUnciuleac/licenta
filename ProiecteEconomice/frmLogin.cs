using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace ProiecteEconomice
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private NpgsqlConnection conn;

        private string connstring = "Host = localhost; Username=postgres;Password=postgres;Database=licenta";

        private NpgsqlCommand cmd;
        private string sql = null;

        private void frmLogin_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }


        private void txtUsername_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            panel1.BackColor = Color.LightGreen;
            txtUsername.BackColor = Color.LightGreen;
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtPassword.UseSystemPasswordChar = true;
            panel2.BackColor = Color.LightGreen;
            txtPassword.BackColor = Color.LightGreen;
        }

        private void txtExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                sql = @"SELECT * FROM login(:_username,:_password)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_username", txtUsername.Text);
                cmd.Parameters.AddWithValue("_password", txtPassword.Text);

                int result = (int)cmd.ExecuteScalar();

                sql = @"SELECT NivelAcces FROM Logare WHERE Username=:_username AND Password=:_password";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_username", txtUsername.Text);
                cmd.Parameters.AddWithValue("_password", txtPassword.Text);

                int nivel = Convert.ToInt32(cmd.ExecuteScalar());

                sql = @"SELECT NumeAngajat FROM Angajat JOIN Logare ON Angajat.IdAngajat = Logare.IdAngajat WHERE Logare.Username=:_username AND Logare.Password=:_password";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_username", txtUsername.Text);
                cmd.Parameters.AddWithValue("_password", txtPassword.Text);

                string nume = Convert.ToString(cmd.ExecuteScalar());

                sql = @"SELECT PrenumeAngajat FROM Angajat JOIN Logare ON Angajat.IdAngajat = Logare.IdAngajat WHERE Logare.Username=:_username AND Logare.Password=:_password";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_username", txtUsername.Text);
                cmd.Parameters.AddWithValue("_password", txtPassword.Text);

                string prenume = Convert.ToString(cmd.ExecuteScalar());

                sql = @"SELECT Angajat.IdAngajat FROM Angajat JOIN Logare ON Angajat.IdAngajat = Logare.IdAngajat WHERE Logare.Username=:_username AND Logare.Password=:_password";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_username", txtUsername.Text);
                cmd.Parameters.AddWithValue("_password", txtPassword.Text);

                int IdAngajat = Convert.ToInt32(cmd.ExecuteScalar());

                conn.Close();

                if (result == 1 && nivel == 1)
                {
                    this.Hide();
                    frmAdmin frm = new frmAdmin(nume, prenume, IdAngajat);
                    frm.Show();
                }
                else if (result == 1 && nivel >= 2)
                {
                    this.Hide();
                    frmAngajat frm = new frmAngajat(nume, prenume, IdAngajat);
                    frm.Show();
                }
                else
                {
                    txtUsername.BackColor = Color.IndianRed;
                    panel1.BackColor = Color.IndianRed;

                    txtPassword.BackColor = Color.IndianRed;
                    panel2.BackColor = Color.IndianRed;

                    MessageBox.Show("Datele introduse sunt gresite!", "Autentificarea a esuat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Text = "username";
                    txtPassword.Text = "parola";

                    txtUsername.BackColor = Color.LightBlue;
                    panel1.BackColor = Color.LightBlue;
                    txtPassword.BackColor = Color.LightBlue;
                    panel2.BackColor = Color.LightBlue;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare: " + ex.Message, "Ceva nu a decurs conform procesului!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }

        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals(""))
            {
                txtUsername.BackColor = Color.IndianRed;
                panel1.BackColor = Color.IndianRed;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals(""))
            {
                txtPassword.BackColor = Color.IndianRed;
                panel2.BackColor = Color.IndianRed;
            }
        }
    }
}
