using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetCabanesGroupeA
{
    public partial class frmCommentaireCabane : Form
    {
        private int idCabaneG;
        private string nomCabaneG;

        public frmCommentaireCabane(int idCabane, string nomCabane)
        {
            InitializeComponent();
            idCabaneG = idCabane;
            nomCabaneG = nomCabane;
        }
 

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void frmCommentaireCabane_Load(object sender, EventArgs e)
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
            cmd.CommandText = "Select commentaire from t_commentaires where id_cabane=" + idCabaneG.ToString();
            cmd.CommandType = CommandType.Text;
            MySqlDataReader reader = cmd.ExecuteReader();



            while (reader.Read())
            {
                lblCommentaire.Text = reader.GetFieldValue<String>(0);
            }
            lblNom.Text = nomCabaneG;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
