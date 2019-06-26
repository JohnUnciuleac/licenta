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
    public partial class frmDistributieSarcini : Form
    {
        public frmDistributieSarcini()
        {
            InitializeComponent();
        }

        private NpgsqlConnection conn;
        private string connstring = "Host = localhost; Username=postgres;Password=postgres;Database=licenta";

        private NpgsqlCommand cmd;
        private string sql = null;

        private NpgsqlDataReader cititor;
        private DataTable dt;
        private string result;

        private void frmDistributieSarcini_Load(object sender, EventArgs e)
        {
            btnClose.Select();

            grdAngajati.BorderStyle = BorderStyle.None;
            grdAngajati.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            grdAngajati.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grdAngajati.DefaultCellStyle.SelectionBackColor = Color.DeepSkyBlue;
            grdAngajati.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            grdAngajati.BackgroundColor = Color.White;

            grdAngajati.EnableHeadersVisualStyles = false;
            grdAngajati.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            grdAngajati.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            grdSarcini.BorderStyle = BorderStyle.None;
            grdSarcini.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            grdSarcini.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grdSarcini.DefaultCellStyle.SelectionBackColor = Color.DeepSkyBlue;
            grdSarcini.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            grdSarcini.BackgroundColor = Color.White;

            grdSarcini.EnableHeadersVisualStyles = false;
            grdSarcini.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            grdSarcini.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            grdSC.BorderStyle = BorderStyle.None;
            grdSC.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            grdSC.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grdSC.DefaultCellStyle.SelectionBackColor = Color.DeepSkyBlue;
            grdSC.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            grdSC.BackgroundColor = Color.White;

            grdSC.EnableHeadersVisualStyles = false;
            grdSC.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            grdSC.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            grdSN.BorderStyle = BorderStyle.None;
            grdSN.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            grdSN.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grdSN.DefaultCellStyle.SelectionBackColor = Color.DeepSkyBlue;
            grdSN.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            grdSN.BackgroundColor = Color.White;

            grdSN.EnableHeadersVisualStyles = false;
            grdSN.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            grdSN.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            conn = new NpgsqlConnection(connstring);
            conn.Open();

            sql = @"SELECT IdAngajat AS Marca, NumeAngajat AS Nume_Angajat,PrenumeAngajat AS Prenume_Angajat, NumeJob AS Job FROM Angajat JOIN Job ON Angajat.IdJob = Job.IdJob ORDER BY 1 ASC";
            cmd = new NpgsqlCommand(sql, conn);

            cititor = cmd.ExecuteReader();

            dt = new DataTable("Angajati");
            dt.Load(cititor);

            DataSet dsAngajati;
            dsAngajati = new DataSet();
            dsAngajati.Tables.Add(dt);

            grdAngajati.DataSource = dsAngajati;
            grdAngajati.DataMember = "Angajati";
            grdAngajati.Refresh();

            conn.Close();

            lblAre.Text = "Angajatul " + grdAngajati.CurrentRow.Cells[1].FormattedValue.ToString() + " " +
                           grdAngajati.CurrentRow.Cells[2].FormattedValue.ToString() + " are urmatoarele sarcini:";

        }

        private void grdAngajati_SelectionChanged(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            conn.Open();

            sql = @"SELECT Asociere.IdSarcina, Descriere ,Data , Sarcina.DomeniuExperienta AS Domeniu, Recompensa FROM Complexitate JOIN Sarcina ON Complexitate.DomeniuExperienta = Sarcina.DomeniuExperienta  JOIN Asociere ON Sarcina.IdSarcina = Asociere.IdSarcina JOIN Angajat ON Asociere.IdAngajat = Angajat.IdAngajat WHERE Angajat.IdAngajat =" + grdAngajati.CurrentRow.Cells[0].FormattedValue.ToString() + " ORDER BY 1 ASC";
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

            lblAre.Text = "Angajatul " + grdAngajati.CurrentRow.Cells[1].FormattedValue.ToString() + " " +
                           grdAngajati.CurrentRow.Cells[2].FormattedValue.ToString() + " are urmatoarele sarcini:";

            conn = new NpgsqlConnection(connstring);
            conn.Open();

            sql = @"SELECT IdAngajat AS Marca, IdSarcina, Descriere, Data, Recompensa FROM SarciniCompletate WHERE IdAngajat=" + grdAngajati.CurrentRow.Cells[0].FormattedValue.ToString() + "ORDER BY 1 ASC";
            cmd = new NpgsqlCommand(sql, conn);

            cititor = cmd.ExecuteReader();

            dt = new DataTable("SC");
            dt.Load(cititor);

            DataSet dsSC;
            dsSC = new DataSet();
            dsSC.Tables.Add(dt);

            grdSC.DataSource = dsSC;
            grdSC.DataMember = "SC";
            grdSC.Refresh();

            sql = @"SELECT IdAngajat AS Marca, IdSarcina, Descriere, Data, Recompensa FROM SarciniNecompletate WHERE IdAngajat=" + grdAngajati.CurrentRow.Cells[0].FormattedValue.ToString() + "ORDER BY 1 ASC";
            cmd = new NpgsqlCommand(sql, conn);

            cititor = cmd.ExecuteReader();

            dt = new DataTable("SN");
            dt.Load(cititor);

            DataSet dsSN;
            dsSN = new DataSet();
            dsSN.Tables.Add(dt);

            grdSN.DataSource = dsSN;
            grdSN.DataMember = "SN";
            grdSN.Refresh();

            sql = @"SELECT Valoare FROM Plata WHERE IdAngajat =" +
                  grdAngajati.CurrentRow.Cells[0].FormattedValue.ToString();
            cmd = new NpgsqlCommand(sql, conn);

            result = Convert.ToString(cmd.ExecuteScalar());
            txtBonus.Text = result + " RON";

            conn.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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


            conn = new NpgsqlConnection(connstring);
            conn.Open();

            sql = @"SELECT Asociere.IdSarcina, Descriere ,Data , Sarcina.DomeniuExperienta AS Domeniu, Recompensa FROM Complexitate JOIN Sarcina ON Complexitate.DomeniuExperienta = Sarcina.DomeniuExperienta  JOIN Asociere ON Sarcina.IdSarcina = Asociere.IdSarcina JOIN Angajat ON Asociere.IdAngajat = Angajat.IdAngajat WHERE Angajat.IdAngajat =" + grdAngajati.CurrentRow.Cells[0].FormattedValue.ToString() + " ORDER BY 1 ASC";
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
        }

        private void btnAchita_Click(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            conn.Open();

            sql = @"UPDATE Plata SET Valoare = 0 WHERE IdAngajat =" + grdAngajati.CurrentRow.Cells[0].FormattedValue.ToString();
            cmd = new NpgsqlCommand(sql, conn);

            cmd.ExecuteNonQuery();

            sql = @"SELECT Valoare FROM Plata WHERE IdAngajat =" +
                  grdAngajati.CurrentRow.Cells[0].FormattedValue.ToString();
            cmd = new NpgsqlCommand(sql, conn);

            result = Convert.ToString(cmd.ExecuteScalar());
            txtBonus.Text = result + " RON";

            conn.Close();

            MessageBox.Show("Bonusul a fost resetat!", "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnValid_Click(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            conn.Open();

            sql = @"INSERT INTO SarciniCompletate VALUES(" + grdAngajati.CurrentRow.Cells[0].FormattedValue.ToString() + ", " + grdSarcini.CurrentRow.Cells[0].FormattedValue.ToString() + ",'" + grdSarcini.CurrentRow.Cells[1].FormattedValue.ToString() + "','" + grdSarcini.CurrentRow.Cells[2].FormattedValue.ToString() + "'::DATE," + grdSarcini.CurrentRow.Cells[4].FormattedValue.ToString() + ")";
            cmd = new NpgsqlCommand(sql, conn);

            cmd.ExecuteNonQuery();

            double add = 0;
            double add2 = 0;

            add = Convert.ToDouble(grdSarcini.CurrentRow.Cells[4].FormattedValue.ToString());

            sql = @"SELECT Bonus FROM Performanta WHERE IdAngajat= " +
                  grdAngajati.CurrentRow.Cells[0].FormattedValue.ToString();
            cmd = new NpgsqlCommand(sql, conn);
            add2 = Convert.ToDouble(cmd.ExecuteScalar());

            double resultAdd = add + add2;

            sql = @"UPDATE Performanta SET Bonus =" + resultAdd + " WHERE IdAngajat =" + grdAngajati.CurrentRow.Cells[0].FormattedValue.ToString();
            cmd = new NpgsqlCommand(sql, conn);

            cmd.ExecuteNonQuery();

            sql = @"DELETE FROM Asociere WHERE IdAngajat =" + grdAngajati.CurrentRow.Cells[0].FormattedValue.ToString() + " AND IdSarcina= " + grdSarcini.CurrentRow.Cells[0].FormattedValue.ToString();
            cmd = new NpgsqlCommand(sql, conn);

            cmd.ExecuteNonQuery();

            int nrSarcini = 0;

            sql = @"SELECT SarciniCompletate FROM Performanta WHERE IdAngajat =" +
                  grdAngajati.CurrentRow.Cells[0].FormattedValue.ToString();
            cmd = new NpgsqlCommand(sql, conn);

            nrSarcini = Convert.ToInt32(cmd.ExecuteScalar());
            nrSarcini++;
            sql = @"UPDATE Performanta SET SarciniCompletate =" + nrSarcini + " WHERE IdAngajat =" +
                  grdAngajati.CurrentRow.Cells[0].FormattedValue.ToString();


            sql = @"SELECT Asociere.IdSarcina, Descriere ,Data , Sarcina.DomeniuExperienta AS Domeniu, Recompensa FROM Complexitate JOIN Sarcina ON Complexitate.DomeniuExperienta = Sarcina.DomeniuExperienta  JOIN Asociere ON Sarcina.IdSarcina = Asociere.IdSarcina JOIN Angajat ON Asociere.IdAngajat = Angajat.IdAngajat WHERE Angajat.IdAngajat =" + grdAngajati.CurrentRow.Cells[0].FormattedValue.ToString() + " ORDER BY 1 ASC";
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

            sql = @"SELECT IdAngajat AS Marca, IdSarcina, Descriere, Data, Recompensa FROM SarciniCompletate WHERE IdAngajat=" + grdAngajati.CurrentRow.Cells[0].FormattedValue.ToString() + "ORDER BY 1 ASC";
            cmd = new NpgsqlCommand(sql, conn);

            cititor = cmd.ExecuteReader();

            dt = new DataTable("SC");
            dt.Load(cititor);

            DataSet dsSC;
            dsSC = new DataSet();
            dsSC.Tables.Add(dt);

            grdSC.DataSource = dsSC;
            grdSC.DataMember = "SC";
            grdSC.Refresh();

            conn.Close();
        }

        private void btnInvalid_Click(object sender, EventArgs e)
        {

            conn = new NpgsqlConnection(connstring);
            conn.Open();

            sql = @"INSERT INTO SarciniNecompletate VALUES(" + grdAngajati.CurrentRow.Cells[0].FormattedValue.ToString() + ", " + grdSarcini.CurrentRow.Cells[0].FormattedValue.ToString() + ",'" + grdSarcini.CurrentRow.Cells[1].FormattedValue.ToString() + "','" + grdSarcini.CurrentRow.Cells[2].FormattedValue.ToString() + "'::DATE," + grdSarcini.CurrentRow.Cells[4].FormattedValue.ToString() + ")";
            cmd = new NpgsqlCommand(sql, conn);

            cmd.ExecuteNonQuery();

            int nrSarcini = 0;

            sql = @"SELECT SarciniNecompletate FROM Performanta WHERE IdAngajat =" +
                  grdAngajati.CurrentRow.Cells[0].FormattedValue.ToString();
            cmd = new NpgsqlCommand(sql, conn);

            nrSarcini = Convert.ToInt32(cmd.ExecuteScalar());
            nrSarcini++;
            sql = @"UPDATE Performanta SET SarciniNecompletate =" + nrSarcini + " WHERE IdAngajat =" +
                  grdAngajati.CurrentRow.Cells[0].FormattedValue.ToString();
            cmd = new NpgsqlCommand(sql, conn);

            cmd.ExecuteNonQuery();

            sql = @"DELETE FROM Asociere WHERE IdAngajat =" + grdAngajati.CurrentRow.Cells[0].FormattedValue.ToString() + " AND IdSarcina= " + grdSarcini.CurrentRow.Cells[0].FormattedValue.ToString();
            cmd = new NpgsqlCommand(sql, conn);

            cmd.ExecuteNonQuery();


            sql = @"SELECT Asociere.IdSarcina, Descriere ,Data , Sarcina.DomeniuExperienta AS Domeniu, Recompensa FROM Complexitate JOIN Sarcina ON Complexitate.DomeniuExperienta = Sarcina.DomeniuExperienta  JOIN Asociere ON Sarcina.IdSarcina = Asociere.IdSarcina JOIN Angajat ON Asociere.IdAngajat = Angajat.IdAngajat WHERE Angajat.IdAngajat =" + grdAngajati.CurrentRow.Cells[0].FormattedValue.ToString() + " ORDER BY 1 ASC";
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

            sql = @"SELECT IdAngajat AS Marca, IdSarcina, Descriere, Data, Recompensa FROM SarciniNecompletate WHERE IdAngajat=" + grdAngajati.CurrentRow.Cells[0].FormattedValue.ToString() + "ORDER BY 1 ASC";
            cmd = new NpgsqlCommand(sql, conn);

            cititor = cmd.ExecuteReader();

            dt = new DataTable("SN");
            dt.Load(cititor);

            DataSet dsSN;
            dsSN = new DataSet();
            dsSN.Tables.Add(dt);

            grdSN.DataSource = dsSN;
            grdSN.DataMember = "SN";
            grdSN.Refresh();

            conn.Close();
        }
    }
}
