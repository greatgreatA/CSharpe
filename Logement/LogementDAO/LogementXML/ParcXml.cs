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
            foreach (XmlNode node  in xmlDocument.ChildNodes[1].FirstChild)
            {
                Parc parc = new Parc();
            }
        }
        
    }
}
