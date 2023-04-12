using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using System.Xml.Serialization;

namespace TestTask
{
    [Serializable, XmlRoot("offer")]
    public class TourOffer : Offer
    {
        [XmlElement("worldRegion")]
        public string WorldRegion { get; set; }
        [XmlElement("country")]
        public string Country { get; set; }
        [XmlElement("Region")]
        public string Region { get; set; }
        [XmlElement("days")]
        public string Days { get; set; }
        [XmlElement("dataTour")]
        public string [] StartDataTour { get; set; }
        [XmlElement("name")]
        public string Name { get; set; }
        [XmlElement("hotel_stars")]
        public string HotelStars { get; set; }
        [XmlElement("Room")]
        public string Room { get; set; }
        [XmlElement("meal")]
        public string Meal { get; set; }
        [XmlElement("included")]
        public string Included { get; set; }
        [XmlElement("transport")]
        public string Transport { get; set; }
    }
}
