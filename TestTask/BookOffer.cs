using System;
using System.Xml.Serialization;

namespace TestTask
{
    [Serializable, XmlRoot("offer")]
    public class BookOffer : Offer
    {
        [XmlElement("author")]
        public string Author { get; set; }
        [XmlElement("name")]
        public string Name { get; set; }
        [XmlElement("publisher")]
        public string Publisher { get; set; }
        [XmlElement("series")]
        public string Series { get; set; }
        [XmlElement("year")]
        public string Year { get; set; }
        [XmlElement("ISBN")]
        public string ISBN { get; set; }
        [XmlElement("volume")]
        public string Volume { get; set; }
        [XmlElement("part")]
        public string Part { get; set; }
        [XmlElement("language")]
        public string Language { get; set; }
        [XmlElement("binding")]
        public string Binding { get; set; }
        [XmlElement("page_extent")]
        public string PageExtent { get; set; }
        [XmlElement("downloadable")]
        public string Downloadable { get; set; }
    }
}
