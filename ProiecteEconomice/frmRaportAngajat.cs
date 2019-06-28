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
    public partial class frmRaportAngajat : Form
    {
        public frmRaportAngajat()
        {
            InitializeComponent();
        }

        private NpgsqlConnection conn;
        private string connstring = "Host = localhost; Username=postgres;Password=postgres;Database=licenta";

        private NpgsqlCommand cmd;
        private string sql = null;

        private NpgsqlDataReader cititor;
        private DataTable dt;

        private void frmRaportAngajat_Load(object sender, EventArgs e)
        {
            grdSC.BorderStyle = BorderStyle.None;
            grdSC.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            grdSC.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grdSC.DefaultCellStyle.SelectionBackColor = Color.DeepSkyBlue;
            grdSC.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            grdSC.RowHeadersVisible = false;

            grdSC.EnableHeadersVisualStyles = false;
            grdSC.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            grdSC.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            grdSN.BorderStyle = BorderStyle.None;
            grdSN.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            grdSN.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grdSN.DefaultCellStyle.SelectionBackColor = Color.DeepSkyBlue;
            grdSN.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            grdSN.RowHeadersVisible = false;

            grdSN.EnableHeadersVisualStyles = false;
            grdSN.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            grdSN.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            txtDom.Visible = false;
            txtSalariu.Visible = false;
            txtBA.Visible = false;
            txtBN.Visible = false;
            txtSN.Visible = false;
            txtSC.Visible = false;
            txtTotal.Visible = false;


            conn = new NpgsqlConnection(connstring);
            conn.Open();

            sql = @"SELECT IdAngajat AS Marca, NumeAngajat AS Nume, PrenumeAngajat AS Prenume FROM Angajat ORDER BY 2 ASC";
            cmd = new NpgsqlCommand(sql, conn);

            cititor = cmd.ExecuteReader();

            dt = new DataTable("NumeRap");
            dt.Load(cititor);

            DataSet dsNumeRaport;
            dsNumeRaport = new DataSet();
            dsNumeRaport.Tables.Add(dt);

            for (int i = 0; i < 10; i++)
            {
                string item = dsNumeRaport.Tables[0].Rows[i][1].ToString() + " " + dsNumeRaport.Tables[0].Rows[i][2].ToString();

                cboAngajati.Items.Add(item);
            }

            conn.Close();
        }

        private void cboAngajati_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTitlu.Left = 80;
            lblTitlu.Text = "Raport detaliat pentru performanța angajatului " + cboAngajati.SelectedItem.ToString();

            int position = cboAngajati.SelectedItem.ToString().IndexOf(" ");
            string sub = cboAngajati.SelectedItem.ToString().Substring(0, position);

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            txtDom.Visible = true;
            txtSalariu.Visible = true;
            txtBA.Visible = true;
            txtBN.Visible = true;
            txtSN.Visible = true;
            txtSC.Visible = true;
            txtTotal.Visible = true;

            conn = new NpgsqlConnection(connstring);
            conn.Open();

            sql = @"SELECT IdAngajat FROM Angajat WHERE NumeAngajat ='" + sub + "'";
            cmd = new NpgsqlCommand(sql, conn);

            string result = Convert.ToString(cmd.ExecuteScalar());


            lblId.Text = result;


            sql = @"SELECT DomeniuExperienta, SalariuBaza, Bonus, Valoare FROM Angajat JOIN Performanta ON Angajat.IdAngajat = Performanta.IdAngajat JOIN Job ON Angajat.IdJob=Job.IdJob JOIN Curriculum ON Angajat.IdCurriculum=Curriculum.IdCurriculum JOIN Plata ON Angajat.IdAngajat=Plata.IdAngajat WHERE Angajat.IdAngajat ='" + lblId.Text + "'";
            cmd = new NpgsqlCommand(sql, conn);

            cititor = cmd.ExecuteReader();

            dt = new DataTable("Det");
            dt.Load(cititor);

            DataSet dsDet;
            dsDet = new DataSet();
            dsDet.Tables.Add(dt);

            txtDom.Text = dsDet.Tables[0].Rows[0][0].ToString();
            txtSalariu.Text = dsDet.Tables[0].Rows[0][1].ToString();
            txtBA.Text = dsDet.Tables[0].Rows[0][2].ToString();
            txtBN.Text = dsDet.Tables[0].Rows[0][3].ToString();


            sql = @"SELECT IdSarcina, Descriere, Data, Recompensa FROM SarciniCompletate WHERE IdAngajat=" + lblId.Text + "ORDER BY 1 ASC";
            cmd = new NpgsqlCommand(sql, conn);

            cititor = cmd.ExecuteReader();

            dt = new DataTable("SC");
            dt.Load(cititor);

            txtSC.Text = dt.Rows.Count.ToString();

            DataSet dsSC;
            dsSC = new DataSet();
            dsSC.Tables.Add(dt);

            grdSC.DataSource = dsSC;
            grdSC.DataMember = "SC";
            grdSC.Refresh();

            sql = @"SELECT IdSarcina, Descriere, Data, Recompensa FROM SarciniNecompletate WHERE IdAngajat=" + lblId.Text + "ORDER BY 1 ASC";
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

            txtSN.Text = dt.Rows.Count.ToString();

            conn.Close();

            grdSC.ClearSelection();
            grdSN.ClearSelection();

            txtSN.Text = dt.Rows.Count.ToString();

            double add = Double.Parse(txtSalariu.Text);
            double add2 = Double.Parse(txtBN.Text);
            double sum = add + add2;

            txtTotal.Text = sum.ToString() + " RON";
        }

    }
}
