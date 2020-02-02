using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeleLog;
using LogementDAO;

using MySql.Data.MySqlClient;


namespace ControleurLog
{
    public class Manager
    {
        public LocataireDao locataireDao = new LocataireDao();
        public  LogementDao logementDao = new LogementDao();
        public  ParcDao parcDao = new ParcDao();
        public  MaisonDao maisonDao = new MaisonDao();

        // listes des proprietes et leurs acsesseurs

        private  List<Locataire> listeDeLocataire;
        public  List<Locataire> getListeLocataires()
        {
            return this.listeDeLocataire;
        }
        private  List<Logement> listeDeLogements;
        public  List<Logement> getListeDeLogements()
        {
            return listeDeLogements;
        }
        private  List<Parc> listeDeParcs;
        public  List<Parc> getListeDeParcs()
        {
            return listeDeParcs;
        }
        //serialisation
       /* public  void sauvegarde()
        {
            FileStream stream = new FileStream("data", FileMode.Create);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(stream, listeDeLocataire);
            binaryFormatter.Serialize(stream, listeDeLogements);
            binaryFormatter.Serialize(stream, listeDeParcs);
            stream.Close();

        }*/

        public  void chargement()
        {
            listeDeLocataire = locataireDao.selectTout();
            listeDeLogements = logementDao.selectTout(); ;
            listeDeParcs = parcDao.selectTout();
            

        }

        //Constructeur du Manager manager
        public Manager()
        {
            listeDeLocataire = new List<Locataire>();
            listeDeLogements = new List<Logement>();
            listeDeParcs = new List<Parc>();
        }
        // Methodes du manager 
        public  void ajouterLocataire(int id, string nom, double revenuMens)
        {
           this.listeDeLocataire.Add(new Locataire(id, nom, revenuMens));
        }
        public  void supprimelocataire(int index)
        {
            this.listeDeLocataire.RemoveAt(index);
        }
        public  void ajouterLogement(int id, string adresse, int nbpieces, double loyer)
        {
            this.listeDeLogements.Add(new Logement(id, adresse, nbpieces, loyer));
        }
        public  void ajouterLogement(int id, string adresse, int nbpieces, double loyer, double surfaceTerrain)
        {
            this.listeDeLogements.Add(new Maison(id, adresse, nbpieces, loyer, surfaceTerrain));
        }
        public  void suppprimerLogement(int index)
        {
            this.listeDeLogements.RemoveAt(index);
        }
        public  void ajouterParc(int id,string name, List<Logement> _listeDeLogement)
        {
            this.listeDeParcs.Add(new Parc(id,_listeDeLogement,name));
        }
        public  void ajouterParc(int id , string name)
        {
            this.listeDeParcs.Add(new Parc(id,name));
        }
        public  void supprimeParc(int index)
        {
            listeDeParcs.RemoveAt(index);
        }
        public  bool affecterLocataireALogement(Locataire locataire, Logement logement)
        {
            return logement.setLocataire(locataire);
        }
        public  void affecterLogementAParc(Logement logement, Parc parc)
        {
            parc.ajouterLogement(logement);
        }
        public  void desaffecterUnLogementDunParc(Logement logement, Parc parc)
        {
            parc.supprimeLogement(logement);
        }
    }




