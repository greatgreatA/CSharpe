using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeleLog
{
    public class Maison : Logement
    {
        private double surfaceTerrain = 0.0;
        public double getSurfaceTerrain()
        {
            return this.surfaceTerrain;
        }

        public Maison():base() {    
            this.surfaceTerrain = 0.0;
        }
        

        public Maison(double uneSurfaceTerrain):base()
        {
            this.surfaceTerrain = uneSurfaceTerrain;
        }
        public Maison(int _id, string _adresse, int _nbpieces, double _loyer, double _surfaceTer) : base(_id, _adresse, -_nbpieces, _loyer)
        {
            this.surfaceTerrain = _surfaceTer;
        } 

        // B2)  cette methode n'est pas surchargée( meme designation et mêmes parametres)
        // B3 ) Cette méthode est redéfinie par le polymorphisme 
        public override string afficher()
        {
            string s = base.afficher();
            s += " La surface du terrain est de : " + this.surfaceTerrain + " .";
            return s;
        }
        public override string ToString()
        {
            return base.ToString()+ " La surface du terrain est de : " + this.surfaceTerrain + " .";
        }


    }
}
