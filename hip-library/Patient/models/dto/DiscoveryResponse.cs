using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace hip_library.Patient.models.dto
{
    public class DiscoveryResponse
    {
        [JsonPropertyName("patient")]
        [XmlElement("patient")]
        public domain.PatientRepresentation PatientRepresentation { get; }

        [JsonPropertyName("matchedBy")]
        [XmlElement("matchedBy")]
        public IEnumerable<string> MatchedBy { get; }

        public DiscoveryResponse(domain.PatientRepresentation patientRepresentation, IEnumerable<string> matchedBy)
        {
            PatientRepresentation = patientRepresentation;
            MatchedBy = matchedBy;
        }
    }
}