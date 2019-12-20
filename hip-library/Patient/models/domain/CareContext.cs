using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace hip_library.Patient.models.domain
{
    public class CareContext
    {
        [JsonPropertyName("referenceNumber")]
        [XmlElement("referenceNumber")]
        public string ReferenceNumber { get; }

        [JsonPropertyName("description")]
        [XmlElement("describtion")]
        public string Description { get; }
        
        public CareContext(string referenceNumber, string description)
        {
            ReferenceNumber = referenceNumber;
            Description = description;
        }
    }
}