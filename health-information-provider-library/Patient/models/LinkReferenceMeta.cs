using System;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace hip_library.Patient.models.dto
{
    public class LinkReferenceMeta
    {
        [JsonPropertyName("communicationMedium")]
        [XmlElement("communicationMedium")]
        public string CommunicationMedium { get; }
        
        [JsonPropertyName("communicationHint")]
        [XmlElement("communicationHint")]
        public String CommunicationHint { get; }
        
        [JsonPropertyName("communicationExpiry")]
        [XmlElement("communicationExpiry")]
        public String CommunicationExpiry { get; }


        public LinkReferenceMeta(string communicationMedium, string communicationHint, string communicationExpiry)
        {
            CommunicationMedium = communicationMedium;
            CommunicationHint = communicationHint;
            CommunicationExpiry = communicationExpiry;
        }
    }
}