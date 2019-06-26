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
    public partial class frmUpdateSarcina : Form
    {
        public frmUpdateSarcina(int idSarcinaStocat)
        {
            InitializeComponent();
            txtIdSarcina.Text = idSarcinaStocat.ToString();
        }

        private NpgsqlConnection conn;
        private string connstring = "Host = localhost; Username=postgres;Password=postgres;Database=licenta";

        private NpgsqlCommand cmd;
        private string sql = null;

        private NpgsqlDataReader cititor;
        DataTable dt;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUpdateSarcina_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            conn.Open();

            sql = @"SELECT Descriere FROM Sarcina WHERE IdSarcina=" + txtIdSarcina.Text;
            cmd = new NpgsqlCommand(sql, conn);

            cititor = cmd.ExecuteReader();

            dt = new DataTable("dSarcina");
            dt.Load(cititor);

            DataSet dsDateS;
            dsDateS = new DataSet();
            dsDateS.Tables.Add(dt);

            txtDescriere.Text = dsDateS.Tables[0].Rows[0][0].ToString();

            sql = @"SELECT DomeniuExperienta FROM Complexitate ORDER BY 1 ASC";
            cmd = new NpgsqlCommand(sql, conn);

            cititor = cmd.ExecuteReader();

            dt = new DataTable("Domenii");
            dt.Load(cititor);

            DataSet dsDomenii;
            dsDomenii = new DataSet();
            dsDomenii.Tables.Add(dt);

            cboDomeniu.DataSource = dsDomenii.Tables["Domenii"];
            cboDomeniu.DisplayMember = "DomeniuExperienta";
            cboDomeniu.ValueMember = "DomeniuExperienta";

            conn.Close();

            txtDescriere.Select();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtDescriere.Text == "")
            {
                MessageBox.Show("Trebuie sa introduceti o descriere! ");
                txtDescriere.Select();
            }
            else
            {
                conn = new NpgsqlConnection(connstring);
                conn.Open();

                sql = @"UPDATE Sarcina SET Descriere='" + txtDescriere.Text + "', Data='" + dtpData.Value + "'::DATE, DomeniuExperienta='" + cboDomeniu.SelectedValue.ToString() + "' WHERE IdSarcina=" + txtIdSarcina.Text + "";
                cmd = new NpgsqlCommand(sql, conn);

                cmd.ExecuteNonQuery();
                this.Close();

                conn.Close();

                MessageBox.Show("Modificarile au fost salvate!");
            }
        }
    }
}
