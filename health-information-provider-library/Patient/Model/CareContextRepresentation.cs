using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace HipLibrary.Patient.Model
{
    public class CareContextRepresentation
    {
        [JsonPropertyName("referenceNumber")]
        [XmlElement("referenceNumber")]
        public string ReferenceNumber { get; }

        [JsonPropertyName("display")]
        [XmlElement("display")]
        public string Display { get; }

        public CareContextRepresentation(string referenceNumber, string display)
        {
            ReferenceNumber = referenceNumber;
            Display = display;
        }
    }
}