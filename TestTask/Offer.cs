using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace TestTask
{
    [Serializable, XmlRoot("offer")]
    public class Offer
    {
        [XmlAttribute("id")]
        public int ID { get;  set; }
        [XmlAttribute("type")]
        public string Type { get;  set; }
        [XmlAttribute("available")]
        public string Available { get;  set; }
        [XmlElement("url")]
        public string Url { get;  set; }
        [XmlElement("price")]
        public string Price { get;  set; }
        [XmlElement("currencyId")]
        public string CurrencyId { get;  set; }
        [XmlElement("categoryId")]
        public string CategoryId { get;  set; }
        [XmlElement("picture")]
        public string PictureUrl { get;  set; }
        [XmlElement("delivery")]
        public string CanBeDelivery { get;  set; }
        [XmlElement("local_delivery_cost")]
        public string LocalDeliveryCost { get; set; }
        [XmlElement("description")]
        public string Description { get; set; }
    }
}
