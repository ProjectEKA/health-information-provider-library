using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace HipLibrary.Patient.Models.Request
{
    public class DiscoveryRequest
    {
        [JsonPropertyName("patient")]
        [XmlElement("patient")]
        public Patient Patient { get; }
        public DiscoveryRequest(Patient patient)
        {
            Patient = patient;
        }
    }
}