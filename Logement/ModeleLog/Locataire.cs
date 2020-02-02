using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    public class Locataire
    {
        private int id;
        private string nom;
        private double revenu;
        
        public Locataire() {
            this.nom = "";
            this.revenu = 0.0;
        }
        public Locataire(int _id, string _nom, double _revenu)
        {
            this.id = _id;
            this.nom = _nom;
            this.revenu = _revenu;
        }
        public int getId() { return this.id; }
        public string getNom() { return this.nom;}
        public double getRevenu() { return this.revenu;}
        public void setRevenu(double _revenu) { this.revenu = _revenu;}
        public override string ToString()
        {
            return ("Id :"+this.id+ " Nom : " +this.nom+" Revenu :"+this.revenu );
        }
    }
}
