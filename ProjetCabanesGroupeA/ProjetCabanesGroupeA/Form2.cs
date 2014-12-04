using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.ProjetCabanesGroupeA;

namespace ProjetCabanesGroupeA
{
    public partial class frmDetailsCabane : Form
    {
        public frmDetailsCabane()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmDetailsCabane_Load(object sender, EventArgs e)
        {
       
        }

        private void btnOK_Click(object sender, EventArgs e)
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

            cmd.Connection = connection;
            connection.Open();
            cmd.CommandText = "Select * from t_cabanes  where id_cabane=1";
            cmd.CommandType = CommandType.Text;
            MySqlDataReader reader = cmd.ExecuteReader();



            while (reader.Read())
            {
                lblNom.Text = reader.GetFieldValue<String>(1);
                lblAltitude.Text = reader.GetFieldValue<int>(2).ToString();
                lblNbLit.Text = reader.GetFieldValue<int>(3).ToString();
                lblTarif.Text = reader.GetFieldValue<String>(5) + "CHF";

                if (reader.GetFieldValue<bool>(4))
                {
                    lblDouche.Text = "Oui";
                }
                else
                {
                    lblDouche.Text = "Non";
                }

            }
        }
    }
}
