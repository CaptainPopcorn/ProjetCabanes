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

    public partial class FrmCabanes : Form
    {      
            
        public FrmCabanes()
        {
            InitializeComponent();
            
        }

        public void PrintCabins(ListBox lbx)
        {
            var connexion = new DbConnection();
            var nbCabanes = connexion.Count("t_cabanes");
            TCabane[] cabanes = new TCabane[nbCabanes];
            lbx.Items.Clear();
            cabanes = connexion.ReadCabanes();
            
            foreach (TCabane cabane in cabanes)
            {
                lbx.Items.Add(cabane.nomCabane);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void dtpDateVisite_ValueChanged(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = "SELECT * FROM t_visites WHERE id_visite =" + 2 + "AND date_visite=" + Convert.ToString(dtpDateVisite.Value);
            cmd.CommandType = CommandType.Text;

            lblRapport.Text = cmd.CommandText;
        }

        private void BtnShowListCabin_Click(object sender, EventArgs e)
        {            
            PrintCabins(LbxCabin);
        }
        private void ajouterCabaneToolStripMenuItem_Click(object sender, EventArgs e)
        {
   
            PrintCabins(LbxCabin);
            frmAjoutCabane formAddCabane = new frmAjoutCabane();
            formAddCabane.Show();
        }
    }
}
