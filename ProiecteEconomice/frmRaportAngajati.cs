using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  Npgsql;

namespace ProiecteEconomice
{
    public partial class frmRaportAngajati : Form
    {
        public frmRaportAngajati()
        {
            InitializeComponent();
        }

        private NpgsqlConnection conn;
        private string connstring = "Host = localhost; Username=postgres;Password=postgres;Database=licenta";

        private NpgsqlCommand cmd;
        private string sql = null;

        private NpgsqlDataReader cititor;
        private DataTable dt;

        private void frmRaportAngajati_Load(object sender, EventArgs e)
        {

            grdRaport.BorderStyle = BorderStyle.None;
            grdRaport.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            grdRaport.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grdRaport.DefaultCellStyle.SelectionBackColor = Color.DeepSkyBlue;
            grdRaport.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            grdRaport.BackgroundColor = Color.White;

            grdRaport.EnableHeadersVisualStyles = false;
            grdRaport.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            grdRaport.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            conn = new NpgsqlConnection(connstring);
            conn.Open();

            sql = @"SELECT Performanta.IdAngajat AS Marca, NumeAngajat AS Nume_Angajat, PrenumeAngajat AS Prenume_Angajat, SarciniCompletate AS Sarcini_Completate, SarciniNecompletate AS Sarcini_Necompletate, Bonus FROM Performanta JOIN Angajat ON Performanta.IdAngajat = Angajat.IdAngajat ORDER BY 4 DESC";
            cmd = new NpgsqlCommand(sql, conn);

            cititor = cmd.ExecuteReader();

            dt = new DataTable("Pozitie");
            dt.Load(cititor);

            DataSet dsPozitie;
            dsPozitie = new DataSet();
            dsPozitie.Tables.Add(dt);

            grdRaport.DataSource = dsPozitie;
            grdRaport.DataMember = "Pozitie";
            grdRaport.Refresh();
        }
    }
}
