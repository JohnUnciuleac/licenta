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
    public partial class frmRaportAngajatA : Form
    {
        public frmRaportAngajatA(string nume)
        {
            InitializeComponent();
            lblNumeRap.Text = nume;
        }

        private NpgsqlConnection conn;
        private string connstring = "Host = localhost; Username=postgres;Password=postgres;Database=licenta";

        private NpgsqlCommand cmd;
        private string sql = null;

        private NpgsqlDataReader cititor;
        private DataTable dt;

        private void frmRaportAngajatA_Load(object sender, EventArgs e)
        {
            btnClose.Select();

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


            string nume = lblNumeRap.Text;
            int position = nume.IndexOf(" ");
            string sub = nume.Substring(0, position);

            conn = new NpgsqlConnection(connstring);
            conn.Open();

            sql = @"SELECT IdAngajat FROM Angajat WHERE NumeAngajat ='" + sub + "'";
            cmd = new NpgsqlCommand(sql, conn);

            string result = Convert.ToString(cmd.ExecuteScalar());
            txtMarca.Text = result;

            sql = @"SELECT DomeniuExperienta, SalariuBaza, Bonus, Valoare FROM Angajat JOIN Performanta ON Angajat.IdAngajat = Performanta.IdAngajat JOIN Job ON Angajat.IdJob=Job.IdJob JOIN Curriculum ON Angajat.IdCurriculum=Curriculum.IdCurriculum JOIN Plata ON Angajat.IdAngajat=Plata.IdAngajat WHERE Angajat.IdAngajat ='" + txtMarca.Text + "'";
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


            sql = @"SELECT IdSarcina, Descriere, Data, Recompensa FROM SarciniCompletate WHERE IdAngajat=" + txtMarca.Text + "ORDER BY 1 ASC";
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

            sql = @"SELECT IdSarcina, Descriere, Data, Recompensa FROM SarciniNecompletate WHERE IdAngajat=" + txtMarca.Text + "ORDER BY 1 ASC";
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 60, 30);
        }

        private Bitmap bmp;

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 10, 10, this.Size);
            printPreviewDialog1.ShowDialog();
        }
    }
}
