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
    public partial class frmListaSarcini : Form
    {
        public frmListaSarcini(string IdAngajat)
        {
            InitializeComponent();

            lblIdAngajat.Text = IdAngajat;
        }

        private NpgsqlConnection conn;
        private string connstring = "Host = localhost; Username=postgres;Password=postgres;Database=licenta";

        private NpgsqlCommand cmd;
        private string sql = null;

        private NpgsqlDataReader cititor;
        private DataTable dt;

        private void frmListaSarcini_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            conn.Open();

            sql = @"SELECT NumeAngajat, PrenumeAngajat FROM Angajat WHERE IdAngajat='" + lblIdAngajat.Text + "'";
            cmd = new NpgsqlCommand(sql, conn);

            cititor = cmd.ExecuteReader();

            dt = new DataTable("Sarcini");
            dt.Load(cititor);

            DataSet dsSarcini;
            dsSarcini = new DataSet();
            dsSarcini.Tables.Add(dt);


            lblNume.Text = dsSarcini.Tables[0].Rows[0][0].ToString() + " " + dsSarcini.Tables[0].Rows[0][1].ToString();

            grdSarcini.BorderStyle = BorderStyle.None;
            grdSarcini.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            grdSarcini.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grdSarcini.DefaultCellStyle.SelectionBackColor = Color.DeepSkyBlue;
            grdSarcini.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            grdSarcini.BackgroundColor = Color.White;

            grdSarcini.EnableHeadersVisualStyles = false;
            grdSarcini.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            grdSarcini.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;


            sql = @"SELECT Asociere.IdSarcina, Descriere ,Data , Sarcina.DomeniuExperienta AS Domeniu_Experienta, Recompensa FROM Complexitate JOIN Sarcina ON Complexitate.DomeniuExperienta = Sarcina.DomeniuExperienta  JOIN Asociere ON Sarcina.IdSarcina = Asociere.IdSarcina JOIN Angajat ON Asociere.IdAngajat = Angajat.IdAngajat WHERE Angajat.IdAngajat =" + lblIdAngajat.Text + " ORDER BY 1 ASC";
            cmd = new NpgsqlCommand(sql, conn);

            cititor = cmd.ExecuteReader();

            dt = new DataTable("Sarcini");
            dt.Load(cititor);

            DataSet dsSarciniP;
            dsSarciniP = new DataSet();
            dsSarciniP.Tables.Add(dt);

            grdSarcini.DataSource = dsSarciniP;
            grdSarcini.DataMember = "Sarcini";
            grdSarcini.Refresh();

            sql = @"SELECT SarciniCompletate, SarciniNecompletate, Bonus FROM Performanta JOIN Angajat ON Performanta.IdAngajat = Angajat.IdAngajat WHERE Angajat.IdAngajat='" + lblIdAngajat.Text + "'";
            cmd = new NpgsqlCommand(sql, conn);

            cititor = cmd.ExecuteReader();

            dt = new DataTable("Performanta");
            dt.Load(cititor);

            DataSet dsPerformanta;
            dsPerformanta = new DataSet();
            dsPerformanta.Tables.Add(dt);

            lblSC.Text = dsPerformanta.Tables[0].Rows[0][0].ToString();
            lblSN.Text = dsPerformanta.Tables[0].Rows[0][1].ToString();
            lblBonusPrecedent.Text = dsPerformanta.Tables[0].Rows[0][2].ToString();

            conn.Close();

            double sum = 0;

            for (int i = 0; i < grdSarcini.RowCount; i++)
            {
                string val = grdSarcini.Rows[i].Cells[4].FormattedValue.ToString();
                sum += Double.Parse(val);
            }

            label2.Text = sum.ToString() + " RON";

            lblTotalBonus.Text = (sum + Convert.ToDouble(lblBonusPrecedent.Text)).ToString() + " RON";
        }

        private void btnAnuleaza_Click(object sender, EventArgs e)
        {
            int idSarcinaStocat;
            idSarcinaStocat = Int32.Parse(grdSarcini.CurrentRow.Cells[0].FormattedValue.ToString());

            string descriere;
            descriere = grdSarcini.CurrentRow.Cells[1].FormattedValue.ToString();

            string data;
            data = grdSarcini.CurrentRow.Cells[2].FormattedValue.ToString();

            string domeniu;
            domeniu = grdSarcini.CurrentRow.Cells[3].FormattedValue.ToString();

            conn = new NpgsqlConnection(connstring);
            conn.Open();

            sql = @"INSERT INTO Sarcina VALUES(DEFAULT,'" + descriere + "','" + data + "'::DATE,'" + domeniu + "', true)";
            cmd = new NpgsqlCommand(sql, conn);

            cmd.ExecuteNonQuery();

            sql = @"DELETE FROM Asociere WHERE IdSarcina =" + idSarcinaStocat;
            cmd = new NpgsqlCommand(sql, conn);

            cmd.ExecuteNonQuery();


            MessageBox.Show("Sarcina a fost eliminata!", "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Information);


            sql = @"SELECT Asociere.IdSarcina, Descriere ,Data , Sarcina.DomeniuExperienta AS Domeniu_Experienta, Recompensa FROM Complexitate JOIN Sarcina ON Complexitate.DomeniuExperienta = Sarcina.DomeniuExperienta  JOIN Asociere ON Sarcina.IdSarcina = Asociere.IdSarcina JOIN Angajat ON Asociere.IdAngajat = Angajat.IdAngajat WHERE Angajat.IdAngajat =" + lblIdAngajat.Text + " ORDER BY 1 ASC";
            cmd = new NpgsqlCommand(sql, conn);

            cititor = cmd.ExecuteReader();

            dt = new DataTable("Sarcini");
            dt.Load(cititor);

            DataSet dsSarciniP;
            dsSarciniP = new DataSet();
            dsSarciniP.Tables.Add(dt);

            grdSarcini.DataSource = dsSarciniP;
            grdSarcini.DataMember = "Sarcini";
            grdSarcini.Refresh();

            conn.Close();

            double sum = 0;

            for (int i = 0; i < grdSarcini.RowCount; i++)
            {
                string val = grdSarcini.Rows[i].Cells[4].FormattedValue.ToString();
                sum += Double.Parse(val);
            }

            label2.Text = sum.ToString() + " RON";

            lblTotalBonus.Text = (sum + Convert.ToDouble(lblBonusPrecedent.Text)).ToString() + " RON";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grdSarcini_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idSarcinaStocat;
            idSarcinaStocat = Int32.Parse(grdSarcini.CurrentRow.Cells[0].FormattedValue.ToString());

            conn.Open();

            sql = @"SELECT Definitie FROM Complexitate JOIN Sarcina ON Complexitate.DomeniuExperienta = Sarcina.DomeniuExperienta WHERE IdSarcina =" + idSarcinaStocat;
            cmd = new NpgsqlCommand(sql, conn);

            string result = (string)cmd.ExecuteScalar();

            txtDescriere.Text = result;

            conn.Close();

        }
    }
}
