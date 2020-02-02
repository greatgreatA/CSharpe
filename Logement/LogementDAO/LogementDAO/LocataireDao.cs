using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ModeleLog;

namespace LogementDAO
{
    public class LocataireDao
    {
        private static string nomTable = "locataire";
        private MySqlDataReader reader;
        private ConnexionToMysql myconx = ConnexionToMysql.getInstance(ConnexionToMysql.getConnString());

        public List<Locataire> selectTout()
        {
            string r = "SELECT * FROM " + nomTable + " ;";
            List<Locataire> liste = new List<Locataire>();
            int id;
            string nom;
            double revenu;

            myconx.openConnexion();
            reader = myconx.prepareCommande(r).ExecuteReader();
            while (reader.Read())
            {
                Locataire unLocataire;
                id = reader.GetInt32(0);
                nom = reader.GetString(1);
                revenu = reader.GetDouble(2);
                
                unLocataire = new Locataire(id, nom, revenu);
                liste.Add(unLocataire);
            }
            reader.Close();
            myconx.closeConnexion();
            return liste;
        }

        public void ajoute(Locataire l)
        {
            string r = "INSERT INTO " + nomTable + "  VALUES(null ,\"" + l.getNom() + "\"," + l.getRevenu() + ") ;";

            myconx.openConnexion();
            myconx.prepareCommande(r).ExecuteNonQuery();
            myconx.closeConnexion();
        }

        public Locataire find(int id)
        {
            
            string r = "SELECT * FROM " + nomTable + " WHERE id=" + id + " ;";

            myconx.openConnexion();
            reader = myconx.prepareCommande(r).ExecuteReader();
            int identifiant = reader.GetInt32(0);
            string nom = reader.GetString(1);
            double revenu = reader.GetDouble(2);
            reader.Close();
            myconx.closeConnexion();
            return new Locataire(identifiant, nom, revenu);
        }

        public void delete(int id)
        {
            string r = "DELETE  FROM " + nomTable + " WHERE id=" + id + " ;";
            myconx.openConnexion();
            myconx.prepareCommande(r).ExecuteNonQuery();
            myconx.closeConnexion();
        }
    }
}

