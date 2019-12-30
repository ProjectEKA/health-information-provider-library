using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using hip_library.Patient.models;

namespace health_information_provider_library.Patient.models
{
    public class PatientLinkResponse
    {
        [JsonPropertyName("patientReferenceNumber")]
        [XmlElement("patientReferenceNumber")]
        public string PatientReferenceNumber { get; }
        
        [JsonPropertyName("careContexts")]
        [XmlElement("careContexts")]
        public IEnumerable<CareContextRepresentation> CareContexts { get; }

        public PatientLinkResponse(string patientReferenceNumber, IEnumerable<CareContextRepresentation> careContexts)
        {
            PatientReferenceNumber = patientReferenceNumber;
            CareContexts = careContexts;
        }
    }
}