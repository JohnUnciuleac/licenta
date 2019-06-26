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
        }

        private void cboAngajati_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTitlu.Left = 80;
            lblTitlu.Text = "Raport detaliat pentru performanța angajatului " + cboAngajati.SelectedItem.ToString();
        }
    }
}
