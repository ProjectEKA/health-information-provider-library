using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace HipLibrary.Patient.Model
{ 
    public class LinkReferenceMeta
    {
        [JsonPropertyName("communicationMedium")]
        [XmlElement("communicationMedium")]
        public string CommunicationMedium { get; }

        [JsonPropertyName("communicationHint")]
        [XmlElement("communicationHint")]
        public string CommunicationHint { get; }

        [JsonPropertyName("communicationExpiry")]
        [XmlElement("communicationExpiry")]
        public string CommunicationExpiry { get; }


        public LinkReferenceMeta(string communicationMedium, string communicationHint, string communicationExpiry)
        {
            CommunicationMedium = communicationMedium;
            CommunicationHint = communicationHint;
            CommunicationExpiry = communicationExpiry;
        }
    }
}