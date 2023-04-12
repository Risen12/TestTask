using System;
using System.Xml.Serialization;

namespace TestTask
{
    [Serializable, XmlRoot("offer")]
    public class ArtistTitleOffer : Offer
    {
        [XmlElement("artist")]
        public string Artist { get;  set; }
        [XmlElement("title")]
        public string Title { get;  set; }
        [XmlElement("year")]
        public string Year { get;  set; }
        [XmlElement("media")]
        public string Media { get;  set; }
        [XmlElement("starring")]
        public string Starring { get; set; }
        [XmlElement("director")]
        public string Director { get; set; }
        [XmlElement("originalName")]
        public string OriginalName { get; set; }
        [XmlElement("country")]
        public string Country { get; set; }

    }
}
