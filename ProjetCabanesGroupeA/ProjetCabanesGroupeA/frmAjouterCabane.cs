using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ProjetCabanesGroupeA;


namespace ProjetCabanesGroupeA
{
    public partial class frmAjouterCabane : Form
    {
        public frmAjouterCabane()
        {
            InitializeComponent();
        }

        private void btnValide_Click(object sender, EventArgs e)
        {
            if (! (txbName.Text == "") && !(txbNbBed.Text == "") && !(txbTarif.Text == "") && !(txbAltitude.Text == ""))
            {
                var connexion = new DbConnection();
                connexion.Insert(
                    "t_cabanes",
                    "(nom_cabane,altitude,nombre_lit,douche,tarif)",
                    "("+txbName.Text+","+txbAltitude.Text+","+txbNbBed.Text+","+cbxShower.Checked+","+txbTarif.Text+")"
            );
                this.Close();

                    
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
