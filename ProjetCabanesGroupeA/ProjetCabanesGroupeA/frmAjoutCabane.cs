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
    public partial class frmAjoutCabane : Form
    {
        public frmAjoutCabane()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!(txtbNom.Text == "") & !(txtbAltitude.Text == "") & !(txtbNbLit.Text == "") & !(txtbTarif.Text == "")){
                var connexion = new DbConnection();
                connexion.Insert(
                    "t_cabanes", 
                    "(nom_cabane, altitude, nombre_lit, douche, tarif)", 
                    "('" + txtbNom.Text + "'," + txtbAltitude.Text + "," + txtbNbLit.Text + "," + ckbDouche.Checked + ",'" + txtbTarif.Text + "')"
                );
                frmAjoutCabane.ActiveForm.Close();
            }
        }

        private void txtbNbLit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
