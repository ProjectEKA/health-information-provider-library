using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace HipLibrary.Patient.Models.Response
{
    public class DiscoveryResponse
    {
        [JsonPropertyName("patient")]
        [XmlElement("patient")]
        public Patient Patient { get; }
    }
}