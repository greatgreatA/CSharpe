using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeleLog
{
    public class Logement
    {
        protected int id = 0;
        public int getid() { return this.id; }
        
        protected string adresse ="";
        public string getAdresse()
        {
            return this.adresse;
        }
        
        protected int nbPieces = 0;
        public int getNbPieces()
        {
            return this.nbPieces;
        }
        protected double loyer = 0.0;
       
        public void setloyer(double _loyer) { this.loyer = _loyer;}
        public double getLoyer() { return this.loyer; }
        
        protected Locataire locataire =null;
        public bool setLocataire(Locataire unLocataire) {
            if (unLocataire.getRevenu() > this.loyer * 3)
            {
                this.locataire = unLocataire;
                return true;
            }
            else
                return false;
        }
        public Locataire getLocataire() {
            if (this.locataire != null)
                return this.locataire;
            else
                throw new Exception("Aucun locataire n'existe pour ce logement ...");
        }

        public Logement() { this.id = 0; this.adresse = "";this.nbPieces = 0;this.loyer = 0.0; }
        public Logement( int _id, string _adresse, int _nbpieces, double _loyer)
        {
            this.id = _id;
            this.adresse = _adresse;
            this.nbPieces = _nbpieces;
            this.loyer = _loyer;
        }
        virtual public string afficher()
        {
            string str = "Id : " + this.id + " Logement situé au : " + this.adresse + " contient : " + this.nbPieces + " pieces, pour un loyer de : " + this.loyer + "";
            return str;
        }
        public override string ToString()
        {
            string []tab = this.GetType().ToString().Split('.');
            string str = "Id : " + this.id + " "+ tab[tab.Length -1] +" situé au : " + this.adresse + " contient : " + this.nbPieces + " pieces, pour un loyer de : " + this.loyer + " ";
            return str;
        }

    }
}
