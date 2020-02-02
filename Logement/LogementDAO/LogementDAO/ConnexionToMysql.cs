using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LogementDAO
{
    public class ConnexionToMysql
    {
        //"SERVER=" ";" "DATABASE"= ";" "UID=" ";" "PASSWORD=" ";"
        private static String connexionString = "server=localhost;port=3308;user id=root;database=mlr1mysql;";
        public static string getConnString()
        {
            return connexionString;
        }
        
        private MySqlConnection mysqlConnexion;
        private static readonly object mylock = new object();
        private static ConnexionToMysql uneInstance = null;

        //creation de la connexion
        private ConnexionToMysql(String connectionSting)
        {
            try
            {
                mysqlConnexion = new MySqlConnection(connectionSting);
            }
            catch (MySqlException me)
            {
                throw me;
            }
        }
        //instanciation de la classe
        public static ConnexionToMysql getInstance(string stringDeConnexion)
        {
            lock((mylock))
            {
                try
                {
                    if (uneInstance != null)
                    {
                        return uneInstance;
                    }
                    else
                    {
                        uneInstance = new ConnexionToMysql(stringDeConnexion);
                        return uneInstance;
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            
        }
        //ouverture de la connexion
        public void openConnexion()
        {
            try
            {
                mysqlConnexion.Open();
            }
            catch (MySqlException e)
            {

                throw e;
            }
        }
        //fermeture de la connexion
        public void closeConnexion()
        {
            try
            {
                mysqlConnexion.Close();
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }
        
        public MySqlCommand prepareCommande(string requete)
        {
            try
            {
                MySqlCommand c = new MySqlCommand(requete, mysqlConnexion);
                return c;
            }
            catch (MySqlException e)
            {

                throw e;
            }
        }
    }


}