    /*private static string connexionString = "server=localhost;port=3306;user id=root;database=mlr13";
    public static ConnexionToMysql laconnexion;
    public static MySqlCommand lacommande;
    public static MySqlDataReader reader;
    public static DataTable dataTable;
    public static DataTable listeTables;


    public static DataTable listeDesTables()
    {
        if (laconnexion != null)
        {
            lacommande = laconnexion.prepareCommande("SHOW TABLES ;");
            reader = lacommande.ExecuteReader();
            listeTables = creeDataTable(reader);
            return listeTables;
        }
        return null;
    }
    public static void ouvreConnexion()
    {
        if (laconnexion != null)
            laconnexion.openConnexion();
        else
        {
            laconnexion = ConnexionToMysql.getInstance(connexionString);
            laconnexion.openConnexion();
        }

    }
    public static void fermeConnexion()
    {
        if (laconnexion != null)
            laconnexion.closeConnexion();
    }


    //initialise la data table 
    public static void  lanceRequeteGenerale(string requete)
    {
        if(laconnexion!=null)
        {
            lacommande=laconnexion.prepareCommande(requete);
            reader=lacommande.ExecuteReader();
            dataTable = creeDataTable(reader);
        }
    }

    //utilitaire de creation de datatbles
    private static DataTable creeDataTable(MySqlDataReader r)
    {
        int c = r.FieldCount;
        DataTable dt = new DataTable();
        for (int i = 0; i < c; i++)
        {
            DataColumn col = new DataColumn(r.GetName(i));
            dt.Columns.Add(col);
        }
        while(r.Read())
        {
            DataRow row = dt.NewRow();
            for (int j = 0; j < c; j++)
            {
                row[j] = r.GetValue(j);
            }
            dt.Rows.Add(row);
        }
        r.Close();
        return dt;
    }


    //on recupère tout le temps la datatable 
    public static void ajouteLocataire(string nom, string prenom, double revenuMensuel)
    {
        try
        {
            if (laconnexion != null)
            {
                lanceRequeteGenerale(LocataireDaooldd.insert(nom, prenom, revenuMensuel));
            }
            else
            {
                ouvreConnexion();
                lanceRequeteGenerale(LocataireDaooldd.insert(nom, prenom, revenuMensuel));


            }
        }
        catch (Exception ex)
        {

            throw ex ;
        }

    }
    public static void supprimeLocataire(int numid)
    {
        if (laconnexion != null)
        {
            lanceRequeteGenerale(LocataireDaooldd.delete(numid));
        }
        else
        {
            ouvreConnexion();
            lanceRequeteGenerale(LocataireDaooldd.delete(numid));


        }
    }
    public static DataTable recupereLocataires()
    {
        if (laconnexion != null)
        {
            lanceRequeteGenerale(LocataireDaooldd.selectAll());
            return dataTable;
        }
        else
        {
            ouvreConnexion();
            lanceRequeteGenerale(LocataireDaooldd.selectAll());
            return dataTable;
        }
    }
    public static void ajouteLogement(string adresse, string codePostal, string ville, int nbpieces,double loyer,double surface=0)
    {
        if (laconnexion != null)
        {
            lanceRequeteGenerale(LogementDaoOld.insert(adresse,codePostal,ville,nbpieces,loyer,surface));
        }
        else
        {
            ouvreConnexion();
            lanceRequeteGenerale(LogementDaoOld.insert(adresse, codePostal, ville, nbpieces, loyer, surface));


        }
    }
    public static void supprimeLogement(int numid)
    {
        if (laconnexion != null)
        {
            lanceRequeteGenerale(LogementDaoOld.delete(numid));
        }
        else
        {
            ouvreConnexion();
            lanceRequeteGenerale(LogementDaoOld.delete(numid));


        }
    }
    public static DataTable recupereLogements()
    {
        if (laconnexion != null)
        {
            lanceRequeteGenerale(LogementDaoOld.selectAll());
            return dataTable;
        }
        else
        {
            ouvreConnexion();
            lanceRequeteGenerale(LogementDaoOld.selectAll());
            return dataTable;
        }
    }
    public static void ajouteParc(string nom)
    {
        if (laconnexion != null)
        {
            lanceRequeteGenerale(ParcDao.insert(nom));
        }
        else
        {
            ouvreConnexion();
            lanceRequeteGenerale(ParcDao.insert(nom));


        }
    }
    public static void supprimeParc(int numid)
    {
        if (laconnexion != null)
        {
            lanceRequeteGenerale(ParcDao.delete(numid));
        }
        else
        {
            ouvreConnexion();
            lanceRequeteGenerale(ParcDao.delete(numid));


        }
    }
    public static DataTable recupereParcs()
    {
        if (laconnexion != null)
        {
            lanceRequeteGenerale(ParcDao.selectAll());
            return dataTable;
        }
        else
        {
            ouvreConnexion();
            lanceRequeteGenerale(ParcDao.selectAll());
            return dataTable;
        }
    }*/
}

