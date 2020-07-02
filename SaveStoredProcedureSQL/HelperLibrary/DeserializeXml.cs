using HelperLibrary.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace HelperLibrary
{
    public class DeserializeXml
    {
        public static Offers DeserializeFormXml(string fileName)
        {
            var output = new Offers();

            using (var xmlTextReader = new XmlTextReader(fileName))
            {
                //xmlTextReader.WhitespaceHandling = WhitespaceHandling.None;

                if (xmlTextReader.ReadToDescendant("offers"))
                {
                    var xmlSerialize = new XmlSerializer(typeof(Offers));
                    output = (Offers)xmlSerialize.Deserialize(xmlTextReader.ReadSubtree());

                    return output;
                }
            }

            return output;
        }
    }
}
