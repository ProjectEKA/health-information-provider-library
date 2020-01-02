using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using hip_library.Patient.models;

namespace health_information_provider_library.Patient.models
{
    public class PatientLinkResponse
    {
        [JsonPropertyName("referenceNumber")]
        [XmlElement("referenceNumber")]
        public string ReferenceNumber { get; }
        
        [JsonPropertyName("careContexts")]
        [XmlElement("careContexts")]
        public IEnumerable<CareContextRepresentation> CareContexts { get; }

        public PatientLinkResponse(string referenceNumber, IEnumerable<CareContextRepresentation> careContexts)
        {
            ReferenceNumber = referenceNumber;
            CareContexts = careContexts;
        }
    }
}