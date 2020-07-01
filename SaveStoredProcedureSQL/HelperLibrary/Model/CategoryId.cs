using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace HelperLibrary.Model
{
    [SerializableAttribute()]    
    [XmlTypeAttribute(AnonymousType = true)]
    public class CategoryId
    {
        [XmlAttribute()]
        public string type { get; set; }
        [XmlText()]
        public byte Value { get; set; }
    }
}