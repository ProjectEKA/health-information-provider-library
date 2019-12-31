using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace HipLibrary.Patient.Models.Request
{
    public class PatientLinkReferenceRequest
    {
        [JsonPropertyName("patientReferenceNumber")]
        [XmlElement("patientReferenceNumber")]
        public string PatientReferenceNumber { get; }

        [JsonPropertyName("careContexts")]
        [XmlElement("careContexts")]
        public IEnumerable<CareContext> CareContexts { get; }

        public PatientLinkReferenceRequest(string patientReferenceNumber, IEnumerable<CareContext> careContexts)
        {
            PatientReferenceNumber = patientReferenceNumber;
            CareContexts = careContexts;
        }
    }
}