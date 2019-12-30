using System;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace hip_library.Patient.models.dto
{
    public class LinkReferenceMeta
    {
        [JsonPropertyName("linkReferenceMode")]
        [XmlElement("linkReferenceMode")]
        public string LinkReferenceMode { get; }
        
        [JsonPropertyName("value")]
        [XmlElement("value")]
        public String Value { get; }
        
        [JsonPropertyName("expiry")]
        [XmlElement("expiry")]
        public String Expiry { get; }


        public LinkReferenceMeta(string linkReferenceMode, string value, string expiry)
        {
            LinkReferenceMode = linkReferenceMode;
            Value = value;
            Expiry = expiry;
        }
    }
}