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
using DGVPrinterHelper;

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
            btnClose.Select();

            grdRaport.BorderStyle = BorderStyle.None;
            grdRaport.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            grdRaport.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grdRaport.DefaultCellStyle.SelectionBackColor = Color.DeepSkyBlue;
            grdRaport.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            //grdRaport.BackgroundColor = Color.White;

            grdRaport.EnableHeadersVisualStyles = false;
            grdRaport.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            grdRaport.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            conn = new NpgsqlConnection(connstring);
            conn.Open();

            sql = @"SELECT Performanta.IdAngajat AS Marca, NumeAngajat AS Nume_Angajat, PrenumeAngajat AS Prenume_Angajat, SarciniCompletate AS Sarcini_Completate, SarciniNecompletate AS Sarcini_Necompletate, Bonus FROM Performanta JOIN Angajat ON Performanta.IdAngajat = Angajat.IdAngajat ORDER BY 4 DESC, 6 DESC";
            cmd = new NpgsqlCommand(sql, conn);

            cititor = cmd.ExecuteReader();

            dt = new DataTable("Pozitie");
            dt.Load(cititor);

            DataSet dsPozitie;
            dsPozitie = new DataSet();
            dsPozitie.Tables.Add(dt);

            conn.Close();

            grdRaport.DataSource = dsPozitie;
            grdRaport.DataMember = "Pozitie";
            grdRaport.Refresh();

            foreach (DataGridViewRow row in grdRaport.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }

            //txtBonus.Width = grdRaport.Columns[5].HeaderCell.Size.Width;
            txtSC.Width = grdRaport.Columns[3].HeaderCell.Size.Width;
            txtSN.Width = grdRaport.Columns[4].HeaderCell.Size.Width;

            int nrsc = 0;
            int nrsn = 0;
            double sum = 0;
            for (int i = 0; i < grdRaport.RowCount; i++)
            {
                nrsc += Convert.ToInt32(grdRaport.Rows[i].Cells[3].FormattedValue);
                nrsn += Convert.ToInt32(grdRaport.Rows[i].Cells[4].FormattedValue);
                sum += Convert.ToDouble(grdRaport.Rows[i].Cells[5].FormattedValue);
            }
            txtSC.Text = nrsc.ToString() + " sarcini completate";
            txtSN.Text = nrsn.ToString() + " sarcini necompletate";
            txtBonus.Text = sum.ToString() + " RON";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = label1.Text;
            printer.SubTitle = string.Format("Data: {0}", DateTime.Now);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PrintRowHeaders = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.PorportionalColumns = true;
            printer.Footer = "Task Auction 2019 ";
            printer.FooterSpacing = 15;
            printer.PageSettings.Landscape = true;
            printer.PrintDataGridView(grdRaport);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
