using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace TestTask
{
    [Serializable, XmlRoot("offer")]
    public class VendorOffer : Offer
    {
        [XmlElement("typePrefix")]
        public string TypePrefix { get; set; }
        [XmlElement("vendor")]
        public string Vendor { get; set; }
        [XmlElement("vendorCode")]
        public string VendorCode { get; set; }
        [XmlElement("model")]
        public string Model { get; set; }
        [XmlElement("manufacturer_warranty")]
        public string ManufacturerWarranty { get; set; }
        [XmlElement("country_of_origin")]
        public string CountryOfOrigin { get; set; }
    }
}
