using System;
using System.Xml.Serialization;

namespace HelperLibrary.Model
{
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
        
        public string url { get; set; }
        
        public double? price { get; set; }
        
        public string currencyId { get; set; }        
        public CategoryId categoryId { get; set; }
        
        public string picture { get; set; }
        
        public bool? delivery { get; set; }
        
        public double? local_delivery_cost { get; set; }
        
        public string typePrefix { get; set; }
        
        public string vendor { get; set; }
        
        public string vendorCode { get; set; }
        
        public string model { get; set; }
        
        public string description { get; set; }
        
        public bool? manufacturer_warranty { get; set; }
        
        public string country_of_origin { get; set; }

        
        public string author { get; set; }
        
        public string name { get; set; }
        
        public string publisher { get; set; }
        
        public string series { get; set; }
        
        public int? year { get; set; }
        
        public string ISBN { get; set; }
        
        public string volume { get; set; }
        
        public string part { get; set; }
        
        public string language { get; set; }
        
        public string binding { get; set; }
        
        public string page_extent { get; set; }
        
        public string performed_by { get; set; }
        
        public string performance_type { get; set; }
        
        public string storage { get; set; }
        
        public string format { get; set; }
        
        public string recording_length { get; set; }
        
        public bool? downloadable { get; set; }

        
        public string artist { get; set; }
        
        public string title { get; set; }
        
        public string media { get; set; }
        
        public string starring { get; set; }
        
        public string director { get; set; }
        
        public string originalName { get; set; }
        
        public string country { get; set; }

        
        public string worldRegion { get; set; }
        
        public string region { get; set; }
        
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

        
        public string hotel_stars { get; set; }
        
        public string room { get; set; }
        
        public string meal { get; set; }
        
        public string included { get; set; }
        
        public string transport { get; set; }

        
        public string place { get; set; }        
        public Hall hall { get; set; }
        
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
        
        
        public int? is_premiere { get; set; }
        
        public int? is_kids { get; set; }
    }
}
