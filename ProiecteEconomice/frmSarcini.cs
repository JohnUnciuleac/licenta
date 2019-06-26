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
    public partial class frmSarcini : Form
    {
        public frmSarcini(string Job, string IdAngajat)
        {
            InitializeComponent();

            lblIdAngajat.Text = IdAngajat;
            lblJob.Text = Job;

            if (lblJob.Text == "Administrator")
            {
                lblJob.ForeColor = Color.DarkRed;

            }
            else
            {
                lblJob.ForeColor = Color.Green;

                btnAdd.Visible = false;
                btnUpdate.Visible = false;
                btnDelete.Visible = false;
            }
            grdSarcini.Focus();
        }

        private NpgsqlConnection conn;
        private string connstring = "Host = localhost; Username=postgres;Password=postgres;Database=licenta";

        private NpgsqlCommand cmd;
        private string sql = null;

        private NpgsqlDataReader cititor;
        DataTable dt;

        private void frmSarcini_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            conn.Open();

            sql = @"SELECT IdSarcina AS Id, Descriere AS Descriere,Data AS Data, DomeniuExperienta AS Domeniu_Experienta FROM Sarcina WHERE disponibila = true ORDER BY 1 ASC";
            cmd = new NpgsqlCommand(sql, conn);

            cititor = cmd.ExecuteReader();

            dt = new DataTable("Sarcini");
            dt.Load(cititor);

            DataSet dsSarcini;
            dsSarcini = new DataSet();
            dsSarcini.Tables.Add(dt);

            grdSarcini.DataSource = dsSarcini;
            grdSarcini.DataMember = "Sarcini";
            grdSarcini.Refresh();

            conn.Close();

            grdSarcini.BorderStyle = BorderStyle.None;
            grdSarcini.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            grdSarcini.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grdSarcini.DefaultCellStyle.SelectionBackColor = Color.DeepSkyBlue;
            grdSarcini.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            grdSarcini.BackgroundColor = Color.White;

            grdSarcini.EnableHeadersVisualStyles = false;
            grdSarcini.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            grdSarcini.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            conn.Open();

            sql = @"SELECT IdSarcina AS Id, Descriere AS Descriere,Data AS Data, DomeniuExperienta AS Domeniu_Experienta FROM Sarcina WHERE disponibila = true ORDER BY 1 ASC";
            cmd = new NpgsqlCommand(sql, conn);

            cititor = cmd.ExecuteReader();

            dt = new DataTable("Sarcini");
            dt.Load(cititor);

            DataSet dsSarcini;
            dsSarcini = new DataSet();
            dsSarcini.Tables.Add(dt);

            grdSarcini.DataSource = dsSarcini;
            grdSarcini.DataMember = "Sarcini";
            grdSarcini.Refresh();

            conn.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddSarcina frm = new frmAddSarcina();
            frm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int idSarcinaStocat;
            idSarcinaStocat = Int32.Parse(grdSarcini.CurrentRow.Cells[0].FormattedValue.ToString());

            conn = new NpgsqlConnection(connstring);
            conn.Open();

            sql = @"DELETE FROM sarcina WHERE idsarcina = " + idSarcinaStocat + "";
            cmd = new NpgsqlCommand(sql, conn);

            cmd.ExecuteNonQuery();


            MessageBox.Show("Sarcina a fost stearsa!", "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Information);


            sql = @"SELECT IdSarcina AS Id, Descriere AS Descriere,Data AS Data, DomeniuExperienta AS Domeniu_Experienta FROM Sarcina WHERE disponibila = true ORDER BY 1 ASC";
            cmd = new NpgsqlCommand(sql, conn);

            cititor = cmd.ExecuteReader();

            dt = new DataTable("Sarcini");
            dt.Load(cititor);

            DataSet dsSarcini;
            dsSarcini = new DataSet();
            dsSarcini.Tables.Add(dt);

            grdSarcini.DataSource = dsSarcini;
            grdSarcini.DataMember = "Sarcini";
            grdSarcini.Refresh();

            conn.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int idSarcinaStocat;
            idSarcinaStocat = Int32.Parse(grdSarcini.CurrentRow.Cells[0].FormattedValue.ToString());

            frmUpdateSarcina frm = new frmUpdateSarcina(idSarcinaStocat);
            frm.Show();
        }

        private void btnFiltru_Click(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            conn.Open();

            sql = @"SELECT DomeniuExperienta, PermisConducere FROM Curriculum JOIN Angajat ON Curriculum.IdCurriculum = Angajat.IdCurriculum WHERE IdAngajat=" + lblIdAngajat.Text + "";
            cmd = new NpgsqlCommand(sql, conn);

            cititor = cmd.ExecuteReader();

            dt = new DataTable("DP");
            dt.Load(cititor);

            DataSet dsDP;
            dsDP = new DataSet();
            dsDP.Tables.Add(dt);

            string domeniu = dsDP.Tables[0].Rows[0][0].ToString();
            bool permis = (bool)dsDP.Tables[0].Rows[0][1];

            if (permis == true)
            {
                sql = @"SELECT IdSarcina AS Id, Descriere AS Descriere,Data AS Data, DomeniuExperienta AS Domeniu_Experienta FROM Sarcina WHERE disponibila = true AND DomeniuExperienta='" + domeniu + "' OR DomeniuExperienta='Livrari' ORDER BY 1 ASC";
                cmd = new NpgsqlCommand(sql, conn);

                cititor = cmd.ExecuteReader();

                dt = new DataTable("SarciniLiv");
                dt.Load(cititor);

                DataSet dsSarciniLiv;
                dsSarciniLiv = new DataSet();
                dsSarciniLiv.Tables.Add(dt);

                grdSarcini.DataSource = dsSarciniLiv;
                grdSarcini.DataMember = "SarciniLiv";
                grdSarcini.Refresh();

                conn.Close();
            }
            else
            {
                sql = @"SELECT IdSarcina AS Id, Descriere AS Descriere,Data AS Data, DomeniuExperienta AS Domeniu_Experienta FROM Sarcina WHERE DomeniuExperienta='" + domeniu + "' AND disponibila = true ORDER BY 1 ASC";
                cmd = new NpgsqlCommand(sql, conn);

                cititor = cmd.ExecuteReader();

                dt = new DataTable("Sarcini");
                dt.Load(cititor);

                DataSet dsSarcini;
                dsSarcini = new DataSet();
                dsSarcini.Tables.Add(dt);

                grdSarcini.DataSource = dsSarcini;
                grdSarcini.DataMember = "Sarcini";
                grdSarcini.Refresh();

                conn.Close();
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            int idSarcinaStocat;
            idSarcinaStocat = Int32.Parse(grdSarcini.CurrentRow.Cells[0].FormattedValue.ToString());

            conn = new NpgsqlConnection(connstring);
            conn.Open();

            sql = @"INSERT INTO Asociere VALUES(" + lblIdAngajat.Text + "," + idSarcinaStocat + ", CURRENT_TIMESTAMP)";
            cmd = new NpgsqlCommand(sql, conn);

            cmd.ExecuteNonQuery();

            sql = @"UPDATE Sarcina SET disponibila = false WHERE IdSarcina =" + idSarcinaStocat;
            cmd = new NpgsqlCommand(sql, conn);

            cmd.ExecuteNonQuery();
            

            MessageBox.Show("Sarcina a fost adaugata!", "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Information);


            sql = @"SELECT IdSarcina AS Id, Descriere AS Descriere,Data AS Data, DomeniuExperienta AS Domeniu_Experienta FROM Sarcina WHERE disponibila = true ORDER BY 1 ASC";
            cmd = new NpgsqlCommand(sql, conn);

            cititor = cmd.ExecuteReader();

            dt = new DataTable("Sarcini");
            dt.Load(cititor);

            DataSet dsSarcini;
            dsSarcini = new DataSet();
            dsSarcini.Tables.Add(dt);

            grdSarcini.DataSource = dsSarcini;
            grdSarcini.DataMember = "Sarcini";
            grdSarcini.Refresh();

            conn.Close();
        }
    }
}
