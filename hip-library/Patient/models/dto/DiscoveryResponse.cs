using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace hip_library.Patient.models.dto
{
    public class DiscoveryResponse
    {
        [JsonPropertyName("patient")]
        [XmlElement("patient")]
        public domain.Patient Patient { get; }

        [JsonPropertyName("matchedBy")]
        [XmlElement("matchedBy")]
        public IEnumerable<string> MatchedBy { get; }

        public DiscoveryResponse(domain.Patient patient, IEnumerable<string> matchedBy)
        {
            Patient = patient;
            MatchedBy = matchedBy;
        }
    }
}