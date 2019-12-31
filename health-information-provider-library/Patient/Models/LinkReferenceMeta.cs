using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace HipLibrary.Patient.Models
{
    public class LinkReferenceMeta
    {
        [JsonPropertyName("linkReferenceMode")]
        [XmlElement("linkReferenceMode")]
        public string LinkReferenceMode { get; }

        [JsonPropertyName("value")]
        [XmlElement("value")]
        public string Value { get; }

        [JsonPropertyName("expiry")]
        [XmlElement("expiry")]
        public string Expiry { get; }


        public LinkReferenceMeta(string linkReferenceMode, string value, string expiry)
        {
            LinkReferenceMode = linkReferenceMode;
            Value = value;
            Expiry = expiry;
        }
    }
}