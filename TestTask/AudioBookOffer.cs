using System;
using System.Xml.Serialization;

namespace TestTask
{
    [Serializable, XmlRoot("offer")]
    public class AudioBookOffer : BookOffer
    {
        [XmlElement("performed_by")]
        public string PerformedBy { get;  set; }
        [XmlElement("performance_type")]
        public string PerformedType { get; set; }
        [XmlElement("storage")]
        public string Storage { get; set; }
        [XmlElement("format")]
        public string Format { get; set; }
        [XmlElement("recording_length")]
        public string RecordingLength { get; set; }
    }
}
