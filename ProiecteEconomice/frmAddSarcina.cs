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
    public partial class frmAddSarcina : Form
    {
        public frmAddSarcina()
        {
            InitializeComponent();
        }

        private NpgsqlConnection conn;
        private string connstring = "Host = localhost; Username=postgres;Password=postgres;Database=licenta";

        private NpgsqlCommand cmd;
        private string sql = null;

        private NpgsqlDataReader cititor;
        DataTable dt;

        private void frmAddSarcina_Load(object sender, EventArgs e)
        {
            txtDescriere.Select();

            conn = new NpgsqlConnection(connstring);
            conn.Open();

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
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpData_ValueChanged(object sender, EventArgs e)
        {
            dtpData.MaxDate = new DateTime(2021, 1, 1);

            if (dtpData.Value < DateTime.Today)
            {
                MessageBox.Show("Selectati o data din viitor!");
                dtpData.Value = DateTime.Today;
            }
            dtpData.CustomFormat = "yyy-MM-dd";
            dtpData.Format = DateTimePickerFormat.Custom;
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

                sql = @"INSERT INTO Sarcina (IdSarcina, Descriere, Data, DomeniuExperienta, disponibila) VALUES (DEFAULT,'" + txtDescriere.Text + "','" + dtpData.Value + "'::DATE,'" + cboDomeniu.SelectedValue.ToString() + "',true)";
                cmd = new NpgsqlCommand(sql, conn);

                cmd.ExecuteNonQuery();
                this.Close();

                conn.Close();

                MessageBox.Show("Sarcina adaugata cu succes!");
            }
        }
    }
}
