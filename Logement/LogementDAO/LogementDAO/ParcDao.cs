using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ModeleLog;

namespace LogementDAO
{
    public class ParcDao
    {
        private static string nomTable = "parc";
        private MySqlDataReader reader;
        private ConnexionToMysql myconx = ConnexionToMysql.getInstance(ConnexionToMysql.getConnString());
        

        public List<Parc> selectTout()
        {
            string r = "SELECT * FROM "+nomTable+" ;";
            List<Parc> liste = new List<Parc>();
            int id;
            string nom;
            myconx.openConnexion();
            reader=myconx.prepareCommande(r).ExecuteReader();
            while(reader.Read())
            {
                Parc parc;
                id = reader.GetInt32(0);
                nom = reader.GetString(1);
                parc = new Parc(id, nom);
                liste.Add(parc);
            }
            reader.Close();
            myconx.closeConnexion();
            return liste;
        }

        public void ajoute(Parc p)
        {
            string r = "INSERT INTO "+nomTable+"  VALUES("+p.getId()+" ,\"" + p.getNom() + "\") ;";

            myconx.openConnexion();
            myconx.prepareCommande(r).ExecuteNonQuery();
            myconx.closeConnexion();
        }

        public Parc find(int id )
        {
            int identifiant;
            string nom;
            string r = "SELECT * FROM "+nomTable+" WHERE id="+id+" ;";
            
            myconx.openConnexion();
            reader=myconx.prepareCommande(r).ExecuteReader();
            identifiant = reader.GetInt32(0);
            nom = reader.GetString(1);
            reader.Close();
            myconx.closeConnexion();
            return new Parc(identifiant, nom);
        }

        public void delete(int id)
        {
            string r = "DELETE  FROM "+nomTable+" WHERE ipparc=" + id + " ;";
            myconx.openConnexion();
            myconx.prepareCommande(r).ExecuteNonQuery();
            myconx.closeConnexion();
        }

        public void update(Parc parc)
        {
            string r = "UPDATE "+ nomTable +" SET nom="+parc.Nom+" WHERE id="+parc.Id +";";
            myconx.openConnexion();
            myconx.prepareCommande(r).ExecuteNonQuery();
            myconx.closeConnexion();
        }
    }
}
