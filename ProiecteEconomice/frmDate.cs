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
    public partial class frmDate : Form
    {
        public frmDate(string IdAngajat)
        {
            InitializeComponent();
            txtMarca.Text = IdAngajat;
        }


        private NpgsqlConnection conn;
        private string connstring = "Host = localhost; Username=postgres;Password=postgres;Database=licenta";

        private NpgsqlCommand cmd;
        private string sql = null;

        private NpgsqlDataReader cititor;
        DataTable dt;
        private string result;

        private void frmDate_Load(object sender, EventArgs e)
        {
            btnClose.Select();

            conn = new NpgsqlConnection(connstring);
            conn.Open();

            sql = @"SELECT NumeAngajat,PrenumeAngajat FROM Angajat WHERE IdAngajat='" + txtMarca.Text + "'";
            cmd = new NpgsqlCommand(sql, conn);

            cititor = cmd.ExecuteReader();

            dt = new DataTable("Nume");
            dt.Load(cititor);

            DataSet dsNume;
            dsNume = new DataSet();
            dsNume.Tables.Add(dt);

            txtNume.Text = dsNume.Tables[0].Rows[0][0].ToString();
            txtPrenume.Text = dsNume.Tables[0].Rows[0][1].ToString();


            sql = @"SELECT NumeDepartament FROM Departament JOIN Angajat ON Departament.IdDepartament=Angajat.IdDepartament WHERE IdAngajat='" + txtMarca.Text + "'";
            cmd = new NpgsqlCommand(sql, conn);

            result = Convert.ToString(cmd.ExecuteScalar());
            txtDepartament.Text = result;


            sql = @"SELECT NumeJob,SalariuBaza, DataLimita FROM Job JOIN Angajat ON Job.IdJob=Angajat.IdJob WHERE IdAngajat='" + txtMarca.Text + "'";
            cmd = new NpgsqlCommand(sql, conn);

            cititor = cmd.ExecuteReader();

            dt = new DataTable("Job");
            dt.Load(cititor);

            DataSet dsJob;
            dsJob = new DataSet();
            dsJob.Tables.Add(dt);

            txtJob.Text = dsJob.Tables[0].Rows[0][0].ToString();
            txtSalariu.Text = dsJob.Tables[0].Rows[0][1].ToString() + " RON";
            txtData.Text = dsJob.Tables[0].Rows[0][2].ToString();

            if (txtData.Text == "")
            {
                txtData.Text = "Nedeterminata";
            }


            sql = @"SELECT Username, Password, NivelAcces FROM Logare WHERE IdAngajat='" + txtMarca.Text + "'";
            cmd = new NpgsqlCommand(sql, conn);

            cititor = cmd.ExecuteReader();

            dt = new DataTable("Logare");
            dt.Load(cititor);

            DataSet dsLogare;
            dsLogare = new DataSet();
            dsLogare.Tables.Add(dt);

            txtUsername.Text = dsLogare.Tables[0].Rows[0][0].ToString();
            txtParola.Text = dsLogare.Tables[0].Rows[0][1].ToString();
            txtNivelAcces.Text = dsLogare.Tables[0].Rows[0][2].ToString();


            sql = @"SELECT Curriculum.IdCurriculum, Facultate, DomeniuExperienta, PermisConducere FROM Curriculum JOIN Angajat ON Curriculum.IdCurriculum = Angajat.IdCurriculum WHERE IdAngajat='" + txtMarca.Text + "'";
            cmd = new NpgsqlCommand(sql, conn);

            cititor = cmd.ExecuteReader();

            dt = new DataTable("Logare");
            dt.Load(cititor);

            DataSet dsCV;
            dsCV = new DataSet();
            dsCV.Tables.Add(dt);

            txtCV.Text = dsCV.Tables[0].Rows[0][0].ToString();
            txtFacultate.Text = dsCV.Tables[0].Rows[0][1].ToString();
            txtDomeniu.Text = dsCV.Tables[0].Rows[0][2].ToString();
            txtPermis.Text = dsCV.Tables[0].Rows[0][3].ToString();

            if (txtPermis.Text == "True")
            {
                txtPermis.Text = "DA";
            }
            else
            {
                txtPermis.Text = "NU";
            }


            sql = @"SELECT SarciniCompletate, SarciniNecompletate, Bonus FROM Performanta JOIN Angajat ON Performanta.IdAngajat = Angajat.IdAngajat WHERE Angajat.IdAngajat='" + txtMarca.Text + "'";
            cmd = new NpgsqlCommand(sql, conn);

            cititor = cmd.ExecuteReader();

            dt = new DataTable("Performanta");
            dt.Load(cititor);

            DataSet dsPerformanta;
            dsPerformanta = new DataSet();
            dsPerformanta.Tables.Add(dt);

            txtSarciniC.Text = dsPerformanta.Tables[0].Rows[0][0].ToString();
            txtSarciniN.Text = dsPerformanta.Tables[0].Rows[0][1].ToString();
            txtBonus.Text = dsPerformanta.Tables[0].Rows[0][2].ToString();

            conn.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPermis_Click(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            conn.Open();

            if (txtPermis.Text == "DA")
            {
                sql = @"UPDATE Curriculum SET PermisConducere=false WHERE IdCurriculum =" + txtMarca.Text;
                cmd = new NpgsqlCommand(sql, conn);

                cmd.ExecuteNonQuery();

                sql = @"SELECT PermisConducere FROM Curriculum JOIN Angajat ON Curriculum.IdCurriculum = Angajat.IdCurriculum WHERE IdAngajat = '" + txtMarca.Text + "'";
                cmd = new NpgsqlCommand(sql, conn);

                string result = Convert.ToString(cmd.ExecuteScalar());
                txtPermis.Text = result;

                if (txtPermis.Text == "True")
                {
                    txtPermis.Text = "DA";
                }
                else
                {
                    txtPermis.Text = "NU";
                }

                conn.Close();
            }
            else
            {
                sql = @"UPDATE Curriculum SET PermisConducere=true  WHERE IdCurriculum = '" + txtMarca.Text + "'";
                cmd = new NpgsqlCommand(sql, conn);

                cmd.ExecuteNonQuery();

                sql = @"SELECT PermisConducere FROM Curriculum JOIN Angajat ON Curriculum.IdCurriculum = Angajat.IdCurriculum WHERE IdAngajat = '" + txtMarca.Text + "'";
                cmd = new NpgsqlCommand(sql, conn);

                string result = Convert.ToString(cmd.ExecuteScalar());
                txtPermis.Text = result;

                if (txtPermis.Text == "True")
                {
                    txtPermis.Text = "DA";
                }
                else
                {
                    txtPermis.Text = "NU";
                }

                conn.Close();
            }

        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            lblOld.Visible = true;
            lblNew.Visible = true;
            lblCNew.Visible = true;
            txtPV.Visible = true;
            txtPN.Visible = true;
            txtCPN.Visible = true;
            btnOK.Visible = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtPV.Text == txtParola.Text && txtPV.Text != txtPN.Text && txtPN.Text == txtCPN.Text)
            {
                conn = new NpgsqlConnection(connstring);
                conn.Open();

                sql = @"UPDATE Logare SET Password='" + txtCPN.Text + "' WHERE IdAngajat=" + txtMarca.Text;
                cmd = new NpgsqlCommand(sql, conn);

                cmd.ExecuteNonQuery();


                MessageBox.Show("Modificarile au fost salvate!");

                lblOld.Visible = false;
                lblNew.Visible = false;
                lblCNew.Visible = false;
                txtPV.Visible = false;
                txtPN.Visible = false;
                txtCPN.Visible = false;
                btnOK.Visible = false;

                txtPV.Clear();
                txtPN.Clear();
                txtCPN.Clear();

                sql = @"SELECT Password FROM Logare WHERE IdAngajat = '" + txtMarca.Text + "'";
                cmd = new NpgsqlCommand(sql, conn);

                string result = Convert.ToString(cmd.ExecuteScalar());
                txtParola.Text = result;

                conn.Close();
            }
            else
            {
                MessageBox.Show("Verificati datele din nou!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtPV.Clear();
                txtPN.Clear();
                txtCPN.Clear();
            }
        }

        private void btnRevendica_Click(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            conn.Open();

            sql = @"UPDATE Plata SET Valoare =" + txtBonus.Text + " WHERE IdAngajat =" + txtMarca.Text;
            cmd = new NpgsqlCommand(sql, conn);

            cmd.ExecuteNonQuery();

            sql = @"UPDATE Performanta SET Bonus = 0  WHERE IdAngajat = '" + txtMarca.Text + "'";
            cmd = new NpgsqlCommand(sql, conn);

            cmd.ExecuteNonQuery();

            sql = @"SELECT Bonus FROM Performanta WHERE IdAngajat = '" + txtMarca.Text + "'";
            cmd = new NpgsqlCommand(sql, conn);

            string result = Convert.ToString(cmd.ExecuteScalar());
            txtBonus.Text = result;

            conn.Close();

            MessageBox.Show("Cererea de revendicare a fost trimisa!", "Succes!", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

        }
    }
}
