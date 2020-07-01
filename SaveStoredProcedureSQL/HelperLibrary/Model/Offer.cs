using System;
using System.Xml.Serialization;

namespace HelperLibrary.Model
{
    [XmlRootAttribute(ElementName = "offer", Namespace = "", IsNullable = false)]
    public class Offer
    {
        [XmlAttribute()]
        public long id { get; set; }
        [XmlAttribute()]
        public string type { get; set; }
        [XmlAttribute()]
        public string bid { get; set; }
        [XmlAttribute()]
        public string cbid { get; set; }
        [XmlAttribute()]
        public bool available { get; set; }
        [XmlAttribute()]
        public string url { get; set; }
        //[XmlAttribute()]
        public double? price { get; set; }
        [XmlAttribute()]
        public string currencyId { get; set; }        
        public CategoryId categoryId { get; set; }
        [XmlAttribute()]
        public string picture { get; set; }
        //[XmlAttribute()]
        public bool? delivery { get; set; }
        //[XmlAttribute()]
        public double? local_delivery_cost { get; set; }
        [XmlAttribute()]
        public string typePrefix { get; set; }
        [XmlAttribute()]
        public string vendor { get; set; }
        [XmlAttribute()]
        public string vendorCode { get; set; }
        [XmlAttribute()]
        public string model { get; set; }
        [XmlAttribute()]
        public string description { get; set; }
        [XmlAttribute()]
        public string manufacturer_warranty { get; set; }
        [XmlAttribute()]
        public string country_of_origin { get; set; }

        [XmlAttribute()]
        public string author { get; set; }
        [XmlAttribute()]
        public string name { get; set; }
        [XmlAttribute()]
        public string publisher { get; set; }
        [XmlAttribute()]
        public string series { get; set; }
        //[XmlAttribute()]
        public int? year { get; set; }
        [XmlAttribute()]
        public string ISBN { get; set; }
        [XmlAttribute()]
        public string volume { get; set; }
        [XmlAttribute()]
        public string part { get; set; }
        [XmlAttribute()]
        public string language { get; set; }
        [XmlAttribute()]
        public string binding { get; set; }
        [XmlAttribute()]
        public string page_extent { get; set; }
        [XmlAttribute()]
        public string performed_by { get; set; }
        [XmlAttribute()]
        public string performance_type { get; set; }
        [XmlAttribute()]
        public string storage { get; set; }
        [XmlAttribute()]
        public string format { get; set; }
        [XmlAttribute()]
        public string recording_length { get; set; }
        //[XmlAttribute()]
        public bool? downloadable { get; set; }

        [XmlAttribute()]
        public string artist { get; set; }
        [XmlAttribute()]
        public string title { get; set; }
        [XmlAttribute()]
        public string media { get; set; }
        [XmlAttribute()]
        public string starring { get; set; }
        [XmlAttribute()]
        public string director { get; set; }
        [XmlAttribute()]
        public string originalName { get; set; }
        [XmlAttribute()]
        public string country { get; set; }

        [XmlAttribute()]
        public string worldRegion { get; set; }
        [XmlAttribute()]
        public string region { get; set; }
        //[XmlAttribute()]
        public double? days { get; set; }
        
        [XmlIgnore]
        public DateTime? dateTourStart { get; set; }

        [XmlElement("dataTour")]
        public string dataTour 
        {
            get
            {
                return dateTourStart.HasValue ? dateTourStart.ToString() : null;
            } 
            set
            {
                DateTime dateTime;
                
                if (DateTime.TryParse(value, out dateTime))
                    dateTourStart = dateTime;
                else
                    dateTourStart = default(DateTime?);                
            } 
        }        
        
        [XmlIgnore]
        public DateTime? dateTourFinish { get => 
                (dateTourStart.HasValue && days.HasValue) ? dateTourStart.Value.AddDays(days.Value) : default(DateTime?); }

        [XmlAttribute()]
        public string hotel_stars { get; set; }
        [XmlAttribute()]
        public string room { get; set; }
        [XmlAttribute()]
        public string meal { get; set; }
        [XmlAttribute()]
        public string included { get; set; }
        [XmlAttribute()]
        public string transport { get; set; }

        [XmlAttribute()]
        public string place { get; set; }        
        public Hall hall { get; set; }
        [XmlAttribute()]
        public string hall_part { get; set; }
        
        [XmlIgnore]
        public DateTime? dateDeserialized { get; set; }

        [XmlElement("date")]
        public string date 
        {
            get 
            {
                return dateDeserialized.HasValue ? dateDeserialized.ToString() : null;
            } 
            set
            {
                DateTime dateTime;

                if (DateTime.TryParse(value, out dateTime))
                    dateDeserialized = dateTime;
                else
                    dateDeserialized = default(DateTime?);
            } 
        }
        
        //[XmlAttribute()]
        public int? is_premiere { get; set; }
        //[XmlAttribute()]
        public int? is_kids { get; set; }
    }
}
