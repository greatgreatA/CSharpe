using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Modele;

namespace LogementDB.dao
{
    public class MaisonDao
    {
        private static string nomTable = "maison";
        private MySqlDataReader reader;
        private ConnexionToMysql myconx = ConnexionToMysql.getInstance(ConnexionToMysql.getConnString());


        public List<Logement> selectTout()
        {
            string r = "SELECT idlogement, adresse, nobpieces, loyer, surface_terrain FROM " + nomTable + "NATURAL JOIN logement ;";
            List<Logement> liste = new List<Logement>();
            int id;
            string adresse;
            int pieces;
            double loyer;
            double surfaceT;

            myconx.openConnexion();
            reader = myconx.prepareCommande(r).ExecuteReader();
            while (reader.Read())
            {
                Maison uneMaison;
                id = reader.GetInt32(0);
                adresse = reader.GetString(3);
                pieces = reader.GetInt32(4);
                loyer = reader.GetDouble(5);
                surfaceT = reader.GetDouble(7);
                uneMaison = new Maison(id, adresse, pieces, loyer,surfaceT);
                liste.Add(uneMaison);
            }
            reader.Close();
            myconx.closeConnexion();
            return liste;
        }

        public void ajoute(Maison m)
        {
            string r = "INSERT INTO logement  VALUES(null ,\"" + m.getAdresse() + "\"," + m.getNbPieces() + "," + m.getLoyer() + ") ;";
            string r1= "INSERT INTO "+ nomTable+"  VALUES(( SELECT idlogement from logement WHERE  adresse=\""+m.getAdresse()+"\" AND nbpieces ="+m.getNbPieces()+"," + m.getSurfaceTerrain()+ ") ;";

            myconx.openConnexion();
            myconx.prepareCommande(r).ExecuteNonQuery();
            myconx.prepareCommande(r1).ExecuteNonQuery();
            myconx.closeConnexion();
        }

        public Logement find(int id)
        {

            string r = "SELECT idlogement, adresse, nobpieces, loyer, surface_terrain FROM " + nomTable + "NATURAL JOIN logement WHERE idlogement="+id+ ";";

            myconx.openConnexion();
            reader = myconx.prepareCommande(r).ExecuteReader();
            int identifiant = reader.GetInt32(0);
            string adresse = reader.GetString(3);
            int pieces = reader.GetInt32(4);
            double loyer = reader.GetDouble(5);
            double surfaceT = reader.GetDouble(7);
            reader.Close();
            myconx.closeConnexion();
            return new Maison(identifiant, adresse, pieces, loyer,surfaceT);
        }

        public void delete(int id)
        {
            string r = "DELETE  FROM " + nomTable + " WHERE id=" + id + " ;";
            string r1 = "DELETE FROM  logement WHERE id="+id+";";

            myconx.openConnexion();
            myconx.prepareCommande(r).ExecuteNonQuery();
            myconx.prepareCommande(r1).ExecuteNonQuery();
            myconx.closeConnexion();
        }
    }
}

