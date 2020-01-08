using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace HipLibrary.Patient.Model.Response
{
    public class DiscoveryResponse
    {
        [JsonPropertyName("patient")]
        [XmlElement("patient")]
        public Patient Patient { get; }
        public DiscoveryResponse(Patient patient)
        {
            Patient = patient;
        }
    }
}