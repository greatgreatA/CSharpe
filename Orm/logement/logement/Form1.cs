using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private logementEntities1 orm;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            orm = new logementEntities1();
            init();
        }

        private void init()
        {
            initLogement();
            refreshLocataire();
            initParc();
        }


        /*****************************************************************************************************
         * 
         * Ajouter
         * 
         * ****************************************************************************************************/
        private void btAjouteLocataire_Click(object sender, EventArgs e)
        {
            
            locataire l = orm.locataires.Create();
            l.IDLOC = Convert.ToInt32(this.tBIdLoc.Text);
            l.NOM = this.tBNomLoc.Text;
            l.REVENU_MENSUEL = Convert.ToDouble(this.tBRevenuMensLoc.Text);
            orm.locataires.Add(l);
            orm.SaveChanges();
            refreshLocataire();

        }

        private void btAjouterLogement_Click(object sender, EventArgs e)
        {
            if(this.tBSurfMaison.Text.Length == 0)
            {
                logement l = orm.logements.Create();
                l.IDLOG = Convert.ToInt32(this.tBIdLog.Text);
                l.ADRESSE = this.tBAdrLog.Text;
                l.LOYER = Convert.ToDouble(this.tBLoyer.Text);
                l.NB_PIECES = Convert.ToInt32(this.tBNbPieces.Text);
                orm.logements.Add(l);
            }
            else
            {
                maison m =(maison)orm.logements.Create();
                m.IDLOG = Convert.ToInt32(this.tBIdLog.Text);
                m.ADRESSE = this.tBAdrLog.Text;
                m.LOYER = Convert.ToDouble(this.tBLoyer.Text);
                m.SURFACE_TER = Convert.ToDouble(this.tBSurfMaison.Text);

            }
            
            orm.SaveChanges();
            refreshLogement();
        }

        private void btAjoputerParc_Click(object sender, EventArgs e)
        {
            parc p = orm.parcs.Create();
            p.IPPARC = Convert.ToSByte(this.txParcId.Text);
            p.NOM = this.txParcNom.Text;
            orm.parcs.Add(p);
            orm.SaveChanges();
            refreshParc();
        }
        /*******************************************************************************************
         * 
         *      supprimer
         *      
         * *********************************************************************************/

        private void btSupprimeLocataire_Click(object sender, EventArgs e)
        {
            int l = lbxLocataires.SelectedIndex;
            locataire loc = orm.locataires.ToArray().ElementAt(l);
            orm.locataires.Remove(loc);
            orm.SaveChanges();
            refreshLocataire();
        }

        private void btSupprimeLogement_Click(object sender, EventArgs e)
        {
            int l = lbxLogements.SelectedIndex;
            logement loc = orm.logements.ToArray().ElementAt(l);
            orm.logements.Remove(loc);
            orm.SaveChanges();
            refreshLogement();
        }

        private void btSupprimerParc_Click(object sender, EventArgs e)
        {
            int p = lbxParcs.SelectedIndex;
            parc prc = orm.parcs.ToArray().ElementAt(p);
            orm.parcs.Remove(prc);
            orm.SaveChanges();
            refreshLocataire();
        }


        /***************************************************************************************************
         * 
         * refresh
         * ***************************************************************************************************/

        private void refreshLogement()
        {
            this.lbxLogements.Items.Clear();
            this.tBIdLog.Clear();
            this.tBAdrLog.Clear();
            this.tBNbPieces.Clear();
            this.tBLoyer.Clear();
            this.tBSurfMaison.Clear();
            initLogement();
        }

        private void initLogement()
        {
            
            List<logement> logements = new List<logement>();
            foreach (logement l in orm.logements.ToList())
            {
                lbxLogements.Items.Add("Id :    " + l.IDLOG + "      adresse :   " + l.ADRESSE + "     Loyer : " + l.LOYER + "       Nb pieces : " + l.NB_PIECES);
            }
        }

        private void refreshLocataire()
        {
            this.lbxLocataires.Items.Clear();
            this.tBIdLoc.Clear();
            this.tBNomLoc.Clear();
            this.tBRevenuMensLoc.Clear();
            
            List<locataire> locataires = new List<locataire>();
            foreach (locataire l in orm.locataires.ToList())
            {
                lbxLocataires.Items.Add("ID :   "+l.IDLOC+"  NOM:    " + l.NOM + "   REVENU: "+l.REVENU_MENSUEL);
            }
        }

        private void refreshParc()
        {
            this.lbxParcs.Items.Clear();
            this.txParcId.Clear();
            this.txParcNom.Clear();
            initParc();
        }
        private void initParc()
        {
            List<parc> parcs= new List<parc>();
            foreach (parc p in orm.parcs.ToList())
            {
                lbxParcs.Items.Add("ID :   " + p.IPPARC + "  NOM:    " + p.NOM);
            }
        }
    }
}
