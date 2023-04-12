using System;
using System.Xml.Serialization;

namespace TestTask
{
    [Serializable, XmlRoot("offer")]
    public class EventOffer : Offer
    {
        [XmlAttribute("name")]
        public  string Name { get;  set; }
        [XmlAttribute("place")]
        public  string Place { get; set; }
        [XmlAttribute("hall")]
        public  string Hall { get; set; }
        [XmlAttribute("hall_part")]
        public  string HallPart { get; set; }
        [XmlAttribute("date")]
        public  DateTime date { get; set; }
        [XmlAttribute("is_premiere")]
        public  bool  IsPremiere { get; set; }
        [XmlAttribute("is_kids")]
        public bool IsForKids { get; set; }
    }
}
