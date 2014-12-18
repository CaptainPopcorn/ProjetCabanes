using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ProjetCabanesGroupeA;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetCabanesGroupeA
{
    public partial class frmRappCabane : Form
    {
        public frmRappCabane()
        {
            InitializeComponent();
        }

        private void dtpDateVisite_ValueChanged(object sender, EventArgs e)
        {
            var server = "127.0.0.1";//"cfpi-r123pc01";
            var database = "cabanes";//"cabane_a";
            var uid = "root";//"UserGroupeA";
            var password = "";//"SuperCabaneA";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            var connection = new MySqlConnection(connectionString);
            //**************************************************************
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = "SELECT * FROM t_visites WHERE id_visite =" + 2 + "AND date_visite=" + Convert.ToString(dtpDateVisite.Value);
            cmd.Connection = connection;
            connection.Open();
            cmd.CommandText = "Select DISTINCT(nom_cabane) from t_visites  Join t_cabanes on t_visites.id_cabane = t_cabanes.id_cabane where date_visite =\"" + dtpDateVisite.Value.ToString("s").Substring(0, 10) + "\"";
            cmd.CommandType = CommandType.Text;
            MySqlDataReader reader = cmd.ExecuteReader();

            cbxListeCabanes.Items.Clear();

            while (reader.Read())
            {
                cbxListeCabanes.Items.Add(reader.GetFieldValue<String>(0));
            }

            cbxListeCabanes.Enabled = true;
            cbxListeCabanes.Text = "";
        }

        private void cbxListeCabanes_SelectedIndexChanged(object sender, EventArgs e)
        {
            var server = "127.0.0.1";//"cfpi-r123pc01";
            var database = "cabanes";//"cabane_a";
            var uid = "root";//"UserGroupeA";
            var password = "";//"SuperCabaneA";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            var connection = new MySqlConnection(connectionString);
            //----------------------------------------------------------------
            MySqlCommand cmd = new MySqlCommand();

            cmd.Connection = connection;
            connection.Open();
            if (rdbOui.Checked)
            {
                cmd.CommandText = "Select rapport, nom_cabane from t_visites  Join t_cabanes on t_visites.id_cabane = t_cabanes.id_cabane where date_visite =\"" + dtpDateVisite.Value.ToString("s").Substring(0, 10) + "\" and nom_cabane = \"" + cbxListeCabanes.Text + "\"";
            }
            else
            {
                cmd.CommandText = "Select rapport, nom_cabane, date_visite from t_visites  Join t_cabanes on t_visites.id_cabane = t_cabanes.id_cabane where  nom_cabane = \"" + cbxListeCabanes.Text + "\"";
            }
            cmd.CommandType = CommandType.Text;
            MySqlDataReader reader = cmd.ExecuteReader();

            tbxRapportsVisites.Text = "";

            while (reader.Read())
            {
                if (rdbNon.Checked)
                {
                    tbxRapportsVisites.Text += "Date de la visite : " + reader.GetFieldValue<DateTime>(2).ToString("s").Substring(0, 10);
                    tbxRapportsVisites.Text += Environment.NewLine;
                }
                tbxRapportsVisites.Text += "Rapport : " + reader.GetFieldValue<String>(0);
                tbxRapportsVisites.Text += Environment.NewLine;
                tbxRapportsVisites.Text += "----------------" + Environment.NewLine; ;
            }
        }

        private void rdbOui_CheckedChanged(object sender, EventArgs e)
        {
            var server = "127.0.0.1";//"cfpi-r123pc01";
            var database = "cabanes";//"cabane_a";
            var uid = "root";//"UserGroupeA";
            var password = "";//"SuperCabaneA";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            var connection = new MySqlConnection(connectionString);
            //----------------------------------------------------------------
            MySqlCommand cmd = new MySqlCommand();

            if (rdbOui.Checked)
            {
                dtpDateVisite.Enabled = true;

                cbxListeCabanes.Enabled = false;
            }
            else
            {
                dtpDateVisite.Enabled = false;

                cmd.Connection = connection;
                connection.Open();
                cmd.CommandText = "Select nom_cabane from  t_cabanes ";
                cmd.CommandType = CommandType.Text;
                MySqlDataReader reader = cmd.ExecuteReader();

                cbxListeCabanes.Items.Clear();

                while (reader.Read())
                {
                    cbxListeCabanes.Items.Add(reader.GetFieldValue<String>(0));
                }
                cbxListeCabanes.Enabled = true;

            }
        }

        private void frmRappCabane_Load(object sender, EventArgs e)
        {

        }
    }
}
