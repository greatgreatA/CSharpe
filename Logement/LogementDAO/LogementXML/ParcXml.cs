using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using ModeleLog;

namespace LogementXML
{
    public class ParcXml
    {
        private static ConnexionXML parcConnexion = new ConnexionXML("parc.xml");
        private static XmlDocument xmlDocument = parcConnexion.getXmlDocument();

        public List<Parc> selectAll()
        {
            List<Parc> res = new List<Parc>();
            foreach (XmlNode node  in xmlDocument.ChildNodes[1].FirstChild)
            {
                Parc parc = new Parc();
                parc.Id = Int32.Parse(node.ChildNodes[0].InnerText);
                parc.Nom = node.ChildNodes[1].InnerText;
                res.Add(parc);
            }
            return res;
        }

        public Parc find(int id)
        {
            // juste pour que le compilateur ne couine pas lors des tests merci 

            Parc test = new Parc();
            return test;
        }
         public void ajoute(Parc parc)
        {

        }
        public void delete(int id)
        {

        }
        public void update(int id)
        {

        }
        
    }
}
