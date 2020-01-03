using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace HipLibrary.Patient.Models.Response
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