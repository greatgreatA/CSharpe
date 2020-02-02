using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleurLog;
using ModeleLog;


namespace LogementForm
{
    public partial class Form1 : Form
    {
        private Manager manager;

         public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            manager = new Manager();
            this.refreshLocataire();
            this.refreshLogement();
            this.refreshParc();
        }

        private void refreshLogement()
        {
            this.lbxLogements.DataSource = null;
            this.lbxLogements.DataSource = manager.getListeDeLogements();
        }

        private void refreshLocataire()
        {
            this.lbxLocataires.DataSource = null;
            this.lbxLocataires.DataSource = manager.getListeLocataires();

        }
        private void refreshParc()
        {
            this.lbxParcs.DataSource = null;
            this.lbxParcs.DataSource = manager.getListeDeParcs();
            this.cbParc.DataSource = manager.getListeDeParcs();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btSupprimeLocataire_Click(object sender, EventArgs e)
        {
            manager.supprimelocataire((Locataire)this.lbxLocataires.SelectedItem);
            refreshLocataire();
        }

        private void btAjouteLocataire_Click(object sender, EventArgs e)
        {
            manager.ajouterLocataire(Convert.ToInt32(this.tBIdLoc.Text.ToString()), this.tBNomLoc.Text.ToString(), Convert.ToDouble(this.tBRevenuMensLoc.Text.ToString()));
            refreshLocataire();
        }

        private void btAjouterLogement_Click(object sender, EventArgs e)
        {
            if (this.tBSurfMaison.TextLength != 0)
            {
                manager.ajouterMaison(Convert.ToInt32(this.tBIdLog.Text), this.tBAdrLog.Text, Convert.ToInt32(this.tBNbPieces.Text), Convert.ToDouble(this.tBLoyer.Text),Convert.ToDouble(this.tBSurfMaison.Text));
                refreshLogement();
            }
            else
            {
                manager.ajouterLogement(Convert.ToInt32(this.tBIdLog.Text), this.tBAdrLog.Text, Convert.ToInt32(this.tBNbPieces.Text), Convert.ToDouble(this.tBLoyer.Text));
                refreshLogement();
            }
        }

        private void btSupprimeLogement_Click(object sender, EventArgs e)
        {
            manager.supprimerLogement((Logement)this.lbxLogements.SelectedItem);
            refreshLogement();
        }

        private void btAjoputerParc_Click(object sender, EventArgs e)
        {
            manager.ajouterParc(Convert.ToInt32(this.txParcId.Text), this.txParcNom.Text);
            refreshParc();
        }

        private void btSupprimerParc_Click(object sender, EventArgs e)
        {
            manager.supprimeParc((Parc)this.lbxParcs.SelectedItem);
            refreshParc();
        }
    }
}


