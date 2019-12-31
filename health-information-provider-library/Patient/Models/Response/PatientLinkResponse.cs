using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace HipLibrary.Patient.Models.Response
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