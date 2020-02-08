using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace LogementXML
{
    public class ConnexionXML
    {
        private XmlDocument xmlDocument=new XmlDocument();
        public XmlDocument getXmlDocument()
        {
            return xmlDocument;
        }
        private string fichierPath="data.xml";

        //Constructeur par défaut
        public ConnexionXML()
        {
            try
            {
                if (!File.Exists(fichierPath))
                {
                    XmlDeclaration declaration = xmlDocument.CreateXmlDeclaration("0.1", "ISO-8859-1", null);
                    xmlDocument.AppendChild(declaration);
                    XmlElement racine = xmlDocument.CreateElement("Gestion");
                    xmlDocument.AppendChild(racine);
                    xmlDocument.Save(fichierPath);
                    xmlDocument.Load(fichierPath);
                }
                else
                {
                    xmlDocument.Load(fichierPath);
                }
            }
            catch (FileLoadException ex)
            {
                throw ex;
            }
            catch (XmlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //constructeur avec nouveau nom de fichier
        public ConnexionXML(string fichier)
        {
            try
            {
                if (!File.Exists(fichier))
                {
                    XmlDeclaration declaration = xmlDocument.CreateXmlDeclaration("0.1", "ISO-8859-1", null);
                    xmlDocument.AppendChild(declaration);
                    XmlElement racine = xmlDocument.CreateElement("Gestion");
                    xmlDocument.AppendChild(racine);
                    xmlDocument.Save(fichier);
                    xmlDocument.Load(fichier);
                }
                else
                {
                    xmlDocument.Load(fichier);
                }
            }
            catch (FileLoadException ex)
            {
                throw ex;
            }
            catch (XmlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
