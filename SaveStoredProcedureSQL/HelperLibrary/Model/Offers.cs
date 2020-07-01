using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace HelperLibrary.Model
{
    [XmlRoot("offers")]
    public class Offers
    {
        //[XmlArray("offers"), XmlArrayItem(ElementName = "offer", Type = typeof(Offer))]
        [XmlElement]
        public Offer[] offer { get; set; }
    }
}
