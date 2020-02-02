using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ModeleLog;

namespace LogementDAO
{
    public class LogementDao
    {
        private static string nomTable = "logement";
        private MySqlDataReader reader;
        private ConnexionToMysql myconx = ConnexionToMysql.getInstance(ConnexionToMysql.getConnString());


        public List<Logement> selectTout()
        {
            string r = "SELECT logement.IDLOG, adresse, nb_pieces, loyer, surface_ter from  logement left join maison on maison.IDLOG = logement.IDLOG;" ;
            List<Logement> liste = new List<Logement>();
            int id;
            string adresse;
            int pieces;
            double loyer;
           

            myconx.openConnexion();
            reader = myconx.prepareCommande(r).ExecuteReader();
            while (reader.Read())
            {
                Logement unLogement;
                id = reader.GetInt32(0);
                adresse = reader.GetString(1);
                pieces = reader.GetInt32(2);
                loyer = reader.GetDouble(3);
                
                if (reader.IsDBNull(4))
                    unLogement = new Logement(id, adresse, pieces, loyer);
                else
                    unLogement = new Maison(id, adresse, pieces, loyer, reader.GetDouble(4));
                
                liste.Add(unLogement);
            }
            reader.Close();
            myconx.closeConnexion();
            return liste;
        }

        public void ajoute(Logement l)
        {
            string r = "INSERT INTO " + nomTable + "  VALUES("+l.getid()+",null,null,\"" + l.getAdresse() + "\","+l.getNbPieces()+","+l.getLoyer()+") ;";

            myconx.openConnexion();
            myconx.prepareCommande(r).ExecuteNonQuery();
            myconx.closeConnexion();
        }

        public Logement find(int id)
        {
           
            string r = "SELECT * FROM " + nomTable + " WHERE id=" + id + " ;";

            myconx.openConnexion();
            reader = myconx.prepareCommande(r).ExecuteReader();
            int identifiant = reader.GetInt32(0);
            string adresse = reader.GetString(1);
            int pieces = reader.GetInt32(2);
            double loyer = reader.GetDouble(3);
            reader.Close();
            myconx.closeConnexion();
            return new Logement(identifiant, adresse, pieces, loyer);
        }

        public void delete(int id)
        {
            string r = "DELETE  FROM " + nomTable + " WHERE idlog=" + id + " ;";
            string r1 = "DELETE FROM maison WHERE IDLOG=" + id + ";";
            myconx.openConnexion();
            myconx.prepareCommande(r).ExecuteNonQuery();
            myconx.prepareCommande(r1).ExecuteNonQuery();
            myconx.closeConnexion();
        }
    }
}

