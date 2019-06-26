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
    public partial class frmRaportP : Form
    {
        public frmRaportP()
        {
            InitializeComponent();
        }

        private NpgsqlConnection conn;

        private string connstring = "Host = localhost; Username=postgres;Password=postgres;Database=licenta";

        private void frmRaportP_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            conn.Open();

            // TODO: This line of code loads data into the 'dsRaportP.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.DataSetRP.DataTable1);

            this.reportViewer1.RefreshReport();
        }
        
    }
}
