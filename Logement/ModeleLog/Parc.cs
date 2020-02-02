using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeleLog
{
    public class Parc
    {
        
        private string nom;
        public string getNom()
        {
            return this.nom;
        }
        private int id;
        public int getId() { return this.id; }
        
        private List<Logement> logements;
        public List<Logement> getLogements() { return this.logements;}
        public void  setListLogements(List<Logement> listeDeLogements)
        {
            this.logements = listeDeLogements;
        }

        public Parc(string nom) { 
            this.logements = new List<Logement>(0);
            this.nom = nom;
           
        }
        public Parc(int _id,string nom) { this.logements = new List<Logement>();
            this.id = _id;
            this.nom = nom;
           
        }
        public Parc(int _id, List<Logement> _logements,string nom) { this.logements = _logements;
          
            this.nom = nom;
        
        }

        // Cette méthode n'est pas surchargée la class Parc est une class mère et ne possède pas d'autres methodes afficher();
        //Cette méthode n'est pas redéfinie car c'est la seule de la classe
        public string afficher()
        {
            string str = "";
            if (this.logements.Count() != 0)
            {
                foreach (Logement log in this.logements)
                {
                    str += log.afficher() + '\n';
                }
                return str;
            }
            else
                return "Le parc est vide ...";
        }

        public void ajouterLogement(Logement unLogement) { this.logements.Add(unLogement);}
        public bool supprimerLogement(int _id)
        {
            if (rechercher(_id)!= null)
            {
                this.logements.Remove(rechercher(_id));
                
                return true;
            }
            else
                return false;
        }
        public bool supprimeLogement(Logement logement)
        {
            if (this.logements.Contains(logement))
            {
                this.logements.Remove(logement);

                return true;
            }
            else
                return false;
        }

        //Utilise la fonction find qui utilise elle-même un prédicat et renvoie un objet ou null
        public Logement rechercher(int _id)
        {
             return this.logements.Find(x => x.getid() == _id);
        }

        public void augmenterloyer(double taux)
        {
            if (this.logements.Count >= 0)
            {
                foreach (Logement logement in this.logements)
                {
                    logement.setloyer(logement.getLoyer() * (1 + taux));
                }
            }
        }
        public override string ToString()
        {
            return ("Parc Id : " + this.id +" Nom :"+this.nom);
        }
    }
}
