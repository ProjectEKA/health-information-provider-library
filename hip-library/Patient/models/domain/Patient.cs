using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace hip_library.Patient.models.domain
{
    public class Patient
    {
        [JsonPropertyName("referenceNumber")]
        [XmlElement("referenceNumber")]
        public string ReferenceNumber { get; }

        [JsonPropertyName("display")]
        [XmlElement("display")]
        public string Display { get; }

        [JsonPropertyName("careContexts")]
        [XmlElement("careContexts")]
        public IEnumerable<CareContext> CareContexts { get; }

        public Patient(string referenceNumber, string display, IEnumerable<CareContext> careContexts)
        {
            ReferenceNumber = referenceNumber;
            Display = display;
            CareContexts = careContexts;
        }
    }
}