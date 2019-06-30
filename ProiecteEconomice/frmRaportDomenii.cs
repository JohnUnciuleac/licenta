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
    public partial class frmRaportDomenii : Form
    {
        public frmRaportDomenii()
        {
            InitializeComponent();
        }

        private NpgsqlConnection conn;
        private string connstring = "Host = localhost; Username=postgres;Password=postgres;Database=licenta";

        private NpgsqlCommand cmd;
        private string sql = null;

        private NpgsqlDataReader cititor;
        private DataTable dt;

        private void frmRaportDomenii_Load(object sender, EventArgs e)
        {
            label5.Visible = false;
            label7.Visible = false;
            txtVal.Visible = false;

            btnClose.Select();

            grdTop.BorderStyle = BorderStyle.None;
            grdTop.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            grdTop.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grdTop.DefaultCellStyle.SelectionBackColor = Color.DeepSkyBlue;
            grdTop.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            grdTop.RowHeadersVisible = false;

            grdTop.EnableHeadersVisualStyles = false;
            grdTop.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            grdTop.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

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

            grdSarcini.BorderStyle = BorderStyle.None;
            grdSarcini.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            grdSarcini.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grdSarcini.DefaultCellStyle.SelectionBackColor = Color.DeepSkyBlue;
            grdSarcini.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            grdSarcini.RowHeadersVisible = false;

            grdSarcini.EnableHeadersVisualStyles = false;
            grdSarcini.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            grdSarcini.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            conn = new NpgsqlConnection(connstring);
            conn.Open();

            sql = @"SELECT domeniuexperienta AS Domeniu, COUNT(domeniuexperienta) AS Numar_Total FROM sarcina WHERE data BETWEEN '2018-06-01' AND '2029-07-20' GROUP BY domeniuexperienta ORDER BY 2 DESC, 1 ASC";
            cmd = new NpgsqlCommand(sql, conn);

            cititor = cmd.ExecuteReader();

            dt = new DataTable("Top");
            dt.Load(cititor);

            DataSet dsTop;
            dsTop = new DataSet();
            dsTop.Tables.Add(dt);

            grdTop.DataSource = dsTop;
            grdTop.DataMember = "Top";
            grdTop.Refresh();

            sql = @"SELECT domeniuexperienta AS Domeniu, COUNT(domeniuexperienta) AS Numar_Total FROM sarcinicompletate JOIN sarcina ON sarcinicompletate.idsarcina = sarcina.idsarcina GROUP BY domeniuexperienta";
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

            sql = @"SELECT domeniuexperienta AS Domeniu, COUNT(domeniuexperienta) AS Numar_Total FROM sarcininecompletate JOIN sarcina ON sarcininecompletate.idsarcina = sarcina.idsarcina GROUP BY domeniuexperienta";
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

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (dtpDataStop.Value < dtpDataStart.Value)
            {
                MessageBox.Show("Data trebuie să fie mai mare decât data de start!", "Eroare!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                conn = new NpgsqlConnection(connstring);
                conn.Open();

                sql =
                    @"SELECT domeniuexperienta AS Domeniu, COUNT(domeniuexperienta) AS Numar_Total FROM sarcina WHERE data BETWEEN '" +
                    dtpDataStart.Value + "'::DATE AND '" + dtpDataStop.Value +
                    "'::DATE GROUP BY domeniuexperienta ORDER BY 2 DESC, 1 ASC";
                cmd = new NpgsqlCommand(sql, conn);

                cititor = cmd.ExecuteReader();

                dt = new DataTable("TopF");
                dt.Load(cititor);

                DataSet dsTopF;
                dsTopF = new DataSet();
                dsTopF.Tables.Add(dt);

                grdTop.DataSource = dsTopF;
                grdTop.DataMember = "TopF";
                grdTop.Refresh();

                conn.Close();
            }
        }

        private void btnAnuleaza_Click(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            conn.Open();

            sql = @"SELECT domeniuexperienta AS Domeniu, COUNT(domeniuexperienta) AS Numar_Total FROM sarcina WHERE data BETWEEN '2018-06-01' AND '2029-07-20' GROUP BY domeniuexperienta ORDER BY 2 DESC, 1 ASC";
            cmd = new NpgsqlCommand(sql, conn);

            cititor = cmd.ExecuteReader();

            dt = new DataTable("Top");
            dt.Load(cititor);

            DataSet dsTop;
            dsTop = new DataSet();
            dsTop.Tables.Add(dt);

            grdTop.DataSource = dsTop;
            grdTop.DataMember = "Top";
            grdTop.Refresh();

            conn.Close();
        }

        private void grdTop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label5.Visible = true;
            label7.Visible = true;
            txtVal.Visible = true;

            conn = new NpgsqlConnection(connstring);
            conn.Open();

            sql = @"SELECT IdSarcina, Descriere, Data FROM sarcina WHERE DomeniuExperienta ='" + grdTop.CurrentRow.Cells[0].FormattedValue.ToString() + "' ORDER BY 3 ASC";
            cmd = new NpgsqlCommand(sql, conn);

            cititor = cmd.ExecuteReader();

            dt = new DataTable("Sarcini");
            dt.Load(cititor);

            DataSet dsSar;
            dsSar = new DataSet();
            dsSar.Tables.Add(dt);

            grdSarcini.DataSource = dsSar;
            grdSarcini.DataMember = "Sarcini";
            grdSarcini.Refresh();

            sql = @"SELECT SUM (recompensa) FROM sarcina JOIN complexitate on sarcina.domeniuexperienta = complexitate.domeniuexperienta where sarcina.domeniuexperienta ='" + grdTop.CurrentRow.Cells[0].FormattedValue.ToString() + "'";
            cmd = new NpgsqlCommand(sql, conn);
            int result = Convert.ToInt32(cmd.ExecuteScalar());

            txtVal.Text = result.ToString() + " RON";

            conn.Close();
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
