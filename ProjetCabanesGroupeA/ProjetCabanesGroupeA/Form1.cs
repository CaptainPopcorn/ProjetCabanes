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


namespace ProjetCabanesGroupeA
{

    public partial class Form1 : Form
    {
        
        //string[] cabane = { "1", "First Cabane", "1230", "13", "false", "200", "yolo" };        
            
        public Form1()
        {
            InitializeComponent();
   
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private void dtpDateVisite_ValueChanged(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = "SELECT * FROM t_visites WHERE id_visite =" + list[0] + "AND date_visite=" + Convert.ToString(dtpDateVisite.Value);
            cmd.CommandType = CommandType.Text;

            lblRapport.Text = cmd.CommandText;
        }
    }
}
