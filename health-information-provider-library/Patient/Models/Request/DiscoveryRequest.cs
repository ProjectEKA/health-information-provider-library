using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace HipLibrary.Patient.Models.Request
{
    public class DiscoveryRequest
    {
        [JsonPropertyName("patient")]
        [XmlElement("patient")]
        public Patient Patient { get; }

        [JsonPropertyName("consentManagerId")]
        [XmlElement("consentManagerId")]
        public string ConsentManagerId { get; }
    }
}