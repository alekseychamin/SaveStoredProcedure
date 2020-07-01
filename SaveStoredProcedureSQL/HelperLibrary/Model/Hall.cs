using System.Xml.Serialization;

namespace HelperLibrary.Model
{
    public class Hall
    {
        [XmlAttribute()]
        public string plan { get; set; }
        [XmlText()]
        public string Value { get; set; }
    }
}