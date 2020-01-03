using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace HipLibrary.Patient.Models.Request
{
    public class PatientLinkReferenceRequest
    {
        [JsonPropertyName("consentManagerId")]
        [XmlElement("consentManagerId")]
        public string ConsentManagerId { get; }

        [JsonPropertyName("consentManagerUserId")]
        [XmlElement("consentManagerUserId")]
        public string ConsentManagerUserId { get; }

        [JsonPropertyName("patientReferenceNumber")]
        [XmlElement("patientReferenceNumber")]
        public string PatientReferenceNumber { get; }

        [JsonPropertyName("careContexts")]
        [XmlElement("careContexts")]
        public IEnumerable<CareContext> CareContexts { get; }

        public PatientLinkReferenceRequest(string consentManagerId, string consentManagerUserId,
            string patientReferenceNumber, IEnumerable<CareContext> careContexts)
        {
            ConsentManagerId = consentManagerId;
            ConsentManagerUserId = consentManagerUserId;
            PatientReferenceNumber = patientReferenceNumber;
            CareContexts = careContexts;
        }
    }
}