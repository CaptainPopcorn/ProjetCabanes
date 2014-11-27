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

    public partial class Form1 : Form
    {      
            
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var connexion = new DbConnection();
            connexion.Insert("t_cabanes", "(nom_cabane, altitude, nombre_lit, douche, tarif)", "('cabaneTest1', 1815, 4, false, 1523)");
        }


        private void dtpDateVisite_ValueChanged(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = "SELECT * FROM t_visites WHERE id_visite =" + 2 + "AND date_visite=" + Convert.ToString(dtpDateVisite.Value);
            cmd.CommandType = CommandType.Text;

            lblRapport.Text = cmd.CommandText;
        }
    }
}
